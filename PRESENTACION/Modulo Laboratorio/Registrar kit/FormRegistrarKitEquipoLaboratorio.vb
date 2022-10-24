Imports NEGOCIO

Public Class FormRegistrarKitEquipoLaboratorio

    'ATRIBUTOS LÓGICOS
    Public registro As RegistroKitEquipoLaboratorio

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean
    Private esFormHijo As Boolean
    Private examenFormPadre As ExamenLaboratorio
    Private unidadFormPadre As UnidadMedidaLaboratorio
    Private tipoResultadoFormPadre As Concepto

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private tipoSeleccionado As Concepto
    Private proveedorSeleccionado As ProveedorKitEquipo


    'ATRIBUTOS G2
    Private examenSeleccionado As ExamenLaboratorio

    'ATRIBUTOS G4
    Private tipoReferenciaSeleccionada As Concepto
    Public formReferecias As FormRegistrarReferenciaResultadoLaboratorio
    Public estadoFormHijoReferenciasGuardado As Boolean
    Public nuevasReferenciasLaboratorio As ReferenciaResultadoLaboratorio()

    'ATRIBUTOS G9
    Private nuevoInputKitEquipo As KitEquipoLaboratorioInput
    Public nuevoKitEquipo As KitEquipoLaboratorio


    'METODOS INICIO
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(False, Nothing, Nothing, Nothing)
        iniciarFormulario()
    End Sub

    Public Sub New(ByRef _examen As ExamenLaboratorio, ByRef _unidad As UnidadMedidaLaboratorio, ByRef _tipoResultado As Concepto)
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(True, _examen, _unidad, _tipoResultado)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormRegistrarKitEquipoLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean, ByRef _examen As ExamenLaboratorio, ByRef _unidad As UnidadMedidaLaboratorio,
                                            ByRef _tipoResultado As Concepto)
        estadoFormGuardado = False

        If _esHijo Then
            esFormHijo = True
            examenFormPadre = _examen
            unidadFormPadre = _unidad
            tipoResultadoFormPadre = _tipoResultado

        Else
            esFormHijo = False
            examenFormPadre = Nothing
            unidadFormPadre = Nothing
            tipoResultadoFormPadre = Nothing
        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarControlesInterfaz()
        traerTipos()
        poblarCboxTipo()


        traerTiposValoresReferencia()
        poblarCboxTipoReferencia()

        traerProveedores()
        poblarCboxProveedor()

        If esFormHijo Then iniciarControlesInterfazFormSecundario()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroKitEquipoLaboratorio()


        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'estadoFormGuardado = False
        'esFormHijo As Boolean
        'examenFormPadre As ExamenLaboratorio

        'ATRIBUTOS G0
        tituloFormulario = "Registrar kit-equipo de laboratorio"

        'ATRIBUTOS G1
        tipoSeleccionado = New Concepto()
        proveedorSeleccionado = New ProveedorKitEquipo()

        'ATRIBUTOS G2
        examenSeleccionado = New ExamenLaboratorio()

        'ATRIBUTOS G4
        tipoReferenciaSeleccionada = New Concepto()
        formReferecias = New FormRegistrarReferenciaResultadoLaboratorio()
        estadoFormHijoReferenciasGuardado = False
        nuevasReferenciasLaboratorio = New ReferenciaResultadoLaboratorio(-1) {}

        'ATRIBUTOS G9
        nuevoInputKitEquipo = New KitEquipoLaboratorioInput()
        nuevoKitEquipo = New KitEquipoLaboratorio()
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarControlesInterfaz()
        iniciarControlesInterfazGrupo0()
        iniciarControlesInterfazGrupo1()
        iniciarControlesInterfazGrupo2()
        iniciarControlesInterfazGrupo3()
        iniciarControlesInterfazGrupo4()
    End Sub

    Private Sub iniciarControlesInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        'do not make the form visible programatically
        'all initilaization should be made in the contrusctor beacuse it is faster,
        'but if execute the next line of code,  the form will stop the constuctor() execution 
        'and will go to the OnLoad() execution, so no, do not do this.
        'Me.Visible = True 

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper

        If esFormHijo Then menuStrip.Enabled = False
        If Not esFormHijo Then menuStrip.Enabled = True
    End Sub

    Private Sub iniciarControlesInterfazGrupo1()
        panelDatosKitEquipo.Enabled = True
        panelDatosKitEquipo.Visible = True

        cboxTipo.Enabled = True
        cboxTipo.Visible = True
        cboxTipo.Font = New Font("Microsoft Sans Serif", 9)
        cboxTipo.Items.Clear()
        cboxTipo.DropDownStyle = ComboBoxStyle.DropDownList

        hintTipo.Enabled = True
        hintTipo.Visible = True
        hintTipo.Font = New Font("Microsoft Sans Serif", 8)
        hintTipo.Text = "SELECCIONAR"
        hintTipo.BackColor = Color.Transparent

        cboxProveedor.Enabled = True
        cboxProveedor.Visible = True
        cboxProveedor.Font = New Font("Microsoft Sans Serif", 9)
        cboxProveedor.Items.Clear()
        cboxProveedor.DropDownStyle = ComboBoxStyle.DropDownList

        hintProveedor.Enabled = True
        hintProveedor.Visible = True
        hintProveedor.Font = New Font("Microsoft Sans Serif", 8)
        hintProveedor.Text = "SELECCIONAR"
        hintProveedor.BackColor = Color.Transparent

        btnRegistrarProveedor.Enabled = True
        btnRegistrarProveedor.Visible = True
        btnRegistrarProveedor.Font = New Font("Microsoft Sans Serif", 9)
        btnRegistrarProveedor.Text = "Registrar nuevo proveedor"

        txtModelo.Enabled = True
        txtModelo.Visible = True
        txtModelo.Font = New Font("Microsoft Sans Serif", 9)
        txtModelo.Text = ""
        txtModelo.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarControlesInterfazGrupo2()
        panelSeleccionarExamen.Enabled = True
        panelSeleccionarExamen.Visible = True

        txtBuscarExamen.Enabled = True
        txtBuscarExamen.Visible = True
        txtBuscarExamen.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarExamen.Text = ""
        txtBuscarExamen.CharacterCasing = CharacterCasing.Upper

        btnBuscarExamen.Enabled = True
        btnBuscarExamen.Visible = True
        btnBuscarExamen.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarExamen.Text = "Buscar"

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
    End Sub

    Private Sub iniciarControlesInterfazGrupo3()
        panelDatosExamen.Enabled = False
        panelDatosExamen.Visible = True

        chPermiteReferencias.Enabled = False
        chPermiteReferencias.Visible = True
        chPermiteReferencias.Checked = False
        chPermiteReferencias.Font = New Font("Microsoft Sans Serif", 9.5)

        txtNombreArea.Enabled = False
        txtNombreArea.Visible = True
        txtNombreArea.Font = New Font("Microsoft Sans Serif", 9)
        txtNombreArea.Text = ""
        txtNombreArea.CharacterCasing = CharacterCasing.Upper

        txtNombreSubarea.Enabled = False
        txtNombreSubarea.Visible = True
        txtNombreSubarea.Font = New Font("Microsoft Sans Serif", 9)
        txtNombreSubarea.Text = ""
        txtNombreSubarea.CharacterCasing = CharacterCasing.Upper

        txtUnidad.Enabled = False
        txtUnidad.Visible = True
        txtUnidad.Font = New Font("Microsoft Sans Serif", 9)
        txtUnidad.Text = ""
        txtUnidad.CharacterCasing = CharacterCasing.Upper

        txtTipoResultado.Enabled = False
        txtTipoResultado.Visible = True
        txtTipoResultado.Font = New Font("Microsoft Sans Serif", 9)
        txtTipoResultado.Text = ""
        txtTipoResultado.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarControlesInterfazGrupo4()
        panelReferencias.Enabled = False
        panelReferencias.Visible = True

        cboxTipoReferencia.Enabled = True
        cboxTipoReferencia.Visible = True
        cboxTipoReferencia.Font = New Font("Microsoft Sans Serif", 9)
        cboxTipoReferencia.Items.Clear()
        cboxTipoReferencia.DropDownStyle = ComboBoxStyle.DropDownList

        hintTipoReferencia.Enabled = True
        hintTipoReferencia.Visible = True
        hintTipoReferencia.Font = New Font("Microsoft Sans Serif", 8)
        hintTipoReferencia.Text = "SELECCIONAR"
        hintTipoReferencia.BackColor = Color.Transparent

        btnAsignarReferencias.Enabled = True
        btnAsignarReferencias.Visible = True
        btnAsignarReferencias.Font = New Font("Microsoft Sans Serif", 9)
        btnAsignarReferencias.Text = "Asignar valores de referencia"

        chValoresAsignados.Enabled = False
        chValoresAsignados.Visible = True
        chValoresAsignados.Checked = False
        chValoresAsignados.Font = New Font("Microsoft Sans Serif", 9.5)
    End Sub

    Private Sub establecerDisplay()
        '    Dim ejeX As Short, ejeY As Short
        '    ejeX = Utilitarios.resolucionEstandarEjeX
        '    ejeY = Utilitarios.resolucionEstandarEjeY

        '    Size = New Size(ejeX, ejeY)
        '    MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        '    MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub

    Private Sub iniciarControlesInterfazFormSecundario()
        'DESHABILITAR CONTRLES INTERFAZ
        panelSeleccionarExamen.Enabled = False
        panelDatosExamen.Enabled = False
        panelReferencias.Enabled = True


        'ESTABLECER ATRIBUTOS LOGICOS DEL FORM PADRE
        examenSeleccionado = examenFormPadre
        examenSeleccionado.setUnidad(unidadFormPadre)


        'MOSTRAR DATOS INTERFAZ A PARTIR DE ATRIBUTOS 
        hintExamen.Text = examenSeleccionado.getNombre()
        txtNombreArea.Text = examenSeleccionado.getArea().getNombre()
        txtNombreSubarea.Text = examenSeleccionado.getSubarea().getNombre()
        txtUnidad.Text = unidadFormPadre.getNombre()
        txtTipoResultado.Text = tipoResultadoFormPadre.getDescripcion()
        chPermiteReferencias.Checked = True

        btnEnviarDatos.Text = "Guardar kit"
    End Sub















    'METODOS LOGICOS G1 --
    Private Sub traerTipos()
        registro.traerTipos()
    End Sub

    Private Sub seleccionarTipo()
        Dim index As Short = cboxTipo.SelectedIndex
        tipoSeleccionado = registro.tipos(index)

    End Sub

    Private Sub traerProveedores()
        registro.traerProveedores()
    End Sub

    Private Sub seleccionarProveedor()
        Dim index As Short = cboxProveedor.SelectedIndex
        proveedorSeleccionado = registro.proveedores(index)
    End Sub


    'METODOS LOGICOS G2 
    Private Sub traerExamenes()
        Dim nombreExamen As String = txtBuscarExamen.Text.Trim()
        registro.traerExamenes(nombreExamen)
    End Sub

    Private Sub seleccionarExamen()
        Dim index As Short = cboxExamen.SelectedIndex
        examenSeleccionado = registro.examenes(index)
    End Sub


    'METODOS LOGICOS G3
    Private Function permiteReferenciasResultado(ByRef _tipoResultado As Concepto) As Boolean
        Dim permiteReferencias As Boolean = registro.permiteReferenciasResultado(_tipoResultado)
        Return permiteReferencias
    End Function


    'METODOS LOGICOS G4
    Private Sub traerTiposValoresReferencia()
        registro.traerTiposValoresReferencia()
    End Sub

    Private Sub seleccionarTipoValorReferencia()
        Dim index As Short = cboxTipoReferencia.SelectedIndex
        tipoReferenciaSeleccionada = registro.tiposReferencia(index)
    End Sub

    Private Sub abrirFormRegistrarReferencias()
        Dim nomKitEquipo As String = proveedorSeleccionado.getNombre() + " " + txtModelo.Text.Trim()
        nuevoKitEquipo.setCodigo(1)
        nuevoKitEquipo.setNombre(nomKitEquipo)


        If Not estadoFormHijoReferenciasGuardado Then
            formReferecias = New FormRegistrarReferenciaResultadoLaboratorio(examenSeleccionado, nuevoKitEquipo, tipoReferenciaSeleccionada)
        End If

        formReferecias.ShowDialog()
        estadoFormHijoReferenciasGuardado = formReferecias.estadoFormGuardado
        nuevasReferenciasLaboratorio = formReferecias.nuevasReferencias
    End Sub



    'METODOS LOGICOS G9
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
            Dim tipo As ConceptoInput, proveedor As ProveedorKitEquipoInput,
                modelo As String, examen As ExamenLaboratorioInput, tipoReferencia As ConceptoInput

            tipo = New ConceptoInput()
            tipo.correlativo = tipoSeleccionado.getCorrelativo()
            tipo.descripcion = tipoSeleccionado.getDescripcion()

            proveedor = New ProveedorKitEquipoInput()
            proveedor.codigo = proveedorSeleccionado.getCodigo()
            proveedor.nombre = proveedorSeleccionado.getNombre()

            examen = New ExamenLaboratorioInput()
            examen.codigo = examenSeleccionado.getCodigo()
            examen.nombre = examenSeleccionado.getNombre()

            modelo = txtModelo.Text.Trim()

            tipoReferencia = New ConceptoInput()
            tipoReferencia.correlativo = tipoReferenciaSeleccionada.getCorrelativo()
            tipoReferencia.descripcion = tipoReferenciaSeleccionada.getDescripcion()

            nuevoInputKitEquipo = New KitEquipoLaboratorioInput()
            nuevoInputKitEquipo.tipo = tipo
            nuevoInputKitEquipo.proveedor = proveedor
            nuevoInputKitEquipo.modelo = modelo
            nuevoInputKitEquipo.examen = examen
            nuevoInputKitEquipo.tipoReferencia = tipoReferencia
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(nuevoInputKitEquipo, estadoFormHijoReferenciasGuardado)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try

            nuevoKitEquipo = New KitEquipoLaboratorio()
            nuevoKitEquipo.setTipo(tipoSeleccionado)
            nuevoKitEquipo.setProveedor(proveedorSeleccionado)
            nuevoKitEquipo.setModelo(nuevoInputKitEquipo.modelo)
            nuevoKitEquipo.setExamen(examenSeleccionado)
            nuevoKitEquipo.setTipoReferencia(tipoReferenciaSeleccionada)
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub enviarDatosDatabase()
        registro.insertKitEquipo(nuevoKitEquipo, nuevasReferenciasLaboratorio, formReferecias.registro)

        Dim mensajeInsercion As String = registro.generarMensajeInsercion()
        mostrarMensaje(mensajeInsercion)
        If registro.estadoInsercion > 0 Then reiniciarFormulario()
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
    Private Sub poblarCboxTipo()
        cboxTipo.Items.Clear()

        For Each tipo As Concepto In registro.tipos
            cboxTipo.Items.Add(tipo.getDescripcion)
        Next
    End Sub

    Private Sub mosrtarHintTipo()
        hintTipo.Visible = True
    End Sub

    Private Sub ocultarHintTipo()
        hintTipo.Visible = False
    End Sub

    Private Sub poblarCboxProveedor()
        cboxProveedor.Items.Clear()

        For Each proveedor As ProveedorKitEquipo In registro.proveedores
            cboxProveedor.Items.Add(proveedor.getNombre())
        Next
    End Sub

    Private Sub mosrtarHintProveedor()
        hintProveedor.Visible = True
    End Sub

    Private Sub ocultarHintProveedor()
        hintProveedor.Visible = False
    End Sub

    'METODOS INTERFAZ G2
    Private Sub poblarCboxExamen()
        cboxExamen.Items.Clear()

        For Each examen As ExamenLaboratorio In registro.examenes
            cboxExamen.Items.Add(examen.getNombre())
        Next
    End Sub

    Private Sub mostrarHintExamen()
        hintExamen.Visible = True
    End Sub

    Private Sub ocultarHintExamen()
        hintExamen.Visible = False
    End Sub


    'METODOS INTERFAZ G3
    Private Sub mostrarDatosExamen()
        Dim nombreUnidad As String, abreviacionUnidad As String, permite As Boolean

        nombreUnidad = examenSeleccionado.getUnidad().getNombre()
        abreviacionUnidad = examenSeleccionado.getUnidad.getAbreviacion()
        permite = permiteReferenciasResultado(examenSeleccionado.getTipoResultado())


        txtNombreArea.Text = examenSeleccionado.getArea().getNombre()
        txtNombreSubarea.Text = examenSeleccionado.getSubarea().getNombre()
        txtUnidad.Text = nombreUnidad + " | " + abreviacionUnidad
        txtTipoResultado.Text = examenSeleccionado.getTipoResultado().getDescripcion()
        If permite Then chPermiteReferencias.Checked = True Else chPermiteReferencias.Checked = False
    End Sub


    'METODOS INTERFAZ G4
    Private Sub poblarCboxTipoReferencia()
        cboxTipoReferencia.Items.Clear()

        For Each tipoReferencia As Concepto In registro.tiposReferencia
            cboxTipoReferencia.Items.Add(tipoReferencia.getDescripcion())
        Next
    End Sub

    Private Sub mostrarHintTipoReferencia()
        hintTipoReferencia.Visible = True
    End Sub

    Private Sub ocultarHintTipoReferencia()
        hintTipoReferencia.Visible = False
    End Sub

    Private Sub ajustarInterfazPanelReferncias()
        If chPermiteReferencias.Checked Then
            panelReferencias.Enabled = True
        Else
            panelReferencias.Enabled = False
        End If
    End Sub

    Private Sub ajustarChValoresAsignados()
        If estadoFormHijoReferenciasGuardado Then
            chValoresAsignados.Checked = True
        Else
            chValoresAsignados.Checked = False
        End If
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
    Private Sub cboxTipo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTipo.SelectionChangeCommitted
        Try
            seleccionarTipo()
            ocultarHintTipo()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarProveedor_Click(sender As Object, e As EventArgs) Handles btnRegistrarProveedor.Click
        Try
            Dim form As FormRegistrarProveedorKitEquipo
            form = New FormRegistrarProveedorKitEquipo(True)
            form.ShowDialog()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G2
    Private Sub btnBuscarExamen_Click(sender As Object, e As EventArgs) Handles btnBuscarExamen.Click
        Try
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
            mostrarDatosExamen()
            ajustarInterfazPanelReferncias()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G4
    Private Sub cboxTipoValoresReferencia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTipoReferencia.SelectionChangeCommitted
        Try
            seleccionarTipoValorReferencia()
            ocultarHintTipoReferencia()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarValoresReferencia_Click(sender As Object, e As EventArgs) Handles btnAsignarReferencias.Click
        Try
            abrirFormRegistrarReferencias()
            ajustarChValoresAsignados()

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

    Private Sub FormRegistrarKitEquipoLaboratorio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If e.CloseReason = CloseReason.UserClosing Then descartarEstado()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxProveedor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxProveedor.SelectionChangeCommitted
        Try
            seleccionarProveedor()
            ocultarHintProveedor()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try


    End Sub



End Class



