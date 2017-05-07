Public Class TinhTonKhoSanPhamResult
    Property TienXuatDauKy As Decimal
        Get
            If Me.SoLuongNhapDauKy = 0 Then
                Return 0
            Else
                Return Me.SoLuongXuatDauKy * (Me.TienNhapDauKy / Me.SoLuongNhapDauKy)
            End If
        End Get
        Set(value As Decimal)

        End Set
    End Property


    Property SoLuongDauKy As Double
        Get
            Return Me.SoLuongNhapDauKy - Me.SoLuongXuatDauKy
        End Get
        Set(value As Double)

        End Set
    End Property

    Property TongTienDauKy As Decimal
        Get
            If Me.SoLuongDauKy < 0 Then
                Return 0
            Else
                Return Me.TienNhapDauKy - Me.TienXuatDauKy
            End If
        End Get
        Set(value As Decimal)

        End Set
    End Property


    Property TienXuatTrongKy As Decimal
        Get
            If Me.SoLuongDauKy + Me.SoLuongNhapTrongKy = 0 Then
                Return 0
            Else
                Return Math.Round((Me.TongTienDauKy + Me.TienNhapTrongKy) / (Me.SoLuongDauKy + Me.SoLuongNhapTrongKy) * Me.SoLuongXuatTrongKy, 0, MidpointRounding.AwayFromZero)
            End If
        End Get
        Set(value As Decimal)

        End Set
    End Property


    Property SoLuongCuoiKy As Double
        Get
            Return Me.SoLuongDauKy + Me.SoLuongNhapTrongKy - Me.SoLuongXuatTrongKy
        End Get
        Set(value As Double)
        End Set
    End Property


    Property TongTienCuoiKy As Decimal
        Get
            If Me.SoLuongCuoiKy <= 0 Then
                Return 0
            Else
                Return Me.TongTienDauKy + Me.TienNhapTrongKy - Me.TienXuatTrongKy
            End If
        End Get
        Set(value As Decimal)
        End Set
    End Property

    Property GiaTriHienTai As Decimal
        Get
            If Me.SoLuongHienTai < 0 Then
                Return 0
            Else
                Return Me.SoLuongHienTai * Me.GiaBinhQuan
            End If
        End Get
        Set(value As Decimal)
        End Set
    End Property
End Class
