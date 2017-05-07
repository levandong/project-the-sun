Public Class ctrlTabPanel
    '  Public dicPanel As New Dictionary(Of ctrlTabHeader, Control)
    Private newCheckBox As New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Public Sub ThemTabpageMoi(TenHienThi As String, Ten As String, control As Control)
        Dim rls = pnlHeader.Controls.Cast(Of ctrlTabHeader).Where(Function(s) s.Name = Ten).FirstOrDefault
        If rls IsNot Nothing Then
            rls.chkCheck.Checked = True
        Else
            pnlHeader.SuspendLayout()
            Dim TabHeader As ctrlTabHeader
            TabHeader = New ctrlTabHeader
            TabHeader.chkCheck.Text = TenHienThi
            TabHeader.Name = Ten
            If Ten = "BanHang" Then
                TabHeader.chkCheck.Values.Image = My.Resources.BlueStar_16
            ElseIf Ten = "BamChucNangBanLe" Then
                TabHeader.chkCheck.Values.Image = My.Resources.Star_16
            End If
            chkSet.CheckButtons.Add(TabHeader.chkCheck)
            TabHeader.chkCheck.Checked = True
            TabHeader.MinimumSize = New Size(100, 22)
            newCheckBox.Text = TenHienThi
            AddHandler TabHeader.CloseTabpage, AddressOf DongTabPageXong
            TabHeader.chkCheck.Checked = True
            TabHeader.Dock = DockStyle.Left
            pnlHeader.Controls.Add(TabHeader)
            TabHeader.BringToFront()
            control.Dock = DockStyle.Fill
            TabHeader.tabPanel = control
            pnlHeader.ResumeLayout()
            chkSet_CheckedButtonChanged(Nothing, Nothing)
        End If

    End Sub

    Private Sub ctrlTabPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        newCheckBox.AutoSize = True
        lblPhienBan.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub DongTabPageXong(tabHeader As ctrlTabHeader)

        Dim rls = pnlHeader.Controls.Cast(Of ctrlTabHeader).Where(Function(s) s.TabIndex > tabHeader.TabIndex).OrderBy(Function(s) s.TabIndex).FirstOrDefault()
        If rls IsNot Nothing Then
            rls.chkCheck.Checked = True
        Else
            rls = pnlHeader.Controls.Cast(Of ctrlTabHeader).Where(Function(s) s.TabIndex < tabHeader.TabIndex).OrderByDescending(Function(s) s.TabIndex).FirstOrDefault()
            If rls IsNot Nothing Then
                rls.chkCheck.Checked = True
            Else
                ' đã xóa hết 
            End If

        End If



        KryptonSplitContainer1.Panel2.Controls.Remove(tabHeader.tabPanel)
        pnlHeader.Controls.Remove(tabHeader)
        tabHeader.tabPanel.Dispose()
        tabHeader.Dispose()
        tabHeader.tabPanel = Nothing
        tabHeader = Nothing
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim tabheader As ctrlTabHeader = chkSet.CheckedButton.Parent.Parent
        If tabheader.chkCheck.Checked Then
            Dim rls = pnlHeader.Controls.Cast(Of ctrlTabHeader).Where(Function(s) s.TabIndex > tabheader.TabIndex).OrderBy(Function(s) s.TabIndex).FirstOrDefault()
            If rls IsNot Nothing Then
                rls.chkCheck.Checked = True
            Else
                rls = pnlHeader.Controls.Cast(Of ctrlTabHeader).Where(Function(s) s.TabIndex < tabheader.TabIndex).OrderByDescending(Function(s) s.TabIndex).FirstOrDefault()
                If rls IsNot Nothing Then
                    rls.chkCheck.Checked = True
                Else
                    ' đã xóa hết 
                End If

            End If
        End If
        tabheader.btnClose_Click(Nothing, Nothing)
    End Sub

    Private Sub chkSet_CheckedButtonChanged(sender As Object, e As EventArgs) Handles chkSet.CheckedButtonChanged
        KryptonSplitContainer1.Panel2.SuspendLayout()
        For Each ctrl As Control In KryptonSplitContainer1.Panel2.Controls
            If ctrl.Name <> "KryptonPanel1" Then
                KryptonSplitContainer1.Panel2.Controls.Remove(ctrl)
            End If
        Next
        KryptonSplitContainer1.Panel2.Controls.Add(CType(chkSet.CheckedButton.Parent.Parent, ctrlTabHeader).tabPanel)
        KryptonPanel1.SendToBack()
        KryptonSplitContainer1.Panel2.ResumeLayout()
    End Sub

    Private Sub cmiDongTatCaTruTabDangChon_Click(sender As Object, e As EventArgs) Handles cmiDongTatCaTruTabDangChon.Click
        Dim rls = pnlHeader.Controls.Cast(Of ctrlTabHeader)().Where(Function(s) s.chkCheck.Checked = False).ToList
        For Each itm In rls
            '   If itm.chkCheck.Checked = False Then
            Dim tabheader As ctrlTabHeader = itm
            tabheader.btnClose_Click(Nothing, Nothing)
        Next

    End Sub


    Private tabVuaDong As ctrlTabHeader

    Private Sub cmiDongTabBenTrai_Click(sender As Object, e As EventArgs) Handles cmiDongTabBenTrai.Click
        ' đóng tab bên trái
        Dim checkTab As ctrlTabHeader = chkSet.CheckedButton.Parent.Parent
        Dim rls = pnlHeader.Controls.Cast(Of ctrlTabHeader).Where(Function(s) s.TabIndex < checkTab.TabIndex).ToList
        For Each itm In rls
            Dim tabheader As ctrlTabHeader = itm
            tabheader.btnClose_Click(Nothing, Nothing)
        Next
    End Sub
    Private Sub cmiDongTabBenPhai_Click(sender As Object, e As EventArgs) Handles cmiDongTabBenPhai.Click
        Dim checkTab As ctrlTabHeader = chkSet.CheckedButton.Parent.Parent
        Dim rls = pnlHeader.Controls.Cast(Of ctrlTabHeader).Where(Function(s) s.TabIndex > checkTab.TabIndex).ToList
        For Each itm In rls
            Dim tabheader As ctrlTabHeader = itm
            tabheader.btnClose_Click(Nothing, Nothing)
        Next
    End Sub
    Private Sub pnlHeader_ControlAdded(sender As Object, e As ControlEventArgs) Handles pnlHeader.ControlAdded
        btnClose.Visible = pnlHeader.Controls.Count > 0
    End Sub

    Private Sub pnlHeader_ControlRemoved(sender As Object, e As ControlEventArgs) Handles pnlHeader.ControlRemoved
        btnClose.Visible = pnlHeader.Controls.Count > 0
    End Sub

    Public Sub cmiDongTatCaTab_Click(sender As Object, e As EventArgs) Handles cmiDongTatCaTab.Click
        Dim rls = pnlHeader.Controls.Cast(Of ctrlTabHeader).ToList
        For Each itm In rls
            Dim tabheader As ctrlTabHeader = itm
            tabheader.btnClose_Click(Nothing, Nothing)
        Next
    End Sub

    Private Sub cmiMoLaiTabVuaDong_Click(sender As Object, e As EventArgs) Handles cmiMoLaiTabVuaDong.Click
        If tabVuaDong IsNot Nothing Then
            pnlHeader.Controls.Add(tabVuaDong)
            tabVuaDong.btnClose.Visible = False
        End If
    End Sub

    Private Sub KryptonLinkLabel1_LinkClicked(sender As Object, e As EventArgs) Handles KryptonLinkLabel1.LinkClicked
        Try
            Process.Start("www.phanmemtmt.com")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub KryptonLinkLabel2_LinkClicked(sender As Object, e As EventArgs) Handles KryptonLinkLabel2.LinkClicked
        Try
            Process.Start("www.truongminhthinh.com")
        Catch ex As Exception

        End Try
    End Sub
End Class
