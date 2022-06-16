<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_monitoring
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
        Me.btn_branch_north = New System.Windows.Forms.Button()
        Me.btn_branch_west = New System.Windows.Forms.Button()
        Me.btn_branch_east = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.الفروعToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.إضافةوتعديلبيناتفرعToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.بحثعنفرعToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.العامالدراسيToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.شؤونالموظفينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.موظفيالمراقبةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مدراءالفروعToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.احصائياتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.المعلمينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الطلابToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.إعداداتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تغييركلمةالسرToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.الصلاحياتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.إدارةالمناطقToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.إدارةالمصارفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.إدارةالمراقباتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_branch_north
        '
        Me.btn_branch_north.Location = New System.Drawing.Point(49, 200)
        Me.btn_branch_north.Name = "btn_branch_north"
        Me.btn_branch_north.Size = New System.Drawing.Size(118, 79)
        Me.btn_branch_north.TabIndex = 0
        Me.btn_branch_north.Text = "الفرع ..."
        Me.btn_branch_north.UseVisualStyleBackColor = True
        '
        'btn_branch_west
        '
        Me.btn_branch_west.Location = New System.Drawing.Point(198, 200)
        Me.btn_branch_west.Name = "btn_branch_west"
        Me.btn_branch_west.Size = New System.Drawing.Size(118, 79)
        Me.btn_branch_west.TabIndex = 1
        Me.btn_branch_west.Text = "الفرع الغربي"
        Me.btn_branch_west.UseVisualStyleBackColor = True
        '
        'btn_branch_east
        '
        Me.btn_branch_east.Location = New System.Drawing.Point(354, 200)
        Me.btn_branch_east.Name = "btn_branch_east"
        Me.btn_branch_east.Size = New System.Drawing.Size(118, 79)
        Me.btn_branch_east.TabIndex = 2
        Me.btn_branch_east.Text = "الفرع الشرقي"
        Me.btn_branch_east.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.الفروعToolStripMenuItem, Me.العامالدراسيToolStripMenuItem, Me.شؤونالموظفينToolStripMenuItem, Me.احصائياتToolStripMenuItem, Me.إعداداتToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(496, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'الفروعToolStripMenuItem
        '
        Me.الفروعToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.إضافةوتعديلبيناتفرعToolStripMenuItem, Me.بحثعنفرعToolStripMenuItem})
        Me.الفروعToolStripMenuItem.Name = "الفروعToolStripMenuItem"
        Me.الفروعToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.الفروعToolStripMenuItem.Text = "الفروع"
        '
        'إضافةوتعديلبيناتفرعToolStripMenuItem
        '
        Me.إضافةوتعديلبيناتفرعToolStripMenuItem.Name = "إضافةوتعديلبيناتفرعToolStripMenuItem"
        Me.إضافةوتعديلبيناتفرعToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.إضافةوتعديلبيناتفرعToolStripMenuItem.Text = "إضافة وتعديل بيانات فرع"
        '
        'بحثعنفرعToolStripMenuItem
        '
        Me.بحثعنفرعToolStripMenuItem.Name = "بحثعنفرعToolStripMenuItem"
        Me.بحثعنفرعToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
        Me.بحثعنفرعToolStripMenuItem.Text = "بحث عن فرع "
        '
        'العامالدراسيToolStripMenuItem
        '
        Me.العامالدراسيToolStripMenuItem.Name = "العامالدراسيToolStripMenuItem"
        Me.العامالدراسيToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.العامالدراسيToolStripMenuItem.Text = "العام الدراسي "
        '
        'شؤونالموظفينToolStripMenuItem
        '
        Me.شؤونالموظفينToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.موظفيالمراقبةToolStripMenuItem, Me.مدراءالفروعToolStripMenuItem})
        Me.شؤونالموظفينToolStripMenuItem.Name = "شؤونالموظفينToolStripMenuItem"
        Me.شؤونالموظفينToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.شؤونالموظفينToolStripMenuItem.Text = "شؤون الموظفين"
        '
        'موظفيالمراقبةToolStripMenuItem
        '
        Me.موظفيالمراقبةToolStripMenuItem.Name = "موظفيالمراقبةToolStripMenuItem"
        Me.موظفيالمراقبةToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.موظفيالمراقبةToolStripMenuItem.Text = "موظفي المراقبة"
        '
        'مدراءالفروعToolStripMenuItem
        '
        Me.مدراءالفروعToolStripMenuItem.Name = "مدراءالفروعToolStripMenuItem"
        Me.مدراءالفروعToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.مدراءالفروعToolStripMenuItem.Text = "مدراء الفروع"
        '
        'احصائياتToolStripMenuItem
        '
        Me.احصائياتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.المعلمينToolStripMenuItem, Me.الطلابToolStripMenuItem})
        Me.احصائياتToolStripMenuItem.Name = "احصائياتToolStripMenuItem"
        Me.احصائياتToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.احصائياتToolStripMenuItem.Text = "احصائيات"
        '
        'المعلمينToolStripMenuItem
        '
        Me.المعلمينToolStripMenuItem.Name = "المعلمينToolStripMenuItem"
        Me.المعلمينToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.المعلمينToolStripMenuItem.Text = "المعلمين "
        '
        'الطلابToolStripMenuItem
        '
        Me.الطلابToolStripMenuItem.Name = "الطلابToolStripMenuItem"
        Me.الطلابToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.الطلابToolStripMenuItem.Text = "الطلاب"
        '
        'إعداداتToolStripMenuItem
        '
        Me.إعداداتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.تغييركلمةالسرToolStripMenuItem, Me.الصلاحياتToolStripMenuItem, Me.إدارةالمناطقToolStripMenuItem, Me.إدارةالمصارفToolStripMenuItem, Me.إدارةالمراقباتToolStripMenuItem})
        Me.إعداداتToolStripMenuItem.Name = "إعداداتToolStripMenuItem"
        Me.إعداداتToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.إعداداتToolStripMenuItem.Text = "إعدادات"
        '
        'تغييركلمةالسرToolStripMenuItem
        '
        Me.تغييركلمةالسرToolStripMenuItem.Name = "تغييركلمةالسرToolStripMenuItem"
        Me.تغييركلمةالسرToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.تغييركلمةالسرToolStripMenuItem.Text = "تغيير كلمة السر"
        '
        'الصلاحياتToolStripMenuItem
        '
        Me.الصلاحياتToolStripMenuItem.Name = "الصلاحياتToolStripMenuItem"
        Me.الصلاحياتToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.الصلاحياتToolStripMenuItem.Text = "الصلاحيات"
        '
        'إدارةالمناطقToolStripMenuItem
        '
        Me.إدارةالمناطقToolStripMenuItem.Name = "إدارةالمناطقToolStripMenuItem"
        Me.إدارةالمناطقToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.إدارةالمناطقToolStripMenuItem.Text = "إدارة المناطق"
        '
        'إدارةالمصارفToolStripMenuItem
        '
        Me.إدارةالمصارفToolStripMenuItem.Name = "إدارةالمصارفToolStripMenuItem"
        Me.إدارةالمصارفToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.إدارةالمصارفToolStripMenuItem.Text = "إدارة المصارف"
        '
        'إدارةالمراقباتToolStripMenuItem
        '
        Me.إدارةالمراقباتToolStripMenuItem.Name = "إدارةالمراقباتToolStripMenuItem"
        Me.إدارةالمراقباتToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.إدارةالمراقباتToolStripMenuItem.Text = "إدارة المراقبات "
        '
        'frm_monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 390)
        Me.Controls.Add(Me.btn_branch_east)
        Me.Controls.Add(Me.btn_branch_west)
        Me.Controls.Add(Me.btn_branch_north)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_monitoring"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "شاشة مراقبة التعليم"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_branch_north As System.Windows.Forms.Button
    Friend WithEvents btn_branch_west As System.Windows.Forms.Button
    Friend WithEvents btn_branch_east As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents الفروعToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إضافةوتعديلبيناتفرعToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents بحثعنفرعToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents العامالدراسيToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents شؤونالموظفينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents احصائياتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إعداداتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents موظفيالمراقبةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents مدراءالفروعToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents المعلمينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents الطلابToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تغييركلمةالسرToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents الصلاحياتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إدارةالمناطقToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إدارةالمصارفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إدارةالمراقباتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
