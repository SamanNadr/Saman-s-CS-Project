Public Class Progressreview

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        homedashboard.Show()
    End Sub

    Private Sub Progressreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildExerciseGrid()
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        BuildExerciseGrid()
    End Sub

    Private Sub BuildExerciseGrid()
        ' Set up the DataGridView
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()
        DataGridView1.AutoGenerateColumns = False

        ' ID column
        DataGridView1.Columns.Add("ID", "ID")

        ' Name column
        DataGridView1.Columns.Add("Name", "Name")

        ' Exercise columns (internal name, header text)
        DataGridView1.Columns.Add("PushUps", "Push-ups")
        DataGridView1.Columns.Add("WidePushUps", "Wide push-ups")
        DataGridView1.Columns.Add("DiamondPushUps", "Diamond push-ups")
        DataGridView1.Columns.Add("TricepDips", "Tricep dips")
        DataGridView1.Columns.Add("PlankShoulderTaps", "Plank shoulder taps")
        DataGridView1.Columns.Add("PikePushUps", "Pike push-ups")
        DataGridView1.Columns.Add("InchwormWalkouts", "Inchworm walkouts")
        DataGridView1.Columns.Add("DeclinePushUps", "Decline push-ups")
        DataGridView1.Columns.Add("SupermanHold", "Superman hold")
        DataGridView1.Columns.Add("ArmCircles", "Arm circles")
        DataGridView1.Columns.Add("SitUps", "Sit-ups")
        DataGridView1.Columns.Add("Crunches", "Crunches")
        DataGridView1.Columns.Add("LegRaises", "Leg raises")
        DataGridView1.Columns.Add("RussianTwists", "Russian twists")
        DataGridView1.Columns.Add("Plank", "Plank")
        DataGridView1.Columns.Add("SidePlankLeft", "Side plank (left)")
        DataGridView1.Columns.Add("SidePlankRight", "Side plank (right)")
        DataGridView1.Columns.Add("MountainClimbers", "Mountain climbers")
        DataGridView1.Columns.Add("FlutterKicks", "Flutter kicks")
        DataGridView1.Columns.Add("BicycleCrunches", "Bicycle crunches")
        DataGridView1.Columns.Add("Squats", "Squats")
        DataGridView1.Columns.Add("Lunges", "Lunges")
        DataGridView1.Columns.Add("CalfRaises", "Calf raises")
        DataGridView1.Columns.Add("WallSit", "Wall sit")
        DataGridView1.Columns.Add("GluteBridges", "Glute bridges")
        DataGridView1.Columns.Add("StepUps", "Step-ups")
        DataGridView1.Columns.Add("SideLegRaises", "Side leg raises")
        DataGridView1.Columns.Add("DonkeyKicks", "Donkey kicks")
        DataGridView1.Columns.Add("JumpSquats", "Jump squats")
        DataGridView1.Columns.Add("HighKnees", "High knees")

        ' Fill rows from arrClients
        Dim id As Integer = 1

        For Each c In arrClients
            Dim rowIndex As Integer = DataGridView1.Rows.Add()

            DataGridView1.Rows(rowIndex).Cells("ID").Value = id
            DataGridView1.Rows(rowIndex).Cells("Name").Value = c.name

            DataGridView1.Rows(rowIndex).Cells("PushUps").Value = c.PushUps
            DataGridView1.Rows(rowIndex).Cells("WidePushUps").Value = c.WidePushUps
            DataGridView1.Rows(rowIndex).Cells("DiamondPushUps").Value = c.DiamondPushUps
            DataGridView1.Rows(rowIndex).Cells("TricepDips").Value = c.TricepDips
            DataGridView1.Rows(rowIndex).Cells("PlankShoulderTaps").Value = c.PlankShoulderTaps
            DataGridView1.Rows(rowIndex).Cells("PikePushUps").Value = c.PikePushUps
            DataGridView1.Rows(rowIndex).Cells("InchwormWalkouts").Value = c.InchwormWalkouts
            DataGridView1.Rows(rowIndex).Cells("DeclinePushUps").Value = c.DeclinePushUps
            DataGridView1.Rows(rowIndex).Cells("SupermanHold").Value = c.SupermanHold
            DataGridView1.Rows(rowIndex).Cells("ArmCircles").Value = c.ArmCircles
            DataGridView1.Rows(rowIndex).Cells("SitUps").Value = c.SitUps
            DataGridView1.Rows(rowIndex).Cells("Crunches").Value = c.Crunches
            DataGridView1.Rows(rowIndex).Cells("LegRaises").Value = c.LegRaises
            DataGridView1.Rows(rowIndex).Cells("RussianTwists").Value = c.RussianTwists
            DataGridView1.Rows(rowIndex).Cells("Plank").Value = c.Plank
            DataGridView1.Rows(rowIndex).Cells("SidePlankLeft").Value = c.SidePlankLeft
            DataGridView1.Rows(rowIndex).Cells("SidePlankRight").Value = c.SidePlankRight
            DataGridView1.Rows(rowIndex).Cells("MountainClimbers").Value = c.MountainClimbers
            DataGridView1.Rows(rowIndex).Cells("FlutterKicks").Value = c.FlutterKicks
            DataGridView1.Rows(rowIndex).Cells("BicycleCrunches").Value = c.BicycleCrunches
            DataGridView1.Rows(rowIndex).Cells("Squats").Value = c.Squats
            DataGridView1.Rows(rowIndex).Cells("Lunges").Value = c.Lunges
            DataGridView1.Rows(rowIndex).Cells("CalfRaises").Value = c.CalfRaises
            DataGridView1.Rows(rowIndex).Cells("WallSit").Value = c.WallSit
            DataGridView1.Rows(rowIndex).Cells("GluteBridges").Value = c.GluteBridges
            DataGridView1.Rows(rowIndex).Cells("StepUps").Value = c.StepUps
            DataGridView1.Rows(rowIndex).Cells("SideLegRaises").Value = c.SideLegRaises
            DataGridView1.Rows(rowIndex).Cells("DonkeyKicks").Value = c.DonkeyKicks
            DataGridView1.Rows(rowIndex).Cells("JumpSquats").Value = c.JumpSquats
            DataGridView1.Rows(rowIndex).Cells("HighKnees").Value = c.HighKnees

            id += 1
        Next
    End Sub

End Class
