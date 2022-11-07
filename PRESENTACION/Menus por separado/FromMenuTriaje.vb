Imports NEGOCIO

Public Class FromMenuTriaje
    'Declaracion de variables.

    Dim menuSolMed As MenuSolMedicas = New MenuSolMedicas()
    Dim NivelAcceso As Long

    Private Sub FromMenuUsuarioComun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LNombre.Text = Usuario.nameUserLoggedSystem.ToString()
        LTipo.Text = Usuario.NomTipoUserLoggedSystem.ToString()
        NivelAcceso = Usuario.tipoUsuUserLoggedSystem
        notificarProgramacionesSinConfirmar()

        ocutarMenuVolver()
    End Sub
    Private Sub ocutarMenuVolver()
        If NivelAcceso = 1 Then
            BtnMP.Visible = True
        Else
            BtnMP.Visible = False
        End If
    End Sub
    Private Sub notificarProgramacionesSinConfirmar()
        Dim mensaje As String = ""
        If menuSolMed.cantidadSolMedProg > 0 Then
            mensaje = "Existen " + "(" + menuSolMed.cantidadSolMedProg.ToString() + ")" + " solicitudes medicas aún sin confirmar."
            BtnRS.Enabled = False
        End If

        mostrarMensajeSolMedProg(mensaje)
    End Sub

    Private Sub mostrarMensajeSolMedProg(ByVal _mensaje As String)
        lAviso.Text = _mensaje
    End Sub

    'Acciones botones
    Private Sub BtnCerrarSession_Click(sender As Object, e As EventArgs) Handles BtnCerrarSession.Click
        Me.Close()
        FormIniciarSesion.limpiarCampos()
        FormIniciarSesion.Show()
        FormIniciarSesion.txtUsuario.Focus()
        Usuario.limpiarDatos()
    End Sub
    Private Sub BtnRS_Click(sender As Object, e As EventArgs) Handles BtnRS.Click
        FormRegistrarSolMed.Show()
        Me.Close()
    End Sub

    Private Sub BtnCS_Click(sender As Object, e As EventArgs) Handles BtnCS.Click
        FormConfirmarSolMed.Show()
        Me.Close()
    End Sub
    Private Sub BtnES_Click(sender As Object, e As EventArgs) Handles BtnES.Click
        FormIniciarSesionEliminarSolMed.Show()
        Me.Close()
    End Sub

    Private Sub BtnMP_Click(sender As Object, e As EventArgs) Handles BtnMP.Click
        FormMenuPrincipal.Show()
        'FormMenuGeneral.show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormReporteDeSolicitudes.Show()
        Close()
    End Sub
End Class