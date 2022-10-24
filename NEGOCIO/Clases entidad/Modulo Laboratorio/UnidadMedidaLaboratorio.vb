Public Class UnidadMedidaLaboratorio

    Private codigo As Long
    Private nombre As String
    Private abreviacion As String

    Public Sub New()

    End Sub

    Public Sub New(_codigo As Long, _nombre As String, _abreviacion As String)
        codigo = _codigo
        nombre = _nombre
        abreviacion = _abreviacion
    End Sub



    'GETTERS Y SETTERS
    Public Function getCodigo() As Long
        Return codigo
    End Function

    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Sub setNombre(_nombre As String)
        nombre = _nombre
    End Sub

    Public Function getAbreviacion() As String
        Return abreviacion
    End Function

    Public Sub setabreviacion(_abreviatura As String)
        abreviacion = _abreviatura
    End Sub


End Class
