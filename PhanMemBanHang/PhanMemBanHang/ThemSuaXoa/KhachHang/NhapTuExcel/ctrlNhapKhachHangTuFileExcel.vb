
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports Tmt.Toolkit
Imports System.Math
Imports System.Runtime.InteropServices

Public Class ctrlNhapKhachHangTuFileExcel
    Private xlApp As Application
    Private xlWorkBook As Excel.Workbook
    Private xlWorkSheet As Excel.Worksheet

    Private Sub btnChonFileExcel_Click(sender As Object, e As EventArgs) Handles btnChonFielExcel.Click
        Dim opFile As New OpenFileDialog
        opFile.Title = "Chọn file excel để nhập dữ liệu"
        opFile.Filter = "File excel (*.xls; *.xlsx)|*.xls; *.xlsx"
        If opFile.ShowDialog = DialogResult.OK Then
            txtDuongDanFile.Text = System.IO.Path.GetFileName(opFile.FileName)
            txtDuongDanFile.Tag = opFile.FileName
        End If
    End Sub

    Private Sub btnNhapKhachHang_Click(sender As Object, e As EventArgs) Handles btnNhapKhachHang.Click
        My.Application.DoEvents()
        KryptonRichTextBox1.Clear()

        If System.IO.File.Exists(txtDuongDanFile.Tag) = False Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn file excel thích hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, _
            CongNoDauKy, MaSoThue, Fax, Email, CongNoMax, NhomKhachHang As Integer

        For Each itm In lstBoxCotTuongUng.Items
            If itm.ToString.Contains("Mã Khách Hàng") Then
                MaKhachHang = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Tên Khách Hàng") Then
                TenKhachHang = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Số Điện Thoại") Then
                SoDienThoai = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Địa Chỉ") Then
                DiaChi = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Công Nợ Đầu Kỳ") Then
                CongNoDauKy = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Mã Số Thuế") Then
                MaSoThue = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Fax") Then
                Fax = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Email") Then
                Email = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Công Nợ Max") Then
                CongNoMax = Asc(itm.ToString.Split(">")(0)) - 64
            ElseIf itm.ToString.Contains("Nhóm Khách Hàng") Then
                NhomKhachHang = Asc(itm.ToString.Split(">")(0)) - 64
            End If
        Next

        KryptonRichTextBox1.AppendText("[" + Now.ToString("dd/MM/yyyy HH:mm:ss") + "] Nhập danh sách khách hàng từ file: " + txtDuongDanFile.Text.Trim + vbNewLine)
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
                If xlWorkSheet.Cells(i, TenKhachHang).value Is Nothing Then
                    KryptonRichTextBox1.AppendText("  >> Dòng thông tin thứ " + i.ToString + " rỗng." + vbNewLine)
                    If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Dòng thông tin thứ " + i.ToString + " rỗng. Bạn muốn tiếp tục ?" _
                                                                               + vbNewLine + "Note: Tên khách hàng không được trống trong file excel.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        i += 1
                        Continue While
                        KryptonRichTextBox1.AppendText("    >> Tiếp tục." + vbNewLine)
                    Else
                        KryptonRichTextBox1.AppendText("    >> Thoát." + vbNewLine)
                        Exit While
                    End If
                End If

                Dim KhachHang As New tbKhachHang
                With KhachHang
                    If xlWorkSheet.Cells(i, MaKhachHang).value IsNot Nothing Then
                        .MaKhachHang = xlWorkSheet.Cells(i, MaKhachHang).value
                    Else
                        .MaKhachHang = xlWorkSheet.Cells(i, TenKhachHang).value
                    End If

                    .TenKhachHang = xlWorkSheet.Cells(i, TenKhachHang).value
                    .TenKhachHangString = mdlGlobals.BoDauTiengViet(.TenKhachHang).Trim.ToLower
                    .DiaChi = xlWorkSheet.Cells(i, DiaChi).value
                    .SoDienThoai = xlWorkSheet.Cells(i, SoDienThoai).value
                    If xlWorkSheet.Cells(i, CongNoDauKy).value IsNot Nothing Then
                        .CongNoDauKy = xlWorkSheet.Cells(i, CongNoDauKy).value
                    Else
                        .CongNoDauKy = 0
                    End If
                    .Email = xlWorkSheet.Cells(i, Email).value
                    .SoFAX = xlWorkSheet.Cells(i, Fax).value
                    .MaSoThue = xlWorkSheet.Cells(i, MaSoThue).value

                    If xlWorkSheet.Cells(i, CongNoMax).value IsNot Nothing Then
                        .CongNoMax = xlWorkSheet.Cells(i, CongNoMax).value
                    Else
                        .CongNoMax = 300000000
                    End If
                    .NgayNhap = Now
                    .NgayTraNo = 90

                    Dim strNhom As String = xlWorkSheet.Cells(i, NhomKhachHang).value
                    Dim Nhom = dt.tbNhomKhachHangs.FirstOrDefault(Function(s) s.GhiChu = strNhom)
                    If Nhom IsNot Nothing Then
                        .idNhomKhachHang = Nhom.id
                    Else
                        .idNhomKhachHang = CType(cmbNhomKhachHang.SelectedItem, tbNhomKhachHang).id
                    End If
                End With

                dt.tbKhachHangs.InsertOnSubmit(KhachHang)
                Try
                    dt.SubmitChanges()
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

        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

        Dim newColumIndex As Integer() = New Integer() {MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, _
                                                        CongNoDauKy, MaSoThue, Fax, Email, CongNoMax, NhomKhachHang}
        For j = 1 To i
            For Each itm In newColumIndex
                If itm <= 0 Then
                    Continue For
                Else
                    releaseObject(xlWorkSheet.Cells(j, itm))
                End If
            Next
        Next

        xlApp.Quit()
        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)
        RaiseEvent NhapKhachHangThanhCong()
    End Sub

    Private Function LayMaKhachHang() As String
        Dim KhachHangMoiNhat As tbKhachHang = (From itm In dt.tbKhachHangs
                                               Order By CInt(itm.MaKhachHang) Descending).FirstOrDefault
        If KhachHangMoiNhat IsNot Nothing Then
            Return (CInt(KhachHangMoiNhat.MaKhachHang) + 1).ToString.PadLeft(7, "0")
        Else
            Return "0000001"
        End If
    End Function

    Event NhapKhachHangThanhCong()
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

    Private Sub lnkFileMau_LinkClicked(sender As Object, e As EventArgs) Handles lnkFileMau.LinkClicked
        Try
            Process.Start(".\FileExcelMau\KHACHHANG.xls")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ctrlNhapKhachHangTuFileExcel_Load(sender As Object, e As EventArgs) Handles Me.Load
        If dt Is Nothing Then Exit Sub
        cmbNhomKhachHang.DataSource = From itm In dt.tbNhomKhachHangs
    End Sub
End Class
