Imports System.Data.SqlClient
Module Module1

    Public ConStr As String = "Data Source= DESKTOP-LKAN02H\SQLEXPRESS;Initial Catalog = DB1;integrated security=true"
    Public Con As New SqlClient.SqlConnection(ConStr)



    Public Sub Insert_Tbl_Monitering(ByVal edu_mon_id As Int32, ByVal edu_mon_name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Monitering ( edu_mon_id,edu_mon_name)values(@edu_mon_id,@edu_mon_name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@edu_mon_id", SqlDbType.Int).Value = edu_mon_id
            .Parameters.AddWithValue("@edu_mon_name", SqlDbType.varchar).Value = edu_mon_name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

End Module
