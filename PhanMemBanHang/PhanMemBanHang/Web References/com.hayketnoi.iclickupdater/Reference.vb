﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace com.hayketnoi.iclickupdater
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="BasicHttpBinding_IUpdateIClick", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UpdateIClick
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private DoWorkOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CheckUpdateOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SubmitUpdateOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CheckExecuteQueryOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UpdateResultExecuteQueryOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.PhanMemBanHang.My.MySettings.Default.PhanMemBanHang_com_hayketnoi_iclickupdater_UpdateIClick
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event DoWorkCompleted As DoWorkCompletedEventHandler
        
        '''<remarks/>
        Public Event CheckUpdateCompleted As CheckUpdateCompletedEventHandler
        
        '''<remarks/>
        Public Event SubmitUpdateCompleted As SubmitUpdateCompletedEventHandler
        
        '''<remarks/>
        Public Event CheckExecuteQueryCompleted As CheckExecuteQueryCompletedEventHandler
        
        '''<remarks/>
        Public Event UpdateResultExecuteQueryCompleted As UpdateResultExecuteQueryCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IUpdateIClick/DoWork", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub DoWork()
            Me.Invoke("DoWork", New Object(-1) {})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DoWorkAsync()
            Me.DoWorkAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub DoWorkAsync(ByVal userState As Object)
            If (Me.DoWorkOperationCompleted Is Nothing) Then
                Me.DoWorkOperationCompleted = AddressOf Me.OnDoWorkOperationCompleted
            End If
            Me.InvokeAsync("DoWork", New Object(-1) {}, Me.DoWorkOperationCompleted, userState)
        End Sub
        
        Private Sub OnDoWorkOperationCompleted(ByVal arg As Object)
            If (Not (Me.DoWorkCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent DoWorkCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IUpdateIClick/CheckUpdate", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CheckUpdate(<System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal ProductCode As String, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal ProductVersion As String) As <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> String
            Dim results() As Object = Me.Invoke("CheckUpdate", New Object() {ProductCode, ProductVersion})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CheckUpdateAsync(ByVal ProductCode As String, ByVal ProductVersion As String)
            Me.CheckUpdateAsync(ProductCode, ProductVersion, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CheckUpdateAsync(ByVal ProductCode As String, ByVal ProductVersion As String, ByVal userState As Object)
            If (Me.CheckUpdateOperationCompleted Is Nothing) Then
                Me.CheckUpdateOperationCompleted = AddressOf Me.OnCheckUpdateOperationCompleted
            End If
            Me.InvokeAsync("CheckUpdate", New Object() {ProductCode, ProductVersion}, Me.CheckUpdateOperationCompleted, userState)
        End Sub
        
        Private Sub OnCheckUpdateOperationCompleted(ByVal arg As Object)
            If (Not (Me.CheckUpdateCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CheckUpdateCompleted(Me, New CheckUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IUpdateIClick/SubmitUpdate", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SubmitUpdate(<System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal ProductCode As String, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal ProductVersion As String, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal MachineName As String, ByVal ExecutedQuery As Boolean, <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal ExecutedQuerySpecified As Boolean, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal strError As String, ByVal isSuccessfful As Boolean, <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal isSuccessffulSpecified As Boolean, ByVal isDaChayQueryThanhCong As Boolean, <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal isDaChayQueryThanhCongSpecified As Boolean) As <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> String
            Dim results() As Object = Me.Invoke("SubmitUpdate", New Object() {ProductCode, ProductVersion, MachineName, ExecutedQuery, ExecutedQuerySpecified, strError, isSuccessfful, isSuccessffulSpecified, isDaChayQueryThanhCong, isDaChayQueryThanhCongSpecified})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub SubmitUpdateAsync(ByVal ProductCode As String, ByVal ProductVersion As String, ByVal MachineName As String, ByVal ExecutedQuery As Boolean, ByVal ExecutedQuerySpecified As Boolean, ByVal strError As String, ByVal isSuccessfful As Boolean, ByVal isSuccessffulSpecified As Boolean, ByVal isDaChayQueryThanhCong As Boolean, ByVal isDaChayQueryThanhCongSpecified As Boolean)
            Me.SubmitUpdateAsync(ProductCode, ProductVersion, MachineName, ExecutedQuery, ExecutedQuerySpecified, strError, isSuccessfful, isSuccessffulSpecified, isDaChayQueryThanhCong, isDaChayQueryThanhCongSpecified, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SubmitUpdateAsync(ByVal ProductCode As String, ByVal ProductVersion As String, ByVal MachineName As String, ByVal ExecutedQuery As Boolean, ByVal ExecutedQuerySpecified As Boolean, ByVal strError As String, ByVal isSuccessfful As Boolean, ByVal isSuccessffulSpecified As Boolean, ByVal isDaChayQueryThanhCong As Boolean, ByVal isDaChayQueryThanhCongSpecified As Boolean, ByVal userState As Object)
            If (Me.SubmitUpdateOperationCompleted Is Nothing) Then
                Me.SubmitUpdateOperationCompleted = AddressOf Me.OnSubmitUpdateOperationCompleted
            End If
            Me.InvokeAsync("SubmitUpdate", New Object() {ProductCode, ProductVersion, MachineName, ExecutedQuery, ExecutedQuerySpecified, strError, isSuccessfful, isSuccessffulSpecified, isDaChayQueryThanhCong, isDaChayQueryThanhCongSpecified}, Me.SubmitUpdateOperationCompleted, userState)
        End Sub
        
        Private Sub OnSubmitUpdateOperationCompleted(ByVal arg As Object)
            If (Not (Me.SubmitUpdateCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SubmitUpdateCompleted(Me, New SubmitUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IUpdateIClick/CheckExecuteQuery", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub CheckExecuteQuery(ByVal idChiTietLanCapNhat As Integer, <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal idChiTietLanCapNhatSpecified As Boolean, ByRef CheckExecuteQueryResult As Boolean, <System.Xml.Serialization.XmlIgnoreAttribute()> ByRef CheckExecuteQueryResultSpecified As Boolean)
            Dim results() As Object = Me.Invoke("CheckExecuteQuery", New Object() {idChiTietLanCapNhat, idChiTietLanCapNhatSpecified})
            CheckExecuteQueryResult = CType(results(0),Boolean)
            CheckExecuteQueryResultSpecified = CType(results(1),Boolean)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CheckExecuteQueryAsync(ByVal idChiTietLanCapNhat As Integer, ByVal idChiTietLanCapNhatSpecified As Boolean)
            Me.CheckExecuteQueryAsync(idChiTietLanCapNhat, idChiTietLanCapNhatSpecified, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CheckExecuteQueryAsync(ByVal idChiTietLanCapNhat As Integer, ByVal idChiTietLanCapNhatSpecified As Boolean, ByVal userState As Object)
            If (Me.CheckExecuteQueryOperationCompleted Is Nothing) Then
                Me.CheckExecuteQueryOperationCompleted = AddressOf Me.OnCheckExecuteQueryOperationCompleted
            End If
            Me.InvokeAsync("CheckExecuteQuery", New Object() {idChiTietLanCapNhat, idChiTietLanCapNhatSpecified}, Me.CheckExecuteQueryOperationCompleted, userState)
        End Sub
        
        Private Sub OnCheckExecuteQueryOperationCompleted(ByVal arg As Object)
            If (Not (Me.CheckExecuteQueryCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CheckExecuteQueryCompleted(Me, New CheckExecuteQueryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IUpdateIClick/UpdateResultExecuteQuery", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UpdateResultExecuteQuery(ByVal idChiTietLanCapNhat As Integer, <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal idChiTietLanCapNhatSpecified As Boolean, ByVal isDaChayQuery As Boolean, <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal isDaChayQuerySpecified As Boolean, ByVal isDaChayQueryThanhCong As Boolean, <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal isDaChayQueryThanhCongSpecified As Boolean, ByVal isThanhCong As Boolean, <System.Xml.Serialization.XmlIgnoreAttribute()> ByVal isThanhCongSpecified As Boolean) As <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> String
            Dim results() As Object = Me.Invoke("UpdateResultExecuteQuery", New Object() {idChiTietLanCapNhat, idChiTietLanCapNhatSpecified, isDaChayQuery, isDaChayQuerySpecified, isDaChayQueryThanhCong, isDaChayQueryThanhCongSpecified, isThanhCong, isThanhCongSpecified})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub UpdateResultExecuteQueryAsync(ByVal idChiTietLanCapNhat As Integer, ByVal idChiTietLanCapNhatSpecified As Boolean, ByVal isDaChayQuery As Boolean, ByVal isDaChayQuerySpecified As Boolean, ByVal isDaChayQueryThanhCong As Boolean, ByVal isDaChayQueryThanhCongSpecified As Boolean, ByVal isThanhCong As Boolean, ByVal isThanhCongSpecified As Boolean)
            Me.UpdateResultExecuteQueryAsync(idChiTietLanCapNhat, idChiTietLanCapNhatSpecified, isDaChayQuery, isDaChayQuerySpecified, isDaChayQueryThanhCong, isDaChayQueryThanhCongSpecified, isThanhCong, isThanhCongSpecified, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UpdateResultExecuteQueryAsync(ByVal idChiTietLanCapNhat As Integer, ByVal idChiTietLanCapNhatSpecified As Boolean, ByVal isDaChayQuery As Boolean, ByVal isDaChayQuerySpecified As Boolean, ByVal isDaChayQueryThanhCong As Boolean, ByVal isDaChayQueryThanhCongSpecified As Boolean, ByVal isThanhCong As Boolean, ByVal isThanhCongSpecified As Boolean, ByVal userState As Object)
            If (Me.UpdateResultExecuteQueryOperationCompleted Is Nothing) Then
                Me.UpdateResultExecuteQueryOperationCompleted = AddressOf Me.OnUpdateResultExecuteQueryOperationCompleted
            End If
            Me.InvokeAsync("UpdateResultExecuteQuery", New Object() {idChiTietLanCapNhat, idChiTietLanCapNhatSpecified, isDaChayQuery, isDaChayQuerySpecified, isDaChayQueryThanhCong, isDaChayQueryThanhCongSpecified, isThanhCong, isThanhCongSpecified}, Me.UpdateResultExecuteQueryOperationCompleted, userState)
        End Sub
        
        Private Sub OnUpdateResultExecuteQueryOperationCompleted(ByVal arg As Object)
            If (Not (Me.UpdateResultExecuteQueryCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UpdateResultExecuteQueryCompleted(Me, New UpdateResultExecuteQueryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")>  _
    Public Delegate Sub DoWorkCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")>  _
    Public Delegate Sub CheckUpdateCompletedEventHandler(ByVal sender As Object, ByVal e As CheckUpdateCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class CheckUpdateCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")>  _
    Public Delegate Sub SubmitUpdateCompletedEventHandler(ByVal sender As Object, ByVal e As SubmitUpdateCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class SubmitUpdateCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")>  _
    Public Delegate Sub CheckExecuteQueryCompletedEventHandler(ByVal sender As Object, ByVal e As CheckExecuteQueryCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class CheckExecuteQueryCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property CheckExecuteQueryResult() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property CheckExecuteQueryResultSpecified() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")>  _
    Public Delegate Sub UpdateResultExecuteQueryCompletedEventHandler(ByVal sender As Object, ByVal e As UpdateResultExecuteQueryCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UpdateResultExecuteQueryCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
