<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPanel
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
        Me.username = New System.Windows.Forms.TextBox()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(295, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login Panel"
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.username.Location = New System.Drawing.Point(302, 152)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(191, 36)
        Me.username.TabIndex = 1
        '
        'loginbtn
        '
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.loginbtn.Location = New System.Drawing.Point(320, 276)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(155, 45)
        Me.loginbtn.TabIndex = 2
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.password.Location = New System.Drawing.Point(302, 201)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(191, 36)
        Me.password.TabIndex = 3
        '
        'LoginPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginPanel"
        Me.Text = "LoginPanel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents password As TextBox
End Class
