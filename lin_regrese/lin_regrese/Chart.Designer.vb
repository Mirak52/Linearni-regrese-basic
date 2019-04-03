<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chart
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
		Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series19 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series20 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Chart1
		'
		ChartArea10.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea10)
		Legend10.Name = "Legend1"
		Me.Chart1.Legends.Add(Legend10)
		Me.Chart1.Location = New System.Drawing.Point(13, 13)
		Me.Chart1.Name = "Chart1"
		Series19.ChartArea = "ChartArea1"
		Series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint
		Series19.Color = System.Drawing.Color.Fuchsia
		Series19.Legend = "Legend1"
		Series19.Name = "body"
		Series19.YValuesPerPoint = 2
		Series20.ChartArea = "ChartArea1"
		Series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
		Series20.Legend = "Legend1"
		Series20.Name = "primka"
		Me.Chart1.Series.Add(Series19)
		Me.Chart1.Series.Add(Series20)
		Me.Chart1.Size = New System.Drawing.Size(469, 393)
		Me.Chart1.TabIndex = 1
		Me.Chart1.Text = "Chart2"
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(601, 205)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(125, 43)
		Me.Button3.TabIndex = 6
		Me.Button3.Text = "Ulož graf do obrázku"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(601, 123)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(125, 43)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "Tisk grafu"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(601, 281)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(125, 43)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Zpět"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Chart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScrollMargin = New System.Drawing.Size(500, 0)
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Chart1)
		Me.Location = New System.Drawing.Point(50, 50)
		Me.Name = "Chart"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Chart"
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents SaveFileDialog2 As SaveFileDialog
End Class
