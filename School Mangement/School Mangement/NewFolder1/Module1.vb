Imports System.Data.SqlClient
Imports System.IO

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
            .Parameters.AddWithValue("@Debartment_Name", SqlDbType.VarChar).Value = Debartment_Name
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

    Public dt_parent_tbl As New DataTable
    Public Sub load_cmb_parentname(ByVal cmb_parent As ComboBox, ByVal mefrom As Form)
        cmb_parent.DataSource = Nothing
        cmb_parent.Items.Clear()
        cmb_parent.Text = vbNullString
        dt_parent_tbl.Clear()
        Dim cmd As New SqlCommand("select * from Tbl_Parents", Con)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            dt_parent_tbl.Load(cmd.ExecuteReader)
            Con.Close()
            cmd = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()

        End Try
        If dt_parent_tbl.Rows.Count <> 0 Then
            With cmb_parent
                .DataSource = dt_parent_tbl
                .DisplayMember = "Parent_Name"
                .ValueMember = "Parent_Id"
            End With
        End If
        If cmb_parent.Items.Count > 0 Then cmb_parent.SelectedIndex = -1


    End Sub

    Public Sub Insert_Tbl_Students(ByVal Student_Id As Int32, ByVal Student_Name As String, ByVal Student_NID As Long, ByVal Parents_Id As Int32, ByVal Birth_Date As Date, ByVal Gender As String, ByVal Address As String, ByVal S_Image As PictureBox, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Students (Student_Id,Student_Name,Student_NID,Parents_Id,Birth_Date,Gender,Address,S_Image,Status)values(@Student_Id,@Student_Name,@Student_NID,@Parents_Id,@Birth_Date,@Gender,@Address,@S_Image,@Status)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Student_Id", SqlDbType.Int).Value = Student_Id
            .Parameters.AddWithValue("@Student_Name", SqlDbType.VarChar).Value = Student_Name
            .Parameters.AddWithValue("@Student_NID", SqlDbType.BigInt).Value = Student_NID
            .Parameters.AddWithValue("@Parents_Id", SqlDbType.Int).Value = Parents_Id
            .Parameters.AddWithValue("@Birth_Date", SqlDbType.Date).Value = Birth_Date
            .Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = Gender
            .Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Address
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(S_Image.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@S_Image", SqlDbType.Image)
            p.Value = data
            .Parameters.Add(p)
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_Students(ByVal Student_Id As Int32, ByVal Student_Name As String, ByVal Student_NID As Long, ByVal Parents_Id As Int32, ByVal Birth_Date As Date, ByVal Gender As String, ByVal Address As String, ByVal Status As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            '"Update Tbl_Debartments Set Debartment_Name = @Debartment_Name,Mon_Id = @Mon_Id,Manager_Id = @Manager_Id                                                                                Where Debartment_Id = @Debartment_Id"   
            .CommandText = "Update Tbl_Students Set Student_Name = @Student_Name,Student_NID = @Student_NID,Parents_Id = @Parents_Id,Birth_Date = @Birth_Date,Gender = @Gender,Address = @Address,Status = @Status Where Student_Id = @Student_Id "
            .Parameters.Clear()
            .Parameters.AddWithValue("@Student_Id", SqlDbType.Int).Value = Student_Id
            .Parameters.AddWithValue("@Student_Name", SqlDbType.VarChar).Value = Student_Name
            .Parameters.AddWithValue("@Student_NID", SqlDbType.BigInt).Value = Student_NID
            .Parameters.AddWithValue("@Parents_Id", SqlDbType.Int).Value = Parents_Id
            .Parameters.AddWithValue("@Birth_Date", SqlDbType.Date).Value = Birth_Date
            .Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = Gender
            .Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Address
            '.Parameters.AddWithValue("@S_Image", SqlDbType.VarChar).Value = S_Image
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_Tbl_Students(ByVal Status As Boolean, ByVal Student_IdW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Students Set Status = @Status Where Student_Id = @Student_Id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Status", SqlDbType.Bit).Value = Status
            .Parameters.AddWithValue("@Student_Id", SqlDbType.BigInt).Value = Student_IdW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل بنجاح", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    Public dt_student_tbl As New DataTable
    Public Sub load_cmb_student(ByVal cmb_student As ComboBox, ByVal mefrom As Form)
        cmb_student.DataSource = Nothing
        cmb_student.Items.Clear()
        cmb_student.Text = vbNullString
        dt_student_tbl.Clear()
        Dim cmd As New SqlCommand("select * from Tbl_Students", Con)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            dt_student_tbl.Load(cmd.ExecuteReader)
            Con.Close()
            cmd = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()

        End Try
        If dt_student_tbl.Rows.Count <> 0 Then
            With cmb_student
                .DataSource = dt_student_tbl
                .DisplayMember = "Student_Name"
                .ValueMember = "Student_Id"
            End With
        End If
        If cmb_student.Items.Count > 0 Then cmb_student.SelectedIndex = -1


    End Sub

    Public Sub Insert_Tbl_Parents(ByVal Parent_Id As Int32, ByVal Parent_NId As Long, ByVal Parent_Name As String, ByVal Gender As String, ByVal Job As String, ByVal Relative_Relation As String, ByVal phone As Long, ByVal Address_Home As String, ByVal p_image As PictureBox)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Parents (Parent_Id,Parent_NId,Parent_Name,Gender,Job,Relative_Relation,phone,Address_Home,p_image)values(@Parent_Id,@Parent_NId,@Parent_Name,@Gender,@Job,@Relative_Relation,@phone,@Address_Home,@p_image)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Parent_Id", SqlDbType.Int).Value = Parent_Id
            .Parameters.AddWithValue("@Parent_NId", SqlDbType.BigInt).Value = Parent_NId
            .Parameters.AddWithValue("@Parent_Name", SqlDbType.VarChar).Value = Parent_Name
            '.Parameters.AddWithValue("@Student_Id", SqlDbType.Int).Value = Student_Id
            .Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = Gender
            .Parameters.AddWithValue("@Job", SqlDbType.VarChar).Value = Job
            .Parameters.AddWithValue("@Relative_Relation", SqlDbType.VarChar).Value = Relative_Relation
            .Parameters.AddWithValue("@phone", SqlDbType.BigInt).Value = phone
            .Parameters.AddWithValue("@Address_Home", SqlDbType.VarChar).Value = Address_Home
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(p_image.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@p_image", SqlDbType.Image)
            p.Value = data
            .Parameters.Add(p)
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_Parents(ByVal Parent_Id As Int32, ByVal Parent_NId As Long, ByVal Parent_Name As String, ByVal Gender As String, ByVal Job As String, ByVal Relative_Relation As String, ByVal phone As Long, ByVal Address_Home As String, ByVal p_image As PictureBox)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Parents Set Parent_NId = @Parent_NId,Parent_Name = @Parent_Name,Gender = @Gender,Job = @Job,Relative_Relation = @Relative_Relation,phone = @phone,Address_Home = @Address_Home,p_image = @p_image Where Parent_Id = @Parent_Id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Parent_Id", SqlDbType.Int).Value = Parent_Id
            .Parameters.AddWithValue("@Parent_NId", SqlDbType.BigInt).Value = Parent_NId
            .Parameters.AddWithValue("@Parent_Name", SqlDbType.VarChar).Value = Parent_Name
            .Parameters.AddWithValue("@Gender", SqlDbType.VarChar).Value = Gender
            .Parameters.AddWithValue("@Job", SqlDbType.VarChar).Value = Job
            .Parameters.AddWithValue("@phone", SqlDbType.BigInt).Value = phone
            .Parameters.AddWithValue("@Relative_Relation", SqlDbType.VarChar).Value = Relative_Relation
            .Parameters.AddWithValue("@Address_Home", SqlDbType.VarChar).Value = Address_Home
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(p_image.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@p_image", SqlDbType.Image)
            p.Value = data
            .Parameters.Add(p)
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_Tbl_Parents(ByVal ID_Position As Int32)


        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Parents Where Parent_Id = @Parent_Id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Parent_Id", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

End Module
