Public Class ctrlThemSuaXoaReport
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
                Case "btnThemReport"
                    PhanQuyenLenDoiTuong(btnThem, qc1.HinhThuc, TrangThai)
                Case "btnSuaReport"
                    PhanQuyenLenDoiTuong(btnSua, qc1.HinhThuc, TrangThai)
                Case "btnXoaReport"
                    PhanQuyenLenDoiTuong(btnXoa, qc1.HinhThuc, TrangThai)
            End Select
        Next
    End Sub

    Private Sub ctrlThemSuaXoaReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        CapNhat()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemReport
        AddHandler frm.ThemReportThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Public Sub CapNhat()
        dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, dt.tbReports)
        CtrlDGVReport1.gridControl.DataSource = From sp In dt.tbReports Select sp
        CtrlDGVReport1.gridViewData.RefreshData()
    End Sub

    Private Sub btnCapNhat_Click() Handles btnCapNhat.Click
        CapNhat()
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        undoChange()
        CapNhat()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If CtrlDGVReport1.gridViewData.FocusedRowHandle >= 0 Then
            Dim BieuMau As tbReport = CtrlDGVReport1.gridViewData.GetRow(CtrlDGVReport1.gridViewData.FocusedRowHandle)

            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa mẫu report " + BieuMau.TenReport + "?", "Xác nhận", MessageBoxButtons.YesNo) _
                                                                   = MsgBoxResult.Yes Then
                dt.tbReports.DeleteOnSubmit(BieuMau)
                Try
                    dt.SubmitChanges()
                    btnCapNhat_Click(Nothing, Nothing)
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xóa biểu mẫu!" + vbNewLine + "Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    btnCapNhat_Click(Nothing, Nothing)
                End Try

            End If
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        CapNhat()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If CtrlDGVReport1.gridViewData.FocusedRowHandle >= 0 Then
            Dim BieuMau As tbReport = CtrlDGVReport1.gridViewData.GetRow(CtrlDGVReport1.gridViewData.FocusedRowHandle)
            Dim frm As New frmSuaReport
            frm.Report = BieuMau
            AddHandler frm.SuaReportThanhCong, AddressOf CapNhat
            frm.ShowDialog()
        End If
    End Sub
End Class
