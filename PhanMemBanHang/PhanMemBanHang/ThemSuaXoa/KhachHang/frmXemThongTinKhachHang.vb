Public Class frmXemThongTinKhachHang
    Public KhachHang As tbKhachHang
    Public MaKhachHangBanDau As String
    Dim lstLuuTam As New List(Of tbChiTietLienHe)
    Dim lstChiTietLienHe As New List(Of tbChiTietLienHe)
    Private Sub frmXemThongTinKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        cmbNhomKhachHang.DataSource = From itm In dt.tbNhomKhachHangs
                                      Order By itm.TenNhomKhachHang
        If KhachHang IsNot Nothing Then
            txtTenRutGon.Text = KhachHang.TenRutGon
            cmbNhomKhachHang.SelectedItem = KhachHang.tbNhomKhachHang
            txtMaKhachHang.Text = KhachHang.MaKhachHang
            txtTenKhachHang.Text = KhachHang.TenKhachHang
            txtSoDienThoai.Text = KhachHang.SoDienThoai
            txtDiaChi.Text = KhachHang.DiaChi
            nudCongNoDauKy.Value = KhachHang.CongNoDauKy
            txtMaSoThue.Text = KhachHang.MaSoThue
            txtSoFax.Text = KhachHang.SoFAX
            txtEmail.Text = KhachHang.Email
            nudCongNoMax.Value = KhachHang.CongNoMax
            nudSoNgayNo.Value = KhachHang.NgayTraNo
            If KhachHang.isNhaCungCap Then
                chkNhaCungCap.Checked = True
            ElseIf KhachHang.isNhaCungCap = False Then
                chkKhachHang.Checked = True
            Else
                chkKhachHang.Checked = True
                chkNhaCungCap.Checked = True
            End If
            lstChiTietLienHe = (From itm In dt.tbChiTietLienHes Where itm.idKhachHang = KhachHang.id).ToList
            For Each itm In lstChiTietLienHe
                Dim Tam As New tbChiTietLienHe
                With Tam
                    .id = itm.id
                    .idKhachHang = itm.idKhachHang
                    .TenNguoiLienHe = itm.TenNguoiLienHe
                    .SoDienThoai = itm.SoDienThoai
                    .Email = itm.Email
                End With
                lstLuuTam.Add(Tam)
            Next
            bsChiTietLienHe.DataSource = From itm In lstChiTietLienHe
        End If
        txtMaKhachHang.Focus()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmXemThongTinKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then
            btnDong_Click(Nothing, Nothing)
        End If
    End Sub
End Class