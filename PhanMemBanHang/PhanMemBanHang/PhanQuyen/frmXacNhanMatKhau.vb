Public Class frmXacNhanMatKhau

    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        If txtMatKhau.Text.Trim = "truongminhthinh6364" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            lblThongBao.Visible = True
        End If
    End Sub

    Private XemMatKhau As Boolean = True
    Private Sub btnXemMatKhau_Click(sender As Object, e As EventArgs) Handles btnXemMatKhau.Click
        XemMatKhau = Not XemMatKhau
        txtMatKhau.UseSystemPasswordChar = XemMatKhau
        If XemMatKhau Then
            txtMatKhau.PasswordChar = "."
        Else
            txtMatKhau.PasswordChar = ""
        End If
    End Sub
End Class