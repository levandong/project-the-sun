﻿
Public Class ctrlThongKeBaoGia
    Dim _isNhapHang As Boolean = False
    Property isNhapHang As Boolean
        Get
            Return _isNhapHang
        End Get
        Set(value As Boolean)
            _isNhapHang = value
            If _isNhapHang Then
                lblTieuDe.Text = "BÁO GIÁ ĐẾN"
            Else
                lblTieuDe.Text = "BÁO GIÁ ĐI"
                'btnThemTabPageMoi.Visible = False
            End If
        End Set
    End Property
    Private Sub ctrlThongKeBaoGiaMoi_Load(sender As Object, e As EventArgs) Handles Me.Load
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = New Date(Now.Date.AddDays(-30).Year, Now.Date.AddDays(-30).Month, Now.Date.AddDays(-30).Day)
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New Date(Now.Date.Year, Now.Date.Month, Now.Day, 23, 59, 59)
        CapNhatTrangThai()
        btnCapNhatNhanVien_Click(Nothing, Nothing)
        cmbTrangThai.SelectedIndex = 0
        btnTimKiem_Click(Nothing, Nothing)
        ''
        ctrl.Visible = False
        ctrl.Location = New Point(txtKhachHang.Location.X, txtKhachHang.Location.Y + txtKhachHang.Size.Height + ToolStrip1.Size.Height)

        Me.Controls.Add(ctrl)
    End Sub
    Sub CapNhatTrangThai()
        cmbTrangThai.Items.Add("<Tất cả>")
        cmbTrangThai.Items.Add("Đang báo giá")
        cmbTrangThai.Items.Add("Đã chuyển đơn đặt hàng")
        'cmbTrangThai.SelectedItem = 1
    End Sub

    Private Sub gridViewData_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridViewData.CustomDrawRowIndicator
        If (e.Info.IsRowIndicator) Then
            If e.RowHandle < 0 Then
                e.Info.DisplayText = ""
            Else
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
        End If
    End Sub
    Private Sub bsBaoGia_CurrentChanged(sender As Object, e As EventArgs)
        'Dim BaoGia As vwBaoGia = bsBaoGia.Current
        'If BaoGia Is Nothing Then
        '    Exit Sub
        'End If
        'Dim rlsChitietBaoGia = From itm In dt.vwChiTietBaoGias
        '                       Where itm.idBaoGia = BaoGia.id
        'bsChiTietDatHang.DataSource = rlsChitietBaoGia
    End Sub

    Dim rlsKetQua As IQueryable(Of vwBaoGia)
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim idKH As Integer = 0
        Dim idNV As Integer = 0
        Dim TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        Dim DenNgay = CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value

        If chkTheoNhanVien.Checked Then
            If cmbNhanVien.SelectedItem IsNot Nothing Then
                idNV = cmbNhanVien.SelectedItem.id
            Else
                ThongBaoError("Chưa chọn nhân viên")
                cmbNhanVien.Focus()
                Exit Sub
            End If
        End If
        If chkTheoKhachHang.Checked Then
            If txtKhachHang.Tag IsNot Nothing Then
                idKH = txtKhachHang.Tag.id
            Else
                ThongBaoError("Chưa chọn khách hàng")
                txtKhachHang.Focus()
                Exit Sub
            End If
        End If
        If cmbTrangThai.SelectedIndex <> 0 Then
            If cmbTrangThai.SelectedIndex = 1 Then
                rlsKetQua = From itm In dt.vwBaoGias
                            Where TuNgay.Date <= itm.NgayLap.Date And itm.NgayLap.Date <= DenNgay.Date
                            Where (Not chkTheoNhanVien.Checked) Or (itm.idNhanVien = idNV)
                            Where (Not chkTheoMaPhieu.Checked) Or (itm.MaPhieu.Contains(txtTheoMaPhieu.Text.Trim))
                            Where (Not chkTheoKhachHang.Checked) Or (itm.idKhachHang = idKH)
                            Where (Not chkTheoCongTrinh.Checked) Or (itm.GhiChu.Contains(txtCongTrinh.Text.Trim))
                            Where itm.isNhapHang = isNhapHang
                            Where itm.DaChuyenPhieuDatHang = 0
                            Select itm Order By itm.NgayLap Descending
            ElseIf cmbTrangThai.SelectedIndex = 2 Then
                rlsKetQua = From itm In dt.vwBaoGias
                            Where TuNgay.Date <= itm.NgayLap.Date And itm.NgayLap.Date <= DenNgay.Date
                            Where (Not chkTheoNhanVien.Checked) Or (itm.idNhanVien = idNV)
                            Where (Not chkTheoMaPhieu.Checked) Or (itm.MaPhieu.Contains(txtTheoMaPhieu.Text.Trim))
                            Where (Not chkTheoKhachHang.Checked) Or (itm.idKhachHang = idKH)
                            Where (Not chkTheoCongTrinh.Checked) Or (itm.GhiChu.Contains(txtCongTrinh.Text.Trim))
                            Where itm.isNhapHang = isNhapHang
                            Where itm.DaChuyenPhieuDatHang = 1
                            Select itm Order By itm.NgayLap Descending
            End If
        Else
            rlsKetQua = From itm In dt.vwBaoGias
                        Where TuNgay.Date <= itm.NgayLap.Date And itm.NgayLap.Date <= DenNgay.Date
                        Where (Not chkTheoNhanVien.Checked) Or (itm.idNhanVien = idNV)
                        Where (Not chkTheoMaPhieu.Checked) Or (itm.MaPhieu.Contains(txtTheoMaPhieu.Text.Trim))
                        Where (Not chkTheoCongTrinh.Checked) Or (itm.GhiChu.Contains(txtCongTrinh.Text.Trim))
                        Where (Not chkTheoKhachHang.Checked) Or (itm.idKhachHang = idKH)
                        Where itm.isNhapHang = isNhapHang
                        Select itm Order By itm.NgayLap Descending
        End If

        gridControl.DataSource = rlsKetQua
        gridViewData.RefreshData()
    End Sub

    Private Sub chkTheoNhanVien_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhanVien.CheckedChanged, chkTheoMaPhieu.CheckedChanged, chkTheoCongTrinh.CheckedChanged, chkTheoKhachHang.CheckedChanged
        cmbNhanVien.Enabled = chkTheoNhanVien.Checked
        txtTheoMaPhieu.Enabled = chkTheoMaPhieu.Checked
        txtCongTrinh.Enabled = chkTheoCongTrinh.Checked
        txtKhachHang.Enabled = chkTheoKhachHang.Checked
        btnTimKiem_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From itm In dt.tbNhanViens
    End Sub
    Event ThemTabpageMoi(TenHienThi As String, Ten As String, control As Control)
    Private Sub SửaPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SửaPhiếuToolStripMenuItem.Click
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vBaoGia As vwBaoGia = gridViewData.GetRow(gridViewData.FocusedRowHandle)

        Dim ctrlBaoGia As New ctrlSuaBangBaoGia
        ctrlBaoGia.SuaPhieuBaoGia(dt.tbBaoGias.First(Function(s) s.id = vBaoGia.id))
        ctrlBaoGia.BaoGia = dt.tbBaoGias.First(Function(s) s.id = vBaoGia.id)
        RaiseEvent ThemTabpageMoi("BG/" + vBaoGia.MaPhieu.ToString(), vBaoGia.MaPhieu.ToString(), ctrlBaoGia)
    End Sub

    Private Sub ChuyểnSangPhiếuBáoGiáToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vBaoGia As vwBaoGia = gridViewData.GetRow(gridViewData.FocusedRowHandle)

        Dim frm = New frmKhachHangDatHang
        frm.BaoGia = dt.tbBaoGias.First(Function(s) s.id = vBaoGia.id)
        If vBaoGia.DaChuyenPhieuDatHang = 1 Then
            If XacNhanYesNo("Mẫu báo giá này đã đc chuyển thành đơn đặt hàng" + vbNewLine + " Bạn vẫn muốn tiếp tục chuyển?") <> MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If
        frm.TenKhachHangDatHang = If(vBaoGia.isNhapHang, "ĐẶT HÀNG NHÀ CUNG CẤP", "KHÁCH HÀNG ĐẶT HÀNG")
        AddHandler frm.BaoGiaThanhCong, AddressOf BaoGiaThanhCong
        frm.Show()
    End Sub

    Sub BaoGiaThanhCong()
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vBaoGia As vwBaoGia = gridViewData.GetRow(gridViewData.FocusedRowHandle)

        Dim iBaoGia As tbBaoGia = dt.tbBaoGias.First(Function(s) s.id = vBaoGia.id)
        dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, iBaoGia)
        iBaoGia.CapDo = 2
        Dim TrangThai As tbTrangThai = dt.tbTrangThais.First(Function(s) s.Loai = 2)
        iBaoGia.idTrangThai = TrangThai.id
        dt.SubmitChanges()
        btnTimKiem_Click(Nothing, Nothing)
    End Sub

    Private Sub ĐangBáoGiáToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vBaoGia As vwBaoGia = gridViewData.GetRow(gridViewData.FocusedRowHandle)

        Dim BaoGia As tbBaoGia = (From s In dt.tbBaoGias Where s.id = vBaoGia.id).FirstOrDefault
        dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, BaoGia)
        Dim TrangThai As tbTrangThai = dt.tbTrangThais.First(Function(s) s.Loai = 1)
        BaoGia.tbTrangThai = TrangThai
        Try
            dt.SubmitChanges()
            pnlPhieuDatHang.Controls.Clear()
            btnTimKiem_Click(Nothing, Nothing)
        Catch ex As Exception
            ThongBao("Thất bại" + ex.ToString)
        End Try
    End Sub

    Private Sub HủyPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HủyPhiếuToolStripMenuItem.Click
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vBaoGia As vwBaoGia = gridViewData.GetRow(gridViewData.FocusedRowHandle)
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa bảng báo giá " + CType(vBaoGia, vwBaoGia).MaPhieu.ToString + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim BaoGia As tbBaoGia = dt.tbBaoGias.First(Function(s) s.id = vBaoGia.id)
            dt.tbBaoGias.DeleteOnSubmit(BaoGia)
            Try
                dt.SubmitChanges()
                btnTimKiem_Click(Nothing, Nothing)
            Catch ex As Exception
                undoChange()
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xóa bảng báo giá thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Dim ctrl As New ctrlDGVKhachHang
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
        txtKhachHang.Text = KhachHang.TenKhachHang
        txtKhachHang.Tag = KhachHang
        btnTimKiem.Focus()
        btnTimKiem_Click(Nothing, Nothing)
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
    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles txtKhachHang.Enter
        CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Text = ""
    End Sub

    Private Sub InPhiếuBáoGiáToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InPhiếuBáoGiáToolStripMenuItem.Click
        If gridViewData.FocusedRowHandle < 0 Then Exit Sub
        Dim vBaoGia As vwBaoGia = gridViewData.GetRow(gridViewData.FocusedRowHandle)

        TaoBaoGiaXuatExcel1(Application.StartupPath + "\UyNhiemChi\BaoGia1.xlsx", vBaoGia, True)
    End Sub

    Public Sub btnThemTabPageMoi_Click(sender As Object, e As EventArgs) Handles btnThemTabPageMoi.Click
        Dim BaoGia As New ctrlBangBaoGia
        BaoGia.isNhapHang = isNhapHang
        If isNhapHang Then
            RaiseEvent ThemTabpageMoi("BÁO GIÁ ĐẾN", "BG/" + Now.ToString("dd/MN/yy HH:ss"), BaoGia)
        Else
            RaiseEvent ThemTabpageMoi("BÁO GIÁ ĐI", "BG/" + Now.ToString("dd/MN/yy HH:ss"), BaoGia)
        End If
    End Sub

    Private Sub cmbTrangThai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTrangThai.SelectedIndexChanged
        btnTimKiem_Click(Nothing, Nothing)
    End Sub

    Private Sub btnHuyPhieu_Click(sender As Object, e As EventArgs) Handles btnHuyPhieu.Click
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim BG As vwBaoGia = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            Dim BaoGia = dt.tbBaoGias.First(Function(s) s.id = BG.id)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, BaoGia)
            If BaoGia.isHuy = True Then
                ' khôi phuc lai
                If frmMessageBox.Show("Bạn muốn khôi phục lại báo giá số " + BG.MaPhieu + "?", "Xác nhận") = DialogResult.No Then
                    Exit Sub
                End If

                BaoGia.isHuy = False
            Else
                ' Hủy hóa don
                If frmMessageBox.Show("Bạn muốn hủy giá giá số " + BG.MaPhieu + "?", "Xác nhận") = DialogResult.No Then
                    Exit Sub
                End If
                If dt.tbKhachHangDatHangs.FirstOrDefault(Function(s) s.idBaoGia = BG.id) IsNot Nothing Then
                    ThongBao("Không thể hủy phiếu khi đã chuyển thành phiếu đặt hàng")
                    Exit Sub
                End If
                BaoGia.isHuy = True
            End If
            Try
                dt.SubmitChanges()
                btnTimKiem_Click(Nothing, Nothing)
            Catch ex As Exception
                undoChange()
                ThongBaoErrorVoiException("Không hủy được báo giá!", ex)
            End Try
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim BG As vwBaoGia = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            Dim BaoGia = dt.tbBaoGias.First(Function(s) s.id = BG.id)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, BaoGia)
            If BaoGia.isHuy = True Then
                ' khôi phuc lai
                btnHuyPhieu.Text = "Khôi phục lại"
                btnHuyPhieu.Image = My.Resources.Undo16
            Else
                ' Hủy hóa don
                btnHuyPhieu.Text = "Hủy phiếu"
                btnHuyPhieu.Image = My.Resources.XoaTatCa16
            End If

        End If
    End Sub

    Private Sub gridControl_DoubleClick(sender As Object, e As EventArgs) Handles gridControl.DoubleClick
        SửaPhiếuToolStripMenuItem_Click(Nothing, Nothing)
    End Sub


    Private Sub XuấtExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtExcelToolStripMenuItem.Click
        If gridViewData.DataRowCount > 0 Then
            ExportExcelFromGridView(gridControl)
        End If
    End Sub
End Class
