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
        Me.cstmr_list = New System.Windows.Forms.ListView()
        Me.supp_id_col = New System.Windows.Forms.ColumnHeader()
        Me.supp_compName_col = New System.Windows.Forms.ColumnHeader()
        Me.supp_compContact_col = New System.Windows.Forms.ColumnHeader()
        Me.supp_phone_num = New System.Windows.Forms.ColumnHeader()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_orderItems = New System.Windows.Forms.Button()
        Me.btn_customers = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cstmr_list
        '
        Me.cstmr_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.supp_id_col, Me.supp_compName_col, Me.supp_compContact_col, Me.supp_phone_num})
        Me.cstmr_list.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cstmr_list.GridLines = True
        Me.cstmr_list.Location = New System.Drawing.Point(119, 48)
        Me.cstmr_list.Name = "cstmr_list"
        Me.cstmr_list.Size = New System.Drawing.Size(474, 231)
        Me.cstmr_list.TabIndex = 12
        Me.cstmr_list.UseCompatibleStateImageBehavior = False
        Me.cstmr_list.View = System.Windows.Forms.View.Details
        '
        'supp_id_col
        '
        Me.supp_id_col.Text = "Supply ID"
        Me.supp_id_col.Width = 100
        '
        'supp_compName_col
        '
        Me.supp_compName_col.Text = "Company Name"
        Me.supp_compName_col.Width = 140
        '
        'supp_compContact_col
        '
        Me.supp_compContact_col.Text = "Company Contact"
        Me.supp_compContact_col.Width = 150
        '
        'supp_phone_num
        '
        Me.supp_phone_num.Text = "Contact Number"
        Me.supp_phone_num.Width = 150
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prod.Location = New System.Drawing.Point(10, 87)
        Me.btn_prod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(82, 22)
        Me.btn_prod.TabIndex = 23
        Me.btn_prod.Text = "Products"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_orderItems
        '
        Me.btn_orderItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orderItems.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orderItems.Location = New System.Drawing.Point(10, 49)
        Me.btn_orderItems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_orderItems.Name = "btn_orderItems"
        Me.btn_orderItems.Size = New System.Drawing.Size(95, 22)
        Me.btn_orderItems.TabIndex = 22
        Me.btn_orderItems.Text = "Order Items"
        Me.btn_orderItems.UseVisualStyleBackColor = False
        '
        'btn_customers
        '
        Me.btn_customers.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_customers.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_customers.Location = New System.Drawing.Point(10, 160)
        Me.btn_customers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.Size = New System.Drawing.Size(82, 22)
        Me.btn_customers.TabIndex = 21
        Me.btn_customers.Text = "Customers"
        Me.btn_customers.UseVisualStyleBackColor = False
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orders.Location = New System.Drawing.Point(10, 124)
        Me.btn_orders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(82, 22)
        Me.btn_orders.TabIndex = 20
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(119, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Supplies"
        '
        'Form_supply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(603, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_orderItems)
        Me.Controls.Add(Me.btn_customers)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.cstmr_list)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form_supply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cstmr_list As ListView
    Friend WithEvents supp_id_col As ColumnHeader
    Friend WithEvents supp_compName_col As ColumnHeader
    Friend WithEvents supp_compContact_col As ColumnHeader
    Friend WithEvents supp_phone_num As ColumnHeader
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_orderItems As Button
    Friend WithEvents btn_customers As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents Label1 As Label
End Class
