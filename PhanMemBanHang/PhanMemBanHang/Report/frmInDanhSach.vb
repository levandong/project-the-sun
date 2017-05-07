Imports Microsoft.Reporting.WinForms

Public Class frmInDanhSach
    Public _bs As New BindingSource
    Public dsName As String
    Public rptName As String
    Public timkiemtheo As String
    Public ThoiGianTimKiem As String

    Private Sub frmInDanhSach_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmInReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + rptName.Substring(1)
        ReportViewer1.LocalReport.EnableExternalImages = True

        Dim ds As New ReportDataSource
        ds.Name = dsName
        ds.Value = _bs


        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(ds)

        If ThoiGianTimKiem <> "" Then
            Dim rp As New ReportParameterCollection
            rp.Add(New ReportParameter("ThoiGian", ThoiGianTimKiem))
            Me.ReportViewer1.LocalReport.SetParameters(rp)
        End If
        If timkiemtheo <> "" Then
            Dim rp As New ReportParameterCollection
            rp.Add(New ReportParameter("TimKiemTheo", timkiemtheo))
            Me.ReportViewer1.LocalReport.SetParameters(rp)
        End If
        'ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(Me.Text))
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = My.Settings.ZoomReport
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class