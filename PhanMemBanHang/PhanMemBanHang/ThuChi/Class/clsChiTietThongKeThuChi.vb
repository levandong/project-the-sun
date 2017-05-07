Public Class clsChiTietThongKeThuChi
    Private _Thu As Integer
    Property Thu As Integer
        Get
            ' < 0 là chi:
            '' -1: Chi trả nợ nhà cung cấp
            '' -2: Chi khác

            ' > 0 là thu
            '' 1: Thu nợ từ khách hàng
            '' 2: Thu khác
            Return _Thu
        End Get
        Set(value As Integer)
            _Thu = value
        End Set
    End Property
    ' Chon
    Private _Chon As Boolean
    Property Chon As Boolean
        Get
            Return _Chon
        End Get
        Set(value As Boolean)
            _Chon = value
        End Set
    End Property

    ' MaNganHang
    Private _MaNganHang As String
    Property MaNganHang As String
        Get
            Return _MaNganHang
        End Get
        Set(value As String)
            _MaNganHang = value
        End Set
    End Property


    Private _idNganHang As Integer
    Property idNganHang As Integer
        Get
            Return _idNganHang
        End Get
        Set(value As Integer)
            _idNganHang = value
        End Set
    End Property
    Private _idPhieu As Integer
    Property idPhieu As Integer
        Get
            Return _idPhieu
        End Get
        Set(value As Integer)
            _idPhieu = value
        End Set
    End Property

    Private _SoPhieu As Integer
    Property SoPhieu As Integer
        Get
            Return _SoPhieu
        End Get
        Set(value As Integer)
            _SoPhieu = value
        End Set
    End Property
    Private _TenNganHang As String
    Property TenNganHang As String
        Get
            If idNganHang <> 0 Then
                Return dt.tbNganHangs.Single(Function(s) s.id = idNganHang).TenTaiKhoan
            End If
            Return _TenNganHang
        End Get
        Set(value As String)
            _TenNganHang = value
        End Set
    End Property
    ' TienPhi
    Private _TienPhi As Integer
    Property TienPhi As Integer
        Get
            Return _TienPhi
        End Get
        Set(value As Integer)
            _TienPhi = value
        End Set
    End Property

    ' GhiChu
    Private _GhiChu As String
    Property GhiChu As String
        Get
            Return _GhiChu
        End Get
        Set(value As String)
            _GhiChu = value
        End Set
    End Property

    ' TenKhachHangUNC
    Private _TenKhachHangUNC As String
    Property TenKhachHangUNC As String
        Get
            If idKhachHangUNC <> 0 Then
                Return dt.tbNganHangs.Single(Function(s) s.id = idKhachHangUNC).TenNganHang
            End If
            Return _TenKhachHangUNC
        End Get
        Set(value As String)
            _TenKhachHangUNC = value
        End Set
    End Property

    ' TenKhachHang
    Private _TenKhachHang As String = ""
    Property TenKhachHang As String
        Get
            If _TenKhachHang Is Nothing Then
                Return ""
            End If
            Return _TenKhachHang
        End Get
        Set(value As String)
            _TenKhachHang = value
        End Set
    End Property
    ' idKhachHangUNC
    Private _idKhachHangUNC As Integer
    Property idKhachHangUNC As Integer
        Get
            Return _idKhachHangUNC
        End Get
        Set(value As Integer)
            _idKhachHangUNC = value
        End Set
    End Property


    ReadOnly Property MaPhieu As String
        Get
            If Me.Thu = 1 Then
                Return "TH/" + Me.ThoiGian.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
            ElseIf Me.Thu = 2 Then
                Return "PT/" + Me.ThoiGian.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
            ElseIf Me.Thu = -1 Then
                Return "TR/" + Me.ThoiGian.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
            Else
                Return "PC/" + Me.ThoiGian.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
            End If
        End Get
    End Property
    ReadOnly Property MaPhieu2 As String
        Get
            If Me.Thu = 1 Then
                Return Me.ThoiGian.ToString("MMyy") + "T" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
            ElseIf Me.Thu = 2 Then
                Return Me.ThoiGian.ToString("MMyy") + "C" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
            ElseIf Me.Thu = 3 Then
                Dim NganHang = dt.tbNganHangs.FirstOrDefault(Function(s) s.id = idNganHang)
                If NganHang Is Nothing Then
                    Return ""
                End If
                If NganHang.isTienMat = True Then
                    If TongChi = 0 Then
                        Return Me.ThoiGian.ToString("MMyy") + "T" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
                    Else
                        Return Me.ThoiGian.ToString("MMyy") + "C" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
                    End If
                Else
                    If dt.tbPhieuUyNhiemChis.Single(Function(s) s.ID = Me.idPhieu).tbPhieuUyNhiemChi IsNot Nothing Or dt.tbPhieuUyNhiemChis.Single(Function(s) s.ID = Me.idPhieu).tbPhieuUyNhiemChis.Count > 0 Then
                        Return Me.ThoiGian.ToString("yy") + "CT" + Me.SoPhieu.ToString.PadLeft(4, "0")
                    ElseIf Me.TongThu = 0 Then
                        Return Me.SoPhieu.ToString.PadLeft(3, "0") + Me.ThoiGian.ToString("/yy") + NganHang.MaNganHang.Trim
                    Else
                        Return Me.ThoiGian.ToString("MMyy") + "T" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongPhieuThuChi, "0")
                    End If
                End If
            ElseIf Me.Thu < 1 Then
                Return "Dư đầu kỳ"
            Else
                Return ""
            End If
        End Get
    End Property
    Private _ThoiGian As Date
    Property ThoiGian As Date
        Get
            Return _ThoiGian
        End Get
        Set(value As Date)
            _ThoiGian = value
        End Set
    End Property

    Private _ThoiGianString As String
    Property ThoiGianString As String
        Get
            Return _ThoiGianString
        End Get
        Set(value As String)
            _ThoiGianString = value
        End Set
    End Property

    Private _DienGiai As String
    Property DienGiai As String
        Get
            Return _DienGiai
        End Get
        Set(value As String)
            _DienGiai = value
        End Set
    End Property

    Private _TongThu As Decimal
    Property TongThu As Decimal
        Get
            Return _TongThu
        End Get
        Set(value As Decimal)
            _TongThu = value
        End Set
    End Property
    Private _TongTien As Decimal
    Property TongTien As Decimal
        Get
            Return _TongTien
        End Get
        Set(value As Decimal)
            _TongTien = value
        End Set
    End Property
    ReadOnly Property TongThuString As String
        Get
            If Me.TongThu = 0 Then
                Return ""
            Else
                Return String.Format("{0:N0}", Me.TongThu)
            End If
        End Get
    End Property


    Private _TongChi As Decimal
    Property TongChi As Decimal
        Get
            Return _TongChi
        End Get
        Set(value As Decimal)
            _TongChi = value
        End Set
    End Property

    ReadOnly Property TongChiString As String
        Get
            If Me.TongChi = 0 Then
                Return ""
            Else
                Return String.Format("{0:N0}", Me.TongChi)
            End If
        End Get
    End Property

    ReadOnly Property ThuImage As Image
        Get
            If TongChi = 0 Then
                Return My.Resources.Them16x16
            Else
                Return My.Resources.Bot16x16
            End If
        End Get
    End Property

    ReadOnly Property Thang As Date
        Get
            Return New Date(Me.ThoiGian.Year, Me.ThoiGian.Month, 1)
        End Get
    End Property
End Class
