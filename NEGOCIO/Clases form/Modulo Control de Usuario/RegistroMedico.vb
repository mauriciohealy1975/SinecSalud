Public Class RegistroMedico

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)

    Dim mensaje As String
    Public oEspecialidadSeleccionada As Especialidad
    Public oDuracionFichaSeleccionada As Concepto
    Public oMedicoInsertado As Medico
    Public listaEspecialidades() As Especialidad
    Public listadDuracionFichas() As Concepto
    Public listaDiasSemana() As String
    Public listaDiasTurno() As String
    Public tipoTurno As Char

    Public horasTurnoMañana As String()
    Public horasTurnoTarde As String()
    Public listaMinutos As String()

    Public Sub New()
        mensaje = ""
        oEspecialidadSeleccionada = New Especialidad()
        listaDiasSemana = New String() {"LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES"}
        listaDiasTurno = New String() {}


        horasTurnoMañana = New String() {"07", "08", "09", "10", "11", "12", "13"}
        horasTurnoTarde = New String() {"13", "14", "15", "16", "17", "18", "19"}
        listaMinutos = New String() {"00", "30"}
    End Sub




    'METODOS FUNCIONALES
    Public Sub traerEspecialidades()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerEspecialidadesBD()
        listaEspecialidades = New Especialidad(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int16 = Int16.Parse(row("COD ESP"))
            Dim nombre As String = row("NOM ESP").ToString()

            Dim objEspecialidad As Especialidad = New Especialidad(codigo, nombre)
            listaEspecialidades(index) = objEspecialidad
            index += 1
        Next

    End Sub

    Public Sub traerDuracionFichas()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerDuracionFichasBD()
        listadDuracionFichas = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Int16.Parse(row("PREFIJO"))
            Dim correlativo As Int16 = row("CORRELATIVO").ToString()
            Dim descripcion As String = row("DESCRPIPCION").ToString()

            Dim objDuracionFicha As Concepto = New Concepto(prefijo, correlativo, descripcion)
            listadDuracionFichas(index) = objDuracionFicha
            index += 1
        Next
    End Sub

    Public Sub seleccionarTiempoDuracionFicha(ByVal _index As Int16)
        oDuracionFichaSeleccionada = listadDuracionFichas(_index)
    End Sub

    Public Sub seleccionarEspecialidad(ByVal _index As Int16)
        oEspecialidadSeleccionada = listaEspecialidades(_index)
    End Sub

    Public Function convertirDiasTurno() As String
        Dim diasTurnoNumeral As String = ""

        For Each dia As String In listaDiasTurno
            If dia = "LUNES" Then
                diasTurnoNumeral = diasTurnoNumeral + " " + "1"

            ElseIf dia = "MARTES" Then
                diasTurnoNumeral = diasTurnoNumeral + " " + "2"

            ElseIf dia = "MIERCOLES" Then
                diasTurnoNumeral = diasTurnoNumeral + " " + "3"

            ElseIf dia = "JUEVES" Then
                diasTurnoNumeral = diasTurnoNumeral + " " + "4"

            ElseIf dia = "VIERNES" Then
                diasTurnoNumeral = diasTurnoNumeral + " " + "5"
            End If
        Next

        Return diasTurnoNumeral
    End Function

    Public Function guardarTurno(ByVal _horaIni, ByVal _horaFin,
                                 ByVal _diasTurno, ByVal _tipoTurno, ByVal _nroFichas, ByVal _esexterno) As Int16
        Dim respuesta As Int16 = 0
        respuesta = guardarTurnoBD(_horaIni, _horaFin, _diasTurno, _tipoTurno, _nroFichas, _esexterno)
        Return respuesta
    End Function


    Public Sub guardarMedico(ByVal tipomed, ByVal Direccion, ByVal telefonos)
        Dim objDTable As DataTable
        objDTable = guardarMedicoBD(tipomed, Direccion, telefonos)

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int16 = Int16.Parse(row("COD MEDICO"))
            oMedicoInsertado = New Medico()
            oMedicoInsertado.setCodigo(codigo)
        Next

    End Sub

    Public Function calcularCantidadFichasTurno(ByVal _horaEntrada As Int16, ByVal _horaSalida As Int16,
                                                ByVal _minutosEntrada As Int64, ByVal _minutosSalida As Int16,
                                                ByVal _duracionFicha As Int16) As Int16

        Dim cantidadFichasTurno As Int16 = 0
        Dim horasTrabajo As Int16 = 0
        Dim tiempoTotalEnMinutos As Int16
        Dim tiempoMinutos As Int16 = 0

        horasTrabajo = _horaSalida - _horaEntrada
        tiempoTotalEnMinutos = horasTrabajo * 60

        If _minutosEntrada = 30 Then
            _minutosEntrada = -30
        End If

        tiempoMinutos = _minutosEntrada + _minutosSalida


        tiempoTotalEnMinutos = tiempoTotalEnMinutos + tiempoMinutos
        Dim nroFichasTotales As Int16 = Fix(tiempoTotalEnMinutos / _duracionFicha)

        If nroFichasTotales < 0 Then
            nroFichasTotales = 0
        End If

        Return nroFichasTotales
    End Function







    'METODOS DE VALIDACIÓN -- VALIDAR MEDICO
    Public Function validarEntradasMedico()
        mensaje = validarEspecialidad()
        If Not mensaje = "" Then
            Return mensaje
        End If

        Return ""
    End Function

    Private Function validarEspecialidad()
        If oEspecialidadSeleccionada.getCodigo() = 0 Then
            Return "Error. Seleccione una especialidad"
        End If

        Return ""
    End Function




    'METODOS DE VALIDACIÓN -- VALIDAR TURNO
    Public Function validarEntradasTurno(ByVal _horaEntrada As Date, ByVal _horaSalida As Date) As String
        mensaje = validarHoras(_horaEntrada, _horaSalida)
        If Not mensaje = "" Then
            Return mensaje
        End If


        mensaje = validarDiasTurno()
        If Not mensaje = "" Then
            Return mensaje
        End If


        mensaje = validarDuracionFicha()
        If Not mensaje = "" Then
            Return mensaje
        End If

        Return ""
    End Function

    Private Function validarHoras(ByVal _horaEntrada, ByVal _horaSalida) As String
        If _horaEntrada = _horaSalida Then
            Return "Error. La hora de entrada no puede ser igual a la hora de salida."
        End If

        If _horaSalida < _horaEntrada Then
            Return "Error. La hora de salida no puede ser menor a la hora de entrada."
        End If

        Return ""
    End Function

    Private Function validarDiasTurno() As String
        If listaDiasTurno.Count = 0 Then
            Return "Error. Seleccione los días de trabajo que conforman el turno."
        End If

        Return ""
    End Function

    Private Function validarDuracionFicha() As String
        If oDuracionFichaSeleccionada Is Nothing Then
            Return "Error. Seleccione la duración de la ficha."
        End If

        Return ""
    End Function







    'METODOS BD
    Private Function traerEspecialidadesBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerEsepecialidades"))
    End Function

    Private Function traerDuracionFichasBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerDuracionesFichas"))
    End Function

    Private Function guardarMedicoBD(ByVal tipomedico, ByVal direccion, ByVal telefono) As DataTable
        Dim P As Object() = New Object(3) {}
        P(0) = oEspecialidadSeleccionada.getCodigo()
        P(1) = tipomedico
        P(2) = direccion
        P(3) = telefono

        Return (objDAL.TraerDataTable("SPguardarMedico", P))
    End Function

    Private Function guardarTurnoBD(ByVal _horaIni As String, ByVal _horaFin As String,
                                    ByVal _diasTurno As String, ByVal _tipoTurno As Char,
                                    ByVal _nroFichas As Int16, ByVal esexterno As Int16) As Int16
        Dim P As Object() = New Object(8) {}
        P(0) = oMedicoInsertado.getCodigo()
        P(1) = _horaIni
        P(2) = _horaFin
        P(3) = _diasTurno
        P(4) = _tipoTurno
        If esexterno = 0 Then
            P(5) = Int16.Parse(oDuracionFichaSeleccionada.getDescripcion())
        Else
            P(5) = 0
        End If

        P(6) = _nroFichas
        P(7) = 0
        P(8) = Usuario.codUserLoggedSystem

        Dim respuesta As Int16 = 0
        respuesta = objDAL.Ejecutar("SPguardarTurno", P)

        Return respuesta
    End Function





End Class
