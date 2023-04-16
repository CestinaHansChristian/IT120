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
        Me.backup_db = New System.Windows.Forms.Button()
        Me.close_btn_cstmr = New System.Windows.Forms.Button()
        Me.load_data = New System.Windows.Forms.OpenFileDialog()
        Me.load_cstmr_info = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cstmr_list
        '
        Me.cstmr_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cust_ID_col, Me.F_name_col, Me.L_name_col, Me.pnum_col, Me.email_col})
        Me.cstmr_list.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cstmr_list.GridLines = True
        Me.cstmr_list.Location = New System.Drawing.Point(127, 96)
        Me.cstmr_list.Name = "cstmr_list"
        Me.cstmr_list.Size = New System.Drawing.Size(536, 220)
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
        Me.btn_orders.Location = New System.Drawing.Point(12, 211)
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
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(12, 96)
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
        Me.btn_prod.Location = New System.Drawing.Point(12, 133)
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
        Me.btn_suppl.Location = New System.Drawing.Point(12, 170)
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
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customers"
        '
        'backup_db
        '
        Me.backup_db.BackColor = System.Drawing.Color.Aqua
        Me.backup_db.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.backup_db.Location = New System.Drawing.Point(576, 16)
        Me.backup_db.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backup_db.Name = "backup_db"
        Me.backup_db.Size = New System.Drawing.Size(87, 38)
        Me.backup_db.TabIndex = 7
        Me.backup_db.Text = "Backup DB"
        Me.backup_db.UseVisualStyleBackColor = False
        '
        'close_btn_cstmr
        '
        Me.close_btn_cstmr.BackColor = System.Drawing.Color.Salmon
        Me.close_btn_cstmr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.close_btn_cstmr.Location = New System.Drawing.Point(12, 274)
        Me.close_btn_cstmr.Name = "close_btn_cstmr"
        Me.close_btn_cstmr.Size = New System.Drawing.Size(80, 27)
        Me.close_btn_cstmr.TabIndex = 9
        Me.close_btn_cstmr.Text = "Close"
        Me.close_btn_cstmr.UseVisualStyleBackColor = False
        '
        'load_data
        '
        Me.load_data.FileName = "load data"
        '
        'load_cstmr_info
        '
        Me.load_cstmr_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.load_cstmr_info.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.load_cstmr_info.Location = New System.Drawing.Point(376, 16)
        Me.load_cstmr_info.Name = "load_cstmr_info"
        Me.load_cstmr_info.Size = New System.Drawing.Size(174, 38)
        Me.load_cstmr_info.TabIndex = 10
        Me.load_cstmr_info.Text = "Load Customer Info"
        Me.load_cstmr_info.UseVisualStyleBackColor = False
        '
        'form_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(675, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.load_cstmr_info)
        Me.Controls.Add(Me.close_btn_cstmr)
        Me.Controls.Add(Me.backup_db)
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
    Friend WithEvents backup_db As Button
    Friend WithEvents close_btn_cstmr As Button
    Friend WithEvents load_data As OpenFileDialog
    Friend WithEvents load_cstmr_info As Button
End Class
