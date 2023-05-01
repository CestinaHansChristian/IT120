<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_products
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
        Me.prod_view = New System.Windows.Forms.DataGridView()
        Me.Export_button_Products = New System.Windows.Forms.Button()
        CType(Me.prod_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_suppl
        '
        Me.btn_suppl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_suppl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_suppl.Location = New System.Drawing.Point(11, 121)
        Me.btn_suppl.Name = "btn_suppl"
        Me.btn_suppl.Size = New System.Drawing.Size(94, 29)
        Me.btn_suppl.TabIndex = 15
        Me.btn_suppl.Text = "Supply"
        Me.btn_suppl.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prod.Location = New System.Drawing.Point(11, 69)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(109, 29)
        Me.btn_prod.TabIndex = 14
        Me.btn_prod.Text = "Order Items"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_oddr_dtls
        '
        Me.btn_oddr_dtls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oddr_dtls.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(11, 219)
        Me.btn_oddr_dtls.Name = "btn_oddr_dtls"
        Me.btn_oddr_dtls.Size = New System.Drawing.Size(94, 29)
        Me.btn_oddr_dtls.TabIndex = 13
        Me.btn_oddr_dtls.Text = "Customers"
        Me.btn_oddr_dtls.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orders.Location = New System.Drawing.Point(11, 171)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(94, 29)
        Me.btn_orders.TabIndex = 12
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(150, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 28)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Products"
        '
        'prod_view
        '
        Me.prod_view.AllowUserToAddRows = False
        Me.prod_view.AllowUserToDeleteRows = False
        Me.prod_view.AllowUserToOrderColumns = True
        Me.prod_view.AllowUserToResizeColumns = False
        Me.prod_view.AllowUserToResizeRows = False
        Me.prod_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.prod_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.prod_view.ColumnHeadersHeight = 29
        Me.prod_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.prod_view.Location = New System.Drawing.Point(141, 69)
        Me.prod_view.Name = "prod_view"
        Me.prod_view.RowHeadersWidth = 51
        Me.prod_view.RowTemplate.Height = 29
        Me.prod_view.Size = New System.Drawing.Size(460, 270)
        Me.prod_view.TabIndex = 17
        '
        'Export_button_Products
        '
        Me.Export_button_Products.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Export_button_Products.Location = New System.Drawing.Point(507, 18)
        Me.Export_button_Products.Name = "Export_button_Products"
        Me.Export_button_Products.Size = New System.Drawing.Size(94, 29)
        Me.Export_button_Products.TabIndex = 18
        Me.Export_button_Products.Text = "Export"
        Me.Export_button_Products.UseVisualStyleBackColor = False
        '
        'Form_products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(613, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.Export_button_Products)
        Me.Controls.Add(Me.prod_view)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_suppl)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_oddr_dtls)
        Me.Controls.Add(Me.btn_orders)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form_products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        CType(Me.prod_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_suppl As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_oddr_dtls As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents prod_view As DataGridView
    Friend WithEvents Export_button_Products As Button
End Class
