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
        'Sub FILL_EMPLOYEE()
        '    cmb_emp.Items.Clear()
        '    Dim dt As New DataTable
        '    Dim da As New SqlClient.SqlDataAdapter("select * from Tbl_Emp", Con)
        '    da.Fill(dt)
        '    For i = 0 To dt.Rows.Count - 1
        '        cmb_emp.Items.Add(dt.Rows(i).Item("Emp_Name"))
        '    Next
        'End Sub

        'Private Sub frm_newFanction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    FILL_EMPLOYEE()

        'End Sub

        Private Sub cmb_emp_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_emp.KeyDown
            If e.KeyCode = Keys.Enter Then
                cmb_emp_Leave(sender, e)
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

        Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_role.SelectedIndexChanged
            If cmb_role.SelectedIndex = 0 Then
                cmb_in.Enabled = True
            End If
        End Sub

        Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        End Sub

        Private Sub cmb_monitor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_monitor.SelectedIndexChanged

        End Sub

        Private Sub cmb_in_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_in.SelectedIndexChanged
            If cmb_in.SelectedIndex = 0 Then
                Exit Sub
            ElseIf cmb_in.SelectedIndex = 1 Then
                cmb_department.Enabled = True
            Else
                cmb_department.Enabled = True
                cmb_school.Enabled = True

            End If
        End Sub

        Private Sub frm_newFanction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FILL_EMPLOYEE(cmb_emp, Me)
        load_cmb_monitoring1(cmb_monitor, Me)
            load_cmb_Debartment(cmb_department, Me)
            load_cmb_School(cmb_school, Me)

        End Sub
    End Class