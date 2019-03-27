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
		End If

	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		n = 0
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
		FileClose(1)
	End Sub
End Class
