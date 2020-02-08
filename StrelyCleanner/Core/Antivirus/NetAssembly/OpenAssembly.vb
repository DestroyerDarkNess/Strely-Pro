Imports Mono.Cecil
Imports System.Reflection


Public Class OpenAssembly

    Public Shared Function GetNameModules(ByVal DirX As String) As String
        On Error Resume Next
        Dim allTypesDefinitaion = Mono.Cecil.ModuleDefinition.ReadModule(DirX).Types
        Dim Cantidad As Integer = allTypesDefinitaion.Count
        Dim lista As String = String.Empty
        For value As Integer = 1 To Cantidad
            Dim Item As String = allTypesDefinitaion(value).ToString
            If lista = String.Empty Then
                lista = Item
            Else
                lista = lista & vbNewLine & Item
            End If
        Next
        Return LCase(lista)
    End Function

    Public Shared Function GetImports(ByVal DirX As String) As String
        On Error Resume Next
        Dim allTypesDefinitaion = ModuleDefinition.ReadModule(DirX).AssemblyReferences
        Dim Cantidad As Integer = allTypesDefinitaion.Count
        Dim lista As String = String.Empty
        For value As Integer = 1 To Cantidad
            Dim ArrCadena As String = allTypesDefinitaion(value).ToString
            Dim Item As String() = ArrCadena.Split(",")
            If lista = String.Empty Then
                lista = Item(0) & "|"
            Else
                lista = lista & vbNewLine & Item(0) & "|"
            End If
        Next
        Return LCase(lista)
    End Function



    'Dim mscorlib As Assembly = GetType(String).Assembly

    ' Dim assembly As Assembly = Assembly.LoadFrom(DirX)
    '       For Each type As Type In assembly.GetTypes()

    '          LogInListBox1.AddItem(type.FullName)
    '       Next

    Private Function GetDependentAssemblies(ByVal analyzedAssembly As Assembly) As IEnumerable(Of Assembly)
        Return AppDomain.CurrentDomain.GetAssemblies().Where(Function(a) GetNamesOfAssembliesReferencedBy(a).Contains(analyzedAssembly.FullName))
    End Function

    Public Function GetNamesOfAssembliesReferencedBy(ByVal assembly As Assembly) As IEnumerable(Of String)
        Return assembly.GetReferencedAssemblies().[Select](Function(assemblyName) assemblyName.FullName)
    End Function

End Class
