Imports NEGOCIO

Public Class FormMenuFarmacia
#Region "DECLARACIONE"
    Dim objUsuario As Usuario = New Usuario()
    Dim NivelAcceso = Usuario.tipoUsuUserLoggedSystem
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)

#End Region
    Private Sub FormMenuFarmacia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configuracionVentana()
        RellenarDatos()
        VerificarNivel()
        verificarSiHayTraspasos()
    End Sub
#Region "Funciones "
    Private Sub configuracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
    Private Sub RellenarDatos()

        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub VerificarNivel()
        If NivelAcceso = 1 Then
            BtnVolver.Visible = True
        Else
            BtnVolver.Visible = False
        End If
    End Sub

    Private Sub verificarSiHayTraspasos()
        Dim Tabla As DataTable = objetoFarmacia.hayTraspasosPendiente()
        Dim row As DataRow = Nothing
        Dim cantidad As String
        If (Tabla.Rows.Count > 0) Then
            row = Tabla.Rows.Item(0)
            cantidad = Convert.ToString(row("Cant"))
            If cantidad > 0 Then
                LHay.Visible = True
                If cantidad > 1 Then
                    LHay.Text = "hay " + cantidad + " solicitudes pendientes"
                Else
                    LHay.Text = "hay " + cantidad + " solicitud pendiente"
                End If

                BtnRecepciones.Enabled = True
            Else
                LHay.Visible = False
                BtnRecepciones.Enabled = False
            End If

        End If
    End Sub
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FormMenuPrincipal.Show()
        Close()
    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
        Close()
        FormIniciarSesion.limpiarCampos()
        FormIniciarSesion.Show()
        FormIniciarSesion.txtUsuario.Focus()
        Usuario.limpiarDatos()
    End Sub

    Private Sub BtnConsultarInventario_Click(sender As Object, e As EventArgs) Handles BtnConsultarInventario.Click
        FormIngresarInventario.Show()
        Close()
    End Sub

    Private Sub BtnTraspasos_Click(sender As Object, e As EventArgs) Handles BtnTraspasos.Click
        FormTraspasos.Show()
        Close()
    End Sub

    Private Sub BtnRecepciones_Click(sender As Object, e As EventArgs) Handles BtnRecepciones.Click
        FormRecibirTraspaso.Show()
        Close()
    End Sub

    Private Sub BtnDespacho_Click(sender As Object, e As EventArgs) Handles BtnDespacho.Click
        FormDespachoRecetas.show()
        Close()
    End Sub

    Private Sub BtnActDesac_Click(sender As Object, e As EventArgs) Handles BtnActDesac.Click
        FormActivarDesactivarMedicamento.Show()
        Close()
    End Sub




#End Region
End Class