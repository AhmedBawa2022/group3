Imports System.Data.SqlClient

Public Class frm_subject

    Public DT_Level_Tbl As New DataTable

    Public Sub Load_Cmb_Level(ByVal CMB_Level_Tbl As ComboBox, field As Integer, ByVal Meform As Form)
        CMB_Level_Tbl.DataSource = Nothing
        CMB_Level_Tbl.Items.Clear()
        CMB_Level_Tbl.Text = vbNullString
        DT_Level_Tbl.Clear()
        Dim Cmd As New SqlCommand("Select * From Tbl_Levels  where Year_ID=" & field & " And  Status='True'", Con) '
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            DT_Level_Tbl.Load(Cmd.ExecuteReader)
            con.Close()
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
        If DT_Level_Tbl.Rows.Count <> 0 Then
            With CMB_Level_Tbl
                .DataSource = DT_Level_Tbl
                .DisplayMember = "Level_Name"
                .ValueMember = "Level_Id"
            End With
        End If
        If CMB_Level_Tbl.Items.Count > 0 Then CMB_Level_Tbl.SelectedIndex = 0
    End Sub

    Public Sub load_combox_year(ByVal cmb_parent As ComboBox, ByVal mefrom As Form)
        combox_year.DataSource = Nothing
        combox_year.Items.Clear()
        combox_year.Text = vbNullString
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
            With combox_year
                .DataSource = dt_Tbl_Years
                .DisplayMember = "Year_Name"
                .ValueMember = "Year_id"
            End With
        End If
    End Sub
    Private Sub frm_subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadall("View_Subject", dgv_subject)
        load_combox_year(combox_year, Me)
        btn_save.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True
        btn_delete.Enabled = False

    End Sub
    'Private Sub CmbLevel_DropDown(sender As System.Object, e As System.EventArgs) Handles CmbLevel.DropDown
    '    Load_Cmb_Level(combox_level, combox_year.SelectedValue, Me)
    'End Sub


    'Private Sub Cmb_Class_DropDown(sender As System.Object, e As System.EventArgs) Handles Cmb_Class.DropDown
    '    'Load_Cmb_Class(Cmb_Class, CmbLevel.SelectedValue, Me)
    'End Sub

    'Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

    '    Me.Close()

    'End Sub

    'Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
    '    If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
    '        Exit Sub
    '    Else
    '        DeleteRowFrom_Subject_Tbl(dgv_subject)
    '    End If
    '    loadall("View_Subject", dgv_subject)
    '    ClearText()
    '    btn_save.Enabled = False
    '    btn_edit.Enabled = False
    '    btn_new.Enabled = True
    '    btn_delete.Enabled = False
    'End Sub
    'Public Sub DeleteRowFrom_Subject_Tbl(ByVal DGV_Subject_Tbl As DataGridView)

    '    Dim Position As Integer = DGV_Subject_Tbl.CurrentRow.Index
    '    Dim ID_Position As Integer = DGV_Subject_Tbl.Rows(Position).Cells(0).Value
    '    Dim CmdDelete As New SqlCommand
    '    With CmdDelete
    '        .Connection = Con
    '        .CommandType = CommandType.Text
    '        .CommandText = "Delete  From Subject_Tbl Where Subject_ID = @Subject_ID"
    '        .Parameters.Clear()
    '        .Parameters.AddWithValue("@Subject_ID", SqlDbType.Int).Value = ID_Position
    '    End With
    '    Try
    '        If Con.State = 1 Then Con.Close()
    '        Con.Open()
    '        CmdDelete.ExecuteNonQuery()
    '        Con.Close()
    '        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
    '        CmdDelete = Nothing
    '    Catch ex As Exception
    '        Con.Close()
    '        MsgBox(Err.Description, MsgBoxStyle.Information)
    '    Finally
    '        If Con.State = ConnectionState.Open Then Con.Close()
    '    End Try
    'End Sub


    'Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
    '    If txt_subject_name.Text = vbNullString Or CmbYear.Text = vbNullString Or CmbLevel.Text = vbNullString Or Cmb_Class.Text = vbNullString Or TxtFullMark.Text = vbNullString Or TxtSuccessMark.Text = vbNullString Then
    '        MessageBox.Show(" عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

    '        If txt_subject_name.Text = vbNullString Then txt_subject_name.Focus()
    '        If combox_year.Text = vbNullString Then combox_year.Focus()
    '        If combox_level.Text = vbNullString Then combox_level.Focus()
    '        If combox_class.Text = vbNullString Then combox_class.Focus()

    '        Exit Sub
    '    End If
    '    UpdateRowIn_Subject_Tbl(txt_subject_name.Text, combox_year.SelectedValue, combox_level.SelectedValue, combox_class.SelectedValue, txt_id_subject.Text)
    '    loadall("View_Subject", dgv_subject)
    '    ClearText()
    '    btn_save.Enabled = False
    '    btn_edit.Enabled = False
    '    btn_new.Enabled = True
    '    btn_delete.Enabled = False
    'End Sub

    'Public Sub UpdateRowIn_Subject_Tbl(ByVal TxtSubjectName As String, ByVal CmbYear_ID As Int32, ByVal CmbLevel_ID As Int32, ByVal CmbClass_ID As Int32, ByVal TxtFullMark As Int32, ByVal TxtSuccessMark As Int32, ByVal TxtSubject_IDW As Int32)
    '    Dim CmdUpdate As New SqlCommand
    '    With CmdUpdate
    '        .Connection = Con
    '        .CommandType = CommandType.Text
    '        .CommandText = "Update Subject_Tbl Set SubjectName = @SubjectName , Year_ID = @Year_ID , Level_ID = @Level_ID , Class_ID = @Class_ID  "
    '        .Parameters.Clear()
    '        .Parameters.AddWithValue("@SubjectName", SqlDbType.VarChar).Value = TxtSubjectName
    '        .Parameters.AddWithValue("@Year_ID", SqlDbType.Int).Value = CmbYear_ID
    '        .Parameters.AddWithValue("@Level_ID", SqlDbType.Int).Value = CmbLevel_ID
    '        .Parameters.AddWithValue("@Class_ID", SqlDbType.Int).Value = CmbClass_ID
    '        .Parameters.AddWithValue("@Subject_ID", SqlDbType.Int).Value = TxtSubject_IDW
    '    End With
    '    Try
    '        If Con.State = 1 Then Con.Close()
    '        Con.Open()
    '        CmdUpdate.ExecuteNonQuery()
    '        Con.Close()
    '        MsgBox("تم تحديث السجل بنجاح", MsgBoxStyle.Information, "تحديث")
    '        CmdUpdate = Nothing
    '    Catch ex As Exception
    '        Con.Close()
    '        MsgBox(Err.Description, MsgBoxStyle.Information)
    '    Finally
    '        If Con.State = ConnectionState.Open Then Con.Close()
    '    End Try
    'End Sub

    'Private Sub combox_class_DropDown(sender As System.Object, e As System.EventArgs) Handles combox_class.DropDown
    '    Load_Cmb_Class(combox_class, combox_level.SelectedValue, Me)
    'End Sub

    'Public Sub InsertNewRowIn_Subject_Tbl(ByVal TxtSubject_ID As Int32, ByVal TxtSubjectName As String, ByVal TxtYear_ID As Int32, ByVal TxtLevel_ID As Int32, ByVal TxtClass_ID As Int32)
    '    Dim CmdInsert As New SqlCommand
    '    With CmdInsert
    '        .Connection = Con
    '        .CommandType = CommandType.Text
    '        .CommandText = "Insert Into Subject_Tbl (Subject_ID , SubjectName , Year_ID , Level_ID , Class_ID , FullMark , SuccessMark)values( @Subject_ID ,  @SubjectName ,  @Year_ID ,  @Level_ID ,  @Class_ID)"
    '        .Parameters.Clear()
    '        .Parameters.AddWithValue("@Subject_ID", SqlDbType.Int).Value = txt_id_subject
    '        .Parameters.AddWithValue("@SubjectName", SqlDbType.VarChar).Value = TxtSubjectName
    '        .Parameters.AddWithValue("@Year_ID", SqlDbType.Int).Value = TxtYear_ID
    '        .Parameters.AddWithValue("@Level_ID", SqlDbType.Int).Value = TxtLevel_ID
    '        .Parameters.AddWithValue("@Class_ID", SqlDbType.Int).Value = TxtClass_ID

    '        Try
    '            If Con.State = 1 Then Con.Close()
    '            Con.Open()
    '            CmdInsert.ExecuteNonQuery()
    '            Con.Close()
    '            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
    '            CmdInsert = Nothing
    '        Catch ex As Exception
    '            Con.Close()
    '            MsgBox(Err.Description, MsgBoxStyle.Information)
    '        Finally
    '            If Con.State = ConnectionState.Open Then Con.Close()
    '        End Try
    'End Sub
    'Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

    '    If txt_subject_name.Text = vbNullString Or combox_year.Text = vbNullString Or combox_level.Text = vbNullString Or combox_class.Text = vbNullString Then
    '        MessageBox.Show(" عفواً ، قم بتعبئة كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

    '        If txt_subject_name.Text = vbNullString Then TxtSubjectName.Focus()
    '        If combox_year.Text = vbNullString Then CmbYear.Focus()
    '        If combox_level.Text = vbNullString Then CmbLevel.Focus()
    '        If combox_class.Text = vbNullString Then Cmb_Class.Focus()
    '        Exit Sub
    '    End If

    '    InsertNewRowIn_Subject_Tbl(txt_id_subject.Text, txt_subject_name.Text, combox_year.SelectedValue, combox_level.SelectedValue, combox_class.SelectedValue)
    '    loadall("View_Subject", dgv_subject)
    '    ClearText()
    '    btn_save.Enabled = False
    '    btn_edit.Enabled = False
    '    btn_new.Enabled = True
    '    btn_delete.Enabled = False
    'End Sub

    'Private Sub dgv_subject_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_subject.CellContentClick

    '    Try
    '        With dgv_subject_CellContentClick.CurrentRow
    '            Me.txt_id_subject.Text = .Cells(0).Value.ToString()
    '            Me.txt_subject_name.Text = .Cells(1).Value.ToString()
    '            Me.combox_year.Text = .Cells(2).Value.ToString()
    '            Me.combox_level.Text = .Cells(3).Value.ToString()
    '            Me.combox_class.Text = .Cells(4).Value.ToString()
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub combox_level_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combox_level.SelectedIndexChanged
    '    Load_combox_level(combox_level, combox_year.SelectedValue, Me)

    'End Sub

    'Sub ClearText()
    '    Me.txt_id_subject.Text = vbNullString
    '    Me.txt_subject_name.Text = vbNullString
    '    Me.combox_year.Text = vbNullString
    '    Me.combox_level.Text = vbNullString
    '    Me.combox_class.Text = vbNullString
    'End Sub

    'Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
    '    ClearText()
    '    txt_id_subject.Text = Max_Record("Subject_Tbl", "Subject_ID") + 1
    '    btn_save.Enabled = True
    '    btn_edit.Enabled = False
    '    btn_new.Enabled = False
    '    btn_delete.Enabled = False
    'End Sub

    'Private Sub combox_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combox_year.SelectedIndexChanged

    'End Sub

    'Private Sub combox_class_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combox_class.SelectedIndexChanged
    '    Load_combox_class(combox_class, combox_level.SelectedValue, Me)

    'End Sub
End Class