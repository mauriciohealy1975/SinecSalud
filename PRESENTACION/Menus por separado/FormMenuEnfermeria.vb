Imports NEGOCIO

Public Class FormMenuEnfermeria
    Dim objUsuario As Usuario = New Usuario()
    Dim NivelAcceso = Usuario.tipoUsuUserLoggedSystem

    Private Sub FormMenuEnfermeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnInyectables_Click(sender As Object, e As EventArgs) Handles btnInyectables.Click
        FormRegistrarAtencionInyectables.Show()
        Me.Close()
    End Sub

    Private Sub btnEjecucionServicio_Click(sender As Object, e As EventArgs) Handles btnEjecucionServicio.Click
        FormRegistrarEjecucionServicio.Show()
        Me.Close()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FormMenuPrincipal.Show()
        Me.Close()

    End Sub
    Private Sub ocutarMenuVolver()
        If NivelAcceso = 1 Then
            BtnVolver.Visible = True
        Else
            BtnVolver.Visible = False
        End If
    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
        Me.Close()
        FormIniciarSesion.limpiarCampos()
        FormIniciarSesion.Show()
        FormIniciarSesion.txtUsuario.Focus()
        Usuario.limpiarDatos()
    End Sub
End Class