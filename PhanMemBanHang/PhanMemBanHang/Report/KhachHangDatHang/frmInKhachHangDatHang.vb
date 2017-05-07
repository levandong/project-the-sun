Imports Microsoft.Reporting.WinForms

Public Class frmInKhachHangDatHang
    Public DatHang As tbKhachHangDatHang
    Public XemTruoc As Boolean
    Public bsData As New BindingSource
    Public TongTien As Decimal

    Private Sub frmInKhachHangDatHang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmInDatHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As tbReport
        Try
            report = dt.tbReports.ToList(My.Settings.KieuDatHang)
        Catch ex As Exception
            report = dt.tbReports.First
        End Try

        Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\Report\KhachHangDatHang\rptKhachHangDatHangA4.rdlc"
        ReportViewer1.LocalReport.EnableExternalImages = True

        Dim ds As New ReportDataSource
        ds.Name = "dsDatHang"
        If XemTruoc Then
            ds.Value = bsData
        Else
            TongTien = DatHang.TongTienChuaGiamGia
            Dim rls = dt.tbChiTietKhachHangDatHangs.Where(Function(s) s.idKhachHangDatHang = DatHang.id)
            ds.Value = rls
        End If

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(ds)
        ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(DatHang, TongTien))

        ReportViewer1.RefreshReport()

        Me.ClientSize = New System.Drawing.Size(report.PixelWidth + 40, 600)
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = My.Settings.ZoomReport
    End Sub

End Class