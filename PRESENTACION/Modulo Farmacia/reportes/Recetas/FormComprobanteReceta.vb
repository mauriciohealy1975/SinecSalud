Public Class FormComprobanteReceta
    Public id As Integer
    Public CODREC As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConfiguracionVentana()
        Dim objReporte As New SubReporte
        objReporte.SetParameterValue("@id", id)
        objReporte.SetParameterValue("@idReceta", id)
        objReporte.SetParameterValue("@receta", CODREC)

        CrystalReportViewer1.ReportSource = objReporte
    End Sub
    Private Sub ConfiguracionVentana()
        Icon = New System.Drawing.Icon("icono.ico")
    End Sub
    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        FormMenuFarmacia.Show()
        Close()
    End Sub

End Class