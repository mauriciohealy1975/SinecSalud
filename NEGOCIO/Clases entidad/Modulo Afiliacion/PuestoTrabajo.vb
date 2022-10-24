Public Class PuestoTrabajo
    Private codigo As Int16
    Private nombre As String
    Public areaTrabajo As AreaTrabajo

    Public Sub New()
        codigo = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal _codigo As Int16, ByVal _nombre As String, ByRef _area As AreaTrabajo)
        codigo = _codigo
        nombre = _nombre
        areaTrabajo = _area
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
