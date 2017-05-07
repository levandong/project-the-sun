Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class ctrlSaoLuuPhucHoi
    Dim chuoiConnect As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(ChuoiConnectString)

#Region "SAO LUU"
    Dim ThoiGianSaoLuu As DateTime
    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = txtDuongDanSaoLuu.Text

        dialog.Description = "Chọn thư mục để sao lưu..."
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDuongDanSaoLuu.Text = dialog.SelectedPath
        End If
    End Sub
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        If txtDuongDanSaoLuu.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn đường dẫn lưu file backup.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim cn As SqlConnection = ConnectionData()
        Dim sqlBackup As String = "BACKUP DATABASE " + chuoiConnect.InitialCatalog + _
                                    " TO DISK ='" + txtDuongDanSaoLuu.Text + "\" + _
                                    txtTenFile.Text + "'" + " WITH FORMAT;"
        Dim cmd As SqlCommand = New SqlCommand(sqlBackup, cn)
        Try
            cmd.ExecuteNonQuery()
            ' Ghi lịch sử backup
            Dim news As New tbLogBackup
            With news
                .NgayThucHien = ThoiGianSaoLuu
                .NoiDung = "Sao lưu toàn bộ dữ liệu. Tên file backup: " + txtTenFile.Text + _
                    ", đường dẫn chứa file: '" + txtDuongDanSaoLuu.Text + "' ."
            End With
            dt.tbLogBackups.InsertOnSubmit(news)
            dt.SubmitChanges()
            ThoiGianSaoLuu = TMT_GioHeThong
            txtTenFile.Text = My.Application.Info.ProductName + ThoiGianSaoLuu.ToString("ddMMyy_HHmmss") + ".bak"
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Đã sao lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CapNhatLichSuSaoLuu()
        Catch ex As Exception
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cn.Close()
    End Sub
#End Region

#Region "PHUC HOI"
    Private Sub btnChonFile_Click(sender As Object, e As EventArgs) Handles btnChonFile.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Tập tin phục hồi (*.bak)|*.bak"
        dialog.Title = "Chọn file .bak để phục hồi dữ liệu"
        dialog.InitialDirectory = txtDuongDanSaoLuu.Text
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDuongDanPhucHoi.Text = dialog.FileName
            lblThongBao.Text = "Đã chọn file phục hồi"
            lblThongBao.Visible = True
        Else
            txtDuongDanPhucHoi.Text = ""
            txtDuongDanPhucHoi.Focus()
            lblThongBao.Text = "Chưa chọn file để phục hồi!"
            lblThongBao.Visible = True
        End If
    End Sub

    Private Sub btnPhucHoi_Click(sender As Object, e As EventArgs) Handles btnPhucHoi.Click
        If txtDuongDanPhucHoi.Text = "" Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn đường dẫn lưu file restore.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDuongDanPhucHoi.Focus()
            Exit Sub
        End If
        Dim cn As SqlConnection = New SqlConnection(ChuoiConnectString.Replace(chuoiConnect.InitialCatalog, "master"))
        cn.Open()
        Dim sqlrestore As String = "Use Master ALTER DATABASE " + chuoiConnect.InitialCatalog + " SET SINGLE_USER with ROLLBACK Immediate  RESTORE DATABASE " + chuoiConnect.InitialCatalog + " From Disk = '" + txtDuongDanPhucHoi.Text + "' WITH REPLACE"
        Dim cmd As SqlCommand = New SqlCommand(sqlrestore, cn)
        Try
            cmd.ExecuteNonQuery()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Dữ liệu phục hồi thành công. Khởi động lại chương trình để hoàn tất", "Thông báo", MessageBoxButtons.OK)
            Application.Restart()
        Catch ex As Exception
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region

    Private Sub ctrlSaoLuuPhucHoi_Load(sender As Object, e As EventArgs) Handles Me.Load
        CapNhatLichSuSaoLuu()
        ThoiGianSaoLuu = TMT_GioHeThong
        If My.Settings.DuongDanFileBackup = "" Then
            txtDuongDanSaoLuu.Text = "D:\"
        Else
            txtDuongDanSaoLuu.Text = My.Settings.DuongDanFileBackup
        End If
        txtTenFile.Text = My.Application.Info.ProductName + ThoiGianSaoLuu.ToString("ddMMyy_HHmmss.bak")
    End Sub

#Region "LICH SU SAO LUU PHUC HOI"
    Private Sub CapNhatLichSuSaoLuu()
        bsLichSu.DataSource = From ls In dt.tbLogBackups Select ls
                       Order By ls.NgayThucHien Descending
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If bsLichSu.Current Is Nothing Then Exit Sub
        Dim LogBackup As tbLogBackup = bsLichSu.Current
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xoá dòng lịch sử ngày " + LogBackup.NgayThucHien.ToString("dd/MM/yyyy HH:mm:ss") + "?", _
                                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dt.tbLogBackups.DeleteOnSubmit(LogBackup)
            Try
                dt.SubmitChanges()
                CapNhatLichSuSaoLuu()
            Catch ex As Exception
                undoChange()
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xóa lịch sử thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub btnXoaTatCa_Click(sender As Object, e As EventArgs) Handles btnXoaTatCa.Click
        If bsLichSu.Count = 0 Then Exit Sub
        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn xoá tất cả lịch sử?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each itm In dt.tbLogBackups
                dt.tbLogBackups.DeleteOnSubmit(itm)
            Next
            Try
                dt.SubmitChanges()
                CapNhatLichSuSaoLuu()
            Catch ex As Exception
                undoChange()
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Xóa lịch sử thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub bsLichSu_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsLichSu.ListChanged
        lblSoDong.Text = bsLichSu.Count.ToString + "."
    End Sub

    Private Sub KryptonDataGridView1_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub
#End Region
End Class
