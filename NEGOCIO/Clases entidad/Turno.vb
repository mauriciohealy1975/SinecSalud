Public Class Turno
    Private codigo As Int16
    Private tipo As Char
    Private horaEntrada
    Private horaSalida
    Public listaDiasTurno() As String
    Private dias As String
    Private tiempoFicha As Int16
    Private cantidadFichas As Int16



    Private nombre As String
    Private duracionTurnoEnMin As Int16
    Public listaHorarioFichas As String()



    ' -- CONSTRUCTORES
    Public Sub New()
        nombre = ""
        duracionTurnoEnMin = 0
        listaHorarioFichas = New String() {}

        codigo = 0
        horaEntrada = ""
        horaSalida = ""
        listaDiasTurno = New String() {}
        dias = ""
        tiempoFicha = 0
        cantidadFichas = 0
    End Sub

    Public Sub New(ByVal _codigo As Int16, ByVal _nombre As String, ByVal _dias As String, ByVal _hrInicio As String, ByVal _hrFin As String, ByVal _tiempo As Int16)
        codigo = _codigo
        nombre = _nombre
        dias = _dias

        horaEntrada = _hrInicio
        horaSalida = _hrFin
        tiempoFicha = _tiempo

        duracionTurnoEnMin = obtenerDurTurEnMin(horaEntrada, horaSalida)
        cantidadFichas = obtenerCanFichas()

        listaHorarioFichas = New String(cantidadFichas - 1) {}
        generarListaHriosSolMed()


    End Sub




    Public Function getCodigo() As Int16
        Return codigo
    End Function

    Public Sub setCodigo(ByVal _codigo As Int16)
        codigo = _codigo
    End Sub

    Public Function getTipo() As String
        Return tipo
    End Function

    Public Sub setTipo(ByVal _tipo As String)
        tipo = _tipo
    End Sub

    Public Function getHoraEntrada()
        Return horaEntrada
    End Function

    Public Sub setHoraEntrada(ByVal _horaEntrada)
        horaEntrada = _horaEntrada
    End Sub

    Public Function getHoraSalida()
        Return horaSalida
    End Function

    Public Sub setHoraSalida(ByVal _horaSalida)
        horaSalida = _horaSalida
    End Sub

    Public Function getDias() As String
        Return dias
    End Function

    Public Sub setDias(ByVal _dias As String)
        dias = _dias
    End Sub

    Public Function getTiempoFicha() As Int16
        Return tiempoFicha
    End Function

    Public Sub setTiempoFicha(ByVal _tiempoFicha As Int16)
        tiempoFicha = _tiempoFicha
    End Sub

    Public Function getCantidadFichas() As Int16
        Return cantidadFichas
    End Function

    Public Sub setCantidadFichas(ByVal _cantidadFichas As Int16)
        cantidadFichas = _cantidadFichas
    End Sub


    Public Function getEntradaHoraSoloHora()
        Dim soloHora As String = ""

        For Each c As Char In horaEntrada
            If c = ":" Then
                Return soloHora
            Else
                soloHora += c
            End If
        Next

        Return ""
    End Function

    Public Function getEntradaHoraSoloMinutos()
        Dim soloHora As String = ""
        Dim empezar As Boolean = False

        For Each c As Char In horaEntrada
            If empezar = False Then
                If c = ":" Then
                    empezar = True
                End If
            Else
                soloHora += c
            End If
        Next

        Return soloHora
    End Function

    Public Function getSalidaHoraSoloHora()
        Dim soloHora As String = ""

        For Each c As Char In horaSalida
            If c = ":" Then
                Return soloHora
            Else
                soloHora += c
            End If
        Next

        Return ""
    End Function

    Public Function getSalidaHoraSoloMinutos()
        Dim soloHora As String = ""
        Dim empezar As Boolean = False

        For Each c As Char In horaSalida
            If empezar = False Then
                If c = ":" Then
                    empezar = True
                End If
            Else
                soloHora += c
            End If
        Next

        Return soloHora
    End Function
















    Public Function getHrInicio()
        Return horaEntrada
    End Function

    Public Function getHrFin()
        Return horaSalida
    End Function

    Public Function getDuracionEnMin() As Int16
        Return duracionTurnoEnMin
    End Function






    'METODOS BASE MINUTOS Y CANTIDAD DE FICHAS
    Private Function obtenerDurTurEnMin(ByVal _hrIni As String, ByVal _hrFin As String) As Int16
        Dim hrInicio As Int16 = 0
        Dim minInicio As Int16 = 0
        Dim hrFin As Int16 = 0
        Dim minFin As Int16 = 0

        hrInicio = Integer.Parse(obtenerElementoDeHora(_hrIni, 1))
        minInicio = Integer.Parse(obtenerElementoDeHora(_hrIni, 2))
        hrFin = Integer.Parse(obtenerElementoDeHora(_hrFin, 1))
        minFin = Integer.Parse(obtenerElementoDeHora(_hrFin, 2))

        If minInicio = minFin Then
            Return (hrFin - hrInicio) * 60
        Else
            Dim difHorasEnMin = (hrFin - hrInicio) * 60
            Dim difMinEnMin = minFin - minInicio
            Return difHorasEnMin + difMinEnMin
        End If

        Return 0
    End Function

    Private Function obtenerCanFichas() As Int16
        Return duracionTurnoEnMin / tiempoFicha
    End Function




    'METODOS HORARIOS
    Public Sub generarListaHriosSolMed()
        Dim pos As Int16 = 0
        pos = Utilitarios.obtenerIndexPrimeraCasillaVacia(listaHorarioFichas)

        For index = 0 To cantidadFichas - 1
            Dim horarioGenerado As String = ""
            Dim inicioSiguienteHorario As String = ""

            If index = 0 Then
                horarioGenerado = generarHorarioSolMed(horaEntrada)
                listaHorarioFichas(pos) = horarioGenerado
            Else
                inicioSiguienteHorario = obtenerElementoHrioSolMed(listaHorarioFichas(pos - 1), 2)
                horarioGenerado = generarHorarioSolMed(inicioSiguienteHorario)
                listaHorarioFichas(pos) = horarioGenerado
            End If
            pos += 1
        Next

    End Sub

    Private Function generarHorarioSolMed(ByVal _InicioHorarioSolMed As String) As String
        Dim finHorarioSolMed As String = ""
        finHorarioSolMed = obtenerFinHorarioSolMed(_InicioHorarioSolMed)

        Return (_InicioHorarioSolMed + "-" + finHorarioSolMed)
    End Function

    Public Function obtenerFinHorarioSolMed(_horaInicio) As String
        Dim horaAux As Int16 = 0
        Dim minutosAux As Int16 = 0

        horaAux = obtenerElementoDeHora(_horaInicio, 1)
        minutosAux = obtenerElementoDeHora(_horaInicio, 2)

        minutosAux += tiempoFicha

        If minutosAux >= 60 Then
            horaAux += 1

            If minutosAux = 60 Then
                minutosAux = 0

            ElseIf minutosAux > 60 Then
                minutosAux = minutosAux - 60
            End If
        End If

        Dim hrString As String = ""
        Dim minString As String = ""

        hrString = horaAux.ToString()
        minString = minutosAux.ToString()

        If horaAux < 10 Then
            hrString = "0" + hrString
        End If

        If minutosAux < 10 Then
            minString = "0" + minString
        End If


        Return (hrString + ":" + minString)
    End Function

    Private Function obtenerElementoDeHora(ByVal _horaUnida As String, ByVal _elemento As Int16) As String
        Dim horas As String = ""
        Dim minutos As String = ""
        Dim arrayHora As String()

        arrayHora = _horaUnida.Split(":"c)

        If _elemento = 1 Then
            horas = arrayHora(0).Trim()
            Return horas
        ElseIf _elemento = 2 Then
            minutos = arrayHora(1).Trim()
            Return minutos
        End If

        Return ""
    End Function

    Private Function obtenerElementoHrioSolMed(ByVal _horarioUnido As String, ByVal _elementoIndex As Int16) As String
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




    'OTROS METODOS
    Public Function convertirNumerosADias(ByVal _dias As String) As String
        Dim longitud As Integer
        Dim diasResultado As String = ""
        longitud = _dias.Length

        For i As Integer = 0 To longitud - 1

            If _dias(i) = "1"c Then
                diasResultado += "lunes"
            ElseIf _dias(i) = "2"c Then
                diasResultado += "martes"
            ElseIf _dias(i) = "3"c Then
                diasResultado += "miercoles"
            ElseIf _dias(i) = "4"c Then
                diasResultado += "jueves"
            ElseIf _dias(i) = "5"c Then
                diasResultado += "viernes"
            ElseIf _dias(i) = "6"c Then
                diasResultado += "sabado"
            ElseIf _dias(i) = "7"c Then
                diasResultado += "domingo"
            ElseIf _dias(i) = ","c Then
                diasResultado += ","
            End If
        Next

        Return diasResultado
    End Function


End Class
