<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminpanel
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
        Me.backbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.loginout = New System.Windows.Forms.ListBox()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.createbtn = New System.Windows.Forms.Button()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(31, 403)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(85, 33)
        Me.backbtn.TabIndex = 21
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Location = New System.Drawing.Point(198, 300)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(85, 33)
        Me.deletebtn.TabIndex = 20
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Location = New System.Drawing.Point(289, 300)
        Me.updatebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(85, 33)
        Me.updatebtn.TabIndex = 19
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Location = New System.Drawing.Point(515, 410)
        Me.refreshbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(144, 26)
        Me.refreshbtn.TabIndex = 18
        Me.refreshbtn.Text = "Refresh"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'loginout
        '
        Me.loginout.FormattingEnabled = True
        Me.loginout.ItemHeight = 16
        Me.loginout.Location = New System.Drawing.Point(395, 15)
        Me.loginout.Margin = New System.Windows.Forms.Padding(4)
        Me.loginout.Name = "loginout"
        Me.loginout.Size = New System.Drawing.Size(389, 372)
        Me.loginout.TabIndex = 17
        '
        'searchbtn
        '
        Me.searchbtn.Location = New System.Drawing.Point(107, 300)
        Me.searchbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(85, 33)
        Me.searchbtn.TabIndex = 15
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'createbtn
        '
        Me.createbtn.Location = New System.Drawing.Point(16, 300)
        Me.createbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.createbtn.Name = "createbtn"
        Me.createbtn.Size = New System.Drawing.Size(85, 33)
        Me.createbtn.TabIndex = 14
        Me.createbtn.Text = "Create"
        Me.createbtn.UseVisualStyleBackColor = True
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.passwordtxt.Location = New System.Drawing.Point(42, 208)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(297, 30)
        Me.passwordtxt.TabIndex = 13
        '
        'usernametxt
        '
        Me.usernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.usernametxt.Location = New System.Drawing.Point(42, 172)
        Me.usernametxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(297, 30)
        Me.usernametxt.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(105, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Admin Panel"
        '
        'Adminpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.loginout)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.createbtn)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Adminpanel"
        Me.Text = "Adminpanel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backbtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents refreshbtn As Button
    Friend WithEvents loginout As ListBox
    Friend WithEvents searchbtn As Button
    Friend WithEvents createbtn As Button
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents Label1 As Label
End Class
