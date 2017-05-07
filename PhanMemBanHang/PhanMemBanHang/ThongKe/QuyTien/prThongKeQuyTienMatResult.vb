Public Class prThongKeQuyTienMatResult

    Property ChungTu As String
        Get
            Dim MaPhieu As String = ""
            If Me.Loai = 1 Then ' Phiếu thu
                MaPhieu = "PT/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
            ElseIf Me.Loai = 2 Then ' Phiếu thu nợ khách hàng
                MaPhieu = "TH/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
            ElseIf Me.Loai = -1 Then ' Phiếu chi
                MaPhieu = "PC/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
            ElseIf Me.Loai = -2 Then ' Phiếu tra nợ nhà cung cấp
                MaPhieu = "TR/" + Me.NgayLap.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
            End If
            Return MaPhieu
        End Get
        Set(value As String)

        End Set
    End Property

    Property Thu As String
        Get
            If Me.Loai > 0 Then
                Return String.Format("{0:N0}", Me.SoTien)
            Else
                Return ""
            End If
        End Get
        Set(value As String)

        End Set
    End Property

    Property Chi As String
        Get
            If Me.Loai < 0 Then
                Return String.Format("{0:N0}", Me.SoTien)
            Else
                Return ""
            End If
        End Get
        Set(value As String)

        End Set
    End Property
End Class
