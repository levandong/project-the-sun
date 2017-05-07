Public Class ctrlThongKeChiTietPhieuNhap
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Public Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From itm In dt.tbNhanViens Order By itm.TenDangNhap
    End Sub

    Dim TuNgay As DateTime
    Dim DenNgay As DateTime
    Dim rls As New List(Of vwChiTietPhieuNhap)
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

        Dim idLoaiPhieuNhap As Integer
        If chkTheoLoaiPhieuNhap.Checked Then
            If cmbTheoLoaiPhieuNhap.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn loại phiếu nhập cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTheoLoaiPhieuNhap.Focus()
                Exit Sub
            Else
                idLoaiPhieuNhap = cmbTheoLoaiPhieuNhap.SelectedItem.id
            End If
        End If
        Dim idKhachHang As Integer
        If chkTheoKhachHang.Checked Then
            If cmbTheoKhachHang.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn khách hàng cần thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbTheoKhachHang.Focus()
                Exit Sub
            Else
                idKhachHang = cmbTheoKhachHang.SelectedItem.id
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

        rls = (From itm In dt.vwChiTietPhieuNhaps
               Where itm.NgayLap >= TuNgay And itm.NgayLap <= DenNgay
               Where (Not chkTheoLoaiPhieuNhap.Checked) Or (itm.idLoaiPhieuNhap = idLoaiPhieuNhap)
               Where (Not chkTheoKhachHang.Checked) Or (itm.idKhachHang = idKhachHang)
               Where (Not chkTheoNhaCungCap.Checked) Or (itm.idNhaCungCap = idNhaCungCap)
               Where (Not chkTheoNhanVien.Checked) Or (itm.idNhanVien = idNV)
               Where (Not chkTheoSanPham.Checked) Or (itm.idSanPham = idSanPham)
               Order By itm.NgayLap).ToList

        bsChiTietPhieuNhap.DataSource = rls.ToList

        If rls.Count > 0 Then
            lblThongBao.Visible = False
            ' Tinh tong
            lblSoDong.Text = rls.Count.ToString + " sản phẩm."

            lblCongTien.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.SoTien)) + "đ"
            lblTienCK.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.TienChietKhauChiTiet)) + "đ"
            lblTienVAT.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.TienVATChiTiet)) + "đ"
            lblTongTien.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.ThanhTien)) + "đ"

            ' Tô màu
            Dim soHD As Integer = dgvMain.Rows(0).Cells("idPhieuNhap").Value
            dgvMain.Rows(0).DefaultCellStyle.BackColor = Color.LightCyan
            For index As Integer = 1 To dgvMain.Rows.Count - 1
                ' format màu nền
                If dgvMain.Rows(index).Cells("idPhieuNhap").Value = soHD Then
                    dgvMain.Rows(index).DefaultCellStyle.BackColor = dgvMain.Rows(index - 1).DefaultCellStyle.BackColor
                Else
                    soHD = dgvMain.Rows(index).Cells("idPhieuNhap").Value
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

            lblCongTien.Text = "0đ"
            lblTienCK.Text = "0đ"
            lblTienVAT.Text = "0đ"
            lblTongTien.Text = "0đ"
        End If
    End Sub

    Private Sub chkTheoNhanVien_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhanVien.CheckedChanged
        cmbNhanVien.Enabled = chkTheoNhanVien.Checked
        cmbNhanVien.Focus()
    End Sub

    Private Sub ctrlThongKeChiTietPhieuNhap_Load(sender As Object, e As EventArgs) Handles Me.Load
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = Now.Date
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 0)
        btnCapNhatNhanVien_Click(Nothing, Nothing)
        btnCapNhatLoaiPhieuNhap_Click(Nothing, Nothing)
    End Sub

    Private Sub bsPhieuNhapNhap_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietPhieuNhap.ListChanged
        If bsChiTietPhieuNhap.Count = 0 Then Exit Sub
        Dim tienchietkhau As Decimal = 0
        Dim tienVAT As Decimal = 0
        Dim CongTien As Decimal = 0
        Dim sophieuNhap As Integer = 0
        Dim ThanhTien As Decimal = 0

        For Each itm In bsChiTietPhieuNhap
            sophieuNhap += 1
            ThanhTien += itm.ThanhTien
            tienchietkhau += itm.TienChietKhauChiTiet
            tienVAT += itm.TienVATChiTiet
            CongTien += itm.SoTien
        Next

        lblSoDong.Text = sophieuNhap.ToString + " sản phẩm."
        lblTongTien.Text = ThanhTien.ToString("N0") + "đ"
        lblCongTien.Text = CongTien.ToString("N0") + "đ"
        lblTienCK.Text = tienchietkhau.ToString("N0") + "đ"
        lblTienVAT.Text = tienVAT.ToString("N0") + "đ"
    End Sub

    Private Sub btnXemNhanh_Click(sender As Object, e As EventArgs) Handles btnXemNhanh.Click
        'If bsChiTietPhieuNhap.Current Is Nothing Then Exit Sub
        'Dim frm As New frmInPhieuNhap
        'Dim vwPhieuNhap As vwChiTietPhieuNhap = bsChiTietPhieuNhap.Current
        'Dim PhieuNhap = dt.tbPhieuNhaps.First(Function(s) s.id = vwPhieuNhap.idPhieuNhap)
        'frm.PhieuNhap = PhieuNhap
        'frm.TongTien = PhieuNhap.TongTien
        'frm.XemTruoc = False
        'frm.Show()
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If bsChiTietPhieuNhap.Count = 0 Then Exit Sub
        Dim frm As New frmInDanhSach
        frm.rptName = ".\Report\PhieuNhap\rptDanhSachChiTietPhieuNhap.rdlc"
        frm.dsName = "dsChiTietPhieuNhap"
        frm._bs = bsChiTietPhieuNhap
        If TuNgay.Date = DenNgay.Date Then
            frm.ThoiGianTimKiem = "Ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay)
        Else
            frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
        End If
        frm.Text = "THỐNG KÊ CHI TIẾT PHIẾU NHẬP"
        frm.Show()
    End Sub

    Private Sub chkTheoSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoSanPham.CheckedChanged
        cmbSanPham.Enabled = chkTheoSanPham.Checked
        cmbSanPham.Focus()
    End Sub


    Private Sub chkTheoNhaCungCap_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhaCungCap.CheckedChanged
        cmbTheoNhaCungCap.Enabled = chkTheoNhaCungCap.Checked
        cmbTheoNhaCungCap.Focus()
    End Sub

    Private Sub chkTheoKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoKhachHang.CheckedChanged
        cmbTheoKhachHang.Enabled = chkTheoKhachHang.Checked
        cmbTheoKhachHang.Focus()

    End Sub

    Private Sub chkTheoLoaiPhieuNhap_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoLoaiPhieuNhap.CheckedChanged
        cmbTheoLoaiPhieuNhap.Enabled = chkTheoLoaiPhieuNhap.Checked
        cmbTheoLoaiPhieuNhap.Focus()
    End Sub


    Private Sub btnCapNhatSanPham_Click(sender As Object, e As EventArgs) Handles btnCapNhatSanPham.Click
        cmbSanPham.DataSource = From itm In dt.tbSanPhams
                                  Order By itm.MaSanPham
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


    Private Sub btnCapNhatLoaiPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoaiPhieuNhap.Click
        cmbTheoLoaiPhieuNhap.DataSource = From itm In dt.tbLoaiPhieuNhaps Select itm
    End Sub

    Private Sub chkTheoLoaiPhieuNhap_Click(sender As Object, e As EventArgs) Handles chkTheoLoaiPhieuNhap.Click
        cmbTheoLoaiPhieuNhap.Enabled = chkTheoLoaiPhieuNhap.Checked
        cmbTheoLoaiPhieuNhap.Focus()
    End Sub

    Private Sub btnCapNhatKhachHang_Click(sender As Object, e As EventArgs) Handles btnCapNhatKhachHang.Click
        cmbTheoKhachHang.DataSource = From itm In dt.tbKhachHangs Select itm Order By itm.TenKhachHang
    End Sub

    Private Sub btnCapNhatNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhaCungCap.Click
        cmbTheoNhaCungCap.DataSource = From itm In dt.tbKhachHangs Select itm Order By itm.TenKhachHang
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
    Private Sub btnTimKiemKhachHang_Click(sender As Object, e As EventArgs) Handles btnTimKiemKhachHang.Click
        Dim frm As New frmTimKiemKhachHang
        AddHandler frm.ChonKhachHangThanhCong, AddressOf ChonKhachHang
        frm.ShowDialog()
    End Sub

    Private Sub ChonKhachHang(kh As tbKhachHang)
        cmbTheoKhachHang.DataSource = From itm In dt.tbKhachHangs
                                  Where itm.id = kh.id
    End Sub
    Private Sub btnXemChiTiet_Click(sender As Object, e As EventArgs) Handles btnXemChiTiet.Click
        'Dim frm = New frmDanhSachSanPhamXuat
        'frm.NgayLap = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        'Dim bs As New BindingSource
        'bs.DataSource = From itm In rls
        '                Order By itm.TenSanPham, itm.id
        '                Group By itm.idSanPham, itm.MaSanPham, itm.TenSanPham, itm.DonVi Into SoLuong = Sum(itm.SoLuong), DonGia = Average(itm.DonGia * (1 - itm.ChietKhau / 100)), ThanhTien = Sum(itm.DonGia * (1 - itm.ChietKhau / 100) * itm.SoLuong)
        'frm.bsData = bs
        'frm.TongTien = rls.Sum(Function(s) s.ThanhTien)
        'frm.ShowDialog()
    End Sub
End Class

