Namespace Net.SuspiciusImports

    Public Class Database

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' A sourcecode template of a WindowsForms application written in Visual Basic.Net.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Public Shared ReadOnly MaliciousImportsDB As String =
            <a><![CDATA[System.Security|
System.Reflection|
System.Diagnostics|
System.Management|
System.CodeDom|
dnlib|
confusedbyattribute|
microsoft.csharp|
Cryptography]]></a>.Value

        Public Shared ReadOnly MaliciousImportsStr As String =
           <a><![CDATA[Liz|
Guard|
dump]]></a>.Value

        Public Shared Function GetData() As String
            Return MaliciousImportsDB
        End Function

        Public Shared Function GetDat() As String
            Return MaliciousImportsStr
        End Function

        Public Shared Function Test() As String
            Return "Hello Sir"
        End Function

    End Class

End Namespace