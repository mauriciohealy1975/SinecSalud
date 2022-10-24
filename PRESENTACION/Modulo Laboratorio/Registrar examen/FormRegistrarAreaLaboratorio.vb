Imports NEGOCIO

Public Class FormRegistrarAreaLaboratorio

    'ATRIBUTOS LÓGICOS
    Private registro As RegistroAreaLaboratorio

    'ATRIBUTOS LÓGICOS MODO FORMHIJO
    Private esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G9
    Private nuevaArea As AreaLaboratorio



    'METODOS INICIO -
    Public Sub New(ByRef _esFormHijo As Boolean)
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(_esFormHijo)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormRegistrarAreaLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)
        esFormHijo = _esHijo

        If esFormHijo Then

        Else

        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarInterfaz()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroAreaLaboratorio()

        'ATRIBUTOS G0
        tituloFormulario = "Registrar area de laboratorio"

        'ATRIBUTOS G9
        nuevaArea = New AreaLaboratorio()
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarInterfaz()
        iniciarInterfazGrupo0()
        iniciarInterfazGrupo1()
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
        panelArea.Enabled = True
        panelArea.Visible = True

        txtAreaPanelArea.Enabled = True
        txtAreaPanelArea.Visible = True
        txtAreaPanelArea.Font = New Font("Microsoft Sans Serif", 9)
        txtAreaPanelArea.Text = ""
        txtAreaPanelArea.CharacterCasing = CharacterCasing.Upper

        btnRegistrarArea.Enabled = True
        btnRegistrarArea.Visible = True
        btnRegistrarArea.Font = New Font("Microsoft Sans Serif", 9)
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


















    'MÉTODOS LÓGICOS G9 
    Private Sub enviarDatosArea()
        Dim datosCargados As Boolean = cargarDatosArea()

        If datosCargados Then
            Dim mensajeValidacion As String = validarEntradasArea()
            If mensajeValidacion = "" Then enviarDatosAreaDatanase() Else mostrarMensaje(mensajeValidacion)
        End If

    End Sub

    Private Function cargarDatosArea()
        Try
            Dim nombreArea As String
            nombreArea = txtAreaPanelArea.Text.Trim()

            nuevaArea = New AreaLaboratorio()
            nuevaArea.setNombre(nombreArea)
            Return True


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradasArea()
        Dim mensaje As String
        mensaje = registro.validarEntradasRegistrarArea(nuevaArea)
        Return mensaje
    End Function

    Private Sub enviarDatosAreaDatanase()
        Dim respuesta As Int16 = registro.insertArea(nuevaArea)

        If respuesta > 0 Then
            mostrarMensaje("El area se registró correctamente")
            reiniciarFormulario()

        ElseIf respuesta < 0 Then
            mostrarMensaje("Ocurrió un error al guardar el area")
        End If

    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub







    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub









    'EVENTOS G0
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim form As FormMenuLaboratorio

        form = New FormMenuLaboratorio()
        form.Show()
        Me.Close()
    End Sub

    'EVENTOS G9
    Private Sub btnRegistrarArea_Click(sender As Object, e As EventArgs) Handles btnRegistrarArea.Click
        Try
            enviarDatosArea()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Class