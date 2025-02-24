Imports DPFP
Imports DPFP.Capture
Imports DPFP.Verification
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class enrollmentFormPage
    Implements DPFP.Capture.EventHandler


    Private capturer As DPFP.Capture.Capture
    Delegate Sub functioncall(ByVal param)
    'Private enroller As DPFP.Processing.Enrollment
    Dim connection As MySqlConnection
    Dim connstring As String
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Public login_staff_id As String




    Private TotalFingers As Integer = 4
    Private RequiredCapturesPerFinger As Integer = 4
    Private FingerCaptureCounts As Integer() = New Integer(TotalFingers - 1) {}
    Private CurrentFinger As Integer = 0
    Private FingerTemplates As New List(Of DPFP.Template)(TotalFingers)
    'Private FingerTemplates As DPFP.Template() = New DPFP.Template(TotalFingers - 1) {}

    Private enroller As New DPFP.Processing.Enrollment()

    ' Event raised when a template is ready
    Public Event ontemplate(template As DPFP.Template)

    Private Sub enrollmentFormPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MyFunction.styleDynamicBorderRadius(enrollSearchBtn, 1, 23) ' Apply 20px radius to the left side

        CenterToParent()
        InitializeCapture()
        StartCapture()
        cancelField()
        MessageBox.Show("YES its ENROLLMENT PAGE")
    End Sub

    Private Sub cancelField()
        enrollSearchTxt.Text = ""
        matricNoFormNoTxt.Text = ""
        fullnameTxt.Text = ""
        departmentTxt.Text = ""
        levelTxt.Text = ""
        passportBox = MyFunction.getPassportPix(MyFunction.defaultPixUrl(), passportBox)
        FptPictureBox.Image = Nothing
    End Sub

    Protected Sub SetStatus(ByVal status)
        Try
            Invoke(New functioncall(AddressOf _SetStatus), status)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub _SetStatus(ByVal status)
        Try
            Me.LabelCount.Text = status
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' initialize biometric capture
    Public Overridable Sub InitializeCapture()
        Try
            capturer = New DPFP.Capture.Capture
            enroller = New DPFP.Processing.Enrollment
            Me.LabelCount.Text = ("Enrollment Capture Count: " & enroller.FeaturesNeeded.ToString)
            If (Not capturer Is Nothing) Then
                capturer.EventHandler = Me
            Else
                MessageBox.Show("Can't Initialize Capture Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub StartCapture()
        Try
            If (Not capturer Is Nothing) Then
                capturer.StartCapture()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub StopCapture()
        Try
            If (Not capturer Is Nothing) Then
                capturer.StopCapture()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New functioncall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        Me.FptPictureBox.Image = New Bitmap(bmp, Me.FptPictureBox.Size)
    End Sub

    Private Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim bitmap As Bitmap = Nothing
        Try
            Dim convertor As New DPFP.Capture.SampleConversion
            convertor.ConvertToPicture(Sample, bitmap)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return bitmap
    End Function



    Private Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Try
            Dim extrator As New DPFP.Processing.FeatureExtraction
            Dim feedback As DPFP.Capture.CaptureFeedback = CaptureFeedback.None
            Dim features As New DPFP.FeatureSet

            extrator.CreateFeatureSet(Sample, Purpose, feedback, features)
            If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
                Return features
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function





    Public Sub ProcessEnroll222(ByVal Sample As DPFP.Sample)
        If (enrollSearchTxt.Text = "") Then
            enrollSearchTxt.BorderColor = Color.Red
            MessageBox.Show("ERROR! Fill in student matric no or form no to verify student details", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cancelField()
        Else
            enrollSearchTxt.BorderColor = Color.Gray
            Try
                ' Validate the sample
                If Sample Is Nothing Then
                    SetStatus("Error: Sample is missing!")
                    Exit Sub
                End If

                ' Convert sample to image and display it
                DrawPicture(ConvertSampleToBitmap(Sample))

                ' Extract features
                Dim FeaturesEnroll As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)
                If FeaturesEnroll Is Nothing Then
                    SetStatus("Unable to extract features from the fingerprint.")
                    Exit Sub
                End If

                ' Add features to the enroller
                enroller.AddFeatures(FeaturesEnroll)
                FingerCaptureCounts(CurrentFinger) += 1 ' Increment capture count

                ' Display progress
                SetStatus("Capturing Finger " & CurrentFinger + 1 & " : " & FingerCaptureCounts(CurrentFinger) & " / " & RequiredCapturesPerFinger)

                ' Check if the current finger is fully captured
                If FingerCaptureCounts(CurrentFinger) >= RequiredCapturesPerFinger Then
                    If CurrentFinger < TotalFingers - 1 Then
                        ' Move to the next finger
                        CurrentFinger += 1
                        SetStatus("Switch to Finger " & (CurrentFinger + 1))
                    Else
                        ' All fingers captured, check template status
                        Select Case enroller.TemplateStatus
                            Case DPFP.Processing.Enrollment.Status.Ready
                                RaiseEvent ontemplate(enroller.Template)
                                StopCapture()
                                SetStatus("Enrollment Completed for All Fingers!")
                                LabelCount.ForeColor = Color.Green

                            Case DPFP.Processing.Enrollment.Status.Failed
                                ' Reset and retry
                                SetStatus("Enrollment Failed! Resetting process.")
                                enroller.Clear()
                                StopCapture()
                                CurrentFinger = 0
                                Array.Clear(FingerCaptureCounts, 0, FingerCaptureCounts.Length)
                                StartCapture()
                                RaiseEvent ontemplate(Nothing)
                        End Select
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Public Sub ProcessEnroll1111(ByVal Sample As DPFP.Sample)
        ' Validate input field
        If String.IsNullOrWhiteSpace(enrollSearchTxt.Text) Then
            enrollSearchTxt.BorderColor = Color.Red
            MessageBox.Show("ERROR! Fill in student matric no or form no to verify student details.",
                            "TrackSmart App",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            cancelField()
            Return
        End If

        enrollSearchTxt.BorderColor = Color.Gray

        Try
            ' Validate the fingerprint sample
            If Sample Is Nothing Then
                SetStatus("Error: No fingerprint sample received.")
                Return
            End If

            ' Display fingerprint image
            DrawPicture(ConvertSampleToBitmap(Sample))

            ' Extract fingerprint features
            Dim FeaturesEnroll As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)
            If FeaturesEnroll Is Nothing Then
                SetStatus("Unable to extract features from the fingerprint.")
                Return
            End If

            ' Add features to the enroller
            enroller.AddFeatures(FeaturesEnroll)
            FingerCaptureCounts(CurrentFinger) += 1

            ' Update progress status
            Dim currentFingerStatus As String = ("Capturing Finger " & CurrentFinger + 1 & " : " & FingerCaptureCounts(CurrentFinger) & " / " & RequiredCapturesPerFinger)
            SetStatus(currentFingerStatus)

            ' Check if the current finger capture is complete
            If FingerCaptureCounts(CurrentFinger) >= RequiredCapturesPerFinger Then
                If CurrentFinger < TotalFingers - 1 Then
                    ' Move to the next finger
                    CurrentFinger += 1
                    SetStatus("Switch to Finger " & (CurrentFinger + 1))
                Else
                    ' All fingers captured, verify template status
                    Dim allFingersCaptured As Boolean = True
                    ' Check if all fingers have the required captures
                    For i As Integer = 0 To TotalFingers - 1
                        If FingerCaptureCounts(i) < RequiredCapturesPerFinger Then
                            allFingersCaptured = False
                            Exit For
                        End If
                    Next

                    If allFingersCaptured Then
                        ' Verify template status and complete enrollment
                        Select Case enroller.TemplateStatus
                            Case DPFP.Processing.Enrollment.Status.Ready
                                RaiseEvent ontemplate(enroller.Template)
                                StopCapture()
                                SetStatus("Enrollment Completed for All Fingers!")
                                LabelCount.ForeColor = Color.Green

                            Case DPFP.Processing.Enrollment.Status.Failed
                                ' Reset and restart the enrollment process
                                ResetEnrollment("Enrollment Failed! Resetting process.")
                        End Select
                    Else
                        ' If any finger is not captured enough times
                        MessageBox.Show("ERROR: Finger templates are not populated correctly. Ensure all 4 fingers are captured.",
                                        "TrackSmart App",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                        ResetEnrollment("Resetting Enrollment Process due to incomplete finger captures.")
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub ProcessEnrollxxx(ByVal Sample As DPFP.Sample)
        ' Validate input field
        If String.IsNullOrWhiteSpace(enrollSearchTxt.Text) Then
            enrollSearchTxt.BorderColor = Color.Red
            MessageBox.Show("ERROR! Fill in student matric no or form no to verify student details.",
                            "TrackSmart App",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            cancelField()
            Return
        End If

        enrollSearchTxt.BorderColor = Color.Gray

        Try
            ' Validate the fingerprint sample
            If Sample Is Nothing Then
                SetStatus("Error: No fingerprint sample received.")
                Return
            End If

            ' Display fingerprint image
            DrawPicture(ConvertSampleToBitmap(Sample))

            ' Extract fingerprint features
            Dim FeaturesEnroll As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)
            If FeaturesEnroll Is Nothing Then
                SetStatus("Unable to extract features from the fingerprint.")
                Return
            End If

            ' Add features to the enroller
            enroller.AddFeatures(FeaturesEnroll)
            FingerCaptureCounts(CurrentFinger) += 1

            ' Update progress status
            Dim currentFingerStatus As String = ("Capturing Finger " & CurrentFinger + 1 & " : " & FingerCaptureCounts(CurrentFinger) & " / " & RequiredCapturesPerFinger)
            SetStatus(currentFingerStatus)

            ' Check if the current finger capture is complete
            If FingerCaptureCounts(CurrentFinger) >= RequiredCapturesPerFinger Then
                If CurrentFinger < TotalFingers - 1 Then
                    ' Move to the next finger
                    CurrentFinger += 1
                    SetStatus("Switch to Finger " & (CurrentFinger + 1))
                Else

                    If AllFingersCaptured() Then
                        ' Verify template status and complete enrollment
                        Select Case enroller.TemplateStatus
                            Case DPFP.Processing.Enrollment.Status.Ready
                                RaiseEvent ontemplate(enroller.Template)
                                enrollRegistration()
                                'StopCapture()
                                SetStatus("Enrollment Completed for All Fingers!")
                                LabelCount.ForeColor = Color.Green
                            Case DPFP.Processing.Enrollment.Status.Failed
                                ' Reset and restart the enrollment process
                                ResetEnrollment("Enrollment Failed! Resetting process.")
                        End Select
                    Else
                        ' If any finger is not captured enough times
                        MessageBox.Show("ERROR: Finger templates are not populated correctly. Ensure all 4 fingers are captured.",
                                        "TrackSmart App",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                        ResetEnrollment("Resetting Enrollment Process due to incomplete finger captures.")
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Public Sub ProcessEnrollaaaa(ByVal Sample As DPFP.Sample)
        ' Validate input field
        If String.IsNullOrWhiteSpace(enrollSearchTxt.Text) Then
            enrollSearchTxt.BorderColor = Color.Red
            MessageBox.Show("ERROR! Fill in student matric no or form no to verify student details.",
                            "TrackSmart App",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            cancelField()
            Return
        End If

        enrollSearchTxt.BorderColor = Color.Gray

        Try
            ' Check if sample is valid
            If Sample Is Nothing Then
                SetStatus("Error: No fingerprint sample received.")
                Return
            End If

            ' Display fingerprint image
            DrawPicture(ConvertSampleToBitmap(Sample))

            ' Extract fingerprint features
            Dim FeaturesEnroll As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)
            If FeaturesEnroll Is Nothing Then
                SetStatus("Unable to extract features from the fingerprint.")
                Return
            End If

            ' Add features to the enroller
            enroller.AddFeatures(FeaturesEnroll)
            FingerCaptureCounts(CurrentFinger) += 1

            ' Update progress status
            Dim currentFingerStatus As String = ("Capturing Finger " & CurrentFinger + 1 & " : " & FingerCaptureCounts(CurrentFinger) & " / " & RequiredCapturesPerFinger)
            SetStatus(currentFingerStatus)

            ' Check if the current finger is fully captured
            If FingerCaptureCounts(CurrentFinger) >= RequiredCapturesPerFinger Then
                ' Save template for the current finger
                FingerTemplates(CurrentFinger) = enroller.Template

                If CurrentFinger < TotalFingers - 1 Then
                    ' Move to next finger
                    CurrentFinger += 1
                    enroller.Clear() ' Reset enroller for the next finger
                    SetStatus("Switch to Finger: " & CurrentFinger + 1)
                Else
                    ' Verify enrollment status
                    If AllFingersCaptured() Then
                        Select Case enroller.TemplateStatus
                            Case DPFP.Processing.Enrollment.Status.Ready
                                RaiseEvent ontemplate(enroller.Template)
                                'enrollRegistration()
                                SetStatus("Enrollment Completed for All Fingers!")
                                LabelCount.ForeColor = Color.Green
                            Case DPFP.Processing.Enrollment.Status.Failed
                                ResetEnrollment("Enrollment Failed! Resetting process.")
                        End Select
                    Else
                        ResetEnrollment("ERROR: Ensure all 4 fingers are captured.")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ProcessEnroll(ByVal Sample As DPFP.Sample)
        If String.IsNullOrWhiteSpace(enrollSearchTxt.Text) Then
            enrollSearchTxt.BorderColor = Color.Red
            MessageBox.Show("ERROR! Fill in student matric no or form no to verify student details.",
                            "TrackSmart App",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            cancelField()
            Return
        End If

        enrollSearchTxt.BorderColor = Color.Gray

        Try
            If Sample Is Nothing Then
                SetStatus("Error: No fingerprint sample received.")
                Return
            End If

            DrawPicture(ConvertSampleToBitmap(Sample))
            Dim FeaturesEnroll As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)
            If FeaturesEnroll Is Nothing Then
                SetStatus("Unable to extract features from the fingerprint.")
                Return
            End If

            enroller.AddFeatures(FeaturesEnroll)
            FingerCaptureCounts(CurrentFinger) += 1
            ' Update progress status
            Dim currentFingerStatus As String = ("Capturing Finger " & CurrentFinger + 1 & " : " & FingerCaptureCounts(CurrentFinger) & " / " & RequiredCapturesPerFinger)
            SetStatus(currentFingerStatus)
            If FingerCaptureCounts(CurrentFinger) >= RequiredCapturesPerFinger Then
                ' Make sure the list has enough elements to access
                If FingerTemplates.Count > CurrentFinger Then
                    FingerTemplates(CurrentFinger) = enroller.Template
                Else
                    FingerTemplates.Add(enroller.Template) ' Add if not yet added
                End If

                If CurrentFinger < TotalFingers - 1 Then
                    CurrentFinger += 1
                    enroller.Clear()
                    SetStatus("Switch to Finger" & CurrentFinger + 1)
                Else
                    If AllFingersCaptured() Then
                        Select Case enroller.TemplateStatus
                            Case DPFP.Processing.Enrollment.Status.Ready
                                RaiseEvent ontemplate(enroller.Template)
                                enrollRegistration() ' Store enrollment data in database
                                SetStatus("Enrollment Completed for All Fingers!")
                                LabelCount.ForeColor = Color.Green
                            Case DPFP.Processing.Enrollment.Status.Failed
                                ResetEnrollment("Enrollment Failed! Resetting process.")
                        End Select
                    Else
                        ResetEnrollment("ERROR: Ensure all fingers are captured.")
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    ' Validate if all fingers are captured
    Private Function AllFingersCaptured() As Boolean
        For i As Integer = 0 To TotalFingers - 1
            If FingerCaptureCounts(i) < RequiredCapturesPerFinger Then
                Return False
            End If
        Next
        Return True
    End Function

    ' Reset the enrollment process
    Public Sub ResetEnrollment(message As String)
        MessageBox.Show(message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        FingerTemplates.Clear()
        FingerCaptureCounts = New Integer(TotalFingers - 1) {}
        CurrentFinger = 0
        enroller.Clear()
    End Sub



    ' Reset enrollment process
    Private Sub ResetEnrollment1(ByVal message As String)
        SetStatus(message)
        enroller.Clear()
        FingerTemplates.Clear()
        StopCapture()
        CurrentFinger = 0
        Array.Clear(FingerCaptureCounts, 0, FingerCaptureCounts.Length)
        StartCapture()
        RaiseEvent ontemplate(Nothing)
    End Sub

    ' Reset enrollment process
    Public Sub ResetEnrollment11(message As String)
        MessageBox.Show(message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        FingerTemplates.Clear()
        FingerCaptureCounts = New Integer(TotalFingers - 1) {}
        CurrentFinger = 0
        enroller.Clear()
        StartCapture()
    End Sub

  



    Public Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        If Me.Visible = True Then
            Try
                ProcessEnroll(Sample)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        'SetStatus("Finger removed from scanner.")
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        '  SetStatus("Finger placed on scanner.")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        SetStatus("Fingerprint reader connected.")
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        SetStatus("Fingerprint reader disconnected.")
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, Quality As DPFP.Capture.CaptureFeedback) Implements EventHandler.OnSampleQuality
        If Quality = DPFP.Capture.CaptureFeedback.Good Then
            SetStatus("Good fingerprint quality.")
        Else
            SetStatus("Poor fingerprint quality.")
        End If
    End Sub



    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles enrollSearchBtn.Click
        If (enrollSearchTxt.Text = "") Then
            enrollSearchTxt.BorderColor = Color.Red
            MessageBox.Show("ERROR! Fill in student matric no or form no to verify student details", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cancelField()
        Else
            'loginTimerLoader.Start()
            enrollSearchTxt.BorderColor = Color.Gray
            enrollSearchBtn.Enabled = False

            Dim connection = MyFunction.connection
            Try
                enrollSearchBtn.Enabled = True
                connection.Open()
                command = New MySqlCommand("SELECT a.*, b.department_name, c.level_name FROM student_tab a, department_tab b, setup_level_tab c WHERE a.department_id=b.department_id AND a.level_id=c.level_id AND (a.matric_no=@matric_no OR a.form_number=@form_number)", connection)
                command.Parameters.AddWithValue("@matric_no", enrollSearchTxt.Text.ToString)
                command.Parameters.AddWithValue("@form_number", enrollSearchTxt.Text.ToString)
                reader = command.ExecuteReader
                reader.Read()

                If reader.HasRows Then
                    If (reader("status_id") = 1) Then
                        Dim matric_no As String = reader("matric_no").ToString()
                        Dim form_number As String = reader("form_number").ToString()
                        If (enrollSearchTxt.Text = matric_no) Then
                            matricNoFormNoTxt.Text = matric_no
                        Else
                            matricNoFormNoTxt.Text = form_number
                        End If
                        Dim std_surname As String = reader("surname").ToString()
                        Dim std_lastname As String = reader("firstname").ToString()
                        fullnameTxt.Text = std_surname & " " & std_lastname ' Concatenate with a space
                        departmentTxt.Text = reader("department_name").ToString()
                        levelTxt.Text = reader("level_name").ToString()
                        Dim passport_url As String = reader("passport_url").ToString()
                        Dim std_passport_pix As String = reader("passport_pix").ToString()
                        Dim imagePath As String = passport_url & "/" & std_passport_pix

                        MyFunction.getPassportPix(imagePath, passportBox)
                        enrollSearchBtn.Enabled = True
                    Else
                        enrollSearchBtn.Enabled = True
                        MessageBox.Show("STUDENT SUSPENDED! Student not eligible for enrollment. Contact admin for assistance", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    enrollSearchBtn.Enabled = True
                    MessageBox.Show("RECORD NOT FOUND! Student not exist", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Catch ex As Exception
                enrollSearchBtn.Enabled = True
                MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure connection is closed
                If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub



    Public Sub enrollRegistrationsss()
        If String.IsNullOrWhiteSpace(enrollSearchTxt.Text) Then
            enrollSearchTxt.BorderColor = Color.Red
            MessageBox.Show("ERROR! Fill in student matric no or form no to verify student details.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        enrollSearchTxt.BorderColor = Color.Gray
        enrollSubmitBtn.Enabled = False

        Dim connection = MyFunction.connection
        Try
            connection.Open()
            Dim command = New MySqlCommand("SELECT * FROM student_tab WHERE matric_no=@matric_no OR form_number=@form_number", connection)
            command.Parameters.AddWithValue("@matric_no", enrollSearchTxt.Text)
            command.Parameters.AddWithValue("@form_number", enrollSearchTxt.Text)

            Dim reader = command.ExecuteReader()
            If reader.HasRows AndAlso reader.Read() Then
                If reader("status_id") = 1 Then
                    Dim matric_no = reader("matric_no").ToString()
                    Dim form_number = reader("form_number").ToString()
                    Dim department_id = reader("department_id").ToString()
                    Dim level_id = reader("level_id").ToString()
                    reader.Close()

                    If FingerTemplates.Count = TotalFingers Then
                        ' Serialize and save templates
                        Dim templates As New List(Of Byte())()
                        For Each template As DPFP.Template In FingerTemplates
                            Dim ms As New MemoryStream()
                            template.Serialize(ms) ' Serialize DPFP.Template to MemoryStream
                            templates.Add(ms.ToArray()) ' Add the byte array to the list
                            ms.Close()
                        Next

                        Dim query = "INSERT INTO enrollment_tab (enroll_id, matric_no, form_number, department_id, level_id, " &
                                    "fingerprint_template_finger1, fingerprint_template_finger2, fingerprint_template_finger3, fingerprint_template_finger4, created_at) " &
                                    "VALUES (@enroll_id, @matric_no, @form_number, @department_id, @level_id, @template1, @template2, @template3, @template4, NOW())"

                        Dim insertCommand = New MySqlCommand(query, connection)
                        insertCommand.Parameters.AddWithValue("@enroll_id", "ENRL" & Now.ToString("yyyyMMddss"))
                        insertCommand.Parameters.AddWithValue("@matric_no", matric_no)
                        insertCommand.Parameters.AddWithValue("@form_number", form_number)
                        insertCommand.Parameters.AddWithValue("@department_id", department_id)
                        insertCommand.Parameters.AddWithValue("@level_id", level_id)
                        For i As Integer = 0 To TotalFingers - 1
                            insertCommand.Parameters.AddWithValue("@template" & (i + 1), templates(i))
                        Next

                        insertCommand.ExecuteNonQuery()
                        MessageBox.Show("SUCCESS! Student enrollment successful.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cancelField()
                        StopCapture()
                    Else
                        ResetEnrollment("ERROR: Ensure all 4 fingers are captured.")
                    End If
                Else
                    MessageBox.Show("STUDENT SUSPENDED! Student is not eligible for enrollment.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("RECORD NOT FOUND! Student does not exist.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
            enrollSubmitBtn.Enabled = True
        End Try
    End Sub








    Public Sub enrollRegistration()
        If String.IsNullOrWhiteSpace(enrollSearchTxt.Text) Then
            enrollSearchTxt.BorderColor = Color.Red
            MessageBox.Show("ERROR! Fill in student matric no or form no to verify student details.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        enrollSearchTxt.BorderColor = Color.Gray
        enrollSubmitBtn.Enabled = False

        Dim connection = MyFunction.connection
        Try
            connection.Open()
            Dim command = New MySqlCommand("SELECT * FROM student_tab WHERE matric_no=@matric_no OR form_number=@form_number", connection)
            command.Parameters.AddWithValue("@matric_no", enrollSearchTxt.Text)
            command.Parameters.AddWithValue("@form_number", enrollSearchTxt.Text)

            Dim reader = command.ExecuteReader()
            If reader.HasRows AndAlso reader.Read() Then
                If reader("status_id") = 1 Then
                    Dim matric_no = reader("matric_no").ToString()
                    Dim form_number = reader("form_number").ToString()
                    Dim department_id = reader("department_id").ToString()
                    Dim level_id = reader("level_id").ToString()
                    reader.Close()

                    If FingerTemplates.Count = TotalFingers Then
                        ' Serialize and save templates
                        Dim templates As New List(Of Byte())()
                        For Each template As DPFP.Template In FingerTemplates
                            Dim ms As New MemoryStream()
                            template.Serialize(ms) ' Serialize DPFP.Template to MemoryStream
                            templates.Add(ms.ToArray()) ' Add the byte array to the list
                            ms.Close()
                        Next

                        Dim query = "INSERT INTO enrollment_tab (enroll_id, matric_no, form_number, department_id, level_id, " &
                                    "fingerprint_template_finger1, fingerprint_template_finger2, fingerprint_template_finger3, fingerprint_template_finger4, created_at) " &
                                    "VALUES (@enroll_id, @matric_no, @form_number, @department_id, @level_id, @template1, @template2, @template3, @template4, NOW())"

                        Dim insertCommand = New MySqlCommand(query, connection)
                        insertCommand.Parameters.AddWithValue("@enroll_id", "ENRL" & Now.ToString("yyyyMMddss"))
                        insertCommand.Parameters.AddWithValue("@matric_no", matric_no)
                        insertCommand.Parameters.AddWithValue("@form_number", form_number)
                        insertCommand.Parameters.AddWithValue("@department_id", department_id)
                        insertCommand.Parameters.AddWithValue("@level_id", level_id)
                        For i As Integer = 0 To TotalFingers - 1
                            insertCommand.Parameters.AddWithValue("@template" & (i + 1), templates(i))
                        Next

                        insertCommand.ExecuteNonQuery()
                        MessageBox.Show("SUCCESS! Student enrollment successful.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cancelField()
                        StopCapture()
                    Else
                        ResetEnrollment("ERROR: Ensure all 4 fingers are captured.")
                    End If
                Else
                    MessageBox.Show("STUDENT SUSPENDED! Student is not eligible for enrollment.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("RECORD NOT FOUND! Student does not exist.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
            enrollSubmitBtn.Enabled = True
        End Try
    End Sub














    Private Sub enrollSubmitBtn_Click(sender As System.Object, e As System.EventArgs) Handles enrollSubmitBtn.Click
        enrollRegistration()
    End Sub


    Private Sub Guna2Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles enrollCancelBtn.Click
        cancelField()
        StopCapture()
        StartCapture()
    End Sub



End Class