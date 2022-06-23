Public Class frm_school

    Private Sub إضافةشعبةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إضافةشعبةToolStripMenuItem.Click
        frm_manger_divition.Show()

    End Sub

    Private Sub توزيعالمعلمينعلىالصفوفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles توزيعالمعلمينعلىالصفوفToolStripMenuItem.Click
        frm_teacher_to_divition.show()

    End Sub

    Private Sub إضافةمعلمToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إضافةمعلمToolStripMenuItem.Click
        frm_teacher.Show()
    End Sub

    Private Sub وليالأمرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles وليالأمرToolStripMenuItem.Click
        frm_parents.Show()
    End Sub

    Private Sub إضافةطالبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إضافةطالبToolStripMenuItem.Click
        frm_student.Show()
    End Sub

    Private Sub توزيعالطلابعلىالشعبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles توزيعالطلابعلىالشعبToolStripMenuItem.Click
        frm_std_to_div.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frm_manager_classes.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frm_level.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frm_manger_divition.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_absence.Show()
    End Sub

    Private Sub إجازاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إجازاتToolStripMenuItem.Click
        frm_holiday.Show()
    End Sub
End Class