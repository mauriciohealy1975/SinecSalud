Imports NEGOCIO

Public Class FormRegistrarUnidadMedidaLaboratorio

    'ATRIBUTOS LÓGICOS
    Private registro As RegistroUnidadMedidaLaboratorio
    Public Property estadoInsercion As Short


    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private nuevaUnidad As UnidadMedidaLaboratorio

    'ATRIBUTOS G9


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormRegistrarUnidadMedidaLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarControlesInterfaz()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroUnidadMedidaLaboratorio()

        'ATRIBUTOS G0
        tituloFormulario = "Registrar unidad de medida"

        'ATRIBUTOS G1
        nuevaUnidad = New UnidadMedidaLaboratorio()

        'ATRIBUTOS G9
        estadoInsercion = 0
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarControlesInterfaz()
        iniciarControlesInterfazGrupo0()
        iniciarControlesInterfazGrupo1()
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
        txtNombre.Enabled = True
        txtNombre.Visible = True
        txtNombre.Font = New Font("Microsoft Sans Serif", 9)
        txtNombre.Text = ""
        txtNombre.CharacterCasing = CharacterCasing.Upper

        txtAbreviatura.Enabled = True
        txtAbreviatura.Visible = True
        txtAbreviatura.Font = New Font("Microsoft Sans Serif", 9)
        txtAbreviatura.Text = ""
        'txtAbreviatura.CharacterCasing = CharacterCasing.Upper


        btnRegistrarUnidad.Enabled = True
        btnRegistrarUnidad.Visible = True
        btnRegistrarUnidad.Font = New Font("Microsoft Sans Serif", 9)
    End Sub

    Private Sub establecerDisplay()
        Dim ejeX As Short, ejeY As Short
        'ejeX = Utilitarios.resolucionEstandarEjeX
        'ejeY = Utilitarios.resolucionEstandarEjeY

        ejeX = 500
        ejeY = 300


        Size = New Size(ejeX, ejeY)
        MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub



    'MÉTODOS LÓGICOS G4
    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub


    'MÉTODOS LÓGICOS G4 REGISTRAR SUBAREA
    Private Sub enviarDatosUnidad()
        Dim datosCargados As Boolean = cargarDatosUnidad()

        If datosCargados Then
            Dim mensajeValidacion As String = validarEntradasUnidad()
            If mensajeValidacion = "" Then enviarDatosUnidadDatanase() Else mostrarMensaje(mensajeValidacion)
        End If
    End Sub

    Private Function cargarDatosUnidad()
        Try
            Dim nombre As String, abreviatura As String

            nombre = txtNombre.Text.Trim()
            abreviatura = txtAbreviatura.Text.Trim()

            nuevaUnidad.setNombre(nombre)
            nuevaUnidad.setabreviacion(abreviatura)

            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradasUnidad()
        Dim mensaje As String
        mensaje = registro.validarEntradasRegistrarUnidad(nuevaUnidad)
        Return mensaje
    End Function

    Private Sub enviarDatosUnidadDatanase()
        Dim respuesta As Int16 = registro.insertUnidad(nuevaUnidad)
        estadoInsercion = respuesta

        If respuesta > 0 Then
            mostrarMensaje("La unidad se registró correctamente.")
            Me.Close()

        ElseIf respuesta < 0 Then
            mostrarMensaje("Ocurrió un error al guardar la unidad.")
        End If
    End Sub


    'METODOS INTERFAZ G4
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub

    Private Sub btnRegistrarUnidad_Click(sender As Object, e As EventArgs) Handles btnRegistrarUnidad.Click
        Try
            enviarDatosUnidad()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub
End Class