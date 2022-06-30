<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_subject
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id_subject = New System.Windows.Forms.TextBox()
        Me.txt_subject_name = New System.Windows.Forms.TextBox()
        Me.dgv_subject = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.combox_year = New System.Windows.Forms.ComboBox()
        Me.combox_level = New System.Windows.Forms.ComboBox()
        Me.combox_class = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_subject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(515, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم المادة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(518, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "اسم المادة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(539, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "السنة"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(529, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "المرحلة"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(537, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "الصف"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(496, 228)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(54, 20)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "الحالة"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(430, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "مفعلة"
        '
        'txt_id_subject
        '
        Me.txt_id_subject.Location = New System.Drawing.Point(34, 37)
        Me.txt_id_subject.Name = "txt_id_subject"
        Me.txt_id_subject.ReadOnly = True
        Me.txt_id_subject.Size = New System.Drawing.Size(458, 22)
        Me.txt_id_subject.TabIndex = 7
        '
        'txt_subject_name
        '
        Me.txt_subject_name.Location = New System.Drawing.Point(34, 71)
        Me.txt_subject_name.Name = "txt_subject_name"
        Me.txt_subject_name.Size = New System.Drawing.Size(458, 22)
        Me.txt_subject_name.TabIndex = 8
        '
        'dgv_subject
        '
        Me.dgv_subject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_subject.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_subject.Location = New System.Drawing.Point(12, 247)
        Me.dgv_subject.Name = "dgv_subject"
        Me.dgv_subject.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv_subject.Size = New System.Drawing.Size(559, 150)
        Me.dgv_subject.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "رقم المادة"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "اسم المادة"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "السنة"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "المرحلة "
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "الصف"
        Me.Column5.Name = "Column5"
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(496, 419)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 13
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(388, 419)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 14
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(264, 419)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 15
        Me.btn_edit.Text = "تعديل"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(153, 419)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 16
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(34, 419)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 17
        Me.btn_exit.Text = "خروج"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'combox_year
        '
        Me.combox_year.FormattingEnabled = True
        Me.combox_year.Location = New System.Drawing.Point(34, 109)
        Me.combox_year.Name = "combox_year"
        Me.combox_year.Size = New System.Drawing.Size(458, 24)
        Me.combox_year.TabIndex = 18
        '
        'combox_level
        '
        Me.combox_level.FormattingEnabled = True
        Me.combox_level.Location = New System.Drawing.Point(34, 144)
        Me.combox_level.Name = "combox_level"
        Me.combox_level.Size = New System.Drawing.Size(458, 24)
        Me.combox_level.TabIndex = 19
        '
        'combox_class
        '
        Me.combox_class.FormattingEnabled = True
        Me.combox_class.Location = New System.Drawing.Point(34, 188)
        Me.combox_class.Name = "combox_class"
        Me.combox_class.Size = New System.Drawing.Size(458, 24)
        Me.combox_class.TabIndex = 20
        '
        'frm_subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 459)
        Me.Controls.Add(Me.combox_class)
        Me.Controls.Add(Me.combox_level)
        Me.Controls.Add(Me.combox_year)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.dgv_subject)
        Me.Controls.Add(Me.txt_subject_name)
        Me.Controls.Add(Me.txt_id_subject)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_subject"
        Me.Text = "شاشة المواد"
        CType(Me.dgv_subject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_id_subject As System.Windows.Forms.TextBox
    Friend WithEvents txt_subject_name As System.Windows.Forms.TextBox
    Friend WithEvents dgv_subject As System.Windows.Forms.DataGridView
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents combox_year As System.Windows.Forms.ComboBox
    Friend WithEvents combox_level As System.Windows.Forms.ComboBox
    Friend WithEvents combox_class As System.Windows.Forms.ComboBox
End Class
