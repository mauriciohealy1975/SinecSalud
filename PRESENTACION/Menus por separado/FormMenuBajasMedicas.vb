Imports NEGOCIO

Public Class FormMenuBajasMedicas
    Dim objUsuario As Usuario = New Usuario()
    Dim NivelAcceso = Usuario.tipoUsuUserLoggedSystem



    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub FormMenuBajasMedicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarDatos()
        ConfigurarDisplay()

    End Sub

    Private Sub MenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormRegistrarBajaMedica.Show()
        Me.Close()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        If NivelAcceso = 1 Then
            FormMenuPrincipal.Show()
        Else
            FormMenuMedicos.Show()
        End If

        Me.Close()

    End Sub

    Private Sub ConfigurarDisplay()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub Cerrarsesion_Click(sender As Object, e As EventArgs) Handles Cerrarsesion.Click
        Me.Close()
        FormIniciarSesion.limpiarCampos()
        FormIniciarSesion.Show()
        FormIniciarSesion.txtUsuario.Focus()
        Usuario.limpiarDatos()
    End Sub
End Class