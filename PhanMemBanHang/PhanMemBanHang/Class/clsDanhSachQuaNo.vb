Public Class clsDanhSachQuaNo
    ' TenKhachHang
    Private _TenKhachHang As String
    Property TenKhachHang As String
        Get
            Return _TenKhachHang
        End Get
        Set(value As String)
            _TenKhachHang = value
        End Set
    End Property
    Private _id As Integer
    Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private _idKhachHang As Integer
    Property idKhachHang As Integer
        Get
            Return _idKhachHang
        End Get
        Set(value As Integer)
            _idKhachHang = value
        End Set
    End Property
    ' NgayQuaHan
    Private _NgayQuaHan As Date
    Property NgayQuaHan As Date
        Get
            Return _NgayQuaHan
        End Get
        Set(value As Date)
            _NgayQuaHan = value
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

End Class
