<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordered_items_update
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
        Me.oi_update_ID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_oi_exit
        '
        Me.btn_oi_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_oi_exit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_exit.Location = New System.Drawing.Point(286, 284)
        Me.btn_oi_exit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oi_exit.Name = "btn_oi_exit"
        Me.btn_oi_exit.Size = New System.Drawing.Size(84, 35)
        Me.btn_oi_exit.TabIndex = 38
        Me.btn_oi_exit.Text = "Cancel"
        Me.btn_oi_exit.UseVisualStyleBackColor = False
        '
        'btn_oi_insert
        '
        Me.btn_oi_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oi_insert.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_insert.Location = New System.Drawing.Point(14, 284)
        Me.btn_oi_insert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oi_insert.Name = "btn_oi_insert"
        Me.btn_oi_insert.Size = New System.Drawing.Size(82, 35)
        Me.btn_oi_insert.TabIndex = 37
        Me.btn_oi_insert.Text = "Save"
        Me.btn_oi_insert.UseVisualStyleBackColor = False
        '
        'oi_update_DatePicker
        '
        Me.oi_update_DatePicker.Location = New System.Drawing.Point(150, 190)
        Me.oi_update_DatePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_DatePicker.Name = "oi_update_DatePicker"
        Me.oi_update_DatePicker.Size = New System.Drawing.Size(219, 23)
        Me.oi_update_DatePicker.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(24, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Product ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(24, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Todays Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Total Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(14, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Product Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(52, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Quantity"
        '
        'oi_update_qty
        '
        Me.oi_update_qty.Location = New System.Drawing.Point(150, 50)
        Me.oi_update_qty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_qty.Name = "oi_update_qty"
        Me.oi_update_qty.Size = New System.Drawing.Size(221, 23)
        Me.oi_update_qty.TabIndex = 30
        '
        'oi_update_ProdPrice
        '
        Me.oi_update_ProdPrice.Location = New System.Drawing.Point(150, 93)
        Me.oi_update_ProdPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_ProdPrice.Name = "oi_update_ProdPrice"
        Me.oi_update_ProdPrice.Size = New System.Drawing.Size(221, 23)
        Me.oi_update_ProdPrice.TabIndex = 29
        '
        'oi_update_TotalAmnt
        '
        Me.oi_update_TotalAmnt.Location = New System.Drawing.Point(150, 142)
        Me.oi_update_TotalAmnt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_TotalAmnt.Name = "oi_update_TotalAmnt"
        Me.oi_update_TotalAmnt.Size = New System.Drawing.Size(221, 23)
        Me.oi_update_TotalAmnt.TabIndex = 28
        '
        'oi_update_ProdID
        '
        Me.oi_update_ProdID.Location = New System.Drawing.Point(150, 238)
        Me.oi_update_ProdID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_ProdID.Name = "oi_update_ProdID"
        Me.oi_update_ProdID.Size = New System.Drawing.Size(221, 23)
        Me.oi_update_ProdID.TabIndex = 27
        '
        'oi_update_ID
        '
        Me.oi_update_ID.Location = New System.Drawing.Point(148, 9)
        Me.oi_update_ID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.oi_update_ID.Name = "oi_update_ID"
        Me.oi_update_ID.Size = New System.Drawing.Size(221, 23)
        Me.oi_update_ID.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(91, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 21)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "ID"
        '
        'Ordered_items_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(412, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.oi_update_ID)
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
        Me.Name = "Ordered_items_update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
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
    Friend WithEvents oi_update_ID As TextBox
    Friend WithEvents Label6 As Label
End Class
