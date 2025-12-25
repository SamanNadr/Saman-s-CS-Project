Public Class workoutcalender
    Private Sub Adminpanelbtn_Click(sender As Object, e As EventArgs) Handles Adminpanelbtn.Click
        Me.Hide()
        Adminpanel.Show()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        mainpanel.Show()
    End Sub
End Class