Public Class tbPhieuXuat
    ReadOnly Property MaPhieu As String
        Get
            Return Me.NgayLap.ToString("MMyy") + "X" + Me.SoPhieuXuat.ToString.PadLeft(My.Settings.SoSoKhongPhieuXuatNhap, "0")
        End Get
    End Property

    Private _TongTien As Decimal
    Property TongTien As Decimal
        Get
            Dim rls = dt.tbChiTietPhieuXuats.Where(Function(s) s.idPhieuXuat = Me.id)
            If rls.Count = 0 Then
                Return _TongTien
            Else
                Dim Tong As Decimal = rls.Sum(Function(s) s.SoLuong * s.DonGia * (100 - s.ChietKhau) / 100)
                Return Math.Round(Tong, 0, MidpointRounding.AwayFromZero)
            End If
        End Get
        Set(value As Decimal)
            _TongTien = value
        End Set
    End Property
End Class
