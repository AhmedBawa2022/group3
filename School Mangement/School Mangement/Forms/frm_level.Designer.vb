<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_level
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
        Me.Status = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_level_specialization = New System.Windows.Forms.ComboBox()
        Me.cmb_year = New System.Windows.Forms.ComboBox()
        Me.txt_level_id = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.dgv_level = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_level_name = New System.Windows.Forms.TextBox()
        CType(Me.dgv_level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(437, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":رقم المرحلة الدراسية"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(431, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":اسم المرحلة الدراسية"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(516, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = ":التخصص"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(480, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":العام الدراسي"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Location = New System.Drawing.Point(355, 234)
        Me.Status.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(49, 21)
        Me.Status.TabIndex = 19
        Me.Status.Text = "نشط"
        Me.Status.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(507, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = ":الحالـــــــة"
        '
        'cmb_level_specialization
        '
        Me.cmb_level_specialization.FormattingEnabled = True
        Me.cmb_level_specialization.Items.AddRange(New Object() {"عام ", "علمي", "أدبي"})
        Me.cmb_level_specialization.Location = New System.Drawing.Point(169, 126)
        Me.cmb_level_specialization.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_level_specialization.Name = "cmb_level_specialization"
        Me.cmb_level_specialization.Size = New System.Drawing.Size(249, 24)
        Me.cmb_level_specialization.TabIndex = 21
        '
        'cmb_year
        '
        Me.cmb_year.FormattingEnabled = True
        Me.cmb_year.Location = New System.Drawing.Point(169, 174)
        Me.cmb_year.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_year.Name = "cmb_year"
        Me.cmb_year.Size = New System.Drawing.Size(249, 24)
        Me.cmb_year.TabIndex = 22
        '
        'txt_level_id
        '
        Me.txt_level_id.Location = New System.Drawing.Point(169, 36)
        Me.txt_level_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_level_id.Name = "txt_level_id"
        Me.txt_level_id.ReadOnly = True
        Me.txt_level_id.Size = New System.Drawing.Size(251, 22)
        Me.txt_level_id.TabIndex = 23
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(329, 442)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(112, 46)
        Me.btn_save.TabIndex = 27
        Me.btn_save.Text = "حفــــــــــظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(169, 442)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(112, 46)
        Me.btn_edit.TabIndex = 26
        Me.btn_edit.Text = "تعديــــــــــل"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(15, 442)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(112, 46)
        Me.btn_delete.TabIndex = 25
        Me.btn_delete.Text = "حــــــــذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(471, 442)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(112, 46)
        Me.btn_new.TabIndex = 24
        Me.btn_new.Text = "جديــــــــــد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'dgv_level
        '
        Me.dgv_level.AllowUserToAddRows = False
        Me.dgv_level.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_level.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_level.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_level.Location = New System.Drawing.Point(7, 277)
        Me.dgv_level.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_level.Name = "dgv_level"
        Me.dgv_level.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv_level.Size = New System.Drawing.Size(576, 145)
        Me.dgv_level.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Level_Id"
        Me.Column1.HeaderText = "رقم المرحلة"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Level_Name"
        Me.Column2.HeaderText = "اسم المرحلة الدراسية"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Level_Specilization"
        Me.Column3.HeaderText = "التخصص"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Year_Name"
        Me.Column4.HeaderText = "العام الدراسي"
        Me.Column4.Name = "Column4"
        '
        'txt_level_name
        '
        Me.txt_level_name.Location = New System.Drawing.Point(169, 82)
        Me.txt_level_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_level_name.Name = "txt_level_name"
        Me.txt_level_name.Size = New System.Drawing.Size(249, 22)
        Me.txt_level_name.TabIndex = 29
        '
        'frm_level
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 501)
        Me.Controls.Add(Me.txt_level_name)
        Me.Controls.Add(Me.dgv_level)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.txt_level_id)
        Me.Controls.Add(Me.cmb_year)
        Me.Controls.Add(Me.cmb_level_specialization)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_level"
        Me.Text = "المرحلة"
        CType(Me.dgv_level, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_level_specialization As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_year As System.Windows.Forms.ComboBox
    Friend WithEvents txt_level_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents dgv_level As System.Windows.Forms.DataGridView
    Friend WithEvents txt_level_name As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class