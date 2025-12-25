Public Class Leaderboard

    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Rebuild leaderboard from clients and show it
        leaderboardfinishing()
        createGridView()

        ' Optional: if you want to save the leaderboard to file on load
        writeleaderboarddata()
    End Sub

    Private Sub createGridView()

        ' Clear and set up the DataGridView
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()
        DataGridView1.AutoGenerateColumns = False

        DataGridView1.Columns.Add("ID", "ID")
        DataGridView1.Columns.Add("Name", "Name")
        DataGridView1.Columns.Add("Score", "Score")

        ' Make sure there's something to sort
        If arrleaderboard IsNot Nothing AndAlso arrleaderboard.Count > 1 Then
            ' Sort the LIST in place: highest score first
            arrleaderboard.Sort(
                Function(a As DataStructures.Leaderboards,
                         b As DataStructures.Leaderboards) b.score.CompareTo(a.score))
        End If

        ' Fill grid with ID, namez, score
        Dim id As Integer = 1

        For Each player In arrleaderboard
            If Not String.IsNullOrEmpty(player.namez) Then
                DataGridView1.Rows.Add(id, player.namez, player.score)
                id += 1
            End If
        Next

    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Me.Hide()
        homedashboard.Show()
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        ' Rebuild leaderboard and refresh grid
        leaderboardfinishing()
        createGridView()
    End Sub

    Sub leaderboardfinishing()
        ' ✅ Clear old leaderboard data so it doesn't keep adding
        arrleaderboard.Clear()

        ' Build leaderboard entries from clients
        For Each tempClient In arrClients
            Dim totalScore As Integer =
              tempClient.PushUps +
              tempClient.WidePushUps +
              tempClient.DiamondPushUps +
              tempClient.TricepDips +
              tempClient.PlankShoulderTaps +
              tempClient.PikePushUps +
              tempClient.InchwormWalkouts +
              tempClient.DeclinePushUps +
              tempClient.SupermanHold +
              tempClient.ArmCircles +
              tempClient.SitUps +
              tempClient.Crunches +
              tempClient.LegRaises +
              tempClient.RussianTwists +
              tempClient.Plank +
              tempClient.SidePlankLeft +
              tempClient.SidePlankRight +
              tempClient.MountainClimbers +
              tempClient.FlutterKicks +
              tempClient.BicycleCrunches +
              tempClient.Squats +
              tempClient.Lunges +
              tempClient.CalfRaises +
              tempClient.WallSit +
              tempClient.GluteBridges +
              tempClient.StepUps +
              tempClient.SideLegRaises +
              tempClient.DonkeyKicks +
              tempClient.JumpSquats +
              tempClient.HighKnees

            Dim tempLeaderboard As New Leaderboards
            tempLeaderboard.namez = tempClient.name
            tempLeaderboard.score = totalScore

            arrleaderboard.Add(tempLeaderboard)
        Next

        ' You can also call writeleaderboarddata() here instead of in Load,
        ' if you want it saved every time the list is rebuilt.
        ' writeleaderboarddata()
    End Sub

End Class
