Imports NEGOCIO
Imports System.Globalization

Public Class FormImprimirResultadosLaboratorio

    'ATRIBUTOS LOGICOS
    Private registro As ImpresionResultadosLab

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1 
    Private modoBusquedaSeleccionado As Short
    Private tipoBusquedaMesSeleccionado As Concepto

    'ATRIBUTOS G2
    Private ordenSeleccionada As OrdenLaboratorio

    Private clmCodigo As String
    Private clmFecha As String
    Private clmMatricula As String
    Private clmAsegurado As String
    Private clmNroExamenes As String
    Private clmNroResultados As String

    'ATRIBUTOS G3
    Private reporte As ReporteResultadosCR




    'METOODS INICIO
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormImprimirResultadosLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarInterfaz()

        traerTiposBusquedaMes()
        poblarCboxTiposBusquedaMes()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New ImpresionResultadosLab()

        'ATRIBUTOS G0
        tituloFormulario = "Imprimir resultados de laboratorio"

        'ATRIBUTOS G1 
        modoBusquedaSeleccionado = 0
        tipoBusquedaMesSeleccionado = New Concepto()

        'ATRIBUTOS G2
        ordenSeleccionada = New OrdenLaboratorio()
        clmCodigo = "clmCodigp"
        clmFecha = "clmFecha"
        clmMatricula = "clmMatricula"
        clmAsegurado = "clmAsegurado"
        clmNroExamenes = "clmNroExamenes"
        clmNroResultados = "clmNroResultado"

        'ATRIBUTOS G3
        reporte = New ReporteResultadosCR()
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarInterfaz()
        iniciarInterfazGrupo0()
        iniciarInterfazGrupo1()
        iniciarInterfazGrupo2()
    End Sub

    Private Sub iniciarInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper()
    End Sub

    Private Sub iniciarInterfazGrupo1()
        panelBuscarOrden.Enabled = True
        panelBuscarOrden.Visible = True

        gboxModoBusqueda.Enabled = True
        gboxModoBusqueda.Visible = True
        gboxModoBusqueda.Text = ""

        rbuttonDia.Enabled = True
        rbuttonDia.Visible = True
        rbuttonDia.Checked = True
        rbuttonDia.Font = New Font("Microsoft Sans Serif", 9)

        rbuttonMes.Enabled = True
        rbuttonMes.Visible = True
        rbuttonMes.Checked = True
        rbuttonMes.Font = New Font("Microsoft Sans Serif", 9)

        rbuttonFechas.Enabled = True
        rbuttonFechas.Visible = True
        rbuttonFechas.Checked = True
        rbuttonFechas.Font = New Font("Microsoft Sans Serif", 9)

        gboxDia.Enabled = True
        gboxDia.Visible = False
        gboxDia.Text = ""

        lblDia.Enabled = False
        lblDia.Visible = True

        dpickerDia.Enabled = False
        dpickerDia.Visible = True
        dpickerDia.Font = New Font("Microsoft Sans Serif", 9)
        dpickerDia.Format = DateTimePickerFormat.Custom
        dpickerDia.CustomFormat = "dd/MM/yyyy"
        'dpickerDia.ShowUpDown = True
        dpickerDia.Value = Date.Today

        gboxMes.Enabled = True
        gboxMes.Visible = False
        gboxMes.Text = ""

        cboxTiposBusquedaMes.Enabled = True
        cboxTiposBusquedaMes.Visible = True
        cboxTiposBusquedaMes.Font = New Font("Microsoft Sans Serif", 9)
        cboxTiposBusquedaMes.Items.Clear()
        cboxTiposBusquedaMes.DropDownStyle = ComboBoxStyle.DropDownList

        hintTipoBusquedaMes.Enabled = True
        hintTipoBusquedaMes.Visible = True
        hintTipoBusquedaMes.Font = New Font("Microsoft Sans Serif", 8)
        hintTipoBusquedaMes.Text = "SELECCIONAR"
        hintTipoBusquedaMes.BackColor = Color.Transparent

        gboxFechas.Enabled = True
        gboxFechas.Visible = False
        gboxFechas.Text = ""

        dpickerDesde.Enabled = True
        dpickerDesde.Visible = True
        dpickerDesde.Font = New Font("Microsoft Sans Serif", 9)
        dpickerDesde.Format = DateTimePickerFormat.Custom
        dpickerDesde.CustomFormat = "dd/MM/yyyy"
        'dpickerDesde.ShowUpDown = True
        dpickerDesde.MinDate = New Date(Today.Year, 1, 1)
        dpickerDesde.MaxDate = Today
        dpickerDesde.Value = Date.Today

        dpickerHasta.Enabled = True
        dpickerHasta.Visible = True
        dpickerHasta.Font = New Font("Microsoft Sans Serif", 9)
        dpickerHasta.Format = DateTimePickerFormat.Custom
        dpickerHasta.CustomFormat = "dd/MM/yyyy"
        'dpickerHasta.ShowUpDown = True
        dpickerHasta.MinDate = New Date(Today.Year, 1, 1)
        dpickerHasta.MaxDate = Today
        dpickerHasta.Value = Date.Today

        btnTraerOrdenes.Enabled = False
        btnTraerOrdenes.Visible = True
        btnTraerOrdenes.Font = New Font("Microsoft Sans Serif", 9)
        btnTraerOrdenes.Text = "Traer ordenes"

        rbuttonDia.Checked = False
        rbuttonMes.Checked = False
        rbuttonFechas.Checked = False
    End Sub

    Private Sub iniciarInterfazGrupo2()
        panelSeleccionarOrden.Enabled = True
        panelSeleccionarOrden.Visible = True

        txtBuscarAsegurado.Enabled = True
        txtBuscarAsegurado.Visible = True
        txtBuscarAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarAsegurado.Text = ""
        txtBuscarAsegurado.CharacterCasing = CharacterCasing.Upper

        btnBuscarAsegurado.Enabled = True
        btnBuscarAsegurado.Visible = True
        btnBuscarAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarAsegurado.Text = "Buscar"


        iniciarDgvOrdenes()
    End Sub

    Public Sub iniciarDgvOrdenes()
        'PROPIEDAS COLUMNAS LABELS
        'lblHeaderEmpty.Visible = False
        'lblHeaderEmpty.Text = ""

        'lblHeaderEdad.Visible = False
        'lblHeaderEdad.Text = "EDAD"

        'lblHeaderValorDeReferencia.Visible = False
        'lblHeaderValorDeReferencia.Text = "VALORES EN"


        'PROPIEDADES BASE
        dgvOrdenes.Enabled = True
        dgvOrdenes.Font = New Font("Microsoft Sans Serif", 9)


        'PROPIEDADES PERMISOS EDITAR
        dgvOrdenes.EditMode = DataGridViewEditMode.EditOnEnter
        dgvOrdenes.AllowUserToAddRows = False
        dgvOrdenes.AllowUserToDeleteRows = False
        dgvOrdenes.AllowUserToResizeRows = False
        dgvOrdenes.AllowUserToOrderColumns = False
        dgvOrdenes.AllowUserToResizeColumns = False
        dgvOrdenes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvOrdenes.MultiSelect = False
        dgvOrdenes.ReadOnly = True


        'PROPIEDAS COLUMNAS
        dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        'PROPIEDADES MODO SELECCION
        dgvOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        'PROPIEDADES GRAFICAS HEADERS COLUMNAS
        dgvOrdenes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvOrdenes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black


        'PROPIEDADES GRAFICAS HEADERS FILAS SELECCIONADAS
        dgvOrdenes.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvOrdenes.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)



        'PROPIEDADES GRAFICAS CELDAS
        dgvOrdenes.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvOrdenes.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvOrdenes.DefaultCellStyle.ForeColor = Color.Black


        'PROPIEDADES GRAFICAS FILAS
        dgvOrdenes.RowsDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvOrdenes.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(77, 106, 255)
        dgvOrdenes.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)


        'PROPIEDAS OTRAS
        dgvOrdenes.ScrollBars = ScrollBars.Both
        dgvOrdenes.EnableHeadersVisualStyles = False



        'AGREGAR COLUMNAS
        dgvOrdenes.Columns.Clear()

        dgvOrdenes.Columns.Add(clmCodigo, "ORDEN")
        dgvOrdenes.Columns(clmCodigo).Visible = True

        dgvOrdenes.Columns.Add(clmFecha, "FECHA")
        dgvOrdenes.Columns(clmFecha).Visible = True

        dgvOrdenes.Columns.Add(clmMatricula, "NATRICULA")
        dgvOrdenes.Columns(clmMatricula).Visible = True

        dgvOrdenes.Columns.Add(clmAsegurado, "ASEGURADO")
        dgvOrdenes.Columns(clmAsegurado).Visible = True

        dgvOrdenes.Columns.Add(clmNroExamenes, "NRO EXAMENES")
        dgvOrdenes.Columns(clmNroExamenes).Visible = True

        dgvOrdenes.Columns.Add(clmNroResultados, "NRO RESULTADOS")
        dgvOrdenes.Columns(clmNroResultados).Visible = True


        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvOrdenes.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'alinear columnas
        For Each columna As DataGridViewColumn In dgvOrdenes.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next


        'configurar ancho columnas
        'dgvSolicitudes.Columns(clmCodigo).FillWeight = 12.5
        'dgvSolicitudes.Columns(clmFecha).FillWeight = 12.5
        'dgvSolicitudes.Columns(clmMatricula).FillWeight = 15
        'dgvSolicitudes.Columns(clmAsegurado).FillWeight = 33
        'dgvSolicitudes.Columns(clmNroExamenes).FillWeight = 13
        'dgvSolicitudes.Columns(clmNroResultados).FillWeight = 13


        'filas
        dgvOrdenes.Rows.Clear()
    End Sub

    Private Sub establecerDisplay()
        'Dim ejeX As Int16 = 1050
        'Dim ejeY As Int16 = 530

        'Size = New Size(ejeX, ejeY)
        'MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        'MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub









    'METODOS LOGICOS G1
    Private Sub seleccionarModoBusqueda()
        If rbuttonDia.Checked Then modoBusquedaSeleccionado = 1
        If rbuttonMes.Checked Then modoBusquedaSeleccionado = 2
        If rbuttonFechas.Checked Then modoBusquedaSeleccionado = 3
    End Sub

    Private Sub traerTiposBusquedaMes()
        registro.traerTiposBusquedaMes()
    End Sub

    Private Sub seleccionarTipoBusquedaMes()
        Dim index As Short = cboxTiposBusquedaMes.SelectedIndex
        tipoBusquedaMesSeleccionado = registro.tiposBusquedaMes(index)
    End Sub

    Private Sub traerOrdenes()
        If modoBusquedaSeleccionado = 1 Then
            Dim fechaHoy As Date

            fechaHoy = Date.Today.Date

            registro.traerOrdenesPorDia(fechaHoy)


        ElseIf modoBusquedaSeleccionado = 2 Then
            Dim tipoBusqueda As Short = tipoBusquedaMesSeleccionado.getCorrelativo()

            If tipoBusqueda = 1 Then
                Dim fechaHoy As Date, fechaInicioMesActual As Date

                fechaHoy = Date.Today
                fechaInicioMesActual = New Date(fechaHoy.Year, fechaHoy.Month, 1)

                registro.traerOrdenesPorMes(fechaInicioMesActual)

            ElseIf tipoBusqueda = 2 Then
                Dim fechaHoy As Date, fechaInicioMesAnterior As Date

                fechaHoy = Date.Today
                fechaInicioMesAnterior = New Date(fechaHoy.Year, fechaHoy.Month - 1, 1)

                registro.traerOrdenesPorMes(fechaInicioMesAnterior)
            End If

        ElseIf modoBusquedaSeleccionado = 3 Then
            Dim fechaDesde As Date, fechaHasta As Date

            fechaDesde = dpickerDesde.Value
            fechaHasta = dpickerHasta.Value

            registro.traerOrdenesPorFechas(fechaDesde, fechaHasta)
        End If
    End Sub


    'METODOS LOGICOS G2
    Private Sub seleccionarOrden()
        Dim index As Short

        For Each row As DataGridViewRow In dgvOrdenes.SelectedRows
            index = row.Index
        Next

        ordenSeleccionada = registro.ordenes(index)
    End Sub

    Private Function validarOrden() As String
        Dim mensaje As String = registro.validarOrden(ordenSeleccionada)
        Return mensaje
    End Function

    Private Sub filtrarOrdenes()
        Dim nombreInput As String = txtBuscarAsegurado.Text.ToUpper.Trim()
        registro.filtrarOrdenes(nombreInput)
    End Sub


    'METODOS LOGICOS G3
    Private Sub traerDatatablesReporte()
        registro.traerDatatableHeaderReporte(ordenSeleccionada)
        registro.traerDatatableDetallesExamenesReporte(ordenSeleccionada)
        registro.traerDatatableFooterProcesadores(ordenSeleccionada)
        registro.traerDatatableFooterTranscriptores(ordenSeleccionada)
    End Sub

    Private Sub cargarReporte()
        Dim headerDatable As DataTable, detailsDatatable As DataTable, footerProcesadores As DataTable, footerTranscriptores As DataTable

        headerDatable = registro.datatableHeaderReporte
        detailsDatatable = registro.datatableDetallesReporte
        footerProcesadores = registro.datatableFooterProcesadores
        footerTranscriptores = registro.datatableFooterTranscriptores

        reporte = New ReporteResultadosCR()

        reporte.Database.Tables(0).SetDataSource(headerDatable)
        reporte.Database.Tables(1).SetDataSource(detailsDatatable)
        reporte.Database.Tables(2).SetDataSource(footerProcesadores)
        reporte.Database.Tables(3).SetDataSource(footerTranscriptores)
    End Sub









    'METODOS INTERFAZ G1
    Private Sub ajustarGboxParaBuscar()
        If modoBusquedaSeleccionado = 1 Then
            'MOSTRAR
            gboxDia.Visible = True

            'OCULTAR
            gboxMes.Visible = False
            gboxFechas.Visible = False


        ElseIf modoBusquedaSeleccionado = 2 Then
            'MOSTRAR
            gboxMes.Visible = True

            'OCULTAR
            gboxDia.Visible = False
            gboxFechas.Visible = False


        ElseIf modoBusquedaSeleccionado = 3 Then
            'MOSTRAR
            gboxFechas.Visible = True

            'OCULTAR 
            gboxDia.Visible = False
            gboxMes.Visible = False
        End If
    End Sub

    Private Sub habilitarBtnTraerOrdenes()
        btnTraerOrdenes.Enabled = True
    End Sub

    Private Sub deshabilitarBtnTraerOrdenes()
        btnTraerOrdenes.Enabled = False
    End Sub

    Private Sub poblarCboxTiposBusquedaMes()
        cboxTiposBusquedaMes.Items.Clear()

        For Each tipoBusqueda As Concepto In registro.tiposBusquedaMes
            cboxTiposBusquedaMes.Items.Add(tipoBusqueda.getDescripcion())
        Next
    End Sub

    Private Sub mostrarHintTipoBusquedaMes()
        hintTipoBusquedaMes.Visible = True
    End Sub

    Private Sub ocultarHintTipoBusquedaMes()
        hintTipoBusquedaMes.Visible = False
    End Sub


    'METODOS INTERFAZ G2
    Private Sub reiniciarTxtBuscarAsegurado()
        txtBuscarAsegurado.Text = ""
    End Sub

    Private Sub poblarDgvOrdenes()
        dgvOrdenes.Rows.Clear()

        For Each orden As OrdenLaboratorio In registro.ordenes
            Dim newIndex As Short, rowActual As DataGridViewRow, codOrden As Long, fecha As Date,
            matricula As String, apPaterno As String, apMaterno As String, nombres As String,
            nomAsegurado As String, nroExamenes As Short, nroResultados As Short

            apPaterno = orden.getAsegurado().getApellidoPaterno()
            apMaterno = orden.getAsegurado().getApellidoMaterno()
            nombres = orden.getAsegurado().getNombres()

            codOrden = orden.getCodigo()
            fecha = orden.getFecha().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
            matricula = orden.getAsegurado().getMatricula()
            'nomAsegurado = apPaterno + " " + apMaterno + " " + nombres
            nomAsegurado = orden.getAsegurado().getNombreCompleto()
            nroExamenes = orden.getNroExamenes()
            nroResultados = orden.getNroResultados()

            newIndex = dgvOrdenes.Rows.Add()
            rowActual = dgvOrdenes.Rows(newIndex)
            rowActual.Cells(clmCodigo).Value = codOrden
            rowActual.Cells(clmFecha).Value = fecha.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
            rowActual.Cells(clmMatricula).Value = matricula
            rowActual.Cells(clmAsegurado).Value = nomAsegurado
            rowActual.Cells(clmNroExamenes).Value = nroExamenes
            rowActual.Cells(clmNroResultados).Value = nroResultados
        Next
    End Sub

    Private Sub poblarDgvOrdenesFiltradas()
        dgvOrdenes.Rows.Clear()

        For Each orden As OrdenLaboratorio In registro.ordenesFiltrdas
            If orden IsNot Nothing Then
                Dim newIndex As Short, rowActual As DataGridViewRow, codOrden As Long, fecha As Date,
                matricula As String, apPaterno As String, apMaterno As String, nombres As String,
                nomAsegurado As String, nroExamenes As Short, nroResultados As Short


                apPaterno = orden.getAsegurado().getApellidoPaterno()
                apMaterno = orden.getAsegurado().getApellidoMaterno()
                nombres = orden.getAsegurado().getNombres()

                codOrden = orden.getCodigo()
                fecha = orden.getFecha().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                matricula = orden.getAsegurado().getMatricula()
                'nomAsegurado = apPaterno + " " + apMaterno + " " + nombres
                nomAsegurado = orden.getAsegurado().getNombreCompleto()
                nroExamenes = orden.getNroExamenes()
                nroResultados = orden.getNroResultados()

                newIndex = dgvOrdenes.Rows.Add()
                rowActual = dgvOrdenes.Rows(newIndex)
                rowActual.Cells(clmCodigo).Value = codOrden
                rowActual.Cells(clmFecha).Value = fecha.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                rowActual.Cells(clmMatricula).Value = matricula
                rowActual.Cells(clmAsegurado).Value = nomAsegurado
                rowActual.Cells(clmNroExamenes).Value = nroExamenes
                rowActual.Cells(clmNroResultados).Value = nroResultados
            End If
        Next
    End Sub

    Private Sub reiniciarDgvOrdenes()
        dgvOrdenes.Rows.Clear()
    End Sub


    'METODOS INTERFAZ G3
    Private Sub reinicarCrViewer()
        crViewer.ReportSource = Nothing
    End Sub

    Private Sub mostrarReporte()
        crViewer.ReportSource = Nothing
        crViewer.ReportSource = reporte
    End Sub

    Private Sub ajustarZoom(ByVal _zoom As Integer)
        crViewer.Zoom(_zoom)
    End Sub


    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub









    'EVENTOS G0
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim form As FormMenuLaboratorio

        form = New FormMenuLaboratorio()
        form.Show()
        Me.Close()
    End Sub


    'EVENTOS G1 
    Private Sub rbuttonDia_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonDia.CheckedChanged
        Try
            If rbuttonDia.Checked Then
                seleccionarModoBusqueda()
                ajustarGboxParaBuscar()
                habilitarBtnTraerOrdenes()
                reiniciarTxtBuscarAsegurado()
                reiniciarDgvOrdenes()


            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub rbuttonMes_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonMes.CheckedChanged
        Try
            If rbuttonMes.Checked Then
                seleccionarModoBusqueda()
                ajustarGboxParaBuscar()
                habilitarBtnTraerOrdenes()
                reiniciarTxtBuscarAsegurado()
                reiniciarDgvOrdenes()

            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub rbuttonFechas_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonFechas.CheckedChanged
        Try
            If rbuttonFechas.Checked Then
                seleccionarModoBusqueda()
                ajustarGboxParaBuscar()
                habilitarBtnTraerOrdenes()
                reiniciarTxtBuscarAsegurado()
                reiniciarDgvOrdenes()

            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnTraerOrdenes_Click(sender As Object, e As EventArgs) Handles btnTraerOrdenes.Click
        Try
            traerOrdenes()
            poblarDgvOrdenes()
            reiniciarTxtBuscarAsegurado()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxTiposBusquedaMes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTiposBusquedaMes.SelectionChangeCommitted
        Try
            seleccionarTipoBusquedaMes()
            ocultarHintTipoBusquedaMes()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    'EVENTOS G2
    Private Sub dgvOrdenes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrdenes.CellDoubleClick
        Try
            Dim mensajeValidacion As String

            reinicarCrViewer()
            seleccionarOrden()
            mensajeValidacion = validarOrden()


            If mensajeValidacion = "" Then
                traerDatatablesReporte()
                cargarReporte()
                mostrarReporte()
                ajustarZoom(60)
            Else
                mostrarMensaje(mensajeValidacion)
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvOrdenes_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvOrdenes.RowPostPaint
        Try
            Dim grid = TryCast(sender, DataGridView)
            Dim rowIdx = (e.RowIndex + 1).ToString()
            Dim centerFormat = New StringFormat() With
                           {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                           }
            Dim headerBounds = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
            e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarAsegurado_Click(sender As Object, e As EventArgs) Handles btnBuscarAsegurado.Click
        Try
            filtrarOrdenes()
            poblarDgvOrdenesFiltradas()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub




End Class




