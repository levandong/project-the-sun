Imports Microsoft.Reporting.WinForms

Public Class frmInPhieuNhap
    Public bsData As New BindingSource
    Public PhieuNhap As tbPhieuNhap
    Public TongTien As Decimal
    Public XemTruoc As Boolean

    Private Sub frmInPhieuNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmInPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As tbReport
        Try
            report = dt.tbReports.ToList(My.Settings.KieuPhieuNhap)
        Catch ex As Exception
            report = dt.tbReports.First(Function(s) s.FileRDLC = ".\Report\PhieuNhap\rptPhieuNhapA4.rdlc")
        End Try

        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + report.FileRDLC.Substring(1)

        Dim ds As New ReportDataSource
        ds.Name = "dsChiTietPhieuNhap"
        If XemTruoc = True Then
            ds.Value = bsData
        Else
            TongTien = PhieuNhap.TongTien
            ds.Value = dt.tbChiTietPhieuNhaps.Where(Function(s) s.idPhieuNhap = PhieuNhap.id)
        End If


        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(ds)
        ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(PhieuNhap, TongTien))

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = My.Settings.ZoomReport
        Me.ClientSize = New System.Drawing.Size(report.PixelWidth + 100, 700)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class