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
                Input(1, tempClient.firstname)
                Input(1, tempClient.lastname)
                Input(1, tempClient.id)

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
            ' Write each client's first name, last name, and ID to the file
            WriteLine(1, tempClient.firstname, tempClient.lastname, tempClient.id)
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

End Module

