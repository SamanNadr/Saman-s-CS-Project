<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Progressreview
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
        Me.backbtn = New System.Windows.Forms.Button()
        Me.Refreshbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(706, 379)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(75, 23)
        Me.backbtn.TabIndex = 0
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'Refreshbtn
        '
        Me.Refreshbtn.Location = New System.Drawing.Point(677, 304)
        Me.Refreshbtn.Name = "Refreshbtn"
        Me.Refreshbtn.Size = New System.Drawing.Size(132, 56)
        Me.Refreshbtn.TabIndex = 2
        Me.Refreshbtn.Text = "Refresh"
        Me.Refreshbtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Location = New System.Drawing.Point(12, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1434, 248)
        Me.DataGridView1.TabIndex = 3
        '
        'Progressreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1458, 417)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Refreshbtn)
        Me.Controls.Add(Me.backbtn)
        Me.Name = "Progressreview"
        Me.Text = "Progressreview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backbtn As Button
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
