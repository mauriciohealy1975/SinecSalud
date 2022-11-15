Imports NEGOCIO
Public Class FormMenuControlDeUsuario

    Private Sub FormMenuControlDeUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Public Sub iniciarFormulario()
        configurarDisplay()
    End Sub

    Private Sub configurarDisplay()
        Dim resEjeX As Int16 = 0
        Dim resEjeY As Int16 = 0

        resEjeX = Utilitarios.resolucionEstandarEjeX
        resEjeY = Utilitarios.resolucionEstandarEjeY

        Icon = New System.Drawing.Icon("icono.ico")

        Size = New Size(resEjeX, resEjeY)
        MaximumSize = New System.Drawing.Size(resEjeX, resEjeY)
        MinimumSize = New System.Drawing.Size(resEjeX, resEjeY)
    End Sub



    'EVENTOS
    Private Sub btnAdministrarUsuarios_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        FormRegistrarUsuario.Show()
        Me.Close()
    End Sub


    Private Sub btnAsignarTurno_Click(sender As Object, e As EventArgs) Handles btnAsignarTurno.Click
        FormAsignarTurno.Show()
        Me.Close()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FormMenuPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub btnReactivarUsuario_Click(sender As Object, e As EventArgs) Handles btnReactivarUsuario.Click
        ' Formreactivarusuario.show()
        ' Close()
        'falto realizar............
    End Sub

    Private Sub bntCDAsignarPOES_Click(sender As Object, e As EventArgs) Handles bntCDAsignarPOES.Click
        FormRegMedDiagnostico.Show()
        Close()
    End Sub
End Class