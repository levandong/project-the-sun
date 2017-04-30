Public Class ctrlThemSuaXoaNganHangUyNhiemChi
    Public KhachHang As tbKhachHang
    Public lstNganHangUyNhiemChi As New List(Of tbNganHangUyNhiemChi)
    Private Sub CapNhat()
        If dt Is Nothing Then Exit Sub
        TbNganHangUyNhiemChiBindingSource.DataSource = From itm In lstNganHangUyNhiemChi
                                                       Select itm
    End Sub

    Private Sub ctrlThemSuaXoaNganHangUyNhiemChi_Load(sender As Object, e As EventArgs) Handles Me.Load
        If dt Is Nothing Then Exit Sub
        CapNhat()
    End Sub

    Public Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemNganHangUyNhiemChi
        frm.KhachHang = KhachHang
        AddHandler frm.ThemNganHangUyNhiemChiThanhCong, AddressOf ThemNganHangUyNhiemChiThanhCongXong
        frm.ShowDialog()
    End Sub

    Private Sub ThemNganHangUyNhiemChiThanhCongXong(NganHangUyNhiemChi As tbNganHangUyNhiemChi)
        lstNganHangUyNhiemChi.Add(NganHangUyNhiemChi)
        CapNhat()
    End Sub

    Public Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If TbNganHangUyNhiemChiBindingSource.Current IsNot Nothing Then
            Dim SuaNganHangUyNhiemChi As tbNganHangUyNhiemChi = TbNganHangUyNhiemChiBindingSource.Current
            Dim frm As New frmSuaNganHangUyNhiemChi
            frm.SuaNganHangUyNhiemChi = SuaNganHangUyNhiemChi
            AddHandler frm.SuaThanhCongNganHangUyNhiemChi, AddressOf SuaNganHangUyNhiemChiThanhCong
            If frm.ShowDialog = DialogResult.OK Then
                CapNhat()
            End If
        Else
            ThongBao("Vui lòng chọn một Ngân hàng ủy nhiệm chi để sửa")
        End If
    End Sub
    Private Sub SuaNganHangUyNhiemChiThanhCong(NganHangUyNhiemChi As tbNganHangUyNhiemChi)

    End Sub
    Public Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If TbNganHangUyNhiemChiBindingSource.Current IsNot Nothing Then
            Dim XoaNganHangUyNhiemChi As tbNganHangUyNhiemChi = TbNganHangUyNhiemChiBindingSource.Current
            If XacNhanYesNo("Bạn muốn xoá Ngân hàng ủy nhiệm chi '" + XoaNganHangUyNhiemChi.ToString + "'?. Chỉ xoá được khi Ngân hàng ủy nhiệm chi không có dữ liệu liên quan.") = MsgBoxResult.Yes Then
                Try
                    lstNganHangUyNhiemChi.Remove(XoaNganHangUyNhiemChi)
                    CapNhat()
                Catch ex As Exception
                    ThongBaoErrorVoiException("Không xoá được Ngân hàng ủy nhiệm chi", ex)
                End Try
            End If
        Else
            ThongBao("Vui lòng chọn một Ngân hàng ủy nhiệm chi để xoá")
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs)
        CapNhat()
    End Sub


    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

End Class