Imports NEGOCIO

Public Class FormRegistrarAtencionInyectables

    Dim oRegistroAteInyec As RegistroAtencionInyectables = New RegistroAtencionInyectables()


    Private Sub btnGuardarAtencion_Click(sender As Object, e As EventArgs) Handles btnGuardarAtencion.Click
        Dim oAtenInyectables As AtencionInyectables = New AtencionInyectables()
        oAtenInyectables.setCodigoMedicamento(txtCodigoMedicamento.Text.ToString.Trim())
        oAtenInyectables.setNombreMedicamento(txtNombreMedicamento.Text.ToString.Trim())
        oAtenInyectables.setDosis(txtDosis.Text.ToString.Trim())
        oAtenInyectables.setVia(txtVia.Text.ToString.Trim())
        oAtenInyectables.setActividadRealizada(txtActividadRealizada.Text.ToString.Trim())

        oRegistroAteInyec.oAtenInyectables = oAtenInyectables
        oRegistroAteInyec.guardarAtencion()
    End Sub



    Private Sub rbuttonSiReacionAdversa_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonSiReacionAdversa.CheckedChanged
        oRegistroAteInyec.oAtenInyectables.setReaccionAdversa("SI")
    End Sub

    Private Sub rbuttonNoReacionAdversa_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonNoReacionAdversa.CheckedChanged
        oRegistroAteInyec.oAtenInyectables.setReaccionAdversa("NO")
    End Sub

    Private Sub rbuttonPositivoPps_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonPositivoPps.CheckedChanged
        oRegistroAteInyec.oAtenInyectables.setPPS("POSITIVO")
    End Sub

    Private Sub rbuttonNegativoPps_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonNegativoPps.CheckedChanged
        oRegistroAteInyec.oAtenInyectables.setPPS("NEGATIVO")
    End Sub


    Private Sub FormRegistroAtencionInyectables_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Restroceder_Click(sender As Object, e As EventArgs) Handles Restroceder.Click
        FormMenuEnfermeria.Show()
        Me.Close()
    End Sub
End Class