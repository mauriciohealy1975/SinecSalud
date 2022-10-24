Public Class SolicitudMedica
    Public horario As String
    Public codigoTurno As Int16

    Public Sub New(_codigoTurno As Int16, ByVal _horario As String)
        codigoTurno = _codigoTurno
        horario = _horario
    End Sub

    Public Function getHorario()
        Return horario
    End Function
End Class
