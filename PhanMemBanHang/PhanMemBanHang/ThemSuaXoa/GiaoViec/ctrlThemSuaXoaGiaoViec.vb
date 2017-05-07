Public Class ctrlThemSuaXoaGiaoViec

    Private Sub CapNhat(key As String)
        If dt Is Nothing Then Exit Sub
        If key = "" Then
            TbGiaoViecBindingSource.DataSource = From itm In dt.tbGiaoViecs
                                                 Where itm.idNhanVienLap = loginNhanVien.id Or itm.idNhanVien = loginNhanVien.id
                                                 Select itm
                                                 Order By itm.id Descending
        Else
            ' code tìm kiếm ở đây
            ' TbGiaoViecBindingSource.DataSource = From itm In dt.tbGiaoViecs
            '                                 where itm.***.ToLower.Contains(key) Or dt.f_nosymbol(itm.***).ToLower.Contains(key)
            'Select itm
            'Order By itm.id Descending
        End If
        lblSoLuong.Text = TbGiaoViecBindingSource.Count.ToString + " Giao việc"
    End Sub
	
    Private Sub ctrlThemSuaXoaGiaoViec_Load(sender As Object, e As EventArgs) Handles Me.Load
        CapNhat("")
    End Sub

    Public Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemGiaoViec
        AddHandler frm.ThemGiaoViecThanhCong, AddressOf ThemGiaoViecThanhCongXong
        frm.ShowDialog()
    End Sub

    Private Sub ThemGiaoViecThanhCongXong(GiaoViec As tbGiaoViec)
        CapNhat("")
    End Sub

    Public Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If TbGiaoViecBindingSource.Current IsNot Nothing Then
            Dim SuaGiaoViec As tbGiaoViec = TbGiaoViecBindingSource.Current
            If SuaGiaoViec.TrangThai = 2 Then
                ThongBaoInfo("Đã nhận việc không thể sửa")
            End If
            If loginNhanVien.id <> SuaGiaoViec.idNhanVienLap Or loginNhanVien.CapBat < 2 Then
                ThongBaoInfo("Bạn không phải là người lập phiếu hoặc quyền hạn không đủ")
                Exit Sub
            End If
            Dim frm As New frmSuaGiaoViec
            frm.SuaGiaoViec = SuaGiaoViec
            If frm.ShowDialog = DialogResult.OK Then
                CapNhat("")
            End If
        Else
            ThongBao("Vui lòng chọn một Giao việc để sửa")
        End If
    End Sub

    Public Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If TbGiaoViecBindingSource.Current IsNot Nothing Then
            Dim XoaGiaoViec As tbGiaoViec = TbGiaoViecBindingSource.Current
            If loginNhanVien.id <> XoaGiaoViec.idNhanVienLap Or loginNhanVien.CapBat < 2 Then
                ThongBaoInfo("Bạn không phải là người lập phiếu hoặc quyền hạn không đủ")
                Exit Sub
            End If
            If XacNhanYesNo("Bạn muốn xoá Giao việc '" + XoaGiaoViec.ToString + "'?. Chỉ xoá được khi Giao việc không có dữ liệu liên quan.") = MsgBoxResult.Yes Then
                Try
                    dt.tbGiaoViecs.DeleteOnSubmit(XoaGiaoViec)
                    dt.SubmitChanges()
                    CapNhat("")
                Catch ex As Exception
                    undoChange()
                    ThongBaoErrorVoiException("Không xoá được Giao việc", ex)
                End Try
            End If
        Else
            ThongBao("Vui lòng chọn một Giao việc để xoá")
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

    Private Sub ĐangTiếnHànhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐangTiếnHànhToolStripMenuItem.Click
        If TbGiaoViecBindingSource.Current Is Nothing Then
            Exit Sub
        End If
        Dim idGiaoViec As Integer = TbGiaoViecBindingSource.Current.id
        Dim GiaoViec = dt.tbGiaoViecs.First(Function(s) s.id = idGiaoViec)
        dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, GiaoViec)
        GiaoViec.TrangThai = 2
        dt.SubmitChanges()
        CapNhat("")
    End Sub

    Private Sub ĐãHoànThànhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐãHoànThànhToolStripMenuItem.Click
        If TbGiaoViecBindingSource.Current Is Nothing Then
            Exit Sub
        End If
        Dim idGiaoViec As Integer = TbGiaoViecBindingSource.Current.id
        Dim GiaoViec = dt.tbGiaoViecs.First(Function(s) s.id = idGiaoViec)
        dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, GiaoViec)
        GiaoViec.TrangThai = 3
        dt.SubmitChanges()
        CapNhat("")
    End Sub
    Private Sub dgvMain_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMain.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Dim rowSelected As Integer = e.RowIndex
            If (e.RowIndex <> -1) Then
                Me.dgvMain.ClearSelection()
                Me.dgvMain.Rows(rowSelected).Selected = True
                TbGiaoViecBindingSource.Position = e.RowIndex
            End If
        End If
    End Sub
End Class