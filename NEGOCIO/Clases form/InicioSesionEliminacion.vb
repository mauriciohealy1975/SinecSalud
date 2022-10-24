Public Class InicioSesionEliminacion

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)



    'METODOS USURIO ELIMINACION
    Public Function encontrarUsuario(ByVal _username As String, ByVal _contrasenha As String)
        Dim objDTable As DataTable
        objDTable = traerUsuarioBD(_username, _contrasenha)

        If objDTable.Rows.Count = 1 Then
            For Each row As DataRow In objDTable.Rows
                Dim codigo As Int16
                codigo = Int16.Parse(row("codigo"))
                guardarUsuarioEliminacion(codigo)
            Next

            Return True
        End If

        Return False
    End Function

    Private Sub guardarUsuarioEliminacion(ByVal _codigo As String)
        UsuarioEliminacion.codigo = _codigo
    End Sub




    'METODOS QUE USAN BD
    Private Function traerUsuarioBD(ByVal _username As String, ByVal _contrasenha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _username
        P(1) = _contrasenha
        Return (objDAL.TraerDataTable("SP_traerUsuariosEliminacion", P))
    End Function




End Class
