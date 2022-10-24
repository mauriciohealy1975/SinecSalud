Imports NEGOCIO

Public Class FormRegistrarResultadoLabTipoValorOpcionSeleccion

    'AITRBUTOS LOGICOS
    Private registro As RegistroResultadoLabTipoValorOpcionSeleccion

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean
    Private esFormHijo As Boolean
    Private modoTipoUsuario As Short


    'ATRIBUTOS PARAMETOS RECIBIDOS
    Private resultadoFormPadre As ResultadoLaboratorio

    'ATRIBUTOS PROPERTIES G0
    Private tituloDeFormulario As String

    'AITRBUTOS G1
    Private procesadorSeleccionado As Usuario
    Private opcionSeleccionada As OpcionResultadoLaboratorio

    'AITRBUTOS PROPIERTIES G9
    Private nuevoInputResultado As ResultadoLaboratorioInput
    Public nuevoResultado As ResultadoLaboratorio






    'METODOS INICIO
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(False, Nothing, 0)
        iniciarFormulario()
    End Sub

    Public Sub New(ByRef _resultado As ResultadoLaboratorio, _modoTipoUsuario As Short)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(True, _resultado, _modoTipoUsuario)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        establecerDisplay()
    End Sub

    Private Sub FormRegistrarResultadoTipoConjuntoOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean, ByRef _resultado As ResultadoLaboratorio, _modoTipoUsuario As Short)
        estadoFormGuardado = False

        If _esHijo Then
            esFormHijo = True
            resultadoFormPadre = _resultado
            modoTipoUsuario = _modoTipoUsuario
        Else
            esFormHijo = False
            resultadoFormPadre = Nothing
            modoTipoUsuario = 0
        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarInterfaz()

        ajustarControlesSegunTipoUsuario()

        mostrarDatosExamen()

        traerOpciones()
        poblarCboxOpciones()

        traerProcesadores()
        poblarCboxProcesador()
    End Sub

    Private Sub iniciarAtributos()
        'AITRBUTOS LOGICOS
        registro = New RegistroResultadoLabTipoValorOpcionSeleccion()

        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'estadoFormGuardado As Boolean
        'esFormHijo As Boolean

        'ATRIBUTOS PARAMETOS RECIBIDOS
        If IsNothing(resultadoFormPadre) Then resultadoFormPadre = New ResultadoLaboratorio

        'ATRIBUTOS G0
        tituloDeFormulario = "Registrar resultados de tipo opción de selección"

        'ATRIBUTOS G1
        procesadorSeleccionado = New Usuario()
        opcionSeleccionada = New OpcionResultadoLaboratorio()

        'AITRBUTOS PROPIERTIES G9
        nuevoInputResultado = New ResultadoLaboratorioInput()
        nuevoResultado = New ResultadoLaboratorio()
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarInterfaz()
        iniciarInterfazGrupo0()
        iniciarInterfazGrupo1()
    End Sub

    Private Sub iniciarInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloDeFormulario

        lblTituloPrincipal.Text = tituloDeFormulario.ToUpper()
    End Sub

    Private Sub iniciarInterfazGrupo1()
        panelResultado.Enabled = True
        panelResultado.Visible = True

        txtExamen.Enabled = False
        txtExamen.Visible = True
        txtExamen.ReadOnly = True
        txtExamen.Font = New Font("Microsoft Sans Serif", 9)
        txtExamen.Text = ""
        txtExamen.CharacterCasing = CharacterCasing.Upper

        txtArea.Enabled = False
        txtArea.Visible = True
        txtArea.ReadOnly = True
        txtArea.Font = New Font("Microsoft Sans Serif", 9)
        txtArea.Text = ""
        txtArea.CharacterCasing = CharacterCasing.Upper

        cboxOpcion.Enabled = True
        cboxOpcion.Visible = True
        cboxOpcion.Font = New Font("Microsoft Sans Serif", 9)
        cboxOpcion.Items.Clear()
        cboxOpcion.DropDownStyle = ComboBoxStyle.DropDownList

        hintOpcion.Enabled = True
        hintOpcion.Visible = True
        hintOpcion.Font = New Font("Microsoft Sans Serif", 9)
        hintOpcion.Text = "SELECCIONAR"
        hintOpcion.BackColor = Color.Transparent
    End Sub

    Private Sub ajustarControlesSegunTipoUsuario()
        If modoTipoUsuario = 3 Then
            cboxProcesador.Enabled = False
            hintProcesador.Enabled = False
            hintProcesador.Text = Usuario.nameUserLoggedSystem
        End If
    End Sub

    Private Sub establecerDisplay()
        'Dim ejeX As Short, ejeY As Short

        ''ejeX = Utilitarios.resolucionEstandarEjeX
        ''ejeY = Utilitarios.resolucionEstandarEjeY

        'ejeX = 510
        'ejeY = 310

        'Size = New Size(ejeX, ejeY)
        'MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        'MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub












    'METODOS LÓGICOS G1
    Private Sub traerProcesadores()
        registro.traerProcesadores()
    End Sub

    Private Sub seleccionarProcesador()
        Dim index As Short = cboxProcesador.SelectedIndex
        procesadorSeleccionado = registro.procesadores(index)
    End Sub

    Private Sub traerOpciones()
        Dim conjunto As ConjuntoOpcionesResultadosLaboratorio = resultadoFormPadre.getConjunto()
        registro.traerOpciones(conjunto)
    End Sub

    Private Sub seleccionarOpcion()
        Dim index As Short = cboxOpcion.SelectedIndex
        opcionSeleccionada = registro.opciones(index)
    End Sub

    'METODOS LÓGICOS G9
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean = cargarEntradas()

        If entradasCargadas Then
            Dim mensajeValidacion As String = validarEntradas()

            If mensajeValidacion = "" Then

                Dim objetosCargados As Boolean = cargarObjetos()

                If objetosCargados Then
                    If esFormHijo Then
                        guardarEstado()
                        ocultarFormulario()
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
            Dim opcion As OpcionResultadoLaboratorioInput, inputProcesador As UsuarioInput

            If modoTipoUsuario = 3 Then
                inputProcesador = New UsuarioInput()
                inputProcesador.codigo = Usuario.codUserLoggedSystem
                inputProcesador.nombres = Usuario.nameUserLoggedSystem

            ElseIf modoTipoUsuario = 4 Then
                inputProcesador = New UsuarioInput()
                inputProcesador.codigo = procesadorSeleccionado.getCodigo()
                inputProcesador.nombres = procesadorSeleccionado.getNombres()
            End If

            opcion = New OpcionResultadoLaboratorioInput()
            opcion.codigo = opcionSeleccionada.getCodigo()
            opcion.valor = opcionSeleccionada.getValor()

            nuevoInputResultado = New ResultadoLaboratorioInput()
            nuevoInputResultado.valorTipoOpcion = opcion
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
            Dim codigoOpcion As Long, valorOpcion As String, opcionResultado As OpcionResultadoLaboratorio,
                codProcesador As Long, nomProcesador As String, procesador As Usuario

            codigoOpcion = nuevoInputResultado.valorTipoOpcion.codigo
            valorOpcion = nuevoInputResultado.valorTipoOpcion.valor

            opcionResultado = New OpcionResultadoLaboratorio()
            opcionResultado.setCodigo(codigoOpcion)
            opcionResultado.setValor(valorOpcion)

            codProcesador = nuevoInputResultado.procesador.codigo
            nomProcesador = nuevoInputResultado.procesador.nombres

            procesador = New Usuario()
            procesador.setCodigo(codProcesador)
            procesador.setNombres(nomProcesador)


            resultadoFormPadre.setValorTipoOpcion(opcionResultado)
            resultadoFormPadre.setProcesador(procesador)

            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub guardarEstado()
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
        txtExamen.Text = resultadoFormPadre.getExamen().getNombre()
        txtArea.Text = resultadoFormPadre.getExamen().getArea().getNombre()
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

    Private Sub poblarCboxOpciones()
        cboxOpcion.Items.Clear()

        For Each opcion As OpcionResultadoLaboratorio In registro.opciones
            cboxOpcion.Items.Add(opcion.getValor())
        Next
    End Sub

    Private Sub mostrarHintOpcion()
        hintOpcion.Visible = True
    End Sub

    Private Sub ocultarHintOpcion()
        hintOpcion.Visible = False
    End Sub


    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub









    'EVENTOS G1
    Private Sub cboxProcesador_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxProcesador.SelectionChangeCommitted
        Try
            seleccionarProcesador()
            ocultarHintProcesador()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    Private Sub cboxOpcion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxOpcion.SelectionChangeCommitted
        Try
            seleccionarOpcion()
            ocultarHintOpcion()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    'EVENTOS G9
    Private Sub btnGuardarResultado_Click(sender As Object, e As EventArgs) Handles btnGuardarResultado.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    Private Sub FormRegistrarResultadoLabTipoValorOpcionSeleccion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If e.CloseReason = CloseReason.UserClosing Then
                descartarResultado()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



End Class