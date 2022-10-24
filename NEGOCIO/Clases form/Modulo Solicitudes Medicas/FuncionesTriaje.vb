Public Class FuncionesTriaje
    Private objDatos As DAL.TDatosSql 'se declara un objeto de conexion'
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub
    Public Function TraerConsultasDB(_nombre, _Desde, _Hasta, _lugarTrabajo) As DataTable
        Dim P As Object() = New Object(3) {}
        P(0) = _nombre + "%"
        P(1) = _Desde
        P(2) = _Hasta
        P(3) = _lugarTrabajo
        Return (objDatos.TraerDataTable("TraerInformeSolicitudMedica", P))
    End Function

    Public Function obtenerProximaFicha(ByVal _fecha As Date)
        Dim P As Object() = New Object(0) {}
        P(0) = _fecha
        Return objDatos.TraerDataTable("TraerSiguenteficha", P)
    End Function
End Class
