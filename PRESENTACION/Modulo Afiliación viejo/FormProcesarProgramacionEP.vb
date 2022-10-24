Imports NEGOCIO
Public Class FormProcesarProgramacionEP

    'ATRIBUTOS LÓGICOS
    Private regProceso As RegistroProcesoProgramcionExamenPreocupacional

    'ATRIBUTOS G1
    Private nomClmCodigo As String,
            nomClmEstado As String,
            nomClmMatricula As String,
            nomClmTitular As String
    Private programacionSeleccionada As ProgramacionExamenPreocupacional

    'ATRIBUTOS G2
    Private estadoSeleccionado As Concepto

    'ATRIBUTOS G3
    Private esReprogramacionLaboratorio As Boolean
    Private esReprogramacionRayosX As Boolean
    Private esReprogramacionMedicoLaboral As Boolean
    Private reprogramacionObligatoriaML As Boolean
    Private reprogramacionTotal As Boolean


    'ATRIBUTOS G4
    Private programacionActualizada As ProgramacionExamenPreocupacional
    Private nuevaReprogramacion As ReprogramacionExamenPreocupacional


    'METODOS INICIO
    Private Sub FormProcesarProgramacionEP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        MaximumSize = New System.Drawing.Size(ejeX, ejeY)
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarControles()
        iniciarControlesLogicos()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()
        iniciarControlesGrupo4()

        traerEstados()
        poblarCboxEstado()
    End Sub

    Private Sub iniciarControlesLogicos()
        regProceso = New RegistroProcesoProgramcionExamenPreocupacional()

        'G1
        nomClmCodigo = "clmCodigo"
        nomClmEstado = "clmEstado"
        nomClmMatricula = "clmMatricula"
        nomClmTitular = "clmTitular"
        programacionSeleccionada = New ProgramacionExamenPreocupacional()

        'G2
        estadoSeleccionado = New Concepto()

        'G3
        esReprogramacionLaboratorio = False
        esReprogramacionRayosX = False
        esReprogramacionMedicoLaboral = False
        reprogramacionObligatoriaML = False
        reprogramacionTotal = False

        'G4
        programacionActualizada = New ProgramacionExamenPreocupacional()
        nuevaReprogramacion = New ReprogramacionExamenPreocupacional()
    End Sub

    Private Sub iniciarControlesGrupo1()
        panelTraerProgramcion.Enabled = True

        dpcProgramciones.Enabled = True
        dpcProgramciones.ShowUpDown = True
        dpcProgramciones.Font = New Font("Microsoft Sans Serif", 9)
        dpcProgramciones.Format = DateTimePickerFormat.Custom
        dpcProgramciones.CustomFormat = "dd--MM--yyyy"
        dpcProgramciones.Value = Date.Today.Date
        dpcProgramciones.MaxDate = Date.Today.Date

        btnTraerProgramaciones.Enabled = True
        btnTraerProgramaciones.Visible = True
        btnTraerProgramaciones.Font = New Font("Microsoft Sans Serif", 9)
        btnTraerProgramaciones.Text = "Traer programaciones"

        iniciarDgvProgramaciones()
    End Sub

    Public Sub iniciarDgvProgramaciones()
        'propiedades base
        dgvProgramaciones.Enabled = True
        dgvProgramaciones.Font = New Font("Microsoft Sans Serif", 9)


        'permisos editar
        dgvProgramaciones.EditMode = DataGridViewEditMode.EditOnEnter
        dgvProgramaciones.AllowUserToAddRows = False
        dgvProgramaciones.AllowUserToDeleteRows = True
        dgvProgramaciones.AllowUserToResizeRows = False
        dgvProgramaciones.AllowUserToOrderColumns = False
        dgvProgramaciones.AllowUserToResizeColumns = False
        dgvProgramaciones.MultiSelect = False
        dgvProgramaciones.ReadOnly = True


        'estilos
        dgvProgramaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvProgramaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProgramaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvProgramaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvProgramaciones.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvProgramaciones.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvProgramaciones.RowHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvProgramaciones.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvProgramaciones.DefaultCellStyle.ForeColor = Color.Black
        dgvProgramaciones.ScrollBars = ScrollBars.Both
        dgvProgramaciones.EnableHeadersVisualStyles = False


        'columnas -- agregar columnas
        dgvProgramaciones.Columns.Clear()

        dgvProgramaciones.Columns.Add(nomClmCodigo, "CÓDIGO")
        dgvProgramaciones.Columns(nomClmCodigo).Visible = True

        dgvProgramaciones.Columns.Add(nomClmEstado, "ESTADO")
        dgvProgramaciones.Columns(nomClmEstado).Visible = True

        dgvProgramaciones.Columns.Add(nomClmMatricula, "MATRÍCULA")
        dgvProgramaciones.Columns(nomClmMatricula).Visible = True

        dgvProgramaciones.Columns.Add(nomClmTitular, "TITULAR")
        dgvProgramaciones.Columns(nomClmTitular).Visible = True


        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvProgramaciones.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        'centrar columnas
        For Each columna As DataGridViewColumn In dgvProgramaciones.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        'configurar ancho columnas
        'dgvAvisos.Columns(dgvAvisosNomClmMatriculaBnf).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreBnf).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreTit).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmMatriculaTit).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmFechaCreacion).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreEstado).FillWeight = 15
        'dgvAvisos.Columns(dgvBajaNomClmFecPres).FillWeight = 15

        'filas
        dgvProgramaciones.Rows.Clear()
    End Sub

    Private Sub iniciarControlesGrupo2()
        panelProcesarProgramacion.Enabled = True

        txtCodigo.Enabled = True
        txtCodigo.Visible = True
        txtCodigo.Font = New Font("Microsoft Sans Serif", 9)
        txtCodigo.Text = ""
        txtCodigo.CharacterCasing = CharacterCasing.Upper

        txtTitular.Enabled = True
        txtTitular.Visible = True
        txtTitular.Font = New Font("Microsoft Sans Serif", 9)
        txtTitular.Text = ""
        txtTitular.CharacterCasing = CharacterCasing.Upper

        txtEmpresa.Enabled = True
        txtEmpresa.Visible = True
        txtEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        txtEmpresa.Text = ""
        txtEmpresa.CharacterCasing = CharacterCasing.Upper

        cboxEstado.Enabled = True
        cboxEstado.Visible = True
        cboxEstado.Font = New Font("Microsoft Sans Serif", 8)
        cboxEstado.Items.Clear()
        cboxEstado.DropDownStyle = ComboBoxStyle.DropDownList

        hintEstado.Enabled = True
        hintEstado.Visible = True
        hintEstado.Font = New Font("Microsoft Sans Serif", 8)
        hintEstado.Text = "SELECCIONAR"
        hintEstado.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarControlesGrupo3()
        panelReprogramacion.Enabled = False

        chLaboratorio.Enabled = True
        chLaboratorio.Visible = True
        chLaboratorio.Checked = False
        chLaboratorio.Font = New Font("Microsoft Sans Serif", 9)
        chLaboratorio.Text = "Reprogramar laboratorio"

        dpcLaboratorio.Enabled = False
        dpcLaboratorio.ShowUpDown = False
        dpcLaboratorio.Font = New Font("Microsoft Sans Serif", 9)
        dpcLaboratorio.Format = DateTimePickerFormat.Custom
        dpcLaboratorio.CustomFormat = "dd--MM--yyyy"
        dpcLaboratorio.Value = Date.Today.Date
        dpcLaboratorio.MinDate = Date.Today.Date

        chRayosX.Enabled = True
        chRayosX.Visible = True
        chRayosX.Checked = False
        chRayosX.Font = New Font("Microsoft Sans Serif", 9)
        chRayosX.Text = "Reprogramar Rayos X"

        dpcRayosX.Enabled = False
        dpcRayosX.ShowUpDown = False
        dpcRayosX.Font = New Font("Microsoft Sans Serif", 9)
        dpcRayosX.Format = DateTimePickerFormat.Custom
        dpcRayosX.CustomFormat = "dd--MM--yyyy"
        dpcRayosX.Value = Date.Today.Date
        dpcRayosX.MinDate = Date.Today.Date

        chMedicoLaboral.Enabled = True
        chMedicoLaboral.Visible = True
        chMedicoLaboral.Checked = False
        chMedicoLaboral.Font = New Font("Microsoft Sans Serif", 9)
        chMedicoLaboral.Text = "Reprogramar Médico laboral"

        dpcMedicoLaboral.Enabled = False
        dpcMedicoLaboral.ShowUpDown = False
        dpcMedicoLaboral.Font = New Font("Microsoft Sans Serif", 9)
        dpcMedicoLaboral.Format = DateTimePickerFormat.Custom
        dpcMedicoLaboral.CustomFormat = "dd--MM--yyyy"
        dpcMedicoLaboral.Value = Date.Today.Date
        dpcMedicoLaboral.MinDate = Date.Today.Date

        lblFichas.Enabled = False

        txtFichas.Enabled = False
        txtFichas.Visible = True
        txtFichas.ReadOnly = True
        txtFichas.Font = New Font("Microsoft Sans Serif", 9)
        txtFichas.Text = ""
        txtFichas.CharacterCasing = CharacterCasing.Upper

        dpcMedicoLaboral.Value = Today.AddDays(1)
        dpcMedicoLaboral.Value = Today
    End Sub

    Private Sub iniciarControlesGrupo4()
        btnCancelar.Enabled = True
        btnCancelar.Visible = True
        btnCancelar.Font = New Font("Microsoft Sans Serif", 9)
        btnCancelar.Text = "Cancelar"

        btnEnviar.Enabled = True
        btnEnviar.Visible = True
        btnEnviar.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviar.Text = "Procesar programación"
    End Sub









    'METODOS LÓGICOS G1
    Private Sub traerProgramaciones()
        Dim fecha As Date = dpcProgramciones.Value
        regProceso.traerProgramaciones(fecha)
    End Sub

    Private Sub seleccionarProgramacion()
        Dim index As Int16 = 0

        For Each row As DataGridViewRow In dgvProgramaciones.SelectedRows
            index = row.Index
        Next

        programacionSeleccionada = regProceso.programaciones(index)
    End Sub

    Private Sub reiniciarProgramacionSeleccionada()
        programacionSeleccionada = New ProgramacionExamenPreocupacional()
    End Sub


    'METODOS LOGICOS G2
    Private Sub traerEstados()
        regProceso.traerEstados()
    End Sub

    Private Sub seleccionarEstado()
        Dim index As Int16 = cboxEstado.SelectedIndex
        estadoSeleccionado = regProceso.estados(index)
    End Sub

    Private Function esReprogamacion() As Boolean
        Dim esReprogramacion As Boolean = regProceso.esReprogramacion(estadoSeleccionado)
        If esReprogramacion Then Return True Else Return False
    End Function

    Private Sub reiniciarEstadoSeleccionado()
        estadoSeleccionado = New Concepto()
    End Sub

    Private Sub reiniciarCboxEstado()
        cboxEstado.SelectedIndex = -1
        mostrarHintEstado()
    End Sub


    'METODOS LOGICOS G3
    Private Sub cargarEstadoReprogramacionLaboratorio()
        If chLaboratorio.Checked Then esReprogramacionLaboratorio = True Else esReprogramacionLaboratorio = False
    End Sub

    Private Sub cargarEstadoReprogrmacionRayosX()
        If chRayosX.Checked Then esReprogramacionRayosX = True Else esReprogramacionRayosX = False
    End Sub

    Private Sub cargarEstadoReprogramacionMedicoLaboral()
        If chMedicoLaboral.Checked Then esReprogramacionMedicoLaboral = True Else esReprogramacionMedicoLaboral = False
    End Sub

    Private Sub cargarReprogramacionObligatoriaML()
        If esReprogramacionLaboratorio Or esReprogramacionRayosX Then reprogramacionObligatoriaML = True Else reprogramacionObligatoriaML = False
    End Sub

    Private Sub cargarReprogramacionTotal()
        If esReprogramacionLaboratorio And esReprogramacionRayosX And esReprogramacionMedicoLaboral Then
            reprogramacionTotal = True
        Else
            reprogramacionTotal = False
        End If

    End Sub

    Private Sub actualizarFechaRayosX()
        Dim fechaLab As Date = dpcLaboratorio.Value
        Dim fechaRayosX As Date = regProceso.generarFechaRayosX(fechaLab)
        dpcRayosX.Value = fechaRayosX
    End Sub

    Private Sub actualizarFechaMedicoLaboral()
        Dim fechaLab As Date = dpcLaboratorio.Value
        Dim fechaRayosX As Date = dpcRayosX.Value
        Dim fechaMedicoLaboral As Date


        If reprogramacionTotal Then
            fechaMedicoLaboral = regProceso.generarFechaMedicoLaboral(fechaLab)
        Else
            If esReprogramacionLaboratorio Then fechaMedicoLaboral = regProceso.generarFechaMedicoLaboral(fechaLab)

            If esReprogramacionRayosX Then fechaMedicoLaboral = regProceso.generarFechaMedicoLaboral(fechaRayosX)
        End If

        dpcMedicoLaboral.Value = fechaMedicoLaboral
    End Sub

    Private Sub cargarFichasDisponibles()
        Dim fecha As Date = dpcMedicoLaboral.Value
        regProceso.cargarFichasDisponibles(fecha)
    End Sub


    'METODOS LOGICOS G4
    Private Function cargarDatos() As Boolean
        Dim datosCargados As Boolean


        Try
            Dim estado As Int16,
                fechaCompletitud As Date,
                programacion As ProgramacionExamenPreocupacional


            estado = estadoSeleccionado.getCorrelativo()
            fechaCompletitud = Today


            programacion = New ProgramacionExamenPreocupacional()
            programacion = programacionSeleccionada
            programacion.setEstadoCompletitud(estadoSeleccionado)
            programacion.setFechaCompletitud(fechaCompletitud)
            programacionActualizada = programacion


            If estado = 2 Then
                Dim reprogramacion As ReprogramacionExamenPreocupacional,
                    codigoProgramacion As Int64,
                    titular As Titular,
                    fechaReprogramacion As Date,
                    reprogramacionLab As Int16,
                    reprogramacionRayosX As Int16,
                    reprogramacionMedLaboral As Int16,
                    fechaLab As Date,
                    fechaRX As Date,
                    fechaMedLab As Date


                codigoProgramacion = programacionActualizada.getCodigo()
                titular = programacionActualizada.getTitular()
                fechaReprogramacion = Today.Date
                If esReprogramacionLaboratorio Then reprogramacionLab = 1 Else reprogramacionLab = 0
                If esReprogramacionRayosX Then reprogramacionRayosX = 1 Else reprogramacionRayosX = 0
                If esReprogramacionMedicoLaboral Then reprogramacionMedLaboral = 1 Else reprogramacionMedLaboral = 0
                fechaLab = dpcLaboratorio.Value
                fechaRX = dpcRayosX.Value
                fechaMedLab = dpcMedicoLaboral.Value


                reprogramacion = New ReprogramacionExamenPreocupacional()
                reprogramacion.setCodigoProgramacion(codigoProgramacion)
                reprogramacion.setTitular(titular)
                reprogramacion.setFecha(fechaReprogramacion)
                reprogramacion.setReprogramacionLaboratorio(reprogramacionLab)
                reprogramacion.setReprogramacionRayosX(reprogramacionRayosX)
                reprogramacion.setReprogramacionMedicoLaboral(reprogramacionMedLaboral)
                reprogramacion.setFechaLaboratorio(fechaLab)
                reprogramacion.setFechaRayosX(fechaRX)
                reprogramacion.setFechaMedicoLaboral(fechaMedLab)
                nuevaReprogramacion = reprogramacion
            End If
            datosCargados = True


        Catch ex As Exception
            programacionActualizada = New ProgramacionExamenPreocupacional()
            nuevaReprogramacion = New ReprogramacionExamenPreocupacional()
            mostrarMensaje(ex.Message)
            datosCargados = False
        End Try


        Return datosCargados
    End Function

    Private Function validarEntradas() As String
        Dim mensaje As String = regProceso.validarEntradas(programacionActualizada, esReprogramacionLaboratorio, esReprogramacionRayosX, esReprogramacionMedicoLaboral,
                                                           nuevaReprogramacion)
        Return mensaje
    End Function

    Private Sub updateDatos()
        Try
            Dim estado As Int16 = estadoSeleccionado.getCorrelativo()

            'BEGIN TRANSATACTION
            updateProgrmacion()
            If estado = 2 Then
                insertReprogramacion()
                mostrarReporte()
            End If
            reiniciarFormulario()
            'IF WORKS, COMMIT TRANSATACION

        Catch ex As Exception
            'IF THERE IS RERROR, ROLL BACK TRANSACTION
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub updateProgrmacion()
        Dim respuesta As Int16 = regProceso.updateProgramacion(programacionActualizada, Me.Text)

        If respuesta > 0 Then
            mostrarMensaje("La programación se procesó correctamente.")

        ElseIf respuesta < 0 Then
            mostrarMensaje("Hubo un error al procesar la programación.")
            'THORW EXCEPTION FOR ROLL BACK TRANSACTION
        End If
    End Sub

    Private Sub insertReprogramacion()
        Dim respuesta As Int16 = regProceso.insertReprogramacion(nuevaReprogramacion)

        If respuesta > 0 Then
            mostrarMensaje("La reprogramación se guardó correctamente.")

        ElseIf respuesta < 0 Then
            mostrarMensaje("Hubo un error al guardar la reprogramación.")
            'THOW EXECPTION FOR ROLL BACK TRANSACTION
        End If
    End Sub

    Private Sub mostrarReporte()
        Dim formReporte As FormReporteProgrmacionExamenPreocupacional
        formReporte = New FormReporteProgrmacionExamenPreocupacional(True)
        formReporte.ShowDialog()
    End Sub

    Private Sub actualizarProgrmacion()
        Dim datosCargados As Boolean = cargarDatos()

        If datosCargados Then
            Dim mensajeValidacion As String = validarEntradas()
            If mensajeValidacion = "" Then updateDatos() Else mostrarMensaje(mensajeValidacion)
        End If
    End Sub

    Private Sub cancelarRegistro()
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de cancelar?", "Cancelar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then reiniciarFormulario()
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub









    'METODOS INTERFAZ G1
    Private Sub poblarDgvProgramaciones()
        dgvProgramaciones.Rows.Clear()

        Dim programaciones As ProgramacionExamenPreocupacional() = regProceso.programaciones
        For Each programacion As ProgramacionExamenPreocupacional In programaciones
            Dim index As Int16 = dgvProgramaciones.Rows.Add()
            Dim rowActual As DataGridViewRow = dgvProgramaciones.Rows(index)

            rowActual.Cells(nomClmCodigo).Value = programacion.getCodigo()
            rowActual.Cells(nomClmEstado).Value = programacion.getEstadoCompletidud().getDescripcion()
            rowActual.Cells(nomClmMatricula).Value = programacion.getTitular().getMatricula()
            rowActual.Cells(nomClmTitular).Value = programacion.getTitular().getNombres()
        Next
    End Sub

    Private Sub mostrarInfoProgramacion()
        Dim codigo As Int16, nomtitular As String, nomEmpresa As String

        codigo = programacionSeleccionada.getCodigo()
        nomtitular = programacionSeleccionada.getTitular().getNombres()
        nomEmpresa = programacionSeleccionada.getEmpresa().getNombre()

        txtCodigo.Text = codigo
        txtTitular.Text = nomtitular
        txtEmpresa.Text = nomEmpresa
    End Sub

    Private Sub deseleccionarEnDgv()
        dgvProgramaciones.ClearSelection()
    End Sub


    'METODOS INTERFAZ G2
    Private Sub poblarCboxEstado()
        cboxEstado.Items.Clear()

        For Each estado As Concepto In regProceso.estados
            cboxEstado.Items.Add(estado.getDescripcion())
        Next
    End Sub

    Private Sub ocultarHintEstado()
        hintEstado.Visible = False
    End Sub

    Private Sub mostrarHintEstado()
        hintEstado.Visible = True
    End Sub

    Private Sub reiniciarTxtProgramacionSeleccionada()
        txtCodigo.Text = ""
        txtTitular.Text = ""
        txtEmpresa.Text = ""
    End Sub


    'METODOS INTERFAZ G3
    Private Sub habilitarPanelReprogramacion()
        panelReprogramacion.Enabled = True
    End Sub

    Private Sub deshabilitarPanelReprogramacion()
        panelReprogramacion.Enabled = False
    End Sub

    Private Sub habilitarDpcLaboratorio()
        dpcLaboratorio.Enabled = True
    End Sub

    Private Sub deshabilitarDpcLaboratorio()
        dpcLaboratorio.Enabled = False
    End Sub

    Private Sub habilitarDpcRayosX()
        dpcRayosX.Enabled = True
    End Sub

    Private Sub deshabilitarDpcRayosX()
        dpcRayosX.Enabled = False
    End Sub

    Private Sub habilitarDpcMedicoLaboral()
        dpcMedicoLaboral.Enabled = True
    End Sub

    Private Sub deshabilitarDpcMedicoLaboral()
        dpcMedicoLaboral.Enabled = False
    End Sub

    Private Sub habilitarControlesFichas()
        lblFichas.Enabled = True
        txtFichas.Enabled = True
    End Sub

    Private Sub deshabilitarControlesFichas()
        lblFichas.Enabled = False
        txtFichas.Enabled = False
    End Sub

    Private Sub habilitarChMedicoLaboral()
        chMedicoLaboral.Enabled = True
    End Sub

    Private Sub deshabilitarChMedicoLaboral()
        chMedicoLaboral.Enabled = False
    End Sub

    Private Sub tickearChMedicoLaboral()
        chMedicoLaboral.Checked = True
    End Sub

    Private Sub destickearChMedicoLaboral()
        chMedicoLaboral.Checked = False
    End Sub

    Private Sub mostrarFichasDisponibles()
        Dim fichasDisponibles As Int16 = regProceso.fichasDisponibles
        txtFichas.Text = fichasDisponibles
    End Sub


    'METODOS INTERFAZ G4
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub

    Private Sub cambiarTextoBtnEnviar()
        btnEnviar.Text = "Procesar y generar nueva reprogramación"
    End Sub

    Private Sub reiniciarTextBtnEnviar()
        btnEnviar.Text = "Procesar programación"
    End Sub





    'EVENTOS GRUPO 1
    Private Sub btnTraerProgramaciones_Click(sender As Object, e As EventArgs) Handles btnTraerProgramaciones.Click
        Try
            reiniciarProgramacionSeleccionada()
            reiniciarTxtProgramacionSeleccionada()
            reiniciarCboxEstado()
            reiniciarEstadoSeleccionado()

            traerProgramaciones()
            poblarDgvProgramaciones()
            deseleccionarEnDgv()
            deshabilitarPanelReprogramacion()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvProgramaciones_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvProgramaciones.RowPostPaint
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

    Private Sub dgvProgramaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProgramaciones.CellContentDoubleClick
        Try
            seleccionarProgramacion()
            mostrarInfoProgramacion()
            reiniciarEstadoSeleccionado()
            reiniciarCboxEstado()
            deshabilitarPanelReprogramacion()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS GRUPO 2
    Private Sub cboxEstado_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles cboxEstado.SelectionChangeCommitted
        Try
            seleccionarEstado()
            ocultarHintEstado()

            If esReprogamacion() Then
                habilitarPanelReprogramacion()
                cambiarTextoBtnEnviar()

            Else
                deshabilitarPanelReprogramacion()
                reiniciarTextBtnEnviar()
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS GRUPO 3
    Private Sub chLaboratorio_CheckedChanged(sender As Object, e As EventArgs) Handles chLaboratorio.CheckedChanged
        Try
            cargarEstadoReprogramacionLaboratorio()
            cargarReprogramacionObligatoriaML()


            If esReprogramacionLaboratorio Then habilitarDpcLaboratorio() Else deshabilitarDpcLaboratorio()


            If reprogramacionObligatoriaML Then
                tickearChMedicoLaboral()
                actualizarFechaMedicoLaboral()
                deshabilitarChMedicoLaboral()
                deshabilitarDpcMedicoLaboral()
            Else
                destickearChMedicoLaboral()
                habilitarChMedicoLaboral()
            End If


            cargarReprogramacionTotal()


            If reprogramacionTotal Then
                actualizarFechaRayosX()
                deshabilitarDpcRayosX()
            Else
                If esReprogramacionRayosX Then habilitarDpcRayosX()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub chRayosX_CheckedChanged(sender As Object, e As EventArgs) Handles chRayosX.CheckedChanged
        Try
            cargarEstadoReprogrmacionRayosX()
            cargarReprogramacionObligatoriaML()


            If esReprogramacionRayosX Then habilitarDpcRayosX() Else deshabilitarDpcRayosX()


            If reprogramacionObligatoriaML Then
                tickearChMedicoLaboral()
                actualizarFechaMedicoLaboral()
                deshabilitarChMedicoLaboral()
                deshabilitarDpcMedicoLaboral()
            Else
                destickearChMedicoLaboral()
                habilitarChMedicoLaboral()
            End If


            cargarReprogramacionTotal()


            If reprogramacionTotal Then
                actualizarFechaRayosX()
                deshabilitarDpcRayosX()
            Else
                If esReprogramacionRayosX Then habilitarDpcRayosX()
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub chMedicoLaboral_CheckedChanged(sender As Object, e As EventArgs) Handles chMedicoLaboral.CheckedChanged
        Try
            cargarEstadoReprogramacionMedicoLaboral()
            cargarReprogramacionObligatoriaML()

            If esReprogramacionMedicoLaboral And Not reprogramacionObligatoriaML Then
                habilitarDpcMedicoLaboral()
            Else
                deshabilitarDpcMedicoLaboral()
            End If

            If esReprogramacionMedicoLaboral Then habilitarControlesFichas() Else deshabilitarControlesFichas()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dpcLaboratorio_ValueChanged(sender As Object, e As EventArgs) Handles dpcLaboratorio.ValueChanged
        Try
            If esReprogramacionLaboratorio And esReprogramacionRayosX Then actualizarFechaRayosX()
            If esReprogramacionLaboratorio Then actualizarFechaMedicoLaboral()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dpcRayosX_ValueChanged(sender As Object, e As EventArgs) Handles dpcRayosX.ValueChanged
        Try
            If esReprogramacionRayosX Then actualizarFechaMedicoLaboral()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    Private Sub dpcMedicoLaboral_ValueChanged(sender As Object, e As EventArgs) Handles dpcMedicoLaboral.ValueChanged
        Try
            cargarFichasDisponibles()
            mostrarFichasDisponibles()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS GRUPO 4
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            actualizarProgrmacion()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub




End Class

