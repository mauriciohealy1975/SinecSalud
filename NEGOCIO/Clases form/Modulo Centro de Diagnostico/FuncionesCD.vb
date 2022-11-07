Public Class FuncionesCD
#Region "Declaraciones"

    Private ReadOnly objDatos As DAL.TDatosSql 'se declara un objeto de conexion'
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub

#End Region

#Region "Solicitudes"

#End Region
#Region "Envios"

#End Region
End Class
