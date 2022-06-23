Imports System.Data.SqlClient

Public Class frm_bank

    Public Function Max_Record1()

        Dim Number As Integer

        Try


            Dim cmd As New SqlCommand("Select Max(bank_Id) From Tbl_Banks ", Con)

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

        Me.txt_idbank.Text = vbNullString

        Me.txt_namebank.Text = vbNullString

    End Sub


    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        ClearControls()
        txt_idbank.Text = Max_Record1() + 1
        btn_delete.Enabled = False

        btn_edit.Enabled = False

        btn_new.Enabled = False

        btn_exit.Enabled = True

        btn_save.Enabled = True



    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If txt_namebank.Text = vbNullString Then

            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

            If txt_namebank.Text = vbNullString Then txt_namebank.Focus()

            Exit Sub

        End If

        Update_Tbl_Banks(txt_idbank.Text, txt_namebank.Text)

        loadall("Tbl_Banks", dgv_bank)

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

            Delete_Tbl_Banks(txt_idbank.Text)

            loadall("Tbl_Banks", dgv_bank)

            ClearControls()
            txt_idbank.Text = Max_Record1() + 1

        End If

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_namebank.Text = vbNullString Then

            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

            If txt_namebank.Text = vbNullString Then txt_namebank.Focus()

            Exit Sub

        End If

        Insert_Tbl_bank(txt_idbank.Text, txt_namebank.Text)

        ClearControls()

        loadall("Tbl_banks", dgv_bank)

        btn_delete.Enabled = False

        btn_edit.Enabled = False

        btn_exit.Enabled = True

        btn_new.Enabled = True

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        Me.Close()

    End Sub



    Private Sub frm_bank_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadall("Tbl_banks", dgv_bank)

        txt_idbank.Text = Max_Record1() + 1

        btn_delete.Enabled = False

        btn_edit.Enabled = False

        btn_new.Enabled = True
    End Sub


    Private Sub dgv_bank_Click(sender As Object, e As EventArgs) Handles dgv_bank.Click
        Try

            With dgv_bank

                Me.txt_idbank.Text = .CurrentRow.Cells(0).Value.ToString()

                Me.txt_namebank.Text = .CurrentRow.Cells(1).Value.ToString()

            End With

            btn_delete.Enabled = True

            btn_edit.Enabled = True

            btn_new.Enabled = True

            btn_save.Enabled = False

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class
