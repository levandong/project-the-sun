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
        ctrl.ToolStrip1.Visible = False
        Me.Controls.Add(ctrl)
    End Sub
    Sub CapNhatTrangThai()
        cmbTrangThai.Items.Add("<Tất cả>")
        cmbTrangThai.Items.Add("Đang báo giá")
        cmbTrangThai.Items.Add("Đã chuyển đơn đặt hàng")
        'cmbTrangThai.SelectedItem = 1
    End Sub

    Private Sub dgvBaoGia_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STTcol.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
    Private Sub bsBaoGia_CurrentChanged(sender As Object, e As EventArgs) Handles bsBaoGia.CurrentChanged
        Dim BaoGia As vwBaoGia = bsBaoGia.Current
        If BaoGia Is Nothing Then
            Exit Sub
        End If
        Dim rlsChitietBaoGia = From itm In dt.vwChiTietBaoGias
                               Where itm.idBaoGia = BaoGia.id
        bsChiTietDatHang.DataSource = rlsChitietBaoGia
    End Sub

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
        PhanTrangSauKhiTimKiem()
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
        Dim ctrlBaoGia As New ctrlSuaBangBaoGia
        Dim BaoGia As vwBaoGia = bsBaoGia.Current
        ctrlBaoGia.SuaPhieuBaoGia(dt.tbBaoGias.First(Function(s) s.id = BaoGia.id))
        ctrlBaoGia.BaoGia = dt.tbBaoGias.First(Function(s) s.id = BaoGia.id)
        RaiseEvent ThemTabpageMoi("BG/" + bsBaoGia.Current.MaPhieu.ToString(), bsBaoGia.Current.MaPhieu.ToString(), ctrlBaoGia)
    End Sub

    Private Sub ChuyểnSangPhiếuBáoGiáToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim BaoGia As vwBaoGia = bsBaoGia.Current
        Dim frm = New frmKhachHangDatHang
        frm.BaoGia = dt.tbBaoGias.First(Function(s) s.id = BaoGia.id)
        If BaoGia.DaChuyenPhieuDatHang = 1 Then
            If XacNhanYesNo("Mẫu báo giá này đã đc chuyển thành đơn đặt hàng" + vbNewLine + " Bạn vẫn muốn tiếp tục chuyển?") <> MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If
        frm.TenKhachHangDatHang = If(BaoGia.isNhapHang, "ĐẶT HÀNG NHÀ CUNG CẤP", "KHÁCH HÀNG ĐẶT HÀNG")
        AddHandler frm.BaoGiaThanhCong, AddressOf BaoGiaThanhCong
        frm.Show()
    End Sub

    Sub BaoGiaThanhCong()
        Dim BaoGia As vwBaoGia = bsBaoGia.Current
        Dim iBaoGia As tbBaoGia = dt.tbBaoGias.First(Function(s) s.id = BaoGia.id)
        dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, iBaoGia)
        iBaoGia.CapDo = 2
        Dim TrangThai As tbTrangThai = dt.tbTrangThais.First(Function(s) s.Loai = 2)
        iBaoGia.idTrangThai = TrangThai.id
        dt.SubmitChanges()
        btnTimKiem_Click(Nothing, Nothing)
    End Sub

    Private Sub ĐangBáoGiáToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim idBaoGia As Integer = bsBaoGia.Current.id
        Dim BaoGia As tbBaoGia = (From s In dt.tbBaoGias Where s.id = idBaoGia).FirstOrDefault
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
        If bsBaoGia.Current Is Nothing Then Exit Sub
        Dim vBaoGia As vwBaoGia = bsBaoGia.Current
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
    Private Sub dgvMain_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMain.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Dim rowSelected As Integer = e.RowIndex
            If (e.RowIndex <> -1) Then
                Me.dgvMain.ClearSelection()
                Me.dgvMain.Rows(rowSelected).Selected = True
                bsBaoGia.Position = e.RowIndex
            End If
        End If
    End Sub

    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        SửaPhiếuToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Dim rlsKetQua As IQueryable(Of vwBaoGia)

