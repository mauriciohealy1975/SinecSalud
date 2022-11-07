Public Class FuncAgregarCD

    Private ReadOnly objDatos As DAL.TDatosSql 'se declara un objeto de conexion'
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub

#Region "Solicitudes"
    Public Function ObtenerPOE(_Nombre, _POE)
        Dim P As Object() = New Object(1) {}
        P(0) = _Nombre + "%"
        P(1) = _POE
        Return (objDatos.TraerDataTable("ObtenerPoe", P))
    End Function
    Public Function ObtenerCodMedCD()
        Dim tabla = objDatos.TraerDataTable("ProximoCodMedCD")
        Return tabla.Rows(0).Item(0).ToString()
    End Function
#End Region
#Region "Envios"
    Public Function REgistrarMCD(_codUsu, _HoraAtencion, _DiasAtencion, _cantidad, _DOM, _dir, _Tel)
        Dim P As Object() = New Object(6) {}
        P(0) = _codUsu
        P(1) = _HoraAtencion
        P(2) = _DiasAtencion
        P(3) = _cantidad
        P(4) = _DOM
        P(5) = _dir
        P(6) = _Tel
        Return objDatos.Ejecutar("SpInsertarMCD", P)
    End Function
    Public Function InsertarPOes(_ID, _CMCD)
        Dim P As Object() = New Object(1) {}
        P(0) = _ID
        P(1) = _CMCD
        Return objDatos.Ejecutar("InsertarListadeProcedimientos", P)
    End Function

    Public Function InsertarNewPOES(_TPOE, _Nombre, _usuario)
        Dim P As Object() = New Object(2) {}
        P(0) = _TPOE
        P(1) = _Nombre
        P(2) = _usuario
        Return objDatos.Ejecutar("InsertarNewPOE", P)
    End Function
#End Region

End Class
