Imports System.Data.SqlClient
Public Class frm_login
    Public vald As Char
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim cmd As New SqlCommand("select * from  Tbl_Employee where Emp_Name=@id and Emp_PassWord=@pass", Con)
        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txt_username.Text
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txt_password.Text
        Con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then


            vald = dr(6)
            If vald = "s" Then
                Form7.Show()
            ElseIf vald = "b" Then

                frm_branch.Show()
            ElseIf vald = "m" Then
                frm_monitoring.Show()
            Else
                MsgBox("الدخول خاطئ")
            End If
        End If
        dr.Close()
        Con.Close()

    End Sub
End Class
