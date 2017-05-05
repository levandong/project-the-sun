Public Class tbNhanVien
    Public Overrides Function ToString() As String
        Return Me.TenDangNhap + "-" + Me.TenNhanVien
    End Function

    ReadOnly Property CapBatString As String
        Get
            If Me.CapBat = 1 Then
                Return "Cấp 1"
            ElseIf Me.CapBat = 2 Then
                Return "Cấp 2"
            Else
                Return "Cấp 3(Chỉ dành chi người toàn quyền)"
            End If
        End Get
    End Property
End Class
