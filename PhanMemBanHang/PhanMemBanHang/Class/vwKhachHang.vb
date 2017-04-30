Public Class vwKhachHang
    ReadOnly Property Loai As String
        Get
            If Me.isNhaCungCap Is Nothing Then
                Return "KH/NCC"
            ElseIf Me.isNhaCungCap = False Then
                Return "KH"
            Else
                Return "NCC"
            End If
        End Get
    End Property
End Class
