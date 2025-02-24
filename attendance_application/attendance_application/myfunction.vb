Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Drawing.Drawing2D

Module MyFunction
    Private capturer As DPFP.Capture.Capture

    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=nacos_idify_db")
        Return conn
    End Function

    Function defaultPixUrl()
        Dim defaultPix As String
        defaultPix = "http://localhost/projects/nacosidify.com/api/uploaded-files/students-pix/friends.png"
        Return defaultPix
    End Function

    Public Sub StartCapture()
        Try
            If (Not capturer Is Nothing) Then
                capturer.StartCapture()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "TrackSmart App", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Timer to fade in the form
    Dim fadeTimer As Timer

    ' Method to start fade-in effect
    Public Sub startFadeIn(ByVal form As Form)
        ' Create and start the fade-in timer
        fadeTimer = New Timer(AddressOf FadeIn, form, 0, 50)
    End Sub

    ' Timer callback to gradually change opacity
    Public Sub FadeIn(ByVal state As Object)
        Dim form As Form = CType(state, Form)
        If form.InvokeRequired Then
            form.Invoke(New MethodInvoker(Sub() FadeIn(state)))
        Else
            If form.Opacity < 1 Then
                form.Opacity += 0.1 ' Increment opacity by 5%
            Else
                fadeTimer.Change(Timeout.Infinite, Timeout.Infinite) ' Stop the timer
            End If
        End If
    End Sub



    Public Sub styleDynamicBorderRadius(ByVal gunaButton As Object, ByVal leftRadius As Integer, ByVal rightRadius As Integer)
        Dim path As New GraphicsPath()
        Dim rect As Rectangle = gunaButton.ClientRectangle

        ' Define diameters for left and right radii
        Dim leftDiameter As Integer = leftRadius * 2
        Dim rightDiameter As Integer = rightRadius * 2

        ' Define the custom rounded rectangle path
        path.AddArc(rect.X, rect.Y, leftDiameter, leftDiameter, 180, 90) ' Top-left corner
        path.AddLine(rect.X + leftRadius, rect.Y, rect.Right - rightRadius, rect.Y) ' Top edge
        path.AddArc(rect.Right - rightDiameter, rect.Y, rightDiameter, rightDiameter, 270, 90) ' Top-right corner
        path.AddLine(rect.Right, rect.Y + rightRadius, rect.Right, rect.Bottom - rightRadius) ' Right edge
        path.AddArc(rect.Right - rightDiameter, rect.Bottom - rightDiameter, rightDiameter, rightDiameter, 0, 90) ' Bottom-right corner
        path.AddLine(rect.Right - rightRadius, rect.Bottom, rect.X + leftRadius, rect.Bottom) ' Bottom edge
        path.AddArc(rect.X, rect.Bottom - leftDiameter, leftDiameter, leftDiameter, 90, 90) ' Bottom-left corner
        path.AddLine(rect.X, rect.Bottom - leftRadius, rect.X, rect.Y + leftRadius) ' Left edge
        path.CloseFigure()

        ' Set the button's region
        gunaButton.Region = New Region(path)
    End Sub

    Public Sub closeForm(ByVal newForm As Form)
        newForm.Close()
        overlay.Close()
    End Sub

    Public Sub activeBtn()
        enrollDashboard.dashboardBtn.Checked = False
        enrollDashboard.enrollBtn.Checked = False
        enrollDashboard.enrollListBtn.Checked = False
        enrollDashboard.verifyBtn.Checked = False
        enrollDashboard.pageLoaderContainer.Hide()

        enrollmentFormPage.enrollSearchTxt.Text = ""
        cancelField()
    End Sub

    Public Sub cancelField()
        enrollmentFormPage.matricNoFormNoTxt.Text = ""
        enrollmentFormPage.fullnameTxt.Text = ""
        enrollmentFormPage.departmentTxt.Text = ""
        enrollmentFormPage.levelTxt.Text = ""
        enrollmentFormPage.passportBox = MyFunction.getPassportPix("http://localhost/projects/nacosidify.com/api/uploaded-files/students-pix/friends.png", enrollmentFormPage.passportBox)
        enrollmentFormPage.FptPictureBox.Image = Nothing

        verificationFormPage.verifyMatricNoFormNoTxt.Text = ""
        verificationFormPage.verifyFullnameTxt.Text = ""
        verificationFormPage.verifyDepartmentTxt.Text = ""
        verificationFormPage.verifyLevelTxt.Text = ""
        verificationFormPage.verifyPassportBox = MyFunction.getPassportPix("http://localhost/projects/nacosidify.com/api/uploaded-files/students-pix/friends.png", enrollmentFormPage.passportBox)
        verificationFormPage.verifyFptPictureBox.Image = Nothing
    End Sub

    Public Sub progressIndicatorHide(ByVal progressBar As Object, ByVal progressIndicator As Object)
        progressBar.Hide()
        progressIndicator.Hide()
    End Sub

    Public Sub loginProgressIndicatorShow(ByVal progressBar As Object, ByVal progressIndicator As Object, ByVal timerLoader As Object)
        ' Increment ProgressBar value
        progressBar.Increment(2)
        ' Show progressIndicator
        progressIndicator.Show()
        progressIndicator.AutoStart = True

        ' Check if progress is complete
        If progressBar.Value >= 60 Then
            timerLoader.Dispose()
            progressBar.Value = 0
            progressIndicator.AutoStart = False
            progressIndicator.Hide()

        End If
    End Sub


    Public Sub dashboardPageProgressIndicatorShow(ByVal getPage As Form, ByVal progressBar As Object, ByVal progressIndicator As Object, ByVal timerLoader As Object)
        ' Increment ProgressBar value
        progressBar.Increment(2)
        ' Show progressIndicator
        progressIndicator.Show()
        progressIndicator.AutoStart = True

        ' Check if progress is complete
        If progressBar.Value >= 20 Then
            timerLoader.Dispose()
            progressBar.Value = 0
            progressIndicator.AutoStart = False
            progressIndicator.Hide()
            enrollDashboard.pageLoaderContainer.Hide()
            getPageForm(getPage)
            'StartCapture()
            ''MessageBox.Show("YES")
            'MessageBox.Show("Completed!!!", "Progress", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Public Sub dashboardFormProgressIndicatorShow(ByVal getForm As Form, ByVal progressBar As Object, ByVal progressIndicator As Object, ByVal timerLoader As Object)
        overlay.Show()
        ' Increment ProgressBar value
        progressBar.Increment(2)
        ' Show progressIndicator
        progressIndicator.Show()
        progressIndicator.AutoStart = True

        ' Check if progress is complete
        If progressBar.Value >= 20 Then
            timerLoader.Dispose()
            progressBar.Value = 0
            progressIndicator.AutoStart = False
            progressIndicator.Hide()
            overlay.formLoaderContainer.Hide()
            getForm.Show()
            ' getPageForm(getForm)
            'MessageBox.Show("Completed!!!", "Progress", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Public Sub getPageForm(ByVal newForm As Form)
        ' Clear any existing controls in the dashboard panel
        enrollDashboard.dashboardPanel.Controls.Clear()
        ' Configure the new form
        newForm.TopLevel = False
        'panel.FormBorderStyle = FormBorderStyle.None --- to remove form border
        newForm.Dock = DockStyle.Fill
        ' Add the new form to the panel
        enrollDashboard.dashboardPanel.Controls.Add(newForm)
        newForm.Show()
    End Sub

    Public Sub formModal(ByVal newForm As Form)
        overlay.Show()
        newForm.Show()
    End Sub



    Public Function hashCodePassword(ByVal source As String) As String
        If String.IsNullOrEmpty(source) Then Throw New ArgumentNullException
        Return String.Concat(MD5.Create().ComputeHash(Encoding.Default.GetBytes(source)).Select(Function(b) b.ToString("x2")))
    End Function

    Public Sub directToDashboard()
        index.email_txt.Text = ""
        index.password_txt.Text = ""
        index.Hide()
        enrollDashboard.ShowDialog()
    End Sub



    Function emailValidate(ByVal email_address As String) As Boolean
        Dim email As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        If email.IsMatch(email_address) Then
            Return True
        End If
        Return False
    End Function


    Function getSequeceCount(ByVal counter_id As String)
        Dim connection = MyFunction.connection

        connection.Open()
        command = New MySqlCommand("SELECT counter_value FROM setup_counter_tab WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("counter_value")
        connection.Close()

        connection.Open()
        command = New MySqlCommand("UPDATE setup_counter_tab SET counter_value=counter_value+1 WHERE counter_id=@counter_id FOR UPDATE", connection)
        command.Parameters.AddWithValue("@counter_value", counter_value)
        reader = command.ExecuteReader
        connection.Close()
        Return counter_value
    End Function





    Function textToLowerCase(ByVal name As String)
        Dim formattedName As String = Char.ToUpper(name(0)) & name.Substring(1).ToLower()
        Return formattedName
    End Function

    Function getStaffLoginDetails(ByVal staff_id As String, ByVal department_id As String)
        Dim connection = MyFunction.connection
        connection.Open()
        command = New MySqlCommand("SELECT a.* b.status_name FROM staff_tab WHERE a.status_id AND b.status_id AND staff_id=@staff_id AND department_id=@department_id", connection)
        command.Parameters.AddWithValue("@staff_id", staff_id)
        reader = command.ExecuteReader
        reader.Read()

        Dim login_Staff_firstname = reader("firstname")
        Dim login_Staff_lastname = reader("lastname")
        Dim login_Staff_last_login_time = reader("last_login_time")
        Dim arrimage() As Byte = reader("profile_pix")
        connection.close()
        Return Tuple.Create(login_Staff_firstname, login_Staff_lastname, login_Staff_last_login_time, arrimage)
    End Function


    Function getPassportPix(ByVal imagePath As String, ByVal passport As Object)
        Try
            ' Dim imagePath As String = passport_url & "/" & std_passport_pix

            If imagePath.StartsWith("http://") OrElse imagePath.StartsWith("https://") Then
                ' Load image from URL
                Dim webClient As New Net.WebClient()
                Dim imageStream As IO.Stream = webClient.OpenRead(imagePath)
                passport.Image = Image.FromStream(imageStream)
            ElseIf IO.File.Exists(imagePath) Then
                ' Load image from local file
                passport.Image = Image.FromFile(imagePath)
            Else
                MessageBox.Show("Image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return passport
    End Function




End Module

