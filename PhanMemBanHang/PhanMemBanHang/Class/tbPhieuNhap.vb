Public Class tbPhieuNhap
    Public Overrides Function ToString() As String
        Return Me.MaPhieu
    End Function
    ReadOnly Property MaPhieu As String
        Get
            Return Me.NgayLap.ToString("MMyy") + "N" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuXuatNhap, "0")
        End Get
    End Property

    Private _TongTien As Decimal
    Property TongTien As Decimal
        Get
            Dim rls = dt.tbChiTietPhieuNhaps.Where(Function(s) s.idPhieuNhap = Me.id)
            If rls.Count = 0 Then
                Return _TongTien
            Else
                Dim Tong As Decimal = rls.Sum(Function(s) s.SoLuong * s.DonGia * (100 - s.ChietKhau) / 100)
                Return Math.Round((Tong * (100 - Me.ChietKhau) / 100 * (100 + Me.VAT) / 100), 0, MidpointRounding.AwayFromZero)
            End If
        End Get
        Set(value As Decimal)
            _TongTien = value
        End Set
    End Property

    Private _SoTienThanhToan As Decimal
    Property SoTienThanhToan As Decimal
        Get
            Dim ThanhToan = dt.tbTraNoNhaCungCaps.FirstOrDefault(Function(s) s.idPhieuNhap = Me.id)
            If ThanhToan IsNot Nothing Then
                _SoTienThanhToan = ThanhToan.SoTien
            End If
            Return _SoTienThanhToan
        End Get
        Set(value As Decimal)
            _SoTienThanhToan = value
        End Set
    End Property
End Class
