<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oi_insert_table
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
        Me.btn_oi_exit = New System.Windows.Forms.Button()
        Me.btn_oi_insert = New System.Windows.Forms.Button()
        Me.oi_update_DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.oi_update_qty = New System.Windows.Forms.TextBox()
        Me.oi_update_ProdPrice = New System.Windows.Forms.TextBox()
        Me.oi_update_TotalAmnt = New System.Windows.Forms.TextBox()
        Me.oi_update_ProdID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_oi_exit
        '
        Me.btn_oi_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_oi_exit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_exit.Location = New System.Drawing.Point(302, 268)
        Me.btn_oi_exit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oi_exit.Name = "btn_oi_exit"
        Me.btn_oi_exit.Size = New System.Drawing.Size(84, 35)
        Me.btn_oi_exit.TabIndex = 52
        Me.btn_oi_exit.Text = "Cancel"
        Me.btn_oi_exit.UseVisualStyleBackColor = False
        '
        'btn_oi_insert
        '
        Me.btn_oi_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oi_insert.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_insert.Location = New System.Drawing.Point(30, 268)
        Me.btn_oi_insert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oi_insert.Name = "btn_oi_insert"
        Me.btn_oi_insert.Size = New System.Drawing.Size(82, 35)
        Me.btn_oi_insert.TabIndex = 51
        Me.btn_oi_insert.Text = "Save"
        Me.btn_oi_insert.UseVisualStyleBackColor = False
        '
        'oi_update_DatePicker
        '
        Me.oi_update_DatePicker.Location = New System.Drawing.Point(165, 174)
        Me.oi_update_DatePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_DatePicker.Name = "oi_update_DatePicker"
        Me.oi_update_DatePicker.Size = New System.Drawing.Size(219, 23)
        Me.oi_update_DatePicker.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(39, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Product ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(39, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Todays Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(28, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Total Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Product Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(67, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Quantity"
        '
        'oi_update_qty
        '
        Me.oi_update_qty.Location = New System.Drawing.Point(165, 34)
        Me.oi_update_qty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_qty.Name = "oi_update_qty"
        Me.oi_update_qty.Size = New System.Drawing.Size(221, 23)
        Me.oi_update_qty.TabIndex = 44
        '
        'oi_update_ProdPrice
        '
        Me.oi_update_ProdPrice.Location = New System.Drawing.Point(165, 76)
        Me.oi_update_ProdPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_ProdPrice.Name = "oi_update_ProdPrice"
        Me.oi_update_ProdPrice.Size = New System.Drawing.Size(221, 23)
        Me.oi_update_ProdPrice.TabIndex = 43
        '
        'oi_update_TotalAmnt
        '
        Me.oi_update_TotalAmnt.Location = New System.Drawing.Point(165, 125)
        Me.oi_update_TotalAmnt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_TotalAmnt.Name = "oi_update_TotalAmnt"
        Me.oi_update_TotalAmnt.Size = New System.Drawing.Size(221, 23)
        Me.oi_update_TotalAmnt.TabIndex = 42
        '
        'oi_update_ProdID
        '
        Me.oi_update_ProdID.Location = New System.Drawing.Point(165, 221)
        Me.oi_update_ProdID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_ProdID.Name = "oi_update_ProdID"
        Me.oi_update_ProdID.Size = New System.Drawing.Size(221, 23)
        Me.oi_update_ProdID.TabIndex = 41
        '
        'oi_insert_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(429, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_oi_exit)
        Me.Controls.Add(Me.btn_oi_insert)
        Me.Controls.Add(Me.oi_update_DatePicker)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.oi_update_qty)
        Me.Controls.Add(Me.oi_update_ProdPrice)
        Me.Controls.Add(Me.oi_update_TotalAmnt)
        Me.Controls.Add(Me.oi_update_ProdID)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "oi_insert_table"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_oi_exit As Button
    Friend WithEvents btn_oi_insert As Button
    Friend WithEvents oi_update_DatePicker As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents oi_update_qty As TextBox
    Friend WithEvents oi_update_ProdPrice As TextBox
    Friend WithEvents oi_update_TotalAmnt As TextBox
    Friend WithEvents oi_update_ProdID As TextBox
End Class
