Public Class ActualizacionAsegurado

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public listaTipoDoc As Concepto()
    Public listaDepartamentos As Concepto()
    Public listaProvincias As Concepto()
    Public listaTipoAsegurado As Concepto()
    Public listaTiposDeSangre As Concepto()
    Public listaAsegurados As Asegurado()

    Public oAsegurado As Asegurado
    Public oEmpresa As Empresa


    'METOD. TRAER DATOS CONTROLES
    Public Sub traerTipoDeDoc()
        Dim objDTable As DataTable
        Dim index As Int16
        Dim objTipoDocumento As Concepto

        objDTable = traerTipoDocBD()
        listaTipoDoc = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = 0
            Dim correlativo As Int16 = 0
            Dim descripcion As String = ""

            prefijo = Integer.Parse(row("PREF"))
            correlativo = Integer.Parse(row("CORR"))
            descripcion = row("DESC").ToString()
            objTipoDocumento = New Concepto(prefijo, correlativo, descripcion)

            listaTipoDoc(index) = objTipoDocumento
            index += 1
        Next
    End Sub

    Public Sub traerTipoAsegurado()
        Dim objDTable As DataTable
        Dim index As Int16
        Dim obTipoAsegurado As Concepto

        objDTable = traerTipoAsegBD()
        listaTipoAsegurado = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = 0
            Dim correlativo As Int16 = 0
            Dim descripcion As String = ""

            prefijo = Integer.Parse(row("prefijo"))
            correlativo = Integer.Parse(row("correlativo"))
            descripcion = row("descripcion").ToString()
            obTipoAsegurado = New Concepto(prefijo, correlativo, descripcion)

            listaTipoAsegurado(index) = obTipoAsegurado
            index += 1
        Next
    End Sub

    Public Sub traerDepartamentos()
        Dim objDTable As DataTable
        Dim index As Int16
        Dim objDepartamento As Concepto

        objDTable = traerDepartamentosBD()
        listaDepartamentos = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = 0
            Dim correlativo As Int16 = 0
            Dim descripcion As String = ""

            prefijo = Integer.Parse(row("prefijo"))
            correlativo = Integer.Parse(row("correlativo"))
            descripcion = row("descripcion").ToString()
            objDepartamento = New Concepto(prefijo, correlativo, descripcion)

            listaDepartamentos(index) = objDepartamento
            index += 1
        Next
    End Sub

    Public Sub traerProvincias(ByVal _departamento As String)
        Dim objDTable As DataTable
        Dim index As Int16
        Dim obProvincia As Concepto

        objDTable = traerProvinciasBD(_departamento)
        listaProvincias = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = 0
            Dim correlativo As Int16 = 0
            Dim descripcion As String = ""

            prefijo = Integer.Parse(row("prefijo"))
            correlativo = Integer.Parse(row("correlativo"))
            descripcion = row("descripcion").ToString()
            obProvincia = New Concepto(prefijo, correlativo, descripcion)

            listaProvincias(index) = obProvincia
            index += 1
        Next
    End Sub

    Public Sub traerTiposDeSangre()
        Dim objDTable As DataTable
        Dim index As Int16
        Dim objTipoDeSangre As Concepto

        objDTable = traerTipoSangreBD()
        listaTiposDeSangre = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = 0
            Dim correlativo As Int16 = 0
            Dim descripcion As String = ""

            prefijo = Integer.Parse(row("prefijo"))
            correlativo = Integer.Parse(row("correlativo"))
            descripcion = row("descripcion").ToString()
            objTipoDeSangre = New Concepto(prefijo, correlativo, descripcion)

            listaTiposDeSangre(index) = objTipoDeSangre
            index += 1
        Next
    End Sub

    Public Function buscarTipoDoc(ByVal _tipoDoc As String) As Int16
        For Each oTipoDoc As Concepto In listaTipoDoc
            If _tipoDoc = oTipoDoc.getDescripcion Then
                Return oTipoDoc.getCorrelativo()
            End If
        Next

        Return Nothing
    End Function

    Public Function buscarTipoAseg(ByVal _tipoAseg As String) As Int16
        For Each tipoAsegurado As Concepto In listaTipoAsegurado
            If _tipoAseg = tipoAsegurado.getDescripcion Then
                Return tipoAsegurado.getCorrelativo()
            End If
        Next

        Return Nothing
    End Function

    Public Function buscarDepartamento(ByVal _departamento As String) As Int16
        For Each oDepartamento As Concepto In listaDepartamentos
            If _departamento = oDepartamento.getDescripcion Then
                Return oDepartamento.getCorrelativo()
            End If
        Next

        Return Nothing
    End Function

    Public Function buscarProvincia(ByVal _provincia As String) As Int16

        If Not _provincia = Nothing Then
            For Each oProvincia As Concepto In listaProvincias
                If _provincia = oProvincia.getDescripcion Then
                    Return oProvincia.getCorrelativo()
                End If
            Next

        Else
            Return Nothing

        End If


        Return Nothing
    End Function

    Public Function buscarTipoSangre(ByVal _tipoSangre As String) As Int16
        For Each oTipoSangre As Concepto In listaTiposDeSangre
            If _tipoSangre = oTipoSangre.getDescripcion Then
                Return oTipoSangre.getCorrelativo()
            End If
        Next

        Return 0
    End Function

    Public Function buscarAsegurado(ByVal _descripcion As String) As Asegurado

        If Not _descripcion = Nothing Then
            For Each asegurado As Asegurado In listaAsegurados
                If asegurado.getDescripcion() = _descripcion Then
                    Return asegurado
                End If
            Next
        Else
            Return Nothing
        End If

        Return Nothing
    End Function




    'VALIDAR ENTRADAS
    Public Function validarEntradas(ByVal _nit As String, ByVal _telfDomicilio As String,
                                    ByVal _telfLaboral As String, ByVal _telfReferencia As String,
                                    ByVal _matComercio As String, ByVal _codPatronal As String,
                                    ByVal _nroDocumento As String) As String
        Dim mensaje = validarNit(_nit)
        If Not mensaje = Nothing Then
            Return mensaje
        End If

        mensaje = validarTelefono(_telfDomicilio)
        If Not mensaje = Nothing Then
            Return "(Telefono Domiciliario)" + mensaje
        End If

        mensaje = validarTelefono(_telfLaboral)
        If Not mensaje = Nothing Then
            Return "(Telefono Laboral)" + mensaje
        End If

        mensaje = validarTelefono(_telfReferencia)
        If Not mensaje = Nothing Then
            Return "(Telefono Referencia)" + mensaje
        End If

        mensaje = validarMatriculaComercio(_matComercio)
        If Not mensaje = Nothing Then
            Return mensaje
        End If

        mensaje = validarCodigoPatronal(_codPatronal)
        If Not mensaje = Nothing Then
            Return mensaje
        End If


        mensaje = validarNroDocumento(_nroDocumento)
        If Not mensaje = Nothing Then
            Return mensaje
        End If


        Return mensaje
    End Function

    Public Function validarEntradas(ByVal _telfDomicilio As String, ByVal _telfLaboral As String,
                                    ByVal _telfReferencia As String, ByVal _nroDocumento As String) As String
        Dim mensaje

        mensaje = validarTelefono(_telfDomicilio)
        If Not mensaje = Nothing Then
            Return "(Telefono Domiciliario)" + mensaje
        End If

        mensaje = validarTelefono(_telfLaboral)
        If Not mensaje = Nothing Then
            Return "(Telefono Laboral)" + mensaje
        End If

        mensaje = validarTelefono(_telfReferencia)
        If Not mensaje = Nothing Then
            Return "(Telefono Referencia)" + mensaje
        End If

        mensaje = validarNroDocumento(_nroDocumento)
        If Not mensaje = Nothing Then
            Return mensaje
        End If


        Return mensaje
    End Function

    Private Function validarNit(ByVal _nit As String) As String
        If _nit.Length < 8 Then
            Return "El numero de NIT debe tener 8 caracteres como minimo"
        End If

        Return Nothing
    End Function

    Private Function validarTelefono(ByVal _telefono As String)
        For Each caracter As Char In _telefono
            If (Not caracter = "1") And (Not caracter = "2") And (Not caracter = "3") And (Not caracter = "4") And (Not caracter = "5") And (Not caracter = "6") And (Not caracter = "7") And (Not caracter = "8") And (Not caracter = "9") And (Not caracter = "0") Then
                Return "Error: En este campo sólo se admiten números"
            End If
        Next

        Return Nothing
    End Function

    Private Function validarMatriculaComercio(ByVal _matComercio As String)
        For Each caracter As Char In _matComercio
            If (Not caracter = "1") And (Not caracter = "2") And (Not caracter = "3") And (Not caracter = "4") And (Not caracter = "5") And (Not caracter = "6") And (Not caracter = "7") And (Not caracter = "8") And (Not caracter = "9") And (Not caracter = "0") Then
                Return "Error: La Matricula Comercio sólo debe contener números"
            End If
        Next

        Return Nothing
    End Function

    Private Function validarCodigoPatronal(ByVal _codigoPatronal As String)
        For Each caracter As Char In _codigoPatronal
            If (Not caracter = "1") And (Not caracter = "2") And (Not caracter = "3") And (Not caracter = "4") And (Not caracter = "5") And (Not caracter = "6") And (Not caracter = "7") And (Not caracter = "8") And (Not caracter = "9") And (Not caracter = "0") And (Not caracter = "-") Then
                Return "Error: El código patronal sólo puede contener números o guiónes medios"
            End If
        Next

        Return Nothing
    End Function

    Public Function validarEntradaBtnBuscar(ByVal _matriculaAsegurado As String) As String
        If _matriculaAsegurado.Trim = "" Then
            Return "No se puede buscar una matricula vacía. Ingrese una matricula"
        End If

        Return ""
    End Function

    Public Function validarNroDocumento(ByVal _nroDocumento As String)
        If _nroDocumento.Length < 6 Then
            Return "El numero de documento debe tener 6 caracteres como mínimo."
        End If

        Return Nothing

    End Function

    Public Function revisarCamposVacios(ByVal _tipoDoc As Int16, ByVal _nitEmpresa As String,
                                          ByVal _matriComer As String, ByVal _codigoPatronal As String,
                                          ByVal _dirDomicilio As String, ByVal _dirLaboral As String,
                                          ByVal _telfLaboral As String, ByVal _departamento As String,
                                          ByVal _provincia As String, ByVal _tipoSangre As String,
                                          ByVal _telefonoDomicilio As String, ByVal _telfReferencia As String,
                                          ByVal _nroDocumento As String, ByVal _extension As String) As String
        If _tipoDoc.ToString.Trim = 0 Then
            Return "Error. Seleccione un tipo de documento antes de guardar los datos."
        End If

        If _nitEmpresa.ToString.Trim = "" Then
            Return "Error. Ingrese el Nro de Nit antes de guardar los datos."
        End If

        If _matriComer.ToString.Trim = "" Then
            Return "Error. Ingrese la matricula de comercio antes de guardar los datos."
        End If

        If _codigoPatronal.ToString.Trim = "" Then
            Return "Error. Ingrese el código patronal antes de guardar los datos."
        End If

        If _dirDomicilio.ToString.Trim = "" Then
            Return "Error. Ingrese la dirección de domicilio antes de guardar los datos."
        End If

        If _dirLaboral.ToString.Trim = "" Then
            Return "Error. Ingrese la dirección laboral antes de guardar los datos."
        End If

        If _telfLaboral.ToString.Trim() = "" Then
            Return "Error. Ingrese el teléfono laboral antes de guardar los datos."
        End If

        If _departamento.ToString.Trim() = 0 Then
            Return "Error. Seleccione un departamento antes de guardar los datos"
        End If

        If _provincia.ToString.Trim() = 0 Then
            Return "Error. Seleccione una provincia antes de guardar los datos"
        End If

        If _tipoSangre.ToString.Trim() = 0 Then
            Return "Error. Seleccione una tipo de sannbre antes de guardar los datos"
        End If

        If _nroDocumento.ToString.Trim() = "" Then
            Return "Error. Ingrese un Nro de Documento antes de guardar los datos"
        End If

        If _extension.ToString.Trim() = "" Then
            Return "Error. Ingrese una extensión antes de guardar los datos"
        End If

        Return controlarCamposVaciosTelefonos(_telefonoDomicilio, _telfReferencia)

        Return Nothing
    End Function

    Public Function revisarCamposVacios(ByVal _tipoDoc As Int16, ByVal _dirDomicilio As String,
                                        ByVal _dirLaboral As String, ByVal _telfLaboral As String,
                                        ByVal _departamento As Int16, ByVal _provincia As Int16,
                                        ByVal _localidad As String, ByVal _tipoSangre As Int16,
                                        ByVal _telefonoDomicilio As String, ByVal _telfReferencia As String,
                                        ByVal _nroDocumento As String, ByVal _extension As String,
                                        ByVal _sector As Int16, ByVal _lugarResidencia As Int16,
                                        ByVal _tipoAsegurado As Int16) As String
        If _tipoDoc = 0 Then
            Return "Error: Seleccione un Tipo de Documento antes de guardar los datos."
        End If

        If _dirDomicilio.ToString.Trim = "" Then
            Return "Error: Ingrese la Dirección de Domicilio antes de guardar los datos."
        End If

        If _dirLaboral.ToString.Trim = "" Then
            Return "Error: Ingrese la Dirección Laboral antes de guardar los datos."
        End If

        If _telfLaboral.ToString.Trim() = "" Then
            Return "Error: Ingrese el Teléfono Laboral antes de guardar los datos."
        End If

        If _departamento = 0 Then
            Return "Error: Seleccione un Departamento antes de guardar los datos"
        End If

        If _provincia = 0 Then
            Return "Error: Seleccione una Provincia antes de guardar los datos"
        End If

        If _localidad.ToString.Trim() = "" Then
            Return "Error: Ingrese la localidad antes de guardar los datos."
        End If

        If _tipoSangre = 0 Then
            Return "Error: Seleccione una Tipo de Sangre antes de guardar los datos"
        End If

        If _nroDocumento.ToString.Trim() = "" Then
            Return "Error: Ingrese un Nro de Documento antes de guardar los datos"
        End If

        If _extension.ToString.Trim() = "" Then
            Return "Error: Ingrese una extensión antes de guardar los datos"
        End If

        If _sector = 0 Then
            Return "Error: Seleccione algún Sector (Publico o Privado) antes de guardar los datos"
        End If

        If _lugarResidencia = 0 Then
            Return "Error: Seleccione algún Lugar de Residencia (Ciudad o Provincia) antes de guardar los datos"
        End If

        If _tipoAsegurado = 0 Then
            Return "Error: Seleccione el Tipo de Asegurado al que pertence antes de guardar los datos"
        End If

        Return controlarCamposVaciosTelefonos(_telefonoDomicilio, _telfReferencia)

        Return Nothing
    End Function

    Private Function controlarCamposVaciosTelefonos(ByVal _telefonoDomicilio As String, ByVal _telfReferencia As String)
        If (_telefonoDomicilio = "" Or _telefonoDomicilio = Nothing) And (_telfReferencia = "" Or _telfReferencia = Nothing) Then
            Return "Los campos Telefono de Domicilio y Telefono de Rerencia están vacíós. Ingrese al menos un campo"
        End If

        Return Nothing
    End Function





    'METODOS FUNCIONALES
    Public Function acutalizarDatosAsegurado()
        Dim respuesta As Int16 = 0
        respuesta = actualizarDatosBD()

        Return respuesta
    End Function

    Public Function acutalizarDatosEmpresa()
        Dim respuesta As Int16 = 0
        respuesta = actualizarDatosEmpresaBD()

        Return respuesta
    End Function

    Public Sub traerDatosAsegurado(ByVal _matricula As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerDatosAseguradoBD(_matricula)

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim nit As String = ""
            Dim nroPatronal As String = ""
            Dim nroDocumento As String = ""
            Dim complemento As String = ""
            Dim matriculaComercio As String = ""

            nit = row("nit").ToString()
            nroPatronal = row("nro patro").ToString()
            nroDocumento = row("nro doc").ToString()
            complemento = row("extension").ToString()
            matriculaComercio = row("matricula").ToString()

            oAsegurado.getEmpesa().setNit(nit)
            oAsegurado.getEmpesa().setCodigoPatronal(nroPatronal)
            oAsegurado.getEmpesa().setMatriculaComercio(matriculaComercio)

            oAsegurado.setNroDocumento(nroDocumento)
            oAsegurado.setComplemento(complemento)
        Next
    End Sub

    Public Sub traerAsegurados(ByVal _nombre)
        Dim objDTable As DataTable
        Dim index As Int16

        objDTable = buscarAsegPorNombreBD(_nombre)
        listaAsegurados = New Asegurado(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows

            Dim tipo As String = row("TYPE").ToString()
            Dim nombre As String = row("ASEGURADO").ToString()
            Dim matricula As String = row("MATRICULA").ToString()
            Dim nroDocumento As String = row("DOCUMENTO").ToString()
            Dim nombreEmpresa As String = row("EMPRESA").ToString()
            Dim codigoEmpresa As String = row("COD EMPRESA").ToString()

            Dim oAseguradoAux As Asegurado = New Asegurado(nombre, matricula, tipo)
            oAseguradoAux.setNroDocumento(nroDocumento)
            Dim oEmpresaAux As Empresa = New Empresa(codigoEmpresa, nombreEmpresa)
            oAseguradoAux.setEmpresa(oEmpresaAux)

            listaAsegurados(index) = oAseguradoAux
            listaAsegurados(index).generarDescripcion()
            index += 1
        Next
    End Sub

    'METOD OTROS METODOS
    Public Sub crearAsegurado(ByRef _obAsegurado As Asegurado)
        oAsegurado = _obAsegurado
    End Sub

    Public Sub crearEmpresa(ByRef _obEmpresa As Empresa)
        oEmpresa = _obEmpresa
    End Sub





    'METOD BD.
    Private Function buscarAsegPorNombreBD(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre
        Return (objDAL.TraerDataTable("spBuscarAsegPorNombre", P))
    End Function

    Private Function buscarAsegXMatBD(ByVal _matricula) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDAL.TraerDataTable("spBuscarAseguradoXMat", P))
    End Function

    Private Function traerTipoDocBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerTipoDocumento_Concepto"))
    End Function

    Private Function traerTipoAsegBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerConceptoTipoAsegurado"))
    End Function

    Public Function traerDepartamentosBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerConceptoDepartamento"))
    End Function

    Private Function traerProvinciasBD(ByVal _departamento As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _departamento
        Return (objDAL.TraerDataTable("SPtraerConProvincias", P))
    End Function

    Private Function traerTipoSangreBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerTiposDeSangre"))
    End Function

    Private Function traerDatosAseguradoBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDAL.TraerDataTable("SPtraerDatosAsegurado", P))
    End Function

    Private Function actualizarDatosBD() As Int16
        Dim respuesta As Int16 = 0

        Dim P As Object() = New Object(16) {}
        P(0) = oAsegurado.getMatricula()
        P(1) = oAsegurado.getTipoDocumento()
        P(2) = oAsegurado.getDireccionDomicilio()
        P(3) = oAsegurado.getTelefono()
        P(4) = oAsegurado.getDireccionLaboral()
        P(5) = oAsegurado.getTelefonoLaboral()
        P(6) = oAsegurado.getDepartamentoResidencia()
        P(7) = oAsegurado.getProvinciaLaboral()
        P(8) = oAsegurado.getLocalidad()
        P(9) = oAsegurado.getTelefonoReferencia()
        P(10) = oAsegurado.getTipoSangre()
        P(11) = oAsegurado.getNroDocumento()
        P(12) = oAsegurado.getComplemento()
        P(13) = oAsegurado.getEmpesa().getSector()
        P(14) = ""
        P(15) = oAsegurado.getTipoAsegurado()
        P(16) = Usuario.codUserLoggedSystem


        respuesta = objDAL.Ejecutar("SPactualizarDatos2", P)
        Return respuesta
    End Function

    Private Function actualizarDatosEmpresaBD() As Int16
        Dim respuesta As Int16 = 0

        Dim P As Object() = New Object(4) {}
        P(0) = oAsegurado.getEmpesa().getCodigo()
        P(1) = oAsegurado.getEmpesa().getNit()
        P(2) = oAsegurado.getEmpesa().getMatriculaComercio()
        P(3) = oAsegurado.getEmpesa().getCodigoPatronal()
        P(4) = oAsegurado.getEmpesa().getRoe()
        respuesta = objDAL.Ejecutar("SPactualizarDatosEmpresa", P)

        Return respuesta
    End Function



End Class
