Imports System.Runtime.CompilerServices

Module ControlHelper
    <Extension()>
    Sub InvokeEX(ByVal control As Control, ByVal action As System.Action)
        If control.InvokeRequired Then
            control.Invoke(action)
        Else
            action()
        End If
    End Sub

    <Extension()>
    Function InvokeGetTextEX(ByVal control As Control, ByVal action As Func(Of String)) As String
        If control.InvokeRequired Then
            Return CStr(control.Invoke(action))
        Else
            Return action()
        End If
    End Function

    <Extension()>
    Function InvokeGetIntegerEX(ByVal control As Control, ByVal action As Func(Of Integer)) As Integer
        If control.InvokeRequired Then
            Return CInt(control.Invoke(action))
        Else
            Return action()
        End If
    End Function

    <Extension()>
    Function InvokeGetObjectEX(ByVal control As Control, ByVal action As Func(Of Object)) As Object
        If control.InvokeRequired Then
            Return control.Invoke(action)
        Else
            Return action()
        End If
    End Function
End Module
