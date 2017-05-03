
Public Class ctrlDGVSanPham_Old

    Private Sub bsSanPham_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs)
        lblSoLuong.Text = bsSanPham.Count.ToString + " sản phẩm."
    End Sub

    Event ChonSanPham(nl As tbSanPham)
    Event SuaSanPham(nl As tbSanPham)

    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If bsSanPham.Current Is Nothing Then Exit Sub
        Dim vSanPham As vwSanPham = bsSanPham.Current
        RaiseEvent ChonSanPham(dt.tbSanPhams.First(Function(s) s.id = vSanPham.id))
    End Sub

    'Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
    '        e.Value = e.RowIndex + 1
    '    End If
    'End Sub

    Event InDanhSachSanPham(InKemGia As Boolean)
    Private Sub btnIn_Click(sender As Object, e As EventArgs)
        If bsSanPham.Count > 0 Then
            RaiseEvent InDanhSachSanPham(btnInKemGia.Checked)
        End If
    End Sub

    Public Sub ToMauCanhBaoTon()
        For i As Integer = 0 To dgvMain.RowCount - 1
            If dgvMain.Rows(i).Cells("CanhBao").Value = True Then
                dgvMain.Rows(i).DefaultCellStyle.BackColor = Color.AntiqueWhite
            End If
            If dgvMain.Rows(i).Cells("HetBan").Value = True Then
                dgvMain.Rows(i).DefaultCellStyle.Font = New Font(dgvMain.DefaultCellStyle.Font, FontStyle.Strikeout)
            End If
        Next
    End Sub
    Public rlsKetQua As IQueryable(Of vwSanPham)
#Region "Phân Trang"
    Dim TrangHienTai As Integer = 0
    Dim SoDongTrenMotTrang As Integer = 30
    Dim TongSoLuong As Integer
    Dim SoTrang As Integer

    Private Sub CapNhapTrang()
        Dim Tu = TrangHienTai * SoDongTrenMotTrang
        Dim Den = (TrangHienTai + 1) * SoDongTrenMotTrang
        If Den > TongSoLuong Then
            Den = TongSoLuong
        End If
        lblSoLuong.Text = "[" + (Tu + 1).ToString("n0") + ".." + Den.ToString("n0") + "]"
        txtSoTrang.Text = (TrangHienTai + 1).ToString()
    End Sub
    Private Sub PhanTrangLucLoad()
        If My.Settings.SoDongKhachHangTrenMotTrang < 1 Then
            My.Settings.SoDongKhachHangTrenMotTrang = 30
            My.Settings.Save()
        End If
        txtSoDongTrenMotTrang.Text = My.Settings.SoDongKhachHangTrenMotTrang
        SoDongTrenMotTrang = My.Settings.SoDongKhachHangTrenMotTrang
        txtSoTrang.Text = 0
    End Sub
    Public Sub PhanTrangSauKhiTimKiem(flag As Boolean)
        If rlsKetQua IsNot Nothing Then
            If flag Then
                TrangHienTai = 0
            End If
            TongSoLuong = rlsKetQua.Count
            SoTrang = Math.Ceiling(TongSoLuong / SoDongTrenMotTrang)
            lblTongSoTrang.Text = SoTrang.ToString("n0")
            lblTongSoTrang2.Text = SoTrang.ToString("n0")
            lblTongSoLuong.Text = TongSoLuong.ToString("n0")

            If flag Or SoTrang = 0 Then
                bsSanPham.DataSource = rlsKetQua.Skip(0).Take(SoDongTrenMotTrang)
            Else
                bsSanPham.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
            End If
            CapNhapTrang()
        End If
    End Sub
    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1 + TrangHienTai * SoDongTrenMotTrang
        End If
    End Sub
    Private Sub btnQuaTrai1_Click(sender As Object, e As EventArgs)
        If rlsKetQua IsNot Nothing Then
            If TrangHienTai > 0 Then
                TrangHienTai -= 1
                bsSanPham.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
                CapNhapTrang()
            End If
        End If
        ToMauCanhBaoTon()
    End Sub

    Private Sub btnQuaTraiTatCa_Click(sender As Object, e As EventArgs)
        If rlsKetQua IsNot Nothing Then
            TrangHienTai = 0
            bsSanPham.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
            CapNhapTrang()
        End If
        ToMauCanhBaoTon()
    End Sub

    Private Sub btnQuaPhai1_Click(sender As Object, e As EventArgs)
        If rlsKetQua IsNot Nothing Then
            If TrangHienTai < SoTrang - 1 Then
                TrangHienTai += 1
                bsSanPham.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
                CapNhapTrang()
            End If
        End If
        ToMauCanhBaoTon()
    End Sub

    Private Sub btnQuaPhaiTatCa_Click(sender As Object, e As EventArgs)
        If rlsKetQua IsNot Nothing Then
            TrangHienTai = SoTrang - 1
            bsSanPham.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
            CapNhapTrang()
        End If
        ToMauCanhBaoTon()
    End Sub

    Private Sub txtSoTrang_KeyPress(sender As Object, e As KeyPressEventArgs)
        If rlsKetQua IsNot Nothing Then
            If e.KeyChar = "\r" Then
                Try
                    TrangHienTai = CInt(txtSoTrang.Text) - 1
                    If TrangHienTai > SoTrang - 1 Then
                        TrangHienTai = SoTrang - 1
                    End If
                    If TrangHienTai < 1 Then
                        TrangHienTai = 0
                    End If
                    bsSanPham.DataSource = rlsKetQua.Skip(TrangHienTai * SoDongTrenMotTrang).Take(SoDongTrenMotTrang)
                    txtSoTrang.SelectAll()
                    CapNhapTrang()
                Catch ex As Exception
                    ThongBaoError(ex.Message)
                End Try
            ElseIf e.KeyChar <> "\b" Then
                If Char.IsNumber(e.KeyChar) = False Then
                    e.Handled = True
                End If
            End If
        End If
        ToMauCanhBaoTon()
    End Sub

    Private Sub txtSoDongTrenMotTrang_KeyPress(sender As Object, e As KeyPressEventArgs)
        If rlsKetQua IsNot Nothing Then
            If Asc(e.KeyChar) = 13 Then
                Try
                    SoDongTrenMotTrang = CInt(txtSoDongTrenMotTrang.Text)
                    My.Settings.SoDongKhachHangTrenMotTrang = SoDongTrenMotTrang
                    My.Settings.Save()
                    SoTrang = Math.Ceiling(TongSoLuong / SoDongTrenMotTrang)
                    lblTongSoTrang.Text = SoTrang.ToString("n0")
                    lblTongSoTrang2.Text = SoTrang.ToString("n0")
                    TrangHienTai = 0
                    bsSanPham.DataSource = rlsKetQua.Skip(0).Take(SoDongTrenMotTrang)
                    CapNhapTrang()
                Catch ex As Exception
                    ThongBaoError(ex.Message)
                End Try
            ElseIf Asc(e.KeyChar) <> 8 Then
                If Char.IsNumber(e.KeyChar) = False Then
                    e.Handled = True
                End If
            End If
        End If
        ToMauCanhBaoTon()
    End Sub
    Public Sub TinhToanTonkho()
        For Each itm In dt.TinhTonKhoSanPham(-1, -1, Now, Now)
            Dim SanPham = dt.tbSanPhams.Where(Function(s) s.id = itm.id).Single
            SanPham.SoLuong = itm.SoLuongCuoiKy
        Next
    End Sub
    Private Sub ctrlDGVSanPham_Old_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
#End Region
End Class

