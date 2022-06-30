Imports System.Data.SqlClient
Public Class frm_employees
    Public Sub ClearControls()
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
            If TypeOf GroupBox1.Controls(I) Is DateTimePicker Then GroupBox1.Controls(I).Text = Date.Now
            If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next
    End Sub

    Public Sub TXTNumricFormat(ByVal e As KeyPressEventArgs, ByVal txt As TextBox)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("يجب ادخال أرقام فقط ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            TXT_IDN.Clear()

        End If

    End Sub

    Public Function Max_Record1()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Emp_Id) From Tbl_Emp ", Con)
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

    Private Sub frm_employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        loadall("View_Emp", dgv_emp)
        TXT_EMP_ID.Text = Max_Record1() + 1
        load_cmb_Bank(CMB_BANK, Me)
        BTN_DELETE.Enabled = False
        BTN_EDIT.Enabled = False
        BTN_NEW.Enabled = True
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        ClearControls()
        TXT_EMP_ID.Text = Max_Record1() + 1
        load_cmb_Bank(CMB_BANK, Me)
        BTN_DELETE.Enabled = False
        BTN_EDIT.Enabled = False
        BTN_SAVE.Enabled = True

    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then
                If GroupBox1.Controls(I).Text = vbNullString Then
                    MessageBox.Show("عفوا,قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    If GroupBox1.Controls(I).Text = vbNullString Then GroupBox1.Controls(I).Focus()
                    Exit Sub
                End If
            End If
        Next
        If TXT_IDN.TextLength <> 12 Then
            MessageBox.Show("يجب ان يحتوي الرقم الوطني على 12 رقما", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        'End If

        Insert_Tbl_Emp(TXT_EMP_ID.Text, TXT_EMPNAME.Text, TXT_IDN.Text, CMB_GENDER.Text, DateTimePicker1.Value, TXT_LOCATION.Text, TXT_ADDREESS.Text, CMB_Martial_Status.Text, TXT_PHONE.Text, TXT_FAMILY_NO.Text, TXT_CARD_NO.Text, CMB_Qualification.Text, TXT_Specialization.Text, PIC_EMP, CMB_WORK_TYPE.Text, TXT_NOTES.Text, True, TXT_ACCOUNT.Text, CMB_BANK.SelectedValue, CMB_FANCTIONALCLASS.Text)
        ClearControls()

    End Sub

    Private Sub TXT_IDN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_IDN.KeyPress
        TXTNumricFormat(e, TXT_IDN)

    End Sub

    Private Sub TXT_PHONE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PHONE.KeyPress
        TXTNumricFormat(e, TXT_PHONE)
    End Sub

    Private Sub TXT_ACCOUNT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ACCOUNT.KeyPress
        TXTNumricFormat(e, TXT_ACCOUNT)
    End Sub

   

    Private Sub TXT_CARD_NO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CARD_NO.KeyPress
        TXTNumricFormat(e, TXT_CARD_NO)
    End Sub

 
    Private Sub BTN_PIC_Click(sender As Object, e As EventArgs) Handles BTN_PIC.Click
        With OpenFileDialog1
            .InitialDirectory = "C:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 2
        End With

        ' When the user clicks the Open button (DialogResult.OK is the only option;
        ' there is not DialogResult.Open), display the image centered in the 
        ' PictureBox and display the full path of the image.
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            With PIC_EMP
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.CenterImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
            'Label7.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub dgv_emp_Click(sender As Object, e As EventArgs) Handles dgv_emp.Click
        Try
            With dgv_emp
                Me.TXT_EMP_ID.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.TXT_EMPNAME.Text = .CurrentRow.Cells(1).Value.ToString()
                Me.TXT_IDN.Text = .CurrentRow.Cells(2).Value.ToString()
                Me.CMB_GENDER.Text = .CurrentRow.Cells(3).Value.ToString()
                Me.DateTimePicker1.Value = .CurrentRow.Cells(4).Value.ToString()
                Me.TXT_LOCATION.Text = .CurrentRow.Cells(5).Value.ToString()
                Me.TXT_ADDREESS.Text = .CurrentRow.Cells(6).Value.ToString()
                Me.CMB_Martial_Status.Text = .CurrentRow.Cells(7).Value.ToString()
                Me.TXT_PHONE.Text = .CurrentRow.Cells(8).Value.ToString()
                Me.TXT_FAMILY_NO.Text = .CurrentRow.Cells(9).Value.ToString()
                Me.TXT_CARD_NO.Text = .CurrentRow.Cells(10).Value.ToString()
                Me.CMB_Qualification.Text = .CurrentRow.Cells(11).Value.ToString()
                'Me.txt_.Text = .CurrentRow.Cells(4).Value.ToString()
                Me.TXT_Specialization.Text = .CurrentRow.Cells(13).Value.ToString()
                Me.CMB_WORK_TYPE.Text = .CurrentRow.Cells(14).Value.ToString()
                Me.TXT_NOTES.Text = .CurrentRow.Cells(15).Value.ToString()
                'Me.txt_NID.Text = .CurrentRow.Cells(4).Value.ToString()
                'Me.txt_NID.Text = .CurrentRow.Cells(4).Value.ToString()
                Me.TXT_ACCOUNT.Text = .CurrentRow.Cells(17).Value.ToString()
                Me.CMB_BANK.Text = .CurrentRow.Cells(18).Value.ToString()
                Me.CMB_FANCTIONALCLASS.Text = .CurrentRow.Cells(19).Value.ToString()
            End With
            BTN_DELETE.Enabled = True
            BTN_EDIT.Enabled = True
            BTN_NEW.Enabled = True
            BTN_SAVE.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        Update_Tbl_Emp(TXT_EMP_ID.Text, TXT_EMPNAME.Text, TXT_IDN.Text, CMB_GENDER.Text, DateTimePicker1.Value, TXT_LOCATION.Text, TXT_ADDREESS.Text, CMB_Martial_Status.Text, TXT_PHONE.Text, TXT_FAMILY_NO.Text, TXT_CARD_NO.Text, CMB_Qualification.Text, TXT_Specialization.Text, PIC_EMP, CMB_WORK_TYPE.Text, TXT_NOTES.Text, True, TXT_ACCOUNT.Text, CMB_BANK.SelectedValue, CMB_FANCTIONALCLASS.Text)
        loadall("View_Emp", dgv_emp)
        ClearControls()
        BTN_DELETE.Enabled = False
        BTN_EDIT.Enabled = False
        BTN_SAVE.Enabled = False
        BTN_NEW.Enabled = True
    End Sub

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Tbl_Emp(False, TXT_EMP_ID.Text)
            loadall("View_Emp", dgv_emp)
        End If
    End Sub
End Class