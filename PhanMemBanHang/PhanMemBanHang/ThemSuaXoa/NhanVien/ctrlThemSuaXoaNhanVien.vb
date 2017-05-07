Imports PhanMemBanHang

Public Class ctrlThemSuaXoaNhanVien
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
                Case "btnThemNhanVien"
                    PhanQuyenLenDoiTuong(btnThem, qc1.HinhThuc, TrangThai)
                Case "btnSuaNhanVien"
                    PhanQuyenLenDoiTuong(btnSua, qc1.HinhThuc, TrangThai)
                Case "btnXoaNhanVien"
                    PhanQuyenLenDoiTuong(btnXoa, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemNhanVien
        AddHandler frm.ThemThanhCongNhanVien, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If CtrlDGVNhanVien1.gridViewData.FocusedRowHandle >= 0 Then
            Dim NhanVien As tbNhanVien = CtrlDGVNhanVien1.gridViewData.GetRow(CtrlDGVNhanVien1.gridViewData.FocusedRowHandle)
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xoá tài khoản " + NhanVien.TenDangNhap + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                            = DialogResult.Yes Then

                dt.tbNhanViens.DeleteOnSubmit(NhanVien)
                Try
                    dt.SubmitChanges()
                    btnTimKiem_ButtonClick(Nothing, Nothing)
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xoá tài khoản này!" + vbNewLine +
                                                                            "Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim rlsNhanVien

        rlsNhanVien = From kh In dt.tbNhanViens
                      Where (dt.f_nosymbol(kh.TenNhanVien).ToLower.Contains(key)) Or (dt.f_nosymbol(kh.TenDangNhap).ToLower.Contains(key))
                      Order By kh.TenNhanVien
                      Select kh

        CtrlDGVNhanVien1.gridControl.DataSource = rlsNhanVien
        CtrlDGVNhanVien1.gridViewData.RefreshData()

    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        undoChange()
        CapNhat()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        CapNhat()
    End Sub

    Private Sub ctrlThemXoaSuaNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLoad = True
        CapNhat()
    End Sub

    Private Sub CapNhat()
        CtrlDGVNhanVien1.gridControl.DataSource = From nv In dt.tbNhanViens Select nv
                                                  Order By nv.TenNhanVien

        CtrlDGVNhanVien1.gridViewData.RefreshData()
    End Sub


    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If CtrlDGVNhanVien1.gridViewData.FocusedRowHandle >= 0 Then
            Dim frm As New frmSuaNhanVien
            Dim NhanVien As tbNhanVien = CtrlDGVNhanVien1.gridViewData.GetRow(CtrlDGVNhanVien1.gridViewData.FocusedRowHandle)
            frm.TenDangNhapBanDau = NhanVien.TenDangNhap
            frm.NhanVien = NhanVien
            AddHandler frm.SuaThanhCongNhanVien, AddressOf CapNhat
            frm.ShowDialog()
        End If
    End Sub

    Private Sub CtrlDGVNhanVien1_ChonNhanVien(nhanVien As tbNhanVien) Handles CtrlDGVNhanVien1.ChonNhanVien
        If btnSua.Enabled Then
            btnSua_Click(Nothing, Nothing)
        End If
    End Sub
End Class
