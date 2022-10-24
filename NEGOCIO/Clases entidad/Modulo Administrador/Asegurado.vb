Public Class Asegurado

    Protected codigo As Int64
    Protected oDatosPersonales As DatosPersonales

    Protected apellidoPaterno As String
    Protected apellidoMaterno As String
    Protected nombres As String
    Protected nombreCompleto As String
    Protected matricula As String
    Protected fechaAfiliacion As Date

    Protected oNacionalidad As Concepto
    Protected oLugarNacimiento As Concepto
    Protected fechaNacimiento As Date
    Protected oTipoSangre As Concepto
    Protected sexo As Char
    Protected oEstadoCivil As Concepto
    Protected localidad As String
    Protected zona As String
    Protected avenida As String
    Protected calle As String
    Protected nroCasa As String


    Protected oTipoDocumento As Concepto
    Protected nroDocumento As String
    Protected complemento As String
    Protected oLugarExpedicion As Concepto


    Protected oTipoAsegurado As Concepto
    Protected empresa As Empresa
    Protected programaproyecto As ProgramaProyecto

    Protected fechaContratacion As String
    Protected oCargo As Concepto
    Protected salario As Decimal
    Protected tipoContratacion As Int16


    Protected telefono As String
    Protected telefonoReferencia As String
    Protected direccionDomicilio As String
    Protected oDepartamentoResidencia As Concepto
    Protected oProvinciaResidencia As Concepto


    Protected telefonoLaboral As String
    Protected direccionLaboral As String
    Protected oDepartamentoLaboral As Concepto
    Protected oProvinciaLaboral As Concepto
    Protected localidadLaboral As String

    Protected tipo As String
    Protected edad As Int16
    Protected descripcion As String





    'CONSTRUCTOR
    Sub New()

    End Sub

    Sub New(ByVal _nombre As String, ByVal _matricula As String)
        nombres = _nombre
        matricula = _matricula
    End Sub

    Sub New(ByVal _nombre As String, ByVal _matricula As String, ByVal _tipo As String)
        nombres = _nombre
        matricula = _matricula
        tipo = _tipo
    End Sub




    'getts y setters 
    Public Sub setDatosPersonales(ByRef _oDatosPersonales As DatosPersonales)
        oDatosPersonales = _oDatosPersonales
    End Sub

    Public Function getDatosPersonales() As DatosPersonales
        Return oDatosPersonales
    End Function


    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function


    Public Sub setTipoDocumento(ByRef _oTipoDocumento As Concepto)
        oTipoDocumento = _oTipoDocumento
    End Sub

    Public Function getTipoDocumento() As Concepto
        Return oTipoDocumento
    End Function



    Public Function getNroDocumento() As String
        Return nroDocumento
    End Function

    Public Sub setNroDocumento(ByVal _nroDocumento As String)
        nroDocumento = _nroDocumento
    End Sub



    Public Sub setComplemento(ByVal _complemento)
        complemento = _complemento
    End Sub

    Public Function getComplemento() As String
        Return complemento
    End Function



    Public Sub setLugarExpedicion(ByRef _oLugarExpedicion As Concepto)
        oLugarExpedicion = _oLugarExpedicion
    End Sub

    Public Function getLugarExpedicion() As Concepto
        Return oLugarExpedicion
    End Function



    Public Sub setApellidoPaterno(ByVal _apellidoPaterno As String)
        apellidoPaterno = _apellidoPaterno
    End Sub

    Public Function getApellidoPaterno() As String
        Return apellidoPaterno
    End Function



    Public Sub setFechaAfiliacion(ByVal _fechaAfiliacion As Date)
        fechaAfiliacion = _fechaAfiliacion
    End Sub

    Public Function getFechaAfiliacion() As Date
        Return fechaAfiliacion
    End Function


    Public Sub setNombreCompleto(_nombreCompleto As String)
        nombreCompleto = _nombreCompleto
    End Sub

    Public Function getNombreCompleto() As String
        Return nombreCompleto
    End Function

    Public Sub setNacionalidad(ByRef _oNacionalidad As Concepto)
        oNacionalidad = _oNacionalidad
    End Sub

    Public Function getNacionalidad() As Concepto
        Return oNacionalidad
    End Function



    Public Sub setSexo(ByVal _sexo As Char)
        sexo = _sexo
    End Sub

    Public Function getSexo() As Char
        Return sexo
    End Function



    Public Sub setEstadoCivil(ByRef _oEstadoCivil As Concepto)
        oEstadoCivil = _oEstadoCivil
    End Sub

    Public Function getEstadoCivil() As Concepto
        Return oEstadoCivil
    End Function



    Public Sub setZona(ByVal _zona As String)
        zona = _zona
    End Sub

    Public Function getZona() As String
        Return zona
    End Function



    Public Sub setAvenida(ByVal _avenida As String)
        avenida = _avenida
    End Sub

    Public Function getAvenida() As String
        Return avenida
    End Function



    Public Sub setCalle(ByVal _calle As String)
        calle = _calle
    End Sub

    Public Function getCalle() As String
        Return calle
    End Function



    Public Sub setNroCasa(ByVal _nroCasa As String)
        nroCasa = _nroCasa
    End Sub

    Public Function getNroCasa() As String
        Return nroCasa
    End Function



    Public Sub setLugarNacimiento(ByVal _oLugarNacimiento As Concepto)
        oLugarNacimiento = _oLugarNacimiento
    End Sub

    Public Function getLugarNacimiento() As Concepto
        Return oLugarNacimiento
    End Function



    Public Sub setApellidoMaterno(ByVal _apellidoMaterno As String)
        apellidoMaterno = _apellidoMaterno
    End Sub

    Public Function getApellidoMaterno() As String
        Return apellidoMaterno
    End Function



    Public Function getNombres() As String
        Return nombres
    End Function

    Public Sub setNombres(ByVal _nombres As String)
        nombres = _nombres
    End Sub



    Public Sub setTipoSangre(ByRef _oTipoSangre As Concepto)
        oTipoSangre = _oTipoSangre
    End Sub

    Public Function getTipoSangre() As Concepto
        Return oTipoSangre
    End Function



    Public Sub setFechaNacimiento(ByVal _fechaNacimiento As Date)
        fechaNacimiento = _fechaNacimiento.Date
    End Sub

    Public Function getFechaNacimiento() As Date
        Return fechaNacimiento
    End Function







    Public Sub setMatricula(ByVal _matricula)
        matricula = _matricula
    End Sub

    Public Function getMatricula() As String
        Return matricula
    End Function



    Public Sub setTipoAsegurado(ByRef _oTipoAsegurado As Concepto)
        oTipoAsegurado = _oTipoAsegurado
    End Sub

    Public Function getTipoAsegurado() As Concepto
        Return oTipoAsegurado
    End Function



    Public Sub setEmpresa(ByRef _empresa As Empresa)
        empresa = _empresa
    End Sub

    Public Function getEmpesa() As Empresa
        Return empresa
    End Function



    Public Sub setProgramaProyecto(ByRef _programaProyecto As ProgramaProyecto)
        programaproyecto = _programaProyecto
    End Sub

    Public Function getProgramaProyecto() As ProgramaProyecto
        Return programaproyecto
    End Function



    Public Sub setFechaContratacion(ByVal _fechaContratacion As String)
        fechaContratacion = _fechaContratacion
    End Sub

    Public Function getFechaContratacion() As String
        Return fechaContratacion
    End Function



    Public Sub setCargo(ByRef _oCargo As Concepto)
        oCargo = _oCargo
    End Sub

    Public Function getCargo() As Concepto
        Return oCargo
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



    Public Sub setTelefono(ByVal _telefono As String)
        telefono = _telefono
    End Sub

    Public Function getTelefono() As String
        Return telefono
    End Function



    Public Function getTelefonoReferencia() As String
        Return telefonoReferencia
    End Function

    Public Sub setTelefonoReferencia(ByVal _telfReferencia)
        telefonoReferencia = _telfReferencia
    End Sub



    Public Sub setDireccionDomicilio(ByVal _direccionDomicilio)
        direccionDomicilio = _direccionDomicilio
    End Sub

    Public Function getDireccionDomicilio() As String
        Return direccionDomicilio
    End Function



    Public Sub setDepartamentoResidencia(ByRef _oDepartamento As Concepto)
        oDepartamentoResidencia = _oDepartamento
    End Sub

    Public Function getDepartamentoResidencia() As Concepto
        Return oDepartamentoResidencia
    End Function



    Public Sub setProvinciaResidencia(ByRef _oProvincia As Concepto)
        oProvinciaResidencia = _oProvincia
    End Sub

    Public Function getProvinciaResidencia() As Concepto
        Return oProvinciaResidencia
    End Function



    Public Sub setLocalidad(ByVal _localidad As String)
        localidad = _localidad
    End Sub

    Public Function getLocalidad() As String
        Return localidad
    End Function



    Public Sub setTelefonoLaboral(ByVal _telfLaboral)
        telefonoLaboral = _telfLaboral
    End Sub

    Public Function getTelefonoLaboral() As String
        Return telefonoLaboral
    End Function



    Public Sub setDireccionLaboral(ByVal _direccionLaboral As String)
        direccionLaboral = _direccionLaboral
    End Sub

    Public Function getDireccionLaboral() As String
        Return direccionLaboral
    End Function



    Public Sub setDepartamentoLaboral(ByRef _oDepartamentoLaboral As Concepto)
        oDepartamentoLaboral = _oDepartamentoLaboral
    End Sub

    Public Function getDepartamentoLaboral() As Concepto
        Return oDepartamentoLaboral
    End Function



    Public Sub setProvinciaLaboral(ByRef _oProvinciaLaboral)
        oProvinciaLaboral = _oProvinciaLaboral
    End Sub

    Public Function getProvinciaLaboral() As Concepto
        Return oProvinciaLaboral
    End Function



    Public Sub setLocalidadLaboral(ByVal _localidadLaboral As String)
        localidadLaboral = _localidadLaboral
    End Sub

    Public Function getLocalidadLaboral() As String
        Return localidadLaboral
    End Function



    Public Sub generarDescripcion()
        descripcion = nombres + " | " + matricula
    End Sub

    Public Function getDescripcion() As String
        Return descripcion
    End Function

    Public Sub setDescripcion(ByVal _descripcion As String)
        descripcion = _descripcion
    End Sub





    Public Function getEdad() As Int16
        Return edad
    End Function

    Public Sub setEdad(ByVal _edad As Int16)
        edad = _edad
    End Sub




End Class
