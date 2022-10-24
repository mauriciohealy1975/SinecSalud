Public Class GrupoValoresOpcionales

    Private codigo As Int16
    Private descripcion As String
    Public listaValoresOpcionales() As ValorOpcional

    Public Sub New()

    End Sub

    Public Sub New(ByVal _codigo As Int16, ByVal _descripcion As String)
        codigo = _codigo
        descripcion = _descripcion
    End Sub

    Public Sub New(ByVal _descripcion As String, ByVal _cantidadElementos As Int16)
        descripcion = _descripcion
        listaValoresOpcionales = New ValorOpcional(_cantidadElementos) {}
    End Sub




    'GETTERS Y SETTERS
    Public Function getDescripcion() As String
        Return descripcion
    End Function

    Public Sub setDescripcion(ByVal _descripcion As String)
        descripcion = _descripcion
    End Sub

    Public Function getCodigo() As Int16
        Return codigo
    End Function

    Public Sub setCodigo(ByVal _codigo As Int16)
        codigo = _codigo
    End Sub



End Class
