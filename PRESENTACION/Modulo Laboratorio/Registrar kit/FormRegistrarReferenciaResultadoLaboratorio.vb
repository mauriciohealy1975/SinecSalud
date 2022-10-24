Imports NEGOCIO

Public Class FormRegistrarReferenciaResultadoLaboratorio

    'ATRIBUTOS LÓGICOS
    Public registro As RegistroReferenciaResultadoLaboratorio

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean
    Private esFormHijo As Boolean
    Private examenFormPadre As ExamenLaboratorio
    Private kitEquipoFormPadre As KitEquipoLaboratorio
    Private tipoReferenciaFormPadre As Concepto

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private areaSeleccionada As AreaLaboratorio
    Private subareaSeleccionada As SubareaLaboratorio
    Private examenSeleccionado As ExamenLaboratorio
    Private kitEquipoSeleccionado As KitEquipoLaboratorio
    Private tipoReferenciaSeleccionada As Concepto

    'ATRIBUTOS G2
    Private clmSexoDgvReferencias As String
    Private clmEdadDesdeDgvReferencias As String
    Private clmEdadHastaDgvReferencias As String
    Private clmValorDesdeDgvReferencias As String
    Private clmValorHastaDgvReferencias As String
    Private clmValorHombresDesdeDgvReferencias As String
    Private clmValorHombresHastaDgvReferencias As String
    Private clmValorMujeresDesdeDgvReferencias As String
    Private clmValorMujeresHastaDgvReferencias As String
    Private clmAccionDgvReferemcias As String

    'ATRIBUTOS G9
    Private inputNuevasReferencias As ReferenciaResultadoLaboratorioInput()
    Public nuevasReferencias As ReferenciaResultadoLaboratorio()


    'METODDOS INICIO
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(False, Nothing, Nothing, Nothing)
        iniciarFormulario()
    End Sub

    Public Sub New(ByRef _examen As ExamenLaboratorio, ByRef _kitEquipo As KitEquipoLaboratorio, ByRef _tipoReferencia As Concepto)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(True, _examen, _kitEquipo, _tipoReferencia)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        establecerDisplay()
    End Sub

    Private Sub FormRegistrarReferenciaResultadoLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean, ByRef _examen As ExamenLaboratorio, ByRef _kitEquipo As KitEquipoLaboratorio, ByRef _tipoReferencia As Concepto)
        estadoFormGuardado = False

        If _esHijo Then
            esFormHijo = True
            examenFormPadre = _examen
            kitEquipoFormPadre = _kitEquipo
            tipoReferenciaFormPadre = _tipoReferencia
        Else
            esFormHijo = False
            examenFormPadre = Nothing
            kitEquipoFormPadre = Nothing
            tipoReferenciaFormPadre = Nothing
        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarControlesInterfaz()

        traerAreas()
        poblarCboxAreas()
        traerTiposReferencias()
        poblarCboxTipoValoresReferencia()
        If esFormHijo Then iniciarFormularioModoHijoLogicoInterfaz()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroReferenciaResultadoLaboratorio()

        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'Private esFormHijo As Boolean
        'Private examenFormPadre As ExamenLaboratorio
        'Private kitEquipoFormPadre As KitEquipoLaboratorio 
        'Private tipoReferenciaFormPadre As Concepto

        'ATRIBUTOS G0
        tituloFormulario = "Registrar referencias"

        'ATRIBUTOS G1
        areaSeleccionada = New AreaLaboratorio()
        subareaSeleccionada = New SubareaLaboratorio()
        examenSeleccionado = New ExamenLaboratorio()
        kitEquipoSeleccionado = New KitEquipoLaboratorio()
        tipoReferenciaSeleccionada = New Concepto()

        'ATRIBUTOS G2
        clmSexoDgvReferencias = "clmSexo"
        clmEdadDesdeDgvReferencias = "clmEdadDesde"
        clmEdadHastaDgvReferencias = "clmEdadHasta"
        clmValorDesdeDgvReferencias = "clmValorDesde"
        clmValorHastaDgvReferencias = "clmValorHasta"
        clmValorHombresDesdeDgvReferencias = "clmHombresDesde"
        clmValorHombresHastaDgvReferencias = "clmHombresHasta"
        clmValorMujeresDesdeDgvReferencias = "clmMujeresDesde"
        clmValorMujeresHastaDgvReferencias = "clmMujeresHasta"
        clmAccionDgvReferemcias = "clmAccion"

        'ATRIBUTOS G9
        inputNuevasReferencias = New ReferenciaResultadoLaboratorioInput(-1) {}
        nuevasReferencias = New ReferenciaResultadoLaboratorio(-1) {}
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarControlesInterfaz()
        iniciarControlesInterfazGrupo0()
        iniciarControlesInterfazGrupo1()
        iniciarControlesInterfazGrupo2()
        iniciarControlesInterfazGrupo9()
    End Sub

    Private Sub iniciarControlesInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper
    End Sub

    Private Sub iniciarControlesInterfazGrupo1()
        panelDatosExamen.Enabled = True
        panelDatosExamen.Visible = True


        lblArea.Enabled = True
        lblArea.Visible = True

        cboxArea.Enabled = True
        cboxArea.Visible = True
        cboxArea.Font = New Font("Microsoft Sans Serif", 9)
        cboxArea.Items.Clear()
        cboxArea.DropDownStyle = ComboBoxStyle.DropDownList

        hintArea.Enabled = True
        hintArea.Visible = True
        hintArea.Font = New Font("Microsoft Sans Serif", 8)
        hintArea.Text = "SELECCIONAR"
        hintArea.BackColor = Color.Transparent




        lblSubarea.Enabled = True
        lblSubarea.Visible = True

        cboxSubarea.Enabled = True
        cboxSubarea.Visible = True
        cboxSubarea.Font = New Font("Microsoft Sans Serif", 9)
        cboxSubarea.Items.Clear()
        cboxSubarea.DropDownStyle = ComboBoxStyle.DropDownList

        hintSubarea.Enabled = True
        hintSubarea.Visible = True
        hintSubarea.Font = New Font("Microsoft Sans Serif", 8)
        hintSubarea.Text = "SELECCIONAR"
        hintSubarea.BackColor = Color.Transparent




        lblExamen.Enabled = True
        lblExamen.Visible = True

        cboxExamen.Enabled = True
        cboxExamen.Visible = True
        cboxExamen.Font = New Font("Microsoft Sans Serif", 9)
        cboxExamen.Items.Clear()
        cboxExamen.DropDownStyle = ComboBoxStyle.DropDownList

        hintExamen.Enabled = True
        hintExamen.Visible = True
        hintExamen.Font = New Font("Microsoft Sans Serif", 8)
        hintExamen.Text = "SELECCIONAR"
        hintExamen.BackColor = Color.Transparent




        lblKitEquipo.Enabled = True
        lblKitEquipo.Visible = True

        cboxKitEquipo.Enabled = False
        cboxKitEquipo.Visible = True
        cboxKitEquipo.Font = New Font("Microsoft Sans Serif", 9)
        cboxKitEquipo.Items.Clear()
        cboxKitEquipo.DropDownStyle = ComboBoxStyle.DropDownList

        hintKitEquipo.Enabled = False
        hintKitEquipo.Visible = True
        hintKitEquipo.Font = New Font("Microsoft Sans Serif", 8)
        hintKitEquipo.Text = "SELECCIONAR"
        hintKitEquipo.BackColor = Color.Transparent




        lblTipoReferencia.Enabled = True
        lblTipoReferencia.Visible = True

        cboxTipoReferencia.Enabled = False
        cboxTipoReferencia.Visible = True
        cboxTipoReferencia.Font = New Font("Microsoft Sans Serif", 9)
        cboxTipoReferencia.Items.Clear()
        cboxTipoReferencia.DropDownStyle = ComboBoxStyle.DropDownList

        hintTipoReferencia.Enabled = False
        hintTipoReferencia.Visible = True
        hintTipoReferencia.Font = New Font("Microsoft Sans Serif", 8)
        hintTipoReferencia.Text = "SELECCIONAR"
        hintTipoReferencia.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarControlesInterfazGrupo2()
        lblHeaderValores.Enabled = True
        lblHeaderValores.Visible = False
        lblHeaderValores.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderValores.Text = "VALORES EN "
        lblHeaderValores.BackColor = Color.FromArgb(235, 235, 235)
        lblHeaderValores.Location = New Point(0, 0)
        lblHeaderValores.Size = New Size(0, 0)


        lblHeaderEdad.Enabled = True
        lblHeaderEdad.Visible = False
        lblHeaderEdad.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderEdad.Text = "EDAD (AÑOS)"
        lblHeaderEdad.BackColor = Color.FromArgb(235, 235, 235)
        lblHeaderEdad.Location = New Point(0, 0)
        lblHeaderEdad.Size = New Size(0, 0)


        lblHeaderValoresHombres.Enabled = True
        lblHeaderValoresHombres.Visible = False
        lblHeaderValoresHombres.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderValoresHombres.Text = "VALORES EN ? - HOMBRES"
        lblHeaderValoresHombres.Location = New Point(0, 0)
        lblHeaderValoresHombres.Size = New Size(0, 0)


        lblHeaderValoresMujeres.Enabled = True
        lblHeaderValoresMujeres.Visible = False
        lblHeaderValoresMujeres.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderValoresMujeres.Text = "VALORES EN ? - MUJERES"
        lblHeaderValoresMujeres.Location = New Point(0, 0)
        lblHeaderValoresMujeres.Size = New Size(0, 0)


        btnAgregarFila.Enabled = False
        btnAgregarFila.Visible = True
        btnAgregarFila.Font = New Font("Microsoft Sans Serif", 9)

        iniciarDgvReferencias()
    End Sub

    Public Sub iniciarDgvReferencias()
        'ENCABEZADOS LABELS


        'propiedades base
        dgvReferencias.Enabled = True
        dgvReferencias.Font = New Font("Microsoft Sans Serif", 9)
        dgvReferencias.Size = New Size(665, 155)


        'propiedades permisos editar
        dgvReferencias.EditMode = DataGridViewEditMode.EditOnEnter
        dgvReferencias.AllowUserToAddRows = False
        dgvReferencias.AllowUserToDeleteRows = False
        dgvReferencias.AllowUserToResizeRows = False
        dgvReferencias.AllowUserToOrderColumns = False
        dgvReferencias.AllowUserToResizeColumns = False
        dgvReferencias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvReferencias.MultiSelect = False
        dgvReferencias.ReadOnly = True

        'propiedades estilos selección
        dgvReferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvReferencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        'propiedades estilos color encabezados columnas
        dgvReferencias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvReferencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black


        'propiedades estilos color seleccion encabezados filas
        dgvReferencias.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)


        'propiedaes estilos color celdas
        dgvReferencias.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.DefaultCellStyle.ForeColor = Color.Black


        'propiedaes estilos color celdas seleccionadas
        dgvReferencias.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvReferencias.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)


        'propiedades otras celdas
        dgvReferencias.ScrollBars = ScrollBars.Both
        dgvReferencias.EnableHeadersVisualStyles = False


        'columnas -- agregar columnas
        dgvReferencias.Columns.Clear()

        dgvReferencias.Columns.Add(clmSexoDgvReferencias, "SEXO")
        dgvReferencias.Columns(clmSexoDgvReferencias).Visible = False

        dgvReferencias.Columns.Add(clmEdadDesdeDgvReferencias, "DESDE")
        dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = False

        dgvReferencias.Columns.Add(clmEdadHastaDgvReferencias, "HASTA")
        dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = False

        dgvReferencias.Columns.Add(clmValorDesdeDgvReferencias, "DESDE")
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = False

        dgvReferencias.Columns.Add(clmValorHastaDgvReferencias, "HASTA")
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = False

        dgvReferencias.Columns.Add(clmValorHombresDesdeDgvReferencias, "DESDE")
        dgvReferencias.Columns(clmValorHombresDesdeDgvReferencias).Visible = False

        dgvReferencias.Columns.Add(clmValorHombresHastaDgvReferencias, "HASTA")
        dgvReferencias.Columns(clmValorHombresHastaDgvReferencias).Visible = False

        dgvReferencias.Columns.Add(clmValorMujeresDesdeDgvReferencias, "DESDE")
        dgvReferencias.Columns(clmValorMujeresDesdeDgvReferencias).Visible = False

        dgvReferencias.Columns.Add(clmValorMujeresHastaDgvReferencias, "HASTA")
        dgvReferencias.Columns(clmValorMujeresHastaDgvReferencias).Visible = False

        Dim clmButtonAccion As New DataGridViewButtonColumn()
        clmButtonAccion.Name = clmAccionDgvReferemcias
        clmButtonAccion.HeaderText = ""
        clmButtonAccion.Text = "ELIMINAR"
        clmButtonAccion.UseColumnTextForButtonValue = True
        dgvReferencias.Columns.Add(clmButtonAccion)
        dgvReferencias.Columns(clmAccionDgvReferemcias).Visible = False


        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvReferencias.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        'alinear columnas
        For Each columna As DataGridViewColumn In dgvReferencias.Columns

            If columna.Name = clmSexoDgvReferencias Then
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            ElseIf columna.Name = clmAccionDgvReferemcias Then
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Else
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
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
        dgvReferencias.Rows.Clear()
        dgvReferencias.Rows.Add()
    End Sub

    Private Sub iniciarControlesInterfazGrupo9()
        btnEnviarDatos.Enabled = True
        btnEnviarDatos.Visible = True
        btnEnviarDatos.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviarDatos.Text = "Registrar referencias"
    End Sub

    Private Sub establecerDisplay()
        'Dim ejeX As Short, ejeY As Short

        ''ejeX = Utilitarios.resolucionEstandarEjeX
        ''ejeY = Utilitarios.resolucionEstandarEjeY

        ''Dim size As New Size(ejeX, ejeY)
        'Dim size As New Size(945, 495)

        'Me.Size = size
        'MinimumSize = size
        'MaximumSize = size

        Me.CenterToScreen()
    End Sub

    Private Sub iniciarFormularioModoHijoLogicoInterfaz()
        lblArea.Enabled = False
        cboxArea.Enabled = False
        hintArea.Enabled = False

        lblSubarea.Enabled = False
        cboxSubarea.Enabled = False
        hintSubarea.Enabled = False

        lblExamen.Enabled = False
        cboxExamen.Enabled = False
        hintExamen.Enabled = False

        lblKitEquipo.Enabled = False
        cboxKitEquipo.Enabled = False
        hintKitEquipo.Enabled = False

        lblTipoReferencia.Enabled = False
        cboxTipoReferencia.Enabled = False
        hintTipoReferencia.Enabled = False




        areaSeleccionada = examenFormPadre.getArea()
        subareaSeleccionada = examenFormPadre.getSubarea()
        examenSeleccionado = examenFormPadre
        kitEquipoSeleccionado = kitEquipoFormPadre
        tipoReferenciaSeleccionada = tipoReferenciaFormPadre

        hintArea.Text = areaSeleccionada.getNombre()
        hintSubarea.Text = subareaSeleccionada.getNombre()
        hintExamen.Text = examenSeleccionado.getNombre()
        hintKitEquipo.Text = kitEquipoSeleccionado.getNombre()
        hintTipoReferencia.Text = tipoReferenciaSeleccionada.getDescripcion()

        ajustarInterfazDgvReferencias()

        btnEnviarDatos.Text = "Guardar referencias"
    End Sub








    'MÉTODOS LOGICOS G1
    Private Sub traerAreas()
        registro.traerAreas()
    End Sub

    Private Sub seleccionarArea()
        Dim index As Int16 = cboxArea.SelectedIndex
        areaSeleccionada = registro.areas(index)
    End Sub

    Private Sub traerSubareas()
        registro.traerSubareas(areaSeleccionada)
    End Sub

    Private Sub seleccionarSubarea()
        Dim index As Short = cboxSubarea.SelectedIndex
        subareaSeleccionada = registro.subareas(index)
    End Sub

    Private Sub traerExamenes()
        registro.traerExamenes(subareaSeleccionada)
    End Sub

    Private Sub seleccionarExamen()
        Dim index As Int16 = cboxExamen.SelectedIndex
        examenSeleccionado = registro.examenes(index)
    End Sub

    Private Sub traerKitsEquipos()
        registro.traerKitsEquipos(examenSeleccionado)
    End Sub

    Private Sub seleccionarKitEquipo()
        Dim index As Short = cboxKitEquipo.SelectedIndex
        kitEquipoSeleccionado = registro.kitsequipos(index)
    End Sub

    Private Sub traerTiposReferencias()
        registro.traerTiposReferencias()
    End Sub

    Private Sub seleccionarTipoReferencia()
        Dim index As Short = cboxTipoReferencia.SelectedIndex
        tipoReferenciaSeleccionada = registro.tiposReferencia(index)
    End Sub


    'MÉTODOS LOGICOS G2
    Private Function esClickEnColumnaAccion(_columnaClickIndex As Short)
        Dim clmAccionIndex As Short, esClicKColumnaAccion As Boolean

        clmAccionIndex = dgvReferencias.Columns(clmAccionDgvReferemcias).Index
        esClicKColumnaAccion = registro.esClickEnColumnaAccion(_columnaClickIndex, clmAccionIndex)
        Return esClicKColumnaAccion
    End Function


    'MÉTODOS LOGICOS G9
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean = cargarEntradas()

        If entradasCargadas Then
            Dim mensajeValidacion As String = validarEntradas()

            If mensajeValidacion = "" Then

                Dim objetosCargados As Boolean = cargarObjetos()

                If objetosCargados Then
                    If esFormHijo Then guardarEstadoYSalir()
                    If Not esFormHijo Then enviarDatosDatabase()
                End If
            Else
                mostrarMensaje(mensajeValidacion)
            End If

        End If
    End Sub

    Private Function cargarEntradas() As Boolean
        Try
            Dim area As AreaLaboratorioInput, subarea As SubareaLaboratorioInput, examen As ExamenLaboratorioInput, kitEquipo As KitEquipoLaboratorioInput,
                tipoReferencia As ConceptoInput


            area = New AreaLaboratorioInput()
            area.codigo = areaSeleccionada.getCodigo()
            area.nombre = areaSeleccionada.getNombre()

            subarea = New SubareaLaboratorioInput()
            subarea.codigo = subareaSeleccionada.getCodigo()
            subarea.nombre = subareaSeleccionada.getNombre()

            examen = New ExamenLaboratorioInput()
            examen.codigo = examenSeleccionado.getCodigo
            examen.nombre = examenSeleccionado.getNombre()
            examen.area = area
            examen.subarea = subarea

            kitEquipo = New KitEquipoLaboratorioInput()
            kitEquipo.codigo = kitEquipoSeleccionado.getCodigo()
            kitEquipo.nombre = kitEquipoSeleccionado.getNombre()

            tipoReferencia = New ConceptoInput()
            tipoReferencia.correlativo = tipoReferenciaSeleccionada.getCorrelativo()
            tipoReferencia.descripcion = tipoReferenciaSeleccionada.getDescripcion()


            Dim tipo As Short = Short.Parse(tipoReferencia.correlativo)
            If tipo = 1 Then Return cargarEntradasReferenciaTipoComun(examen, kitEquipo, tipoReferencia)
            If tipo = 2 Then Return cargarEntradasReferenciaTipoSexo(examen, kitEquipo, tipoReferencia)
            If tipo = 3 Then Return cargarEntradasReferenciaTipoEdad(examen, kitEquipo, tipoReferencia)
            If tipo = 4 Then Return cargarEntradasReferenciasTipoSexoYEdad(examen, kitEquipo, tipoReferencia) Else Return cargarEntradasReferenciaTipoComun(examen, kitEquipo, tipoReferencia)

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function cargarEntradasReferenciaTipoComun(ByRef _examen As ExamenLaboratorioInput, ByRef _kitEquipo As KitEquipoLaboratorioInput,
                                                       ByRef _tipoReferencia As ConceptoInput) As Boolean

        Dim valorInicio As String, valorFin As String, row As DataGridViewRow
        inputNuevasReferencias = New ReferenciaResultadoLaboratorioInput(0) {}

        row = dgvReferencias.Rows(0)
        valorInicio = row.Cells(clmValorDesdeDgvReferencias).Value
        valorFin = row.Cells(clmValorHastaDgvReferencias).Value

        Dim inputReferencia As New ReferenciaResultadoLaboratorioInput()
        inputReferencia.examen = _examen
        inputReferencia.kitequipo = _kitEquipo
        inputReferencia.tipoReferencia = _tipoReferencia
        inputReferencia.valorInicio = valorInicio
        inputReferencia.valorFin = valorFin

        inputNuevasReferencias(0) = inputReferencia
        Return True
    End Function

    Private Function cargarEntradasReferenciaTipoSexo(ByRef _examen As ExamenLaboratorioInput, ByRef _kitEquipo As KitEquipoLaboratorioInput,
                                                       ByRef _tipoReferencia As ConceptoInput) As Boolean

        Dim index As Short = 0
        inputNuevasReferencias = New ReferenciaResultadoLaboratorioInput(1) {}


        For Each row As DataGridViewRow In dgvReferencias.Rows
            Dim valorInicio As String, valorFin As String, sexo As String

            valorInicio = row.Cells(clmValorDesdeDgvReferencias).Value
            valorFin = row.Cells(clmValorHastaDgvReferencias).Value
            sexo = row.Cells(clmSexoDgvReferencias).Value
            If sexo = "MASCULINO" Then sexo = "M" Else If sexo = "FEMENINO" Then sexo = "F"

            Dim inputReferencia As New ReferenciaResultadoLaboratorioInput()
            inputReferencia.examen = _examen
            inputReferencia.kitequipo = _kitEquipo
            inputReferencia.tipoReferencia = _tipoReferencia
            inputReferencia.valorInicio = valorInicio
            inputReferencia.valorFin = valorFin
            inputReferencia.sexo = sexo

            inputNuevasReferencias(index) = inputReferencia
            index += 1
        Next

        Return True
    End Function

    Private Function cargarEntradasReferenciaTipoEdad(ByRef _examen As ExamenLaboratorioInput, ByRef _kitEquipo As KitEquipoLaboratorioInput,
                                                      ByRef _tipoReferencia As ConceptoInput) As Boolean
        Dim index As Short = 0
        inputNuevasReferencias = New ReferenciaResultadoLaboratorioInput(dgvReferencias.Rows.Count - 1) {}


        For Each row As DataGridViewRow In dgvReferencias.Rows
            Dim edadInicio As String, edadFin As String, valorInicio As String, valorFin As String

            edadInicio = row.Cells(clmEdadDesdeDgvReferencias).Value
            edadFin = row.Cells(clmEdadHastaDgvReferencias).Value
            valorInicio = row.Cells(clmValorDesdeDgvReferencias).Value
            valorFin = row.Cells(clmValorHastaDgvReferencias).Value

            Dim iputReferencia As New ReferenciaResultadoLaboratorioInput()
            iputReferencia.examen = _examen
            iputReferencia.kitequipo = _kitEquipo
            iputReferencia.tipoReferencia = _tipoReferencia
            iputReferencia.valorInicio = valorInicio
            iputReferencia.valorFin = valorFin
            iputReferencia.edadInicio = edadInicio
            iputReferencia.edadFin = edadFin

            inputNuevasReferencias(index) = iputReferencia
            index += 1
        Next

        Return True
    End Function

    Private Function cargarEntradasReferenciasTipoSexoYEdad(ByRef _examen As ExamenLaboratorioInput, ByRef _kitEquipo As KitEquipoLaboratorioInput,
                                                            ByRef _tipoReferencia As ConceptoInput) As Boolean
        Dim nroReferencias As Short, index As Short

        nroReferencias = dgvReferencias.Rows.Count * 2
        index = 0
        inputNuevasReferencias = New ReferenciaResultadoLaboratorioInput(nroReferencias - 1) {}


        For Each row As DataGridViewRow In dgvReferencias.Rows
            Dim edadInicio As String, edadFin As String, valorInicioHombres As String, valorFinHombres As String,
                valorInicioMujeres As String, valorFinMujeres As String

            edadInicio = row.Cells(clmEdadDesdeDgvReferencias).Value
            edadFin = row.Cells(clmEdadHastaDgvReferencias).Value
            valorInicioHombres = row.Cells(clmValorHombresDesdeDgvReferencias).Value
            valorFinHombres = row.Cells(clmValorHombresHastaDgvReferencias).Value
            valorInicioMujeres = row.Cells(clmValorMujeresDesdeDgvReferencias).Value
            valorFinMujeres = row.Cells(clmValorMujeresHastaDgvReferencias).Value

            Dim hombresReferencia As New ReferenciaResultadoLaboratorioInput()
            hombresReferencia.examen = _examen
            hombresReferencia.kitequipo = _kitEquipo
            hombresReferencia.tipoReferencia = _tipoReferencia
            hombresReferencia.valorInicio = valorInicioHombres
            hombresReferencia.valorFin = valorFinHombres
            hombresReferencia.sexo = "M"
            hombresReferencia.edadInicio = edadInicio
            hombresReferencia.edadFin = edadFin

            Dim mujeresReferencia As New ReferenciaResultadoLaboratorioInput()
            mujeresReferencia.examen = _examen
            mujeresReferencia.kitequipo = _kitEquipo
            mujeresReferencia.tipoReferencia = _tipoReferencia
            mujeresReferencia.valorInicio = valorInicioMujeres
            mujeresReferencia.valorFin = valorFinMujeres
            mujeresReferencia.sexo = "F"
            mujeresReferencia.edadInicio = edadInicio
            mujeresReferencia.edadFin = edadFin

            inputNuevasReferencias(index) = hombresReferencia
            index += 1

            inputNuevasReferencias(index) = mujeresReferencia
            index += 1
        Next

        Return True
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(tipoReferenciaSeleccionada, inputNuevasReferencias)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try
            Dim tipo As Short = tipoReferenciaSeleccionada.getCorrelativo()

            nuevasReferencias = New ReferenciaResultadoLaboratorio(inputNuevasReferencias.Count - 1) {}
            For Each referencia As ReferenciaResultadoLaboratorio In nuevasReferencias
                referencia = New ReferenciaResultadoLaboratorio()
            Next


            If tipo = 1 Then Return cargarObjetosReferenciaTipoComun()
            If tipo = 2 Then Return cargarObjetosReferenciaTipoSexo()
            If tipo = 3 Then Return cargarObjetosReferenciaTipoEdad()
            If tipo = 4 Then Return cargarObjetosReferenciaTipoSexoYEdad()
            Return False

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function cargarObjetosReferenciaTipoComun()
        Dim valorInicio As Double, valorFin As Double, inputReferencia As ReferenciaResultadoLaboratorioInput

        inputReferencia = inputNuevasReferencias(0)
        nuevasReferencias = New ReferenciaResultadoLaboratorio(0) {}

        valorInicio = inputReferencia.valorInicio
        valorFin = inputReferencia.valorFin

        Dim referencia As New ReferenciaResultadoLaboratorio()
        referencia.setExamen(examenSeleccionado)
        referencia.setKitEquipo(kitEquipoSeleccionado)
        referencia.setTipo(tipoReferenciaSeleccionada)
        referencia.setValorInicio(valorInicio)
        referencia.setValorFin(valorFin)
        nuevasReferencias(0) = referencia

        Return True
    End Function

    Private Function cargarObjetosReferenciaTipoSexo()
        Dim index As Short = 0
        nuevasReferencias = New ReferenciaResultadoLaboratorio(1) {}

        For Each inputReferencia As ReferenciaResultadoLaboratorioInput In inputNuevasReferencias
            Dim valorInicio As Double, valorFin As Double, sexo As Char, referencia As ReferenciaResultadoLaboratorio

            valorInicio = inputReferencia.valorInicio
            valorFin = inputReferencia.valorFin
            sexo = inputReferencia.sexo

            referencia = New ReferenciaResultadoLaboratorio()
            referencia.setExamen(examenSeleccionado)
            referencia.setKitEquipo(kitEquipoSeleccionado)
            referencia.setTipo(tipoReferenciaSeleccionada)
            referencia.setValorInicio(valorInicio)
            referencia.setValorFin(valorFin)
            referencia.setSexo(sexo)
            nuevasReferencias(index) = referencia
            index += 1
        Next

        Return True
    End Function

    Private Function cargarObjetosReferenciaTipoEdad()
        Dim nroReferencias As Short, index As Short

        nroReferencias = inputNuevasReferencias.Count
        index = 0
        nuevasReferencias = New ReferenciaResultadoLaboratorio(nroReferencias - 1) {}

        For Each inputReferencia As ReferenciaResultadoLaboratorioInput In inputNuevasReferencias
            Dim edadInicio As Short, edadFin As Short, valorInicio As Double, valorFin As Double,
                referencia As ReferenciaResultadoLaboratorio

            edadInicio = inputReferencia.edadInicio
            edadFin = inputReferencia.edadFin
            valorInicio = inputReferencia.valorInicio
            valorFin = inputReferencia.valorFin

            referencia = New ReferenciaResultadoLaboratorio()
            referencia.setExamen(examenSeleccionado)
            referencia.setKitEquipo(kitEquipoSeleccionado)
            referencia.setTipo(tipoReferenciaSeleccionada)
            referencia.setEdadInicio(edadInicio)
            referencia.setEdadFin(edadFin)
            referencia.setValorInicio(valorInicio)
            referencia.setValorFin(valorFin)
            nuevasReferencias(index) = referencia
            index += 1
        Next

        Return True
    End Function

    Private Function cargarObjetosReferenciaTipoSexoYEdad()
        Dim nroReferencias As Short, index As Short

        nroReferencias = inputNuevasReferencias.Count
        index = 0
        nuevasReferencias = New ReferenciaResultadoLaboratorio(nroReferencias - 1) {}

        For Each inputReferencia As ReferenciaResultadoLaboratorioInput In inputNuevasReferencias
            Dim edadInicio As Short, edadFin As Short, sexo As Char, valorInicio As Double,
                valorFin As Double, referencia As ReferenciaResultadoLaboratorio

            edadInicio = inputReferencia.edadInicio
            edadFin = inputReferencia.edadFin
            sexo = inputReferencia.sexo
            valorInicio = inputReferencia.valorInicio
            valorFin = inputReferencia.valorFin

            referencia = New ReferenciaResultadoLaboratorio()
            referencia.setExamen(examenSeleccionado)
            referencia.setKitEquipo(kitEquipoSeleccionado)
            referencia.setTipo(tipoReferenciaSeleccionada)
            referencia.setEdadInicio(edadInicio)
            referencia.setEdadFin(edadFin)
            referencia.setSexo(sexo)
            referencia.setValorInicio(valorInicio)
            referencia.setValorFin(valorFin)
            nuevasReferencias(index) = referencia

            index += 1
        Next

        Return True
    End Function

    Private Sub enviarDatosDatabase()
        registro.insertReferencias(tipoReferenciaSeleccionada, nuevasReferencias)

        Dim mensajeInsercion As String = registro.generarMensajeInsercion()
        mostrarMensaje(mensajeInsercion)
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub

    Private Sub guardarEstadoYSalir()
        estadoFormGuardado = True
        Me.Hide()
    End Sub

    Private Sub descartarEstado()
        estadoFormGuardado = False
    End Sub






    'METODOS INTERFAZ G1 --
    Private Sub poblarCboxAreas()
        cboxArea.Items.Clear()

        For Each area As AreaLaboratorio In registro.areas
            cboxArea.Items.Add(area.getNombre())
        Next
    End Sub

    Private Sub poblarCboxSubareas()
        cboxSubarea.Items.Clear()

        For Each subarea As SubareaLaboratorio In registro.subareas
            cboxSubarea.Items.Add(subarea.getNombre())
        Next
    End Sub

    Private Sub poblarCboxExamen()
        cboxExamen.Items.Clear()

        For Each examen As ExamenLaboratorio In registro.examenes
            cboxExamen.Items.Add(examen.getNombre())
        Next
    End Sub

    Private Sub poblarCboxKitEquipo()
        cboxKitEquipo.Items.Clear()

        For Each kitEquipo As KitEquipoLaboratorio In registro.kitsequipos
            cboxKitEquipo.Items.Add(kitEquipo.getNombre())
        Next
    End Sub

    Private Sub poblarCboxTipoValoresReferencia()
        cboxTipoReferencia.Items.Clear()

        For Each tipo As Concepto In registro.tiposReferencia
            cboxTipoReferencia.Items.Add(tipo.getDescripcion())
        Next
    End Sub

    Private Sub deshabilitarControlesAreaSubareaExamen()
        lblArea.Enabled = False
        lblSubarea.Enabled = False
        lblExamen.Enabled = False

        deshabilitarCboxArea()
        deshabilitarCboxSubarea()
        deshabilitarCboxExamen()
    End Sub

    Private Sub ocultarHintArea()
        hintArea.Visible = False
    End Sub

    Private Sub deshabilitarCboxArea()
        cboxArea.Enabled = False
    End Sub

    Private Sub ocultarHintSubarea()
        hintSubarea.Visible = False
    End Sub

    Private Sub deshabilitarCboxSubarea()
        cboxSubarea.Enabled = False
    End Sub

    Private Sub ocultarHintExamen()
        hintExamen.Visible = False
    End Sub

    Private Sub deshabilitarCboxExamen()
        cboxExamen.Enabled = False
    End Sub

    Private Sub habilitarCboxKitEquipo()
        cboxKitEquipo.Enabled = True
    End Sub

    Private Sub deshabilitarCboxKitEquipo()
        cboxKitEquipo.Enabled = False
    End Sub

    Private Sub mostrarHintKitEquipo()
        hintKitEquipo.Visible = True
    End Sub

    Private Sub ocultarHintKitEquipo()
        hintKitEquipo.Visible = False
    End Sub

    Private Sub habilitarHintKitEquipo()
        hintKitEquipo.Enabled = True
    End Sub

    Private Sub deshabilitarHintKitEquipo()
        hintKitEquipo.Enabled = False
    End Sub

    Private Sub habilitarCboxTipoReferencia()
        cboxTipoReferencia.Enabled = True
    End Sub

    Private Sub deshabilitarCboxTipoReferencia()
        cboxTipoReferencia.Enabled = False
    End Sub

    Private Sub mostrarHintTipoRereferencia()
        hintTipoReferencia.Visible = True
    End Sub

    Private Sub ocultarHintTipoRereferencia()
        hintTipoReferencia.Visible = False
    End Sub

    Private Sub habilitarHintTIpoReferencia()
        hintTipoReferencia.Enabled = True
    End Sub

    Private Sub deshabilitarHintTipoReferencia()
        hintTipoReferencia.Enabled = False
    End Sub


    'METODOS INTERFAZ G2
    Private Sub ajustarInterfazDgvReferencias()
        Dim tipoReferencia As Short = tipoReferenciaSeleccionada.getCorrelativo()

        reiniciarCeldasDgv()
        concatenarUnidadEnHeadersValores()

        If tipoReferencia = 1 Then
            ajustarInterfazDgvParaValoresComunes()
            deshabilitarBtnAgregarFila()
        End If

        If tipoReferencia = 2 Then
            ajustarInterfazDgvParaValoresPorSexo()
            deshabilitarBtnAgregarFila()
        End If

        If tipoReferencia = 3 Then
            ajustarInterfazDgvParaValoresPorEdad()
            habilitarBtnAgregarFila()
        End If

        If tipoReferencia = 4 Then
            ajustartInterfazDgvParaValoresPorSexoYedad()
            habilitarBtnAgregarFila()
        End If
    End Sub

    Private Sub reiniciarCeldasDgv()
        Dim clmAcccionIndex As Short = dgvReferencias.Columns(clmAccionDgvReferemcias).Index

        For Each row As DataGridViewRow In dgvReferencias.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not cell.ColumnIndex = clmAcccionIndex Then cell.Value = ""

            Next
        Next
    End Sub

    Private Sub concatenarUnidadEnHeadersValores()
        Dim abreviacion As String = examenSeleccionado.getUnidad().getAbreviacion()

        lblHeaderValores.Text = "VALORES EN " + abreviacion
        lblHeaderValoresHombres.Text = "VALORES EN " + abreviacion + " - HOMBRES"
        lblHeaderValoresMujeres.Text = "VALORES EN " + abreviacion + " - MUJERES"
    End Sub

    Private Sub ajustarInterfazDgvParaValoresComunes()
        'MOSTRAR ENCABEZADOS
        lblHeaderValores.Visible = True
        lblHeaderValores.Location = New Point(72, 245)
        lblHeaderValores.Size = New Size(201, 25)

        'OCULTAR ENCABEZADOS
        lblHeaderEdad.Visible = False
        lblHeaderEdad.Location = New Point(0, 0)
        lblHeaderEdad.Size = New Size(0, 0)

        lblHeaderValoresHombres.Visible = False
        lblHeaderValoresHombres.Location = New Point(0, 0)
        lblHeaderValoresHombres.Size = New Size(0, 0)

        lblHeaderValoresMujeres.Visible = False
        lblHeaderValoresMujeres.Location = New Point(0, 0)
        lblHeaderValoresMujeres.Size = New Size(0, 0)




        'ESPACIAR COLUMNAS
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Width = 100
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Width = 100




        'OCULTAR COLUMNAS
        dgvReferencias.Columns(clmSexoDgvReferencias).Visible = False
        dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = False
        dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorHombresDesdeDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorHombresHastaDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorMujeresDesdeDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorMujeresHastaDgvReferencias).Visible = False
        dgvReferencias.Columns(clmAccionDgvReferemcias).Visible = False
        'MOSTRAR COLUMNAS
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True




        'PERMISOS DGV
        dgvReferencias.AllowUserToAddRows = False
        dgvReferencias.AllowUserToDeleteRows = False
        dgvReferencias.ReadOnly = False




        'ASIGNAR FILAS NECESARIAS
        dgvReferencias.Rows.Clear()
        dgvReferencias.Rows.Add(1)
    End Sub

    Private Sub ajustarInterfazDgvParaValoresPorSexo()
        'ENCABEZADOS
        lblHeaderEdad.Visible = False
        lblHeaderEdad.Location = New Point(0, 0)
        lblHeaderEdad.Size = New Size(0, 0)

        lblHeaderValoresHombres.Visible = False
        lblHeaderValoresHombres.Location = New Point(0, 0)
        lblHeaderValoresHombres.Size = New Size(0, 0)

        lblHeaderValoresMujeres.Visible = False
        lblHeaderValoresMujeres.Location = New Point(0, 0)
        lblHeaderValoresMujeres.Size = New Size(0, 0)

        lblHeaderValores.Visible = True
        lblHeaderValores.Location = New Point(169, 245)
        lblHeaderValores.Size = New Size(209, 25)




        'ESPACIAR COLUMNAS
        dgvReferencias.Columns(clmSexoDgvReferencias).Width = 100
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Width = 100
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Width = 100




        'OCULTAR COLUMNAS
        dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = False
        dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = False
        dgvReferencias.Columns(clmAccionDgvReferemcias).Visible = False

        'MOSTRAR COLUMNAS
        dgvReferencias.Columns(clmSexoDgvReferencias).Visible = True
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True




        'PERMISOS DGV
        dgvReferencias.AllowUserToAddRows = False
        dgvReferencias.AllowUserToDeleteRows = False
        dgvReferencias.ReadOnly = False




        'ASIGNAR FILAS NECESARIAS
        dgvReferencias.Rows.Clear()
        dgvReferencias.Rows.Add(2)

        dgvReferencias.Rows(0).Cells(clmSexoDgvReferencias).Value = "MASCULINO"
        dgvReferencias.Rows(0).Cells(clmSexoDgvReferencias).ReadOnly = True
        dgvReferencias.Rows(1).Cells(clmSexoDgvReferencias).Value = "FEMENINO"
        dgvReferencias.Rows(1).Cells(clmSexoDgvReferencias).ReadOnly = True


    End Sub

    Private Sub ajustarInterfazDgvParaValoresPorEdad()
        'ENCABEZADOS
        lblHeaderValoresHombres.Visible = False
        lblHeaderValoresHombres.Location = New Point(0, 0)
        lblHeaderValoresHombres.Size = New Size(0, 0)

        lblHeaderValoresMujeres.Visible = False
        lblHeaderValoresMujeres.Location = New Point(0, 0)
        lblHeaderValoresMujeres.Size = New Size(0, 0)

        lblHeaderEdad.Visible = True
        lblHeaderEdad.Location = New Point(74, 245)
        lblHeaderEdad.Size = New Size(200, 25)

        lblHeaderValores.Visible = True
        lblHeaderValores.Location = New Point(268, 245)
        lblHeaderValores.Size = New Size(209, 25)




        'ESPACIAR COLUMNAS
        dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Width = 100
        dgvReferencias.Columns(clmEdadHastaDgvReferencias).Width = 100
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Width = 100
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Width = 100
        dgvReferencias.Columns(clmAccionDgvReferemcias).Width = 100




        'OCULTAR COLUMNAS
        dgvReferencias.Columns(clmSexoDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorHombresDesdeDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorHombresHastaDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorMujeresDesdeDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorMujeresHastaDgvReferencias).Visible = False
        'MOSTRAR COLUMNAS
        dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = True
        dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = True
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True
        dgvReferencias.Columns(clmAccionDgvReferemcias).Visible = True




        'PERMISOS DGV
        dgvReferencias.ReadOnly = False
        dgvReferencias.AllowUserToAddRows = False
        dgvReferencias.AllowUserToDeleteRows = False


        'ASIGNAR FILAS NECESARIAS
        dgvReferencias.Rows.Clear()
        dgvReferencias.Rows.Add(1)
    End Sub

    Private Sub ajustartInterfazDgvParaValoresPorSexoYedad()
        'ENCABEZADOS
        lblHeaderEdad.Visible = True
        lblHeaderEdad.Location = New Point(72, 245)
        lblHeaderEdad.Size = New Size(124, 25)

        lblHeaderValores.Visible = False
        lblHeaderValores.Location = New Point(0, 0)
        lblHeaderValores.Size = New Size(0, 0)

        lblHeaderValoresHombres.Visible = True
        lblHeaderValoresHombres.Location = New Point(192, 245)
        lblHeaderValoresHombres.Size = New Size(202, 25)

        lblHeaderValoresMujeres.Visible = True
        lblHeaderValoresMujeres.Location = New Point(391, 245)
        lblHeaderValoresMujeres.Size = New Size(203, 25)




        'ESPACIAR COLUMNAS
        dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Width = 60
        dgvReferencias.Columns(clmEdadHastaDgvReferencias).Width = 60
        dgvReferencias.Columns(clmValorHombresDesdeDgvReferencias).Width = 100
        dgvReferencias.Columns(clmValorHombresHastaDgvReferencias).Width = 100
        dgvReferencias.Columns(clmValorMujeresDesdeDgvReferencias).Width = 100
        dgvReferencias.Columns(clmValorMujeresHastaDgvReferencias).Width = 100
        dgvReferencias.Columns(clmAccionDgvReferemcias).Width = 85




        'OCULTAR COLUMNAS
        dgvReferencias.Columns(clmSexoDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = False
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = False
        'MOSTRAR COLUMNAS
        dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = True
        dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = True
        dgvReferencias.Columns(clmValorHombresDesdeDgvReferencias).Visible = True
        dgvReferencias.Columns(clmValorHombresHastaDgvReferencias).Visible = True
        dgvReferencias.Columns(clmValorMujeresDesdeDgvReferencias).Visible = True
        dgvReferencias.Columns(clmValorMujeresHastaDgvReferencias).Visible = True
        dgvReferencias.Columns(clmAccionDgvReferemcias).Visible = True




        'PERMISOS DGV
        dgvReferencias.ReadOnly = False
        dgvReferencias.AllowUserToAddRows = False
        dgvReferencias.AllowUserToDeleteRows = False


        'ASIGNAR FILAS NECESARIAS
        dgvReferencias.Rows.Clear()
        dgvReferencias.Rows.Add(1)
    End Sub

    Private Sub eliminarFilaDgvReferencias(_indexFila As Short)
        Dim row As DataGridViewRow = dgvReferencias.Rows(_indexFila)
        dgvReferencias.Rows.Remove(row)
    End Sub

    Private Sub habilitarBtnAgregarFila()
        btnAgregarFila.Enabled = True
    End Sub

    Private Sub deshabilitarBtnAgregarFila()
        btnAgregarFila.Enabled = False
    End Sub


    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub







    'EVENTOS G0 --
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim form As FormMenuLaboratorio

        form = New FormMenuLaboratorio()
        form.Show()
        Me.Close()
    End Sub


    'EVENTOS G1 
    Private Sub cboxArea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxArea.SelectionChangeCommitted
        Try
            seleccionarArea()
            ocultarHintArea()

            traerSubareas()
            poblarCboxSubareas()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxSubarea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxSubarea.SelectionChangeCommitted
        Try
            seleccionarSubarea()
            ocultarHintSubarea()

            traerExamenes()
            poblarCboxExamen()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxExamen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxExamen.SelectionChangeCommitted
        Try
            seleccionarExamen()
            ocultarHintExamen()

            deshabilitarControlesAreaSubareaExamen()

            habilitarCboxKitEquipo()
            habilitarHintKitEquipo()

            traerKitsEquipos()
            poblarCboxKitEquipo()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxKitEquipo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxKitEquipo.SelectionChangeCommitted
        Try
            seleccionarKitEquipo()
            ocultarHintKitEquipo()

            habilitarCboxTipoReferencia()
            habilitarHintTIpoReferencia()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxTipoValoresReferencia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTipoReferencia.SelectionChangeCommitted
        Try
            seleccionarTipoReferencia()
            ocultarHintTipoRereferencia()
            ajustarInterfazDgvReferencias()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    'EVENTOS G2
    Private Sub dgvReferencias_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvReferencias.RowPostPaint
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

    Private Sub dgvReferencias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReferencias.CellClick
        Try
            'SI ES CLICK EN UNA FILA HEADER
            If e.RowIndex < 0 Then Return

            If esClickEnColumnaAccion(e.ColumnIndex) Then eliminarFilaDgvReferencias(e.RowIndex)

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarFila_Click(sender As Object, e As EventArgs) Handles btnAgregarFila.Click
        dgvReferencias.Rows.Add()
    End Sub



    'EVENTOS G9
    Private Sub FormRegistrarReferenciaResultadoLaboratorio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If e.CloseReason = CloseReason.UserClosing Then descartarEstado()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub






End Class




