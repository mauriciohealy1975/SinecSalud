Imports DAL
Public Class RegistroProcesoProgramcionExamenPreocupacional

    'ATRIBUTOS LÓGICOS
    Private objDAL As TDatosSql

    'ATRIBUTOS G1
    Public programaciones As ProgramacionExamenPreocupacional()
    Public estados As Concepto()

    'ATRIBUTOS G2
    Public diasPenalizacion As Int16

    'ATRIBUTOS G3
    Private medicosLaborales As Medico()
    Public fichasLaborales As Int64
    Public fichasOcupadas As Int64
    Public fichasDisponibles As Int64


    Public Sub New()
        objDAL = New TDatosSql(False)
        programaciones = New ProgramacionExamenPreocupacional(0) {}
        estados = New Concepto(0) {}
        diasPenalizacion = 3
        medicosLaborales = New Medico(0) {}
        fichasLaborales = 0
        fichasOcupadas = 0
        fichasDisponibles = 0
    End Sub



    'METODOS FUNCIONALES G1
    Public Sub traerProgramaciones(ByVal _fecha As Date)
        Dim objDTable As DataTable = traerProgramacionesBD(_fecha), index As Int16 = 0
        programaciones = New ProgramacionExamenPreocupacional(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, matricula As String, nomTitular As String, codEmpresa As Int64, nomEmpresa As String,
                fecha As Date, fecLab As Date, fecRayosX As Date, fecMedLaboral As Date, codEstado As Int16,
                descripcionEstado As String

            If IsDBNull(row("COD PROG")) Then codigo = 0 Else codigo = Int64.Parse(row("COD PROG"))
            If IsDBNull(row("MATI PROG")) Then matricula = "" Else matricula = row("MATI PROG").ToString()
            If IsDBNull(row("NOMTI PROG")) Then nomTitular = "" Else nomTitular = row("NOMTI PROG").ToString()
            If IsDBNull(row("COEM PROG")) Then codEmpresa = 0 Else codEmpresa = Int64.Parse(row("COEM PROG"))
            If IsDBNull(row("NOEM EMP")) Then nomEmpresa = "" Else nomEmpresa = row("NOEM EMP").ToString()
            If IsDBNull(row("FE PROG")) Then fecha = "" Else fecha = Date.Parse(row("FE PROG"))
            If IsDBNull(row("FELAB PROG")) Then fecLab = "" Else fecLab = Date.Parse(row("FELAB PROG"))
            If IsDBNull(row("FERX PROG")) Then fecRayosX = "" Else fecRayosX = Date.Parse(row("FERX PROG"))
            If IsDBNull(row("FEME PROG")) Then fecMedLaboral = "" Else fecMedLaboral = Date.Parse(row("FEME PROG"))
            If IsDBNull(row("ESCO PROG")) Then codEstado = "" Else codEstado = row("ESCO PROG").ToString()
            If IsDBNull(row("DEES CON")) Then descripcionEstado = "" Else descripcionEstado = row("DEES CON").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row(""c).ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))


            Dim titular As Titular = New Titular()
            titular.setMatricula(matricula)
            titular.setNombres(nomTitular)

            Dim empresa As Empresa = New Empresa()
            empresa.setCodigo(codEmpresa)
            empresa.setNombre(nomEmpresa)

            Dim estado As Concepto = New Concepto(0, codEstado, descripcionEstado)

            Dim programacion As ProgramacionExamenPreocupacional = New ProgramacionExamenPreocupacional()
            programacion.setCodigo(codigo)
            programacion.setTitular(titular)
            programacion.setEmpresa(empresa)
            programacion.setFecha(fecha)
            programacion.setFechaLaboratio(fecLab)
            programacion.setFechaRayosX(fecRayosX)
            programacion.setFechaMedicoLaboral(fecMedLaboral)
            programacion.setEstadoCompletitud(estado)

            programaciones(index) = programacion
            index += 1
        Next

    End Sub


    'METODOS FUNCIONALES G2
    Public Sub traerEstados()
        Dim index As Int16 = 0, objDTable As DataTable = traerEstadosBD()
        estados = New Concepto(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            estados(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Function esReprogramacion(ByRef _estado As Concepto) As Boolean
        If _estado.getCorrelativo() = 2 Then Return True Else Return False
    End Function



    'METODOS FUNCIONALES G3
    Public Function generarFechaRayosX(ByVal _fechaLab As Date) As Date
        Dim fechaRayosX As Date = _fechaLab
        Return fechaRayosX
    End Function

    Public Function generarFechaMedicoLaboral(ByVal _fecha As Date) As Date
        Dim fechaAux As Date = _fecha
        Dim diasSumados As Int16 = 0

        While True
            fechaAux = fechaAux.AddDays(1)
            Dim esDiaLaboral As Boolean = Utilitarios.esDiaLaboral(fechaAux)
            If esDiaLaboral Then diasSumados += 1
            If diasSumados = 2 Then Exit While
        End While

        Dim fechaMedicoLaboral As Date = fechaAux
        Return fechaMedicoLaboral
    End Function

    Public Sub cargarFichasDisponibles(ByVal _fecha As Date)
        traerMedicosLaborales()
        calcularOfertaFichasLaborales()
        traerFichasLaboralresOcupadas(_fecha)

        fichasDisponibles = fichasLaborales - fichasOcupadas
        If fichasDisponibles < 0 Then fichasDisponibles = 0
    End Sub

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
            medico.setUsuario(New Usuario())
            medico.setTurno(turno)
            medicosLaborales(index) = medico

            index += 1
        Next
    End Sub

    Public Sub calcularOfertaFichasLaborales()
        Dim totalFichas As Int64 = 0

        For Each medico In medicosLaborales
            Dim turnoActual As Turno = medico.getTurno()
            totalFichas += turnoActual.getCantidadFichas()
        Next

        fichasLaborales = totalFichas
    End Sub

    Public Sub traerFichasLaboralresOcupadas(ByVal _fechaSeleccionada As Date)
        Dim index As Int16 = 0, objDTable As DataTable = traerFichasLaboralresOcupadasBD(_fechaSeleccionada)

        For Each row As DataRow In objDTable.Rows
            If IsDBNull(row("FICHAS OCUPADAS")) Then fichasOcupadas = 0 Else fichasOcupadas = Int64.Parse(row("FICHAS OCUPADAS"))
        Next
    End Sub


    'METODOS FUNCIONALES G4
    Public Function updateProgramacion(ByRef _programacion As ProgramacionExamenPreocupacional, _nombreForm As String) As Int16
        Dim respuesta As Int16 = updateProgramacionBD(_programacion, _nombreForm)
        Return respuesta
    End Function

    Public Function insertReprogramacion(ByRef _reprogramacion As ReprogramacionExamenPreocupacional) As Int16
        Dim respuesta As Int16 = insertReprogramacionBD(_reprogramacion)
        Return respuesta
    End Function







    'METODOS BD G1
    Private Function traerProgramacionesBD(ByVal _fecha As Date) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _fecha
        Return objDAL.TraerDataTable("SPtraerProgramaciones_RegProcesoEP", P)
    End Function

    Private Function traerEstadosBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerEstadosAsignarProgramacionEP_Concepto")
    End Function


    'METODOS BD G3
    Private Function traerMedicosLaboralesBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerMedLaborales_RegProgExamenPreocupacional")
    End Function

    Private Function traerFichasLaboralresOcupadasBD(ByVal _fecha As Date) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _fecha
        Return objDAL.TraerDataTable("SPtraerFichasProgramadasMedLaboral_RegProgExamenPreocupacional", P)
    End Function


    'METODOS BD G4
    Private Function updateProgramacionBD(ByRef _programacion As ProgramacionExamenPreocupacional, ByVal _nombreForm As String) As Int16
        Dim estado As Int16 = _programacion.getEstadoCompletidud().getCorrelativo()

        Dim P As Object() = New Object(4) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _nombreForm
        P(2) = _programacion.getCodigo()
        P(3) = estado
        If Not estado = 3 Then P(4) = DBNull.Value Else P(4) = _programacion.getFechaCompletitud()

        Dim respuesta As Int16 = objDAL.Ejecutar("SPprocesarProgrmacionEP_RegProcesoEP", P)
        Return respuesta
    End Function

    Private Function insertReprogramacionBD(ByRef _reprogramacion As ReprogramacionExamenPreocupacional) As Int16
        Dim reprogramarLab As Int16 = _reprogramacion.getReprogramacionLaboratorio()
        Dim reprogramarRX As Int16 = _reprogramacion.getReprogramacionRayosX()
        Dim reprogramarMedLab As Int16 = _reprogramacion.getReprogramacionMedicoLaboral()

        Dim fechaLab As Date = _reprogramacion.getFechaLaboratorio()
        Dim fechaRX As Date = _reprogramacion.getFechaRayosX()
        Dim fechaMedLab As Date = _reprogramacion.getFechaMedicoLaboral()

        Dim P As Object() = New Object(9) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _reprogramacion.getCodigoProgramacion()
        P(2) = _reprogramacion.getTitular().getMatricula()
        P(3) = _reprogramacion.getFecha()

        If reprogramarLab = 0 Then P(4) = DBNull.Value Else P(4) = reprogramarLab
        If reprogramarRX = 0 Then P(5) = DBNull.Value Else P(5) = reprogramarRX
        If reprogramarMedLab = 0 Then P(6) = DBNull.Value Else P(6) = reprogramarMedLab
        If reprogramarLab = 0 Then P(7) = DBNull.Value Else P(7) = fechaLab
        If reprogramarRX = 0 Then P(8) = DBNull.Value Else P(8) = fechaRX
        If reprogramarMedLab = 0 Then P(9) = DBNull.Value Else P(9) = fechaMedLab
        ''If Not estado = 3 Then P(4) = DBNull.Value Else P(4) = _programacion.getFechaCompletitud()

        Dim respuesta As Int16 = objDAL.Ejecutar("SPguardarReprogramacion_RegProcesoEP", P)
        Return respuesta
    End Function






    'METODOS VALIDACIÓN
    Public Function validarEntradas(_programacion As ProgramacionExamenPreocupacional, _repgromacionLab As Boolean, _reprogramacionRX As Boolean,
                                    _reprogramacionMedLaboral As Boolean, _reprogramacion As ReprogramacionExamenPreocupacional) As String
        Dim mensaje As String
        Dim estado As Int16 = _programacion.getEstadoCompletidud().getCorrelativo()

        mensaje = validarProgrmacionSeleccionada(_programacion)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarEstado(_programacion.getEstadoCompletidud())
        If Not mensaje = "" Then Return mensaje


        'SI EL ESTADO SELECCIONADO ES REPROGRAMACION
        If estado = 2 Then
            mensaje = validarReprogramacion(_repgromacionLab, _reprogramacionRX, _reprogramacionMedLaboral)
            If Not mensaje = "" Then Return mensaje

            If _repgromacionLab Then
                mensaje = validarReprogramacionLaboratorio(_reprogramacion.getFechaLaboratorio())
                If Not mensaje = "" Then Return mensaje
            End If

            If _reprogramacionRX Then
                mensaje = validarRepromacionRayosX(_reprogramacion.getFechaRayosX())
                If Not mensaje = "" Then Return mensaje
            End If

            If _reprogramacionMedLaboral Then
                mensaje = validarReprogramacionMedicoLaboral(_reprogramacion.getFechaMedicoLaboral())
                If Not mensaje = "" Then Return mensaje
            End If
        End If

        Return ""
    End Function

    Private Function validarProgrmacionSeleccionada(_programacion As ProgramacionExamenPreocupacional) As String
        If _programacion.getCodigo = 0 Then Return "Error. Seleccione una programación." Else Return ""
    End Function

    Private Function validarEstado(_estado As Concepto) As String
        If _estado.getPrefijo = 0 Then Return "Error. Seleccione un estado." Else Return ""
        If _estado.getCorrelativo = 1 Then Return "Error. No se puede "
    End Function

    Private Function validarReprogramacion(ByVal _reprogramacionLaboratorio As Boolean, ByVal _reprogramacionRayosX As Boolean, ByVal _reprogramacionMedicoLaboral As Boolean) As String
        If _reprogramacionLaboratorio = False And _reprogramacionRayosX = False And _reprogramacionMedicoLaboral = False Then Return "Error. Marque el tipo de reprogramación que desea realizar." Else Return ""
    End Function

    Private Function validarReprogramacionLaboratorio(ByVal _fecha As Date) As String
        Dim diaLaboral As Boolean = Utilitarios.esDiaLaboral(_fecha)


        If Not diaLaboral Then Return "Error. La fecha de Examen de Laboratorio no puede en un día fin de semana. Seleccione otra fecha."

        If _fecha = Today.Date Then Return "Error. No se puede reprogrmar un Examen de Laboratorio con la fecha de hoy. Seleccione una fecha posterior."

        If Not esDespuesFechasPenalizacion(_fecha) Then Return "Error. La fecha de reprogramación debe ser posterior a un periodo de " + diasPenalizacion.ToString + " días de penalización. Seleccione una fecha posterior."

        Return ""
    End Function

    Private Function validarRepromacionRayosX(ByVal _fecha As Date) As String
        Dim esDiaLaboral As Boolean = Utilitarios.esDiaLaboral(_fecha)


        If Not esDiaLaboral Then Return "Error. La fecha de examen de Rayos x no puede ser en un día fin de semana. Seleccione otra fecha."

        If _fecha = Today.Date Then Return "Error. No se puede programar un Examen de Rayos X con la fecha de hoy. Seleccione otra fecha."

        If Not esDespuesFechasPenalizacion(_fecha) Then Return "Error. La fecha de reprogramación debe ser posterior a un periodo de " + diasPenalizacion.ToString + " días de penalización. Seleccione una fecha posterior."

        Return ""
    End Function

    Private Function validarReprogramacionMedicoLaboral(ByVal _fecha As Date) As String
        Dim esDiaLaboral As Boolean = Utilitarios.esDiaLaboral(_fecha)


        If Not esDiaLaboral Then Return "Error. La fecha de examen de médico laboral no puede ser en un día fin de semana. Seleccione otra fecha."

        If _fecha = Today.Date Then Return "Error. No se puede programar un Examen de Medico laboral con la fecha de hoy. Seleccione otra fecha."

        If Not esDespuesFechasPenalizacion(_fecha) Then Return "Error. La fecha de reprogramación debe ser posterior a un periodo de " + diasPenalizacion.ToString + " días de penalización. Seleccione una fecha posterior."

        If fichasDisponibles = 0 Then Return "Error. No existen fichas disponibles para médico laboral en la fecha " + _fecha.ToString("dd--MM--yyyy") + ". Seleccione otra fecha."

        Return ""
    End Function

    Private Function esDespuesFechasPenalizacion(ByVal _fecha As Date) As Boolean
        Dim primerFechaPostPenalizacion = calcularPrimerFechaPostPenalizacion()
        If _fecha >= primerFechaPostPenalizacion Then Return True Else Return False
    End Function

    Private Function calcularPrimerFechaPostPenalizacion() As Date
        Dim fechaPostPenalizacion As Date
        Dim fechaAux As Date = Today
        Dim nroDiasPenalizacion As Int16 = diasPenalizacion
        Dim nroDiasHabilesSumados As Int16 = 0

        While True
            fechaAux = fechaAux.AddDays(1)
            Dim esDiaHabil As Boolean = Utilitarios.esDiaLaboral(fechaAux)
            If esDiaHabil Then nroDiasHabilesSumados += 1


            If nroDiasHabilesSumados = nroDiasPenalizacion Then
                fechaPostPenalizacion = fechaAux.AddDays(1)
                Exit While
            End If
        End While


        Return fechaPostPenalizacion
    End Function




End Class




