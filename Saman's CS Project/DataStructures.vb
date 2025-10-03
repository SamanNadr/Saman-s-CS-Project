Module DataStructures
    Public arrClients As New List(Of Clients)

    Public Class Clients
        Public Property firstname As String
        Public Property lastname As String
        Public Property id As Integer
    End Class

    Public arrWorkoutList As New List(Of Workoutlist)

    Public Class Workoutlist
        Public Property workouts As String
    End Class
End Module
