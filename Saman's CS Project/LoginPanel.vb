Imports System.Security.Cryptography.X509Certificates


Public Class LoginPanel
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim found As Boolean = False
        For i = 0 To arrlogininfo.Count - 1
            If arrlogininfo(i).username = username.Text Then
                arrlogininfo(i).password = password.Text
                found = True
                ID = username.Text
                username.Clear()
                password.Clear()
            End If
        Next

        If Not found Then
            MessageBox.Show("Login not found. Please try again.")
        End If

        If found Then
            Me.Hide()
            mainpanel.Show()
        End If
    End Sub

    Private Sub LoginPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readlogininfo()
    End Sub
    Sub leaderfinished()
     
    End Sub
End Class