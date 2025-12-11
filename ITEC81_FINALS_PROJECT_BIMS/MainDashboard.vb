Imports System.Data.OleDb

Public Class MainDashboard
    Public CurrentRole As String

    Public Sub New(role As String)
        InitializeComponent()
        CurrentRole = role

        ' Hack: Adjust controls order because Dock=Top stacks bottom-up
        pnlSidebar.Controls.SetChildIndex(btnResidents, 0)
        pnlSidebar.Controls.SetChildIndex(btnCertificates, 1)
        pnlSidebar.Controls.SetChildIndex(btnProjects, 2)
    End Sub

    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStats()
    End Sub

    Private Sub LoadStats()
        Connect()
        ' Count Residents
        cmd = New OleDbCommand("SELECT COUNT(*) FROM tblResidents", con)
        lblStat1.Text = "Total Residents: " & cmd.ExecuteScalar().ToString()

        ' Count Projects
        cmd = New OleDbCommand("SELECT COUNT(*) FROM tblProjects WHERE Status='Ongoing'", con)
        lblStat2.Text = "Active Projects: " & cmd.ExecuteScalar().ToString()
        con.Close()
    End Sub

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        OpenChildForm(New ResidentsForm(CurrentRole))
    End Sub

    Private Sub btnProjects_Click(sender As Object, e As EventArgs) Handles btnProjects.Click
        OpenChildForm(New ProjectsForm(CurrentRole))
    End Sub

    Private Sub btnCertificates_Click(sender As Object, e As EventArgs) Handles btnCertificates.Click
        OpenChildForm(New CertificatesForm())
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        pnlContent.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlContent.Controls.Add(childForm)
        pnlContent.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Close()
    End Sub
End Class