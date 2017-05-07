Public Class clsChiTietTonKho
    Private _Loai As Integer
    Property Loai As Integer
        Get
            Return _Loai
        End Get
        Set(value As Integer)
            _Loai = value
        End Set
    End Property


    Private _LyDo As String
    Property LyDo As String
        Get
            Return _LyDo
        End Get
        Set(value As String)
            _LyDo = value
        End Set
    End Property

    Private _DoiTuong As String
    Property DoiTuong As String
        Get
            Return _DoiTuong
        End Get
        Set(value As String)
            _DoiTuong = value
        End Set
    End Property

    Private _idPhieu As Integer
    Property idPhieu As Integer
        Get
            Return _idPhieu
        End Get
        Set(value As Integer)
            _idPhieu = value
        End Set
    End Property

    Private _SoPhieu As String
    Property SoPhieu As String
        Get
            Return _SoPhieu
        End Get
        Set(value As String)
            _SoPhieu = value
        End Set
    End Property

    ReadOnly Property MaPhieu As String
        Get
            If Me.Loai = 0 Then
                Return Me.Ngay.ToString("MMyy") + "N" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuXuatNhap, "0")
            ElseIf Loai = 1 Then
                Return Me.Ngay.ToString("MMyy") + "X" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuXuatNhap, "0")
            Else
                Return "HD/" + Me.Ngay.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
            End If
        End Get
    End Property

    Private _Ngay As DateTime
    Property Ngay As DateTime
        Get
            Return _Ngay
        End Get
        Set(value As DateTime)
            _Ngay = value
        End Set
    End Property


    Private _SoLuongNhap As Double
    Property SoLuongNhap As Double
        Get
            Return _SoLuongNhap
        End Get
        Set(value As Double)
            _SoLuongNhap = value
        End Set
    End Property

    Private _DonGiaNhap As Decimal
    Property DonGiaNhap As Decimal
        Get
            Return _DonGiaNhap
        End Get
        Set(value As Decimal)
            _DonGiaNhap = value
        End Set
    End Property


    ReadOnly Property ThanhTienNhap As Decimal
        Get
            Return Me.SoLuongNhap * Me.DonGiaNhap
        End Get
    End Property


    Private _SoLuongXuat As Double
    Property SoLuongXuat As Double
        Get
            Return _SoLuongXuat
        End Get
        Set(value As Double)
            _SoLuongXuat = value
        End Set
    End Property

    Private _DonGiaXuat As Decimal
    Property DonGiaXuat As Decimal
        Get
            Return _DonGiaXuat
        End Get
        Set(value As Decimal)
            _DonGiaXuat = value
        End Set
    End Property

    ReadOnly Property ThanhTienXuat As Decimal
        Get
            Return Me.SoLuongXuat * Me.DonGiaXuat
        End Get
    End Property


    Private _SoLuongTon As Double
    Property SoLuongTon As Double
        Get
            Return _SoLuongTon
        End Get
        Set(value As Double)
            _SoLuongTon = value
        End Set
    End Property

    Private _ThanhTienTon As Decimal
    Property ThanhTienTon As Decimal
        Get
            Return _ThanhTienTon
        End Get
        Set(value As Decimal)
            _ThanhTienTon = value
        End Set
    End Property
End Class
