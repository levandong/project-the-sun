Public Class vwGiaCong
    ReadOnly Property MaPhieu As String
        Get
            Return NgayLap.ToString("MM/yy") + "GC" + SoPhieu.ToString().PadLeft(3, "0")
        End Get
    End Property
End Class
