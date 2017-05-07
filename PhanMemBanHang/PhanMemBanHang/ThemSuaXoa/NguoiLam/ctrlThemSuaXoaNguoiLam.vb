Public Class ctrlThemSuaXoaNguoiLam
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

    Private Sub CapNhat(key As String)
        gridControl.DataSource = From itm In dt.tbNguoiLams
                                 Where (key = "") Or (itm.MaNguoiLamString.Contains(key) Or itm.TenNguoiLamString.Contains(key) _
                                    Or itm.CMND.Contains(key) Or itm.SoDienThoai.Contains(key))
                                 Order By itm.TenNguoiLam Select itm
        gridViewData.RefreshData()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemNguoiLam
        If frm.ShowDialog = DialogResult.OK Then
            CapNhat("")
        End If
    End Sub

    Private Sub ctrlThemSuaXoaNguoiLam_Load(sender As Object, e As EventArgs) Handles Me.Load
        CapNhat("")
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim NhanVien As tbNguoiLam = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            Dim frm As New frmSuaNguoiLam
            frm.NguoiLam = NhanVien
            If frm.ShowDialog = DialogResult.OK Then
                CapNhat("")
            End If
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim NhanVien As tbNguoiLam = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xoá nhân viên " + NhanVien.TenNguoiLam + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                            = DialogResult.Yes Then

                Try
                    dt.tbNguoiLams.DeleteOnSubmit(NhanVien)
                    dt.SubmitChanges()
                    CapNhat("")
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xoá nhân viên này!" + vbNewLine +
                                                                            "Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        undoChange()
        CapNhat("")
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        CapNhat("")
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTuKhoa.Text.Trim)
        CapNhat(key)
    End Sub

    Private Sub txtTuKhoa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTuKhoa.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTimKiem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles txtTuKhoa.TextChanged
        If txtTuKhoa.Text.Trim = "" Then
            CapNhat("")
        End If
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

    Private Sub mnuItemExportExcel_Click(sender As Object, e As EventArgs) Handles mnuItemExportExcel.Click
        If gridViewData.DataRowCount > 0 Then
            ExportExcelFromGridView(gridControl)
        End If
    End Sub
End Class
