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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_monitor = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmb_department = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_Emp_IDN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Emp_id = New System.Windows.Forms.TextBox()
        Me.TXT_Functional_Class = New System.Windows.Forms.TextBox()
        Me.cmb_emp = New System.Windows.Forms.ComboBox()
        Me.cmb_role = New System.Windows.Forms.ComboBox()
        Me.cmb_school = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.cmb_in = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(810, 185)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 17)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "الوظيفة"
        '
        'cmb_monitor
        '
        Me.cmb_monitor.FormattingEnabled = True
        Me.cmb_monitor.Location = New System.Drawing.Point(518, 261)
        Me.cmb_monitor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_monitor.Name = "cmb_monitor"
        Me.cmb_monitor.Size = New System.Drawing.Size(247, 24)
        Me.cmb_monitor.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(802, 266)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 17)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "اسم المراقبة"
        '
        'cmb_department
        '
        Me.cmb_department.Enabled = False
        Me.cmb_department.FormattingEnabled = True
        Me.cmb_department.Location = New System.Drawing.Point(524, 293)
        Me.cmb_department.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_department.Name = "cmb_department"
        Me.cmb_department.Size = New System.Drawing.Size(241, 24)
        Me.cmb_department.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(785, 296)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 17)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "اسم الفرع"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"رقم الموظف ", "اسم الموظف"})
        Me.ComboBox1.Location = New System.Drawing.Point(577, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 24)
        Me.ComboBox1.TabIndex = 50
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column7, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 368)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(838, 181)
        Me.DataGridView1.TabIndex = 49
        '
        'Column1
        '
        Me.Column1.HeaderText = "اسم الموظف"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "الوظيفة "
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle1.NullValue = "لايوجد"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "المراقبة "
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle2.NullValue = "لايوجد"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "الفرع"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle3.NullValue = "لايوجد"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column7.HeaderText = "المدرسة"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = "جاري حالياّ"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "تاريخ التعيين "
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "تاريخ الانتهاء "
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(442, 122)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 17)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "الدرجة الوظيفية"
        '
        'txt_Emp_IDN
        '
        Me.txt_Emp_IDN.Location = New System.Drawing.Point(175, 55)
        Me.txt_Emp_IDN.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Emp_IDN.Name = "txt_Emp_IDN"
        Me.txt_Emp_IDN.ReadOnly = True
        Me.txt_Emp_IDN.Size = New System.Drawing.Size(247, 22)
        Me.txt_Emp_IDN.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "الرقم الوطني"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(542, 113)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(247, 22)
        Me.txt_name.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(796, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "اسم الموظف"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(796, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "رقم الموظف"
        '
        'txt_Emp_id
        '
        Me.txt_Emp_id.Location = New System.Drawing.Point(543, 53)
        Me.txt_Emp_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Emp_id.Name = "txt_Emp_id"
        Me.txt_Emp_id.ReadOnly = True
        Me.txt_Emp_id.Size = New System.Drawing.Size(247, 22)
        Me.txt_Emp_id.TabIndex = 53
        '
        'TXT_Functional_Class
        '
        Me.TXT_Functional_Class.Location = New System.Drawing.Point(175, 117)
        Me.TXT_Functional_Class.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_Functional_Class.Name = "TXT_Functional_Class"
        Me.TXT_Functional_Class.ReadOnly = True
        Me.TXT_Functional_Class.Size = New System.Drawing.Size(247, 22)
        Me.TXT_Functional_Class.TabIndex = 59
        '
        'cmb_emp
        '
        Me.cmb_emp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_emp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_emp.FormattingEnabled = True
        Me.cmb_emp.Location = New System.Drawing.Point(175, 12)
        Me.cmb_emp.Name = "cmb_emp"
        Me.cmb_emp.Size = New System.Drawing.Size(247, 24)
        Me.cmb_emp.TabIndex = 60
        '
        'cmb_role
        '
        Me.cmb_role.FormattingEnabled = True
        Me.cmb_role.Items.AddRange(New Object() {"مدير ", "معلم "})
        Me.cmb_role.Location = New System.Drawing.Point(541, 185)
        Me.cmb_role.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_role.Name = "cmb_role"
        Me.cmb_role.Size = New System.Drawing.Size(247, 24)
        Me.cmb_role.TabIndex = 61
        '
        'cmb_school
        '
        Me.cmb_school.Enabled = False
        Me.cmb_school.FormattingEnabled = True
        Me.cmb_school.Location = New System.Drawing.Point(524, 325)
        Me.cmb_school.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_school.Name = "cmb_school"
        Me.cmb_school.Size = New System.Drawing.Size(247, 24)
        Me.cmb_school.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(808, 330)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "اسم المدرسة"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 85)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(247, 22)
        Me.TextBox1.TabIndex = 64
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(256, 555)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 34)
        Me.btn_delete.TabIndex = 68
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(347, 555)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 34)
        Me.btn_edit.TabIndex = 67
        Me.btn_edit.Text = "تعديل"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(436, 555)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 34)
        Me.btn_save.TabIndex = 66
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(524, 555)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 34)
        Me.btn_new.TabIndex = 65
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'cmb_in
        '
        Me.cmb_in.Enabled = False
        Me.cmb_in.FormattingEnabled = True
        Me.cmb_in.Items.AddRange(New Object() {"مراقبة", "فرع", "مدرسة "})
        Me.cmb_in.Location = New System.Drawing.Point(175, 178)
        Me.cmb_in.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_in.Name = "cmb_in"
        Me.cmb_in.Size = New System.Drawing.Size(247, 24)
        Me.cmb_in.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 185)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "في"
        '
        'frm_newFanction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 615)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_in)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmb_school)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_role)
        Me.Controls.Add(Me.cmb_emp)
        Me.Controls.Add(Me.TXT_Functional_Class)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_Emp_IDN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Emp_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmb_monitor)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmb_department)
        Me.Controls.Add(Me.Label16)
        Me.Name = "frm_newFanction"
        Me.Text = "frm_newFanction"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmb_monitor As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmb_department As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_Emp_IDN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Emp_id As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Functional_Class As System.Windows.Forms.TextBox
    Friend WithEvents cmb_emp As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_role As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_school As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents cmb_in As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
