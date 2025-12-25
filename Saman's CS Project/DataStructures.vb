Module DataStructures
    Public arrClients As New List(Of Clients)

    Public Class Clients
        Public Property name As String
        Public Property PushUps As Integer
        Public Property WidePushUps As Integer
        Public Property DiamondPushUps As Integer
        Public Property TricepDips As Integer
        Public Property PlankShoulderTaps As Integer
        Public Property PikePushUps As Integer
        Public Property InchwormWalkouts As Integer
        Public Property DeclinePushUps As Integer
        Public Property SupermanHold As Integer
        Public Property ArmCircles As Integer
        Public Property SitUps As Integer
        Public Property Crunches As Integer
        Public Property LegRaises As Integer
        Public Property RussianTwists As Integer
        Public Property Plank As Integer
        Public Property SidePlankLeft As Integer
        Public Property SidePlankRight As Integer
        Public Property MountainClimbers As Integer
        Public Property FlutterKicks As Integer
        Public Property BicycleCrunches As Integer
        Public Property Squats As Integer
        Public Property Lunges As Integer
        Public Property CalfRaises As Integer
        Public Property WallSit As Integer
        Public Property GluteBridges As Integer
        Public Property StepUps As Integer
        Public Property SideLegRaises As Integer
        Public Property DonkeyKicks As Integer
        Public Property JumpSquats As Integer
        Public Property HighKnees As Integer
    End Class

    Public arrWorkoutList As New List(Of Workoutlist)

    Public Class Workoutlist
        Public Property workouts As String
    End Class


    ' Added list to hold login info records
    Public arrlogininfo As New List(Of logininfo)

    ' Fixed class name from "loginifo" to "logininfo"
    Public Class logininfo
        Public Property username As String
        Public Property password As String
    End Class

    Public arrleaderboard As New List(Of Leaderboards)
    Public Class Leaderboards
        Public Property namez As String
        Public Property score As Integer
    End Class

    Public ID As String


End Module
