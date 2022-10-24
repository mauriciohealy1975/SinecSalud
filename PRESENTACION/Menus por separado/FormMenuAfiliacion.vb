Imports NEGOCIO

Public Class FormMenuAfiliacion

    Dim NivelAcceso = Usuario.tipoUsuUserLoggedSystem
    Private Sub VerificarNivel()
        If NivelAcceso = 1 Then
            BtnVolver.Visible = True
        Else
            BtnVolver.Visible = False
            btnBajaPorEmpresa.Enabled = False
            btnBajaPorEmpresa.Visible = False
            btnRegistrarBaja.Visible = False
            btnRegistrarBaja.Enabled = False

            If NivelAcceso = 9 Then
                btnBajaPorEmpresa.Enabled = True
                btnBajaPorEmpresa.Visible = True
                btnRegistrarBaja.Visible = True
                btnRegistrarBaja.Enabled = True
            End If
        End If

    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub FormMenuAfiliacion_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        VerificarNivel()
        RellenarDatos()
        configuracionVentana()

    End Sub
    Private Sub configuracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

#Region "Botones"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnActualizarAsegurado.Click
        FormActualizarAsegurado.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistrarTitular_Click(sender As Object, e As EventArgs) Handles btnRegistrarAfiliacion.Click
        FormRegistrarTitular.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistrarBaja_Click(sender As Object, e As EventArgs) Handles btnRegistrarBaja.Click
        FormRegistrarBaja.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistrarReingreso_Click(sender As Object, e As EventArgs) Handles btnRegistrarReingreso.Click
        FormRegistrarReingreso.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistrarBeneficiario_Click(sender As Object, e As EventArgs) Handles btnRegistrarBeneficiario.Click
        FormRegistrarBeneficiario.Show()
        Me.Close()
    End Sub


    Private Sub btnControlPrestaciones_Click(sender As Object, e As EventArgs) Handles btnControlPrestaciones.Click
        FormAsignarControlPrestaciones.Show()
        Me.Close()
    End Sub

    Private Sub btnBajaPorEmpresa_Click(sender As Object, e As EventArgs) Handles btnBajaPorEmpresa.Click
        FormRegistrarBajaPorEmpresa.Show()
        Me.Close()
    End Sub


    Private Sub btnProcesarAvisos_Click(sender As Object, e As EventArgs) Handles btnProcesarAvisos.Click
        FormProcesarAvisosAsignacionesFamiliares.Show()
        Me.Close()
    End Sub


    Private Sub btnExamenPreocupacional_Click(sender As Object, e As EventArgs) Handles btnExamenPreocupacional.Click
        FormRegistrarProgramacionExamenPreocupacional.Show()
        Me.Close()
    End Sub


    Private Sub btnProcesarProgramacionExamenPreocupacional_Click(sender As Object, e As EventArgs) Handles btnProcesarProgramacionExamenPreocupacional.Click
        FormProcesarProgramacionEP.Show()
        Me.Close()
    End Sub

    Private Sub btnReporteExamenPreocupacional_Click(sender As Object, e As EventArgs) Handles btnReporteExamenPreocupacional.Click
        Dim formReporteEP As FormReporteProgrmacionExamenPreocupacional
        formReporteEP = New FormReporteProgrmacionExamenPreocupacional(False)

        formReporteEP.Show()
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
#End Region
End Class

