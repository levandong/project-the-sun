
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports Tmt.Toolkit
Imports System.Math

Public Class ctrlNhapSanPhamTuFileExcel
    Private xlApp As Application
    Private xlWorkBook As Excel.Workbook
    Private xlWorkSheet As Excel.Worksheet
    Event NhapSanPhamThanhCong()
    Private Sub btnChonFileExcel_Click(sender As Object, e As EventArgs) Handles btnChonFileExcel.Click
        Dim opFile As New OpenFileDialog
        opFile.Title = "Chọn file excel để nhập dữ liệu"
        opFile.Filter = "File excel (*.xls; *.xlsx)|*.xls; *.xlsx"
        If opFile.ShowDialog = DialogResult.OK Then
            txtDuongDanFile.Text = System.IO.Path.GetFileName(opFile.FileName)
            txtDuongDanFile.Tag = opFile.FileName
        End If
    End Sub

    Private lstSanPham As New List(Of tbSanPham)
    Private Sub btnNhapSanPham_Click(sender As Object, e As EventArgs) Handles btnNhapSanPham.Click
        My.Application.DoEvents()
        KryptonRichTextBox1.Clear()
        lstSanPham.Clear()

        If System.IO.File.Exists(txtDuongDanFile.Tag) = False Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn file excel thích hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim MaSanPham, MaVach, TenSanPham, DonVi, GiaNhap, GiaNhapQC, GiaBan, GiaBanQC,
            QuyCach, GioiHanTon, MoTa, MaLoai, TonKho As Integer

        'A> Mã Sản Phẩm
        'B> Mã Vạch
        'C> Tên Sản Phẩm
        'D> Đơn Vị
        'e> Giá Nhập
        'F> Giá Nhập QC
        'G> Giá Bán
        'H> Giá Bán QC
        'i> Quy Cách
        'J> Giới Hạn Tồn
        'K> Mô Tả
        'L> Mã Loại Sản Phẩm
        'M> Tồn Kho

        For Each itm In lstBoxCotTuongUng.Items
            If itm.ToString.Contains("Mã Sản Phẩm") Then
                MaSanPham = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Mã Vạch") Then
                MaVach = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Tên Sản Phẩm") Then
                TenSanPham = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Đơn Vị") Then
                DonVi = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Giá Nhập") Then
                GiaNhap = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Giá Nhập QC") Then
                GiaNhapQC = Asc(itm.ToString.Split(">")(0)) - 64

            ElseIf itm.ToString.Contains("Giá Bán") Then
                GiaBan = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Giá Bán QC") Then
                GiaBanQC = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Quy Cách") Then
                QuyCach = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Giới Hạn Tồn") Then
                GioiHanTon = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Mô Tả") Then
                MoTa = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Mã Loại Sản Phẩm") Then
                MaLoai = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Tồn Kho") Then
                TonKho = Asc(itm.ToString.Split(">")(0)) - 64
            End If
        Next

        If (MaSanPham * TenSanPham * DonVi) = 0 Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Yêu cầu phải có những trường bắt buộc (Mã sản phẩm, Tên sản phẩm, đơn vị)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        KryptonRichTextBox1.AppendText("[" + Now.ToString("dd/MM/yyyy HH:mm:ss") + "] Nhập danh sách sản phẩm từ file: " + txtDuongDanFile.Text.Trim + vbNewLine)
        xlApp = New Application
        Dim oldCI As System.Globalization.CultureInfo = _
            System.Threading.Thread.CurrentThread.CurrentCulture
        Dim fc As New System.Globalization.CultureInfo(dudNgonNgu.Text, True)
        System.Threading.Thread.CurrentThread.CurrentCulture = fc
        System.Threading.Thread.CurrentThread.CurrentUICulture = fc

        xlWorkBook = xlApp.Workbooks.Open(txtDuongDanFile.Tag.Trim)
        xlWorkSheet = xlWorkBook.Worksheets(nudSheet.Value)

       

        Dim counter As Integer = 0
        Dim i As Integer = nudDongBatDau.Value

        While (i <= nudSoDongCanNhap.Value)
            Try
                'Kiễm tra tên sp rỗng
                If xlWorkSheet.Cells(i, TenSanPham).value Is Nothing Then
                    KryptonRichTextBox1.AppendText("  >> Dòng thông tin thứ " + i.ToString + " rỗng. Bỏ qua dòng này." + vbNewLine)
                    If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Dòng thông tin thứ " + i.ToString + " rỗng. Bạn muốn tiếp tục ?" _
                                                                               + vbNewLine + "Note: Mã sản phẩm, tên sản phẩm, đơn vị không được trống trong file excel.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        i += 1
                        Continue While
                        KryptonRichTextBox1.AppendText("    >> Tiếp tục." + vbNewLine)
                    Else
                        KryptonRichTextBox1.AppendText("    >> Thoát." + vbNewLine)
                        Exit While
                    End If
                End If

                Dim SanPham As New tbSanPham
                With SanPham
                    .MaSanPham = xlWorkSheet.Cells(i, MaSanPham).value
                    .MaSanPhamString = mdlGlobals.BoDauTiengViet(.MaSanPham.Trim).ToLower
                    .TenSanPham = xlWorkSheet.Cells(i, TenSanPham).value
                    .TenSanPhamString = mdlGlobals.BoDauTiengViet(.TenSanPham.Trim).ToLower
                    .MaVachSanPham = xlWorkSheet.Cells(i, MaVach).value
                    .DonVi = xlWorkSheet.Cells(i, DonVi).value

                    'If xlWorkSheet.Cells(i, GiaNhap).value IsNot Nothing Then
                    '    .GiaNhap = Math.Round(xlWorkSheet.Cells(i, GiaNhap).value, 0, MidpointRounding.AwayFromZero)
                    '    .GiaBinhQuan = Math.Round(xlWorkSheet.Cells(i, GiaNhap).value, 0, MidpointRounding.AwayFromZero)
                    'Else
                    '    .GiaBinhQuan = 0
                    '    .GiaNhap = 0
                    'End If

                    If xlWorkSheet.Cells(i, GiaNhapQC).value IsNot Nothing Then
                        .GiaNhapQuyCach = Math.Round(xlWorkSheet.Cells(i, GiaNhapQC).value, 0, MidpointRounding.AwayFromZero)
                    Else
                        .GiaNhapQuyCach = 0
                    End If

                    'If xlWorkSheet.Cells(i, GiaBan).value IsNot Nothing Then
                    '    .GiaBan = Math.Round(xlWorkSheet.Cells(i, GiaBan).value, 0, MidpointRounding.AwayFromZero)
                    'Else
                    '    .GiaBan = .GiaNhap
                    'End If

                    If xlWorkSheet.Cells(i, GiaBanQC).value IsNot Nothing Then
                        .GiaQuyCach = Math.Round(xlWorkSheet.Cells(i, GiaBanQC).value, 0, MidpointRounding.AwayFromZero)
                    Else
                        .GiaQuyCach = 0
                    End If

                    If xlWorkSheet.Cells(i, GioiHanTon).value IsNot Nothing Then
                        .TonMin = xlWorkSheet.Cells(i, GioiHanTon).value
                    Else
                        .TonMin = 0
                    End If

                    If xlWorkSheet.Cells(i, QuyCach).value IsNot Nothing Then
                        .QuyCach = xlWorkSheet.Cells(i, QuyCach).value
                    Else
                        .QuyCach = 1
                    End If

                    Dim MaLoaiSanPham As String = xlWorkSheet.Cells(i, MaLoai).value
                    Dim Loai = dt.tbLoaiSanPhams.FirstOrDefault(Function(s) s.MaLoaiSanPham = MaLoaiSanPham)
                    If Loai IsNot Nothing Then
                        .idLoaiSanPham = Loai.id
                    Else
                        .idLoaiSanPham = CType(cmbLoaiSanPham.SelectedItem, tbLoaiSanPham).id
                    End If
                    .MoTa = xlWorkSheet.Cells(i, MoTa).value
                    .HetBan = False
                    .NgayTao = Now
                End With

                dt.tbSanPhams.InsertOnSubmit(SanPham)
                Try
                    dt.SubmitChanges()
                    lstSanPham.Add(SanPham)
                Catch ex As Exception
                    KryptonRichTextBox1.AppendText(" Lỗi: " + ex.Message.ToString + vbNewLine)
                    undoChange()
                End Try
                KryptonRichTextBox1.AppendText("  >> Nhập dòng " + i.ToString + " thành công" + vbNewLine)
                i += 1
            Catch ex As Exception
                KryptonRichTextBox1.AppendText("  >> Không thêm được dòng " + i.ToString + vbNewLine + "Lỗi: " + ex.ToString + vbNewLine)
                If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thêm được dòng " + i.ToString + vbNewLine + "Bạn có muốn tiếp tục?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    KryptonRichTextBox1.AppendText("    >> Tiếp tục." + vbNewLine)
                    undoChange()
                    i += 1
                Else
                    KryptonRichTextBox1.AppendText("    >> Thoát." + vbNewLine)
                    Exit While
                End If
            End Try
        End While

        If chkNhapHangTonKho.Checked Then
            Dim rlsSanPham = From itm In lstSanPham
                             Where itm.SoLuong > 0

            If rlsSanPham.Count > 0 Then
                Dim newPhieuNhap As New tbPhieuNhap
                With newPhieuNhap
                    .idLoaiPhieuNhap = dt.tbLoaiPhieuNhaps.First(Function(s) s.Loai = ELoaiPhieuNhap.NhapDieuChinh).id
                    .SoPhieu = LaySoPhieuNhap()
                    .NgayLap = Now
                    .idNhanVien = loginNhanVien.id
                    .GhiChu = "Nhập hàng tồn đầu kỳ: " + Now.ToString("dd/MM/yyyy")

                    Dim newChitietNhap As tbChiTietPhieuNhap
                    For Each itm In rlsSanPham
                        newChitietNhap = New tbChiTietPhieuNhap
                        With newChitietNhap
                            .TheoDonVi = True
                            .idSanPham = itm.id
                            .SoLuong = itm.SoLuong
                            .DonGia = itm.GiaNiemYet
                            newPhieuNhap.tbChiTietPhieuNhaps.Add(newChitietNhap)
                        End With
                    Next
                End With
                dt.tbPhieuNhaps.InsertOnSubmit(newPhieuNhap)
                dt.SubmitChanges()
            End If

            Dim rlsXuat = From itm In lstSanPham
                             Where itm.SoLuong < 0

            If rlsXuat.Count > 0 Then
                Dim newPhieuXuat As New tbPhieuXuat
                With newPhieuXuat
                    .idLoaiPhieuXuat = dt.tbLoaiPhieuXuats.First(Function(s) s.Loai = ELoaiPhieuXuat.XuatDieuChinh).id
                    .SoPhieuXuat = LaySoPhieuXuat()
                    .NgayLap = Now
                    .idNhanVien = loginNhanVien.id
                    .GhiChu = "Xuất hàng tồn: " + Now.ToString("dd/MM/yyyy")

                    Dim newChitietXuat As tbChiTietPhieuXuat
                    For Each itm In rlsXuat
                        newChitietXuat = New tbChiTietPhieuXuat
                        With newChitietXuat
                            .TheoDonVi = True
                            .idSanPham = itm.id
                            .SoLuong = Math.Abs(itm.SoLuong)
                            .DonGia = itm.GiaNiemYet
                            newPhieuXuat.tbChiTietPhieuXuats.Add(newChitietXuat)
                        End With
                    Next
                End With
                dt.tbPhieuXuats.InsertOnSubmit(newPhieuXuat)
                dt.SubmitChanges()
            End If
        End If

        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Dim newColumIndex As Integer() = New Integer() {MaSanPham, MaVach, TenSanPham, DonVi, GiaNhap, GiaNhapQC, GiaBan, GiaBanQC,
                                                        QuyCach, GioiHanTon, MoTa, MaLoai}
        For j = 1 To i
            For Each itm In newColumIndex
                If itm <= 0 Then Continue For
                releaseObject(xlWorkSheet.Cells(j, itm))
            Next
        Next

        xlApp.Quit()
        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        RaiseEvent NhapSanPhamThanhCong()
    End Sub

    Private Function LaySoPhieuNhap() As Integer
        If dt.tbPhieuNhaps.Count = 0 Then Return 1
        Dim PhieuNhapCuNhat = (From itm In dt.tbPhieuNhaps
                                  Where itm.NgayLap.Year = Now.Year
                                  Where itm.NgayLap.Month = Now.Month
                                  Select itm Order By itm.id Descending).FirstOrDefault
        If PhieuNhapCuNhat Is Nothing Then Return 1
        Return PhieuNhapCuNhat.SoPhieu + 1
    End Function

    Private Function LaySoPhieuXuat() As Integer
        If dt.tbPhieuXuats.Count = 0 Then Return 1
        Dim PhieuXuatCuNhat = (From itm In dt.tbPhieuXuats
                                  Where itm.NgayLap.Year = Now.Year
                                  Where itm.NgayLap.Month = Now.Month
                                  Select itm Order By itm.id Descending).FirstOrDefault
        If PhieuXuatCuNhat Is Nothing Then Return 1
        Return PhieuXuatCuNhat.SoPhieuXuat + 1
    End Function

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub KryptonRichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles KryptonRichTextBox1.TextChanged
        KryptonRichTextBox1.SelectionStart = KryptonRichTextBox1.Text.Length
        KryptonRichTextBox1.ScrollToCaret()
    End Sub

    Private Sub ctrlNhapSanPhamTuFileExcel_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbLoaiSanPham.DataSource = From itm In dt.tbLoaiSanPhams
                                    Select itm Order By itm.TenLoaiSanPham
    End Sub

    Private Sub lnkFileMau_LinkClicked(sender As Object, e As EventArgs) Handles lnkFileMau.LinkClicked
        Try
            Process.Start(".\FileExcelMau\SANPHAM.xls")
        Catch ex As Exception

        End Try
    End Sub

End Class
