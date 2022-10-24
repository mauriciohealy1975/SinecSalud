Public Class ConjuntoOpcionesResultadosLaboratorio

    Private codigo As Long
    Private nombre As String


    Public Sub New()

    End Sub

    Public Sub New(_codigo As Long, _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub


    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Long
        Return codigo
    End Function

    Public Sub setNombre(_nombre As String)
        nombre = _nombre
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function




End Class
