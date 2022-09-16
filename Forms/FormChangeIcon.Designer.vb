Namespace Chainski_Crypter.Forms
	Partial Public Class FormChangeIcon
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FormChangeIcon))
			Me.pictureIcon = New System.Windows.Forms.PictureBox()
			Me.s = New System.Windows.Forms.Button()
			Me.label8 = New System.Windows.Forms.Label()
			Me.txtIcon = New System.Windows.Forms.TextBox()
			DirectCast(Me.pictureIcon, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pictureIcon
			' 
			Me.pictureIcon.BackColor = System.Drawing.Color.DarkSlateGray
			Me.pictureIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.pictureIcon.Location = New System.Drawing.Point(85, 44)
			Me.pictureIcon.Margin = New System.Windows.Forms.Padding(2)
			Me.pictureIcon.Name = "pictureIcon"
			Me.pictureIcon.Size = New System.Drawing.Size(64, 64)
			Me.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureIcon.TabIndex = 8
			Me.pictureIcon.TabStop = False
			' 
			' s
			' 
			Me.s.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.s.Font = New System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.s.ForeColor = System.Drawing.Color.Cyan
			Me.s.Location = New System.Drawing.Point(283, 13)
			Me.s.Margin = New System.Windows.Forms.Padding(2)
			Me.s.Name = "s"
			Me.s.Size = New System.Drawing.Size(85, 25)
			Me.s.TabIndex = 5
			Me.s.Text = "Choose Icon"
			Me.s.UseVisualStyleBackColor = True
'			Me.s.Click += New System.EventHandler(Me.S_Click)
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label8.ForeColor = System.Drawing.Color.Cyan
			Me.label8.Location = New System.Drawing.Point(9, 21)
			Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(59, 15)
			Me.label8.TabIndex = 7
			Me.label8.Text = "Icon Path"
			' 
			' txtIcon
			' 
			Me.txtIcon.BackColor = System.Drawing.Color.DarkSlateGray
			Me.txtIcon.Location = New System.Drawing.Point(85, 16)
			Me.txtIcon.Margin = New System.Windows.Forms.Padding(2)
			Me.txtIcon.Name = "txtIcon"
			Me.txtIcon.Size = New System.Drawing.Size(194, 20)
			Me.txtIcon.TabIndex = 6
			' 
			' FormChangeIcon
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.DarkSlateGray
			Me.ClientSize = New System.Drawing.Size(373, 127)
			Me.Controls.Add(Me.pictureIcon)
			Me.Controls.Add(Me.s)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.txtIcon)
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "FormChangeIcon"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Change Icon"
			Me.TopMost = True
'			Me.Load += New System.EventHandler(Me.FormChangeIcon_Load)
			DirectCast(Me.pictureIcon, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private pictureIcon As System.Windows.Forms.PictureBox
		Private WithEvents s As System.Windows.Forms.Button
		Private label8 As System.Windows.Forms.Label
		Public txtIcon As System.Windows.Forms.TextBox
	End Class
End Namespace