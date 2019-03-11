Public Class Libro
    Inherits Material
    Private _isbn As String
    Public Property ISBN As String
        Get
            Return _isbn
        End Get
        Set(value As String)
            If value.Length < 3 Or value.Length >= 20 Then
                Throw New ArgumentException("El ISBN debe ser mayor a 3 y menor a 20 Caracteres!")
            Else
                _isbn = value
            End If
        End Set
    End Property
    Public Overrides Function GananciaPorcentajePorAutor() As Byte
        Return (100 - PorcentajeEditorPorLibro) / getAllAutores.Count
    End Function
    Public Overrides Function ToString() As String
        Dim cadena As String = Titulo
        For Each autor In getAllAutores()
            cadena += autor.Nombre & ", "
        Next
        Return cadena.Substring(0, cadena.Length - 2) & "(" & ISBN & ")"
    End Function
    Sub New(isbn As String, titulo As String, montoContrato As Decimal)
        MyBase.New(titulo, montoContrato)
        Me.ISBN = isbn
        _autores = New List(Of Autor)
    End Sub
End Class
