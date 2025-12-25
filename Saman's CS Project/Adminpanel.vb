Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Adminpanel
    Dim indexCurrent As Integer = -1
    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        workoutcalender.Show()
    End Sub
    Private Sub Adminpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readlogininfo()

    End Sub
    Private Sub createbtn_Click(sender As Object, e As EventArgs) Handles createbtn.Click
        Dim tempLogin As New logininfo

        tempLogin.username = usernametxt.Text
        tempLogin.password = passwordtxt.Text

        arrlogininfo.Add(tempLogin)

        Dim tempClient As New Clients

        tempClient.name = usernametxt.Text
        tempClient.PushUps = 0
        tempClient.PushUps = 0
        tempClient.WidePushUps = 0
        tempClient.DiamondPushUps = 0
        tempClient.TricepDips = 0
        tempClient.PlankShoulderTaps = 0
        tempClient.PikePushUps = 0
        tempClient.InchwormWalkouts = 0
        tempClient.DeclinePushUps = 0
        tempClient.SupermanHold = 0
        tempClient.ArmCircles = 0
        tempClient.SitUps = 0
        tempClient.Crunches = 0
        tempClient.LegRaises = 0
        tempClient.RussianTwists = 0
        tempClient.Plank = 0
        tempClient.SidePlankLeft = 0
        tempClient.SidePlankRight = 0
        tempClient.MountainClimbers = 0
        tempClient.FlutterKicks = 0
        tempClient.BicycleCrunches = 0
        tempClient.Squats = 0
        tempClient.Lunges = 0
        tempClient.CalfRaises = 0
        tempClient.WallSit = 0
        tempClient.GluteBridges = 0
        tempClient.StepUps = 0
        tempClient.SideLegRaises = 0
        tempClient.DonkeyKicks = 0
        tempClient.JumpSquats = 0
        tempClient.HighKnees = 0

        arrClients.Add(tempClient)
        writeLogininfo()
        writeclientsdata()
    End Sub



    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        For i = 0 To arrlogininfo.Count - 1
            If arrlogininfo(i).username = usernametxt.Text Then
                passwordtxt.Text = arrlogininfo(i).password
                indexCurrent = i
            End If
        Next
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        arrlogininfo.RemoveAt(indexCurrent)
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim tempLogin As New logininfo

        tempLogin.username = usernametxt.Text
        tempLogin.password = passwordtxt.Text

        arrlogininfo.Add(tempLogin)
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loginout.Items.Clear()

        ' Create a list of unique user entries before displaying
        Dim uniqueLogins = arrlogininfo.
        GroupBy(Function(l) l.username & " " & l.password).
        Select(Function(g) g.First()).
        ToList()

        ' Loop through only the unique ones
        For i = 0 To uniqueLogins.Count - 1
            loginout.Items.Add(uniqueLogins(i).username & " " &
                               uniqueLogins(i).password)
        Next
    End Sub
End Class