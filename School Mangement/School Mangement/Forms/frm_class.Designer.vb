<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_class
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.cmb_level = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.cmb_year = New System.Windows.Forms.ComboBox()
        Me.txt_class_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_class = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.CheckBox()
        Me.txt_class_name = New System.Windows.Forms.TextBox()
        CType(Me.dgv_class, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(635, 452)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(631, 398)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 17)
        Me.Label8.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(643, 351)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(643, 284)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "الحالة"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(61, 574)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 28)
        Me.btn_exit.TabIndex = 33
        Me.btn_exit.Text = "خروج"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(204, 574)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(100, 28)
        Me.btn_edit.TabIndex = 32
        Me.btn_edit.Text = "تعديل"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(348, 574)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(100, 28)
        Me.btn_delete.TabIndex = 31
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(489, 574)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 28)
        Me.btn_save.TabIndex = 30
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'cmb_level
        '
        Me.cmb_level.FormattingEnabled = True
        Me.cmb_level.Location = New System.Drawing.Point(73, 217)
        Me.cmb_level.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_level.Name = "cmb_level"
        Me.cmb_level.Size = New System.Drawing.Size(515, 24)
        Me.cmb_level.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(628, 226)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "اسم المرحلة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(597, 170)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "رقم العام الدراسي"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(639, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "اسم الصف"
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(621, 574)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(100, 28)
        Me.btn_new.TabIndex = 24
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'cmb_year
        '
        Me.cmb_year.FormattingEnabled = True
        Me.cmb_year.Location = New System.Drawing.Point(73, 166)
        Me.cmb_year.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_year.Name = "cmb_year"
        Me.cmb_year.Size = New System.Drawing.Size(515, 24)
        Me.cmb_year.TabIndex = 23
        '
        'txt_class_id
        '
        Me.txt_class_id.Location = New System.Drawing.Point(73, 48)
        Me.txt_class_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_class_id.Name = "txt_class_id"
        Me.txt_class_id.ReadOnly = True
        Me.txt_class_id.Size = New System.Drawing.Size(515, 22)
        Me.txt_class_id.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(645, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "رقم الصف"
        '
        'dgv_class
        '
        Me.dgv_class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_class.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_class.Location = New System.Drawing.Point(16, 335)
        Me.dgv_class.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_class.Name = "dgv_class"
        Me.dgv_class.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv_class.Size = New System.Drawing.Size(699, 219)
        Me.dgv_class.TabIndex = 41
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Class_ID"
        Me.Column1.HeaderText = "رقم الصف"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ClassName"
        Me.Column2.HeaderText = "اسم الصف"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Year_Name"
        Me.Column3.HeaderText = "العام الدراسي"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Level_Name"
        Me.Column4.HeaderText = "المرحلة"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Status"
        Me.Column5.HeaderText = "الحالة"
        Me.Column5.Name = "Column5"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(571, 286)
        Me.Status.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(18, 17)
        Me.Status.TabIndex = 42
        Me.Status.UseVisualStyleBackColor = True
        '
        'txt_class_name
        '
        Me.txt_class_name.Location = New System.Drawing.Point(73, 106)
        Me.txt_class_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_class_name.Name = "txt_class_name"
        Me.txt_class_name.Size = New System.Drawing.Size(516, 22)
        Me.txt_class_name.TabIndex = 43
        '
        'frm_class
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 617)
        Me.Controls.Add(Me.txt_class_name)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.dgv_class)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.cmb_level)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.cmb_year)
        Me.Controls.Add(Me.txt_class_id)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_class"
        Me.Text = " الصف"
        CType(Me.dgv_class, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents cmb_level As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents cmb_year As System.Windows.Forms.ComboBox
    Friend WithEvents txt_class_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_class As System.Windows.Forms.DataGridView
    Friend WithEvents Status As System.Windows.Forms.CheckBox
    Friend WithEvents txt_class_name As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
