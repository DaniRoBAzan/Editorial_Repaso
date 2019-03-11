Public MustInherit Class Material
    Protected _autores As List(Of Autor)
    Private _editor As Editor
    Private _titulo As String
    Private _montoContrato As Decimal
    Shared _porcentajeEditorPorBorrador As Byte
    Shared _porcentajeEditorPorLibro As Byte
    Public Property Editor As Editor
        Get
            Return _editor
        End Get
        Friend Set(value As Editor)
            _editor = value
        End Set
    End Property
    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            If value.Length < 3 Or value.Length > 256 Then
                Throw New Exception("Exception: El titulo no debe superar los 256 caracteres y debe tener mas de 3!")
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
    ''==> CARDINALIDAD 1,3 - M CON AUTOR: CLASE DEPENDIENTE
    Public Sub AddAutor(variable As Autor)
        _autores.Add(variable)
    End Sub
    Public Sub RemoveAutor(variable As Autor)
        _autores.Remove(variable)
    End Sub
    Public Function GetAllAutores() As List(Of Autor)
        Return _autores
    End Function
    Public MustOverride Function GananciaPorcentajePorAutor() As Byte
    Public Function GananciaEditor() As Decimal
        Dim total As Decimal
        If TypeOf Me Is Borrador Then
            total += MontoContrato * PorcentajeEditorPorBorrador / 100
        Else
            total += MontoContrato * PorcentajeEditorPorBorrador / 100
        End If
        Return total
    End Function
    Sub New(titulo As String, montoContrato As Decimal)
        Me.Titulo = titulo
        Me.MontoContrato = montoContrato
        _autores = New List(Of Autor)
    End Sub
End Class
