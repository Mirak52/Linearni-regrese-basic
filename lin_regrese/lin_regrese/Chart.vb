Public Class Chart
	Dim vpravo As Integer
	Private Sub Chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		For i = 1 To n
			Me.Chart1.Series("body").Points.AddXY(x(i), y(i))
			Me.Chart1.Series("primka").Points.AddXY(x(i), a + b * x(i))

		Next
		Me.CenterToParent()
		vpravo = Form1.Left / 2
		Form1.Left = 100

		Me.Left = Me.Left + 250
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Chart1.Printing.Print(True)

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Dim myBMP As New Bitmap(Chart1.Width, Chart1.Height)
		myBMP.SetResolution(120, 120)
		Chart1.DrawToBitmap(myBMP, Chart1.ClientRectangle)
		SaveFileDialog1.ShowDialog()

		myBMP.Save(SaveFileDialog1.FileName + ".BMP", Drawing.Imaging.ImageFormat.Bmp)

	End Sub

	Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Form1.Left = left
		Me.Close()
	End Sub
End Class