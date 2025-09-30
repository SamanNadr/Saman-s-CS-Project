Imports System.Net.Http

Module FileHander
    Sub readClientsdata()

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

        End Try
        FileClose(1)
    End Sub

    Sub writeclientsdata()
        FileOpen(1, "Clients.txt", OpenMode.Output)

        For Each tempClients In arrClients
            WriteLine(1, tempClients.firstname, tempClients.lastname, tempClients.id)
        Next
        FileClose(1)
    End Sub


    Sub readworkoutlistdata()
        FileOpen(1, "Workoutlist.txt", OpenMode.Input)

        While Not EOF(1)

            Dim tempworkoutlist As New Workoutlist

            Input(1, tempworkoutlist.workouts)

            arrworkoutlist.Add(tempworkoutlist)

        End While

        FileClose(1)

    End Sub

    Sub writeworkoutlistdata()
        FileOpen(1, "Workoutlist.txt", OpenMode.Output)

        For Each tempworkoutlist In arrworkoutlist
            WriteLine(1, tempworkoutlist.workouts)
        Next
        FileClose(1)
    End Sub
End Module
