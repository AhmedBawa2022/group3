Imports System.Data.SqlClient
    Public Class frm_newFanction
        Public dt_monitoring_tbl1 As New DataTable
        Public Sub load_cmb_monitoring1(ByVal cmb_monitoring As ComboBox, ByVal mefrom As Form)
            cmb_monitoring.DataSource = Nothing
            cmb_monitoring.Items.Clear()
            cmb_monitoring.Text = vbNullString
            dt_monitoring_tbl1.Clear()
            Dim cmd As New SqlCommand("select * from Tbl_Monitoring", Con)
            Try
                If Con.State = 1 Then Con.Close()
                Con.Open()
                dt_monitoring_tbl1.Load(cmd.ExecuteReader)
                Con.Close()
                cmd = Nothing

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Con.Close()

            End Try
            If dt_monitoring_tbl1.Rows.Count <> 0 Then
                With cmb_monitoring
                    .DataSource = dt_monitoring_tbl1
                    .DisplayMember = "edu_mon_name"
                    .ValueMember = "edu_mon_id"
                End With
            End If
            If cmb_monitoring.Items.Count > 0 Then cmb_monitoring.SelectedIndex = -1


        End Sub
    Sub FILL_EMPLOYEE()
        cmb_emp.Items.Clear()
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("select * from Tbl_Emp", Con)
        da.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            cmb_emp.Items.Add(dt.Rows(i).Item("Emp_Name"))
        Next
    End Sub

    Public Sub ClearControls()
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
            If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
            'If TypeOf GroupBox2.Controls(I) Is DateTimePicker Then GroupBox1.Controls(I).Text = Date.Now
            If TypeOf GroupBox2.Controls(I) Is ComboBox Then GroupBox2.Controls(I).Text = ""
        Next
    End Sub



    Public Function Max_Record1()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Fun_id) From Tbl_Functional_Data ", Con)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = 0
            Con.Close()
        End Try
        Return Number
    End Function
   


        Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        FILL_EMPLOYEE()
        load_cmb_monitoring1(cmb_monitor, Me)
        load_cmb_Debartment(cmb_department, Me)
        load_cmb_School(cmb_school, Me)
        cmb_IN.Enabled = False
        ClearControls()
        txt_FUN_ID.Text = Max_Record1() + 1

        End Sub

   



        Private Sub frm_newFanction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FILL_EMPLOYEE()
        'load_cmb_monitoring1(cmb_monitor, Me)
        'load_cmb_Debartment(cmb_department, Me)
        'load_cmb_School(cmb_school, Me)
        'cmb_IN.Enabled = False
        'ClearControls()
        'txt_FUN_ID.Text = Max_Record1() + 1
        btn_new_Click(sender, e)
        loadall("View_NewFunction", DataGridView1)
        End Sub

    Private Sub cmb_role_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_role.SelectedIndexChanged
        If cmb_role.SelectedIndex = 0 Then
            cmb_IN.Enabled = True
        End If
    End Sub

    Private Sub cmb_IN_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_IN.SelectedIndexChanged
        If cmb_IN.SelectedIndex = 0 Then
            Exit Sub
        ElseIf cmb_IN.SelectedIndex = 1 Then
            cmb_department.Enabled = True
        Else
            cmb_department.Enabled = True
            cmb_school.Enabled = True

        End If
    End Sub

    Private Sub cmb_emp_Leave(sender As Object, e As EventArgs) Handles cmb_emp.Leave
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM Tbl_Emp where Emp_Name ='" & cmb_emp.Text.Trim & "'", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then

            Dim DR = DT.Rows(0)
            TXT_Functional_Class.Text = DR!Functional_Class
            txt_Emp_IDN.Text = DR!Id_Number
            txt_name.Text = DR!Emp_Name
            txt_Emp_id.Text = DR!Emp_Id
        Else

            MsgBox("لايوجد ")
        End If
    End Sub

    Private Sub cmb_emp_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_emp.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_emp_Leave(sender, e)
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_FUN_ID.Text = vbNullString Or txt_Emp_id.Text = vbNullString Or cmb_emp.Text = vbNullString Or cmb_role.Text = vbNullString Or cmb_IN.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        If cmb_IN.SelectedIndex = 0 Then
            TextBox1.Text = cmb_monitor.Text
        ElseIf cmb_IN.SelectedIndex = 1 Then
            TextBox1.Text = cmb_department.Text
        Else
            TextBox1.Text = cmb_school.Text
        End If
        Insert_Tbl_Functional_Data(txt_FUN_ID.Text, CInt(txt_Emp_id.Text), TextBox1.Text, cmb_role.Text, DateTimePicker1.Value, cmb_IN.SelectedIndex + 1)
        ClearControls()
        loadall("View_NewFunction", DataGridView1)
    End Sub

 
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(6).Value = "إنهاء وظيفة"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(7).Value = "حذف"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = -1 Or DataGridView1.Rows.Count = 0 Then Exit Sub
        Dim COLUMNAME = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If COLUMNAME = "COLMDEND" Then
            If DataGridView1.Rows.Count = 0 Then Exit Sub
            DataGridView1.CurrentRow.Cells(5).Value = Date.Now.ToString
            Update_Tbl_Functional_Data(DataGridView1.CurrentRow.Cells(5).Value, DataGridView1.CurrentRow.Cells(0).Value)
        End If
        If e.ColumnIndex = -1 Or DataGridView1.Rows.Count = 0 Then Exit Sub
        Dim COLUMNAME1 = CType(sender, DataGridView).Columns(e.ColumnIndex).Name
        If COLUMNAME1 = "COLMNDEL" Then
            If DataGridView1.Rows.Count = 0 Then Exit Sub
            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                Delete_Tbl_Functional(DataGridView1.CurrentRow.Cells(0).Value)
                loadall("View_NewFunction", DataGridView1)
            End If
        End If
    End Sub



    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        'Delete_Tbl_Functional(ByVal ID_Position As Int32)
    End Sub
End Class



