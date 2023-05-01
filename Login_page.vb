
Imports MySql.Data.MySqlClient

Public Class Login_page
    Dim adm As String = "admin"
    Dim adp As String = "adminPass"
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Try
            If txtbox_user.Text = adm And txtbox_pass.Text = adp Then
                MsgBox(txtbox_user.Text + " Logged in successfully", vbOKOnly, "Status")
                form_customer.Show()
                Me.Hide()
            Else
                MsgBox(txtbox_user.Text + " is not a valid user", vbOKOnly, "Information")
            End If
            txtbox_user.Clear()
            txtbox_pass.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Call openDB()
        'Dim myreader As MySqlDataReader


        'strSql = "Select user from mysql. user where username = '" _
        '    & .txtbox_user.Text & "' and password = sha2('" _
        '    & .txtbox_pass.Text & "', 224)"
        'Dim mycmd As New MySqlCommand(strSql, myconn)
        'MsgBox(strSql)
        'mycmd.CommandText = strSql
        'mycmd.Connection = myconn

        'myreader = mycmd.ExecuteReader
        'If myreader.HasRows Then
        '    form_customer.Show()
        'Else
        '    MessageBox.Show("Invalid username or password")
        'End If
        'Call closeDB()
    End Sub
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        'closeDB()
        Me.Close()
    End Sub

    Private Sub pass_visibility_CheckedChanged(sender As Object, e As EventArgs) Handles pass_visibility.CheckedChanged
        If pass_visibility.CheckState = pass_visibility.Checked Then
            txtbox_pass.UseSystemPasswordChar = False

        Else
            txtbox_pass.UseSystemPasswordChar = True
        End If
    End Sub
End Class
