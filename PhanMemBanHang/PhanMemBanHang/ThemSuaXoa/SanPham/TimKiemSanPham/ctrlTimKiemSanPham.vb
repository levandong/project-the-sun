Public Class ctrlTimKiemSanPham
    Event ChonSanPhamThanhCong(SanPham As tbSanPham, SoLuong As Double, TheoDonVi As Boolean)

    Private ModeTimKiem As Integer
    Private Sub ctrlTimKiemSanPham_Load(sender As Object, e As EventArgs) Handles Me.Load

        nudDonVi.SelectedIndex = 0
        cmbTimKiemTheo.SelectedIndex = My.Settings.TimKiemTheo
        ModeTimKiem = My.Settings.KieuTimKiem

        If My.Settings.KieuTimKiem = 0 Then
            ctmTimKiemChuaTrong.Checked = True
            ctmTimKiemBatDau.Checked = False
        ElseIf My.Settings.KieuTimKiem = 1 Then
            ctmTimKiemChuaTrong.Checked = False
            ctmTimKiemBatDau.Checked = True
        End If
        TimKiemSanPham()
        Timer1.Interval = My.Settings.ThoiGianTimKiemChamSanPham
    End Sub

    Private Sub TimKiemSanPham()
        If loginNhanVien Is Nothing Then Exit Sub
        If dt Is Nothing Then Exit Sub
        Dim key As String = mdlGlobals.BoDauTiengViet(txtSearch.GetText.Trim.ToLower)
        If key = "" Then
            CapNhatDanhSachSanPham()
            Exit Sub
        End If

        If cmbTimKiemTheo.SelectedIndex = 0 Then
            ' tIM KIEM THEO MA
            bsSanPham.DataSource = (From s In dt.vwSanPhams
                                    Where ((ModeTimKiem = 0 And s.MaSanPhamString.Contains(key))) Or (ModeTimKiem <> 0 And s.MaSanPhamString.StartsWith(key))
                                    Where s.HetBan = False).Take(My.Settings.SoDongTimKiemSanPham).OrderBy(Function(s) s.MaSanPham)
        ElseIf cmbTimKiemTheo.SelectedIndex = 1 Then
            ' Tim kiem theo ten
            bsSanPham.DataSource = (From s In dt.vwSanPhams
                                    Where ((ModeTimKiem = 0 And s.TenSanPhamString.Contains(key))) Or (ModeTimKiem <> 0 And s.TenSanPhamString.StartsWith(key))
                                    Where s.HetBan = False).Take(My.Settings.SoDongTimKiemSanPham).OrderBy(Function(s) s.MaSanPham)

        Else
            ' TIM KIEM THEO MA VACH
            bsSanPham.DataSource = (From itm In dt.vwSanPhams
                                    Where itm.HetBan = False
                                    Where itm.MaVachSanPham = txtSearch.GetText.Trim).Take(My.Settings.SoDongTimKiemSanPham).OrderBy(Function(s) s.MaSanPham)

            btnChon_Click(Nothing, Nothing)
        End If

    End Sub


    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbTimKiemTheo.SelectedIndex = 2 Then
                Timer1.Start()
            Else
                btnChon_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.Down Then
            If dgvMain.CurrentCell.RowIndex = dgvMain.RowCount - 1 Then
                dgvMain.CurrentCell = dgvMain.Rows(0).Cells(dgvMain.CurrentCell.ColumnIndex)
            Else
                dgvMain.CurrentCell = dgvMain.Rows(dgvMain.CurrentCell.RowIndex + 1).Cells(dgvMain.CurrentCell.ColumnIndex)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If dgvMain.CurrentCell.RowIndex = 0 Then
                dgvMain.CurrentCell = dgvMain.Rows(dgvMain.RowCount - 1).Cells(dgvMain.CurrentCell.ColumnIndex)
            Else
                dgvMain.CurrentCell = dgvMain.Rows(dgvMain.CurrentCell.RowIndex - 1).Cells(dgvMain.CurrentCell.ColumnIndex)
            End If
        End If
    End Sub


    Private Sub btnChon_Click(sender As Object, e As EventArgs) Handles btnChon.Click
        If bsSanPham.Current IsNot Nothing Then
            Dim vSanPham As vwSanPham = bsSanPham.Current
            Dim SanPham = dt.tbSanPhams.Single(Function(s) s.id = vSanPham.id)
            dt.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, SanPham)
            Dim SoLuongChon As Double = 1
            Try
                SoLuongChon = CDbl(txtSoLuong.Text.Trim)
            Catch ex As Exception

            End Try

            Dim TheoDonViTinh As Boolean = (nudDonVi.SelectedIndex = 0)
            RaiseEvent ChonSanPhamThanhCong(SanPham, SoLuongChon, TheoDonViTinh)
        End If
        txtSearch.SelectAll()
        txtSearch.Focus()
        txtSoLuong.Text = "1"
    End Sub


    Public Sub ctmCapNhat_Click(sender As Object, e As EventArgs) Handles ctmCapNhat.Click
        Dim frm As New Tmt.Toolkit.ProgressingDialog
        frm.Animation = Tmt.Toolkit.ProgressingDialog.AnimationStyle.Waiting
        frm.Caption = "Đang tải dữ liệu..."
        frm.DialogStyle = Tmt.Toolkit.ProgressingDialog.ProgressingDialogStyle.ContinuingDialog
        frm.Show()
        TimKiemSanPham()
        frm.Dismiss()
        txtSearch.Focus()
    End Sub

    Public Sub CapNhatDanhSachSanPham()
        bsSanPham.DataSource = (From nl In dt.vwSanPhams
                                Where nl.HetBan = False
                                Select nl Order By nl.MaSanPham).Take(My.Settings.SoDongTimKiemSanPham)
    End Sub


    Private Sub dgvMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        btnChon_Click(Nothing, Nothing)
    End Sub

    Private Sub dgvMain_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvMain.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.STT.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub dgvMain_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChon_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub bsSanPham_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles bsSanPham.ListChanged
        lblSoDong.Text = bsSanPham.Count.ToString + " sản phẩm."
        For i As Integer = 0 To dgvMain.RowCount - 1
            If dgvMain.Rows(i).Cells("CanhBao").Value = True Then
                dgvMain.Rows(i).DefaultCellStyle.BackColor = Color.AntiqueWhite
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        TimKiemSanPham()
    End Sub

    Private Sub ctmThemSanPhamMoi_Click(sender As Object, e As EventArgs) Handles ctmThemSanPhamMoi.Click
        Dim frm As New frmThemSanPham
        AddHandler frm.ThemSanPhamThanhCong, AddressOf CapNhatDanhSachSanPham
        frm.ShowDialog()
    End Sub

    Private Sub ctmCauHinhTimKiem_Click(sender As Object, e As EventArgs) Handles ctmCauHinhTimKiem.Click
        Dim frm As New frmCauHinhTimKiemSanPham
        frm.nudDelay.Value = My.Settings.ThoiGianTimKiemChamSanPham
        frm.nudSoDong.Value = My.Settings.SoDongTimKiemSanPham
        If frm.ShowDialog = DialogResult.OK Then
            My.Settings.ThoiGianTimKiemChamSanPham = frm.nudDelay.Value
            My.Settings.SoDongTimKiemSanPham = frm.nudSoDong.Value
            My.Settings.Save()
            Timer1.Interval = frm.nudDelay.Value
        End If
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        txtSearch.SelectAll()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.GetText <> "" Then
            If cmbTimKiemTheo.SelectedIndex <> 2 Then
                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub txtSoLuong_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSoLuong.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChon_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtSoLuong_LostFocus(sender As Object, e As EventArgs) Handles txtSoLuong.LostFocus
        txtSoLuong.SelectAll()
    End Sub

    Private Sub ctmTimKiemChuaTrong_Click(sender As Object, e As EventArgs) Handles ctmTimKiemChuaTrong.Click
        ModeTimKiem = 0
        My.Settings.KieuTimKiem = 0
        My.Settings.Save()
    End Sub

    Private Sub ctmTimKiemBatDau_Click(sender As Object, e As EventArgs) Handles ctmTimKiemBatDau.Click
        ModeTimKiem = 1
        My.Settings.KieuTimKiem = 1
        My.Settings.Save()
    End Sub

    Private Sub cmbTimKiemTheo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTimKiemTheo.SelectedIndexChanged
        If cmbTimKiemTheo.SelectedIndex = 2 Then
            colMaVachSanPham.Visible = True
            txtSoLuong.Text = "1"
            txtSoLuong.Enabled = False
        Else
            txtSoLuong.Enabled = True
            colMaVachSanPham.Visible = False
        End If
        My.Settings.TimKiemTheo = cmbTimKiemTheo.SelectedIndex
        My.Settings.Save()
    End Sub

    Public Sub ChuyenDoiKieuTimKiem()
        If cmbTimKiemTheo.SelectedIndex = cmbTimKiemTheo.Items.Count - 1 Then
            cmbTimKiemTheo.SelectedIndex = 0
        Else
            cmbTimKiemTheo.SelectedIndex += 1
        End If
        txtSearch.Focus()
        txtSearch.SelectAll()
    End Sub

    Private Sub nudDonVi_KeyDown(sender As Object, e As KeyEventArgs) Handles nudDonVi.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSoLuong.Focus()
            txtSoLuong.SelectAll()
        End If
    End Sub

    Public Sub ChuyenDoiDonViTinh()
        If nudDonVi.SelectedIndex = 0 Then
            nudDonVi.SelectedIndex = 1
        Else
            nudDonVi.SelectedIndex = 0
        End If
        txtSearch.Focus()
        txtSearch.SelectAll()
    End Sub
End Class
