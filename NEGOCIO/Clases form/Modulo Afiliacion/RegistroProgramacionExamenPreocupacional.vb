Imports DAL

Public Class RegistroProgramacionExamenPreocupacional

    'ATRIBUTOS LOGICOS
    Private objDAL As TDatosSql

    'AITRBUTOS G1
    Public titulares As Titular()
    Public empresas As Empresa()

    'ATRIBUTOS G2
    Public medicosLaborales As Medico()
    Private ofertaFichasLaborales As Int64
    Public fichasDisponibles As Int64
    Public fichasLaboralesOcupadas As Int16
    Public diasLimite As Parametro

    'ATRIBUTOS G3
    Public nuevaProgrExamen As ProgramacionExamenPreocupacional

    Public Sub New()
        objDAL = New TDatosSql(False)
        titulares = New Titular(0) {}
        empresas = New Empresa(0) {}
        medicosLaborales = New Medico(0) {}
        ofertaFichasLaborales = 0
        fichasDisponibles = 0
        fichasLaboralesOcupadas = 0
        diasLimite = New Parametro()
        nuevaProgrExamen = New ProgramacionExamenPreocupacional()
    End Sub









    'METODOS FUNCIONALES G1
    Public Sub traerTitulares(ByVal _matricula As String)
        Dim index As Int16 = 0, objDTable As DataTable = traerTitularesBD(_matricula)
        titulares = New Titular(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows

            'apPaterno As String, 
            'apMaterno As String,

            Dim codigo As Int64, nombres As String, matricula As String,
                sexo As Char, fecNac As Date, codEmpresa As Int64, nomEmpresa As String, ci As String,
                luExpedicion As String

            If IsDBNull(row("COD TIT")) Then codigo = 0 Else codigo = Int64.Parse(row("COD TIT"))
            'If IsDBNull(row("APA TIT")) Then apPaterno = "" Else apPaterno = row("APA TIT").ToString()
            'If IsDBNull(row("AMA TIT")) Then apMaterno = "" Else apMaterno = row("AMA TIT").ToString()
            If IsDBNull(row("NOM TIT")) Then nombres = "" Else nombres = row("NOM TIT").ToString()
            If IsDBNull(row("MAT TIT")) Then matricula = "" Else matricula = row("MAT TIT").ToString()


            If IsDBNull(row("SEXO TIT")) Then sexo = "" Else sexo = row("SEXO TIT").ToString()
            If IsDBNull(row("FENA TIT")) Then fecNac = "" Else fecNac = Date.Parse(row("FENA TIT"))


            If IsDBNull(row("COD EMP")) Then codEmpresa = 0 Else codEmpresa = Int64.Parse(row("COD EMP"))
            If IsDBNull(row("NOM EMP")) Then nomEmpresa = "" Else nomEmpresa = row("NOM EMP").ToString()
            If IsDBNull(row("NRODO TIT")) Then ci = "" Else ci = row("NRODO TIT").ToString()
            If IsDBNull(row("LEXDO TIT")) Then luExpedicion = "" Else luExpedicion = row("LEXDO TIT").ToString()



            'If IsDBNull(row("")) Then = "" Else = row("").ToString()
            'If IsDBNull(row("")) Then = "" Else = row("").ToString()
            'If IsDBNull(row("")) Then = "" Else = row("").ToString()


            Dim empresa As Empresa = New Empresa(codEmpresa, nomEmpresa)
            Dim lugarExpedicion As Concepto = New Concepto(0, 0, luExpedicion)
            Dim titular As Titular = New Titular()
            titular.setCodigo(codigo)
            'titular.setApellidoPaterno(apPaterno)
            'titular.setApellidoMaterno(apMaterno)
            titular.setNombres(nombres)
            titular.setMatricula(matricula)
            titular.setSexo(sexo)
            titular.setFechaNacimiento(fecNac)
            titular.setEmpresa(empresa)
            titular.setNroDocumento(ci)
            titular.setLugarExpedicion(lugarExpedicion)

            titulares(index) = titular
            index += 1
        Next

    End Sub

    Public Sub traerEmpresas(ByVal _nombreEmpresa As String)
        Dim index As Int16 = 0, objDTable As DataTable = traerEmpresasBD(_nombreEmpresa)
        empresas = New Empresa(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String

            If IsDBNull(row("COD EMP")) Then codigo = 0 Else codigo = Int64.Parse(row("COD EMP"))
            If IsDBNull(row("NOM EMP")) Then nombre = "" Else nombre = row("NOM EMP").ToString()

            empresas(index) = New Empresa(codigo, nombre)
            index += 1
        Next
    End Sub


    'METODOS FUNCIONALES G2
    Public Function actualizarFechaRayosX(ByVal _fechaLaboratorio As Date)
        Dim fechaRayosX As Date = _fechaLaboratorio
        Return fechaRayosX
    End Function

    Public Function actualizarFechaMedicoLaboral(ByVal _fechaLaboratorio As Date, ByVal _esDeProvincia As Boolean)
        Dim fechaAux As Date = _fechaLaboratorio
        Dim diasSumados As Int16 = 0
        While True
            fechaAux = fechaAux.AddDays(1)
            Dim esDiaLaboral As Boolean = Utilitarios.esDiaLaboral(fechaAux)
            If esDiaLaboral Then diasSumados += 1

            If _esDeProvincia And diasSumados = 1 Then Exit While
            If Not _esDeProvincia And diasSumados = 2 Then Exit While
        End While

        Dim fechaMedicoLaboral As Date = fechaAux
        Return fechaMedicoLaboral
    End Function

    Public Sub traerMedicosLaborales()
        Dim index As Int16 = 0, objDTable As DataTable = traerMedicosLaboralesBD()
        medicosLaborales = New Medico(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String, cantidadFichas As Int64

            If IsDBNull(row("COD MED")) Then codigo = 0 Else codigo = Int64.Parse(row("COD MED"))
            If IsDBNull(row("NOM MED")) Then nombre = "" Else nombre = row("NOM MED").ToString()
            If IsDBNull(row("CAN FIC")) Then cantidadFichas = 0 Else cantidadFichas = Int64.Parse(row("CAN FIC"))

            Dim turno As Turno = New Turno()
            turno.setCodigo(0)
            turno.setCantidadFichas(cantidadFichas)

            Dim medico As Medico = New Medico()
            medico.setCodigo(codigo)
            medico.setTurno(turno)
            medicosLaborales(index) = medico

            index += 1
        Next
    End Sub

    Public Sub calcularOfertaTotalFichasLaborales()
        Dim totalFichas As Int64 = 0

        For Each medico In medicosLaborales
            Dim turnoActual As Turno = medico.getTurno()
            totalFichas += turnoActual.getCantidadFichas()
        Next

        ofertaFichasLaborales = totalFichas
    End Sub

    Public Sub traerFichasLaboralesOcupadas(ByVal _fechaSeleccionada As Date)
        Dim objDTable As DataTable = traerFichasLaboralresOcupadasBD(_fechaSeleccionada)

        For Each row As DataRow In objDTable.Rows
            If IsDBNull(row("FICHAS OCUPADAS")) Then fichasLaboralesOcupadas = 0 Else fichasLaboralesOcupadas = Int16.Parse(row("FICHAS OCUPADAS"))
        Next
    End Sub

    Public Sub cargarFichasDisponiblesMedicoLaboral(ByVal _fecha As Date)
        traerMedicosLaborales()
        calcularOfertaTotalFichasLaborales()
        traerFichasLaboralesOcupadas(_fecha)

        fichasDisponibles = ofertaFichasLaborales - fichasLaboralesOcupadas
        If fichasDisponibles < 0 Then fichasDisponibles = 0
    End Sub

    Public Sub traerParametrosRangoDiasLaboral()
        Dim index As Int16 = 0, objDTable As DataTable = traerParametroDiasBD()

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, tipo As Int16, parametroValor As Int64, parametroRangoInicio As Int64,
                parametroRangoFinal As Int64, descripcion As String

            If IsDBNull(row("COD PA")) Then codigo = 0 Else codigo = Int64.Parse(row("COD PA"))
            If IsDBNull(row("TI PA")) Then tipo = 0 Else tipo = Int16.Parse(row("TI PA"))
            If IsDBNull(row("PVA PA")) Then parametroValor = 0 Else parametroValor = Int64.Parse(row("PVA PA"))
            If IsDBNull(row("RINI PA")) Then parametroRangoInicio = 0 Else parametroRangoInicio = Int64.Parse(row("RINI PA"))
            If IsDBNull(row("RFIN PA")) Then parametroRangoFinal = 0 Else parametroRangoFinal = Int64.Parse(row("RFIN PA"))
            If IsDBNull(row("DES PA")) Then descripcion = "" Else descripcion = row("DES PA").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            diasLimite = New Parametro()
            diasLimite.setCodigo(codigo)
            diasLimite.setTipo(tipo)
            diasLimite.setValor(parametroValor)
            diasLimite.setRangoInicial(parametroRangoInicio)
            diasLimite.setRangoFinal(parametroRangoFinal)
            diasLimite.setDescripcion(descripcion)
        Next
    End Sub

    Public Function revisarEsDiaLaboral(ByVal _fecha As Date)
        Dim dia As Int16 = _fecha.DayOfWeek

        If Not dia = DayOfWeek.Saturday And Not dia = DayOfWeek.Sunday Then
            Return True
        Else
            Return False
        End If
    End Function


    'METODOS FUNCIONALES G3
    Public Function insertarProgramacion() As Int16
        Dim respueta As Int16 = insertarProgramacionBD()
        Return respueta
    End Function






    'METODOS BD G1
    Private Function traerTitularesBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerTitulares_RegProgExamenPreocupacional", P)
    End Function

    Private Function traerEmpresasBD(ByVal _nombreEmpresa As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombreEmpresa
        Return objDAL.TraerDataTable("SPtraerEmpresas_RegProgExamenPreocupacional", P)
    End Function


    'METODOS BD G2
    Private Function traerMedicosLaboralesBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerMedLaborales_RegProgExamenPreocupacional")
    End Function

    Private Function traerFichasLaboralresOcupadasBD(ByVal _fecha As Date) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _fecha
        Return objDAL.TraerDataTable("SPtraerFichasProgramadasMedLaboral_RegProgExamenPreocupacional", P)
    End Function

    Private Function traerParametroDiasBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerRangoDiasProgramacionEP_Parametro")
    End Function

    'METODOS BD G3
    Private Function insertarProgramacionBD() As Int16
        Dim titular As Titular = nuevaProgrExamen.getTitular()
        Dim lugarExpedicion As String = titular.getLugarExpedicion().getDescripcion()
        Dim esDeProvincia As Int16
        If nuevaProgrExamen.getEsDeProvincia() Then esDeProvincia = 1 Else esDeProvincia = 0


        Dim P As Object() = New Object(14) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = titular.getMatricula()
        P(2) = nuevaProgrExamen.getEmpresa().getCodigo()
        P(3) = nuevaProgrExamen.getFecha()
        P(4) = nuevaProgrExamen.getFechaLaboratorio()
        P(5) = nuevaProgrExamen.getFechaRayosX()
        P(6) = nuevaProgrExamen.getFechaMedicoLaboral()
        P(7) = nuevaProgrExamen.getEstadoCompletidud().getCorrelativo()
        P(8) = nuevaProgrExamen.getNroComprobantePago()
        P(9) = titular.getNombres()
        P(10) = titular.getSexo()
        P(11) = titular.getFechaNacimiento()

        If String.IsNullOrEmpty(titular.getNroDocumento()) Then P(12) = DBNull.Value Else P(12) = titular.getNroDocumento()
        If String.IsNullOrEmpty(lugarExpedicion) Then P(13) = DBNull.Value Else P(13) = lugarExpedicion
        P(14) = esDeProvincia

        Dim respuesta As Int16 = objDAL.Ejecutar("SPguardarProgramacion_RegProgExamenPreocipacional", P)
        Return respuesta
    End Function











    'METODOS VALIDACION
    Public Function validarEntradas(ByVal _esNuevoTitular As Boolean, ByVal _esNuevaEmpresa As Boolean) As String
        Dim mensaje As String = "", titular As Titular = nuevaProgrExamen.getTitular(), empresa As Empresa = nuevaProgrExamen.getEmpresa()


        If Not _esNuevoTitular Then
            mensaje = validarTitularSeleccionado(titular)
            If Not mensaje = "" Then Return mensaje

        Else
            mensaje = validarApellidoPaterno(titular.getApellidoPaterno())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarNombres(titular.getNombres())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarMatricula(titular.getMatricula())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarSexo(titular.getSexo())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarFechaNacimiento(titular.getFechaNacimiento())
            If Not mensaje = "" Then Return mensaje
        End If


        If _esNuevaEmpresa Then
            mensaje = validarEmpresaSeleccionada(empresa)
            If Not mensaje = "" Then Return mensaje
        End If

        mensaje = validarFechaLaboratorio(nuevaProgrExamen.getFechaLaboratorio())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarFechaRayosX(nuevaProgrExamen.getFechaRayosX())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarFechaMedicoLaboral(nuevaProgrExamen.getFechaMedicoLaboral())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarNroComprobantePago(nuevaProgrExamen.getNroComprobantePago())
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarTitularSeleccionado(ByRef _titular As Titular) As String
        If _titular.getCodigo() = 0 Then Return "Error. Seleccione el titular." Else Return ""
    End Function

    Private Function validarApellidoPaterno(ByVal _apellidoPaterno As String) As String
        If _apellidoPaterno = "" Then Return "Error. Ingrese el apellido paterno." Else Return ""
    End Function

    Private Function validarNombres(ByVal _nombres As String) As String
        If _nombres = "" Then Return "Error. Ingrese el nombre." Else Return ""
    End Function

    Private Function validarMatricula(ByVal _matricula As String) As String
        If _matricula = "" Then Return "Error. Ingrese la matricula."
        If _matricula.Length < 11 Then Return "Error. La matrícula no puede ser menor de 11 caracteres." Else Return ""
    End Function

    Private Function validarSexo(ByVal _sexo As Char) As String
        If Not _sexo = "M" And Not _sexo = "F" Then Return "Error. Seleccione un sexo." Else Return ""
    End Function

    Private Function validarFechaNacimiento(ByVal _fechaNacimiento As Date) As String
        Dim edad As Int16 = Utilitarios.calcularEdad(_fechaNacimiento)
        If edad < 18 Then Return "Error. No se puede registrar un titular menor de 18 años" Else Return ""
    End Function





    Private Function validarEmpresaSeleccionada(ByRef _empresa As Empresa) As String
        If _empresa.getCodigo() = 0 Then Return "Error. Seleccione una empresa." Else Return ""
    End Function

    Private Function validarFechaLaboratorio(ByVal _fecha As Date)
        Dim esDiaLaboral As Boolean = revisarEsDiaLaboral(_fecha)

        If Not esDiaLaboral Then Return "Error. La fecha de examen de laboratorio no puede en un día fin de semana. Seleccione otra fecha."
        If _fecha = Today.Date Then Return "Error. No se puede programar un Examen de Laboratorio con la fecha de hoy. Seleccione otra fecha." Else Return ""
    End Function

    Private Function validarFechaRayosX(ByVal _fecha As Date)
        Dim esDiaLaboral As Boolean = revisarEsDiaLaboral(_fecha)

        If Not esDiaLaboral Then Return "Error. La fecha de examen de Rayos x no puede ser en un día fin de semana. Seleccione otra fecha."
        If _fecha = Today.Date Then Return "Error. No se puede programar un Examen de Rayos X con la fecha de hoy. Seleccione otra fecha." Else Return ""
    End Function

    Private Function validarFechaMedicoLaboral(ByVal _fecha As Date)
        Dim esDiaLaboral As Boolean = revisarEsDiaLaboral(_fecha)
        If Not esDiaLaboral Then Return "Error. La fecha de examen de médico laboral no puede ser en un día fin de semana. Seleccione otra fecha."

        If _fecha = Today.Date Then Return "Error. No se puede programar un Examen de Medico laboral con la fecha de hoy. Seleccione otra fecha."

        If fichasDisponibles <= 0 Then Return "Error. La fecha " + _fecha + " no cuenta con fichas disponibles para médico laboral. Seleccione otra fecha."

        Dim esFechaMenor As Boolean = validarFechaEsMenorFechaLimite(_fecha)
        If Not esFechaMenor Then Return "Error. Las fichas para médico laboral sólo se pueden programar hasta " + diasLimite.getValor().ToString() + " días habiles en adelante. Seleccione una fecha menor."
        Return ""
    End Function

    Private Function validarFechaEsMenorFechaLimite(ByVal _fechaMedLaboral As Date) As Boolean
        Dim fechaLimite As Date
        Dim fechaAux As Date = Today.Date
        Dim diasHabilesSumados As Int16 = 0
        Dim limiteDiasHabilies As Int64 = diasLimite.getValor()

        While True
            fechaAux = fechaAux.AddDays(1)
            If revisarEsDiaLaboral(fechaAux) Then diasHabilesSumados += 1
            If diasHabilesSumados = limiteDiasHabilies Then Exit While
        End While

        fechaLimite = fechaAux
        If _fechaMedLaboral <= fechaLimite Then Return True Else Return False
    End Function

    Private Function validarNroComprobantePago(ByVal _nroComprobante As String) As String
        If _nroComprobante = "" Then Return "Error. Ingrese el nro de comprobante de pago." Else Return ""
    End Function

End Class

