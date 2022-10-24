Imports System.Security.Policy
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.[Shared].Json
Imports NEGOCIO

Public Class FormTraspasos
#Region "Declaraciones"
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)
    Public NuevoInventario As ConstructorDeInventarioFarmaco
    Public NuevaCabeza As ConstructorTraspaso
    Dim CodUsuario As String = Usuario.codUserLoggedSystem.ToString() 'codigo de usuario
    Dim CCDF As Boolean = True
    Dim Terminado As Boolean = False
    Dim PoximoCodigo = 0

#End Region
#Region "Principal"
    Private Sub FormTraspasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configuracionVentana()
        inicializar()
    End Sub
    Private Sub configuracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub
    Private Sub inicializar()
        RellenarDatos()
        RellenarOrigen()
        RellenarDestino()
        RellenarCBConInventario()
        ReiniciarFormulario()
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
#End Region
#Region "funciones"
    Private Sub RellenarOrigen()
        Dim Tabla As DataTable = objetoFarmacia.TraerAlmacenes()
        CbOrigen.DataSource = Tabla
        CbOrigen.DisplayMember = "Almacen"
        CbOrigen.ValueMember = "CodAlmacen"
        '-------------------------------------------------------------------------
    End Sub
    Private Sub RellenarDestino()
        Dim Tabla As DataTable = objetoFarmacia.TraerAlmacenes()
        CbDestino.DataSource = Tabla
        CbDestino.DisplayMember = "Almacen"
        CbDestino.ValueMember = "CodAlmacen"
        CCDF = False
    End Sub
    Private Sub RellenarCBConInventario()
        Dim Almacen As String = CbOrigen.SelectedValue.ToString()
        Dim nombre As String = TxbBuscarMed.Text.ToString().Trim()
        Dim Tabla As DataTable = objetoFarmacia.TraerInventario(Almacen, nombre)
        CbInventario.DataSource = Tabla
        CbInventario.DisplayMember = "Medicamento"
        CbInventario.ValueMember = "ID"
        Terminado = True
    End Sub
    Private Sub RellenarCampos()
        'crear procedimeinto almacenado para traer datos por id 
        Try
            If Terminado Then
                Dim Cid, CL, CSM, Precio, AlD, Sec, Lote, CB, FV As String
                Dim Id As String
                Id = CbInventario.SelectedValue().ToString()
                Dim AlmacenO As String = CbOrigen.SelectedValue.ToString()
                Dim Tabla As DataTable = objetoFarmacia.TraerInventarioPoriD(Id)
                Dim row As DataRow = Nothing
                Dim proximoValor As String = ObtenerPoximoRegistro() + 1
                Lproximo.Text = proximoValor
                If (Tabla.Rows.Count > 0) Then

                    row = Tabla.Rows.Item(0)
                    TxbCL.Text = Convert.ToString(row("CodLiname"))
                    TxbMP.Text = Convert.ToString(row("Medicamento"))
                    TxbDisp.Text = Convert.ToString(row("Disponibilidad"))

                    Cid = Id
                    CL = Convert.ToString(row("CodLiname"))
                    CSM = Convert.ToString(row("CodSM"))
                    Precio = Convert.ToString(row("Precio"))
                    AlD = CbDestino.SelectedValue().ToString()
                    Sec = Convert.ToString(row("Sector"))
                    Lote = Convert.ToString(row("Lote"))
                    CB = Convert.ToString(row("CB"))
                    FV = Convert.ToDateTime(row("Vencimiento"))

                    NuevoInventario = New ConstructorDeInventarioFarmaco()
                    NuevoInventario.SetId(Id)
                    NuevoInventario.setcodLiname(CL)
                    NuevoInventario.setSubmedicamento(CSM)
                    NuevoInventario.setprecio(Precio)
                    NuevoInventario.Setalmacen(AlD)
                    NuevoInventario.setLote(Lote)
                    NuevoInventario.setCodbarr(CB)
                    NuevoInventario.setfechaVencimento(FV)
                    NuevoInventario.setArea(Sec)
                    'MessageBox.Show("se cargo: liname=" + CL + "Medicamento=" + CSM + "precio=" + Precio + "almacen=" + AlD + "sec=" + Sec + "lote=" + Lote + "CB=" + CB + "FV=" + FV)
                Else
                    MessageBox.Show("No existen datos.")

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("El error es:" + ex.ToString())
        End Try
    End Sub
    Private Sub EnviarADgv()

        Dim ID, name, CL, CSM, Precio, AlD, CUsu, Sec, Lote, CB, Es, FV As String
        Dim Corigen As Integer = TxbDisp.Text
        Dim Cdestino As Integer = TxbCEnviar.Text
        Dim Cantidad As Integer
        Dim CR As Integer = Corigen - Cdestino
        ID = NuevoInventario.GetID()
        CL = NuevoInventario.getcodLiname()
        CSM = NuevoInventario.getSubmedicamento()
        name = CbInventario.Text.ToString().Trim()
        Precio = NuevoInventario.getprecio()
        AlD = NuevoInventario.GetAlmacen()
        Sec = NuevoInventario.getArea()
        Lote = NuevoInventario.getLote()
        CB = NuevoInventario.getCodBarra()
        CUsu = NuevoInventario.getcodUsuario()
        Es = 4
        FV = NuevoInventario.getfechaVencimento()
        Cantidad = TxbCEnviar.Text
        If Not ExisteDatoEnGrid(ID) Then
            DgvListaTraspasos.Rows.Add(ID, CL, CSM, name, Cantidad, Cantidad, Precio, AlD, CUsu, Sec, Lote, CB, Es, FV, CR)
        Else
            MessageBox.Show("El Medicamento ya pertenece está en este envio.")
        End If

    End Sub
    '---------------------------------------------------------------------------------------------------------------
    Private Function ObtenerPoximoRegistro()
        Try
            Dim Tabla As DataTable = objetoFarmacia.ObtenerCodigoDelUltimoRegistro()
            Dim row As DataRow = Nothing
            Dim UR As String
            If (Tabla.Rows.Count > 0) Then
                row = Tabla.Rows.Item(0)
                UR = Convert.ToString(row("UltimoRegistro"))
                If UR = "" Then
                    UR = 999999
                    Return UR
                Else
                    Return UR
                End If
            End If
        Catch ex As Exception

        End Try


    End Function
    Private Function RegistarNuevoTraspaso()
        Dim datosCargados As Boolean = CargarDatosCabeceraTraspaso()
        If datosCargados Then
            Dim listo As Boolean = objetoFarmacia.GuardarCabecera(NuevaCabeza)
            If listo Then
                If CargarListaYEnviar() Then
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
    Private Function CargarDatosCabeceraTraspaso()
        Dim ALO, ALD As Long
        ALO = CbOrigen.SelectedValue().ToString()
        ALD = CbDestino.SelectedValue().ToString()
        NuevaCabeza = New ConstructorTraspaso()
        NuevaCabeza.SetCodAlmEmisor(ALO)
        NuevaCabeza.SetCodAlmRecept(ALD)
        NuevaCabeza.SetUsuEmisor(CodUsuario)
        If ValidarCabeceraTraspaso() Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function CargarListaYEnviar()
        Dim CTactual = ObtenerPoximoRegistro()
        Dim correcto As Boolean
        Try
            For X As Integer = 0 To DgvListaTraspasos.Rows.Count - 2
                Dim Liname As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("CL").Value)
                Dim CSM As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("CSM").Value)
                Dim Cant As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("CantidadE").Value)
                Dim Precio As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("Precio").Value)
                Dim Almacen As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("Almacen").Value)
                Dim CodUsu As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("CodUsu").Value)
                Dim Area As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("Area").Value)
                Dim Lote As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("Lote").Value)
                Dim CB As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("CB").Value)
                Dim Estado As String = 4
                Dim FV As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("FechaVencimiento").Value)
                Dim CT As String = CTactual
                '------------------------------------------------------------------------------------------------
                Dim ID As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("ID").Value)
                Dim CR As String = Convert.ToString(DgvListaTraspasos.Rows(X).Cells("CR").Value)

                NuevoInventario = New ConstructorDeInventarioFarmaco
                NuevoInventario.setcodLiname(Liname)
                NuevoInventario.setSubmedicamento(CSM)
                NuevoInventario.setcantidad(Cant)
                NuevoInventario.setprecio(Precio)
                NuevoInventario.Setalmacen(Almacen)
                NuevoInventario.setcodUsuario(CodUsu)
                NuevoInventario.setArea(Area)
                NuevoInventario.setLote(Lote)
                NuevoInventario.setCodbarr(CB)
                NuevoInventario.setEstado(Estado)
                NuevoInventario.setfechaVencimento(FV)
                NuevoInventario.SetCT(CTactual)
                correcto = objetoFarmacia.actualizarCantidades(ID, CR)
                If CR = 0 Then
                    correcto = objetoFarmacia.actualizaraAgotado(ID)
                End If
                correcto = objetoFarmacia.InsertarInventarioTraspaso(NuevoInventario)

                If correcto = False Then
                    Return False
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString())
        End Try
        Return correcto
    End Function

    Private Sub ReiniciarFormulario()
        CPMed.Enabled = False
        CbInventario.SelectedIndex = -1
        CbDestino.Enabled = False
        CbOrigen.Enabled = True
        TxbBuscarMed.Text = ""
        TxbCEnviar.Text = "0"
        TxbCL.Text = ""
        TxbMP.Text = ""
        TxbDisp.Text = ""
        DgvListaTraspasos.Rows.Clear()
        Lproximo.Text = ObtenerPoximoRegistro() + 1
    End Sub
