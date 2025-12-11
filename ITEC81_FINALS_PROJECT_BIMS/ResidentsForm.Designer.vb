<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResidentsForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvResidents As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents cmbSex As System.Windows.Forms.ComboBox
    Friend WithEvents dtpBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvResidents = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.dtpBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()

        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10)

        ' Input Controls Layout
        Me.Label1.Text = "Resident Information"
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top

        Me.txtFname.PlaceholderText = "First Name"
        Me.txtFname.Top = 40 : Me.txtFname.Width = 280

        Me.txtLname.PlaceholderText = "Last Name"
        Me.txtLname.Top = 70 : Me.txtLname.Width = 280

        Me.txtAddr.PlaceholderText = "Address"
        Me.txtAddr.Top = 100 : Me.txtAddr.Width = 280

        Me.cmbSex.Items.AddRange({"Male", "Female"})
        Me.cmbSex.Top = 130 : Me.cmbSex.Width = 280

        Me.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpBirth.Top = 160 : Me.dtpBirth.Width = 280

        Me.btnAdd.Text = "ADD" : Me.btnAdd.Top = 200 : Me.btnAdd.Width = 280 : Me.btnAdd.BackColor = System.Drawing.Color.Teal : Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Text = "UPDATE" : Me.btnUpdate.Top = 240 : Me.btnUpdate.Width = 135 : Me.btnUpdate.BackColor = System.Drawing.Color.Orange
        Me.btnDelete.Text = "DELETE" : Me.btnDelete.Top = 240 : Me.btnDelete.Left = 155 : Me.btnDelete.Width = 135 : Me.btnDelete.BackColor = System.Drawing.Color.Red : Me.btnDelete.ForeColor = System.Drawing.Color.White

        Me.SplitContainer1.Panel1.Controls.AddRange({Label1, txtFname, txtLname, txtAddr, cmbSex, dtpBirth, btnAdd, btnUpdate, btnDelete})

        ' Grid Layout
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearch.PlaceholderText = "Search by Name..."

        Me.dgvResidents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvResidents)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)

        Me.Controls.Add(Me.SplitContainer1)
    End Sub
End Class