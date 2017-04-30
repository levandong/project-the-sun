Public Class frmThongKeCongGopChiTietKhachHangDatHang
    Public lst As IQueryable(Of clsSanPhamCongGop)
    Public ThoiGian As String
    Private Sub frmThongKeCongGopChiTietKhachHangDatHang_Load(sender As Object, e As EventArgs) Handles Me.Load

        With Me.CtrlDGVSanPhamCongGop1
            .ThoiGianTimKiem = ThoiGian
            .bsDaBan.DataSource = lst
            .ToolStripSeparator3.Visible = False
            .ToolStripSeparator2.Visible = False
        End With
    End Sub
End Class