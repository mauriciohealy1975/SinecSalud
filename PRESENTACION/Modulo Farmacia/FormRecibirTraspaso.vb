Imports NEGOCIO

Public Class FormRecibirTraspaso
#Region "Declaraciones"
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)
    Public codTraspaso As FormDetalleTraspaso
    Dim fase1 As Boolean = False

#End Region
#Region "principales"
    Private Sub FormRecibirTraspasovb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Inicializar()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub
    Private Sub Inicializar()
        RellenarDatos()
        configuracionVentana()
        RellenarCBAlmacenes()
        RellenarListaDeEspera()
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub configuracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub
#End Region
#Region "Funciones"
    Private Sub RellenarCBAlmacenes()
        Dim Tabla As DataTable = objetoFarmacia.TraerAlmacenes()
        CbAlmacenes.DataSource = Tabla
        CbAlmacenes.DisplayMember = "Almacen"
        CbAlmacenes.ValueMember = "CodAlmacen"
        fase1 = True
    End Sub
    Private Function RellenarListaDeEspera()
        Try
            Dim Al As String = CbAlmacenes.SelectedValue.ToString()
            Dim Tabla As DataTable = objetoFarmacia.ObtenerListaDeTraspasosEnEspera(Al)
            DgvListaRececpcionEspera.DataSource = Tabla
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region
#Region "botones"
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuFarmacia.Show()
        Close()
    End Sub

    Private Sub CbAlmacenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAlmacenes.SelectedIndexChanged
        RellenarListaDeEspera()
    End Sub

    Private Sub DgvListaRececpcionEspera_DoubleClick(sender As Object, e As EventArgs) Handles DgvListaRececpcionEspera.DoubleClick
        Try
            'doble clic para obtener la lista del menu
            Dim FilaSeleccionada As DataGridViewRow = DgvListaRececpcionEspera.CurrentRow
            Dim valor As Integer = Val(FilaSeleccionada.Index)
            If DgvListaRececpcionEspera.RowCount - 1 > 0 Then
                Dim CT As String = Convert.ToDouble(DgvListaRececpcionEspera.Rows(valor).Cells("CodTransferencia").Value)
                Dim CR As String = Convert.ToDouble(DgvListaRececpcionEspera.Rows(valor).Cells("CodReceptor").Value)
                Dim CE As String = Convert.ToDouble(DgvListaRececpcionEspera.Rows(valor).Cells("CodEmisor").Value)
                codTraspaso = New FormDetalleTraspaso
                codTraspaso.setcodTraspaso(CT)
                codTraspaso.SetCodEmisor(CE)
                codTraspaso.SetCodReceptor(CR)
                codTraspaso.Show()
                Close()
            Else
                MessageBox.Show("Ese envio esta vacio")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub


#End Region


End Class