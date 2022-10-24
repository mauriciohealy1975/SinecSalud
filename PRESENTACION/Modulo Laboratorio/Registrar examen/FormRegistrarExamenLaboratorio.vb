Imports NEGOCIO

Public Class FormRegistrarExamenLaboratorio

    'ATRIBUTOS LÓGICOS
    Private registro As RegistroExamenLaboratorio

    'ATRIBUTOS FORM MODO HIJO
    Private esFormHijo As Boolean


    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private areaSeleccionada As AreaLaboratorio
    Private subareaSeleccionada As SubareaLaboratorio
    Private tipoResultadoSeleccionado As Concepto

    'ATRIBUTOS G2 -- RESULTADO FORMATO 1
    Public unidadSeleccionada As UnidadMedidaLaboratorio

    'ATRIBUTOS G3a --RESULTADO TIPO 1
    Private formKitEquipo As FormRegistrarKitEquipoLaboratorio
    Private estadoFormHijoKitEquipoGuardado As Boolean
    Private nuevoKitEquipo As KitEquipoLaboratorio
    Private nuevasReferencias As ReferenciaResultadoLaboratorio()


    'ATRIBUTOS G3b -- RESULTADO TIPO 2
    Private conjuntoSeleccionado As ConjuntoOpcionesResultadosLaboratorio
    Private clmValorDgvOpciones As String


    'ATRIBUTOS G9  
    Private nuevoInputExamen As ExamenLaboratorioInput
    Private nuevoExamen As ExamenLaboratorio






    'METODOS INICIO --
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(False)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormRegistrarExamenLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(ByRef _esHijo As Boolean)
        esFormHijo = _esHijo

        If _esHijo Then

        Else

        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarInterfaz()

        traerAreas()
        poblarCboxArea()

        traerTipoDeResultado()
        poblarCboxTipoResultado()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroExamenLaboratorio()

        'ATRIBUTOS G0
        tituloFormulario = "Registrar examen de laboratorio"

        'ATRIBUTOS G1
        areaSeleccionada = New AreaLaboratorio()
        subareaSeleccionada = New SubareaLaboratorio()
        tipoResultadoSeleccionado = New Concepto()

        'ATRIBUTOS G2
        unidadSeleccionada = New UnidadMedidaLaboratorio()

        'ATRIBUTOS G3a
        formKitEquipo = New FormRegistrarKitEquipoLaboratorio()
        estadoFormHijoKitEquipoGuardado = False
        nuevoKitEquipo = New KitEquipoLaboratorio()
        nuevasReferencias = New ReferenciaResultadoLaboratorio(-1) {}

        'ATRIBUTOS G3b
        conjuntoSeleccionado = New ConjuntoOpcionesResultadosLaboratorio()
        clmValorDgvOpciones = "clmValor"

        'ATRIBUTOS G9  
        nuevoInputExamen = New ExamenLaboratorioInput()
        nuevoExamen = New ExamenLaboratorio()
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarInterfaz()
        iniciarInterfazGrupo0()
        iniciarInterfazGrupo1()
        iniciarInterfazGrupo2()
        iniciarInterfazGrupo3a()
        iniciarInterfazGrupo3b()
    End Sub

    Private Sub iniciarInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper

        If esFormHijo Then menuStrip.Enabled = False
        If Not esFormHijo Then menuStrip.Enabled = True
    End Sub

    Private Sub iniciarInterfazGrupo1()
        panelDatosExamen.Enabled = True
        panelDatosExamen.Visible = True


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

        btnRegistrarArea.Enabled = True
        btnRegistrarArea.Visible = True
        btnRegistrarArea.Font = New Font("Microsoft Sans Serif", 9)
        btnRegistrarArea.Text = "Registrar area"



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

        btnRegistrarSubarea.Enabled = True
        btnRegistrarSubarea.Visible = True
        btnRegistrarSubarea.Font = New Font("Microsoft Sans Serif", 9)
        btnRegistrarSubarea.Text = "Registrar subarea"



        txtNombreExamen.Enabled = True
        txtNombreExamen.Visible = True
        txtNombreExamen.Font = New Font("Microsoft Sans Serif", 9)
        txtNombreExamen.Text = ""
        txtNombreExamen.CharacterCasing = CharacterCasing.Upper




        cboxTipoResultado.Enabled = True
        cboxTipoResultado.Visible = True
        cboxTipoResultado.Font = New Font("Microsoft Sans Serif", 9)
        cboxTipoResultado.Items.Clear()
        cboxTipoResultado.DropDownStyle = ComboBoxStyle.DropDownList

        hintTipoResultado.Enabled = True
        hintTipoResultado.Visible = True
        hintTipoResultado.Font = New Font("Microsoft Sans Serif", 8)
        hintTipoResultado.Text = "SELECCIONAR"
        hintTipoResultado.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarInterfazGrupo2()
        panelDatosUnidad.Enabled = True
        panelDatosUnidad.Visible = False

        txtBuscarUnidad.Enabled = True
        txtBuscarUnidad.Visible = True
        txtBuscarUnidad.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarUnidad.Text = ""
        txtBuscarUnidad.CharacterCasing = CharacterCasing.Upper

        btnBuscarUnidad.Enabled = True
        btnBuscarUnidad.Visible = True
        btnBuscarUnidad.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarUnidad.Text = "Buscar"

        cboxUnidadMedida.Enabled = True
        cboxUnidadMedida.Visible = True
        cboxUnidadMedida.Font = New Font("Microsoft Sans Serif", 9)
        cboxUnidadMedida.Items.Clear()
        cboxUnidadMedida.DropDownStyle = ComboBoxStyle.DropDownList

        hintUnidadMedida.Enabled = True
        hintUnidadMedida.Visible = True
        hintUnidadMedida.Font = New Font("Microsoft Sans Serif", 8)
        hintUnidadMedida.Text = "SELECCIONAR"
        hintUnidadMedida.BackColor = Color.Transparent

        btnRegistrarUnidadMedida.Enabled = True
        btnRegistrarUnidadMedida.Visible = True
        btnRegistrarUnidadMedida.Font = New Font("Microsoft Sans Serif", 9)
        btnRegistrarUnidadMedida.Text = "Registrar nueva unidad"
    End Sub

    Private Sub iniciarInterfazGrupo3a()
        panelResultado1.Enabled = True
        panelResultado1.Visible = False

        lblNombreKitEquipo.Enabled = False
        lblNombreKitEquipo.Visible = True
        lblNombreKitEquipo.Font = New Font("Microsoft Sans Serif", 9.5)
        lblNombreKitEquipo.Text = "Nombre del kit-equipo"

        txtKitEquipo.Enabled = False
        txtKitEquipo.Visible = True
        txtKitEquipo.Font = New Font("Microsoft Sans Serif", 9)
        txtKitEquipo.Text = ""
        txtKitEquipo.CharacterCasing = CharacterCasing.Upper

        lblNombreTipoReferencia.Enabled = False
        lblNombreTipoReferencia.Visible = True
        lblNombreTipoReferencia.Font = New Font("Microsoft Sans Serif", 9.5)
        lblNombreTipoReferencia.Text = "Tipo de referencia"

        txtTipoReferencia.Enabled = False
        txtTipoReferencia.Visible = True
        txtTipoReferencia.Font = New Font("Microsoft Sans Serif", 9)
        txtTipoReferencia.Text = ""
        txtTipoReferencia.CharacterCasing = CharacterCasing.Upper


        btnRegistrarKitEquipo.Enabled = True
        btnRegistrarKitEquipo.Visible = True
        btnRegistrarKitEquipo.Font = New Font("Microsoft Sans Serif", 9)
        btnRegistrarKitEquipo.Text = "Registrar nuevo kit-equipo"

        chKitEquipoAsignado.Enabled = False
        chKitEquipoAsignado.Visible = True
        chKitEquipoAsignado.Checked = False
        chKitEquipoAsignado.Font = New Font("Microsoft Sans Serif", 9.5)
        chKitEquipoAsignado.Text = "Kit-equipo asignado"
    End Sub

    Private Sub iniciarInterfazGrupo3b()
        panelResultado2.Enabled = True
        panelResultado2.Visible = False

        txtBuscarConjunto.Enabled = True
        txtBuscarConjunto.Visible = True
        txtBuscarConjunto.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarConjunto.Text = ""
        txtBuscarConjunto.CharacterCasing = CharacterCasing.Upper

        btnBuscarConjunto.Enabled = True
        btnBuscarConjunto.Visible = True
        btnBuscarConjunto.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarConjunto.Text = "Buscar"

        cboxConjunto.Enabled = True
        cboxConjunto.Visible = True
        cboxConjunto.Font = New Font("Microsoft Sans Serif", 9)
        cboxConjunto.Items.Clear()
        cboxConjunto.DropDownStyle = ComboBoxStyle.DropDownList

        hintConjunto.Enabled = True
        hintConjunto.Visible = True
        hintConjunto.Font = New Font("Microsoft Sans Serif", 8)
        hintConjunto.Text = "SELECCIONAR"
        hintConjunto.BackColor = Color.Transparent

        btnRegistrarConjunto.Enabled = True
        btnRegistrarConjunto.Visible = True
        btnRegistrarConjunto.Font = New Font("Microsoft Sans Serif", 9)
        btnRegistrarConjunto.Text = "Registrar nuevo conjunto de opciones"

        iniciarDgvOpciones()
    End Sub

    Public Sub iniciarDgvOpciones()
        'propiedades base
        dgvOpciones.Enabled = True
        dgvOpciones.Font = New Font("Microsoft Sans Serif", 9)
        'dgvOpciones.Size = New Size(665, 155)




        'propiedades permisos editar
        dgvOpciones.EditMode = DataGridViewEditMode.EditOnEnter
        dgvOpciones.AllowUserToAddRows = False
        dgvOpciones.AllowUserToDeleteRows = False
        dgvOpciones.AllowUserToResizeRows = False
        dgvOpciones.AllowUserToOrderColumns = False
        dgvOpciones.AllowUserToResizeColumns = False
        dgvOpciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvOpciones.MultiSelect = False
        dgvOpciones.ReadOnly = True




        'propiedades estilos selección
        dgvOpciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOpciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect




        'propiedades estilos color encabezados columnas
        dgvOpciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvOpciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black




        'propiedades estilos color seleccion encabezados filas
        dgvOpciones.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvOpciones.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)




        'propiedaes estilos color celdas
        dgvOpciones.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvOpciones.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvOpciones.DefaultCellStyle.ForeColor = Color.Black
        'MAYUSCUL dgvOpciones.DefaultCellStyle.




        'propiedaes estilos color celdas seleccionadas
        dgvOpciones.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvOpciones.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)




        'propiedades otras celdas
        dgvOpciones.ScrollBars = ScrollBars.Both
        dgvOpciones.EnableHeadersVisualStyles = False




        'columnas -- agregar columnas
        dgvOpciones.Columns.Clear()

        dgvOpciones.Columns.Add(clmValorDgvOpciones, "VALOR")
        dgvOpciones.Columns(clmValorDgvOpciones).Visible = True


        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvOpciones.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        'alinear columnas
        For Each columna As DataGridViewColumn In dgvOpciones.Columns

            If columna.Name = clmValorDgvOpciones Then
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
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
        dgvOpciones.Rows.Clear()
        dgvOpciones.Rows.Add(1)
    End Sub

    Private Sub establecerDisplay()
        Dim ejeX As Short, ejeY As Short

        ejeX = Utilitarios.resolucionEstandarEjeX
        ejeY = Utilitarios.resolucionEstandarEjeY

        Dim size As New Size(ejeX, ejeY)

        Me.Size = size
        MinimumSize = size
        MaximumSize = size

        Me.CenterToScreen()
    End Sub



    'MÉTODOS LÓGICOS G1
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

    Private Sub traerTipoDeResultado()
        registro.traerTipoDeResultado()
    End Sub

    Private Sub seleccionarTipoResultado()
        Dim index As Short = cboxTipoResultado.SelectedIndex
        tipoResultadoSeleccionado = registro.tiposResultado(index)
    End Sub

    Private Function esTipoResultadoComun() As Boolean
        Dim tipoComun As Boolean = registro.esTipoResultadoComun(tipoResultadoSeleccionado)
        Return tipoComun
    End Function


    'MÉTODOS LÓGICOS G2
    Private Sub traerUnidadesMedida()
        Dim nombreUnidad As String = txtBuscarUnidad.Text.Trim()
        registro.traerUnidadesMedida(nombreUnidad)
    End Sub

    Private Sub seleccionarUnidadMedida()
        Dim index As Short = cboxUnidadMedida.SelectedIndex
        unidadSeleccionada = registro.unidadesMedida(index)
    End Sub


    'MÉTODOS LÓGICOS G3a
    Private Sub abrirFormularioKitEqiupo()
        nuevoExamen.setCodigo(1)
        nuevoExamen.setNombre(txtNombreExamen.Text.Trim())
        nuevoExamen.setArea(areaSeleccionada)
        nuevoExamen.setSubarea(subareaSeleccionada)


        If Not estadoFormHijoKitEquipoGuardado Then
            formKitEquipo = New FormRegistrarKitEquipoLaboratorio(nuevoExamen, unidadSeleccionada, tipoResultadoSeleccionado)
        End If


        formKitEquipo.ShowDialog()
        estadoFormHijoKitEquipoGuardado = formKitEquipo.estadoFormGuardado
        nuevoKitEquipo = formKitEquipo.nuevoKitEquipo
        nuevasReferencias = formKitEquipo.nuevasReferenciasLaboratorio
    End Sub

    'MÉTODOS LÓGICOS G3b
    Private Sub traerConjuntosOpciones()
        Dim nombre As String = txtBuscarConjunto.Text.Trim()
        registro.traerConjuntosOpciones(nombre)

    End Sub

    Private Sub seleccionarConjunto()
        Dim index As Short = cboxConjunto.SelectedIndex
        conjuntoSeleccionado = registro.conjuntosOpciones(index)
    End Sub

    Private Sub traerOpciones()
        registro.traerOpciones(conjuntoSeleccionado)
    End Sub

    Private Sub abrirFormRegistrarConjuntoOpciones()
        Dim formConjunto As FormRegistrarConjuntoOpcionesResultadoLaboratorio

        formConjunto = New FormRegistrarConjuntoOpcionesResultadoLaboratorio(True)
        formConjunto.ShowDialog()
    End Sub


    'MÉTODOS LÓGICOS G9tru  
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean = cargarEntradas()

        If entradasCargadas Then
            Dim mensajeValidacion As String = validarEntradas()

            If mensajeValidacion = "" Then
                Dim objetosCargados As Boolean = cargarObjetos()
                If objetosCargados Then enviarDatosDatabase()
            Else
                mostrarMensaje(mensajeValidacion)
            End If
        End If
    End Sub

    Private Function cargarEntradas() As Boolean
        Try
            Dim area As AreaLaboratorioInput, subarea As SubareaLaboratorioInput, nombre As String, tipoResultado As ConceptoInput

            area = New AreaLaboratorioInput()
            area.codigo = areaSeleccionada.getCodigo()
            area.nombre = areaSeleccionada.getNombre()

            subarea = New SubareaLaboratorioInput()
            subarea.codigo = subareaSeleccionada.getCodigo()
            subarea.nombre = subareaSeleccionada.getNombre()

            nombre = txtNombreExamen.Text.Trim()

            tipoResultado = New ConceptoInput()
            tipoResultado.correlativo = tipoResultadoSeleccionado.getCorrelativo()
            tipoResultado.descripcion = tipoResultadoSeleccionado.getDescripcion()


            Dim tipo As Short = Short.Parse(tipoResultado.correlativo)

            If tipo = 1 Then Return cargarEntradasResultadoTipoComunNumerico(area, subarea, nombre, tipoResultado)
            If tipo = 2 Then Return cargarEntradasResultadoTipoOpccionSeleccion(area, subarea, nombre, tipoResultado)
            If tipo = 3 Then Return cargarEntradasResultadoTipoTextual(area, subarea, nombre, tipoResultado) Else Return cargarEntradasResultadoTipoComunNumerico(area, subarea, nombre, tipoResultado)


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function cargarEntradasResultadoTipoComunNumerico(ByRef _area As AreaLaboratorioInput, _subarea As SubareaLaboratorioInput, _nombre As String,
                                                              _tipoResultado As ConceptoInput) As Boolean
        Dim unidad As New UnidadMedidaLaboratorioInput()

        unidad.codigo = unidadSeleccionada.getCodigo()
        unidad.nombre = unidadSeleccionada.getNombre()
        unidad.abreviacion = unidadSeleccionada.getAbreviacion()

        nuevoInputExamen = New ExamenLaboratorioInput()
        nuevoInputExamen.area = _area
        nuevoInputExamen.subarea = _subarea
        nuevoInputExamen.nombre = _nombre
        nuevoInputExamen.tipoResultado = _tipoResultado
        nuevoInputExamen.unidad = unidad

        Return True
    End Function

    Private Function cargarEntradasResultadoTipoOpccionSeleccion(ByRef _area As AreaLaboratorioInput, _subarea As SubareaLaboratorioInput, _nombre As String,
                                                              _tipoResultado As ConceptoInput) As Boolean


        Dim conjuntoOpciones As New ConjuntoOpcionesResultadosLabInput()
        conjuntoOpciones.codigo = conjuntoSeleccionado.getCodigo()

        nuevoInputExamen = New ExamenLaboratorioInput()
        nuevoInputExamen.area = _area
        nuevoInputExamen.subarea = _subarea
        nuevoInputExamen.nombre = _nombre
        nuevoInputExamen.tipoResultado = _tipoResultado
        nuevoInputExamen.conjuntoOpcionesResultado = conjuntoOpciones

        Return True
    End Function

    Private Function cargarEntradasResultadoTipoTextual(ByRef _area As AreaLaboratorioInput, _subarea As SubareaLaboratorioInput, _nombre As String,
                                                              _tipoResultado As ConceptoInput) As Boolean

        nuevoInputExamen = New ExamenLaboratorioInput()
        nuevoInputExamen.area = _area
        nuevoInputExamen.subarea = _subarea
        nuevoInputExamen.nombre = _nombre
        nuevoInputExamen.tipoResultado = _tipoResultado

        Return True
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(tipoResultadoSeleccionado, nuevoInputExamen, estadoFormHijoKitEquipoGuardado)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try
            Dim tipo As Short = tipoResultadoSeleccionado.getCorrelativo()

            If tipo = 1 Then Return cargarObjetosResultadoTipoComun()
            If tipo = 2 Then Return cargarObjetosResultadoTipoOpcionSeleccion()
            If tipo = 3 Then Return cargarObjetosResultadoTipoTextual()
            Return False

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function cargarObjetosResultadoTipoComun()
        Dim nombreExamen As String = nuevoInputExamen.nombre

        nuevoExamen = New ExamenLaboratorio()
        nuevoExamen.setArea(areaSeleccionada)
        nuevoExamen.setSubarea(subareaSeleccionada)
        nuevoExamen.setNombre(nombreExamen)
        nuevoExamen.setTipoResultado(tipoResultadoSeleccionado)
        nuevoExamen.setUnidad(unidadSeleccionada)

        Return True
    End Function

    Private Function cargarObjetosResultadoTipoOpcionSeleccion()
        Dim nombreExamen As String = nuevoInputExamen.nombre

        nuevoExamen = New ExamenLaboratorio()
        nuevoExamen.setArea(areaSeleccionada)
        nuevoExamen.setSubarea(subareaSeleccionada)
        nuevoExamen.setNombre(nombreExamen)
        nuevoExamen.setTipoResultado(tipoResultadoSeleccionado)
        nuevoExamen.setConjuntoOpcionesResultado(conjuntoSeleccionado)

        Return True
    End Function

    Private Function cargarObjetosResultadoTipoTextual()
        Dim nombreExamen As String = nuevoInputExamen.nombre

        nuevoExamen = New ExamenLaboratorio()
        nuevoExamen.setArea(areaSeleccionada)
        nuevoExamen.setSubarea(subareaSeleccionada)
        nuevoExamen.setNombre(nombreExamen)
        nuevoExamen.setTipoResultado(tipoResultadoSeleccionado)

        Return True
    End Function

    Private Sub enviarDatosDatabase()
        Dim registroKitEquipo As RegistroKitEquipoLaboratorio = formKitEquipo.registro
        Dim registroReferencias As RegistroReferenciaResultadoLaboratorio = formKitEquipo.formReferecias.registro

        registro.insertExamen(tipoResultadoSeleccionado, nuevoExamen, nuevoKitEquipo, nuevasReferencias, registroKitEquipo, registroReferencias)

        Dim mensajeInsercion As String = registro.generarMensajeInsercion()
        mostrarMensaje(mensajeInsercion)
        If registro.estadoInsercion > 0 Then reiniciarFormulario()
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub










    'METODOS INTERFAZ G1
    Private Sub poblarCboxArea()
        cboxArea.Items.Clear()

        For Each area As AreaLaboratorio In registro.areas
            cboxArea.Items.Add(area.getNombre())
        Next
    End Sub

    Private Sub poblarCboxSubarea()
        cboxSubarea.Items.Clear()

        For Each subarea As SubareaLaboratorio In registro.subareas
            cboxSubarea.Items.Add(subarea.getNombre())
        Next
    End Sub

    Private Sub ocultarHintArea()
        hintArea.Visible = False
    End Sub

    Private Sub mostrarHintArea()
        hintArea.Visible = True
    End Sub

    Private Sub ocultarHintSubarea()
        hintSubarea.Visible = False
    End Sub

    Private Sub mostrarHintSubarea()
        hintSubarea.Visible = True
    End Sub

    Private Sub poblarCboxTipoResultado()
        cboxTipoResultado.Items.Clear()

        For Each tipo As Concepto In registro.tiposResultado
            cboxTipoResultado.Items.Add(tipo.getDescripcion())
        Next
    End Sub

    Private Sub mostrarHintTipoResultado()
        hintTipoResultado.Visible = True
    End Sub

    Private Sub ocultarHintTipoResultado()
        hintTipoResultado.Visible = False
    End Sub





    'METODOS INTERFAZ G2 -- RESULTADO FORMATO 1
    Private Sub mostrarPanelDatosUnidadMedida()
        panelDatosUnidad.Visible = True
    End Sub

    Private Sub ocultarPanelDatosUnidadMedida()
        panelDatosUnidad.Visible = False
    End Sub


    'METODOS INTERFAZ G2
    Private Sub poblarCboxUnidadMedida()
        cboxUnidadMedida.Items.Clear()

        For Each unidad As UnidadMedidaLaboratorio In registro.unidadesMedida
            cboxUnidadMedida.Items.Add(unidad.getAbreviacion() + " | " + unidad.getNombre())
        Next
    End Sub

    Private Sub mostrarHintUnidadMedida()
        hintUnidadMedida.Visible = True
    End Sub

    Private Sub ocultarHintUnidadMedida()
        hintUnidadMedida.Visible = False
    End Sub



    'METODOS INTERFAZ G3
    Private Sub ajustarPanelResultado()
        Dim tipo As Short = tipoResultadoSeleccionado.getCorrelativo()

        If tipo = 1 Then
            mostrarPanelDatosUnidadMedida()
            mostrarPanelResultadoTipoComun()

            ocultarPanelResultadoTipoOpcionSeleccion()

        ElseIf tipo = 2 Then
            mostrarPanelResutadoTipoOpcionSeleccion()

            ocultarPanelDatosUnidadMedida()
            ocultarPanelResultadoTipoComun()

        ElseIf tipo = 3 Then
            ocultarPanelResultadoTipoComun()
            ocultarPanelDatosUnidadMedida()
            ocultarPanelResultadoTipoOpcionSeleccion()
        End If
    End Sub


    'METODOS INTERFAZ G3a
    Private Sub mostrarPanelResultadoTipoComun()
        panelResultado1.Visible = True
    End Sub

    Private Sub ocultarPanelResultadoTipoComun()
        panelResultado1.Visible = False
    End Sub

    Private Sub mostrarDatosKitEquipoAsignado()
        Dim kitEquipo As KitEquipoLaboratorio, nombreKitEquipo As String, nombreTipoReferencia As String


        kitEquipo = formKitEquipo.nuevoKitEquipo
        nombreKitEquipo = kitEquipo.getNombre()
        nombreTipoReferencia = kitEquipo.getTipoReferencia().getDescripcion()


        txtKitEquipo.Text = nombreKitEquipo
        txtTipoReferencia.Text = nombreTipoReferencia
    End Sub

    Private Sub ajustarChKitEquipoAsignados()
        If estadoFormHijoKitEquipoGuardado Then
            chKitEquipoAsignado.Checked = True
        Else
            chKitEquipoAsignado.Checked = False
        End If
    End Sub

    'METODOS INTERFAZ G3b
    Private Sub mostrarPanelResutadoTipoOpcionSeleccion()
        panelResultado2.Visible = True
    End Sub

    Private Sub ocultarPanelResultadoTipoOpcionSeleccion()
        panelResultado2.Visible = False
    End Sub

    Private Sub mostarHintConjunto()
        hintConjunto.Visible = True
    End Sub

    Private Sub ocultarHintConjunto()
        hintConjunto.Visible = False
    End Sub

    Private Sub poblarCboxConjunto()
        cboxConjunto.Items.Clear()

        For Each conjunto As ConjuntoOpcionesResultadosLaboratorio In registro.conjuntosOpciones
            cboxConjunto.Items.Add(conjunto.getNombre())
        Next
    End Sub

    Private Sub poblarDgvOpciones()
        dgvOpciones.Rows.Clear()

        For Each opcion As OpcionResultadoLaboratorio In registro.opciones
            Dim index As Short = dgvOpciones.Rows.Add()
            Dim rowActual As DataGridViewRow = dgvOpciones.Rows(index)
            rowActual.Cells(clmValorDgvOpciones).Value = opcion.getValor()
        Next
    End Sub



    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub






    'EVENTOS G0
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim formMenu As FormMenuLaboratorio

        formMenu = New FormMenuLaboratorio()
        formMenu.Show()
        Me.Close()
    End Sub


    'EVENTOS G1
    Private Sub cboxArea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxArea.SelectionChangeCommitted
        Try
            seleccionarArea()
            ocultarHintArea()

            traerSubareas()
            poblarCboxSubarea()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarNuevaArea_Click(sender As Object, e As EventArgs) Handles btnRegistrarArea.Click
        Try
            Dim formArea As FormRegistrarAreaLaboratorio

            formArea = New FormRegistrarAreaLaboratorio(True)
            formArea.ShowDialog()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxSubarea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxSubarea.SelectionChangeCommitted
        Try
            seleccionarSubarea()
            ocultarHintSubarea()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarNuevaSubarea_Click(sender As Object, e As EventArgs) Handles btnRegistrarSubarea.Click
        Try
            Dim formSubarea As FormRegistrarSubareaLaboratorio

            formSubarea = New FormRegistrarSubareaLaboratorio(True)
            formSubarea.ShowDialog()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxTipoResultado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTipoResultado.SelectionChangeCommitted
        Try
            seleccionarTipoResultado()
            ocultarHintTipoResultado()
            ajustarPanelResultado()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G2
    Private Sub btnBuscarUnidad_Click(sender As Object, e As EventArgs) Handles btnBuscarUnidad.Click
        Try
            traerUnidadesMedida()
            poblarCboxUnidadMedida()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxUnidadMedida_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxUnidadMedida.SelectionChangeCommitted
        Try
            seleccionarUnidadMedida()
            ocultarHintUnidadMedida()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarUnidadMedida_Click(sender As Object, e As EventArgs) Handles btnRegistrarUnidadMedida.Click
        Dim form As New FormRegistrarUnidadMedidaLaboratorio()
        form.ShowDialog()
    End Sub


    'EVENTOS G3a
    Private Sub btnRegistrarKitEquipo_Click(sender As Object, e As EventArgs) Handles btnRegistrarKitEquipo.Click
        abrirFormularioKitEqiupo()
        mostrarDatosKitEquipoAsignado()
        ajustarChKitEquipoAsignados()
    End Sub



    'EVENTOS G3b
    Private Sub btnBuscarConjunto_Click(sender As Object, e As EventArgs) Handles btnBuscarConjunto.Click
        Try
            traerConjuntosOpciones()
            poblarCboxConjunto()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxConjunto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxConjunto.SelectionChangeCommitted
        Try
            seleccionarConjunto()
            ocultarHintConjunto()
            traerOpciones()
            poblarDgvOpciones()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarConjunto_Click(sender As Object, e As EventArgs) Handles btnRegistrarConjunto.Click
        Try
            abrirFormRegistrarConjuntoOpciones()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub





    'EVENTOS G9
    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvOpciones_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvOpciones.RowPostPaint
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



End Class


