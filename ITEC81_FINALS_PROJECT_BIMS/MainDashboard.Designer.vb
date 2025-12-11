<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDashboard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
            End If
            MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents btnResidents As System.Windows.Forms.Button
    Friend WithEvents btnCertificates As System.Windows.Forms.Button
    Friend WithEvents btnProjects As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlStats As System.Windows.Forms.Panel
    Friend WithEvents lblStat1 As System.Windows.Forms.Label
    Friend WithEvents lblStat2 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResidents = New System.Windows.Forms.Button()
        Me.btnCertificates = New System.Windows.Forms.Button()
        Me.btnProjects = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblStat1 = New System.Windows.Forms.Label()
        Me.lblStat2 = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnProjects)
        Me.pnlSidebar.Controls.Add(Me.btnCertificates)
        Me.pnlSidebar.Controls.Add(Me.btnResidents)
        Me.pnlSidebar.Controls.Add(Me.Label1)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Size = New System.Drawing.Size(250, 600)
        '
        'Buttons Layout (Manual Positioning for Clean look)
        '
        Me.Label1.Text = "BIMS ADMIN"
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.AutoSize = True

        Me.btnResidents.Text = "Residents"
        Me.btnResidents.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResidents.Height = 60
        Me.btnResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResidents.ForeColor = System.Drawing.Color.White

        Me.btnCertificates.Text = "Certificates"
        Me.btnCertificates.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCertificates.Height = 60
        Me.btnCertificates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCertificates.ForeColor = System.Drawing.Color.White

        Me.btnProjects.Text = "Projects & Budget"
        Me.btnProjects.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProjects.Height = 60
        Me.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProjects.ForeColor = System.Drawing.Color.White

        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.Height = 60
        Me.btnLogout.BackColor = System.Drawing.Color.IndianRed
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        '
        'pnlContent
        '
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlContent.Controls.Add(Me.pnlStats)

        '
        'pnlStats (Sample Dashboard Cards)
        '
        Me.pnlStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStats.Height = 150
        Me.pnlStats.Controls.Add(Me.lblStat1)
        Me.pnlStats.Controls.Add(Me.lblStat2)

        Me.lblStat1.Text = "Total Residents: Loading..."
        Me.lblStat1.Font = New System.Drawing.Font("Segoe UI", 16)
        Me.lblStat1.Location = New System.Drawing.Point(20, 20)
        Me.lblStat1.AutoSize = True

        Me.lblStat2.Text = "Active Projects: Loading..."
        Me.lblStat2.Font = New System.Drawing.Font("Segoe UI", 16)
        Me.lblStat2.Location = New System.Drawing.Point(300, 20)
        Me.lblStat2.AutoSize = True

        '
        'MainDashboard
        '
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStats.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
End Class