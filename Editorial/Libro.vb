Public Class Libro
    Inherits Material
    Private _isbn As String
    Public Property ISBN As String
        Get
            Return _isbn
        End Get
        Set(value As String)
            If value.Length < 3 Or value.Length > 20 Then
                Throw New Exception("Exception: El nombre no debe superar los 20 caracteres y debe tener mas de 3!")
            Else
                _isbn = value
            End If
        End Set
    End Property
    Public Overrides Function GananciaPorcentajePorAutor() As Byte
        Return 100 - PorcentajeEditorPorLibro / _autores.Count()
    End Function
    Public Overrides Function ToString() As String
        Dim cadena As String = ""
        cadena += Titulo & " - " & ISBN
        For Each autor In _autores
            cadena += autor.Nombre
        Next
        Return cadena
    End Function
    Sub New(isbn As String, titulo As String, montoContrato As Decimal)
        MyBase.New(titulo, montoContrato)
        Me.ISBN = isbn
    End Sub
End Class
