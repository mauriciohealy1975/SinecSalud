Imports NEGOCIO

Public Class FormRegistrarOrdenAtencionServiciosEnfermeria

    'RESOL 1280, 600
    Dim oRegOrden As RegistroOrdenAtencionEnfermeria

    Private Sub FormRegistroOrdenAtencionServiciosEnfermeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
        configurarDisplay()


    End Sub




    'METODOS INICIO INTERFAZ
    Public Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
        poblarListBoxServiciosEnfermeria()
    End Sub

    Private Sub configurarDisplay()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarControles()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()

        oRegOrden = New RegistroOrdenAtencionEnfermeria()
    End Sub

    Private Sub iniciarControlesGrupo1()
        txtAsegurado.Enabled = True
        txtAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtAsegurado.Text = ""
        txtAsegurado.ReadOnly = False

        txtMatriculaAsegurado.Enabled = True
        txtMatriculaAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtMatriculaAsegurado.Text = ""
        txtMatriculaAsegurado.ReadOnly = False

        txtEdad.Enabled = True
        txtEdad.Font = New Font("Microsoft Sans Serif", 9)
        txtEdad.Text = ""
        txtEdad.ReadOnly = False

        txtMedico.Enabled = True
        txtMedico.Font = New Font("Microsoft Sans Serif", 9)
        txtMedico.Text = ""
        txtMedico.ReadOnly = False

        'datePickerFecha.Enabled = False
        'datePickerFecha.Font = New Font("Microsoft Sans Serif", 9)
    End Sub

    Private Sub iniciarControlesGrupo2()
        lboxServicios.Enabled = True
        lboxServicios.Font = New Font("Microsoft Sans Serif", 9)
        lboxServicios.Items.Clear()

        btnCancelar.Enabled = True
        btnCancelar.Font = New Font("Microsoft Sans Serif", 9)
        btnCancelar.Text = "Cancelar"

        btnConfirmarServicios.Enabled = True
        btnConfirmarServicios.Font = New Font("Microsoft Sans Serif", 9)
        btnConfirmarServicios.Text = "Confimar Servicios"

        iniciarDgviewServicios()

        btnGuardarAtencion.Enabled = True
        btnGuardarAtencion.Font = New Font("Microsoft Sans Serif", 9)
        btnGuardarAtencion.Text = "Guardar Orden"
    End Sub

    Private Sub iniciarDgviewServicios()
        dgviewServiciosConfirmados.Enabled = True
        dgviewServiciosConfirmados.Columns.Clear()
        dgviewServiciosConfirmados.Rows.Clear()
        dgviewServiciosConfirmados.Font = New Font("Microsoft Sans Serif", 9)


        dgviewServiciosConfirmados.EditMode = DataGridViewEditMode.EditOnEnter
        dgviewServiciosConfirmados.AllowUserToAddRows = False
        dgviewServiciosConfirmados.AllowUserToDeleteRows = False
        dgviewServiciosConfirmados.AllowUserToResizeRows = False
        dgviewServiciosConfirmados.AllowUserToOrderColumns = False
        dgviewServiciosConfirmados.AllowUserToResizeColumns = False
        dgviewServiciosConfirmados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgviewServiciosConfirmados.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgviewServiciosConfirmados.MultiSelect = False
        dgviewServiciosConfirmados.ReadOnly = False


        dgviewServiciosConfirmados.BackgroundColor = Color.FromArgb(215, 215, 215)
        dgviewServiciosConfirmados.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        dgviewServiciosConfirmados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(166, 176, 255)
        dgviewServiciosConfirmados.DefaultCellStyle.SelectionForeColor = Color.Black


        dgviewServiciosConfirmados.EnableHeadersVisualStyles = False
    End Sub






    'METODOS INTERFAZ
    Private Sub poblarListBoxServiciosEnfermeria()
        oRegOrden.traerServiciosEnfermeria()

        For Each servicioEnfermeria As Concepto In oRegOrden.listaServiciosEnfermeria
            If Not IsNothing(servicioEnfermeria) Then
                lboxServicios.Items.Add(servicioEnfermeria.getDescripcion())
            End If
        Next

    End Sub

    Private Sub deseleccionarLboxServicios()
        lboxServicios.ClearSelected()
    End Sub

    Private Sub guardarServiciosSeleccionadas()
        Dim dimension As Int16 = lboxServicios.SelectedItems.Count
        oRegOrden.serviciosSeleccionadas = New Concepto(dimension - 1) {}

        Dim index As Int16 = 0
        For Each fila In lboxServicios.SelectedItems
            oRegOrden.serviciosSeleccionadas(index) = oRegOrden.buscarServicio(fila)
            index += 1
        Next

    End Sub

    Private Sub eliminarColumnasDgview()
        dgviewServiciosConfirmados.Columns.Clear()
    End Sub

    Private Sub iniciarColumnasObligatoriasDgview()
        dgviewServiciosConfirmados.Columns.Add("columnaServicio", "SERVICIO")
        dgviewServiciosConfirmados.Columns.Add("columnaDescripcion", "DESCRIPCIÓN")
        dgviewServiciosConfirmados.Columns.Add("columnaCantidad", "CANTIDAD")

        dgviewServiciosConfirmados.Columns("columnaServicio").[ReadOnly] = True
    End Sub

    Private Sub añadirServiciosDgview()
        For Each actividadEnfermeria As Concepto In oRegOrden.serviciosSeleccionadas
            dgviewServiciosConfirmados.Rows.Add(actividadEnfermeria.getDescripcion())
        Next
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje)
    End Sub

    Private Function validarEntradasDetalle() As String
        Dim respuesta As String = ""
        Dim cantidad As String = ""
        Dim descripcion As String = ""



        Dim index As Int16 = 0
        For Each row As DataGridViewRow In dgviewServiciosConfirmados.Rows
            If row.Cells("columnaCantidad").Value = Nothing Then
                cantidad = ""
            Else
                cantidad = row.Cells("columnaCantidad").Value
            End If

            If row.Cells("columnaDescripcion").Value = Nothing Then
                descripcion = ""

            Else
                descripcion = row.Cells("columnaDescripcion").Value
            End If

            Dim oDetalle As DetalleOrdenAtencion = New DetalleOrdenAtencion()
            oDetalle.setCantidad(cantidad.Trim())
            oDetalle.setDescripcion(descripcion.Trim())

            respuesta = oRegOrden.validarDetalle(oDetalle)
            If Not respuesta = "" Then
                Return respuesta
            End If

            index += 1
        Next

        Return ""
    End Function

    Private Function guardarOrdenAtencion() As Int16
        Try
            Dim matricula As String = txtMatriculaAsegurado.Text.Trim
            Dim codigoMedico As Int16 = Int16.Parse(txtMedico.Text)
            Dim tipoServicio As Int16 = 1
            Dim codigoOrden As Int16 = 0
            Dim codUsuario As Int16 = Usuario.codUserLoggedSystem

            Dim nuevoIdOrden As Int16 = oRegOrden.guardarOrden(matricula, codigoMedico, tipoServicio, codigoOrden, codUsuario)
            Return nuevoIdOrden
        Catch ex As Exception
            mostrarMensaje("Formato incorrecto en el campo del Medico")
        End Try






    End Function

    Private Sub guardarDetallesOrden(ByVal _nuevoIdOrden As Int16)
        Dim codigoDetalle As Int16 = 0
        oRegOrden.listaDetalles = New DetalleOrdenAtencion(dgviewServiciosConfirmados.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataGridViewRow In dgviewServiciosConfirmados.Rows
            codigoDetalle += 1
            Dim nomServicio = row.Cells("columnaServicio").Value
            Dim codServicio = oRegOrden.obtenerCodServicio(nomServicio)
            Dim cantidad As Int16 = row.Cells("columnaCantidad").Value
            Dim descripcion As String = row.Cells("columnaDescripcion").Value.ToString.ToUpper()

            Dim oDetalle As DetalleOrdenAtencion = New DetalleOrdenAtencion(_nuevoIdOrden, codigoDetalle, codServicio, cantidad,
                                                                            descripcion)
            oRegOrden.listaDetalles(index) = oDetalle
            index += 1
        Next

        oRegOrden.guardarDetalles()
    End Sub






    'METODOS EVENTOS 
    Private Sub btnConfirmarServicios_Click(sender As Object, e As EventArgs) Handles btnConfirmarServicios.Click
        If lboxServicios.SelectedItems.Count > 0 Then
            guardarServiciosSeleccionadas()
            eliminarColumnasDgview()
            iniciarColumnasObligatoriasDgview()
            añadirServiciosDgview()
            deseleccionarLboxServicios()

            dgviewServiciosConfirmados.Select()
        Else
            mostrarMensaje("Error: Debe seleccionar al menos un servicio para poder continuar")
        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuMedicos.Show()
        Me.Close()
    End Sub

    Private Sub btnGuardarAtencion_Click(sender As Object, e As EventArgs) Handles btnGuardarAtencion.Click
        Dim respuesta As String = ""
        respuesta = validarEntradasDetalle()

        If Not respuesta = "" Then
            mostrarMensaje(respuesta)
        Else
            Dim nuevoIdOrden As Int16 = guardarOrdenAtencion()
            guardarDetallesOrden(nuevoIdOrden)
            reiniciarFormulario()
        End If

    End Sub

    Private Sub dgviewServiciosConfirmados_KeyDown(sender As Object, e As KeyEventArgs) Handles dgviewServiciosConfirmados.KeyDown
        If (e.KeyData = Keys.Enter) Then
            e.SuppressKeyPress = True
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub


End Class

