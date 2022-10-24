Public Class DatosPersonales
    Private codigo As Int64

    Public Sub New()

    End Sub

    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function

End Class


