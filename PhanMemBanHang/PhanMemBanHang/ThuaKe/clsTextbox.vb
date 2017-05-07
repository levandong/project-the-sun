Imports System.ComponentModel

Public Class clsTextbox
    Inherits ComponentFactory.Krypton.Toolkit.KryptonTextBox

 Public Sub New()
        MyBase.New()
        Me.StateCommon.Content.Font = New System.Drawing.Font(DefaultFont.FontFamily, 12, FontStyle.Italic)
        Me.StateCommon.Content.Color1 = Color.Gray
        Me.TextGoiY = "Nhập nội dung ở đây..."
    End Sub

    Private _TextGoiY As String
    Property TextGoiY As String
        Get
            Return _TextGoiY
        End Get
        Set(value As String)
            _TextGoiY = value
            Me.Text = _TextGoiY
        End Set
    End Property

    Public Sub txtTenChuDe_GotFocus() Handles Me.GotFocus
        If Me.Text = _TextGoiY Then
            Me.Text = ""
            Me.StateCommon.Content.Color1 = Nothing
            Me.StateCommon.Content.Font = New Font(Me.StateCommon.Content.Font.FontFamily, Me.StateCommon.Content.Font.Size, FontStyle.Regular)
        Else
            ' giữ nguyên 
        End If
    End Sub
    Private Sub txtTenChuDe_LostFocus() Handles Me.LostFocus
        If Me.Text = _TextGoiY Then
            ' giữ nguyên 
        ElseIf Me.Text.Trim = "" Then
            Me.Text = _TextGoiY
            Me.StateCommon.Content.Color1 = Color.Gray
            Me.StateCommon.Content.Font = New Font(Me.StateCommon.Content.Font.FontFamily, Me.StateCommon.Content.Font.Size, FontStyle.Italic)
        Else
            ' giữ nguyên 
        End If
    End Sub


    ReadOnly Property GetText As String
        Get
            If Me.Text = _TextGoiY Then
                Return ""
            Else
                Return Me.Text
            End If
        End Get
    End Property

    WriteOnly Property SetText As String
        Set(value As String)
            If value = "" Then Exit Property
            Me.StateCommon.Content.Color1 = Nothing
            Me.StateCommon.Content.Font = New Font(Me.StateCommon.Content.Font.FontFamily, Me.StateCommon.Content.Font.Size, FontStyle.Regular)
            Me.Text = value
        End Set
    End Property


    Public Sub BaoThieu()
        If Me.Text.Trim = "" Or Me.Text = TextGoiY Then
            Me.Focus()
            Me.StateCommon.Border.Color1 = Color.Red
        End If
    End Sub

    Public Sub SetRong()
        Me.Text = ""
        txtTenChuDe_LostFocus()
    End Sub

    Private Sub clsTextbox_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        If Me.Text.Trim <> "" And Me.Text <> TextGoiY Then
            If Me.StateCommon.Border.Color1 = Color.Red Then
                Me.StateCommon.Border.Color1 = Nothing

            End If
        End If
    End Sub
End Class
