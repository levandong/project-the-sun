Public Class frmChinhSuaHangLoatChiecKhau
    Private _LoaiSanPham As tbLoaiSanPham
    Property LoaiSanPham As tbLoaiSanPham
        Get
            Return _LoaiSanPham
        End Get
        Set(value As tbLoaiSanPham)
            _LoaiSanPham = value
            lblLoaiSanPham.Text = _LoaiSanPham.TenLoaiSanPham
        End Set
    End Property
    Private _Nhap As Boolean
    Property Nhap As Boolean
        Get
            Return _Nhap
        End Get
        Set(value As Boolean)
            _Nhap = value
            If _Nhap Then
                lblLoai.Text += " NHẬP"
            Else
                lblLoai.Text += " XUẤT"
            End If
        End Set
    End Property

    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        If Nhap Then
            For Each itm In dt.tbSanPhams.Where(Function(s) s.idLoaiSanPham = LoaiSanPham.id)
                itm.PhanTramNhap = nudChiecKhau.Value
            Next
            Try
                dt.SubmitChanges()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                ThongBaoError("Lỗi")
            End Try
        Else
            For Each itm In dt.tbSanPhams.Where(Function(s) s.idLoaiSanPham = LoaiSanPham.id)
                itm.PhanTramBan = nudChiecKhau.Value
            Next
            Try
                dt.SubmitChanges()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                ThongBaoError("Lỗi")
            End Try
        End If
    End Sub

    Private Sub frmChinhSuaHangLoatChiecKhau_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        nudChiecKhau.Select(0, nudChiecKhau.Text.Length)
    End Sub
End Class