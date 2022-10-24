Imports NEGOCIO

Public Class FormMenuPrincipal
    Dim fechaActual As Date
    'METODS INICIO
    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
        cargarreloj()

    End Sub

    Private Sub iniciarFormulario()

        iniciarControles()
        fechaActual = FormatDateTime(Now, DateFormat.ShortDate)
        Fecha.Text = fechaActual
    End Sub

    Private Sub iniciarControles()
        iniciarControlesGrupo1()
    End Sub
    'actvamos los controles de menu principal, aqui se decide que se activara y que no.
    Private Sub iniciarControlesGrupo1()
        btnSolicitudesMedicas.Enabled = True
        btnMedicos.Enabled = True
        btnAfiliacion.Enabled = True
        btnBajaMedica.Enabled = True
        btnEnfermeria.Enabled = True
        btnLaboratorio.Enabled = True
        btnControlUsuario.Enabled = True
    End Sub

    Private Sub cargarreloj()
        Reloj.TopLevel = False
        Reloj.Show()
        Reloj.Opacity = 0.5

    End Sub




    'EVENTOS G1 derivaciones a diferentes menú
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSolicitudesMedicas.Click
        FromMenuTriaje.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMedicos.Click
        FormMenuMedicos.Show()
        Me.Close()
    End Sub

    Private Sub btnBajaMedica_Click(sender As Object, e As EventArgs) Handles btnBajaMedica.Click
        FormMenuBajasMedicas.Show()
        Me.Close()
    End Sub

    Private Sub btnAfiliacion_Click(sender As Object, e As EventArgs) Handles btnAfiliacion.Click
        FormMenuAfiliacion.Show()
        Me.Close()
    End Sub

    Private Sub btnEnfermeria_Click(sender As Object, e As EventArgs) Handles btnEnfermeria.Click
        FormMenuEnfermeria.Show()
        Me.Close()
    End Sub

    Private Sub btnLaboratorio_Click(sender As Object, e As EventArgs) Handles btnLaboratorio.Click
        FormMenuLaboratorio.Show()
        Me.Close()
    End Sub

    Private Sub btnMenuControlUsuario_Click(sender As Object, e As EventArgs) Handles btnControlUsuario.Click
        FormMenuControlDeUsuario.Show()
        Me.Close()
    End Sub

    Private Sub BtnFarmacia_Click(sender As Object, e As EventArgs) Handles BtnFarmacia.Click
        FormMenuFarmacia.Show()
        Me.Close()
    End Sub


    Private Sub BtnRayosX_Click(sender As Object, e As EventArgs) Handles BtnRayosX.Click
        FormSolicitudRayosX.Show()
        Close()
    End Sub
End Class