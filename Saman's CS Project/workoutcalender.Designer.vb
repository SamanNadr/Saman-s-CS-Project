<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class workoutcalender
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
        Me.Adminpanelbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Adminpanelbtn
        '
        Me.Adminpanelbtn.Location = New System.Drawing.Point(447, 84)
        Me.Adminpanelbtn.Name = "Adminpanelbtn"
        Me.Adminpanelbtn.Size = New System.Drawing.Size(170, 23)
        Me.Adminpanelbtn.TabIndex = 0
        Me.Adminpanelbtn.Text = "Admin Panel"
        Me.Adminpanelbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(370, 216)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(75, 23)
        Me.backbtn.TabIndex = 2
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'workoutcalender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Adminpanelbtn)
        Me.Name = "workoutcalender"
        Me.Text = "workoutcalender"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Adminpanelbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents backbtn As Button
End Class
