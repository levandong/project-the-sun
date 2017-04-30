Public Class vwChiTietPhieuXuat
    ReadOnly Property MaPhieu As String
        Get
            Return Me.NgayLap.ToString("MMyy") + "X" + Me.SoPhieuXuat.ToString.PadLeft(4, "0")
        End Get
    End Property
End Class
