Public Class oi_insert_table
    Private Sub btn_oi_insert_Click(sender As Object, e As EventArgs) Handles btn_oi_insert.Click
        MsgBox("Record Added!", vbOK, "Status")
    End Sub

    Private Sub btn_oi_exit_Click(sender As Object, e As EventArgs) Handles btn_oi_exit.Click
        Me.Close()
    End Sub
End Class