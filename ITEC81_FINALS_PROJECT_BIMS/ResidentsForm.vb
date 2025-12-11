Imports System.Data.OleDb

Public Class ResidentsForm
    Private UserRole As String

    Public Sub New(role As String)
        InitializeComponent()
        UserRole = role
        If role = "Viewer" Then
            btnAdd.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub ResidentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Sub LoadData()
        Connect()
        Dim da As New OleDbDataAdapter("SELECT * FROM tblResidents WHERE FirstName LIKE @s OR LastName LIKE @s", con)
        da.SelectCommand.Parameters.AddWithValue("@s", "%" & txtSearch.Text & "%")
        Dim dt As New DataTable
        da.Fill(dt)
        dgvResidents.DataSource = dt
        con.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Connect()
        cmd = New OleDbCommand("INSERT INTO tblResidents(FirstName, LastName, Address, BirthDate, Sex) VALUES(@f,@l,@a,@b,@s)", con)
        cmd.Parameters.AddWithValue("@f", txtFname.Text)
        cmd.Parameters.AddWithValue("@l", txtLname.Text)
        cmd.Parameters.AddWithValue("@a", txtAddr.Text)
        cmd.Parameters.AddWithValue("@b", dtpBirth.Value.ToShortDateString())
        cmd.Parameters.AddWithValue("@s", cmbSex.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Saved!")
        LoadData()
        con.Close()
    End Sub

    Private Sub dgvResidents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResidents.CellClick
        If e.RowIndex >= 0 Then
            Dim r = dgvResidents.Rows(e.RowIndex)
            txtFname.Text = r.Cells("FirstName").Value.ToString()
            txtLname.Text = r.Cells("LastName").Value.ToString()
            txtAddr.Text = r.Cells("Address").Value.ToString()
            cmbSex.Text = r.Cells("Sex").Value.ToString()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadData()
    End Sub
End Class