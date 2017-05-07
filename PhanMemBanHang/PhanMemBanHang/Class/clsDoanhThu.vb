Public Class clsDoanhThu

    Private _STT As String
    Public Property STT As String
        Get
            If _STT IsNot Nothing Then
                Return _STT
            End If
            Return ""
        End Get
        Set(ByVal value As String)
            _STT = value
        End Set
    End Property
    Private _isDam As Boolean = False
    Public Property isDam As Boolean
        Get
            Return _isDam
        End Get
        Set(ByVal value As Boolean)
            _isDam = value
        End Set
    End Property
    Private _DienGiai As String
    Public Property DienGiai As String
        Get

            Return _DienGiai
        End Get
        Set(ByVal value As String)
            _DienGiai = value
        End Set
    End Property
    Private _SoLuong As Integer?
    Public Property SoLuong As Integer?
        Get
            If _SoLuong IsNot Nothing Then
                Return _SoLuong
            End If
            Return 0
        End Get
        Set(ByVal value As Integer?)
            _SoLuong = value
        End Set
    End Property
    Private _SoTien As Double?
    Public Property SoTien As Double?
        Get
            If _SoTien IsNot Nothing Then
                Return _SoTien
            End If
            Return 0
        End Get
        Set(ByVal value As Double?)
            _SoTien = value
        End Set
    End Property
End Class
