Imports System.Globalization
Imports Microsoft.Reporting.WinForms

Public Class ctrlThongKeThuChi
    Private Sub rdoTheoNgay_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTheoNgay.CheckedChanged
        pnlTheoThang.Enabled = False
        pnlTheoNgay.Enabled = True

    End Sub

    Private Sub rdoTheoThang_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTheoThang.CheckedChanged
        pnlTheoThang.Enabled = True
        pnlTheoNgay.Enabled = False
    End Sub


    Private TuNgayThongKe As Date
    Private DenNgayThongKe As Date


    Dim rlsChiTiet As New List(Of clsChiTietThongKeThuChi)
    Dim lstKetQua As New List(Of clsThongKeThuChi)
    Private ThongKeTheo As String


    Private ThoiGianTimKiem As String = ""
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim frm As New Tmt.Toolkit.ProgressingDialog
        frm.Animation = Tmt.Toolkit.ProgressingDialog.AnimationStyle.Waiting
        frm.Caption = "Đang thống kê..."
        frm.DialogStyle = Tmt.Toolkit.ProgressingDialog.ProgressingDialogStyle.ContinuingDialog
        frm.Show()

        
        rlsChiTiet.Clear()
        lstKetQua.Clear()

        Dim TuNgay As Date
        Dim DenNgay As Date
        If rdoTheoNgay.Checked Then
            ThongKeTheo = "dd"
            TuNgayThongKe = dtpTuNgay.Value.Date
            DenNgayThongKe = dtpDenNgay.Value.Date
            TuNgay = New Date(TuNgayThongKe.Year, TuNgayThongKe.Month, TuNgayThongKe.Day)
            DenNgay = New Date(DenNgayThongKe.Year, DenNgayThongKe.Month, DenNgayThongKe.Day)
            ThoiGianTimKiem = " TỪ NGÀY " + TuNgayThongKe.ToString("dd/MM/yyyy") + " ĐẾN NGÀY " + DenNgayThongKe.ToString("dd/MM/yyyy")
        Else
            ThongKeTheo = "MM"
            TuNgayThongKe = dtpTuThang.Value.Date
            DenNgayThongKe = dtpDenThang.Value.Date
            TuNgay = New Date(TuNgayThongKe.Year, TuNgayThongKe.Month, 1)
            Dim DenThang As Date = New Date(DenNgayThongKe.Year, DenNgayThongKe.Month, 1)
            DenNgay = DenThang.AddMonths(1).AddDays(-1)
            ThoiGianTimKiem = " TỪ THÁNG " + TuNgayThongKe.ToString("MM/yyyy") + " ĐẾN THÁNG " + DenNgayThongKe.ToString("MM/yyyy")
        End If

        ' 1: Thu nợ khách hàng
        Dim rlsThuNo = From itm In dt.tbThuNoKhachHangs
                       Where itm.NgayThu.Date >= TuNgay And itm.NgayThu.Date <= DenNgay
                       Where itm.idPhieuNhap Is Nothing
                       Select New clsChiTietThongKeThuChi With {
                          .Thu = 1,
                           .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayThu,
                          .DienGiai = itm.GhiChu + " (" + itm.tbKhachHang.TenKhachHang + ")",
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayThu),
                          .TongThu = itm.SoTien
                          }

        ' 2: Thu khác
        Dim rlsThu = From itm In dt.vwPhieuThus
                     Where itm.NgayLap.Date >= TuNgay And itm.NgayLap.Date <= DenNgay.Date
                     Select New clsChiTietThongKeThuChi With {
                          .Thu = 2,
                         .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap,
                          .DienGiai = itm.LyDo,
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                          .TongThu = itm.SoTien
                          }


        ' -2: Chi khác
        Dim rlsChi = From itm In dt.vwPhieuChis
                     Where itm.NgayLap.Date >= TuNgay And itm.NgayLap.Date <= DenNgay.Date
                     Select New clsChiTietThongKeThuChi With {
                          .Thu = -2,
                         .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap,
                          .DienGiai = itm.LyDo,
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                          .TongChi = itm.SoTien
                          }

        ' -1 Chi trả nợ nhà cung cấp
        Dim rlsTraNo = From itm In dt.tbTraNoNhaCungCaps
                       Where itm.NgayTra.Date >= TuNgay And itm.NgayTra.Date <= DenNgay
                       Where itm.idPhieuXuat Is Nothing
                       Select New clsChiTietThongKeThuChi With {
                          .Thu = -1,
                           .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayTra,
                          .DienGiai = itm.GhiChu + " (" + itm.tbKhachHang.TenKhachHang + ")",
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayTra),
                          .TongChi = itm.SoTien
                          }


        rlsChiTiet.AddRange(rlsThu)
        rlsChiTiet.AddRange(rlsThuNo)
        rlsChiTiet.AddRange(rlsChi)
        rlsChiTiet.AddRange(rlsTraNo)


        If rdoTheoNgay.Checked Then
            lstKetQua = (From itm In rlsChiTiet
                         Group By itm.ThoiGian.Date Into ThuNo = Sum(If(itm.Thu = 1, itm.TongThu, 0)),
                                                        ThuKhac = Sum(If(itm.Thu = 2, itm.TongThu, 0)),
                                                        ChiKhac = Sum(If(itm.Thu = -2, itm.TongChi, 0)),
                                                        TraNo = Sum(If(itm.Thu = -1, itm.TongChi, 0))
                         Select New clsThongKeThuChi With {
                            .ThoiGian = [Date],
                            .ThoiGianString = String.Format("{0:dd/MM/yyyy}", [Date]),
                            .ThuNo = ThuNo,
                            .ThuKhac = ThuKhac,
                            .ChiKhac = ChiKhac,
                            .TraNo = TraNo
                            }).ToList

            Dim i As Integer = 0
            While TuNgay.AddDays(i) <= DenNgay
                If Not lstKetQua.Any(Function(s) s.ThoiGian = TuNgay.AddDays(i)) Then
                    Dim newThuChi As New clsThongKeThuChi
                    With newThuChi
                        .ThoiGian = TuNgay.AddDays(i)
                        .ThoiGianString = String.Format("{0:dd/MM/yyyy}", TuNgay.AddDays(i))
                    End With
                    lstKetQua.Add(newThuChi)
                End If
                i += 1
            End While
        Else
            lstKetQua = (From itm In rlsChiTiet
                         Group By itm.ThoiGian.Year, itm.ThoiGian.Month Into ThuNo = Sum(If(itm.Thu = 1, itm.TongThu, 0)),
                                                                            ThuKhac = Sum(If(itm.Thu = 2, itm.TongThu, 0)),
                                                                            ChiKhac = Sum(If(itm.Thu = -2, itm.TongChi, 0)),
                                                                            TraNo = Sum(If(itm.Thu = -1, itm.TongChi, 0))
                         Select New clsThongKeThuChi With {
                            .ThoiGian = New Date(Year, Month, 1),
                            .ThoiGianString = String.Format("{0:MM/yyyy}", .ThoiGian),
                            .ThuNo = ThuNo,
                            .ThuKhac = ThuKhac,
                            .ChiKhac = ChiKhac,
                            .TraNo = TraNo
                            }).ToList

            Dim i As Integer = 0
            While TuNgay.AddMonths(i) <= DenNgay
                If Not lstKetQua.Any(Function(s) s.ThoiGian = TuNgay.AddMonths(i)) Then
                    Dim newThuChi As New clsThongKeThuChi
                    With newThuChi
                        .ThoiGian = TuNgay.AddMonths(i)
                        .ThoiGianString = String.Format("{0:MM/yyyy}", TuNgay.AddMonths(i))
                    End With
                    lstKetQua.Add(newThuChi)
                End If
                i += 1
            End While
        End If
        bsThongKe.DataSource = From itm In lstKetQua Order By itm.ThoiGian

        ' Tính tổng
        lblTongThu.Text = lstKetQua.Sum(Function(s) s.TongThu).ToString("N0")
        lblTongChi.Text = lstKetQua.Sum(Function(s) s.TongChi).ToString("N0")
        If rdoTheoNgay.Checked Then
            lblSoDong.Text = bsThongKe.Count.ToString + " ngày"
        Else
            lblSoDong.Text = bsThongKe.Count.ToString + " tháng"
        End If
        frm.Dismiss()
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If bsThongKe.Count > 0 Then
            Dim frm As New frmInDanhSach
            frm.timkiemtheo = ""
            frm.ThoiGianTimKiem = ""
            frm.Text = "BÁO CÁO THU CHI" + ThoiGianTimKiem
            frm._bs = bsThongKe
            frm.rptName = ".\Report\ThuChi\rptThongKeThuChi.rdlc"
            frm.dsName = "dsThongKe"
            frm.Show()
        End If
    End Sub

    'Private Sub btnXemBieuDo_Click(sender As Object, e As EventArgs) Handles btnXemBieuDo.Click
    '    If bsThongKe.Count > 0 Then
    '        Dim frm As New frmXemBieuDo

    '        ' Tạo biểu đồ 
    '        frm.CtrlBieuDoThuChi1.bsData = bsThongKe
    '        frm.CtrlBieuDoThuChi1.TenBieuDo = "BIỂU ĐỒ THU CHI" + ThoiGianTimKiem
    '        If ThongKeTheo = "dd" Then
    '            frm.CtrlBieuDoThuChi1.TaoBanDau("dd")
    '        Else
    '            frm.CtrlBieuDoThuChi1.TaoBanDau("MM")
    '        End If
    '        frm.CtrlBieuDoThuChi1.CapNhat()
    '        frm.Show()
    '    End If
    'End Sub

    Private Sub bsThongKe_CurrentChanged(sender As Object, e As EventArgs) Handles bsThongKe.CurrentChanged
        If bsThongKe.Current IsNot Nothing Then
            Dim ThuChi As clsThongKeThuChi = bsThongKe.Current
            If ThongKeTheo = "dd" Then
                bsChiTiet.DataSource = From itm In rlsChiTiet
                                       Where itm.ThoiGian.Date = ThuChi.ThoiGian.Date
            Else
                bsChiTiet.DataSource = From itm In rlsChiTiet
                                       Where itm.Thang = ThuChi.ThoiGian.Date
            End If
        End If
    End Sub

    Private Sub dgvChiTiet_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvChiTiet.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT2.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub btnInDanhSachChiTiet_Click(sender As Object, e As EventArgs) Handles btnInDanhSachChiTiet.Click
        Dim frm As New frmInDanhSach
        frm.rptName = ".\Report\ThuChi\rptBangKeChiTietThuChi.rdlc"
        frm.dsName = "dsThongKe"
        frm.Text = "BẢNG KÊ CHI TIẾT THU CHI"
        frm.ThoiGianTimKiem = ThoiGianTimKiem
        frm.timkiemtheo = ""
        frm._bs = bsChiTiet
        frm.Show()
    End Sub

    Private Sub btnInTatCa_Click(sender As Object, e As EventArgs) Handles btnInTatCa.Click
        Dim frm As New frmInDanhSach
        frm.rptName = ".\Report\ThuChi\rptBangKeChiTietThuChi.rdlc"
        frm.dsName = "dsThongKe"
        frm.Text = "BẢNG KÊ CHI TIẾT THU CHI"
        frm.ThoiGianTimKiem = ThoiGianTimKiem
        frm.timkiemtheo = ""
        frm._bs.DataSource = From ITM In rlsChiTiet
        frm.Show()
    End Sub
End Class
