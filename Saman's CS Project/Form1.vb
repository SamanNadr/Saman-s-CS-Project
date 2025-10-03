Imports System.ComponentModel

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readClientsdata()
        RefreshClientList()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        writeclientsdata()
    End Sub

    Private Sub btnLoadWorkouts_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lstOutput.Items.Clear()
        readworkoutlistdata()
        For Each workout In arrWorkoutList
            lstOutput.Items.Add(workout.workouts)
        Next
    End Sub

    Private Sub btnLoadClients_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshClientList()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim()

        Dim foundClient = arrClients.Find(Function(c) c.firstname.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
        If foundClient IsNot Nothing Then
            TextBox1.Text = foundClient.firstname
            TextBox2.Text = foundClient.lastname
        Else
            MessageBox.Show("Client not found.")
        End If
    End Sub

    ' Add new client via InputBox
    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim firstName As String = InputBox("Enter First Name")
        Dim lastName As String = InputBox("Enter Last Name")

        If String.IsNullOrWhiteSpace(firstName) Or String.IsNullOrWhiteSpace(lastName) Then
            MessageBox.Show("First and Last names cannot be empty.")
            Return
        End If

        Dim newClient As New Clients With {
            .firstname = firstName,
            .lastname = lastName,
            .id = GenerateNewClientID()
        }

        arrClients.Add(newClient)
        writeclientsdata()
        RefreshClientList()

        MessageBox.Show("Client added successfully.")
    End Sub

    ' Save client from TextBoxes
    Private Sub btnSaveClient_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim firstName = TextBox1.Text.Trim()
        Dim lastName = TextBox2.Text.Trim()

        If String.IsNullOrWhiteSpace(firstName) Or String.IsNullOrWhiteSpace(lastName) Then
            MessageBox.Show("First and Last names cannot be empty.")
            Return
        End If

        Dim newClient As New Clients With {
            .firstname = firstName,
            .lastname = lastName,
            .id = GenerateNewClientID()
        }

        arrClients.Add(newClient)
        writeclientsdata()
        RefreshClientList()

        MessageBox.Show("Client saved successfully.")
    End Sub

    Private Sub RefreshClientList()
        lstOutput.Items.Clear()
        For Each client In arrClients
            lstOutput.Items.Add($"ID: {client.id} - {client.firstname} {client.lastname}")
        Next
    End Sub

    Private Function GenerateNewClientID() As Integer
        If arrClients.Count = 0 Then Return 1
        Return arrClients.Max(Function(c) c.id) + 1
    End Function

End Class

