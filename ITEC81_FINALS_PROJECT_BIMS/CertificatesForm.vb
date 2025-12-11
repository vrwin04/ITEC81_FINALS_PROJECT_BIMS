Imports System.Drawing.Printing
Imports System.Data.OleDb

Public Class CertificatesForm
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If txtName.Text = "" Or cmbCertType.Text = "" Then
            MsgBox("Fill details first")
            Exit Sub
        End If

        ' Save Record
        Connect()
        cmd = New OleDbCommand("INSERT INTO tblCertificates(ResidentName, CertType, DateIssued) VALUES(@n, @t, @d)", con)
        cmd.Parameters.AddWithValue("@n", txtName.Text)
        cmd.Parameters.AddWithValue("@t", cmbCertType.Text)
        cmd.Parameters.AddWithValue("@d", DateTime.Now.ToString())
        cmd.ExecuteNonQuery()
        con.Close()

        ' Preview
        Dim dlg As New PrintPreviewDialog()
        dlg.Document = PrintDocument1
        dlg.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fHeader As New Font("Arial", 18, FontStyle.Bold)
        Dim fBody As New Font("Arial", 12)

        e.Graphics.DrawString("OFFICE OF THE BARANGAY CAPTAIN", fHeader, Brushes.Black, 200, 50)
        e.Graphics.DrawString(cmbCertType.Text.ToUpper(), fHeader, Brushes.Black, 250, 150)

        Dim text As String = "This is to certify that " & txtName.Text.ToUpper() & " is a resident of this Barangay." & vbCrLf &
                             "Issued this " & DateTime.Now.ToShortDateString() & "."

        e.Graphics.DrawString(text, fBody, Brushes.Black, New RectangleF(50, 250, 700, 300))
    End Sub
End Class