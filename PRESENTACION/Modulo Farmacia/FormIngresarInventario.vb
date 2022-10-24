Imports System.Runtime.Hosting
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Security.Cryptography
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports CrystalDecisions.[Shared].Json
Imports Microsoft.Win32
Imports NEGOCIO

Public Class FormIngresarInventario
#Region "inicializaciones"
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)
    Public NuevoInventario As ConstructorDeInventarioFarmaco
    Dim ultimoPrecio As String



#End Region
#Region "Principales"

    Private Sub FormFarmaciaIAñadirInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configuracionVentana()
        inicializar()
        CBProv.Enabled = False

    End Sub

    Private Sub configuracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False


    End Sub
    Private Sub inicializar()
        LlenarComboBoxLiname()
        LLenarDgvRegistros()
        LLenarComboBoxProveedor()
        RellenarDatos()
        rellenarEstado()
        rellenarArea()
        DataFechaVencimiento.MinDate = Today
    End Sub
#End Region
#Region "Eventos selecion"

    Private Sub CB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB1.SelectedIndexChanged
        LLenarComboBoxSubMedicamento()
        LCL.Text = CB1.SelectedValue.ToString().Trim()
    End Sub
    Private Sub CBProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProv.SelectedIndexChanged
        Try
            CbSm.Text = ""
            LLenarComboBoxSubMedicamentoporLab()
            LCL.Text = CB1.SelectedValue.ToString().Trim()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CbSm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbSm.SelectedIndexChanged
        Dim listo As Boolean
        listo = True
        If ValidarSubMedicamento() Then
            TxbPrecio.Text = TraerUltimoPrecio()
        End If

    End Sub

