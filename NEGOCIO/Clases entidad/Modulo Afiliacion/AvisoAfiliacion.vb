Public Class AvisoAfiliacion
    Private codigo As Int64
    Private tipo As Char
    Private nroAviso As Int64
    Private asegurado As Asegurado
    Private empleador As Empresa
    Private anteriorEmpleador As Empresa
    Private fechaContratacion As Date
    Private cargo As Concepto
    Private salario As Decimal
    Private tipoContratacion As Int16
    Private programaproyecto As ProgramaProyecto
    Private entidadDesconcentrada As EntidadDesconcentrada
    Private fechaPresentacion As Date
    Private fechaRecepcion As Date
    Private fechaBaja As Date
    Private motivo As Concepto
    Private inicioCensantia As Date
    Private finCesantaia As Date
    Private reingresoEnCesantia As Int16


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



    Public Sub setNroAviso(ByVal _nroAviso As Int64)
        nroAviso = _nroAviso
    End Sub

    Public Function getNroAviso() As Int64
        Return nroAviso
    End Function



    Public Sub setAsegurado(ByVal _asegurado As Asegurado)
        asegurado = _asegurado
    End Sub

    Public Function getAsegurado() As Asegurado
        Return asegurado
    End Function



    Public Sub setEmpleador(ByRef _empleador As Empresa)
        empleador = _empleador
    End Sub

    Public Function getEmpleador() As Empresa
        Return empleador
    End Function



    Public Sub setAnteriorEmpleador(ByRef _anteriorEmpleador As Empresa)
        anteriorEmpleador = _anteriorEmpleador
    End Sub

    Public Function getAnteriorEmpleador() As Empresa
        Return anteriorEmpleador
    End Function






    Public Sub setFechaContratacion(ByVal _fechaContratacion As Date)
        fechaContratacion = _fechaContratacion
    End Sub

    Public Function getFechaContratacion() As Date
        Return fechaContratacion
    End Function



    Public Sub setCargo(ByRef _cargo As Concepto)
        cargo = _cargo
    End Sub

    Public Function getCargo() As Concepto
        Return cargo
    End Function



    Public Sub setSalario(ByVal _salario As Decimal)
        salario = _salario
    End Sub

    Public Function getSalario() As Decimal
        Return salario
    End Function



    Public Sub setTipoContratacion(ByVal _tipoContratacion As Int16)
        tipoContratacion = _tipoContratacion
    End Sub

    Public Function getTipoContratacion() As Int16
        Return tipoContratacion
    End Function



    Public Sub setProgramaProyecto(ByRef _programaProyecto As ProgramaProyecto)
        programaproyecto = _programaProyecto
    End Sub

    Public Function getProgramaProyecto() As ProgramaProyecto
        Return programaproyecto
    End Function



    Public Sub setEntidadDesconcentrada(ByRef _entidadDesconcentrada As EntidadDesconcentrada)
        entidadDesconcentrada = _entidadDesconcentrada
    End Sub

    Public Function getEntidadDesconcentrada() As EntidadDesconcentrada
        Return entidadDesconcentrada
    End Function



    Public Sub setFechaPresentacion(ByVal _fechaPresentacion As Date)
        fechaPresentacion = _fechaPresentacion
    End Sub

    Public Function getFechaPresentacion() As Date
        Return fechaPresentacion
    End Function



    Public Sub setFechaRecepcion(ByVal _fechaRecepcion As Date)
        fechaRecepcion = _fechaRecepcion
    End Sub

    Public Function getFechaRecepcion() As Date
        Return fechaRecepcion
    End Function



    Public Sub setFechaBaja(ByVal _fechaBaja As Date)
        fechaBaja = _fechaBaja
    End Sub

    Public Function getFechaBaja() As Date
        Return fechaBaja
    End Function



    Public Sub setMotivo(ByRef _motivo As Concepto)
        motivo = _motivo
    End Sub

    Public Function getMotivo() As Concepto
        Return motivo
    End Function



    Public Sub setInicioCesantia(ByVal _inicioCesantia As Date)
        inicioCensantia = _inicioCesantia
    End Sub

    Public Function getInicioCesantia() As Date
        Return inicioCensantia
    End Function



    Public Sub setFinCesantia(ByVal _finCesantia As Date)
        finCesantaia = _finCesantia
    End Sub

    Public Function getFinCesantia() As Date
        Return finCesantaia
    End Function



    Public Sub setReingresoEnCesantia(ByVal _reingresoEnCesantia As Int16)
        reingresoEnCesantia = _reingresoEnCesantia
    End Sub

    Public Function getReingresoEnCesantia() As Int16
        Return reingresoEnCesantia
    End Function


End Class
