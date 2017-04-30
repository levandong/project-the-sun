Public Class clsPhieuKiemDuyet
    Private _Loai As Integer
    Property Loai As Integer
        Get
            Return _Loai
        End Get
        Set(value As Integer)
            _Loai = value
        End Set
    End Property
    Private _id As Integer
    Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private _idNguoiLap As Integer
    Property idNguoiLap As Integer
        Get
            Return _idNguoiLap
        End Get
        Set(value As Integer)
            _idNguoiLap = value
        End Set
    End Property
    Private _MaPhieu As String
    Property MaPhieu As String
        Get
            Return _MaPhieu
        End Get
        Set(value As String)
            _MaPhieu = value
        End Set
    End Property
    Private _NguoiKiemDuyet As String
    Property NguoiKiemDuyet As String
        Get
            Return _NguoiKiemDuyet
        End Get
        Set(value As String)
            If value IsNot Nothing Then
                Dim idNhanVien = CDec(value)
                _NguoiKiemDuyet = dt.tbNhanViens.FirstOrDefault(Function(s) s.id = idNhanVien).TenNhanVien
            Else
                _NguoiKiemDuyet = ""
            End If

        End Set
    End Property
    Private _NgayKiemDuyet As Date?
    Property NgayKiemDuyet As Date?
        Get
            Return _NgayKiemDuyet
        End Get
        Set(value As Date?)
            _NgayKiemDuyet = value
        End Set
    End Property
    Private _CapDo As Integer?
    Property CapDo As Integer?
        Get
            Return _CapDo
        End Get
        Set(value As Integer?)
            _CapDo = value
        End Set
    End Property
    Private _TrangThai As String
    Property TrangThai As String
        Get
            If CapDo Is Nothing Then
                Return ""
            ElseIf CapDo = 1 Then
                Return "Đã kiểm tra"
            Else
                Return "Đã duyệt"
            End If
        End Get
        Set(value As String)
            _TrangThai = value
        End Set
    End Property
End Class
