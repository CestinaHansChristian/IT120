<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_orderItems
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
        Me.btn_suppl = New System.Windows.Forms.Button()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_oddr_dtls = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_oi_insert = New System.Windows.Forms.Button()
        Me.btn_oi_delete = New System.Windows.Forms.Button()
        Me.btn_oi_update = New System.Windows.Forms.Button()
        Me.oi_table = New System.Windows.Forms.DataGridView()
        Me.Export_Ordered_items = New System.Windows.Forms.Button()
        CType(Me.oi_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_suppl
        '
        Me.btn_suppl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_suppl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_suppl.Location = New System.Drawing.Point(25, 49)
        Me.btn_suppl.Name = "btn_suppl"
        Me.btn_suppl.Size = New System.Drawing.Size(94, 29)
        Me.btn_suppl.TabIndex = 1
        Me.btn_suppl.Text = "Supply"
        Me.btn_suppl.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prod.Location = New System.Drawing.Point(25, 93)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(94, 29)
        Me.btn_prod.TabIndex = 2
        Me.btn_prod.Text = "Products"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_oddr_dtls
        '
        Me.btn_oddr_dtls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oddr_dtls.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(25, 139)
        Me.btn_oddr_dtls.Name = "btn_oddr_dtls"
        Me.btn_oddr_dtls.Size = New System.Drawing.Size(94, 29)
        Me.btn_oddr_dtls.TabIndex = 3
        Me.btn_oddr_dtls.Text = "Customers"
        Me.btn_oddr_dtls.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orders.Location = New System.Drawing.Point(25, 183)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(94, 29)
        Me.btn_orders.TabIndex = 4
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(143, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ordered Items"
        '
        'btn_oi_insert
        '
        Me.btn_oi_insert.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btn_oi_insert.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_insert.Location = New System.Drawing.Point(25, 237)
        Me.btn_oi_insert.Name = "btn_oi_insert"
        Me.btn_oi_insert.Size = New System.Drawing.Size(94, 29)
        Me.btn_oi_insert.TabIndex = 11
        Me.btn_oi_insert.Text = "Insert"
        Me.btn_oi_insert.UseVisualStyleBackColor = False
        '
        'btn_oi_delete
        '
        Me.btn_oi_delete.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btn_oi_delete.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_delete.Location = New System.Drawing.Point(25, 289)
        Me.btn_oi_delete.Name = "btn_oi_delete"
        Me.btn_oi_delete.Size = New System.Drawing.Size(94, 29)
        Me.btn_oi_delete.TabIndex = 12
        Me.btn_oi_delete.Text = "Delete"
        Me.btn_oi_delete.UseVisualStyleBackColor = False
        '
        'btn_oi_update
        '
        Me.btn_oi_update.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btn_oi_update.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oi_update.Location = New System.Drawing.Point(25, 336)
        Me.btn_oi_update.Name = "btn_oi_update"
        Me.btn_oi_update.Size = New System.Drawing.Size(94, 29)
        Me.btn_oi_update.TabIndex = 13
        Me.btn_oi_update.Text = "Update"
        Me.btn_oi_update.UseVisualStyleBackColor = False
        '
        'oi_table
        '
        Me.oi_table.AllowUserToAddRows = False
        Me.oi_table.AllowUserToDeleteRows = False
        Me.oi_table.AllowUserToOrderColumns = True
        Me.oi_table.AllowUserToResizeColumns = False
        Me.oi_table.AllowUserToResizeRows = False
        Me.oi_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.oi_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.oi_table.ColumnHeadersHeight = 29
        Me.oi_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.oi_table.Location = New System.Drawing.Point(143, 49)
        Me.oi_table.MultiSelect = False
        Me.oi_table.Name = "oi_table"
        Me.oi_table.ReadOnly = True
        Me.oi_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.oi_table.RowTemplate.Height = 29
        Me.oi_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.oi_table.Size = New System.Drawing.Size(602, 316)
        Me.oi_table.TabIndex = 14
        '
        'Export_Ordered_items
        '
        Me.Export_Ordered_items.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Export_Ordered_items.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Export_Ordered_items.Location = New System.Drawing.Point(651, 8)
        Me.Export_Ordered_items.Name = "Export_Ordered_items"
        Me.Export_Ordered_items.Size = New System.Drawing.Size(94, 35)
        Me.Export_Ordered_items.TabIndex = 15
        Me.Export_Ordered_items.Text = "Export"
        Me.Export_Ordered_items.UseVisualStyleBackColor = False
        '
        'Form_orderItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(757, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.Export_Ordered_items)
        Me.Controls.Add(Me.oi_table)
        Me.Controls.Add(Me.btn_oi_update)
        Me.Controls.Add(Me.btn_oi_delete)
        Me.Controls.Add(Me.btn_oi_insert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_suppl)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_oddr_dtls)
        Me.Controls.Add(Me.btn_orders)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form_orderItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordered Items"
        CType(Me.oi_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_suppl As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_oddr_dtls As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_oi_insert As Button
    Friend WithEvents btn_oi_delete As Button
    Friend WithEvents btn_oi_update As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents oi_table As DataGridView
    Friend WithEvents Export_Ordered_items As Button
End Class
