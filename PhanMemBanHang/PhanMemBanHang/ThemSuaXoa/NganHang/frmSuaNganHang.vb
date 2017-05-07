Public Class frmSuaNganHang
    ' SuaNganHang
    Public SoDuDauKyBanDau As Double
    Private _SuaNganHang As tbNganHang
    Property SuaNganHang As tbNganHang
        Get
            Return _SuaNganHang
        End Get
        Set(value As tbNganHang)
            _SuaNganHang = value
            If SuaNganHang IsNot Nothing Then
                CapNhat()
            End If
        End Set
    End Property
    Sub CapNhatLoaiNganHang()
        cmbLoaiNganHang.DataSource = From itm In dt.tbLoaiNganHangs
                                     Order By itm.Loai
    End Sub
    Private Sub CapNhat()
        CapNhatLoaiNganHang()
        With SuaNganHang
            ' Lấy giá trị
            txtTenTaiKhoan.Text = .TenTaiKhoan.Trim
            txtTenNganHang.Text = .TenNganHang.Trim
            txtSoTaiKhoan.Text = .SoTaiKhoan.Trim
            txtChiNhanh.Text = .ChiNhanh.Trim
            txtGhiChu.Text = .GhiChu
            txtMaNganHang.Text = .MaNganHang.Trim
            If Not String.IsNullOrEmpty(.DuongDanAnh) Then
                Try
                    pctLogo.Image = Image.FromFile(Application.StartupPath + .DuongDanAnh.Substring(1))
                Catch ex As Exception

                End Try
            End If
            nudSoDuDauKy.Value = .SoDuDauKy
            pctLogo.Tag = .DuongDanAnh
            txtRDLC.Text = .DuongDanFileReport
            vndNoiDung.Value = .ChieuDaiNoiDung
            vndTienChu.Value = .ChieuDaiTienChu
            dtpNgayNhap.Value = .NgayNhap
            If .DiaChi IsNot Nothing Then
                txtDiaChi.Text = .DiaChi
            End If
            txtSoDienThoai.Text = .DienThoai
            txtTenChuTaiKhoan.Text = .TenChuTaiKhoan
            cmbLoaiNganHang.SelectedItem = dt.tbLoaiNganHangs.Single(Function(S) S.Loai = .LoaiNganHang)
        End With
    End Sub
    Private Sub pctLogo_Click(sender As Object, e As EventArgs) Handles pctLogo.Click
        Dim openFile As New OpenFileDialog
        openFile.InitialDirectory = Application.StartupPath + "\LogoNganHang"
        openFile.Filter = "Image Files (*.png, *.jpg, *.bmp, *jpeg)|*.png;*.jpg;*.bmp;*.jpeg"
        If (openFile.ShowDialog) = DialogResult.OK Then
            pctLogo.Image = Image.FromFile(openFile.FileName)
            pctLogo.Tag = openFile.FileName
            SendKeys.Send("{TAB}")
            pctLogo.Tag = "." + openFile.FileName.Substring(Application.StartupPath.Length)
        End If

    End Sub
    Private Sub btnChonDuongDan_Click(sender As Object, e As EventArgs) Handles btnChonDuongDan.Click
        Dim openFile As New OpenFileDialog
        openFile.InitialDirectory = Application.StartupPath + "\Report"
        openFile.Filter = "Report files (*.rdlc)|*.rdlc"
        If (openFile.ShowDialog) = DialogResult.OK Then
            txtRDLC.Text = "." + openFile.FileName.Substring(Application.StartupPath.Length)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Điều kiện
        If txtTenNganHang.Text.Trim = "" Then
            ThongBao("Vui lòng nhập Tên Ngân Hàng")
            txtTenNganHang.Focus()
            Exit Sub
        End If
        ' Gán giá trị
        With SuaNganHang
            .TenTaiKhoan = txtTenTaiKhoan.Text
            .TenNganHang = txtTenNganHang.Text.Trim
            .SoTaiKhoan = txtSoTaiKhoan.Text.Trim
            .ChiNhanh = txtChiNhanh.Text.Trim
            .GhiChu = txtGhiChu.Text.Trim
            .MaNganHang = txtMaNganHang.Text.Trim
            .SoDuDauKy = nudSoDuDauKy.Value
            .DuongDanAnh = pctLogo.Tag
            .DuongDanFileReport = txtRDLC.Text
            .ChieuDaiTienChu = vndTienChu.Value
            .ChieuDaiNoiDung = vndNoiDung.Value
            .DiaChi = txtDiaChi.Text
            .TenChuTaiKhoan = txtTenChuTaiKhoan.Text
            .DienThoai = txtSoDienThoai.Text
            .LoaiNganHang = cmbLoaiNganHang.SelectedItem.Loai
            .NgayNhap = dtpNgayNhap.Value
        End With

        ' Submitchange
        Try
            dt.SubmitChanges()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            undoChange()
            ThongBaoErrorVoiException("Không sửa được NganHang_", ex)
        End Try
    End Sub


#Region "Form Handles"
    Private Sub frmSuaNganHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtTenNganHang.Focus()
    End Sub

    Private Sub frmSuaNganHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnSua_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtTenNganHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenNganHang.KeyPress, txtSoTaiKhoan.KeyPress, txtMaNganHang.KeyPress, txtGhiChu.KeyPress, txtChiNhanh.KeyPress, nudSoDuDauKy.KeyPress, txtTenChuTaiKhoan.KeyPress, txtSoDienThoai.KeyPress, txtDiaChi.KeyPress, txtTenTaiKhoan.KeyPress, cmbLoaiNganHang.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtRDLC_Enter(sender As Object, e As EventArgs) Handles txtRDLC.Enter
        btnChonDuongDan_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "Dữ liệu combobox"

#End Region
#Region "Không đặt ngày"

#End Region

End Class
