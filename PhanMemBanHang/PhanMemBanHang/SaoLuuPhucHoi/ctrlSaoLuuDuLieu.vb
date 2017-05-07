Imports System.IO
Imports System.Xml

Public Class ctrlSaoLuuDuLieu

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If chkSaoLuuHangTuan.Checked Then
            If cmbThuSaoLuu.SelectedItem Is Nothing Then
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn thứ để sao lưu hàng tuần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        With My.Settings
            .SaoLuuHangTuan = chkSaoLuuHangTuan.Checked
            .SaoLuuKhiDangNhap = chkSaoLuuKhiDangNhap.Checked
            .SaoLuuKhiTatChuongTrinh = chkSaoLuuKhiTat.Checked
            .CoBak10Ngay = chkXoa10Ngay.Checked
            .CoBak30Ngay = chkXoa30Ngay.Checked
            .SaoLuuVaoThuMay = cmbThuSaoLuu.SelectedIndex
            .DuongDanFileBackup = txtDuongDan.Text
        End With
        My.Settings.Save()

        Dim docXML As XmlDocument = New XmlDataDocument
        docXML.Load(".\" + Application.ProductName + ".exe.config")
        For Each itm As XmlNode In docXML.GetElementsByTagName("setting")
            If itm.Attributes("name").Value = "SaoLuuHangTuan" Then
                itm.FirstChild.InnerXml = My.Settings.SaoLuuHangTuan
            ElseIf itm.Attributes("name").Value = "SaoLuuKhiDangNhap" Then
                itm.FirstChild.InnerXml = My.Settings.SaoLuuKhiDangNhap
            ElseIf itm.Attributes("name").Value = "SaoLuuKhiTatChuongTrinh" Then
                itm.FirstChild.InnerXml = My.Settings.SaoLuuKhiTatChuongTrinh
            ElseIf itm.Attributes("name").Value = "CoBak10Ngay" Then
                itm.FirstChild.InnerXml = My.Settings.CoBak10Ngay
            ElseIf itm.Attributes("name").Value = "CoBak30Ngay" Then
                itm.FirstChild.InnerXml = My.Settings.CoBak30Ngay
            ElseIf itm.Attributes("name").Value = "SaoLuuVaoThuMay" Then
                itm.FirstChild.InnerXml = My.Settings.SaoLuuVaoThuMay
            ElseIf itm.Attributes("name").Value = "DuongDanFileBackup" Then
                itm.FirstChild.InnerXml = My.Settings.DuongDanFileBackup
            End If
        Next
        docXML.Save(".\" + Application.ProductName + ".exe.config")

        ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Lưu cấu hình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ctrlSaoLuuDuLieu_Load(sender As Object, e As EventArgs) Handles Me.Load
        chkSaoLuuHangTuan.Checked = My.Settings.SaoLuuHangTuan
        chkSaoLuuKhiDangNhap.Checked = My.Settings.SaoLuuKhiDangNhap
        chkSaoLuuKhiTat.Checked = My.Settings.SaoLuuKhiTatChuongTrinh
        chkXoa10Ngay.Checked = My.Settings.CoBak10Ngay
        chkXoa30Ngay.Checked = My.Settings.CoBak30Ngay
        cmbThuSaoLuu.SelectedIndex = My.Settings.SaoLuuVaoThuMay
        txtDuongDan.Text = My.Settings.DuongDanFileBackup
    End Sub

    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = txtDuongDan.Text
        dialog.Description = "Select Directory..."
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDuongDan.Text = dialog.SelectedPath
        End If
    End Sub
End Class
