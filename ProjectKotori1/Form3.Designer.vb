<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lstChat = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.Black
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(0, 489)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(648, 13)
        Me.txtUser.TabIndex = 0
        '
        'lstChat
        '
        Me.lstChat.BackColor = System.Drawing.Color.Black
        Me.lstChat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstChat.ForeColor = System.Drawing.Color.White
        Me.lstChat.FormattingEnabled = True
        Me.lstChat.Location = New System.Drawing.Point(13, 13)
        Me.lstChat.Name = "lstChat"
        Me.lstChat.Size = New System.Drawing.Size(623, 468)
        Me.lstChat.TabIndex = 1
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(648, 504)
        Me.Controls.Add(Me.lstChat)
        Me.Controls.Add(Me.txtUser)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "ConsoleVersion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lstChat As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
