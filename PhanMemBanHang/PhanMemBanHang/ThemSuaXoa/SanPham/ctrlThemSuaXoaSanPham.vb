﻿Public Class ctrlThemSuaXoaSanPham
    Public Sub PhanQuyen(QuyenCha As tbQuyen)
        For Each qc1 In dt.tbQuyens.Where(Function(s) s.idQuyenCha = QuyenCha.id)
            Dim TrangThai As Boolean
            Dim PhanQuyenCap1 = dt.vwPhanQuyens.SingleOrDefault(Function(s) s.idQuyen = qc1.id And s.idNhanVien = loginNhanVien.id)
            If PhanQuyenCap1 Is Nothing Then
                CapNhatQuyen(loginNhanVien.id)
                PhanQuyenCap1 = dt.vwPhanQuyens.Single(Function(s) s.idQuyen = qc1.id And s.idNhanVien = loginNhanVien.id)
            End If
            TrangThai = PhanQuyenCap1.TrangThai

            Select Case qc1.TenControl
                Case "btnThemSanPham"
                    PhanQuyenLenDoiTuong(btnThemSanPham, qc1.HinhThuc, TrangThai)
                Case "btnSuaSanPham"
                    PhanQuyenLenDoiTuong(btnSuaSanPham, qc1.HinhThuc, TrangThai)
                Case "btnXoaSanPham"
                    PhanQuyenLenDoiTuong(btnXoaSanPham, qc1.HinhThuc, TrangThai)

                Case "btnThemLoai"
                    PhanQuyenLenDoiTuong(btnThemLoaiSanPham, qc1.HinhThuc, TrangThai)
                Case "btnSuaLoai"
                    PhanQuyenLenDoiTuong(btnSuaLoaiSanPham, qc1.HinhThuc, TrangThai)
                Case "btnXoaLoai"
                    PhanQuyenLenDoiTuong(btnXoaLoaiSanPham, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub
    Private Sub ctrlThemSuaXoaSanPham_Moi_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnCapNhatLoaiSanPham_Click(Nothing, Nothing)
        With CtrlDGVLoaiSanPham1
            .colMaLoaiSanPham.Visible = True
            .STT.Visible = False
            .MoTa.Visible = False
            .Chon.Visible = True
            .TenLoaiSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

    End Sub

#Region "Loại Sản Phẩm"
    Private lst As IQueryable(Of tbLoaiSanPham)
    Private ChonTatCa As Boolean

    Private Sub btnChonTatCa_Click(sender As Object, e As EventArgs) Handles btnChonTatCa.Click
        ChonTatCa = Not ChonTatCa
        For Each itm In lst.ToList
            itm.Chon = ChonTatCa
        Next
        CtrlDGVLoaiSanPham1.bsLoaiSanPham.EndEdit()
        CtrlDGVLoaiSanPham1.bsLoaiSanPham.ResetBindings(True)
        CtrlDGVLoaiSanPham1.dgvLoaiSanPham.Refresh()

        If ChonTatCa Then
            btnChonTatCa.Image = My.Resources.unchecked
            btnChonTatCa.Text = "Bỏ chọn tất cả"
        Else
            btnChonTatCa.Image = My.Resources.Checked
            btnChonTatCa.Text = "Chọn tất cả"
        End If
    End Sub

    Private Sub TimKiemLoaiSanPham()
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTimKiemLoai.Text.Trim).ToLower()
        If key = "" Then
            CapNhatLoaiSanPham()
        Else
            lst = From itm In dt.tbLoaiSanPhams
                  Where dt.f_nosymbol(itm.TenLoaiSanPham).ToLower.Contains(key) Or itm.MaLoaiSanPham.ToLower.Contains(key)
                  Select itm Order By itm.MaLoaiSanPham
            CtrlDGVLoaiSanPham1.bsLoaiSanPham.DataSource = lst
        End If

    End Sub
    Private Sub txtTimKiemLoai_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimKiemLoai.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimKiemLoaiSanPham()
        End If
    End Sub
    Private Sub CapNhatLoaiSanPham()
        lst = From itm In dt.tbLoaiSanPhams
              Select itm Order By itm.MaLoaiSanPham
        CtrlDGVLoaiSanPham1.bsLoaiSanPham.DataSource = lst
    End Sub

    Private Sub btnCapNhatLoaiSanPham_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoaiSanPham.Click
        CapNhatLoaiSanPham()
    End Sub

    Private Sub btnThemLoaiSanPham_Click(sender As Object, e As EventArgs) Handles btnThemLoaiSanPham.Click
        Dim frm As New frmThemLoaiSanPham
        AddHandler frm.ThemThanhCongLoaiSanPham, AddressOf CapNhatLoaiSanPham
        frm.ShowDialog()
    End Sub

    Private Sub btnSuaLoaiSanPham_Click(sender As Object, e As EventArgs) Handles btnSuaLoaiSanPham.Click
        If CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current IsNot Nothing Then
            Dim frm As New frmSuaLoaiSanPham
            frm.MaLoaiBanDau = CType(CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current, tbLoaiSanPham).MaLoaiSanPham
            frm.LoaiSanPham = CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current
            AddHandler frm.SuaThanhCongLoaiSanPham, AddressOf CapNhatLoaiSanPham
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnXoaLoaiSanPham_Click(sender As Object, e As EventArgs) Handles btnXoaLoaiSanPham.Click
        If CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current Is Nothing Then Exit Sub
        Dim LoaiSanPham As tbLoaiSanPham = CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xoá loại sản phẩm " + _
                                LoaiSanPham.TenLoaiSanPham + "?" + _
                                vbNewLine + "Mọi dữ liệu liên quan sẽ bị xoá theo?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                            = DialogResult.Yes Then

            If LoaiSanPham.tbSanPhams.Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xóa loại sản phẩm này. Vui lòng xóa sản phẩm thuộc loại trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            dt.tbLoaiSanPhams.DeleteOnSubmit(LoaiSanPham)
            Try
                dt.SubmitChanges()
                btnCapNhatLoaiSanPham_Click(Nothing, Nothing)
            Catch ex As Exception
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không xoá được loại sản phẩm!" + vbNewLine + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                undoChange()
                CapNhatLoaiSanPham()
            End Try
        End If
    End Sub

    Private Sub CtrlDGVLoaiSanPham_LoaiSanPhamThayDoi() Handles CtrlDGVLoaiSanPham1.LoaiSanPhamThayDoi
        If CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current Is Nothing Then
            rlsSanPham = (From itm In dt.vwSanPhams
                          Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham)
        End If
        Dim LoaiSanPham As tbLoaiSanPham = CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current

        Dim key As String = mdlGlobals.BoDauTiengViet(txtTimKiemSanPham.Text.Trim.ToLower)
        Dim lstID = From itm In CtrlDGVLoaiSanPham1.bsLoaiSanPham.List
                    Where itm.Chon = True
                    Select itm.id
        If lstID.Count = 0 Then
            rlsSanPham = (From itm In dt.vwSanPhams
                          Where LoaiSanPham.id = itm.idLoaiSanPham
                          Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham)
        Else
            rlsSanPham = (From itm In dt.vwSanPhams
                          Where lstID.Contains(itm.idLoaiSanPham)
                          Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham)
        End If

        CtrlDGVSanPham1.rlsKetQua = rlsSanPham
        CtrlDGVSanPham1.PhanTrangSauKhiTimKiem(True)
        CtrlDGVSanPham1.ToMauCanhBaoTon()
    End Sub

    Private Sub txtTimKiemLoai_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiemLoai.TextChanged
        If txtTimKiemLoai.Text.Trim = "" Then
            CapNhatLoaiSanPham()
        End If
    End Sub
