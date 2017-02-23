Imports System.Data.SQLite
Imports System.Data
Module Connection

    Public connect As New SQLiteConnection

    Public Sub Connection()
       
            If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "DataSource = groloan.sqlite;"
                connect.Open()
            End If

    End Sub

End Module
