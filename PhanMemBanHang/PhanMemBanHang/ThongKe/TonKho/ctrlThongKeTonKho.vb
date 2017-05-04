Public Class ctrlThongKeTonKho

    Private Sub chkTheoSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoSanPham.CheckedChanged
        cmbSanPham.Enabled = chkTheoSanPham.Checked
    End Sub

    Private Sub ctrlTonKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTuNgay.Value = New Date(Now.Year, Now.Month, 1)
        dtpDenNgay.Value = Now
        With CtrlDGVLoaiSanPham1
            '.Chon.Visible = True
            .gridViewData.OptionsView.ShowIndicator = False
            .colMaLoaiSanPham.Visible = False
            .colMoTa.Visible = False
        End With
        isLoad = True
        TimKiemLoaiSanPham()
    End Sub

    Public Sub btnCapNhatSanPham_Click(sender As Object, e As EventArgs) Handles btnCapNhatSanPham.Click
        cmbSanPham.DataSource = From itm In dt.tbSanPhams
                               Order By itm.TenSanPham
    End Sub

    Dim TuNgay As Date
    Dim DenNgay As Date
    Dim TheoNgay As Boolean

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        TuNgay = dtpTuNgay.Value.Date
        DenNgay = dtpDenNgay.Value.Date
        TheoNgay = chkTheoThoiGian.Checked

        Dim idSanPham As Integer = -1
        If chkTheoSanPham.Checked Then
            If cmbSanPham.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn sản phẩm cần thống kê.", _
                                                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                idSanPham = cmbSanPham.SelectedItem.id
            End If
        End If

        Dim rlsLoai = From itm In lst.ToList
                      Where itm.Chon = True
                      Select itm.id
        Dim rlsTonKho = From ct In dt.TinhTonKhoSanPham(idSanPham, chkTheoThoiGian.Checked, TuNgay, DenNgay)
        If rlsLoai.Count > 0 Then
            bsTonKho.DataSource = From itm In rlsTonKho.ToList
                                  Where (Not chkCoPhatSinhDuLieu.Checked) Or (chkCoPhatSinhDuLieu.Checked And (itm.SoLuongNhapTrongKy > 0 Or itm.SoLuongXuatTrongKy > 0))
                                  Where (Not chkConTonKho.Checked) Or (chkConTonKho.Checked And itm.SoLuongCuoiKy > 0)
                                  Where rlsLoai.Any(Function(s) s = itm.idLoaiSanPham)
                                  Order By itm.TenLoaiSanPham, itm.TenSanPham
        Else
            bsTonKho.DataSource = From itm In rlsTonKho
                                  Where (Not chkCoPhatSinhDuLieu.Checked) Or (chkCoPhatSinhDuLieu.Checked And (itm.SoLuongNhapTrongKy > 0 Or itm.SoLuongXuatTrongKy > 0))
                                  Where (Not chkConTonKho.Checked) Or (chkConTonKho.Checked And itm.SoLuongCuoiKy > 0)
                                  Order By itm.TenLoaiSanPham, itm.TenSanPham
        End If
    End Sub

    Private Sub dgvTonKho_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        btnXemChiTiet_Click(Nothing, Nothing)
    End Sub

    Private Sub dgvTonKho_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub bsTonKho_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsTonKho.ListChanged
        Dim slNhap As Double = 0, slXuat As Double = 0, slDauKy As Double = 0
        Dim slCuoiKy As Double = 0

        Dim tienNhap As Decimal = 0, tienXuat As Decimal = 0
        Dim tiendauky As Decimal = 0, tiencuoiky As Decimal = 0

        For Each itm In bsTonKho
            slNhap += itm.SoLuongNhapTrongKy
            slXuat += itm.SoLuongXuatTrongKy
            slDauKy += itm.SoLuongDauKy
            slCuoiKy += itm.SoluongCuoiKy

            tiendauky += itm.TongTienDauKy
            tienNhap += itm.TienNhapTrongKy
            tienXuat += itm.TienXuatTrongKy
            tiencuoiky += itm.TongTienCuoiKy
        Next

        lblSLDauKy.Text = slDauKy.ToString
        lblSLCuoiKy.Text = slCuoiKy.ToString
        lblSLNhap.Text = slNhap.ToString
        lblSLXuat.Text = slXuat.ToString

        lblDauKy.Text = String.Format("{0:N0}", tiendauky) + "đ"
        lblTTNhap.Text = String.Format("{0:N0}", tienNhap) + "đ"
        lblTTXuat.Text = String.Format("{0:N0}", tienXuat) + "đ"
        lblTTCuoiKy.Text = String.Format("{0:N0}", tiencuoiky) + "đ"
        lblSoDong.Text = bsTonKho.Count.ToString + " sản phẩm."
    End Sub

    Private Sub btnXemChiTiet_Click(sender As Object, e As EventArgs) Handles btnXemChiTiet.Click
        If bsTonKho.Current Is Nothing Then Exit Sub
        Dim frm As New frmChiTietTonKho
        frm.idSanPham = bsTonKho.Current.id
        frm.TheoNgay = TheoNgay
        frm.TuNgay = TuNgay
        frm.DenNgay = DenNgay
        Dim TonKho As TinhTonKhoSanPhamResult = bsTonKho.Current
        frm.Text = "THẺ KHO - " + TonKho.TenSanPham
        frm.Show()
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        If bsTonKho.Count > 0 Then
            Dim frm As New frmInDanhSach
            frm.rptName = ".\Report\TonKho\rptTonKhoSanPham.rdlc"
            frm.dsName = "dsTonKho"
            frm.timkiemtheo = ""
            If TheoNgay Then
                frm.ThoiGianTimKiem = "Từ ngày " + String.Format("{0:dd/MM/yyyy}", TuNgay) + _
                " đến ngày " + String.Format("{0:dd/MM/yyyy}", DenNgay)
            Else
                frm.ThoiGianTimKiem = "<Tất cả>"
            End If
            frm._bs = bsTonKho
            frm.Text = "NHẬP - XUẤT - TỒN"
            frm.Show()
        End If
    End Sub

    Private Sub chkTheoThoiGian_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoThoiGian.CheckedChanged
        dtpTuNgay.Enabled = chkTheoThoiGian.Checked
        dtpDenNgay.Enabled = chkTheoThoiGian.Checked

        SoLuongDauKy.Visible = chkTheoThoiGian.Checked
        TongTienDauKy.Visible = chkTheoThoiGian.Checked
    End Sub

