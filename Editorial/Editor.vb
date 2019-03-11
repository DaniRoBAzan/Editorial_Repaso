Public Class Editor
    Implements Empleado
    Private _dni As UInteger
    Private _nombre As String
    Private _materiales As List(Of Material)
    Public Property Dni As UInteger Implements Empleado.Dni
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
            If value.Length < 3 Or value.Length > 30 Then
                Throw New Exception("Exception: El nombre no debe superar los 30 caracteres y debe tener mas de 3!")
            Else
                _nombre = value
            End If
        End Set
    End Property
    ''===> cardinalidad con clase materiales: clase responsable
    Public Sub AddMaterial(variable As Material)
        variable.Editor = Me
        _materiales.Add(variable)

    End Sub
    Public Sub RemoveMaterial(variable As Material)
        variable.Editor = Nothing
        _materiales.Remove(variable)
    End Sub
    Public Function GetAllMateriales() As List(Of Material)
        Return _materiales
    End Function
    Public Function CalcularGanancia() As Decimal Implements Empleado.CalcularGanancia
        Dim total As Decimal
        For Each material In _materiales
            total += material.GananciaEditor() + material.MontoContrato * 0.5
        Next
        Return total
    End Function
    Public Overrides Function ToString() As String
        Return Nombre & " - " & Dni
    End Function
    Sub New(dni As UInteger, nombre As String)
        Me.Dni = dni
        Me.Nombre = nombre
        _materiales = New List(Of Material)
    End Sub
End Class
