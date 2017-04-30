Imports Microsoft.Reporting.WinForms
Imports System.Xml
Imports System.Globalization

Public Class ctrlInHoaDon

    Public HoaDon As tbHoaDon
    Public KhachHang As tbKhachHang
    Public SoDong As Integer
    Public XemTruoc As Boolean
    Public tableChiTietHoaDon As List(Of tbChiTietHoaDon)

    Private xml As New XmlDocument
    Public Function DoiSoThanhChu(So As Double) As String
        Dim str As String = ""
        str = So.ToString("#,###,###,###,##0.###", CultureInfo.CreateSpecificCulture("vi-VN"))
        Return str
    End Function

    Public Function DoiTienThanhChu(So As Double) As String
        Dim str As String = ""
        str = So.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"))
        Return str
    End Function


    Public Sub CapNhat()
        btnCapNhat_Click(Nothing, Nothing)
    End Sub

    Private Sub frmInHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.ShowPrintButton = True
        Me.btnInHoaDon.Visible = False
        If HoaDon IsNot Nothing Then
            nudDoCaoDong.Value = My.Settings.KhoangCachHaiDongLienTiep
        End If
        nudCoChuDiaChi.Value = 11
        nudCoChuDonVi.Value = 11
        nudDoCaoDong.Value = My.Settings.KhoangCachHaiDongLienTiep
        nudSanPham.Value = 11
        nudTenKhachHang.Value = 11
        If HoaDon IsNot Nothing Then
            CapNhat()
        End If
    End Sub
    Public Sub CatTenSanPham(STT As Integer, ChiTietHoaDon As tbChiTietHoaDon)
        Dim strTenSanPhamGoc = ChiTietHoaDon.TenSanPham.Split(" ")
        Dim index = 0
        Dim strLine As String = ""
        Label1.Text = ""
        Dim DongDauTien As Boolean = True
        While index < strTenSanPhamGoc.Length
            Label1.Text = strLine + " " + strTenSanPhamGoc(index)
            If Label1.Size.Width > My.Settings.ChieuDaiOHangHoa Then

                If DongDauTien = True Then
                    tbl.AddtbChiTietHoaDonDeInRow(STT, ChiTietHoaDon.isHienSTT, strLine, True,
                                              ChiTietHoaDon.DonVi, ChiTietHoaDon.isHienDonVi,
                                              DoiSoThanhChu(ChiTietHoaDon.DonGia), ChiTietHoaDon.isHienDonGia,
                                              DoiSoThanhChu(ChiTietHoaDon.SoLuong), ChiTietHoaDon.isHienSoLuong,
                                              DoiTienThanhChu(ChiTietHoaDon.ThanhTien), ChiTietHoaDon.isHienThanhTien, ChiTietHoaDon.idHoaDon)
                    DongDauTien = False
                    SoDong += 1
                Else
                    tbl.AddtbChiTietHoaDonDeInRow("", False, strLine, True, "", False, 0, False, 0, False, 0, False, ChiTietHoaDon.idHoaDon)
                    SoDong += 1
                End If
                strLine = ""
            Else
                strLine += strTenSanPhamGoc(index) + " "
                index += 1
            End If
        End While
        If strLine.Trim <> "" Then
            If Not DongDauTien Then
                tbl.AddtbChiTietHoaDonDeInRow(STT, False, strLine, True, "", False, 0, False, 0, False, 0, False, ChiTietHoaDon.idHoaDon)
                SoDong += 1
            Else
                tbl.AddtbChiTietHoaDonDeInRow(STT, ChiTietHoaDon.isHienSTT, strLine, True,
                                              ChiTietHoaDon.DonVi, ChiTietHoaDon.isHienDonVi,
                                              DoiSoThanhChu(ChiTietHoaDon.DonGia), ChiTietHoaDon.isHienDonGia,
                                              DoiSoThanhChu(ChiTietHoaDon.SoLuong), ChiTietHoaDon.isHienSoLuong,
                                              DoiTienThanhChu(ChiTietHoaDon.ThanhTien), ChiTietHoaDon.isHienThanhTien, ChiTietHoaDon.idHoaDon)
                SoDong += 1
            End If
        End If
    End Sub


    Dim tbl As New dsQL.tbChiTietHoaDonDeInDataTable
    Public Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If HoaDon Is Nothing Then Exit Sub

        tbl.Clear()
        Dim strReport As String = ""
        If chkInHoaDonMau.Checked Then
            strReport = Application.StartupPath + "\Report\HoaDon\rptBangInMau.rdlc"
        Else
            strReport = Application.StartupPath + "\Report\HoaDon\rptHoaDon.rdlc"
        End If

        Label1.Font = New Font("Times New Roman", nudSanPham.Value)
        Me.ReportViewer1.Reset()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        ReportViewer1.LocalReport.EnableExternalImages = True

        SoDong = 0

        Dim ds As New ReportDataSource
        ds.Name = "dsHoaDon"

        Dim STT As Integer = 0

        If XemTruoc Then
            For Each itm In tableChiTietHoaDon
                If itm.TheLoai <> THEOLOAICHITIETHOADON.GHICHU And itm.TheLoai <> THEOLOAICHITIETHOADON.TENSANPHAMDACBIET Then
                    STT += 1
                End If
                CatTenSanPham(STT, itm)
            Next
            ds.Value = tbl
        Else
            tableChiTietHoaDon = (From itm In dt.tbChiTietHoaDons
                                  Where itm.idHoaDon = HoaDon.id
                                  Select itm
                                  Order By itm.SoThuTu).ToList
            For Each itm In tableChiTietHoaDon
                If itm.TheLoai <> THEOLOAICHITIETHOADON.GHICHU And itm.TheLoai <> THEOLOAICHITIETHOADON.TENSANPHAMDACBIET Then
                    STT += 1
                End If
                CatTenSanPham(STT, itm)
            Next
            ds.Value = tbl
        End If

        If SoDong > My.Settings.SoDongToiDa Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Số dòng vượt quá " + My.Settings.SoDongToiDa.ToString + " dòng. Bạn có muốn in hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
                Exit Sub
            End If
        End If

        If Not chkInHoaDonMau.Checked Then
            xml.Load(strReport)
            Dim dongGach As XmlNode = xml.GetElementsByTagName("Line").Item(1)
            Dim ChieuCao As Double = (My.Settings.SoDongToiDa - SoDong) * nudDoCaoDong.Value
            If ChieuCao < 0 Then ChieuCao = 0
            If SoDong >= My.Settings.SoDongToiDa - 1 Then
                dongGach.ChildNodes(2).InnerXml = "0cm"
            Else
                Dim str As String = ChieuCao.ToString
                Try
                    dongGach.ChildNodes(2).InnerXml = str.Substring(0, 4).Replace(",", ".") + "cm"
                Catch ex As Exception
                    dongGach.ChildNodes(2).InnerXml = str.Replace(",", ".") + "cm"
                End Try
            End If
            xml.Save(strReport)
        End If

        Me.ReportViewer1.LocalReport.ReportPath = strReport
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(ds)
        ReportViewer1.LocalReport.SetParameters(DanhSachThamSo(HoaDon, SoDong))
        ReportViewer1.RefreshReport()

    End Sub

    Public Function DanhSachThamSo(hd As tbHoaDon, soDong As Integer) As ReportParameterCollection
        Dim lstParameters As New ReportParameterCollection
        With lstParameters
            ' truyen thong tin cong ty vao report
            .Add(New ReportParameter("DienThoaiCongTy", My.Settings.DienThoai))
            .Add(New ReportParameter("SoFaxCongTy", My.Settings.Fax))
            .Add(New ReportParameter("SoTaiKhoanCongTy", My.Settings.SoTaiKhoan))
            .Add(New ReportParameter("MaSoThueCongTy", My.Settings.MaSoThue))
            .Add(New ReportParameter("EmailCongTy", My.Settings.EmailCongTy))
            .Add(New ReportParameter("WebsiteCongTy", My.Settings.WebsiteCongTy))
            .Add(New ReportParameter("DiaChiCongTy", My.Settings.DiaChi))

            ' Thong tin hoa don
            .Add(New ReportParameter("SoHoaDon", hd.SoHoaDon))
            .Add(New ReportParameter("NgayLap", hd.NgayLap))
            .Add(New ReportParameter("ThueGTGT", hd.VAT))
            .Add(New ReportParameter("HinhThucThanhToan", hd.HinhThucThanhToan))

            .Add(New ReportParameter("CongTien", DoiTienThanhChu(hd.TienTruocThue)))
            .Add(New ReportParameter("TienThue", DoiTienThanhChu((hd.TienTruocThue * hd.VAT / 100))))
            .Add(New ReportParameter("TongTien", DoiTienThanhChu(hd.TienTruocThue * (100 + hd.VAT) / 100)))
            .Add(New ReportParameter("CoVAT", hd.CoVAT))

            ' Thong tin khách hàng

            .Add(New ReportParameter("TenNguoiBanHang", ""))
            .Add(New ReportParameter("TenKhachHang", ""))
            .Add(New ReportParameter("SoDienThoaiKhachHang", ""))
            .Add(New ReportParameter("TenDonVi", hd.tbKhachHang.TenRutGon))

            If hd.SoTaiKhoan.Trim = "" Then
                Label1.Font = New Font("Times New Roman", nudCoChuDiaChi.Value)
                Label1.Text = hd.DiaChi

                If Label1.Size.Width > My.Settings.ChieuDaiODiaChi Then
                    Dim str1 As String = ""
                    Dim str2 As String = ""
                    For Each itm In hd.DiaChi.Split(" ")
                        Label1.Text = str1 + itm
                        If Label1.Size.Width <= My.Settings.ChieuDaiODiaChi Then
                            str1 += itm + " "
                            Continue For
                        Else
                            str1 = str1.Trim
                            str2 = hd.DiaChi.Substring(str1.Length, hd.DiaChi.Length - str1.Length)
                            Exit For
                        End If
                    Next
                    .Add(New ReportParameter("DiaChiKhachHang", str1.Trim))
                    .Add(New ReportParameter("SoTaiKhoanKH", str2))
                Else
                    .Add(New ReportParameter("DiaChiKhachHang", hd.DiaChi))
                    .Add(New ReportParameter("SoTaiKhoanKH", hd.SoTaiKhoan))
                End If
            Else
                .Add(New ReportParameter("SoTaiKhoanKH", hd.SoTaiKhoan))
                .Add(New ReportParameter("DiaChiKhachHang", hd.DiaChi))
            End If


            Dim strMaSoThue As String = ""
            For index As Integer = 0 To hd.tbKhachHang.MaSoThue.Length - 1
                strMaSoThue += hd.tbKhachHang.MaSoThue(index).ToString + " "
            Next
            .Add(New ReportParameter("MaSoThueKH", strMaSoThue))

            Try
                For index As Integer = 0 To 14
                    If index = 0 Then
                        .Add(New ReportParameter("Mot", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 1 Then
                        .Add(New ReportParameter("Hai", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 2 Then
                        .Add(New ReportParameter("Ba", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 3 Then
                        .Add(New ReportParameter("Bon", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 4 Then
                        .Add(New ReportParameter("Nam", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 5 Then
                        .Add(New ReportParameter("Sau", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 6 Then
                        .Add(New ReportParameter("Bay", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 7 Then
                        .Add(New ReportParameter("Tam", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 8 Then
                        .Add(New ReportParameter("Chin", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 9 Then
                        .Add(New ReportParameter("Muoi", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 10 Then
                        .Add(New ReportParameter("MuoiMot", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 11 Then
                        .Add(New ReportParameter("MuoiHai", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 12 Then
                        .Add(New ReportParameter("MuoiBa", hd.tbKhachHang.MaSoThue(index)))
                    ElseIf index = 13 Then
                        .Add(New ReportParameter("MuoiBon", hd.tbKhachHang.MaSoThue(index)))
                    End If

                Next
            Catch ex As Exception

            End Try
            Dim TongTien As Decimal = tableChiTietHoaDon.Sum(Function(s) s.ThanhTien) * hd.VAT
            Dim strTienChu = Number2Text.Number2Text.Num2Text(Math.Round(TongTien))
            Label1.Font = New Font("Times New Roman", 11)
            Label1.Text = strTienChu
            If Label1.Size.Width > My.Settings.ChieuDaiOTienChu Then
                Dim str1 As String = ""
                Dim str2 As String = ""
                For Each itm In strTienChu.Split(" ")
                    Label1.Text = str1 + itm
                    If Label1.Size.Width <= My.Settings.ChieuDaiOTienChu Then
                        str1 += itm + " "
                        Continue For
                    Else
                        str1 = str1.Trim
                        str2 = strTienChu.Substring(str1.Length, strTienChu.Length - str1.Length)
                        Exit For
                    End If
                Next
                .Add(New ReportParameter("TienChu", str1.Trim))
                .Add(New ReportParameter("TienChu2", str2))
            Else
                .Add(New ReportParameter("TienChu", strTienChu))
            End If
            ' Thong tin khác
            If My.Settings.HienDuongGachCuoi Then
                .Add(New ReportParameter("HienDuongGachCuoi", If(soDong >= (My.Settings.SoDongToiDa), False, True)))
            Else
                .Add(New ReportParameter("HienDuongGachCuoi", False))
            End If
            .Add(New ReportParameter("FontSizeTenKhachHang", nudTenKhachHang.Value.ToString.Replace(",", ".") + "pt"))
            .Add(New ReportParameter("FontSizeTenDonVi", nudCoChuDonVi.Value.ToString.Replace(",", ".") + "pt"))
            .Add(New ReportParameter("FontSizeDiaChi", nudCoChuDiaChi.Value.ToString.Replace(",", ".") + "pt"))
            .Add(New ReportParameter("FontSizeSanPham", nudSanPham.Value.ToString.Replace(",", ".") + "pt"))
        End With
        Return lstParameters
    End Function
    Event InThanhCong(HoaDon As tbHoaDon)

    Private Sub chkInHoaDonMau_CheckedChanged(sender As Object, e As EventArgs) Handles chkInHoaDonMau.CheckedChanged
        btnCapNhat_Click(Nothing, Nothing)
    End Sub

    Private Sub btnInHoaDon_Click(sender As Object, e As EventArgs) Handles btnInHoaDon.Click
        If XacNhanYesNo("Bạn có muốn in hóa đơn hay không?") = MsgBoxResult.Yes Then
            Dim InTuDong As New mdlPrintReport
            RaiseEvent InThanhCong(HoaDon)
        End If
    End Sub
End Class