Public Class clsXuatNhatTonKho
    ' STT
    Private _STT As String
    Property STT As String
        Get
            Return _STT
        End Get
        Set(value As String)
            _STT = value
        End Set
    End Property

    ' DienGiai
    Private _DienGiai As String
    Property DienGiai As String
        Get
            Return _DienGiai
        End Get
        Set(value As String)
            _DienGiai = value
        End Set
    End Property

    ' SoLuong
    Private _SoLuong As Integer
    Property SoLuong As Integer
        Get
            Return _SoLuong
        End Get
        Set(value As Integer)
            _SoLuong = value
        End Set
    End Property

    ' isDam
    Private _isDam As Boolean
    Property isDam As Boolean
        Get
            Return _isDam
        End Get
        Set(value As Boolean)
            _isDam = value
        End Set
    End Property
End Class
