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
		components = New System.ComponentModel.Container()
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Text = "Form1"
	End Sub

End Class
