Public Class ctrlPhanQuyen
    Private Sub CtrlRibbon1_ThuNhoRibbon(isThuNho As Boolean) Handles CtrlRibbon1.ThuNhoRibbon
        If isThuNho = False Then
            KryptonPanel1.Height += CtrlRibbon1.KryptonGroup1.Height
        Else
            KryptonPanel1.Height -= CtrlRibbon1.KryptonGroup1.Height
        End If
    End Sub

    Dim lst As New List(Of Control)

    Private Sub btnSaveDatabase_Click(sender As Object, e As EventArgs) Handles btnSaveDatabase.Click
        Dim newCha As New tbQuyen
        newCha.HinhThuc = 1
        newCha.TenControl = "Phân quyền trên ribbon"
        newCha.TenQuyen = "Phân quyền trên ribbon"
        SaveDatabase(tvwQuyenRibbon.Nodes(0), newCha)
        dt.tbQuyens.InsertOnSubmit(newCha)
        dt.SubmitChanges()
        Dim quyenGoc = dt.tbQuyens.Where(Function(s) s.TenQuyen = "Phân quyền trên ribbon" And s.idQuyenCha Is Nothing).FirstOrDefault()
        quyenGoc.tbQuyens.First.tbQuyen = Nothing
        dt.tbQuyens.DeleteOnSubmit(quyenGoc)
        dt.SubmitChanges()

        For Each itm In dt.tbQuyens
            If itm.TenControl.StartsWith("chk") And itm.HinhThuc = 0 Then
                itm.TheLoai = 1
            End If
        Next
        dt.SubmitChanges()
        MsgBox("Đã xong")
    End Sub


    Private Sub SaveDatabase(node As TreeNode, cha As tbQuyen)
        Dim newQuyen = New tbQuyen
        newQuyen.tbQuyen = cha
        newQuyen.HinhThuc = CInt(node.Text.Split("|")(1))
        newQuyen.TenControl = node.Text.Split("|")(2)
        newQuyen.TenQuyen = node.Text.Split("|")(0)
        For Each cnode As TreeNode In node.Nodes
            SaveDatabase(cnode, newQuyen)
        Next
    End Sub


    Private dictionary1 As Dictionary(Of String, tbPhanQuyen)
    Private dictionsry2 As Dictionary(Of String, Control)
    Dim i As Integer



    Private Function AddToTreeViewFromDatabase(quyenCha As tbQuyen, idNhanVien As Integer) As TreeNode
        Dim newNode = New TreeNode(quyenCha.TenQuyen)
        Dim PhanQuyen As tbPhanQuyen = dt.tbPhanQuyens.Single(Function(s) s.idQuyen = quyenCha.id And s.idNhanVien = idNhanVien)
        newNode.Checked = PhanQuyen.TrangThai
        newNode.Tag = PhanQuyen
        For Each itm As tbQuyen In quyenCha.tbQuyens
            If itm.TheLoai <> 1 Then
                newNode.Nodes.Add(AddToTreeViewFromDatabase(itm, idNhanVien))
            End If
        Next
        Return newNode
    End Function

    Private Sub btnTaoQuyenChoNhanVien_Click(sender As Object, e As EventArgs) Handles btnTaoQuyenChoNhanVien.Click
        Dim newPhanQuyen As tbPhanQuyen
        For Each qy In dt.tbQuyens
            For Each nv In dt.tbNhanViens
                newPhanQuyen = New tbPhanQuyen
                newPhanQuyen.idNhanVien = nv.id
                newPhanQuyen.idQuyen = qy.id
                newPhanQuyen.TrangThai = True
                dt.tbPhanQuyens.InsertOnSubmit(newPhanQuyen)
            Next
        Next
        dt.SubmitChanges()
        MsgBox("Đã xong")
    End Sub

    Private Sub SaveDatabasePhanQuyen(node As TreeNode)
        node.Tag.TrangThai = node.Checked
        For Each cnode As TreeNode In node.Nodes
            SaveDatabasePhanQuyen(cnode)
        Next
    End Sub

    Private Sub tvwQuyenRibbon_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvwQuyenRibbon.AfterCheck, tvwQuyenRibbon.AfterCheck
        If e.Node.Checked = False Then
            For Each node As TreeNode In e.Node.Nodes
                node.Checked = False
            Next
        End If

        If e.Node.Checked = True Then
            If e.Node.Parent IsNot Nothing Then e.Node.Parent.Checked = True
        End If
    End Sub



    Private DaLoadControl As Boolean
    Private lstPhanQuyen As New List(Of tbQuyen)

    Private Sub LoadQuyenToList(phanQuyen As tbQuyen)
        lstPhanQuyen.Add(phanQuyen)
        For Each itm As tbQuyen In phanQuyen.tbQuyens
            If itm.TheLoai <= 1 Then
                LoadQuyenToList(itm)
            End If
        Next
    End Sub

    Private Sub LoadControlToList(ctrl As Control)
        If (ctrl.Tag IsNot Nothing) Then
            lstControl.Add(ctrl)
        End If
        For Each itm As Control In ctrl.Controls
            LoadControlToList(itm)
        Next
    End Sub

    Private Function GetNameOfControl(control As Control, str As String) As String
        str = control.Name
        If control.Parent IsNot Nothing And control.Parent.Name <> CtrlRibbon1.Name Then
            Return (str + GetNameOfControl(control.Parent, str))
        Else
            Return str
        End If
    End Function


    Dim lstControl As New List(Of Control)
    Private Function LoadToTreeView(nodeToAd As TreeNode, ctrl As Control) As TreeNode

        Dim newNode As TreeNode
        If (ctrl.Tag IsNot Nothing) Then
            newNode = New TreeNode(ctrl.Tag + "|" + ctrl.Name)
            lstControl.Add(ctrl)
        Else
            newNode = nodeToAd
        End If

        For Each itm As Control In ctrl.Controls
            If itm.Tag IsNot Nothing Then
                newNode.Nodes.Add(LoadToTreeView(newNode, itm))
            Else
                LoadToTreeView(newNode, itm)
            End If
        Next
        Return newNode
    End Function


    Private Sub btnCapNhatQuyenChoNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatQuyenChoNhanVien.Click
        If dt.tbPhanQuyens.Count = 0 Then Exit Sub
        If cmbNhanVien.SelectedItem IsNot Nothing Then
            tvwQuyenRibbon.Nodes.Clear()
            tvwQuyenRibbon.CheckBoxes = True
            Dim idNhanVien As Integer = cmbNhanVien.SelectedItem.id
            tvwQuyenRibbon.Nodes.Add(AddToTreeViewFromDatabase(dt.tbQuyens.FirstOrDefault(Function(s) s.idQuyenCha Is Nothing), idNhanVien))
            tvwQuyenRibbon.ExpandAll()
            tvwQuyenRibbon.SelectedNode = tvwQuyenRibbon.Nodes(0)
        Else
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhân viên để phân quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnCapNhatNhanVien_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVien.Click
        cmbNhanVien.DataSource = From itm In dt.tbNhanViens
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        SaveDatabasePhanQuyen(tvwQuyenRibbon.Nodes(0))
        dt.SubmitChanges()
        ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Đã lưu phân quyền xong." + vbNewLine + _
                                                                "Đăng nhập với nhân viên vừa phân quyền để thây kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private ChonTatCa As Boolean
    Private Sub btnChonTatCa_Click(sender As Object, e As EventArgs) Handles btnChonTatCa.Click
        ChonTatCa = Not ChonTatCa

        For Each n1 As TreeNode In tvwQuyenRibbon.Nodes
            n1.Checked = ChonTatCa
            For Each n2 As TreeNode In n1.Nodes
                n2.Checked = ChonTatCa
                For Each n3 As TreeNode In n2.Nodes
                    n3.Checked = ChonTatCa
                    For Each n4 As TreeNode In n3.Nodes
                        n4.Checked = ChonTatCa
                        For Each n5 As TreeNode In n4.Nodes
                            n5.Checked = ChonTatCa
                            For Each n6 As TreeNode In n5.Nodes
                                n6.Checked = ChonTatCa
                            Next
                        Next
                    Next
                Next
            Next
        Next

        If ChonTatCa Then
            btnChonTatCa.Text = "Bỏ chọn tất cả"
            btnChonTatCa.Image = My.Resources.unchecked
        Else
            btnChonTatCa.Text = "Chọn tất cả"
            btnChonTatCa.Image = My.Resources.Checked
        End If
    End Sub

    Private Sub btnXemKetQua_Click(sender As Object, e As EventArgs) Handles btnXemKetQua.Click
        If cmbNhanVien.SelectedItem IsNot Nothing Then
            Dim idNhanVien As Integer = cmbNhanVien.SelectedItem.id
            If DaLoadControl = False Then
                lstControl.Clear()
                LoadControlToList(CtrlRibbon1.pnlHeader)
                DaLoadControl = True
            End If
            lstPhanQuyen.Clear()
            LoadQuyenToList(dt.tbQuyens.Single(Function(s) s.idQuyenCha Is Nothing))
            Dim j As Integer = 0
            For j = 0 To lstPhanQuyen.Count - 1
                Dim PhanQuyen As tbPhanQuyen = dt.tbPhanQuyens.Single(Function(s) s.idQuyen = lstPhanQuyen(j).id And s.idNhanVien = idNhanVien)
                If PhanQuyen.tbQuyen.HinhThuc = 0 And PhanQuyen.tbQuyen.TheLoai < 0 Then
                    lstControl(j).Visible = PhanQuyen.TrangThai
                ElseIf PhanQuyen.tbQuyen.HinhThuc = 1 Then
                    lstControl(j).Enabled = PhanQuyen.TrangThai
                Else
                    If lstControl(j).GetType.Name.Contains("Textbox") Then
                    ElseIf lstControl(j).GetType.Name.Contains("DatagridViewColumn") Then
                    ElseIf lstControl(j).GetType.Name.Contains("DatagridView") Then
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub btnChonNhanhQuyenRibbon_Click(sender As Object, e As EventArgs) Handles btnChonNhanhQuyenRibbon.Click
        If tvwQuyenRibbon.SelectedNode Is Nothing Then Exit Sub
        tvwQuyenRibbon.SelectedNode.Checked = True
        For Each n1 As TreeNode In tvwQuyenRibbon.SelectedNode.Nodes
            n1.Checked = True
            For Each n2 As TreeNode In n1.Nodes
                n2.Checked = True
                For Each n3 As TreeNode In n2.Nodes
                    n3.Checked = True
                    For Each n4 As TreeNode In n3.Nodes
                        n4.Checked = True
                    Next
                Next
            Next
        Next
    End Sub


    Private Sub btnSaoChep_Click(sender As Object, e As EventArgs) Handles btnSaoChep.Click
        If cmbNhanVien.SelectedItem Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhân viên sao chép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If cmbNhanVienDuocSaoChep.SelectedItem Is Nothing Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Vui lòng chọn nhân viên được sao chép!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim NhanVienCopy As tbNhanVien = cmbNhanVien.SelectedItem
        Dim NhanVienPaste As tbNhanVien = cmbNhanVienDuocSaoChep.SelectedItem
        If NhanVienPaste.id = NhanVienCopy.id Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không thể chuyển quyền cùng một người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Bạn muốn chuyển quyền từ người " + NhanVienCopy.TenDangNhap + " tới " + NhanVienPaste.TenDangNhap + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Exit Sub
        End If
        For Each quyen In dt.tbPhanQuyens.Where(Function(s) s.idNhanVien = NhanVienCopy.id)
            dt.tbPhanQuyens.Single(Function(s) s.idQuyen = quyen.idQuyen And s.idNhanVien = NhanVienPaste.id).TrangThai = quyen.TrangThai
        Next
        Try
            dt.SubmitChanges()
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Chuyển quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Chuyển quyền thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnCapNhatNhanVienSaoChep_Click(sender As Object, e As EventArgs) Handles btnCapNhatNhanVienSaoChep.Click
        Dim nv As tbNhanVien = cmbNhanVien.SelectedItem
        If nv IsNot Nothing Then
            cmbNhanVienDuocSaoChep.DataSource = From itm In dt.tbNhanViens
                                                Where itm.id <> nv.id
        Else
            cmbNhanVienDuocSaoChep.DataSource = From itm In dt.tbNhanViens
        End If
    End Sub

    Private Sub cmbNhanVien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNhanVien.SelectedIndexChanged
        If cmbNhanVien.SelectedItem IsNot Nothing Then
            btnCapNhatQuyenChoNhanVien_Click(Nothing, Nothing)
            btnCapNhatNhanVienSaoChep_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnLoadTreeviewFromControl_Click(sender As Object, e As EventArgs) Handles btnLoadTreeviewFromControl.Click
        tvwQuyenRibbon.Nodes.Clear()
        tvwQuyenRibbon.Nodes.Add(LoadToTreeView(Nothing, CtrlRibbon1.pnlHeader))
    End Sub

    Private Sub ctrlPhanQuyen_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnCapNhatNhanVien_Click(Nothing, Nothing)
    End Sub

    Private Sub lnkAdministrator_LinkClicked(sender As Object, e As EventArgs) Handles lnkAdministrator.LinkClicked
        If pnlAdmin.Visible = False Then
            Dim frm As New frmXacNhanMatKhau
            If frm.ShowDialog = DialogResult.OK Then
                pnlAdmin.Visible = True
                lnkAdministrator.Text = "Đóng"
            End If
        Else
            lnkAdministrator.Text = "Mở chức năng Admin"
            pnlAdmin.Visible = False
        End If
    End Sub

    Private Sub btnXoaQuyen_Click(sender As Object, e As EventArgs) Handles btnXoaQuyen.Click
        For Each itm In dt.tbPhanQuyens
            dt.tbPhanQuyens.DeleteOnSubmit(itm)
        Next
        For Each itm In dt.tbQuyens
            dt.tbQuyens.DeleteOnSubmit(itm)
        Next
        dt.SubmitChanges()
        dt.ExecuteCommand("DBCC CHECKIDENT('tbPhanQuyen', RESEED, 0)")
        dt.ExecuteCommand("DBCC CHECKIDENT('tbQuyen', RESEED, 0)")
        MsgBox("Đã xong")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnXoaPhanQuyen.Click
        For Each itm In dt.tbPhanQuyens
            dt.tbPhanQuyens.DeleteOnSubmit(itm)
        Next
        dt.SubmitChanges()
        dt.ExecuteCommand("DBCC CHECKIDENT('tbPhanQuyen', RESEED, 0)")
        MsgBox("Đã xong")
    End Sub

End Class
