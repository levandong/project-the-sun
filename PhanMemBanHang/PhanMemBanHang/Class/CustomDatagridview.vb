Public Class CustomDatagridview
    Inherits ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Dim _editing As Boolean
    Property Editing As Boolean
        Get
            Return _editing
        End Get
        Set(value As Boolean)
            _editing = value
        End Set
    End Property
    Event KeyUpDown(keyData As Keys)
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If (keyData = Keys.Down Or keyData = Keys.Up) And Editing = True Then
            RaiseEvent KeyUpDown(keyData)
            Return True
        ElseIf keyData = Keys.Enter And Editing = True Then
            RaiseEvent KeyUpDown(keyData)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            RaiseEvent BamEnter()
            EndEdit()
            Return True
        End If
        If (keyData = Keys.Down Or keyData = Keys.Up) And Editing = True Then
            Return True
        End If
        Return MyBase.ProcessDialogKey(keyData)
    End Function
    Event BamEnter()
End Class
