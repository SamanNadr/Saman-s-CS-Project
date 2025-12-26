<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editcalenderpanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Hourbox = New System.Windows.Forms.ComboBox()
        Me.Minsbox = New System.Windows.Forms.ComboBox()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Removebtn = New System.Windows.Forms.Button()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Hourbox
        '
        Me.Hourbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Hourbox.FormattingEnabled = True
        Me.Hourbox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.Hourbox.Location = New System.Drawing.Point(359, 17)
        Me.Hourbox.Name = "Hourbox"
        Me.Hourbox.Size = New System.Drawing.Size(121, 33)
        Me.Hourbox.TabIndex = 1
        Me.Hourbox.Text = "Hour"
        '
        'Minsbox
        '
        Me.Minsbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Minsbox.FormattingEnabled = True
        Me.Minsbox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"})
        Me.Minsbox.Location = New System.Drawing.Point(486, 17)
        Me.Minsbox.Name = "Minsbox"
        Me.Minsbox.Size = New System.Drawing.Size(121, 33)
        Me.Minsbox.TabIndex = 2
        Me.Minsbox.Text = "Mins"
        '
        'Addbtn
        '
        Me.Addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Addbtn.Location = New System.Drawing.Point(359, 72)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(100, 30)
        Me.Addbtn.TabIndex = 3
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'Searchbtn
        '
        Me.Searchbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Searchbtn.Location = New System.Drawing.Point(465, 72)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(100, 30)
        Me.Searchbtn.TabIndex = 4
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Removebtn
        '
        Me.Removebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Removebtn.Location = New System.Drawing.Point(571, 72)
        Me.Removebtn.Name = "Removebtn"
        Me.Removebtn.Size = New System.Drawing.Size(100, 30)
        Me.Removebtn.TabIndex = 5
        Me.Removebtn.Text = "Remove"
        Me.Removebtn.UseVisualStyleBackColor = True
        '
        'Backbtn
        '
        Me.Backbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Backbtn.Location = New System.Drawing.Point(12, 408)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(100, 30)
        Me.Backbtn.TabIndex = 6
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Editcalenderpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.Removebtn)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Minsbox)
        Me.Controls.Add(Me.Hourbox)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "Editcalenderpanel"
        Me.Text = "Editcalenderpanel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Hourbox As ComboBox
    Friend WithEvents Minsbox As ComboBox
    Friend WithEvents Addbtn As Button
    Friend WithEvents Searchbtn As Button
    Friend WithEvents Removebtn As Button
    Friend WithEvents Backbtn As Button
End Class
