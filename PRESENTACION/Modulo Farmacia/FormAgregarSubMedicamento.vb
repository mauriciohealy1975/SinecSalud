Imports NEGOCIO

Public Class FormAgregarSubMedicamento
#Region "Declaraciones"
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)
    Public NuevoSubMedicamento As ConstructorDeSubProducto
    Public NuevoProveedor As ConstructorProveedor
    Dim EstadoB As Boolean = False


#End Region
#Region "Primario"
    Private Sub FormAgregarSubMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configuracionVentana()
        inicializar()
    End Sub
    Private Sub inicializar()
        RellenarDatos()
        rellenarCBLiname()
        RellenarTipoMedicamento()
        TxbNombreSubmedicamento.Enabled = False
        TxbNuevoProveedor.Visible = False
        BtnAgregarProveedor.Visible = False
        BtnAgregarProveedor.Enabled = False
        Label7.Visible = False
    End Sub
    Private Sub configuracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub

#End Region
#Region "Funciones"

    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub rellenarCBLiname()
        Dim nombre As String = TxbBuscar.Text.Trim()
        Dim Tabla As DataTable = objetoFarmacia.TraerLinameCompleto(nombre, "L")
        CbLiname.DataSource = Tabla
        CbLiname.DisplayMember = "Medicamento"
        CbLiname.ValueMember = "CodLiname"

    End Sub
    Private Sub RellenarProveedores()
        Try
            Dim Nombre As String = TbBuscarProveedor.Text.Trim()
            Dim CodLiname As String = CbLiname.SelectedValue.ToString().Trim()
            Dim Tabla As DataTable = objetoFarmacia.BuscarProveedorQueNoTengaMedicmanteoigualDelLiname(CodLiname, Nombre)
            CbProveedor.DataSource = Tabla
            CbProveedor.DisplayMember = "Proveedor"
            CbProveedor.ValueMember = "CodProveedor"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub RellenarTipoMedicamento()
        Try
            Dim CodTipo As String = TxbBuscarTipo.Text.Trim()
            Dim Tabla As DataTable = objetoFarmacia.TraerTipo(CodTipo)
            CbTipoMedicamento.DataSource = Tabla
            CbTipoMedicamento.DisplayMember = "descripcion"
            CbTipoMedicamento.ValueMember = "codigoTipo"
        Catch ex As Exception

        End Try
    End Sub
    Private Function CargarDatos()
        Try
            If ValidarFormulario() Then
                Dim Codliname, Nombre, Tipo, Proveedor, CodUsuario As String
                Dim finalizado As Boolean
                Codliname = CbLiname.SelectedValue.ToString().Trim()
                Nombre = TxbNombreSubmedicamento.Text.ToString().Trim()
                Tipo = CbTipoMedicamento.SelectedValue.ToString().Trim()
                Proveedor = CbProveedor.SelectedValue.ToString().Trim()
                CodUsuario = Usuario.codUserLoggedSystem.ToString().Trim()
                '--------------------------------------------------
                NuevoSubMedicamento = New ConstructorDeSubProducto()
                NuevoSubMedicamento.setcodLiname(Codliname)
                NuevoSubMedicamento.SetNombre(Nombre)
                NuevoSubMedicamento.SetTipo(Tipo)
                NuevoSubMedicamento.SetCodProveedor(Proveedor)
                NuevoSubMedicamento.SetCodUsuario(CodUsuario)
                finalizado = ValidarDatosCargados()
                Return finalizado
            Else
                Return False
            End If


        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function CargarDatosProv()
        Try
            If ValidarFormularioProv() Then
                Dim Nombre, Estado, CodUsuario As String
                Dim finalizado As Boolean
                Nombre = TxbNuevoProveedor.Text.ToString().Trim()
                Estado = 1
                CodUsuario = Usuario.codUserLoggedSystem.ToString().Trim()
                '--------------------------------------------------
                NuevoProveedor = New ConstructorProveedor()
                NuevoProveedor.SetNombre(Nombre)
                NuevoProveedor.SetEstado(Estado)
                NuevoProveedor.SetCoUsuaio(CodUsuario)
                finalizado = validarDatosCargadosProv()
                Return finalizado
            Else
                Return False
            End If


        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function EnviarDatos()
        Dim datosCargados As Boolean = CargarDatos()
        If datosCargados Then
            Dim Liname As String = NuevoSubMedicamento.getcodLiname
            Dim CodUsuario As String = NuevoSubMedicamento.GetCodUsuario
            Dim listo As Boolean = objetoFarmacia.GuardarNuevoSubMedicamento(NuevoSubMedicamento)
            Dim Valor As Int16 = objetoFarmacia.ActualizarEstadoMedicamentoLiname(Liname, CodUsuario)
            If listo Then
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If

    End Function
    Private Function EnviarNewProveedor()
        Dim datosCargados As Boolean = CargarDatosProv()
        If datosCargados Then
            Dim listo As Boolean = objetoFarmacia.GuardarProveedor(NuevoProveedor)
            If listo Then
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If

    End Function
