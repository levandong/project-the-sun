Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms
Imports System.Drawing

Class mdlPrintReport
    Implements IDisposable
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    Private Function CreateStream(ByVal name As String, _
       ByVal fileNameExtension As String, _
       ByVal encoding As Encoding, ByVal mimeType As String, _
       ByVal willSeek As Boolean) As Stream
        Dim TenFile = name + TMT_GioHeThong.Ticks.ToString + "." + fileNameExtension
        Dim stream As Stream = _
            New FileStream(Application.StartupPath + "\FileTam\" + TenFile, FileMode.Create)
        m_streams.Add(stream)
        Return stream
    End Function

    Private Sub Export(ByVal report As LocalReport, rp As tbReport)
        Dim deviceInfo As String = _
          "<DeviceInfo>" + _
          "  <OutputFormat>EMF</OutputFormat>" + _
          "  <PageWidth>" + rp.SizeWidth.ToString + "mm" + "</PageWidth>" + _
          "  <PageHeight>" + rp.SizeHeight.ToString + "mm" + "</PageHeight>" + _
          "  <MarginTop>" + rp.MarginTop.ToString + "mm" + "</MarginTop>" + _
          "  <MarginLeft>" + rp.MarginLeft.ToString + "mm" + "</MarginLeft>" + _
          "  <MarginRight>" + rp.MarginRight.ToString + "mm" + "</MarginRight>" + _
          "  <MarginBottom>" + rp.MarginBot.ToString + "mm" + "</MarginBottom>" + _
          "</DeviceInfo>"

        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, _
           warnings)

        Dim stream As Stream
        stream = Nothing
        For Each stream In m_streams
            stream.Position = 0
        Next
        '  stream.Dispose()
    End Sub

    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
        ' giấy A5 nằm giữa tờ giấy Letter
        ' ev.PageSettings.PaperSize = a
        ' ev.Graphics.DrawImage(pageImage, New Rectangle(New Point(-18, -18), New Size(830, 1170)))
        Dim chinhLaiHinhChuNhat As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX), _
         ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY), _
         ev.PageBounds.Width, ev.PageBounds.Height)

        ev.Graphics.DrawImage(pageImage, chinhLaiHinhChuNhat)

        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Public Sub Print(rp As tbReport)
        If m_streams Is Nothing Or m_streams.Count = 0 Then
            Return
        End If
        Dim printDoc As New PrintDocument()
        printDoc.PrinterSettings.PrinterName = rp.TenMayIn
        printDoc.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize(rp.Size, rp.PixelWidth, rp.PixelHeight)
        If Not printDoc.PrinterSettings.IsValid Then
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Lỗi: Không tìm thấy máy in " + rp.TenMayIn)
            Exit Sub
        End If
        AddHandler printDoc.PrintPage, AddressOf PrintPage
        printDoc.Print()
    End Sub

    Public Sub Run(report As LocalReport, rp As tbReport)
        Export(report, rp)
        m_currentPageIndex = 0
        Print(rp)
    End Sub

    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        If Not (m_streams Is Nothing) Then
            Dim stream As Stream
            For Each stream In m_streams
                stream.Close()
            Next
            m_streams = Nothing
        End If
    End Sub

End Class
