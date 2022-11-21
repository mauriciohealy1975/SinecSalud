Imports NEGOCIO

Public Class FormMenuMedicos
#Region "axuliares"
    Private matricula, codsolicitud, paciente As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        matricula = ""
        codsolicitud = ""
        paciente = ""
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub SetMatricula(_Mat)
        matricula = _Mat
    End Sub
    Public Sub SetCodSolicitud(_sol)
        codsolicitud = _sol
    End Sub
    Public Sub SetPaciente(_paciente)
        paciente = _paciente
    End Sub
#End Region
    Dim NivelAcceso = Usuario.tipoUsuUserLoggedSystem

    Private Sub FormMenuMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarDatos()
        VerificarNivel()
    End Sub
    Private Sub VerificarNivel()
        If NivelAcceso = 1 Then
            BtnVolver.Visible = True
        Else
            BtnVolver.Visible = False
        End If
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub

    Private Sub btnTransfernciaMedica_Click(sender As Object, e As EventArgs) Handles btnTransfernciaMedica.Click
        FormRegistrarTransferenciaMed.Show()
        Me.Close()
    End Sub



    Private Sub btnOrdenServiciosEnfemeria_Click(sender As Object, e As EventArgs) Handles btnOrdenServiciosEnfemeria.Click
        FormRegistrarOrdenAtencionServiciosEnfermeria.Show()
        Me.Close()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FormMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
        Me.Close()
        FormIniciarSesion.limpiarCampos()
        FormIniciarSesion.Show()
        FormIniciarSesion.txtUsuario.Focus()
        Usuario.limpiarDatos()
    End Sub

    Private Sub BtnBM_Click(sender As Object, e As EventArgs) Handles BtnBM.Click
        FormMenuBajasMedicas.Show()
        Me.Close()
    End Sub

    Private Sub BtnRecetas_Click(sender As Object, e As EventArgs) Handles BtnRecetas.Click
        FormRecetas.Show()
        Close()
    End Sub
End Class