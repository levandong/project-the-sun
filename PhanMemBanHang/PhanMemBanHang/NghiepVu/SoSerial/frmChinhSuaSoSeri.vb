Public Class frmChinhSuaSeri
    Public idPhieuNhap As Integer = 0
    Public idSanPham As Integer = 0
    Public SoLuong As Integer = 0
    Dim sanPham As tbSanPham
    Dim rls As List(Of tbChiTietSeri)
    Private Sub frmThemSoSeri_Load(sender As Object, e As EventArgs) Handles Me.Load
        sanPham = dt.tbSanPhams.FirstOrDefault(Function(s) s.id = idSanPham)
        bsChiTietXacNhan.DataSource = From itm In dt.tbChiTietSeris Where itm.idSanPham = idSanPham And itm.idPhieuNhap = idPhieuNhap And itm.isDanhSo = True
        rls = (From s In dt.tbChiTietSeris Where s.idSanPham = idSanPham And s.idPhieuNhap = idPhieuNhap And (s.isDanhSo = False Or s.isDanhSo.HasValue = False)).ToList
        SoLuong = rls.Count
        Me.Text = "Cần tạo " + SoLuong.ToString + " số seri"
        bsChiTietSoSeri.DataSource = From s In rls
    End Sub
    Dim lstChiTietSoSeri As New List(Of tbChiTietSeri)
    Private Sub btnThemSoSeri_Click(sender As Object, e As EventArgs) Handles btnThemSoSeri.Click
        If bsChiTietSoSeri.Count = 0 Then
            If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Số lượng số seri cần nhận đã đủ." + vbNewLine + "Bạn có muốn hoàn tất quá trình nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Me.Close()
            End If
        End If
        For Each itm In rls
            If itm.isDanhSo Then
                Continue For
            End If
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, itm)
            itm.MaSeri = txtSoSeri.Text.Trim
            itm.isDanhSo = True
            dt.SubmitChanges()
            rls = (From s In dt.tbChiTietSeris Where s.idSanPham = idSanPham And s.idPhieuNhap = idPhieuNhap And (s.isDanhSo = False Or s.isDanhSo.HasValue = False)).ToList
            bsChiTietSoSeri.DataSource = From s In rls
            bsChiTietXacNhan.DataSource = From s In dt.tbChiTietSeris Where s.idSanPham = idSanPham And s.idPhieuNhap = idPhieuNhap And s.isDanhSo = True
            Exit Sub
        Next

    End Sub
    Private Sub TaoSoSeri()
        ThongBao("")
        Try
            dt.SubmitChanges()
            Me.Close()
        Catch ex As Exception
            ThongBaoError("Thay đổi thất bại")
        End Try
    End Sub
    Private Sub bsChiTietSoSeri_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsChiTietSoSeri.ListChanged
        lblSoLuong.Text = bsChiTietSoSeri.Count.ToString + " Số seri"
    End Sub

    Private Sub btnBoQua_Click(sender As Object, e As EventArgs) Handles btnBoQua.Click
        Try
            dt.SubmitChanges()
            Me.Close()
        Catch ex As Exception
            ThongBaoError("Thay đổi thất bại")
        End Try
    End Sub

    Private Sub txtSoSeri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoSeri.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            btnThemSoSeri_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs)
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

    Private Sub btnSuaSeri_Click(sender As Object, e As EventArgs) Handles btnSuaSeri.Click
        If txtTextSua.Text.Trim = "" Then Exit Sub
        Dim ChiTiet As tbChiTietSeri = bsChiTietXacNhan.Current
        dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, ChiTiet)
        ChiTiet.MaSeri = txtTextSua.Text.Trim
        Try
            dt.SubmitChanges()
            txtTextSua.Text = ""
        Catch
        End Try
    End Sub

    Private Sub bsChiTietXacNhan_CurrentChanged(sender As Object, e As EventArgs) Handles bsChiTietXacNhan.CurrentChanged
        If bsChiTietXacNhan.Current IsNot Nothing Then
            txtTextSua.Text = bsChiTietXacNhan.Current.MaSeri
        End If
    End Sub

    Private Sub frmChinhSuaSeri_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
        ElseIf e.KeyCode = Keys.F3 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmChinhSuaSeri_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        btnBoQua_Click(Nothing, Nothing)
    End Sub

    Private Sub txtTextSua_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTextSua.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSuaSeri_Click(Nothing, Nothing)
        End If
    End Sub
End Class