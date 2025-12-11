Imports System.Data.OleDb

Module ModConnection
    ' Connection String (Assumes nasa bin/Debug ang DB mo)
    Public strCon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BarangayDB.accdb"
    Public con As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader

    Public Sub Connect()
        Try
            con = New OleDbConnection(strCon)
            If con.State = ConnectionState.Closed Then con.Open()
        Catch ex As Exception
            MsgBox("DB Error: " & ex.Message)
        End Try
    End Sub
End Module