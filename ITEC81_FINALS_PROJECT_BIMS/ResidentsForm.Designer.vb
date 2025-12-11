<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResidentsForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents splitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvResidents As System.Windows.Forms.DataGridView
    Friend WithEvents pnlInputs As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    ' Input Fields
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents cmbSex As System.Windows.Forms.ComboBox
    Friend WithEvents dtpBirth As System.Windows.Forms.DateTimePicker
    ' Buttons
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.pnlInputs = New System.Windows.Forms.Panel()
        Me.dgvResidents = New System.Windows.Forms.DataGridView()

        ' CONTAINER
        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.SplitterDistance = 350 ' Left Panel width
        Me.splitContainer.Panel1.BackColor = System.Drawing.Color.WhiteSmoke ' Input Area
        Me.splitContainer.Panel2.BackColor = System.Drawing.Color.White ' Grid Area

        ' INPUTS PANEL
        Me.pnlInputs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInputs.Padding = New System.Windows.Forms.Padding(20)

        ' CONTROLS GENERATION (With Styles)
        Me.lblHeader = CreateLabel("Manage Resident Info", 20, 20, 16, True)
        Me.txtSearch = CreateTxt("Search Resident...", 60)
        Me.txtFname = CreateTxt("First Name", 110)
        Me.txtLname = CreateTxt("Last Name", 150)
        Me.txtAddr = CreateTxt("Address", 190)

        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.cmbSex.Items.AddRange({"Male", "Female"})
        Me.cmbSex.Location = New System.Drawing.Point(20, 230)
        Me.cmbSex.Size = New System.Drawing.Size(300, 30)
        Me.cmbSex.Font = New System.Drawing.Font("Segoe UI", 10.0!)

        Me.dtpBirth = New System.Windows.Forms.DateTimePicker()
        Me.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpBirth.Location = New System.Drawing.Point(20, 270)
        Me.dtpBirth.Size = New System.Drawing.Size(300, 30)

        ' BUTTONS (Colored)
        Me.btnAdd = CreateBtn("ADD NEW", 330, System.Drawing.Color.SeaGreen)
        Me.btnUpdate = CreateBtn("UPDATE RECORD", 380, System.Drawing.Color.Orange)
        Me.btnDelete = CreateBtn("DELETE RECORD", 430, System.Drawing.Color.IndianRed)

        Me.pnlInputs.Controls.AddRange({lblHeader, txtSearch, txtFname, txtLname, txtAddr, cmbSex, dtpBirth, btnAdd, btnUpdate, btnDelete})
        Me.splitContainer.Panel1.Controls.Add(Me.pnlInputs)

        ' DATAGRID STYLING (The Visual Effect)
        Me.dgvResidents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResidents.BackgroundColor = System.Drawing.Color.White
        Me.dgvResidents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResidents.RowHeadersVisible = False
        Me.dgvResidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResidents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        ' Headers
        Me.dgvResidents.EnableHeadersVisualStyles = False
        Me.dgvResidents.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.dgvResidents.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvResidents.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvResidents.ColumnHeadersHeight = 40

        ' Rows
        Me.dgvResidents.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dgvResidents.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(230, 240, 250)
        Me.dgvResidents.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvResidents.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)

        Me.splitContainer.Panel2.Controls.Add(Me.dgvResidents)
        Me.Controls.Add(Me.splitContainer)
    End Sub

    ' Helpers for clean code
    Private Function CreateTxt(place As String, y As Integer) As System.Windows.Forms.TextBox
        Dim t As New System.Windows.Forms.TextBox
        t.PlaceholderText = place
        t.Location = New System.Drawing.Point(20, y)
        t.Size = New System.Drawing.Size(300, 30)
        t.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Return t
    End Function

    Private Function CreateBtn(txt As String, y As Integer, bg As System.Drawing.Color) As System.Windows.Forms.Button
        Dim b As New System.Windows.Forms.Button
        b.Text = txt
        b.Location = New System.Drawing.Point(20, y)
        b.Size = New System.Drawing.Size(300, 40)
        b.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        b.FlatAppearance.BorderSize = 0
        b.BackColor = bg
        b.ForeColor = System.Drawing.Color.White
        b.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        b.Cursor = System.Windows.Forms.Cursors.Hand
        Return b
    End Function

    Private Function CreateLabel(txt As String, x As Integer, y As Integer, size As Single, bold As Boolean) As System.Windows.Forms.Label
        Dim l As New System.Windows.Forms.Label
        l.Text = txt
        l.Location = New System.Drawing.Point(x, y)
        l.AutoSize = True
        l.Font = New System.Drawing.Font("Segoe UI", size, If(bold, System.Drawing.FontStyle.Bold, System.Drawing.FontStyle.Regular))
        l.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Return l
    End Function
End Class