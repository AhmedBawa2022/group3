Imports System.Data.SqlClient
Public Class frm_years
    Public Function Max_Record1()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Year_id) From Tbl_Years ", Con)
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
        Me.txt_year_id.Text = vbNullString
        Me.txt_year_name.Text = vbNullString
        Me.Status.Checked = False
    End Sub



    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = False
        btn_exit.Enabled = True
        btn_save.Enabled = True
        ClearControls()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_year_name.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_year_name.Text = vbNullString Then txt_year_name.Focus()
            Exit Sub
        End If
        Update_Tbl_Years(txt_year_id.Text, txt_year_name.Text, Status.Checked)
        loadall("Tbl_Years", dgv_year)
        ClearControls()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_exit.Enabled = True
        btn_new.Enabled = True
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Tbl_Years(False, txt_year_id.Text)
            loadall("Tbl_Years", dgv_year)
            txt_year_id.Text = Max_Record1() + 1
            txt_year_name.Text = vbNullString
            btn_delete.Enabled = False
            btn_edit.Enabled = False
            btn_new.Enabled = True
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_year_name.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_year_name.Text = vbNullString Then txt_year_name.Focus()
            Exit Sub
        End If
        Insert_Tbl_Years(txt_year_id.Text, txt_year_name.Text, Status.Checked)
        loadall("Tbl_Years", dgv_year)
        ClearControls()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_exit.Enabled = True
        btn_new.Enabled = True
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub dgv_year_Click(sender As Object, e As EventArgs) Handles dgv_year.Click
        Try
            With dgv_year
                Me.txt_year_id.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.txt_year_name.Text = .CurrentRow.Cells(1).Value.ToString()
            End With
            btn_delete.Enabled = True
            btn_edit.Enabled = True
            btn_new.Enabled = True
            btn_save.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_years_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadall("Tbl_Years", dgv_year)
        txt_year_id.Text = Max_Record1() + 1
        txt_year_name.Text = vbNullString
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True
    End Sub
End Class