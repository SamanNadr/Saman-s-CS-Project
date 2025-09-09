Imports System.Net.Http

Module FileHander
    Sub readClientsData()
        FileOpen(1, "Clients.txt", OpenMode.Input)

        While Not EOF(1)
            Dim tempClient As New Client

            Input(1, tempClient.firstname)
            Input(1, tempClient.lastname)
            Input(1, tempClient.id)
            Input(1, tempClient.workout)

            arrClients.Add(tempClient)

        End While
        FileClose(1)

    Sub writeClientsData()
        FileOpen(1, "students.txt", OpenMode.Output)

        For Each tempClients In arrClients
            WriteLine(1, tempClients.id, tempClients, tempClients.lastname, tempClients.block)
        Next
        FileClose(1)
    End Sub
End Module
