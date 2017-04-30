Public Class frmHoaDon
    Public HoaDon As New ctrlHoaDon
    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles Me.Load
        HoaDon.Dock = Dock.Fill
        Me.Controls.Add(HoaDon)
    End Sub
End Class