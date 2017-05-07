Public Class vwPhieuThu
    ReadOnly Property MaPhieu As String
        Get
            Return "PT/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
        End Get
    End Property
End Class
