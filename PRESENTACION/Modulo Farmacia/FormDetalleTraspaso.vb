Imports NEGOCIO

Public Class FormDetalleTraspaso
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)
    Private codTraspaso, codEmisor, codReceptor As String
#Region "experiencia Auxiliar"

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        codTraspaso = 0
        codEmisor = 0
        codReceptor = 0

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub setcodTraspaso(ByVal _codTraspaso)
        codTraspaso = _codTraspaso
    End Sub
    Public Function getcodTraspaso()
        Return codTraspaso
    End Function
    Public Sub SetCodEmisor(ByVal _codEmisor)
        codEmisor = _codEmisor
    End Sub
    Public Function GetCodEmisor()
        Return codEmisor
    End Function
    Public Sub SetCodReceptor(ByVal _codReceptor)
        codReceptor = _codReceptor
    End Sub
    Public Function GetcodReceptor()
        Return codReceptor
    End Function
#End Region


    Private Sub FormDetalleTraspaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()

    End Sub
#Region "funciones"
    Private Sub Inicializar()
        RellenarDatos()
        configuracionVentana()
        RellenarDGV()
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub configuracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub
    Private Sub RellenarDGV()
        Try
            Dim CodigoTraspaso = codTraspaso
            Dim Tabla As DataTable = objetoFarmacia.ObtenerDetalleDelTraspaso(CodigoTraspaso)
            DvgDetalleTraspaso.DataSource = Tabla
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub
    Private Sub Recibido_Cancelado(_estadoT As String, _estadoI As String, _almacen As String)

        Try
            Dim CodigoTraspaso = codTraspaso
            Dim Observacion = TxbObservaciones.Text
            Dim CodUsuario = Usuario.codUserLoggedSystem.ToString()
            Dim siguiente As Boolean = objetoFarmacia.ActualizarTablaDeTraspasos(CodigoTraspaso, _estadoT, Observacion, CodUsuario) 'funca
            If (siguiente) Then
                For X As Integer = 0 To DvgDetalleTraspaso.Rows.Count - 2
                    Dim Id As String = Convert.ToString(DvgDetalleTraspaso.Rows(X).Cells("ID").Value)
                    objetoFarmacia.ActualizarestadoDEldetalle(Id, _estadoI, _estadoT, _almacen)
                Next
            End If


        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try


    End Sub

#End Region
#Region "Botones"
    Private Sub BtnVerLuego_Click(sender As Object, e As EventArgs) Handles BtnVerLuego.Click
        FormRecibirTraspaso.Show()
        Close()
    End Sub

    Private Sub BtnRecibir_Click(sender As Object, e As EventArgs) Handles BtnRecibir.Click
        Recibido_Cancelado(1, 1, codReceptor)
        FormRecibirTraspaso.Show()
        Close()

    End Sub

    Private Sub BtnCancelarRecepcion_Click(sender As Object, e As EventArgs) Handles BtnCancelarRecepcion.Click
        Recibido_Cancelado(6, 1, codEmisor)
        FormRecibirTraspaso.Show()
        Close()
    End Sub
#End Region
End Class