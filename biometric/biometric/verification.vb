Imports DPFP
Imports DPFP.Capture
Imports DPFP.Verification
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class verification
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
   ' Dim FormInstance As New Enrollment()


    Private Sub verification_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
        ClearOption()
        InitializeCapture()
        StartCapture()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        StopCapture()

       ClearOption()

        admin_dashboard.AllBtnTransparent()
    End Sub

    Public Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        If Me.Visible = True Then
            Try
                ProcessVerify(Sample)
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
            If (Not capturer Is Nothing) Then
                capturer.EventHandler = Me
            Else
                MsgBox("Can't Initialize Capture Operation")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub ProcessVerify(ByVal sample As DPFP.Sample)
        Try
            connection = MyFuctions.GetSqlConnection
            DrawPicture(ConvertSampleToBitmap(sample))
            Dim FeaturesVerify As DPFP.FeatureSet = ExtractFeatures(sample, DPFP.Processing.DataPurpose.Verification)

            If FeaturesVerify IsNot Nothing Then
                Dim verificator As New DPFP.Verification.Verification
                Dim result As New DPFP.Verification.Verification.Result()

                Dim query As String = "SELECT fingerprint_template FROM users_tab"
                Dim sda As New MySqlDataAdapter(query, connection)
                Dim dt As New DataTable
                sda.Fill(dt)

                For Each dr As DataRow In dt.Rows
                    Dim bytes As Byte() = TryCast(dr("fingerprint_template"), Byte())
                    If bytes IsNot Nothing Then
                        Dim SavedTemp As New DPFP.Template
                        SavedTemp.DeSerialize(bytes)
                        verificator.Verify(FeaturesVerify, SavedTemp, result)

                        If result.Verified Then
                            SetStatus("Fingerprint is Verified")
                            connection = MyFuctions.GetSqlConnection
                            query = "SELECT a.fullname, a.email_address, a.mobile, a.address, a.gender, a.passport FROM users_tab a WHERE fingerprint_template=@fingerprint_template;"
                            command = New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@fingerprint_template", bytes)
                            reader = command.ExecuteReader
                            reader.Read()
                            Me.Invoke(Sub()
                                          Try
                                              fullname_txt.Text = reader("fullname")
                                              email_txt.Text = reader("email_address")
                                              mobile_txt.Text = reader("mobile")
                                              address_txt.Text = reader("address")
                                              gender_txt.Text = reader("gender")
                                              arrimage = reader("passport")
                                              mstream = New MemoryStream(arrimage)
                                              UserPicturebox.Image = Image.FromStream(mstream)
                                          Catch ex As Exception
                                              MsgBox("An error occurred: " & ex.Message)
                                          End Try
                                          connection.Close()
                                      End Sub)
                            Exit For
                        End If
                    End If
                Next

                If Not result.Verified Then
                    SetStatus("No Record Found with the Specified Fingerprint")
                    Me.Invoke(Sub()
                                  fullname_txt.Text = ""
                                  email_txt.Text = ""
                                  mobile_txt.Text = ""
                                  address_txt.Text = ""
                                  gender_txt.Text = ""
                                  UserPictureBox.Image = Nothing
                              End Sub)
                End If
            Else
                SetStatus("Unable to extract features from the fingerprint")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
        connection.Close()
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
            If LabelCount.Text = ("No Record Found with the Specified Fingerprint") Then
                Me.LabelCount.ForeColor = Color.DarkRed
            Else
                Me.LabelCount.ForeColor = Color.DarkGreen
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

    Private Function ClearOption()
        fullname_txt.Text = ""
        email_txt.Text = ""
        mobile_txt.Text = ""
        address_txt.Text = ""
        gender_txt.Text = ""
        UserPicturebox.Image = Nothing
        FptPictureBox.Image = Nothing
        SetStatus("")
    End Function

  



    
End Class