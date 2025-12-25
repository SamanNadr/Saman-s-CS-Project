<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboard
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.Refreshbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(314, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Leader Board"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(146, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(553, 275)
        Me.DataGridView1.TabIndex = 1
        '
        'Backbtn
        '
        Me.Backbtn.Location = New System.Drawing.Point(384, 398)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(75, 23)
        Me.Backbtn.TabIndex = 2
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Refreshbtn
        '
        Me.Refreshbtn.Location = New System.Drawing.Point(32, 111)
        Me.Refreshbtn.Name = "Refreshbtn"
        Me.Refreshbtn.Size = New System.Drawing.Size(75, 23)
        Me.Refreshbtn.TabIndex = 3
        Me.Refreshbtn.Text = "Refresh"
        Me.Refreshbtn.UseVisualStyleBackColor = True
        '
        'Leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Refreshbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Leaderboard"
        Me.Text = "Leaderboard"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Backbtn As Button
    Friend WithEvents Refreshbtn As Button
End Class
