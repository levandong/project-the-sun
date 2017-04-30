Public Class frmSuaLoaiPhieuThu
    ' SuaLoaiPhieuThu
    Private _SuaLoaiPhieuThu As tbLoaiPhieuThu
    Property SuaLoaiPhieuThu As tbLoaiPhieuThu
        Get
            Return _SuaLoaiPhieuThu
        End Get
        Set(value As tbLoaiPhieuThu)
            _SuaLoaiPhieuThu = value
            If SuaLoaiPhieuThu IsNot Nothing Then
                CapNhat()
            End If
        End Set
    End Property
    Private Sub CapNhat()
        With SuaLoaiPhieuThu
            ' Lấy giá trị
            txtLoaiThu.Text = .LoaiThu
            txtMoTa.Text = .MoTa
        End With
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Điều kiện
        If txtLoaiThu.Text.Trim = "" Then
            ThongBao("Vui lòng nhập Tên Loại Thu")
            txtLoaiThu.Focus()
            Exit Sub
        End If



        ' Gán giá trị
        With SuaLoaiPhieuThu
            .LoaiThu = txtLoaiThu.Text.Trim
            .MoTa = txtMoTa.Text.Trim
        End With

        ' Submitchange
        Try
            dt.SubmitChanges()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            undoChange()
            ThongBaoErrorVoiException("Không sửa được Loại Phiếu Thu", ex)
        End Try
    End Sub


#Region "Form Handles"
    Private Sub frmSuaLoaiPhieuThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub frmSuaLoaiPhieuThu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnSua_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub txtLoaiPhieuNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoaiThu.KeyPress
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
