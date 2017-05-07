Imports System.Xml

Public Class ctrlCauHinhThongTin

    Private Sub ctrlCauHinhThongTin_Load(sender As Object, e As EventArgs) Handles Me.Load
        chkHienLogo.Checked = My.Settings.HienAnhTrenHoaDon
        pctLogo.Tag = My.Settings.DuongDanAnh
        Try
            pctLogo.Image = Image.FromFile(My.Settings.DuongDanAnh)
        Catch
        End Try
        txtSaoLuuExcel.Text = My.Settings.DuongDanLuuExcel
        txtTenCongTy.Text = My.Settings.TenCongTy
        txtThongTinLienHe.Text = My.Settings.ThongTinLienHe
        txtLoiChao.Text = My.Settings.NhacNho
        chkXacNhanTaoPhieu.Checked = My.Settings.LuonXacNhanHoaDon
        chkChonKhachHangMacDinh.Checked = My.Settings.ChonKhachHangMacDinh
        nudZoomReport.Value = My.Settings.ZoomReport
        nudSoLien.Value = My.Settings.SoLienIn
        CapNhatKieuHoaDon()
    End Sub

    Private Sub pctLogo_Click(sender As Object, e As EventArgs) Handles pctLogo.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files (*.png, *.jpg, *.bmp, *jpeg)|*.png;*.jpg;*.bmp;*.jpeg"
        If (openFile.ShowDialog) = DialogResult.OK Then
            Try
                pctLogo.Image = Image.FromFile(openFile.FileName)
                pctLogo.Tag = openFile.FileName
            Catch
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không lấy được ảnh", "Thông báo", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub btnLuuCauHinh_Click(sender As Object, e As EventArgs) Handles btnLuuCauHinh.Click

        With My.Settings
            ' Thong tin cong ty
            .TenCongTy = txtTenCongTy.Text
            .ThongTinLienHe = txtThongTinLienHe.Text
            .HienAnhTrenHoaDon = chkHienLogo.Checked
            .DuongDanAnh = pctLogo.Tag
            .DuongDanLuuExcel = txtSaoLuuExcel.Text
            ' Cau hinh bieu mau
            .LuonXacNhanHoaDon = chkXacNhanTaoPhieu.Checked
            .ChonKhachHangMacDinh = chkChonKhachHangMacDinh.Checked
            .NhacNho = txtLoiChao.Text
            .KieuHoaDon = cmbHoaDon.SelectedIndex
            .KieuPhieuNhap = cmbPhieuNhap.SelectedIndex
            .KieuPhieuXuat = cmbPhieuXuat.SelectedIndex

            .KieuDatHang = cmbDatHang.SelectedIndex
            .KieuBaoGia = cmbBaoGia.SelectedIndex
            .KieuPhieuThu = cmbPhieuThu.SelectedIndex
            .KieuPhieuChi = cmbPhieuChi.SelectedIndex
            .ZoomReport = nudZoomReport.Value
            .SoLienIn = nudSoLien.Value
        End With

        My.Settings.Save()

        Dim docXML As XmlDocument = New XmlDataDocument
        docXML.Load(Application.StartupPath + "\" + Application.ProductName + ".exe.config")
        For Each itm As XmlNode In docXML.GetElementsByTagName("setting")
            If itm.Attributes("name").Value = "TenCongTy" Then
                itm.FirstChild.InnerText = My.Settings.TenCongTy
            ElseIf itm.Attributes("name").Value = "ThongTinLienHe" Then
                itm.FirstChild.InnerText = My.Settings.ThongTinLienHe
            ElseIf itm.Attributes("name").Value = "HienAnhTrenHoaDon" Then
                itm.FirstChild.InnerText = My.Settings.HienAnhTrenHoaDon
            ElseIf itm.Attributes("name").Value = "DuongDanAnh" Then
                itm.FirstChild.InnerText = My.Settings.DuongDanAnh
            ElseIf itm.Attributes("name").Value = "NhacNho" Then
                itm.FirstChild.InnerText = My.Settings.NhacNho

            ElseIf itm.Attributes("name").Value = "KieuHoaDon" Then
                itm.FirstChild.InnerText = My.Settings.KieuHoaDon
            ElseIf itm.Attributes("name").Value = "KieuPhieuNhap" Then
                itm.FirstChild.InnerText = My.Settings.KieuPhieuNhap
            ElseIf itm.Attributes("name").Value = "KieuPhieuXuat" Then
                itm.FirstChild.InnerText = My.Settings.KieuPhieuXuat
            ElseIf itm.Attributes("name").Value = "KieuDatHang" Then
                itm.FirstChild.InnerText = My.Settings.KieuDatHang

            ElseIf itm.Attributes("name").Value = "KieuBaoGia" Then
                itm.FirstChild.InnerText = My.Settings.KieuBaoGia
            ElseIf itm.Attributes("name").Value = "KieuPhieuThu" Then
                itm.FirstChild.InnerText = My.Settings.KieuPhieuThu
            ElseIf itm.Attributes("name").Value = "KieuPhieuChi" Then
                itm.FirstChild.InnerText = My.Settings.KieuPhieuChi

            ElseIf itm.Attributes("name").Value = "ZoomReport" Then
                itm.FirstChild.InnerText = My.Settings.ZoomReport
            ElseIf itm.Attributes("name").Value = "SoLienIn" Then
                itm.FirstChild.InnerText = My.Settings.SoLienIn
            End If
        Next
        docXML.Save(Application.StartupPath + "\" + Application.ProductName + ".exe.config")

        ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Lưu cấu hình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lklQuanLyBieuMau_LinkClicked(sender As Object, e As EventArgs) Handles lklQuanLyBieuMau.LinkClicked
        frmQuanLyReport.Show()
        frmQuanLyReport.BringToFront()
    End Sub

    Private Sub lklCapNhat_LinkClicked(sender As Object, e As EventArgs) Handles lklCapNhat.LinkClicked
        CapNhatKieuHoaDon()
    End Sub

    Private Sub CapNhatKieuHoaDon()
        ' load từ database
        cmbHoaDon.DataSource = (From hd In dt.tbReports Select hd).ToList
        cmbPhieuNhap.DataSource = (From rp In dt.tbReports Select rp).ToList
        cmbPhieuXuat.DataSource = (From rp In dt.tbReports Select rp).ToList

        cmbDatHang.DataSource = (From rp In dt.tbReports Select rp).ToList
        cmbBaoGia.DataSource = (From rp In dt.tbReports Select rp).ToList
        cmbPhieuThu.DataSource = (From rp In dt.tbReports Select rp).ToList
        cmbPhieuChi.DataSource = (From rp In dt.tbReports Select rp).ToList

        If My.Settings.KieuHoaDon < cmbHoaDon.Items.Count Then cmbHoaDon.SelectedIndex = My.Settings.KieuHoaDon
        If My.Settings.KieuPhieuNhap < cmbPhieuNhap.Items.Count Then cmbPhieuNhap.SelectedIndex = My.Settings.KieuPhieuNhap
        If My.Settings.KieuPhieuXuat < cmbPhieuXuat.Items.Count Then cmbPhieuXuat.SelectedIndex = My.Settings.KieuPhieuXuat

        If My.Settings.KieuDatHang < cmbDatHang.Items.Count Then cmbDatHang.SelectedIndex = My.Settings.KieuDatHang
        If My.Settings.KieuBaoGia < cmbBaoGia.Items.Count Then cmbBaoGia.SelectedIndex = My.Settings.KieuBaoGia
        If My.Settings.KieuPhieuThu < cmbPhieuThu.Items.Count Then cmbPhieuThu.SelectedIndex = My.Settings.KieuPhieuThu
        If My.Settings.KieuPhieuChi < cmbPhieuChi.Items.Count Then cmbPhieuChi.SelectedIndex = My.Settings.KieuPhieuChi
    End Sub

    Private Sub btnDuogDan_Click(sender As Object, e As EventArgs) Handles btnDuogDan.Click
        Dim ofd As FolderBrowserDialog = New FolderBrowserDialog
        If ofd.ShowDialog = DialogResult.OK Then
            txtSaoLuuExcel.Text = ofd.SelectedPath
        End If
    End Sub
End Class
