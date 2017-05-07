Public Class tbKhachHangDatHang
    Public Overrides Function ToString() As String
        'Để hiển thị lên combobox trong bán hàng
        If isNhapHang = False Then
            Return Me.NgayLap.ToString("MMyy") + "D" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
        Else
            Return Me.NgayLap.ToString("MMyy") + "P" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
        End If
    End Function

    ReadOnly Property MaDatHang As String
        Get
            If isNhapHang = False Then
                Return Me.NgayLap.ToString("MMyy") + "D" + Me.SoPhieu.ToString.PadLeft(4, "0")
            Else
                Return Me.NgayLap.ToString("MMyy") + "P" + Me.SoPhieu.ToString.PadLeft(4, "0")
            End If
        End Get
    End Property

    Private _TongTienChuaGiamGia As Decimal
    Public Property TongTienChuaGiamGia() As Decimal
        Get
            Dim rls = dt.tbChiTietKhachHangDatHangs.Where(Function(s) s.idKhachHangDatHang = Me.id)
            If rls.Count = 0 Then
                Return _TongTienChuaGiamGia
            End If
            Return dt.tbChiTietKhachHangDatHangs.Where(Function(s) s.idKhachHangDatHang = Me.id).Sum(Function(s) s.SoLuong * s.GiaBan)
        End Get
        Set(ByVal value As Decimal)
            _TongTienChuaGiamGia = value
        End Set
    End Property

    Private _TongTienDaGiamGia As Decimal
    Public Property TongTienDaGiamGia() As Decimal
        Get
            Dim rls = dt.tbChiTietKhachHangDatHangs.Where(Function(s) s.idKhachHangDatHang = Me.id)
            If rls.Count = 0 Then
                Return _TongTienDaGiamGia
            End If
            Return Math.Round((TongTienChuaGiamGia * (100 - Me.ChietKhau) / 100 * (100 + Me.VAT) / 100), 0, MidpointRounding.AwayFromZero)
        End Get
        Set(ByVal value As Decimal)
            _TongTienDaGiamGia = value
        End Set
    End Property

    'ReadOnly Property DaXuatHoaDon As Integer
    '    Get
    '        Dim rlsHoaDon = From itm In dt.tbHoaDons
    '                        Where itm.idKhachHangDatHang = Me.id

    '        Return rlsHoaDon.Count
    '    End Get
    'End Property
End Class
