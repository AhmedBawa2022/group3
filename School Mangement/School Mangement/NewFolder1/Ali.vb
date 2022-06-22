Imports System.Data.SqlClient
Module Ali
    Public Tbl_Location As New DataTable
    Public Sub Insert_Tbl_Location(ByVal Location_Id As Int32, ByVal Location_Name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Location ( Location_Id,Location_Name)values(@Location_Id,@Location_Name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Location_Id", SqlDbType.Int).Value = Location_Id
            .Parameters.AddWithValue("@Location_Name", SqlDbType.VarChar).Value = Location_Name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Tbl_Location(ByVal Location_Id As Int32, ByVal Location_Name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Location Set Location_Name = @Location_Name Where Location_Id = @Location_Id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Location_Id", SqlDbType.Int).Value = Location_Id
            .Parameters.AddWithValue("@Location_Name", SqlDbType.VarChar).Value = Location_Name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_Tbl_Location(ByVal ID_Position As Int32)

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Location Where Location_Id = @Location_Id"

            .Parameters.Clear()
            .Parameters.AddWithValue("@Location_Id", SqlDbType.Int).Value = ID_Position

        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
End Module
