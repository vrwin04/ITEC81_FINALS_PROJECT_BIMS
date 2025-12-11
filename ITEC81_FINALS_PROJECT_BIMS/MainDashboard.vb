Public Class MainDashboard
    Public CurrentRole As String

    Public Sub New(role As String)
        InitializeComponent()
        CurrentRole = role

        ' Reverse button addition order fix for Dock=Top
        pnlSidebar.Controls.SetChildIndex(btnResidents, 0)
        pnlSidebar.Controls.SetChildIndex(btnCertificates, 1)
        pnlSidebar.Controls.SetChildIndex(btnProjects, 2)

        ' Start with Residents
        OpenForm(New ResidentsForm(CurrentRole))
    End Sub

    ' --- VISUAL EFFECTS (HOVER) ---
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnResidents.MouseEnter, btnCertificates.MouseEnter, btnProjects.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(52, 73, 94) ' Lighter Blue
        btn.ForeColor = Color.White
        btn.Padding = New Padding(10, 0, 0, 0) ' Slight move animation
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnResidents.MouseLeave, btnCertificates.MouseLeave, btnProjects.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.Transparent
        btn.ForeColor = Color.LightGray
        btn.Padding = New Padding(0, 0, 0, 0) ' Reset position
    End Sub

    ' --- NAVIGATION LOGIC ---
    Private Sub OpenForm(frm As Form)
        pnlContent.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlContent.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        lblTitle.Text = "RESIDENT MANAGEMENT"
        OpenForm(New ResidentsForm(CurrentRole))
    End Sub

    Private Sub btnCertificates_Click(sender As Object, e As EventArgs) Handles btnCertificates.Click
        lblTitle.Text = "CERTIFICATE ISSUANCE"
        OpenForm(New CertificatesForm())
    End Sub

    Private Sub btnProjects_Click(sender As Object, e As EventArgs) Handles btnProjects.Click
        lblTitle.Text = "PROJECTS AND BUDGET MONITORING"
        OpenForm(New ProjectsForm(CurrentRole))
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Close()
    End Sub
End Class