Imports NEGOCIO

Public Class FormAsignarTurno


    Private oAsigTurno As AsignacionTurno
    Private oTurno As Turno
    Private tipoTurno As Char
    Public oDuracionFichaSeleccionada As Concepto

    Private nomColumnaCodTurno As String
    Private nomColumnaHoraEntranda As String
    Private nomColumnaHoraSalida As String
    Private nomColumnaNroFichas As String
    Private nomColumnaMañana As String
    Private nomColumnaTarde As String
    Private nomColumnaLunes As String
    Private nomColumnaMartes As String
    Private nomColumnaMiercoles As String
    Private nomColumnaJueves As String
    Private nomColumnaViernes As String
    Private nomColumnaEditar As String


    Dim rowModelo As DataGridViewRow


    'METOODS INICIO
    Private Sub FormAsignarTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Public Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
    End Sub

    Private Sub configurarDisplay()
        Dim ejeX As Int16 = Utilitarios.resolucionEstandarEjeX
        Dim ejeY As Int16 = Utilitarios.resolucionEstandarEjeY + 70

        Size = New Size(ejeX, ejeY)
        MaximumSize = New System.Drawing.Size(ejeY, ejeY)
        MinimumSize = New System.Drawing.Size(ejeX, ejeY)
    End Sub

    Private Sub iniciarControles()
        iniciarControlesLogicos()

        iniciarControlesRegistrarEditarEliminar()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()
        iniciarControelsGrupo4()
        rowModelo = CType(dgvTurnos.Rows(0).Clone(), DataGridViewRow)

        poblarCmboxDuracionFichas()
        poblarChlistDias()
    End Sub

    Private Sub iniciarControlesLogicos()
        oAsigTurno = New AsignacionTurno()
        oTurno = New Turno()
        tipoTurno = ""
        oDuracionFichaSeleccionada = New Concepto()
        oDuracionFichaSeleccionada.setDescripcion(0)

        nomColumnaCodTurno = "clmCodigo"
        nomColumnaHoraEntranda = "clmEntrada"
        nomColumnaHoraSalida = "clmSalida"
        nomColumnaNroFichas = "clmCantidadFichas"
        nomColumnaMañana = "clmMañana"
        nomColumnaTarde = "clmTarde"
        nomColumnaLunes = "clmLunes"
        nomColumnaMartes = "clmMartes"
        nomColumnaMiercoles = "clmMiercoles"
        nomColumnaJueves = "clmJueves"
        nomColumnaViernes = "clmViernes"
        nomColumnaEditar = "clmEditar"
    End Sub

    Private Sub iniciarControlesRegistrarEditarEliminar()
        toolStripModosForm.BackColor = Color.FromArgb(244, 244, 244)
        tlStripRegistrar.BackColor = Color.FromArgb(69, 143, 255)
        tlStripEditar.BackColor = Color.FromArgb(250, 250, 250)
        tlStripEliminar.BackColor = Color.FromArgb(250, 250, 250)

        iniciarControlesModoEditar()
    End Sub

    Private Sub iniciarControlesModoEditar()
        edLaTurnos.Visible = False
        edLaTurnos.Font = New Font("Microsoft Sans Serif", 9.5)
        edLaTurnos.Text = "Turnos"

        edHintCTurnos.Visible = False
        edHintCTurnos.Font = New Font("Microsoft Sans Serif", 9)
        edHintCTurnos.Text = "SELECCIONAR"

        edCoTurnos.Visible = False
        edCoTurnos.Font = New Font("Microsoft Sans Serif", 9.5)
        edCoTurnos.Items.Clear()
        edCoTurnos.DropDownStyle = ComboBoxStyle.DropDownList

        edLaModoEdicion.Visible = False
        edLaModoEdicion.Font = New Font("Microsoft Sans Serif", 9.5)
        edLaModoEdicion.Text = "Modo de edición"

        edHintCModoEdicion.Visible = False
        edHintCModoEdicion.Font = New Font("Microsoft Sans Serif", 9)
        edHintCModoEdicion.Text = "SELECCIONAR"

        edCoModoEdicion.Visible = False
        edCoModoEdicion.Font = New Font("Microsoft Sans Serif", 9)
        edCoModoEdicion.DropDownStyle = ComboBoxStyle.DropDownList
        edCoModoEdicion.Items.Clear()

    End Sub

    Private Sub iniciarControlesGrupo1()
        txtMedico.Enabled = True
        txtMedico.Font = New Font("Microsoft Sans Serif", 9)
        txtMedico.Text = ""
        txtMedico.CharacterCasing = CharacterCasing.Upper

        btnBuscarMedico.Enabled = True
        btnBuscarMedico.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarMedico.Text = "Buscar"

        hintCmboxMedico.Font = New Font("Microsoft Sans Serif", 9)
        hintCmboxMedico.Text = "SELECCIONAR"
        hintCmboxMedico.BackColor = Color.Transparent
        hintCmboxMedico.Visible = True

        cmboxMedicos.Enabled = True
        cmboxMedicos.Font = New Font("Microsoft Sans Serif", 9)
        cmboxMedicos.Items.Clear()
        cmboxMedicos.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub iniciarControlesGrupo2()
        panelDatosTurno.Enabled = False

        iniciarRadioButtonsTipoTurno()
        panelHorario.Enabled = True
        iniciarCombosHorasYMinutos()
        inciarDuracionFicha()
        iniciarCantidadFichas()
        iniciarCheckListDias()

        btnAgregarTurno.Enabled = True
        btnAgregarTurno.Text = "Agregar turno"

        rButtonMañana.Checked = True
    End Sub

    Private Sub iniciarRadioButtonsTipoTurno()
        panelTipoTurno.Enabled = True
        rButtonMañana.Enabled = True
        rButtonMañana.Checked = False

        rButtonTarde.Enabled = True
        rButtonMañana.Checked = False
    End Sub

    Private Sub iniciarCombosHorasYMinutos()

        cmboxEntradaHora.Enabled = True
        cmboxEntradaHora.Font = New Font("Microsoft Sans Serif", 9)
        cmboxEntradaHora.DropDownStyle = ComboBoxStyle.DropDownList

        cmboxEntradaMinutos.Enabled = True
        cmboxEntradaMinutos.Font = New Font("Microsoft Sans Serif", 9)
        cmboxEntradaMinutos.DropDownStyle = ComboBoxStyle.DropDownList

        cmboxSalidaHora.Enabled = True
        cmboxSalidaHora.Font = New Font("Microsoft Sans Serif", 9)
        cmboxSalidaHora.DropDownStyle = ComboBoxStyle.DropDownList

        cmboxSalidaMinutos.Enabled = True
        cmboxSalidaMinutos.Font = New Font("Microsoft Sans Serif", 9)
        cmboxSalidaMinutos.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub inciarDuracionFicha()
        cmboxDuracionFicha.Enabled = True
        cmboxDuracionFicha.Font = New Font("Microsoft Sans Serif", 9)
        cmboxDuracionFicha.DropDownStyle = ComboBoxStyle.DropDownList

        hintCmboxDuracionFicha.Visible = True
        hintCmboxDuracionFicha.Font = New Font("Microsoft Sans Serif", 9)
        hintCmboxDuracionFicha.Text = "SELECCIONAR"
    End Sub

    Private Sub iniciarCantidadFichas()
        txtCantidadFichas.Enabled = True
        txtCantidadFichas.Font = New Font("Microsoft Sans Serif", 9)
        txtCantidadFichas.Text = "0"
        txtCantidadFichas.ReadOnly = True
    End Sub

    Private Sub iniciarCheckListDias()
        lblDiasTurno.Enabled = True

        chListDias.Enabled = True
        chListDias.Font = New Font("Microsoft Sans Serif", 9)

        For index = 0 To chListDias.Items.Count - 1
            chListDias.SetItemChecked(index, False)
        Next

    End Sub

    Private Sub iniciarControlesGrupo3()
        panelListaTurnos.Enabled = True
        lblTituloGrupo3.Enabled = True
        iniciarDgvTurnos()
    End Sub

    Private Sub iniciarDgvTurnos()
        'propiedades base
        dgvTurnos.Enabled = True
        dgvTurnos.Font = New Font("Microsoft Sans Serif", 9)

        'permisos editar
        dgvTurnos.EditMode = DataGridViewEditMode.EditOnEnter
        dgvTurnos.AllowUserToAddRows = False
        dgvTurnos.AllowUserToDeleteRows = False
        dgvTurnos.AllowUserToResizeRows = False
        dgvTurnos.AllowUserToOrderColumns = False
        dgvTurnos.AllowUserToResizeColumns = False
        dgvTurnos.MultiSelect = False
        dgvTurnos.ReadOnly = True

        'estilos
        dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTurnos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvTurnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvTurnos.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvTurnos.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvTurnos.DefaultCellStyle.ForeColor = Color.Black
        'dgvTurnos.ScrollBars = ScrollBars.Both
        dgvTurnos.EnableHeadersVisualStyles = False

        'columnas
        configurarColumnasDgvTurnos()

        'filas
        dgvTurnos.Rows.Add(1)
    End Sub

    Private Sub configurarColumnasDgvTurnos()
        dgvTurnos.Columns.Clear()
        agregarColumnasNormales()
        agregarColumnasTipoCheckBoxDgv(dgvTurnos.Columns.Count)
        centrarEncabezadosDgv()
        configurarAnchoColumnasDgv()
    End Sub

    Private Sub agregarColumnasNormales()
        dgvTurnos.Columns.Add(nomColumnaCodTurno, "Codigo turno")
        dgvTurnos.Columns(nomColumnaCodTurno).Visible = False
        dgvTurnos.Columns.Add(nomColumnaHoraEntranda, "H. Entrada")
        dgvTurnos.Columns(nomColumnaHoraEntranda).Visible = True
        dgvTurnos.Columns.Add(nomColumnaHoraSalida, "H. Salida")
        dgvTurnos.Columns(nomColumnaHoraSalida).Visible = True
        dgvTurnos.Columns.Add(nomColumnaNroFichas, "Fichas")
        dgvTurnos.Columns(nomColumnaNroFichas).Visible = True
    End Sub

    Private Sub agregarColumnasTipoCheckBoxDgv(ByVal cantidadColumnas As Int16)
        Dim oClmAux As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()

        'creando checkbox partes del dia
        For index = cantidadColumnas To cantidadColumnas + 1
            oClmAux = New DataGridViewCheckBoxColumn()

            If index = cantidadColumnas Then
                oClmAux.Name = nomColumnaMañana
                oClmAux.HeaderText = "Mañana"

            ElseIf index = cantidadColumnas + 1 Then
                oClmAux.Name = nomColumnaTarde
                oClmAux.HeaderText = "Tarde"
            End If

            oClmAux.FalseValue = "0"
            oClmAux.TrueValue = "1"
            dgvTurnos.Columns.Insert(index, oClmAux)
        Next
        cantidadColumnas += 2


        'creando checkbox dias de la semana
        For index = cantidadColumnas To cantidadColumnas + 4
            oClmAux = New DataGridViewCheckBoxColumn()

            If index = cantidadColumnas Then
                oClmAux.Name = nomColumnaLunes
                oClmAux.HeaderText = "L"
            ElseIf index = cantidadColumnas + 1 Then
                oClmAux.Name = nomColumnaMartes
                oClmAux.HeaderText = "M"
            ElseIf index = cantidadColumnas + 2 Then
                oClmAux.Name = nomColumnaMiercoles
                oClmAux.HeaderText = "Mi"
            ElseIf index = cantidadColumnas + 3 Then
                oClmAux.Name = nomColumnaJueves
                oClmAux.HeaderText = "J"
            ElseIf index = cantidadColumnas + 4 Then
                oClmAux.Name = nomColumnaViernes
                oClmAux.HeaderText = "V"
            End If

            oClmAux.FalseValue = "0"
            oClmAux.TrueValue = "1"
            dgvTurnos.Columns.Insert(index, oClmAux)
        Next


        oClmAux = New DataGridViewCheckBoxColumn()
        oClmAux.Name = nomColumnaEditar
        oClmAux.HeaderText = "Editar"

        oClmAux.FalseValue = "0"
        oClmAux.TrueValue = "1"
        dgvTurnos.Columns.Insert(dgvTurnos.Columns.Count, oClmAux)
        dgvTurnos.Columns(dgvTurnos.Columns.Count - 1).Visible = False
    End Sub

    Private Sub centrarEncabezadosDgv()
        For Each columna As DataGridViewColumn In dgvTurnos.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub configurarAnchoColumnasDgv()
        dgvTurnos.Columns(nomColumnaHoraEntranda).FillWeight = 15
        dgvTurnos.Columns(nomColumnaHoraSalida).FillWeight = 15
        dgvTurnos.Columns(nomColumnaNroFichas).FillWeight = 8
        dgvTurnos.Columns(nomColumnaMañana).FillWeight = 9
        dgvTurnos.Columns(nomColumnaTarde).FillWeight = 9
        dgvTurnos.Columns(nomColumnaLunes).FillWeight = 8
        dgvTurnos.Columns(nomColumnaMartes).FillWeight = 8
        dgvTurnos.Columns(nomColumnaMiercoles).FillWeight = 8
        dgvTurnos.Columns(nomColumnaJueves).FillWeight = 8
        dgvTurnos.Columns(nomColumnaViernes).FillWeight = 8
        dgvTurnos.Columns(nomColumnaEditar).FillWeight = 8
    End Sub

    Private Sub iniciarControelsGrupo4()
        btnCancelar.Enabled = True
        btnCancelar.Font = New Font("Microsoft Sans Serif", 9)
        btnCancelar.Text = "Cancelar"


        btnRegistrarTurnos.Enabled = False
        btnRegistrarTurnos.Font = New Font("Microsoft Sans Serif", 9)
        btnRegistrarTurnos.Text = "Registrar turnos"
    End Sub







    'METODOS INTERFAZ
    Private Sub poblarCmboxMedicos(ByVal _nobmre As String)
        cmboxMedicos.Items.Clear()

        Try
            oAsigTurno.traerMedicos(_nobmre)
            For Each medico As Medico In oAsigTurno.listaMedico
                cmboxMedicos.Items.Add(medico.getUsuario.getNombres())
            Next
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub poblarCmboxDuracionFichas()
        cmboxDuracionFicha.Items.Clear()

        Try
            oAsigTurno.traerDuracionFichas()
            For Each duracionFicha As Concepto In oAsigTurno.listadDuracionFichas
                cmboxDuracionFicha.Items.Add(duracionFicha.getDescripcion() + " MINUTOS")
            Next
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub poblarChlistDias()
        chListDias.Items.Clear()

        For Each dia As String In oAsigTurno.listaDiasSemana
            chListDias.Items.Add(dia)
        Next
    End Sub

    Private Sub poblarAmbosCmbHorasTurnoMaña()
        cmboxEntradaHora.Items.Clear()
        cmboxSalidaHora.Items.Clear()

        For Each hora As String In oAsigTurno.horasTurnoMañana
            cmboxEntradaHora.Items.Add(hora)
            cmboxSalidaHora.Items.Add(hora)
        Next

        cmboxEntradaHora.SelectedIndex = 0
        cmboxSalidaHora.SelectedIndex = 6
    End Sub

    Private Sub poblarAmbosCombHorasTurnoTarde()
        cmboxEntradaHora.Items.Clear()
        cmboxSalidaHora.Items.Clear()

        For Each hora As String In oAsigTurno.horasTurnoTarde
            cmboxEntradaHora.Items.Add(hora)
            cmboxSalidaHora.Items.Add(hora)
        Next

        cmboxEntradaHora.SelectedIndex = 0
        cmboxSalidaHora.SelectedIndex = 6
    End Sub

    Private Sub poblarAmbosCombMinutos()
        cmboxEntradaMinutos.Items.Clear()
        cmboxSalidaMinutos.Items.Clear()

        For Each minutos As String In oAsigTurno.listaMinutos
            cmboxEntradaMinutos.Items.Add(minutos)
            cmboxSalidaMinutos.Items.Add(minutos)
        Next

        cmboxEntradaMinutos.SelectedIndex = 0
        cmboxSalidaMinutos.SelectedIndex = 0
    End Sub

    Private Sub calcularNroFichasTurno()
        Dim horaEntrada As Int16 = Int16.Parse(cmboxEntradaHora.SelectedItem.ToString)
        Dim horaSalida As Int16 = Int16.Parse(cmboxSalidaHora.SelectedItem.ToString)
        Dim minutosEntrada As Int16 = Int16.Parse(cmboxEntradaMinutos.SelectedItem.ToString)
        Dim minutosSalida As Int16 = Int16.Parse(cmboxSalidaMinutos.SelectedItem.ToString)
        Dim tiempoFicha As Int16 = oDuracionFichaSeleccionada.getDescripcion()

        Dim minutosAcumulados As Int16 = minutosEntrada + minutosSalida
        Dim nroFichas As Int16 = oAsigTurno.calcularCantidadFichasTurno(horaEntrada, horaSalida, minutosEntrada, minutosSalida, tiempoFicha)
        txtCantidadFichas.Text = nroFichas.ToString()
    End Sub

    Private Sub mostrarTurnosActivosDgv()
        dgvTurnos.Rows.Clear()

        Dim nodoAcutal As NodoTurno
        nodoAcutal = oAsigTurno.listaTurnosActivos.raiz

        While (nodoAcutal IsNot Nothing)
            Dim rowAux As DataGridViewRow = New DataGridViewRow()
            rowAux = CType(rowModelo.Clone, DataGridViewRow)

            Dim oTurAux As Turno = nodoAcutal.turno
            rowAux.Cells(0).Value = oTurAux.getCodigo()
            rowAux.Cells(1).Value = oTurAux.getHoraEntrada()
            rowAux.Cells(2).Value = oTurAux.getHoraSalida()
            rowAux.Cells(3).Value = oTurAux.getCantidadFichas()
            tickearParteDelDiaTurno(rowAux, oTurAux)
            tickearDiasDeLaSemana(rowAux, oTurAux)

            dgvTurnos.Rows.Add(rowAux)
            nodoAcutal = nodoAcutal.siguiente
        End While

    End Sub

    Private Sub adicionarTurnoADgv()
        Dim rowAux As DataGridViewRow = New DataGridViewRow()
        rowAux = CType(rowModelo.Clone, DataGridViewRow)
        rowAux.Cells(0).Value = oTurno.getCodigo()
        rowAux.Cells(1).Value = oTurno.getHoraEntrada()
        rowAux.Cells(2).Value = oTurno.getHoraSalida()
        rowAux.Cells(3).Value = oTurno.getCantidadFichas()
        tickearParteDelDiaTurno(rowAux, oTurno)
        tickearDiasDeLaSemana(rowAux, oTurno)
        dgvTurnos.Rows.Add(rowAux)
    End Sub

    Private Sub tickearParteDelDiaTurno(ByRef _rowAux As DataGridViewRow, ByRef _oTurnoAux As Turno)
        If _oTurnoAux.getTipo = "M" Then
            _rowAux.Cells(4).Value = "1"
            _rowAux.Cells(5).Value = "0"
        Else
            _rowAux.Cells(4).Value = "0"
            _rowAux.Cells(5).Value = "1"
        End If
    End Sub

    Private Sub tickearDiasDeLaSemana(ByRef _rowAux As DataGridViewRow, ByRef _oTurnoAux As Turno)
        Dim dias As String = ""
        dias = _oTurnoAux.getDias()

        For Each c In dias
            If c = "1" Then
                _rowAux.Cells(6).Value = "1"
            ElseIf c = "2" Then
                _rowAux.Cells(7).Value = "1"
            ElseIf c = "3" Then
                _rowAux.Cells(8).Value = "1"
            ElseIf c = "4" Then
                _rowAux.Cells(9).Value = "1"
            ElseIf c = "5" Then
                _rowAux.Cells(10).Value = "1"
            End If
        Next
    End Sub

    Private Sub reiniciarControlesGrupo2()
        oTurno = New Turno()
        oDuracionFichaSeleccionada = New Concepto()
        oDuracionFichaSeleccionada.setDescripcion(0)

        iniciarControlesGrupo2()
    End Sub

    Private Sub reiniciarControlesHorarioTurno()
        cmboxDuracionFicha.SelectedIndex = -1
        hintCmboxDuracionFicha.Visible = True
        txtCantidadFichas.Text = 0
        oDuracionFichaSeleccionada = New Concepto()
        oDuracionFichaSeleccionada.setDescripcion(0)
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub





    'METODOS LOGICOS
    Private Sub seleccionarMedico(ByVal _index As Int16)
        oAsigTurno.seleccionarMedico(_index)
    End Sub

    Private Function obtenerCodigoMedicoSeleccionado()
        Return oAsigTurno.oMedicoSeleccionado.getCodigo()
    End Function

    Private Function cargarDatosTurno() As Boolean
        Try
            Dim horaEntrada As String = cmboxEntradaHora.SelectedItem.ToString() + ":" + cmboxEntradaMinutos.SelectedItem.ToString()
            Dim horaSalida As String = cmboxSalidaHora.SelectedItem.ToString() + ":" + cmboxSalidaMinutos.SelectedItem.ToString()
            Dim nroFichas As Int16 = txtCantidadFichas.Text
            Dim diasTurno As String = cargarDiasTurno()

            oTurno.setTipo(tipoTurno)
            oTurno.setHoraEntrada(horaEntrada)
            oTurno.setHoraSalida(horaSalida)
            oTurno.setTiempoFicha(oDuracionFichaSeleccionada.getDescripcion())
            oTurno.setCantidadFichas(nroFichas)
            oTurno.setDias(diasTurno)
            Return True

        Catch ex As Exception
            oTurno = New Turno()
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function cargarDiasTurno() As String
        oTurno.listaDiasTurno = New String(chListDias.CheckedIndices.Count - 1) {}

        Dim index As Int16 = 0
        For Each item As String In chListDias.CheckedItems
            oTurno.listaDiasTurno(index) = item
            index += 1
        Next

        Dim turnoNumeral As String = oAsigTurno.convertirDiasLiteralToNum(oTurno.listaDiasTurno)
        Return turnoNumeral
    End Function

    Private Sub agregarNuevoTurno()
        oAsigTurno.agregarNuevoTurno(oTurno)
    End Sub

    Private Sub cambiarModoFormulario(ByVal modo As Int16)
        oAsigTurno.modoFormulario = modo
    End Sub

    Private Sub AdicionarTurno()
        Dim datosCargadosTurno As Boolean = cargarDatosTurno()

        If datosCargadosTurno Then
            Dim mensajeValidarTurno As String = oAsigTurno.validarEntradasTurno(oTurno, oAsigTurno.listaTurnosActivos)

            If Not mensajeValidarTurno = "" Then
                mostrarMensaje(mensajeValidarTurno)
            Else
                agregarNuevoTurno()
                adicionarTurnoADgv()
                reiniciarControlesGrupo2()
                btnRegistrarTurnos.Enabled = True
            End If
        End If

    End Sub

    Private Sub edEditarTurnoSeleccionado()
        Dim datosCargadosTurno As Boolean = cargarDatosTurno()

        If datosCargadosTurno Then
            Dim mensajeValidarTurno As String = oAsigTurno.validarEntradasTurno(oTurno, oAsigTurno.listaTurnosActivos)

            If Not mensajeValidarTurno = "" Then
                mostrarMensaje(mensajeValidarTurno)
            Else
                dgvTurnos.Rows.Clear()
                adicionarTurnoADgv()

                btnRegistrarTurnos.Enabled = True
            End If
        End If


    End Sub

    Private Sub reRegistrarDatosTurno()
        Dim numRowsAfected As Int16 = oAsigTurno.registrarTurnos()

        If numRowsAfected > 0 Then
            mostrarMensaje("Se guardaron los datos correctamente.")
            reiniciarFormulario()
        Else
            mostrarMensaje("Ocurrió un error al guardar los datos.")
        End If

    End Sub



    'ENVENTOS GRUPO 0
    Private Sub tlStripRegistrar_Click(sender As Object, e As EventArgs) Handles tlStripRegistrar.Click
        cambiarModoFormulario(1)
        reiniciarFormulario()
    End Sub

    Private Sub tlStripEditar_Click(sender As Object, e As EventArgs) Handles tlStripEditar.Click
        reiniciarFormulario()
        edCambiarFormAModoEditar()
    End Sub

    Private Sub tlStripEliminar_Click(sender As Object, e As EventArgs) Handles tlStripEliminar.Click
        reiniciarFormulario()
        elcambiarFormAModoEliminar()
    End Sub




    'EVENTOS GRUPO 1

    Private Sub btnBuscarMedico_Click(sender As Object, e As EventArgs) Handles btnBuscarMedico.Click
        Try
            Dim nombreMedico As String = ""
            nombreMedico = txtMedico.Text.Trim()
            poblarCmboxMedicos(nombreMedico)
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cmboxMedicos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxMedicos.SelectionChangeCommitted
        Dim modoFormulario As Int16 = oAsigTurno.modoFormulario

        Try
            seleccionarMedico(cmboxMedicos.SelectedIndex)
            hintCmboxMedico.Visible = False
            Dim codigoMedico As Int16 = obtenerCodigoMedicoSeleccionado()
            oAsigTurno.traerTurnos(codigoMedico)
            dgvTurnos.Rows.Clear()

            If modoFormulario = 1 Then
                panelDatosTurno.Enabled = True
                mostrarTurnosActivosDgv()

            ElseIf modoFormulario = 2 Then
                mostrarTurnosActivosDgv()
                mePoblarCboxModoEdicion()

            ElseIf modoFormulario = 3 Then
                mePoblarCboxTurnos()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub






    'EVENTOS GRUPO 2
    Private Sub rButtonMañana_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonMañana.CheckedChanged
        If rButtonMañana.Checked Then
            tipoTurno = "M"
            oTurno.setTipo(tipoTurno)

            poblarAmbosCmbHorasTurnoMaña()
            poblarAmbosCombMinutos()
        End If
    End Sub

    Private Sub rButtonTarde_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonTarde.CheckedChanged
        If rButtonTarde.Checked Then
            tipoTurno = "T"
            oTurno.setTipo(tipoTurno)

            poblarAmbosCombHorasTurnoTarde()
            poblarAmbosCombMinutos()
        End If
    End Sub

    Private Sub cmboxDuracionFicha_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxDuracionFicha.SelectionChangeCommitted
        hintCmboxDuracionFicha.Visible = False
        Dim index As Int16 = 0

        Try
            index = cmboxDuracionFicha.SelectedIndex
            oDuracionFichaSeleccionada = oAsigTurno.listadDuracionFichas(index)
            calcularNroFichasTurno()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cmboxEntradaHora_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxEntradaHora.SelectionChangeCommitted
        reiniciarControlesHorarioTurno()
    End Sub

    Private Sub cmboxEntradaMinutos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxEntradaMinutos.SelectionChangeCommitted
        reiniciarControlesHorarioTurno()
    End Sub

    Private Sub cmboxSalidaHora_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxSalidaHora.SelectionChangeCommitted
        reiniciarControlesHorarioTurno()
    End Sub

    Private Sub cmboxSalidaMinutos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxSalidaMinutos.SelectionChangeCommitted
        reiniciarControlesHorarioTurno()
    End Sub

    Private Sub btnAgregarTurno_Click(sender As Object, e As EventArgs) Handles btnAgregarTurno.Click
        Dim modoFormulario As Int16 = oAsigTurno.modoFormulario

        If modoFormulario = 1 Then
            AdicionarTurno()

        ElseIf modoFormulario = 2 Then
            edEditarTurnoSeleccionado()
        End If
    End Sub






    'EVENTOS GRUPO 3
    Private Sub dgvTurnos_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvTurnos.RowPostPaint
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

    Private Sub dgvTurnos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTurnos.SelectionChanged
        Dim modoFormulario As Int16 = oAsigTurno.modoFormulario

        If modoFormulario = 1 Then
            dgvTurnos.ClearSelection()

        ElseIf modoFormulario = 2 Then
            dgvTurnos.ClearSelection()
        End If

    End Sub




    'EVENTOS CONTROELS GRUPO 4
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim modoFormulario As Int16 = oAsigTurno.modoFormulario

        If modoFormulario = 1 Then
            reiniciarFormulario()

        ElseIf modoFormulario = 2 Then
            reiniciarFormulario()
            edCambiarFormAModoEditar()

        ElseIf modoFormulario = 3 Then
            reiniciarFormulario()
            elcambiarFormAModoEliminar()
        End If
    End Sub

    Private Sub btnRegistrarTurnos_Click(sender As Object, e As EventArgs) Handles btnRegistrarTurnos.Click
        Dim modoFormulario As Int16 = oAsigTurno.modoFormulario

        If modoFormulario = 1 Then
            reRegistrarDatosTurno()

        ElseIf modoFormulario = 2 Then
            edEditarDatosTurno()

        ElseIf modoFormulario = 3 Then
            elEliminarDatosTurno()
        End If

    End Sub














    '[MODO EDDITAR] ---------------------------- METODOS INICIO
    Private edModoEdicionTurno As Int16 = 0


    Private Sub edCambiarFormAModoEditar()
        cambiarModoFormulario(2)

        edCambiarColorMenuEditar()
        edCambiarControlesGrupo1()
        edCambiarControlesGrupo2()
        edCambiarControlesGrupo3()
        edCambiarControlesGrupo4()

        'dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'dgvTurnos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(194, 217, 255)
        'dgvTurnos.DefaultCellStyle.SelectionForeColor = Color.Black
    End Sub

    Private Sub edCambiarColorMenuEditar()
        tlStripEditar.BackColor = Color.FromArgb(69, 143, 255)
        tlStripRegistrar.BackColor = Color.FromArgb(250, 250, 250)
        tlStripEliminar.BackColor = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub edCambiarControlesGrupo1()
        edLaTurnos.Visible = True

        edHintCTurnos.Visible = True
        edHintCTurnos.Enabled = True

        edCoTurnos.Visible = True
        edCoTurnos.Enabled = True

        edLaModoEdicion.Visible = True

        edHintCModoEdicion.Visible = True
        edHintCModoEdicion.Enabled = True

        edCoModoEdicion.Visible = True
        edCoModoEdicion.Enabled = True
    End Sub

    Private Sub edCambiarControlesGrupo2()
        panelDatosTurno.Enabled = False
        btnAgregarTurno.Text = "Editar turno"
    End Sub

    Private Sub edCambiarControlesGrupo3()
        edDeshabilitarDgvTurnos(False)
    End Sub

    Private Sub edCambiarControlesGrupo4()
        btnCancelar.Enabled = True

        btnRegistrarTurnos.Enabled = False
        btnRegistrarTurnos.Text = "Confirmar edición de turno"
    End Sub





    'MODO EDDITAR --------------------------------  METODOS INTERFAZ
    Private Sub mePoblarCboxTurnos()
        edCoTurnos.Items.Clear()


        Dim nodoAcutal As NodoTurno
        nodoAcutal = oAsigTurno.listaTurnosActivos.raiz

        While (nodoAcutal IsNot Nothing)
            Dim oTurAux As Turno = nodoAcutal.turno
            Dim hEntrada As String = oTurAux.getHoraEntrada()
            Dim hSalida As String = oTurAux.getHoraSalida()
            Dim turno As String = oTurAux.getTipo()
            Dim cantidadFichas As String = oTurAux.getCantidadFichas()
            Dim dias As String = oAsigTurno.convertirDiasNumToLiteral(oTurAux.getDias())

            edCoTurnos.Items.Add(turno + "  | " + hEntrada + " - " + hSalida + " | " + dias)

            nodoAcutal = nodoAcutal.siguiente
        End While

    End Sub

    Private Sub mePoblarCboxModoEdicion()
        edCoModoEdicion.Items.Clear()
        edCoModoEdicion.Items.Add("EDITAR HORARIO")
        edCoModoEdicion.Items.Add("EDITAR TURNO Y HORARIO")
        edCoModoEdicion.Items.Add("EDTIAR DIAS")
    End Sub

    Private Sub elHabilitarDgvTurnos()
        dgvTurnos.Enabled = True

        dgvTurnos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvTurnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvTurnos.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvTurnos.DefaultCellStyle.ForeColor = Color.Black
        dgvTurnos.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvTurnos.ReadOnly = True
        dgvTurnos.EnableHeadersVisualStyles = False
    End Sub

    Private Sub edDeshabilitarDgvTurnos(ByVal _bloquearControles)
        If _bloquearControles Then
            dgvTurnos.Enabled = False
        End If

        dgvTurnos.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
        dgvTurnos.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText
        dgvTurnos.DefaultCellStyle.BackColor = SystemColors.Control
        dgvTurnos.DefaultCellStyle.ForeColor = SystemColors.GrayText
        dgvTurnos.BackgroundColor = SystemColors.Control
        dgvTurnos.CurrentCell = Nothing
        dgvTurnos.ReadOnly = True
        dgvTurnos.EnableHeadersVisualStyles = False
    End Sub

    Private Sub edMostrarDatosParaEditar()
        panelDatosTurno.Enabled = True

        If edModoEdicionTurno = 1 Then
            edMostrarDatosEditarHorario()
        ElseIf edModoEdicionTurno = 2 Then
            edMostrarDatosEditarTurnoYHorario()
        ElseIf edModoEdicionTurno = 3 Then
            edMostrarDatosEditarDias()
        End If
    End Sub

    Private Sub edMostrarDatosEditarHorario()
        panelTipoTurno.Enabled = False
        lblDiasTurno.Enabled = False
        chListDias.Enabled = False

        edMostrarDatosTipoTurno()
        edMostrarDatosHorario()
        edMostrarDatosDiasTurno()
    End Sub

    Private Sub edMostrarDatosTipoTurno()
        Dim tipoTurno As Char = oTurno.getTipo()

        If tipoTurno = "M" Then
            rButtonMañana.Checked = True
        Else
            rButtonTarde.Checked = True
        End If
    End Sub

    Private Sub edMostrarDatosHorario()
        Dim entradaHora As String = oTurno.getEntradaHoraSoloHora()
        Dim entradaMinutos As String = oTurno.getEntradaHoraSoloMinutos()
        Dim salidaHora As String = oTurno.getSalidaHoraSoloHora()
        Dim salidaMinutos As String = oTurno.getSalidaHoraSoloMinutos()
        Dim duracionFicha As String = oTurno.getTiempoFicha.ToString() + " MINUTOS"
        Dim cantidadFichas As Int16 = oTurno.getCantidadFichas()



        cmboxEntradaHora.SelectedItem = entradaHora
        cmboxEntradaMinutos.SelectedItem = entradaMinutos
        cmboxSalidaHora.SelectedItem = salidaHora
        cmboxSalidaMinutos.SelectedItem = salidaMinutos

        hintCmboxDuracionFicha.Visible = False
        cmboxDuracionFicha.SelectedItem = duracionFicha
        Dim index As Int16 = cmboxDuracionFicha.SelectedIndex
        oDuracionFichaSeleccionada = oAsigTurno.listadDuracionFichas(index)

        txtCantidadFichas.Text = cantidadFichas.ToString()
    End Sub

    Private Sub edMostrarDatosDiasTurno()
        Dim dias As String = oTurno.getDias()

        For Each c In dias
            If c = "1" Then
                chListDias.SetItemChecked(0, True)
            ElseIf c = "2" Then
                chListDias.SetItemChecked(1, True)
            ElseIf c = "3" Then
                chListDias.SetItemChecked(2, True)
            ElseIf c = "4" Then
                chListDias.SetItemChecked(3, True)
            ElseIf c = "5" Then
                chListDias.SetItemChecked(4, True)
            End If
        Next

    End Sub

    Private Sub edMostrarDatosEditarTurnoYHorario()
        panelTipoTurno.Enabled = True
        panelHorario.Enabled = True
        lblDiasTurno.Enabled = False
        chListDias.Enabled = False
        edMostrarDatosTipoTurno()
        edMostrarDatosHorario()
        edMostrarDatosDiasTurno()
    End Sub

    Private Sub edMostrarDatosEditarDias()
        panelTipoTurno.Enabled = False
        panelHorario.Enabled = False
        lblDiasTurno.Enabled = True
        chListDias.Enabled = True
        edMostrarDatosTipoTurno()
        edMostrarDatosHorario()
        edMostrarDatosDiasTurno()
    End Sub




    'MODO EDDITAR -------------  METODOS LOGICOS
    Private Sub edSeleccionarTurnoParaEditar(ByVal _index As Int16)
        If _index < 0 Then
            Throw New ArgumentException("Error. No se seleccionó ningun turno")
        End If
        oTurno = oAsigTurno.listaTurnosActivos.traerTurnoPorIndex(_index)
    End Sub

    Private Sub edEditarDatosTurno()
        Dim numRowsAfected As Int16 =  oAsigTurno.edEditarTurno(oTurno, Me.Text)

        If numRowsAfected > 0 Then
            mostrarMensaje("Se editaron los datos correctamente.")
            reiniciarFormulario()
            edCambiarFormAModoEditar()
        Else
            mostrarMensaje("Ocurrió un error al editar el turno.")
        End If

    End Sub




    'MODO EDDITAR ------------------  EVENTOS GRUPO 1
    Private Sub edCModoEdicion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles edCoModoEdicion.SelectionChangeCommitted
        Dim index As Int16 = edCoModoEdicion.SelectedIndex

        If index >= 0 Then
            edHintCModoEdicion.Visible = False

            If index = 0 Then
                edModoEdicionTurno = 1
            ElseIf index = 1 Then
                edModoEdicionTurno = 2
            ElseIf index = 2 Then
                edModoEdicionTurno = 3
            End If

            mePoblarCboxTurnos()
        End If
    End Sub

    Private Sub edCTurnos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles edCoTurnos.SelectionChangeCommitted
        Dim modoFormulario As Int16 = oAsigTurno.modoFormulario
        Dim index As Int16 = edCoTurnos.SelectedIndex

        Try
            If modoFormulario = 2 Then
                edSeleccionarTurnoParaEditar(index)
                edHintCTurnos.Visible = False
                edHintCModoEdicion.Enabled = False
                edCoModoEdicion.Enabled = False
                edCoTurnos.Enabled = False
                edMostrarDatosParaEditar()

            ElseIf modoFormulario = 3 Then
                elSeleccionarTurnoParaEliminar(index)
                edHintCTurnos.Visible = False
                elMostrarTurnoParaEliminar()
                btnRegistrarTurnos.Enabled = True
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub




















    '[MODO ELIMINAR] ---- METODOS INICIO
    Private Sub elcambiarFormAModoEliminar()
        cambiarModoFormulario(3)
        elCambiarColorMenuEliminar()
        elCambiarControlesGrupo1()
        elCambiarControlesGrupo2()
        elCambiarControlesGrupo3()
        elCambiarControlesGrupo4()
    End Sub

    Private Sub elCambiarColorMenuEliminar()
        tlStripEliminar.BackColor = Color.FromArgb(69, 143, 255)
        tlStripEditar.BackColor = Color.FromArgb(250, 250, 250)
        tlStripRegistrar.BackColor = Color.FromArgb(250, 250, 250)
    End Sub

    Private Sub elCambiarControlesGrupo1()
        edLaTurnos.Visible = True
        edHintCTurnos.Visible = True
        edHintCTurnos.Enabled = True
        edCoTurnos.Visible = True
        edCoTurnos.Enabled = True
    End Sub

    Private Sub elCambiarControlesGrupo2()
        panelDatosTurno.Enabled = False
    End Sub

    Private Sub elCambiarControlesGrupo3()
        edDeshabilitarDgvTurnos(False)
    End Sub

    Private Sub elCambiarControlesGrupo4()
        btnCancelar.Enabled = True

        btnRegistrarTurnos.Enabled = False
        btnRegistrarTurnos.Text = "Eliminar Turno"
    End Sub



    'MODO ELIMINAR- METODOS INTERFAZ
    Private Sub elMostrarTurnoParaEliminar()
        dgvTurnos.Rows.Clear()
        adicionarTurnoADgv()

    End Sub




    'MODO ELIMIANR - METODOS LOGICOS
    Private Sub elSeleccionarTurnoParaEliminar(ByVal _index As Int16)
        If _index < 0 Then
            Throw New ArgumentException("Error. No se seleccionó ningun turno")
        End If
        oTurno = oAsigTurno.listaTurnosActivos.traerTurnoPorIndex(_index)
    End Sub

    Private Sub elEliminarDatosTurno()
        Dim dialogResult As DialogResult = MessageBox.Show("¿Está seguro de eliminar este turno?", "Eliminar Turno", MessageBoxButtons.YesNo)

        If dialogResult = dialogResult.Yes Then

            Dim numRowsAfected As Int16 = oAsigTurno.elEliminarTurno(oTurno, Me.Text)
            If numRowsAfected > 0 Then
                mostrarMensaje("Se elimino el turno correctamente.")
                reiniciarFormulario()
                elcambiarFormAModoEliminar()
            Else
                mostrarMensaje("Ocurrió un error al eliminar el turno.")
            End If
        End If

    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FormMenuControlDeUsuario.Show()
        Close()
    End Sub
End Class