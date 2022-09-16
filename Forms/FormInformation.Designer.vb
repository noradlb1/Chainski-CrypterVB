Namespace Chainski_Crypter.Forms
	Partial Public Class FormInformation
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FormInformation))
			Me.btnRandom = New System.Windows.Forms.Button()
			Me.btnClone = New System.Windows.Forms.Button()
			Me.assemblyPrivatePart = New System.Windows.Forms.NumericUpDown()
			Me.assemblyBuildPart = New System.Windows.Forms.NumericUpDown()
			Me.assemblyMinorVersion = New System.Windows.Forms.NumericUpDown()
			Me.assemblyMajorVersion = New System.Windows.Forms.NumericUpDown()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.txtProduct = New System.Windows.Forms.TextBox()
			Me.txtCompany = New System.Windows.Forms.TextBox()
			Me.txtDescription = New System.Windows.Forms.TextBox()
			Me.txtTrademark = New System.Windows.Forms.TextBox()
			Me.txtCopyright = New System.Windows.Forms.TextBox()
			Me.txtTitle = New System.Windows.Forms.TextBox()
			DirectCast(Me.assemblyPrivatePart, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.assemblyBuildPart, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.assemblyMinorVersion, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.assemblyMajorVersion, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnRandom
			' 
			Me.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnRandom.Location = New System.Drawing.Point(365, 144)
			Me.btnRandom.Margin = New System.Windows.Forms.Padding(2)
			Me.btnRandom.Name = "btnRandom"
			Me.btnRandom.Size = New System.Drawing.Size(82, 31)
			Me.btnRandom.TabIndex = 22
			Me.btnRandom.Text = "Random"
			Me.btnRandom.UseVisualStyleBackColor = True
'			Me.btnRandom.Click += New System.EventHandler(Me.BtnRandom_Click)
			' 
			' btnClone
			' 
			Me.btnClone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnClone.Location = New System.Drawing.Point(451, 144)
			Me.btnClone.Margin = New System.Windows.Forms.Padding(2)
			Me.btnClone.Name = "btnClone"
			Me.btnClone.Size = New System.Drawing.Size(82, 31)
			Me.btnClone.TabIndex = 21
			Me.btnClone.Text = "Clone..."
			Me.btnClone.UseVisualStyleBackColor = True
'			Me.btnClone.Click += New System.EventHandler(Me.BtnClone_Click)
			' 
			' assemblyPrivatePart
			' 
			Me.assemblyPrivatePart.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.assemblyPrivatePart.Location = New System.Drawing.Point(499, 92)
			Me.assemblyPrivatePart.Margin = New System.Windows.Forms.Padding(2)
			Me.assemblyPrivatePart.Name = "assemblyPrivatePart"
			Me.assemblyPrivatePart.Size = New System.Drawing.Size(36, 23)
			Me.assemblyPrivatePart.TabIndex = 19
			' 
			' assemblyBuildPart
			' 
			Me.assemblyBuildPart.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.assemblyBuildPart.Location = New System.Drawing.Point(455, 92)
			Me.assemblyBuildPart.Margin = New System.Windows.Forms.Padding(2)
			Me.assemblyBuildPart.Name = "assemblyBuildPart"
			Me.assemblyBuildPart.Size = New System.Drawing.Size(36, 23)
			Me.assemblyBuildPart.TabIndex = 18
			' 
			' assemblyMinorVersion
			' 
			Me.assemblyMinorVersion.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.assemblyMinorVersion.Location = New System.Drawing.Point(411, 92)
			Me.assemblyMinorVersion.Margin = New System.Windows.Forms.Padding(2)
			Me.assemblyMinorVersion.Name = "assemblyMinorVersion"
			Me.assemblyMinorVersion.Size = New System.Drawing.Size(36, 23)
			Me.assemblyMinorVersion.TabIndex = 17
			' 
			' assemblyMajorVersion
			' 
			Me.assemblyMajorVersion.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.assemblyMajorVersion.Location = New System.Drawing.Point(369, 92)
			Me.assemblyMajorVersion.Margin = New System.Windows.Forms.Padding(2)
			Me.assemblyMajorVersion.Name = "assemblyMajorVersion"
			Me.assemblyMajorVersion.Size = New System.Drawing.Size(36, 23)
			Me.assemblyMajorVersion.TabIndex = 16
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(10, 138)
			Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(51, 15)
			Me.label4.TabIndex = 15
			Me.label4.Text = "Product"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(10, 95)
			Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(58, 15)
			Me.label3.TabIndex = 14
			Me.label3.Text = "Company"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(10, 53)
			Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(71, 15)
			Me.label2.TabIndex = 20
			Me.label2.Text = "Description"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(288, 95)
			Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(49, 15)
			Me.label7.TabIndex = 13
			Me.label7.Text = "Version"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(288, 53)
			Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(68, 15)
			Me.label6.TabIndex = 12
			Me.label6.Text = "Trademark"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(288, 14)
			Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(61, 15)
			Me.label5.TabIndex = 11
			Me.label5.Text = "Copyright"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(10, 14)
			Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(32, 15)
			Me.label1.TabIndex = 10
			Me.label1.Text = "Title"
			' 
			' txtProduct
			' 
			Me.txtProduct.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.txtProduct.Location = New System.Drawing.Point(99, 136)
			Me.txtProduct.Margin = New System.Windows.Forms.Padding(2)
			Me.txtProduct.Name = "txtProduct"
			Me.txtProduct.Size = New System.Drawing.Size(166, 23)
			Me.txtProduct.TabIndex = 8
			' 
			' txtCompany
			' 
			Me.txtCompany.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.txtCompany.Location = New System.Drawing.Point(99, 92)
			Me.txtCompany.Margin = New System.Windows.Forms.Padding(2)
			Me.txtCompany.Name = "txtCompany"
			Me.txtCompany.Size = New System.Drawing.Size(166, 23)
			Me.txtCompany.TabIndex = 7
			' 
			' txtDescription
			' 
			Me.txtDescription.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.txtDescription.Location = New System.Drawing.Point(99, 51)
			Me.txtDescription.Margin = New System.Windows.Forms.Padding(2)
			Me.txtDescription.Name = "txtDescription"
			Me.txtDescription.Size = New System.Drawing.Size(166, 23)
			Me.txtDescription.TabIndex = 6
			' 
			' txtTrademark
			' 
			Me.txtTrademark.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.txtTrademark.Location = New System.Drawing.Point(369, 48)
			Me.txtTrademark.Margin = New System.Windows.Forms.Padding(2)
			Me.txtTrademark.Name = "txtTrademark"
			Me.txtTrademark.Size = New System.Drawing.Size(166, 23)
			Me.txtTrademark.TabIndex = 5
			' 
			' txtCopyright
			' 
			Me.txtCopyright.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.txtCopyright.Location = New System.Drawing.Point(369, 9)
			Me.txtCopyright.Margin = New System.Windows.Forms.Padding(2)
			Me.txtCopyright.Name = "txtCopyright"
			Me.txtCopyright.Size = New System.Drawing.Size(166, 23)
			Me.txtCopyright.TabIndex = 9
			' 
			' txtTitle
			' 
			Me.txtTitle.BackColor = System.Drawing.SystemColors.WindowFrame
			Me.txtTitle.Location = New System.Drawing.Point(99, 9)
			Me.txtTitle.Margin = New System.Windows.Forms.Padding(2)
			Me.txtTitle.Name = "txtTitle"
			Me.txtTitle.Size = New System.Drawing.Size(166, 23)
			Me.txtTitle.TabIndex = 4
			' 
			' FormInformation
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.DarkSlateGray
			Me.ClientSize = New System.Drawing.Size(547, 201)
			Me.Controls.Add(Me.btnRandom)
			Me.Controls.Add(Me.btnClone)
			Me.Controls.Add(Me.assemblyPrivatePart)
			Me.Controls.Add(Me.assemblyBuildPart)
			Me.Controls.Add(Me.assemblyMinorVersion)
			Me.Controls.Add(Me.assemblyMajorVersion)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.txtProduct)
			Me.Controls.Add(Me.txtCompany)
			Me.Controls.Add(Me.txtDescription)
			Me.Controls.Add(Me.txtTrademark)
			Me.Controls.Add(Me.txtCopyright)
			Me.Controls.Add(Me.txtTitle)
			Me.Font = New System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ForeColor = System.Drawing.Color.Cyan
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "FormInformation"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Information"
			Me.TopMost = True
			DirectCast(Me.assemblyPrivatePart, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.assemblyBuildPart, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.assemblyMinorVersion, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.assemblyMajorVersion, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents btnRandom As System.Windows.Forms.Button
		Private WithEvents btnClone As System.Windows.Forms.Button
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Public assemblyPrivatePart As System.Windows.Forms.NumericUpDown
		Public assemblyBuildPart As System.Windows.Forms.NumericUpDown
		Public assemblyMinorVersion As System.Windows.Forms.NumericUpDown
		Public assemblyMajorVersion As System.Windows.Forms.NumericUpDown
		Public txtProduct As System.Windows.Forms.TextBox
		Public txtCompany As System.Windows.Forms.TextBox
		Public txtDescription As System.Windows.Forms.TextBox
		Public txtTrademark As System.Windows.Forms.TextBox
		Public txtCopyright As System.Windows.Forms.TextBox
		Public txtTitle As System.Windows.Forms.TextBox
	End Class
End Namespace