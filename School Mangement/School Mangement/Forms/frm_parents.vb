'Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Interop.Word
Imports System.Data.SqlClient
Public Class frm_parents
    Public Sub ClearControls()
        Me.txt_id.Text = vbNullString
        Me.txt_NID.Text = vbNullString
        Me.txt_name.Text = vbNullString
        'Me.cmb_studentName.Text = vbNullString
        Me.cmb_gender.Text = vbNullString
        Me.txt_job.Text = vbNullString
        Me.txt_Relative.Text = vbNullString
        Me.txt_phone.Text = vbNullString
        Me.txt_address.Text = vbNullString
        Me.picture_parents.Image = Nothing
    End Sub
    Public Function Max_Record1()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Parent_Id) From Tbl_Parents ", Con)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        loadall("Tbl_Parents", dgv_parents)
        txt_id.Text = Max_Record1() + 1
        ClearControls()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = True
        btn_new.Enabled = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frm_parents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadall("Tbl_Parents", dgv_parents)
        txt_id.Text = Max_Record1() + 1
        'load_cmb_student(cmb_studentName, Me)
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_id.Text = vbNullString Or txt_NID.Text = vbNullString Or txt_name.Text = vbNullString Or cmb_gender.Text = vbNullString Or txt_job.Text = vbNullString Or txt_Relative.Text = vbNullString Or txt_phone.Text = vbNullString Or txt_address.Text = vbNullString Or IsNothing(picture_parents) Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        If txt_NID.TextLength = 12 Then
            'Exit Sub
        Else
            MessageBox.Show("يجب ان يحتوي الرقم الوطني على 12 رقما", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        Insert_Tbl_Parents(txt_id.Text, txt_NID.Text, txt_name.Text, cmb_gender.Text, txt_job.Text, txt_Relative.Text, txt_phone.Text, txt_address.Text, picture_parents)
        loadall("View_parents", dgv_parents)
        ClearControls()
        picture_parents.Image = New PictureBox().Image
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_save.Enabled = False
        btn_new.Enabled = True



    End Sub

    Private Sub cmb_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_gender.SelectedIndexChanged
        'txt_NID.Text = cmb_gender.SelectedIndex + 1 & txt_NID.Text
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
            With picture_parents
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.CenterImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
            Label7.Text = OpenFileDialog1.FileName
        End If


    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Update_Tbl_Parents(txt_id.Text, txt_NID.Text, txt_name.Text, cmb_gender.Text, txt_job.Text, txt_Relative.Text, txt_phone.Text, txt_address.Text, picture_parents)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub dgv_parents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_parents.CellContentClick

    End Sub
    Private Sub dgv_parents_Click(sender As Object, e As EventArgs) Handles dgv_parents.Click
        Try
            With dgv_parents
                Me.txt_id.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.txt_NID.Text = .CurrentRow.Cells(1).Value.ToString()
                Me.txt_name.Text = .CurrentRow.Cells(2).Value.ToString()
                Me.txt_phone.Text = .CurrentRow.Cells(3).Value.ToString()
                Me.cmb_gender.Text = .CurrentRow.Cells(4).Value.ToString()
                Me.txt_job.Text = .CurrentRow.Cells(6).Value.ToString()

                Me.txt_Relative.Text = .CurrentRow.Cells(5).Value.ToString()
                Me.txt_address.Text = .CurrentRow.Cells(7).Value.ToString()
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
        Delete_Tbl_Parents(txt_id.Text)
        loadall("Tbl_Parents", dgv_parents)
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_new.Enabled = True
    End Sub
End Class