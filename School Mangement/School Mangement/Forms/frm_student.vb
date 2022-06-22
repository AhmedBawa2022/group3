Imports System.Data.SqlClient

Public Class frm_student
    Public Function Max_Record1()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Student_Id) From Tbl_Students ", Con)
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
        Me.txt_std_id.Text = vbNullString
        Me.txt_location.Text = vbNullString
        Me.txt_name.Text = vbNullString
        Me.txt_NID.Text = vbNullString
        cmb_gender.SelectedIndex = -1
        cmb_parent_name.SelectedIndex = -1
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NID.KeyPress
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "" Then

        Else
            MessageBox.Show("يجب ادخال أرقام فقط ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            txt_NID.Clear()

        End If


    End Sub

    Private Sub frm_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadall("View_Student_info", dgv_student)
        txt_std_id.Text = Max_Record1() + 1
        load_cmb_parentname(cmb_parent_name, Me)
   
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_name.Text = vbNullString Or cmb_parent_name.Text = vbNullString Or cmb_gender.Text = vbNullString Or txt_location.Text = vbNullString Or txt_NID.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_name.Text = vbNullString Then txt_name.Focus()
            If txt_location.Text = vbNullString Then txt_location.Focus()
            If txt_NID.Text = vbNullString Then txt_NID.Focus()
            If cmb_parent_name.Text = vbNullString Then cmb_parent_name.Focus()
            If cmb_gender.Text = vbNullString Then cmb_gender.Focus()
            If txt_NID.TextLength = 12 Then
                'Exit Sub
            Else
                MessageBox.Show("يجب ان يحتوي الرقم الوطني على 12 رقما", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            Exit Sub
        End If
        Insert_Tbl_Students(txt_std_id.Text, txt_name.Text, txt_NID.Text, cmb_parent_name.SelectedValue, dtb_date.Value, cmb_gender.Text, txt_location.Text, picture_student, Status.Checked)
        loadall("View_Student_info", dgv_student)
        ClearControls()
        picture_student.Image = New PictureBox().Image
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_new.Enabled = True
        'MsgBox(dtb_date.Value.Year.ToString())
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
      loadall("View_Student_info", dgv_student)
        txt_std_id.Text = Max_Record1() + 1
        ClearControls()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_new.Enabled = False
    End Sub

    Private Sub cmb_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_gender.SelectedIndexChanged

        txt_NID.Text = cmb_gender.SelectedIndex + 1 & txt_NID.Text
    End Sub

    Private Sub dtb_date_ValueChanged(sender As Object, e As EventArgs) Handles dtb_date.ValueChanged
        txt_NID.Text = txt_NID.Text & dtb_date.Value.Year.ToString()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If txt_name.Text = vbNullString Or cmb_parent_name.Text = vbNullString Or cmb_gender.Text = vbNullString Or txt_location.Text = vbNullString Or txt_NID.Text = vbNullString Then
            MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            If txt_name.Text = vbNullString Then txt_name.Focus()
            If txt_location.Text = vbNullString Then txt_location.Focus()
            If txt_NID.Text = vbNullString Then txt_NID.Focus()
            If cmb_parent_name.Text = vbNullString Then cmb_parent_name.Focus()
            If cmb_gender.Text = vbNullString Then cmb_gender.Focus()
            If txt_NID.TextLength = 12 Then
                'Exit Sub
            Else
                MessageBox.Show("يجب ان يحتوي الرقم الوطني على 12 رقما", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            Exit Sub
        End If

        Update_Tbl_Students(txt_std_id.Text, txt_name.Text, txt_NID.Text, cmb_parent_name.SelectedValue, dtb_date.Value, cmb_gender.Text, txt_location.Text, Status.Checked)
        loadall("View_Student_info", dgv_student)
        ClearControls()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_new.Enabled = True

    End Sub

    Private Sub dgv_student_Click(sender As Object, e As EventArgs) Handles dgv_student.Click
        Try
            With dgv_student
                Me.txt_std_id.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.txt_name.Text = .CurrentRow.Cells(1).Value.ToString()
                Me.cmb_gender.Text = .CurrentRow.Cells(2).Value.ToString()
                Me.cmb_parent_name.Text = .CurrentRow.Cells(3).Value.ToString()
                Me.txt_NID.Text = .CurrentRow.Cells(4).Value.ToString()
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
            Delete_Tbl_Students(False, txt_std_id.Text)
            loadall("View_Student_info", dgv_student)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .InitialDirectory = "C:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 2
        End With

        ' When the user clicks the Open button (DialogResult.OK is the only option;
        ' there is not DialogResult.Open), display the image centered in the 
        ' PictureBox and display the full path of the image.
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            With picture_student
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.CenterImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
            Label7.Text = OpenFileDialog1.FileName
        End If


    End Sub
End Class