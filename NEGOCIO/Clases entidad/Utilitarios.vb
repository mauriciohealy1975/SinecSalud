
Public Class Utilitarios

    Public Shared resolucionEstandarEjeX As Int16 = 1280
    Public Shared resolucionEstandarEjeY As Int16 = 600


    Public Shared Function obtenerIndexPrimeraCasillaVacia(ByRef _array As String()) As Int16
        Dim indexCasillaVacia As Int16 = 0

        For index = 0 To _array.Length - 1

            If IsNothing(_array(index)) Then
                indexCasillaVacia = index
                Exit For
            End If
        Next

        Return indexCasillaVacia
    End Function

    Public Shared Function obtenerIndexPrimeraCasillaVacia(ByRef _array As ExamenLaboratorio()) As Int16
        Dim indexCasillaVacia As Int16 = 0

        For index = 0 To _array.Length - 1

            If IsNothing(_array(index)) Then
                indexCasillaVacia = index
                Exit For
            End If
        Next

        Return indexCasillaVacia
    End Function

    Public Shared Function obtenerFechaActual() As String
        Return (DateTime.UtcNow.ToString("yyyy-MM-dd"))
    End Function

    Public Shared Function calcularEdad(ByVal _fechaNacimiento As Date) As Int16
        Dim fechaActual As Date = Date.Today
        Dim edad = fechaActual.Year - _fechaNacimiento.Year

        If _fechaNacimiento.Date > fechaActual.AddYears(-edad) Then edad -= 1

        If edad < 0 Then Return 0 Else Return edad
    End Function

    Public Shared Function esTitularHomonimo(ByVal _matricula As String) As Boolean
        Dim caracter As Int16 = Int16.Parse(_matricula(9))

        If Not caracter = 0 Then Return True Else Return False
    End Function

    Public Shared Function esDiaLaboral(ByVal _fecha As Date) As Boolean
        Dim dia As Int16 = _fecha.DayOfWeek
        If Not dia = DayOfWeek.Saturday And Not dia = DayOfWeek.Sunday Then Return True Else Return False
    End Function

End Class
