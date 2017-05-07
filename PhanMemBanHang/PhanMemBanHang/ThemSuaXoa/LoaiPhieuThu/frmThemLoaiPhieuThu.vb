Public Class frmThemLoaiPhieuThu
    Private _ThemXongDong As Boolean
    Property ThemXongDong As Boolean
        Get
            Return _ThemXongDong
        End Get
        Set(value As Boolean)
            _ThemXongDong = value
        End Set
    End Property
    Event ThemLoaiPhieuThuThanhCong(LoaiPhieuThu As tbLoaiPhieuThu)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Điều kiện
        If txtLoaiThu.Text.Trim = "" Then
            ThongBao("Vui lòng nhập Tên Loại Thu")
            txtLoaiThu.Focus()
            Exit Sub
        End If


        'Gán thuộc tính
        Dim newLoaiPhieuThu = New tbLoaiPhieuThu
        With NewLoaiPhieuThu
            .LoaiThu = txtLoaiThu.Text.Trim
            .MoTa = rtxtMoTa.Text.Trim
            .Loai = 1
        End With
        ' Submitchange
        Try
            dt.tbLoaiPhieuThus.InsertOnSubmit(NewLoaiPhieuThu)
            dt.SubmitChanges()
            RaiseEvent ThemLoaiPhieuThuThanhCong(NewLoaiPhieuThu)
            If ThemXongDong Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                ' Sau khi thêm
            End If
            Me.Close()
        Catch ex As Exception
            undoChange()
            ThongBaoErrorVoiException("Không thêm được Loại Phiếu Thu", ex)
        End Try
    End Sub
#Region "Form Handles"
    Private Sub frmThemLau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        'Load Combobox

    End Sub

    Private Sub frmThemLau_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThem_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub txtLoaiPhieuNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoaiThu.KeyPress, rtxtMoTa.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then 'Hoặc Convert.ToChar(Keys.Enter)
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region

#Region "Dữ liệu combobox"

#End Region

#Region "Không đặt ngày"

#End Region
End Class