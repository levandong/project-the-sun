Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Xml

Public Class ctrlKetNoiDatabase
    Private Sub btnTestKetNoi_Click(sender As Object, e As EventArgs) Handles btnTestKetNoi.Click
        Dim cntString As String = "Data Source=" + txtServer.Text.Trim + ";Initial Catalog=" + txtDatabase.Text.Trim + ";User ID=" + txtUser.Text.Trim + ";Password=" + txtPassword.Text.Trim
        Dim dx As New dcQLDataContext(cntString)
        Try
            dx.Connection.Open()
            lnkLuuThongTinKetNoi.Enabled = True
            txtLoi.Text = "Kết nối thành công!"
        Catch ex As Exception
            lnkLuuThongTinKetNoi.Enabled = False
            txtLoi.Text = ex.Message
            If ex.Message = "Login failed for user '" + txtUser.Text.Trim + "'." Then
                txtLoi.Text = "Tên đăng nhập/mật khẩu không đúng."
            ElseIf ex.Message.StartsWith("Cannot open database """ + txtDatabase.Text.Trim + """+ requested by the login.") Then
                txtLoi.Text = "Tên database không đúng hoặc không khả dụng."
            ElseIf ex.Message.Contains("The server was not found or was not accessible.") Then
                txtLoi.Text = "Server không đúng hoặc không khả dụng."
            Else
                txtLoi.Text = ex.Message
            End If

        End Try
    End Sub

    Private Sub lnkLuuThongTinKetNoi_LinkClicked(sender As Object, e As EventArgs) Handles lnkLuuThongTinKetNoi.LinkClicked
        connectionString.DataSource = txtServer.Text.Trim
        connectionString.UserID = txtUser.Text.Trim
        connectionString.Password = txtPassword.Text.Trim
        connectionString.InitialCatalog = txtDatabase.Text.Trim
        connectionString.MultipleActiveResultSets = True
        Dim aMaHoa As New TMTSecuritys.clsMaHoa
        My.Settings.ThongTinKetNoi = aMaHoa.Encrypt(connectionString.ConnectionString, "tmt6364")
        My.Settings.Save()

        If chkCopyClipboard.Checked Then
            Clipboard.SetText(My.Settings.ThongTinKetNoi)
        End If
        If chkSaveSetting.Checked Then
            Dim docXML As XmlDocument = New XmlDataDocument
            docXML.Load(".\" + Application.ProductName + ".exe.config")
            For Each itm As XmlNode In docXML.GetElementsByTagName("setting")
                If itm.Attributes("name").Value = "ThongTinKetNoi" Then
                    itm.FirstChild.InnerXml = My.Settings.ThongTinKetNoi
                    Exit For
                End If
            Next
            docXML.Save(".\" + Application.ProductName + ".exe.config")
        End If
        ctrlKetNoiDatabase_Load(Nothing, Nothing)
    End Sub


    Private connectionString As New SqlConnectionStringBuilder
    Private Sub ctrlKetNoiDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim ConnectionStringDaMaHoa = mh.Decrypt(My.Settings.ThongTinKetNoi, "tmt6364")
            connectionString = New SqlConnectionStringBuilder(ConnectionStringDaMaHoa)
            txtServer.Text = connectionString.DataSource
            txtUser.Text = connectionString.UserID
            txtPassword.Text = connectionString.Password
            txtDatabase.Text = connectionString.InitialCatalog
        Catch
        End Try
    End Sub

End Class
