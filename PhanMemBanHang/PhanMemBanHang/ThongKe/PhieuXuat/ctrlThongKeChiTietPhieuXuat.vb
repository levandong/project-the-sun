Public Class ctrlThongKeChiTietPhieuXuat
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
    Dim rls As List(Of vwChiTietPhieuXuat)
    Public Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From itm In dt.tbNhanViens Order By itm.TenDangNhap
    End Sub

    Dim TuNgay As DateTime
    Dim DenNgay As DateTime
    Dim TongTien As Decimal
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        DenNgay = CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value

        Dim idNV As Integer = 0
        If chkTheoNhanVien.Checked Then
            If cmbNhanVien.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhân viên cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbNhanVien.Focus()
                Exit Sub
            Else
                idNV = cmbNhanVien.SelectedItem.id
            End If
        End If

        Dim idLoaiPhieuXuat As Integer
        If chkTheoLoaiPhieuXuat.Checked Then
            If cmbTheoLoaiPhieuXuat.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn loại phiếu nhập cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTheoLoaiPhieuXuat.Focus()
                Exit Sub
            Else
                idLoaiPhieuXuat = cmbTheoLoaiPhieuXuat.SelectedItem.id
            End If
        End If
        Dim idNhaCungCap As Integer
        If chkTheoNhaCungCap.Checked Then
            If cmbTheoNhaCungCap.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhà cung cấp cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTheoNhaCungCap.Focus()
                Exit Sub
            Else
                idNhaCungCap = cmbTheoNhaCungCap.SelectedItem.id
            End If
        End If

        Dim idSanPham As Integer = 0
        If chkTheoSanPham.Checked Then
            If cmbSanPham.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn sản phẩm cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbSanPham.Focus()
                Exit Sub
            Else
                idSanPham = cmbSanPham.SelectedItem.id
            End If
        End If

        rls = (From itm In dt.vwChiTietPhieuXuats
               Where itm.NgayLap >= TuNgay And itm.NgayLap <= DenNgay
               Where (Not chkTheoNhanVien.Checked) Or (itm.idNhanVien = idNV)
               Where (Not chkTheoLoaiPhieuXuat.Checked) Or (itm.idLoaiPhieuXuat = idLoaiPhieuXuat)
               Where (Not chkTheoNhaCungCap.Checked) Or (itm.idKhachHang = idNhaCungCap)
               Where (Not chkTheoSanPham.Checked) Or (itm.idSanPham = idSanPham)
               Order By itm.NgayLap).ToList

        bsChiTietPhieuXuat.DataSource = From itm In rls

        If rls.Count > 0 Then
            lblThongBao.Visible = False
            ' Tinh tong
            lblSoDong.Text = rls.Count.ToString + " sản phẩm."
            TongTien = rls.Sum(Function(s) s.ThanhTien)
            lblTongTien.Text = String.Format("{0:N0}", TongTien) + "đ"

            ' Tô màu
            Dim soHD As Integer = dgvMain.Rows(0).Cells("idPhieuXuat").Value
            dgvMain.Rows(0).DefaultCellStyle.BackColor = Color.LightCyan
            For index As Integer = 1 To dgvMain.Rows.Count - 1
                ' format màu nền
                If dgvMain.Rows(index).Cells("idPhieuXuat").Value = soHD Then
                    dgvMain.Rows(index).DefaultCellStyle.BackColor = dgvMain.Rows(index - 1).DefaultCellStyle.BackColor
                Else
                    soHD = dgvMain.Rows(index).Cells("idPhieuXuat").Value
                    If dgvMain.Rows(index - 1).DefaultCellStyle.BackColor = Color.LightCyan Then
                        dgvMain.Rows(index).DefaultCellStyle.BackColor = Color.White
                    Else
                        dgvMain.Rows(index).DefaultCellStyle.BackColor = Color.LightCyan
                    End If
                End If
            Next
        Else
            lblThongBao.Text = "[Không tìm thấy dữ liệu phù hợp]"
            lblThongBao.Visible = True

            ' Tinh tong
            lblSoDong.Text = "0 sản phẩm."

            lblTongTien.Text = "0đ"
        End If
    End Sub


    Private Sub ctrlThongKeChiTietPhieuXuat_Load(sender As Object, e As EventArgs) Handles Me.Load
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = Now.Date
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 0)
        btnCapNhatLoaiPhieuXuat_Click(Nothing, Nothing)
        btnCapNhatNhanVien_Click(Nothing, Nothing)
    End Sub


    Private Sub btnXemNhanh_Click(sender As Object, e As EventArgs) Handles btnXemNhanh.Click
        'If bsChiTietPhieuXuat.Current Is Nothing Then Exit Sub
        'Dim frm As New frmInPhieuXuat
        'Dim vwPhieuXuat As vwChiTietPhieuXuat = bsChiTietPhieuXuat.Current
        'Dim PhieuXuat = dt.tbPhieuXuats.First(Function(s) s.id = vwPhieuXuat.idPhieuXuat)
        'frm.PhieuXuat = PhieuXuat
        'frm.TongTien = PhieuXuat.TongTien
        'frm.XemTruoc = False
        'frm.Show()
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If bsChiTietPhieuXuat.Count = 0 Then Exit Sub
        Dim frm As New frmInDanhSach
        frm.rptName = ".\Report\PhieuXuat\rptDanhSachChiTietPhieuXuatKho.rdlc"
        frm.dsName = "dsChiTietPhieuXuat"
        frm._bs = bsChiTietPhieuXuat
        If TuNgay.Date = DenNgay.Date Then
            frm.ThoiGianTimKiem = "Ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay)
        Else
            frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
        End If
        frm.Text = "THỐNG KÊ CHI TIẾT PHIẾU XUẤT"
        frm.Show()
    End Sub

    Private Sub chkTheoSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoSanPham.CheckedChanged
        cmbSanPham.Enabled = chkTheoSanPham.Checked
        cmbSanPham.Focus()
    End Sub


    Private Sub chkTheoNhanVien_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhanVien.CheckedChanged
        cmbNhanVien.Enabled = chkTheoNhanVien.Checked
        cmbNhanVien.Focus()
    End Sub

    Private Sub chkTheoNhaCungCap_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhaCungCap.CheckedChanged
        cmbTheoNhaCungCap.Enabled = chkTheoNhaCungCap.Checked
        cmbTheoNhaCungCap.Focus()
    End Sub

    Private Sub chkTheoLoaiPhieuXuat_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoLoaiPhieuXuat.CheckedChanged
        cmbTheoLoaiPhieuXuat.Enabled = chkTheoLoaiPhieuXuat.Checked
        cmbTheoLoaiPhieuXuat.Focus()
    End Sub

    Private Sub btnCapNhatSanPham_Click(sender As Object, e As EventArgs) Handles btnCapNhatSanPham.Click
        cmbSanPham.DataSource = From itm In dt.tbSanPhams
                                  Order By itm.MaSanPham
    End Sub


    Private Sub btnCapNhatLoaiPhieuXuat_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoaiPhieuXuat.Click
        cmbTheoLoaiPhieuXuat.DataSource = From itm In dt.tbLoaiPhieuXuats Select itm
    End Sub

    Private Sub btnCapNhatNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhaCungCap.Click
        cmbTheoNhaCungCap.DataSource = From itm In dt.tbKhachHangs Select itm Order By itm.TenKhachHang
    End Sub

    Private Sub btnTimKiemSanPham_Click(sender As Object, e As EventArgs) Handles btnTimKiemSanPham.Click
        Dim frm As New frmTimKiemSanPham
        AddHandler frm.CtrlTimKiemSanPhamMoi1.ChonSanPhamThanhCong, AddressOf ChonSanPham
        frm.ShowDialog()
    End Sub

    Private Sub ChonSanPham(SanPham As tbSanPham, soluong As Double, TheoDonVi As Boolean)
        cmbSanPham.DataSource = From itm In dt.tbSanPhams
                                Where itm.id = SanPham.id
    End Sub


    Private Sub btnTimKiemNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnTimKiemNhaCungCap.Click
        Dim frm As New frmTimKiemKhachHang
        AddHandler frm.ChonKhachHangThanhCong, AddressOf ChonNhaCungCap
        frm.ShowDialog()
    End Sub

    Private Sub ChonNhaCungCap(kh As tbKhachHang)
        cmbTheoNhaCungCap.DataSource = From itm In dt.tbKhachHangs
                                       Where itm.id = kh.id
    End Sub

    Private Sub btnChiTietHangXuatKho_Click(sender As Object, e As EventArgs) Handles btnChiTietHangXuatKho.Click
        'Dim frm = New frmDanhSachSanPhamXuat
        'frm.NgayLap = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        'Dim bs As New BindingSource
        'bs.DataSource = From itm In rls
        '                Order By itm.TenSanPham, itm.id
        '                Group By itm.idSanPham, itm.MaSanPham, itm.TenSanPham, itm.DonVi Into SoLuong = Sum(itm.SoLuong), DonGia = Average(itm.DonGia)
        'frm.bsData = bs
        'frm.TongTien = TongTien
        'frm.ShowDialog()
    End Sub
End Class

