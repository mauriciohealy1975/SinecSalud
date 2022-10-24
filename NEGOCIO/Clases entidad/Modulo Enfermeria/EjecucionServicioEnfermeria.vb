Public Class EjecucionServicioEnfermeria
    Private descripcion As String
    Private fecha As String
    Private nroCesion As Int16
    Private nroOrden As Int16
    Private nroDetalle As Int16


    Public Sub New(ByVal _descripcion As String, ByVal _fecha As String, ByVal _nroCesion As Int16)
        descripcion = _descripcion
        fecha = _fecha
        nroCesion = _nroCesion
    End Sub

    Public Sub New()

    End Sub




    'GETTERS Y SETTERS
    Public Function getDescripcion() As String
        Return descripcion
    End Function

    Public Sub setDescripcion(ByVal _descripcion As String)
        descripcion = _descripcion
    End Sub

    Public Function getFecha() As String
        Return fecha
    End Function

    Public Sub setFecha(ByVal _fecha)
        fecha = _fecha
    End Sub

    Public Function getNroCesion() As Int16
        Return nroCesion
    End Function

    Public Sub setNroCesion(ByVal _nroCesion As Int16)
        nroCesion = _nroCesion
    End Sub

    Public Function getNroOrden() As Int16
        Return nroOrden
    End Function

    Public Sub setNroOrden(ByVal _nroOrden As Int16)
        nroOrden = _nroOrden
    End Sub

    Public Function getNroDetalle() As Int16
        Return nroDetalle
    End Function

    Public Sub setNroDetalle(ByVal _nroDetalle As Int16)
        nroDetalle = _nroDetalle
    End Sub



End Class



