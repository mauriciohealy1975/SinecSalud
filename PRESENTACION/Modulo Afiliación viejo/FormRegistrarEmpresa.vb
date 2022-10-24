Imports NEGOCIO
Public Class FormRegistrarEmpresa




    'METODOS INICIO
    Private Sub FormRegistrarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Private Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
    End Sub

    Private Sub configurarDisplay()
        Dim ejeX As Int16 = Utilitarios.resolucionEstandarEjeX
        Dim ejeY As Int16 = Utilitarios.resolucionEstandarEjeY

        Size = New Size(ejeX, ejeY)
        MaximumSize = New System.Drawing.Size(ejeX, ejeY)
        MinimumSize = New System.Drawing.Size(ejeX, ejeY)
    End Sub

    Private Sub iniciarControles()

    End Sub


    'EVENTOS
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

    End Sub





End Class