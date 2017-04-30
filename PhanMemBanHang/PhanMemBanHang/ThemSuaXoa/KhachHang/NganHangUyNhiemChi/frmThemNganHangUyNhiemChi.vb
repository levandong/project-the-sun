Public Class frmThemNganHangUyNhiemChi
    Private _ThemXongDong As Boolean
    Public KhachHang As tbKhachHang
    Property ThemXongDong As Boolean
        Get
            Return _ThemXongDong
        End Get
        Set(value As Boolean)
            _ThemXongDong = value
        End Set
    End Property
    Event ThemNganHangUyNhiemChiThanhCong(NganHangUyNhiemChi As tbNganHangUyNhiemChi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
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


        'Gán thuộc tính
        Dim newNganHangUyNhiemChi = New tbNganHangUyNhiemChi
        With NewNganHangUyNhiemChi
            .TenChuTaiKhoan = txtTenChuTaiKhoan.Text.Trim
            .SoTaiKhoan = txtSoTaiKhoan.Text.Trim
            .TenNganHang = txtTenNganHang.Text.Trim
            .ChiNhanh = txtChiNhanh.Text.Trim
            .Tinh = txtTinh.Text.Trim
        End With
        Try
            RaiseEvent ThemNganHangUyNhiemChiThanhCong(newNganHangUyNhiemChi)
            If ThemXongDong Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                ' Sau khi thêm
                Me.Close()
            End If
        Catch ex As Exception
            undoChange()
            ThongBaoErrorVoiException("Không thêm được Ngân hàng ủy nhiệm chi", ex)
        End Try
    End Sub

#Region "Form Handles"
    Private Sub frmThemLau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtTenChuTaiKhoan.Text = KhachHang.TenRutGon.Trim
    End Sub

    Private Sub frmThemLau_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtTenChuTaiKhoan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenChuTaiKhoan.KeyPress, txtSoTaiKhoan.KeyPress, txtTenNganHang.KeyPress, txtTinh.KeyPress, txtChiNhanh.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region

#Region "Không đặt ngày"

#End Region
End Class