#Region "SẢN PHẨM"
    Dim KeyTimKiem As String
    Dim isTimKiem As Boolean = True
    Private Sub cmbSanPham_TextChanged(sender As Object, e As EventArgs) Handles cmbSanPham.TextChanged
        If isTimKiem Then
            KeyTimKiem = cmbSanPham.Text.Trim.ToLower
        End If
        If cmbSanPham.Text.Trim = "" And cmbSanPham.DroppedDown = True Then
            cmbSanPham.DroppedDown = False
        End If
    End Sub

    Private Sub CapNhatSanPham(key As String)
        Dim rls = From itm In dt.tbSanPhams
                                 Where (key = "") Or (itm.TenSanPhamString.Contains(key) Or dt.f_nosymbol(itm.MaSanPhamString).ToLower.Contains(key))
                                Select itm Order By itm.tbLoaiSanPham.TenLoaiSanPham, itm.MaSanPham

        cmbSanPham.DataSource = rls
    End Sub

    Private Sub cmbSanPham_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSanPham.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            isTimKiem = False
            KeyTimKiem = BoDauTiengViet(KeyTimKiem)
            If KeyTimKiem = "" Then
                CapNhatSanPham("")
            Else
                If cmbSanPham.DroppedDown = False Then
                    CapNhatSanPham(KeyTimKiem)
                    cmbSanPham.DroppedDown = True
                    Cursor.Current = Cursors.Default
                    e.Handled = True
                End If
            End If
            isTimKiem = True
        End If
    End Sub
#End Region

