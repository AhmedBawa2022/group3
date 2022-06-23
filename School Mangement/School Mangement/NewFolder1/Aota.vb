Imports System.Data.SqlClient
Module Aota
    Public Sub Insert_Tbl_bank(ByVal bank_id As Int32, ByVal bank_name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Banks ( bank_id,bank_name)values(@bank_id,@bank_name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@bank_id", SqlDbType.Int).Value = bank_id
            .Parameters.AddWithValue("@bank_name", SqlDbType.VarChar).Value = bank_name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_Banks(ByVal bank_id As Int32, ByVal bank_name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Banks Set bank_name = @bank_name Where bank_id = @bank_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@bank_id", SqlDbType.Int).Value = bank_id
            .Parameters.AddWithValue("@bank_name", SqlDbType.VarChar).Value = bank_name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_Tbl_Banks(ByVal ID_Position As Int32)


        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Banks Where Bank_Id = @Bank_Id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Bank_Id", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
End Module
