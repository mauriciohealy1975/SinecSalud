Imports NEGOCIO
Imports System.Globalization

Public Class FormRegistrarResultadosLab

    'ATRIBUTOS LOGICOS
    Public registro As RegistroResultadosLab

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private modoBusquedaSeleccionado As Short
    Private fechaSeleccionada As Date
    Private ordenSeleccionada As OrdenLaboratorio

    'ATRIBUTOS G2 
    Private clmCodDetalle As String
    Private clmNomArea As String
    Private clmNomExamen As String
    Private clmResultado As String
    Private clmTipoRestulado As String
    Private clmAccion As String
    Private resultadoSeleccionado As ResultadoLaboratorio

    'ATRIBUTOS G2 
    Private nuevosResultados As ResultadoLaboratorio()




    'METODOS INICIO -
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

    Private Sub FormRegistrarResultadosLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)
        estadoFormGuardado = False

        If _esHijo Then
        Else
        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarInterfaz()


        mostrarInformacionValidesDiasRegistro()
        generarFechas()
        poblarCboxFechas()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LOGICOS
        registro = New RegistroResultadosLab()

        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'estadoFormGuardado = False

        'ATRIBUTOS G0
        tituloFormulario = "Registrar resultados laboratorio"

        'ATRIBUTOS G1 
        modoBusquedaSeleccionado = 0
        fechaSeleccionada = New Date()
        ordenSeleccionada = New OrdenLaboratorio()

        'ATRIBUTOS G2 
        clmCodDetalle = "clmCodDetalle"
        clmNomArea = "clmArea"
        clmNomExamen = "clmExamen"
        clmResultado = "clmRestulado"
        clmTipoRestulado = "clmTipoResultado"
        clmAccion = "clmAccion"
        resultadoSeleccionado = New ResultadoLaboratorio()

        'ATRIBUTOS G9
        nuevosResultados = New ResultadoLaboratorio(-1) {}
    End Sub

    Private Sub iniciarProcesosNegocio()
        registro.iniciarProcesos()
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
        lblTituloPrincipal.Text = tituloFormulario.ToUpper
    End Sub

    Private Sub iniciarInterfazGrupo1()
        panelBuscarOrden.Enabled = True
        panelBuscarOrden.Visible = True


        rbuttonNroOrden.Enabled = True
        rbuttonNroOrden.Visible = True
        rbuttonNroOrden.Checked = False
        rbuttonNroOrden.Font = New Font("Microsoft Sans Serif", 9)

        rbuttonNombre.Enabled = True
        rbuttonNombre.Visible = True
        rbuttonNombre.Checked = False
        rbuttonNombre.Font = New Font("Microsoft Sans Serif", 9)

        rbuttonFecha.Enabled = True
        rbuttonFecha.Visible = True
        rbuttonFecha.Checked = False
        rbuttonFecha.Font = New Font("Microsoft Sans Serif", 9)






        gboxNroOrden.Enabled = True
        gboxNroOrden.Visible = False

        txtBuscarPorNroOrden.Enabled = True
        txtBuscarPorNroOrden.Visible = True
        txtBuscarPorNroOrden.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarPorNroOrden.Text = ""
        txtBuscarPorNroOrden.CharacterCasing = CharacterCasing.Upper

        btnBuscarPorNroOrden.Enabled = True
        btnBuscarPorNroOrden.Visible = True
        btnBuscarPorNroOrden.Font = New Font("Microsoft Sans Serif", 9)
        'btnBuscarPorNroOrden.Text = "Traer ordenes"

        cboxOrdenNroOrden.Enabled = True
        cboxOrdenNroOrden.Visible = True
        cboxOrdenNroOrden.Font = New Font("Microsoft Sans Serif", 8)
        cboxOrdenNroOrden.Items.Clear()
        cboxOrdenNroOrden.DropDownStyle = ComboBoxStyle.DropDownList

        hintOrdenNroOrden.Enabled = True
        hintOrdenNroOrden.Visible = True
        hintOrdenNroOrden.BackColor = Color.Transparent
        hintOrdenNroOrden.Font = New Font("Microsoft Sans Serif", 8)
        hintOrdenNroOrden.Text = "SELECCIONAR"






        gboxNombre.Enabled = True
        gboxNombre.Visible = False

        txtBuscarPorNombre.Enabled = True
        txtBuscarPorNombre.Visible = True
        txtBuscarPorNombre.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarPorNombre.Text = ""
        txtBuscarPorNombre.CharacterCasing = CharacterCasing.Upper

        btnBuscarPorNombre.Enabled = True
        btnBuscarPorNombre.Visible = True
        btnBuscarPorNombre.Font = New Font("Microsoft Sans Serif", 9)
        'btnBuscarPorNombre.Text = "Traer ordenes"

        cboxOrdenNombre.Enabled = True
        cboxOrdenNombre.Visible = True
        cboxOrdenNombre.Font = New Font("Microsoft Sans Serif", 8)
        cboxOrdenNombre.Items.Clear()
        cboxOrdenNombre.DropDownStyle = ComboBoxStyle.DropDownList

        hintOrdenNombre.Enabled = True
        hintOrdenNombre.Visible = True
        hintOrdenNombre.BackColor = Color.Transparent
        hintOrdenNombre.Font = New Font("Microsoft Sans Serif", 8)
        hintOrdenNombre.Text = "SELECCIONAR"






        gboxFecha.Enabled = True
        gboxFecha.Visible = False

        cboxFecha.Enabled = True
        cboxFecha.Visible = True
        cboxFecha.Font = New Font("Microsoft Sans Serif", 9)
        cboxFecha.Items.Clear()
        cboxFecha.DropDownStyle = ComboBoxStyle.DropDownList

        hintFecha.Enabled = True
        hintFecha.Visible = True
        hintFecha.BackColor = Color.Transparent
        hintFecha.Font = New Font("Microsoft Sans Serif", 8)
        hintFecha.Text = "SELECCIONAR"

        cboxOrdenFecha.Enabled = True
        cboxOrdenFecha.Visible = True
        cboxOrdenFecha.Font = New Font("Microsoft Sans Serif", 9)
        cboxOrdenFecha.Items.Clear()
        cboxOrdenFecha.DropDownStyle = ComboBoxStyle.DropDownList

        hintOrdenFecha.Enabled = True
        hintOrdenFecha.Visible = True
        hintOrdenFecha.BackColor = Color.Transparent
        hintOrdenFecha.Font = New Font("Microsoft Sans Serif", 8)
        hintOrdenFecha.Text = "SELECCIONAR"
    End Sub

    Private Sub iniciarInterfazGrupo2()
        panelResultados.Enabled = True
        panelResultados.Visible = True

        iniciarDgvResultados()
        deshabilitarDgvDetalles()
    End Sub

    Public Sub iniciarDgvResultados()
        'propiedades encabezados columnas (labels)

        'propiedades base
        dgvResultados.Enabled = True
        dgvResultados.Font = New Font("Microsoft Sans Serif", 9)

        'propiedades permisos editar
        dgvResultados.EditMode = DataGridViewEditMode.EditOnEnter
        dgvResultados.AllowUserToAddRows = False
        dgvResultados.AllowUserToDeleteRows = False
        dgvResultados.AllowUserToResizeRows = False
        dgvResultados.AllowUserToOrderColumns = False
        dgvResultados.AllowUserToResizeColumns = False
        dgvResultados.MultiSelect = False
        dgvResultados.ReadOnly = True


        'propiedades estilos selección
        dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        'propiedades estilos color encabezados columnas
        dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black


        'propiedades estilos color seleccion encabezados filas
        dgvResultados.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvResultados.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)


        'propiedaes estilos color celdas
        dgvResultados.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvResultados.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvResultados.DefaultCellStyle.ForeColor = Color.Black


        'propiedaes estilos color celdas seleccionadas
        dgvResultados.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 120, 255)
        dgvResultados.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)



        'propiedades otras celdas
        dgvResultados.ScrollBars = ScrollBars.Both
        dgvResultados.EnableHeadersVisualStyles = False


        'columnas -- agregar columnas
        dgvResultados.Columns.Clear()

        dgvResultados.Columns.Add(clmCodDetalle, "CODIGO DETALLE")
        dgvResultados.Columns(clmCodDetalle).Visible = False

        dgvResultados.Columns.Add(clmNomArea, "AREA")
        dgvResultados.Columns(clmNomArea).Visible = True

        dgvResultados.Columns.Add(clmNomExamen, "EXAMEN")
        dgvResultados.Columns(clmNomExamen).Visible = True

        dgvResultados.Columns.Add(clmResultado, "RESULTADO")
        dgvResultados.Columns(clmResultado).Visible = True

        dgvResultados.Columns.Add(clmTipoRestulado, "TIPO DE RESULTADO")
        dgvResultados.Columns(clmTipoRestulado).Visible = False

        Dim clmButtonAccion As New DataGridViewButtonColumn()
        clmButtonAccion.Name = clmAccion
        clmButtonAccion.HeaderText = ""
        clmButtonAccion.Text = "INGRESAR RESULTADO"
        clmButtonAccion.UseColumnTextForButtonValue = True
        dgvResultados.Columns.Add(clmButtonAccion)
        dgvResultados.Columns(clmAccion).Visible = True


        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvResultados.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'alinear contenido columnas
        For Each columna As DataGridViewColumn In dgvResultados.Columns
            If columna.Name = clmResultado Then
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Else
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End If
        Next

        'configurar ancho columnas
        dgvResultados.Columns(clmNomArea).FillWeight = 23
        dgvResultados.Columns(clmNomExamen).FillWeight = 35
        dgvResultados.Columns(clmResultado).FillWeight = 22
        dgvResultados.Columns(clmAccion).FillWeight = 20

        'filas
        dgvResultados.Rows.Clear()
    End Sub

    Private Sub establecerDisplay()
        'Dim ejeX As Short, ejeY As Short

        'ejeX = Utilitarios.resolucionEstandarEjeX
        'ejeY = Utilitarios.resolucionEstandarEjeY

        'Dim size As New Size(ejeX, ejeY)

        'Me.Size = size
        'MinimumSize = size
        'MaximumSize = size

        Me.CenterToScreen()
    End Sub

    'MÉTODOS LOGICOS G1 --
    Private Sub seleccionarModoBusqueda()
        If rbuttonNroOrden.Checked Then modoBusquedaSeleccionado = 1
        If rbuttonNombre.Checked Then modoBusquedaSeleccionado = 2
        If rbuttonFecha.Checked Then modoBusquedaSeleccionado = 3
    End Sub

    Public Sub ajustarHabilitacionFormulario()
        Dim usuarioValido As Boolean = registro.tipoUsuarioValido

        If Not usuarioValido Then mostrarMensaje("Error. Usted no es un usuario valido para ingresar resultados de laboratorio")
    End Sub

    Public Sub controlarTipoUsuarioValido()
        registro.controlaerTipoUsuarioValido()
    End Sub

    Private Sub generarFechas()
        registro.generarFechas()
    End Sub

    Private Sub seleccionarFecha()
        Dim index As Short = cboxFecha.SelectedIndex
        fechaSeleccionada = registro.fechasValidas(index)
    End Sub

    Private Sub traerOrdenes()
        If modoBusquedaSeleccionado = 1 Then traerOrdenesPorNroOrden()
        If modoBusquedaSeleccionado = 2 Then traerOrdenesPorNombre()
        If modoBusquedaSeleccionado = 3 Then traerOrdenesPorFecha()
    End Sub

    Private Sub traerOrdenesPorNroOrden()
        Dim codigoOrden As String = txtBuscarPorNroOrden.Text.Trim()
        registro.traerOrdenesPorNroOrden(codigoOrden)
    End Sub

    Private Sub traerOrdenesPorNombre()
        Dim nombreCompleto As String = txtBuscarPorNombre.Text.Trim()
        registro.traerOrdenesPorNombre(nombreCompleto)
    End Sub

    Private Sub traerOrdenesPorFecha()
        registro.traerOrdenesPorFechas(fechaSeleccionada)
    End Sub

    Private Sub seleccionarOrden()
        If modoBusquedaSeleccionado = 1 Then
            Dim indexCboxOrdenNroOrden As Short = cboxOrdenNroOrden.SelectedIndex
            ordenSeleccionada = registro.ordenes(indexCboxOrdenNroOrden)

        ElseIf modoBusquedaSeleccionado = 2 Then
            Dim indexCboxOrdenNombre As Short = cboxOrdenNombre.SelectedIndex
            ordenSeleccionada = registro.ordenes(indexCboxOrdenNombre)

        ElseIf modoBusquedaSeleccionado = 3 Then
            Dim inddexCboxOrdenFecha As Short = cboxOrdenFecha.SelectedIndex
            ordenSeleccionada = registro.ordenes(inddexCboxOrdenFecha)
        End If
    End Sub

    Private Sub traerDetalles()
        registro.traerDetalles(ordenSeleccionada)
    End Sub

    Private Sub generarListaResultados()
        registro.generarListaResultados(nuevosResultados)
    End Sub

    Private Sub reiniciarLogicoOrdenSeleccionada()
        ordenSeleccionada = New OrdenLaboratorio()
    End Sub


    'MÉTODOS LOGICOS G2 
    Private Sub seleccionarResultado()
        Dim index As Short = 0

        For Each cell As DataGridViewCell In dgvResultados.SelectedCells
            index = cell.RowIndex
        Next

        resultadoSeleccionado = nuevosResultados(index)
    End Sub

    Private Sub abrirModalResultados()
        Dim tipoRestulado As Short = resultadoSeleccionado.getExamen().getTipoResultado().getCorrelativo()

        If tipoRestulado = 1 Then abrirFormRegistrarResultadoTipoComun()
        If tipoRestulado = 2 Then abrirFormRegistrarResultadoTipoOpcion()
        If tipoRestulado = 3 Then abrirFormRegistrarResultadoTipoTextual()
    End Sub

    Private Sub abrirFormRegistrarResultadoTipoComun()
        Dim asegurado As Asegurado, modoTipoUsuario As Short, formulario As FormRegistrarResultadoLabTipoValorComun

        asegurado = ordenSeleccionada.getAsegurado()
        modoTipoUsuario = registro.codigoTipoUsuario
        formulario = New FormRegistrarResultadoLabTipoValorComun(resultadoSeleccionado, asegurado, modoTipoUsuario)
        formulario.ShowDialog()
    End Sub

    Private Sub abrirFormRegistrarResultadoTipoOpcion()
        Dim formulario As FormRegistrarResultadoLabTipoValorOpcionSeleccion, modoTipoUsuario As Short

        modoTipoUsuario = registro.codigoTipoUsuario
        formulario = New FormRegistrarResultadoLabTipoValorOpcionSeleccion(resultadoSeleccionado, modoTipoUsuario)
        formulario.ShowDialog()
    End Sub

    Private Sub abrirFormRegistrarResultadoTipoTextual()
        Dim formulario As FormRegistrarResultadoLabTipoValorTextual, modoTipoUsuario As Short

        modoTipoUsuario = registro.codigoTipoUsuario
        formulario = New FormRegistrarResultadoLabTipoValorTextual(resultadoSeleccionado, modoTipoUsuario)
        formulario.ShowDialog()
    End Sub






    'MÉTODOS LOGICOS G9
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean = cargarEntradas()

        If entradasCargadas Then
            Dim mensajeValidacion As String = validarEntradas()

            If mensajeValidacion = "" Then
                Dim objetosCargados As Boolean = cargarObjetos()

                If objetosCargados Then
                    enviarDatosDatabase()
                End If
            Else
                mostrarMensaje(mensajeValidacion)
            End If
        End If
    End Sub

    Private Function cargarEntradas() As Boolean
        Try
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(nuevosResultados)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub enviarDatosDatabase()
        Dim mensajeInsercion As String, estadoInsercion As Short

        registro.insertarResultados(nuevosResultados)

        mensajeInsercion = registro.generarMensajeInsercion()
        estadoInsercion = registro.estadoInsercion

        If Not mensajeInsercion = "" Then
            mostrarMensaje(mensajeInsercion)

            If estadoInsercion > 0 Then reiniciarFormulario()
        End If
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub






    'METODOS INTERFAZ G1 --
    Private Sub mostrarInformacionValidesDiasRegistro()
        Dim parametro As Parametro = registro.parametroNroDiasValidos
        lblMensajeRestriccion.Text = "La busqueda de ordenes sólo aplica para ordenes ingresadas en los últimos " + parametro.getValor().ToString() + " días."
    End Sub

    Private Sub ajustarGboxBusqueda()
        If modoBusquedaSeleccionado = 1 Then
            'MOSTRAR
            gboxNroOrden.Visible = True

            'OCULTAR
            gboxNombre.Visible = False
            gboxFecha.Visible = False


        ElseIf modoBusquedaSeleccionado = 2 Then
            'MOSTRAR
            gboxNombre.Visible = True

            'OCULTAR
            gboxNroOrden.Visible = False
            gboxFecha.Visible = False


        ElseIf modoBusquedaSeleccionado = 3 Then
            'MOSTRAR
            gboxFecha.Visible = True

            'OCULTAR
            gboxNroOrden.Visible = False
            gboxNombre.Visible = False
        End If
    End Sub

    Private Sub poblarCboxOrdenes()
        If modoBusquedaSeleccionado = 1 Then poblarCboxOrdenNroOrden()
        If modoBusquedaSeleccionado = 2 Then poblarCboxOrdenNombre()
        If modoBusquedaSeleccionado = 3 Then poblarCboxOrdenFecha()
    End Sub

    Private Sub poblarCboxOrdenNroOrden()
        cboxOrdenNroOrden.Items.Clear()

        For Each orden As OrdenLaboratorio In registro.ordenes
            Dim apPaterno As String, apMaterno As String, nombres As String,
                nombreCompleto As String, codigo As String, matricula As String

            apPaterno = orden.getAsegurado().getApellidoPaterno()
            apMaterno = orden.getAsegurado().getApellidoMaterno()
            nombres = orden.getAsegurado.getNombres()

            nombreCompleto = apPaterno + " " + apMaterno + " " + nombres
            nombreCompleto = nombreCompleto.Trim()

            codigo = orden.getCodigo().ToString()
            matricula = orden.getAsegurado().getMatricula()

            cboxOrdenNroOrden.Items.Add("NRO: " + codigo + " | " + nombreCompleto + " | " + matricula)
        Next
    End Sub

    Private Sub poblarCboxOrdenNombre()
        cboxOrdenNombre.Items.Clear()

        For Each orden As OrdenLaboratorio In registro.ordenes
            Dim apPaterno As String, apMaterno As String, nombres As String,
                nombreCompleto As String, codigo As String, matricula As String

            apPaterno = orden.getAsegurado().getApellidoPaterno()
            apMaterno = orden.getAsegurado().getApellidoMaterno()
            nombres = orden.getAsegurado.getNombres()

            nombreCompleto = apPaterno + " " + apMaterno + " " + nombres
            nombreCompleto = nombreCompleto.Trim()

            codigo = orden.getCodigo().ToString()
            matricula = orden.getAsegurado().getMatricula()

            cboxOrdenNombre.Items.Add("NRO: " + codigo + " | " + nombreCompleto + " | " + matricula)
        Next
    End Sub

    Private Sub poblarCboxOrdenFecha()
        cboxOrdenFecha.Items.Clear()

        For Each orden As OrdenLaboratorio In registro.ordenes
            Dim apPaterno As String, apMaterno As String, nombres As String,
                nombreCompleto As String, codigo As String, matricula As String

            apPaterno = orden.getAsegurado().getApellidoPaterno()
            apMaterno = orden.getAsegurado().getApellidoMaterno()
            nombres = orden.getAsegurado.getNombres()

            nombreCompleto = apPaterno + " " + apMaterno + " " + nombres
            nombreCompleto = nombreCompleto.Trim()

            codigo = orden.getCodigo().ToString()
            matricula = orden.getAsegurado().getMatricula()

            cboxOrdenFecha.Items.Add("NRO: " + codigo + " | " + nombreCompleto + " | " + matricula)
        Next
    End Sub

    Private Sub poblarCboxFechas()
        cboxFecha.Items.Clear()

        For Each fecha As Date In registro.fechasValidas
            cboxFecha.Items.Add(fecha.ToString("dd / MM / yyyy", CultureInfo.InvariantCulture))
        Next
    End Sub

    Private Sub mostrarHintFecha()
        hintFecha.Visible = True
    End Sub

    Private Sub ocultarHintFecha()
        hintFecha.Visible = False
    End Sub


    Private Sub reiniciarInterfazLogicoGboxBusqueda()
        reiniciarInterfazLogicoGboxNroOrden()
        reiniciarInterfazLogicoGboxNombre()
        reiniciarInterfazLogicoGboxFecha()
    End Sub

    Private Sub reiniciarInterfazLogicoGboxNroOrden()
        txtBuscarPorNroOrden.Text = ""
        cboxOrdenNroOrden.Items.Clear()
        hintOrdenNroOrden.Visible = True

        ordenSeleccionada = New OrdenLaboratorio()
    End Sub

    Private Sub reiniciarInterfazLogicoGboxNombre()
        txtBuscarPorNombre.Text = ""
        cboxOrdenNombre.Items.Clear()
        hintOrdenNombre.Visible = True

        ordenSeleccionada = New OrdenLaboratorio()
    End Sub

    Private Sub reiniciarInterfazLogicoGboxFecha()
        cboxFecha.Items.Clear()
        hintFecha.Visible = True

        cboxOrdenFecha.Items.Clear()
        hintOrdenFecha.Visible = True

        ordenSeleccionada = New OrdenLaboratorio()
    End Sub





    Private Sub mostrarHintOrdenNroOrden()
        hintOrdenNroOrden.Visible = True
    End Sub

    Private Sub ocultarHintOrdenNroOrden()
        hintOrdenNroOrden.Visible = False
    End Sub

    Private Sub mostrarHintOrdenNombre()
        hintOrdenNombre.Visible = True
    End Sub

    Private Sub ocultarHintOrdenNombre()
        hintOrdenNombre.Visible = False
    End Sub

    Private Sub mostarHintOrdenFecha()
        hintOrdenFecha.Visible = True
    End Sub

    Private Sub ocultarHintOrdenFecha()
        hintOrdenFecha.Visible = False
    End Sub



    'METODOS INTERFAZ G2
    Private Sub poblarDgvResultados()
        Dim nroResultados As Short

        dgvResultados.Rows.Clear()
        nroResultados = nuevosResultados.Count()

        If nroResultados > 0 Then
            For Each resultado As ResultadoLaboratorio In nuevosResultados
                Dim codigo As String, nombreArea As String, nombreExamen As String, tipoResultado As Short, asignado As Boolean,
                    descripcionResultado As String

                Dim rowIndex As Int16 = dgvResultados.Rows.Add()
                Dim rowAux As DataGridViewRow = dgvResultados.Rows(rowIndex)


                codigo = resultado.getDetalle.getCodigo()
                nombreArea = resultado.getExamen().getArea().getNombre()
                nombreExamen = resultado.getExamen().getNombre()
                tipoResultado = resultado.getTipoResultado().getCorrelativo()
                asignado = resultado.getAsignado()


                rowAux.Cells(clmCodDetalle).Value = codigo
                rowAux.Cells(clmNomArea).Value = nombreArea
                rowAux.Cells(clmNomExamen).Value = nombreExamen
                rowAux.Cells(clmTipoRestulado).Value = tipoResultado

                If asignado Then
                    If tipoResultado = 1 Then descripcionResultado = resultado.getValorTipoComun().ToString()
                    If tipoResultado = 2 Then descripcionResultado = resultado.getValorTipoOpcion().getValor().ToString()
                    If tipoResultado = 3 Then descripcionResultado = resultado.getValorTipoTextual().ToString()

                    rowAux.Cells(clmResultado).Value = descripcionResultado
                Else
                    descripcionResultado = "RESULTADOS PENDIENTES"
                    rowAux.Cells(clmResultado).Value = descripcionResultado
                End If
            Next

        Else
            mostrarNoHayPendientes()

        End If
    End Sub

    Private Sub mostrarNoHayPendientes()
        Dim modoTipoUsuario As Short
        modoTipoUsuario = registro.codigoTipoUsuario

        If modoTipoUsuario = 3 Then mostrarMensaje("Esta orden no tiene resultados pendientes de sus areas.")
        If modoTipoUsuario = 4 Then mostrarMensaje("Esta orden no tiene resultados pendientes.")
    End Sub

    Private Sub habilitarDgvResultados()
        dgvResultados.Enabled = True

        dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvResultados.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvResultados.DefaultCellStyle.ForeColor = Color.Black
        dgvResultados.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvResultados.EnableHeadersVisualStyles = False
    End Sub

    Private Sub deshabilitarDgvDetalles()
        dgvResultados.Enabled = False

        dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
        dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText
        dgvResultados.DefaultCellStyle.BackColor = SystemColors.Control
        dgvResultados.DefaultCellStyle.ForeColor = SystemColors.GrayText
        dgvResultados.BackgroundColor = SystemColors.Control
        dgvResultados.CurrentCell = Nothing
        dgvResultados.EnableHeadersVisualStyles = False
    End Sub

    Private Sub reiniciarDgvResultados()
        dgvResultados.Rows.Clear()
    End Sub

    Private Sub deseleccionarDgv()
        dgvResultados.ClearSelection()
    End Sub




    'METODOS INTERFAZ G3
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub








    'EVENTOS G0 -
    Private Sub tsmItemMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles tsmItemMenuLaboratorio.Click
        FormMenuLaboratorio.Show()
        Me.Close()
    End Sub


    'EVENTOS G1
    Private Sub rbuttonNroOrden_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonNroOrden.CheckedChanged
        Try
            If rbuttonNroOrden.Checked Then
                seleccionarModoBusqueda()
                ajustarGboxBusqueda()
                reiniciarInterfazLogicoGboxBusqueda()
                reiniciarDgvResultados()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub rbuttonNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonNombre.CheckedChanged
        Try
            If rbuttonNombre.Checked Then
                seleccionarModoBusqueda()
                ajustarGboxBusqueda()
                reiniciarInterfazLogicoGboxBusqueda()
                reiniciarDgvResultados()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub rbuttonFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonFecha.CheckedChanged
        Try
            If rbuttonFecha.Checked Then
                seleccionarModoBusqueda()
                ajustarGboxBusqueda()
                reiniciarInterfazLogicoGboxBusqueda()
                reiniciarDgvResultados()

                generarFechas()
                poblarCboxFechas()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    Private Sub btnBuscarPorNroOrden_Click(sender As Object, e As EventArgs) Handles btnBuscarPorNroOrden.Click
        Try
            Dim input As String = txtBuscarPorNroOrden.Text, entero As Boolean = Integer.TryParse(input, 1)

            If entero Then
                traerOrdenes()
                poblarCboxOrdenes()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxOrdenBuscarPorNroOrden_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxOrdenNroOrden.SelectionChangeCommitted
        Try
            seleccionarOrden()
            ocultarHintOrdenNroOrden()

            traerDetalles()
            generarListaResultados()
            poblarDgvResultados()

            habilitarDgvResultados()
            deseleccionarDgv()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    Private Sub btnBuscarPorNombre_Click(sender As Object, e As EventArgs) Handles btnBuscarPorNombre.Click
        Try
            Dim input As String = txtBuscarPorNombre.Text
            If input = "" Then Return

            traerOrdenes()
            poblarCboxOrdenes()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxOrdenNombre_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxOrdenNombre.SelectionChangeCommitted
        Try
            seleccionarOrden()
            ocultarHintOrdenNombre()

            traerDetalles()
            generarListaResultados()
            poblarDgvResultados()

            habilitarDgvResultados()
            deseleccionarDgv()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    Private Sub cboxFechas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxFecha.SelectionChangeCommitted
        Try
            seleccionarFecha()
            ocultarHintFecha()

            traerOrdenes()
            poblarCboxOrdenes()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxOrdenFecha_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxOrdenFecha.SelectionChangeCommitted
        Try
            seleccionarOrden()
            ocultarHintOrdenFecha()

            traerDetalles()
            generarListaResultados()
            poblarDgvResultados()

            habilitarDgvResultados()
            deseleccionarDgv()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub









    'EVENTOS G2
    Private Sub dgvResultados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultados.CellClick
        Try
            Dim clmAccionIndex As Short

            clmAccionIndex = dgvResultados.Columns(clmAccion).Index

            If e.RowIndex < 0 Then Return

            If e.ColumnIndex = clmAccionIndex Then
                seleccionarResultado()
                abrirModalResultados()
                poblarDgvResultados()
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvResultados_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvResultados.RowPostPaint
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


    'EVENTOS G9
    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



End Class

