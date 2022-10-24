Public Class ProveedorKitEquipo
    Private codigo As Long
    Private nombre As String

    Public Sub New()
        codigo = 0
        nombre = ""
    End Sub

    Public Sub New(_codigo As Long, ByVal _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub




    Public Function getCodigo() As Long
        Return codigo
    End Function

    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Sub setNombre(ByVal _nombre As String)
        nombre = _nombre
    End Sub

End Class


Public Class ProveedorKitEquipoInput
    Public Property codigo As String
    Public Property nombre As String

    Public Sub New()
        codigo = "0"
        nombre = ""
    End Sub

End Class
