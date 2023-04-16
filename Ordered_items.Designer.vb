<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_orderItems
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
        Me.btn_suppl = New System.Windows.Forms.Button()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_oddr_dtls = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cstmr_list = New System.Windows.Forms.ListView()
        Me.oi_id_col = New System.Windows.Forms.ColumnHeader()
        Me.oi_qty_col = New System.Windows.Forms.ColumnHeader()
        Me.oi_pprice_col = New System.Windows.Forms.ColumnHeader()
        Me.oi_total_col = New System.Windows.Forms.ColumnHeader()
        Me.oi_todayDate_col = New System.Windows.Forms.ColumnHeader()
        Me.io_prod_id = New System.Windows.Forms.ColumnHeader()
        Me.btn_oi_insert = New System.Windows.Forms.Button()
        Me.btn_oi_delete = New System.Windows.Forms.Button()
        Me.btn_oi_update = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_suppl
        '
        Me.btn_suppl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_suppl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_suppl.Location = New System.Drawing.Point(22, 37)
        Me.btn_suppl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_suppl.Name = "btn_suppl"
        Me.btn_suppl.Size = New System.Drawing.Size(82, 22)
        Me.btn_suppl.TabIndex = 1
        Me.btn_suppl.Text = "Supply"
        Me.btn_suppl.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prod.Location = New System.Drawing.Point(22, 70)
        Me.btn_prod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(82, 22)
        Me.btn_prod.TabIndex = 2
        Me.btn_prod.Text = "Products"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_oddr_dtls
        '
        Me.btn_oddr_dtls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oddr_dtls.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(22, 104)
        Me.btn_oddr_dtls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oddr_dtls.Name = "btn_oddr_dtls"
        Me.btn_oddr_dtls.Size = New System.Drawing.Size(82, 22)
        Me.btn_oddr_dtls.TabIndex = 3
        Me.btn_oddr_dtls.Text = "Customers"
        Me.btn_oddr_dtls.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orders.Location = New System.Drawing.Point(22, 137)
        Me.btn_orders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(82, 22)
        Me.btn_orders.TabIndex = 4
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(125, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ordered Items"
        '
        'cstmr_list
        '
        Me.cstmr_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.oi_id_col, Me.oi_qty_col, Me.oi_pprice_col, Me.oi_total_col, Me.oi_todayDate_col, Me.io_prod_id})
        Me.cstmr_list.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cstmr_list.GridLines = True
        Me.cstmr_list.HoverSelection = True
        Me.cstmr_list.Location = New System.Drawing.Point(125, 37)
        Me.cstmr_list.Name = "cstmr_list"
        Me.cstmr_list.RightToLeftLayout = True
        Me.cstmr_list.Size = New System.Drawing.Size(527, 224)
        Me.cstmr_list.TabIndex = 10
        Me.cstmr_list.UseCompatibleStateImageBehavior = False
        Me.cstmr_list.View = System.Windows.Forms.View.Details
        '
        'oi_id_col
        '
        Me.oi_id_col.Text = "ID"
        Me.oi_id_col.Width = 50
        '
        'oi_qty_col
        '
        Me.oi_qty_col.Text = "Quantity"
        Me.oi_qty_col.Width = 80
        '
        'oi_pprice_col
        '
        Me.oi_pprice_col.Text = "Product price"
        Me.oi_pprice_col.Width = 115
        '
        'oi_total_col
        '
        Me.oi_total_col.Text = "Total Amount"
        Me.oi_total_col.Width = 135
        '
        'oi_todayDate_col
        '
        Me.oi_todayDate_col.Text = "Todays Date"
        Me.oi_todayDate_col.Width = 110
        '
        'io_prod_id
        '
        Me.io_prod_id.Text = "Product ID"
        Me.io_prod_id.Width = 110
        '
        'btn_oi_insert
        '
        Me.btn_oi_insert.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btn_oi_insert.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_insert.Location = New System.Drawing.Point(22, 178)
        Me.btn_oi_insert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oi_insert.Name = "btn_oi_insert"
        Me.btn_oi_insert.Size = New System.Drawing.Size(82, 22)
        Me.btn_oi_insert.TabIndex = 11
        Me.btn_oi_insert.Text = "Insert"
        Me.btn_oi_insert.UseVisualStyleBackColor = False
        '
        'btn_oi_delete
        '
        Me.btn_oi_delete.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btn_oi_delete.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_delete.Location = New System.Drawing.Point(22, 217)
        Me.btn_oi_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oi_delete.Name = "btn_oi_delete"
        Me.btn_oi_delete.Size = New System.Drawing.Size(82, 22)
        Me.btn_oi_delete.TabIndex = 12
        Me.btn_oi_delete.Text = "Delete"
        Me.btn_oi_delete.UseVisualStyleBackColor = False
        '
        'btn_oi_update
        '
        Me.btn_oi_update.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btn_oi_update.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_update.Location = New System.Drawing.Point(22, 252)
        Me.btn_oi_update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oi_update.Name = "btn_oi_update"
        Me.btn_oi_update.Size = New System.Drawing.Size(82, 22)
        Me.btn_oi_update.TabIndex = 13
        Me.btn_oi_update.Text = "Update"
        Me.btn_oi_update.UseVisualStyleBackColor = False
        '
        'Form_orderItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(662, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_oi_update)
        Me.Controls.Add(Me.btn_oi_delete)
        Me.Controls.Add(Me.btn_oi_insert)
        Me.Controls.Add(Me.cstmr_list)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_suppl)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_oddr_dtls)
        Me.Controls.Add(Me.btn_orders)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form_orderItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordered Items"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_suppl As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_oddr_dtls As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cstmr_list As ListView
    Friend WithEvents oi_id_col As ColumnHeader
    Friend WithEvents oi_qty_col As ColumnHeader
    Friend WithEvents oi_pprice_col As ColumnHeader
    Friend WithEvents oi_total_col As ColumnHeader
    Friend WithEvents oi_todayDate_col As ColumnHeader
    Friend WithEvents io_prod_id As ColumnHeader
    Friend WithEvents btn_oi_insert As Button
    Friend WithEvents btn_oi_delete As Button
    Friend WithEvents btn_oi_update As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
End Class
