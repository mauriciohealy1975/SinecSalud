Public Class ControlRegSolMed
    Public fecha As String

    Public Sub New()
        fecha = obtenerFechaDelSistema()
    End Sub

    Private Function obtenerFechaDelSistema()
        fecha = DateTime.Today.ToString("yyyy-MM-dd")
        Return fecha
    End Function

    Public Function getFecha() As String
        Return fecha
    End Function


End Class
