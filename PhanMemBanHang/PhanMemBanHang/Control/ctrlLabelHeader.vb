Public Class ctrlLabelHeader
    ' pnlMain
    Private _pnlMain As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Property pnlMain As ComponentFactory.Krypton.Toolkit.KryptonPanel
        Get
            Return _pnlMain
        End Get
        Set(value As ComponentFactory.Krypton.Toolkit.KryptonPanel)
            _pnlMain = value
        End Set
    End Property
    ' Header
    Private _Header As String
    Property Header As String
        Get
            Return _Header
        End Get
        Set(value As String)
            _Header = value
            lblMain.Text = value
        End Set
    End Property


  
    Private Sub ctrlCheckBoxHeader_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        If pnlMain IsNot Nothing Then
            pnlMain.Location = New Point(Me.Location.X, Me.Location.Y + Me.Height)
        End If
    End Sub

    Private Sub ctrlLabelHeader_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If pnlMain IsNot Nothing Then
            pnlMain.Width = Me.Width
        End If
    End Sub
End Class
