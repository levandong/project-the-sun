Public Class ctrlDangNhap

    Event DangNhapThanhCong()
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        If txtTaiKhoan.Text.Trim = "" Then
            txtTaiKhoan.Focus()
            txtTaiKhoan.StateCommon.Border.Color1 = Color.Red
            Exit Sub
        End If

        If txtMatKhau.Text.Trim = "" Then
            txtMatKhau.Focus()
            txtMatKhau.StateCommon.Border.Color1 = Color.Red
            Exit Sub
        End If

        Dim frm As New Tmt.Toolkit.ProgressingDialog
        frm.Animation = Tmt.Toolkit.ProgressingDialog.AnimationStyle.Waiting
        frm.Caption = "Đang đăng nhập..."
        frm.DialogStyle = Tmt.Toolkit.ProgressingDialog.ProgressingDialogStyle.ContinuingDialog
        frm.Show()


        Dim rls As IQueryable(Of tbNhanVien)
        Try
            ChuoiConnectString = mh.Decrypt(My.Settings.ThongTinKetNoi, "tmt6364")
            If dt Is Nothing Then
                dt = New dcQLDataContext(ChuoiConnectString)
            End If
            rls = From tk In dt.tbNhanViens Where tk.TenDangNhap = txtTaiKhoan.Text And
                      tk.MatKhau = txtMatKhau.Text Select tk
            If (rls.Count = 0) Then
                frm.Dismiss()
                ThongBao("Tên đăng nhập hoặc Mật khẩu không đúng!" + vbNewLine + "Vui lòng kiểm tra lại.")
                txtTaiKhoan.Focus()

                Exit Sub
            Else
                If rls.First.HopLe = False Then

                    ThongBao("Tài khoản " + rls.First.TenDangNhap + " đã bị khóa." + vbNewLine + "Vui lòng kiểm tra lại.")
                    txtTaiKhoan.Focus()
                    Exit Sub
                End If
                frm.Caption = "Đang đăng nhập..."
                loginNhanVien = rls.First

                ' Luu ten dang nhap, mat khau
                If chkLuuTaiKhoan.Checked Then
                    My.Settings.TaiKhoan = mh.Encrypt(txtTaiKhoan.Text.Trim, "tmt6364")
                    My.Settings.MatKhau = mh.Encrypt(txtMatKhau.Text.Trim, "tmt6364")
                Else
                    My.Settings.TaiKhoan = ""
                    My.Settings.MatKhau = ""
                    txtMatKhau.Text = ""
                    txtTaiKhoan.Text = ""
                End If
                My.Settings.Save()
                RaiseEvent DangNhapThanhCong()
            End If
        Catch ex As Exception
            frm.Dismiss()
            If XacNhanYesNo("Đăng nhập thất bại, Bạn có muốn cấu hình/ khởi tạo dữ liệu?" + vbNewLine + "Lỗi: " + ex.Message) Then
                Dim frmKetNoi As New frmKetNoiDatabase
                frmKetNoi.ShowDialog()
                dt = Nothing
            End If
            Exit Sub
        End Try


        Try
            CuaHang = dt.tbCuaHangs.First
            If CuaHang IsNot Nothing Then
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, CuaHang)
            End If
        Catch ex As Exception

        End Try

        frm.Dismiss()
    End Sub

    Private Sub txtTaiKhoan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTaiKhoan.KeyDown, txtMatKhau.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnDangNhap_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtMatKhau_LostFocus(sender As Object, e As EventArgs) Handles txtMatKhau.LostFocus
        txtMatKhau.Select(0, txtMatKhau.Text.Length)
    End Sub

    Private Sub txtTaiKhoan_LostFocus(sender As Object, e As EventArgs) Handles txtTaiKhoan.LostFocus
        txtTaiKhoan.Select(0, txtTaiKhoan.Text.Length)
    End Sub

    Private Sub ctrlDangNhap_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            txtMatKhau.Text = mh.Decrypt(My.Settings.MatKhau, "tmt6364")
            txtTaiKhoan.Text = mh.Decrypt(My.Settings.TaiKhoan, "tmt6364")
        Catch ex As Exception
            txtMatKhau.Text = ""
            txtTaiKhoan.Text = ""
        End Try

        If txtTaiKhoan.Text.Trim <> "" Then
            chkLuuTaiKhoan.Checked = True
        Else
            chkLuuTaiKhoan.Checked = False
        End If

        Try
            mdlGlobals.UpdatePhanMem(False)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTaiKhoan_TextChanged(sender As Object, e As EventArgs) Handles txtTaiKhoan.TextChanged
        If txtTaiKhoan.Text.Trim <> "" And txtTaiKhoan.StateCommon.Border.Color1 <> Nothing Then
            txtTaiKhoan.StateCommon.Border.Color1 = Nothing
        End If
    End Sub

    Private Sub txtMatKhau_TextChanged(sender As Object, e As EventArgs) Handles txtMatKhau.TextChanged
        If txtMatKhau.Text.Trim <> "" And txtMatKhau.StateCommon.Border.Color1 <> Nothing Then
            txtMatKhau.StateCommon.Border.Color1 = Nothing
        End If
    End Sub
End Class
