
Public Class Login_page
    Dim username As String = "Admin"
    Dim password As String = "Cestina"

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        MsgBox("Logged in successfull", vbInformation, "Status")
        'Try
        '    If Me.txtbox_user = username && Me.txtbox_pass <> password Then
        form_customer.Show()
        Me.Hide()
        '    End If
        'Catch ex As Exception
        '    MsgBox("Invalid Credentials", vbCritical, "Status")
        'End Try

    End Sub
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Application.Exit()
    End Sub

    Private Sub Login_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
