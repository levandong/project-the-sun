Public Class vwHoaDon
    ReadOnly Property MaHoaDon As String
        Get
            Return "HD/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoHoaDon.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
        End Get
    End Property

    ReadOnly Property SoTienConThieu As Decimal
        Get
            If Me.TongTienDaThanhToan >= Me.TongTien Then
                Return 0
            Else
                Return Me.TongTien - Me.TongTienDaThanhToan
            End If
        End Get
    End Property
    ReadOnly Property HinhThucThanhToan As String
        Get
            If Me.idHinhThucThanhToan IsNot Nothing Then
                Return "CK"
            Else
                Return "TM"
            End If
        End Get
    End Property
    ReadOnly Property TienPhi As Double
        Get
            Return (Me.MucPhi * Me.TongTien) / 100
        End Get
    End Property
    ReadOnly Property TenNhanVienThuTien As String
        Get
            If Me.idNhanVienThuTien IsNot Nothing Then
                Return dt.tbNhanViens.First(Function(s) s.id = Me.idNhanVienThuTien).TenNhanVien
            Else
                Return ""
            End If
        End Get
    End Property
End Class
