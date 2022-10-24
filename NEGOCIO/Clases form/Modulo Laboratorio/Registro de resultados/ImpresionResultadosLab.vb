Imports DAL

Public Class ImpresionResultadosLab

    'ATRIBUTOS LOGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public ordenes As OrdenLaboratorio()
    Public tiposBusquedaMes As Concepto()

    'ATRIBUTOS G2
    Public ordenesFiltrdas As OrdenLaboratorio()

    'ATRIBUTOS G3
    Public datatableHeaderReporte As DataTable
    Public datatableDetallesReporte As DataTable
    Public datatableFooterProcesadores As DataTable
    Public datatableFooterTranscriptores As DataTable







    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LOGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        ordenes = New OrdenLaboratorio(-1) {}
        tiposBusquedaMes = New Concepto(-1) {}

        'ATRIBUTOS G2
        ordenesFiltrdas = New OrdenLaboratorio(-1) {}

        'ATRIBUTOS G2
        datatableHeaderReporte = New DataTable()
        datatableDetallesReporte = New DataTable()
        datatableFooterProcesadores = New DataTable()
        datatableFooterTranscriptores = New DataTable()
    End Sub

    Public Sub iniciarProcesos()

    End Sub




    'METODOS FUNCIONALES G1
    Public Sub traerTiposBusquedaMes()
        Dim datatable As DataTable = traerTiposBusquedaMesBD(), index As Short = 0
        tiposBusquedaMes = New Concepto(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim prefijo As Long, correlativo As Long, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Long.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Long.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            tiposBusquedaMes(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Sub traerOrdenesPorDia(_fechaDiaActual As Date)
        Dim datatable As DataTable = traerOrdenesPorDiaBD(_fechaDiaActual), index As Short = 0
        ordenes = New OrdenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, fecha As Date, matricula As String, nombreCompleto As String,
                nroExamenes As Short, nroResultados As Short


            If IsDBNull(row("CODORD ORD")) Then codigo = 0 Else codigo = Long.Parse(row("CODORD ORD"))
            If IsDBNull(row("FECORD ORD")) Then fecha = "" Else fecha = Date.Parse(row("FECORD ORD"))
            If IsDBNull(row("MATORD ORD")) Then matricula = "" Else matricula = row("MATORD ORD").ToString()
            If IsDBNull(row("NOMCOM ASE")) Then nombreCompleto = "" Else nombreCompleto = row("NOMCOM ASE").ToString()
            If IsDBNull(row("CANDET DET")) Then nroExamenes = 0 Else nroExamenes = Short.Parse(row("CANDET DET"))
            If IsDBNull(row("CANRES RES")) Then nroResultados = 0 Else nroResultados = Short.Parse(row("CANRES RES"))


            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim asegurado As New Asegurado()
            asegurado.setMatricula(matricula)
            asegurado.setNombreCompleto(nombreCompleto.Trim())


            Dim orden As New OrdenLaboratorio()
            orden.setCodigo(codigo)
            orden.setFecha(fecha)
            orden.setAsegurado(asegurado)
            orden.setNroExamenes(nroExamenes)
            orden.setNroResultados(nroResultados)

            ordenes(index) = orden
            index += 1
        Next
    End Sub

    Public Sub traerOrdenesPorMes(_fechaInicioMes As Date)
        Dim datatable As DataTable = traerOrdenesPorMesBD(_fechaInicioMes), index As Short = 0
        ordenes = New OrdenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, fecha As Date, matricula As String, nombreCompleto As String,
                nroExamenes As Short, nroResultados As Short


            If IsDBNull(row("CODORD ORD")) Then codigo = 0 Else codigo = Long.Parse(row("CODORD ORD"))
            If IsDBNull(row("FECORD ORD")) Then fecha = "" Else fecha = Date.Parse(row("FECORD ORD"))
            If IsDBNull(row("MATORD ORD")) Then matricula = "" Else matricula = row("MATORD ORD").ToString()
            If IsDBNull(row("NOMCOM ASE")) Then nombreCompleto = "" Else nombreCompleto = row("NOMCOM ASE").ToString()
            If IsDBNull(row("CANDET DET")) Then nroExamenes = 0 Else nroExamenes = Short.Parse(row("CANDET DET"))
            If IsDBNull(row("CANRES RES")) Then nroResultados = 0 Else nroResultados = Short.Parse(row("CANRES RES"))


            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim asegurado As New Asegurado()
            asegurado.setMatricula(matricula)
            asegurado.setNombreCompleto(nombreCompleto.Trim())


            Dim orden As New OrdenLaboratorio()
            orden.setCodigo(codigo)
            orden.setFecha(fecha)
            orden.setAsegurado(asegurado)
            orden.setNroExamenes(nroExamenes)
            orden.setNroResultados(nroResultados)

            ordenes(index) = orden
            index += 1
        Next

    End Sub

    Public Sub traerOrdenesPorFechas(_fechaDesde As Date, _fechaHasta As Date)
        Dim datatable As DataTable = traerOrdenesPorFechasBD(_fechaDesde, _fechaHasta), index As Short = 0
        ordenes = New OrdenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, fecha As Date, matricula As String, nombreCompleto As String,
                nroExamenes As Short, nroResultados As Short


            If IsDBNull(row("CODORD ORD")) Then codigo = 0 Else codigo = Long.Parse(row("CODORD ORD"))
            If IsDBNull(row("FECORD ORD")) Then fecha = "" Else fecha = Date.Parse(row("FECORD ORD"))
            If IsDBNull(row("MATORD ORD")) Then matricula = "" Else matricula = row("MATORD ORD").ToString()
            If IsDBNull(row("NOMCOM ASE")) Then nombreCompleto = "" Else nombreCompleto = row("NOMCOM ASE").ToString()
            If IsDBNull(row("CANDET DET")) Then nroExamenes = 0 Else nroExamenes = Short.Parse(row("CANDET DET"))
            If IsDBNull(row("CANRES RES")) Then nroResultados = 0 Else nroResultados = Short.Parse(row("CANRES RES"))


            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim asegurado As New Asegurado()
            asegurado.setMatricula(matricula)
            asegurado.setNombreCompleto(nombreCompleto.Trim())


            Dim orden As New OrdenLaboratorio()
            orden.setCodigo(codigo)
            orden.setFecha(fecha)
            orden.setAsegurado(asegurado)
            orden.setNroExamenes(nroExamenes)
            orden.setNroResultados(nroResultados)

            ordenes(index) = orden
            index += 1
        Next
    End Sub


    'METODOS FUNCIONALES G2
    Public Function validarOrden(ByRef _orden As OrdenLaboratorio) As String
        Dim nroResultados As Short

        nroResultados = _orden.getNroResultados()

        If nroResultados <= 0 Then Return "No se ha ingresado ningun resultado para esta orden."
        Return ""
    End Function

    Private Sub dimensionarOrdenesFiltradas()
        Dim dimension As Short

        dimension = ordenes.Count()

        ordenesFiltrdas = New OrdenLaboratorio(dimension - 1) {}
    End Sub

    Public Sub filtrarOrdenes(_nombre As String)
        Dim index As Short, filtradasIndex As Short
        dimensionarOrdenesFiltradas()


        index = 0
        filtradasIndex = 0
        For Each orden As OrdenLaboratorio In ordenes
            Dim coinciden As Boolean, nombreAsegurado As String, dimensionNomAseugrado As Short, dimensionInputNombre As Short


            coinciden = False
            nombreAsegurado = orden.getAsegurado().getNombreCompleto()
            dimensionNomAseugrado = nombreAsegurado.Count()
            dimensionInputNombre = _nombre.Count()


            If dimensionInputNombre <= dimensionNomAseugrado Then
                For i = 0 To dimensionInputNombre - 1
                    If Not _nombre(i) = nombreAsegurado(i) Then
                        coinciden = False
                        Exit For
                    Else
                        coinciden = True
                    End If
                Next

            End If



            If coinciden Then
                ordenesFiltrdas(filtradasIndex) = orden
                filtradasIndex += 1
            End If

            index += 1
        Next
    End Sub


    'METODOS FUNCIONALES G3
    Public Sub traerDatatableHeaderReporte(ByRef _orden As OrdenLaboratorio)
        datatableHeaderReporte = traerDatatableHeaderReporteBD(_orden)
    End Sub

    Public Sub traerDatatableDetallesExamenesReporte(ByRef _orden As OrdenLaboratorio)
        datatableDetallesReporte = traerDatatabDetallesReporteBD(_orden)
    End Sub

    Public Sub traerDatatableFooterProcesadores(ByRef _orden As OrdenLaboratorio)
        datatableFooterProcesadores = traerDatatableFooterProcesadoresBD(_orden)
    End Sub

    Public Sub traerDatatableFooterTranscriptores(ByRef _orden As OrdenLaboratorio)
        datatableFooterTranscriptores = traerDatatableFooterTranscriptoresBD(_orden)
    End Sub







    'METODOS BD G1
    Private Function traerTiposBusquedaMesBD() As DataTable
        Return dal.TraerDataTable("SPtraerTipoBusquedaMes_Concepto")
    End Function

    Private Function traerOrdenesPorDiaBD(_fechaDiaActual As Date) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _fechaDiaActual.Date
        Return (dal.TraerDataTable("SPtraerOrdenesPorDia_ImprimirResultadosLaboratorio", P))
    End Function

    Private Function traerOrdenesPorMesBD(_fechaInicioMes As Date) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _fechaInicioMes.Date
        Return (dal.TraerDataTable("SPtraerOrdenesPorMes_ImprimirResultadosLaboratorio", P))
    End Function

    Private Function traerOrdenesPorFechasBD(_fechaDesde As Date, _fechaHasta As Date) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _fechaDesde.Date
        P(1) = _fechaHasta.Date

        Return (dal.TraerDataTable("SPtraerOrdenesPorFechas_ImprimirResultadosLaboratorio", P))
    End Function

    'METODOS BD G3
    Private Function traerDatatableHeaderReporteBD(ByRef _orden As OrdenLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _orden.getCodigo()

        Return (dal.TraerDataTable("SPtraerCabezeraReporteOrden_ImprimirResultadosLaboratorio", P))
    End Function

    Private Function traerDatatabDetallesReporteBD(ByRef _orden As OrdenLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _orden.getCodigo()

        Return (dal.TraerDataTable("SPtraerDetallesReporte_ImprimirResultadosLaboratorio", P))
    End Function

    Private Function traerDatatableFooterProcesadoresBD(ByRef _orden As OrdenLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _orden.getCodigo()

        Return (dal.TraerDataTable("SPtraerProcesadoresReporteFooter_ImprimirResultadosLaboratorio", P))
    End Function

    Private Function traerDatatableFooterTranscriptoresBD(ByRef _orden As OrdenLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _orden.getCodigo()

        Return (dal.TraerDataTable("SPtraerTranscriptoresReporteFooter_ImprimirResultadosLaboratorio", P))
    End Function


End Class