#End Region
#Region "Funciones"
    'funciones principales
    Private Function CargarObjetos()
        Try
            Dim codLiname, Submedicamento, cantidad, precio, codUsuario, Lote, CodBarra, fechaVencimento, Estado, Area As String
            Submedicamento = CbSm.SelectedValue.ToString().Trim()

            If CheckBBPL.Checked = True Then
                Dim linamevalor As String = traerLInameporSubProducto()
                If (linamevalor IsNot "0") Then
                    codLiname = linamevalor
                End If
            Else
                codLiname = CB1.SelectedValue.ToString().Trim()

            End If
            cantidad = TxbCant.Text.ToString().Trim()
            precio = TxbPrecio.Text.ToString().Trim()
            codUsuario = Usuario.codUserLoggedSystem.ToString().Trim()
            Lote = TxBLote.Text.Trim()
            CodBarra = "" + TxBcb.Text.ToString().Trim()
            fechaVencimento = DataFechaVencimiento.Value.ToString("dd/MM/yyyy").Trim()
            Estado = CBEstado.SelectedValue.ToString().Trim()
            Area = CBArea.SelectedValue.ToString().Trim()
            NuevoInventario = New ConstructorDeInventarioFarmaco()
            NuevoInventario.setcodLiname(codLiname)
            NuevoInventario.setSubmedicamento(Submedicamento)
            NuevoInventario.setcantidad(cantidad)
            NuevoInventario.setprecio(precio)
            NuevoInventario.setcodUsuario(codUsuario)
            NuevoInventario.setLote(Lote)
            NuevoInventario.setCodbarr(CodBarra)
            NuevoInventario.setfechaVencimento(fechaVencimento)
            NuevoInventario.setEstado(Estado)
            NuevoInventario.setArea(Area)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Private Function traerLInameporSubProducto()
        Dim Submedicamento, codliname As String
        If ValidarSubMedicamento() Then
            Submedicamento = CbSm.SelectedValue.ToString().Trim()
            Dim Tabla2 As DataTable = objetoFarmacia.TraeLinamePorCodSM(Submedicamento)
            Dim row As DataRow = Tabla2.Rows(Tabla2.Rows.Count - 1)
            codliname = CStr(row("CodLiname"))
            Return codliname
        Else
            Return 0
        End If

    End Function
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub LlenarComboBoxLiname()
        CB1.Text = ""
        Dim nombre As String = TBBuscar.Text.Trim()
        Dim tabla As DataTable
        If CheckBoxInsumo.Checked = False Then
            tabla = objetoFarmacia.BuscarMedPorLiname(nombre, "L")
        Else
            tabla = objetoFarmacia.BuscarMedPorLiname(nombre, "I")
        End If
        CB1.DataSource = Tabla
        CB1.DisplayMember = "Medicamento"
        CB1.ValueMember = "CodLiname"
        LCL.Text = "00000"

    End Sub
    Private Sub LLenarDgvRegistros()
        Dim Tabla As DataTable = objetoFarmacia.TraerTop20DB()
        DgvTTop20.DataSource = Tabla

    End Sub
    Private Sub LLenarComboBoxSubMedicamento()
        CbSm.Text = ""
        Dim liname As String
        liname = CB1.SelectedValue.ToString().Trim()
        Dim Tabla As DataTable = objetoFarmacia.TraerSubMedicaentos(liname)
        CbSm.DataSource = Tabla
        CbSm.DisplayMember = "Medicamento"
        CbSm.ValueMember = "CodSubMed"

    End Sub
    Private Sub LLenarComboBoxProveedor()
        Try
            Dim CodSM As String = TBBuscar.Text.Trim()
            Dim Tabla As DataTable = objetoFarmacia.TraerLaboratorios(CodSM)
            CBProv.DataSource = Tabla
            CBProv.DisplayMember = "Proveedor"
            CBProv.ValueMember = "CodProveedor"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LLenarComboBoxSubMedicamentoporLab()
        CbSm.Text = ""
        Dim CodLab As String
        CodLab = CBProv.SelectedValue.ToString().Trim()
        Dim Tabla As DataTable = objetoFarmacia.TraerSubMedPorproveedor(CodLab)
        CbSm.DataSource = Tabla
        CbSm.DisplayMember = "Medicamento"
        CbSm.ValueMember = "CodSubMed"
    End Sub
    Private Sub rellenarEstado()
        Dim Tabla As DataTable = objetoFarmacia.TraerEstado()
        CBEstado.DataSource = Tabla
        CBEstado.DisplayMember = "Descripcion"
        CBEstado.ValueMember = "CodEstado"
    End Sub
    Private Sub rellenarArea()
        Dim Tabla As DataTable = objetoFarmacia.TraerArea()
        CBArea.DataSource = Tabla
        CBArea.DisplayMember = "Descripcion"
        CBArea.ValueMember = "Descripcion"
    End Sub
    Private Function enviar()
        If varlidar() Then

            Dim datosCargados As Boolean = CargarObjetos()
            If datosCargados Then
                Dim listo As Boolean = objetoFarmacia.GuardarInventario(NuevoInventario)
                If listo Then
                    Return True
                Else
                    Return False
                End If

            Else
                Return False
            End If
        Else
            Return False
        End If


    End Function
    Private Sub LimpiarCampos()
        TBBuscar.Text = ""
        CbSm.Text = ""
        TxBLote.Text = ""
        TxBcb.Text = ""
        TxbCant.Text = ""
        TxbPrecio.Text = ""

    End Sub
    Private Function TraerUltimoPrecio()
        Try
            If ValidarSubMedicamento() Then
                Dim submedicamento, Liname As String
                Dim Precioliname As Decimal
                submedicamento = CbSm.SelectedValue.ToString().Trim()
                Liname = traerLInameporSubProducto()
                Precioliname = TraerPrecioLiname(Liname.ToString())
                Dim Tabla2 As DataTable = objetoFarmacia.TraerUltimoPrecio(submedicamento)
                If (Tabla2.Rows.Count > 0) Then
                    Dim row As DataRow = Tabla2.Rows(Tabla2.Rows.Count - 1)
                    ultimoPrecio = CStr(row("precio"))
                    Return ultimoPrecio
                Else
                    Return Precioliname
                End If

            End If
        Catch ex As Exception

        End Try

    End Function
    Private Function TraerPrecioLiname(_liname As String)

        Try
            Dim PrecioLiname As String
            Dim Tabla2 As DataTable = objetoFarmacia.TraerPrecioLinameDB(_liname)
            If (Tabla2.Rows.Count > 0) Then
                Dim row As DataRow = Tabla2.Rows(Tabla2.Rows.Count - 1)
                PrecioLiname = CStr(row("PrecioLiname"))
                Return PrecioLiname
            Else
                Return 0
            End If
        Catch ex As Exception

        End Try

    End Function
    Private Function PrecioEsMayor()
        Dim V As Double
        Dim codLiname As String
        Dim PrecioLiname, aumento, PrecioMax, PrecioActual As Decimal
        codLiname = traerLInameporSubProducto()
        PrecioLiname = TraerPrecioLiname(codLiname)
        If PrecioLiname < 10 Then
            V = 0.3
        Else
            V = 0.05
        End If
        aumento = PrecioLiname * V
        PrecioMax = PrecioLiname + aumento
        If Len(TxbPrecio.Text) > 0 Then
            PrecioActual = TxbPrecio.Text.ToString()
            If PrecioActual > PrecioMax Then
                Return True
            Else
                Return False
            End If
        Else
            MessageBox.Show("El campo de Canditad esta vacio")
            Return True
        End If
    End Function
    Private Function PrecioMinimo()
        If ValidarSubMedicamento() Then
            Dim ultimoprecio, aumento, _PrecioMinimo, PrecioAnterior As Decimal
            PrecioAnterior = TraerUltimoPrecio()
            Dim V As Double
            If PrecioAnterior < 10 Then
                V = 0.3
            Else
                V = 0.05
            End If
            If PrecioAnterior > 0 Then
                ultimoprecio = CDec(PrecioAnterior)
                aumento = CDec(ultimoprecio * V)
                _PrecioMinimo = (ultimoprecio - aumento)
                If _PrecioMinimo > 0 Then
                    Return _PrecioMinimo
                Else
                    Return 0
                End If

            Else
                Return 0
            End If
        End If

    End Function
    Private Function ValidarcambioPrecio()
        Dim PrecioAnterior As Decimal = TraerUltimoPrecio()
        Dim precioMin As Decimal = PrecioMinimo()
        Dim PrecioActual As Decimal = CDec(TxbPrecio.Text.ToString())
        If PrecioEsMayor() Then
            MessageBox.Show("El precio esta por encima del permitido")
            Return False
        Else
            If precioMin >= 0 Then
                If PrecioActual > precioMin Then
                    Return True
                Else
                    MessageBox.Show("El precio es Menor al permitido permitido")
                    Return False
                End If
            Else
                MessageBox.Show("El precio no puede ser negativo")
                Return False
            End If
        End If


    End Function


