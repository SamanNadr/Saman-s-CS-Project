<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Workoutmanager = New System.Windows.Forms.Label()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Workoutmanager
        '
        Me.Workoutmanager.AutoSize = True
        Me.Workoutmanager.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Workoutmanager.Location = New System.Drawing.Point(399, 9)
        Me.Workoutmanager.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Workoutmanager.Name = "Workoutmanager"
        Me.Workoutmanager.Size = New System.Drawing.Size(286, 39)
        Me.Workoutmanager.TabIndex = 7
        Me.Workoutmanager.Text = "Workout Manager"
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(980, 519)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(75, 23)
        Me.backbtn.TabIndex = 19
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"67", "69"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(59, 72)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(361, 284)
        Me.CheckedListBox1.TabIndex = 21
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(444, 72)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 22
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.Workoutmanager)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Status :                                                                 "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Workoutmanager As Label
    Friend WithEvents backbtn As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Add As Button
End Class
