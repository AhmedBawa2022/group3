Imports System.Data.SqlClient
Public Class frm_manager_branchs

    Public Function Max_Record1()
        Dim Number As Integer
        Try
            'Select Max(Debartment_Id) From Tbl_Debartments
            Dim cmd As New SqlCommand("Select Max(Debartment_Id) From Tbl_Debartments ", Con)
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
    Public Sub ClearControls()
        Me.txt_id.Text = vbNullString
        Me.txt_name.Text = vbNullString
    End Sub
    Private Sub frm_manager_branchs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txt_id.Text = Max_Record("Tbl_Debartments", "Debartment_Id") + 1
        loadall("View_Debartment", dgv_Branch)
        txt_id.Text = Max_Record1() + 1
        load_cmb_monitoring(cmb_monitoring, Me)
        load_cmb_Manager(cmb_manager, Me)
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_name.Text = vbNullString Or cmb_monitoring.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_name.Text = vbNullString Then txt_name.Focus()
            If cmb_monitoring.Text = vbNullString Then cmb_monitoring.Focus()
            Exit Sub
        End If
        Insert_Tbl_Branch(txt_id.Text, txt_name.Text, cmb_manager.SelectedValue, cmb_monitoring.SelectedValue)
        ClearControls()
        loadall("View_Debartment", dgv_Branch)
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_name.Text = vbNullString Or cmb_monitoring.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_name.Text = vbNullString Then txt_name.Focus()
            If cmb_monitoring.Text = vbNullString Then cmb_monitoring.Focus()
            Exit Sub
        End If
        Update_Tbl_Debartments(txt_id.Text, txt_name.Text, cmb_manager.SelectedValue, cmb_monitoring.SelectedValue)
        loadall("View_Debartment", dgv_Branch)
        ClearControls()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_new.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Branch.CellContentClick


    End Sub

    Private Sub dgv_Branch_Click(sender As Object, e As EventArgs) Handles dgv_Branch.Click
        Try
            With dgv_Branch
                Me.txt_id.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.txt_name.Text = .CurrentRow.Cells(1).Value.ToString()
                Me.cmb_monitoring.Text = .CurrentRow.Cells(2).Value.ToString()
                Me.cmb_manager.Text = .CurrentRow.Cells(3).Value.ToString()

            End With
            btn_delete.Enabled = True
            btn_edit.Enabled = True
            btn_new.Enabled = True
            btn_save.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Tbl_Debartments(txt_id.Text)
            loadall("View_Debartment", dgv_Branch)
        End If

    End Sub
End Class