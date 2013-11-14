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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstChat = New System.Windows.Forms.ListBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnCamera = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btndevoff = New System.Windows.Forms.Button()
        Me.btnconsole = New System.Windows.Forms.Button()
        Me.lblemv = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnrandomiseEMV = New System.Windows.Forms.Button()
        Me.btnsetemv = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnSetUsername = New System.Windows.Forms.Button()
        Me.btnEnableDev = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnnote = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.axAVI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstChat
        '
        Me.lstChat.FormattingEnabled = True
        Me.lstChat.Location = New System.Drawing.Point(6, 6)
        Me.lstChat.Name = "lstChat"
        Me.lstChat.Size = New System.Drawing.Size(446, 446)
        Me.lstChat.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(377, 465)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 21)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(6, 466)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(365, 20)
        Me.txtUser.TabIndex = 2
        '
        'btnOptions
        '
        Me.btnOptions.Enabled = False
        Me.btnOptions.Location = New System.Drawing.Point(7, 65)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(445, 23)
        Me.btnOptions.TabIndex = 3
        Me.btnOptions.Text = "OtherOption"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnCamera
        '
        Me.btnCamera.Enabled = False
        Me.btnCamera.Location = New System.Drawing.Point(7, 94)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(445, 23)
        Me.btnCamera.TabIndex = 4
        Me.btnCamera.Text = "Disable Camera Feed"
        Me.btnCamera.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Location = New System.Drawing.Point(7, 152)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(445, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(466, 519)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstChat)
        Me.TabPage1.Controls.Add(Me.txtUser)
        Me.TabPage1.Controls.Add(Me.btnSend)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(458, 493)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Chat"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btndevoff)
        Me.TabPage2.Controls.Add(Me.btnconsole)
        Me.TabPage2.Controls.Add(Me.lblemv)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btnrandomiseEMV)
        Me.TabPage2.Controls.Add(Me.btnsetemv)
        Me.TabPage2.Controls.Add(Me.btnRecord)
        Me.TabPage2.Controls.Add(Me.btnSetUsername)
        Me.TabPage2.Controls.Add(Me.btnEnableDev)
        Me.TabPage2.Controls.Add(Me.btnOptions)
        Me.TabPage2.Controls.Add(Me.btnReset)
        Me.TabPage2.Controls.Add(Me.btnCamera)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(458, 493)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Options"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btndevoff
        '
        Me.btndevoff.Enabled = False
        Me.btndevoff.Location = New System.Drawing.Point(3, 435)
        Me.btndevoff.Name = "btndevoff"
        Me.btndevoff.Size = New System.Drawing.Size(449, 23)
        Me.btndevoff.TabIndex = 14
        Me.btndevoff.Text = "Turn Off Developer Options"
        Me.btndevoff.UseVisualStyleBackColor = True
        '
        'btnconsole
        '
        Me.btnconsole.Location = New System.Drawing.Point(3, 464)
        Me.btnconsole.Name = "btnconsole"
        Me.btnconsole.Size = New System.Drawing.Size(449, 23)
        Me.btnconsole.TabIndex = 13
        Me.btnconsole.Text = "Console Mode"
        Me.btnconsole.UseVisualStyleBackColor = True
        '
        'lblemv
        '
        Me.lblemv.BackColor = System.Drawing.Color.White
        Me.lblemv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblemv.Location = New System.Drawing.Point(375, 240)
        Me.lblemv.Name = "lblemv"
        Me.lblemv.Size = New System.Drawing.Size(67, 21)
        Me.lblemv.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "EMV:"
        '
        'btnrandomiseEMV
        '
        Me.btnrandomiseEMV.Enabled = False
        Me.btnrandomiseEMV.Location = New System.Drawing.Point(7, 210)
        Me.btnrandomiseEMV.Name = "btnrandomiseEMV"
        Me.btnrandomiseEMV.Size = New System.Drawing.Size(445, 23)
        Me.btnrandomiseEMV.TabIndex = 10
        Me.btnrandomiseEMV.Text = "Randomise EMV"
        Me.btnrandomiseEMV.UseVisualStyleBackColor = True
        '
        'btnsetemv
        '
        Me.btnsetemv.Enabled = False
        Me.btnsetemv.Location = New System.Drawing.Point(7, 181)
        Me.btnsetemv.Name = "btnsetemv"
        Me.btnsetemv.Size = New System.Drawing.Size(445, 23)
        Me.btnsetemv.TabIndex = 9
        Me.btnsetemv.Text = "Set EMV"
        Me.btnsetemv.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.Enabled = False
        Me.btnRecord.Location = New System.Drawing.Point(7, 123)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(445, 23)
        Me.btnRecord.TabIndex = 8
        Me.btnRecord.Text = "Record"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnSetUsername
        '
        Me.btnSetUsername.Location = New System.Drawing.Point(7, 7)
        Me.btnSetUsername.Name = "btnSetUsername"
        Me.btnSetUsername.Size = New System.Drawing.Size(445, 23)
        Me.btnSetUsername.TabIndex = 7
        Me.btnSetUsername.Text = "Set Username"
        Me.btnSetUsername.UseVisualStyleBackColor = True
        '
        'btnEnableDev
        '
        Me.btnEnableDev.Location = New System.Drawing.Point(7, 36)
        Me.btnEnableDev.Name = "btnEnableDev"
        Me.btnEnableDev.Size = New System.Drawing.Size(445, 23)
        Me.btnEnableDev.TabIndex = 6
        Me.btnEnableDev.Text = "Enable Developer Options"
        Me.btnEnableDev.UseVisualStyleBackColor = True
        '
        'axAVI
        '
        Me.axAVI.Location = New System.Drawing.Point(474, 27)
        Me.axAVI.Name = "axAVI"
        Me.axAVI.OcxState = CType(resources.GetObject("axAVI.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axAVI.Size = New System.Drawing.Size(571, 497)
        Me.axAVI.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(909, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Time Remaining (S) = "
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltime.Location = New System.Drawing.Point(1018, 5)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(27, 15)
        Me.lbltime.TabIndex = 9
        Me.lbltime.Text = "300"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'btnnote
        '
        Me.btnnote.Location = New System.Drawing.Point(6, 543)
        Me.btnnote.Name = "btnnote"
        Me.btnnote.Size = New System.Drawing.Size(1039, 23)
        Me.btnnote.TabIndex = 15
        Me.btnnote.Text = "Note From The Developer"
        Me.btnnote.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 535)
        Me.Controls.Add(Me.btnnote)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.axAVI)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Chatting With: Kotori"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.axAVI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstChat As System.Windows.Forms.ListBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnCamera As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnEnableDev As System.Windows.Forms.Button
    Friend WithEvents btnSetUsername As System.Windows.Forms.Button
    Friend WithEvents axAVI As AxMSComCtl2.AxAnimation
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents btnrandomiseEMV As System.Windows.Forms.Button
    Friend WithEvents btnsetemv As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblemv As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnconsole As System.Windows.Forms.Button
    Friend WithEvents btndevoff As System.Windows.Forms.Button
    Friend WithEvents btnnote As System.Windows.Forms.Button

End Class
