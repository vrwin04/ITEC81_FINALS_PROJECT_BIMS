Imports System.Data.OleDb

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the panel programmatically
        pnlCard.Location = New Point((Me.Width - pnlCard.Width) / 2, (Me.Height - pnlCard.Height) / 2)
    End Sub

    ' Login Logic (Same as before but linked to new button)
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' ... (Use CRUD logic from previous prompt) ...
        ' Connect(), Check DB, Open Dashboard...
        Connect()
        cmd = New OleDbCommand("SELECT * FROM tblUsers WHERE Username=@u AND Password=@p", con)
        cmd.Parameters.AddWithValue("@u", txtUser.Text)
        cmd.Parameters.AddWithValue("@p", txtPass.Text)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            Dim role As String = dr("Role").ToString()
            Dim main As New MainDashboard(role)
            main.Show()
            Me.Hide()
        Else
            MsgBox("Access Denied.")
        End If
        con.Close()
    End Sub
End Class