Public Class ConstructorProveedor
    Private Nombre As String
    Private Estado As Long
    Private CoUsuario As Long
    Public Sub New()
        Nombre = ""
        Estado = 0
        CoUsuario = 0

    End Sub
#Region "Get"
    Public Function GetNombre() As String
        Return Nombre
    End Function
    Public Function GetEstardo() As Long
        Return Estado
    End Function
    Public Function GetCoUsuario() As Long
        Return CoUsuario
    End Function
#End Region
#Region "set"
    Public Sub SetNombre(ByVal _Nombre As String)
        Nombre = _Nombre
    End Sub
    Public Sub SetEstado(ByVal _Estado As Long)
        Estado = _Estado
    End Sub
    Public Sub SetCoUsuaio(ByVal _CoUsuario As Long)
        CoUsuario = _CoUsuario
    End Sub
#End Region
End Class
