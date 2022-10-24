Public Class ConstructorDeSubProducto

    Private codLiname As String
    Private Nombre As String
    Private Tipo As Long
    Private CodProveedor As Long
    Private CodUsuario As Long
    Public Sub New()
        codLiname = ""
        Nombre = ""
        Tipo = 0
        CodProveedor = 0
        CodUsuario = 0
    End Sub
#Region "Get"
    Public Function getcodLiname() As String
        Return codLiname
    End Function
    Public Function GetNombre() As String
        Return Nombre
    End Function
    Public Function GetTipo() As Long
        Return Tipo
    End Function
    Public Function GetCodProveedor() As Long
        Return CodProveedor
    End Function
    Public Function GetCodUsuario() As Long
        Return CodUsuario
    End Function
#End Region
#Region "Set"
    Public Sub setcodLiname(ByVal _codLiname As String)
        codLiname = _codLiname
    End Sub
    Public Sub SetNombre(ByVal _Nombre As String)
        Nombre = _Nombre
    End Sub
    Public Sub SetTipo(ByVal _tipo As Long)
        Tipo = _tipo
    End Sub
    Public Sub SetCodProveedor(ByVal _CodProveedor As Long)
        CodProveedor = _CodProveedor
    End Sub
    Public Sub SetCodUsuario(ByVal _CodUsuario As Long)
        CodUsuario = _CodUsuario
    End Sub
#End Region


End Class