#End Region
#Region "Eventos"
    Private Sub DgvListaTraspasos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvListaTraspasos.CellMouseDoubleClick
        Try
            Dim FilaSeleccionada As DataGridViewRow = DgvListaTraspasos.CurrentRow
            Dim valor As Integer = Val(FilaSeleccionada.Index)
            If DgvListaTraspasos.RowCount - 1 > 0 Then
                DgvListaTraspasos.Rows.Remove(DgvListaTraspasos.Rows(valor))
            Else
                MessageBox.Show("La lista esta vacia no hay nada que eliminar")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error" + ex.ToString())
        End Try

    End Sub
    Private Sub CbOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbOrigen.SelectedIndexChanged
        Try
            If Not CCDF Then
                RellenarCBConInventario()
                CbDestino.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxbBuscarMed_TextChanged(sender As Object, e As EventArgs)
        RellenarCBConInventario()
    End Sub
    Private Sub CbInventario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbInventario.SelectedIndexChanged

        If Not CbInventario.SelectedIndex = -1 Then
            RellenarCampos()
        End If
    End Sub
#End Region
#Region "Validaciones"
    Private Function ValidarEnvio() As Boolean
        If Not TxbCEnviar.Text = "" And Not TxbCEnviar.Text = "0" Then
            If Not CbInventario.SelectedIndex = -1 Then
                Dim Corigen As Integer = TxbDisp.Text
                Dim Cdestino As Integer = TxbCEnviar.Text
                Dim Emisor As Integer = CbOrigen.SelectedValue.ToString()
                Dim receptor As Integer = CbDestino.SelectedValue.ToString()
                If Corigen >= Cdestino Then
                    If Not Emisor = receptor Then
                        Return True
                    Else
                        MessageBox.Show("El origen y destino no pueden ser los mismos")
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                MessageBox.Show("Seleccione item del inventario")
            End If
        Else
            MessageBox.Show("Verifique la cantidad")
            Return False
        End If
    End Function
    Private Function ExisteDatoEnGrid(id As Long) As Boolean
        Dim existe As Boolean = DgvListaTraspasos.Rows.Cast(Of DataGridViewRow).Any(Function(x) CInt(x.Cells("ID").Value) = id)

        If Not existe Then
            Return False
        Else
            Return True
        End If

    End Function
    Private Function ValidarCabeceraTraspaso()
        If Not NuevaCabeza.GetCodAlmEmisor = 0 Then
            If Not NuevaCabeza.GetCodAlmRecept = 0 Then
                If Not NuevaCabeza.GetUsuEmisor = 0 Then
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

#End Region
#Region "Botones"
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        Dim terminado As Boolean = RegistarNuevoTraspaso()

        If terminado Then
            ReiniciarFormulario()
            MessageBox.Show("Registrado Correctamente")
        Else
            MessageBox.Show("Registrado Fallido")
        End If
    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuFarmacia.Show()
        Me.Close()
    End Sub

    Private Sub CbDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDestino.SelectedIndexChanged
        If Not CCDF Then
            CPMed.Enabled = True
            CbDestino.Enabled = False
            CbOrigen.Enabled = False
        End If

    End Sub

    Private Sub BtnReiniciarForm_Click(sender As Object, e As EventArgs) Handles BtnReiniciarForm.Click
        ReiniciarFormulario()
    End Sub

    Private Sub BtnMandarAlDgv_Click_1(sender As Object, e As EventArgs) Handles BtnMandarAlDgv.Click
        Dim continuar As Boolean = ValidarEnvio()

        If continuar Then

            EnviarADgv()

        Else
            ' MessageBox.Show("Verifique la los datos")
        End If
    End Sub



#End Region
End Class