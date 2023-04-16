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
        Me.cstmr_list = New System.Windows.Forms.ListView()
        Me.prod_id_col = New System.Windows.Forms.ColumnHeader()
        Me.prod_name_col = New System.Windows.Forms.ColumnHeader()
        Me.prod_suppID_col = New System.Windows.Forms.ColumnHeader()
        Me.prod_unitPrice_col = New System.Windows.Forms.ColumnHeader()
        Me.btn_suppl = New System.Windows.Forms.Button()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_oddr_dtls = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cstmr_list
        '
        Me.cstmr_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.prod_id_col, Me.prod_name_col, Me.prod_suppID_col, Me.prod_unitPrice_col})
        Me.cstmr_list.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cstmr_list.GridLines = True
        Me.cstmr_list.Location = New System.Drawing.Point(131, 50)
        Me.cstmr_list.Name = "cstmr_list"
        Me.cstmr_list.Size = New System.Drawing.Size(394, 200)
        Me.cstmr_list.TabIndex = 11
        Me.cstmr_list.UseCompatibleStateImageBehavior = False
        Me.cstmr_list.View = System.Windows.Forms.View.Details
        '
        'prod_id_col
        '
        Me.prod_id_col.Text = "Product ID"
        Me.prod_id_col.Width = 100
        '
        'prod_name_col
        '
        Me.prod_name_col.Text = "Product Name"
        Me.prod_name_col.Width = 130
        '
        'prod_suppID_col
        '
        Me.prod_suppID_col.Text = "Supplier ID"
        Me.prod_suppID_col.Width = 115
        '
        'prod_unitPrice_col
        '
        Me.prod_unitPrice_col.Text = "Unit Price"
        Me.prod_unitPrice_col.Width = 100
        '
        'btn_suppl
        '
        Me.btn_suppl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_suppl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_suppl.Location = New System.Drawing.Point(10, 91)
        Me.btn_suppl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_suppl.Name = "btn_suppl"
        Me.btn_suppl.Size = New System.Drawing.Size(82, 22)
        Me.btn_suppl.TabIndex = 15
        Me.btn_suppl.Text = "Supply"
        Me.btn_suppl.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prod.Location = New System.Drawing.Point(10, 52)
        Me.btn_prod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(95, 22)
        Me.btn_prod.TabIndex = 14
        Me.btn_prod.Text = "Order Items"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_oddr_dtls
        '
        Me.btn_oddr_dtls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oddr_dtls.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(10, 164)
        Me.btn_oddr_dtls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oddr_dtls.Name = "btn_oddr_dtls"
        Me.btn_oddr_dtls.Size = New System.Drawing.Size(82, 22)
        Me.btn_oddr_dtls.TabIndex = 13
        Me.btn_oddr_dtls.Text = "Customers"
        Me.btn_oddr_dtls.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orders.Location = New System.Drawing.Point(10, 128)
        Me.btn_orders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(82, 22)
        Me.btn_orders.TabIndex = 12
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(131, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Products"
        '
        'Form_products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(536, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_suppl)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_oddr_dtls)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.cstmr_list)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form_products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cstmr_list As ListView
    Friend WithEvents prod_id_col As ColumnHeader
    Friend WithEvents prod_name_col As ColumnHeader
    Friend WithEvents prod_suppID_col As ColumnHeader
    Friend WithEvents prod_unitPrice_col As ColumnHeader
    Friend WithEvents btn_suppl As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_oddr_dtls As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents Label1 As Label
End Class
