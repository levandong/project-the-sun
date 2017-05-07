Imports System.Drawing.Printing

Public Class frmChonMayIn
    Public TenMayIn As String
    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmChonMayIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCapNhat_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        For Each itm In PrinterSettings.InstalledPrinters
            cmbMayInMacDinh.Items.Add(itm)
        Next
    End Sub

    Private Sub cmbMayInMacDinh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMayInMacDinh.SelectedIndexChanged
        TenMayIn = cmbMayInMacDinh.Text
    End Sub
End Class