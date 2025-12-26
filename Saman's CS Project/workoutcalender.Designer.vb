<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class workoutcalender
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
        Me.Adminpanelbtn = New System.Windows.Forms.Button()
        Me.Refreshbtn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.editcalender = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Adminpanelbtn
        '
        Me.Adminpanelbtn.Location = New System.Drawing.Point(618, 415)
        Me.Adminpanelbtn.Name = "Adminpanelbtn"
        Me.Adminpanelbtn.Size = New System.Drawing.Size(170, 23)
        Me.Adminpanelbtn.TabIndex = 0
        Me.Adminpanelbtn.Text = "Admin Panel"
        Me.Adminpanelbtn.UseVisualStyleBackColor = True
        '
        'Refreshbtn
        '
        Me.Refreshbtn.Location = New System.Drawing.Point(61, 200)
        Me.Refreshbtn.Name = "Refreshbtn"
        Me.Refreshbtn.Size = New System.Drawing.Size(75, 23)
        Me.Refreshbtn.TabIndex = 1
        Me.Refreshbtn.Text = "Refresh"
        Me.Refreshbtn.UseVisualStyleBackColor = True
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(12, 415)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(75, 23)
        Me.backbtn.TabIndex = 2
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(692, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'editcalender
        '
        Me.editcalender.Location = New System.Drawing.Point(169, 200)
        Me.editcalender.Name = "editcalender"
        Me.editcalender.Size = New System.Drawing.Size(100, 23)
        Me.editcalender.TabIndex = 5
        Me.editcalender.Text = "Edit calender"
        Me.editcalender.UseVisualStyleBackColor = True
        '
        'workoutcalender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.editcalender)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.Refreshbtn)
        Me.Controls.Add(Me.Adminpanelbtn)
        Me.Name = "workoutcalender"
        Me.Text = "workoutcalender"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Adminpanelbtn As Button
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents backbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents editcalender As Button
End Class
