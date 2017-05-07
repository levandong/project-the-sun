Public Class frmThongTinPhanMem


    Private Sub frmThongTinPhanMem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.TuDongKiemTraCapNhat = chkTuDongKiemTraCapNhat.Checked
        My.Settings.Save()
    End Sub
    Private Sub frmThongTinPhanMem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPhienBanCu.Text = Application.ProductVersion
        lblCopyRight.Text = My.Application.Info.Copyright
        chkTuDongKiemTraCapNhat.Checked = My.Settings.TuDongKiemTraCapNhat

    End Sub

    Private Sub lnkCapNhat_LinkClicked(sender As Object, e As EventArgs) Handles lnkCapNhat.LinkClicked
        mdlGlobals.UpdatePhanMem(True)
    End Sub
End Class