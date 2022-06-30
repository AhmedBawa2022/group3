Imports System.Data.SqlClient

Module Naji
    'Public ConStr As String = "Data Source= DESKTOP-SMJSBIB\SQLEXPRESS;Initial Catalog = DB1;integrated security=true"
    'Public Con As New SqlClient.SqlConnection(ConStr)

    Public Tbl_Years As New DataTable
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

    'Public Sub loadallStatus(ByVal tblName As String, ByVal dgv As DataGridView)
    '    Dim dt As New DataTable
    '    Dim da As New SqlDataAdapter
    '    dt.Clear()
    '    da = New SqlDataAdapter("Select * from " & tblName & " where Status=1", Con)
    '    da.Fill(dt)
    '    dgv.AutoGenerateColumns = False
    '    dgv.DataSource = dt
    'End Sub
    'Public Tbl_Years As New DataTable
    Public Sub Insert_Tbl_Years(ByVal Year_id As Int32, ByVal Year_Name As String, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Years ( Year_id,Year_Name,Status)values(@Year_id,@Year_Name,@Status)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Year_id", SqlDbType.Int).Value = Year_id
            .Parameters.AddWithValue("@Year_Name", SqlDbType.NChar).Value = Year_Name
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Tbl_Years(ByVal Year_id As Int32, ByVal Year_Name As String, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Years Set Year_Name = @Year_Name,Status=@Status Where Year_id = @Year_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Year_id", SqlDbType.Int).Value = Year_id
            .Parameters.AddWithValue("@Year_Name", SqlDbType.NChar).Value = Year_Name
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_Tbl_Years(ByVal Status As Boolean, ByVal Year_id As Int32)

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete From Tbl_Years Where Year_id = @Year_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
            .Parameters.AddWithValue("@Year_id", SqlDbType.BigInt).Value = Year_id
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل بنجاح", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Public dt_Tbl_Years As New DataTable
    Public dt_Tbl_Levels As New DataTable

    Public Sub Insert_Tbl_Classes(ByVal Class_ID As Int32, ByVal ClassName As String, ByVal Year_ID As Int32, ByVal Level_ID As Int32, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Classes (Class_ID,ClassName,Year_ID,Level_ID,Status)values(@Class_ID,@ClassName,@Year_ID,@Level_ID,@Status)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Class_ID", SqlDbType.Int).Value = Class_ID
            .Parameters.AddWithValue("@ClassName", SqlDbType.NChar).Value = ClassName
            .Parameters.AddWithValue("@Year_ID", SqlDbType.Int).Value = Year_ID
            .Parameters.AddWithValue("@Level_ID", SqlDbType.Int).Value = Level_ID
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Tbl_Classes(ByVal Class_ID As Int32, ByVal ClassName As String, ByVal Year_ID As Int32, ByVal Level_ID As Int32, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Classes Set ClassName = @ClassName,Year_ID = @Year_ID,Level_ID = @Level_ID,Status=@Status where Class_ID=@Class_ID "
            .Parameters.Clear()
            .Parameters.AddWithValue("@Class_ID", SqlDbType.Int).Value = Class_ID
            .Parameters.AddWithValue("@ClassName", SqlDbType.NChar).Value = ClassName
            .Parameters.AddWithValue("@Year_ID", SqlDbType.Int).Value = Year_ID
            .Parameters.AddWithValue("@Level_ID", SqlDbType.Int).Value = Level_ID
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_Tbl_Classes(ByVal Status As Boolean, ByVal Class_ID As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete from Tbl_Classes  Where Class_ID = @Class_ID"
            .Parameters.Clear()
            '.Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
            .Parameters.AddWithValue("@Class_ID", SqlDbType.BigInt).Value = Class_ID
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
        da = New SqlDataAdapter("Select * from " & tblName & "", Con)
        da.Fill(dt)
        dgv.AutoGenerateColumns = False
        dgv.DataSource = dt
    End Sub

    Public dt_Tbl_class As New DataTable
    Public Sub Insert_Tbl_section(ByVal txt_section_id As Int32, ByVal txt_section_name As String, ByVal Year_ID As Int32, ByVal Level_Id As Int32, ByVal Class_ID As Int32, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Sections (Section_ID,Section_Name,Year_ID,Level_ID,Class_ID,Status)values(@Section_ID,@Section_Name,@Year_ID,@Level_ID,@Class_ID,@Status)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Section_ID", SqlDbType.Int).Value = txt_section_id
            .Parameters.AddWithValue("@Section_Name", SqlDbType.NChar).Value = txt_section_name
            .Parameters.AddWithValue("@Year_ID", SqlDbType.Int).Value = Year_ID
            .Parameters.AddWithValue("@Level_ID", SqlDbType.Int).Value = Level_Id
            .Parameters.AddWithValue("@Class_ID", SqlDbType.Int).Value = Class_ID
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Tbl_section(ByVal txt_section_id As Int32, ByVal txt_section_name As String, ByVal Year_ID As Int32, ByVal Level_Id As Int32, ByVal Class_ID As Int32, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Sections Set Section_Name = @Section_Name,Year_ID = @Year_ID,Level_ID = @Level_ID,Class_ID = @Class_ID,Status=@Status where Section_ID=@Section_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Section_ID", SqlDbType.Int).Value = txt_section_id
            .Parameters.AddWithValue("@Section_Name", SqlDbType.NChar).Value = txt_section_name
            .Parameters.AddWithValue("@Year_ID", SqlDbType.Int).Value = Year_ID
            .Parameters.AddWithValue("@Level_ID", SqlDbType.Int).Value = Level_Id
            .Parameters.AddWithValue("@Class_ID", SqlDbType.Int).Value = Class_ID
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_Tbl_section(ByVal Status As Boolean, ByVal Section_ID As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete from Tbl_Sections  Where Section_ID = @Section_ID"
            .Parameters.Clear()
            '.Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
            .Parameters.AddWithValue("@Section_ID", SqlDbType.BigInt).Value = Section_ID
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل بنجاح", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
End Module