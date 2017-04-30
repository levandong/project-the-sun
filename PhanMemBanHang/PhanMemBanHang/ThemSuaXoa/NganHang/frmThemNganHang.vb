Public Class frmThemNganHang
    Private _ThemXongDong As Boolean
    Property ThemXongDong As Boolean
        Get
            Return _ThemXongDong
        End Get
        Set(value As Boolean)
            _ThemXongDong = value
        End Set
    End Property
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
    Dim i As Integer = 0
    Private Sub dtpNgayNiemYet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpNgayNhap.KeyPress
        i += 1
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
        If i = 2 Then
            SendKeys.Send("{DIVIDE}")
            i = -1
        End If
    End Sub
    Sub CapNhatLoaiNganHang()
        cmbLoaiNganHang.DataSource = From itm In dt.tbLoaiNganHangs
                                     Order By itm.Loai
    End Sub
    Private Sub txtRDLC_Enter(sender As Object, e As EventArgs) Handles txtRDLC.Enter
        btnChonDuongDan_Click(Nothing, Nothing)
    End Sub
    Event ThemNganHangThanhCong(NganHang As tbNganHang)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Điều kiện
        If txtTenNganHang.Text.Trim = "" Then
            ThongBao("Vui lòng nhập Tên Ngân Hàng")
            txtTenNganHang.Focus()
            Exit Sub
        End If

        ' Gán thuộc tính
        Dim newNganHang = New tbNganHang
        With newNganHang
            .TenTaiKhoan = txtTenTaiKhoan.Text.Trim
            .TenNganHang = txtTenNganHang.Text.Trim
            .SoTaiKhoan = txtSoTaiKhoan.Text.Trim
            .ChiNhanh = txtChiNhanh.Text.Trim
            .GhiChu = txtGhiChu.Text.Trim
            .MaNganHang = txtMaNganHang.Text.Trim
            .SoDuDauKy = nudSoDuDauKy.Value
            .DuongDanAnh = pctLogo.Tag
            .DuongDanFileReport = txtRDLC.Text
            .ChieuDaiNoiDung = vndNoiDung.Value
            .ChieuDaiTienChu = vndTienChu.Value
            .DiaChi = txtDiaChi.Text
            .DienThoai = txtSoDienThoai.Text
            .TenChuTaiKhoan = txtTenChuTaiKhoan.Text
            .LoaiNganHang = CType(cmbLoaiNganHang.SelectedItem, tbLoaiNganHang).Loai
            .isTienMat = False
            .NgayNhap = dtpNgayNhap.Value
        End With

        ' Submitchange0
        Try
            dt.tbNganHangs.InsertOnSubmit(newNganHang)
            dt.SubmitChanges()
            RaiseEvent ThemNganHangThanhCong(newNganHang)
            If ThemXongDong Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                ' Sau khi thêm
            End If
        Catch ex As Exception
            undoChange()
            ThongBaoErrorVoiException("Không thêm được Ngân hàng", ex)
        End Try
    End Sub
#Region "Form Handles"
    Private Sub frmThemLau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtTenNganHang.Focus()
        CapNhatLoaiNganHang()
        vndNoiDung.Value = 350
        vndTienChu.Value = 250
    End Sub

    Private Sub frmThemLau_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            Me.Close()
        End If
    End Sub

    Private Sub txtTenNganHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenNganHang.KeyPress, txtSoTaiKhoan.KeyPress, txtMaNganHang.KeyPress, txtGhiChu.KeyPress, txtChiNhanh.KeyPress, nudSoDuDauKy.KeyPress, txtDiaChi.KeyPress, txtTenChuTaiKhoan.KeyPress, txtSoDienThoai.KeyPress, cmbLoaiNganHang.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region
#Region "Dữ liệu combobox"

#End Region
#Region "Không đặt ngày"

#End Region
End Class
