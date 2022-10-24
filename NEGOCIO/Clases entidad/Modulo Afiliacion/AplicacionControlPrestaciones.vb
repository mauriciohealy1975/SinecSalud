Public Class AplicacionControlPrestaciones
    Private codigo As Int64
    Private tipo As Char
    Private controlPrestaciones As ControlPrestaciones
    Private codigoReceptor As Int64
    Private titular As Titular
    Private beneficiario As Beneficiario
    Private empresa As Empresa
    Private relacion As Int16
    Private fecha As Date
    Private vigencia As Int16
    Private fechaLimiteAtencion As Date
    Public Sub New()

    End Sub


    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function



    Public Sub setTipo(ByVal _tipo As Char)
        tipo = _tipo
    End Sub

    Public Function getTipo() As Char
        Return tipo
    End Function



    Public Sub setControlPrestaciones(ByRef _controlPrestaciones As ControlPrestaciones)
        controlPrestaciones = _controlPrestaciones
    End Sub

    Public Function getControlPrestaciones() As ControlPrestaciones
        Return controlPrestaciones
    End Function


    Public Sub setCodigoReceptor(ByVal _codigoReceptor As Int64)
        codigoReceptor = _codigoReceptor
    End Sub

    Public Function getCodigoReceptor() As Int64
        Return codigoReceptor
    End Function


    Public Sub setFecha(ByVal _fecha As Date)
        fecha = _fecha
    End Sub

    Public Function getFecha() As Date
        Return fecha
    End Function



    Public Sub setVigencia(ByVal _vigencia As Int16)
        vigencia = _vigencia
    End Sub

    Public Function getVigencia() As Int16
        Return vigencia
    End Function



    Public Sub setFechaLimiteAtencion(ByVal _fechaLimiteAtencion As Date)
        fechaLimiteAtencion = _fechaLimiteAtencion
    End Sub

    Public Function getFechaLimiteAtencion() As Date
        Return fechaLimiteAtencion
    End Function



    Public Sub setTitular(ByRef _titular As Titular)
        titular = _titular
    End Sub

    Public Function getTitular() As Titular
        Return titular
    End Function



    Public Sub setBeneficiario(ByRef _beneficiario As Beneficiario)
        beneficiario = _beneficiario
    End Sub

    Public Function getBeneficiario() As Beneficiario
        Return beneficiario
    End Function



    Public Sub setEmpresa(ByRef _empresa)
        empresa = _empresa
    End Sub

    Public Function getEmpresa() As Empresa
        Return empresa
    End Function




End Class
