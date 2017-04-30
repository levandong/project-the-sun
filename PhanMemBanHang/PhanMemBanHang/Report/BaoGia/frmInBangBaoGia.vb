Imports Microsoft.Reporting.WinForms

Public Class frmInBangBaoGia
    Public _bs As New BindingSource
    Public BangBaoGia As tbBaoGia
    Public XemTruoc As Boolean
    Public isHienNhieuBaoGia = False
    Public rlsLoai As List(Of Integer)
    Private Sub frmInBangBaoGia_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmInReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkMauBaoGia1.Checked = True
        CapNhatPhieuBaoGia()
    End Sub
    Sub CapNhatPhieuBaoGia()
        Dim report As tbReport
        Try
            report = dt.tbReports.ToList(My.Settings.KieuBaoGia)
        Catch ex As Exception
            report = dt.tbReports.First
        End Try
        If chkMauBaoGia1.Checked Then
            Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + ".\Report\BaoGia\rptBangBaoGia.rdlc"
        Else
            Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + ".\Report\BaoGia\rptBangBaoGia2.rdlc"
        End If
        ReportViewer1.LocalReport.EnableExternalImages = True
        Dim ds As New ReportDataSource
        ds.Name = "dsBangBaoGia"
        If XemTruoc Then
            ds.Value = _bs
        Else
            If isHienNhieuBaoGia Then
                Dim rls = From itm In dt.vwChiTietBaoGias
                          Where rlsLoai.Contains(itm.idBaoGia)
                ds.Value = rls.ToList
            Else
                Dim rls = dt.vwChiTietBaoGias.Where(Function(s) s.idBaoGia = BangBaoGia.id)
                ds.Value = rls.ToList
            End If
        End If
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(ds)
        ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(BangBaoGia, isHienNhieuBaoGia))
        ReportViewer1.RefreshReport()
        Me.ClientSize = New System.Drawing.Size(report.PixelWidth + 40, 600)
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = My.Settings.ZoomReport
    End Sub

    Private Sub chkMauBaoGia1_CheckedChanged(sender As Object, e As EventArgs) Handles chkMauBaoGia1.CheckedChanged, chkMauBaoGia2.CheckedChanged
        CapNhatPhieuBaoGia()
    End Sub
End Class