Public Class ctrlChucNangTonKhoSanPham

    Private Sub rdoSoLuongTheo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSoLuongTheo.CheckedChanged
        nudSoLuong.Enabled = rdoSoLuongTheo.Checked
    End Sub

    Private Sub rdoTatCa_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLonHon.CheckedChanged
        nudSoLuong.Enabled = rdoLonHon.Checked
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTuKhoa.GetText.Trim.ToLower)

        Dim ModeTimKiem As Integer = 0
        If rdoSoLuongNhoHonTonMin.Checked Then
            ModeTimKiem = 0
        ElseIf rdoSoLuongTheo.Checked Then
            ModeTimKiem = 1
        ElseIf rdoLonHon.Checked Then
            ModeTimKiem = 2
        Else
            ModeTimKiem = 3 ' Tim kiem tat ca
        End If


        Dim rlsLoai = From itm In lst.ToList
                      Where itm.Chon = True
                      Select itm.id

        Dim rls
        If rlsLoai.Count > 0 Then
            rls = From itm In dt.vwSanPhams
                   Where itm.HetBan = False
                   Where rlsLoai.Contains(itm.idLoaiSanPham)
                      Where (ModeTimKiem = 0 And itm.SoLuong <= itm.TonMin) Or (ModeTimKiem = 1 And itm.SoLuong <= nudSoLuong.Value) Or (ModeTimKiem = 2 And itm.SoLuong >= nudSoLuong.Value) Or (ModeTimKiem = 3 And True)
                      Where itm.MaSanPhamString.Contains(key) Or itm.MaVachSanPham.Contains(key) Or itm.TenSanPhamString.Contains(key)
                      Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham
        Else
            rls = From itm In dt.vwSanPhams
                  Where itm.HetBan = False
                  Where (ModeTimKiem = 0 And itm.SoLuong <= itm.TonMin) Or (ModeTimKiem = 1 And itm.SoLuong <= nudSoLuong.Value) Or (ModeTimKiem = 2 And itm.SoLuong >= nudSoLuong.Value) Or (ModeTimKiem = 3 And True)
                  Where itm.MaSanPhamString.Contains(key) Or itm.MaVachSanPham.Contains(key) Or itm.TenSanPhamString.Contains(key)
                  Select itm Order By itm.TenLoaiSanPham, itm.MaSanPham
        End If

        CtrlDGVSanPham1.gridControl.DataSource = rls
        CtrlDGVSanPham1.gridViewData.RefreshData()
        CtrlDGVSanPham1.ToMauCanhBaoTon()
    End Sub

    Private Sub CtrlDGVSanPham1_InDanhSachSanPham(InKemGia As Boolean) Handles CtrlDGVSanPham1.InDanhSachSanPham
        If CtrlDGVSanPham1.gridViewData.DataRowCount = 0 Then Exit Sub
        Dim frm As New frmInDanhSach
        frm.Text = "DANH SÁCH SẢN PHẨM TỒN KHO"
        frm.dsName = "dsDanhSachSanPham"
        If InKemGia Then
            frm.rptName = ".\Report\SanPham\rptDanhSachSanPhamTonKemGia.rdlc"
        Else
            frm.rptName = ".\Report\SanPham\rptDanhSachSanPhamTon.rdlc"
        End If
        frm._bs.DataSource = CtrlDGVSanPham1.gridControl.DataSource
        frm.Show()
    End Sub

    Private Sub txtTuKhoa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTuKhoa.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTimKiem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ctrlChucNangTonKhoSanPham_Load(sender As Object, e As EventArgs) Handles Me.Load
        With CtrlDGVSanPham1
            '.GiaBan.Visible = False
            '.MaVachSanPham.Visible = False
            '.GiaBinhQuan.Visible = True
            '.GiaTriHienTai.Visible = True
            '.btnInKemGia.Visible = True
        End With

        With CtrlDGVLoaiSanPham1
            .colChon.Visible = True
            .gridViewData.OptionsView.ShowIndicator = False
            .colMaLoaiSanPham.Visible = False
            .colMoTa.Visible = False
        End With
        isLoad = True
        TimKiemLoaiSanPham()
    End Sub

#Region "LOAI SAN PHAM"
    Private lst As IQueryable(Of tbLoaiSanPham)
    Private ChonTatCa As Boolean
    Private Sub btnChonTatCa_Click(sender As Object, e As EventArgs) Handles btnChonTatCa.Click
        ChonTatCa = Not ChonTatCa
        For Each itm In lst.ToList
            itm.Chon = ChonTatCa
        Next
        CtrlDGVLoaiSanPham1.gridViewData.RefreshData()
        'CtrlDGVLoaiSanPham1.bsLoaiSanPham.ResetBindings(True)
        'CtrlDGVLoaiSanPham1.dgvLoaiSanPham.Refresh()

        If ChonTatCa Then
            btnChonTatCa.Image = My.Resources.unchecked
            btnChonTatCa.Text = "Bỏ chọn tất cả"
        Else
            btnChonTatCa.Image = My.Resources.Checked
            btnChonTatCa.Text = "Chọn tất cả"
        End If
    End Sub


    Private Sub TimKiemLoaiSanPham()
        Dim key As String = mdlGlobals.BoDauTiengViet(txtTimKiemLoai.Text.Trim).ToLower
        lst = (From itm In dt.tbLoaiSanPhams
               Where dt.f_nosymbol(itm.TenLoaiSanPham).ToLower.Contains(key)
               Order By itm.MaLoaiSanPham)

        CtrlDGVLoaiSanPham1.gridControl.DataSource = lst
        CtrlDGVLoaiSanPham1.gridViewData.RefreshData()
    End Sub
    Private Sub txtTimKiemLoai_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimKiemLoai.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimKiemLoaiSanPham()
        End If
    End Sub

    Private Sub txtTimKiemLoai_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiemLoai.TextChanged
        If txtTimKiemLoai.Text.Trim = "" Then
            CtrlDGVLoaiSanPham1.gridControl.DataSource = From itm In lst
                                                         Order By itm.MaLoaiSanPham

            CtrlDGVLoaiSanPham1.gridViewData.RefreshData()
        End If
    End Sub
    Private Sub CtrlDGVLoaiSanPham1_ChonLoaiSanPham(LoaiSanPham As tbLoaiSanPham) Handles CtrlDGVLoaiSanPham1.ChonLoaiSanPham
        LoaiSanPham.Chon = Not LoaiSanPham.Chon
    End Sub
#End Region
End Class