#End Region
#Region "validaciones"
    Private Function varlidar()
        Try
            Dim estado As Boolean = True
            If estado Then
                estado = ValidarCantidad()
                If estado Then
                    estado = ValidadCodBarras()
                    If estado Then
                        estado = ValidarSubMedicamento()
                    End If
                End If
            End If
            If CheckBoxInsumo.Checked = False Then ' si el check esta desactivado que valide eso
                estado = ValidarPrecio()
                If estado Then
                    estado = ValidarLote()
                    If estado Then
                        estado = ValidarFecha()
                    End If
                End If
            End If
            If estado = False Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

        End Try
    End Function
    Private Function ValidarCantidad()
        If (IsNumeric(TxbCant.Text)) Then
            Return True
        Else
            MessageBox.Show("La cantidad no es correcta.")
            Return False
        End If
    End Function
    Private Function ValidarPrecio()
        If (IsNumeric(TxbPrecio.Text)) Then

            If (ValidarcambioPrecio()) Then
                Return True
            Else
                Return False
            End If
        Else
            MessageBox.Show("Por favor, revisar el precio.")
            Return False
        End If
    End Function
    Private Function ValidadCodBarras()
        If Len(TxBcb.Text) <= 0 Then
            TxBcb.Text = 0
            Return True 'aqui se decide si deja o no que dejen vacio el campo de codigo de barras true= si false = no


        Else
            If IsNumeric(TxBcb.Text) Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    Private Function ValidarLote()
        If Len(TxBLote.Text) <= 0 Then
            MessageBox.Show("El Codigo de lote esta vacio")
            Return False
        Else
            Return True
        End If

    End Function
    Private Function ValidarFecha()
        Dim fechaVencimento As String = DataFechaVencimiento.Value.ToString("dd/MM/yyyy").Trim()
        Dim fechaActual As String = Date.Today
        If fechaActual = fechaVencimento Then
            MessageBox.Show("La fecha de vencimineto del producto es hoy?")
            DataFechaVencimiento.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Private Function ValidarSubMedicamento()
        If CbSm.SelectedIndex = -1 Then
            MessageBox.Show("El submedicamento no fue registrado")
            Return False
        Else
            Return True
        End If
    End Function

#End Region
#Region "eventoskeypress"
    Private Sub TxBcb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxBcb.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            TxBLote.Focus()
        End If
    End Sub

    Private Sub TxbCant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbCant.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            TxbPrecio.Focus()
        End If
    End Sub
    Private Sub TxbPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbPrecio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar.ToString = ","
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            CBArea.Focus()
        End If
    End Sub
    Private Sub TxBLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxBLote.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            DataFechaVencimiento.Focus()
        End If
    End Sub

    Private Sub DataFechaVencimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataFechaVencimiento.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            TxbCant.Focus()
        End If
    End Sub

    Private Sub CBArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBArea.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            CBEstado.Focus()
        End If
    End Sub

    Private Sub CBEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBEstado.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            BtnEnviar.Focus()
        End If
    End Sub


#End Region
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        Dim completo As Boolean = enviar()
        If completo Then

            LimpiarCampos()
            LLenarDgvRegistros()
            MessageBox.Show("Registro realizado.")
        Else
            TBBuscar.Focus()
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuFarmacia.Show()
        Me.Close()
    End Sub


    Private Sub TBBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBBuscar.TextChanged
        Try
            If CheckBBPL.Checked Then
                LLenarComboBoxProveedor()
            Else
                LlenarComboBoxLiname()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBBPL_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBBPL.CheckedChanged
        If CheckBBPL.Checked Then
            CBProv.Enabled = True
            CB1.Enabled = False
        Else
            CBProv.Enabled = False
            CB1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAgregarSubMedicamento.Show()
        Me.Close()

    End Sub

    Private Sub CheckBoxInsumo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxInsumo.CheckedChanged
        LlenarComboBoxLiname()
        If CheckBoxInsumo.Checked = True Then
            CheckBBPL.Enabled = False
        Else
            CheckBBPL.Enabled = True
        End If
    End Sub

    Private Sub BtnNuevoInsumo_Click(sender As Object, e As EventArgs) Handles BtnNuevoInsumo.Click
        FromNuevoInsumo.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormReporteInventarioGeneral.Show()
    End Sub
End Class
