﻿Imports MySql.Data.MySqlClient

Public Class Form_orderItems
    Private Sub btn_suppl_Click(sender As Object, e As EventArgs) Handles btn_suppl.Click

        Form_supply.Show()
        Me.Close()
    End Sub

    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click

        Form_products.Show()
        Me.Close()
    End Sub

    Private Sub btn_oddr_dtls_Click(sender As Object, e As EventArgs) Handles btn_oddr_dtls.Click

        form_customer.Show()
        Me.Close()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click

        Form_orders.Show()
        Me.Close()
    End Sub

    Private Sub btn_oi_insert_Click(sender As Object, e As EventArgs) Handles btn_oi_insert.Click
        oi_insert_table.Show()
    End Sub

    Private Sub btn_oi_delete_Click(sender As Object, e As EventArgs) Handles btn_oi_delete.Click
        oi_delete_table.Show()
    End Sub

    Private Sub btn_oi_update_Click(sender As Object, e As EventArgs) Handles btn_oi_update.Click
        Ordered_items_update.Show()
    End Sub

    Private Sub Form_orderItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openDB()
        Dim formThis As String = "Select * from orderitems"
        load_data_to_grid(formThis, oi_table)
    End Sub

    Private Sub Export_Ordered_items_Click(sender As Object, e As EventArgs) Handles Export_Ordered_items.Click
        toExcel(oi_table, "Ordered Items")
    End Sub
End Class