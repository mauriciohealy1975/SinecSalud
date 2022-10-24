Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports NEGOCIO


Public Class FormIniciarSesion

    'ATRIBUTOS LÓGICOS
    Dim registro As InicioSesion

    'ATRIBUTOS LÓGICOS MODO FORMHIJO
    Private esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String



    'METODOS INICIO--
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        registro = New InicioSesion()

        'ATRIBUTOS G0
        tituloFormulario = "Iniciar sesión"
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

        'lblTituloPrincipal.Enabled = True
        'lblTituloPrincipal.Visible = True
        'lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        'lblTituloPrincipal.Text = tituloFormulario.ToUpper

        'If esFormHijo Then MenuStrip.Enabled = False
        'If Not esFormHijo Then MenuStrip.Enabled = True
    End Sub

    Private Sub iniciarInterfazGrupo1()
        txtUsuario.Enabled = True
        txtUsuario.Visible = True
        txtUsuario.Font = New Font("Microsoft Sans Serif", 9)
        txtUsuario.Text = ""
        txtUsuario.CharacterCasing = CharacterCasing.Upper

        txtContrasenha.Enabled = True
        txtContrasenha.Visible = True
        txtContrasenha.Font = New Font("Microsoft Sans Serif", 9)
        txtContrasenha.Text = ""
        txtContrasenha.PasswordChar = "*"


        btnIngresar.Enabled = True
        btnIngresar.Visible = True
        btnIngresar.Font = New Font("Microsoft Sans Serif", 9)

        btnCambiarContrasenha.Enabled = True
        btnCambiarContrasenha.Visible = True
        btnCambiarContrasenha.Font = New Font("Microsoft Sans Serif", 9)
    End Sub

    Private Sub establecerDisplay()
        '    Dim ejeX As Short, ejeY As Short
        '    ejeX = Utilitarios.resolucionEstandarEjeX
        '    ejeY = Utilitarios.resolucionEstandarEjeY

        '    Size = New Size(ejeX, ejeY)
        '    MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        '    MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        MaximizeBox = False
        MinimizeBox = False

        Me.CenterToScreen()
    End Sub

    'METODOS INTERFAZ G1
    Private Sub enfocarTxtContrasenha()
        txtContrasenha.Focus()
    End Sub

    Private Sub presionarBtnIngresar()
        btnIngresar_Click(Nothing, Nothing)
    End Sub

    Public Sub limpiarCampos()
        txtUsuario.Text = ""
        txtContrasenha.Text = ""
    End Sub



    'METODOS INTERFA G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub









    'EVENTOS G1
    Private Sub txtUsuario_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyUp
        Try
            If e.KeyValue = Keys.Enter Then enfocarTxtContrasenha()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub txtContrasenha_KeyUp(sender As Object, e As KeyEventArgs) Handles txtContrasenha.KeyUp
        Try
            If e.KeyValue = Keys.Enter Then presionarBtnIngresar()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'definiendo variables
        Dim usuario As String,
            contrasenha As String,
            encontrado As Boolean,
            TipoAcceso As Long
        'tipoUsuario As Integer

        encontrado = False

        Try
            usuario = txtUsuario.Text.Trim()
            contrasenha = txtContrasenha.Text.Trim()
            encontrado = registro.traerUsuario(usuario, contrasenha)


            If encontrado Then
                TipoAcceso = registro.VerificarAcceso(usuario, contrasenha)
                Select Case TipoAcceso
                    Case 1
                        FormMenuPrincipal.Show()
                        Me.Hide()
                    Case 2
                        'MessageBox.Show("estoy entrando")
                        FromMenuTriaje.Show()
                        Me.Hide()
                    Case 3
                        FormMenuMedicos.Show()
                        Me.Hide()
                    Case 4
                        FormMenuEnfermeria.Show()
                        Me.Hide()
                    Case 5
                        FormMenuAfiliacion.Show()
                        Me.Hide()
                    Case 6
                        FormMenuAfiliacion.Show()
                        Me.Hide()
                    Case 7
                        FormMenuFarmacia.Show()
                        Me.Hide()
                    Case 8
                        FormMenuFarmacia.Show()
                        Me.Hide()
                    Case Else
                        MsgBox("Chale llama a mantenimiento")
                End Select


            Else
                lblMensaje.Text = "Usuario o contraseña incorrectos."
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnCambiarContrasenha_Click(sender As Object, e As EventArgs) Handles btnCambiarContrasenha.Click
        'FormCambiarContrasenha.Show()
        'Me.Hide()
    End Sub


    'EVENTOS G9
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.[Exit]()
    End Sub





End Class





