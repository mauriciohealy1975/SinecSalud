Imports NEGOCIO
Public Class FormIniciarSesionEliminarSolMed

    Dim obInicioSesionElim As InicioSesionEliminacion = New InicioSesionEliminacion()

    Private Sub FormIniciarSesionEliminarSolMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    'METODOS CLICK
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim respuesta As Boolean
        respuesta = obInicioSesionElim.encontrarUsuario(txtUsername.Text.ToString(), txtContrasenha.Text.ToString())

        If respuesta Then
            FormEliminarSolMed.Show()
            Me.Close()
        Else
            lblMensaje.Text = "Datos incorrectos o usuario inbabilitado para usar esta función."
        End If

    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FromMenuTriaje.Show()
        Me.Close()
    End Sub


End Class