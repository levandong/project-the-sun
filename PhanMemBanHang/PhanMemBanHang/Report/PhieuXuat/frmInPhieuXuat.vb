Imports Microsoft.Reporting.WinForms

Public Class frmInPhieuXuat
    Public bsData As New BindingSource
    Public PhieuXuat As tbPhieuXuat
    Public TongTien As Decimal
    Public XemTruoc As Boolean

    Private Sub frmInPhieuXuat_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmInPhieuXuatNhapNguyenLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As tbReport
        Try
            report = dt.tbReports.ToList(My.Settings.KieuPhieuXuat)
        Catch ex As Exception
            report = dt.tbReports.First(Function(s) s.FileRDLC = ".\Report\PhieuXuat\rptPhieuXuatA5.rdlc")
        End Try

        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\" + report.FileRDLC.Substring(2)

        Dim ds As New ReportDataSource
        ds.Name = "dsChiTietPhieuXuat"
        If XemTruoc Then
            ds.Value = bsData
        Else
            ds.Value = dt.tbChiTietPhieuXuats.Where(Function(s) s.idPhieuXuat = PhieuXuat.id)
        End If

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(ds)
        ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(PhieuXuat, TongTien))

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = My.Settings.ZoomReport
        Me.ClientSize = New System.Drawing.Size(report.PixelWidth + 100, 700)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class