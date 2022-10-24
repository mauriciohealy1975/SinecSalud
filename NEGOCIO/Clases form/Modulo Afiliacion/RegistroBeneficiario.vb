Imports DAL

Public Class RegistroBeneficiario
    Private objDAL As TDatosSql
    Public modoFormulario As Int16
    Public parentescos As Concepto()
    Public titulares As Titular()
    Public tiposDeDocumento As Concepto()
    Public lugaresExpedicion As Concepto()
    Public beneficiariosYaRegistrados As ListaEnlazadaBeneficiarios
    Public nuevosBeneficiarios As ListaEnlazadaBeneficiarios
    Public hijosMenoresUnAño As ListaEnlazadaBeneficiarios
    Public nuevosBenficiariosAuxiliar As ListaEnlazadaBeneficiarios
    Public avisosAsigFamiliares As AvisoAsignacionesFamiliares()

    Public Sub New()
        objDAL = New TDatosSql(False)
        beneficiariosYaRegistrados = New ListaEnlazadaBeneficiarios()
        nuevosBeneficiarios = New ListaEnlazadaBeneficiarios()
        hijosMenoresUnAño = New ListaEnlazadaBeneficiarios()
        nuevosBenficiariosAuxiliar = New ListaEnlazadaBeneficiarios()
        avisosAsigFamiliares = New AvisoAsignacionesFamiliares() {}
        modoFormulario = 1
    End Sub




    'METODOS FUNCIONALES
    Public Sub traerTitulares(ByVal _matricula As String)
        Dim objDTable As DataTable = traerTitularesBD(_matricula), index As Int16 = 0
        titulares = New Titular(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim apPaterno As String, apMaterno As String, nombres As String, matricula As String, fechaAfiliacion As Date,
                codEmpresa As Int64, codPro As Int64



            If IsDBNull(row("APA TIT")) Then apPaterno = "" Else apPaterno = row("APA TIT").ToString()
            If IsDBNull(row("AMA TIT")) Then apMaterno = "" Else apMaterno = row("AMA TIT").ToString()
            If IsDBNull(row("NOM TIT")) Then nombres = "" Else nombres = row("NOM TIT").ToString()
            If IsDBNull(row("MAT TIT")) Then matricula = "" Else matricula = row("MAT TIT").ToString()
            If IsDBNull(row("FEAFI TIT")) Then fechaAfiliacion = "" Else fechaAfiliacion = Date.Parse(row("FEAFI TIT"))
            If IsDBNull(row("COD EMP")) Then codEmpresa = 0 Else codEmpresa = Int64.Parse(row("COD EMP"))
            If IsDBNull(row("CODPRO TIT")) Then codPro = 0 Else codPro = Int64.Parse(row("CODPRO TIT"))
            'If IsDBNull(row("")) Then = 0 Else  = int64.Parse(row(""))

            Dim empresa As Empresa = New Empresa()
            empresa.setCodigo(codEmpresa)

            Dim programaproyecto As ProgramaProyecto = New ProgramaProyecto()
            programaproyecto.setCodigo(codPro)

            Dim titular As Titular = New Titular()
            titular.setApellidoPaterno(apPaterno)
            titular.setApellidoMaterno(apMaterno)
            titular.setNombres(nombres)
            titular.setMatricula(matricula)
            titular.setFechaAfiliacion(fechaAfiliacion)
            titular.setEmpresa(empresa)
            titular.setProgramaProyecto(programaproyecto)

            titulares(index) = titular
            index += 1
        Next
    End Sub

    Public Sub traerBeneficiarios(ByVal _matriculaTitular As String)
        Dim objDTable As DataTable = traerBeneficiariosBD(_matriculaTitular)

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, matricula As String, apPaterno As String, apMaterno As String, nombres As String,
                matriTitular As String

            If IsDBNull(row("COD BEN")) Then codigo = 0 Else codigo = Int64.Parse(row("COD BEN"))
            If IsDBNull(row("MAT BEN")) Then matricula = "" Else matricula = row("MAT BEN").ToString()
            If IsDBNull(row("APA BEN")) Then apPaterno = "" Else apPaterno = row("APA BEN").ToString()
            If IsDBNull(row("AMAT BEN")) Then apMaterno = "" Else apMaterno = row("AMAT BEN").ToString()
            If IsDBNull(row("NOM BEN")) Then nombres = "" Else nombres = row("NOM BEN").ToString()
            If IsDBNull(row("MAT TIT")) Then matriTitular = "" Else matriTitular = row("MAT TIT").ToString()


            Dim beneficario As Beneficiario = New Beneficiario()
            beneficario.setCodigo(codigo)
            beneficario.setMatricula(matricula)
            beneficario.setApellidoPaterno(apPaterno)
            beneficario.setApellidoMaterno(apMaterno)
            beneficario.setNombres(nombres)
            beneficario.setMatTitular(matriTitular)

            adicionarEnListaBeneficiariosYaRegistrados(beneficario)
        Next
    End Sub

    Public Sub adicionarEnListaBeneficiariosYaRegistrados(ByRef _beneficiario As Beneficiario)
        beneficiariosYaRegistrados.agregarNodo(_beneficiario)
    End Sub

    Public Sub adicionarNuevoBeneficiario(ByRef _beneficiario As Beneficiario)
        nuevosBeneficiarios.agregarNodo(_beneficiario)
    End Sub

    Public Function generarNuevaMatricula(ByVal _matriculaTitular As String) As String
        Dim matriculaAux As String
        Dim nroBeneficiariosAntiguos As Int16 = beneficiariosYaRegistrados.encontrarDimension()
        Dim nroBeneficiariosNuevos As Int16 = nuevosBeneficiarios.encontrarDimension()
        Dim nroTotalBeneficiarios As Int16 = nroBeneficiariosAntiguos + nroBeneficiariosNuevos

        Dim nuevoIndice As Int16 = nroTotalBeneficiarios + 1

        If nroTotalBeneficiarios >= 1 Then

            If nuevoIndice < 10 Then
                matriculaAux = _matriculaTitular.Remove(_matriculaTitular.Length - 1) + nuevoIndice.ToString()
            Else
                matriculaAux = _matriculaTitular.Remove(_matriculaTitular.Length - 2) + nuevoIndice.ToString()
            End If

        Else
            matriculaAux = _matriculaTitular.Remove(_matriculaTitular.Length - 1) + 1.ToString()
        End If

        Return matriculaAux
    End Function

    Public Sub traerParentesco()
        Dim objDTable As DataTable = traerParentescoBD()
        parentescos = New Concepto(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            Dim parentesco As Concepto = New Concepto(prefijo, correlativo, descripcion)
            parentescos(index) = parentesco
            index += 1
        Next
    End Sub

    Public Sub traerTipoDocumento()
        Dim objDTable As DataTable = traerTipoDocumentoBD()
        tiposDeDocumento = New Concepto(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            tiposDeDocumento(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Sub traerLugarExpedicion()
        Dim objDTable As DataTable = traerLugarExpedicionBD()
        lugaresExpedicion = New Concepto(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            lugaresExpedicion(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub



    'METODOS FUNCIONALES G4
    Public Sub eliminarBenficiario(ByVal _matricula As String)
        copiarBeneficiariosListaAuxiliar()           'bien
        nuevosBeneficiarios.vaciarLista()                 'bien
        eliminarBeneficiarioDeBeneficiariosAuxiliar(_matricula) 'bien

        copiarBeneficiariosConNuevasMatriculas()
        nuevosBenficiariosAuxiliar.vaciarLista()


        nuevosBenficiariosAuxiliar.vaciarLista() 'bien
    End Sub

    Private Sub copiarBeneficiariosListaAuxiliar()
        Dim nodoActual As NodoBeneficiario = nuevosBeneficiarios.raiz

        While nodoActual IsNot Nothing
            Dim bnf As Beneficiario = nodoActual.beneficiario
            nuevosBenficiariosAuxiliar.agregarNodo(bnf)

            nodoActual = nodoActual.siguiente
        End While
    End Sub

    Private Sub eliminarBeneficiarioDeBeneficiariosAuxiliar(ByVal _matricula As String)
        nuevosBenficiariosAuxiliar.eliminarNodo(_matricula)
    End Sub

    Private Sub copiarBeneficiariosConNuevasMatriculas()
        Dim nodo As NodoBeneficiario = nuevosBenficiariosAuxiliar.raiz

        While nodo IsNot Nothing
            Dim bnf As Beneficiario = nodo.beneficiario
            Dim nuevaMatricula As String = generarNuevaMatricula(bnf.getMatriculaTitular())
            bnf.setMatricula(nuevaMatricula)
            nuevosBeneficiarios.agregarNodo(bnf)


            nodo = nodo.siguiente
        End While
    End Sub



    'METODOS FUNCIONALES G5
    Private Function generarNroFormulario() As Int64
        Dim objDTable As DataTable = generarNroFormularioBD()
        Dim nroFormulario As Int64 = 0

        For Each row As DataRow In objDTable.Rows
            If IsDBNull(row("CODFO BEN")) Then nroFormulario = 0 Else nroFormulario = Int64.Parse(row("CODFO BEN"))
        Next

        Return nroFormulario
    End Function

    Public Sub asignarNroFormulario(ByRef _listaBeneficiarios As ListaEnlazadaBeneficiarios)
        Dim nroFormulario As Int64 = generarNroFormulario()
        Dim nodoActual As NodoBeneficiario = _listaBeneficiarios.raiz

        While nodoActual IsNot Nothing
            Dim beneficiario As Beneficiario = nodoActual.beneficiario
            beneficiario.setNroFormulario(nroFormulario)

            nodoActual = nodoActual.siguiente
        End While
    End Sub

    Public Sub corregirParentescoHijos()
        Dim nodoActual As NodoBeneficiario = nuevosBeneficiarios.raiz
        Dim parentescoHijo As Int16 = 2

        While nodoActual IsNot Nothing
            Dim parentesco As Concepto = nodoActual.beneficiario.getParentesco()
            If parentesco.getCorrelativo() = 3 Then parentesco.setCorrelativo(parentescoHijo)

            nodoActual = nodoActual.siguiente
        End While
    End Sub

    Public Sub copiarHijosMenoresUnAñoEnListaPropia()
        hijosMenoresUnAño = copiarRecursivo(nuevosBeneficiarios.raiz, hijosMenoresUnAño)
    End Sub

    Private Function copiarRecursivo(ByRef _nodo As NodoBeneficiario, ByRef _hijosMenores As ListaEnlazadaBeneficiarios) As ListaEnlazadaBeneficiarios

        If IsNothing(_nodo) Then
            Return _hijosMenores

        Else
            Dim bnf As Beneficiario = _nodo.beneficiario
            Dim edad As Int16 = Utilitarios.calcularEdad(bnf.getFechaNacimiento())
            Dim parentesco As Int16 = bnf.getParentesco().getCorrelativo()

            If edad = 0 And parentesco = 2 Then
                _hijosMenores.agregarNodo(bnf)
                _hijosMenores = copiarRecursivo(_nodo.siguiente, _hijosMenores)
            Else
                _hijosMenores = copiarRecursivo(_nodo.siguiente, _hijosMenores)
            End If

            Return _hijosMenores
        End If


    End Function

    Public Sub eliminarHijosMenoresUnAñoListaPrincipal()
        Dim nodo As NodoBeneficiario = nuevosBeneficiarios.raiz

        While nodo IsNot Nothing
            Dim bnfActual As Beneficiario = nodo.beneficiario

            Dim parentesco As Int16 = bnfActual.getParentesco().getCorrelativo()
            Dim edad As Int16 = Utilitarios.calcularEdad(bnfActual.getFechaNacimiento)
            Dim matricula As String = bnfActual.getMatricula()

            If edad = 0 And parentesco = 2 Then
                nuevosBeneficiarios.eliminarNodo(matricula)
            End If

            nodo = nodo.siguiente
        End While
    End Sub

    Public Function insertarNuevosBeneficiarios() As Int16
        Dim nodoActual As NodoBeneficiario = nuevosBeneficiarios.raiz,
            respuesta As Int16 = 0

        While nodoActual IsNot Nothing
            respuesta = insertarBeneficiarioBD(nodoActual.beneficiario)
            nodoActual = nodoActual.siguiente
        End While

        Return respuesta
    End Function

    Public Function insertarNuevosBeneficiariosMenores() As Int16
        Dim nodoActual As NodoBeneficiario = hijosMenoresUnAño.raiz,
       respuesta As Int16 = 0

        While nodoActual IsNot Nothing
            Dim nroFormulario As Int64 = generarNroFormulario()
            nodoActual.beneficiario.setNroFormulario(nroFormulario)
            respuesta = insertarBeneficiarioBD(nodoActual.beneficiario)

            nodoActual = nodoActual.siguiente
        End While

        Return respuesta
    End Function

    Public Sub generarAvisosAsignacionesFamiliares()
        Dim dimension As Int16 = hijosMenoresUnAño.encontrarDimension()
        avisosAsigFamiliares = New AvisoAsignacionesFamiliares(dimension - 1) {}


        Dim nodoActual As NodoBeneficiario = hijosMenoresUnAño.raiz, index As Int16 = 0
        While nodoActual IsNot Nothing
            Dim bnfActual As Beneficiario = nodoActual.beneficiario
            Dim titActual As Titular = bnfActual.getTitular()
            Dim empresaActual As Empresa = titActual.getEmpesa()
            Dim progproyActual As ProgramaProyecto = titActual.getProgramaProyecto()
            Dim fecNacBe As Date = bnfActual.getFechaNacimiento()
            Dim fecAfiliacionTi As Date = titActual.getFechaAfiliacion()
            Dim correspondeNatalidad As Boolean = revisarCorrespondeNatalidad(fecNacBe, fecAfiliacionTi)
            Dim fechaAsignacion As Date = Today.Date
            Dim natalidad As Int16
            If correspondeNatalidad Then natalidad = 1 Else natalidad = 0
            Dim lactancia As Int16 = 1
            Dim fechaFin As Date = fecNacBe.AddYears(1)
            Dim estado As Concepto = New Concepto(0, 1, "")


            Dim aviso As AvisoAsignacionesFamiliares = New AvisoAsignacionesFamiliares()
            aviso.setBeneficiario(bnfActual)
            aviso.setTitular(titActual)
            aviso.setEmpresa(empresaActual)
            aviso.setProgramaProyecto(progproyActual)
            aviso.setFechaAsignacion(fechaAsignacion)
            aviso.setNatalidad(natalidad)
            aviso.setLactancia(lactancia)
            aviso.setFechaFinAsignacion(fechaFin)
            aviso.setEstado(estado)

            avisosAsigFamiliares(index) = aviso
            index += 1
            nodoActual = nodoActual.siguiente
        End While

    End Sub

    Private Function revisarCorrespondeNatalidad(ByVal _fechaNacimientoBeneficiario As Date, ByVal _fechaAfiliacionTitular As Date) As Boolean
        If _fechaNacimientoBeneficiario.Date > _fechaAfiliacionTitular.Date Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function isnertarAvisosAsignacionesFamiliares()
        Dim dimension As Int16 = avisosAsigFamiliares.Count()
        Dim respuesta As Int16 = 0

        For index = 0 To dimension - 1
            Dim aviso As AvisoAsignacionesFamiliares = avisosAsigFamiliares(index)
            respuesta = insertarAvisosAsignacionesFamiliaresBD(aviso)
        Next

        Return respuesta
    End Function





    'METODOS BD 1
    Private Function traerTitularesBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerTitulares_RegistrarBeneficiario", P)
    End Function

    Private Function traerBeneficiariosBD(ByVal _matriculaTitular As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matriculaTitular
        Return objDAL.TraerDataTable("SPtraerBeneficiarios_RegistrarBeneficiario", P)
    End Function

    Private Function traerParentescoBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerParentesco_Concepto")
    End Function

    Private Function traerTipoDocumentoBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerTipoDocumento_Concepto")
    End Function

    Private Function traerLugarExpedicionBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerLugarExpedicion_Concepto")
    End Function



    'METODOS BD G5
    Private Function generarNroFormularioBD() As DataTable
        Return objDAL.TraerDataTable("SPgenerarNroFormulario_RegBeneficiarios")
    End Function

    'METODOS BD G5
    Private Function insertarBeneficiarioBD(ByVal _beneficiario As Beneficiario) As Int16
        Dim P As Object() = New Object(18) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _beneficiario.getTipoDocumento().getCorrelativo()
        P(2) = _beneficiario.getNroDocumento()
        If String.IsNullOrEmpty(_beneficiario.getComplemento()) Then P(3) = DBNull.Value Else P(3) = _beneficiario.getComplemento()
        P(4) = _beneficiario.getApellidoPaterno()


        If String.IsNullOrEmpty(_beneficiario.getApellidoMaterno()) Then P(5) = DBNull.Value Else P(5) = _beneficiario.getApellidoMaterno()
        P(6) = _beneficiario.getNombres()
        P(7) = _beneficiario.getSexo()
        P(8) = _beneficiario.getMatricula()
        P(9) = _beneficiario.getFechaNacimiento()
        If String.IsNullOrEmpty(_beneficiario.getNroOficialia()) Then P(10) = DBNull.Value Else P(10) = _beneficiario.getNroOficialia()


        If String.IsNullOrEmpty(_beneficiario.getNroLibro()) Then P(11) = DBNull.Value Else P(11) = _beneficiario.getNroLibro()
        If String.IsNullOrEmpty(_beneficiario.getNroPartida()) Then P(12) = DBNull.Value Else P(12) = _beneficiario.getNroPartida()
        If String.IsNullOrEmpty(_beneficiario.getNroFolio()) Then P(13) = DBNull.Value Else P(13) = _beneficiario.getNroFolio()
        If String.IsNullOrEmpty(_beneficiario.getNroDeclaracionJurada()) Then P(14) = DBNull.Value Else P(14) = _beneficiario.getNroDeclaracionJurada()
        If String.IsNullOrEmpty(_beneficiario.getNroNotaria()) Then P(15) = DBNull.Value Else P(15) = _beneficiario.getNroNotaria()


        P(16) = _beneficiario.getParentesco().getCorrelativo()
        P(17) = _beneficiario.getTitular().getMatricula()
        P(18) = _beneficiario.getNroFormulario()


        Dim respuesta As Int16 = objDAL.Ejecutar("SPregistrarBeneficioario", P)
        Return respuesta
    End Function

    Public Function insertarAvisosAsignacionesFamiliaresBD(ByRef _avisoAsigFam As AvisoAsignacionesFamiliares) As Int16
        Dim P As Object() = New Object(11) {}
        Dim beneficiario As Beneficiario = _avisoAsigFam.getBeneficiario()
        Dim titular As Titular = _avisoAsigFam.getTitular()
        Dim empresa As Empresa = _avisoAsigFam.getEmpresa()
        Dim progproy As ProgramaProyecto = _avisoAsigFam.getProgramaProyecto()

        P(0) = Usuario.codUserLoggedSystem
        P(1) = beneficiario.getMatricula()
        P(2) = beneficiario.getSexo()
        P(3) = beneficiario.getFechaNacimiento()

        P(4) = titular.getMatricula()
        P(5) = empresa.getCodigo()
        If progproy.getCodigo() = 0 Then P(6) = DBNull.Value Else P(6) = progproy.getCodigo()

        P(7) = _avisoAsigFam.getFechaAsignacion()
        P(8) = _avisoAsigFam.getNatalidad()
        P(9) = _avisoAsigFam.getLactancia()
        P(10) = _avisoAsigFam.getFechaFinAsignacion()
        P(11) = _avisoAsigFam.getEstado().getCorrelativo()

        Dim respuesta As Int16 = objDAL.Ejecutar("SPguardarAvisoAsignacionesFamiliares_RegBeneficiario", P)
        Return respuesta
    End Function









    'METODOS VALIDACIÓN
    Public Function validarEntradas(ByRef _beneficiario As Beneficiario, ByVal _tipoPanelDetalle As Int16) As String
        Dim mensaje As String

        mensaje = validarParentezco(_beneficiario.getParentesco())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarApellidoPaterno(_beneficiario.getApellidoPaterno())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarNombres(_beneficiario.getNombres)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarMatriula(_beneficiario.getMatricula())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarSexo(_beneficiario.getSexo())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarFechaNacimiento(_beneficiario.getFechaNacimiento())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarTipoDocumento(_beneficiario.getTipoDocumento())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarNroDocumento(_beneficiario.getNroDocumento())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarLugarExpedicion(_beneficiario.getLugarExpedicion())
        If Not mensaje = "" Then Return mensaje


        If _tipoPanelDetalle = 1 Then
            mensaje = validarNroOficialia(_beneficiario.getNroOficialia())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarNroLibro(_beneficiario.getNroLibro())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarNroPartida(_beneficiario.getNroPartida())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarNroFolio(_beneficiario.getNroFolio())
            If Not mensaje = "" Then Return mensaje

        ElseIf _tipoPanelDetalle = 2 Then
            mensaje = validarNroDeclaracionJurada(_beneficiario.getNroDeclaracionJurada())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarNroNotaria(_beneficiario.getNroNotaria())
            If Not mensaje = "" Then Return mensaje
        End If


        Return ""
    End Function

    Private Function validarParentezco(ByRef _parentezco As Concepto) As String
        If _parentezco Is Nothing Then Return "Error. Seleccione un parentezco." Else Return ""
    End Function

    Private Function validarApellidoPaterno(ByVal _apPaterno As String) As String
        If String.IsNullOrEmpty(_apPaterno) Then Return "Error. Ingrese el apellido paterno." Else Return ""
    End Function

    Private Function validarNombres(ByVal _nombres As String) As String
        If String.IsNullOrEmpty(_nombres) Then Return "Error. Ingrese el nombre." Else Return ""
    End Function

    Private Function validarMatriula(ByVal _matricula As String) As String
        If String.IsNullOrEmpty(_matricula) Then Return "Error. Ingrese la matrícula." Else Return ""
    End Function

    Private Function validarSexo(ByVal _sexo As String) As String
        If Not _sexo = "M" And Not _sexo = "F" Then Return "Error. Seleccione el sexo." Else Return ""

    End Function

    Private Function validarFechaNacimiento(ByVal _fechaNacimiento As Date) As String
        If _fechaNacimiento.Date > Date.Today.Date Then
            Return "Error. La fecha de nacimiento no puede ser mayor a la fecha actual."

        Else
            Return ""
        End If
    End Function

    Private Function validarTipoDocumento(ByRef _tipoDocumento As Concepto)
        If _tipoDocumento Is Nothing Then Return "Error. Seleccione un tipo de documento." Else Return ""
    End Function

    Private Function validarNroDocumento(ByVal _nroDocumento As String)
        If String.IsNullOrEmpty(_nroDocumento) Then Return "Error. Ingrese el nro de documento."
        If _nroDocumento.Length < 7 Then Return "Error. El nro. de documento no puede ser menor de 7 caracteres."
        Return ""
    End Function

    Private Function validarLugarExpedicion(ByRef _lugarExpedicion As Concepto)
        If _lugarExpedicion Is Nothing Then Return "Error. Seleccione el lugar de expedición." Else Return ""
    End Function

    Private Function validarNroOficialia(ByVal _oficilia As String)
        If String.IsNullOrEmpty(_oficilia) Then Return "Error. Ingrese el nro de oficialía." Else Return ""
    End Function

    Private Function validarNroLibro(ByVal _nroLibro As String)
        If String.IsNullOrEmpty(_nroLibro) Then Return "Error. Ingrese el nro de libro." Else Return ""
    End Function

    Private Function validarNroPartida(ByVal _nroPartida As String)
        If String.IsNullOrEmpty(_nroPartida) Then Return "Error. Ingrese el nro de partida." Else Return ""
    End Function

    Private Function validarNroFolio(ByVal _nroFolio As String)
        If String.IsNullOrEmpty(_nroFolio) Then Return "Error. Ingrese el nro de folio." Else Return ""
    End Function

    Private Function validarNroDeclaracionJurada(ByVal _declaracionJurada As String)
        If String.IsNullOrEmpty(_declaracionJurada) Then Return "Error. Ingrese el nro de declaración jurada." Else Return ""
    End Function

    Private Function validarNroNotaria(ByVal _nroNotaria As String)
        If String.IsNullOrEmpty(_nroNotaria) Then Return "Error. Ingrese el nro de notaría." Else Return ""
    End Function

    Public Function validarListaVacia() As String
        If nuevosBeneficiarios.raiz Is Nothing Then Return "Error. Adicione al menos un beneficiario a la lista." Else Return ""
    End Function























    '[MODO ELIMINAR] ATRIBUTOS
    Public elBeneficiarios As Beneficiario()
    Public elMotivosBaja As Concepto()
    Public elBeneficiarioParaEliminar As Beneficiario

    '[MODO ELIMINAR] METODOS FUNCIONALES
    Public Sub elTraerBeneficiarios(ByVal _matriculaBeneficiario As String)
        Dim objDTable As DataTable = elTraerBeneficiariosBD(_matriculaBeneficiario), index As Int16 = 0
        elBeneficiarios = New Beneficiario(objDTable.Rows.Count - 1) {}


        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, matricula As String, apPaterno As String, apMaterno As String, nombres As String, sexo As Char, fnacimiento As Date,
                matriTitular As String

            If IsDBNull(row("COD BEN")) Then codigo = 0 Else codigo = Int64.Parse(row("COD BEN"))
            If IsDBNull(row("MAT BEN")) Then matricula = "" Else matricula = row("MAT BEN").ToString()
            If IsDBNull(row("APA BEN")) Then apPaterno = "" Else apPaterno = row("APA BEN").ToString()
            If IsDBNull(row("AMAT BEN")) Then apMaterno = "" Else apMaterno = row("AMAT BEN").ToString()
            If IsDBNull(row("NOM BEN")) Then nombres = "" Else nombres = row("NOM BEN").ToString()
            If IsDBNull(row("SEXO BEN")) Then sexo = "" Else sexo = row("SEXO BEN").ToString()
            If IsDBNull(row("FNAC BEN")) Then fnacimiento = "" Else fnacimiento = row("FNAC BEN").ToString()
            If IsDBNull(row("MAT TIT")) Then matriTitular = "" Else matriTitular = row("MAT TIT").ToString()


            Dim beneficario As Beneficiario = New Beneficiario()
            beneficario.setCodigo(codigo)
            beneficario.setMatricula(matricula)
            beneficario.setApellidoPaterno(apPaterno)
            beneficario.setApellidoMaterno(apMaterno)
            beneficario.setNombres(nombres)
            beneficario.setSexo(sexo)
            beneficario.setFechaNacimiento(fnacimiento)
            beneficario.setMatTitular(matriTitular)

            elBeneficiarios(index) = beneficario
            index += 1
        Next
    End Sub

    Public Sub elTraerMotivoBaja()
        Dim objDTable As DataTable = elTraerMotivoBajaBD()
        elMotivosBaja = New Concepto(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            elMotivosBaja(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Function elEliminarBeneficiario(ByVal _nombreForm As String) As Int16
        Dim respuesta As Int16 = elEliminarBeneficiarioBD(_nombreForm)
        Return respuesta
    End Function


    '[MODO ELIMINAR] METODOS BD
    Private Function elTraerBeneficiariosBD(ByVal _matriculaBeneficiario As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matriculaBeneficiario
        Return objDAL.TraerDataTable("SPTraerBeneficiarios_RegistrarBeneficiarioEL", P)
    End Function

    Private Function elTraerMotivoBajaBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerMotivoBajaBeneficiario_Concepto")
    End Function

    Private Function elEliminarBeneficiarioBD(ByVal _nombreForm As String) As Int16
        Dim P As Object() = New Object(3) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _nombreForm
        P(2) = elBeneficiarioParaEliminar.getMatricula()
        P(3) = elBeneficiarioParaEliminar.getMotivoBaja().getCorrelativo()

        Dim respuesta As Int16 = objDAL.Ejecutar("SPeliminarBeneficiario", P)
        Return respuesta
    End Function


    '[MODO ELIMINAR] METODOS VALIDACIÓN
    Public Function elValidarEntradas() As String
        Dim mensaje As String

        mensaje = elValidarBeneficiario(elBeneficiarioParaEliminar)
        If Not mensaje = "" Then Return mensaje


        mensaje = elValidarMotivoBaja(elBeneficiarioParaEliminar.getMotivoBaja())
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function elValidarBeneficiario(ByRef _beneficiario As Beneficiario) As String
        If _beneficiario Is Nothing Then Return "Error. Seleccione un beneficiario." Else Return ""

    End Function

    Private Function elValidarMotivoBaja(ByRef _motivo As Concepto) As String
        If _motivo Is Nothing Then Return "Error. Seleccione un motivo de baja" Else Return ""
    End Function








End Class