#End Region
#Region "Eventos"
#Region "textChange"
    Private Sub TxbBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxbBuscar.TextChanged
        Try
            rellenarCBLiname()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TbBuscarProveedor_TextChanged(sender As Object, e As EventArgs) Handles TbBuscarProveedor.TextChanged
        Try
            RellenarProveedores()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CbLiname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbLiname.SelectedIndexChanged
        TxbNombreSubmedicamento.Text = CbLiname.Text.ToString()
        RellenarProveedores()

    End Sub
#End Region
#End Region
#Region "Validaciones"
    Private Function ValidarFormulario()
        Dim valor1, valor2, valor3 As Integer
        valor1 = 0
        valor2 = 0
        valor3 = 0
        If Len(TxbBuscar.Text) > 0 Then
            valor1 = -1
        End If

        If CbLiname.SelectedIndex > valor1 Then
            If (Len(TbBuscarProveedor.Text) > 0) Then
                valor2 = -1
            End If
            If CbProveedor.SelectedIndex > valor2 Then
                If (Len(TxbBuscarTipo.Text) > 0) Then
                    valor2 = -1
                End If
                If CbTipoMedicamento.SelectedIndex > valor3 Then
                    Return True
                Else
                    MessageBox.Show("Seleccione un Tipo     ")
                    Return False
                End If
            Else
                MessageBox.Show("Seleccione un Proveedor")
                Return False

            End If
        Else
            MessageBox.Show("Seleccione un Medicamento Liname")
            Return False
        End If
    End Function
    Private Function ValidarFormularioProv()
        If (Len(TxbNuevoProveedor.Text) > 5) Then
            Return True
        Else
            If (MsgBox("El Nombre es muy corto Esta seguro de continuar?", vbYesNo) = 6) Then
                Return True
            Else
                Return False
            End If
        End If

    End Function
    Private Function ValidarDatosCargados()
        Dim CodLiname, nombre, Tipo, CodProveedor, CodUsuario As String
        CodLiname = NuevoSubMedicamento.getcodLiname
        nombre = NuevoSubMedicamento.GetNombre
        Tipo = NuevoSubMedicamento.GetTipo
        CodProveedor = NuevoSubMedicamento.GetCodProveedor
        CodUsuario = NuevoSubMedicamento.GetCodUsuario

        If Not CodLiname = "" Then
            If Not nombre = "" Then
                If Not Tipo = 0 Then
                    If Not CodProveedor = 0 Then
                        If Not CodUsuario = 0 Then
                            Return True 'repuesta que todo correcto
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If
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
    Private Function validarDatosCargadosProv()
        Dim nombre, Estado, CodUsuario As String
        nombre = NuevoProveedor.GetNombre.ToString()
        Estado = NuevoProveedor.GetEstardo.ToString()
        CodUsuario = NuevoProveedor.GetCoUsuario.ToString()
        If Not nombre = "" Then
            If Not Estado = 0 Then
                If (Not CodUsuario = 0) Then
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
    Private Sub OcultarNewProveedor()
        If EstadoB Then
            TxbNuevoProveedor.Visible = False
            BtnAgregarProveedor.Visible = False
            BtnAgregarProveedor.Enabled = False
            Label7.Visible = False
            EstadoB = False
        Else
            Label7.Visible = True
            TxbNuevoProveedor.Visible = True
            BtnAgregarProveedor.Visible = True
            BtnAgregarProveedor.Enabled = True
            EstadoB = True
        End If
    End Sub

#End Region
#Region "Botones"
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If EnviarDatos() Then
            MessageBox.Show("Todo Perfecto")
        Else
            MessageBox.Show("Algo Salio mal ¿no?")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormIngresarInventario.Show()
        Me.Close()
    End Sub
    Private Sub BtnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles BtnActivaNewProveedor.Click
        OcultarNewProveedor()
    End Sub

    Private Sub BtnAgregarProveedor_Click_1(sender As Object, e As EventArgs) Handles BtnAgregarProveedor.Click
        If EnviarNewProveedor() Then
            MessageBox.Show("Registro Exitoso")
            OcultarNewProveedor()
            TxbNuevoProveedor.Text = ""

        Else
            MessageBox.Show("Algo sucedio en el registro")
        End If

    End Sub
#End Region

End Class


