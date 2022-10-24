Public Class RegistroTomaMuestra

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public listaOrdenesLab() As OrdenLaboratorio
    Public listaDetallesOrdLab() As DetalleOrdenLaboratorio
    Public oOrdenLaboratorio As OrdenLaboratorio
    Public listaDetallesSeleccionados() As DetalleOrdenLaboratorio





    'METODOS FUNCIONALES
    Public Sub traerOrdenesXNroOrden(ByVal _nroOrden As Int16)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerOrdenesXNroOrdenBD(_nroOrden)
        listaOrdenesLab = New OrdenLaboratorio(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigoOrden As Int16 = Int16.Parse(row("COD ORDEN"))
            Dim nombreAsegurado As String = row("NOM ASEGURADO").ToString()
            Dim fecha As String = row("FECHA").ToString()

            Dim asegurado As New Asegurado()
            asegurado.setNombres(nombreAsegurado)

            Dim objOrdenLab As OrdenLaboratorio = New OrdenLaboratorio()
            objOrdenLab.setCodigo(codigoOrden)
            objOrdenLab.setAsegurado(asegurado)
            objOrdenLab.setFecha(fecha)

            listaOrdenesLab(index) = objOrdenLab
            index += 1
        Next
    End Sub

    Public Sub traerOrdenesXMatricula(ByVal _matricula As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerOrdenesXMatriculaBD(_matricula)
        listaOrdenesLab = New OrdenLaboratorio(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigoOrden As Int16 = Int16.Parse(row("COD ORDEN"))
            Dim nombreAsegurado As String = row("NOM ASEGURADO").ToString()
            Dim fecha As String = row("FECHA").ToString()

            Dim asegurado As New Asegurado()
            asegurado.setNombres(nombreAsegurado)


            Dim oden As OrdenLaboratorio = New OrdenLaboratorio()
            oden.setCodigo(codigoOrden)
            oden.setAsegurado(asegurado)
            oden.setFecha(fecha)

            listaOrdenesLab(index) = oden
            index += 1
        Next
    End Sub

    Public Sub traerDetallesOrden(ByVal _codigoOrden As Int16)
        Dim datatable As DataTable = traerDetallesOrdenBD(_codigoOrden), index As Int16 = 0
        listaDetallesOrdLab = New DetalleOrdenLaboratorio(datatable.Rows.Count - 1) {}

        Dim orden As New OrdenLaboratorio()
        orden.setCodigo(_codigoOrden)

        For Each row As DataRow In datatable.Rows
            Dim codigoDetalle As Int16 = Int16.Parse(row("COD DETALLE"))
            Dim codigoOrden As Int16 = Int16.Parse(row("COD ORDEN"))
            Dim nombreExamen As String = row("EXAMEN").ToString()
            Dim objDetalleOrdenLab As DetalleOrdenLaboratorio = New DetalleOrdenLaboratorio()
            objDetalleOrdenLab.setCodigo(codigoDetalle)
            objDetalleOrdenLab.setOrden(orden)
            objDetalleOrdenLab.getExamen().setNombre(nombreExamen)

            listaDetallesOrdLab(index) = objDetalleOrdenLab
            index += 1
        Next
    End Sub

    Public Function registrarRecepcionDeMuestra()
        Dim respuesta As Int16 = 0

        For Each ordenLaboratorio As DetalleOrdenLaboratorio In listaDetallesSeleccionados
            respuesta = registrarRecepcionDeMuestraBD(ordenLaboratorio)
        Next

        Return respuesta
    End Function






    'METODOS BD
    Private Function traerOrdenesXNroOrdenBD(ByVal _nroOrden As Int16)
        Dim P As Object() = New Object(0) {}
        P(0) = _nroOrden
        Return (objDAL.TraerDataTable("SPtraerOrLabAbiertasUltimos7dias", P))
    End Function

    Private Function traerOrdenesXMatriculaBD(ByVal _matricula As String)
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDAL.TraerDataTable("SPtraerOrLabAbiertasUltimos7diasXMatricula", P))
    End Function

    Private Function traerDetallesOrdenBD(ByVal _codigoOrden As Int16) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codigoOrden
        Return (objDAL.TraerDataTable("SPtraerDetalleOrden", P))
    End Function

    Private Function registrarRecepcionDeMuestraBD(ByVal _oDetalleOrdenLab As DetalleOrdenLaboratorio) As Int16
        Dim P As Object() = New Object(1) {}
        P(0) = _oDetalleOrdenLab.getCodigo()
        P(1) = Usuario.codUserLoggedSystem
        Return (objDAL.Ejecutar("SPregistrarTomaMuestra", P))
    End Function





End Class

