Public NotInheritable Class Autor
    Implements Empleado
    Private _materiales As List(Of Material)
    Private _dni As UInteger
    Private _nombre As String

    Public Property DNI As UInteger Implements Empleado.DNI
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property

    Public Property Nombre As String Implements Empleado.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length <= 3 Then
                Throw New Exception("El  nombre  debe superar los 3 caracteres!")
            Else
                _nombre = value
            End If
        End Set
    End Property
    ''==============> CARDINALIDAD CON MATERIALES: CLASE RESPONSABLE
    Public Sub addMaterial(variable As Material)
        If variable.getAllAutores().Count() >= 3 Then
            Throw New Exception("Solo se pueden agregar 3 autores!")
        Else
            variable.addAutor(Me)
            _materiales.Add(variable)
        End If
    End Sub
    Public Sub removeMaterial(variable As Material)
        variable.removeAutor(Me)
        _materiales.Remove(variable)
    End Sub
    Public Function getAllMateriales() As List(Of Material)
        Return _materiales
    End Function
    Public Function CalcularGanancia() As Decimal Implements Empleado.CalcularGanancia
        Dim total As Decimal
        ''sumatoria ganancias por venta de libros
        For Each material In _materiales
            total += material.MontoContrato * material.GananciaPorcentajePorAutor / 100
        Next
        Return total
    End Function
    Public Overrides Function ToString() As String
        Return Nombre & " - " & DNI
    End Function
    Sub New(dni As UInteger, nombre As String)
        Me.DNI = dni
        Me.Nombre = nombre
        _materiales = New List(Of Material)
    End Sub
End Class
