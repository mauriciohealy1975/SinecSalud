Public Class AreaTrabajo
    Private codigo As Int16
    Private nombre As String

    Public Sub New()
        codigo = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal _codigo As Int16, ByVal _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub

    Public Function getCodigo() As Int16
        Return codigo
    End Function

    Public Sub setCodigo(ByVal _codigo As Int16)
        codigo = _codigo
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Sub setNombre(ByVal _nombre As String)
        nombre = _nombre
    End Sub





End Class
