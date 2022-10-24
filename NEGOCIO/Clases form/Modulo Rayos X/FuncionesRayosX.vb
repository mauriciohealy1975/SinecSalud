Public Class FuncionesRayosX
    Private objDatos As DAL.TDatosSql 'se declara un objeto de conexion'
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub
#Region "Solicitudes"
    Public Function BuscarPaciente(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("spBuscarPorNombre", P))
    End Function
    Public Function BuscarPacienteporCodigo(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("SPBuscarPacientePorMatricula", P))
    End Function
    '--------------------------------------------------------------------------------
    Public Function BuscarYTraerTiposDeRadiografia(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("SPTraerTiposdeExamenesRX", P))
    End Function

#End Region
#Region "Envios"

#End Region
End Class
