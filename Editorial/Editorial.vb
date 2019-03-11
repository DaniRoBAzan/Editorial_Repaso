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
        Dim listanueva As New List(Of Material)
        For Each material In _materiales
            'si el material contiene al autor recibido lo agregamos a la listanueva
            If material.getAllAutores.Contains(variable) Then
                listanueva.Add(material)
            End If
        Next
        Return listanueva
    End Function
    Shared Function GetAutor(dni As UInteger) As Autor
        For Each material In _materiales
            ''traemos todos los autores de cada material y si existe dentro de el el DNI recibido
            If material.getAllAutores.Exists(Function(a) a.DNI = dni) Then
                ''devolvemos ese material con la funcion de encontrar por dni.
                Return material.getAllAutores.Find(Function(a) a.DNI = dni)
            End If
        Next
        Throw New Exception("El Dni " & dni & " no pertenece a ningún autor!")
    End Function
    Shared Function GetAllEmpleados() As List(Of Empleado)
        Dim _listaEmpleados As New List(Of Empleado)
        For Each material In _materiales
            ''por cada material traigo todos los autores 
            For Each empleado In material.getAllAutores()
                '' si el empleado no esta en la lista lo agrego
                If Not _listaEmpleados.Contains(empleado) Then
                    _listaEmpleados.Add(empleado)
                End If
            Next
            ''si el editor no esta en la lista tambien lo agrego
            If Not _listaEmpleados.Contains(material.Editor) Then
                _listaEmpleados.Add(material.Editor)
            End If
        Next
        Return _listaEmpleados
    End Function
    Sub New()
        _materiales = New List(Of Material)
    End Sub
End Class
