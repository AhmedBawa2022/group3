<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manger_divition
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Status = New System.Windows.Forms.CheckBox()
        Me.cmb_class = New System.Windows.Forms.ComboBox()
        Me.cmb_level = New System.Windows.Forms.ComboBox()
        Me.cmb_year = New System.Windows.Forms.ComboBox()
        Me.txt_section_name = New System.Windows.Forms.TextBox()
        Me.txt_section_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.dgv_section = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_section, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Controls.Add(Me.cmb_class)
        Me.GroupBox1.Controls.Add(Me.cmb_level)
        Me.GroupBox1.Controls.Add(Me.cmb_year)
        Me.GroupBox1.Controls.Add(Me.txt_section_name)
        Me.GroupBox1.Controls.Add(Me.txt_section_id)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.OrangeRed
        Me.GroupBox1.Location = New System.Drawing.Point(20, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(589, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Status.Location = New System.Drawing.Point(409, 207)
        Me.Status.Margin = New System.Windows.Forms.Padding(2)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(78, 20)
        Me.Status.TabIndex = 11
        Me.Status.Text = "مفعلـــــــــة"
        Me.Status.UseVisualStyleBackColor = True
        '
        'cmb_class
        '
        Me.cmb_class.FormattingEnabled = True
        Me.cmb_class.Location = New System.Drawing.Point(169, 165)
        Me.cmb_class.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_class.Name = "cmb_class"
        Me.cmb_class.Size = New System.Drawing.Size(318, 24)
        Me.cmb_class.TabIndex = 10
        '
        'cmb_level
        '
        Me.cmb_level.FormattingEnabled = True
        Me.cmb_level.Location = New System.Drawing.Point(169, 127)
        Me.cmb_level.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_level.Name = "cmb_level"
        Me.cmb_level.Size = New System.Drawing.Size(318, 24)
        Me.cmb_level.TabIndex = 9
        '
        'cmb_year
        '
        Me.cmb_year.FormattingEnabled = True
        Me.cmb_year.Location = New System.Drawing.Point(169, 89)
        Me.cmb_year.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_year.Name = "cmb_year"
        Me.cmb_year.Size = New System.Drawing.Size(318, 24)
        Me.cmb_year.TabIndex = 8
        '
        'txt_section_name
        '
        Me.txt_section_name.Location = New System.Drawing.Point(169, 53)
        Me.txt_section_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_section_name.Name = "txt_section_name"
        Me.txt_section_name.Size = New System.Drawing.Size(318, 23)
        Me.txt_section_name.TabIndex = 7
        '
        'txt_section_id
        '
        Me.txt_section_id.Location = New System.Drawing.Point(169, 21)
        Me.txt_section_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_section_id.Name = "txt_section_id"
        Me.txt_section_id.ReadOnly = True
        Me.txt_section_id.Size = New System.Drawing.Size(318, 23)
        Me.txt_section_id.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(492, 208)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "الحالـــــة:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(492, 165)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "الصف الدراسي:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(490, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "المرحلة الدراسية:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(492, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "العام الدراسي:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(490, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "اسم الشعبة:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(492, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم الشعبة:"
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btn_exit.Location = New System.Drawing.Point(20, 414)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_exit.Size = New System.Drawing.Size(104, 32)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "خروج"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btn_delete.Location = New System.Drawing.Point(132, 414)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_delete.Size = New System.Drawing.Size(104, 32)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btn_edit.Location = New System.Drawing.Point(268, 414)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_edit.Size = New System.Drawing.Size(104, 32)
        Me.btn_edit.TabIndex = 4
        Me.btn_edit.Text = "تعديل"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(385, 414)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_save.Size = New System.Drawing.Size(104, 32)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "حفظ"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btn_new.Location = New System.Drawing.Point(505, 414)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_new.Size = New System.Drawing.Size(104, 32)
        Me.btn_new.TabIndex = 2
        Me.btn_new.Text = "جديد"
        Me.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'dgv_section
        '
        Me.dgv_section.AllowUserToAddRows = False
        Me.dgv_section.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_section.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_section.Location = New System.Drawing.Point(20, 245)
        Me.dgv_section.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_section.Name = "dgv_section"
        Me.dgv_section.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv_section.RowTemplate.Height = 24
        Me.dgv_section.Size = New System.Drawing.Size(595, 150)
        Me.dgv_section.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Section_ID"
        Me.Column1.HeaderText = "رقم الشعبة"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Section_Name"
        Me.Column2.HeaderText = "اسم الشعبة"
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
        Me.Column4.HeaderText = "المرحلة الدراسية"
        Me.Column4.MaxInputLength = 40000
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ClassName"
        Me.Column5.HeaderText = "الصف الدراسي"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Status"
        Me.Column6.HeaderText = "الحالة"
        Me.Column6.Name = "Column6"
        '
        'frm_manger_divition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 469)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.dgv_section)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_manger_divition"
        Me.Text = "شاشة الشعب"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_section, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Status As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_class As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_level As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_year As System.Windows.Forms.ComboBox
    Friend WithEvents txt_section_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_section_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents dgv_section As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
