Public Class vwSanPham
    ReadOnly Property CanhBao As Boolean
        Get
            If Me.SoLuong <= Me.TonMin Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Property GiaTriHienTai As Decimal
        Get
            If Me.SoLuong < 0 Then
                Return 0
            Else
                Return Me.SoLuong * Me.GiaBinhQuan
            End If
        End Get
        Set(value As Decimal)
        End Set
    End Property
End Class
