Public Class tbGiaoViec
    Public Overrides Function ToString() As String
        Return Me.tbNhanVien.TenNhanVien + "/" + Me.NoiDung
    End Function
    Property TrangThaiString As String
        Get
            If Me.TrangThai = 1 Then
                Return "Chưa xác nhận"
            ElseIf Me.TrangThai = 2 Then
                Return "Đang tiến hành"
            Else
                Return "Đã hoàn thành"
            End If
        End Get
        Set(value As String)

        End Set
    End Property
End Class
