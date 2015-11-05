Public Class frmLogin

    ''' <summary>
    ''' Contains a MySqlConnection instance
    ''' </summary>
    ''' <returns>MySql.Data.MySqlClient.MySqlConnection</returns>
    Public Property dbConnection As New MySql.Data.MySqlClient.MySqlConnection


    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        ' Note: for security, real connection details would never be included in source code
        Dim connectionDetails As String = "server=127.0.0.1;database=mysql_climsoft_db_v4;port=3306;"
        Dim usernamePassword As String = "uid=" & txtUserName.Text & ";" &
            "pwd=" & txtPassword.Text & ";"
        dbConnection.ConnectionString = connectionDetails & usernamePassword
        Try
            dbConnection.Open()
            Me.Hide()
            frmStation.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class