#End Region

#Region "Sản Phẩm"
    Private Sub CapNhatSanPham()
        If CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current Is Nothing Then Exit Sub
        Dim rls As IQueryable(Of vwSanPham)
        Dim LoaiSanPham As tbLoaiSanPham = CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current
        Dim rlsLoai = (From itm In lst.ToList
                       Where itm.Chon = True
                       Select itm.id).ToList
        If LoaiSanPham Is Nothing Then
            CtrlDGVSanPham1.bsSanPham.DataSource = Nothing
            rls = From itm In dt.vwSanPhams
        Else
            If rlsLoai.Count > 0 Then
                rls = (From itm In dt.vwSanPhams
                       Where rlsLoai.Contains(itm.idLoaiSanPham)
                       Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham)
            Else
                rls = (From itm In dt.vwSanPhams
                       Where itm.idLoaiSanPham = LoaiSanPham.id
                       Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham)
            End If
        End If
            CtrlDGVSanPham1.rlsKetQua = From itm In rls
        CtrlDGVSanPham1.PhanTrangSauKhiTimKiem(False)
        CtrlDGVSanPham1.ToMauCanhBaoTon()
    End Sub

    Private Sub btnCapNhatSanPham_Click(sender As Object, e As EventArgs) Handles btnCapNhatSanPham.Click
        CapNhatSanPham()
    End Sub

    Private Sub txtTimKiemSanPham_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimKiemSanPham.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLoaiTimKiemSanPham_ButtonClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtTimKiemSanPham_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiemSanPham.TextChanged
        If txtTimKiemSanPham.Text = "" Then
            btnLoaiTimKiemSanPham_ButtonClick(Nothing, Nothing)
        End If
    End Sub

    Dim rlsSanPham As IQueryable(Of vwSanPham)
    Private Sub btnLoaiTimKiemSanPham_ButtonClick(sender As Object, e As EventArgs) Handles btnLoaiTimKiemSanPham.ButtonClick
        If CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current Is Nothing Then Exit Sub
        Dim LoaiSanPham As tbLoaiSanPham = CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current

        Dim key As String = mdlGlobals.BoDauTiengViet(txtTimKiemSanPham.Text.Trim.ToLower)

        rlsSanPham = (From itm In dt.vwSanPhams
                      Where (itm.TenSanPhamString.Contains(key)) Or (itm.MaSanPhamString.Contains(key)) Or itm.MaVachSanPham.Contains(key)
                      Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham)

        CtrlDGVSanPham1.bsSanPham.DataSource = rlsSanPham
        CtrlDGVSanPham1.ToMauCanhBaoTon()
    End Sub

    Public Sub btnThemSanPham_Click(sender As Object, e As EventArgs) Handles btnThemSanPham.Click
        Dim frm As New frmThemSanPham
        frm.LoaiSanPham = CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current
        AddHandler frm.ThemSanPhamThanhCong, AddressOf CapNhatSanPham
        frm.ShowDialog()
    End Sub

    Public Sub btnSuaSanPham_Click(sender As Object, e As EventArgs) Handles btnSuaSanPham.Click
        If CtrlDGVSanPham1.bsSanPham.Current IsNot Nothing Then
            Dim frm As New frmSuaSanPham
            frm.MaSanPhamBanDau = CType(CtrlDGVSanPham1.bsSanPham.Current, vwSanPham).MaSanPham
            frm.MaVachSanPhamBanDau = CType(CtrlDGVSanPham1.bsSanPham.Current, vwSanPham).MaVachSanPham
            Dim vSanPham As vwSanPham = CtrlDGVSanPham1.bsSanPham.Current
            frm.SanPham = dt.tbSanPhams.First(Function(s) s.id = vSanPham.id)
            AddHandler frm.SuaSanPhamThanhCong, AddressOf CapNhatSanPham
            frm.ShowDialog()
        End If
    End Sub

    Public Sub btnXoaSanPham_Click(sender As Object, e As EventArgs) Handles btnXoaSanPham.Click
        If CtrlDGVSanPham1.bsSanPham.Current IsNot Nothing Then
            Dim vSanPham As vwSanPham = CtrlDGVSanPham1.bsSanPham.Current
            Dim SanPham = dt.tbSanPhams.First(Function(s) s.id = vSanPham.id)
            If SanPham.tbChiTietHoaDons.Count > 0 Or SanPham.tbChiTietPhieuNhaps.Count > 0 Or SanPham.tbChiTietPhieuXuats.Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xóa sản phẩm đã phát sinh dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa sản phẩm " + SanPham.TenSanPham + "?",
                                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                                                   = MsgBoxResult.Yes Then
                Dim newLichSuCongViec = New tbLichSuCongViec
                With newLichSuCongViec
                    .idNhanvien = loginNhanVien.id
                    .NgayThayDoi = Now
                    .NoiDung = "Xóa với mã sản phẩm cũ " + SanPham.MaSanPham
                    .NoiDungString = BoDauTiengViet(.NoiDung)
                End With
                dt.tbSanPhams.DeleteOnSubmit(SanPham)
                Try
                    dt.SubmitChanges()
                    CapNhatSanPham()
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không xóa được sản phẩm!" + vbNewLine + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CapNhatSanPham()
                End Try

            End If
        End If
    End Sub

    'Private Sub btnInMaVachSanPham_Click(sender As Object, e As EventArgs) Handles btnInMaVachSanPham.Click
    '    Dim frm As New frmInMaVachNhanh
    '    frm.temp = True
    '    frm.bsSP = CtrlDGVSanPham1.bsSanPham
    '    frm.Show()
    'End Sub

    Private Sub btnNhapSanPhamTuExcel_Click(sender As Object, e As EventArgs) 
        frmNhapSanPhamExcel.Show()
        frmNhapSanPhamExcel.BringToFront()
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        undoChange()
        CapNhatSanPham()
    End Sub

    Private Sub HủyTìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HủyTìmKiếmToolStripMenuItem.Click
        txtTimKiemSanPham.Text = ""
    End Sub

    Private Sub CtrlDGVSanPham1_InDanhSachSanPham() Handles CtrlDGVSanPham1.InDanhSachSanPham
        Dim rlsLoai = From itm In lst.ToList
                  Where itm.Chon = True
                  Select itm.id
        Dim rls
        If rlsLoai.Count > 0 Then
            rls = (From itm In dt.vwSanPhams
                   Where rlsLoai.Contains(itm.idLoaiSanPham)
                      Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham)
        Else
            rls = (From itm In dt.vwSanPhams
                      Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham)
        End If

        Dim frm As New frmInDanhSach
        frm.Text = "DANH SÁCH SẢN PHẨM"
        frm.dsName = "dsDanhSachSanPham"
        frm.rptName = ".\Report\SanPham\rptDanhSachSanPham.rdlc"
        frm._bs.DataSource = rls
        frm.ShowDialog()
    End Sub

    Private Sub btnChiTietNhapXuat_Click(sender As Object, e As EventArgs) Handles btnChiTietNhapXuat.Click

    End Sub

    Private Sub CtrlDGVSanPham1_InDanhSachSanPham(InKemGia As Boolean) Handles CtrlDGVSanPham1.InDanhSachSanPham

    End Sub

    Private Sub CtrlDGVSanPham1_ChonSanPham(nl As tbSanPham) Handles CtrlDGVSanPham1.ChonSanPham
        btnSuaSanPham_Click(Nothing, Nothing)
    End Sub

    Private Sub btnTinhToanTonKho_Click(sender As Object, e As EventArgs) Handles btnTinhToanTonKho.Click
        CtrlDGVSanPham1.TinhToanTonkho()
        CapNhatSanPham()
    End Sub

    Private Sub CKNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CKNhậpToolStripMenuItem.Click
        If CtrlDGVSanPham1.bsSanPham.Current Is Nothing Then Exit Sub
        Dim idLoaiSanPham As Integer = CtrlDGVSanPham1.bsSanPham.Current.idLoaiSanPham
        Dim LoaiSanPham = dt.tbLoaiSanPhams.Single(Function(s) s.id = idLoaiSanPham)
        Dim frm As New frmChinhSuaHangLoatChiecKhau
        frm.LoaiSanPham = LoaiSanPham
        frm.Nhap = True
        frm.nudChiecKhau.Value = CtrlDGVSanPham1.bsSanPham.Current.PhanTramNhap
        If frm.ShowDialog() = DialogResult.OK Then
            CapNhatSanPham()
        End If
    End Sub

    Private Sub CKXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CKXuấtToolStripMenuItem.Click
        If CtrlDGVSanPham1.bsSanPham.Current Is Nothing Then Exit Sub
        Dim idLoaiSanPham As Integer = CtrlDGVSanPham1.bsSanPham.Current.idLoaiSanPham
        Dim LoaiSanPham = dt.tbLoaiSanPhams.Single(Function(s) s.id = idLoaiSanPham)
        Dim frm As New frmChinhSuaHangLoatChiecKhau
        frm.LoaiSanPham = LoaiSanPham
        frm.Nhap = False
        frm.nudChiecKhau.Value = CtrlDGVSanPham1.bsSanPham.Current.PhanTramBan
        If frm.ShowDialog() = DialogResult.OK Then
            CapNhatSanPham()
        End If
    End Sub
#End Region

End Class
