Public Class vwKhachHangDatHang
    ReadOnly Property MaDatHang As String
        Get
            Return Me.NgayLap.ToString("MMyy") + "D" + Me.SoPhieu.ToString.PadLeft(4, "0")
        End Get
    End Property
    ReadOnly Property TrangThai As String
        Get
            If Me.isGiaoHangXong Then
                Return "Đã giao xong - " + SoLanDaGiao.ToString + " lần"
            ElseIf SoLanDaGiao > 0 Then
                Return "Đã giao " + SoLanDaGiao.ToString() + " lần"
            Else
                Return "Chưa giao hàng"
            End If
        End Get
    End Property
    ReadOnly Property Loai As String
        Get
            If Me.isNhapHang Then
                Return "MUA"
            Else
                Return "BÁN"
            End If
        End Get
    End Property
End Class
