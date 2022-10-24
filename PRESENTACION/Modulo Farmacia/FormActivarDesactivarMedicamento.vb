Public Class FormActivarDesactivarMedicamento
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)
    Private Sub FormActivarDesactivarMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub Inicializar()
        ConfiguracionVentana()
    End Sub
    Private Sub ConfiguracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub
    Private Function TraerInventario50()
        Try
            Dim liname As String = TxbBliname.Text.ToString().Trim()
            Dim tabla As DataTable = objetoFarmacia.TraerInventarioActivoDel50(liname)
            DgvDatos50.DataSource = tabla
            DgvDatos50.Columns(8).Visible = False
            DgvDatos50.Columns(0).Visible = False
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuFarmacia.Show()
        Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        TraerInventario50()
    End Sub
End Class