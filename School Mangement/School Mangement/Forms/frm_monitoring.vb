Public Class frm_monitoring

    Private Sub frm_monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub إضافةوتعديلبيناتفرعToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إضافةوتعديلبيناتفرعToolStripMenuItem.Click
        frm_manager_branchs.Show()

    End Sub

    Private Sub إضافةعامدراسيToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إضافةعامدراسيToolStripMenuItem.Click
        frm_years.Show()

    End Sub

    Private Sub إضافةموظفينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إضافةموظفينToolStripMenuItem.Click
        frm_employees.Show()

    End Sub

    Private Sub إدارةالمناطقToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إدارةالمناطقToolStripMenuItem.Click
        frm_location.Show()

    End Sub

    Private Sub إدارةالمصارفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إدارةالمصارفToolStripMenuItem.Click
        frm_bank.Show()

    End Sub

    Private Sub إدارةالمراقباتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إدارةالمراقباتToolStripMenuItem.Click
        'frm_()
    End Sub

    Private Sub الفروعToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles الفروعToolStripMenuItem1.Click
        frm_branch.Show()
    End Sub

    Private Sub المدارسToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المدارسToolStripMenuItem.Click
        frm_school.Show()
    End Sub
End Class