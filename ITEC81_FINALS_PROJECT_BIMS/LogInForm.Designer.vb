<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()

        ' FORM
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackColor = System.Drawing.Color.FromArgb(41, 128, 185) ' Background Blue

        ' CARD (Center Box)
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.Size = New System.Drawing.Size(400, 450)
        ' Note: Centering logic is in .vb file Paint event

        ' LABELS
        Me.lblHead.Text = "BARANGAY SYSTEM"
        Me.lblHead.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblHead.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.lblHead.Location = New System.Drawing.Point(50, 50)
        Me.lblHead.AutoSize = True

        Me.lblSub.Text = "Please login to continue"
        Me.lblSub.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSub.ForeColor = System.Drawing.Color.Gray
        Me.lblSub.Location = New System.Drawing.Point(50, 90)
        Me.lblSub.AutoSize = True

        ' TEXTBOXES (Styled)
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUser.Location = New System.Drawing.Point(50, 150)
        Me.txtUser.Size = New System.Drawing.Size(300, 30)
        Me.txtUser.PlaceholderText = "Username"

        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPass.Location = New System.Drawing.Point(50, 200)
        Me.txtPass.Size = New System.Drawing.Size(300, 30)
        Me.txtPass.PasswordChar = "●"c
        Me.txtPass.PlaceholderText = "Password"

        ' BUTTON
        Me.btnLogin.Text = "SECURE LOGIN"
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.Location = New System.Drawing.Point(50, 280)
        Me.btnLogin.Size = New System.Drawing.Size(300, 50)
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand

        ' Add to Card
        Me.pnlCard.Controls.AddRange({lblHead, lblSub, txtUser, txtPass, btnLogin})
        Me.Controls.Add(Me.pnlCard)
    End Sub
End Class