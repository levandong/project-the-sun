Public Class frmSuaNganHangUyNhiemChi
    Public KhachHang As tbKhachHang
    ' SuaNganHangUyNhiemChi
    Private _SuaNganHangUyNhiemChi As tbNganHangUyNhiemChi
    Property SuaNganHangUyNhiemChi As tbNganHangUyNhiemChi
        Get
            Return _SuaNganHangUyNhiemChi
        End Get
        Set(value As tbNganHangUyNhiemChi)
            _SuaNganHangUyNhiemChi = value
            If SuaNganHangUyNhiemChi IsNot Nothing Then
                CapNhat()
            End If
        End Set
    End Property
    Private Sub CapNhat()
        With SuaNganHangUyNhiemChi
            ' Lấy giá trị
            txtTenChuTaiKhoan.Text = .TenChuTaiKhoan
            txtSoTaiKhoan.Text = .SoTaiKhoan
            txtTenNganHang.Text = .TenNganHang
            KryptonTextBox1.Text = .ChiNhanh
            txtTinh.Text = .Tinh
        End With
    End Sub
    Event SuaThanhCongNganHangUyNhiemChi(NganHang As tbNganHangUyNhiemChi)
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Điều kiện
        If txtTenChuTaiKhoan.Text.Trim = "" Then
            ThongBao("Vui lòng nhập Tên chủ tài khoản")
            txtTenChuTaiKhoan.Focus()
            Exit Sub
        End If

        If txtSoTaiKhoan.Text.Trim = "" Then
            ThongBao("Vui lòng nhập Số tài khoản")
            txtSoTaiKhoan.Focus()
            Exit Sub
        End If

        If txtTenNganHang.Text.Trim = "" Then
            ThongBao("Vui lòng nhập Tên ngân hàng")
            txtTenNganHang.Focus()
            Exit Sub
        End If

        ' Gán giá trị
        With SuaNganHangUyNhiemChi
            .TenChuTaiKhoan = txtTenChuTaiKhoan.Text.Trim
            .SoTaiKhoan = txtSoTaiKhoan.Text.Trim
            .TenNganHang = txtTenNganHang.Text.Trim
            .ChiNhanh = KryptonTextBox1.Text.Trim
            .Tinh = txtTinh.Text.Trim
        End With

        ' Submitchange
        Try
            RaiseEvent SuaThanhCongNganHangUyNhiemChi(SuaNganHangUyNhiemChi)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            undoChange()
            ThongBaoErrorVoiException("Không sửa được Ngân hàng ủy nhiệm chi", ex)
        End Try
    End Sub


#Region "Form Handles"
    Private Sub frmSuaNganHangUyNhiemChi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub frmSuaNganHangUyNhiemChi_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnSua_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            Me.Close()
        End If
    End Sub
    Private Sub txtTenChuTaiKhoan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenChuTaiKhoan.KeyPress, txtSoTaiKhoan.KeyPress, txtTenNganHang.KeyPress, txtTinh.KeyPress, KryptonTextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region
#Region "Không đặt ngày"

#End Region

End Class