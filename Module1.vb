'Imports MySql.Data.MySqlClient
'Module Module1
'    Public myconn As New MySqlConnection
'    Public sqlcon As String
'    Public strSQL As String

'    Public Sub openDB()
'        Login_page.Close()
'        form_customer.Show()
'        sqlcon = "server=localhost;" _
'                    & "uid=root;" _
'                    & "pwd=Admin123;" _
'                    & "database=test"
'        Try
'            myconn.ConnectionString = sqlcon
'            myconn.Open()
'            MsgBox("Success", vbInformation, "Status")

'        Catch e As MySqlException
'            MsgBox("Error invalid credentials")
'        End Try
'    End Sub
'    Public Sub closeDB()
'        myconn.Close()
'        myconn.Dispose()
'        MsgBox("Closed", vbInformation, "Status")
'    End Sub

'End Module
