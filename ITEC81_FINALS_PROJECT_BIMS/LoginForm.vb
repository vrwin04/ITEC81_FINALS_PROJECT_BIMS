Imports System.Data.OleDb

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Connect()
        cmd = New OleDbCommand("SELECT * FROM tblUsers WHERE Username=@u AND Password=@p", con)
        cmd.Parameters.AddWithValue("@u", txtUser.Text)
        cmd.Parameters.AddWithValue("@p", txtPass.Text)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Read()
            Dim role As String = dr("Role").ToString()
            MsgBox("Login Successful! Role: " & role)
            Dim dash As New MainDashboard(role)
            dash.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Credentials")
        End If
        con.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Center the login box programmatically just to be safe
        Panel1.Location = New Point((Me.Width - Panel1.Width) / 2, (Me.Height - Panel1.Height) / 2)
    End Sub
End Class