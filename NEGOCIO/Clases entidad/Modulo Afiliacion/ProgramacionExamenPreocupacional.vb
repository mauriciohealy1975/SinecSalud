Public Class ProgramacionExamenPreocupacional
    Private codigo As Int64
    Private titular As Titular
    Private empresa As Empresa
    Private fecha As Date
    Private fechaLaboratorio As Date
    Private fechaRayosX As Date
    Private fechaMedicoLaboral As Date
    Private estadoCompletitud As Concepto
    Private fechaCompletitud As Date
    Private nroComprobantePago As String
    Private esDeProvincia As Boolean
    Private tipo As Int16

    Public Sub New()
        titular = New Titular()
        empresa = New Empresa()
    End Sub






    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function



    Public Sub setTitular(ByRef _titular As Titular)
        titular = _titular
    End Sub

    Public Function getTitular() As Titular
        Return titular
    End Function



    Public Sub setEmpresa(ByRef _empresa As Empresa)
        empresa = _empresa
    End Sub

    Public Function getEmpresa() As Empresa
        Return empresa
    End Function



    Public Sub setFecha(ByVal _fecha As Date)
        fecha = _fecha
    End Sub

    Public Function getFecha() As Date
        Return fecha
    End Function



    Public Sub setFechaLaboratio(ByVal _fechaLaboratorio As Date)
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



    Public Sub setEstadoCompletitud(ByVal _estadoCompletitud As Concepto)
        estadoCompletitud = _estadoCompletitud
    End Sub

    Public Function getEstadoCompletidud() As Concepto
        Return estadoCompletitud
    End Function



    Public Sub setFechaCompletitud(ByVal _fechaCompletitud As Date)
        fechaCompletitud = _fechaCompletitud
    End Sub

    Public Function getFechaCompletitud() As Date
        Return fechaCompletitud
    End Function



    Public Sub setNroComprobantePago(ByVal _nroComprobantePago As String)
        nroComprobantePago = _nroComprobantePago
    End Sub

    Public Function getNroComprobantePago() As String
        Return nroComprobantePago
    End Function



    Public Sub setEsDeProvincia(ByVal _esDeProvinicia As Boolean)
        esDeProvincia = _esDeProvinicia
    End Sub

    Public Function getEsDeProvincia() As Boolean
        Return esDeProvincia
    End Function



    Public Sub setTipo(ByVal _tipo As Int16)
        tipo = _tipo
    End Sub

    Public Function getTipo() As Int16
        Return tipo
    End Function


End Class
