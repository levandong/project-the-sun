Public Class tbTraNoNhaCungCap

    ReadOnly Property TenNhaCungCap As String
        Get
            Return Me.tbKhachHang.TenKhachHang
        End Get
    End Property

    ReadOnly Property DaiChi As String
        Get
            Return Me.tbKhachHang.DiaChi
        End Get
    End Property

    ReadOnly Property SoDienThoai As String
        Get
            Return Me.tbKhachHang.SoDienThoai
        End Get
    End Property

    ReadOnly Property TenNhanVien As String
        Get
            Return Me.tbNhanVien.TenNhanVien
        End Get
    End Property

    ReadOnly Property MaPhieu As String
        Get
            Return "TR/" + Me.NgayTra.ToString("MMyy") + "/" + Me.SoPhieu.ToString.PadLeft(My.Settings.SoSoKhongHoaDon, "0")
        End Get
    End Property


    'ReadOnly Property ChungTuKemTheo As String
    '    Get
    '        If Me.tbPhieuNhap IsNot Nothing Then
    '            Return Me.tbPhieuNhap.MaPhieu
    '        ElseIf Me.tbPhieuXuat IsNot Nothing Then
    '            Return Me.tbPhieuXuat.MaPhieu
    '        Else
    '            Return ""
    '        End If
    '    End Get
    'End Property
End Class
