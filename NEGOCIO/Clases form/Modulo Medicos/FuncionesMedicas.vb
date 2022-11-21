Public Class FuncionesMedicas

    Private ReadOnly objDatos As DAL.TDatosSql 'se declara un objeto de conexion'
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub

#Region "Solicitudes"
    Public Function ObtenerListaPacientes(_usuario, _fecha)
        Dim P As Object() = New Object(1) {}
        P(0) = _usuario
        P(1) = _fecha
        Return (objDatos.TraerDataTable("ObtenerPacientesConturno", P))
    End Function
#End Region
#Region "Envios"

#End Region
End Class
