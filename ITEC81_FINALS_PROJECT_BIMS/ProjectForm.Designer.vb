<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectsForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents dgvProjects As System.Windows.Forms.DataGridView
    Friend WithEvents txtProject As System.Windows.Forms.TextBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtBudget As System.Windows.Forms.TextBox
    Friend WithEvents txtUsed As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlLeft = New Panel()
        Label1 = New Label()
        txtProject = New TextBox()
        cmbStatus = New ComboBox()
        txtBudget = New TextBox()
        txtUsed = New TextBox()
        txtNotes = New TextBox()
        btnSave = New Button()
        dgvProjects = New DataGridView()
        pnlLeft.SuspendLayout()
        CType(dgvProjects, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.WhiteSmoke
        pnlLeft.Controls.Add(Label1)
        pnlLeft.Controls.Add(txtProject)
        pnlLeft.Controls.Add(cmbStatus)
        pnlLeft.Controls.Add(txtBudget)
        pnlLeft.Controls.Add(txtUsed)
        pnlLeft.Controls.Add(txtNotes)
        pnlLeft.Controls.Add(btnSave)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(300, 253)
        pnlLeft.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 32)
        Label1.TabIndex = 0
        Label1.Text = "Project & Budget"
        ' 
        ' txtProject
        ' 
        txtProject.Location = New Point(10, 50)
        txtProject.Name = "txtProject"
        txtProject.PlaceholderText = "Project Name"
        txtProject.Size = New Size(280, 27)
        txtProject.TabIndex = 1
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Items.AddRange(New Object() {"Planning", "Ongoing", "Completed"})
        cmbStatus.Location = New Point(10, 90)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(280, 28)
        cmbStatus.TabIndex = 2
        ' 
        ' txtBudget
        ' 
        txtBudget.Location = New Point(10, 130)
        txtBudget.Name = "txtBudget"
        txtBudget.PlaceholderText = "Budget Allocated"
        txtBudget.Size = New Size(280, 27)
        txtBudget.TabIndex = 3
        ' 
        ' txtUsed
        ' 
        txtUsed.Location = New Point(10, 170)
        txtUsed.Name = "txtUsed"
        txtUsed.PlaceholderText = "Budget Utilized"
        txtUsed.Size = New Size(280, 27)
        txtUsed.TabIndex = 4
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(10, 210)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.PlaceholderText = "Notes"
        txtNotes.Size = New Size(280, 100)
        txtNotes.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Green
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(10, 330)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(280, 23)
        btnSave.TabIndex = 6
        btnSave.Text = "SAVE PROJECT"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dgvProjects
        ' 
        dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProjects.ColumnHeadersHeight = 29
        dgvProjects.Dock = DockStyle.Fill
        dgvProjects.Location = New Point(300, 0)
        dgvProjects.Name = "dgvProjects"
        dgvProjects.RowHeadersWidth = 51
        dgvProjects.Size = New Size(0, 253)
        dgvProjects.TabIndex = 0
        ' 
        ' ProjectsForm
        ' 
        ClientSize = New Size(282, 253)
        Controls.Add(dgvProjects)
        Controls.Add(pnlLeft)
        Name = "ProjectsForm"
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        CType(dgvProjects, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class