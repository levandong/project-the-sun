Public Class ctrlThemSuaXoaLoaiSanPham
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
                Case "btnThemLoaiSanPham"
                    PhanQuyenLenDoiTuong(btnThem, qc1.HinhThuc, TrangThai)
                Case "btnSuaLoaiSanPham"
                    PhanQuyenLenDoiTuong(btnSua, qc1.HinhThuc, TrangThai)
                Case "btnXoaLoaiSanPham"
                    PhanQuyenLenDoiTuong(btnXoa, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemLoaiSanPham
        AddHandler frm.ThemThanhCongLoaiSanPham, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If CtrlDGVLoaiSanPham1.gridViewData.FocusedRowHandle > 0 Then
            Dim LoaiSanPham As tbLoaiSanPham = CtrlDGVLoaiSanPham1.gridViewData.GetRow(CtrlDGVLoaiSanPham1.gridViewData.FocusedRowHandle)
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xoá loại sản phẩm " + LoaiSanPham.TenLoaiSanPham + "?" +
                                vbNewLine + "Mọi dữ liệu liên quan sẽ bị xoá theo?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                            = DialogResult.Yes Then
                If LoaiSanPham.tbSanPhams.Count > 0 Then
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xóa loại sản phẩm này. Vui lòng xóa sản phẩm thuộc loại trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                dt.tbLoaiSanPhams.DeleteOnSubmit(LoaiSanPham)
                Try
                    dt.SubmitChanges()
                    btnTimKiem_ButtonClick(Nothing, Nothing)
                Catch ex As Exception
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xoá loại sản phẩm này. Vui lòng xoá các dữ liệu liên quan trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    undoChange()
                    CapNhat()
                End Try
            End If
        End If
    End Sub

    Private Sub txtTuKhoa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTuKhoa.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTimKiem_ButtonClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles txtTuKhoa.TextChanged
        If txtTuKhoa.Text = "" Then
            CapNhat()
        End If
    End Sub

    Private Sub btnTimKiem_ButtonClick(sender As Object, e As EventArgs) Handles btnTimKiem.ButtonClick
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTuKhoa.Text.Trim.ToLower)
        Dim rlsLoaiSanPham

        rlsLoaiSanPham = From kh In dt.tbLoaiSanPhams
                         Where (dt.f_nosymbol(kh.TenLoaiSanPham).ToLower.Contains(key)) Or (dt.f_nosymbol(kh.MaLoaiSanPham).ToLower.Contains(key))
                         Order By kh.MaLoaiSanPham
                         Select kh

        CtrlDGVLoaiSanPham1.gridControl.DataSource = rlsLoaiSanPham
        CtrlDGVLoaiSanPham1.gridViewData.RefreshData()

    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        undoChange()
        CapNhat()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        CapNhat()
    End Sub

    Private Sub ctrlThemXoaSuaLoaiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLoad = True
        CapNhat()
        CtrlDGVLoaiSanPham1.colChon.Visible = False
    End Sub

    Private Sub CapNhat()
        CtrlDGVLoaiSanPham1.gridControl.DataSource = From nv In dt.tbLoaiSanPhams Select nv
                                                     Order By nv.MaLoaiSanPham

        CtrlDGVLoaiSanPham1.gridViewData.RefreshData()

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If CtrlDGVLoaiSanPham1.gridViewData.FocusedRowHandle > 0 Then
            Dim LoaiSanPham As tbLoaiSanPham = CtrlDGVLoaiSanPham1.gridViewData.GetRow(CtrlDGVLoaiSanPham1.gridViewData.FocusedRowHandle)
            Dim frm As New frmSuaLoaiSanPham
            frm.MaLoaiBanDau = LoaiSanPham.MaLoaiSanPham
            frm.LoaiSanPham = LoaiSanPham
            AddHandler frm.SuaThanhCongLoaiSanPham, AddressOf CapNhat
            frm.ShowDialog()
        End If
    End Sub
End Class
