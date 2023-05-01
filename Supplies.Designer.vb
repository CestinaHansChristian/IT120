<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_supply
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
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_orderItems = New System.Windows.Forms.Button()
        Me.btn_customers = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.supply_view = New System.Windows.Forms.DataGridView()
        Me.Export_button_excel = New System.Windows.Forms.Button()
        CType(Me.supply_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prod.Location = New System.Drawing.Point(11, 116)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(94, 29)
        Me.btn_prod.TabIndex = 23
        Me.btn_prod.Text = "Products"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_orderItems
        '
        Me.btn_orderItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orderItems.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orderItems.Location = New System.Drawing.Point(11, 65)
        Me.btn_orderItems.Name = "btn_orderItems"
        Me.btn_orderItems.Size = New System.Drawing.Size(109, 29)
        Me.btn_orderItems.TabIndex = 22
        Me.btn_orderItems.Text = "Order Items"
        Me.btn_orderItems.UseVisualStyleBackColor = False
        '
        'btn_customers
        '
        Me.btn_customers.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_customers.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_customers.Location = New System.Drawing.Point(11, 213)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.Size = New System.Drawing.Size(94, 29)
        Me.btn_customers.TabIndex = 21
        Me.btn_customers.Text = "Customers"
        Me.btn_customers.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orders.Location = New System.Drawing.Point(11, 165)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(94, 29)
        Me.btn_orders.TabIndex = 20
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(136, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Supplies"
        '
        'supply_view
        '
        Me.supply_view.AllowDrop = True
        Me.supply_view.AllowUserToAddRows = False
        Me.supply_view.AllowUserToDeleteRows = False
        Me.supply_view.AllowUserToOrderColumns = True
        Me.supply_view.AllowUserToResizeColumns = False
        Me.supply_view.AllowUserToResizeRows = False
        Me.supply_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.supply_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.supply_view.ColumnHeadersHeight = 29
        Me.supply_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.supply_view.Location = New System.Drawing.Point(155, 65)
        Me.supply_view.Name = "supply_view"
        Me.supply_view.RowHeadersWidth = 51
        Me.supply_view.RowTemplate.Height = 29
        Me.supply_view.Size = New System.Drawing.Size(522, 307)
        Me.supply_view.TabIndex = 25
        '
        'Export_button_excel
        '
        Me.Export_button_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Export_button_excel.Location = New System.Drawing.Point(583, 22)
        Me.Export_button_excel.Name = "Export_button_excel"
        Me.Export_button_excel.Size = New System.Drawing.Size(94, 29)
        Me.Export_button_excel.TabIndex = 26
        Me.Export_button_excel.Text = "Export"
        Me.Export_button_excel.UseVisualStyleBackColor = False
        '
        'Form_supply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(689, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.Export_button_excel)
        Me.Controls.Add(Me.supply_view)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_orderItems)
        Me.Controls.Add(Me.btn_customers)
        Me.Controls.Add(Me.btn_orders)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form_supply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplies"
        CType(Me.supply_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_orderItems As Button
    Friend WithEvents btn_customers As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents supply_view As DataGridView
    Friend WithEvents Export_button_excel As Button
End Class
