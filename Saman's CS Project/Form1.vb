Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readClientsdata()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'writeClientsData()
        writeclientsdata()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        lstOutput.Items.Clear()
        readworkoutlistdata()
        For Each workout In arrworkoutlist
            lstOutput.Items.Add(workout.workouts)

        Next
    End Sub



    Private Sub IstOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOutput.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        lstOutput.Items.Clear()
        readClientsdata()
        For Each clients In arrClients

            lstOutput.Items.Add(clients.firstname)
            lstOutput.Items.Add(clients.lastname)
            lstOutput.Items.Add(clients.id)

        Next
    End Sub
End Class
