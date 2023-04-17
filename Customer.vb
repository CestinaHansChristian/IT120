Imports System.IO
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class form_customer

    Private Sub btn_oddr_dtls_Click(sender As Object, e As EventArgs) Handles btn_oddr_dtls.Click

        Form_orderItems.Show()
        Me.Close()
    End Sub

    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click

        Form_products.Show()
        Me.Close()
    End Sub

    Private Sub btn_suppl_Click(sender As Object, e As EventArgs) Handles btn_suppl.Click

        Form_supply.Show()
        Me.Close()
    End Sub
    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click

        Form_orders.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles backup_db.Click
        Try
            Process.Start("cmd", "/c mysqldump -u root -p it120e > C:\Users\user\Desktop\backupDB.sql")
            MsgBox("Backup successfully created and added to Desktop", vbOKOnly + vbInformation, "Status")
        Catch ex As Exception
            MsgBox("Unable to create backup file", vbOKOnly, "Status")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles close_btn_cstmr.Click
        Application.Exit()
    End Sub

    Private Sub load_cstmr_info_Click(sender As Object, e As EventArgs) Handles load_cstmr_info.Click
        Try
            ' load file
            load_data.Title = "Select a load file"
            load_data.Filter = "CSV FILES | *.csv"
            load_data.ShowDialog()

            ' store file location and name
            Dim file_loc As String = load_data.FileName
            Dim reader As New TextFieldParser(file_loc)
            reader.SetDelimiters(",")
            reader.TextFieldType = FileIO.FieldType.Delimited
            Dim thisRow As String()
            While Not reader.EndOfData
                Try
                    thisRow = reader.ReadFields
                    For Each curfield As String In thisRow
                        grid_view_customer.Rows.Add(thisRow)
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message & "Invalid option")
                End Try
                Dim pass = grid_view_customer
            End While
        Catch ex As Exception
            MsgBox(ex.Message & "invalid option")
        End Try
    End Sub
End Class

