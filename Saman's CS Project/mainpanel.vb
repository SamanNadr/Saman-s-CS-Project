Public Class mainpanel
    Private Sub Wokoutplanmanagerbtn_Click(sender As Object, e As EventArgs) Handles Wokoutplanmanagerbtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Homedashboardbtn_Click(sender As Object, e As EventArgs) Handles Homedashboardbtn.Click
        Me.Hide()
        homedashboard.Show()
    End Sub

    Private Sub Workoutcalenderbtn_Click(sender As Object, e As EventArgs) Handles Workoutcalenderbtn.Click
        Me.Hide()
        workoutcalender.Show()
    End Sub
End Class