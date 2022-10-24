Public Class ReprogramacionExamenPreocupacional
    Private codigo As Int64
    Private codigoProgramacion As Int64
    Private titular As Titular
    Private fecha As Date
    Private reprogramacionLaboratorio As Int16
    Private reprogramacionRayosX As Int16
    Private reprogramacionMedicoLaboral As Int16
    Private fechaLaboratorio As Date
    Private fechaRayosX As Date
    Private fechaMedicoLaboral As Date

    Public Sub New()

    End Sub



    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function



    Public Sub setCodigoProgramacion(ByVal _codigoProgramacion As Int64)
        codigoProgramacion = _codigoProgramacion
    End Sub

    Public Function getCodigoProgramacion() As Int64
        Return codigoProgramacion
    End Function



    Public Sub setTitular(ByRef _titular As Titular)
        titular = _titular
    End Sub

    Public Function getTitular() As Titular
        Return titular
    End Function



    Public Sub setFecha(ByVal _fecha As Date)
        fecha = _fecha
    End Sub

    Public Function getFecha() As Date
        Return fecha
    End Function



    Public Sub setReprogramacionLaboratorio(ByVal _reprogramacionLaboratorio As Int16)
        reprogramacionLaboratorio = _reprogramacionLaboratorio
    End Sub

    Public Function getReprogramacionLaboratorio() As Int16
        Return reprogramacionLaboratorio
    End Function



    Public Sub setReprogramacionRayosX(ByVal _reprogramacionRayosX As Int16)
        reprogramacionRayosX = _reprogramacionRayosX
    End Sub

    Public Function getReprogramacionRayosX() As Int16
        Return reprogramacionRayosX
    End Function



    Public Sub setReprogramacionMedicoLaboral(ByVal _reprogrmacionMedicoLaboral As Int16)
        reprogramacionMedicoLaboral = _reprogrmacionMedicoLaboral
    End Sub

    Public Function getReprogramacionMedicoLaboral() As Int16
        Return reprogramacionMedicoLaboral
    End Function



    Public Sub setFechaLaboratorio(ByVal _fechaLaboratorio As Date)
        fechaLaboratorio = _fechaLaboratorio
    End Sub

    Public Function getFechaLaboratorio() As Date
        Return fechaLaboratorio
    End Function



    Public Sub setFechaRayosX(ByVal _fechaRayosX As Date)
        fechaRayosX = _fechaRayosX
    End Sub

    Public Function getFechaRayosX() As Date
        Return fechaRayosX
    End Function



    Public Sub setFechaMedicoLaboral(ByVal _fechaMedicoLaboral As Date)
        fechaMedicoLaboral = _fechaMedicoLaboral
    End Sub

    Public Function getFechaMedicoLaboral() As Date
        Return fechaMedicoLaboral
    End Function


End Class
