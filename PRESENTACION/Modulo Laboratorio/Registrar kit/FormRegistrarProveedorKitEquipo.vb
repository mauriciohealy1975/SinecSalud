Imports NEGOCIO

Public Class FormRegistrarProveedorKitEquipo

    'ATRIBUTOS LÓGICOS
    Private registro As RegistroProveedorKitEquipo

    'ATRIBUTOS LÓGICOS MODO FORMHIJO
    Private esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G9
    Private nuevoProveedor As ProveedorKitEquipo



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

    Private Sub FormRegistrarProveedorKitEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        registro = New RegistroProveedorKitEquipo()

        'ATRIBUTOS G0
        tituloFormulario = "Registrar proveedor de kit-equipo"

        'ATRIBUTOS G9
        nuevoProveedor = New ProveedorKitEquipo()
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
        panelProveedor.Enabled = True
        panelProveedor.Visible = True

        txtProveedor.Enabled = True
        txtProveedor.Visible = True
        txtProveedor.Font = New Font("Microsoft Sans Serif", 9)
        txtProveedor.Text = ""
        txtProveedor.CharacterCasing = CharacterCasing.Upper

        btnEnviarDatos.Enabled = True
        btnEnviarDatos.Visible = True
        btnEnviarDatos.Font = New Font("Microsoft Sans Serif", 9)
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
    Private Sub enviarDatos()
        Dim datosCargados As Boolean = cargarDatos()

        If datosCargados Then
            Dim mensajeValidacion As String = validarEntradas()
            If mensajeValidacion = "" Then enviarDatosDatabase() Else mostrarMensaje(mensajeValidacion)
        End If

    End Sub

    Private Function cargarDatos()
        Try
            Dim nombreProveedor As String
            nombreProveedor = txtProveedor.Text.Trim()

            nuevoProveedor = New ProveedorKitEquipo()
            nuevoProveedor.setNombre(nombreProveedor)
            Return True


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(nuevoProveedor)
        Return mensaje
    End Function

    Private Sub enviarDatosDatabase()
        Dim mensajeInsercion As String, codigoInsercion As Short

        registro.insertarProveedor(nuevoProveedor)
        mensajeInsercion = registro.generarMensajeInsercion()
        codigoInsercion = registro.codigoInsercion

        If Not mensajeInsercion = "" Then
            mostrarMensaje(mensajeInsercion)
            If codigoInsercion > 0 Then reiniciarFormulario()
        End If
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub






    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub


    'EVENTOS G9
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim form As FormMenuLaboratorio

        form = New FormMenuLaboratorio()
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


End Class