<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_customer
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
        Me.cstmr_list = New System.Windows.Forms.ListView()
        Me.cust_ID_col = New System.Windows.Forms.ColumnHeader()
        Me.F_name_col = New System.Windows.Forms.ColumnHeader()
        Me.L_name_col = New System.Windows.Forms.ColumnHeader()
        Me.pnum_col = New System.Windows.Forms.ColumnHeader()
        Me.email_col = New System.Windows.Forms.ColumnHeader()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.btn_oddr_dtls = New System.Windows.Forms.Button()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_suppl = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.backup_db = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cstmr_list
        '
        Me.cstmr_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cust_ID_col, Me.F_name_col, Me.L_name_col, Me.pnum_col, Me.email_col})
        Me.cstmr_list.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cstmr_list.GridLines = True
        Me.cstmr_list.Location = New System.Drawing.Point(127, 59)
        Me.cstmr_list.Name = "cstmr_list"
        Me.cstmr_list.Size = New System.Drawing.Size(472, 196)
        Me.cstmr_list.TabIndex = 0
        Me.cstmr_list.UseCompatibleStateImageBehavior = False
        Me.cstmr_list.View = System.Windows.Forms.View.Details
        '
        'cust_ID_col
        '
        Me.cust_ID_col.Text = "ID"
        Me.cust_ID_col.Width = 50
        '
        'F_name_col
        '
        Me.F_name_col.Text = "First Name"
        Me.F_name_col.Width = 115
        '
        'L_name_col
        '
        Me.L_name_col.Text = "Last Name"
        Me.L_name_col.Width = 115
        '
        'pnum_col
        '
        Me.pnum_col.Text = "Phone Number"
        Me.pnum_col.Width = 135
        '
        'email_col
        '
        Me.email_col.Text = "Email"
        Me.email_col.Width = 150
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orders.Location = New System.Drawing.Point(10, 166)
        Me.btn_orders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(82, 22)
        Me.btn_orders.TabIndex = 4
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'btn_oddr_dtls
        '
        Me.btn_oddr_dtls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oddr_dtls.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(10, 59)
        Me.btn_oddr_dtls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_oddr_dtls.Name = "btn_oddr_dtls"
        Me.btn_oddr_dtls.Size = New System.Drawing.Size(99, 22)
        Me.btn_oddr_dtls.TabIndex = 1
        Me.btn_oddr_dtls.Text = "Order Details"
        Me.btn_oddr_dtls.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prod.Location = New System.Drawing.Point(10, 94)
        Me.btn_prod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(82, 22)
        Me.btn_prod.TabIndex = 2
        Me.btn_prod.Text = "Products"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_suppl
        '
        Me.btn_suppl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_suppl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_suppl.Location = New System.Drawing.Point(10, 128)
        Me.btn_suppl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_suppl.Name = "btn_suppl"
        Me.btn_suppl.Size = New System.Drawing.Size(82, 22)
        Me.btn_suppl.TabIndex = 3
        Me.btn_suppl.Text = "Supply"
        Me.btn_suppl.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(127, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customers"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Goldenrod
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(290, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 22)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Load cstmr Details"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'backup_db
        '
        Me.backup_db.BackColor = System.Drawing.Color.Aqua
        Me.backup_db.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.backup_db.Location = New System.Drawing.Point(495, 28)
        Me.backup_db.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backup_db.Name = "backup_db"
        Me.backup_db.Size = New System.Drawing.Size(82, 22)
        Me.backup_db.TabIndex = 7
        Me.backup_db.Text = "Backup DB"
        Me.backup_db.UseVisualStyleBackColor = False
        '
        'form_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(609, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.backup_db)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_suppl)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_oddr_dtls)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.cstmr_list)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "form_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cstmr_list As ListView
    Friend WithEvents btn_orders As Button
    Friend WithEvents btn_oddr_dtls As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_suppl As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cust_ID_col As ColumnHeader
    Friend WithEvents F_name_col As ColumnHeader
    Friend WithEvents L_name_col As ColumnHeader
    Friend WithEvents pnum_col As ColumnHeader
    Friend WithEvents email_col As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents backup_db As Button
End Class
