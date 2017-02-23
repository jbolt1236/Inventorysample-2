Imports System.Data.SQLite
Module _C_Register

    Public Sub UserRegistration()
        Try

            Connection.Connection()

            Dim RegString As String
            Dim RegCommand As New SQLiteCommand
            Dim RegAdapter As New SQLiteDataAdapter
            Dim RegTable As New DataTable

            RegString = " INSERT INTO Registered (`Name`,`Address`,`Email`,`Age`,`Sex`,`Birthdate`,`Civil_status`,`ContactNo`,`TeleponeNo`,`Amount_Deposited`,`Position`)VALUES('" & Requirements.TextName.Text & "','" & Requirements.TextAddrss.Text & "','" & Requirements.TextEmail.Text & "','" & Requirements.TextAge.Text & "','" & Requirements.ComboSex.Text & "','" & Requirements.DateTimePicker1.Text & "','" & Requirements.ComboCVS.Text & "','" & Requirements.TextCnmbr.Text & "','" & Requirements.TextTnmbr.Text & "','" & Requirements.TextAmntDpstd.Text & "','" & Requirements.ComboPos.Text & "')"
            RegCommand.CommandText = RegString
            RegCommand.Connection = connect
            RegAdapter.SelectCommand = RegCommand
            RegAdapter.Fill(RegTable)

            DisplayRegistrationData()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub EditRegistration()

        Connection.Connection()

        Dim RegString As String
        Dim RegCommand As New SQLiteCommand
        Dim RegAdapter As New SQLiteDataAdapter
        Dim RegTable As New DataTable

        RegString = "UPDATE Registered SET Name='" & Requirements.TextName.Text & "', Address='" & Requirements.TextAddrss.Text & "', Email='" & Requirements.TextEmail.Text & "', Age='" & Requirements.TextAge.Text & "', Birthdate='" & Requirements.DateTimePicker1.Text & "', Civil_status='" & Requirements.ComboCVS.Text & "', ContactNo='" & Requirements.TextCnmbr.Text & "', TeleponeNo='" & Requirements.TextTnmbr.Text & "', Amount_Deposited='" & Requirements.TextAmntDpstd.Text & "', Position='" & Requirements.ComboPos.Text & "', Sex='" & Requirements.ComboSex.Text & "' WHERE Name='" & Requirements.TextName.Text & "'"
        RegCommand.CommandText = RegString
        RegCommand.Connection = connect
        RegAdapter.SelectCommand = RegCommand
        RegAdapter.Fill(RegTable)
        DisplayRegistrationData()
    End Sub

    Public Sub DeleteRegistrationData()

        Connection.Connection()

        Dim RegString As String
        Dim RegCommand As New SQLiteCommand
        Dim RegAdapter As New SQLiteDataAdapter
        Dim RegTable As New DataTable
        Dim regSource As New BindingSource

        RegString = "DELETE FROM Registered WHERE ClientNo='" & DelSea.TextDelSea.Text & "'"
        RegCommand.CommandText = RegString
        RegCommand.Connection = connect
        RegAdapter.SelectCommand = RegCommand
        RegAdapter.Fill(RegTable)
        DisplayRegistrationData()
    End Sub

    Public Sub SearchRegisteredRecord()

        Connection.Connection()

        Dim RegString As String
        Dim RegCommand As New SQLiteCommand
        Dim RegAdapter As New SQLiteDataAdapter
        Dim RegTable As New DataTable
        Dim RegSource As New BindingSource

        RegString = "SELECT * FROM Registered WHERE ClientNo='" & DelSea.TextDelSea.Text & "'"
        RegCommand.CommandText = RegString
        RegCommand.Connection = connect
        RegAdapter.SelectCommand = RegCommand
        RegAdapter.Fill(RegTable)
        RegSource.DataSource = RegTable
        Registration.DataGridView1.DataSource = RegSource
        RegAdapter.Update(RegTable)
    End Sub

    Public Sub DisplayRegistrationData()

        Connection.Connection()

        Dim RegString As String
        Dim RegCommand As New SQLiteCommand
        Dim RegAdapter As New SQLiteDataAdapter
        Dim RegTable As New DataTable
        Dim RegSource As New BindingSource

        RegString = "SELECT * FROM Registered"
        RegCommand.CommandText = RegString
        RegCommand.Connection = connect
        RegAdapter.SelectCommand = RegCommand
        RegAdapter.Fill(RegTable)
        RegSource.DataSource = RegTable
        Registration.DataGridView1.DataSource = RegSource
        RegAdapter.Update(RegTable)
    End Sub
End Module
