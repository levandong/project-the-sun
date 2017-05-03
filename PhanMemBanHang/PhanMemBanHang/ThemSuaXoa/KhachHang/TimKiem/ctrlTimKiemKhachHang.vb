Public Class ctrlTimKiemKhachHang
    Event ChonKhachHangThanhCong(KhachHang As tbKhachHang)
    Private _isNhaCungCap As Integer
    Property isNhaCungCap As Integer
        Get
            Return _isNhaCungCap
        End Get
        Set(value As Integer)
            _isNhaCungCap = value

        End Set
    End Property
    Private Sub ctrlTimKiemKhachHang_Load(sender As Object, e As EventArgs) Handles Me.Load
        'With CtrlDGVKhachHang1
        '    .btnIn.Visible = False
        '    .CongNoDauKy.Visible = False
        '    .CongNoMax.Visible = False
        'End With
        TimKiemKhachHang(isNhaCungCap)
        Timer1.Interval = My.Settings.ThoiGianTimKiemCham
    End Sub

    Private Sub TimKiemKhachHang(Loai As Integer)
        ' 0 - KH/NCC  1 - KH 2 - NCC
        Dim key As String = mdlGlobals.BoDauTiengViet(txtSearch.GetText.Trim.ToLower)
        Dim rlsKhachHang

        If key = "" Then
            rlsKhachHang = (From itm In dt.vwKhachHangs
                            Where ((Loai = 0) Or ((Loai = 1) And ((itm.isNhaCungCap = False) Or (itm.isNhaCungCap Is Nothing))) Or ((Loai = 2) And ((itm.isNhaCungCap = True) Or (itm.isNhaCungCap Is Nothing))))
                            Select itm Order By itm.TenKhachHang).Take(My.Settings.SoDongTimKiem)
        Else
            rlsKhachHang = (From kh In dt.vwKhachHangs
                            Where kh.TenKhachHangString.Contains(key) Or dt.f_nosymbol(kh.MaKhachHang).Contains(key) _
                            Or kh.SoDienThoai.Contains(key) Or (dt.f_nosymbol(kh.DiaChi).Contains(key))
                            Select kh).Take(My.Settings.SoDongTimKiem)
        End If
        CtrlDGVKhachHang1.gridControl.DataSource = rlsKhachHang
        CtrlDGVKhachHang1.gridViewData.RefreshData()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChon_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Down Then
            If CtrlDGVKhachHang1.gridViewData.FocusedRowHandle = CtrlDGVKhachHang1.gridViewData.DataRowCount - 1 Then
                CtrlDGVKhachHang1.gridViewData.FocusedRowHandle = 0
            Else
                CtrlDGVKhachHang1.gridViewData.FocusedRowHandle += 1
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If CtrlDGVKhachHang1.gridViewData.FocusedRowHandle = 0 Then
                CtrlDGVKhachHang1.gridViewData.FocusedRowHandle = CtrlDGVKhachHang1.gridViewData.DataRowCount - 1
            Else
                CtrlDGVKhachHang1.gridViewData.FocusedRowHandle -= 1
            End If
        End If
    End Sub

    Private Sub btnChon_Click(sender As Object, e As EventArgs) Handles btnChon.Click
        If CtrlDGVKhachHang1.gridViewData.FocusedRowHandle > 0 Then
            Dim vKhachHang As vwKhachHang = CtrlDGVKhachHang1.gridViewData.GetRow(CtrlDGVKhachHang1.gridViewData.FocusedRowHandle)
            Dim Khachhang As tbKhachHang = dt.tbKhachHangs.First(Function(s) s.id = vKhachHang.id)
            RaiseEvent ChonKhachHangThanhCong(KhachHang)
        End If
    End Sub

    Public Sub ctmCapNhat_Click(sender As Object, e As EventArgs) Handles ctmCapNhat.Click
        TimKiemKhachHang(isNhaCungCap)
    End Sub

    Private Sub CtrlDGVKhachHang1_ChonKhachHang(nl As tbKhachHang) Handles CtrlDGVKhachHang1.ChonKhachHang
        btnChon_Click(Nothing, Nothing)
    End Sub


    Private Sub ctmThemKhachHangMoi_Click(sender As Object, e As EventArgs) Handles ctmThemKhachHangMoi.Click
        Dim frm As New frmThemKhachHang
        AddHandler frm.ThemKhachHangThanhCong, AddressOf CapNhat
        frm.ShowDialog()
    End Sub
    Sub CapNhat()
        TimKiemKhachHang(isNhaCungCap)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        TimKiemKhachHang(isNhaCungCap)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.GetText <> "" Then
            Timer1.Start()
        End If
    End Sub

    Private Sub ctmCauHinhTimKiem_Click(sender As Object, e As EventArgs) Handles ctmCauHinhTimKiem.Click
        Dim frm As New frmCauHinhTimKiemSanPham
        frm.nudDelay.Value = My.Settings.ThoiGianTimKiemCham
        frm.nudSoDong.Value = My.Settings.SoDongTimKiem
        If frm.ShowDialog = DialogResult.OK Then
            My.Settings.ThoiGianTimKiemCham = frm.nudDelay.Value
            My.Settings.SoDongTimKiem = frm.nudSoDong.Value
            My.Settings.Save()
            Timer1.Interval = frm.nudDelay.Value
        End If
    End Sub
End Class
