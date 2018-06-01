'
' Created by SharpDevelop.
' User: IP-Man
' Date: 1/9/2017
' Time: 1:51 PM
' 
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.SourcePath = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.SourceFind_BTN = New System.Windows.Forms.Button()
		Me.edit_keysBTN = New System.Windows.Forms.Button()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.Tools_BTN = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me.buildAPKbtn = New System.Windows.Forms.Button()
		Me.apkbuilder_output = New System.Windows.Forms.ListBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.statuLBL = New System.Windows.Forms.Label()
		Me.folderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
		Me.groupBox1.SuspendLayout
		Me.SuspendLayout
		'
		'SourcePath
		'
		Me.SourcePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.SourcePath.Location = New System.Drawing.Point(105, 12)
		Me.SourcePath.Name = "SourcePath"
		Me.SourcePath.Size = New System.Drawing.Size(411, 24)
		Me.SourcePath.TabIndex = 0
		AddHandler Me.SourcePath.TextChanged, AddressOf Me.SourcePathTextChanged
		'
		'label1
		'
		Me.label1.ForeColor = System.Drawing.Color.Red
		Me.label1.Location = New System.Drawing.Point(13, 18)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 15)
		Me.label1.TabIndex = 1
		Me.label1.Text = "HTML 5 Project : "
		'
		'SourceFind_BTN
		'
		Me.SourceFind_BTN.Location = New System.Drawing.Point(522, 13)
		Me.SourceFind_BTN.Name = "SourceFind_BTN"
		Me.SourceFind_BTN.Size = New System.Drawing.Size(63, 24)
		Me.SourceFind_BTN.TabIndex = 2
		Me.SourceFind_BTN.Text = "Find"
		Me.SourceFind_BTN.UseVisualStyleBackColor = true
		AddHandler Me.SourceFind_BTN.Click, AddressOf Me.SourceFind_BTNClick
		'
		'edit_keysBTN
		'
		Me.edit_keysBTN.ForeColor = System.Drawing.Color.DarkGreen
		Me.edit_keysBTN.Location = New System.Drawing.Point(28, 35)
		Me.edit_keysBTN.Name = "edit_keysBTN"
		Me.edit_keysBTN.Size = New System.Drawing.Size(145, 29)
		Me.edit_keysBTN.TabIndex = 3
		Me.edit_keysBTN.Text = "Edit Key Files"
		Me.edit_keysBTN.UseVisualStyleBackColor = true
		AddHandler Me.edit_keysBTN.Click, AddressOf Me.Edit_keysBTNClick
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.Tools_BTN)
		Me.groupBox1.Controls.Add(Me.edit_keysBTN)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.ForeColor = System.Drawing.Color.Red
		Me.groupBox1.Location = New System.Drawing.Point(13, 60)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(572, 92)
		Me.groupBox1.TabIndex = 4
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Settings"
		'
		'Tools_BTN
		'
		Me.Tools_BTN.ForeColor = System.Drawing.Color.DarkGreen
		Me.Tools_BTN.Location = New System.Drawing.Point(396, 35)
		Me.Tools_BTN.Name = "Tools_BTN"
		Me.Tools_BTN.Size = New System.Drawing.Size(145, 29)
		Me.Tools_BTN.TabIndex = 4
		Me.Tools_BTN.Text = "Tools"
		Me.Tools_BTN.UseVisualStyleBackColor = true
		AddHandler Me.Tools_BTN.Click, AddressOf Me.Tools_BTNClick
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.Color.Red
		Me.label2.Location = New System.Drawing.Point(179, 37)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(289, 32)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Default Files:"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"> testkey.pk8, testkey.x509.pem"
		'
		'buildAPKbtn
		'
		Me.buildAPKbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buildAPKbtn.Location = New System.Drawing.Point(13, 168)
		Me.buildAPKbtn.Name = "buildAPKbtn"
		Me.buildAPKbtn.Size = New System.Drawing.Size(286, 70)
		Me.buildAPKbtn.TabIndex = 5
		Me.buildAPKbtn.Text = "Build APK"
		Me.buildAPKbtn.UseVisualStyleBackColor = true
		AddHandler Me.buildAPKbtn.Click, AddressOf Me.BuildAPKbtnClick
		'
		'apkbuilder_output
		'
		Me.apkbuilder_output.FormattingEnabled = true
		Me.apkbuilder_output.Location = New System.Drawing.Point(13, 300)
		Me.apkbuilder_output.Name = "apkbuilder_output"
		Me.apkbuilder_output.Size = New System.Drawing.Size(572, 160)
		Me.apkbuilder_output.TabIndex = 6
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(299, 168)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(286, 70)
		Me.button1.TabIndex = 7
		Me.button1.Text = "APK Folder"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ForeColor = System.Drawing.Color.Red
		Me.label3.Location = New System.Drawing.Point(13, 257)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(64, 18)
		Me.label3.TabIndex = 6
		Me.label3.Text = "Status : "
		'
		'statuLBL
		'
		Me.statuLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.statuLBL.ForeColor = System.Drawing.Color.Red
		Me.statuLBL.Location = New System.Drawing.Point(70, 257)
		Me.statuLBL.Name = "statuLBL"
		Me.statuLBL.Size = New System.Drawing.Size(515, 18)
		Me.statuLBL.TabIndex = 8
		Me.statuLBL.Text = "N/A"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.ClientSize = New System.Drawing.Size(598, 470)
		Me.Controls.Add(Me.statuLBL)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.apkbuilder_output)
		Me.Controls.Add(Me.buildAPKbtn)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.SourceFind_BTN)
		Me.Controls.Add(Me.SourcePath)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "HTML5 to APK GUI"
		Me.groupBox1.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private folderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
	Private statuLBL As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private apkbuilder_output As System.Windows.Forms.ListBox
	Private buildAPKbtn As System.Windows.Forms.Button
	Private Tools_BTN As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private edit_keysBTN As System.Windows.Forms.Button
	Private SourceFind_BTN As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private SourcePath As System.Windows.Forms.TextBox
End Class
