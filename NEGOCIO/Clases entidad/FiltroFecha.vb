Public Class FiltroFecha
    Private fecha As String
    Private mensaje As String

    Public Sub New(ByVal _fecha As String)
        fecha = _fecha
        mensaje = generarMensaje(_fecha)
    End Sub


    Private Function generarMensaje(ByVal _fecha As String) As String
        Return ("Sólo las solicitudes del " + fecha)
    End Function

    Public Function getMensaje()
        Return mensaje
    End Function

    Public Function getFecha() As String
        Return fecha
    End Function


End Class
