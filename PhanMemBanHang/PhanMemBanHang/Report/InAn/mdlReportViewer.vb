Imports System.Reflection
Imports System.Drawing.Printing

Module mdlReportViewer
    Friend Function ExecuteFunction(obj As Object, parms As Object(), fnName As String) As Object
        Try
            Dim t As Type = obj.[GetType]()
            Dim infos As MethodInfo() = t.GetMethods(BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance)
            Dim c = From pe In infos Where pe.Name = fnName Select pe
            For Each info As MethodInfo In c
                Return info.Invoke(obj, parms)
            Next
            Return Nothing
        Catch
            ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("Không in được theo kiểu 2. Vui lòng đổi kiểu in.", "Thông báo", MessageBoxButtons.OK)
            Return Nothing
        End Try

    End Function
    Private Function GetPropertyVal(obj As Object, properityName As String) As Object
        Dim t As Type = obj.[GetType]()
        Dim info As PropertyInfo = t.GetProperty(properityName, BindingFlags.NonPublic Or BindingFlags.[Public] Or BindingFlags.Instance)
        Return info.GetValue(obj, Nothing)

    End Function
    Public Sub WriteProperityVal(srcobj As Object, val As Object, properityName As String)
        Dim infos = From inf In srcobj.[GetType]().GetProperties() Where inf.Name = properityName Select inf
        For Each inf As PropertyInfo In infos

            inf.SetValue(srcobj, val, Nothing)
        Next

    End Sub
    Public Sub PrintwithDialog(viewer As Microsoft.Reporting.WinForms.ReportViewer)
        If True Then
            Dim parms As Object() = {viewer, EventArgs.Empty}
            ExecuteFunction(viewer, parms, "OnPrint")
        End If
    End Sub
    Public Sub PrintByPriner(report As ReportForm, viewer As Microsoft.Reporting.WinForms.ReportViewer, Printername As String)
        viewer.RefreshReport()
        viewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Dim pagesettings As PageSettings = viewer.GetPageSettings()
        Dim objviewer As Object = viewer
        Dim info As FieldInfo = viewer.[GetType]().GetField("m_lastUIState", BindingFlags.FlattenHierarchy Or BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.NonPublic)
        Dim m_lastUIState As Object = info.GetValue(objviewer)
        Dim PostRenderArgs As Object = Nothing
        Dim variables = From nn In viewer.[GetType]().Assembly.GetTypes() Where nn.Name.Contains("ReportViewerStatus") OrElse nn.Name.Contains("PostRenderArgs") Select nn
        For Each type As Type In variables
            If type.Name.Contains("ReportViewerStatus") Then
                Dim prms As Object() = {m_lastUIState}
                ExecuteFunction(type, prms, "DoesStateAllowPrinting")
            End If
            If type.Name.Contains("PostRenderArgs") Then
                Dim ooo As Object() = {False, False}
                PostRenderArgs = Activator.CreateInstance(type, ooo)
            End If
        Next
        Dim pr As Object = ExecuteFunction(objviewer, Nothing, "CreateDefaultPrintSettings")
        TryCast(pr, System.Drawing.Printing.PrinterSettings).Copies = 1
        TryCast(pr, System.Drawing.Printing.PrinterSettings).PrinterName = Printername

        If True Then
            Dim prms As Object() = {objviewer, pr}
            ExecuteFunction(objviewer, prms, "OnPrintingBegin")
        End If
        Dim processprms As Object() = {0, 0}
        Dim deviceInfo As String = ExecuteFunction(objviewer, processprms, "CreateEMFDeviceInfo").ToString()
        ExecuteFunction(objviewer, Nothing, "ProcessAsyncInvokes")
        WriteProperityVal(objviewer, True, "PrintDialogDisplayed")
        Dim parms As Object() = {"IMAGE", True, deviceInfo, Microsoft.Reporting.WinForms.PageCountMode.Estimate, report.CreateAndRegisterStream, report.AsyncCompletedEventHandler, _
            PostRenderArgs, False}
        ExecuteFunction(objviewer, parms, "BeginAsyncRender")
        Dim currentReport As Object = GetPropertyVal(objviewer, "CurrentReport")
        Dim fileManager As Object = GetPropertyVal(currentReport, "FileManager")

        Dim ReportPrintDocument As Object = Nothing
        Dim variables2 = From nn In viewer.[GetType]().Assembly.GetTypes() Where nn.Name.Contains("ReportPrintDocument") Select nn
        For Each type As Type In variables2


            Dim parms2 As Object() = {fileManager, pagesettings.Clone()}
            Dim ci As ConstructorInfo = type.GetConstructor(BindingFlags.NonPublic Or BindingFlags.Instance, Nothing, New Type() {fileManager.[GetType](), GetType(PageSettings)}, Nothing)
            ReportPrintDocument = ci.Invoke(parms2)

            WriteProperityVal(ReportPrintDocument, pr, "PrinterSettings")
            WriteProperityVal(ReportPrintDocument, report.Title, "DocumentName")
            ExecuteFunction(ReportPrintDocument, Nothing, "Print")
        Next

    End Sub

End Module
