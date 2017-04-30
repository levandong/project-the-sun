Public Class clsBackFile
    Private _CreatedDate As Date
    Property CreatedDate As Date
        Get
            Return _CreatedDate
        End Get
        Set(value As Date)
            _CreatedDate = value
        End Set
    End Property

    Private _FilePath As String
    Property FilePath As String
        Get
            Return _FilePath
        End Get
        Set(value As String)
            _FilePath = Value
        End Set
    End Property
End Class
