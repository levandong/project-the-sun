Public Class ctrlThongKeChiTietHoaDon
    Private Sub chkTheoSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoSanPham.CheckedChanged
        cmbSanPham.Enabled = chkTheoSanPham.Checked
        cmbSanPham.Focus()
    End Sub

    Dim TuNgay, DenNgay As DateTime
    Dim idSP, idLSP As Integer
    Dim idKH As Integer = 0
    Dim idNV As Integer = 0

    Public rls As IQueryable(Of vwChiTietHoaDon)
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        DenNgay = CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value


        If chkTheoNhanVien.Checked Then
            If cmbNhanVien.SelectedItem Is Nothing Then
                lblThongBao.Text = "[Chưa chọn nhân viên]"
                lblThongBao.Visible = True
                Exit Sub
            Else
                lblThongBao.Visible = False
                idNV = cmbNhanVien.SelectedItem.id
            End If
        End If

        If chkTheoKhachHang.Checked Then
            If cmbKhachHang.SelectedItem Is Nothing Then
                lblThongBao.Text = "[Chưa chọn khách hàng]"
                lblThongBao.Visible = True
                Exit Sub
            Else
                lblThongBao.Visible = False
                idKH = cmbKhachHang.SelectedItem.id
            End If
        End If


        If chkTheoLoai.Checked Then
            If cmbLoaiSanPham.SelectedItem Is Nothing Then
                lblThongBao.Text = "[Chưa chọn loại sản phẩm]"
                lblThongBao.Visible = True
                Exit Sub
            Else
                lblThongBao.Visible = False
                idLSP = cmbLoaiSanPham.SelectedItem.id
            End If
        End If

        If chkTheoSanPham.Checked Then
            If cmbSanPham.SelectedItem Is Nothing Then
                lblThongBao.Text = "[Chưa chọn sản phẩm]"
                lblThongBao.Visible = True
                Exit Sub
            Else
                lblThongBao.Visible = False
                idSP = cmbSanPham.SelectedItem.id
            End If
        End If

        rls = From ct In dt.vwChiTietHoaDons
              Where ct.NgayLap >= TuNgay And ct.NgayLap <= DenNgay
              Where (Not chkTheoKhachHang.Checked) Or (ct.idKhachHang = idKH)
              Where (Not chkTheoNhanVien.Checked) Or (ct.idNhanVien = idNV)
              Where (Not chkTheoLoai.Checked) Or (ct.idLoaiSanPham = idLSP)
              Where (Not chkTheoSanPham.Checked) Or (ct.idSanPham = idSP)
              Order By ct.NgayLap Select ct

        bsChiTietHoaDon.DataSource = rls


        If bsChiTietHoaDon.Count > 0 Then
            lblThongBao.Visible = False
            ' Tinh tong
            lblSoLuong.Text = bsChiTietHoaDon.Count.ToString + " sản phẩm."

            lblCong.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.SoTien)) + "đ"
            lblChietKhau.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.SoTienChietKhauSanPham)) + "đ"
            lblVAT.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.SoTienVAT)) + "đ"
            lblTongCong.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.ThanhTien)) + "đ"
            lblGiamGia.Text = String.Format("{0:N0}", rls.Sum(Function(s) s.SoTienGiamGia)) + "đ"

            ' Tô màu
            Dim soHD As Integer = dgvMain.Rows(0).Cells("idHoaDon").Value
            dgvMain.Rows(0).DefaultCellStyle.BackColor = Color.LightCyan
            For index As Integer = 1 To dgvMain.Rows.Count - 1
                ' format màu nền
                If dgvMain.Rows(index).Cells("idHoaDon").Value = soHD Then
                    dgvMain.Rows(index).DefaultCellStyle.BackColor = dgvMain.Rows(index - 1).DefaultCellStyle.BackColor
                Else
                    soHD = dgvMain.Rows(index).Cells("idHoaDon").Value
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
            lblSoLuong.Text = "0 sản phẩm."
            lblCong.Text = "0"
            lblChietKhau.Text = "0"
            lblVAT.Text = "0"
            lblTongCong.Text = "0"
            lblGiamGia.Text = "0"
        End If
    End Sub

    Private Sub ctrlThongKeChiTietHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = Now.Date
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 0)
        btnCapNhatLoai_Click(Nothing, Nothing)
        btnCapNhatNhanVien_Click(Nothing, Nothing)
    End Sub


    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Dim rlsSanPham As IQueryable(Of tbSanPham)
    Public Sub btnCapNhatSanPham_Click(sender As Object, e As EventArgs) Handles btnCapNhatSanPham.Click
        If chkTheoLoai.Checked Then
            If cmbLoaiSanPham.SelectedItem IsNot Nothing Then
                Dim Loai As tbLoaiSanPham = cmbLoaiSanPham.SelectedItem
                rlsSanPham = From kh In dt.tbSanPhams
                            Where kh.idLoaiSanPham = Loai.id
            End If
        Else
            rlsSanPham = From sp In dt.tbSanPhams
        End If
        cmbSanPham.DataSource = rlsSanPham
    End Sub

    Private Sub btnCongGopSanPham_Click(sender As Object, e As EventArgs) Handles btnCongGopSanPham.Click
        If bsChiTietHoaDon.Count = 0 Then Exit Sub
        Dim frm As New frmThongKeCongGopChiTietHoaDon
        Dim rlsCongGop = From sp In rls
                         Group By sp.idSanPham, sp.MaSanPham, sp.TenSanPham, sp.DonVi, sp.idLoaiSanPham, sp.TenLoaiSanPham
                         Into Soluong = Sum(sp.SoLuong), thanhtien = Sum((((sp.SoLuong * sp.DonGia * (100 - sp.ChietKhau) / 100) - sp.SoTienGiamGia) * (100 - sp.ChietKhauHoaDon) / 100 * (100 + sp.VAT) / 100))
                         Select New clsSanPhamCongGop With {
                             .idSanPham = idSanPham,
                             .MaSanPham = MaSanPham,
                             .TenSanPham = TenSanPham,
                             .DonVi = DonVi,
                             .idLoaiSanPham = idLoaiSanPham,
                             .TenLoaiSanPham = TenLoaiSanPham,
                             .SoLuong = Soluong,
                             .ThanhTien = thanhtien
                             }

        frm.lst = rlsCongGop
        frm.CtrlDGVSanPhamCongGop1.LoaiThongKe = "DANH SÁCH SẢN PHẨM ĐÃ BÁN"
        frm.ThoiGian = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
        frm.Show()
    End Sub

    Private Sub btnInDanhSach_Click(sender As Object, e As EventArgs) Handles btnInDanhSach.Click
        If bsChiTietHoaDon.Count = 0 Then Exit Sub
        Dim frm As New frmInDanhSach
        frm.Text = "THỐNG KÊ CHI TIẾT HÓA ĐƠN"
        frm.rptName = ".\Report\HoaDon\rptDanhSachChiTietHoaDon.rdlc"
        frm.dsName = "dsChiTietHoaDon"
        frm._bs = bsChiTietHoaDon
        frm.timkiemtheo = ""
        If TuNgay.Date = DenNgay.Date Then
            frm.ThoiGianTimKiem = "Ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay)
        Else
            frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
        End If
        frm.ShowDialog()
    End Sub


    Private Sub chkTheoLoaiSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoLoai.CheckedChanged
        cmbLoaiSanPham.Enabled = chkTheoLoai.Checked
        btnCapNhatSanPham_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCapNhatLoai_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoai.Click
        cmbLoaiSanPham.DataSource = From lsp In dt.tbLoaiSanPhams
                                   Select lsp
    End Sub

    Private Sub chkTheoKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoKhachHang.CheckedChanged
        cmbKhachHang.Enabled = chkTheoKhachHang.Checked
        cmbKhachHang.Focus()
    End Sub

    Private Sub btnTimKiemKhachHang_Click(sender As Object, e As EventArgs) Handles btnTimKiemKhachHang.Click
        Dim frm As New frmTimKiemKhachHang
        AddHandler frm.ChonKhachHangThanhCong, AddressOf ChonKhachHang
        frm.ShowDialog()
    End Sub

    Private Sub ChonKhachHang(kh As tbKhachHang)
        cmbKhachHang.DataSource = From itm In dt.tbKhachHangs
                                  Where itm.id = kh.id
    End Sub


    Private Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        Dim rls = From nv In dt.tbNhanViens
            Where If(loginNhanVien.HopLe, True, nv.id = loginNhanVien.id)
            Select nv
        cmbNhanVien.DataSource = rls
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

    Private Sub btnCapNhatKhachHang_Click(sender As Object, e As EventArgs) Handles btnCapNhatKhachHang.Click
        Dim rls = From nv In dt.tbKhachHangs
            Select nv
        cmbKhachHang.DataSource = rls
    End Sub

    Private Sub chkTheoNhanVien_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhanVien.CheckedChanged
        cmbNhanVien.Enabled = chkTheoNhanVien.Checked
        cmbNhanVien.Focus()
    End Sub
End Class
