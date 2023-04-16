<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oi_delete_table
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_proceed_deleteTable = New System.Windows.Forms.Button()
        Me.btn_oi_delete_table = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(60, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 55)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 23)
        Me.TextBox1.TabIndex = 1
        '
        'btn_proceed_deleteTable
        '
        Me.btn_proceed_deleteTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_proceed_deleteTable.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_proceed_deleteTable.Location = New System.Drawing.Point(18, 111)
        Me.btn_proceed_deleteTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_proceed_deleteTable.Name = "btn_proceed_deleteTable"
        Me.btn_proceed_deleteTable.Size = New System.Drawing.Size(82, 28)
        Me.btn_proceed_deleteTable.TabIndex = 2
        Me.btn_proceed_deleteTable.Text = "Proceed"
        Me.btn_proceed_deleteTable.UseVisualStyleBackColor = False
        '
        'btn_oi_delete_table
        '
        Me.btn_oi_delete_table.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_oi_delete_table.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_delete_table.Location = New System.Drawing.Point(180, 111)
        Me.btn_oi_delete_table.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oi_delete_table.Name = "btn_oi_delete_table"
        Me.btn_oi_delete_table.Size = New System.Drawing.Size(82, 28)
        Me.btn_oi_delete_table.TabIndex = 3
        Me.btn_oi_delete_table.Text = "Close"
        Me.btn_oi_delete_table.UseVisualStyleBackColor = False
        '
        'oi_delete_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(273, 154)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_oi_delete_table)
        Me.Controls.Add(Me.btn_proceed_deleteTable)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "oi_delete_table"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_proceed_deleteTable As Button
    Friend WithEvents btn_oi_delete_table As Button
End Class
