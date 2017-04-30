Public Class clsPhieuNhapXuat
    ' id
    Private _id As Integer
    Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    ' Loai
    Private _Loai As Integer
    Property Loai As Integer
        Get
            Return _Loai
        End Get
        Set(value As Integer)
            _Loai = value
        End Set
    End Property

    ReadOnly Property TenKhachHang As String
        Get
            If Me.idKhachHang Is Nothing Then
                Return dt.tbKhachHangs.Single(Function(s) s.id = Me.idKhachHang).TenKhachHang
            Else
                Return dt.tbKhachHangs.Single(Function(s) s.id = Me.idNhaCungCap).TenKhachHang
            End If
        End Get
    End Property

    ' idNhanVien
    Private _idNhanVien As Integer
    Property idNhanVien As Integer
        Get
            Return _idNhanVien
        End Get
        Set(value As Integer)
            _idNhanVien = value
        End Set
    End Property

    ' idLoaiPhieu
    Private _idLoaiPhieu As Integer
    Property idLoaiPhieu As Integer
        Get
            Return _idLoaiPhieu
        End Get
        Set(value As Integer)
            _idLoaiPhieu = value
        End Set
    End Property


    ' idNhaCungCap
    Private _idNhaCungCap As Integer?
    Property idNhaCungCap As Integer?
        Get
            Return _idNhaCungCap
        End Get
        Set(value As Integer?)
            _idNhaCungCap = value
        End Set
    End Property

    ' idKhachHang
    Private _idKhachHang As Integer?
    Property idKhachHang As Integer?
        Get
            Return _idKhachHang
        End Get
        Set(value As Integer?)
            _idKhachHang = value
        End Set
    End Property


    ' DiaChi
    Private _DiaChi As String
    Property DiaChi As String
        Get
            Return _DiaChi
        End Get
        Set(value As String)
            _DiaChi = value
        End Set
    End Property

    ' TongTien
    Private _TongTien As Decimal
    Property TongTien As Decimal
        Get
            Return _TongTien
        End Get
        Set(value As Decimal)
            _TongTien = value
        End Set
    End Property

    ' MaPhieu
    Private _MaPhieu As String
    Property MaPhieu As String
        Get
            Return _MaPhieu
        End Get
        Set(value As String)
            _MaPhieu = value
        End Set
    End Property

    ' TenNhanVien
    Private _TenNhanVien As String
    Property TenNhanVien As String
        Get
            Return _TenNhanVien
        End Get
        Set(value As String)
            _TenNhanVien = value
        End Set
    End Property

    ' TenCongTrinh
    Private _TenCongTrinh As String
    Property TenCongTrinh As String
        Get
            Return _TenCongTrinh
        End Get
        Set(value As String)
            _TenCongTrinh = value
        End Set
    End Property


End Class
