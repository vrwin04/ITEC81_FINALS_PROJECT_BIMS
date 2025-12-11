<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CertificatesForm
    Inherits System.Windows.Forms.Form

    ' DITO ANG FIX: Idagdag ang components declaration
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' ... (Ituloy ang iba pang controls declarations sa baba tulad ng txtName, btnPrint, etc.)
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbCertType As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ' ... (Huwag baguhin ang nasa loob ng InitializeComponent) ...
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbCertType = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()

        Me.Label1.Text = "CERTIFICATE ISSUANCE"
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(50, 30)
        Me.Label1.AutoSize = True

        Me.txtName.PlaceholderText = "Resident Full Name"
        Me.txtName.Location = New System.Drawing.Point(50, 80)
        Me.txtName.Width = 300

        Me.cmbCertType.Items.AddRange({"Barangay Clearance", "Indigency", "Residency"})
        Me.cmbCertType.Location = New System.Drawing.Point(50, 120)
        Me.cmbCertType.Width = 300

        Me.btnPrint.Text = "PRINT PREVIEW"
        Me.btnPrint.Location = New System.Drawing.Point(50, 160)
        Me.btnPrint.Width = 300
        Me.btnPrint.Height = 40
        Me.btnPrint.BackColor = System.Drawing.Color.Navy
        Me.btnPrint.ForeColor = System.Drawing.Color.White

        Me.Controls.AddRange({Label1, txtName, cmbCertType, btnPrint})
        Me.BackColor = System.Drawing.Color.White
    End Sub
End Class