<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_orders
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
        Me.btn_prods = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.order_view = New System.Windows.Forms.DataGridView()
        Me.Export_button_orders = New System.Windows.Forms.Button()
        CType(Me.order_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_suppl
        '
        Me.btn_suppl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_suppl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_suppl.Location = New System.Drawing.Point(23, 129)
        Me.btn_suppl.Name = "btn_suppl"
        Me.btn_suppl.Size = New System.Drawing.Size(94, 29)
        Me.btn_suppl.TabIndex = 19
        Me.btn_suppl.Text = "Supply"
        Me.btn_suppl.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prod.Location = New System.Drawing.Point(23, 77)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(109, 29)
        Me.btn_prod.TabIndex = 18
        Me.btn_prod.Text = "Order Items"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_oddr_dtls
        '
        Me.btn_oddr_dtls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oddr_dtls.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(23, 227)
        Me.btn_oddr_dtls.Name = "btn_oddr_dtls"
        Me.btn_oddr_dtls.Size = New System.Drawing.Size(94, 29)
        Me.btn_oddr_dtls.TabIndex = 17
        Me.btn_oddr_dtls.Text = "Customers"
        Me.btn_oddr_dtls.UseVisualStyleBackColor = False
        '
        'btn_prods
        '
        Me.btn_prods.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prods.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prods.Location = New System.Drawing.Point(23, 179)
        Me.btn_prods.Name = "btn_prods"
        Me.btn_prods.Size = New System.Drawing.Size(94, 29)
        Me.btn_prods.TabIndex = 16
        Me.btn_prods.Text = "Products"
        Me.btn_prods.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(158, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 28)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Orders"
        '
        'order_view
        '
        Me.order_view.AllowUserToAddRows = False
        Me.order_view.AllowUserToDeleteRows = False
        Me.order_view.AllowUserToResizeColumns = False
        Me.order_view.AllowUserToResizeRows = False
        Me.order_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.order_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.order_view.ColumnHeadersHeight = 29
        Me.order_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.order_view.Location = New System.Drawing.Point(138, 77)
        Me.order_view.MultiSelect = False
        Me.order_view.Name = "order_view"
        Me.order_view.ReadOnly = True
        Me.order_view.RowHeadersWidth = 51
        Me.order_view.RowTemplate.Height = 29
        Me.order_view.Size = New System.Drawing.Size(263, 179)
        Me.order_view.TabIndex = 21
        '
        'Export_button_orders
        '
        Me.Export_button_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Export_button_orders.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Export_button_orders.Location = New System.Drawing.Point(307, 31)
        Me.Export_button_orders.Name = "Export_button_orders"
        Me.Export_button_orders.Size = New System.Drawing.Size(94, 29)
        Me.Export_button_orders.TabIndex = 22
        Me.Export_button_orders.Text = "Export"
        Me.Export_button_orders.UseVisualStyleBackColor = False
        '
        'Form_orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(413, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Export_button_orders)
        Me.Controls.Add(Me.order_view)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_suppl)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_oddr_dtls)
        Me.Controls.Add(Me.btn_prods)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form_orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        CType(Me.order_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_suppl As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_oddr_dtls As Button
    Friend WithEvents btn_prods As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents order_view As DataGridView
    Friend WithEvents Export_button_orders As Button
End Class
