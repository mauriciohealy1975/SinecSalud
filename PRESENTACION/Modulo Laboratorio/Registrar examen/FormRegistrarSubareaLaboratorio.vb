Imports NEGOCIO

Public Class FormRegistrarSubareaLaboratorio

    'ATRIBUTOS LÓGICOS
    Private registro As RegistroSubareaLaboratorio


    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Private esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G2
    Public areaSeleccionadaPanelSubarea As AreaLaboratorio
    Private nuevaSubarea As SubareaLaboratorio


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

    Private Sub FormRegistrarSubareaLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)

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
        poblarCboxAreaPanelSubarea()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroSubareaLaboratorio()

        'ATRIBUTOS G0
        tituloFormulario = "Registrar subarea de laboratorio"

        'ATRIBUTOS G2
        areaSeleccionadaPanelSubarea = New AreaLaboratorio()
        nuevaSubarea = New SubareaLaboratorio()

    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarInterfaz()
        iniciarInterfazDisplay()
        iniciarInterfazGrupo0()
        iniciarInterfazGrupo2()
    End Sub

    Private Sub iniciarInterfazDisplay()
        Dim ejeX As Short, ejeY As Short
        ejeX = Utilitarios.resolucionEstandarEjeX
        ejeY = Utilitarios.resolucionEstandarEjeY

        Dim mySize As New Size(500, 300)

        Size = mySize
        MinimumSize = mySize
        MaximumSize = mySize
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

    Private Sub iniciarInterfazGrupo2()
        cboxAreaPanelSubarea.Enabled = True
        cboxAreaPanelSubarea.Visible = True
        cboxAreaPanelSubarea.Font = New Font("Microsoft Sans Serif", 9)
        cboxAreaPanelSubarea.Items.Clear()
        cboxAreaPanelSubarea.DropDownStyle = ComboBoxStyle.DropDownList

        hintAreaPanelSubarea.Enabled = True
        hintAreaPanelSubarea.Visible = True
        hintAreaPanelSubarea.Font = New Font("Microsoft Sans Serif", 8)
        hintAreaPanelSubarea.Text = "SELECCIONAR"
        hintAreaPanelSubarea.BackColor = Color.Transparent

        txtSubareaPanelSubarea.Enabled = True
        txtSubareaPanelSubarea.Visible = True
        txtSubareaPanelSubarea.Font = New Font("Microsoft Sans Serif", 9)
        txtSubareaPanelSubarea.Text = ""
        txtSubareaPanelSubarea.CharacterCasing = CharacterCasing.Upper


        btnRegistrarSubarea.Enabled = True
        btnRegistrarSubarea.Visible = True
        btnRegistrarSubarea.Font = New Font("Microsoft Sans Serif", 9)
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


    'MÉTODOS LÓGICOS G2 =========================
    Private Sub traerAreas()
        registro.traerAreas()
    End Sub

    Private Sub seleccionarAreaPanelSubarea()
        Dim index As Short = cboxAreaPanelSubarea.SelectedIndex
        areaSeleccionadaPanelSubarea = registro.areas(index)
    End Sub


    'MÉTODOS LÓGICOS G4
    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub


    'MÉTODOS LÓGICOS G4 REGISTRAR SUBAREA
    Private Sub enviarDatosSubarea()
        Dim datosCargados As Boolean = cargarDatosSubarea()

        If datosCargados Then
            Dim mensajeValidacion As String = validarEntradasSubarea()
            If mensajeValidacion = "" Then enviarDatosSubareaDatanase() Else mostrarMensaje(mensajeValidacion)
        End If
    End Sub

    Private Function cargarDatosSubarea()
        Try
            Dim nombreSubarea As String
            nombreSubarea = txtSubareaPanelSubarea.Text.Trim()

            nuevaSubarea.setArea(areaSeleccionadaPanelSubarea)
            nuevaSubarea.setNombre(nombreSubarea)

            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradasSubarea()
        Dim mensaje As String
        mensaje = registro.validarEntradasRegistrarSubarea(nuevaSubarea)
        Return mensaje
    End Function

    Private Sub enviarDatosSubareaDatanase()
        Dim respuesta As Int16 = registro.insertSubarea(nuevaSubarea)

        If respuesta > 0 Then
            mostrarMensaje("El subarea se registró correctamente")
            reiniciarFormulario()
        ElseIf respuesta < 0 Then
            mostrarMensaje("Ocurrió un error al guardar el subarea")
        End If
    End Sub





    'METODOS INTERFAZ G2 ====================
    Private Sub poblarCboxAreaPanelSubarea()
        cboxAreaPanelSubarea.Items.Clear()

        For Each area As AreaLaboratorio In registro.areas
            cboxAreaPanelSubarea.Items.Add(area.getNombre())
        Next
    End Sub

    Private Sub mostrarHintAreaPanelsubarea()
        hintAreaPanelSubarea.Visible = True
    End Sub

    Private Sub ocultarHintAreaPanelsubarea()
        hintAreaPanelSubarea.Visible = False
    End Sub



    'METODOS INTERFAZ G4
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

    'EVENTOS G2
    Private Sub cboxAreaPanelSubarea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxAreaPanelSubarea.SelectionChangeCommitted
        Try
            seleccionarAreaPanelSubarea()
            ocultarHintAreaPanelsubarea()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarSubarea_Click(sender As Object, e As EventArgs) Handles btnRegistrarSubarea.Click
        Try
            enviarDatosSubarea()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


End Class

