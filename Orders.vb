Public Class Form_orders
    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click

        Form_orderItems.Show()
        Me.Close()
    End Sub

    Private Sub btn_suppl_Click(sender As Object, e As EventArgs) Handles btn_suppl.Click

        Form_supply.Show()
        Me.Close()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_prods.Click

        Form_products.Show()
        Me.Close()
    End Sub

    Private Sub btn_oddr_dtls_Click(sender As Object, e As EventArgs) Handles btn_oddr_dtls.Click
        form_customer.Show()
        Me.Close()
    End Sub

    Private Sub Form_orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openDB()
        Dim formThis As String = "Select * from orders"
        load_data_to_grid(formThis, order_view)
    End Sub

    Private Sub Export_button_orders_Click(sender As Object, e As EventArgs) Handles Export_button_orders.Click
        toExcel(order_view, "Orders")
    End Sub
End Class