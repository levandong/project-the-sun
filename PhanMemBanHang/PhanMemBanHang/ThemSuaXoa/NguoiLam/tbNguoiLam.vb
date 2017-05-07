Public Class tbNguoiLam
    Public Overrides Function ToString() As String
        Return Me.TenNguoiLam
    End Function

    ReadOnly Property GioiTinhString As String
        Get
            If Me.GioiTinh Then
                Return "Nam"
            Else
                Return "Nữ"
            End If
        End Get
    End Property
End Class
