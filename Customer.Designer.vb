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
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.btn_oddr_dtls = New System.Windows.Forms.Button()
        Me.btn_prod = New System.Windows.Forms.Button()
        Me.btn_suppl = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backup_db = New System.Windows.Forms.Button()
        Me.close_btn_cstmr = New System.Windows.Forms.Button()
        Me.load_cstmr_info = New System.Windows.Forms.Button()
        Me.grid_view_customer = New System.Windows.Forms.DataGridView()
        Me.btn_export_cstmr = New System.Windows.Forms.Button()
        Me.open_file = New System.Windows.Forms.OpenFileDialog()
        CType(Me.grid_view_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_orders
        '
        Me.btn_orders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_orders.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_orders.Location = New System.Drawing.Point(14, 281)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(94, 29)
        Me.btn_orders.TabIndex = 4
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = False
        '
        'btn_oddr_dtls
        '
        Me.btn_oddr_dtls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_oddr_dtls.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_oddr_dtls.Location = New System.Drawing.Point(14, 128)
        Me.btn_oddr_dtls.Name = "btn_oddr_dtls"
        Me.btn_oddr_dtls.Size = New System.Drawing.Size(113, 29)
        Me.btn_oddr_dtls.TabIndex = 1
        Me.btn_oddr_dtls.Text = "Order Details"
        Me.btn_oddr_dtls.UseVisualStyleBackColor = False
        '
        'btn_prod
        '
        Me.btn_prod.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_prod.Location = New System.Drawing.Point(14, 177)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Size = New System.Drawing.Size(94, 29)
        Me.btn_prod.TabIndex = 2
        Me.btn_prod.Text = "Products"
        Me.btn_prod.UseVisualStyleBackColor = False
        '
        'btn_suppl
        '
        Me.btn_suppl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_suppl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_suppl.Location = New System.Drawing.Point(14, 227)
        Me.btn_suppl.Name = "btn_suppl"
        Me.btn_suppl.Size = New System.Drawing.Size(94, 29)
        Me.btn_suppl.TabIndex = 3
        Me.btn_suppl.Text = "Supply"
        Me.btn_suppl.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customers"
        '
        'backup_db
        '
        Me.backup_db.BackColor = System.Drawing.Color.Aqua
        Me.backup_db.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.backup_db.Location = New System.Drawing.Point(658, 21)
        Me.backup_db.Name = "backup_db"
        Me.backup_db.Size = New System.Drawing.Size(99, 51)
        Me.backup_db.TabIndex = 7
        Me.backup_db.Text = "Backup DB"
        Me.backup_db.UseVisualStyleBackColor = False
        '
        'close_btn_cstmr
        '
        Me.close_btn_cstmr.BackColor = System.Drawing.Color.Salmon
        Me.close_btn_cstmr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.close_btn_cstmr.Location = New System.Drawing.Point(14, 365)
        Me.close_btn_cstmr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.close_btn_cstmr.Name = "close_btn_cstmr"
        Me.close_btn_cstmr.Size = New System.Drawing.Size(91, 36)
        Me.close_btn_cstmr.TabIndex = 9
        Me.close_btn_cstmr.Text = "Close"
        Me.close_btn_cstmr.UseVisualStyleBackColor = False
        '
        'load_cstmr_info
        '
        Me.load_cstmr_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.load_cstmr_info.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.load_cstmr_info.Location = New System.Drawing.Point(453, 19)
        Me.load_cstmr_info.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.load_cstmr_info.Name = "load_cstmr_info"
        Me.load_cstmr_info.Size = New System.Drawing.Size(199, 51)
        Me.load_cstmr_info.TabIndex = 10
        Me.load_cstmr_info.Text = "Load Customer Info"
        Me.load_cstmr_info.UseVisualStyleBackColor = False
        '
        'grid_view_customer
        '
        Me.grid_view_customer.AllowUserToAddRows = False
        Me.grid_view_customer.AllowUserToDeleteRows = False
        Me.grid_view_customer.AllowUserToResizeColumns = False
        Me.grid_view_customer.AllowUserToResizeRows = False
        Me.grid_view_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_view_customer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_view_customer.ColumnHeadersHeight = 29
        Me.grid_view_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_view_customer.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.grid_view_customer.Location = New System.Drawing.Point(149, 128)
        Me.grid_view_customer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grid_view_customer.MultiSelect = False
        Me.grid_view_customer.Name = "grid_view_customer"
        Me.grid_view_customer.ReadOnly = True
        Me.grid_view_customer.RowHeadersWidth = 51
        Me.grid_view_customer.RowTemplate.Height = 25
        Me.grid_view_customer.ShowCellErrors = False
        Me.grid_view_customer.ShowCellToolTips = False
        Me.grid_view_customer.ShowEditingIcon = False
        Me.grid_view_customer.Size = New System.Drawing.Size(609, 293)
        Me.grid_view_customer.TabIndex = 11
        '
        'btn_export_cstmr
        '
        Me.btn_export_cstmr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_export_cstmr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_export_cstmr.Location = New System.Drawing.Point(333, 20)
        Me.btn_export_cstmr.Name = "btn_export_cstmr"
        Me.btn_export_cstmr.Size = New System.Drawing.Size(104, 51)
        Me.btn_export_cstmr.TabIndex = 12
        Me.btn_export_cstmr.Text = "Export"
        Me.btn_export_cstmr.UseVisualStyleBackColor = False
        '
        'open_file
        '
        Me.open_file.FileName = "open_file"
        '
        'form_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(771, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_export_cstmr)
        Me.Controls.Add(Me.grid_view_customer)
        Me.Controls.Add(Me.load_cstmr_info)
        Me.Controls.Add(Me.close_btn_cstmr)
        Me.Controls.Add(Me.backup_db)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_suppl)
        Me.Controls.Add(Me.btn_prod)
        Me.Controls.Add(Me.btn_oddr_dtls)
        Me.Controls.Add(Me.btn_orders)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "form_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        CType(Me.grid_view_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_orders As Button
    Friend WithEvents btn_oddr_dtls As Button
    Friend WithEvents btn_prod As Button
    Friend WithEvents btn_suppl As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents backup_db As Button
    Friend WithEvents close_btn_cstmr As Button
    Friend WithEvents load_cstmr_info As Button
    Friend WithEvents load_data As OpenFileDialog
    Friend WithEvents btn_export_cstmr As Button
    Friend WithEvents open_file As OpenFileDialog
    Friend WithEvents grid_view_customer As DataGridView
End Class
