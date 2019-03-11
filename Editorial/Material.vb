Public MustInherit Class Material
    Private _titulo As String
    Private _montoContrato As Decimal
    Shared _porcentajeEditorPorBorrador As Byte
    Shared _porcentajeEditorPorLibro As Byte
    Private _editor As Editor
    Protected _autores As List(Of Autor)
    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            If value.Length >= 256 Then
                Throw New Exception("El Titulo no debe superar los 256 caracteres!")
            Else
                _titulo = value
            End If
        End Set
    End Property
    Public Property MontoContrato As Decimal
        Get
            Return _montoContrato
        End Get
        Set(value As Decimal)
            _montoContrato = value
        End Set
    End Property
    Shared Property PorcentajeEditorPorBorrador As Byte
        Get
            Return _porcentajeEditorPorBorrador
        End Get
        Set(value As Byte)
            _porcentajeEditorPorBorrador = value
        End Set
    End Property
    Shared Property PorcentajeEditorPorLibro As Byte
        Get
            Return _porcentajeEditorPorLibro
        End Get
        Set(value As Byte)
            _porcentajeEditorPorLibro = value
        End Set
    End Property
    Public Property Editor As Editor
        Get
            Return _editor
        End Get
        Set(value As Editor)
            _editor = value
        End Set
    End Property
    '===== CARDINALIDAD MULTIPLE CON AUTOR: CLASE DEPENDIENTE
    Public Sub addAutor(variable As Autor)
        _autores.Add(variable)
    End Sub
    Public Sub removeAutor(variable As Autor)
        _autores.Remove(variable)
    End Sub
    Public Function getAllAutores() As List(Of Autor)
        Return _autores
    End Function
    Public MustOverride Function GananciaPorcentajePorAutor() As Byte
    Public Function GananciaEditor() As Decimal
        If TypeOf Me Is Borrador Then
            Return MontoContrato * PorcentajeEditorPorBorrador / 100
        Else
            Return MontoContrato * PorcentajeEditorPorLibro / 100
        End If
    End Function

    Sub New(titulo As String, montoContrato As Decimal)
        Me.Titulo = titulo
        Me.MontoContrato = montoContrato
        _autores = New List(Of Autor)
    End Sub
End Class
