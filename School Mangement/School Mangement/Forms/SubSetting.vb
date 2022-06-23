Public Class SubSetting

    Private Sub SubSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bank As New frm_bank
        bank.MdiParent = Me
        TabControl1.TabPages(0).Controls.Add(bank)
        bank.Show()
    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        Dim bank As New frm_bank
        bank.MdiParent = Me
        TabControl1.TabPages(0).Controls.Add(bank)
        bank.Show()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        Dim location As New frm_location
        location.MdiParent = Me
        TabControl1.TabPages(1).Controls.Add(location)
        location.Show()
    End Sub

    Private Sub TabPage1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabPage1.MouseClick

    End Sub
End Class