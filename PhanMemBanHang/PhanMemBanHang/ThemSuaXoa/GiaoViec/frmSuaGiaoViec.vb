Public Class frmSuaGiaoViec
    ' SuaGiaoViec
    Private _SuaGiaoViec As tbGiaoViec
    Property SuaGiaoViec As tbGiaoViec
        Get
            Return _SuaGiaoViec
        End Get
        Set(value As tbGiaoViec)
            _SuaGiaoViec = value
            If SuaGiaoViec IsNot Nothing Then
                CapNhat()
            End If
        End Set
    End Property
    Private Sub CapNhat()
        With SuaGiaoViec
            ' Lấy giá trị
            rtxtNoiDung.Text = .NoiDung
            rtxtGhiChu.Text = .GhiChu
            CapNhatKhachHang()
            cmbKhachHang.SelectedItem = .tbKhachHang
            CapNhatNhanVien()
            cmbNhanVien.SelectedItem = .tbNhanVien
            cmbDoUuTien.SelectedIndex = .DoUuTien - 1
            dtpNgayHoanThanh.Value = .NgayHoanThanh
        End With
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Điều kiện
        If rtxtNoiDung.Text.Trim = "" Then
            ThongBao("Vui lòng nhập Nội dung")
            rtxtNoiDung.Focus()
            Exit Sub
        End If
        If cmbNhanVien.SelectedItem Is Nothing Then
            ThongBao("Vui lòng chọn Nhân viên")
            cmbNhanVien.Focus()
            Exit Sub
        End If



        ' Gán giá trị
        With SuaGiaoViec
            .NoiDung = rtxtNoiDung.Text.Trim
            .GhiChu = rtxtGhiChu.Text.Trim
            .tbKhachHang = cmbKhachHang.SelectedItem
            .tbNhanVien = cmbNhanVien.SelectedItem
            .DoUuTien = cmbDoUuTien.SelectedItem - 1
            .NgayHoanThanh = dtpNgayHoanThanh.Value
        End With

        ' Submitchange
        Try
            dt.SubmitChanges()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            undoChange()
            ThongBaoErrorVoiException("Không sửa được Giao việc", ex)
        End Try
    End Sub


#Region "Form Handles"
    Private Sub frmSuaGiaoViec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub frmSuaGiaoViec_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnSua_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region
    Dim isKhachHang = True
#Region "Dữ liệu combobox"
    Private Sub CapNhatKhachHang()
        cmbKhachHang.DataSource = From itm In dt.tbKhachHangs
                                  Select itm
    End Sub

    Private Sub btnThemKhachHang_Click(sender As Object, e As EventArgs)
        Dim frm As New frmThemKhachHang
        frm.ThemXongDong = True
        AddHandler frm.ThemKhachHangThanhCong, AddressOf ThemKhachHangThanhCongXong
        frm.ShowDialog()
    End Sub
    Private Sub ThemKhachHangThanhCongXong(KhachHang As tbKhachHang)
        CapNhatKhachHang()
        cmbKhachHang.SelectedItem = KhachHang
    End Sub

    Private Sub CapNhatNhanVien()
        cmbNhanVien.DataSource = From itm In dt.tbNhanViens
                                 Select itm
    End Sub
    Private Sub ThemNhanVienThanhCongXong(NhanVien As tbNhanVien)
        CapNhatNhanVien()
        cmbNhanVien.SelectedItem = NhanVien
    End Sub


#End Region
#Region "Không đặt ngày"
    Private Sub btnKhongDatKhachHang_Click(sender As Object, e As EventArgs) Handles btnKhongDatKhachHang.Click
        cmbKhachHang.SelectedItem = Nothing
    End Sub

#End Region

    Public Sub btnTimKiemKhachHang_Click(sender As Object, e As EventArgs) Handles btnTimKiemKhachHang.Click
        Dim frm As New frmTimKiemKhachHang
        AddHandler frm.ChonKhachHangThanhCong, AddressOf ChonKhachHang
        frm.ShowDialog()
    End Sub

    Private Sub ChonKhachHang(khachHang As tbKhachHang)
        cmbKhachHang.DataSource = From itm In dt.tbKhachHangs
                                  Where itm.id = khachHang.id
    End Sub
End Class