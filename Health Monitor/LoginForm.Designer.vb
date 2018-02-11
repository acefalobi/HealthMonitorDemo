<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.btnLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.checkShowPassword = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txtPassoword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.btnLogin)
        Me.MainPanel.Controls.Add(Me.checkShowPassword)
        Me.MainPanel.Controls.Add(Me.txtPassoword)
        Me.MainPanel.Controls.Add(Me.txtUsername)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainPanel.Location = New System.Drawing.Point(0, 63)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(333, 234)
        Me.MainPanel.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Depth = 0
        Me.btnLogin.Location = New System.Drawing.Point(12, 135)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Primary = True
        Me.btnLogin.Size = New System.Drawing.Size(309, 49)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "L O G I N"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'checkShowPassword
        '
        Me.checkShowPassword.AutoSize = True
        Me.checkShowPassword.Depth = 0
        Me.checkShowPassword.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.checkShowPassword.Location = New System.Drawing.Point(12, 87)
        Me.checkShowPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.checkShowPassword.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.checkShowPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.checkShowPassword.Name = "checkShowPassword"
        Me.checkShowPassword.Ripple = True
        Me.checkShowPassword.Size = New System.Drawing.Size(128, 30)
        Me.checkShowPassword.TabIndex = 2
        Me.checkShowPassword.Text = "Show Password"
        Me.checkShowPassword.UseVisualStyleBackColor = True
        '
        'txtPassoword
        '
        Me.txtPassoword.Depth = 0
        Me.txtPassoword.Hint = "Enter the password..."
        Me.txtPassoword.Location = New System.Drawing.Point(12, 52)
        Me.txtPassoword.MaxLength = 32767
        Me.txtPassoword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassoword.Name = "txtPassoword"
        Me.txtPassoword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassoword.SelectedText = ""
        Me.txtPassoword.SelectionLength = 0
        Me.txtPassoword.SelectionStart = 0
        Me.txtPassoword.Size = New System.Drawing.Size(309, 23)
        Me.txtPassoword.TabIndex = 1
        Me.txtPassoword.TabStop = False
        Me.txtPassoword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Depth = 0
        Me.txtUsername.Hint = "Enter the username..."
        Me.txtUsername.Location = New System.Drawing.Point(12, 12)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(309, 23)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TabStop = False
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 297)
        Me.Controls.Add(Me.MainPanel)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPassoword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents checkShowPassword As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialRaisedButton
End Class
