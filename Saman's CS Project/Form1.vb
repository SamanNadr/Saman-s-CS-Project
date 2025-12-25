Imports System.ComponentModel

Public Class Form1

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        mainpanel.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readworkoutlistdata()
        loadworkouts()
        readlogininfo()
        writeleaderboarddata()
    End Sub
    Private Sub loadworkouts()
        CheckedListBox1.Items.Clear()

        Dim uniqueWorkouts = arrWorkoutList.
        GroupBy(Function(l) l.workouts).
        Select(Function(g) g.First()).
        ToList()

        ' Randomly shuffle the list
        Dim rnd As New Random()
        Dim shuffled = uniqueWorkouts.OrderBy(Function(x) rnd.Next()).ToList()

        ' Take ONLY 5 (or fewer if list is small)
        Dim randomFive = shuffled.Take(5).ToList()

        ' Output the 5 random workouts
        For i As Integer = 0 To randomFive.Count - 1
            CheckedListBox1.Items.Add(randomFive(i).workouts)
        Next
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        ' Make sure we are updating the correct client
        For i As Integer = 0 To arrClients.Count - 1
            If arrClients(i).name = ID Then  ' ID must be the current logged-in client
                ' Go through every checked workout
                For Each selectedWorkout As String In CheckedListBox1.CheckedItems

                    Select Case selectedWorkout
                        Case "Push-ups" : arrClients(i).PushUps += 1
                        Case "Wide push-ups" : arrClients(i).WidePushUps += 1
                        Case "Diamond push-ups" : arrClients(i).DiamondPushUps += 1
                        Case "Tricep dips" : arrClients(i).TricepDips += 1
                        Case "Plank shoulder taps" : arrClients(i).PlankShoulderTaps += 1
                        Case "Pike push-ups" : arrClients(i).PikePushUps += 1
                        Case "Inchworm walkouts" : arrClients(i).InchwormWalkouts += 1
                        Case "Decline push-ups" : arrClients(i).DeclinePushUps += 1
                        Case "Superman hold" : arrClients(i).SupermanHold += 1
                        Case "Arm circles" : arrClients(i).ArmCircles += 1
                        Case "Sit-ups" : arrClients(i).SitUps += 1
                        Case "Crunches" : arrClients(i).Crunches += 1
                        Case "Leg raises" : arrClients(i).LegRaises += 1
                        Case "Russian twists" : arrClients(i).RussianTwists += 1
                        Case "Plank" : arrClients(i).Plank += 1
                        Case "Side plank (left)" : arrClients(i).SidePlankLeft += 1
                        Case "Side plank (right)" : arrClients(i).SidePlankRight += 1
                        Case "Mountain climbers" : arrClients(i).MountainClimbers += 1
                        Case "Flutter kicks" : arrClients(i).FlutterKicks += 1
                        Case "Bicycle crunches" : arrClients(i).BicycleCrunches += 1
                        Case "Squats" : arrClients(i).Squats += 1
                        Case "Lunges" : arrClients(i).Lunges += 1
                        Case "Calf raises" : arrClients(i).CalfRaises += 1
                        Case "Wall sit" : arrClients(i).WallSit += 1
                        Case "Glute bridges" : arrClients(i).GluteBridges += 1
                        Case "Step-ups" : arrClients(i).StepUps += 1
                        Case "Side leg raises" : arrClients(i).SideLegRaises += 1
                        Case "Donkey kicks" : arrClients(i).DonkeyKicks += 1
                        Case "Jump squats" : arrClients(i).JumpSquats += 1
                        Case "High knees" : arrClients(i).HighKnees += 1
                    End Select

                Next

                Exit For
            End If
        Next

        ' Save updated values back to file
        writeclientsdata()
        MsgBox("Workout progress saved!")

    End Sub
End Class

