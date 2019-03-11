Public Class Borrador
    Inherits Material

    Public Overrides Function GananciaPorcentajePorAutor() As Byte
        Return 100 - PorcentajeEditorPorBorrador / _autores.Count()
    End Function
    Public Overrides Function ToString() As String
        Return Editor.Nombre & " - " & Editor.Dni
    End Function
    Sub New(titulo As String, montoContrato As Decimal)
        MyBase.New(titulo, montoContrato)
    End Sub
End Class
