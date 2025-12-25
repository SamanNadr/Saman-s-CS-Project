Module FileHandler

    Sub readClientsdata()
        arrClients.Clear() ' Clear any existing data first

        ' If the file doesn't exist, just exit the sub
        If Not IO.File.Exists("Clients.txt") Then Return

        ' Open the file for reading
        FileOpen(1, "Clients.txt", OpenMode.Input)
        Try
            ' Read until we reach the end of the file
            While Not EOF(1)
                Dim tempClient As New Clients

                ' Read each field from the file into the tempClient object
                Input(1, tempClient.name)
                Input(1, tempClient.PushUps)
                Input(1, tempClient.WidePushUps)
                Input(1, tempClient.DiamondPushUps)
                Input(1, tempClient.TricepDips)
                Input(1, tempClient.PlankShoulderTaps)
                Input(1, tempClient.PikePushUps)
                Input(1, tempClient.InchwormWalkouts)
                Input(1, tempClient.DeclinePushUps)
                Input(1, tempClient.SupermanHold)
                Input(1, tempClient.ArmCircles)
                Input(1, tempClient.SitUps)
                Input(1, tempClient.Crunches)
                Input(1, tempClient.LegRaises)
                Input(1, tempClient.RussianTwists)
                Input(1, tempClient.Plank)
                Input(1, tempClient.SidePlankLeft)
                Input(1, tempClient.SidePlankRight)
                Input(1, tempClient.MountainClimbers)
                Input(1, tempClient.FlutterKicks)
                Input(1, tempClient.BicycleCrunches)
                Input(1, tempClient.Squats)
                Input(1, tempClient.Lunges)
                Input(1, tempClient.CalfRaises)
                Input(1, tempClient.WallSit)
                Input(1, tempClient.GluteBridges)
                Input(1, tempClient.StepUps)
                Input(1, tempClient.SideLegRaises)
                Input(1, tempClient.DonkeyKicks)
                Input(1, tempClient.JumpSquats)
                Input(1, tempClient.HighKnees)


                ' Add the client to the main list
                arrClients.Add(tempClient)
            End While
        Catch ex As Exception
            ' Optional: handle any errors that occur while reading
        Finally
            ' Always close the file
            FileClose(1)
        End Try
    End Sub

    ' Writes all client data from arrClients to "Clients.txt"
    Sub writeclientsdata()
        FileOpen(1, "Clients.txt", OpenMode.Output)
        For Each tempClient In arrClients
            ' Write each client's fields to the file in the same order used by readClientsdata
            WriteLine(1, tempClient.name,
                         tempClient.PushUps,
                         tempClient.WidePushUps,
                         tempClient.DiamondPushUps,
                         tempClient.TricepDips,
                         tempClient.PlankShoulderTaps,
                         tempClient.PikePushUps,
                         tempClient.InchwormWalkouts,
                         tempClient.DeclinePushUps,
                         tempClient.SupermanHold,
                         tempClient.ArmCircles,
                         tempClient.SitUps,
                         tempClient.Crunches,
                         tempClient.LegRaises,
                         tempClient.RussianTwists,
                         tempClient.Plank,
                         tempClient.SidePlankLeft,
                         tempClient.SidePlankRight,
                         tempClient.MountainClimbers,
                         tempClient.FlutterKicks,
                         tempClient.BicycleCrunches,
                         tempClient.Squats,
                         tempClient.Lunges,
                         tempClient.CalfRaises,
                         tempClient.WallSit,
                         tempClient.GluteBridges,
                         tempClient.StepUps,
                         tempClient.SideLegRaises,
                         tempClient.DonkeyKicks,
                         tempClient.JumpSquats,
                         tempClient.HighKnees)
        Next
        FileClose(1)
    End Sub

    ' Reads workout list data from "Workoutlist.txt" and loads it into arrWorkoutList
    Sub readworkoutlistdata()
        arrWorkoutList.Clear() ' Clear any existing data first

        ' If the file doesn't exist, exit
        If Not IO.File.Exists("Workoutlist.txt") Then Return

        ' Open the file for reading
        FileOpen(1, "Workoutlist.txt", OpenMode.Input)
        Try
            ' Read until the end of the file
            While Not EOF(1)
                Dim tempWorkoutlist As New Workoutlist

                ' Read the workout data from the file
                Input(1, tempWorkoutlist.workouts)

                ' Add the workout to the list
                arrWorkoutList.Add(tempWorkoutlist)
            End While
        Catch ex As Exception
            ' Optional: handle any errors while reading
        Finally
            ' Always close the file
            FileClose(1)
        End Try
    End Sub

    ' Writes all workout list data from arrWorkoutList to "Workoutlist.txt"
    Sub writeworkoutlistdata()
        FileOpen(1, "Workoutlist.txt", OpenMode.Output)
        For Each tempWorkout In arrWorkoutList
            ' Write each workout to the file
            WriteLine(1, tempWorkout.workouts)
        Next
        FileClose(1)
    End Sub

    Sub readlogininfo()
        ' If the file doesn't exist, exit
        If Not IO.File.Exists("logininfo.txt") Then Return
        ' Open the file for reading
        FileOpen(1, "logininfo.txt", OpenMode.Input)
        Try
            ' Read until the end of the file
            While Not EOF(1)
                Dim tempLogininfo As New logininfo
                ' Read username and password from the file
                Input(1, tempLogininfo.username)
                Input(1, tempLogininfo.password)
                ' Add the login info to the list
                arrlogininfo.Add(tempLogininfo)
            End While
        Catch ex As Exception
            ' Optional: handle any errors while reading
        Finally
            ' Always close the file
            FileClose(1)
        End Try
    End Sub

    Sub writeLogininfo()
        FileOpen(1, "Login.txt", OpenMode.Output)

        'loops through all records in the user list
        For Each tempLogin In arrlogininfo
            'writes each record to a line in the file
            WriteLine(1, tempLogin.username, tempLogin.password)
        Next

        FileClose(1) 'saves to file
    End Sub


    Sub readleaderboarddata()
        ' Make sure we start fresh each time
        arrleaderboard.Clear()

        If Not IO.File.Exists("Leaderboard.txt") Then Return

        FileOpen(1, "Leaderboard.txt", OpenMode.Input)
        Try
            ' Use a dictionary to enforce one entry per name
            Dim unique As New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase)

            While Not EOF(1)
                Dim name As String = ""
                Dim score As Integer = 0

                ' Read from file
                Input(1, name)
                Input(1, score)

                ' If the name already exists, keep the highest score
                If unique.ContainsKey(name) Then
                    If score > unique(name) Then
                        unique(name) = score
                    End If
                Else
                    unique.Add(name, score)
                End If
            End While

            ' Rebuild arrleaderboard from the unique dictionary
            For Each kvp In unique
                Dim tempLeaderboard As New Leaderboards
                tempLeaderboard.namez = kvp.Key
                tempLeaderboard.score = kvp.Value
                arrleaderboard.Add(tempLeaderboard)
            Next

        Catch ex As Exception
            ' Optional: handle any errors while reading
        Finally
            FileClose(1)
        End Try
    End Sub


    Sub writeleaderboarddata()
        FileOpen(1, "Leaderboard.txt", OpenMode.Output)
        For Each tempLeaderboard In arrleaderboard
            ' Write each leaderboard entry to the file
            WriteLine(1, tempLeaderboard.namez, tempLeaderboard.score)
        Next
        FileClose(1)
    End Sub
End Module

