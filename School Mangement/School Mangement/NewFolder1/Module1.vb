﻿Imports System.Data.SqlClient
Module Module1

    Public ConStr As String = "Data Source= DESKTOP-A923AE2\SQLEXPRESS;Initial Catalog = DB1;integrated security=true"
    Public Con As New SqlClient.SqlConnection(ConStr)



    Public Function Max_Record(Tname As String, Field As String)
        Dim Number As Integer
        Try
            'Select Max(Debartment_Id) From Tbl_Debartments
            Dim cmd As New SqlCommand("Select Max('" & Field & "') From '" & Tname & "' ", Con)
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


    Public dt_monitoring_tbl As New DataTable

    Public Sub load_cmb_monitoring(ByVal cmb_monitoring As ComboBox, ByVal mefrom As Form)
        cmb_monitoring.DataSource = Nothing
        cmb_monitoring.Items.Clear()
        cmb_monitoring.Text = vbNullString
        dt_monitoring_tbl.Clear()
        Dim cmd As New SqlCommand("select * from Tbl_Monitoring", Con)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            dt_monitoring_tbl.Load(cmd.ExecuteReader)
            Con.Close()
            cmd = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()

        End Try
        If dt_monitoring_tbl.Rows.Count <> 0 Then
            With cmb_monitoring
                .DataSource = dt_monitoring_tbl
                .DisplayMember = "edu_mon_name"
                .ValueMember = "edu_mon_id"
            End With
        End If
        If cmb_monitoring.Items.Count > 0 Then cmb_monitoring.SelectedIndex = -1


    End Sub
    Public Sub Insert_Tbl_Branch(ByVal Debartment_Id As Int32, ByVal Debartment_Name As String, ByVal Manager_Id As Int32, ByVal Mon_Id As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Debartments ( Debartment_Id,Debartment_Name,Manager_Id,Mon_Id)values(@Debartment_Id,@Debartment_Name,@Manager_Id,@Mon_Id)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Debartment_Id", SqlDbType.Int).Value = Debartment_Id
            .Parameters.AddWithValue("@Debartment_Name", SqlDbType.VarChar).Value = Debartment_Name
            .Parameters.AddWithValue("@Manager_Id", SqlDbType.Int).Value = Manager_Id
            .Parameters.AddWithValue("@Mon_Id", SqlDbType.Int).Value = Mon_Id
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub loadall(ByVal tblName As String, ByVal dgv As DataGridView)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        dt.Clear()
        da = New SqlDataAdapter("Select * from " & tblName & "", Con)
        da.Fill(dt)
        dgv.AutoGenerateColumns = False
        dgv.DataSource = dt
    End Sub



    Public Sub Update_Tbl_Debartments(ByVal Debartment_Id As Int32, ByVal Debartment_Name As String, ByVal Mon_Id As Int32, ByVal Manager_Id As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Debartments Set Debartment_Name = @Debartment_Name,Mon_Id = @Mon_Id,Manager_Id = @Manager_Id Where Debartment_Id = @Debartment_Id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Debartment_Id", SqlDbType.Int).Value = Debartment_Id
            .Parameters.AddWithValue("@Debartment_Name", SqlDbType.varchar).Value = Debartment_Name
            .Parameters.AddWithValue("@Mon_Id", SqlDbType.Int).Value = Mon_Id
            .Parameters.AddWithValue("@Manager_Id", SqlDbType.Int).Value = Manager_Id
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public dt_Emp_tbl As New DataTable
    Public Sub load_cmb_Manager(ByVal cmb_Manager As ComboBox, ByVal mefrom As Form)
        cmb_Manager.DataSource = Nothing
        cmb_Manager.Items.Clear()
        cmb_Manager.Text = vbNullString
        dt_Emp_tbl.Clear()
        Dim cmd As New SqlCommand("select * from Tbl_Emp", Con)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            dt_Emp_tbl.Load(cmd.ExecuteReader)
            Con.Close()
            cmd = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()

        End Try
        If dt_Emp_tbl.Rows.Count <> 0 Then
            With cmb_Manager
                .DataSource = dt_Emp_tbl
                .DisplayMember = "Emp_Name"
                .ValueMember = "Emp_Id"
            End With
        End If
        If cmb_Manager.Items.Count > 0 Then cmb_Manager.SelectedIndex = -1


    End Sub

    Public Sub Delete_Tbl_Debartments(ByVal ID_Position As Int32)


        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Debartments Where Debartment_Id = @Debartment_Id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Debartment_Id", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub




End Module
