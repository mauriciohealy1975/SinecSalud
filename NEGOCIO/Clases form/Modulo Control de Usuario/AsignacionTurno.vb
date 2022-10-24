Public Class AsignacionTurno

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)

    Dim mensaje As String
    Public modoFormulario As Int16

    Public oMedicoSeleccionado As Medico
    Public listaMedico() As Medico
    Public listadDuracionFichas() As Concepto
    Public listaDiasSemana() As String
    Public listaTurnosActivos As ListaEnlazadaTurnos
    Public listaNuevosTurnos As ListaEnlazadaTurnos


    Public horasTurnoMañana As String()
    Public horasTurnoTarde As String()
    Public listaMinutos As String()

    Public Sub New()
        modoFormulario = 1
        horasTurnoMañana = New String() {"07", "08", "09", "10", "11", "12", "13"}
        horasTurnoTarde = New String() {"13", "14", "15", "16", "17", "18", "19"}
        listaMinutos = New String() {"00", "30"}
        listaDiasSemana = New String() {"LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES"}
        listaTurnosActivos = New ListaEnlazadaTurnos()
        listaNuevosTurnos = New ListaEnlazadaTurnos()
    End Sub






    'METODOS FUNCIONALES
    Public Sub traerMedicos(ByVal _nombre As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerMedicosBD(_nombre)
        listaMedico = New Medico(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigoMedico As Int16 = Int16.Parse(row("COD MED"))
            Dim codigoUsuario As Int16 = Int16.Parse(row("COD USU"))
            Dim nombre As String = row("NOM MED").ToString()

            Dim objMedico As Medico = New Medico()
            objMedico.setCodigo(codigoMedico)

            Dim objUsuario As Usuario = New Usuario()
            objUsuario.setCodigo(codigoUsuario)
            objUsuario.setNombres(nombre)

            objMedico.setUsuario(objUsuario)

            listaMedico(index) = objMedico
            index += 1
        Next

    End Sub

    Public Sub seleccionarMedico(ByVal _index As Int16)
        oMedicoSeleccionado = listaMedico(_index)
    End Sub

    Public Sub traerTurnos(ByVal _codMedico As Int16)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerTurnosBD(_codMedico)
        listaTurnosActivos = New ListaEnlazadaTurnos()

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigoTurno As Int16 = Int16.Parse(row("COD TUR"))
            Dim tipoTurno As String = row("TIP TUR").ToString()
            Dim horaInicio As String = row("HR INI").ToString()
            Dim horaFin As String = row("HR FIN").ToString()
            Dim dias As String = row("DIAS").ToString()
            Dim tiempoFicha As Int16 = Int16.Parse(row("TIE FIC"))
            Dim cantidadFichas As Int16 = Int16.Parse(row("NRO FIC"))


            Dim objTurno As Turno = New Turno()
            objTurno.setCodigo(codigoTurno)
            objTurno.setTipo(tipoTurno)
            objTurno.setHoraEntrada(horaInicio)
            objTurno.setHoraSalida(horaFin)
            objTurno.setDias(dias)
            objTurno.setTiempoFicha(tiempoFicha)
            objTurno.setCantidadFichas(cantidadFichas)

            listaTurnosActivos.agregarNodo(objTurno)
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

    Public Function convertirDiasLiteralToNum(ByRef _listaDiasTurno() As String) As String
        Dim diasTurnoNumeral As String = ""

        For Each dia As String In _listaDiasTurno
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

    Public Function convertirDiasNumToLiteral(ByVal _dias As String)
        Dim diasLiteral As String = ""


        For Each c As Char In _dias
            If c = "1" Then
                diasLiteral = diasLiteral + "Lun, "

            ElseIf c = "2" Then
                diasLiteral = diasLiteral + "Mar, "

            ElseIf c = "3" Then
                diasLiteral = diasLiteral + "Mie, "

            ElseIf c = "4" Then
                diasLiteral = diasLiteral + "Jue, "

            ElseIf c = "5" Then
                diasLiteral = diasLiteral + "Vie  "
            End If
        Next

        Return diasLiteral
    End Function

    Public Sub agregarNuevoTurno(ByRef _oTurno As Turno)
        listaNuevosTurnos.agregarNodo(_oTurno)
    End Sub

    Public Function registrarTurnos()
        Dim nodoAcutal As NodoTurno
        nodoAcutal = listaNuevosTurnos.raiz
        Dim numRowsAfected As Int16 = 0


        While (nodoAcutal IsNot Nothing)
            numRowsAfected += agregarTurnoBD(nodoAcutal.turno)
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return numRowsAfected
    End Function





    'METODOS DE VALIDACIÓN -- VALIDAR TURNO
    Public Function validarEntradasTurno(ByRef _oTurno As Turno, ByRef _listaTurnos As ListaEnlazadaTurnos) As String
        mensaje = validarHoras(_oTurno.getHoraEntrada(), _oTurno.getHoraSalida(), _oTurno.getTipo())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarDuracionFicha(_oTurno.getTiempoFicha())
        If Not mensaje = "" Then
            Return mensaje
        End If

        mensaje = validarDiasTurno(_oTurno.listaDiasTurno)
        If Not mensaje = "" Then
            Return mensaje
        End If


        mensaje = validarDiaYHoraRepetidos(_oTurno)
        If Not mensaje = "" Then
            Return mensaje
        End If

        Return ""
    End Function

    Private Function validarHoras(ByVal _horaEntrada As Date, ByVal _horaSalida As Date, ByVal _tipoTurno As Char) As String
        If _horaEntrada = _horaSalida Then
            Return "Error. La hora de entrada no puede ser igual a la hora de salida."
        End If

        If _horaSalida < _horaEntrada Then
            Return "Error. La hora de salida no puede ser menor a la hora de entrada."
        End If

        If _tipoTurno = "M" Then
            If _horaEntrada = "13:30" Or _horaSalida = "13:30" Then
                Return "Error. El turno de la mañana termina a las 13:00. Seleccione otra hora"
            End If

        Else
            If _horaEntrada = "19:30" Or _horaSalida = "19:30" Then
                Return "Error. El turno de la mañana termina a las 19:00. Seleccione otra hora"
            End If
        End If

        Return ""
    End Function

    Private Function validarDiasTurno(ByRef _listaDiasTurno() As String) As String
        If _listaDiasTurno.Count = 0 Then
            Return "Error. Seleccione los días de trabajo que conforman el turno."
        End If

        Return ""
    End Function

    Private Function validarDuracionFicha(ByVal _duracionFicha As Int16) As String
        If _duracionFicha = 0 Or _duracionFicha = Nothing Then
            Return "Error. Seleccione la duración de la ficha."
        End If

        Return ""
    End Function

    Private Function validarDiaYHoraRepetidos(ByRef _oNuevoTurno As Turno)
        Dim mensaje As String = ""

        If modoFormulario = 1 Then
            mensaje = validarConTurnosYaActivos(_oNuevoTurno)
            If Not mensaje = "" Then
                Return mensaje
            End If

            mensaje = validarConTurnosPorAgregar(_oNuevoTurno)
            If Not mensaje = "" Then
                Return mensaje
            End If

        ElseIf modoFormulario = 2 Then
            mensaje = edValidarConTurnosYaActivos(_oNuevoTurno)
            If Not mensaje = "" Then
                Return mensaje
            End If
        End If

        Return ""
    End Function

    Private Function validarConTurnosYaActivos(ByRef _oTurnoNuevo As Turno) As String
        Dim nodoAcutal As NodoTurno
        nodoAcutal = listaTurnosActivos.raiz

        While (nodoAcutal IsNot Nothing)
            Dim turnoActual As Turno = nodoAcutal.turno
            Dim diasTurno1 As String = turnoActual.getDias()
            Dim diasTurno2 As String = _oTurnoNuevo.getDias()
            Dim tipoTurno1 As Char = turnoActual.getTipo()
            Dim tipoTurno2 As Char = _oTurnoNuevo.getTipo()

            Dim parteDelDia As String = revisarParteDelDiaRepetida(tipoTurno1, tipoTurno2)
            Dim diasRepetido As Boolean = revisarDiasRepetidos(diasTurno1, diasTurno2)

            If diasRepetido And Not parteDelDia = "" Then
                Return "Error. El médico ya tiene asignado un turno en la " + parteDelDia + " en alguno de los días seleccionados."
            End If
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return ""
    End Function

    Private Function validarConTurnosPorAgregar(ByRef _oTurnoNuevo As Turno)
        Dim nodoAcutal As NodoTurno
        nodoAcutal = listaNuevosTurnos.raiz

        While (nodoAcutal IsNot Nothing)
            Dim turnoActual As Turno = nodoAcutal.turno
            Dim diasTurno1 As String = turnoActual.getDias()
            Dim diasTurno2 As String = _oTurnoNuevo.getDias()
            Dim tipoTurno1 As Char = turnoActual.getTipo()
            Dim tipoTurno2 As Char = _oTurnoNuevo.getTipo()

            Dim parteDelDia As String = revisarParteDelDiaRepetida(tipoTurno1, tipoTurno2)
            Dim diasRepetido As Boolean = revisarDiasRepetidos(diasTurno1, diasTurno2)

            If diasRepetido And Not parteDelDia = "" Then
                Return "Error. El médico ya tiene asignado un turno en la " + parteDelDia + " en alguno de los días seleccionados."
            End If
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return ""
    End Function

    Private Function edValidarConTurnosYaActivos(ByRef _oTurnoNuevo As Turno) As String
        Dim nodoAcutal As NodoTurno
        nodoAcutal = listaTurnosActivos.raiz

        While (nodoAcutal IsNot Nothing)
            Dim turnoActual As Turno = nodoAcutal.turno

            Dim codTurno1 As Int16 = turnoActual.getCodigo()
            Dim codTurno2 As Int16 = _oTurnoNuevo.getCodigo()
            Dim diasTurno1 As String = turnoActual.getDias()
            Dim diasTurno2 As String = _oTurnoNuevo.getDias()
            Dim tipoTurno1 As Char = turnoActual.getTipo()
            Dim tipoTurno2 As Char = _oTurnoNuevo.getTipo()

            If Not _oTurnoNuevo.getCodigo() = turnoActual.getCodigo() Then
                Dim parteDelDia As String = revisarParteDelDiaRepetida(tipoTurno1, tipoTurno2)
                Dim diasRepetido As Boolean = revisarDiasRepetidos(diasTurno1, diasTurno2)

                If diasRepetido And Not parteDelDia = "" Then
                    Return "Error. El médico ya tiene asignado un turno en la " + parteDelDia + " en alguno de los días seleccionados."
                End If
            End If

            nodoAcutal = nodoAcutal.siguiente
        End While

        Return ""
    End Function

    Private Function revisarDiasRepetidos(ByVal _diasTurnoExistente As String, ByVal _diasNuevoTurno As String) As Boolean

        For Each diaTurno1 As Char In _diasTurnoExistente
            If diaTurno1 = " " Then
                Continue For
            End If

            For Each diaTurno2 As Char In _diasNuevoTurno
                If diaTurno1 = diaTurno2 Then
                    Return True
                End If
            Next

        Next

        Return False
    End Function

    Private Function revisarParteDelDiaRepetida(ByVal parteDiaT1 As Char, ByVal parteDiaT2 As Char)
        Dim parteDelDiaRepetida As String = ""

        If parteDiaT1 = parteDiaT2 Then
            If parteDiaT1 = "M" Then
                parteDelDiaRepetida = "mañana"
                Return parteDelDiaRepetida
            Else
                parteDelDiaRepetida = "tarde"
                Return parteDelDiaRepetida
            End If

        End If

        Return ""
    End Function






    'METODOS BD
    Private Function traerMedicosBD(ByVal _nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = "%" + _nombre + "%"
        Return (objDAL.TraerDataTable("SPtraerMedico", P))
    End Function

    Private Function traerTurnosBD(ByVal _codMedico As Int16) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codMedico
        Return (objDAL.TraerDataTable("SPtraerTurnos", P))
    End Function

    Private Function traerDuracionFichasBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerDuracionesFichas"))
    End Function

    Private Function agregarTurnoBD(ByRef _oTurno As Turno) As Int16
        Dim P As Object() = New Object(7) {}
        P(0) = oMedicoSeleccionado.getCodigo()
        P(1) = _oTurno.getTipo()
        P(2) = _oTurno.getHoraEntrada()
        P(3) = _oTurno.getHoraSalida()
        P(4) = _oTurno.getDias()
        P(5) = _oTurno.getTiempoFicha()
        P(6) = _oTurno.getCantidadFichas()
        P(7) = Usuario.codUserLoggedSystem


        Dim numRowsAfected As Int16 = objDAL.Ejecutar("SPagregarTurno", P)
        Return numRowsAfected
    End Function










    '[MODO EDITAR] ------ METODOS FUNCIONALES
    Public Function edEditarTurno(ByRef _oTurno As Turno, ByVal _nombreForm As String) As Int16
        Dim respuesta As Int16 = 0
        respuesta = edEditarTurnoBD(_oTurno, _nombreForm)
        Return respuesta
    End Function


    'MODO EDITAR ------ METODOS BD
    Private Function edEditarTurnoBD(ByRef _oTurno As Turno, ByVal _nombreForm As String) As Int16
        Dim P As Object() = New Object(9) {}
        P(0) = _oTurno.getCodigo()
        P(1) = _oTurno.getTipo()
        P(2) = _oTurno.getHoraEntrada()
        P(3) = _oTurno.getHoraSalida()
        P(4) = _oTurno.getDias()
        P(5) = _oTurno.getTiempoFicha()
        P(6) = _oTurno.getCantidadFichas()
        P(7) = oMedicoSeleccionado.getCodigo()
        P(8) = _nombreForm
        P(9) = Usuario.codUserLoggedSystem

        Dim respuesta As Int16 = 0
        respuesta = (objDAL.Ejecutar("SPactualizarTurno", P))
        Return respuesta
    End Function














    '[MODO ELIMINAR] - METODOS FUNCIONALES
    Public Function elEliminarTurno(ByRef _oTurno As Turno, ByVal _nombreForm As String) As Int16
        Dim respuesta As Int16 = 0
        respuesta = elEliminarTurnoBD(_oTurno, _nombreForm)
        Return respuesta
    End Function


    'MODO EDITAR ------ METODOS BD
    Private Function elEliminarTurnoBD(ByRef _oTurno As Turno, ByVal _nombreForm As String) As Int16
        Dim P As Object() = New Object(2) {}
        P(0) = _oTurno.getCodigo()
        P(1) = _nombreForm
        P(2) = Usuario.codUserLoggedSystem

        Dim respuesta As Int16 = 0
        respuesta = (objDAL.Ejecutar("SPeliminarTurno", P))
        Return respuesta
    End Function


End Class
