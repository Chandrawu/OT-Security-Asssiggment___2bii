<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Lbl_LineA = New System.Windows.Forms.Label()
		Me.Lbl_PathlineA = New System.Windows.Forms.Label()
		Me.Lbl_StatusLineA = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Lbl_PathLineB = New System.Windows.Forms.Label()
		Me.Lbl_pathLineC = New System.Windows.Forms.Label()
		Me.Lbl_StatusLineB = New System.Windows.Forms.Label()
		Me.Lbl_StatusLineC = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'Lbl_LineA
		'
		Me.Lbl_LineA.AutoSize = True
		Me.Lbl_LineA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lbl_LineA.Location = New System.Drawing.Point(22, 19)
		Me.Lbl_LineA.Name = "Lbl_LineA"
		Me.Lbl_LineA.Size = New System.Drawing.Size(64, 24)
		Me.Lbl_LineA.TabIndex = 1
		Me.Lbl_LineA.Text = "Line A"
		'
		'Lbl_PathlineA
		'
		Me.Lbl_PathlineA.AutoSize = True
		Me.Lbl_PathlineA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lbl_PathlineA.Location = New System.Drawing.Point(113, 19)
		Me.Lbl_PathlineA.Name = "Lbl_PathlineA"
		Me.Lbl_PathlineA.Size = New System.Drawing.Size(66, 24)
		Me.Lbl_PathlineA.TabIndex = 2
		Me.Lbl_PathlineA.Text = "Label2"
		'
		'Lbl_StatusLineA
		'
		Me.Lbl_StatusLineA.AutoSize = True
		Me.Lbl_StatusLineA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lbl_StatusLineA.Location = New System.Drawing.Point(282, 19)
		Me.Lbl_StatusLineA.Name = "Lbl_StatusLineA"
		Me.Lbl_StatusLineA.Size = New System.Drawing.Size(38, 24)
		Me.Lbl_StatusLineA.TabIndex = 3
		Me.Lbl_StatusLineA.Text = "NG"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(22, 45)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 24)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Line B"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(22, 73)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(64, 24)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Line C"
		'
		'Lbl_PathLineB
		'
		Me.Lbl_PathLineB.AutoSize = True
		Me.Lbl_PathLineB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lbl_PathLineB.Location = New System.Drawing.Point(113, 45)
		Me.Lbl_PathLineB.Name = "Lbl_PathLineB"
		Me.Lbl_PathLineB.Size = New System.Drawing.Size(66, 24)
		Me.Lbl_PathLineB.TabIndex = 6
		Me.Lbl_PathLineB.Text = "Label2"
		'
		'Lbl_pathLineC
		'
		Me.Lbl_pathLineC.AutoSize = True
		Me.Lbl_pathLineC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lbl_pathLineC.Location = New System.Drawing.Point(113, 73)
		Me.Lbl_pathLineC.Name = "Lbl_pathLineC"
		Me.Lbl_pathLineC.Size = New System.Drawing.Size(66, 24)
		Me.Lbl_pathLineC.TabIndex = 7
		Me.Lbl_pathLineC.Text = "Label2"
		'
		'Lbl_StatusLineB
		'
		Me.Lbl_StatusLineB.AutoSize = True
		Me.Lbl_StatusLineB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lbl_StatusLineB.Location = New System.Drawing.Point(282, 45)
		Me.Lbl_StatusLineB.Name = "Lbl_StatusLineB"
		Me.Lbl_StatusLineB.Size = New System.Drawing.Size(38, 24)
		Me.Lbl_StatusLineB.TabIndex = 8
		Me.Lbl_StatusLineB.Text = "NG"
		'
		'Lbl_StatusLineC
		'
		Me.Lbl_StatusLineC.AutoSize = True
		Me.Lbl_StatusLineC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Lbl_StatusLineC.Location = New System.Drawing.Point(282, 73)
		Me.Lbl_StatusLineC.Name = "Lbl_StatusLineC"
		Me.Lbl_StatusLineC.Size = New System.Drawing.Size(38, 24)
		Me.Lbl_StatusLineC.TabIndex = 9
		Me.Lbl_StatusLineC.Text = "NG"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(447, 135)
		Me.Controls.Add(Me.Lbl_StatusLineC)
		Me.Controls.Add(Me.Lbl_StatusLineB)
		Me.Controls.Add(Me.Lbl_pathLineC)
		Me.Controls.Add(Me.Lbl_PathLineB)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Lbl_StatusLineA)
		Me.Controls.Add(Me.Lbl_PathlineA)
		Me.Controls.Add(Me.Lbl_LineA)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Lbl_LineA As Label
	Friend WithEvents Lbl_PathlineA As Label
	Friend WithEvents Lbl_StatusLineA As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Lbl_PathLineB As Label
	Friend WithEvents Lbl_pathLineC As Label
	Friend WithEvents Lbl_StatusLineB As Label
	Friend WithEvents Lbl_StatusLineC As Label
	Friend WithEvents Timer1 As Timer
End Class
