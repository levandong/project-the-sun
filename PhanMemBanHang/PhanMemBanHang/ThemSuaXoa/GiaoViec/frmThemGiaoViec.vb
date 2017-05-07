Public Class frmThemGiaoViec
    Private _ThemXongDong As Boolean
    Property ThemXongDong As Boolean
        Get
            Return _ThemXongDong
        End Get
        Set(value As Boolean)
            _ThemXongDong = value
        End Set
    End Property
    Event ThemGiaoViecThanhCong(GiaoViec As tbGiaoViec)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
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


        'Gán thuộc tính
        Dim newGiaoViec = New tbGiaoViec
        With NewGiaoViec
            .NoiDung = rtxtNoiDung.Text.Trim
            .GhiChu = rtxtGhiChu.Text.Trim
            If cmbKhachHang.SelectedItem IsNot Nothing Then
                .idKhachHang = cmbKhachHang.SelectedItem.id
            End If
            .DoUuTien = cmbDoUuTien.SelectedIndex + 1
            .idNhanVien = cmbNhanVien.SelectedItem.id
            .NgayHoanThanh = dtpNgayHoanThanh.Value
            .idNhanVienLap = loginNhanVien.id
            .TrangThai = 1
        End With
        ' Submitchange
        Try
            dt.tbGiaoViecs.InsertOnSubmit(NewGiaoViec)
            dt.SubmitChanges()
            RaiseEvent ThemGiaoViecThanhCong(NewGiaoViec)
            If ThemXongDong Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                ' Sau khi thêm
            End If
        Catch ex As Exception
            undoChange()
            ThongBaoErrorVoiException("Không thêm được Giao việc", ex)
        End Try
    End Sub

#Region "Form Handles"
    Private Sub frmThemLau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        'Load Combobox
        CapNhatKhachHang()
        CapNhatNhanVien()
        btnKhongDatKhachHang_Click(Nothing, Nothing)
        cmbDoUuTien.SelectedIndex = 1
    End Sub

    Private Sub frmThemLau_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

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
    Dim isKhachHang = True

    Public Sub btnTimKiemKhachHang_Click(sender As Object, e As EventArgs) Handles btnTimKiemKhachHang.Click
        Dim frm As New frmTimKiemKhachHang
        AddHandler frm.ChonKhachHangThanhCong, AddressOf ChonKhachHang
        frm.ShowDialog()
    End Sub

    Private Sub ChonKhachHang(khachHang As tbKhachHang)
        cmbKhachHang.DataSource = From itm In dt.tbKhachHangs
                                  Where itm.id = khachHang.id
    End Sub
#Region "Không đặt ngày"
    Private Sub btnKhongDatKhachHang_Click(sender As Object, e As EventArgs) Handles btnKhongDatKhachHang.Click
        cmbKhachHang.SelectedItem = Nothing
    End Sub

#End Region
End Class
