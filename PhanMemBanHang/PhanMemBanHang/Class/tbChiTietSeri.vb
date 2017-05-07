Public Class tbChiTietSeri
    Private _TenSanPham As String
    Property TenSanPham As String
        Get
            If Me.tbSanPham IsNot Nothing Then
                _TenSanPham = Me.tbSanPham.TenSanPham
            End If
            Return _TenSanPham
        End Get
        Set(value As String)
            _TenSanPham = value
        End Set
    End Property

    ReadOnly Property NgayXuat As String
        Get
            If Me.tbPhieuXuat IsNot Nothing Then
                Return Me.tbPhieuXuat.NgayLap.ToString
            End If
            Return "-"
        End Get
    End Property
    ReadOnly Property MaPhieuXuat As String
        Get
            If Me.tbPhieuXuat IsNot Nothing Then
                Return Me.tbPhieuXuat.MaPhieu
            End If
            Return "-"
        End Get
    End Property
    ReadOnly Property NhaCungCapKhachHang As String
        Get
            If Me.tbPhieuNhap IsNot Nothing Then
                If Me.tbPhieuNhap.tbKhachHang IsNot Nothing Then
                    Return Me.tbPhieuNhap.tbKhachHang.TenKhachHang
                ElseIf Me.tbPhieuNhap.tbKhachHang1 IsNot Nothing Then
                    Return Me.tbPhieuNhap.tbKhachHang1.TenKhachHang
                End If
            End If
            Return "-"
        End Get
    End Property
    ReadOnly Property NhaCungCapKhachHangXuat As String
        Get
            If Me.tbPhieuXuat IsNot Nothing Then
                If Me.tbPhieuXuat.tbKhachHang IsNot Nothing Then
                    Return Me.tbPhieuXuat.tbKhachHang.TenKhachHang
                End If
            End If
            Return "-"
        End Get
    End Property
    ReadOnly Property MaPhieuNhap As String
        Get
            If Me.tbPhieuNhap IsNot Nothing Then
                Return Me.tbPhieuNhap.MaPhieu
            End If
            Return "-"
        End Get
    End Property
End Class
