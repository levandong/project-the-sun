Public Class ctrlThemSuaXoaLoaiPhieuNhap
    Private Sub ctrlThemSuaXoaLoaiPhieuNhap_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnLoaiTimKiem_ButtonClick(Nothing, Nothing)
    End Sub

    Public Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemLoaiPhieuNhap
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

    Dim rlsLoaiPhieuNhap As IQueryable(Of tbLoaiPhieuNhap)
    Private Sub btnLoaiTimKiem_ButtonClick(sender As Object, e As EventArgs) Handles btnLoaiTimKiem.ButtonClick
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTimKiem.Text.Trim.ToLower)

        rlsLoaiPhieuNhap = From kh In dt.tbLoaiPhieuNhaps
                        Where (dt.f_nosymbol(kh.LoaiPhieuNhap).ToLower.Contains(key))
                        Select kh

        CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuNhap.DataSource = rlsLoaiPhieuNhap
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        undoChange()
        CapNhat()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuNhap.Current IsNot Nothing Then
            Dim LoaiPhieuNhap As tbLoaiPhieuNhap = CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuNhap.Current
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa loại phiếu nhập " + LoaiPhieuNhap.LoaiPhieuNhap + "?", _
                                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                                                   = MsgBoxResult.Yes Then
                dt.tbLoaiPhieuNhaps.DeleteOnSubmit(LoaiPhieuNhap)
                Try
                    dt.SubmitChanges()
                    btnLoaiTimKiem_ButtonClick(Nothing, Nothing)
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xóa loại phiếu nhập đã phát sinh dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuNhap.Current IsNot Nothing Then
            Dim frm As New frmSuaLoaiPhieuNhap
            frm.LoaiPhieuNhaoBanDau = CType(CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuNhap.Current, tbLoaiPhieuNhap).LoaiPhieuNhap
            frm.LoaiPhieuNhap = CtrlDGVLoaiPhieuNhap1.bsLoaiPhieuNhap.Current
            AddHandler frm.SuaLoaiPhieuNhapThanhCong, AddressOf CapNhat
            frm.ShowDialog()
        End If
    End Sub
End Class
