Public Class Editor
    Implements Empleado
    Private _dni As UInteger
    Private _nombre As String
    Private _materiales As List(Of Material)
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
    ''==== CARDINALIDAD BIDIRECCIONAL CON MATERIAL: CLASE RESPONSABLE
    Public Sub addMaterial(variable As Material)
        variable.Editor = Me
        _materiales.Add(variable)
    End Sub
    Public Sub removeMaterial(variable As Material)
        variable.Editor = Nothing
        _materiales.Remove(variable)
    End Sub
    Public Function getAllMateriales() As List(Of Material)
        Return _materiales
    End Function
    Public Function CalcularGanancia() As Decimal Implements Empleado.CalcularGanancia
        'sueldo + 5% de los libros donde este sea el editor.
        Throw New NotImplementedException()
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
