Public Class DetalleOrdenAtencion

    Private codigoOrden As Int16
    Private codigoDetalle As Int16
    Private correlativoServicio As Int16
    Private cantidad As String
    Private descripcion As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal _codigoOrden As Int16, ByVal _codigoDetalle As Int16, ByVal _codigoServicio As Int16,
                   ByVal _cantidad As Int16, ByVal _descripcion As String)

        codigoOrden = _codigoOrden
        codigoDetalle = _codigoDetalle
        correlativoServicio = _codigoServicio
        cantidad = _cantidad
        descripcion = _descripcion
    End Sub





    Public Function getCodigoOrden() As Int16
        Return codigoOrden
    End Function

    Public Sub setCodigoOrden(ByVal _codigoOrden As Int16)
        codigoOrden = _codigoOrden
    End Sub

    Public Function getCodigoDetalle() As Int16
        Return codigoDetalle
    End Function

    Public Sub setCodigoDetalle(ByVal _codigoDetalle As Int16)
        codigoDetalle = _codigoDetalle
    End Sub

    Public Function getCorrelativoServicio() As Int16
        Return correlativoServicio
    End Function

    Public Sub setCorrelativoServicio(ByVal _correlativoServicio As Int16)
        correlativoServicio = _correlativoServicio
    End Sub

    Public Function getCantidad() As String
        Return cantidad
    End Function

    Public Sub setCantidad(ByVal _cantidad As String)
        cantidad = _cantidad
    End Sub

    Public Function getDescripcion() As String
        Return descripcion
    End Function

    Public Sub setDescripcion(ByVal _descripcion As String)
        descripcion = _descripcion
    End Sub



End Class
