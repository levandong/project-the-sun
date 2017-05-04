Public Class ctrlThongKeTienNganHang
    Dim lst As New List(Of clsChiTietThongKeThuChi)
    Dim rls As New List(Of clsChiTietThongKeThuChi)
    Dim rlsTinhToan As New List(Of clsChiTietThongKeThuChi)
    Dim rlsThongKe As List(Of clsChiTietThongKeThuChi)
    Dim rlsListChonTam As New List(Of clsChiTietThongKeThuChi)
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        rlsTinhToan.Clear()
        rlsSoDuDauKy.Clear()
        rls.Clear()
        TienDauKy()
        Dim TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        Dim DenNgay = CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value
        'PhieuThu Uy Nhiem Chi
        Dim rlsThuUyNhiemChi = From itm In dt.tbPhieuUyNhiemChis
                               Where itm.NgayLap.Date >= TuNgay And itm.NgayLap.Date <= DenNgay
                               Where itm.isPhieuThu = True
                               Select New clsChiTietThongKeThuChi With {
                          .Thu = 3,
                          .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap,
                                   .DienGiai = itm.ChungTuKemTheo,
                          .TenKhachHang = itm.tbKhachHang.TenKhachHang,
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                          .TongThu = itm.SoTien,
                                   .TienPhi = itm.MucPhi,
                                   .TenKhachHangUNC = itm.tbKhachHang1.TenKhachHang,
                                   .GhiChu = itm.NoiDung,
                          .idNganHang = itm.idNganHang,
                                   .MaNganHang = itm.tbNganHang.MaNganHang,
                                   .idPhieu = itm.ID
                          }
        Dim rlsChiUyNhiemChi = From itm In dt.tbPhieuUyNhiemChis
                               Where itm.NgayLap.Date >= TuNgay And itm.NgayLap.Date <= DenNgay
                               Where itm.isPhieuThu = False
                               Select New clsChiTietThongKeThuChi With {
                          .Thu = 3,
                          .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap,
                                   .DienGiai = itm.ChungTuKemTheo,
                          .TenKhachHang = itm.tbKhachHang.TenKhachHang,
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                          .TongChi = itm.SoTien,
                                   .TienPhi = itm.MucPhi,
                                    .TenKhachHangUNC = itm.tbKhachHang1.TenKhachHang,
                                   .GhiChu = itm.NoiDung,
                          .idNganHang = itm.idNganHang,
                                   .MaNganHang = itm.tbNganHang.MaNganHang,
                                        .idPhieu = itm.ID
                          }
        Dim rlsPhatLuong = From itm In dt.tbPhieuChis
                           Where itm.NgayLap.Date >= TuNgay And itm.NgayLap.Date <= DenNgay
                           Where itm.tbLoaiPhieuChi.Loai = -1
                           Where itm.idPhieuNhap Is Nothing
                           Select New clsChiTietThongKeThuChi With {
                          .Thu = 2,
                          .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap,
                          .DienGiai = itm.LyDo,
                           .TenKhachHang = itm.tbNhanVien.TenNhanVien,
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                           .GhiChu = "",
                          .TongChi = itm.SoTien,
                            .TienPhi = itm.MucPhi,
                          .idNganHang = itm.idNganHang,
                               .MaNganHang = itm.tbNganHang.MaNganHang,
                                    .idPhieu = itm.id
                          }
        Dim rlsTraNo = From itm In dt.tbPhieuChis
                       Where itm.NgayLap.Date >= TuNgay And itm.NgayLap.Date <= DenNgay
                       Where itm.tbLoaiPhieuChi.Loai > 0
                       Where itm.idPhieuNhap Is Nothing
                       Select New clsChiTietThongKeThuChi With {
                          .Thu = 2,
                          .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap,
                          .TenKhachHang = itm.tbLoaiPhieuChi.LoaiChi,
                           .TenKhachHangUNC = "",
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                           .DienGiai = itm.LyDo,
                           .GhiChu = "",
                          .TongChi = itm.SoTien,
                            .TienPhi = itm.MucPhi,
                          .idNganHang = itm.idNganHang,
                           .MaNganHang = itm.tbNganHang.MaNganHang,
                                .idPhieu = itm.id
                          }
        Dim rlsThuNo = From itm In dt.tbPhieuThus
                       Where itm.NgayLap.Date >= TuNgay And itm.NgayLap.Date <= DenNgay
                       Where itm.tbLoaiPhieuThu.Loai > 0
                       Select New clsChiTietThongKeThuChi With {
                          .Thu = 1,
                          .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap,
                          .TenKhachHang = itm.tbLoaiPhieuThu.LoaiThu,
                          .TenKhachHangUNC = "",
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                          .DienGiai = itm.LyDo,
                          .GhiChu = "",
                          .TongThu = itm.SoTien,
                          .TienPhi = itm.MucPhi,
                          .idNganHang = itm.idNganHang,
                          .MaNganHang = itm.tbNganHang.MaNganHang,
                          .idPhieu = itm.id
                          }
        rls.AddRange(rlsPhatLuong)
        rls.AddRange(rlsTraNo)
        rls.AddRange(rlsThuNo)
        rls.AddRange(rlsChiUyNhiemChi)
        rls.AddRange(rlsThuUyNhiemChi)
        For Each itm In dt.tbNganHangs
            Dim rlsTam = rls.Where(Function(s) s.idNganHang = itm.id).OrderBy(Function(s) s.ThoiGian).ToList
            For i = 0 To rlsTam.Count - 1
                If i > 0 Then
                    rlsTam(i).TongTien = rlsTam(i - 1).TongTien + rlsTam(i).TongThu - rlsTam(i).TongChi - rlsTam(i).TienPhi
                Else
                    rlsTam(i).TongTien = rlsSoDuDauKy.Single(Function(s) s.idNganHang = itm.id).TongTien + rlsTam(i).TongThu - rlsTam(i).TongChi
                End If
            Next
            rlsTinhToan.AddRange(rlsTam)
        Next
        rlsThongKe = (From itm In rls.ToList
                      Group By itm.idNganHang, itm.TenNganHang Into TongChi = Sum(itm.TongChi), TongThu = Sum(itm.TongThu), TongTien = Sum(itm.TongTien), TienPhi = Sum(itm.TienPhi)
                      Select New clsChiTietThongKeThuChi With {
                          .Thu = 1,
                          .SoPhieu = 0,
                          .ThoiGian = Now.Date,
                          .DienGiai = "",
                          .ThoiGianString = "",
                          .TongChi = TongChi,
                          .TongThu = TongThu,
                          .TongTien = TongThu - TongChi - TienPhi + rlsSoDuDauKy.Single(Function(s) s.idNganHang = idNganHang).TongTien,
                          .idNganHang = idNganHang
                          }).ToList
        For Each itm In rlsThongKe
            If rlsListChonTam.Where(Function(s) s.idNganHang = itm.idNganHang).Count > 0 Then
                itm.Chon = True
            End If
        Next

        gridControl.DataSource = (From itm In rlsThongKe
                                  Order By itm.TenNganHang).ToList()

        gridViewData.RefreshData()

        'CapNhatListChonTam(rlsThongKe)

        gridViewData_FocusedRowChanged(Nothing, Nothing)
    End Sub
    Dim rlsSoDuDauKy As New List(Of clsChiTietThongKeThuChi)
    Sub TienDauKy()
        Dim rlsDauKy As New List(Of clsChiTietThongKeThuChi)
        Dim TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        'PhieuThu Uy Nhiem Chi
        Dim rlsThuUyNhiemChi = From itm In dt.tbPhieuUyNhiemChis
                               Where itm.NgayLap.Date < TuNgay
                               Where itm.isPhieuThu = True
                               Select New clsChiTietThongKeThuChi With {
                                   .Thu = 3,
                                   .SoPhieu = itm.SoPhieu,
                                   .ThoiGian = itm.NgayLap,
                                   .DienGiai = "Thu tiền nợ" + " (" + itm.tbKhachHang.TenKhachHang + ")",
                                   .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                                   .TongThu = itm.SoTien,
                                   .TienPhi = itm.MucPhi,
                                   .idNganHang = itm.idNganHang,
                                   .TenKhachHang = ""}

        Dim rlsChiUyNhiemChi = From itm In dt.tbPhieuUyNhiemChis
                               Where itm.NgayLap.Date < TuNgay
                               Where itm.isPhieuThu = False
                               Select New clsChiTietThongKeThuChi With {
                          .Thu = 3,
                          .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap,
                          .DienGiai = "Trả tiền nợ" + " (" + itm.tbKhachHang.TenKhachHang + ")",
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                          .TongChi = itm.SoTien,
                                   .TienPhi = itm.MucPhi,
                          .idNganHang = itm.idNganHang,
                             .TenKhachHang = ""
                          }
        Dim rlsChi = From itm In dt.tbPhieuChis
                     Where itm.NgayLap.Date < TuNgay
                     Select New clsChiTietThongKeThuChi With {
                          .Thu = 2,
                          .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap.Date,
                          .DienGiai = itm.tbLoaiPhieuChi.LoaiChi,
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                          .TongChi = itm.SoTien,
                            .TienPhi = itm.MucPhi,
                          .idNganHang = itm.idNganHang,
                             .TenKhachHang = ""
                         }
        Dim rlsThu = From itm In dt.tbPhieuThus
                     Where itm.NgayLap.Date < TuNgay
                     Select New clsChiTietThongKeThuChi With {
                          .Thu = 2,
                          .SoPhieu = itm.SoPhieu,
                          .ThoiGian = itm.NgayLap.Date,
                          .DienGiai = itm.tbLoaiPhieuThu.LoaiThu,
                          .ThoiGianString = String.Format("{0:dd/MM/yyyy}", itm.NgayLap),
                          .TongThu = itm.SoTien,
                            .TienPhi = itm.MucPhi,
                          .idNganHang = itm.idNganHang,
                             .TenKhachHang = ""
                         }
        rlsDauKy.AddRange(rlsChi)
        rlsDauKy.AddRange(rlsThu)
        rlsDauKy.AddRange(rlsChiUyNhiemChi)
        rlsDauKy.AddRange(rlsThuUyNhiemChi)
        Dim rlsDuDauKy = From itm In rlsDauKy.ToList
                         Group By itm.idNganHang Into TongChi = Sum(itm.TongChi), TongThu = Sum(itm.TongThu), TienPhi = Sum(itm.TienPhi)
                         Select New clsChiTietThongKeThuChi With {
                          .Thu = -1,
                             .MaNganHang = dt.tbNganHangs.Single(Function(s) s.id = idNganHang).MaNganHang,
                          .SoPhieu = 0,
                          .ThoiGian = TuNgay.AddDays(-1),
                          .DienGiai = "Số dư đầu kỳ",
                          .ThoiGianString = "",
                          .TongChi = 0,
                             .TongThu = 0,
                                   .TongTien = dt.tbNganHangs.Single(Function(s) s.id = idNganHang).SoDuDauKy + TongThu - TongChi - TienPhi,
                             .TienPhi = 0,
                          .idNganHang = idNganHang,
                             .TenKhachHang = ""
                          }
        rlsSoDuDauKy.AddRange(rlsDuDauKy)
        For Each itm In dt.tbNganHangs
            If rlsSoDuDauKy.Where(Function(s) s.idNganHang = itm.id).Count = 0 Then
                Dim NganHang As New clsChiTietThongKeThuChi
                With NganHang
                    .Thu = -1
                    .SoPhieu = 0
                    .MaNganHang = itm.MaNganHang
                    .ThoiGian = TuNgay.AddDays(-1)
                    .DienGiai = "Số dư đầu kỳ"
                    .ThoiGianString = ""
                    .TongChi = 0
                    .TongThu = 0
                    .TongTien = itm.SoDuDauKy
                    .idNganHang = itm.id
                    .TenKhachHang = ""
                End With
                rlsSoDuDauKy.Add(NganHang)
            End If
        Next
        rls.AddRange(rlsSoDuDauKy)
    End Sub
    Function LayNganHangDangChon() As tbNganHang
        Dim idNganHang As Integer
        If rlsListChonTam.Count = 0 Then
            If gridViewData.FocusedRowHandle >= 0 Then
                Dim nganhang As clsChiTietThongKeThuChi = gridViewData.GetRow(gridViewData.FocusedRowHandle)
                idNganHang = nganhang.idNganHang
            End If

        ElseIf rlsListChonTam.Count = 1 Then
            idNganHang = rlsListChonTam(0).idNganHang
        Else
            If gridViewDetail.FocusedRowHandle > 0 Then
                Dim PhieuDangChon As clsChiTietThongKeThuChi = gridViewDetail.GetRow(gridViewDetail.FocusedRowHandle)
                idNganHang = PhieuDangChon.idNganHang
            End If

        End If
        Return dt.tbNganHangs.Single(Function(s) s.id = idNganHang)
    End Function
    Private Sub ctrlThongKeTienNganHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = New Date(Now.Year, Now.Month, 1)
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 0)
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, Me.Size.Height - txtKhachHang.Location.Y - 245)
        Me.Controls.Add(ctrl)
        btnTimKiem_Click(Nothing, Nothing)
    End Sub


    Sub CapNhat()
        btnTimKiem_Click(Nothing, Nothing)
    End Sub
    Public Sub frmThemPhieuThuTienMat_Click(sender As Object, e As EventArgs) Handles btnThemPhieuThuTienMat.Click
        Dim frm As New frmThemPhieuThuTienMat
        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Public Sub btnThemPhieuChiTienMat_Click(sender As Object, e As EventArgs) Handles btnThemPhieuChiTienMat.Click
        Dim frm As New frmThemPhieuChiTienMat
        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Public Sub btnThemPhieuThuUyNhiemChi_Click(sender As Object, e As EventArgs) Handles btnThemPhieuThuUyNhiemChi.Click
        Dim frm As New frmThemPhieuThuUyNhiemChi
        frm.NganHang = LayNganHangDangChon()
        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Public Sub btnThemPhieuChiUyNhiemChi_Click(sender As Object, e As EventArgs) Handles btnThemPhieuChiUyNhiemChi.Click
        Dim frm As New frmThemPhieuChiUyNhiemChi
        frm.Nganhang = LayNganHangDangChon()
        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Public Sub btnThemPhieuDieuChuyenTien_Click(sender As Object, e As EventArgs) Handles btnThemPhieuDieuChuyenTien.Click
        Dim frm As New frmThemDieuChuyenUyNhiemChi
        frm.Nganhang = LayNganHangDangChon()
        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Public Sub btnThemPhieuChiLuong_Click(sender As Object, e As EventArgs) Handles btnThemPhieuChiLuong.Click
        Dim frm As New frmThemPhieuChi
        frm.NganHang = LayNganHangDangChon()
        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Public Sub btnThemPhieuChiKhac_Click(sender As Object, e As EventArgs) Handles btnThemPhieuChiKhac.Click
        Dim frm As New frmThemPhieuChiTheoLoai
        frm.NganHang = LayNganHangDangChon()
        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Private Sub dgvLoaiSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        gridViewData_FocusedRowChanged(Nothing, Nothing)
    End Sub

    Private Sub dgvLoaiSanPham_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        'If dgvTongHop.IsCurrentCellDirty Then
        '    dgvTongHop.CommitEdit(DataGridViewDataErrorContexts.Commit)
        'End If
    End Sub

    Sub CapNhatListChonTam(rls As List(Of clsChiTietThongKeThuChi))
        rlsListChonTam.Clear()
        For Each im In (From itm In rls
                        Where itm.Chon = True
                        Select itm.idNganHang).ToList
            Dim temp As New clsChiTietThongKeThuChi
            temp.Chon = True
            temp.idNganHang = im
            rlsListChonTam.Add(temp)
        Next
    End Sub


    Private Sub XóaPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaPhiếuToolStripMenuItem.Click
        If gridViewDetail.FocusedRowHandle < 0 Then Exit Sub
        Dim PhieuDangChon As clsChiTietThongKeThuChi = gridViewDetail.GetRow(gridViewDetail.FocusedRowHandle)

        If XacNhanYesNo("Bạn có chắc muốn xóa phiếu") = DialogResult.No Then Exit Sub
        If PhieuDangChon.idPhieu = 0 Then
            ThongBaoError("Bạn không thể xóa phiếu này")
            Exit Sub
        End If
        If PhieuDangChon.Thu = 3 Then
            Dim PhieuUyNhiemChi = dt.tbPhieuUyNhiemChis.Single(Function(s) s.ID = PhieuDangChon.idPhieu)
            If PhieuUyNhiemChi.idPhieuChuyenTien Is Nothing And PhieuUyNhiemChi.tbPhieuUyNhiemChis.Count = 0 Then
                dt.tbPhieuUyNhiemChis.DeleteOnSubmit(PhieuUyNhiemChi)
            ElseIf PhieuUyNhiemChi.idPhieuChuyenTien Is Nothing Then
                Dim PhieuGoc = dt.tbPhieuUyNhiemChis.Single(Function(s) s.idPhieuChuyenTien = PhieuUyNhiemChi.ID)
                PhieuGoc.tbPhieuUyNhiemChi = Nothing
                dt.tbPhieuUyNhiemChis.DeleteOnSubmit(PhieuGoc)
                dt.tbPhieuUyNhiemChis.DeleteOnSubmit(PhieuUyNhiemChi)
            Else
                Dim PhieuGoc = dt.tbPhieuUyNhiemChis.Single(Function(s) s.ID = PhieuUyNhiemChi.idPhieuChuyenTien)
                PhieuUyNhiemChi.tbPhieuUyNhiemChi = Nothing
                dt.tbPhieuUyNhiemChis.DeleteOnSubmit(PhieuUyNhiemChi)
                dt.tbPhieuUyNhiemChis.DeleteOnSubmit(PhieuGoc)
            End If
        ElseIf PhieuDangChon.Thu = 2 Then
            dt.tbPhieuChis.DeleteOnSubmit(dt.tbPhieuChis.Single(Function(s) s.id = PhieuDangChon.idPhieu))
        ElseIf PhieuDangChon.Thu = 1 Then
            dt.tbPhieuThus.DeleteOnSubmit(dt.tbPhieuThus.Single(Function(s) s.id = PhieuDangChon.idPhieu))
        End If
        Try
            dt.SubmitChanges()
            btnTimKiem_Click(Nothing, Nothing)
        Catch ex As Exception
            undoChange()
            ThongBao("Có lỗi trong quá trình xóa" + ex.Message)
        End Try

    End Sub


    Private Sub SửaPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SửaPhiếuToolStripMenuItem.Click
        If gridViewDetail.FocusedRowHandle < 0 Then Exit Sub
        Dim PhieuDangChon As clsChiTietThongKeThuChi = gridViewDetail.GetRow(gridViewDetail.FocusedRowHandle)
        If PhieuDangChon.idPhieu = 0 Then
            ThongBaoError("Bạn không thể sửa mục này")
            Exit Sub
        End If
        If PhieuDangChon.Thu = 3 Then
            Dim PhieuUyNhiemChi = dt.tbPhieuUyNhiemChis.Single(Function(s) s.ID = PhieuDangChon.idPhieu)
            If PhieuUyNhiemChi.idPhieuChuyenTien Is Nothing And PhieuUyNhiemChi.tbPhieuUyNhiemChis.Count = 0 Then
                If PhieuDangChon.TongThu > 0 And PhieuUyNhiemChi.isThuTienMat = False Then
                    Try
                        Dim frm As New frmThemPhieuChiUyNhiemChi
                        frm.PhieuUyNhiemChi = PhieuUyNhiemChi
                        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
                        frm.ShowDialog()
                    Catch ex As Exception
                        undoChange()
                        ThongBao("Có lỗi trong quá trình sửa" + ex.Message)
                    End Try
                ElseIf PhieuDangChon.TongChi > 0 And PhieuUyNhiemChi.isThuTienMat = False Then
                    Try
                        Dim frm As New frmThemPhieuThuUyNhiemChi
                        frm.PhieuUyNhiemChi = PhieuUyNhiemChi
                        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
                        frm.ShowDialog()
                    Catch ex As Exception
                        undoChange()
                        ThongBao("Có lỗi trong quá trình sửa" + ex.Message)
                    End Try
                ElseIf PhieuUyNhiemChi.isThuTienMat = True And PhieuUyNhiemChi.isPhieuThu = True Then
                    Try
                        Dim frm As New frmThemPhieuThuTienMat
                        frm.PhieuUyNhiemChi = PhieuUyNhiemChi
                        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
                        frm.ShowDialog()
                    Catch ex As Exception
                        undoChange()
                        ThongBao("Có lỗi trong quá trình sửa" + ex.Message)
                    End Try
                ElseIf PhieuUyNhiemChi.isThuTienMat = True And PhieuUyNhiemChi.isPhieuThu = False Then
                    Try
                        Dim frm As New frmThemPhieuChiTienMat
                        frm.PhieuUyNhiemChi = PhieuUyNhiemChi
                        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
                        frm.ShowDialog()
                    Catch ex As Exception
                        undoChange()
                        ThongBao("Có lỗi trong quá trình sửa" + ex.Message)
                    End Try
                End If
            Else
                Try
                    Dim frm As New frmThemDieuChuyenUyNhiemChi
                    frm.PhieuUyNhiemChi = PhieuUyNhiemChi
                    AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
                    frm.ShowDialog()
                Catch ex As Exception
                    undoChange()
                    ThongBao("Có lỗi trong quá trình sửa" + ex.Message)
                End Try
            End If


        ElseIf PhieuDangChon.Thu = 2 Then
            If PhieuDangChon.TongChi > 0 Then
                Dim PhieuChi = dt.tbPhieuChis.Single(Function(s) s.id = PhieuDangChon.idPhieu)
                If PhieuChi.tbLoaiPhieuChi.Loai = -1 Then
                    Dim frm As New frmThemPhieuChi
                    frm.PhieuChi = PhieuChi
                    AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
                    frm.ShowDialog()
                Else
                    Dim frm As New frmThemPhieuChiTheoLoai
                    frm.PhieuChi = PhieuChi
                    AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
                    frm.ShowDialog()
                End If
            End If
        ElseIf PhieuDangChon.Thu = 1 Then
            Dim PhieuThu = dt.tbPhieuThus.Single(Function(s) s.id = PhieuDangChon.idPhieu)
            If PhieuThu.tbLoaiPhieuThu.Loai = -1 Then

            Else
                Dim frm As New frmThemPhieuThuTheoLoai
                frm.PhieuThu = PhieuThu
                AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub dgvChiTiet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        SửaPhiếuToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Public Sub btnThemPhieuThuKhac_Click(sender As Object, e As EventArgs) Handles btnThemPhieuThuKhac.Click
        Dim frm As New frmThemPhieuThuTheoLoai
        AddHandler frm.ThemPhieuThanhCong, AddressOf CapNhat
        frm.NganHang = LayNganHangDangChon()
        frm.ShowDialog()
    End Sub

    Private Sub InPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InPhiếuToolStripMenuItem.Click
        If gridViewDetail.FocusedRowHandle < 0 Then Exit Sub
        Dim PhieuDangChon As clsChiTietThongKeThuChi = gridViewDetail.GetRow(gridViewDetail.FocusedRowHandle)
        If PhieuDangChon.idPhieu = 0 Then
            ThongBaoError("Bạn không thể sửa mục này")
            Exit Sub
        End If
        If PhieuDangChon.Thu = 3 Then
            Dim PhieuUyNhiemChi = dt.tbPhieuUyNhiemChis.Single(Function(s) s.ID = PhieuDangChon.idPhieu)
            If PhieuUyNhiemChi.idPhieuChuyenTien Is Nothing And PhieuUyNhiemChi.tbPhieuUyNhiemChis.Count = 0 Then
                If PhieuDangChon.TongThu > 0 And PhieuUyNhiemChi.isThuTienMat = False Then
                    Dim frm As New frmInPhieuUyNhiemChi
                    frm.CtrlInPhieuUyNhiemChi1.PhieuUyNhiemChi = PhieuUyNhiemChi
                    frm.Show()
                ElseIf PhieuDangChon.TongChi > 0 And PhieuUyNhiemChi.isThuTienMat = False Then
                    'PhieuChiTien từ mình chuyển
                    If PhieuUyNhiemChi.tbNganHang.LoaiNganHang = THEONGANHANG.DONGA Then
                        TaoPhieuUyChiDongA(Application.StartupPath + "\UyNhiemChi\UyNhiemChiDongA.xlsx", PhieuUyNhiemChi)
                    ElseIf PhieuUyNhiemChi.tbNganHang.LoaiNganHang = THEONGANHANG.AGRIBANK Then
                        TaoPhieuUyNhiemChiAgribank(Application.StartupPath + "\UyNhiemChi\UyNhiemChiAgribank.xlsx", PhieuUyNhiemChi)
                    ElseIf PhieuUyNhiemChi.tbNganHang.LoaiNganHang = THEONGANHANG.VIETTINBANK Then
                        TaoPhieuUyNhiemChiVietinBank(Application.StartupPath + "\UyNhiemChi\UyNhiemChiVietinbank.xlsx", PhieuUyNhiemChi)
                    Else
                        TaoPhieuUyNhiemChiKhac(Application.StartupPath + "\UyNhiemChi\UyNhiemChiKhac.xlsx", PhieuUyNhiemChi)
                    End If
                    'Dim frm As New frmInPhieuUyNhiemChi
                    'frm.CtrlInPhieuUyNhiemChi1.PhieuUyNhiemChi = PhieuUyNhiemChi
                    'frm.Show()
                ElseIf PhieuUyNhiemChi.isThuTienMat = True And PhieuDangChon.TongThu > 0 Then
                    TaoPhieuThuTienMat(Application.StartupPath + "\UyNhiemChi\PhieuThuTienMat.xlsx", PhieuUyNhiemChi)
                ElseIf PhieuUyNhiemChi.isThuTienMat = True And PhieuDangChon.TongChi > 0 Then
                    TaoPhieuChiTienMat(Application.StartupPath + "\UyNhiemChi\PhieuChiTienMat.xlsx", PhieuUyNhiemChi)
                End If
            Else
                'Điều chueyern tiền
                Dim frm As New frmInPhieuUyNhiemChi
                If PhieuUyNhiemChi.idPhieuChuyenTien Is Nothing Then
                    TaoPhieuDieuChuyenTien(Application.StartupPath + "\UyNhiemChi\PhieuDieuChuyen.xlsx", dt.tbPhieuUyNhiemChis.Single(Function(s) s.idPhieuChuyenTien = PhieuUyNhiemChi.ID))
                Else
                    TaoPhieuDieuChuyenTien(Application.StartupPath + "\UyNhiemChi\PhieuDieuChuyen.xlsx", PhieuUyNhiemChi)
                End If
                frm.CtrlInPhieuUyNhiemChi1.isDieuChuyen = True
                frm.Show()
            End If


        ElseIf PhieuDangChon.Thu = 2 Then
            If PhieuDangChon.TongChi > 0 Then
                Dim PhieuChi = dt.tbPhieuChis.Single(Function(s) s.id = PhieuDangChon.idPhieu)
                If PhieuChi.tbLoaiPhieuChi.Loai = -1 Then
                    'Chi tiền lương
                Else
                    'Chi khác
                    Dim frm As New frmInPhieuThuChi
                    frm.PhieuChi = dt.vwPhieuChis.Single(Function(s) s.id = PhieuChi.id)
                    frm.Show()
                End If
            ElseIf PhieuDangChon.TongThu > 0 Then
                Dim PhieuThu = dt.tbPhieuThus.Single(Function(s) s.id = PhieuDangChon.idPhieu)
            End If
        ElseIf PhieuDangChon.Thu = 1 Then
            Dim PhieuThu = dt.tbPhieuThus.Single(Function(s) s.id = PhieuDangChon.idPhieu)
            If PhieuThu.tbLoaiPhieuThu.Loai = -1 Then

            Else
                'thu theo loại
                Dim frm As New frmInPhieuThuChi
                frm.PhieuThu = dt.vwPhieuThus.Single(Function(s) s.id = PhieuThu.id)
                frm.Show()
            End If
        End If
    End Sub
    Dim ctrl As New ctrlDGVKhachHang
    Private Sub txtTimKiemNoiDung_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimKiemNoiDung.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTimKiem_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub txtKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtKhachHang.TextChanged
        Dim key = BoDauTiengViet(txtKhachHang.Text.Trim)
        ctrl.BringToFront()
        If key <> "" Then
            ctrl.Visible = True
            ctrl.gridControl.DataSource = From itm In dt.vwKhachHangs
                                          Where itm.MaKhachHang.Contains(key) Or itm.TenKhachHangString.Contains(key) Or itm.MaSoThue.StartsWith(key)
            ctrl.gridViewData.RefreshData()
            If ctrl.gridViewData.DataRowCount = 0 Then
                ctrl.Visible = False
            End If
            ctrl.Size = New Size(txtKhachHang.Size.Width, 380)
        Else
            ctrl.Visible = False
        End If
    End Sub
    Sub ChonKhachHang(KhachHang As tbKhachHang)
        txtKhachHang.Tag = KhachHang
        txtKhachHang.Text = KhachHang.TenKhachHang
    End Sub
    Private Sub txtKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKhachHang.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ctrl.gridViewData.FocusedRowHandle < 0 Then
                Exit Sub
            End If
            Dim vKhachHang As vwKhachHang = ctrl.gridViewData.GetRow(ctrl.gridViewData.FocusedRowHandle)
            Dim Khachhang As tbKhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
            ChonKhachHang(Khachhang)
            ctrl.Visible = False
        ElseIf e.KeyCode = Keys.Down Then
            If ctrl.gridViewData.FocusedRowHandle = ctrl.gridViewData.DataRowCount - 1 Then
                ctrl.gridViewData.FocusedRowHandle = 0
            Else
                ctrl.gridViewData.FocusedRowHandle += 1
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If ctrl.gridViewData.FocusedRowHandle = 0 Then
                ctrl.gridViewData.FocusedRowHandle = ctrl.gridViewData.DataRowCount - 1
            Else
                ctrl.gridViewData.FocusedRowHandle -= 1
            End If
        End If
    End Sub

    Private Sub chkTheoKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoKhachHang.CheckedChanged
        txtKhachHang.Enabled = sender.Checked
    End Sub

    Private Sub chkTheoNoiDung_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNoiDung.CheckedChanged
        txtTimKiemNoiDung.Enabled = sender.Checked
    End Sub


    Private Sub gridViewData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewData.FocusedRowChanged
        rlsListChonTam.Clear()
        If rlsThongKe Is Nothing Then Exit Sub
        Dim rlsTemp = (From itm In rlsThongKe
                       Where itm.Chon = True
                       Select itm.idNganHang).ToList
        Dim rlsTam As New List(Of clsChiTietThongKeThuChi)
        CapNhatListChonTam(rlsThongKe)
        Dim TenKhachHang As String = ""
        If chkTheoKhachHang.Checked AndAlso txtKhachHang.Tag Is Nothing Then
            ThongBao("Vui lòng nhập khách hàng")
            Exit Sub
        End If
        Dim rlsTinhToanNhieu As New List(Of clsChiTietThongKeThuChi)
        If rlsTemp.Count = 0 Then
            Dim ThongKeTien As clsChiTietThongKeThuChi = Nothing
            If gridViewData.FocusedRowHandle >= 0 Then
                ThongKeTien = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            End If
            If ThongKeTien Is Nothing Then
                Exit Sub
            End If
            gridDetailControl.DataSource = (From itm In rlsTinhToan
                                            Where itm.idNganHang = ThongKeTien.idNganHang
                                            Where Not chkTheoNoiDung.Checked Or (BoDauTiengViet(itm.DienGiai).Trim.ToLower.Contains(BoDauTiengViet(txtTimKiemNoiDung.Text.Trim.ToLower)) Or BoDauTiengViet(itm.DienGiai).Trim.ToLower.Contains(BoDauTiengViet(txtTimKiemNoiDung.Text.Trim.ToLower)))
                                            Where Not chkTheoKhachHang.Checked Or itm.TenKhachHang.Trim.Contains(txtKhachHang.Text.Trim)
                                            Order By itm.ThoiGian).ToList

            gridViewDetail.RefreshData()
        Else
            For Each im In (From itm In rlsTinhToan
                            Where rlsTemp.Contains(itm.idNganHang)
                            Order By itm.ThoiGian).ToList
                Dim s = New clsChiTietThongKeThuChi
                With s
                    .Thu = im.Thu
                    .SoPhieu = im.SoPhieu
                    .ThoiGian = im.ThoiGian
                    .DienGiai = im.DienGiai
                    .ThoiGianString = im.ThoiGianString
                    .TongThu = im.TongThu
                    .TienPhi = im.TienPhi
                    .TongChi = im.TongChi
                    .TongTien = im.TongTien
                    .TenKhachHang = im.TenKhachHang
                    .TenKhachHangUNC = im.TenKhachHangUNC
                    .GhiChu = im.GhiChu
                    .idNganHang = im.idNganHang
                    .MaNganHang = im.MaNganHang
                    .idPhieu = im.idPhieu
                End With
                rlsTam.Add(s)
            Next
            For i = 0 To rlsTam.Count - 1
                If rlsTam(i).ThoiGian >= CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value Then
                    rlsTam(i).TongTien = rlsTam(i - 1).TongTien + rlsTam(i).TongThu - rlsTam(i).TongChi - rlsTam(i).TienPhi
                    rlsTinhToanNhieu.Add(rlsTam(i))
                ElseIf i = 0 Then
                    rlsTam(i).TongTien = rlsTam.Where(Function(s) s.ThoiGian < CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value).Sum(Function(s) s.TongTien)
                    rlsTinhToanNhieu.Add(rlsTam(i))
                Else
                    rlsTam(i).TongTien = rlsTam(i - 1).TongTien
                End If
            Next
            gridDetailControl.DataSource = (From itm In rlsTinhToanNhieu
                                            Where Not chkTheoNoiDung.Checked Or (BoDauTiengViet(itm.DienGiai).Trim.ToLower.Contains(BoDauTiengViet(txtTimKiemNoiDung.Text.Trim.ToLower)) Or BoDauTiengViet(itm.DienGiai).Trim.ToLower.Contains(BoDauTiengViet(txtTimKiemNoiDung.Text.Trim.ToLower)))
                                            Where Not chkTheoKhachHang.Checked Or itm.TenKhachHang.Trim.Contains(txtKhachHang.Text.Trim)
                                            Order By itm.ThoiGian).ToList

            gridViewDetail.RefreshData()
        End If
        rlsTam.Clear()
        rlsTinhToanNhieu.Clear()
    End Sub

    Private Sub gridViewData_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridViewData.CustomDrawRowIndicator
        If (e.Info.IsRowIndicator) Then
            If e.RowHandle < 0 Then
                e.Info.ImageIndex = 0
                e.Info.DisplayText = ""
            Else
                e.Info.ImageIndex = 1
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
        End If
    End Sub

    Private Sub gridViewDetail_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridViewDetail.CustomDrawRowIndicator
        If (e.Info.IsRowIndicator) Then
            If e.RowHandle < 0 Then
                e.Info.ImageIndex = 0
                e.Info.DisplayText = ""
            Else
                e.Info.ImageIndex = 1
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
        End If
    End Sub
End Class
