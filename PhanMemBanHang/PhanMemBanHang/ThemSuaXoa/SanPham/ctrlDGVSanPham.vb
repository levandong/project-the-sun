
Public Class ctrlDGVSanPham
    Event ChonSanPham(nl As tbSanPham)
    Event SuaSanPham(nl As tbSanPham)

    Event InDanhSachSanPham(InKemGia As Boolean)


    Public Sub ToMauCanhBaoTon()
        'For i As Integer = 0 To dgvMain.RowCount - 1
        '    If dgvMain.Rows(i).Cells("CanhBao").Value = True Then
        '        dgvMain.Rows(i).DefaultCellStyle.BackColor = Color.AntiqueWhite
        '    End If
        '    If dgvMain.Rows(i).Cells("HetBan").Value = True Then
        '        dgvMain.Rows(i).DefaultCellStyle.Font = New Font(dgvMain.DefaultCellStyle.Font, FontStyle.Strikeout)
        '    End If
        'Next
    End Sub
    'Public rlsKetQua As IQueryable(Of vwSanPham)


    Public Sub TinhToanTonkho()
        '    For Each itm In dt.TinhTonKhoSanPham(-1, -1, Now, Now)
        '        Dim SanPham = dt.tbSanPhams.Where(Function(s) s.id = itm.id).Single
        '        SanPham.SoLuong = itm.SoLuongCuoiKy
        '    Next
    End Sub

    Private Sub mnuItemPrint_Click(sender As Object, e As EventArgs) Handles mnuItemPrint.Click
        If gridViewData.DataRowCount > 0 Then
            RaiseEvent InDanhSachSanPham(False)
        End If
    End Sub

    Private Sub gridViewData_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridViewData.CustomDrawRowIndicator
        If (e.Info.IsRowIndicator) Then
            If e.RowHandle < 0 Then
                e.Info.ImageIndex = 0
                e.Info.DisplayText = ""
            Else
                e.Info.ImageIndex = 1
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
        End If
    End Sub

    Private Sub mnuItemExportExcel_Click(sender As Object, e As EventArgs) Handles mnuItemExportExcel.Click
        If gridViewData.DataRowCount > 0 Then
            'HISLib.AppCore.Other.GridDevExportToExcel.ExportToExcel(gridControl, DevExpress.XtraPrinting.TextExportMode.Value, False)
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        mnuItemExportExcel.Enabled = gridViewData.DataRowCount > 0
        mnuItemPrint.Enabled = gridViewData.DataRowCount > 0
    End Sub

    Private Sub gridControl_KeyDown(sender As Object, e As KeyEventArgs) Handles gridControl.KeyDown

    End Sub

    Private Sub gridControl_DoubleClick(sender As Object, e As EventArgs) Handles gridControl.DoubleClick
        If gridViewData.FocusedRowHandle >= 0 Then
            Dim vSanPham As vwSanPham = gridViewData.GetRow(gridViewData.FocusedRowHandle)
            RaiseEvent ChonSanPham(dt.tbSanPhams.First(Function(s) s.id = vSanPham.id))
        End If
    End Sub
End Class