#Region "Phân Trang"
    Dim TrangHienTai As Integer = 0
    Dim SoDongTrenMotTrang As Integer = 30
    Dim TongSoLuong As Integer
    Dim SoTrang As Integer

    Private Sub CapNhapTrang()
        Dim Tu = TrangHienTai * SoDongTrenMotTrang
        Dim Den = (TrangHienTai + 1) * SoDongTrenMotTrang
        If Den > TongSoLuong Then
            Den = TongSoLuong
        End If
        lblSoLuong.Text = "[" + (Tu + 1).ToString("n0") + ".." + Den.ToString("n0") + "]"
        txtSoTrang.Text = (TrangHienTai + 1).ToString()
    End Sub
    Private Sub PhanTrangLucLoad()
        If My.Settings.SoDongKhachHangTrenMotTrang < 1 Then
            My.Settings.SoDongKhachHangTrenMotTrang = 30
            My.Settings.Save()
        End If
        txtSoDongTrenMotTrang.Text = My.Settings.SoDongKhachHangTrenMotTrang
        SoDongTrenMotTrang = My.Settings.SoDongKhachHangTrenMotTrang
        txtSoTrang.Text = 0
    End Sub
    Private Sub PhanTrangSauKhiTimKiem()
        If rlsKetQua IsNot Nothing Then
            TrangHienTai = 0
            TongSoLuong = rlsKetQua.Count
            SoTrang = Math.Ceiling(TongSoLuong / SoDongTrenMotTrang)
            lblTongSoTrang.Text = SoTrang.ToString("n0")
            lblTongSoTrang2.Text = SoTrang.ToString("n0")
            lblTongSoLuong.Text = TongSoLuong.ToString("n0")
            bsBaoGia.DataSource = rlsKetQua.Skip(0).Take(SoDongTrenMotTrang)
            For i As Integer = 0 To dgvMain.RowCount - 1
                If dgvMain.Rows(i).DataBoundItem.isHuy = True Then
                    dgvMain.Rows(i).DefaultCellStyle.Font = New Font(dgvMain.DefaultCellStyle.Font, FontStyle.Strikeout)
                End If
            Next
            CapNhapTrang()
        End If
    End Sub
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STTcol.Index Then
            e.Value = e.RowIndex + 1 + TrangHienTai * SoDongTrenMotTrang
        End If
    End Sub
    Private Sub btnQuaTrai1_Click(sender As Object, e As EventArgs) Handles btnQuaTrai1.Click
        If rlsKetQua IsNot Nothing Then
            If TrangHienTai > 0 Then
                TrangHienTai -= 1
                bsBaoGia.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
                CapNhapTrang()
            End If
        End If
    End Sub

    Private Sub btnQuaTraiTatCa_Click(sender As Object, e As EventArgs) Handles btnQuaTraiTatCa.Click
        If rlsKetQua IsNot Nothing Then
            TrangHienTai = 0
            bsBaoGia.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
            CapNhapTrang()
        End If
    End Sub

    Private Sub btnQuaPhai1_Click(sender As Object, e As EventArgs) Handles btnQuaPhai1.Click
        If rlsKetQua IsNot Nothing Then
            If TrangHienTai < SoTrang - 1 Then
                TrangHienTai += 1
                bsBaoGia.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
                CapNhapTrang()
            End If
        End If
    End Sub

    Private Sub txtSoTrang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoTrang.KeyPress
        If rlsKetQua IsNot Nothing Then
            If e.KeyChar = "\r" Then
                Try
                    If TrangHienTai < 1 Then
                        TrangHienTai = 0
                    End If
                    bsBaoGia.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
                    txtSoTrang.SelectAll()
                    CapNhapTrang()
                Catch ex As Exception
                    ThongBaoError(ex.Message)
                End Try
            ElseIf Asc(e.KeyChar) <> 8 Then
                If Char.IsNumber(e.KeyChar) = False Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub


#End Region
    Dim ctrl As New ctrlDGVKhachHang
    Private Sub txtKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtKhachHang.TextChanged
        Dim key = BoDauTiengViet(txtKhachHang.Text.Trim)
        ctrl.BringToFront()
        If key <> "" Then
            ctrl.Visible = True
            ctrl.bsKhachHang.DataSource = From itm In dt.vwKhachHangs
                                          Where itm.MaKhachHang.Contains(key) Or itm.TenKhachHangString.Contains(key) Or itm.MaSoThue.StartsWith(key)
            If ctrl.bsKhachHang.Count = 0 Then
                ctrl.Visible = False
            End If
            ctrl.Size = New Size(500, 380)
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
            Dim vKhachHang As vwKhachHang = ctrl.bsKhachHang.Current
            If vKhachHang Is Nothing Then
                Exit Sub
            End If
            Dim Khachhang As tbKhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
            ChonKhachHang(Khachhang)
            ctrl.Visible = False
        ElseIf e.KeyCode = Keys.Down Then
            If ctrl.dgvMain.CurrentCell.RowIndex = ctrl.dgvMain.RowCount - 1 Then
                ctrl.dgvMain.CurrentCell = ctrl.dgvMain.Rows(0).Cells(ctrl.dgvMain.CurrentCell.ColumnIndex)
            Else
                ctrl.dgvMain.CurrentCell = ctrl.dgvMain.Rows(ctrl.dgvMain.CurrentCell.RowIndex + 1).Cells(ctrl.dgvMain.CurrentCell.ColumnIndex)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If ctrl.dgvMain.CurrentCell.RowIndex = 0 Then
                ctrl.dgvMain.CurrentCell = ctrl.dgvMain.Rows(ctrl.dgvMain.RowCount - 1).Cells(ctrl.dgvMain.CurrentCell.ColumnIndex)
            Else
                ctrl.dgvMain.CurrentCell = ctrl.dgvMain.Rows(ctrl.dgvMain.CurrentCell.RowIndex - 1).Cells(ctrl.dgvMain.CurrentCell.ColumnIndex)
            End If
        End If
    End Sub
    Private Sub txtKhachHang_Enter(sender As Object, e As EventArgs) Handles txtKhachHang.Enter
        CType(sender, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Text = ""
    End Sub

    Private Sub InPhiếuBáoGiáToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InPhiếuBáoGiáToolStripMenuItem.Click
        Dim vBaoGia As vwBaoGia = bsBaoGia.Current
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
        If bsBaoGia.Current IsNot Nothing Then
            Dim BG As vwBaoGia = bsBaoGia.Current
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
        If bsBaoGia.Current IsNot Nothing Then
            Dim BG As vwBaoGia = bsBaoGia.Current
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
End Class
