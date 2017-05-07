Public Class ctrlThongKeChiTietKhachHangDatHang

    Private Sub chkTheoSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoSanPham.CheckedChanged
        cmbSanPham.Enabled = chkTheoSanPham.Checked
    End Sub

    Dim TuNgay, DenNgay As DateTime
    Dim idSP, idLSP As Integer
    Public rls As IQueryable(Of vwChiTietKhachHangDatHang)
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        DenNgay = CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value
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

        rls = From ct In dt.vwChiTietKhachHangDatHangs
                        Where ct.NgayLap >= TuNgay And ct.NgayLap <= DenNgay
                        Where (Not chkTheoLoai.Checked) Or (ct.idLoaiSanPham = idLSP)
                        Where (Not chkTheoSanPham.Checked) Or (ct.idSanPham = idSP)

        bsChiTietKhachHangDatHang.DataSource = rls

        If rls.Count > 0 Then
            lblThongBao.Visible = False
        Else
            lblThongBao.Text = "[Không tìm thấy dữ liệu phù hợp]"
            lblThongBao.Visible = True
        End If
        btnHuyTimKiem.Enabled = True
    End Sub

    Private Sub ctrlThongKeXuatNhapNguyenLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = Now.Date
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = Now
        btnCapNhatLoai_Click(Nothing, Nothing)
        btnCapNhatSanPham_Click(Nothing, Nothing)
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
        If dgvMain.RowCount = 0 Then Exit Sub
        Dim frm As New frmThongKeCongGopChiTietKhachHangDatHang
        Dim rlsCongGop = From sp In rls
                         Group By sp.idSanPham
                         Into Soluong = Sum(sp.SoLuong), thanhtien = Sum((sp.SoLuong * sp.DonGia * (100 - sp.ChietKhau) / 100 * (100 - sp.ChietKhauKhachHangDatHang) / 100 * (100 + sp.VAT) / 100))
                         Select New clsSanPhamCongGop With {
                             .idSanPham = idSanPham,
                             .SoLuong = Soluong,
                             .ThanhTien = thanhtien
                             }

        frm.lst = rlsCongGop
        frm.CtrlDGVSanPhamCongGop1.LoaiThongKe = "DANH SÁCH SẢN PHẨM ĐÃ BÁN"
        frm.ThoiGian = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
        frm.Show()
    End Sub

    Public Sub btnTimKiemSanPham_Click(sender As Object, e As EventArgs) Handles btnTimKiemSanPham.Click
        Dim frm As New frmTimKiemSanPham
        If frm.ShowDialog = DialogResult.OK Then
            Try
                cmbSanPham.SelectedItem = frm.SanPhamDuocChon
            Catch ex As Exception
                btnCapNhatSanPham_Click(Nothing, Nothing)
                cmbSanPham.SelectedItem = frm.SanPhamDuocChon
            End Try
        End If
    End Sub

    Public Function TimKiemTheoDieuKien() As String
        Dim TimKiemTheo As String = ""
        If chkTheoLoai.Checked = False And chkTheoSanPham.Checked Then
            TimKiemTheo = "Tất cả"
        Else
            If chkTheoLoai.Checked Then
                TimKiemTheo += " - Loại:  " + cmbLoaiSanPham.SelectedItem.TenSanPham
            End If
            If chkTheoSanPham.Checked Then
                If chkTheoLoai.Checked Then
                    TimKiemTheo += vbNewLine + " - Sản phẩm:  " + cmbSanPham.SelectedItem.ToString
                Else
                    TimKiemTheo += " - Sản phẩm:  " + cmbSanPham.SelectedItem.TenSanPham
                End If
            End If
        End If

        Return TimKiemTheo
    End Function

    Private Sub btnInDanhSach_Click(sender As Object, e As EventArgs) Handles btnInDanhSach.Click
        If bsChiTietKhachHangDatHang.Count = 0 Then Exit Sub
        Dim frm As New frmInDanhSach
        frm.Text = "THỐNG KÊ CHI TIẾT ĐƠN ĐẶT HÀNG"
        frm.rptName = ".\Report\KhachHangDatHang\rptDanhSachChiTietKhachHangDatHang.rdlc"
        frm.dsName = "dsDanhSachChiTietKhachHangDatHang"
        frm._bs = bsChiTietKhachHangDatHang
        frm.timkiemtheo = TimKiemTheoDieuKien()
        frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
        frm.ShowDialog()
    End Sub

    Private Sub bsChiTietKhachHangDatHang_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietKhachHangDatHang.ListChanged
        lblSoLuong.Text = bsChiTietKhachHangDatHang.Count.ToString + " sản phẩm."
        Dim vat, cong, ck, tong As Decimal
        vat = 0
        cong = 0
        ck = 0
        tong = 0

        For Each itm In bsChiTietKhachHangDatHang
            cong += itm.CongTienChiTiet
            ck += itm.SoTienChietKhauSanPham
            tong += itm.ThanhTien
            vat += itm.SoTienVATChiTiet
        Next
        lblTongCong.Text = String.Format("{0:N0}", tong) + "đ"
        lblCong.Text = String.Format("{0:N0}", cong) + "đ"
        lblChietKhau.Text = String.Format("{0:N0}", ck) + "đ"
        lblVAT.Text = String.Format("{0:N0}", vat) + "đ"

        If bsChiTietKhachHangDatHang.Count > 0 Then
            Dim soHD As Integer = dgvMain.Rows(0).Cells("idKhachHangDatHang").Value
            dgvMain.Rows(0).DefaultCellStyle.BackColor = Color.LightCyan
            For index As Integer = 1 To dgvMain.Rows.Count - 1
                ' format màu nền
                If dgvMain.Rows(index).Cells("idKhachHangDatHang").Value = soHD Then
                    dgvMain.Rows(index).DefaultCellStyle.BackColor = dgvMain.Rows(index - 1).DefaultCellStyle.BackColor
                Else
                    soHD = dgvMain.Rows(index).Cells("idKhachHangDatHang").Value
                    If dgvMain.Rows(index - 1).DefaultCellStyle.BackColor = Color.LightCyan Then
                        dgvMain.Rows(index).DefaultCellStyle.BackColor = Color.White
                    Else
                        dgvMain.Rows(index).DefaultCellStyle.BackColor = Color.LightCyan
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub btnHuyTimKiem_Click(sender As Object, e As EventArgs) Handles btnHuyTimKiem.Click
        bsChiTietKhachHangDatHang.Clear()
        btnHuyTimKiem.Enabled = False
        lblThongBao.Visible = False
    End Sub

    Private Sub chkTheoLoaiSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoLoai.CheckedChanged
        cmbLoaiSanPham.Enabled = chkTheoLoai.Checked
        btnCapNhatSanPham_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCapNhatLoai_Click(sender As Object, e As EventArgs) Handles btnCapNhatLoai.Click
        bsLoaiSanPham.DataSource = From lsp In dt.tbLoaiSanPhams
                                   Select lsp
                                   Order By lsp.MaLoaiSanPham
    End Sub
End Class
