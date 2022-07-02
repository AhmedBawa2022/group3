<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newFanction
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_emp = New System.Windows.Forms.ComboBox()
        Me.TXT_Functional_Class = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_Emp_IDN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Emp_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmb_IN = New System.Windows.Forms.ComboBox()
        Me.txt_FUN_ID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_role = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_school = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_monitor = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmb_department = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLMDEND = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.COLMNDEL = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column7, Me.Column4, Me.Column5, Me.COLMDEND, Me.COLMNDEL, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 437)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(849, 224)
        Me.DataGridView1.TabIndex = 49
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(51, 19)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(244, 34)
        Me.btn_delete.TabIndex = 68
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(315, 19)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(221, 34)
        Me.btn_save.TabIndex = 66
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(594, 19)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(191, 34)
        Me.btn_new.TabIndex = 65
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmb_emp)
        Me.GroupBox1.Controls.Add(Me.TXT_Functional_Class)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txt_Emp_IDN)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Emp_id)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(838, 181)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الموظف"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 17)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "ابحث"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(748, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "البحث بواسطة"
        '
        'cmb_emp
        '
        Me.cmb_emp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_emp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_emp.FormattingEnabled = True
        Me.cmb_emp.Location = New System.Drawing.Point(76, 29)
        Me.cmb_emp.Name = "cmb_emp"
        Me.cmb_emp.Size = New System.Drawing.Size(247, 24)
        Me.cmb_emp.TabIndex = 85
        '
        'TXT_Functional_Class
        '
        Me.TXT_Functional_Class.Location = New System.Drawing.Point(76, 135)
        Me.TXT_Functional_Class.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_Functional_Class.Name = "TXT_Functional_Class"
        Me.TXT_Functional_Class.ReadOnly = True
        Me.TXT_Functional_Class.Size = New System.Drawing.Size(247, 22)
        Me.TXT_Functional_Class.TabIndex = 84
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(342, 140)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 17)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "الدرجة الوظيفية"
        '
        'txt_Emp_IDN
        '
        Me.txt_Emp_IDN.Location = New System.Drawing.Point(76, 86)
        Me.txt_Emp_IDN.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Emp_IDN.Name = "txt_Emp_IDN"
        Me.txt_Emp_IDN.ReadOnly = True
        Me.txt_Emp_IDN.Size = New System.Drawing.Size(247, 22)
        Me.txt_Emp_IDN.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "الرقم الوطني"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(502, 136)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(235, 22)
        Me.txt_name.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(756, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "اسم الموظف"
        '
        'txt_Emp_id
        '
        Me.txt_Emp_id.Location = New System.Drawing.Point(502, 86)
        Me.txt_Emp_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Emp_id.Name = "txt_Emp_id"
        Me.txt_Emp_id.ReadOnly = True
        Me.txt_Emp_id.Size = New System.Drawing.Size(235, 22)
        Me.txt_Emp_id.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(756, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "رقم الموظف"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"رقم الموظف ", "اسم الموظف"})
        Me.ComboBox1.Location = New System.Drawing.Point(502, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 24)
        Me.ComboBox1.TabIndex = 76
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.cmb_IN)
        Me.GroupBox2.Controls.Add(Me.txt_FUN_ID)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_role)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cmb_school)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmb_monitor)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cmb_department)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(849, 176)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بيانات وظيفية "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(420, 76)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(40, 22)
        Me.TextBox1.TabIndex = 103
        Me.TextBox1.Visible = False
        '
        'cmb_IN
        '
        Me.cmb_IN.FormattingEnabled = True
        Me.cmb_IN.Items.AddRange(New Object() {"مراقبة", "فرع", "مدرسة"})
        Me.cmb_IN.Location = New System.Drawing.Point(82, 22)
        Me.cmb_IN.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_IN.Name = "cmb_IN"
        Me.cmb_IN.Size = New System.Drawing.Size(247, 24)
        Me.cmb_IN.TabIndex = 102
        '
        'txt_FUN_ID
        '
        Me.txt_FUN_ID.Location = New System.Drawing.Point(420, 29)
        Me.txt_FUN_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_FUN_ID.Name = "txt_FUN_ID"
        Me.txt_FUN_ID.ReadOnly = True
        Me.txt_FUN_ID.Size = New System.Drawing.Size(40, 22)
        Me.txt_FUN_ID.TabIndex = 101
        Me.txt_FUN_ID.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 120)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(247, 22)
        Me.DateTimePicker1.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(365, 120)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "تاريخ التعيين "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "في"
        '
        'cmb_role
        '
        Me.cmb_role.FormattingEnabled = True
        Me.cmb_role.Items.AddRange(New Object() {"مدير ", "معلم "})
        Me.cmb_role.Location = New System.Drawing.Point(485, 26)
        Me.cmb_role.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_role.Name = "cmb_role"
        Me.cmb_role.Size = New System.Drawing.Size(263, 24)
        Me.cmb_role.TabIndex = 96
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(773, 29)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 17)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "الوظيفة"
        '
        'cmb_school
        '
        Me.cmb_school.Enabled = False
        Me.cmb_school.FormattingEnabled = True
        Me.cmb_school.Location = New System.Drawing.Point(487, 113)
        Me.cmb_school.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_school.Name = "cmb_school"
        Me.cmb_school.Size = New System.Drawing.Size(263, 24)
        Me.cmb_school.TabIndex = 94
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(758, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "اسم المدرسة"
        '
        'cmb_monitor
        '
        Me.cmb_monitor.FormattingEnabled = True
        Me.cmb_monitor.Location = New System.Drawing.Point(485, 74)
        Me.cmb_monitor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_monitor.Name = "cmb_monitor"
        Me.cmb_monitor.Size = New System.Drawing.Size(263, 24)
        Me.cmb_monitor.TabIndex = 92
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(762, 77)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 17)
        Me.Label18.TabIndex = 91
        Me.Label18.Text = "اسم المراقبة"
        '
        'cmb_department
        '
        Me.cmb_department.Enabled = False
        Me.cmb_department.FormattingEnabled = True
        Me.cmb_department.Location = New System.Drawing.Point(81, 74)
        Me.cmb_department.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_department.Name = "cmb_department"
        Me.cmb_department.Size = New System.Drawing.Size(247, 24)
        Me.cmb_department.TabIndex = 90
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(365, 77)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 17)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "اسم الفرع"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Fun_id"
        Me.Column6.HeaderText = "رقم الوظيفة"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Emp_Name"
        Me.Column1.HeaderText = "اسم الموظف"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Role"
        Me.Column2.HeaderText = "الوظيفة "
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Enterprise_Name"
        DataGridViewCellStyle5.NullValue = "لايوجد"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.HeaderText = "مكان التعيين"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Function_Date"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = "جاري حالياّ"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.HeaderText = "تاريخ التعيين "
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "End_Date"
        Me.Column5.HeaderText = "تاريخ الانتهاء "
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'COLMDEND
        '
        Me.COLMDEND.HeaderText = "...."
        Me.COLMDEND.Name = "COLMDEND"
        Me.COLMDEND.ReadOnly = True
        '
        'COLMNDEL
        '
        Me.COLMNDEL.HeaderText = "...."
        Me.COLMNDEL.Name = "COLMNDEL"
        Me.COLMNDEL.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Enterprise_Tybe"
        Me.Column3.HeaderText = "نوع المؤسسة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'frm_newFanction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(867, 670)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frm_newFanction"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة وظيفة جديدة "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_emp As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_Functional_Class As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_Emp_IDN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Emp_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_FUN_ID As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_role As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmb_school As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_monitor As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmb_department As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmb_IN As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLMDEND As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents COLMNDEL As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
