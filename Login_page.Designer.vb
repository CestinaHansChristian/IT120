<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_page
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
        Me.txtbox_user = New System.Windows.Forms.TextBox()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbox_user
        '
        Me.txtbox_user.Location = New System.Drawing.Point(142, 107)
        Me.txtbox_user.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(236, 27)
        Me.txtbox_user.TabIndex = 0
        '
        'txtbox_pass
        '
        Me.txtbox_pass.Location = New System.Drawing.Point(142, 176)
        Me.txtbox_pass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.Size = New System.Drawing.Size(237, 27)
        Me.txtbox_pass.TabIndex = 1
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_fname.Location = New System.Drawing.Point(34, 103)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(102, 28)
        Me.lbl_fname.TabIndex = 2
        Me.lbl_fname.Text = "username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(34, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "password"
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.PaleGreen
        Me.login_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.login_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.login_btn.Location = New System.Drawing.Point(142, 263)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(86, 47)
        Me.login_btn.TabIndex = 1
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.DarkSalmon
        Me.exit_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exit_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.exit_btn.Location = New System.Drawing.Point(293, 263)
        Me.exit_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(86, 47)
        Me.exit_btn.TabIndex = 2
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(183, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Login"
        '
        'Login_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(458, 353)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.txtbox_user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Login_page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbox_user As TextBox
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents lbl_fname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents login_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents Label2 As Label
End Class
