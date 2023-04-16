Imports System.IO
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
            Process.Start("cmd", "/c mysqldump -u root -p Admin123 it120e > C:\Users\user\Desktop\backupDB.sql")
            MsgBox("Backup successfully created and added to Desktop", vbOKOnly + vbInformation, "Status")
        Catch ex As Exception
            MsgBox("Unable to create backup file", vbOKOnly, "Status")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles close_btn_cstmr.Click
        Application.Exit()
    End Sub

    Private Sub load_data_Click(sender As Object, e As EventArgs) Handles load_data.Click
        Try
            Dim as
        Catch ex As Exception

        End Try
    End Sub

End Class