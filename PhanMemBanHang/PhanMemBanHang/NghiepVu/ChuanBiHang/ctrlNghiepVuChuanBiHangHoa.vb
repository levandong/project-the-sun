Imports System.ComponentModel

Public Class ctrlNghiepVuChuanBiHangHoa

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        CapNhatLaiDanhSachNhuCauMuaHang()
    End Sub
    Dim lstSanPhamCanNhap As New List(Of clsSanPhamCanNhap)
    Dim rlsCongGop As New List(Of clsSanPhamCanNhap)
    Dim lstChiTietKhachHangDatHang As New List(Of vwChiTietKhachHangDatHang)
    Dim oldIndex As Integer = 0
    Dim oldirection As ListSortDirection = ListSortDirection.Ascending
    Private Sub dgvMain_ColumnHeaderMouseClick(ByVal sender As Object,
    ByVal e As DataGridViewCellMouseEventArgs) Handles dgvMain.ColumnHeaderMouseClick

        Dim newColumn As DataGridViewColumn = dgvMain.Columns(e.ColumnIndex)
        Dim oldColumn As DataGridViewColumn = dgvMain.SortedColumn

        ' If oldColumn is null, then the DataGridView is not currently sorted.
        If oldIndex <> 0 Then
            If e.ColumnIndex = oldIndex AndAlso oldirection = ListSortDirection.Ascending Then
                If newColumn.Name = "TenSanPham" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.TenSanPham Descending
                ElseIf newColumn.Name = "SoLuongMua" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.SoLuongMua Descending
                ElseIf newColumn.Name = "SoLuongChuanBiNhap" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.SoLuongChuanBiNhap Descending
                ElseIf newColumn.Name = "SoLuongChuanBiXuat" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.SoLuongChuanBiXuat Descending
                ElseIf newColumn.Name = "SoLuongCan" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.SoLuongCan Descending
                ElseIf newColumn.Name = "TonKho" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.TonKho Descending
                ElseIf newColumn.Name = "TonKhoToiThieu" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.TonKhoToiThieu Descending
                End If
                oldirection = ListSortDirection.Descending
            Else
                If newColumn.Name = "TenSanPham" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.TenSanPham Ascending
                ElseIf newColumn.Name = "SoLuongMua" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.SoLuongMua Ascending
                ElseIf newColumn.Name = "SoLuongChuanBiNhap" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.SoLuongChuanBiNhap Ascending
                ElseIf newColumn.Name = "SoLuongChuanBiXuat" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.SoLuongChuanBiXuat Ascending
                ElseIf newColumn.Name = "SoLuongCan" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.SoLuongCan Ascending
                ElseIf newColumn.Name = "TonKho" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.TonKho Ascending
                ElseIf newColumn.Name = "TonKhoToiThieu" Then
                    bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                                  Order By itm.TonKhoToiThieu Ascending
                End If
                oldirection = ListSortDirection.Ascending
            End If
        Else
            bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                          Order By itm.TenSanPham Ascending
            oldirection = ListSortDirection.Ascending
        End If
        oldIndex = e.ColumnIndex

    End Sub
    Private Sub dataGridView1_DataBindingComplete(ByVal sender As Object,
    ByVal e As DataGridViewBindingCompleteEventArgs) Handles dgvMain.DataBindingComplete

        ' Put each of the columns into programmatic sort mode.
        For Each column As DataGridViewColumn In dgvMain.Columns
            column.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
    End Sub
    Private Sub FormatGrid()
        Dim fieldNames As String() = New String() {"STT", "Chon", "MaSanPham", "TenSanPham", "TonKho", "TonToiThieu", "SoLuongChuanBiNhap", "SoLuongChuanBiXuat", _
    "SoLuongCan", "SoLuongMua", "TenKhachHang", "TenCongTrinh"}
        grdViewData.Columns("Chon").Caption = "Chọn"
        grdViewData.Columns("Chon").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("Chon").OptionsColumn.AllowMove = False

        grdViewData.Columns("MaSanPham").Caption = "Mã sản phẩm"
        grdViewData.Columns("MaSanPham").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("MaSanPham").OptionsColumn.AllowMove = False

        grdViewData.Columns("TenSanPham").Caption = "Tên sản phẩm"
        grdViewData.Columns("TenSanPham").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("TenSanPham").OptionsColumn.AllowMove = False

        grdViewData.Columns("TonKho").Caption = "Tồn kho"
        grdViewData.Columns("TonKho").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("TonKho").OptionsColumn.AllowMove = False

        grdViewData.Columns("TonToiThieu").Caption = "Tồn tối thiểu"
        grdViewData.Columns("TonToiThieu").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("TonToiThieu").OptionsColumn.AllowMove = False

        grdViewData.Columns("SoLuongChuanBiNhap").Caption = "SL C.B Nhập"
        grdViewData.Columns("SoLuongChuanBiNhap").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("SoLuongChuanBiNhap").OptionsColumn.AllowMove = False

        grdViewData.Columns("SoLuongChuanBiXuat").Caption = "SL C.B Xuất"
        grdViewData.Columns("SoLuongChuanBiXuat").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("SoLuongChuanBiXuat").OptionsColumn.AllowMove = False

        grdViewData.Columns("SoLuongCan").Caption = "SL Cần"
        grdViewData.Columns("SoLuongCan").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("SoLuongCan").OptionsColumn.AllowMove = False

        grdViewData.Columns("SoLuongMua").Caption = "Số lượng mua"
        grdViewData.Columns("SoLuongMua").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("SoLuongMua").OptionsColumn.AllowMove = False

        grdViewData.Columns("TenKhachHang").Caption = "Tên khách hàng"
        grdViewData.Columns("TenKhachHang").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("TenKhachHang").OptionsColumn.AllowMove = False

        grdViewData.Columns("TenCongTrinh").Caption = "Tên công trình"
        grdViewData.Columns("TenCongTrinh").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        grdViewData.Columns("TenCongTrinh").OptionsColumn.AllowMove = False


        grdViewData.Columns("STT").Width = 60
        grdViewData.Columns("Chon").Width = 80
        grdViewData.Columns("MaSanPham").Width = 100
        grdViewData.Columns("TenSanPham").Width = 200
        grdViewData.Columns("TonKho").Width = 100
        grdViewData.Columns("TonToiThieu").Width = 100
        grdViewData.Columns("SoLuongChuanBiNhap").Width = 100
        grdViewData.Columns("SoLuongChuanBiXuat").Width = 100
        grdViewData.Columns("SoLuongCan").Width = 100
        grdViewData.Columns("SoLuongMua").Width = 100
        grdViewData.Columns("TenKhachHang").Width = 160
        grdViewData.Columns("TenCongTrinh").Width = 180

        Dim chkCheckBox As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        chkCheckBox.ValueChecked = CDec(1)
        chkCheckBox.ValueUnchecked = CDec(0)
        grdViewData.Columns("Chon").ColumnEdit = chkCheckBox
    End Sub
    Sub CapNhatLaiDanhSachNhuCauMuaHang()
        lstChiTietKhachHangDatHang.Clear()
        lstSanPhamCanNhap.Clear()
        For Each itm In dt.vwChiTietKhachHangDatHangs.Where(Function(s) s.SoLuongConLai > 0)
            lstChiTietKhachHangDatHang.Add(itm)
        Next
        Dim rls = From itm In lstChiTietKhachHangDatHang
                  Group By itm.idSanPham, itm.TenSanPham, itm.isNhapHang, itm.CongTrinh, itm.TenKhachHang Into SoLuongChuaGiao = Sum(itm.SoLuongConLai)
        For Each itm In rls
            Dim SanPham As tbSanPham = dt.tbSanPhams.Single(Function(s) s.id = itm.idSanPham)
            Dim newSanPhamCanNhap As New clsSanPhamCanNhap
            With newSanPhamCanNhap
                .MaSanPham = SanPham.MaSanPham
                .TenSanPham = itm.TenSanPham
                .id = SanPham.id
                .TonKho = SanPham.SoLuong
                .TonKhoToiThieu = SanPham.TonMin
                .TenCongTrinh = itm.CongTrinh
                .TenKhachHang = itm.TenKhachHang
                If itm.isNhapHang Then
                    .SoLuongChuanBiNhap = itm.SoLuongChuaGiao
                Else
                    .SoLuongChuanBiXuat = itm.SoLuongChuaGiao
                End If
            End With
            lstSanPhamCanNhap.Add(newSanPhamCanNhap)
        Next
        rlsCongGop = (From itm In lstSanPhamCanNhap
                      Select New clsSanPhamCanNhap With {
                             .MaSanPham = itm.MaSanPham,
                             .TenSanPham = itm.TenSanPham,
                             .id = itm.id,
                             .TonKho = itm.TonKho,
                             .TonKhoToiThieu = itm.TonKhoToiThieu,
                             .SoLuongChuanBiNhap = itm.SoLuongChuanBiNhap,
                             .SoLuongChuanBiXuat = itm.SoLuongChuanBiXuat,
                          .TenCongTrinh = itm.TenCongTrinh,
                          .TenKhachHang = itm.TenKhachHang,
                          .SoLuongMua = .SoLuongCan}).ToList
        rlsCongGop.RemoveAll(Function(s) s.SoLuongCan <= 0)
        For Each itm In dt.tbSanPhams.Where(Function(s) s.TonMin > s.SoLuong)
            If rlsCongGop.Where(Function(s) s.id = itm.id).Count = 0 Then
                Dim SanPhamCanNhap As New clsSanPhamCanNhap
                With SanPhamCanNhap
                    .MaSanPham = itm.MaSanPham
                    .TenSanPham = itm.TenSanPham
                    .id = itm.id
                    .TonKho = itm.SoLuong
                    .TonKhoToiThieu = itm.TonMin
                    .SoLuongChuanBiNhap = 0
                    .SoLuongChuanBiXuat = 0
                    .SoLuongMua = .SoLuongCan
                    .TenCongTrinh = "Nhập tối thiểu"
                    .TenKhachHang = ""
                End With
                rlsCongGop.Add(SanPhamCanNhap)
            End If
        Next
        Dim iSTT As Integer = 1
        For Each itm In rlsCongGop
            itm.STT = iSTT
            iSTT += 1
        Next
        bsSanPhanCanNhap.DataSource = From itm In rlsCongGop.AsQueryable()
                                      Order By itm.STT, itm.TenSanPham

    End Sub

    Private Sub ctrlNghiepVuChuanBiHangHoa_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnRefresh_Click(Nothing, Nothing)
    End Sub
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
    'Private Sub dgvLoaiSanPham_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellValueChanged

    'End Sub


    'Private Sub dgvLoaiSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellClick

    'End Sub


    Private Sub gridViewData_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles grdViewData.CustomDrawRowIndicator
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

    Dim isChon As Boolean = True
    Private Sub ChọnTấtCảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChọnTấtCảToolStripMenuItem.Click
        If isChon = True Then
            ChọnTấtCảToolStripMenuItem.Text = "BỎ CHỌN"
            isChon = False
        Else
            ChọnTấtCảToolStripMenuItem.Text = "CHỌN TẤT CẢ"
            isChon = True
        End If
        For Each itm In rlsCongGop
            itm.Chon = Not isChon
        Next
        bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
    End Sub
    Event ThemTabpageMoi(TenHienThi As String, Ten As String, control As Control)
    Dim count As Decimal = 0
    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XToolStripMenuItem.Click
        dgvMain.EndEdit()
        count += 1
        Dim KhachHangDatHang As New ctrlKhachHangDatHang
        For Each itm In rlsCongGop
            If itm.Chon Then
                KhachHangDatHang.CtrlTimKiemSanPham1_ChonSanPhamThanhCong(dt.tbSanPhams.First(Function(s) s.id = itm.id), itm.SoLuongMua, False)
            End If
        Next
        RaiseEvent ThemTabpageMoi("Nhu cầu đặt hàng", "ĐH/Nhu cầu " + iSTT.ToString(), KhachHangDatHang)
    End Sub
    Dim iSTT As Decimal = 0
    Private Sub ChuyểnBáoGiáToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChuyểnBáoGiáToolStripMenuItem.Click
        dgvMain.EndEdit()
        iSTT += 1
        Dim BaoGia As New ctrlBangBaoGia
        BaoGia.isNhapHang = True
        For Each itm In rlsCongGop
            If itm.Chon Then
                BaoGia.CtrlTimKiemSanPham1_ChonSanPhamThanhCong(dt.tbSanPhams.First(Function(s) s.id = itm.id), itm.SoLuongMua, False)
            End If
        Next
        BaoGia.lblTenHienThi.Text = "Yêu cầu báo giá"
        RaiseEvent ThemTabpageMoi("Yêu cầu báo giá", "BG/Nhu cầu " + iSTT.ToString(), BaoGia)
    End Sub

    Private Sub ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtCácPhiếuYêuCầuNhậpToolStripMenuItem.Click
        If bsSanPhanCanNhap.Current Is Nothing Then Exit Sub
        Dim SanPhamCan As clsSanPhamCanNhap = bsSanPhanCanNhap.Current
        If SanPhamCan.SoLuongChuanBiNhap > 0 Then
            Dim frm As New frmDanhSachChuaXuatHang
            frm.Text = "DANH SÁCH SẢN PHẨM " + SanPhamCan.TenSanPham + " CHƯA NHẬP"
            frm.bsChiTietKhachHangDatHang.DataSource = From itm In dt.vwChiTietKhachHangDatHangs
                                                       Where itm.idSanPham = SanPhamCan.id
                                                       Where itm.SoLuongConLai > 0
                                                       Where itm.isNhapHang = True
            frm.ShowDialog()
        End If
    End Sub

    Private Sub ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtCácPhiếuYêuCầuXuấtToolStripMenuItem.Click
        If bsSanPhanCanNhap.Current Is Nothing Then Exit Sub
        Dim SanPhamCan As clsSanPhamCanNhap = bsSanPhanCanNhap.Current
        If SanPhamCan.SoLuongChuanBiXuat > 0 Then
            Dim frm As New frmDanhSachChuaXuatHang
            frm.Text = "DANH SÁCH SẢN PHẨM " + SanPhamCan.TenSanPham + " CHƯA XUẤT"
            frm.bsChiTietKhachHangDatHang.DataSource = From itm In dt.vwChiTietKhachHangDatHangs
                                                       Where itm.idSanPham = SanPhamCan.id
                                                       Where itm.SoLuongConLai > 0
                                                       Where itm.isNhapHang = False
            frm.ShowDialog()
        End If
    End Sub
    Private Sub dgvMain_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMain.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Dim rowSelected As Integer = e.RowIndex
            If (e.RowIndex <> -1) Then
                Me.dgvMain.ClearSelection()
                Me.dgvMain.Rows(rowSelected).Selected = True
                bsSanPhanCanNhap.Position = e.RowIndex
            End If
        End If
    End Sub

    Private Sub btnTinhToanTonKhoHienTai_Click(sender As Object, e As EventArgs) Handles btnTinhToanTonKhoHienTai.Click
        For Each itm In dt.TinhTonKhoSanPham(-1, -1, Now.Date, Now.Date)
            Dim SanPham As tbSanPham = dt.tbSanPhams.Single(Function(s) s.id = itm.id)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPham)
            SanPham.SoLuong = itm.SoLuongCuoiKy
        Next
        Try
            dt.SubmitChanges()
        Catch ex As Exception

        End Try
    End Sub
    Sub CapNhatLaiDanhSachTheoSoThuTu()
        Dim count = 0
        For Each itm In rlsCongGop.OrderBy((Function(s) s.STT))
            count += 1
            itm.STT = count
        Next
        bsSanPhanCanNhap.DataSource = From itm In rlsCongGop
                                      Order By itm.STT, itm.TenSanPham
    End Sub
    Private Sub btnCapNhatLaiSoThuTu_Click(sender As Object, e As EventArgs) Handles btnCapNhatLaiSoThuTu.Click
        CapNhatLaiDanhSachTheoSoThuTu()
    End Sub

    Private Sub grdViewData_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles grdViewData.CustomColumnDisplayText
        If e.Column.FieldName = "" Then
            e.DisplayText = e.RowHandle.ToString + 1
        End If
    End Sub
End Class
