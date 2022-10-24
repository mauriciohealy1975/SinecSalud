Imports NEGOCIO
Public Class FormProcesarAvisosAsignacionesFamiliares

    'ATRIBUTOS LOGICOS
    Private regProcesoAF As RegistroProcesoAvisoAsignacionesFamiliares


    'ATRIBUTOS G1
    Private filtroSeleccionado As Concepto
    Private dgvAvisosNomClmNombreBnf As String,
            dgvAvisosNomClmMatriculaBnf As String,
            dgvAvisosNomClmNombreTit As String,
            dgvAvisosNomClmMatriculaTit As String,
            dgvAvisosNomClmFechaCreacion As String,
            dgvAvisosNomClmNombreEstado As String
    Private avisoSeleccionado As AvisoAsignacionesFamiliares


    'ATRIBUTOS G3
    Private parentescoSeleccionado As Concepto
    Private estadoSeleccionado As Concepto

    'ATRIBUTOS G4
    Dim avisoAcualizado As AvisoAsignacionesFamiliares




    'METODOS INICIO
    Private Sub FormProcesarAvisosAsignacionesFamiliares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
        configurarDisplay()
    End Sub

    Private Sub configurarDisplay()
        Dim ejeX As Int16 = Utilitarios.resolucionEstandarEjeX

        Size = New Size(ejeX, 700)
        MaximumSize = New System.Drawing.Size(ejeX, 700)
        MinimumSize = New System.Drawing.Size(ejeX, 700)
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarFormulario()
        'configurar display
        iniciarControles()
    End Sub

    Private Sub iniciarControles()
        iniciarControlesLogicos()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()
        iniciarControlesGrupo4()

        traerFiltrosFecha()
        poblarCboxFiltroFecha()

        traerParentescos()
        poblarCboxParentescos()

        traerEstadosAviso()
        poblarCboxEstado()
    End Sub

    Private Sub iniciarControlesLogicos()
        regProcesoAF = New RegistroProcesoAvisoAsignacionesFamiliares()
        filtroSeleccionado = New Concepto()
        dgvAvisosNomClmNombreBnf = "nomBnf"
        dgvAvisosNomClmMatriculaBnf = "matBnf"
        dgvAvisosNomClmNombreTit = "nomTit"
        dgvAvisosNomClmMatriculaTit = "matTit"
        dgvAvisosNomClmFechaCreacion = "fecCreacion"
        dgvAvisosNomClmNombreEstado = "nomEstado"
        avisoSeleccionado = New AvisoAsignacionesFamiliares()
        parentescoSeleccionado = New Concepto()
        estadoSeleccionado = New Concepto()
        avisoAcualizado = New AvisoAsignacionesFamiliares()
    End Sub

    Private Sub iniciarControlesGrupo1()
        lblTituloPrincipal.Text = "PROCESAR AVISOS DE ASIGNACIONES FAMILIARES"

        panelAvisos.Enabled = True
        iniciarDgvAvisos()

        cboxFiltroFecha.Enabled = True
        cboxFiltroFecha.Font = New Font("Microsoft Sans Serif", 9)
        cboxFiltroFecha.Items.Clear()
        cboxFiltroFecha.DropDownStyle = ComboBoxStyle.DropDownList

        hintFiltroFecha.Enabled = True
        hintFiltroFecha.Visible = True
        hintFiltroFecha.Font = New Font("Microsoft Sans Serif", 8)
        hintFiltroFecha.Text = "SELECCIONAR"
        hintFiltroFecha.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarDgvAvisos()
        'propiedades base
        dgvAvisos.Enabled = True
        dgvAvisos.Font = New Font("Microsoft Sans Serif", 9)


        'permisos editar
        dgvAvisos.EditMode = DataGridViewEditMode.EditOnEnter
        dgvAvisos.AllowUserToAddRows = False
        dgvAvisos.AllowUserToDeleteRows = True
        dgvAvisos.AllowUserToResizeRows = False
        dgvAvisos.AllowUserToOrderColumns = False
        dgvAvisos.AllowUserToResizeColumns = False
        dgvAvisos.MultiSelect = False
        dgvAvisos.ReadOnly = True


        'estilos
        dgvAvisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvAvisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAvisos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvAvisos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvAvisos.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvAvisos.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvAvisos.DefaultCellStyle.ForeColor = Color.Black
        dgvAvisos.ScrollBars = ScrollBars.Both
        dgvAvisos.EnableHeadersVisualStyles = False



        'columnas
        dgvAvisos.Columns.Clear()

        dgvAvisos.Columns.Add(dgvAvisosNomClmNombreBnf, "Benficiario")
        dgvAvisos.Columns(dgvAvisosNomClmNombreBnf).Visible = True

        dgvAvisos.Columns.Add(dgvAvisosNomClmMatriculaBnf, "Matricula beneficiario")
        dgvAvisos.Columns(dgvAvisosNomClmMatriculaBnf).Visible = True

        dgvAvisos.Columns.Add(dgvAvisosNomClmNombreTit, "Titular")
        dgvAvisos.Columns(dgvAvisosNomClmNombreTit).Visible = True

        dgvAvisos.Columns.Add(dgvAvisosNomClmMatriculaTit, "Matricula titular")
        dgvAvisos.Columns(dgvAvisosNomClmMatriculaTit).Visible = True

        dgvAvisos.Columns.Add(dgvAvisosNomClmFechaCreacion, "Fecha creación aviso")
        dgvAvisos.Columns(dgvAvisosNomClmFechaCreacion).Visible = True

        dgvAvisos.Columns.Add(dgvAvisosNomClmNombreEstado, "Estado")
        dgvAvisos.Columns(dgvAvisosNomClmNombreEstado).Visible = True


        'centrar columnas
        For Each columna As DataGridViewColumn In dgvAvisos.Columns
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
        dgvAvisos.Rows.Clear()
    End Sub

    Private Sub iniciarControlesGrupo2()
        panelDetalleAviso.Enabled = False

        txtBeneficiario.Enabled = True
        txtBeneficiario.Font = New Font("Microsoft Sans Serif", 9)
        txtBeneficiario.Text = ""
        txtBeneficiario.CharacterCasing = CharacterCasing.Upper

        txtTitular.Enabled = True
        txtTitular.Font = New Font("Microsoft Sans Serif", 9)
        txtTitular.Text = ""
        txtTitular.CharacterCasing = CharacterCasing.Upper

        txtMatriculaTitular.Enabled = True
        txtMatriculaTitular.Font = New Font("Microsoft Sans Serif", 9)
        txtMatriculaTitular.Text = ""
        txtMatriculaTitular.CharacterCasing = CharacterCasing.Upper

        txtFechaExpiracion.Enabled = True
        txtFechaExpiracion.Font = New Font("Microsoft Sans Serif", 9)
        txtFechaExpiracion.Text = ""
        txtFechaExpiracion.CharacterCasing = CharacterCasing.Upper

        txtEmpresa.Enabled = True
        txtEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        txtEmpresa.Text = ""
        txtEmpresa.CharacterCasing = CharacterCasing.Upper

        txtProyecto.Enabled = True
        txtProyecto.Font = New Font("Microsoft Sans Serif", 9)
        txtProyecto.Text = ""
        txtProyecto.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarControlesGrupo3()
        panelProcesarAviso.Enabled = False

        txtNombreEjecutor.Enabled = True
        txtNombreEjecutor.Font = New Font("Microsoft Sans Serif", 9)
        txtNombreEjecutor.Text = ""
        txtNombreEjecutor.CharacterCasing = CharacterCasing.Upper

        txtCi.Enabled = True
        txtCi.Font = New Font("Microsoft Sans Serif", 9)
        txtCi.Text = ""
        txtCi.CharacterCasing = CharacterCasing.Upper

        cboxParentesco.Enabled = True
        cboxParentesco.Font = New Font("Microsoft Sans Serif", 9)
        cboxParentesco.Items.Clear()
        cboxParentesco.DropDownStyle = ComboBoxStyle.DropDownList

        hintParentesco.Enabled = True
        hintParentesco.Visible = True
        hintParentesco.Font = New Font("Microsoft Sans Serif", 8)
        hintParentesco.Text = "SELECCIONAR"
        hintParentesco.BackColor = Color.Transparent

        cboxEstado.Enabled = True
        cboxEstado.Font = New Font("Microsoft Sans Serif", 9)
        cboxEstado.Items.Clear()
        cboxEstado.DropDownStyle = ComboBoxStyle.DropDownList

        hintEstado.Enabled = True
        hintEstado.Visible = True
        hintEstado.Font = New Font("Microsoft Sans Serif", 8)
        hintEstado.Text = "SELECCIONAR"
        hintEstado.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarControlesGrupo4()
        btnCancelar.Enabled = True
        btnCancelar.Font = New Font("Microsoft Sans Serif", 9)
        btnCancelar.Text = "Cancelar"

        btnEnviar.Enabled = True
        btnEnviar.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviar.Text = "Procesar aviso"
    End Sub








    'METODOS INFERFAZ G1
    Private Sub poblarCboxFiltroFecha()
        cboxFiltroFecha.Items.Clear()

        For Each filtro As Concepto In regProcesoAF.filtrosFecha
            cboxFiltroFecha.Items.Add(filtro.getDescripcion)
        Next
    End Sub

    Private Sub ocultarHintFiltroFecha()
        hintFiltroFecha.Visible = False
    End Sub

    Private Sub mostrarHintFiltroFecha()
        hintFiltroFecha.Visible = True
    End Sub

    Private Sub deseleccionarEnDgvAvisos()
        dgvAvisos.ClearSelection()
    End Sub

    Private Sub poblarDgvAvisos()
        dgvAvisos.Rows.Clear()


        For Each aviso As AvisoAsignacionesFamiliares In regProcesoAF.avisosAsignaciones
            Dim rowIndex As Int16 = dgvAvisos.Rows.Add()
            Dim rowAux As DataGridViewRow = dgvAvisos.Rows(rowIndex)

            Dim bnfActual As Beneficiario = aviso.getBeneficiario()
            Dim titActual As Titular = aviso.getTitular()

            Dim nombreBeneficiario As String = bnfActual.getApellidoPaterno() + " " + bnfActual.getApellidoMaterno() + " " + bnfActual.getNombres()
            Dim matriculaBeneficiario As String = bnfActual.getMatricula()
            Dim nombreTitular As String = titActual.getApellidoPaterno() + " " + titActual.getApellidoMaterno() + " " + titActual.getNombres()
            Dim matriculaTitular As String = titActual.getMatricula()
            Dim fechaAsignacion As String = aviso.getFechaAsignacion().ToShortDateString()
            Dim descripcionProceso As String = aviso.getEstado().getDescripcion()

            rowAux.Cells(dgvAvisosNomClmNombreBnf).Value = nombreBeneficiario
            rowAux.Cells(dgvAvisosNomClmMatriculaBnf).Value = matriculaBeneficiario
            rowAux.Cells(dgvAvisosNomClmNombreTit).Value = nombreTitular
            rowAux.Cells(dgvAvisosNomClmMatriculaTit).Value = matriculaTitular
            rowAux.Cells(dgvAvisosNomClmFechaCreacion).Value = fechaAsignacion
            rowAux.Cells(dgvAvisosNomClmNombreEstado).Value = descripcionProceso
        Next
    End Sub



    'METODOS INFERFAZ G2
    Private Sub deshabilitarPanelDetalleAviso()
        panelDetalleAviso.Enabled = False
    End Sub

    Private Sub habilitarPanelDetalleAviso()
        panelDetalleAviso.Enabled = True
    End Sub

    Private Sub reiniciarInputsPanelDetalleAviso()
        txtBeneficiario.Text = ""
        txtTitular.Text = ""
        txtMatriculaTitular.Text = ""
        txtFechaExpiracion.Text = ""
        txtEmpresa.Text = ""
        txtProyecto.Text = ""
    End Sub

    Private Sub mostrarInformacionAviso()
        Dim titular As Titular = avisoSeleccionado.getTitular()
        Dim empresa As Empresa = avisoSeleccionado.getEmpresa()
        Dim beneficiario As Beneficiario = avisoSeleccionado.getBeneficiario()
        Dim programaproyecto As ProgramaProyecto = avisoSeleccionado.getProgramaProyecto()

        Dim nombreBeneficiario As String = beneficiario.getApellidoPaterno() + " " + beneficiario.getApellidoMaterno() + " " + beneficiario.getNombres()
        Dim nombreTitular As String = titular.getApellidoPaterno() + " " + titular.getApellidoMaterno() + " " + titular.getNombres()
        Dim matriculaTitular As String = titular.getMatricula()
        Dim nombreEmpresa As String = empresa.getNombre()
        Dim fechaExpiracion As String = avisoSeleccionado.getFechaFinAsignacion().ToString("dd-MM-yyyy")
        Dim nombreProgramaProyecto As String = programaproyecto.getNombre()

        txtBeneficiario.Text = nombreBeneficiario
        txtTitular.Text = nombreTitular
        txtMatriculaTitular.Text = matriculaTitular
        txtFechaExpiracion.Text = fechaExpiracion
        txtEmpresa.Text = nombreEmpresa
        txtProyecto.Text = nombreProgramaProyecto
    End Sub



    'METODOS INTERFAZ G3
    Private Sub deshabilitarPanelProcesarAviso()
        panelProcesarAviso.Enabled = False
    End Sub

    Private Sub habilitarPanelProcesarAviso()
        panelProcesarAviso.Enabled = True
    End Sub

    Private Sub reiniciarInputsPanelProcesarAviso()

        txtNombreEjecutor.Text = ""
        txtCi.Text = ""
        cboxParentesco.SelectedIndex = -1
        mostrarHintParentesco()
        cboxEstado.SelectedIndex = -1
        mostrarHintEstado()
    End Sub

    Private Sub poblarCboxParentescos()
        cboxParentesco.Items.Clear()

        For Each parentesco As Concepto In regProcesoAF.parentescos
            cboxParentesco.Items.Add(parentesco.getDescripcion())
        Next
    End Sub

    Private Sub ocultarHintParentesco()
        hintParentesco.Visible = False
    End Sub

    Private Sub mostrarHintParentesco()
        hintParentesco.Visible = True
    End Sub

    Private Sub poblarCboxEstado()
        cboxEstado.Items.Clear()

        For Each estado As Concepto In regProcesoAF.estados
            cboxEstado.Items.Add(estado.getDescripcion())
        Next
    End Sub

    Private Sub ocultarHintEstado()
        hintEstado.Visible = False
    End Sub

    Private Sub mostrarHintEstado()
        hintEstado.Visible = True
    End Sub

    Private Sub deshabilitarInputsEjecutorAviso()
        txtNombreEjecutor.Enabled = False
        txtNombreEjecutor.Text = ""

        txtCi.Enabled = False
        txtCi.Text = ""

        cboxParentesco.Enabled = False
        cboxParentesco.SelectedIndex = -1
        parentescoSeleccionado = New Concepto()

        mostrarHintParentesco()
        hintParentesco.Enabled = False
    End Sub

    Private Sub habilitarInputsEjecutorAviso()
        txtNombreEjecutor.Enabled = True
        txtCi.Enabled = True
        cboxParentesco.Enabled = True
        hintParentesco.Enabled = True
    End Sub



    'METODOS INTERFAZ G4
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub









    'METODOS LOGICOS G1
    Private Sub seleccionarFiltroFecha()
        Dim index As Int16 = cboxFiltroFecha.SelectedIndex
        filtroSeleccionado = regProcesoAF.filtrosFecha(index)
    End Sub

    Private Sub traerFiltrosFecha()
        regProcesoAF.traerFiltrosPorFecha()
    End Sub

    Private Sub traerAvisos()
        Dim opcion As Int16 = filtroSeleccionado.getCorrelativo()
        regProcesoAF.traerAvisos(opcion)
    End Sub

    Private Sub seleccionarAviso()
        Dim index As Int16

        For Each row As DataGridViewRow In dgvAvisos.SelectedRows
            index = row.Index
        Next
        avisoSeleccionado = regProcesoAF.avisosAsignaciones(index)
    End Sub

    Private Sub reiniciarAvisoSeleccionado()
        avisoSeleccionado = New AvisoAsignacionesFamiliares()
    End Sub


    'METODOS LOGICOS G3
    Private Sub traerParentescos()
        regProcesoAF.traerParentescos()
    End Sub

    Private Sub seleccionarParentesco()
        Dim index As Int16 = cboxParentesco.SelectedIndex
        parentescoSeleccionado = regProcesoAF.parentescos(index)
    End Sub

    Private Sub traerEstadosAviso()
        regProcesoAF.traerEstadosAviso()
    End Sub

    Private Sub seleccionarEstado()
        Dim index As Int16 = cboxEstado.SelectedIndex
        estadoSeleccionado = regProcesoAF.estados(index)
    End Sub

    Private Sub bloquearEstadoEnProceso()
        Dim index As Int16 = cboxEstado.SelectedIndex
        If index = 0 Then
            cboxEstado.SelectedIndex = -1
            mostrarHintEstado()
            estadoSeleccionado = New Concepto()
            Throw New ArgumentException("Error. Este aviso ya se encuentra en proceso. Seleccione otro estado.")
        End If
    End Sub

    Private Function revisarEsEstadoNoRecojido()
        If estadoSeleccionado.getCorrelativo = 3 Then Return True Else Return False
    End Function


    'METODOS LOGICOS G4
    Private Function cargarDatos() As Boolean
        Try
            Dim codigo As Int64 = avisoSeleccionado.getCodigo()
            Dim nombreEjecutor As String = txtNombreEjecutor.Text.Trim()
            Dim ciEjecutor As String = txtCi.Text.Trim()


            avisoAcualizado.setCodigo(codigo)
            avisoAcualizado.setNombreEjecutor(nombreEjecutor)
            avisoAcualizado.setCiEjecutor(ciEjecutor)
            avisoAcualizado.setParentescoEjecutor(parentescoSeleccionado)
            avisoAcualizado.setEstado(estadoSeleccionado)
            avisoAcualizado.setFechaProceso(Today.Date)
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try

    End Function

    Private Function validarEntradas() As String
        Dim mensaje As String = regProcesoAF.validarEntradas(avisoAcualizado)
        Return mensaje
    End Function

    Private Sub guardarAvisoActualizado()
        Try
            Dim respuesta As Int16 = updateAvisos()

            If respuesta > 0 Then
                mostrarMensaje("El aviso se procesó correctamente.")
                reiniciarFormulario()

            ElseIf respuesta < 0 Then
                mostrarMensaje("Error. No se pudo procesar el aviso.")
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            mostrarMensaje("Error. No se pudo procesar el aviso.")
        End Try
    End Sub

    Private Function updateAvisos()
        Dim respuesta As Int16 = regProcesoAF.updateAviso(Me.Text, avisoAcualizado)
        Return respuesta
    End Function

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub











    'EVENTOS G1
    Private Sub cboxFiltroFecha_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles cboxFiltroFecha.SelectionChangeCommitted
        Try
            seleccionarFiltroFecha()
            ocultarHintFiltroFecha()
            traerAvisos()
            poblarDgvAvisos()
            deseleccionarEnDgvAvisos()
            deshabilitarPanelDetalleAviso()
            reiniciarInputsPanelDetalleAviso()
            deshabilitarPanelProcesarAviso()
            reiniciarInputsPanelProcesarAviso()
            reiniciarAvisoSeleccionado()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvAvisos_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvisos.CellDoubleClick
        Try
            seleccionarAviso()
            habilitarPanelDetalleAviso()
            reiniciarInputsPanelDetalleAviso()
            habilitarPanelProcesarAviso()
            reiniciarInputsPanelProcesarAviso()

            mostrarInformacionAviso()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvAvisos_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvAvisos.RowPostPaint
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


    'EVENTOS G3
    Private Sub cboxParentesco_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxParentesco.SelectionChangeCommitted
        Try
            seleccionarParentesco()
            ocultarHintParentesco()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxEstado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxEstado.SelectionChangeCommitted
        Try
            seleccionarEstado()
            ocultarHintEstado()
            bloquearEstadoEnProceso()
            Dim esEstadoNoRecojido As Boolean = revisarEsEstadoNoRecojido()
            If esEstadoNoRecojido Then deshabilitarInputsEjecutorAviso() Else habilitarInputsEjecutorAviso()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    'EVENTOS G4
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim datosCargados As Boolean = cargarDatos()

        If datosCargados Then
            Dim mensajeValidacion As String = validarEntradas()
            If mensajeValidacion = "" Then guardarAvisoActualizado() Else mostrarMensaje(mensajeValidacion)
        End If
    End Sub


End Class