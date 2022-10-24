Imports NEGOCIO

Public Class FormCambiarContrasenha

    Private Sub FormCambiarContrasenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False

        txtContrasenhaActual.PasswordChar = "*"
        txtContrasenhaNueva.PasswordChar = "*"
    End Sub

    Private Sub btnCambiarContraseha_Click(sender As Object, e As EventArgs) Handles btnCambiarContraseha.Click
        Dim objCambioCon As CambioContrasenha = New CambioContrasenha()
        Dim usuario As String = txtUsername.Text.ToString()
        Dim contrasenhaActual As String = txtContrasenhaActual.Text.ToString()
        Dim contrasenNueva As String = txtContrasenhaNueva.Text.ToString()


        If objCambioCon.usuarioValido(usuario, contrasenhaActual) Then
            objCambioCon.actualizarContrasenha(usuario, contrasenNueva)
            MessageBox.Show("La contraseña se cambió correctamente")
            FormIniciarSesion.Show()
            Me.Close()
        Else
            lblMensaje.Text = "Usuario o contraseña actual incorrectos."
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormIniciarSesion.Show()
        Me.Close()
    End Sub


End Class