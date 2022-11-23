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

    Public Function BuscarCI(ByVal _mat) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _mat
        Return (objDatos.TraerDataTable("TraerCI", P))
    End Function

    Public Function EviarDatosHCO(ByVal _nhco, ByVal _ldn, ByVal _gdi, ByVal _mtr, ByVal _tra, ByVal _medi, ByVal _hemr,
                                  ByVal _espef) As DataTable
    End Function
#End Region
#Region "Envios"

#End Region
End Class
