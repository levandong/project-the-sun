Public Class frmThemSoSeri
    Public idPhieuNhap As Integer = 0
    Public idSanPham As Integer = 0
    Public SoLuong As Integer = 0
    Dim sanPham As tbSanPham
    Private Sub frmThemSoSeri_Load(sender As Object, e As EventArgs) Handles Me.Load
        sanPham = dt.tbSanPhams.FirstOrDefault(Function(s) s.id = idSanPham)
    End Sub
    Dim lstChiTietSoSeri As New List(Of tbChiTietSeri)
    Private Sub btnThemSoSeri_Click(sender As Object, e As EventArgs) Handles btnThemSoSeri.Click
        If bsChiTietSoSeri.Count = SoLuong Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Số lượng số seri cần nhận đã đủ." + vbNewLine + "Bạn có muốn hoàn tất quá trình nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            End If
        End If
        For Each itm In lstChiTietSoSeri
            If itm.MaSeri = txtSoSeri.Text.Trim Then
                ThongBao("Số seri bị trùng")
            End If
        Next
        Dim newSoSeri As New tbChiTietSeri
        With newSoSeri
            .MaSeri = txtSoSeri.Text.Trim
            .idPhieuNhap = idPhieuNhap
            .NgayNhap = Now.Date
            .TenSanPham = sanPham.TenSanPham
            .idSanPham = idSanPham
            .isDanhSo = True
        End With
        lstChiTietSoSeri.Add(newSoSeri)
        bsChiTietSoSeri.DataSource = From itm In lstChiTietSoSeri
        txtSoSeri.Text = ""
    End Sub
    Private Sub TaoSoSeri()
        For i = 1 To SoLuong - bsChiTietSoSeri.Count Step 1
            Dim newSoSeri As New tbChiTietSeri
            With newSoSeri
                .MaSeri = "*"
                .idPhieuNhap = idPhieuNhap
                .NgayNhap = Now.Date
                .TenSanPham = sanPham.TenSanPham
                .idSanPham = sanPham.id
                .isDanhSo = False
            End With
            lstChiTietSoSeri.Add(newSoSeri)
        Next
        dt.tbChiTietSeris.InsertAllOnSubmit(lstChiTietSoSeri)
        Try
            dt.SubmitChanges()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bsChiTietSoSeri_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietSoSeri.ListChanged
        lblSoLuong.Text = bsChiTietSoSeri.Count.ToString + " Số seri"
    End Sub

    Private Sub btnBoQua_Click(sender As Object, e As EventArgs) Handles btnBoQua.Click
        lstChiTietSoSeri.Clear()
        For i = 1 To SoLuong Step 1
            Dim newSoSeri As New tbChiTietSeri
            With newSoSeri
                .MaSeri = "*"
                .idPhieuNhap = idPhieuNhap
                .NgayNhap = Now.Date
                .TenSanPham = sanPham.TenSanPham
                .idSanPham = sanPham.id
            End With
            lstChiTietSoSeri.Add(newSoSeri)
        Next
        dt.tbChiTietSeris.InsertAllOnSubmit(lstChiTietSoSeri)
        Try
            dt.SubmitChanges()
            Me.Close()
        Catch ex As Exception
            ThongBaoError("Thêm dữ liệu thất bại")
        End Try
    End Sub

    Private Sub txtSoSeri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoSeri.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btnThemSoSeri_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        TaoSoSeri()
        Me.Close()
    End Sub
    Sub CapNhat()
        bsChiTietSoSeri.DataSource = From itm In lstChiTietSoSeri
    End Sub
    Private Sub XóaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaToolStripMenuItem.Click
        lstChiTietSoSeri.Remove(bsChiTietSoSeri.Current)
        CapNhat()
    End Sub

    Private Sub frmThemSoSeri_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If XacNhanYesNo("Bạn muốn bỏ qua bước thêm số seri") = DialogResult.No Then Exit Sub
        lstChiTietSoSeri.Clear()
        For i = 1 To SoLuong Step 1
            Dim newSoSeri As New tbChiTietSeri
            With newSoSeri
                .MaSeri = "*"
                .idPhieuNhap = idPhieuNhap
                .NgayNhap = Now.Date
                .TenSanPham = sanPham.TenSanPham
                .idSanPham = sanPham.id
            End With
            lstChiTietSoSeri.Add(newSoSeri)
        Next
        dt.tbChiTietSeris.InsertAllOnSubmit(lstChiTietSoSeri)
        Try
            dt.SubmitChanges()
        Catch ex As Exception
            ThongBaoError("Thêm dữ liệu thất bại")
        End Try
    End Sub
End Class