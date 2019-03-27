<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Vyžadováno Návrhářem Windows Form
	Private components As System.ComponentModel.IContainer

	'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
	'Může být upraveno pomocí Návrháře Windows Form.  
	'Neupravovat pomocí editoru kódu
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBoxX = New System.Windows.Forms.TextBox()
		Me.TextBoxY = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Save = New System.Windows.Forms.Button()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Chybiska = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(223, 24)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Přidej"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBoxX
		'
		Me.TextBoxX.Location = New System.Drawing.Point(109, 23)
		Me.TextBoxX.Name = "TextBoxX"
		Me.TextBoxX.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxX.TabIndex = 1
		'
		'TextBoxY
		'
		Me.TextBoxY.Location = New System.Drawing.Point(109, 50)
		Me.TextBoxY.Name = "TextBoxY"
		Me.TextBoxY.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxY.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(58, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Hodnota X"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(13, 57)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(58, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Hodnota Y"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(16, 105)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(437, 239)
		Me.DataGridView1.TabIndex = 7
		'
		'Save
		'
		Me.Save.Location = New System.Drawing.Point(497, 105)
		Me.Save.Name = "Save"
		Me.Save.Size = New System.Drawing.Size(135, 23)
		Me.Save.TabIndex = 8
		Me.Save.Text = "Ulož do souboru"
		Me.Save.UseVisualStyleBackColor = True
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(497, 170)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 9
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Chybiska
		'
		Me.Chybiska.AutoSize = True
		Me.Chybiska.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Chybiska.ForeColor = System.Drawing.Color.Crimson
		Me.Chybiska.Location = New System.Drawing.Point(497, 50)
		Me.Chybiska.Name = "Chybiska"
		Me.Chybiska.Size = New System.Drawing.Size(0, 39)
		Me.Chybiska.TabIndex = 10
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Chybiska)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Save)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBoxY)
		Me.Controls.Add(Me.TextBoxX)
		Me.Controls.Add(Me.Button1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents TextBoxX As TextBox
	Friend WithEvents TextBoxY As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Save As Button
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents Button2 As Button
	Friend WithEvents Chybiska As Label
End Class
