Public Class clsGroupbox
    Inherits ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Private tempHeight As Integer
    Private tempWidth As Integer
    Event ThayDoiChieuCao(DentalHeight As Integer)
    Private Sub Me_Click() Handles Me.Click
        If KhongMoRong = True Then Exit Sub
        If Me.CaptionEdge = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top Then
            If Me.Height <> 20 Then
                tempHeight = Me.Height
                Me.Height = 20
                Me.Values.Image = My.Resources.Cong16
                RaiseEvent ThayDoiChieuCao(tempHeight - 20)
            Else
                If tempHeight = 0 Then
                    Me.Height = ChieuCaoMacDinh

                Else
                    Me.Height = tempHeight
                End If

                Me.Values.Image = My.Resources.Tru16
                RaiseEvent ThayDoiChieuCao(20 - Me.Height)
            End If
        Else
            If Me.Width <> 20 Then
                If DockFill Then
                    Me.Dock = DockStyle.Left
                End If
                tempWidth = Me.Width
                Me.Width = 20
                Me.Values.Image = My.Resources.Cong16
                RaiseEvent ThayDoiChieuCao(tempWidth - 20)
            Else
                If DockFill Then
                    Me.Dock = DockStyle.Fill
                End If
                If tempWidth = 0 Then
                    Me.Width = ChieuCaoMacDinh
                Else
                    Me.Width = tempWidth
                End If
                Me.Values.Image = My.Resources.Tru16
                RaiseEvent ThayDoiChieuCao(20 - Me.Width)
            End If
        End If

    End Sub

    Private _DockFill As Boolean
    Property DockFill As Boolean
        Get
            Return _DockFill
        End Get
        Set(value As Boolean)
            _DockFill = value
        End Set
    End Property
    Private _ChieuCaoMacDinh As Integer
    Property ChieuCaoMacDinh As Integer
        Get
            Return _ChieuCaoMacDinh
        End Get
        Set(value As Integer)
            _ChieuCaoMacDinh = value
        End Set
    End Property

    Private _LeftHayTop As Boolean
    Property LeftHayTop As Boolean
        Get
            Return _LeftHayTop
        End Get
        Set(value As Boolean)
            _LeftHayTop = value
            If _LeftHayTop Then
                Me.CaptionEdge = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
                Me.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left
            Else
                Me.CaptionEdge = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
                Me.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top
            End If
        End Set
    End Property


    Private _KhongMoRong As Boolean
    Property KhongMoRong As Boolean
        Get
            Return _KhongMoRong
        End Get
        Set(value As Boolean)
            _KhongMoRong = value
            If _KhongMoRong Then
                Me.Values.Image = My.Resources.DongDinh16
            Else
                If BanDauThuNho Then
                    Me.Values.Image = My.Resources.Cong16
                Else
                    Me.Values.Image = My.Resources.Tru16
                End If
            End If
        End Set
    End Property

    Private _BanDauThuNho As Boolean
    Property BanDauThuNho As Boolean
        Get
            Return _BanDauThuNho
        End Get
        Set(value As Boolean)
            _BanDauThuNho = value
            If _BanDauThuNho Then
                If Me.LeftHayTop Then
                    Me.Width = 20
                Else
                    Me.Height = 20
                End If
                Me.Values.Image = My.Resources.Cong16
            Else
                Me.Values.Image = My.Resources.Tru16
            End If
        End Set
    End Property


    Public Sub New()
        'Me.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top
        '   Me.Values.Image = My.Resources.Cong16
    End Sub

End Class
