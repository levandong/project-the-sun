Imports Microsoft.Reporting.WinForms

Public Class frmDanhSachSanPhamNhap
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
        Dim strReport As String
        Try
            strReport = dt.tbReports.First(Function(s) s.FileRDLC = ".\Report\PhieuNhap\rptDanhSachChiTietNhapKho.rdlc").FileRDLC
        Catch ex As Exception
            strReport = ".\Report\PhieuNhap\rptDanhSachChiTietNhapKho.rdlc"
        End Try

        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + strReport

        Dim ds As New ReportDataSource
        ds.Name = "dsChiTietPhieuNhap"
        ds.Value = bsData

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(ds)
        ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(dt.tbPhieuNhaps.First, TongTien))

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = My.Settings.ZoomReport
        'Me.ClientSize = New System.Drawing.Size(report.PixelWidth + 100, 700)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class