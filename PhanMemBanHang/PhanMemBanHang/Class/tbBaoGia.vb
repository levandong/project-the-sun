Public Class tbBaoGia
    ReadOnly Property MaPhieu As String
        Get
            If isNhapHang Then
                Return NgayLap.ToString("MMyy") + "ĐNBG" + Me.SoPhieu.ToString.PadLeft(4, "0")

            Else
                Return NgayLap.ToString("MMyy") + "B" + Me.SoPhieu.ToString.PadLeft(4, "0")
            End If
        End Get
    End Property
    ReadOnly Property KhachHangNhaCungCap As String
        Get
            If Me.tbKhachHang IsNot Nothing Then
                Return Me.tbKhachHang.TenKhachHang
            End If
            Return "-"
        End Get
    End Property
    ReadOnly Property GiaChuaThue As Decimal
        Get
            Return dt.tbChiTietBaoGias.Where(Function(s) s.idBaoGia = Me.id).Sum(Function(s) s.SoLuong * s.GiaNiemYet * (1 - s.ChietKhau / 100))
        End Get
    End Property
    ReadOnly Property TienThue As Decimal
        Get
            Return dt.tbChiTietBaoGias.Where(Function(s) s.idBaoGia = Me.id).Sum(Function(s) s.SoLuong * s.GiaNiemYet * (1 - s.ChietKhau / 100)) * (Me.VAT / 100)
        End Get
    End Property
    ReadOnly Property TongTien As Decimal
        Get
            Return dt.tbChiTietBaoGias.Where(Function(s) s.idBaoGia = Me.id).Sum(Function(s) s.SoLuong * s.GiaNiemYet * (1 - s.ChietKhau / 100)) * (1 + Me.VAT / 100)
        End Get
    End Property
    ReadOnly Property TrangThai As String
        Get
            If Me.tbTrangThai IsNot Nothing Then
                Return Me.tbTrangThai.TenTrangThai.Trim
            End If
            Return ""
        End Get
    End Property
    ReadOnly Property LoaiXuatNhap As String
        Get
            If Me.isNhapHang Then
                Return "Nhập hàng"
            Else
                Return "Xuất hàng"
            End If
        End Get
    End Property
    ReadOnly Property DiaChi As String
        Get
            If Me.tbKhachHang IsNot Nothing Then
                Return Me.tbKhachHang.DiaChi
            End If
            Return "-"
        End Get
    End Property
    Private _Chon As Boolean
    Property Chon As Boolean
        Get
            Return _Chon
        End Get
        Set(value As Boolean)
            _Chon = value
        End Set
    End Property
End Class
