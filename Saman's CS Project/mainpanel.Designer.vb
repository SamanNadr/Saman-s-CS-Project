<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainpanel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Homedashboardbtn = New System.Windows.Forms.Button()
        Me.Wokoutplanmanagerbtn = New System.Windows.Forms.Button()
        Me.Workoutcalenderbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(292, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Panel"
        '
        'Homedashboardbtn
        '
        Me.Homedashboardbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Homedashboardbtn.Location = New System.Drawing.Point(299, 132)
        Me.Homedashboardbtn.Name = "Homedashboardbtn"
        Me.Homedashboardbtn.Size = New System.Drawing.Size(181, 61)
        Me.Homedashboardbtn.TabIndex = 1
        Me.Homedashboardbtn.Text = "Home Dashboard"
        Me.Homedashboardbtn.UseVisualStyleBackColor = True
        '
        'Wokoutplanmanagerbtn
        '
        Me.Wokoutplanmanagerbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Wokoutplanmanagerbtn.Location = New System.Drawing.Point(299, 199)
        Me.Wokoutplanmanagerbtn.Name = "Wokoutplanmanagerbtn"
        Me.Wokoutplanmanagerbtn.Size = New System.Drawing.Size(181, 61)
        Me.Wokoutplanmanagerbtn.TabIndex = 2
        Me.Wokoutplanmanagerbtn.Text = "Wokout Plan Manager"
        Me.Wokoutplanmanagerbtn.UseVisualStyleBackColor = True
        '
        'Workoutcalenderbtn
        '
        Me.Workoutcalenderbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Workoutcalenderbtn.Location = New System.Drawing.Point(299, 266)
        Me.Workoutcalenderbtn.Name = "Workoutcalenderbtn"
        Me.Workoutcalenderbtn.Size = New System.Drawing.Size(181, 61)
        Me.Workoutcalenderbtn.TabIndex = 3
        Me.Workoutcalenderbtn.Text = "Workout Calender"
        Me.Workoutcalenderbtn.UseVisualStyleBackColor = True
        '
        'mainpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Workoutcalenderbtn)
        Me.Controls.Add(Me.Wokoutplanmanagerbtn)
        Me.Controls.Add(Me.Homedashboardbtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "mainpanel"
        Me.Text = "mainpanel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Homedashboardbtn As Button
    Friend WithEvents Wokoutplanmanagerbtn As Button
    Friend WithEvents Workoutcalenderbtn As Button
End Class
