Public Class frmMessageBox
    Dim result As DialogResult = DialogResult.No
    Public Overloads Function Show(NoiDung As String, TieuDe As String) As DialogResult
        Truoc = lblNoiDung.Size.Height
        lblNoiDung.Text = NoiDung
        Me.Text = TieuDe
        Me.ShowDialog()
        Return result
    End Function
    Dim Truoc As Integer = 0
    Private Sub lblNoiDung_TextChanged(sender As Object, e As EventArgs)
        Dim ChieuDai = lblNoiDung.Size.Height
        lblNoiDung.Location = New Point((Me.Width / 2 - lblNoiDung.Size.Width / 2) - 15, lblNoiDung.Location.Y)
        If Truoc - lblNoiDung.Size.Height <> 0 Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (lblNoiDung.Size.Height - Truoc))
        End If
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        result = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub frmMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNoiDung_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub frmMessageBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Y Then
            btnYes_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.N Or e.KeyCode = Keys.Escape Then
            btnNo_Click(Nothing, Nothing)
        End If
    End Sub
End Class