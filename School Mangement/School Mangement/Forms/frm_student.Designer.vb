<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_student
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_std_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_NID = New System.Windows.Forms.TextBox()
        Me.picture_student = New System.Windows.Forms.PictureBox()
        Me.dtb_date = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.CheckBox()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_student = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_gender = New System.Windows.Forms.ComboBox()
        Me.cmb_parent_name = New System.Windows.Forms.ComboBox()
        CType(Me.picture_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(820, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":رقم الطالب"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(822, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":اسم الطالب"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(822, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":تاريخ الميلاد"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "الصورة الشخصية"
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(654, 33)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(172, 45)
        Me.btn_new.TabIndex = 8
        Me.btn_new.Text = "جديــــــــــد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(272, 33)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(154, 45)
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.Text = "حــــــــذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(69, 33)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(176, 45)
        Me.btn_edit.TabIndex = 11
        Me.btn_edit.Text = "تعديــــــــــل"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(447, 33)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(172, 45)
        Me.btn_save.TabIndex = 12
        Me.btn_save.Text = "حفــــــــــظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_std_id
        '
        Me.txt_std_id.Location = New System.Drawing.Point(570, 23)
        Me.txt_std_id.Name = "txt_std_id"
        Me.txt_std_id.ReadOnly = True
        Me.txt_std_id.Size = New System.Drawing.Size(233, 22)
        Me.txt_std_id.TabIndex = 13
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(570, 83)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(233, 22)
        Me.txt_name.TabIndex = 14
        '
        'txt_NID
        '
        Me.txt_NID.Location = New System.Drawing.Point(570, 141)
        Me.txt_NID.Name = "txt_NID"
        Me.txt_NID.Size = New System.Drawing.Size(233, 22)
        Me.txt_NID.TabIndex = 15
        '
        'picture_student
        '
        Me.picture_student.Location = New System.Drawing.Point(35, 23)
        Me.picture_student.Name = "picture_student"
        Me.picture_student.Size = New System.Drawing.Size(125, 140)
        Me.picture_student.TabIndex = 18
        Me.picture_student.TabStop = False
        '
        'dtb_date
        '
        Me.dtb_date.Location = New System.Drawing.Point(570, 203)
        Me.dtb_date.Name = "dtb_date"
        Me.dtb_date.Size = New System.Drawing.Size(234, 22)
        Me.dtb_date.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(820, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = ":الرقم الوطني"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Location = New System.Drawing.Point(418, 206)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(49, 21)
        Me.Status.TabIndex = 25
        Me.Status.Text = "نشط"
        Me.Status.UseVisualStyleBackColor = True
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(233, 83)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(233, 22)
        Me.txt_location.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(487, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = ":الحالـــــــة"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(487, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = ":عنوان السكن"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(487, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = ":اسم ولي الامر"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_new)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 542)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(877, 100)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'dgv_student
        '
        Me.dgv_student.AllowUserToAddRows = False
        Me.dgv_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_student.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_student.Location = New System.Drawing.Point(12, 255)
        Me.dgv_student.Name = "dgv_student"
        Me.dgv_student.RowTemplate.Height = 24
        Me.dgv_student.Size = New System.Drawing.Size(887, 282)
        Me.dgv_student.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Student_Id"
        Me.Column1.HeaderText = "رقم الطالب "
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Student_Name"
        Me.Column2.HeaderText = "اسم الطالب "
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Gender"
        Me.Column3.HeaderText = "الجنس"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Parent_Name"
        Me.Column4.HeaderText = "اسم ولي الأمر "
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Student_NID"
        Me.Column5.HeaderText = "الرقم الوطني"
        Me.Column5.Name = "Column5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(483, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "الجنس"
        '
        'cmb_gender
        '
        Me.cmb_gender.FormattingEnabled = True
        Me.cmb_gender.Items.AddRange(New Object() {"ذكر ", "أنثى"})
        Me.cmb_gender.Location = New System.Drawing.Point(234, 144)
        Me.cmb_gender.Name = "cmb_gender"
        Me.cmb_gender.Size = New System.Drawing.Size(233, 24)
        Me.cmb_gender.TabIndex = 30
        '
        'cmb_parent_name
        '
        Me.cmb_parent_name.FormattingEnabled = True
        Me.cmb_parent_name.Location = New System.Drawing.Point(233, 21)
        Me.cmb_parent_name.Name = "cmb_parent_name"
        Me.cmb_parent_name.Size = New System.Drawing.Size(233, 24)
        Me.cmb_parent_name.TabIndex = 31
        '
        'frm_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 664)
        Me.Controls.Add(Me.cmb_parent_name)
        Me.Controls.Add(Me.cmb_gender)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgv_student)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtb_date)
        Me.Controls.Add(Me.picture_student)
        Me.Controls.Add(Me.txt_NID)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_std_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_student"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "الطلبة"
        CType(Me.picture_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_std_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_NID As System.Windows.Forms.TextBox
    Friend WithEvents picture_student As System.Windows.Forms.PictureBox
    Friend WithEvents dtb_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.CheckBox
    Friend WithEvents txt_location As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_student As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_gender As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_parent_name As System.Windows.Forms.ComboBox

End Class
