Public Class oi_delete_table
    Private Sub btn_proceed_deleteTable_Click(sender As Object, e As EventArgs) Handles btn_proceed_deleteTable.Click
        MsgBox("Record deleted", vbOK, "Status")
    End Sub

    Private Sub btn_oi_delete_table_Click(sender As Object, e As EventArgs) Handles btn_oi_delete_table.Click
        MsgBox("Process Closed", vbInformation, "Status")
        Me.Close()
    End Sub
End Class