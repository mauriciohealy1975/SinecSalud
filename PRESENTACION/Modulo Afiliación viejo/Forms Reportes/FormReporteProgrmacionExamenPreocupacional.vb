Imports NEGOCIO

Public Class FormReporteProgrmacionExamenPreocupacional

    'ATRIBUTOS LOGICOS
    Private reporteProg As ReporteProgramacionReprogramacionExamenPreocupacional
    Private esFormularioSecundario As Boolean


    'ATRIBUTOS G1
    Private datatableReporte As DataTable
    Private programacionSeleccionada As ProgramacionExamenPreocupacional
    '   Private reporteActual As MyReportExPre




    'METODOS INICIO
    Public Sub New(ByVal _esFormularioSecundario As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        esFormularioSecundario = _esFormularioSecundario
    End Sub

    Private Sub FormReporteProgrmacionExamenPreocupacional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Private Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
    End Sub

    Private Sub configurarDisplay()
        Dim ejeX As Int16 = Utilitarios.resolucionEstandarEjeX
        Dim ejeY As Int16 = Utilitarios.resolucionEstandarEjeY

        Size = New Size(ejeX, ejeY)
        MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        'MaximumSize = New System.Drawing.Size(ejeX, ejeY)
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarControles()
        iniciarControlesLogicos()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        cargarProcesosAutomaticos()
    End Sub

    Private Sub iniciarControlesLogicos()
        reporteProg = New ReporteProgramacionReprogramacionExamenPreocupacional()

        'G1
        datatableReporte = New DataTable()
        programacionSeleccionada = New ProgramacionExamenPreocupacional()


        'G2
        'reporteActual = New MyReportExPre()
    End Sub

    Private Sub iniciarControlesGrupo1()
        dpcDesede.Enabled = True
        dpcDesede.ShowUpDown = False
        dpcDesede.Font = New Font("Microsoft Sans Serif", 9)
        dpcDesede.Format = DateTimePickerFormat.Custom
        dpcDesede.CustomFormat = "dd--MM--yyyy"
        dpcDesede.Value = Date.Today.Date
        dpcDesede.MaxDate = Date.Today.Date

        dpcHasta.Enabled = True
        dpcHasta.ShowUpDown = False
        dpcHasta.Font = New Font("Microsoft Sans Serif", 9)
        dpcHasta.Format = DateTimePickerFormat.Custom
        dpcHasta.CustomFormat = "dd--MM--yyyy"
        dpcHasta.Value = Date.Today.Date
        dpcHasta.MaxDate = Date.Today.Date

        btnTraerProgramaciones.Enabled = True
        btnTraerProgramaciones.Visible = True
        btnTraerProgramaciones.Font = New Font("Microsoft Sans Serif", 9)
        btnTraerProgramaciones.Text = "Traer programaciones / reprogramaciones"

        iniciarDgvProgramacionesReprogramacinoes()
    End Sub

    Private Sub iniciarDgvProgramacionesReprogramacinoes()
        'propiedades base
        dgvProgramacionesReprogramaciones.Enabled = True
        dgvProgramacionesReprogramaciones.Font = New Font("Microsoft Sans Serif", 9)


        'permisos editar
        dgvProgramacionesReprogramaciones.EditMode = DataGridViewEditMode.EditOnEnter
        dgvProgramacionesReprogramaciones.AllowUserToAddRows = False
        dgvProgramacionesReprogramaciones.AllowUserToDeleteRows = True
        dgvProgramacionesReprogramaciones.AllowUserToResizeRows = False
        dgvProgramacionesReprogramaciones.AllowUserToOrderColumns = False
        dgvProgramacionesReprogramaciones.AllowUserToResizeColumns = False
        dgvProgramacionesReprogramaciones.MultiSelect = False
        dgvProgramacionesReprogramaciones.ReadOnly = True


        'estilos
        dgvProgramacionesReprogramaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProgramacionesReprogramaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProgramacionesReprogramaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvProgramacionesReprogramaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvProgramacionesReprogramaciones.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvProgramacionesReprogramaciones.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvProgramacionesReprogramaciones.RowHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvProgramacionesReprogramaciones.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvProgramacionesReprogramaciones.DefaultCellStyle.ForeColor = Color.Black
        dgvProgramacionesReprogramaciones.ScrollBars = ScrollBars.Both
        dgvProgramacionesReprogramaciones.EnableHeadersVisualStyles = False


        'columnas -- agregar columnas
        'dgvProgramacionesReprogramaciones.Columns.Clear()

        'dgvProgramaciones.Columns.Add(nomClmCodigo, "CÓDIGO")
        dgvProgramacionesReprogramaciones.Columns("Column1").Visible = False

        'dgvProgramaciones.Columns.Add(nomClmEstado, "ESTADO")
        dgvProgramacionesReprogramaciones.Columns("Column2").Visible = False


        'dgvProgramaciones.Columns.Add(nomClmMatricula, "MATRÍCULA")
        'dgvProgramaciones.Columns(nomClmMatricula).Visible = True

        'dgvProgramaciones.Columns.Add(nomClmTitular, "TITULAR")
        'dgvProgramaciones.Columns(nomClmTitular).Visible = True


        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvProgramacionesReprogramaciones.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        'centrar columnas
        For Each columna As DataGridViewColumn In dgvProgramacionesReprogramaciones.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        'configurar ancho columnas
        dgvProgramacionesReprogramaciones.Columns("Column1").FillWeight = 50
        dgvProgramacionesReprogramaciones.Columns("Column2").FillWeight = 50

        'dgvAvisos.Columns(dgvAvisosNomClmNombreTit).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmMatriculaTit).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmFechaCreacion).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreEstado).FillWeight = 15
        'dgvAvisos.Columns(dgvBajaNomClmFecPres).FillWeight = 15


        'filas
        dgvProgramacionesReprogramaciones.Rows.Clear()
    End Sub

    Private Sub iniciarControlesGrupo2()
        cViewer.Enabled = True
        cViewer.ShowCloseButton = False
        cViewer.ShowCopyButton = False
        cViewer.ShowExportButton = False
        cViewer.ShowGotoPageButton = False
        cViewer.ShowGroupTreeButton = False
        cViewer.ShowLogo = False
        cViewer.ShowParameterPanelButton = False


        cViewer.ShowPageNavigateButtons = True
        cViewer.ShowPrintButton = True
        cViewer.ShowRefreshButton = True
        cViewer.ShowTextSearchButton = True


        cViewer.ShowZoomButton = True
        cViewer.Zoom(75)


        cViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        cViewer.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController
    End Sub

    Private Sub cargarProcesosAutomaticos()
        If esFormularioSecundario Then iniciarProcesosAutomaticos()
    End Sub

    Private Sub iniciarProcesosAutomaticos()
        Try
            traerProgramaciones()
            poblarDgvProgramacionesReprogramaciones()
            programacionSeleccionada = reporteProg.programaciones(0)
            traerDatosReporte()
            cargarReporte()
            mostrarReporte()
            ajustarZoom(65)

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub








    'METODOS LOGICOS G1
    Private Sub traerProgramaciones()
        Dim desde As Date = dpcDesede.Value
        Dim hasta As Date = dpcHasta.Value
        reporteProg.traerProgramacionesReprogrmaciones(desde, hasta)
    End Sub

    Private Sub seleccionarProgramacion()
        Dim index As Int16

        For Each row As DataGridViewRow In dgvProgramacionesReprogramaciones.SelectedRows
            index = row.Index
        Next

        programacionSeleccionada = reporteProg.programaciones(index)
    End Sub


    'METODOS LOGICOS G2
    Private Sub traerDatosReporte()
        datatableReporte = reporteProg.traerReporte(programacionSeleccionada)
    End Sub

    Private Sub cargarReporte()
        'reporteActual = New MyReportExPre()
        'reporteActual.SetDataSource(datatableReporte)
    End Sub








    'METODOS INTERFAZ G1
    Private Sub poblarDgvProgramacionesReprogramaciones()
        dgvProgramacionesReprogramaciones.Rows.Clear()

        For Each programacion As ProgramacionExamenPreocupacional In reporteProg.programaciones
            Dim index As Int16 = dgvProgramacionesReprogramaciones.Rows.Add()
            Dim rowActual As DataGridViewRow = dgvProgramacionesReprogramaciones.Rows(index)

            rowActual.Cells(0).Value = programacion.getCodigo()
            rowActual.Cells(1).Value = programacion.getFecha().ToString("dd--MM--yyyy")
            rowActual.Cells(2).Value = programacion.getTitular().getMatricula()
            rowActual.Cells(3).Value = programacion.getTitular().getNombres()
        Next
    End Sub


    'METODOS INTERFAZ G2
    Private Sub mostrarReporte()
        cViewer.ReportSource = Nothing
        ' cViewer.ReportSource = reporteActual
    End Sub

    Private Sub ajustarZoom(ByVal _zoom As Integer)
        cViewer.Zoom(_zoom)
    End Sub


    'METODOS INTERFAZ G3
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub






    'EVENTOS G0
    Private Sub MenuAfiliacionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    'EVENTOS G1
    Private Sub btnTraerProgramaciones_Click(sender As Object, e As EventArgs) Handles btnTraerProgramaciones.Click
        Try
            traerProgramaciones()
            poblarDgvProgramacionesReprogramaciones()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvProgramacionesReprogramaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProgramacionesReprogramaciones.CellContentDoubleClick
        Try
            seleccionarProgramacion()
            traerDatosReporte()
            cargarReporte()
            mostrarReporte()
            ajustarZoom(65)

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvProgramacionesReprogramaciones_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvProgramacionesReprogramaciones.RowPostPaint
        Dim grid = TryCast(sender, DataGridView)
        Dim rowIdx = (e.RowIndex + 1).ToString()
        Dim centerFormat = New StringFormat() With
                           {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                           }
        Dim headerBounds = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMenuAfiliacion.Show()
        Me.Close()
    End Sub
End Class