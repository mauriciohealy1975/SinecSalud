Imports NEGOCIO

Public Class FormRegistrarEjecucionServicio

    Private oRegEjecucion As RegistroEjecucionServicio = New RegistroEjecucionServicio()

    Private Sub FormRegistrarEjecucionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub





    'METODOS INICIO INTERFAZ
    Private Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
    End Sub

    Private Sub reiniciarFormulario()
        iniciarControles()
        oRegEjecucion = New RegistroEjecucionServicio()
    End Sub

    Private Sub configurarDisplay()
        Me.Size = New Size(1280, 600)
        Me.MinimumSize = New System.Drawing.Size(1280, 600)
    End Sub

    Private Sub iniciarControles()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()

        'oRegOrden = New RegistroOrdenAtencionEnfermeria()
    End Sub

    Private Sub iniciarControlesGrupo1()
        txtBuscarNombreAsegurado.Enabled = True
        txtBuscarNombreAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarNombreAsegurado.Text = ""
        txtBuscarNombreAsegurado.Visible = True

        cmboxOrdenMedica.Enabled = False
        cmboxOrdenMedica.Font = New Font("Microsoft Sans Serif", 9)
        cmboxOrdenMedica.Items.Clear()
        cmboxOrdenMedica.DropDownStyle = ComboBoxStyle.DropDown
        cmboxOrdenMedica.Text = "SELECCIONAR"

        cmboxOrdenMedica.Visible = True

        txtOrdenMedica.Enabled = False
        txtOrdenMedica.Font = New Font("Microsoft Sans Serif", 9)
        txtOrdenMedica.Text = ""
        txtOrdenMedica.Visible = False


        iniciarDgviewDetalles()
    End Sub

    Private Sub iniciarDgviewDetalles()
        dgvDetalles.Enabled = True
        dgvDetalles.Font = New Font("Microsoft Sans Serif", 9)

        'eliminar contenido de un dgv con binned data.
        Dim objDataTable As DataTable = CType(dgvDetalles.DataSource, DataTable)
        If objDataTable IsNot Nothing Then
            objDataTable.Clear()
        End If


        'dgvDetalles.EditMode = DataGridViewEditMode.EditOnEnter
        dgvDetalles.AllowUserToAddRows = False
        dgvDetalles.AllowUserToDeleteRows = False
        dgvDetalles.AllowUserToResizeRows = False
        dgvDetalles.AllowUserToOrderColumns = False
        dgvDetalles.AllowUserToResizeColumns = False
        dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetalles.MultiSelect = False
        dgvDetalles.ReadOnly = True

        dgvDetalles.BackgroundColor = Color.FromArgb(215, 215, 215)
        dgvDetalles.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        'dgvDetalles.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 255)
        'dgvDetalles.DefaultCellStyle.SelectionForeColor = Color.Black

        dgvDetalles.EnableHeadersVisualStyles = False
    End Sub

    Private Sub configurarAnchoDgv()
        'la suma de los valores de weight pueden ser mayor a 100%
        dgvDetalles.Columns("Nro").FillWeight = 5
        dgvDetalles.Columns("Servicio").FillWeight = 30
        dgvDetalles.Columns("Cesiones").FillWeight = 10
        dgvDetalles.Columns("Descripcion").FillWeight = 50
    End Sub

    Private Sub bloquearSortEnColumnas()
        For i = 0 To dgvDetalles.Columns.Count - 1
            dgvDetalles.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
    End Sub

    Private Sub iniciarControlesGrupo2()
        txtServicioSeleccionado.Enabled = False
        txtServicioSeleccionado.Font = New Font("Microsoft Sans Serif", 9)
        txtServicioSeleccionado.Text = ""
        txtServicioSeleccionado.Visible = True
        txtServicioSeleccionado.ReadOnly = True

        rboxDescripcion.Enabled = False
        rboxDescripcion.Font = New Font("Microsoft Sans Serif", 9)
        rboxDescripcion.Text = ""
        rboxDescripcion.Visible = True

        numberCesion.Enabled = False
        numberCesion.Font = New Font("Microsoft Sans Serif", 9)
        numberCesion.Value = 0
        numberCesion.Visible = True

        datePickerFecha.Enabled = False
        datePickerFecha.Font = New Font("Microsoft Sans Serif", 9)
        datePickerFecha.Value = Utilitarios.obtenerFechaActual()
        datePickerFecha.MinDate = Utilitarios.obtenerFechaActual()
        datePickerFecha.MaxDate = Utilitarios.obtenerFechaActual()
        datePickerFecha.Visible = True

        guardar.Enabled = False
        guardar.Font = New Font("Microsoft Sans Serif", 9)
        guardar.Text = "Guardar Ejecución"
        guardar.Visible = True
    End Sub

    Private Sub habilitarCmboxOrdenMedica()
        cmboxOrdenMedica.Enabled = True
    End Sub





    'METODOS INTERFAZ
    Private Sub poblarCmboxOrdenes()
        For Each ordenAtencion As OrdenAtencionEnfermeria In oRegEjecucion.listaOrdenes
            If Not IsNothing(ordenAtencion) Then
                cmboxOrdenMedica.Items.Add(ordenAtencion.getDescripcion())
            End If
        Next

    End Sub

    Private Sub habilitarControlesGrupo2()
        txtServicioSeleccionado.Enabled = True
        numberCesion.Enabled = True
        datePickerFecha.Enabled = True
        rboxDescripcion.Enabled = True
        guardar.Enabled = True
    End Sub

    Private Sub ocultarColumnas()
        dgvDetalles.Columns("CODIGOORDEN").Visible = False
    End Sub

    Private Sub mostrarServicioSeleccionado()
        Dim nomServicio As String = ""
        For Each row As DataGridViewRow In dgvDetalles.SelectedRows
            nomServicio = row.Cells("SERVICIO").Value
        Next

        txtServicioSeleccionado.Text = nomServicio
    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje)
    End Sub







    'EVENTOS
    Private Sub btnBuscarOrden_Click(sender As Object, e As EventArgs) Handles btnBuscarOrden.Click
        cmboxOrdenMedica.Items.Clear()
        cmboxOrdenMedica.Text = "SELECCIONAR"
        Dim nombre As String = ""
        nombre = txtBuscarNombreAsegurado.Text.Trim()
        oRegEjecucion.traerOrdenesMedicas(nombre)
        poblarCmboxOrdenes()
        habilitarCmboxOrdenMedica()

        cmboxOrdenMedica.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub cmboxOrdenMedica_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxOrdenMedica.SelectionChangeCommitted
        Dim descripcion As String = ""
        descripcion = cmboxOrdenMedica.SelectedItem.ToString()
        oRegEjecucion.buscarOrden(descripcion)
        dgvDetalles.DataSource = oRegEjecucion.traerDetalles()
        configurarAnchoDgv()
        ocultarColumnas()
        bloquearSortEnColumnas()
        habilitarControlesGrupo2()
        mostrarServicioSeleccionado()
    End Sub

    Private Sub dgvDetalles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellClick
        mostrarServicioSeleccionado()
    End Sub

    Private Sub EjecutarGuardado()
        Dim descripcion As String = rboxDescripcion.Text.ToString.ToUpper()
        Dim fecha As String = Utilitarios.obtenerFechaActual()
        Dim nroCesion As Int16 = numberCesion.Value
        Dim nroOrden As Int16
        Dim nroDetalle As Int16
        For Each row As DataGridViewRow In dgvDetalles.SelectedRows
            nroOrden = row.Cells("CODIGOORDEN").Value
            nroDetalle = row.Cells("NRO").Value
        Next

        Dim respuesta As String = oRegEjecucion.validarEntradas(nroCesion)
        If respuesta = "" Then
            Dim oEjecucion As EjecucionServicioEnfermeria = New EjecucionServicioEnfermeria(descripcion, fecha, nroCesion)
            oEjecucion.setNroOrden(nroOrden)
            oEjecucion.setNroDetalle(nroDetalle)
            oRegEjecucion.oEjecucionServicio = oEjecucion
            oRegEjecucion.guardarEjecucion()
            reiniciarFormulario()
        Else
            mostrarMensaje(respuesta)
        End If
    End Sub


    Private Sub txtBuscarNombreAsegurado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscarNombreAsegurado.KeyDown
        If (e.KeyData = Keys.Enter) Then
            e.SuppressKeyPress = True
            SelectNextControl(ActiveControl, True, True, True, True)
        End If

    End Sub

    Private Sub numberCesion_KeyDown(sender As Object, e As KeyEventArgs) Handles numberCesion.KeyDown
        If (e.KeyData = Keys.Enter) Then
            e.SuppressKeyPress = True
            SelectNextControl(ActiveControl, True, True, True, True)
        End If

    End Sub

    Private Sub datePickerFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles datePickerFecha.KeyDown
        If (e.KeyData = Keys.Enter) Then
            e.SuppressKeyPress = True
            SelectNextControl(ActiveControl, True, True, True, True)
        End If

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        FormMenuMedicos.Show()
        Me.Close()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        EjecutarGuardado()
    End Sub
End Class

