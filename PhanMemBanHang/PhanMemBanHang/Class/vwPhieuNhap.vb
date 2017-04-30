Public Class vwPhieuNhap
    ReadOnly Property MaPhieu As String
        Get
            Return Me.NgayLap.ToString("MMyy") + "N" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuXuatNhap, "0")
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

    ReadOnly Property SoTienConLai As Decimal
        Get
            Return Me.TongTienPhieuNhap - Me.SoTienThanhToan
        End Get
    End Property

    ReadOnly Property tPhieuNhap As tbPhieuNhap
        Get
            Return dt.tbPhieuNhaps.First(Function(s) s.id = Me.id)
        End Get
    End Property

    ReadOnly Property HanThanhToan As Date
        Get
            Return Me.NgayLap.AddDays(Me.SoNgayNo)
        End Get
    End Property
    ReadOnly Property GhiTrenFileExcel As String
        Get
            Dim vKhachHangDatHang As vwKhachHangDatHang = dt.vwKhachHangDatHangs.Single(Function(S) S.id = Me.idKhachHangDatHang)
            If vKhachHangDatHang.isGiaoHangXong Then
                If Me.GiaoLanThu < vKhachHangDatHang.SoLanDaGiao Then
                    Return Me.GiaoLanThu.Value.ToString() + " (còn)"
                Else
                    Return Me.GiaoLanThu.Value.ToString() + " (hết)"
                End If
            Else
                Return Me.GiaoLanThu.Value.ToString() + " (còn)"
            End If
        End Get
    End Property
End Class
