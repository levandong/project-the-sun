Public Class frmDanhSachSoSeri
    Public ChiTietPhieuXuat As tbChiTietPhieuXuat
    Dim lstDanhSachChon As New List(Of tbChiTietSeri)
    Dim lst As New List(Of tbChiTietSeri)
    Dim TieuDe = ""
    Private Sub frmDanhSachSoSeri_Load(sender As Object, e As EventArgs) Handles Me.Load
        lst = (From itm In dt.tbChiTietSeris
               Where itm.idPhieuXuat.HasValue = False
               Where itm.isDanhSo = True
               Where itm.idSanPham = ChiTietPhieuXuat.idSanPham).ToList
        bsDanhSachSoSeri.DataSource = From itm In lst
        TieuDe = Me.Text
        Me.Text += " Chọn " + ChiTietPhieuXuat.SoLuong.ToString + " sản phẩm"
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim ChiTiet As tbChiTietSeri = bsDanhSachSoSeri.Current
            lstDanhSachChon.Add(ChiTiet)
            bsDanhSachChon.DataSource = From itm In lstDanhSachChon
            txtSearch.Text = ""
        ElseIf e.KeyCode = Keys.Down Then
            If dgvSanPham.CurrentCell.RowIndex = dgvSanPham.RowCount - 1 Then
                dgvSanPham.CurrentCell = dgvSanPham.Rows(0).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            Else
                dgvSanPham.CurrentCell = dgvSanPham.Rows(dgvSanPham.CurrentCell.RowIndex + 1).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If dgvSanPham.CurrentCell.RowIndex = 0 Then
                dgvSanPham.CurrentCell = dgvSanPham.Rows(dgvSanPham.RowCount - 1).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            Else
                dgvSanPham.CurrentCell = dgvSanPham.Rows(dgvSanPham.CurrentCell.RowIndex - 1).Cells(dgvSanPham.CurrentCell.ColumnIndex)
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim key = txtSearch.Text
        If txtSearch.Text = "" Then
            'dgvSanPham.Visible = False
            lst = From itm In dt.tbChiTietSeris
                  Where itm.idPhieuXuat.HasValue = False
                  Where itm.idSanPham = ChiTietPhieuXuat.idSanPham
        Else
            'dgvSanPham.Visible = True
            lst = From itm In dt.tbChiTietSeris
                  Where itm.idPhieuXuat.HasValue = False
                  Where itm.MaSeri.Contains(key)
                  Where itm.idSanPham = itm.idSanPham
        End If
        bsDanhSachSoSeri.DataSource = From itm In lst
    End Sub

    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        For Each itm In lstDanhSachChon
            Dim ChiTiet As tbChiTietSeri = dt.tbChiTietSeris.First(Function(s) s.id = itm.id)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, ChiTiet)
            ChiTiet.tbPhieuXuat = ChiTietPhieuXuat.tbPhieuXuat
            Try
                dt.SubmitChanges()
                Me.Close()
            Catch
            End Try
        Next
    End Sub

    Private Sub dgvSanPham_DoubleClick(sender As Object, e As EventArgs) Handles dgvSanPham.DoubleClick
        Dim ChiTiet As tbChiTietSeri = bsDanhSachSoSeri.Current
        lstDanhSachChon.Add(ChiTiet)
        lst.Remove(ChiTiet)
        bsDanhSachChon.DataSource = From itm In lstDanhSachChon
        bsDanhSachSoSeri.DataSource = From itm In lst
        txtSearch.Text = ""
    End Sub

    Private Sub btnBoQua_Click(sender As Object, e As EventArgs) Handles btnBoQua.Click
        lstDanhSachChon.Clear()
        lstDanhSachChon = (From itm In dt.tbChiTietSeris
                           Where itm.idPhieuXuat.HasValue = False
                           Where itm.isDanhSo = False).ToList
        If lstDanhSachChon.Count >= ChiTietPhieuXuat.SoLuong Then
            Dim i = 0
            For Each itm In lstDanhSachChon
                If i = ChiTietPhieuXuat.SoLuong Then
                    Exit For
                End If
                Dim ChiTiet As tbChiTietSeri = dt.tbChiTietSeris.First(Function(s) s.id = itm.id)
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, ChiTiet)
                ChiTiet.idPhieuXuat = ChiTietPhieuXuat.idPhieuXuat
                Try
                    dt.SubmitChanges()
                    Me.Close()
                Catch
                End Try
                i += 1
            Next
        Else
            Dim i = 0
            For Each itm In lstDanhSachChon

                Dim ChiTiet As tbChiTietSeri = dt.tbChiTietSeris.First(Function(s) s.id = itm.id)
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, ChiTiet)
                ChiTiet.idPhieuXuat = ChiTietPhieuXuat.idPhieuXuat
                Try
                    dt.SubmitChanges()
                    Me.Close()
                Catch
                End Try
                i += 1
            Next
            For Each itm In dt.tbChiTietSeris.Where(Function(s) s.isDanhSo = True And s.idPhieuXuat.HasValue = False)
                If i = ChiTietPhieuXuat.SoLuong Then
                    Exit For
                End If
                Dim ChiTiet As tbChiTietSeri = dt.tbChiTietSeris.First(Function(s) s.id = itm.id)
                dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, ChiTiet)
                ChiTiet.idPhieuXuat = ChiTietPhieuXuat.idPhieuXuat
                Try
                    dt.SubmitChanges()
                    Me.Close()
                Catch
                End Try
                i += 1
            Next
        End If
        Me.Close()


    End Sub

    Private Sub frmDanhSachSoSeri_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnBoQua_Click(Nothing, Nothing)
    End Sub
End Class