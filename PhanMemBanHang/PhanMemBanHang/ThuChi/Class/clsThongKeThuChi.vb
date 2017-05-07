Public Class clsThongKeThuChi
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

    ' ThuNo
    Private _ThuNo As Decimal
    Property ThuNo As Decimal
        Get
            Return _ThuNo
        End Get
        Set(value As Decimal)
            _ThuNo = value
        End Set
    End Property

    ' ThuNoString
    ReadOnly Property ThuNoString As String
        Get
            If Me.ThuNo = 0 Then
                Return ""
            Else
                Return String.Format("{0:N0}", Me.ThuNo)
            End If
        End Get
    End Property

    ' ThuKhac
    Private _ThuKhac As Decimal
    Property ThuKhac As Decimal
        Get
            Return _ThuKhac
        End Get
        Set(value As Decimal)
            _ThuKhac = value
        End Set
    End Property

    ' ThuKhacString
    ReadOnly Property ThuKhacString As String
        Get
            If Me.ThuKhac = 0 Then
                Return ""
            Else
                Return String.Format("{0:N0}", Me.ThuKhac)
            End If
        End Get
    End Property


    ' ChiKhac
    Private _ChiKhac As Decimal
    Property ChiKhac As Decimal
        Get
            Return _ChiKhac
        End Get
        Set(value As Decimal)
            _ChiKhac = value
        End Set
    End Property

    ' ChiKhacString
    ReadOnly Property ChiKhacString As String
        Get
            If Me.ChiKhac = 0 Then
                Return ""
            Else
                Return String.Format("{0:N0}", Me.ChiKhac)
            End If
        End Get
    End Property

    ' TraNo
    Private _TraNo As Decimal
    Property TraNo As Decimal
        Get
            Return _TraNo
        End Get
        Set(value As Decimal)
            _TraNo = value
        End Set
    End Property

    ' TraNoString
    ReadOnly Property TraNoString As String
        Get
            If Me.TraNo = 0 Then
                Return ""
            Else
                Return String.Format("{0:N0}", Me.TraNo)
            End If
        End Get
    End Property

    ReadOnly Property TongThu As Decimal
        Get
            Return Me.ThuNo + Me.ThuKhac
        End Get
    End Property

    ReadOnly Property TongChi As Decimal
        Get
            Return Me.ChiKhac + Me.TraNo
        End Get
    End Property
End Class
