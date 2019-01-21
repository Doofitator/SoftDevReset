Imports System.Data.SqlClient

Public Class frm_main

    Public connectionString As String = "Data Source=120.150.110.21,1433;Network Library=DBMSSOCN;Initial Catalog=SoftDevChat;"
    Public loginString As String = ""

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        loginString = "uid=" & txt_saUsername.Text & ";pwd=" & txt_saPassword.Text
        If DBConnectionStatus() Then
            grp_clear.Enabled = True
            grp_userReset.Enabled = True
            grp_saLogin.Enabled = False
        Else
            MsgBox("Bad Sysadmin username and password")
        End If
    End Sub

    Private Function DBConnectionStatus() As Boolean
        Try
            Using sqlConn As New SqlConnection(connectionString & loginString)
                sqlConn.Open()
                Return (sqlConn.State = ConnectionState.Open)
            End Using
        Catch e1 As SqlException
            Return False
        Catch e2 As Exception
            Return False
        End Try
    End Function

    Function userExists(ByVal name As String) As Boolean
        'Create a Connection object.
        Dim MyConn = New SqlConnection(connectionString & loginString)

        'Create a Command object.
        Dim myCmd = MyConn.CreateCommand
        myCmd.CommandText = "select count(*) from tbl_users where convert(varchar, Name) = '" & MakeSQLSafe(name) & "'"

        'Open the connection.
        MyConn.Open()

        If myCmd.ExecuteScalar = 1 Then 'if there is one result returned, then the username already exists in the database.
            MyConn.Close()
            Return True
        Else
            MyConn.Close()
            Return False
        End If
    End Function

    Public Function MakeSQLSafe(ByVal sql As String) As String

        If sql.Contains("'") Then
            sql = sql.Replace("'", "''")
        End If

        Return sql
    End Function

    Function writeSQL(ByVal Query As String) As Boolean 'with any luck, all database WRITE functions will call this one at some point.
        'Create a Connection object.
        Dim MyConn = New SqlConnection(connectionString & loginString)

        'Create a Command object.
        Dim myCmd = MyConn.CreateCommand
        myCmd.CommandText = Query

        'Open the connection.
        MyConn.Open()

        Try
            myCmd.ExecuteNonQuery() 'run sql script
            MyConn.Close() 'close connection
            Return True
        Catch ex As Exception 'if a catastrophic error occurs
            'console.writeline(ex.ToString)
            MyConn.Close() 'close the connection
            MsgBox(Query)
            MsgBox("Sql error" & vbCrLf & vbCrLf & ex.ToString)
            Return False
        End Try
    End Function

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        If userExists(txt_username.Text.ToLower) Then
            '// fancy encryption stuff from encryption.vb //

            Dim password As String  'new string to hold encrypted password

            Dim wrapper As Encryption = New Encryption(txt_username.Text.ToLower)             'make a new encrypted string with the key of username
            password = wrapper.EncryptData(txt_password.Text)   'encrypt the password with the key of the username

            Try
                writeSQL("update tbl_users set password = '" & password & "' where convert(varchar, Name) = '" & txt_username.Text.ToLower & "'")
            Catch ex As Exception
                MsgBox("Fail to update password:" & vbCrLf & vbCrLf & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        If MessageBox.Show("Are you sure?", "Delete All Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If MessageBox.Show("This will destroy ALL DATA across ALL CHATS on this server. Are you sure you want to do this?", "Clear database", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Dim sql As String = "EXEC sp_MSForEachTable ""ALTER TABLE ? NOCHECK CONSTRAINT all"" EXEC sp_MSForEachTable ""DELETE FROM ?"" DBCC CHECKIDENT (tbl_users, RESEED, 0) DBCC CHECKIDENT (tbl_streams, RESEED, 0) DBCC CHECKIDENT (tbl_messages, RESEED, 0) exec sp_MSForEachTable ""ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"""
                If writeSQL(sql) Then MsgBox("All data permanently deleted.", vbOKOnly, "Gone.") Else MsgBox("Error. No data deleted.", vbOKOnly, "Error")
            End If
        End If
    End Sub
End Class
