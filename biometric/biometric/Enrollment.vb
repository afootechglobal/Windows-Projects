Imports DPFP
Imports DPFP.Capture
Imports DPFP.Verification
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class Enrollment
    Implements DPFP.Capture.EventHandler

    Private capturer As DPFP.Capture.Capture
    Delegate Sub functioncall(ByVal param)

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

    Private Sub Enrollment_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
        InitializeCapture()
        StartCapture()
        ClearOption()
    End Sub


    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        ' capturer.StopCapture()
        StopCapture()
        ClearOption()

        admin_dashboard.AllBtnTransparent()
    End Sub

    Private Sub selectpassport_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectpassport_button.Click
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Image Files|*.gif;*.bmp;*.wmf;*.jpeg;*.png;*.jpg"
        If fd.ShowDialog() = DialogResult.OK Then
            UserPictureBox.Image = Image.FromFile(fd.FileName)
        End If
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If fullname_txt.Text = "" Or email_txt.Text = "" Or mobile_txt.Text = "" Or address_txt.Text = "" Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            EmptyMBox.ShowDialog()
            formodal.Dispose()

        ElseIf validateEmail(email_txt.Text) = False Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            EmailValidation.ShowDialog()
            formodal.Dispose()
            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub

        ElseIf mobile_txt.TextLength < 10 Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            PhoneNoVerification.ShowDialog()
            formodal.Dispose()
            mobile_txt.Text = ""
            mobile_txt.Focus()
            Exit Sub

        ElseIf GenderComboBox.Text = "" Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            GenderSelect.ShowDialog()
            formodal.Dispose()

        ElseIf UserPictureBox.Image Is Nothing Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            PassportSelect.ShowDialog()
            formodal.Dispose()

        ElseIf FptPictureBox.Image Is Nothing Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            FptValidation.ShowDialog()
            formodal.Dispose()

        ElseIf LabelCount.Text = ("Fingerprint Samples Needed: " & enroller.FeaturesNeeded.ToString) Or LabelCount.Text = ("Fingerprint Templates Remaining: " & enroller.FeaturesNeeded.ToString) Then
            Dim formodal As New Form
            Dim modal As New Enrollment
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            FptTemplateValid.ShowDialog()
            formodal.Dispose()
        ElseIf LabelCount.Text = ("Fingerprint Templates Remaining: 0") Then
            enroller.Clear()
            FptPictureBox.Image = Nothing
            StopCapture()
            RaiseEvent ontemplate(Nothing)
            StartCapture()
        Else
            connection = MyFuctions.GetSqlConnection
            query = "SELECT * FROM users_tab WHERE email_address=@email_address"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email_Address", email_txt.Text)
            reader = command.ExecuteReader
            If reader.HasRows = True Then
                Dim formodal As New Form
                Dim modal As New Enrollment
                formodal.FormBorderStyle = FormBorderStyle.None
                formodal.Opacity = 0.5
                formodal.BackColor = Color.Black
                formodal.WindowState = FormWindowState.Maximized
                formodal.Show()
                modal.Owner = formodal
                EmailExist.ShowDialog()
                formodal.Dispose()
                email_txt.Text = ""

            Else
                connection = MyFuctions.GetSqlConnection
                query = "SELECT * FROM users_tab WHERE mobile=@mobile"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@mobile", mobile_txt.Text)
                reader = command.ExecuteReader
                If reader.HasRows = True Then
                    Dim formodal As New Form
                    Dim modal As New Enrollment
                    formodal.FormBorderStyle = FormBorderStyle.None
                    formodal.Opacity = 0.5
                    formodal.BackColor = Color.Black
                    formodal.WindowState = FormWindowState.Maximized
                    formodal.Show()
                    modal.Owner = formodal
                    PhoneExist.ShowDialog()
                    formodal.Dispose()
                    mobile_txt.Text = ""

                Else
                    Dim formodal As New Form
                    Dim modal As New Enrollment
                    formodal.FormBorderStyle = FormBorderStyle.None
                    formodal.Opacity = 0.5
                    formodal.BackColor = Color.Black
                    formodal.WindowState = FormWindowState.Maximized
                    formodal.Show()
                    modal.Owner = formodal
                    YesNoSave.ShowDialog()
                    formodal.Dispose()
                    ' Enrollment()
                End If
            End If
        End If
    End Sub

    Public Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        If Me.Visible = True Then
            Try
                ProcessEnroll(Sample)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        ' MsgBox("")
    End Sub

    Public Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        'MsgBox("Fingerprint Touch")
    End Sub

    Public Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        ' MsgBox("FingerPrint Reader Connected")
    End Sub

    Public Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        MsgBox("FingerPrint Reader Disconnected")
    End Sub

    Public Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        MsgBox("quality")
    End Sub

    'My Funcrion Start here.....

    Public Overridable Sub InitializeCapture()
        Try
            capturer = New DPFP.Capture.Capture
            enroller = New DPFP.Processing.Enrollment
            Me.LabelCount.Text = ("Fingerprint Samples Needed: " & enroller.FeaturesNeeded.ToString)
            If (Not capturer Is Nothing) Then
                capturer.EventHandler = Me
            Else
                MsgBox("Can't Initialize Capture Operation")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

  

    Public Sub ProcessEnroll(ByVal Sample As DPFP.Sample)
        Try
            DrawPicture(ConvertSampleToBitmap(Sample))
            Dim FeaturesEnroll As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)
            If Not FeaturesEnroll Is Nothing Then
                Try
                    ' MsgBox("The fingerprint feature set was created")
                    enroller.AddFeatures(FeaturesEnroll)
                Finally
                    SetStatus("Fingerprint Templates Remaining: " & enroller.FeaturesNeeded.ToString)
                    Select Case enroller.TemplateStatus
                        Case DPFP.Processing.Enrollment.Status.Ready
                            RaiseEvent ontemplate(enroller.Template)
                            StopCapture()
                            SetStatus("Fingerprint Templates Completed Now...")

                        Case DPFP.Processing.Enrollment.Status.Failed
                            enroller.Clear()
                            StopCapture()
                            RaiseEvent ontemplate(Nothing)
                            StartCapture()
                    End Select
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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
            Me.LabelCount.Text = status
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub StopCapture()
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
            MsgBox(ex.Message)
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
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Sub EnrollmentReg()
        Dim msstream As New System.IO.MemoryStream()
        UserPictureBox.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Try
            connection = MyFuctions.GetSqlConnection
            user_id = MyFuctions.userID
            ' staff_id = MyFuctions.staffID

            '  If enroller.FeaturesNeeded > 0 Then

            ' End If

            Dim fs As MemoryStream = New MemoryStream
            enroller.Template.Serialize(fs)
            fs.Position = 0
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim fs_bytes() As Byte = br.ReadBytes(CType(fs.Length, Int32))

            query = "Insert into users_tab(user_id,fullname,email_address,mobile,address,gender,passport,fingerprint_template,created_at)VALUES(@user_id,@fullname,@email_address,@mobile,@address,@gender,@passport,@fingerprint_template,NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", user_id)
            command.Parameters.AddWithValue("@fullname", fullname_txt.Text)
            command.Parameters.AddWithValue("@email_address", email_txt.Text)
            command.Parameters.AddWithValue("@mobile", mobile_txt.Text)
            command.Parameters.AddWithValue("@address", address_txt.Text)
            command.Parameters.AddWithValue("@gender", GenderComboBox.Text)
            command.Parameters.AddWithValue("@passport", arrimage)
            command.Parameters.AddWithValue("@fingerprint_template", fs_bytes)
            ' command.Parameters.AddWithValue("@finger_mask",)
            reader = command.ExecuteReader
            connection.Close()
            RecordSave.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub ClearOption()
        fullname_txt.Text = ""
        email_txt.Text = ""
        mobile_txt.Text = ""
        address_txt.Text = ""
        GenderComboBox.Text = Nothing
        UserPictureBox.Image = Nothing
        FptPictureBox.Image = Nothing
    End Sub


End Class