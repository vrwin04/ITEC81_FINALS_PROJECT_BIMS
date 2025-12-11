Imports System.Data.OleDb

Public Class ProjectsForm
    Private UserRole As String
    Public Sub New(role As String)
        InitializeComponent()
        UserRole = role
    End Sub

    Private Sub ProjectsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProjects()
    End Sub

    Sub LoadProjects()
        Connect()
        Dim da As New OleDbDataAdapter("SELECT * FROM tblProjects", con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvProjects.DataSource = dt
        con.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Connect()
        Dim q As String = "INSERT INTO tblProjects(ProjectName, Status, BudgetAllocated, BudgetUtilized, Notes) VALUES(@p, @s, @ba, @bu, @n)"
        cmd = New OleDbCommand(q, con)
        cmd.Parameters.AddWithValue("@p", txtProject.Text)
        cmd.Parameters.AddWithValue("@s", cmbStatus.Text)
        cmd.Parameters.AddWithValue("@ba", Val(txtBudget.Text))
        cmd.Parameters.AddWithValue("@bu", Val(txtUsed.Text))
        cmd.Parameters.AddWithValue("@n", txtNotes.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Project Saved")
        LoadProjects()
        con.Close()
    End Sub
End Class