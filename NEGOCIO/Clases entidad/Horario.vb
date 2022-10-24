Public Class Horario

    Public inicio As String
    Public fin As String

    Public Sub New()
        inicio = ""
        fin = ""
    End Sub

    Public Function obtenerFinHorario(ByVal _horaInicio As String, ByVal _tiempoFicha As Int16) As String
        Dim horaAux As Int16 = 0
        Dim minutosAux As Int16 = 0

        horaAux = Me.obtenerElementoDeHora(_horaInicio, 1)
        minutosAux = Me.obtenerElementoDeHora(_horaInicio, 2)

        minutosAux += _tiempoFicha

        If minutosAux >= 60 Then
            horaAux += 1

            If minutosAux = 60 Then
                minutosAux = 0
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


End Class
