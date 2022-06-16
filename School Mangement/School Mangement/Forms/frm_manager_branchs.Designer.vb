<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manager_branchs
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
        Me.cmb_monitoring = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.الفروع = New System.Windows.Forms.GroupBox()
        Me.dgv_Branch = New System.Windows.Forms.DataGridView()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.cmb_manager = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.الفروع.SuspendLayout()
        CType(Me.dgv_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_manager)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_monitoring)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات"
        '
        'cmb_monitoring
        '
        Me.cmb_monitoring.FormattingEnabled = True
        Me.cmb_monitoring.Location = New System.Drawing.Point(136, 124)
        Me.cmb_monitoring.Name = "cmb_monitoring"
        Me.cmb_monitoring.Size = New System.Drawing.Size(323, 24)
        Me.cmb_monitoring.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(520, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "المراقبة"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(136, 39)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(323, 22)
        Me.txt_id.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(136, 86)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(323, 22)
        Me.txt_name.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(520, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "اسم الفرع"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(520, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "رقم الفرع"
        '
        'الفروع
        '
        Me.الفروع.Controls.Add(Me.dgv_Branch)
        Me.الفروع.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.الفروع.Location = New System.Drawing.Point(12, 217)
        Me.الفروع.Name = "الفروع"
        Me.الفروع.Size = New System.Drawing.Size(606, 207)
        Me.الفروع.TabIndex = 1
        Me.الفروع.TabStop = False
        Me.الفروع.Text = "الفروع"
        '
        'dgv_Branch
        '
        Me.dgv_Branch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Branch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Branch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_Branch.Location = New System.Drawing.Point(0, 21)
        Me.dgv_Branch.Name = "dgv_Branch"
        Me.dgv_Branch.RowTemplate.Height = 24
        Me.dgv_Branch.Size = New System.Drawing.Size(594, 180)
        Me.dgv_Branch.TabIndex = 0
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(456, 439)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(103, 48)
        Me.btn_new.TabIndex = 0
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(317, 439)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(103, 48)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(175, 439)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(103, 48)
        Me.btn_edit.TabIndex = 2
        Me.btn_edit.Text = "تعديل"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(33, 439)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(103, 48)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'cmb_manager
        '
        Me.cmb_manager.FormattingEnabled = True
        Me.cmb_manager.Location = New System.Drawing.Point(136, 169)
        Me.cmb_manager.Name = "cmb_manager"
        Me.cmb_manager.Size = New System.Drawing.Size(323, 24)
        Me.cmb_manager.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(520, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "اسم المدير"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Debartment_Id"
        Me.Column1.HeaderText = "رقم الفرع"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Debartment_Name"
        Me.Column2.HeaderText = "اسم الفرع "
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Edu_Mon_Name"
        Me.Column3.HeaderText = "اسم المراقبة"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Emp_Name"
        Me.Column4.HeaderText = "اسم المدير "
        Me.Column4.Name = "Column4"
        '
        'frm_manager_branchs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 499)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.الفروع)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_manager_branchs"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "شاشة إدارة الفروع"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.الفروع.ResumeLayout(False)
        CType(Me.dgv_Branch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents الفروع As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Branch As System.Windows.Forms.DataGridView
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_monitoring As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_manager As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
