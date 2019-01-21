<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.grp_saLogin = New System.Windows.Forms.GroupBox()
        Me.grp_userReset = New System.Windows.Forms.GroupBox()
        Me.grp_clear = New System.Windows.Forms.GroupBox()
        Me.txt_saUsername = New System.Windows.Forms.TextBox()
        Me.txt_saPassword = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_saUsername = New System.Windows.Forms.Label()
        Me.lbl_saPassword = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.grp_saLogin.SuspendLayout()
        Me.grp_userReset.SuspendLayout()
        Me.grp_clear.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_saLogin
        '
        Me.grp_saLogin.Controls.Add(Me.lbl_saPassword)
        Me.grp_saLogin.Controls.Add(Me.lbl_saUsername)
        Me.grp_saLogin.Controls.Add(Me.btn_login)
        Me.grp_saLogin.Controls.Add(Me.txt_saPassword)
        Me.grp_saLogin.Controls.Add(Me.txt_saUsername)
        Me.grp_saLogin.Location = New System.Drawing.Point(13, 13)
        Me.grp_saLogin.Name = "grp_saLogin"
        Me.grp_saLogin.Size = New System.Drawing.Size(201, 160)
        Me.grp_saLogin.TabIndex = 0
        Me.grp_saLogin.TabStop = False
        Me.grp_saLogin.Text = "Database Login"
        '
        'grp_userReset
        '
        Me.grp_userReset.Controls.Add(Me.btn_reset)
        Me.grp_userReset.Controls.Add(Me.lbl_password)
        Me.grp_userReset.Controls.Add(Me.lbl_username)
        Me.grp_userReset.Controls.Add(Me.txt_password)
        Me.grp_userReset.Controls.Add(Me.txt_username)
        Me.grp_userReset.Enabled = False
        Me.grp_userReset.Location = New System.Drawing.Point(221, 13)
        Me.grp_userReset.Name = "grp_userReset"
        Me.grp_userReset.Size = New System.Drawing.Size(166, 102)
        Me.grp_userReset.TabIndex = 1
        Me.grp_userReset.TabStop = False
        Me.grp_userReset.Text = "User Reset"
        '
        'grp_clear
        '
        Me.grp_clear.Controls.Add(Me.btn_clear)
        Me.grp_clear.Enabled = False
        Me.grp_clear.ForeColor = System.Drawing.Color.Red
        Me.grp_clear.Location = New System.Drawing.Point(221, 121)
        Me.grp_clear.Name = "grp_clear"
        Me.grp_clear.Size = New System.Drawing.Size(166, 52)
        Me.grp_clear.TabIndex = 2
        Me.grp_clear.TabStop = False
        Me.grp_clear.Text = "DANGER ZONE"
        '
        'txt_saUsername
        '
        Me.txt_saUsername.Location = New System.Drawing.Point(10, 39)
        Me.txt_saUsername.Name = "txt_saUsername"
        Me.txt_saUsername.Size = New System.Drawing.Size(185, 20)
        Me.txt_saUsername.TabIndex = 0
        '
        'txt_saPassword
        '
        Me.txt_saPassword.Location = New System.Drawing.Point(10, 78)
        Me.txt_saPassword.Name = "txt_saPassword"
        Me.txt_saPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_saPassword.Size = New System.Drawing.Size(185, 20)
        Me.txt_saPassword.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(120, 132)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Location = New System.Drawing.Point(7, 23)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(153, 23)
        Me.btn_clear.TabIndex = 0
        Me.btn_clear.Text = "Clear entire database"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(62, 20)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(98, 20)
        Me.txt_username.TabIndex = 0
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(90, 46)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(70, 20)
        Me.txt_password.TabIndex = 1
        '
        'lbl_saUsername
        '
        Me.lbl_saUsername.AutoSize = True
        Me.lbl_saUsername.Location = New System.Drawing.Point(7, 23)
        Me.lbl_saUsername.Name = "lbl_saUsername"
        Me.lbl_saUsername.Size = New System.Drawing.Size(101, 13)
        Me.lbl_saUsername.TabIndex = 4
        Me.lbl_saUsername.Text = "Sysadmin username"
        '
        'lbl_saPassword
        '
        Me.lbl_saPassword.AutoSize = True
        Me.lbl_saPassword.Location = New System.Drawing.Point(7, 62)
        Me.lbl_saPassword.Name = "lbl_saPassword"
        Me.lbl_saPassword.Size = New System.Drawing.Size(101, 13)
        Me.lbl_saPassword.TabIndex = 5
        Me.lbl_saPassword.Text = "Sysadmin Password"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(6, 23)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(55, 13)
        Me.lbl_username.TabIndex = 2
        Me.lbl_username.Text = "Username"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(6, 49)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(78, 13)
        Me.lbl_password.TabIndex = 3
        Me.lbl_password.Text = "New Password"
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(85, 70)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_reset.TabIndex = 4
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 185)
        Me.Controls.Add(Me.grp_clear)
        Me.Controls.Add(Me.grp_userReset)
        Me.Controls.Add(Me.grp_saLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_main"
        Me.Text = "SoftDevReset"
        Me.grp_saLogin.ResumeLayout(False)
        Me.grp_saLogin.PerformLayout()
        Me.grp_userReset.ResumeLayout(False)
        Me.grp_userReset.PerformLayout()
        Me.grp_clear.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_saLogin As GroupBox
    Friend WithEvents lbl_saPassword As Label
    Friend WithEvents lbl_saUsername As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_saPassword As TextBox
    Friend WithEvents txt_saUsername As TextBox
    Friend WithEvents grp_userReset As GroupBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents grp_clear As GroupBox
    Friend WithEvents btn_clear As Button
End Class
