Public Class RegistroAtencionInyectables

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public oAtenInyectables As AtencionInyectables = New AtencionInyectables()





    Public Function guardarAtencion() As Int16
        Return guardarAtencionBD()
    End Function




    Private Function guardarAtencionBD() As Int16
        Dim P As Object() = New Object(7) {}
        P(0) = oAtenInyectables.getCodigoMedicamento()
        P(1) = oAtenInyectables.getnombreMedicamento()
        P(2) = oAtenInyectables.getDosis()
        P(3) = oAtenInyectables.getVia()
        'P(4) = oAtenInyectables.getReaccionAdversa()
        'P(5) = oAtenInyectables.getPPS()   
        P(4) = 1
        P(5) = 1
        P(6) = oAtenInyectables.getActividadRealizada()
        P(7) = Usuario.codUserLoggedSystem

        Dim respuesta As Int16 = objDAL.Ejecutar("SPguardarAtencionInyectables", P)
        Return respuesta
    End Function






End Class
