Public Class tbLichSuCongViec
    ReadOnly Property NhanVien As String
        Get
            If Me.tbNhanVien IsNot Nothing Then
                Return Me.tbNhanVien.ToString
            Else
                Return ""
            End If
        End Get
    End Property
End Class
