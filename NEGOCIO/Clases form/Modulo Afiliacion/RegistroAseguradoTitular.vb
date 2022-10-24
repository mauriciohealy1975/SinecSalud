Public Class RegistroAseguradoTitular

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public oModoFormuario As Int16
    Public oTitular As Titular
    Public fechaPresentacion As Date


    'G1
    Public listaNacionalidades As Concepto()
    Public listaLugarNacimiento As Concepto()

    Public listaTipoSangre As Concepto()
    Public listaEstadosCiviles As Concepto()

    Public oNacionalidadSeleccionada As Concepto
    Public oLugarNacimientoSeleccionado As Concepto
    Public oTipoSangreSeleccionado As Concepto
    Public oEstadoCivilSeleccionado As Concepto




    'G2
    Public listaTiposDocumento As Concepto()
    Public listaLugarExpedicion As Concepto()


    Public oTipoDocSeleciconado As Concepto
    Public oLugarExpedicionSeleccionado As Concepto




    'G3
    Public listaTipoAsegurado As Concepto()
    Public listaEmpresas As Empresa()
    Public listaCargos As Concepto()
    Public listaProgramasProyectos As ProgramaProyecto()
    Public listaEntidadesDesconcetradas As EntidadDesconcentrada()

    Public oTipoAseguradoSeleccionado As Concepto
    Public oEmpresaSeleccionada As Empresa
    Public oCargoSeleccionado As Concepto
    Public oProgramaProyectoSeleccionado As ProgramaProyecto
    Public oEntidadDesconcentradaSeleccionada As EntidadDesconcentrada




    'G4
    Public listaDepartamentos As Concepto()
    Public listaProvincias As Concepto()
    Public oDepartamentoResidenciaSeleccionado As Concepto
    Public oProvinciaResidenciaSeleccionada As Concepto




    'G5
    Public listaProvinciasLaborales As Concepto()
    Public oDptoLaboralSeleccionado As Concepto
    Public oProvinciaLaboralSeleccionada As Concepto
    Public localidadLaboral As String



    Public Sub New()
        oTitular = New Titular()
        oModoFormuario = 1
    End Sub



    'METODOS FUNCIONALES G1
    Public Sub traerNacionalidades()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerNacionalidadesBD()
        listaNacionalidades = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oNacionalidad As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaNacionalidades(index) = oNacionalidad
            index += 1
        Next
    End Sub

    Public Sub traerLugarNacimiento()
        Dim objDTable As DataTable
        Dim index As Int16

        objDTable = traerDepartamentosBD()
        listaLugarNacimiento = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oLugarNacimiento As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaLugarNacimiento(index) = oLugarNacimiento

            index += 1
        Next
    End Sub

    Public Sub traerTipoSangre()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerTipoSangreBD()
        listaTipoSangre = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oTipoSangre As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaTipoSangre(index) = oTipoSangre
            index += 1
        Next
    End Sub

    Public Sub traerEstadosCivilies()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerEstadosCivilesBD()
        listaEstadosCiviles = New Concepto(objDTable.Rows.Count - 1) {}
        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()
            Dim oEstadoCivil As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaEstadosCiviles(index) = oEstadoCivil
            index += 1
        Next
    End Sub

    Public Function generarMatricula(ByVal _fechaNac As Date, ByVal _apPater As String, ByVal _apMater As String, ByVal _nombres As String, ByVal _sexo As Char)

        Dim matriculaGenerada As String = ""
        Dim ultimaMatriHomonima As String = ""

        Dim año As String = _fechaNac.Year.ToString()
        Dim mes As String = _fechaNac.Month.ToString()
        Dim dia As String = _fechaNac.Day.ToString()
        Dim parteAño As String = generarParteAño(año)
        Dim parteMes As String = generarParteMes(mes, _sexo)
        Dim parteDia As String = generarParteDia(dia)
        Dim parteNombre As String = generarParteNombre(_apPater, _apMater, _nombres)

        ultimaMatriHomonima = traerUltimoHomonimo(parteAño, parteMes, parteDia, parteNombre)

        If ultimaMatriHomonima = "" Then
            matriculaGenerada = parteAño + parteMes + parteDia + parteNombre + "00"
        Else
            matriculaGenerada = generarSiguienteHomonimo(ultimaMatriHomonima)
        End If

        Return matriculaGenerada
    End Function

    Private Function generarParteAño(ByVal _año As String) As String
        Dim parteAño As String = ""
        parteAño = _año(_año.Length - 2) + _año(_año.Length - 1)

        Return parteAño
    End Function

    Private Function generarParteMes(ByVal _mes As String, ByVal _sexo As Char) As String
        Dim parteMes As String = ""

        If _mes.Length = 1 Then
            parteMes = "0" + _mes
        Else
            parteMes = _mes
        End If


        If _sexo = "F" Then
            parteMes = convertirMesesFormatoMujeres(parteMes)
        End If

        Return parteMes
    End Function

    Private Function convertirMesesFormatoMujeres(ByVal _mes As String) As String
        Dim mesFormateado As String = ""

        If _mes(0) = "0" Then mesFormateado = "5" + _mes(1) Else mesFormateado = "6" + _mes(1)
        Return mesFormateado
    End Function

    Private Function generarParteDia(ByVal _dia As String) As String
        Dim parteDia As String = ""

        If _dia.Length = 1 Then
            parteDia = "0" + _dia
        Else
            parteDia = _dia
        End If

        Return parteDia
    End Function

    Private Function generarParteNombre(ByVal _apPater As String, ByVal _apMater As String, ByVal _nombres As String)
        Dim parteNombre As String = ""

        If _apMater = "" Then
            parteNombre = _apPater(0) + _apPater(1) + _nombres(0)
        Else
            parteNombre = _apPater(0) + _apMater(0) + _nombres(0)
        End If

        Return parteNombre
    End Function

    Private Function traerUltimoHomonimo(ByVal _parteAño As String, ByVal _parteMes As String, ByVal _parteDia As String,
                                        ByVal _parteNombre As String) As String

        Dim matriculaGenerada As String = ""
        Dim prefijoMatricula As String = _parteAño + _parteMes + _parteDia + _parteNombre
        Dim listaMatHomonimas As String() = traerHomonimos(prefijoMatricula)


        If Not listaMatHomonimas.Count = 0 Then
            Dim ultimaMatricula As String = listaMatHomonimas(listaMatHomonimas.Count - 1)
            Return ultimaMatricula
        End If

        Return ""
    End Function

    Private Function traerHomonimos(ByVal _inicioMatricula As String) As String()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerHomonimosBD(_inicioMatricula)
        Dim listaHomonimos As String() = New String(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim matricula As String = row("MAT TIT").ToString()

            listaHomonimos(index) = matricula
            index += 1
        Next

        Return listaHomonimos
    End Function

    Private Function generarSiguienteHomonimo(ByVal _ultimaMatHomonima As String)
        Dim nuevaMatricula As String = ""
        Dim complemento As String = ""
        Dim longitud As Int16 = _ultimaMatHomonima.Length

        complemento = _ultimaMatHomonima(longitud - 3)

        If Char.IsDigit(complemento) Then
            complemento = Int16.Parse(complemento) + 1
            Dim matriAux As String = _ultimaMatHomonima.Substring(0, 9)
            nuevaMatricula = matriAux + complemento + "00"
        Else
            complemento = 1
            Dim matriAux As String = _ultimaMatHomonima.Substring(0, 9)
            nuevaMatricula = matriAux + complemento + "00"
        End If

        Return nuevaMatricula
    End Function

    Public Function validarEntradasGenerarMatricula(ByVal _fechaNac As String, ByVal _apPater As String,
                                                ByVal _nombres As String, ByVal _sexo As Char)

        If _fechaNac = "" Then Return "Error. Ingrese la fecha de nacimiento antes de generar la matrícula."
        If _apPater = "" Then Return "Error. Ingrese el apellido parterno antes de generar la matrícula."
        If _nombres = "" Then Return "Error. Ingrese el nombre antes de generar la matrícula."
        If Not _sexo = "F" And Not _sexo = "M" Then Return "Error. Seleccione el sexo antes de generar la matrícula."

        Return ""
    End Function




    'G2
    Public Sub traerTipoDocumento()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerTipoDocumentoBD()
        listaTiposDocumento = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREFIJO"))
            Dim correlativo As Int16 = Int16.Parse(row("CORRELATIVO"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oTipoDocumento As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaTiposDocumento(index) = oTipoDocumento
            index += 1
        Next
    End Sub

    Public Sub traerLugarExpedicion()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerLugarExpedicionBD()
        listaLugarExpedicion = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oLugarExpedicion As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaLugarExpedicion(index) = oLugarExpedicion
            index += 1
        Next
    End Sub


    'G3
    Public Sub traerTipoAsegurado()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerTipoAseguradoBD()
        listaTipoAsegurado = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oTipoAsegurado As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaTipoAsegurado(index) = oTipoAsegurado
            index += 1
        Next
    End Sub

    Public Sub traerEmpresas(ByVal _nombreEmpresa As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerEmpresasBD(_nombreEmpresa)
        listaEmpresas = New Empresa(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int16 = Int16.Parse(row("COD EMP"))
            Dim nombre As String = row("NOM EMP").ToString()

            Dim sectorCod As Int16 = 0
            If Not IsDBNull(row("COD SEC")) Then sectorCod = Int16.Parse(row("COD SEC"))

            Dim sectorNom As String = ""
            If Not IsDBNull(row("NOM SEC")) Then sectorNom = row("NOM SEC").ToString()

            Dim nit As Int64 = 0
            If Not IsDBNull(row("NIT EMP")) Then nit = Int64.Parse(row("NIT EMP"))

            Dim matriculaComercio = ""
            If Not IsDBNull(row("MAT COMER EMP")) Then matriculaComercio = row("MAT COMER EMP").ToString()

            Dim codigoPatronal As String = ""
            If Not IsDBNull(row("COD PATRO")) Then codigoPatronal = row("COD PATRO").ToString()


            Dim oEmpresa As Empresa = New Empresa(codigo, nombre)
            oEmpresa.setSector(New Concepto())
            oEmpresa.getSector().setCorrelativo(sectorCod)
            oEmpresa.getSector().setDescripcion(sectorNom)
            oEmpresa.setNit(nit)
            oEmpresa.setMatriculaComercio(matriculaComercio)
            oEmpresa.setCodigoPatronal(codigoPatronal)

            listaEmpresas(index) = oEmpresa
            index += 1
        Next
    End Sub

    Public Sub traerCargosTrabajo()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerCargosTrabajoBD()
        listaCargos = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oCargoTrabajo As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaCargos(index) = oCargoTrabajo
            index += 1
        Next
    End Sub

    Public Sub traerProgramaProyecto()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerProgramaProyectoBD()
        listaProgramasProyectos = New ProgramaProyecto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int16 = Int16.Parse(row("COD PROG"))
            Dim nombre As String = row("NOM PROG").ToString()
            Dim tipo As String = Int16.Parse(row("TIPO"))
            Dim codEmpresa As Int16 = Int16.Parse(row("COD EMP"))

            Dim oProgramaProyecto As ProgramaProyecto = New ProgramaProyecto()
            oProgramaProyecto.setCodigo(codigo)
            oProgramaProyecto.setNombre(nombre)
            oProgramaProyecto.setTipo(tipo)
            oProgramaProyecto.setEmpresa(oEmpresaSeleccionada)


            listaProgramasProyectos(index) = oProgramaProyecto
            index += 1
        Next
    End Sub

    Public Sub traerEntidadDesconcentrada()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerEntidadDesconcentradaBD()
        listaEntidadesDesconcetradas = New EntidadDesconcentrada(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int16 = Int16.Parse(row("COD ENTI"))
            Dim nombre As String = row("NOM ENTI").ToString()
            Dim codigoEmpresa As Int16 = Int16.Parse(row("COD EMP"))

            Dim OentidadDesconcentrada As EntidadDesconcentrada = New EntidadDesconcentrada()
            OentidadDesconcentrada.setCodigo(codigo)
            OentidadDesconcentrada.setNombre(nombre)
            OentidadDesconcentrada.setEmpresa(oEmpresaSeleccionada)

            listaEntidadesDesconcetradas(index) = OentidadDesconcentrada
            index += 1
        Next

    End Sub

    Public Function esEmpresaPublica() As Boolean
        Dim oSectorAux As Concepto = oEmpresaSeleccionada.getSector()

        If oSectorAux.getCorrelativo() = 1 Then
            Return True
        End If

        Return False
    End Function


    'G4 Y G5
    Public Sub traerDepartamentos()
        Dim objDTable As DataTable
        Dim index As Int16

        objDTable = traerDepartamentosBD()
        listaDepartamentos = New Concepto(objDTable.Rows.Count - 2) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            If index = objDTable.Rows.Count - 1 Then Continue For

            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oDepartamento As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaDepartamentos(index) = oDepartamento
            index += 1
        Next
    End Sub

    Public Sub traerProvincias()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerProvinciasBD(oDepartamentoResidenciaSeleccionado.getCorrelativo())
        listaProvincias = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oProvincia As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaProvincias(index) = oProvincia
            index += 1
        Next
    End Sub

    Public Sub traerProvinciasLaborales()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerProvinciasBD(oDptoLaboralSeleccionado.getCorrelativo())
        listaProvinciasLaborales = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREF"))
            Dim correlativo As Int16 = Int16.Parse(row("CORR"))
            Dim descripcion As String = row("DESC").ToString()

            Dim oProvincia As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listaProvinciasLaborales(index) = oProvincia
            index += 1
        Next
    End Sub


    'G6
    Public Function guardarTitular() As Int16
        Dim respuesta As Int16 = guardarTitularBD()

        Return respuesta
    End Function

    Public Function guardarDatosPersonales() As Int16
        Dim respuesta As Int16 = guardarDatosPersonalesBD()

        Return respuesta
    End Function

    Public Function guardarAvisoAfiliacion() As Int16
        Dim respuesta As Int16 = guardarAvisoAfiliacionBD()

        Return respuesta
    End Function









    'METODOS VALIDIACIÓN
    Public Function validarEntradas() As String
        Dim mensaje As String = ""

        'cg1
        mensaje = validarApellidoPaterno(oTitular.getApellidoPaterno())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarNombres(oTitular.getNombres())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarMatricula(oTitular.getMatricula())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarNacionalidad(oNacionalidadSeleccionada)
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarLugarNacimiento(oLugarNacimientoSeleccionado)
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarFechaNacimiento(oTitular.getFechaNacimiento())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarTipoSangre(oTipoSangreSeleccionado)
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarSexo(oTitular.getSexo())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarEstadoCivil(oTitular.getEstadoCivil())
        If Not mensaje = "" Then
            Return mensaje
        End If


        mensaje = validarZona(oTitular.getZona())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarCalle(oTitular.getCalle())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarNroCasa(oTitular.getNroCasa())
        If Not mensaje = "" Then
            Return mensaje
        End If



        'cg2
        mensaje = validarTipoDocumento(oTipoDocSeleciconado)
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarNroDocumento(oTitular.getNroDocumento())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarLugarExpedicion(oLugarExpedicionSeleccionado)
        If Not mensaje = "" Then
            Return mensaje
        End If



        'cg3
        mensaje = validarTipoAsegurado(oTipoAseguradoSeleccionado)
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarEmpresa(oTitular.getEmpesa())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarFechaContratacion(oTitular.getFechaContratacion())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarCargo(oTitular.getCargo())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarSalario(oTitular.getSalario())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarTipoContratacion(oTitular.getTipoContratacion())
        If Not mensaje = "" Then
            Return mensaje
        End If

        Dim sectorAux As Concepto = oEmpresaSeleccionada.getSector()

        If sectorAux.getCorrelativo() = 1 Then
            mensaje = validarProgramaProyectoYEntidad()
            If Not mensaje = "" Then
                Return mensaje
            End If
        End If

        mensaje = validarFechaPresentacion(fechaPresentacion)
        If Not mensaje = "" Then
            Return mensaje
        End If



        'cg4
        mensaje = validarTelefono(oTitular.getTelefono())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarTelefonoReferencia(oTitular.getTelefonoReferencia())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarDptoResidencia(oDepartamentoResidenciaSeleccionado)
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarProvinciaResidencia(oProvinciaResidenciaSeleccionada)
        If Not mensaje = "" Then
            Return mensaje
        End If





        'cg5
        mensaje = validarTelefonoLaboral(oTitular.getTelefonoLaboral())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarDireccionLaboral(oTitular.getDireccionLaboral())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarDptoLaboralSeleccionado(oDptoLaboralSeleccionado)
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarProvinciaLaboralSeleccionada(oProvinciaLaboralSeleccionada)
        If Not mensaje = "" Then
            Return mensaje
        End If

        Return ""
    End Function


    'cg1
    Private Function validarApellidoPaterno(ByVal _apPaterno As String) As String
        If _apPaterno = "" Then
            Return "Error. El apellido paterno no puede estar vacío."
        End If

        Return ""
    End Function

    Private Function validarNombres(ByVal _nombres As String) As String
        If _nombres = "" Then
            Return "Error. El nombre no puede estar vacío."
        End If

        Return ""
    End Function

    Private Function validarMatricula(ByVal _matricula As String) As String
        If _matricula = "" Then
            Return "Error. La matricula no puede estar vacía."
        End If

        Return ""
    End Function

    Private Function validarNacionalidad(ByRef _oNacionalidad As Concepto) As String
        If _oNacionalidad Is Nothing Then
            Return "Error. Seleccione una nacionalidad."
        End If

        Return ""
    End Function

    Private Function validarLugarNacimiento(ByRef _oLugarNacimiento As Concepto) As String
        If _oLugarNacimiento Is Nothing Then
            Return "Error. Seleecione un lugar de nacimiento."
        End If

        Return ""
    End Function

    Private Function validarFechaNacimiento(ByVal _fechaNacimiento As String) As String
        If _fechaNacimiento = "" Then
            Return "Error. Ingrese la fecha de nacimiento"
        End If

        Dim edad As Int16 = Utilitarios.calcularEdad(_fechaNacimiento)
        If edad < 18 Then
            Return "Error en fecha de nacimiento. No se puede registrar un titular menor de 18 años."
        End If

        Return ""
    End Function

    Private Function validarTipoSangre(ByRef _oTipoSangre As Concepto) As String
        If _oTipoSangre Is Nothing Then
            Return "Error. Seleccione el tipo sangre."
        End If

        Return ""
    End Function

    Private Function validarSexo(ByVal _sexo As Char)
        If Not _sexo = "M" And Not _sexo = "F" Then
            Return "Error. Seleccione un sexo."
        End If

        Return ""
    End Function

    Private Function validarEstadoCivil(ByRef _oEstadoCivil As Concepto)
        If _oEstadoCivil Is Nothing Then
            Return "Error. Seleccione un estado civil."
        End If

        Return ""
    End Function

    Private Function validarZona(ByVal _zona As String)
        If _zona = "" Then
            Return "Error. Ingrese el nombre de la zona."
        End If

        Return ""
    End Function

    Private Function validarCalle(ByVal _calle As String)
        If _calle = "" Then
            Return "Error. Ingrese el nombre de la calle."
        End If

        Return ""
    End Function

    Private Function validarNroCasa(ByVal _nroCasa As String)
        If _nroCasa = "" Then
            Return "Error. Ingrese el nro casa."
        End If

        Return ""
    End Function



    'cg2
    Private Function validarTipoDocumento(ByRef _oTipoDocumento As Concepto)
        If _oTipoDocumento Is Nothing Then
            Return "Error. Seleccione un tipo de documento."
        End If

        Return ""
    End Function

    Private Function validarNroDocumento(ByVal _nroDocumento As String)
        If _nroDocumento = "" Then
            Return "Error. Ingrese el nro. de documento."
        End If

        If _nroDocumento.Count < 7 Then
            Return "Error. El nro. de documento no puede ser menor a 7 caracteres."
        End If

        Return ""
    End Function

    Private Function validarLugarExpedicion(ByRef _oLugarExpSeleccionado As Concepto)
        If _oLugarExpSeleccionado Is Nothing Then
            Return "Error. Seleccione un lugar de expedición."
        End If

        Return ""
    End Function



    'cg3
    Private Function validarTipoAsegurado(ByRef _oTipoAsegurado As Concepto)
        If _oTipoAsegurado Is Nothing Then
            Return "Error. Seleccione un tipo de asegurado."
        End If

        Return ""
    End Function

    Private Function validarEmpresa(ByRef _oEmpresa As Empresa)
        If _oEmpresa Is Nothing Then
            Return "Error. Seleccione una empresa."
        End If

        Return ""
    End Function

    Private Function validarFechaContratacion(ByVal _fechaContratacion As Date)
        If _fechaContratacion.ToString() = "" Then
            Return "Error. Ingrese la fecha de contratación"
        End If

        If _fechaContratacion > Date.Today Then
            Return "Error. La fecha de contratación no puede ser mayor a la fecha del día actual."
        End If

        Return ""
    End Function

    Private Function validarCargo(ByRef _oCargo As Concepto)
        If _oCargo Is Nothing Then
            Return "Error. Seleccione un cargo."
        End If

        Return ""
    End Function

    Private Function validarSalario(ByVal _salario As Int64)
        If _salario = 0 Then
            Return "Error. Ingrese un salario."
        End If

        Return ""
    End Function

    Private Function validarTipoContratacion(ByVal _tipoContrtacion As Int16)
        If IsNothing(_tipoContrtacion) Or _tipoContrtacion = 0 Then
            Return "Error. Seleccione un tipo de contratación."
        End If

        Return ""
    End Function

    Private Function validarProgramaProyectoYEntidad()
        If oProgramaProyectoSeleccionado Is Nothing And oEntidadDesconcentradaSeleccionada Is Nothing Then
            Return "Error. Seleccione un programa/proyecto, una Entidad Desconcentrada, o ambos."
        End If

        Return ""
    End Function

    Private Function validarFechaPresentacion(ByVal _fechaPresentacion As Date)
        If _fechaPresentacion.ToString() = "" Then
            Return "Error. Ingrese la fecha de presentación"
        End If

        If _fechaPresentacion > Date.Today Then
            Return "Error. La fecha de presentación no puede ser mayor a la fecha del día actual."
        End If

        Return ""
    End Function


    'g4
    Private Function validarTelefono(ByVal _telefono As String) As String
        If _telefono = "" Then
            Return "Error. Ingrese un nro de teléfono."
        End If

        For Each c As Char In _telefono
            If Not Char.IsDigit(c) Then
                Return "Error. El teléfono sólo debe contener números."
            End If
        Next

        If _telefono.Count() < 8 Then
            Return "Error. El teléfono no puede ser menor de 8 dígitos."
        End If


        Return ""
    End Function

    Private Function validarTelefonoReferencia(ByVal _telefonoReferencia As String) As String

        If Not _telefonoReferencia = "" Then
            For Each c As Char In _telefonoReferencia
                If Not Char.IsDigit(c) Then
                    Return "Error. El teléfono de referencia sólo debe contener números."
                End If
            Next

            If _telefonoReferencia.Count() < 8 Then
                Return "Error. El teléfono der referencia no puede ser menor de 8 dígitos."
            End If
        End If

        Return ""
    End Function

    Private Function validarDptoResidencia(ByRef _oDptoResidencia As Concepto)
        If _oDptoResidencia Is Nothing Then
            Return "Error. Seleccione un departamento de residencia."
        End If

        Return ""
    End Function

    Private Function validarProvinciaResidencia(ByRef _oProvResidencia As Concepto)
        If _oProvResidencia Is Nothing Then
            Return "Error. Seleccione una provincia de residencia."
        End If

        Return ""
    End Function

    Private Function validarTelefonoLaboral(ByVal _telefonoLaboral As String)

        If Not _telefonoLaboral = "" Then
            For Each c As Char In _telefonoLaboral
                If Not Char.IsDigit(c) Then
                    Return "Error. El teléfono laboral sólo debe contener números."
                End If
            Next

            If _telefonoLaboral.Count() < 8 Then
                Return "Error. El teléfono laboral no puede ser menor de 8 digitos."
            End If
        End If

        Return ""
    End Function

    Private Function validarDireccionLaboral(ByVal _dirLaboral As String)
        If _dirLaboral = "" Then
            Return "Error. Ingrese la dirección laboral."
        End If

        Return ""
    End Function

    Private Function validarDptoLaboralSeleccionado(ByRef _oDptoLaboral As Concepto)
        If _oDptoLaboral Is Nothing Then
            Return "Error. Seleccione un departamento laboral."
        End If

        Return ""
    End Function

    Private Function validarProvinciaLaboralSeleccionada(ByRef _oProvinciaLaboral As Concepto)
        If _oProvinciaLaboral Is Nothing Then
            Return "Error. Seleccione una provincia laboral."
        End If

        Return ""
    End Function





    'METODOS BD -- G1
    Private Function traerHomonimosBD(ByVal _inicioMatricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _inicioMatricula
        Return objDAL.TraerDataTable("SPbuscarHominimosTitulares", P)
    End Function

    Private Function traerNacionalidadesBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerNacionalidades")
    End Function

    Private Function traerTipoSangreBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerTipoSangre")
    End Function



    'G2
    Private Function traerTipoDocumentoBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerTipoDocumento")
    End Function

    Private Function traerLugarExpedicionBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerLugarExpedicion")
    End Function



    'G3
    Private Function traerTipoAseguradoBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerTipoAsegurado")
    End Function

    Private Function traerEmpresasBD(ByVal _nombreEmpresa As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombreEmpresa
        Return objDAL.TraerDataTable("SPtraerEmpresas", P)
    End Function

    Private Function traerCargosTrabajoBD()
        Return objDAL.TraerDataTable("SPtraerCargosTrabajo")
    End Function

    Private Function traerProgramaProyectoBD() As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = oEmpresaSeleccionada.getCodigo()
        Return objDAL.TraerDataTable("SPtraerProgramaProyecto", P)
    End Function

    Private Function traerEntidadDesconcentradaBD()
        Dim P As Object() = New Object(0) {}
        P(0) = oEmpresaSeleccionada.getCodigo()
        Return objDAL.TraerDataTable("SPtraerEntidadDesconcentrada", P)
    End Function



    'G4
    Private Function traerDepartamentosBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerDepartamento")
    End Function

    Private Function traerProvinciasBD(ByVal _departamento As Int16) As DataTable
        Dim P As Object() = New Object(4) {}
        P(0) = _departamento
        Return objDAL.TraerDataTable("SPtraerProvincia", P)
    End Function

    Private Function traerEstadosCivilesBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerEstadosCiviviles")
    End Function



    'G6
    Private Function guardarTitularBD() As Int16
        Dim P As Object() = New Object(14) {}


        P(0) = oTipoDocSeleciconado.getCorrelativo()
        P(1) = oTitular.getNroDocumento()

        If String.IsNullOrEmpty(oTitular.getComplemento()) Then
            P(2) = DBNull.Value
        Else
            P(2) = oTitular.getComplemento()
        End If

        P(3) = oLugarExpedicionSeleccionado.getDescripcion()




        P(4) = oTitular.getApellidoPaterno()

        If String.IsNullOrEmpty(oTitular.getApellidoMaterno()) Then
            P(5) = DBNull.Value
        Else
            P(5) = oTitular.getApellidoMaterno()
        End If

        P(6) = oTitular.getNombres()
        P(7) = oTitular.getMatricula()
        P(8) = oTipoAseguradoSeleccionado.getCorrelativo()





        P(9) = oEmpresaSeleccionada.getCodigo()

        If IsNothing(oEmpresaSeleccionada.getNit()) Or oEmpresaSeleccionada.getNit() = 0 Then
            P(10) = DBNull.Value
        Else
            P(10) = oEmpresaSeleccionada.getNit()
        End If

        If String.IsNullOrEmpty(oEmpresaSeleccionada.getMatriculaComercio()) Then
            P(11) = DBNull.Value
        Else
            P(11) = oEmpresaSeleccionada.getMatriculaComercio()
        End If

        If String.IsNullOrEmpty(oEmpresaSeleccionada.getCodigoPatronal()) Then
            P(12) = DBNull.Value
        Else
            P(12) = oEmpresaSeleccionada.getCodigoPatronal()
        End If

        If IsNothing(oEmpresaSeleccionada.getSector().getCorrelativo()) Or oEmpresaSeleccionada.getSector().getCorrelativo() = 0 Then
            P(13) = DBNull.Value
        Else
            P(13) = oEmpresaSeleccionada.getSector().getCorrelativo()
        End If

        P(14) = Usuario.codUserLoggedSystem


        Dim respuesta As Int16 = objDAL.Ejecutar("SPguardarTitular", P)
        Return respuesta
    End Function

    Private Function guardarDatosPersonalesBD() As Int16
        Dim P As Object() = New Object(20) {}
        P(0) = oTitular.getMatricula()
        P(1) = oTitular.getSexo()
        P(2) = oTitular.getFechaNacimiento()
        P(3) = oTitular.getNacionalidad().getCorrelativo()



        P(4) = oTitular.getLugarNacimiento.getCorrelativo()
        P(5) = oTitular.getTipoSangre.getCorrelativo()
        P(6) = oTitular.getEstadoCivil().getCorrelativo()
        P(7) = oTitular.getTelefono()



        If String.IsNullOrEmpty(oTitular.getTelefonoReferencia()) Then
            P(8) = DBNull.Value
        Else
            P(8) = oTitular.getTelefonoReferencia()
        End If

        P(9) = oTitular.getZona()
        P(10) = oTitular.getCalle()
        P(11) = oTitular.getNroCasa()




        P(12) = oTitular.getDepartamentoResidencia().getCorrelativo()
        P(13) = oTitular.getProvinciaResidencia().getCorrelativo()

        If String.IsNullOrEmpty(oTitular.getLocalidad()) Then
            P(14) = DBNull.Value
        Else
            P(14) = oTitular.getLocalidad()
        End If

        If String.IsNullOrEmpty(oTitular.getTelefonoLaboral()) Then
            P(15) = DBNull.Value
        Else
            P(15) = oTitular.getTelefonoLaboral()
        End If




        If String.IsNullOrEmpty(oTitular.getDireccionLaboral()) Then
            P(16) = DBNull.Value
        Else
            P(16) = oTitular.getDireccionLaboral()
        End If

        P(17) = oTitular.getDepartamentoLaboral().getCorrelativo()
        P(18) = oTitular.getProvinciaLaboral().getCorrelativo()

        If String.IsNullOrEmpty(oTitular.getLocalidadLaboral()) Then
            P(19) = DBNull.Value
        Else
            P(19) = oTitular.getLocalidadLaboral()
        End If



        P(20) = Usuario.codUserLoggedSystem
        Dim respuesta As Int16 = objDAL.Ejecutar("SPagregarDatosPersonales", P)
        Return respuesta
    End Function

    Private Function guardarAvisoAfiliacionBD() As Int16
        Dim P As Object() = New Object(10) {}
        P(0) = "A"
        P(1) = oTitular.getMatricula()
        P(2) = oTitular.getEmpesa().getCodigo()
        P(3) = oTitular.getFechaContratacion()



        P(4) = oTitular.getCargo.getCorrelativo()
        P(5) = oTitular.getSalario()
        P(6) = oTitular.getTipoContratacion()

        If IsNothing(oTitular.getEmpesa().getProgramaProyecto()) Then
            P(7) = DBNull.Value
        Else
            P(7) = oTitular.getEmpesa().getProgramaProyecto().getCodigo()
        End If




        If IsNothing(oTitular.getEmpesa.getEntidadDesconcetrada()) Then
            P(8) = DBNull.Value
        Else
            P(8) = oTitular.getEmpesa().getEntidadDesconcetrada.getCodigo()
        End If

        P(9) = fechaPresentacion
        P(10) = Usuario.codUserLoggedSystem




        Dim respuesta As Int16 = objDAL.Ejecutar("SPguardarAvisoAfliliacion", P)
        Return respuesta
    End Function











    '[MODO EDITAR] ATRIBUTOS
    Public edListaTitulares As Titular()
    Public edOtitularSeleccionado As Titular



    '[MODO EDITAR] METODOS FUNCIONALES
    Public Sub edTraerTitulares(ByVal _matricula As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = edTraerTitularesBD(_matricula)
        edListaTitulares = New Titular(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim apPaterno, apMaterno, nombres, matricula

            If IsDBNull(row("APAT TIT")) Then apPaterno = "" Else apPaterno = row("APAT TIT").ToString()
            If IsDBNull(row("APMAT TIT")) Then apMaterno = "" Else apMaterno = row("APMAT TIT").ToString()
            If IsDBNull(row("NOM TIT")) Then nombres = "" Else nombres = row("NOM TIT").ToString()
            If IsDBNull(row("MAT TIT")) Then matricula = "" Else matricula = row("MAT TIT").ToString()

            Dim oTitular As Titular = New Titular()
            oTitular.setApellidoPaterno(apPaterno)
            oTitular.setApellidoMaterno(apMaterno)
            oTitular.setNombres(nombres)
            oTitular.setMatricula(matricula)
            edListaTitulares(index) = oTitular
            index += 1
        Next

    End Sub

    Public Sub edTraerDatosParaEditar(ByVal _matricula As String)
        Dim objDTable As DataTable
        objDTable = edTraerDatosParaEditarBD(_matricula)

        For Each row As DataRow In objDTable.Rows
            Dim codDatosPersonales As Int64
            Dim apPaterno, apMaterno, nombres, matricula, localidad, zona, calle, nroCasa, telefono, telefonoRef As String

            If IsDBNull(row("COD DPE")) Then codDatosPersonales = 0 Else codDatosPersonales = Int64.Parse(row("COD DPE"))
            If IsDBNull(row("APAT TIT")) Then apPaterno = "" Else apPaterno = row("APAT TIT").ToString()
            If IsDBNull(row("AMAT TIT")) Then apMaterno = "" Else apMaterno = row("AMAT TIT").ToString()
            If IsDBNull(row("NOM TIT")) Then nombres = "" Else nombres = row("NOM TIT").ToString()
            If IsDBNull(row("MAT TIT")) Then matricula = "" Else matricula = row("MAT TIT").ToString()
            If IsDBNull(row("LOC TIT")) Then localidad = "" Else localidad = row("LOC TIT").ToString()
            If IsDBNull(row("ZON TIT")) Then zona = "" Else zona = row("ZON TIT").ToString()
            If IsDBNull(row("CAL TIT")) Then calle = "" Else calle = row("CAL TIT").ToString()
            If IsDBNull(row("NRO CA TIT")) Then nroCasa = "" Else nroCasa = row("NRO CA TIT").ToString()
            If IsDBNull(row("TEL TIT")) Then telefono = "" Else telefono = row("TEL TIT").ToString()
            If IsDBNull(row("TEL REF TIT")) Then telefonoRef = "" Else telefonoRef = row("TEL REF TIT").ToString()

            oTitular.setDatosPersonales(New DatosPersonales())
            oTitular.getDatosPersonales().setCodigo(codDatosPersonales)
            oTitular.setApellidoPaterno(apPaterno)
            oTitular.setApellidoMaterno(apMaterno)
            oTitular.setNombres(nombres)
            oTitular.setMatricula(matricula)
            oTitular.setLocalidad(localidad)
            oTitular.setZona(zona)
            oTitular.setCalle(calle)
            oTitular.setNroCasa(nroCasa)
            oTitular.setTelefono(telefono)
            oTitular.setTelefonoReferencia(telefonoRef)

            edOtitularSeleccionado = oTitular
        Next
    End Sub

    Public Function edActualizarDatos(ByVal _nombreForm As String) As Int16
        Dim respuesta As Int16 = edActualizarDatosBD(_nombreForm)
        Return respuesta
    End Function




    '[MODO EDITAR] METODOS VALIDACIÓN
    Public Function edValidarEntradas() As String
        Dim mensaje As String = ""

        'cg1
        mensaje = validarZona(oTitular.getZona())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarCalle(oTitular.getCalle())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarNroCasa(oTitular.getNroCasa())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarTelefono(oTitular.getTelefono())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarTelefonoReferencia(oTitular.getTelefonoReferencia())
        If Not mensaje = "" Then
            Return mensaje
        End If

        Return ""
    End Function




    '[MODO EDITAR] METODOS BD
    Private Function edTraerTitularesBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerTitulares", P)
    End Function

    Private Function edTraerDatosParaEditarBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerDatosParaEditar", P)
    End Function

    Private Function edActualizarDatosBD(ByVal _nombreForm As String)
        Dim P As Object() = New Object(9) {}

        P(0) = oTitular.getMatricula()
        P(1) = oTitular.getDatosPersonales.getCodigo()
        P(2) = _nombreForm
        P(3) = Usuario.codUserLoggedSystem
        P(4) = oTitular.getTelefono()

        If String.IsNullOrEmpty(oTitular.getTelefonoReferencia()) Then P(5) = DBNull.Value Else P(5) = oTitular.getTelefonoReferencia()
        P(6) = oTitular.getZona()
        P(7) = oTitular.getCalle()
        P(8) = oTitular.getNroCasa()
        If String.IsNullOrEmpty(oTitular.getLocalidad()) Then P(9) = DBNull.Value Else P(9) = oTitular.getLocalidad()


        Return objDAL.Ejecutar("SPactualizarDatosPersonalesTitular", P)
    End Function



End Class
