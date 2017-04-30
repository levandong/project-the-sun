Imports Microsoft.Reporting.WinForms

Public Class ctrlThongKeQuyTien
    Private Sub rdoTheoThang_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTheoThang.CheckedChanged
        If rdoTheoThang.Checked Then
            pnTheoNam.Visible = True
            pnTheoNgay.Visible = False
        End If
    End Sub

    Private Sub rdoTheoNgay_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTheoNgay.CheckedChanged
        If rdoTheoNgay.Checked Then
            pnTheoNam.Visible = False
            pnTheoNgay.Visible = True
        End If
    End Sub

    Dim QuyDauKy As Double
    Dim TuNgay As Date
    Dim DenNgay As Date

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim frm As New Tmt.Toolkit.ProgressingDialog
        frm.Animation = Tmt.Toolkit.ProgressingDialog.AnimationStyle.Waiting
        frm.Caption = "Đang thống kê..."
        frm.DialogStyle = Tmt.Toolkit.ProgressingDialog.ProgressingDialogStyle.ContinuingDialog
        frm.Show()

        Dim TongThu As Double = 0
        Dim TongChi As Double = 0
        Dim ThoiGian As String = ""
        If rdoTheoNgay.Checked Then
            TuNgay = dtpTuNgay.Value.Date
            DenNgay = dtpDenNgay.Value.Date
            ThoiGian = "TỪ NGÀY " + TuNgay.ToString("dd/MM/yyyy") + " ĐẾN NGÀY " + DenNgay.ToString("dd/MM/yyyy")
        Else
            TuNgay = New Date(dtpThang.Value.Year, dtpThang.Value.Month, 1)
            DenNgay = TuNgay.AddMonths(1).AddDays(-1)
            ThoiGian = "THÁNG " + TuNgay.Month.ToString + " NĂM " + TuNgay.Year.ToString
        End If

        QuyDauKy = dt.fLayQuyTienDauKy(TuNgay)
        Dim rls = dt.prThongKeQuyTienMat(TuNgay, DenNgay)

        Dim lstKetQua = rls.ToList

        Dim SoDong = lstKetQua.Count
        If SoDong > 0 Then
            Dim i As Integer
            For i = 0 To SoDong - 1
                If i = 0 Then
                    If lstKetQua(i).Loai >= 0 Then
                        lstKetQua(i).QuyTien = QuyDauKy + lstKetQua(i).SoTien
                    Else
                        lstKetQua(i).QuyTien = QuyDauKy - lstKetQua(i).SoTien
                    End If
                Else
                    If lstKetQua(i).Loai > 0 Then
                        lstKetQua(i).QuyTien = lstKetQua(i - 1).QuyTien + lstKetQua(i).SoTien
                    Else
                        lstKetQua(i).QuyTien = lstKetQua(i - 1).QuyTien - lstKetQua(i).SoTien
                    End If
                End If
            Next

            TongThu = lstKetQua.Where(Function(s) s.Loai > 0).Sum(Function(s) s.SoTien)
            TongChi = lstKetQua.Where(Function(s) s.Loai < 0).Sum(Function(s) s.SoTien)
        End If
        bsQuyTien.DataSource = lstKetQua.ToList

        lblSoDong.Text = SoDong.ToString
        lblDauKy.Text = String.Format("{0:N0}", QuyDauKy)
        lblTongThu.Text = String.Format("{0:N0}", TongThu)
        lblTongChi.Text = String.Format("{0:N0}", TongChi)
        lblCuoiKy.Text = String.Format("{0:N0}", QuyDauKy + TongThu - TongChi)

        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Dim rp As New ReportParameterCollection
        With rp
            .Add(New ReportParameter("TenBaoCao", "SỔ QUỸ TIỀN MẶT"))
            .Add(New ReportParameter("ThoiGian", ThoiGian))
            .Add(New ReportParameter("NgayIn", Now))
            .Add(New ReportParameter("DuDauKy", lblDauKy.Text))
            .Add(New ReportParameter("TongThu", lblTongThu.Text))
            .Add(New ReportParameter("TongChi", lblTongChi.Text))
            .Add(New ReportParameter("DuCuoiKy", lblCuoiKy.Text))

        End With
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = My.Settings.ZoomReport
        Me.ReportViewer1.RefreshReport()

        frm.Dismiss()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn thay đổi quỹ tiền đầu vào của công ty?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CuaHang.QuyTienDauKy = nudQuyDauKy.Value
            dt.SubmitChanges()
        End If
    End Sub

    Dim CuaHang As tbCuaHang
    Private Sub ctrlThongKeQuyTien_Load(sender As Object, e As EventArgs) Handles Me.Load
        CuaHang = dt.tbCuaHangs.First
        nudQuyDauKy.Value = CuaHang.QuyTienDauKy

        dtpTuNgay.Value = New Date(Now.Year, Now.Month, 1)
    End Sub
End Class
