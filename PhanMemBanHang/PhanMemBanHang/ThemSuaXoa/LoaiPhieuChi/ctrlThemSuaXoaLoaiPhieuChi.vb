Public Class ctrlThemSuaXoaLoaiPhieuChi
    Private Sub ctrlThemSuaXoaLoaiPhieuNhap_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnLoaiTimKiem_ButtonClick(Nothing, Nothing)
    End Sub

    Public Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemLoaiPhieuChi
        AddHandler frm.ThemLoaiPhieuNhapThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub

    Public Sub CapNhat()
        btnLoaiTimKiem_ButtonClick(Nothing, Nothing)
    End Sub

    Private Sub btnCapNhat_Click() Handles btnCapNhat.Click
        CapNhat()
    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        If txtTimKiem.Text = "" Then
            btnLoaiTimKiem_ButtonClick(Nothing, Nothing)
        End If
    End Sub

    Dim rlsLoaiPhieuNhap As IQueryable(Of tbLoaiPhieuChi)
    Private Sub btnLoaiTimKiem_ButtonClick(sender As Object, e As EventArgs) Handles btnLoaiTimKiem.ButtonClick
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTimKiem.Text.Trim.ToLower)

        rlsLoaiPhieuNhap = From kh In dt.tbLoaiPhieuChis
                           Where (dt.f_nosymbol(kh.LoaiChi).ToLower.Contains(key))
                           Where kh.Loai > 0
                           Select kh

        CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuChi.DataSource = rlsLoaiPhieuNhap
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        undoChange()
        CapNhat()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuChi.Current IsNot Nothing Then
            Dim LoaiPhieuNhap As tbLoaiPhieuChi = CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuChi.Current
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa loại phiếu chi " + LoaiPhieuNhap.LoaiChi + "?",
                                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                                                   = MsgBoxResult.Yes Then
                dt.tbLoaiPhieuChis.DeleteOnSubmit(LoaiPhieuNhap)
                Try
                    dt.SubmitChanges()
                    btnLoaiTimKiem_ButtonClick(Nothing, Nothing)
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xóa loại phiếu chi đã phát sinh dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CapNhat()
                End Try

            End If
        End If
    End Sub

    Private Sub txtTimKiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimKiem.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLoaiTimKiem_ButtonClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuChi.Current IsNot Nothing Then
            Dim frm As New frmSuaLoaiPhieuChi
            frm.LoaiPhieuNhaoBanDau = CType(CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuChi.Current, tbLoaiPhieuChi).LoaiChi
            frm.LoaiPhieuNhap = CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuChi.Current
            AddHandler frm.SuaLoaiPhieuNhapThanhCong, AddressOf CapNhat
            frm.ShowDialog()
        End If
    End Sub
End Class
