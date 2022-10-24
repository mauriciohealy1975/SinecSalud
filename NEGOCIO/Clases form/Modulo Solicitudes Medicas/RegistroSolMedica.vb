Public Class RegistroSolMedica

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public obJAsegurado As Asegurado
    Public objTitular As Titular
    Public objBeneficiario As Beneficiario
    Public objEspeciadlidad As Especialidad
    Public objMedico As Medico
    Public objTurno As Turno
    Public objTipoConsulta As Concepto
    Private horarioConsulta As String
    Public listaEspecialidades As Especialidad()
    Public medicos As Medico()
    Public listaTurnos As Turno()
    Public listaHorarios As String()
    Public listaTipoConsultas As Concepto()
    Public listaSolcitudesMed As SolicitudMedica()
    Private origenDelForm As String = ""
    Private fechaSolicitud As String = ""


#Region "Revisar derecho de ficha"

    Public Function buscarAsegurado(ByVal _nombre) As DataTable
        Return (buscarAseguradosPorNomBD(_nombre))
    End Function
    Public Function asignarMatriculaTitular(_matricula)
        Dim objDTable As DataTable
        Dim matTitular As String = ""

        objDTable = traerMatriculaTitularBD(_matricula)
        For Each row As DataRow In objDTable.Rows
            matTitular = row("mat titular").ToString()
            Return matTitular
        Next

    End Function
    Public Function TraerPacientePormatricula(ByVal _matricula) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDAL.TraerDataTable("SpTraerPacientePorMatricula", P))
    End Function
    Private Function buscarAseguradosPorNomBD(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = "%" + _nombre + "%"
        Return (objDAL.TraerDataTable("spBuscarPorNombre", P))
    End Function

    Private Function traerMatriculaTitularBD(ByVal _matBeneficiario As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matBeneficiario
        Return (objDAL.TraerDataTable("traerMTdeBeneficiario", P))
    End Function

    Public Function revisarTiFRepetidaTi(ByVal _matAse As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matAse
        P(1) = _fecha
        Return (objDAL.TraerDataTable("SP_TiCheckFUsedT", P))
    End Function

    Public Function revisarTiFRepetidaBe(ByVal _matAse As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matAse
        P(1) = _fecha
        Return (objDAL.TraerDataTable("SP_TiCheckFUsedB", P))
    End Function

    Public Function revisarBeFRepetidaTi(ByVal _matAse As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matAse
        P(1) = _fecha
        Return (objDAL.TraerDataTable("SP_BeCheckFUsedTi", P))
    End Function

    Public Function revisarBeFRepetidaBe(ByVal _matTitular As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matTitular
        P(1) = _fecha
        Return (objDAL.TraerDataTable("SP_BeCheckFUsedB", P))
    End Function

#End Region



    'GETTERS / SETTERS
    Public Function getHorario() As String
        Return horarioConsulta
    End Function

    Public Sub setHorario(ByVal _horario As String)
        horarioConsulta = _horario
    End Sub

    Public Function getFeha()
        Return fechaSolicitud
    End Function

    Public Function getOrigen()
        Return origenDelForm
    End Function




    'METODOS ESPECIALIDADES
    Public Sub traerEspecialidades(_edad)
        Dim objDTable As DataTable
        Dim index As Int16

        objDTable = traerEspPorEdadBD(_edad)
        listaEspecialidades = New Especialidad(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim id As Int16 = 0
            Dim especialidad As String = ""

            id = row("id").ToString()
            especialidad = row("especialidad").ToString()
            listaEspecialidades(index) = New Especialidad(id, especialidad)

            index += 1
        Next
    End Sub

    Public Function buscarCodEspc(ByVal _nombreEspc) As Int16
        Dim codEspc As Int16 = 0

        For Each objEspecialidad As Especialidad In listaEspecialidades
            If _nombreEspc = objEspecialidad.getnombre Then
                codEspc = objEspecialidad.getCodigo
                Exit For
            End If
        Next

        Return codEspc
    End Function



    'METODOS MEDICOS 
    Public Sub traerMedicos(_codigoEspecialidad As Int16, _esexterno As Int16, _fecha As Date)

        Dim datatable As DataTable = traerMedicosBD(_codigoEspecialidad, _fecha, _esexterno), Index As Short = 0
        medicos = New Medico(datatable.Rows.Count - 1) {}


        For Each row As DataRow In datatable.Rows
            Dim codigo, lugtrabajo As Long, nombreCompleto As String

            If IsDBNull(row("codigo")) Then codigo = 0 Else codigo = Long.Parse(row("codigo"))
            If IsDBNull(row("medico")) Then nombreCompleto = "" Else nombreCompleto = row("medico").ToString()
            If IsDBNull(row("LT")) Then lugtrabajo = 0 Else lugtrabajo = row("LT").ToString()

            Dim usuario As New Usuario()
            usuario.setNombres(nombreCompleto)
            Dim medico As New Medico()
            medico.setCodigo(codigo)
            medico.setUsuario(usuario)
            medico.setLugarTrabajo(lugtrabajo)

            medicos(Index) = medico
            Index += 1
        Next
    End Sub

    Public Function buscarMedico(ByVal _medSeleccionado As String) As Medico
        For Each objMed As Medico In medicos
            If _medSeleccionado = objMed.getUsuario().getNombres() Then
                Return objMed
            End If
        Next

        Return Nothing
    End Function

    Public Function traerTurnosDelMedico(ByVal _codigo, ByVal _fecha)
        Dim objDTable As DataTable

        objDTable = traerTurnosHoyBD(_codigo, _fecha)
        listaTurnos = New Turno(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int16 = 0
            Dim nombre As String = ""
            Dim diasNumeral As String = ""
            Dim hrInicio As String = ""
            Dim hrFin As String = ""
            Dim tiempo As Int16 = 0

            codigo = Int16.Parse(row("codigo"))
            diasNumeral = row("dias").ToString()
            hrInicio = row("hrInicio").ToString()
            hrFin = row("hrFin").ToString()
            tiempo = Int16.Parse(row("tiempo"))
            If tiempo > 0 Then
                listaTurnos(index) = New Turno(codigo, nombre, diasNumeral, hrInicio, hrFin, tiempo)
                index += 1
                Return ""
            Else
                Return hrInicio + " A " + hrFin
            End If


        Next

    End Function




    'METODOS HORARIOS
    Public Function buscarTurno(ByVal _horario As String) As Turno
        Dim hrInicioAux As String = ""
        Dim hrFinAux As String = ""

        hrInicioAux = obtenerElementoHorario(_horario, 1)
        hrFinAux = obtenerElementoHorario(_horario, 2)


        For Each objTur As Turno In listaTurnos
            If objTur.getHrInicio <= hrInicioAux And objTur.getHrFin >= hrFinAux Then
                Return objTur
            End If
        Next

        Return Nothing
    End Function

    Public Function obtenerCantidadFiDelDia() As Int16
        Dim cantidadFichasDelDia As Int16 = 0

        For Each objTurno As Turno In listaTurnos
            cantidadFichasDelDia += objTurno.getCantidadFichas()
        Next

        Return cantidadFichasDelDia
    End Function

    Private Function obtenerElementoHorario(ByVal _horarioUnido As String, ByVal _elementoIndex As Int16) As String
        Dim InicioDelHorario As String = ""
        Dim FinDelHorario As String = ""
        Dim arrayHorario As String()

        arrayHorario = _horarioUnido.Split("-"c)

        If _elementoIndex = 1 Then
            InicioDelHorario = arrayHorario(0).Trim()
            Return InicioDelHorario
        ElseIf _elementoIndex = 2 Then
            FinDelHorario = arrayHorario(1).Trim()
            Return FinDelHorario
        End If

        Return ""
    End Function

    Public Sub descartarHorariosSolMedOcup()

        For Each objTur As Turno In listaTurnos

            Dim listaHorariosFichasAux As String()
            listaHorariosFichasAux = New String(objTur.getCantidadFichas() - 1) {}
            Dim index As Int16 = 0

            For Each horarioFicha As String In objTur.listaHorarioFichas
                Dim repetido As Boolean = False

                For Each objSolMed As SolicitudMedica In listaSolcitudesMed
                    If horarioFicha = objSolMed.getHorario() Then
                        repetido = True
                        Exit For
                    End If
                Next

                If Not repetido Then
                    listaHorariosFichasAux(index) = horarioFicha
                    index += 1
                End If
            Next

            objTur.listaHorarioFichas = listaHorariosFichasAux
        Next


    End Sub






    '-- METODOS TIPO CONSULTA
    Public Sub traerTipoConsulta()
        Dim objDTable As DataTable
        Dim index As Int16
        Dim objtipoConsulta As Concepto

        objDTable = traerTipoConsultasBD()
        listaTipoConsultas = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = 0
            Dim correlativo As Int16 = 0
            Dim descripcion As String = ""

            prefijo = Integer.Parse(row("prefijo"))
            correlativo = Integer.Parse(row("correlativo"))
            descripcion = row("descripcion").ToString()
            objtipoConsulta = New Concepto(prefijo, correlativo, descripcion)

            listaTipoConsultas(index) = objtipoConsulta
            index += 1
        Next
    End Sub

    Public Function buscaTipoConsul(ByVal _nombreTipoConsulta) As Concepto

        For Each objTipoConsulta As Concepto In listaTipoConsultas
            If objTipoConsulta.getDescripcion() = _nombreTipoConsulta Then
                Return objTipoConsulta
            End If
        Next

        Return Nothing
    End Function




    '-- METODOS SOL. MEDICAS
    Public Sub traerHorariosSolMed(ByVal _codMed As Int16, ByVal _fecha As Date)
        Dim objDTable As DataTable
        Dim horario As String = ""
        Dim codigoTurno As Int16 = 0

        objDTable = traerHorariosSolMedBD(_codMed, _fecha)
        listaSolcitudesMed = New SolicitudMedica(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            codigoTurno = row("codigo turno").ToString()
            horario = row("horario").ToString()
            listaSolcitudesMed(index) = New SolicitudMedica(codigoTurno, horario)
            index += 1
        Next
    End Sub

    Public Function horarioOcupado(ByVal _horario As String) As Boolean
        For Each solMedica As SolicitudMedica In listaSolcitudesMed
            If solMedica.getHorario() = _horario Then
                Return True
            End If
        Next

        Return False
    End Function


    '--GUARDAR SOL. MEDICAS
    Public Sub guardarSolMedica(ByVal _matAse As String, ByVal _codEspc As Int16, ByVal _codMed As Int16, ByVal _horario As String, ByVal _prefCon As Int16, ByVal _corrCon As Int16, ByVal _codTurno As Int16, ByVal _codUSuario As Int16, ByVal _fecha As String)
        If origenDelForm = "reg" Then
            guardarRegistroSolMedicaBD(_matAse, _codEspc, _codMed, _horario, _prefCon, _corrCon, _codTurno, _codUSuario, _fecha)
        Else
            guardarProgramacionSolMedicaBD(_matAse, _codEspc, _codMed, _horario, _prefCon, _corrCon, _codTurno, _codUSuario, _fecha)
        End If
    End Sub






    '-- METODOS QUE USAN BD 
    '**********************************************************************************
    Public Function obtenerdirytel(ByVal _codmed As Int16)
        Dim P As Object() = New Object(0) {}
        P(0) = _codmed
        Return (objDAL.TraerDataTable("ObtenerDirandTel", P))
    End Function
    Public Function traeridturnoparaexterno(ByVal _Codmed As Int16) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _Codmed
        Return (objDAL.TraerDataTable("SpObtenerCodturno", P))
    End Function

    Public Function TraerCantFichOcupada(ByVal _codMed As Int16, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _codMed
        P(1) = _fecha
        Return (objDAL.TraerDataTable("SPVerificarFichasDisponibles", P))
    End Function

    Public Function traerEdadAsegBD(ByVal _matricula) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDAL.TraerDataTable("spObtenerEdadAsegurado", P))
    End Function


    Private Function traerEspPorEdadBD(ByVal _edad As Integer) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _edad
        Return (objDAL.TraerDataTable("SPTraerEspcPorEdad", P))
    End Function

    Private Function traerMedicosBD(ByVal _codEsp As Int16, ByVal _fecha As Date, _esexterno As Int16) As DataTable
        Dim P As Object() = New Object(2) {}
        P(0) = _codEsp
        P(1) = _fecha
        P(2) = _esexterno
        Return (objDAL.TraerDataTable("sp_traerMedicosConTurno", P))
    End Function

    Public Function traerTurnosHoyBD(ByVal _codMed As Int16, ByVal _fecha As Date) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _codMed
        P(1) = _fecha
        Return (objDAL.TraerDataTable("sp_traerTurnos", P))
    End Function

    Public Function traerTipoConsultasBD() As DataTable
        Return (objDAL.TraerDataTable("SPtrarTipoConsulta"))
    End Function

    Public Sub guardarRegistroSolMedicaBD(ByVal _matAse As String, ByVal _codEspc As Int16, ByVal _codMed As Int16, ByVal _horario As String, ByVal _prefCon As Int16, ByVal _corrCon As Int16, ByVal _codTurno As Int16, ByVal _codUSuario As Int16, ByVal _fecha As String)
        Dim P As Object() = New Object(8) {}
        P(0) = _matAse
        P(1) = _codEspc
        P(2) = _codMed
        P(3) = _horario
        P(4) = _prefCon
        P(5) = _corrCon
        P(6) = _codTurno
        P(7) = _codUSuario
        P(8) = _fecha
        objDAL.Ejecutar("SP_guardarSolMed", P)
    End Sub

    Public Sub guardarProgramacionSolMedicaBD(ByVal _matAse As String, ByVal _codEspc As Int16, ByVal _codMed As Int16, ByVal _horario As String, ByVal _prefCon As Int16, ByVal _corrCon As Int16, ByVal _codTurno As Int16, ByVal _codUSuario As Int16, ByVal _fecha As String)
        Dim P As Object() = New Object(8) {}
        P(0) = _matAse
        P(1) = _codEspc
        P(2) = _codMed
        P(3) = _horario
        P(4) = _prefCon
        P(5) = _corrCon
        P(6) = _codTurno
        P(7) = _codUSuario
        P(8) = _fecha
        objDAL.Ejecutar("SP_programarSolMed", P)
    End Sub

    Private Function traerHorariosSolMedBD(ByVal _codMed As Int16, ByVal _fechaSolicitudMedica As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _codMed
        P(1) = _fechaSolicitudMedica
        Return (objDAL.TraerDataTable("SP_traerHorariosOcupados", P))
    End Function


End Class
