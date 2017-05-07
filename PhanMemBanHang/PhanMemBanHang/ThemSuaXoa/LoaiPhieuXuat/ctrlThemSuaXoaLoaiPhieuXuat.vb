Public Class ctrlThemSuaXoaLoaiPhieuXuat
    Private Sub ctrlThemSuaXoaLoaiPhieuXuat_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnLoaiTimKiem_ButtonClick(Nothing, Nothing)
    End Sub

    Public Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmThemLoaiPhieuXuat
        AddHandler frm.ThemLoaiPhieuXuatThanhCong, AddressOf CapNhat
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

    Dim rlsLoaiPhieuXuat As IQueryable(Of tbLoaiPhieuXuat)
    Private Sub btnLoaiTimKiem_ButtonClick(sender As Object, e As EventArgs) Handles btnLoaiTimKiem.ButtonClick
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTimKiem.Text.Trim.ToLower)

        rlsLoaiPhieuXuat = From kh In dt.tbLoaiPhieuXuats
                        Where (dt.f_nosymbol(kh.LoaiPhieuXuat).ToLower.Contains(key))
                        Select kh

        CtrlDGVLoaiPhieuXuat1.bsLoaiPhieuXuat.DataSource = rlsLoaiPhieuXuat
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        undoChange()
        CapNhat()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If CtrlDGVLoaiPhieuXuat1.bsLoaiPhieuXuat.Current IsNot Nothing Then
            Dim LoaiPhieuXuat As tbLoaiPhieuXuat = CtrlDGVLoaiPhieuXuat1.bsLoaiPhieuXuat.Current
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xóa loại phiếu xuất " + LoaiPhieuXuat.LoaiPhieuXuat + "?", _
                                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                                                   = MsgBoxResult.Yes Then
                dt.tbLoaiPhieuXuats.DeleteOnSubmit(LoaiPhieuXuat)
                Try
                    dt.SubmitChanges()
                Catch ex As Exception
                    undoChange()
                    ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể xóa loại phiếu xuất đã phát sinh dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If CtrlDGVLoaiPhieuXuat1.bsLoaiPhieuXuat.Current IsNot Nothing Then
            Dim frm As New frmSuaLoaiPhieuXuat
            frm.LoaiPhieuXuatBanDau = CType(CtrlDGVLoaiPhieuXuat1.bsLoaiPhieuXuat.Current, tbLoaiPhieuXuat).LoaiPhieuXuat
            frm.LoaiPhieuXuat = CtrlDGVLoaiPhieuXuat1.bsLoaiPhieuXuat.Current
            AddHandler frm.SuaLoaiPhieuXuatThanhCong, AddressOf CapNhat
            frm.ShowDialog()
        End If
    End Sub
End Class
