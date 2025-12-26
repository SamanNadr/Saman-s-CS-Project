Public Class workoutcalender
    Private Sub Adminpanelbtn_Click(sender As Object, e As EventArgs) Handles Adminpanelbtn.Click
        Me.Hide()
        Adminpanel.Show()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        mainpanel.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        readcalenderinfo()
        RefreshCalendarGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles editcalender.Click
        Me.Hide()
        Editcalenderpanel.Show()
    End Sub

    Private Sub RefreshCalendarGrid()
        ' Set up the DataGridView
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()
        DataGridView1.AutoGenerateColumns = False

        ' ID column
        DataGridView1.Columns.Add("ID", "ID")

        ' Date and Time columns (as strings)
        DataGridView1.Columns.Add("WorkoutDate", "Date")
        DataGridView1.Columns.Add("WorkoutTime", "Time")

        ' Make a copy of the calendar list so we can sort it
        Dim list As New List(Of Calenders)(arrcalender)

        ' Sort by combined date+time: earliest (soonest) first
        list.Sort(
            Function(a As Calenders, b As Calenders)
                Dim dtA, dtB As DateTime

                Dim okA As Boolean = DateTime.TryParseExact(
                    a.workoutdate & " " & a.workouttime,
                    New String() {"dd/MM/yyyy HH:mm", "dd/MM/yyyy H:mm"},
                    System.Globalization.CultureInfo.InvariantCulture,
                    Globalization.DateTimeStyles.None,
                    dtA)

                Dim okB As Boolean = DateTime.TryParseExact(
                    b.workoutdate & " " & b.workouttime,
                    New String() {"dd/MM/yyyy HH:mm", "dd/MM/yyyy H:mm"},
                    System.Globalization.CultureInfo.InvariantCulture,
                    Globalization.DateTimeStyles.None,
                    dtB)

                ' If parsing fails for either, treat them as equal
                If Not okA AndAlso Not okB Then Return 0
                If Not okA Then Return 1    ' put invalid ones at the bottom
                If Not okB Then Return -1

                Return dtA.CompareTo(dtB)   ' ascending (soonest first)
            End Function)

        ' Fill the grid
        Dim id As Integer = 1

        For Each c In list
            Dim rowIndex As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(rowIndex).Cells("ID").Value = id
            DataGridView1.Rows(rowIndex).Cells("WorkoutDate").Value = c.workoutdate
            DataGridView1.Rows(rowIndex).Cells("WorkoutTime").Value = c.workouttime
            id += 1
        Next
    End Sub

End Class