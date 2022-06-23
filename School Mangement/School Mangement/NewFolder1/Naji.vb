Imports System.Data.SqlClient

Module Naji
    'Public ConStr As String = "Data Source= DESKTOP-SMJSBIB\SQLEXPRESS;Initial Catalog = DB1;integrated security=true"
    'Public Con As New SqlClient.SqlConnection(ConStr)

    Public dt_Tbl_Years As New DataTable
    Public Sub Insert_Tbl_Levels(ByVal Level_Id As Int32, ByVal Level_Name As String, ByVal Level_Specilization As String, ByVal Year_ID As Int32, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Levels (Level_Id,Level_Name,Level_Specilization,Year_ID,Status)values(@Level_Id,@Level_Name,@Level_Specilization,@Year_ID,@Status)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Level_Id", SqlDbType.Int).Value = Level_Id
            .Parameters.AddWithValue("@Level_Name", SqlDbType.NChar).Value = Level_Name
            .Parameters.AddWithValue("@Level_Specilization", SqlDbType.NChar).Value = Level_Specilization
            .Parameters.AddWithValue("@Year_ID", SqlDbType.Int).Value = Year_ID
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Tbl_Levels(ByVal Level_Id As Int32, ByVal Level_Name As String, ByVal Level_Specilization As String, ByVal Year_ID As Int32, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            '"Update Tbl_Debartments Set Debartment_Name = @Debartment_Name,Mon_Id = @Mon_Id,Manager_Id = @Manager_Id                                                                                Where Debartment_Id = @Debartment_Id"  
            .CommandText = "Update Tbl_Levels Set Level_Name = @Level_Name,Level_Specilization = @Level_Specilization,Year_ID = @Year_ID,Status=@Status"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Level_Id", SqlDbType.Int).Value = Level_Id
            .Parameters.AddWithValue("@Level_Name", SqlDbType.NChar).Value = Level_Name
            .Parameters.AddWithValue("@Level_Specilization", SqlDbType.NChar).Value = Level_Specilization
            .Parameters.AddWithValue("@Year_ID", SqlDbType.Int).Value = Year_ID
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_Tbl_Levels(ByVal Status As Boolean, ByVal Level_Id As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Levels Set Status = @Status Where Level_Id = @Level_Id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
            .Parameters.AddWithValue("@Level_Id", SqlDbType.BigInt).Value = Level_Id
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل بنجاح", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Public Sub loadallStatus(ByVal tblName As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        dt.Clear()
        da = New SqlDataAdapter("Select * from " & tblName & " where Status=1", Con)
        da.Fill(dt)
        dgv.AutoGenerateColumns = False
        dgv.DataSource = dt
    End Sub

End Module



