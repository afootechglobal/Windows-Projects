Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Public Class CircleAvatar
    Inherits PictureBox
    Public Sub New()
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim brushimege As System.Drawing.Brush
        Try
            Dim imagem As New Bitmap(Me.Image)
            imagem = New Bitmap(imagem, New Size(Me.Width - 1, Me.Height - 1))
            brushimege = New TextureBrush(imagem)
        Catch
            Dim imagem As New Bitmap(Me.Width - 1, Me.Height - 1, PixelFormat.Format24bppRgb)
            Using grp As Graphics = Graphics.FromImage(imagem)
                grp.FillRectangle(Brushes.White, 0, 0, Me.Width - 1, Me.Height - 1)
                imagem = New Bitmap(Me.Width - 1, Me.Height - 1, grp)
            End Using
            brushimege = New TextureBrush(imagem)
        End Try
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        Dim path As New GraphicsPath
        path.AddEllipse(0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.FillPath(brushimege, path)
        e.Graphics.DrawPath(Pens.Transparent, path)
    End Sub
End Class
