Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class ConstructorDeInventarioFarmaco
    Private Id As String
    Private codLiname As String
    Private Submedicamento As Integer
    Private cantidad As Long
    Private precio As Double
    Private almacen As Double
    Private codUsuario As Long
    Private Lote As String
    Private CodBarra As Long
    Private fechaVencimento As String
    Private Estado As Integer
    Private Area As String
    Private CT As Long
    Public Sub New()
        Id = 0
        codLiname = ""
        Submedicamento = 0
        cantidad = 0
        precio = 0.00
        almacen = 1
        codUsuario = 0
        Lote = ""
        CodBarra = 0
        fechaVencimento = ""
        Estado = 0
        Area = ""
        CT = 0
    End Sub

#Region "getters"
    Public Function GetID() As Long
        Return Id
    End Function
    Public Function getcodLiname() As String
        Return codLiname
    End Function
    Public Function getSubmedicamento() As String
        Return Submedicamento
    End Function
    Public Function getcantidad() As String
        Return cantidad
    End Function
    Public Function getprecio() As String
        Return precio
    End Function
    Public Function GetAlmacen() As String
        Return almacen
    End Function
    Public Function getLote() As String
        Return Lote
    End Function
    Public Function getcodUsuario() As String
        Return codUsuario
    End Function
    Public Function getCodBarra() As String
        Return CodBarra
    End Function
    Public Function getfechaVencimento() As String
        Return fechaVencimento
    End Function
    Public Function getEstado() As String
        Return Estado
    End Function
    Public Function getArea() As String
        Return Area
    End Function
    Public Function GetCT() As Long
        Return CT
    End Function

#End Region
#Region "setters"
    Public Sub SetId(ByVal _Id As Long)
        Id = _Id
    End Sub
    Public Sub setcodLiname(ByVal _codLiname As String)
        codLiname = _codLiname
    End Sub
    Public Sub setSubmedicamento(ByVal _submedicamento As String)
        Submedicamento = _submedicamento
    End Sub
    Public Sub setcantidad(ByVal _cantidad As String)
        cantidad = _cantidad
    End Sub
    Public Sub setprecio(ByVal _precio As String)
        precio = _precio
    End Sub
    Public Sub Setalmacen(ByVal _almacen As String)
        almacen = _almacen
    End Sub
    Public Sub setcodUsuario(ByVal _codUsuario As String)
        codUsuario = _codUsuario
    End Sub
    Public Sub setLote(ByVal _Lote As String)
        Lote = _Lote
    End Sub
    Public Sub setCodbarr(ByVal _CodBarra As String)
        CodBarra = _CodBarra
    End Sub
    Public Sub setfechaVencimento(ByVal _fechaVencimento As String)
        fechaVencimento = _fechaVencimento
    End Sub
    Public Sub setEstado(ByVal _Estado As String)
        Estado = _Estado
    End Sub
    Public Sub setArea(ByVal _Area As String)
        Area = _Area
    End Sub
    Public Sub SetCT(ByVal _CT As Long)
        CT = _CT
    End Sub
#End Region

End Class
