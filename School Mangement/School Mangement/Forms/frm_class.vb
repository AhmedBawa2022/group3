Imports System.Data.SqlClient

Public Class frm_class
    Public Function Max_Record1()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Class_ID) From Tbl_Classes ", Con)
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
        Me.txt_class_id.Text = vbNullString
        Me.txt_class_name.Text = vbNullString
        cmb_year.SelectedIndex = -1
        cmb_level.SelectedIndex = -1
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
    Public Sub load_cmb_level(ByVal cmb_parent As ComboBox, ByVal mefrom As Form)
        cmb_level.DataSource = Nothing
        cmb_level.Items.Clear()
        cmb_level.Text = vbNullString
        dt_Tbl_Levels.Clear()
        Dim cmd As New SqlCommand("select * from Tbl_Levels", Con)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            dt_Tbl_Levels.Load(cmd.ExecuteReader)
            Con.Close()
            cmd = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()

        End Try
        If dt_Tbl_Levels.Rows.Count <> 0 Then
            With cmb_level
                .DataSource = dt_Tbl_Levels
                .DisplayMember = "Level_Name"
                .ValueMember = "Level_Id"
            End With
        End If
        If cmb_level.Items.Count > 0 Then cmb_level.SelectedIndex = -1


    End Sub
    Private Sub frm_class_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadall("View_class", dgv_class)
        txt_class_id.Text = Max_Record1() + 1
        txt_class_name.Text = vbNullString
        load_cmb_year(cmb_year, Me)
        load_cmb_level(cmb_level, Me)

        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_class_name.Text = vbNullString Or cmb_year.Text = vbNullString Or cmb_level.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_class_name.Text = vbNullString Then txt_class_name.Focus()
            If cmb_level.Text = vbNullString Then cmb_level.Focus()
            If cmb_year.Text = vbNullString Then cmb_year.Focus()

            Exit Sub
        End If
        Insert_Tbl_Classes(txt_class_id.Text, txt_class_name.Text, cmb_level.SelectedValue, cmb_year.SelectedValue, Status.Checked)
        loadall("View_class", dgv_class)
        ClearControls()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_new.Enabled = True
        Update()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_class_name.Text = vbNullString Or cmb_year.Text = vbNullString Or cmb_level.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_class_name.Text = vbNullString Then txt_class_name.Focus()
            If cmb_level.Text = vbNullString Then cmb_level.Focus()
            If cmb_year.Text = vbNullString Then cmb_year.Focus()
            loadall("View_class", dgv_class)
            ClearControls()
            btn_delete.Enabled = False
            btn_edit.Enabled = False
            btn_save.Enabled = False
            btn_new.Enabled = True

            Exit Sub
        End If
        Update_Tbl_Classes(txt_class_id.Text, txt_class_name.Text, cmb_level.SelectedValue, cmb_year.SelectedValue, Status.Checked)
        loadall("View_class", dgv_class)
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
            Delete_Tbl_Classes(False, txt_class_id.Text)
        End If
    End Sub
    Private Sub dgv_class_Click(sender As Object, e As EventArgs) Handles dgv_class.Click
        Try
            With dgv_class
                Me.txt_class_id.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.txt_class_name.Text = .CurrentRow.Cells(1).Value.ToString()
                Me.cmb_year.Text = .CurrentRow.Cells(2).Value.ToString()
                Me.cmb_level.Text = .CurrentRow.Cells(3).Value.ToString()

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