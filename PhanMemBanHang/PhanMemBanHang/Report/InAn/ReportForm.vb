Imports Microsoft.Reporting.WinForms
Imports System.Text
Imports System.IO

Public Class ReportForm

    Public Shared WriteOnly Property DLGRptPath As String
        Set(value As String)
            PrintForm.viewer.LocalReport.ReportPath = value
        End Set
    End Property

    Public Shared WriteOnly Property SLNRptPath As String
        Set(value As String)
            SilentPrintForm.viewer.Reset()
            SilentPrintForm.viewer.LocalReport.ReportPath = value
        End Set
    End Property


    Public Shared WriteOnly Property DLGlstPara() As ReportParameterCollection
        Set(value As ReportParameterCollection)
            PrintForm.viewer.LocalReport.EnableExternalImages = True
            PrintForm.viewer.LocalReport.SetParameters(value)
        End Set
    End Property

    Public Shared WriteOnly Property DLGrptDs() As ReportDataSource
        Set(value As ReportDataSource)
            PrintForm.viewer.LocalReport.DataSources.Clear()
            PrintForm.viewer.LocalReport.DataSources.Add(value)
        End Set
    End Property

    Public Shared WriteOnly Property SLNlstPara() As ReportParameterCollection
        Set(value As ReportParameterCollection)
            SilentPrintForm.viewer.LocalReport.EnableExternalImages = True
            SilentPrintForm.viewer.LocalReport.SetParameters(value)
        End Set
    End Property

    Public Shared WriteOnly Property SLNrptDs() As ReportDataSource
        Set(value As ReportDataSource)
            SilentPrintForm.viewer.LocalReport.DataSources.Clear()
            SilentPrintForm.viewer.LocalReport.DataSources.Add(value)
        End Set
    End Property

    Public Shared WriteOnly Property SLNrptDsLogo() As ReportDataSource
        Set(value As ReportDataSource)
            SilentPrintForm.viewer.LocalReport.DataSources.Add(value)
        End Set
    End Property

    Public Shared SilentPrintForm As New ReportForm(False)
    Public Shared PrintForm As New ReportForm(True)

    Private Sub New(Optional bprint As Boolean = False)
        InitializeComponent()
        '   viewer.LocalReport.ReportPath = "Report.rdlc"
        If (bprint) Then
            AddHandler viewer.RenderingComplete, AddressOf viewer_RenderingComplete
        End If

    End Sub
    Private Sub OnRenderingCompletePrintOnly(sender As Object, args As System.ComponentModel.AsyncCompletedEventArgs)
        Dim objviewer As Object = viewer
        Dim prms As Object() = {sender, args}
        mdlReportViewer.ExecuteFunction(objviewer, prms, "OnRenderingCompletePrintOnly")
    End Sub
    Private streamed As Boolean = False
    Private Function CreateStreamEMFPrintOnly(name As String, extension As String, encoding As Encoding, mimeType As String, useChunking As Boolean, operation As Microsoft.ReportingServices.Interfaces.StreamOper) As Stream
        If streamed Then
            Return Nothing
        End If
        streamed = True
        Dim objviewer As Object = viewer
        Dim prms As Object() = {name, extension, encoding, mimeType, useChunking, operation}
        Dim str As Stream = DirectCast(mdlReportViewer.ExecuteFunction(objviewer, prms, "CreateStreamEMFPrintOnly"), Stream)
        Return str
    End Function
    Public ReadOnly Property CreateAndRegisterStream() As Microsoft.ReportingServices.Interfaces.CreateAndRegisterStream
        Get
            Return New Microsoft.ReportingServices.Interfaces.CreateAndRegisterStream(AddressOf CreateStreamEMFPrintOnly)
        End Get
    End Property
    Public ReadOnly Property AsyncCompletedEventHandler() As System.ComponentModel.AsyncCompletedEventHandler
        Get
            Return New System.ComponentModel.AsyncCompletedEventHandler(AddressOf Me.OnRenderingCompletePrintOnly)
        End Get
    End Property
    Public Sub Print()
        viewer.RefreshReport()
    End Sub
    Public Sub PrintByPrinter(Printername As String)
        mdlReportViewer.PrintByPriner(Me, viewer, Printername)
    End Sub
    Private Sub viewer_RenderingComplete(sender As Object, e As RenderingCompleteEventArgs)
        mdlReportViewer.PrintwithDialog(viewer)
    End Sub
    Public Property Title() As Object
        Get
            Return m_Title
        End Get
        Set(value As Object)
            m_Title = value
        End Set
    End Property
    Private m_Title As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.viewer.RefreshReport()
    End Sub
End Class
