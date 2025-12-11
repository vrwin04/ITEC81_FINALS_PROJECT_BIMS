<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDashboard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnResidents As System.Windows.Forms.Button
    Friend WithEvents btnCertificates As System.Windows.Forms.Button
    Friend WithEvents btnProjects As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox ' Placeholder for visuals

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnResidents = New System.Windows.Forms.Button()
        Me.btnCertificates = New System.Windows.Forms.Button()
        Me.btnProjects = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()

        ' FORM PROPERTIES (Maximized & Modern)
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None ' No Border for custom look
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Name = "MainDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen

        ' SIDEBAR (Dark Theme)
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(30, 39, 46) ' Dark Blue/Black
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Width = 260
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(0, 100, 0, 0) ' Space for Logo

        ' HEADER (Clean White)
        Me.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 60

        Me.lblTitle.Text = "BARANGAY MANAGEMENT SYSTEM"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 39, 46)
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.AutoSize = True
        Me.pnlHeader.Controls.Add(Me.lblTitle)

        ' CONTENT (Where forms will load)
        Me.pnlContent.BackColor = System.Drawing.Color.White
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill

        ' BUTTON STYLING (Shared Functionality)
        SetupButton(Me.btnResidents, "RESIDENT INFORMATION")
        SetupButton(Me.btnCertificates, "ISSUANCE & CERTIFICATES")
        SetupButton(Me.btnProjects, "PROJECTS & BUDGET")

        ' LOGOUT BUTTON (Red Accent)
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.Height = 55
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(231, 76, 60) ' Red
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand

        ' ADD CONTROLS
        Me.pnlSidebar.Controls.Add(Me.btnProjects)
        Me.pnlSidebar.Controls.Add(Me.btnCertificates)
        Me.pnlSidebar.Controls.Add(Me.btnResidents)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)

        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
    End Sub

    ' Helper para hindi paulit-ulit ang code ng button design
    Private Sub SetupButton(btn As System.Windows.Forms.Button, txt As String)
        btn.Text = "   " & txt ' Indent
        btn.Dock = System.Windows.Forms.DockStyle.Top
        btn.Height = 60
        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = System.Drawing.Color.Transparent
        btn.ForeColor = System.Drawing.Color.LightGray
        btn.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        btn.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub
End Class