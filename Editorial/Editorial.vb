Public Class Editorial
    Shared _materiales As New List(Of Material)
    Shared Sub AddMaterial(variable As Material)
        _materiales.Add(variable)
    End Sub
    Shared Sub RemoveMaterial(variable As Material)
        _materiales.Remove(variable)
    End Sub
    Shared Function GetAllMateriales() As List(Of Material)
        Return _materiales
    End Function
    Shared Function GetAllMateriales(variable As Autor) As List(Of Material)
        Dim _enviarlista As New List(Of Material)
        For Each material In _materiales
            If material.GetAllAutores().Contains(variable) Then
                If Not _enviarlista.Contains(material) Then
                    _enviarlista.Add(material)
                End If
            End If
        Next
        Return _enviarlista
    End Function
    Shared Function GetAutor(variable As UInteger) As Autor
        For Each material In _materiales
            If material.GetAllAutores.Exists(Function(a) a.Dni = variable) Then
                Return material.GetAllAutores.Find(Function(a) a.Dni = variable)
            End If
        Next
        Throw New Exception("Exception: Dni " & variable & " no pertenece a ningún autor")
    End Function
    Shared Function GetAllEmpleados() As List(Of Empleado)
        Dim _enviarLista As New List(Of Empleado)
        For Each material In _materiales
            For Each autor In material.GetAllAutores()
                If Not _enviarLista.Contains(autor) Then
                    _enviarLista.Add(autor)
                End If
            Next
            If Not _enviarLista.Contains(material.Editor) Then
                _enviarLista.Add(material.Editor)
            End If
        Next
        Return _enviarLista
    End Function
End Class
