Public Class vwChiTietKhachHangDatHang
    ReadOnly Property MaDatHang As String
        Get
            Return "DH/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
        End Get
    End Property

    ReadOnly Property SoTienChietKhauSanPham As Decimal
        Get
            Dim SoTien As Decimal = Me.SoLuong * Me.DonGia * Me.ChietKhau / 100
            Return SoTien + (Me.SoLuong * Me.DonGia * (100 - Me.ChietKhau) / 100 * Me.ChietKhauKhachHangDatHang / 100)
        End Get
    End Property

    ReadOnly Property SoTienVATChiTiet As Decimal
        Get
            Return Me.SoLuong * Me.DonGia * (100 - Me.ChietKhau) / 100 * (100 - Me.ChietKhauKhachHangDatHang) / 100 * Me.VAT / 100
        End Get
    End Property

    ReadOnly Property CongTienChiTiet As Decimal
        Get
            Return Me.SoLuong * Me.DonGia
        End Get
    End Property
End Class
