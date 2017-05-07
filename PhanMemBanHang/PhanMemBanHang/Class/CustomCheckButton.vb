Public Class CustomCheckButton
    Inherits ComponentFactory.Krypton.Toolkit.KryptonCheckButton
    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            RaiseEvent BamEnter()
            Return True
        End If
        Return MyBase.ProcessDialogKey(keyData)
    End Function
    Event BamEnter()
End Class
