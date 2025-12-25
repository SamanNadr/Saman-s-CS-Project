<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homedashboard
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
        Me.Leaderboardbtn = New System.Windows.Forms.Button()
        Me.Progressreviewbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Leaderboardbtn
        '
        Me.Leaderboardbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Leaderboardbtn.Location = New System.Drawing.Point(294, 262)
        Me.Leaderboardbtn.Name = "Leaderboardbtn"
        Me.Leaderboardbtn.Size = New System.Drawing.Size(181, 61)
        Me.Leaderboardbtn.TabIndex = 6
        Me.Leaderboardbtn.Text = "Leaderboard"
        Me.Leaderboardbtn.UseVisualStyleBackColor = True
        '
        'Progressreviewbtn
        '
        Me.Progressreviewbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Progressreviewbtn.Location = New System.Drawing.Point(294, 154)
        Me.Progressreviewbtn.Name = "Progressreviewbtn"
        Me.Progressreviewbtn.Size = New System.Drawing.Size(181, 61)
        Me.Progressreviewbtn.TabIndex = 5
        Me.Progressreviewbtn.Text = "Progress Review"
        Me.Progressreviewbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(251, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Home dashboard"
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(12, 415)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(75, 23)
        Me.backbtn.TabIndex = 7
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'homedashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.Leaderboardbtn)
        Me.Controls.Add(Me.Progressreviewbtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "homedashboard"
        Me.Text = "homedashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Leaderboardbtn As Button
    Friend WithEvents Progressreviewbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents backbtn As Button
End Class
