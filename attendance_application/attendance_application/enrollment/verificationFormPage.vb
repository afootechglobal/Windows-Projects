Imports DPFP
Imports DPFP.Capture
Imports DPFP.Verification
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class verificationFormPage
    Implements DPFP.Capture.EventHandler

    Private capturer As DPFP.Capture.Capture
    Delegate Sub functioncall(ByVal param)
    ' Delegate Sub functioncall(ByVal bmp As Object)

    Private Event ontemplate(ByVal template)
    Private enroller As DPFP.Processing.Enrollment
    Dim connection As MySqlConnection
    Dim connstring As String
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim staff_id, user_id As String


    Private Sub verificationFormPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
        cancelField()
        InitializeCapture()
        StartCapture()
        MessageBox.Show("YES its VERIFY PAGE")
    End Sub

    Private Sub cancelField()
        verifyMatricNoFormNoTxt.Text = ""
        verifyFullnameTxt.Text = ""
        verifyDepartmentTxt.Text = ""
        verifyLevelTxt.Text = ""
        verifyPassportBox = MyFunction.getPassportPix(MyFunction.defaultPixUrl(), verifyPassportBox)
        verifyFptPictureBox.Image = Nothing
        SetStatus("")
    End Sub

    Public Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        If Me.Visible = True Then
            Try
                ProcessVerify(Sample)
            Catch ex As Exception
                MessageBox.Show("ERROR! " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        ' MsgBox("")
    End Sub

    Public Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        'MsgBox("Fingerprint Touch")
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        ' MessageBox.Show("SUCCESS! FingerPrint Reader Connected.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        MessageBox.Show("ERROR! FingerPrint Reader Disconnected.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        MessageBox.Show("Quality", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    'My Funcrion Start here.....

    Public Overridable Sub InitializeCapture()
        Try
            capturer = New DPFP.Capture.Capture
            enroller = New DPFP.Processing.Enrollment
            If (Not capturer Is Nothing) Then
                capturer.EventHandler = Me
            Else
                MessageBox.Show("ERROR! Can't Initialize Capture Operation", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR! " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Public Sub ProcessVerify(ByVal sample As DPFP.Sample)
        ' Convert the fingerprint sample to an image and display it
        DrawPicture(ConvertSampleToBitmap(sample))

        ' Extract features for verification
        Dim FeaturesVerify As DPFP.FeatureSet = ExtractFeatures(sample, DPFP.Processing.DataPurpose.Verification)
        If FeaturesVerify Is Nothing Then
            SetStatus("Unable to extract features from the fingerprint.")
            Return
        End If

        Dim verificator As New DPFP.Verification.Verification()
        Dim result As New DPFP.Verification.Verification.Result()

        Try
            connection = MyFunction.connection
            connection.Open()

            ' Fetch all stored fingerprint templates
            Dim query As String = "SELECT fingerprint_template_finger1, fingerprint_template_finger2, fingerprint_template_finger3, fingerprint_template_finger4 FROM enrollment_tab"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim matchedTemplate As Byte() = Nothing
            Dim temp As String = ""

            While reader.Read()
                For i As Integer = 1 To 4
                    Dim columnName As String = "fingerprint_template_finger" & i
                    Dim templateData As Byte() = TryCast(reader(columnName), Byte())

                    If templateData IsNot Nothing Then
                        ' Deserialize the template
                        Dim savedTemplate As New DPFP.Template()
                        savedTemplate.DeSerialize(templateData)

                        ' Verify the template
                        verificator.Verify(FeaturesVerify, savedTemplate, result)
                        If result.Verified Then
                            matchedTemplate = templateData
                            temp = columnName
                            SetStatus("Fingerprint Verified! Match found for finger: " & i)
                            Exit While
                        End If
                    End If
                Next
                If result.Verified Then Exit While
            End While

            ' Close the reader before calling VerifyStudentDetails
            reader.Close()

            If result.Verified AndAlso matchedTemplate IsNot Nothing Then
                MessageBox.Show("Template " & temp, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)

                VerifyStudentDetails(matchedTemplate, connection) ' Retrieve student details
            Else
                SetStatus("No Record Found with the Specified Fingerprint")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub











    Private Sub VerifyStudentDetails(ByVal templateData As Byte(), ByVal connection As MySqlConnection)
        Try
            ' Query to fetch student details
            '  Dim command = New MySqlCommand("SELECT a.*, b.department_name, c.level_name FROM student_tab a, department_tab b, setup_level_tab c, enrollment_tab d WHERE a.department_id=b.department_id AND a.level_id=c.level_id AND (a.matric_no=d.matric_no OR a.form_number=d.form_number) AND (d.fingerprint_template_finger1=@fingerprint_template OR d.fingerprint_template_finger2=@fingerprint_template OR d.fingerprint_template_finger3=@fingerprint_template OR d.fingerprint_template_finger4=@fingerprint_template)", connection)
            ' command.Parameters.AddWithValue("@fingerprint_template", bytes)

            Dim command = New MySqlCommand("SELECT a.*, b.department_name, c.level_name FROM student_tab a, department_tab b, setup_level_tab c, enrollment_tab d WHERE a.department_id=b.department_id AND a.level_id=c.level_id AND a.department_id=d.department_id AND a.form_number=d.form_number AND (d.fingerprint_template_finger1=@fingerprint_template OR d.fingerprint_template_finger2=@fingerprint_template OR d.fingerprint_template_finger3=@fingerprint_template OR d.fingerprint_template_finger4=@fingerprint_template)", connection)
            command.Parameters.AddWithValue("@fingerprint_template", templateData)
            ToString()
            reader = command.ExecuteReader()
            reader.Read()

            If reader.HasRows Then
                If (reader("status_id") = 1) Then
                    Dim form_number As String = reader("form_number").ToString()
                    Dim std_surname As String = reader("surname").ToString()
                    Dim std_lastname As String = reader("firstname").ToString()
                    Dim department As String = reader("department_name").ToString()
                    Dim level As String = reader("level_name").ToString()
                    Dim passport_url As String = reader("passport_url").ToString()
                    Dim std_passport_pix As String = reader("passport_pix").ToString()
                    Dim imagePath As String = passport_url & "/" & std_passport_pix

                    ' Update UI using Invoke
                    Me.Invoke(Sub()
                                  verifyMatricNoFormNoTxt.Text = form_number
                                  verifyFullnameTxt.Text = std_surname & " " & std_lastname ' Concatenate with a space
                                  verifyDepartmentTxt.Text = department
                                  verifyLevelTxt.Text = level
                                  MyFunction.getPassportPix(imagePath, verifyPassportBox)
                              End Sub)
                Else
                    Me.Invoke(Sub()
                                  MessageBox.Show("STUDENT SUSPENDED! Contact admin for assistance.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
                              End Sub)
                End If
            Else
                Me.Invoke(Sub()
                              MessageBox.Show("RECORD NOT FOUND! Student does not exist.", "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
                          End Sub)
            End If
        Catch ex As Exception
            Me.Invoke(Sub()
                          MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
                      End Sub)
        End Try
    End Sub












    Protected Sub SetStatus(ByVal status)
        Try
            Invoke(New functioncall(AddressOf _SetStatus), status)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub _SetStatus(ByVal status)
        Try
            Me.verifyLabel.Text = status
            If verifyLabel.Text = "No Record Found with the Specified Fingerprint" Then
                Me.verifyLabel.ForeColor = Color.DarkRed
            Else
                Me.verifyLabel.ForeColor = Color.DarkGreen
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub StartCapture()
        Try
            If (Not capturer Is Nothing) Then
                capturer.StartCapture()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub StopCapture()
        Try
            If (Not capturer Is Nothing) Then
                capturer.StopCapture()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New functioncall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        Me.verifyFptPictureBox.Image = New Bitmap(bmp, Me.verifyFptPictureBox.Size)
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


    Private Sub Guna2Button1_Click(sender As System.Object, e As System.EventArgs) Handles verifyCancelBtn.Click
        cancelField()
        StopCapture()
        StartCapture()
    End Sub
End Class