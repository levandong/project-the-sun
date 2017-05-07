Public Class tbPhieuChi
    ReadOnly Property MaPhieu As String
        Get
            Return "PC/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
        End Get
    End Property
End Class
