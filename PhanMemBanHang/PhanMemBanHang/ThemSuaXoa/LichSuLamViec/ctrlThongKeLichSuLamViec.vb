Public Class ctrlThongKeLichSuLamViec
    Private Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From itm In dt.tbNhanViens
                                 Order By itm.TenNhanVien
    End Sub

    Private Sub ctrlThongKeLichSuLamViec_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnCapNhatNhanVien_Click(Nothing, Nothing)
        CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value = Now.Date
        CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value = New DateTime(Now.Year, Now.Month, Now.Day, 23, 59, 0)
    End Sub
    Dim TuNgay, DenNgay As DateTime
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim idNV As Integer = 0
        TuNgay = CtrlTimKiemTheoThoiGian1.dtpTuLuc.Value
        DenNgay = CtrlTimKiemTheoThoiGian1.dtpToiLuc.Value

        If chkTheoNhanVien.Checked Then
            If cmbNhanVien.SelectedItem Is Nothing Then
                lblThongBao.Text = "[Chưa chọn nhân viên]"
                lblThongBao.Visible = True
                Exit Sub
            Else
                lblThongBao.Visible = False
                idNV = cmbNhanVien.SelectedItem.id
            End If
        End If

        Dim key As String = mdlGlobals.BoDauTiengViet(txtTuKhoa.Text.Trim)

        bsLichSu.DataSource = From itm In dt.tbLichSuCongViecs
                              Where itm.NgayThayDoi >= TuNgay And itm.NgayThayDoi <= DenNgay
                              Where itm.NoiDungString.Contains(key)
                              Where (Not chkTheoNhanVien.Checked) Or (chkTheoNhanVien.Checked And itm.idNhanvien = idNV)
                              Order By itm.NgayThayDoi


    End Sub
    Private Sub dgvMain_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMain.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Dim rowSelected As Integer = e.RowIndex
            If (e.RowIndex <> -1) Then
                Me.dgvMain.ClearSelection()
                Me.dgvMain.Rows(rowSelected).Selected = True
                bsLichSu.Position = e.RowIndex
            End If
        End If
    End Sub
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub XóaDòngLịchSửToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnXoaLichSu.Click
        If bsLichSu.Current IsNot Nothing Then
            Dim LichSu As tbLichSuCongViec = bsLichSu.Current
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa dòng lịch sử của " + LichSu.tbNhanVien.TenDangNhap + " lúc: " + LichSu.NgayThayDoi.ToString("dd/MM/yyyy HH:mm:ss") + "?",
                                                                       "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dt.tbLichSuCongViecs.DeleteOnSubmit(LichSu)
                Try
                    dt.SubmitChanges()
                    btnTimKiem_Click(Nothing, Nothing)
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xóa lịch sử thất bại!" + vbNewLine + "Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub XóaTấtCảLịchSửToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnXoaTatCa.Click
        If bsLichSu.Count > 0 Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa tất cả dòng lịch sử?",
                                                                       "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                bsLichSu.Clear()
                Try
                    dt.SubmitChanges()
                    btnTimKiem_Click(Nothing, Nothing)
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xóa lịch sử thất bại!" + vbNewLine + "Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub XemChiTiếtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnXemChiTiet.Click
        If bsLichSu.Current IsNot Nothing Then
        End If
    End Sub

    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        XemChiTiếtToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub chkTheoNhanVien_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheoNhanVien.CheckedChanged
        cmbNhanVien.Enabled = chkTheoNhanVien.Checked
    End Sub

    Private Sub txtTuKhoa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTuKhoa.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTimKiem_Click(Nothing, Nothing)
        End If
    End Sub
End Class
