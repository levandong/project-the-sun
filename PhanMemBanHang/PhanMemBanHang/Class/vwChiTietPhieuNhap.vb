Public Class vwChiTietPhieuNhap
    ReadOnly Property MaPhieu As String
        Get
            Return "PN/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuXuatNhap, "0")
        End Get
    End Property
    ReadOnly Property DonGiaThuc As Decimal
        Get
            Return Me.DonGia * (1 - Me.ChietKhau / 100)
        End Get
    End Property

    ReadOnly Property KhachHangNhaCungCap As String
        Get
            If Me.idNhaCungCap IsNot Nothing Then
                Return Me.TenNhaCungCap
            Else
                Return Me.TenKhachHang
            End If
        End Get
    End Property
End Class
