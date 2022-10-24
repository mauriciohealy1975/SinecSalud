Imports NEGOCIO

Public Class FromNuevoInsumo
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)
    Dim insumos As ConstructorDeSubProducto
    Private Sub FromNuevoInsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub Inicializar()
        ConfiguracionVentana()
        RellenarDatos()
        RellenarCBLiname()
    End Sub
    Private Sub ConfiguracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub RellenarCBLiname()
        Dim nombre As String = TxbBuscar.Text.Trim()
        Dim Tabla As DataTable = objetoFarmacia.TraerLinameCompletoInsumo(nombre, "I")
        CbLiname.DataSource = Tabla
        CbLiname.DisplayMember = "Medicamento"
        CbLiname.ValueMember = "CodLiname"
    End Sub
    Private Sub guardar()
        Dim continuar As Boolean = DatosCargados()
        If continuar Then
            Dim completo = objetoFarmacia.GuardarNuevoInsumo(insumos)
            If completo Then
                MessageBox.Show("Producto guardado.")
            Else
                MessageBox.Show("ocuurio un problema.")
            End If
        Else
            MessageBox.Show("ocurrio algo al cargar los datos")
        End If

    End Sub

    Private Function DatosCargados() As Boolean
        Try
            Dim codUsuario, Nombre, Liname As String
            Liname = CbLiname.SelectedValue.ToString()
            Nombre = txbNombre.Text.ToString() + TxbEspecificacion.Text.ToString()
            codUsuario = Usuario.codUserLoggedSystem.ToString().Trim()

            insumos = New ConstructorDeSubProducto
            insumos.setcodLiname(Liname)
            insumos.SetNombre(Nombre)
            insumos.SetCodUsuario(codUsuario)
            Return True
        Catch ex As Exception
            MessageBox.Show(Err.Description)
            Return False
        End Try



    End Function
    Private Sub TxbBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxbBuscar.TextChanged
        RellenarCBLiname()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormIngresarInventario.Show()
        Close()
    End Sub

    Private Sub CbLiname_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbLiname.SelectedValueChanged
        txbNombre.Text = CbLiname.Text
        'MessageBox.Show(CbLiname.SelectedValue.ToString())
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        guardar()
    End Sub
End Class