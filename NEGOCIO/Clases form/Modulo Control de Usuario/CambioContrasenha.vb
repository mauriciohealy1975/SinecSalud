Public Class CambioContrasenha
    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)

    Public Function usuarioValido(ByVal _username As String, ByVal _contrasenha As String) As Boolean
        Dim objDTable As DataTable
        Dim nombre As String = ""
        Dim unidad As String = ""

        objDTable = traerUsuarioBD(_username, _contrasenha)

        If objDTable.Rows.Count = 1 Then
            For Each row As DataRow In objDTable.Rows
                nombre = row("nombre").ToString()
                unidad = row("unidad").ToString()
            Next
            Return True
        End If

        Return False
    End Function

    Public Sub actualizarContrasenha(ByVal _username As String, ByVal _contrasenhaNueva As String)
        modificarContrasehaBD(_username, _contrasenhaNueva)
    End Sub


    'METODOS QUE USAN BD
    Private Function traerUsuarioBD(ByVal _username As String, ByVal _contrasenha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _username
        P(1) = _contrasenha
        Return (objDAL.TraerDataTable("SP_traerUsuario", P))

    End Function

    Private Sub modificarContrasehaBD(ByVal _username As String, ByVal _contrasenhaNueva As String)
        Dim P As Object() = New Object(1) {}
        P(0) = _username
        P(1) = _contrasenhaNueva
        objDAL.Ejecutar("spActualizarContrasenha", P)
    End Sub

End Class
