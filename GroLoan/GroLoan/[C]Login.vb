Imports System.Data.SQLite
Module _C_Login

    Public Sub Logined()

        Dim sqliteString As String
        Dim sqlitecommand As New SQLiteCommand
        Dim sqliteadapter As New SQLiteDataAdapter
        Dim sqliteset As New DataSet
        Dim sqlitetable As New DataTable

        Connection.Connection()
        sqliteString = "SELECT *FROM `Accounts` WHERE `uname` = '" & Form1.TextPW.Text & "' AND `pass` = '" & Form1.TextUname.Text & "';"
        sqlitecommand.CommandText = sqliteString
        sqlitecommand.Connection = connect
        sqliteadapter.SelectCommand = sqlitecommand
        sqliteadapter.Fill(sqlitetable)
        connect.Close()

        Try
            If Form1.TextPW.Text = sqlitetable.Rows(0).Item(2).ToString And Form1.TextUname.Text = sqlitetable.Rows(0).Item(1).ToString Then
                Call Connection.Connection()
                MsgBox("Welcome", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Access Granted!")
                Admin_Cashier.Show()
                Admin_Cashier.Focus()
                Form1.Hide()
            Else
                MsgBox("Account Not Registered!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Denied!")
            End If

        Catch ex As Exception
            MsgBox("Not a Registered Account!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Denied!")

        End Try

       

    End Sub

    Public Sub Admin()

        Dim sqliteString As String
        Dim sqlitecommand As New SQLiteCommand
        Dim sqliteadapter As New SQLiteDataAdapter
        Dim sqliteset As New DataSet
        Dim sqlitetable As New DataTable

        Connection.Connection()
        sqliteString = "SELECT *FROM Accounts WHERE pass = '" & Password.TextAdminPassword.Text & "';"
        sqlitecommand.CommandText = sqliteString
        sqlitecommand.Connection = connect
        sqliteadapter.SelectCommand = sqlitecommand
        sqliteadapter.Fill(sqlitetable)
        connect.Close()

        Try
            If Password.TextAdminPassword.Text = sqlitetable.Rows(0).Item(2).ToString Then
                Inventory.Show()
                Inventory.Focus()
                Password.Hide()
                Admin_Cashier.Hide()
            Else
                MsgBox("Incorrect Password!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Incorrect Password")
            End If
        Catch ex As Exception
            MsgBox("Incorrect Password!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Incorrect Password")

        End Try



    End Sub

    Public Sub ChangeCredentials()
        Try

            Dim sqliteString As String
            Dim sqlitecommand As New SQLiteCommand
            Dim sqliteadapter As New SQLiteDataAdapter
            Dim sqliteset As New DataSet
            Dim sqlitetable As New DataTable

            Connection.Connection()
            sqliteString = "UPDATE `Accounts` SET `uname` = '" & Change_account.textChangeUname.Text & "', `pass` = '" & Change_account.textChangePass.Text & "' WHERE uname = '" & Change_account.TextBox1.Text & "'"
            sqlitecommand.CommandText = sqliteString
            sqlitecommand.Connection = connect
            sqliteadapter.SelectCommand = sqlitecommand
            sqliteadapter.Fill(sqlitetable)
            connect.Close()
        Catch ex As Exception


        End Try
        MsgBox("Change Successful!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Change Account")

    End Sub


End Module
