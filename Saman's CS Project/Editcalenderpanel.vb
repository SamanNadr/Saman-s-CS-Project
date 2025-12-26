Public Class Editcalenderpanel
    Dim indexcurrent As Integer = -1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Hourbox.SelectedIndexChanged

    End Sub

    Private Sub Removebtn_Click(sender As Object, e As EventArgs) Handles Removebtn.Click
        arrlogininfo.RemoveAt(indexCurrent)
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Dim tempcalender As New Calenders
        Dim workoutttime As String = Hourbox.Text & ":" & Minsbox.Text
        Dim selectedDate As String = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy")
        tempcalender.namezz = ID
        tempcalender.workoutdate = workoutttime
        tempcalender.workouttime = selectedDate

        arrcalender.Add(tempcalender)

        writecalenderinfo()
    End Sub

    Private Sub Editcalenderpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Me.Hide()
        workoutcalender.Show()
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim workoutttime As String = Hourbox.Text & ":" & Minsbox.Text
        Dim selectedDate As String = MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy")
        For i = 0 To arrcalender.Count - 1
            If arrcalender(i).workoutdate = workoutttime Then
                arrcalender(i).workouttime = selectedDate
                indexcurrent = i
            End If
        Next
    End Sub
End Class