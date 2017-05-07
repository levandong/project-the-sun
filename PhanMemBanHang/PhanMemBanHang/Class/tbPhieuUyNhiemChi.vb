Public Class tbPhieuUyNhiemChi
    ReadOnly Property MaPhieu As String
        Get
            If Me.isThuTienMat Then
                Dim strMa
                If Me.isPhieuThu Then
                    strMa = "T"
                Else
                    strMa = "C"
                End If
                Return Me.NgayLap.ToString("MMyy") + strMa + SoPhieu.ToString.PadLeft(3, "0")
            Else
                If Me.tbPhieuUyNhiemChi IsNot Nothing Or Me.tbPhieuUyNhiemChis.Count = 1 Then
                    Return Me.NgayLap.ToString("MMyy") + "CT" + SoPhieu.ToString.PadLeft(3, "0")
                Else
                    Return Me.SoPhieu.ToString.PadLeft(3, "0") + Me.NgayLap.ToString("/yy") + Me.tbNganHang.MaNganHang.Trim
                End If
            End If

        End Get
    End Property
    ReadOnly Property isThuTienMat
        Get
            If Me.tbNganHang.isTienMat = True Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    ' TenNganHang
    Private _TenNganHang As String
    Property TenNganHang As String
        Get
            If Me.tbNganHang IsNot Nothing Then
                Return Me.tbNganHang.TenNganHang.Trim
            End If
            Return _TenNganHang
        End Get
        Set(value As String)
            _TenNganHang = value
        End Set
    End Property

    ' TenNganHangUNC
    Private _TenNganHangUNC As String
    Property TenNganHangUNC As String
        Get
            If Me.tbNganHangUyNhiemChi IsNot Nothing Then
                Return Me.tbNganHangUyNhiemChi.TenNganHang.Trim
            End If
            Return ""
        End Get
        Set(value As String)
            _TenNganHangUNC = value
        End Set
    End Property
    'ThuImage
    ReadOnly Property ThuImage As Image
        Get
            If Me.isPhieuThu Then
                Return My.Resources.Them16x16
            Else
                Return My.Resources.Bot16x16
            End If
        End Get
    End Property

    ' TenKhachHangUNC
    Private _TenKhachHangUNC As String
    Property TenKhachHangUNC As String
        Get
            If Me.tbNganHangUyNhiemChi IsNot Nothing Then
                Return Me.tbNganHangUyNhiemChi.tbKhachHang.TenKhachHang
            End If
            Return _TenKhachHangUNC
        End Get
        Set(value As String)
            _TenKhachHangUNC = value
        End Set
    End Property
    ' TenKhachHang
    Private _TenKhachHang As String
    Property TenKhachHang As String
        Get
            If Me.tbNganHangUyNhiemChi IsNot Nothing Then
                Return Me.tbNganHangUyNhiemChi.tbKhachHang.TenKhachHang
            End If
            Return _TenKhachHang
        End Get
        Set(value As String)
            _TenKhachHang = value
        End Set
    End Property
End Class
