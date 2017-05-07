Imports System.Text.RegularExpressions
Imports System.Text

Public Class VNDTextBox
    Inherits ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Property Value As Decimal
        Get
            Return Me.Tag
        End Get
        Set(value As Decimal)
            Me.Tag = value
            Me.Text = value.ToString
        End Set
    End Property

    Private Sub NumbericTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Dim temp As Decimal
    Private Sub NumbericTextbox_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        If Me.Text = "" Then Me.Text = "0"
        If Not IsNumeric(Me.Text) Then
            Dim start As Integer = Me.Text.Length - Me.SelectionStart
            Me.Text = String.Format("{0:N0}", temp)
            Me.Select(Me.TextLength, 0)
            Me.Tag = temp
        Else
            temp = CDec(Me.Text)
            Dim start As Integer = Me.Text.Length - Me.SelectionStart
            Me.Text = String.Format("{0:N0}", temp)
            If (-start + Me.Text.Length) > 0 Then Me.SelectionStart = -start + Me.Text.Length
            Me.Tag = temp
        End If
    End Sub

End Class
