Public Class FuncionesOdontologia
    Private ReadOnly objDatos As DAL.TDatosSql 'se declara un objeto de conexion'
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub

#Region "Solicitudes"
    Public Function BuscarHCO(ByVal _matricula) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDatos.TraerDataTable("BuscarHCO", P))
    End Function

    Public Function BuscarCI(ByVal _ci) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _ci
        Return (objDatos.TraerDataTable("TraerCI", P))
    End Function

#End Region
#Region "Envios"

#End Region
End Class
