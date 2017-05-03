Imports System.Xml

Public Class ctrlThemSuaXoaKhachHang
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
                Case "btnThemKhachHang"
                    PhanQuyenLenDoiTuong(btnThem, qc1.HinhThuc, TrangThai)
                Case "btnSuaKhachHang"
                    PhanQuyenLenDoiTuong(btnSua, qc1.HinhThuc, TrangThai)
                Case "btnXoaKhachHang"
                    PhanQuyenLenDoiTuong(btnXoa, qc1.HinhThuc, TrangThai)

                Case "btnThemNhomKhachHang"
                    PhanQuyenLenDoiTuong(btnThemNhomKhachHang, qc1.HinhThuc, TrangThai)
                Case "btnSuaNhomKhachHang"
                    PhanQuyenLenDoiTuong(btnSuaNhomKhachHang, qc1.HinhThuc, TrangThai)
                Case "btnXoaNhomKhachHang"
                    PhanQuyenLenDoiTuong(btnXoaNhomKhachHang, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub

    Private Sub ctrlThemSuaXoaKhachHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbSoDong.SelectedIndex = 1
        CapNhatKhachHang()
        CapNhatNhomKhachHang()
    End Sub

#Region "KHÁCH HÀNG"
    Public Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemKhachHang
        frm.NhomKhachHang = bsNhomKhachHang.Current
        AddHandler frm.ThemKhachHangThanhCong, AddressOf CapNhatKhachHang
        frm.ShowDialog()
    End Sub

    Public Sub CapNhatKhachHang()
        CtrlDGVKhachHang1.gridControl.DataSource = From kh In dt.vwKhachHangs
                                                   Order By kh.TenKhachHang Select kh

        CtrlDGVKhachHang1.gridViewData.RefreshData()
    End Sub

    Private Sub btnCapNhat_Click() Handles btnCapNhat.Click
        CapNhatKhachHang()
    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        If txtTimKiem.Text = "" Then
            CapNhatKhachHang()
        End If
    End Sub

    Dim rlsKhachHang As IQueryable(Of vwKhachHang)
    Private Sub btnLoaiTimKiem_ButtonClick(sender As Object, e As EventArgs) Handles btnLoaiTimKiem.ButtonClick
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTimKiem.Text.Trim.ToLower)
        Dim SoDongTake As Integer
        If cmbSoDong.Text = "<tất cả>" Then
            SoDongTake = dt.tbKhachHangs.Count
        Else
            Try
                Integer.TryParse(cmbSoDong.Text.Replace("dòng", "").Trim, SoDongTake)
            Catch
                SoDongTake = 100
            End Try
        End If
        rlsKhachHang = (From kh In dt.vwKhachHangs
                        Where (kh.TenKhachHangString.Contains(key)) Or (dt.f_nosymbol(kh.MaKhachHang).Contains(key) Or kh.SoDienThoai.Contains(key) Or kh.MaSoThue.Contains(key) Or kh.DiaChi.Contains(key))
                        Order By kh.TenKhachHang
                        Select kh).Take(SoDongTake)

        CtrlDGVKhachHang1.gridControl.DataSource = rlsKhachHang
        CtrlDGVKhachHang1.gridViewData.RefreshData()
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        undoChange()
        CapNhatKhachHang()
    End Sub

    Public Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If CtrlDGVKhachHang1.gridViewData.FocusedRowHandle >= 0 Then
            Dim vKhachHang As vwKhachHang = CtrlDGVKhachHang1.gridViewData.GetRow(CtrlDGVKhachHang1.gridViewData.FocusedRowHandle)
            Dim KhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa khách hàng " + KhachHang.TenKhachHang + "?",
                                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                                                   = MsgBoxResult.Yes Then
                If KhachHang.tbHoaDons.Count > 0 Or KhachHang.tbPhieuNhaps.Count > 0 Or KhachHang.tbThuNoKhachHangs.Count > 0 Then
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xóa khách hàng khi đã phát sinh dữ liệu liên quan!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Dim newLichSuCongViec = New tbLichSuCongViec
                With newLichSuCongViec
                    .idNhanvien = loginNhanVien.id
                    .NgayThayDoi = Now
                    .NoiDung = "Xóa với mã khách hàng " + KhachHang.MaKhachHang
                    .NoiDungString = BoDauTiengViet(.NoiDung)
                End With
                dt.tbLichSuCongViecs.InsertOnSubmit(newLichSuCongViec)
                dt.tbChiTietLienHes.DeleteAllOnSubmit(dt.tbChiTietLienHes.Where(Function(s) s.idKhachHang = KhachHang.id))
                dt.tbNganHangUyNhiemChis.DeleteAllOnSubmit(dt.tbNganHangUyNhiemChis.Where(Function(s) s.idKhachHang = KhachHang.id))
                dt.tbKhachHangs.DeleteOnSubmit(KhachHang)
                Try
                    dt.SubmitChanges()
                    CapNhatKhachHang()
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không xóa được khách hàng!" + vbNewLine + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

    Private Sub txtTimKiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimKiem.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLoaiTimKiem_ButtonClick(Nothing, Nothing)
        End If
    End Sub

    Public Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If CtrlDGVKhachHang1.gridViewData.FocusedRowHandle >= 0 Then
            Dim vKhachHang As vwKhachHang = CtrlDGVKhachHang1.gridViewData.GetRow(CtrlDGVKhachHang1.gridViewData.FocusedRowHandle)

            Dim frm As New frmSuaKhachHang
            Dim KhachHang = dt.tbKhachHangs.Single(Function(s) s.id = vKhachHang.id)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, KhachHang)
            frm.MaKhachHangBanDau = vKhachHang.MaKhachHang
            frm.TenKhachHangBanDau = vKhachHang.TenKhachHang
            frm.TenRutGonBanDau = vKhachHang.TenRutGon
            frm.MaSoThueBanDau = vKhachHang.MaSoThue
            frm.SoDuDauKyBanDau = vKhachHang.CongNoDauKy
            frm.KhachHang = KhachHang
            AddHandler frm.SuaKhachHangThanhCong, AddressOf CapNhatKhachHang
            frm.ShowDialog()
        End If
    End Sub

    Private Sub HủyTìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HủyTìmKiếmToolStripMenuItem.Click
        txtTimKiem.Text = ""
    End Sub

    Private Sub btnNhapSanPhamTuExcel_Click(sender As Object, e As EventArgs) Handles btnNhapSanPhamTuExcel.Click
        frmNhapKhachHangExcel.Show()
        frmNhapKhachHangExcel.BringToFront()
    End Sub

    Private Sub CtrlDGVKhachHang_InDanhSachKhachHang() Handles CtrlDGVKhachHang1.InDanhSachKhachHang
        Dim frm As New frmInDanhSach
        frm.Text = "DANH SÁCH KHÁCH HÀNG"
        frm.rptName = ".\Report\KhachHang\rptDanhSachKhachHang.rdlc"
        frm.dsName = "dsDanhSachKhachHang"
        frm._bs.DataSource = CtrlDGVKhachHang1.gridControl.DataSource
        frm.ShowDialog()
    End Sub

    Private Sub btnSetKhachHangMacDinh_Click(sender As Object, e As EventArgs) Handles btnSetKhachHangMacDinh.Click
        If CtrlDGVKhachHang1.gridViewData.FocusedRowHandle >= 0 Then
            Dim vKhachHang As vwKhachHang = CtrlDGVKhachHang1.gridViewData.GetRow(CtrlDGVKhachHang1.gridViewData.FocusedRowHandle)

            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn chọn " + vKhachHang.TenKhachHang + " làm khách hàng mặc định?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                My.Settings.idKhachHangMacDinh = vKhachHang.id
                Dim docXML As XmlDocument = New XmlDataDocument
                docXML.Load(Application.StartupPath + "\" + Application.ProductName + ".exe.config")
                For Each itm As XmlNode In docXML.GetElementsByTagName("setting")
                    If itm.Attributes("name").Value = "idKhachHangMacDinh" Then
                        itm.FirstChild.InnerXml = My.Settings.idKhachHangMacDinh
                    End If
                Next
                docXML.Save(".\" + Application.ProductName + ".exe.config")
            End If
        End If
    End Sub
#End Region
#Region "NHÓM KHÁCH HÀNG"
    Private Sub CapNhatNhomKhachHang()
        bsNhomKhachHang.DataSource = From itm In dt.tbNhomKhachHangs
                                     Order By itm.TenNhomKhachHang
    End Sub

    Private Sub btnThemNhomKhachHang_Click(sender As Object, e As EventArgs) Handles btnThemNhomKhachHang.Click
        Dim frm As New frmThemNhomKhachHang
        AddHandler frm.ThemNhomKhachHangThanhCong, AddressOf CapNhatNhomKhachHang
        frm.ShowDialog()
    End Sub

    Private Sub btnSuaNhomKhachHang_Click(sender As Object, e As EventArgs) Handles btnSuaNhomKhachHang.Click
        If bsNhomKhachHang.Current IsNot Nothing Then
            Dim frm As New frmSuaNhomKhachHang
            frm.NhomKhachHang = bsNhomKhachHang.Current
            If frm.ShowDialog = DialogResult.OK Then
                CapNhatNhomKhachHang()
            End If
        End If
    End Sub

    Private Sub btnXoaNhomKhachHang_Click(sender As Object, e As EventArgs) Handles btnXoaNhomKhachHang.Click
        If bsNhomKhachHang.Current IsNot Nothing Then
            Dim NhomKhachHang As tbNhomKhachHang = bsNhomKhachHang.Current
            If NhomKhachHang.tbKhachHangs.Count > 0 Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xóa nhóm khách hàng khi đã phát sinh dữ liệu liên quan!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa nhóm khách hàng " + NhomKhachHang.TenNhomKhachHang + "?", _
                                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                                                   = MsgBoxResult.Yes Then

                dt.tbNhomKhachHangs.DeleteOnSubmit(NhomKhachHang)
                Try
                    dt.SubmitChanges()
                    CapNhatNhomKhachHang()
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không xóa được nhóm khách hàng!" + vbNewLine + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnCapNhatNhom_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhom.Click
        CapNhatNhomKhachHang()
    End Sub

    Private Sub bsNhomKhachHang_CurrentChanged(sender As Object, e As EventArgs) Handles bsNhomKhachHang.CurrentChanged
        If bsNhomKhachHang.Current IsNot Nothing Then
            CapNhatKhachHang()
        End If
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvNhomKhachHang.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub bsNhomKhachHang_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsNhomKhachHang.ListChanged
        lblSoNhom.Text = bsNhomKhachHang.Count.ToString + " nhóm"
    End Sub
    Private Sub CtrlDGVKhachHang1_DoubleClick(sender As Object, e As EventArgs) Handles CtrlDGVKhachHang1.DoubleClick

    End Sub
    Private Sub CtrlDGVKhachHang1_ChonKhachHang(nl As tbKhachHang) Handles CtrlDGVKhachHang1.ChonKhachHang
        Dim frm As New frmXemThongTinKhachHang
        If CtrlDGVKhachHang1.gridViewData.FocusedRowHandle >= 0 Then
            Dim vKhachHang As vwKhachHang = CtrlDGVKhachHang1.gridViewData.GetRow(CtrlDGVKhachHang1.gridViewData.FocusedRowHandle)
            Dim KhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
            frm.MaKhachHangBanDau = vKhachHang.MaKhachHang
            frm.KhachHang = KhachHang
            frm.ShowDialog()
        End If
    End Sub

#End Region
End Class
