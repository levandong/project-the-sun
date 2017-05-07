Public Class vwBaoGia
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
            If Me.idKhachHang IsNot Nothing Then
                Return dt.tbKhachHangs.First(Function(s) s.id = Me.idKhachHang).TenKhachHang
            End If
            Return "-"
        End Get
    End Property
    ReadOnly Property TrangThai As String
        Get
            Dim KhachHangDatHang = dt.vwKhachHangDatHangs.FirstOrDefault(Function(s) s.idBaoGia = Me.id)
            If KhachHangDatHang IsNot Nothing Then
                If KhachHangDatHang.isGiaoHangXong Then
                    Return "Đã Giao Xong"
                Else
                    Return "Đang Giao Hàng"
                End If
            Else
                Return "Đang Báo Giá"
            End If
        End Get
    End Property
    ReadOnly Property LoaiXuatNhap As String
        Get
            If Me.isNhapHang Then
                Return "MUA"
            Else
                Return "BÁN"
            End If
        End Get
    End Property
    ReadOnly Property DiaChi As String
        Get
            If Me.idKhachHang IsNot Nothing Then
                Return dt.tbKhachHangs.First(Function(s) s.id = Me.idKhachHang).DiaChi
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
