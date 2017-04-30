Public Class vwPhieuXuat
    ReadOnly Property MaPhieu As String
        Get
            Return Me.NgayLap.ToString("MMyy") + "X" + Me.SoPhieuXuat.ToString.PadLeft(4, "0")
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
