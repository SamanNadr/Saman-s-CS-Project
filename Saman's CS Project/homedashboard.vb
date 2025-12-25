Public Class homedashboard
    Private Sub Progressreviewbtn_Click(sender As Object, e As EventArgs) Handles Progressreviewbtn.Click
        Progressreview.Show()

        Me.Hide()
    End Sub

    Private Sub Leaderboardbtn_Click(sender As Object, e As EventArgs) Handles Leaderboardbtn.Click
        Me.Hide()
        Leaderboard.Show()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        mainpanel.Show()
    End Sub

    Private Sub homedashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readleaderboarddata()
        readClientsdata()

    End Sub


End Class