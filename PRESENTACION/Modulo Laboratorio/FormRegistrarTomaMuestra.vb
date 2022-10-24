Imports NEGOCIO
Public Class FormRegistrarTomaMuestra

    '- - - - - - - REGISTROO DE TOMA DE MUESTRA - - - - - 
    Private oRegistroTM As RegistroTomaMuestra

    Dim DgvDeshabilitado As Boolean = True
    Dim nombreColumnaCodigoDetalle As String = "clmCodDetalle"
    Dim nombreColumnaExamen As String = "clmExamen"
    Dim nombreColumnaSeleccionar As String = "clmSeleccionar"






    'METODOS INICIO 
    Private Sub FomrRegistrarTomaMuestra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Private Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
    End Sub

    Private Sub configurarDisplay()
        Me.Size = New Size(1280, 600)
        Me.MinimumSize = New System.Drawing.Size(1280, 600)
    End Sub

    Private Sub iniciarControles()
        oRegistroTM = New RegistroTomaMuestra()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
    End Sub

    Private Sub iniciarControlesGrupo1()
        txtNroOrden.Enabled = True
        txtNroOrden.Font = New Font("Microsoft Sans Serif", 9)
        txtNroOrden.Text = ""

        btnBuscarOrdenXNroOrden.Enabled = True
        btnBuscarOrdenXNroOrden.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarOrdenXNroOrden.Text = "Buscar por nro. orden"

        txtMatricula.Enabled = True
        txtMatricula.Font = New Font("Microsoft Sans Serif", 9)
        txtMatricula.Text = ""

        btnBuscarOrdenXMatricula.Enabled = True
        btnBuscarOrdenXMatricula.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarOrdenXMatricula.Text = "Buscar por matrícula"


        cmboxOrdenes.Enabled = False
        cmboxOrdenes.Font = New Font("Microsoft Sans Serif", 9)
        cmboxOrdenes.Items.Clear()
        cmboxOrdenes.DropDownStyle = ComboBoxStyle.DropDownList

        hintCmboxOrdenes.Font = New Font("Microsoft Sans Serif", 9)
        hintCmboxOrdenes.Text = "SELECCIONAR"
        hintCmboxOrdenes.BackColor = Color.Transparent
        hintCmboxOrdenes.Visible = True

    End Sub

    Private Sub iniciarControlesGrupo2()
        lblMensajeListaOrdenes.Font = New Font("Microsoft Sans Serif", 9.5)
        lblMensajeListaOrdenes.Text = "Pruebas pendientes de recepción"
        configurarDgvDetallesOrden()
        configurarDgvDeshabilitado()
    End Sub

    Private Sub configurarDgvDetallesOrden()
        DgvDeshabilitado = False

        DgvDetallesOrden.Enabled = True
        DgvDetallesOrden.Font = New Font("Microsoft Sans Serif", 9)

        DgvDetallesOrden.EditMode = DataGridViewEditMode.EditOnEnter
        DgvDetallesOrden.AllowUserToAddRows = False
        DgvDetallesOrden.AllowUserToDeleteRows = False
        DgvDetallesOrden.AllowUserToResizeRows = False
        DgvDetallesOrden.AllowUserToOrderColumns = False
        DgvDetallesOrden.AllowUserToResizeColumns = True
        DgvDetallesOrden.MultiSelect = True
        DgvDetallesOrden.ReadOnly = True

        DgvDetallesOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvDetallesOrden.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvDetallesOrden.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        DgvDetallesOrden.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DgvDetallesOrden.BackgroundColor = Color.FromArgb(255, 255, 255)
        DgvDetallesOrden.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        DgvDetallesOrden.DefaultCellStyle.ForeColor = Color.Black
        DgvDetallesOrden.EnableHeadersVisualStyles = False

        DgvDetallesOrden.Columns.Clear()
        DgvDetallesOrden.Columns.Add(nombreColumnaCodigoDetalle, "CODIGO DETALLE")
        DgvDetallesOrden.Columns.Add(nombreColumnaExamen, "EXAMEN")

        DgvDetallesOrden.Columns(nombreColumnaCodigoDetalle).Visible = False

        DgvDetallesOrden.Columns(nombreColumnaCodigoDetalle).FillWeight = 10
        DgvDetallesOrden.Columns(nombreColumnaExamen).FillWeight = 80


        DgvDetallesOrden.Rows.Clear()
        DgvDetallesOrden.Rows.Add(1)
    End Sub

    Private Sub configurarDgvDeshabilitado()
        DgvDeshabilitado = True

        DgvDetallesOrden.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
        DgvDetallesOrden.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText
        DgvDetallesOrden.DefaultCellStyle.BackColor = SystemColors.Control
        DgvDetallesOrden.DefaultCellStyle.ForeColor = SystemColors.GrayText
        DgvDetallesOrden.CurrentCell = Nothing
        DgvDetallesOrden.ReadOnly = True
        DgvDetallesOrden.EnableHeadersVisualStyles = False

        DgvDetallesOrden.Rows.Clear()
        DgvDetallesOrden.Rows.Add(1)
    End Sub




    'METODOS INTERFAZ
    Private Sub poblarCmboxOrdenes()
        cmboxOrdenes.Items.Clear()

        For Each ordenLaboratorio As OrdenLaboratorio In oRegistroTM.listaOrdenesLab
            Dim codigoOrden As Int16 = ordenLaboratorio.getCodigo()
            Dim asegurado As String = ordenLaboratorio.getAsegurado().getNombres()
            Dim fecha As String = ordenLaboratorio.getFecha()
            cmboxOrdenes.Items.Add("ORDEN: " + codigoOrden.ToString() + " | " + asegurado + " | " + fecha)
        Next
    End Sub

    Private Sub poblarDataGridOrdenes()
        Dim rowModelo As DataGridViewRow = CType(DgvDetallesOrden.Rows(0).Clone(), DataGridViewRow)
        DgvDetallesOrden.Rows.Clear()

        If Not oRegistroTM.listaDetallesOrdLab.Count = 0 Then
            For Each detalleOrden As DetalleOrdenLaboratorio In oRegistroTM.listaDetallesOrdLab
                Dim rowAuxiliar As DataGridViewRow = New DataGridViewRow()
                rowAuxiliar = CType(rowModelo.Clone, DataGridViewRow)
                rowAuxiliar.Cells(0).Value = detalleOrden.getCodigo()
                rowAuxiliar.Cells(1).Value = detalleOrden.getExamen().getNombre()
                DgvDetallesOrden.Rows.Add(rowAuxiliar)
            Next

        Else
            mostrarMensaje("Esta orden no tiene muestras pendientes de recepción")
        End If
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub






    'METODOS FUNCIONALES
    Private Function validarEntradas() As Boolean
        If DgvDetallesOrden.SelectedRows.Count = 0 Then
            mostrarMensaje("Error. Seleccione al menos una prueba para marcar su recepción")
            Return False
        End If

        Return True
    End Function

    Private Sub guardarRecepcionMuestra()
        oRegistroTM.listaDetallesSeleccionados = New DetalleOrdenLaboratorio(DgvDetallesOrden.SelectedRows.Count - 1) {}
        Dim index As Int16 = 0
        For Each row As DataGridViewRow In DgvDetallesOrden.SelectedRows
            Dim codigoDetalle As Int16 = row.Cells(nombreColumnaCodigoDetalle).Value
            Dim oDetOrLabAux As DetalleOrdenLaboratorio = New DetalleOrdenLaboratorio()
            oDetOrLabAux.setCodigo(codigoDetalle)
            oRegistroTM.listaDetallesSeleccionados(index) = oDetOrLabAux
            index += 1
        Next

        Dim respuesta As Int16 = 0
        respuesta = oRegistroTM.registrarRecepcionDeMuestra()

        If respuesta Then
            mostrarMensaje("Los datos se guardaron correctamente")
            reiniciarFormulario()
        Else
            mostrarMensaje("Hubo un error al guardar los datos")
        End If

    End Sub






    'EVENTOS GRUPO 1

    Private Sub btnBuscarOrdenXNroOrden_Click(sender As Object, e As EventArgs) Handles btnBuscarOrdenXNroOrden.Click
        txtMatricula.Text = ""

        cmboxOrdenes.Enabled = True
        hintCmboxOrdenes.Visible = True

        configurarDgvDeshabilitado()

        Try
            Dim codigoOrden As Int16 = 0
            codigoOrden = Int16.Parse(txtNroOrden.Text.Trim())
            oRegistroTM.traerOrdenesXNroOrden(codigoOrden)
            poblarCmboxOrdenes()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub btnBuscarOrdenXMatricula_Click(sender As Object, e As EventArgs) Handles btnBuscarOrdenXMatricula.Click
        txtNroOrden.Text = ""

        cmboxOrdenes.Enabled = True
        hintCmboxOrdenes.Visible = True

        configurarDgvDeshabilitado()

        Dim matricula As String = ""
        matricula = txtMatricula.Text.Trim()
        oRegistroTM.traerOrdenesXMatricula(matricula)
        poblarCmboxOrdenes()
    End Sub

    Private Sub cmboxOrdenes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxOrdenes.SelectionChangeCommitted
        configurarDgvDetallesOrden()

        hintCmboxOrdenes.Visible = False

        Dim indexSeleccinoado As Int16 = 0
        Dim codigoOrden As Int16 = 0
        indexSeleccinoado = cmboxOrdenes.SelectedIndex()
        codigoOrden = oRegistroTM.listaOrdenesLab(indexSeleccinoado).getCodigo
        oRegistroTM.traerDetallesOrden(codigoOrden)
        poblarDataGridOrdenes()
    End Sub

  




    'EVENTOS GRUPO 2
    Private Sub DgvDetallesOrden_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DgvDetallesOrden.RowPostPaint
        Dim grid = TryCast(sender, DataGridView)
        Dim rowIdx = (e.RowIndex + 1).ToString()
        Dim centerFormat = New StringFormat() With
                           {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                           }
        Dim headerBounds = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Private Sub DgvDetallesOrden_SelectionChanged(sender As Object, e As EventArgs) Handles DgvDetallesOrden.SelectionChanged
        If DgvDeshabilitado Then
            DgvDetallesOrden.ClearSelection()
        End If
    End Sub

    Private Sub btnRegistrarRecepcion_Click(sender As Object, e As EventArgs) Handles btnRegistrarRecepcion.Click
        Dim entradasValidas As Boolean = False
        entradasValidas = validarEntradas()

        If entradasValidas Then
            guardarRecepcionMuestra()
        End If

    End Sub

    Private Sub btnCancelarRecepcion_Click(sender As Object, e As EventArgs) Handles btnCancelarRecepcion.Click
        Dim dialogResult As DialogResult = MessageBox.Show("¿Desea cancelar el registro de estás tomas de muestra?", "Cancelar registro", MessageBoxButtons.YesNo)
        If dialogResult = dialogResult.Yes Then reiniciarFormulario()
    End Sub

End Class