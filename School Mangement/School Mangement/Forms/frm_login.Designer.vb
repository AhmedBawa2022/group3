<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Simplified Arabic", 12.0!)
        Me.lbl_username.Location = New System.Drawing.Point(267, 66)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(77, 28)
        Me.lbl_username.TabIndex = 0
        Me.lbl_username.Text = "اسم المستخدم"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Simplified Arabic", 12.0!)
        Me.lbl_password.Location = New System.Drawing.Point(273, 168)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(71, 28)
        Me.lbl_password.TabIndex = 1
        Me.lbl_password.Text = "كلمة المرور"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Simplified Arabic", 12.0!)
        Me.txt_password.Location = New System.Drawing.Point(32, 158)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(202, 34)
        Me.txt_password.TabIndex = 2
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Simplified Arabic", 12.0!)
        Me.txt_username.Location = New System.Drawing.Point(32, 55)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(202, 34)
        Me.txt_username.TabIndex = 3
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Simplified Arabic", 12.0!)
        Me.btn_login.Location = New System.Drawing.Point(32, 243)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(85, 42)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "موافق"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Simplified Arabic", 12.0!)
        Me.btn_cancel.Location = New System.Drawing.Point(149, 243)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 42)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "إلغاء"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 308)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Font = New System.Drawing.Font("Simplified Arabic", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frm_login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة تسجيل الدخول"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button

End Class
