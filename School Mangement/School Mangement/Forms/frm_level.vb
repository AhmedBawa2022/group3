Imports System.Data.SqlClient
Public Class frm_level

    Public Function Max_Record1()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Level_Id) From Tbl_Levels ", Con)
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
        Me.txt_level_id.Text = vbNullString
        Me.txt_level_name.Text = vbNullString
        cmb_level_specialization.SelectedIndex = -1
        cmb_year.SelectedIndex = -1
    End Sub
    Public Sub load_cmb_year(ByVal cmb_parent As ComboBox, ByVal mefrom As Form)
        cmb_year.DataSource = Nothing
        cmb_year.Items.Clear()
        cmb_year.Text = vbNullString
        dt_Tbl_Years.Clear()
        Dim cmd As New SqlCommand("select * from Tbl_Years", Con)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            dt_Tbl_Years.Load(cmd.ExecuteReader)
            Con.Close()
            cmd = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()

        End Try
        If dt_Tbl_Years.Rows.Count <> 0 Then
            With cmb_parent
                .DataSource = dt_Tbl_Years
                .DisplayMember = "Year_Name"
                .ValueMember = "Year_id"
            End With
        End If
        If cmb_parent.Items.Count > 0 Then cmb_parent.SelectedIndex = -1


    End Sub


    Private Sub frm_level_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadallStatus("View_level", dgv_level)
        txt_level_id.Text = Max_Record1() + 1
        txt_level_name.Text = vbNullString
        load_cmb_year(cmb_year, Me)
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_level_name.Text = vbNullString Or cmb_year.Text = vbNullString Or cmb_level_specialization.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_level_name.Text = vbNullString Then txt_level_name.Focus()
            If cmb_level_specialization.Text = vbNullString Then cmb_level_specialization.Focus()
            If cmb_year.Text = vbNullString Then cmb_year.Focus()

            Exit Sub
        End If
        Insert_Tbl_Levels(txt_level_id.Text, txt_level_name.Text, cmb_level_specialization.Text, cmb_year.SelectedValue, Status.Checked)
        loadallStatus("View_level", dgv_level)
        ClearControls()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_new.Enabled = True
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_level_name.Text = vbNullString Or cmb_year.Text = vbNullString Or cmb_level_specialization.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_level_name.Text = vbNullString Then txt_level_name.Focus()
            If cmb_level_specialization.Text = vbNullString Then cmb_level_specialization.Focus()
            If cmb_year.Text = vbNullString Then cmb_year.Focus()

            Exit Sub
        End If

        Update_Tbl_Levels(txt_level_id.Text, txt_level_name.Text, cmb_level_specialization.Text, cmb_year.SelectedValue, Status.Checked)
        loadallStatus("View_level", dgv_level)
        ClearControls()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_new.Enabled = True

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Tbl_Levels(False, txt_level_id.Text)
            loadallStatus("View_level", dgv_level)
        End If
    End Sub
    Private Sub dgv_level_Click(sender As Object, e As EventArgs) Handles dgv_level.Click
        Try
            With dgv_level
                Me.txt_level_id.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.txt_level_name.Text = .CurrentRow.Cells(1).Value.ToString()
                Me.cmb_level_specialization.Text = .CurrentRow.Cells(2).Value.ToString()
                Me.cmb_year.Text = .CurrentRow.Cells(3).Value.ToString()
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