Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If (TextBoxX.Text = "" Or TextBoxY.Text = "" Or IsNumeric(TextBoxX.Text) = False Or IsNumeric(TextBoxY.Text) = False) Then
			Chybiska.Text = "Zadej číslo, Díky!"
		Else
			Chybiska.Text = ""
			n = n + 1
			x(n) = Val(TextBoxX.Text)
			y(n) = Val(TextBoxY.Text)

			DataGridView1.Rows.Add(1)
			DataGridView1.Rows.Item(n - 1).Cells(0).Value = n
			DataGridView1.Rows.Item(n - 1).Cells(1).Value = x(n)
			DataGridView1.Rows.Item(n - 1).Cells(2).Value = y(n)
			TextBoxX.Clear()
			TextBoxY.Clear()
			Button3.Show()
			Button4.Show()
			Button5.Show()
		End If

	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		n = 0
		Me.CenterToParent()
		Button3.Hide()
		Button4.Hide()
		Button5.Hide()
		DataGridView1.Rows.Clear()
		DataGridView1.Columns.Add("ID", "Pořadí")
		DataGridView1.Columns.Add("X", "Hodnota X")
		DataGridView1.Columns.Add("Y", "Hodnota Y")
	End Sub

	Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

		SaveFileDialog1.ShowDialog()
		FileOpen(1, SaveFileDialog1.FileName, OpenMode.Append)
		WriteLine(1, n)
		For i = 1 To n Step 1
			Write(1, x(i))
			Write(1, y(i))
		Next
		FileClose(1)
	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		MessageBox.Show("Hodnota je " + Convert.ToString(DataGridView1.CurrentCell.Value))
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		OpenFileDialog1.ShowDialog()

		FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
		Input(1, n)
		For i = 1 To n
			Input(1, x(i))
			Input(1, y(i))
			DataGridView1.Rows.Add(1)
			DataGridView1.Rows.Item(i - 1).Cells(0).Value = i
			DataGridView1.Rows.Item(i - 1).Cells(1).Value = x(i)
			DataGridView1.Rows.Item(i - 1).Cells(2).Value = y(i)
		Next
		Button3.Show()
		Button4.Show()
		Button5.Show()
		FileClose(1)
	End Sub
	Public Function calculateRegFunc(bool As Boolean)
		Dim sumxy As Single
		Dim sumx As Single
		Dim sumy As Single
		Dim sumx2 As Single

		sumxy = 0
		sumx = 0
		sumy = 0
		sumx2 = 0
		For i = 1 To n
			sumxy = sumxy + x(i) * y(i)
			sumx = sumx + x(i)
			sumy = sumy + y(i)
			sumx2 = sumx2 + (x(i) * x(i))
		Next i
		b = ((n * sumxy) - (sumx * sumy)) / ((n * sumx2) - (sumx * sumx))
		a = (sumy - (b * sumx)) / n

		If (bool) Then
			MsgBox("Rovnice regresní přímky je: " + "y = " + Str(a) + " + " + Str(b) + ".x")
		End If
	End Function
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		calculateRegFunc(True)
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		a = 0
		b = 0
		Chart.Show()

	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		calculateRegFunc(False)
		Chart.Show()
	End Sub

End Class
