Public Class tbThuNoKhachHang
    ReadOnly Property TenKhachHang As String
        Get
            Return tbKhachHang.TenKhachHang
        End Get
    End Property

    ReadOnly Property SoDienThoai As String
        Get
            Return tbKhachHang.SoDienThoai
        End Get
    End Property


    ReadOnly Property DiaChi As String
        Get
            Return tbKhachHang.DiaChi
        End Get
    End Property


    ReadOnly Property TenNhanVien As String
        Get
            Return tbNhanVien.TenNhanVien
        End Get
    End Property
    ReadOnly Property HinhThucThanhToan As String
        Get
            If Me.idHinhThucThanhToan Is Nothing Then
                Return "TM"
            Else
                Return "CK"
            End If

        End Get
    End Property
    ReadOnly Property TenNganHang As String
        Get
            If Me.idHinhThucThanhToan IsNot Nothing Then
                Return Me.tbNganHang.TenNganHang
            Else
                Return Nothing
            End If
        End Get
    End Property
    ReadOnly Property MaPhieu As String
        Get
            Return "TH/" + Me.NgayThu.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
        End Get
    End Property

    'ReadOnly Property ChungTuKemTheo As String
    '    Get
    '        If Me.tbHoaDon IsNot Nothing Then
    '            Return Me.tbHoaDon.MaHoaDon
    '        ElseIf Me.tbPhieuNhap IsNot Nothing Then
    '            Return Me.tbPhieuNhap.MaPhieu
    '        Else
    '            Return ""
    '        End If
    '    End Get
    'End Property
End Class
