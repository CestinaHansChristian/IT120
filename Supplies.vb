Public Class Form_supply
    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click

        form_customer.Show()
        Me.Close()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click

        Form_orders.Show()
        Me.Close()
    End Sub

    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click

        Form_products.Show()
        Me.Close()
    End Sub

    Private Sub btn_orderItems_Click(sender As Object, e As EventArgs) Handles btn_orderItems.Click

        Form_orderItems.Show()
        Me.Close()
    End Sub

End Class