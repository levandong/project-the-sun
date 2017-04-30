Public Class frmThemLoaiPhieuNhap
    Event ThemLoaiPhieuNhapThanhCong(LoaiPhieuNhap As tbLoaiPhieuNhap)
    Private newLoaiPhieuNhap As New tbLoaiPhieuNhap

    Private Sub frmThemLoaiPhieuNhap_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        txtLoaiPhieuNhap.Focus()
    End Sub

    Private Sub frmThemLoaiPhieuNhap_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        undoChange()
    End Sub

    Private Sub frmThemLoaiPhieuNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtLoaiPhieuNhap.Focus()
        If txtLoaiPhieuNhap.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng nhập loại phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If dt.tbLoaiPhieuNhaps.Where(Function(s) s.LoaiPhieuNhap = txtLoaiPhieuNhap.Text.Trim).Count > 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Loại phiếu nhập " + txtLoaiPhieuNhap.Text.Trim + " đã có.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        With newLoaiPhieuNhap
            .LoaiPhieuNhap = txtLoaiPhieuNhap.Text.Trim
            .MoTa = txtGhiChu.Text.Trim
        End With
        ' thêm sản phẩm vào dánh sách sản phẩm
        dt.tbLoaiPhieuNhaps.InsertOnSubmit(newLoaiPhieuNhap)
        Try
            dt.SubmitChanges()
            RaiseEvent ThemLoaiPhieuNhapThanhCong(newLoaiPhieuNhap)
        Catch ex As Exception
            undoChange()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Thêm loại phiếu nhập thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

        If chkCopyLoaiPhieuNhap.Checked = False Then
            txtGhiChu.Clear()
            txtLoaiPhieuNhap.Clear()
        End If

        newLoaiPhieuNhap = New tbLoaiPhieuNhap

        txtLoaiPhieuNhap.Focus()
        txtLoaiPhieuNhap.SelectAll()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class