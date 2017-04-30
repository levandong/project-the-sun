Public Class ctrlThemSuaXoaLoaiPhieuThu

    Private Sub CapNhat(key As String)
        If dt Is Nothing Then Exit Sub
        If key = "" Then
            TbLoaiPhieuThuBindingSource.DataSource = From itm In dt.tbLoaiPhieuThus
                                            Select itm
											Order By itm.id Descending
        Else
            ' code tìm kiếm ở đây
            TbLoaiPhieuThuBindingSource.DataSource = From itm In dt.tbLoaiPhieuThus
                                                     Where itm.LoaiThu.ToLower.Contains(key) Or dt.f_nosymbol(itm.MoTa).ToLower.Contains(key)
                                                     Select itm
                                                     Order By itm.id Descending
        End If
        lblSoLuong.Text = TbLoaiPhieuThuBindingSource.Count.ToString + " Loại Phiếu Thu"
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
        If TbLoaiPhieuThuBindingSource.Current IsNot Nothing Then
            Dim SuaLoaiPhieuThu As tbLoaiPhieuThu = TbLoaiPhieuThuBindingSource.Current
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
        If TbLoaiPhieuThuBindingSource.Current IsNot Nothing Then
            Dim XoaLoaiPhieuThu As tbLoaiPhieuThu = TbLoaiPhieuThuBindingSource.Current
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

  Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
  End Sub

End Class