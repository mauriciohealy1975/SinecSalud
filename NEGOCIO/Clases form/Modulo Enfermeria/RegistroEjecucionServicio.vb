Public Class RegistroEjecucionServicio

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public listaOrdenes As OrdenAtencionEnfermeria()
    Public obOrdenSerEnfer As OrdenAtencionEnfermeria
    Public oEjecucionServicio As EjecucionServicioEnfermeria



    'METODOS FUNCIONALES
    Public Sub traerOrdenesMedicas(ByVal _nombreAsegurado As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerOrdenesMedicasBD(_nombreAsegurado)
        listaOrdenes = New OrdenAtencionEnfermeria(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codOrden As String = row("CODIGOORDEN").ToString()
            Dim fechaOrden As Date = row("FECHAORDEN").ToString()
            Dim tipoAsegurado As String = row("TYPE").ToString()
            Dim matricula As String = row("MATRICULA").ToString()
            Dim nomAsegurado As String = row("ASEGURADO").ToString()
            Dim codMedico As String = row("CODIGOMEDICO").ToString()
            Dim nomMedico As String = row("NONBREMEDICO").ToString()

            Dim obOrdenAtencion As OrdenAtencionEnfermeria = New OrdenAtencionEnfermeria(codOrden, fechaOrden)
            obOrdenAtencion.setMatriculaAsegurado(matricula)
            obOrdenAtencion.setNombreAsegurado(nomAsegurado)
            obOrdenAtencion.setCodigoMedico(codMedico)
            obOrdenAtencion.setNombreMedico(nomMedico)

            listaOrdenes(index) = obOrdenAtencion
            listaOrdenes(index).generarDescripcion()
            index += 1
        Next


    End Sub

    Public Sub buscarOrden(ByVal _descripcion As String)
        If Not _descripcion = Nothing Then
            For Each orden As OrdenAtencionEnfermeria In listaOrdenes
                If orden.getDescripcion() = _descripcion Then
                    obOrdenSerEnfer = orden
                End If

            Next
        End If

    End Sub

    Public Function traerDetalles() As DataTable
        Return (traerDetallesBD(obOrdenSerEnfer.getCodigo()))
    End Function

    Public Function guardarEjecucion()
        Dim respuesta As Int16 = guardarEjecucionBD()
        Return respuesta
    End Function

    Public Function validarEntradas(ByVal _nroCesion As Int16) As String
        Dim respuesta As String = ""

        respuesta = validarNroCesion(_nroCesion)
        If Not respuesta = "" Then
            Return respuesta
        End If


        Return ""
    End Function

    Private Function validarNroCesion(ByVal _nroCesion As Int16) As String
        If _nroCesion <= 0 Then
            Return "Error: El Nro. de cesión debe ser 1 cómo mínimo"
        End If

        Return ""
    End Function





    'METODOS QUE USAN BD
    Private Function traerOrdenesMedicasBD(ByVal _nombreAsegurado) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombreAsegurado
        Return (objDAL.TraerDataTable("SPtraerOrdenesMedicas", P))
    End Function

    Private Function traerDetallesBD(ByVal _codigoOrden As Int16) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codigoOrden
        Return (objDAL.TraerDataTable("SPtraerDetallesOrden", P))
    End Function

    Private Function guardarEjecucionBD() As Int16
        Dim P As Object() = New Object(5) {}
        P(0) = oEjecucionServicio.getDescripcion()
        P(1) = oEjecucionServicio.getFecha()
        P(2) = oEjecucionServicio.getNroCesion()
        P(3) = oEjecucionServicio.getNroOrden()
        P(4) = oEjecucionServicio.getNroDetalle()
        P(5) = Usuario.codUserLoggedSystem

        Return (objDAL.Ejecutar("SPguardarEjecucionServicio", P))

    End Function



End Class
