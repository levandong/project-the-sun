Public Class ctrlThemSuaXoaNganHang

    Private Sub CapNhat(key As String)
        If key = "" Then
            gridControl.DataSource = From itm In dt.tbNganHangs
                                     Select itm
            gridViewData.RefreshData()
        Else
            ' code tìm kiếm ở đây
            gridControl.DataSource = From itm In dt.tbNganHangs
                                     Where dt.f_nosymbol(itm.TenNganHang).ToLower.Contains(key) Or dt.f_nosymbol(itm.SoTaiKhoan).ToLower.Contains(key)

            gridViewData.RefreshData()
        End If


    End Sub
    Private Sub ctrlThemSuaXoaNganHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        CapNhat("")
    End Sub
    Public Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemNganHang
        AddHandler frm.ThemNganHangThanhCong, AddressOf ThemNganHangThanhCongXong
        frm.ShowDialog()
    End Sub
    Private Sub ThemNganHangThanhCongXong(NganHang As tbNganHang)
        CapNhat("")
    End Sub

    Public Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If gridViewData.FocusedRowHandle > 0 Then
            Dim SuaNganHang As tbNganHang = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            Dim frm As New frmSuaNganHang
            frm.SuaNganHang = SuaNganHang
            frm.SoDuDauKyBanDau = SuaNganHang.SoDuDauKy
            If frm.ShowDialog = DialogResult.OK Then
                CapNhat("")
            End If
        Else
            ThongBao("Vui lòng chọn một Ngân hàng để sửa")
        End If
    End Sub

    Public Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If gridViewData.FocusedRowHandle > 0 Then
            Dim XoaNganHang As tbNganHang = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            If XacNhanYesNo("Bạn muốn xoá Ngân hàng '" + XoaNganHang.ToString() + "'?. Chỉ xoá được khi Ngân hàng không có dữ liệu liên quan.") = MsgBoxResult.Yes Then
                Try
                    dt.tbNganHangs.DeleteOnSubmit(XoaNganHang)
                    dt.SubmitChanges()
                    CapNhat("")
                Catch ex As Exception
                    undoChange()
                    ThongBaoErrorVoiException("Không xoá được Ngân hàng", ex)
                End Try
            End If
        Else
            ThongBao("Vui lòng chọn một Ngân hàng để xoá")
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