Module FileHandler
    Sub readClientsdata()
        arrClients.Clear()
        If Not IO.File.Exists("Clients.txt") Then Return

        FileOpen(1, "Clients.txt", OpenMode.Input)
        Try
            While Not EOF(1)
                Dim tempClient As New Clients
                Input(1, tempClient.firstname)
                Input(1, tempClient.lastname)
                Input(1, tempClient.id)
                arrClients.Add(tempClient)
            End While
        Catch ex As Exception
            ' Handle error (optional)
        Finally
            FileClose(1)
        End Try
    End Sub

    Sub writeclientsdata()
        FileOpen(1, "Clients.txt", OpenMode.Output)
        For Each tempClient In arrClients
            WriteLine(1, tempClient.firstname, tempClient.lastname, tempClient.id)
        Next
        FileClose(1)
    End Sub

    Sub readworkoutlistdata()
        arrWorkoutList.Clear()
        If Not IO.File.Exists("Workoutlist.txt") Then Return

        FileOpen(1, "Workoutlist.txt", OpenMode.Input)
        Try
            While Not EOF(1)
                Dim tempWorkoutlist As New Workoutlist
                Input(1, tempWorkoutlist.workouts)
                arrWorkoutList.Add(tempWorkoutlist)
            End While
        Catch ex As Exception
            ' Handle error (optional)
        Finally
            FileClose(1)
        End Try
    End Sub

    Sub writeworkoutlistdata()
        FileOpen(1, "Workoutlist.txt", OpenMode.Output)
        For Each tempWorkoutlist In arrWorkoutList
            WriteLine(1, tempWorkoutlist.workouts)
        Next
        FileClose(1)
    End Sub
End Module