#Region "LOẠI SẢN PHAM"

    Private lst As IQueryable(Of tbLoaiSanPham)
    Private ChonTatCa As Boolean
    Private Sub btnChonTatCa_Click(sender As Object, e As EventArgs) Handles btnChonTatCa.Click
        ChonTatCa = Not ChonTatCa
        For Each itm In lst.ToList
            itm.Chon = ChonTatCa
        Next
        'CtrlDGVLoaiSanPham1.bsLoaiSanPham.EndEdit()
        'CtrlDGVLoaiSanPham1.bsLoaiSanPham.ResetBindings(True)
        'CtrlDGVLoaiSanPham1.dgvLoaiSanPham.Refresh()

        If ChonTatCa Then
            btnChonTatCa.Image = My.Resources.unchecked
            btnChonTatCa.Text = "Bỏ chọn tất cả"
        Else
            btnChonTatCa.Image = My.Resources.Checked
            btnChonTatCa.Text = "Chọn tất cả"
        End If
    End Sub

    'Private Sub dgvLoaiSanPham_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '    If CtrlDGVLoaiSanPham1.bsLoaiSanPham.Current IsNot Nothing Then
    '        CtrlDGVLoaiSanPham1.dgvLoaiSanPham.Rows(e.RowIndex).Cells("Chon").Value = Not CtrlDGVLoaiSanPham1.dgvLoaiSanPham.Rows(e.RowIndex).Cells("Chon").Value
    '    End If
    'End Sub

    Private Sub TimKiemLoaiSanPham()
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTimKiemLoai.Text.Trim).ToLower
        lst = (From itm In dt.tbLoaiSanPhams
               Where dt.f_nosymbol(itm.TenLoaiSanPham).ToLower.Contains(key)
               Order By itm.TenLoaiSanPham)

        CtrlDGVLoaiSanPham1.gridControl.DataSource = lst
        CtrlDGVLoaiSanPham1.gridViewData.RefreshData()
    End Sub
    Private Sub txtTimKiemLoai_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimKiemLoai.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimKiemLoaiSanPham()
        End If
    End Sub

    Private Sub txtTimKiemLoai_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiemLoai.TextChanged
        If txtTimKiemLoai.Text.Trim = "" Then
            CtrlDGVLoaiSanPham1.gridControl.DataSource = From itm In lst
                                                         Order By itm.TenLoaiSanPham

            CtrlDGVLoaiSanPham1.gridViewData.RefreshData()
        End If
    End Sub

    Private Sub CtrlDGVLoaiSanPham1_ChonLoaiSanPham(LoaiSanPham As tbLoaiSanPham) Handles CtrlDGVLoaiSanPham1.ChonLoaiSanPham
        LoaiSanPham.Chon = Not LoaiSanPham.Chon
    End Sub
#End Region

#Region "TÍNH LẠI GIÁ BÌNH QUÂN GIA QUYỀN"
    Private Sub btnTinhLaiGiaBinhQuan_Click(sender As Object, e As EventArgs) Handles btnTinhLaiGiaBinhQuan.Click, ctmNhungSanPhamCoPhatSinh.Click
        If bsTonKho.Count = 0 Then
            btnTimKiem_Click(Nothing, Nothing)
        End If

        Dim lst = From itm In bsTonKho
                  Where itm.SoLuongNhapTrongKy > 0 Or itm.SoLuongXuatTrongKy > 0

        For Each itm In lst
            Dim idSanPham As Integer = itm.id
            dt.TinhGiaBinhQuan(idSanPham)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, dt.tbSanPhams.First(Function(s) s.id = idSanPham))
        Next
    End Sub

    Private Sub ctmTinhChoTatCaSanPham_Click(sender As Object, e As EventArgs) Handles ctmTinhChoTatCaSanPham.Click
        For Each itm In dt.tbSanPhams
            dt.TinhGiaBinhQuan(itm.id)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, itm)
        Next
    End Sub

    Private Sub btnCapNhatTonKho_Click(sender As Object, e As EventArgs) Handles btnCapNhatTonKho.Click
        If XacNhanYesNo("Bạn có muốn cập nhật lại số lượng tồn kho trong kho") = DialogResult.Yes Then
            Dim rlsTonKho = From ct In dt.TinhTonKhoSanPham(-1, 0, TuNgay, DenNgay)
            For Each itm In rlsTonKho.ToList
                Dim SanPham As tbSanPham = dt.tbSanPhams.Single(Function(s) s.id = itm.id)
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPham)
                SanPham.SoLuong = itm.SoLuongCuoiKy
            Next
            Try
                dt.SubmitChanges()
                btnTimKiem_Click(Nothing, Nothing)
            Catch ex As Exception
                undoChange()
                ThongBao("Có lỗi trong quá trình cập nhật lại dữ liệu")
            End Try
        End If
    End Sub
    Private Sub dgvMain_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMain.CellFormatting
        If e.RowIndex > -1 And e.ColumnIndex > -1 Then
            If dgvMain.Columns(e.ColumnIndex).Name.Equals("SoLuongCuoiKy") Or dgvMain.Columns(e.ColumnIndex).Name.Equals("SoLuongHienTai") Then
                If dgvMain.Rows(e.RowIndex).Cells("SoLuongCuoiKy").Value <> dgvMain.Rows(e.RowIndex).Cells("SoLuongHienTai").Value Then
                    e.CellStyle.BackColor = Color.Red
                    e.CellStyle.SelectionBackColor = Color.Red
                End If
            End If
        End If
    End Sub
#End Region

End Class
