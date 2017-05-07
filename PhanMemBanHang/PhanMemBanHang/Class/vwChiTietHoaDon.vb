Public Class vwChiTietHoaDon

    Private _MaHoaDon As String
    Property MaHoaDon As String
        Get
            Return "HD/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoHoaDon.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
        End Get
        Set(value As String)
            _MaHoaDon = value
        End Set
    End Property

    ReadOnly Property NgayTaoHoaDon As Date
        Get
            Return Me.NgayLap.Date
        End Get
    End Property

    ' SoLuongYeuCau
    Private _SoLuongYeuCau As Double
    Property SoLuongYeuCau As Double
        Get
            If Me.idKhachHangDatHang IsNot Nothing Then
                Dim ChiTietDat = dt.vwChiTietKhachHangDatHangs.FirstOrDefault(Function(s) s.idSanPham = Me.idSanPham And s.idKhachHangDatHang = Me.idKhachHangDatHang)
                If ChiTietDat IsNot Nothing Then
                    _SoLuongYeuCau = ChiTietDat.SoLuong
                End If
            End If
            Return _SoLuongYeuCau
        End Get
        Set(value As Double)
            _SoLuongYeuCau = value
        End Set
    End Property

End Class
