Imports NEGOCIO

Public Class FormMenuMedicos
    'RESOL 1280, 600
    Dim objUsuario As Usuario = New Usuario()
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