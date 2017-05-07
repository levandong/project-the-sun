Public Class ctrlThemSuaXoaLoaiPhieuThu

    Private Sub CapNhat(key As String)
        If dt Is Nothing Then Exit Sub
        If key = "" Then
            gridControl.DataSource = From itm In dt.tbLoaiPhieuThus
                                     Select itm
                                     Order By itm.id Descending
        Else
            ' code tìm kiếm ở đây
            gridControl.DataSource = From itm In dt.tbLoaiPhieuThus
                                     Where itm.LoaiThu.ToLower.Contains(key) Or dt.f_nosymbol(itm.MoTa).ToLower.Contains(key)
                                     Select itm
                                     Order By itm.id Descending
        End If
    End Sub

    Private Sub ctrlThemSuaXoaLoaiPhieuThu_Load(sender As Object, e As EventArgs) Handles Me.Load
        CapNhat("")
    End Sub
	
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemLoaiPhieuThu
        AddHandler frm.ThemLoaiPhieuThuThanhCong, AddressOf ThemLoaiPhieuThuThanhCongXong
        frm.ShowDialog()
    End Sub
	
    Private Sub ThemLoaiPhieuThuThanhCongXong(LoaiPhieuThu As tbLoaiPhieuThu)
        CapNhat("")
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim SuaLoaiPhieuThu As tbLoaiPhieuThu = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            Dim frm As New frmSuaLoaiPhieuThu
            frm.SuaLoaiPhieuThu = SuaLoaiPhieuThu
            If frm.ShowDialog = DialogResult.OK Then
                CapNhat("")
            End If
        Else
            ThongBao("Vui lòng chọn một Loại Phiếu Thu để sửa")
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim XoaLoaiPhieuThu As tbLoaiPhieuThu = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            If XacNhanYesNo("Bạn muốn xoá Loại Phiếu Thu '" + XoaLoaiPhieuThu.ToString + "'?. Chỉ xoá được khi Loại Phiếu Thu không có dữ liệu liên quan.") = MsgBoxResult.Yes Then
                Try
                    dt.tbLoaiPhieuThus.DeleteOnSubmit(XoaLoaiPhieuThu)
                    dt.SubmitChanges()
                    CapNhat("")
                Catch ex As Exception
                    undoChange()
                    ThongBaoErrorVoiException("Không xoá được Loại Phiếu Thu", ex)
                End Try
             End If
        Else
            ThongBao("Vui lòng chọn một Loại Phiếu Thu để xoá")
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        CapNhat("")
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim key = BoDauTiengViet(txtTuKhoa.Text.Trim).ToLower
        CapNhat(key)
    End Sub

    Private Sub txtTuKhoa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTuKhoa.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTimKiem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub gridViewData_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridViewData.CustomDrawRowIndicator
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
End Class