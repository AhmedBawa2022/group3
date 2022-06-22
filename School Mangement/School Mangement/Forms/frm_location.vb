Imports System.Data.SqlClient
Public Class frm_location

    Public Function Max_Record1()
        Dim Number As Integer
        Try
            'Select Max(Location_Id) From Tbl_Location
            Dim cmd As New SqlCommand("Select Max(Location_Id) From Tbl_Location ", Con)
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

    Private Sub frm_location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txt_id.Text = Max_Record("Tbl_Location", "Location_Id") + 1
        loadall("Tbl_Location", dgv_Location)
        txt_id.Text = Max_Record1() + 1
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True
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
        If txt_name.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_name.Text = vbNullString Then txt_name.Focus()
            Exit Sub
        End If
        Update_Tbl_Location(txt_id.Text, txt_name.Text)
        loadall("Tbl_Location", dgv_Location)
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
            Delete_Tbl_Location(txt_id.Text)
            loadall("Tbl_Location", dgv_Location)
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_name.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_name.Text = vbNullString Then txt_name.Focus()
            Exit Sub
        End If
        Insert_Tbl_Location(txt_id.Text, txt_name.Text)
        ClearControls()
        loadall("Tbl_Location", dgv_Location)
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_exit.Enabled = True
        btn_new.Enabled = True
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub dgv_Location_Click(sender As Object, e As EventArgs) Handles dgv_Location.Click
        Try
            With dgv_Location
                Me.txt_id.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.txt_name.Text = .CurrentRow.Cells(1).Value.ToString()
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