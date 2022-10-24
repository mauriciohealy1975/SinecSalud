Imports NEGOCIO

Public Class FormRegistrarResultadoLabTipoValorComun

    'ATRIBUTOS -- ATRIBUTOS LÓGICOS
    Private registro As RegistroResultadosEnValoresReferencia

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean
    Private esFormHijo As Boolean
    Private modoTipoUsuario As Short

    'ATRIBUTOS PARAMETOS RECIBIDOS
    Private resultadoFormPadre As ResultadoLaboratorio
    Private aseguradoFormPadre As Asegurado

    'ATRIBUTOS G0
    Private tituloDeFormulario As String

    'ATRIBUTOS G3
    Private proveedorSeleccionado As ProveedorKitEquipo
    Private kitequipoSeleccionado As KitEquipoLaboratorio
    Private referenciaAsignada As ReferenciaResultadoLaboratorio
    Private procesadorSeleccionado As Usuario
    Private observacion As Boolean


    Private clmSexoDgvReferencias As String
    Private clmEdadDesdeDgvReferencias As String
    Private clmEdadHastaDgvReferencias As String
    Private clmValorDesdeDgvReferencias As String
    Private clmValorHastaDgvReferencias As String

    'ATRIBUTOS PROPERTIES G9
    Private nuevoInputResultado As ResultadoLaboratorioInput
    Public nuevoResultado As ResultadoLaboratorio








    'METODOS INICIO
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(False, Nothing, Nothing, 0)
        iniciarFormulario()
    End Sub

    Public Sub New(ByRef _resultado As ResultadoLaboratorio, ByRef _asegurado As Asegurado, _modoTipoUsuario As Short)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(True, _resultado, _asegurado, _modoTipoUsuario)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        establecerDisplay()
    End Sub

    Private Sub FormGuardarResultadoVReferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean, ByRef _resultado As ResultadoLaboratorio, ByRef _asegurado As Asegurado,
                                            _modoTipoUsuario As Short)
        estadoFormGuardado = False

        If _esHijo Then
            esFormHijo = True
            resultadoFormPadre = _resultado
            aseguradoFormPadre = _asegurado
            modoTipoUsuario = _modoTipoUsuario
        Else
            esFormHijo = False
            resultadoFormPadre = Nothing
            aseguradoFormPadre = Nothing
            modoTipoUsuario = 0
        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarInterfaz()

        ajustarControlesSegunTipoUsuario()

        mostrarDatosExamen()
        mostrarDatosAsegurado()

        traerProveedores()
        poblarCboxProveedor()

        traerProcesadores()
        poblarCboxProcesador()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroResultadosEnValoresReferencia()

        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'estadoFormGuardado As Boolean
        ' esFormHijo As Boolean

        'ATRIBUTOS PARAMETOS RECIBIDOS
        If IsNothing(resultadoFormPadre) Then resultadoFormPadre = New ResultadoLaboratorio
        If IsNothing(aseguradoFormPadre) Then aseguradoFormPadre = New Asegurado

        'ATRIBUTOS G0
        tituloDeFormulario = "Registrar resultados de tipo valor numérico"

        'ATRIBUTOS G3
        proveedorSeleccionado = New ProveedorKitEquipo()
        kitequipoSeleccionado = New KitEquipoLaboratorio()
        referenciaAsignada = New ReferenciaResultadoLaboratorio()
        procesadorSeleccionado = New Usuario()
        observacion = False

        clmSexoDgvReferencias = "clmSexo"
        clmEdadDesdeDgvReferencias = "clmEdadDesde"
        clmEdadHastaDgvReferencias = "clmEdadHasta"
        clmValorDesdeDgvReferencias = "clmDesde"
        clmValorHastaDgvReferencias = "clmHasta"

        'ATRIBUTOS PROPERTIES G9
        nuevoInputResultado = New ResultadoLaboratorioInput()
        nuevoResultado = New ResultadoLaboratorio()
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarInterfaz()
        iniciarInterfazGrupo0()
        iniciarInterfazGrupo1()
        iniciarInterfazGrupo2()
        iniciarInterfazGrupo3()
    End Sub

    Private Sub iniciarInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloDeFormulario

        lblTituloPrincipal.Text = tituloDeFormulario.ToUpper()
    End Sub

    Private Sub iniciarInterfazGrupo1()
        panelDatosExamen.Enabled = True
        panelDatosExamen.Visible = True

        lblExamen.Enabled = False
        lblExamen.Visible = True

        txtExamen.Enabled = False
        txtExamen.Visible = True
        txtExamen.ReadOnly = True
        txtExamen.Font = New Font("Microsoft Sans Serif", 9)
        txtExamen.Text = ""
        txtExamen.CharacterCasing = CharacterCasing.Upper

        lblArea.Enabled = False
        lblArea.Visible = True

        txtArea.Enabled = False
        txtArea.Visible = True
        txtArea.ReadOnly = True
        txtArea.Font = New Font("Microsoft Sans Serif", 9)
        txtArea.Text = ""
        txtArea.CharacterCasing = CharacterCasing.Upper

        lblUnidad.Enabled = False
        lblUnidad.Visible = True

        txtUnidad.Enabled = False
        txtUnidad.Visible = True
        txtUnidad.ReadOnly = True
        txtUnidad.Font = New Font("Microsoft Sans Serif", 9)
        txtUnidad.Text = ""
        txtUnidad.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarInterfazGrupo2()
        panelDatosAsegurado.Enabled = True
        panelDatosAsegurado.Visible = True

        lblNombreAsegurado.Enabled = False
        lblNombreAsegurado.Visible = True

        txtAsegurado.Enabled = False
        txtAsegurado.Visible = True
        txtAsegurado.ReadOnly = True
        txtAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtAsegurado.Text = ""
        txtAsegurado.CharacterCasing = CharacterCasing.Upper

        lblMatricula.Enabled = False
        lblMatricula.Visible = True

        txtMatricula.Enabled = False
        txtMatricula.Visible = True
        txtMatricula.ReadOnly = True
        txtMatricula.Font = New Font("Microsoft Sans Serif", 9)
        txtMatricula.Text = ""
        txtMatricula.CharacterCasing = CharacterCasing.Upper

        lblSexo.Enabled = False
        lblSexo.Visible = True

        txtSexo.Enabled = False
        txtSexo.Visible = True
        txtSexo.ReadOnly = True
        txtSexo.Font = New Font("Microsoft Sans Serif", 9)
        txtSexo.Text = ""
        txtSexo.CharacterCasing = CharacterCasing.Upper

        lblEdad.Enabled = False
        lblEdad.Visible = True

        txtEdad.Enabled = False
        txtEdad.Visible = True
        txtEdad.ReadOnly = True
        txtEdad.Font = New Font("Microsoft Sans Serif", 9)
        txtEdad.Text = ""
        txtEdad.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarInterfazGrupo3()
        panelDatosResultado.Enabled = True
        panelDatosResultado.Visible = True

        lblHeaderEmpty.Enabled = True
        lblHeaderEmpty.Visible = False
        lblHeaderEmpty.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderEmpty.Text = ""
        lblHeaderEmpty.BackColor = Color.FromArgb(235, 235, 235)
        'lblHeaderEmpty.Location = New Point(0, 0)
        'lblHeaderEmpty.Size = New Size(0, 0)

        lblHeaderEdad.Enabled = True
        lblHeaderEdad.Visible = False
        lblHeaderEdad.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderEdad.Text = "EDAD"
        lblHeaderEdad.BackColor = Color.FromArgb(235, 235, 235)
        'lblHeaderEdad.Location = New Point(0, 0)
        'lblHeaderEdad.Size = New Size(0, 0)

        lblHeaderValorDeReferencia.Enabled = True
        lblHeaderValorDeReferencia.Visible = False
        lblHeaderValorDeReferencia.Font = New Font("Microsoft Sans Serif", 9)
        lblHeaderValorDeReferencia.Text = "VALORES EN "
        lblHeaderValorDeReferencia.BackColor = Color.FromArgb(235, 235, 235)
        'lblHeaderValorDeReferencia.Location = New Point(0, 0)
        'lblHeaderValorDeReferencia.Size = New Size(0, 0)

        iniciarDgvReferencias()

        cboxKit.Enabled = True
        cboxKit.Visible = True
        cboxKit.Font = New Font("Microsoft Sans Serif", 9)
        cboxKit.Items.Clear()
        cboxKit.DropDownStyle = ComboBoxStyle.DropDownList

        hintKit.Enabled = True
        hintKit.Visible = True
        hintKit.Font = New Font("Microsoft Sans Serif", 9)
        hintKit.Text = "SELECCIONAR"
        hintKit.BackColor = Color.Transparent

        numResultado.Enabled = False
        numResultado.Visible = True
        numResultado.ReadOnly = False
        numResultado.Font = New Font("Microsoft Sans Serif", 10)
        numResultado.Text = "0.000"
        numResultado.Maximum = 999.999

        cboxProcesador.Enabled = True
        cboxProcesador.Visible = True
        cboxProcesador.Font = New Font("Microsoft Sans Serif", 9)
        cboxProcesador.Items.Clear()
        cboxProcesador.DropDownStyle = ComboBoxStyle.DropDownList

        hintProcesador.Enabled = True
        hintProcesador.Visible = True
        hintProcesador.Font = New Font("Microsoft Sans Serif", 9)
        hintProcesador.Text = "SELECCIONAR"
        hintProcesador.BackColor = Color.Transparent
    End Sub

    Public Sub iniciarDgvReferencias()
        'propiedades encabezados columnas (labels)
        lblHeaderEmpty.Visible = False
        lblHeaderEmpty.Text = ""

        lblHeaderEdad.Visible = False
        lblHeaderEdad.Text = "EDAD"

        lblHeaderValorDeReferencia.Visible = False
        lblHeaderValorDeReferencia.Text = "VALORES EN"


        'propiedades base
        dgvReferencias.Enabled = True
        dgvReferencias.Font = New Font("Microsoft Sans Serif", 9)


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
        dgvReferencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
        dgvReferencias.Columns(clmSexoDgvReferencias).Visible = True

        dgvReferencias.Columns.Add(clmEdadDesdeDgvReferencias, "DESDE")
        dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = True

        dgvReferencias.Columns.Add(clmEdadHastaDgvReferencias, "HASTA")
        dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = True

        dgvReferencias.Columns.Add(clmValorDesdeDgvReferencias, "DESDE")
        dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True

        dgvReferencias.Columns.Add(clmValorHastaDgvReferencias, "HASTA")
        dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True


        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvReferencias.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        'centrar columnas
        For Each columna As DataGridViewColumn In dgvReferencias.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
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
    End Sub

    Private Sub ajustarControlesSegunTipoUsuario()
        If modoTipoUsuario = 3 Then
            cboxProcesador.Enabled = False
            hintProcesador.Enabled = False
            hintProcesador.Text = Usuario.nameUserLoggedSystem
        End If
    End Sub

    Private Sub establecerDisplay()
        'Dim ejeX As Int16 = 1050
        'Dim ejeY As Int16 = 530

        'Size = New Size(ejeX, ejeY)
        'MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        'MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub









    'METODOS LOGICOS G3
    Private Sub traerProveedores()
        registro.traerProveedores()
    End Sub

    Private Sub seleccionarProveedor()
        Dim index As Short = cboxProveedor.SelectedIndex
        proveedorSeleccionado = registro.proveedores(index)
    End Sub

    Private Sub traerKits()
        Dim examen As ExamenLaboratorio = resultadoFormPadre.getExamen()
        registro.traerKits(proveedorSeleccionado, examen)
    End Sub

    Private Sub seleccionarKit()
        Dim index As Int16 = cboxKit.SelectedIndex
        kitequipoSeleccionado = registro.kits(index)
    End Sub

    Private Sub traerReferencias()
        Dim codigo As Int64 = kitequipoSeleccionado.getCodigo()

        registro.traerReferencias(codigo)
    End Sub

    Private Sub traerReferenciaDelPaciente()
        Dim tipoReferecnia As Concepto

        tipoReferecnia = kitequipoSeleccionado.getTipoReferencia()
        registro.traerReferenciaPaciente(tipoReferecnia, aseguradoFormPadre, resultadoFormPadre)
    End Sub

    Private Sub traerProcesadores()
        registro.traerProcesadores()
    End Sub

    Private Sub seleccionarProcesador()
        Dim index As Short = cboxProcesador.SelectedIndex
        procesadorSeleccionado = registro.procesadores(index)
    End Sub

    Private Sub hayObservacion()
        Dim referencia As ReferenciaResultadoLaboratorio, valorIngresado As Double

        referencia = resultadoFormPadre.getReferencia()
        valorIngresado = numResultado.Value

        observacion = registro.hayObservacion(referencia, valorIngresado)
    End Sub

    Private Sub buscarIndexObservacion()
        Dim referencia As ReferenciaResultadoLaboratorio

        referencia = resultadoFormPadre.getReferencia()

        registro.buscarIndexObservacion(referencia)
    End Sub

    'METODOS LOGICOS G9
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean = cargarEntradas()

        If entradasCargadas Then
            Dim mensajeValidacion As String = validarEntradas()

            If mensajeValidacion = "" Then
                Dim objetosCargados As Boolean = cargarObjetos()

                If objetosCargados Then
                    If esFormHijo Then

                        If observacion Then
                            Dim result As DialogResult
                            result = preguntarGuardarConObservacion()

                            If result = vbYes Then
                                guardarEstadoResultado()
                                ocultarFormulario()
                            End If

                        Else
                            guardarEstadoResultado()
                            ocultarFormulario()
                        End If

                    Else
                        enviarDatosDatabase()
                    End If
                End If

            Else
                mostrarMensaje(mensajeValidacion)
            End If
        End If
    End Sub

    Private Function cargarEntradas() As Boolean
        Try
            Dim proveedor As ProveedorKitEquipoInput, kitequipo As KitEquipoLaboratorioInput, inputProcesador As UsuarioInput,
            valorResultado As Double

            proveedor = New ProveedorKitEquipoInput()
            proveedor.codigo = proveedorSeleccionado.getCodigo()
            proveedor.nombre = proveedorSeleccionado.getNombre()

            kitequipo = New KitEquipoLaboratorioInput()
            kitequipo.proveedor = proveedor
            kitequipo.codigo = kitequipoSeleccionado.getCodigo()

            inputProcesador = New UsuarioInput()
            If modoTipoUsuario = 3 Then
                inputProcesador = New UsuarioInput()
                inputProcesador.codigo = Usuario.codUserLoggedSystem
                inputProcesador.nombres = Usuario.nameUserLoggedSystem

            ElseIf modoTipoUsuario = 4 Then
                inputProcesador = New UsuarioInput()
                inputProcesador.codigo = procesadorSeleccionado.getCodigo()
                inputProcesador.nombres = procesadorSeleccionado.getNombres()
            End If
            valorResultado = numResultado.Value


            nuevoInputResultado = New ResultadoLaboratorioInput()
            nuevoInputResultado.kitequipo = kitequipo
            nuevoInputResultado.valorTipoComun = valorResultado
            nuevoInputResultado.procesador = inputProcesador
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(nuevoInputResultado, modoTipoUsuario)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try
            Dim procesador As Usuario, codProcesador As Long, nomProcesador As String, valorResultado As Double

            codProcesador = nuevoInputResultado.procesador.codigo
            nomProcesador = nuevoInputResultado.procesador.nombres

            procesador = New Usuario()
            procesador.setCodigo(codProcesador)
            procesador.setNombres(nomProcesador)
            valorResultado = nuevoInputResultado.valorTipoComun
            kitequipoSeleccionado.setProveedor(proveedorSeleccionado)


            resultadoFormPadre.setKitEquipo(kitequipoSeleccionado)
            resultadoFormPadre.setProcesador(procesador)
            resultadoFormPadre.setValorTipoComun(valorResultado)
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub guardarEstadoResultado()
        resultadoFormPadre.setAsignado(True)
    End Sub

    Private Sub ocultarFormulario()
        Me.Hide()
    End Sub

    Private Sub enviarDatosDatabase()
        'registro.insertReferencias(tipoReferenciaSeleccionada, nuevasReferencias)

        'Dim mensajeInsercion As String = registro.generarMensajeInsercion()
        'mostrarMensaje(mensajeInsercion)
    End Sub

    Private Sub descartarResultado()
        resultadoFormPadre.setAsignado(False)
    End Sub




    'METODOS INTERFAZ G1
    Private Sub mostrarDatosExamen()
        Dim examen As ExamenLaboratorio, nombreExamen As String, nombreArea As String, descripcionUnidad As String

        examen = resultadoFormPadre.getExamen()
        nombreExamen = examen.getNombre()
        nombreArea = examen.getArea().getNombre()
        descripcionUnidad = resultadoFormPadre.getUnidad().getNombre() + " " + resultadoFormPadre.getUnidad().getAbreviacion()

        txtExamen.Text = nombreExamen
        txtArea.Text = nombreArea
        txtUnidad.Text = descripcionUnidad
    End Sub


    'METODOS INTERFAZ G2
    Private Sub mostrarDatosAsegurado()
        Dim nombre As String, matricula As String, sexo As String, edad As String

        nombre = aseguradoFormPadre.getApellidoPaterno() + " " + aseguradoFormPadre.getApellidoMaterno() + " " + aseguradoFormPadre.getNombres()
        matricula = aseguradoFormPadre.getMatricula()
        sexo = aseguradoFormPadre.getSexo()
        If sexo = "M" Then sexo = "MASCULINO" Else If sexo = "F" Then sexo = "FEMENINO"
        edad = aseguradoFormPadre.getEdad()
        edad = Utilitarios.calcularEdad(aseguradoFormPadre.getFechaNacimiento).ToString()

        txtAsegurado.Text = nombre
        txtMatricula.Text = matricula
        txtSexo.Text = sexo
        txtEdad.Text = edad
    End Sub


    'METODOS INTERFAZ G3
    Private Sub poblarCboxProveedor()
        cboxProveedor.Items.Clear()

        For Each proveedor As ProveedorKitEquipo In registro.proveedores
            cboxProveedor.Items.Add(proveedor.getNombre())
        Next
    End Sub

    Private Sub mostrarHintProveedor()
        hintProveedor.Visible = True
    End Sub

    Private Sub ocultarHintProveedor()
        hintProveedor.Visible = False
    End Sub

    Private Sub poblarCboxKits()
        cboxKit.Items.Clear()

        For Each kit As KitEquipoLaboratorio In registro.kits
            Dim nombrePoveedor As String, modelo As String

            nombrePoveedor = kit.getProveedor().getNombre()
            modelo = kit.getModelo()

            cboxKit.Items.Add(nombrePoveedor + " " + modelo)
        Next
    End Sub

    Private Sub mostrarHintKit()
        hintKit.Visible = True
    End Sub

    Private Sub ocultarHintKit()
        hintKit.Visible = False
    End Sub

    Private Sub poblarCboxProcesador()
        For Each procesador As Usuario In registro.procesadores
            Dim apPaterno As String, apMaterno As String, nombres As String, nombreCompleto As String

            apPaterno = procesador.getApellidoPaterno()
            apMaterno = procesador.getApellidoMaterno()
            nombres = procesador.getNombres()
            nombreCompleto = apPaterno + " " + apMaterno + " " + nombres

            cboxProcesador.Items.Add(nombreCompleto)
        Next
    End Sub

    Private Sub mostrarHintProcesador()
        hintProcesador.Visible = True
    End Sub

    Private Sub ocultarHintProcesador()
        hintProcesador.Visible = False
    End Sub

    Private Sub poblarDgvReferencias()
        dgvReferencias.Rows.Clear()

        Dim tipoReferencia As Short
        tipoReferencia = kitequipoSeleccionado.getTipoReferencia().getCorrelativo()


        Dim referencias As ReferenciaResultadoLaboratorio() = registro.referencias
        For Each referencia As ReferenciaResultadoLaboratorio In referencias
            Dim index As Short = dgvReferencias.Rows.Add()
            Dim rowActual As DataGridViewRow = dgvReferencias.Rows(index)


            If tipoReferencia = 1 Then
                Dim valorDesde As Double, valorHasta As Double

                valorDesde = referencia.getValorInicio()
                valorHasta = referencia.getValorFin()

                rowActual.Cells(clmValorDesdeDgvReferencias).Value = valorDesde
                rowActual.Cells(clmValorHastaDgvReferencias).Value = valorHasta

            ElseIf tipoReferencia = 2 Then
                Dim valorDesde As Double, valorHasta As Double, sexo As String

                valorDesde = referencia.getValorInicio()
                valorHasta = referencia.getValorFin()
                sexo = referencia.getSexo()
                If sexo = "M" Then sexo = "MASCULINO"
                If sexo = "F" Then sexo = "FEMENINO"

                rowActual.Cells(clmValorDesdeDgvReferencias).Value = valorDesde
                rowActual.Cells(clmValorHastaDgvReferencias).Value = valorHasta
                rowActual.Cells(clmSexoDgvReferencias).Value = sexo

            ElseIf tipoReferencia = 3 Then
                Dim valorDesde As Double, valorHasta As Double, edadInicio As Short, edadFin As Short

                valorDesde = referencia.getValorInicio()
                valorHasta = referencia.getValorFin()
                edadInicio = referencia.getEdadInicio()
                edadFin = referencia.getEdadFin()

                rowActual.Cells(clmValorDesdeDgvReferencias).Value = valorDesde
                rowActual.Cells(clmValorHastaDgvReferencias).Value = valorHasta
                rowActual.Cells(clmEdadDesdeDgvReferencias).Value = edadInicio
                rowActual.Cells(clmEdadHastaDgvReferencias).Value = edadFin

            ElseIf tipoReferencia = 4 Then
                Dim valorDesde As Double, valorHasta As Double, sexo As String, edadInicio As Short,
                    edadFin As Short

                valorDesde = referencia.getValorInicio()
                valorHasta = referencia.getValorFin()
                sexo = referencia.getSexo()
                If sexo = "M" Then sexo = "MASCULINO"
                If sexo = "F" Then sexo = "FEMENINO"
                edadInicio = referencia.getEdadInicio()
                edadFin = referencia.getEdadFin()

                rowActual.Cells(clmValorDesdeDgvReferencias).Value = valorDesde
                rowActual.Cells(clmValorHastaDgvReferencias).Value = valorHasta
                rowActual.Cells(clmSexoDgvReferencias).Value = sexo
                rowActual.Cells(clmEdadDesdeDgvReferencias).Value = edadInicio
                rowActual.Cells(clmEdadHastaDgvReferencias).Value = edadFin
            End If
        Next
    End Sub

    Private Sub ajustarInterfazDgvReferencias()
        Dim tipoReferencia As Int16 = kitequipoSeleccionado.getTipoReferencia().getCorrelativo()

        If tipoReferencia = 1 Then
            'OCULTAR CULUMAS
            lblHeaderEmpty.Visible = False
            lblHeaderEdad.Visible = False
            lblHeaderValorDeReferencia.Visible = False
            dgvReferencias.Columns(clmSexoDgvReferencias).Visible = False
            dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = False
            dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = False

            'MOSTRAR CULUMAS
            dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True


        ElseIf tipoReferencia = 2 Then
            'OCULTAR CULUMAS
            lblHeaderEmpty.Visible = False
            lblHeaderEdad.Visible = False
            lblHeaderValorDeReferencia.Visible = False
            dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = False
            dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = False

            'MOSTRAR CULUMAS
            dgvReferencias.Columns(clmSexoDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True

            'AJUSTAR TAMAÑO HEADERS
            'lblHeaderEmpty.Location = New Point(0, 0)
            'lblHeaderEmpty.Size = New Size(0, 0)
            lblHeaderEdad.Location = New Point(139, 74)
            lblHeaderEdad.Size = New Size(161, 18)
            lblHeaderValorDeReferencia.Location = New Point(299, 74)
            lblHeaderValorDeReferencia.Size = New Size(164, 18)


        ElseIf tipoReferencia = 3 Then
            'OCULTAR CULUMAS
            lblHeaderEmpty.Visible = False
            dgvReferencias.Columns(clmSexoDgvReferencias).Visible = False

            'MOSTRAR CULUMAS
            lblHeaderEdad.Visible = True
            lblHeaderValorDeReferencia.Visible = True
            dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True

            'AJUSTAR TAMAÑO HEADERS
            'lblHeaderEmpty.Location = New Point(0, 0)
            'lblHeaderEmpty.Size = New Size(0, 0)
            lblHeaderEdad.Location = New Point(58, 74)
            lblHeaderEdad.Size = New Size(203, 18)
            lblHeaderValorDeReferencia.Location = New Point(261, 74)
            lblHeaderValorDeReferencia.Size = New Size(202, 18)


        ElseIf tipoReferencia = 4 Then
            'OCULTAR CULUMAS
            lblHeaderEmpty.Visible = False


            'MOSTRAR CULUMAS
            lblHeaderEdad.Visible = True
            lblHeaderValorDeReferencia.Visible = True
            dgvReferencias.Columns(clmSexoDgvReferencias).Visible = True
            dgvReferencias.Columns(clmEdadDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmEdadHastaDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorDesdeDgvReferencias).Visible = True
            dgvReferencias.Columns(clmValorHastaDgvReferencias).Visible = True


            'AJUSTAR TAMAÑO HEADERS
            'lblHeaderEmpty.Location = New Point(0, 0)
            'lblHeaderEmpty.Size = New Size(0, 0)
            lblHeaderEdad.Location = New Point(139, 74)
            lblHeaderEdad.Size = New Size(161, 18)
            lblHeaderValorDeReferencia.Location = New Point(299, 74)
            lblHeaderValorDeReferencia.Size = New Size(164, 18)
        End If
    End Sub

    Private Sub deseleccionarEnDgvReferencias()
        dgvReferencias.ClearSelection()
    End Sub

    Private Sub pintarObservacionControlesInterfaz()
        pintarObservacionFilDgv()
        pintarObservacionNumResultado()
    End Sub

    Private Sub pintarObservacionFilDgv()
        Dim index As Short = registro.observacionIndex

        dgvReferencias.Rows(index).DefaultCellStyle.BackColor = Color.FromArgb(255, 46, 46)
    End Sub

    Private Sub pintarObservacionNumResultado()
        numResultado.BackColor = Color.FromArgb(255, 46, 46)
    End Sub

    Private Sub despintarObservacionControlesInterfaz()
        despintarObservacionFilaDgv()
        despintarObersvacionNumResultado()
    End Sub

    Private Sub despintarObservacionFilaDgv()
        For Each row As DataGridViewRow In dgvReferencias.Rows
            row.DefaultCellStyle.BackColor = Color.White
        Next
    End Sub

    Private Sub despintarObersvacionNumResultado()
        numResultado.BackColor = Color.White
    End Sub

    Private Sub habilitarNumResultado()
        numResultado.Enabled = True
    End Sub

    Private Sub deshabilitarNumResultado()
        numResultado.Enabled = False
    End Sub

    Private Sub reiniciarNumResultado()
        numResultado.Value = 0.000
        numResultado.BackColor = Color.White
    End Sub






    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub

    Private Function preguntarGuardarConObservacion() As DialogResult
        Dim dialogResult As DialogResult

        dialogResult = MessageBox.Show("´¿El resultado actual se encuentra fuera del rango de los valores de referencia. Desea confirmar este resultado?", "Mensaje.", MessageBoxButtons.YesNo)

        If dialogResult = vbYes Then Return vbYes Else Return vbNo
    End Function









    'EVENTOS G3
    Private Sub cboxProveedor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxProveedor.SelectionChangeCommitted
        Try
            seleccionarProveedor()
            ocultarHintProveedor()

            traerKits()
            poblarCboxKits()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxKit_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxKit.SelectionChangeCommitted
        Try
            seleccionarKit()
            ocultarHintKit()

            traerReferencias()
            ajustarInterfazDgvReferencias()

            poblarDgvReferencias()
            deseleccionarEnDgvReferencias()

            despintarObservacionFilaDgv()
            despintarObersvacionNumResultado()

            traerReferenciaDelPaciente()

            habilitarNumResultado()
            reiniciarNumResultado()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxProcesador_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxProcesador.SelectionChangeCommitted
        Try
            seleccionarProcesador()
            ocultarHintProcesador()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub numResultado_ValueChanged(sender As Object, e As EventArgs) Handles numResultado.ValueChanged
        Try
            hayObservacion()

            If observacion Then
                buscarIndexObservacion()
                pintarObservacionControlesInterfaz()
            Else
                despintarObservacionControlesInterfaz()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

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



    'EVENTOS G9
    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub FormRegistrarResultadoLabTipoValorComun_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If e.CloseReason = CloseReason.UserClosing Then
                descartarResultado()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


End Class