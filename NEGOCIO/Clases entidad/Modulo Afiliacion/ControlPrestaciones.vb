Public Class ControlPrestaciones
    Private codigo As Int64
    Private nombre As String
    Private codigoGrupo As Int64

    Public Sub New()
    End Sub

    Public Sub New(ByVal _codigo As Int64, _nombre As String, ByVal _codigoGrupo As Int64)
        codigo = _codigo
        nombre = _nombre
        codigoGrupo = _codigoGrupo
    End Sub







    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function



    Public Sub setNombre(ByVal _nombre As String)
        nombre = _nombre
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function



    Public Sub setCodigoGrupo(ByVal _codigoGrupo As Int64)
        codigoGrupo = _codigoGrupo
    End Sub

    Public Function getCodigoGrupo() As Int64
        Return codigoGrupo
    End Function


End Class
