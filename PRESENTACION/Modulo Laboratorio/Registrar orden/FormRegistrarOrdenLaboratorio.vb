Imports NEGOCIO


Public Class FormRegistrarOrdenLaboratorio

    'ATRIBUTOS LÓGICOS
    Private registro As RegistroOrdenLaboratorio

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean
    Public esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private medicoSeleccionado As Medico
    Private aseguradoSeleccionado As Asegurado

    'ATRIBUTOS G2
    Private areaSeleccionada As AreaLaboratorio

    'ATRIBUTOS G3
    Private clmExamen As String
    Private clmAccion As String

    'ATRIBUTOS G9
    Public nuevaOrden As OrdenLaboratorio
    Public nuevosDetalles() As DetalleOrdenLaboratorio





    'METODOS INICIO
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(False)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)


        establecerDisplay()
    End Sub

    Private Sub FormRegistrarOrdenLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)
        estadoFormGuardado = False

        If _esHijo Then
            esFormHijo = True
        Else
            esFormHijo = False
        End If
    End Sub

    Public Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarControlesInterfaz()

        traerMedicos()
        poblarCboxMedico()

        traerAsegurados()
        poblarCboxAsegurado()

        traerAreas()
        poblarLboxAreas()

        'If esFormHijo Then iniciarControlesInterfazFormSecundario()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroOrdenLaboratorio()

        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'estadoFormGuardado = False

        'ATRIBUTOS G0
        tituloFormulario = "Registrar orden de laboratorio"

        'ATRIBUTOS G1
        medicoSeleccionado = New Medico()
        aseguradoSeleccionado = New Asegurado()

        'ATRIBUTOS G2
        areaSeleccionada = New AreaLaboratorio()

        'ATRIBUTOS G3
        clmExamen = "clmExamen"
        clmAccion = "clmAccion"
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarControlesInterfaz()
        iniciarControlesInterfazGrupo0()
        iniciarControlesInterfazGrupo1()
        iniciarControlesInterfazGrupo2()
        iniciarControlesInterfazGrupo3()
        iniciarControlesInterfazGrupo9()
    End Sub

    Private Sub iniciarControlesInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper
    End Sub

    Private Sub iniciarControlesInterfazGrupo1()
        cboxMedico.Enabled = True
        cboxMedico.Visible = True
        cboxMedico.Font = New Font("Microsoft Sans Serif", 9)
        cboxMedico.Items.Clear()
        cboxMedico.DropDownStyle = ComboBoxStyle.DropDownList

        hintMedico.Enabled = True
        hintMedico.Visible = True
        hintMedico.Font = New Font("Microsoft Sans Serif", 8)
        hintMedico.Text = "SELECCIONAR"
        hintMedico.BackColor = Color.Transparent

        cboxAsegurado.Enabled = True
        cboxAsegurado.Visible = True
        cboxAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        cboxAsegurado.Items.Clear()
        cboxAsegurado.DropDownStyle = ComboBoxStyle.DropDownList

        hintAsegurado.Enabled = True
        hintAsegurado.Visible = True
        hintAsegurado.Font = New Font("Microsoft Sans Serif", 8)
        hintAsegurado.Text = "SELECCIONAR"
        hintAsegurado.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarControlesInterfazGrupo2()
        lboxAreas.Enabled = True
        lboxAreas.Visible = True
        lboxAreas.Font = New Font("Microsoft Sans Serif", 9)
        lboxAreas.Items.Clear()

        clistExamen.Enabled = True
        clistExamen.Visible = True
        clistExamen.MultiColumn = True
        clistExamen.ColumnWidth = clistExamen.Width * 0.5
        clistExamen.Font = New Font("Microsoft Sans Serif", 9)
        clistExamen.Items.Clear()

        btnAgregarExamenes.Enabled = True
        btnAgregarExamenes.Visible = True
        btnAgregarExamenes.Font = New Font("Microsoft Sans Serif", 9)
        btnAgregarExamenes.Text = "Agregar Examenes"
    End Sub

    Private Sub iniciarControlesInterfazGrupo3()
        iniciarDgvExamenes()
    End Sub

    Private Sub iniciarDgvExamenes()
        'ENCABEZADOS LABELS

        'PROPIEDADES BASE
        dgvExamenes.Enabled = True
        dgvExamenes.Visible = True
        dgvExamenes.Font = New Font("Microsoft Sans Serif", 9)
        dgvExamenes.Rows.Clear()
        dgvExamenes.Columns.Clear()

        'PERMISOS EDITAR
        dgvExamenes.EditMode = DataGridViewEditMode.EditOnEnter
        dgvExamenes.AllowUserToAddRows = False
        dgvExamenes.AllowUserToDeleteRows = False
        dgvExamenes.AllowUserToResizeRows = False
        dgvExamenes.AllowUserToOrderColumns = False
        dgvExamenes.AllowUserToResizeColumns = False
        dgvExamenes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvExamenes.MultiSelect = False
        dgvExamenes.ReadOnly = True

        'PROPIEDADES MODOS DE SELECCION
        dgvExamenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvExamenes.SelectionMode = DataGridViewSelectionMode.CellSelect

        'PROPIEDADES COLOR CABEZAS COLUMNAS 
        dgvExamenes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvExamenes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR CABEZERAS FILAS
        dgvExamenes.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvExamenes.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'PROPIEDAES COLOR CELDAS NORMALES
        dgvExamenes.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvExamenes.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvExamenes.DefaultCellStyle.ForeColor = Color.Black

        'PROPIEDADES COLOR FILAS SELECCIONADAS
        dgvExamenes.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvExamenes.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'OTRAS PROPIEDAES
        dgvExamenes.ScrollBars = ScrollBars.Both
        dgvExamenes.EnableHeadersVisualStyles = False




        'COLUMNAS 
        dgvExamenes.Columns.Add(clmExamen, "EXAMEN")
        dgvExamenes.Columns(clmExamen).Visible = True

        Dim clmButtonAccion As New DataGridViewButtonColumn()
        clmButtonAccion.Name = clmAccion
        clmButtonAccion.HeaderText = ""
        clmButtonAccion.Text = "ELIMINAR"
        clmButtonAccion.UseColumnTextForButtonValue = True
        dgvExamenes.Columns.Add(clmButtonAccion)
        dgvExamenes.Columns(clmAccion).Visible = True


        'BLOQUEAR ORDENAR POR COLUMNA
        For Each columna As DataGridViewColumn In dgvExamenes.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        'ALINEAR COLUMNAS
        For Each columna As DataGridViewColumn In dgvExamenes.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next


        'CONFIGURAR ANCHO COLUMNAS
        dgvExamenes.Columns(clmExamen).FillWeight = 75
        dgvExamenes.Columns(clmAccion).FillWeight = 25


        'FILAS
        dgvExamenes.Rows.Clear()
    End Sub

    Private Sub iniciarControlesInterfazGrupo9()
        btnEnviarDatos.Enabled = True
        btnEnviarDatos.Visible = True
        btnEnviarDatos.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviarDatos.Text = "Registrar Orden"
    End Sub

    Private Sub establecerDisplay()
        '    Dim ejeX As Short, ejeY As Short
        '    ejeX = Utilitarios.resolucionEstandarEjeX
        '    ejeY = Utilitarios.resolucionEstandarEjeY

        '    Size = New Size(ejeX, ejeY)
        '    MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        '    MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub









    'METODOS LÓGICOS G1
    Private Sub traerMedicos()
        registro.traerMedicos()
    End Sub

    Private Sub seleccionarMedico()
        Dim index As Short = cboxMedico.SelectedIndex
        medicoSeleccionado = registro.medicos(index)
    End Sub

    Private Sub traerAsegurados()
        registro.traerAsegurados()
    End Sub

    Private Sub seleccionarAsegurado()
        Dim index As Int16 = cboxAsegurado.SelectedIndex
        aseguradoSeleccionado = registro.asegurados(index)
    End Sub


    'METODOS LÓGICOS G2
    Private Sub traerAreas()
        registro.traerAreas()
    End Sub

    Private Sub seleccionarArea()
        Dim index As Short = lboxAreas.SelectedIndex
        areaSeleccionada = registro.areas(index)
    End Sub

    Private Sub traerExamenes()
        registro.traerExamenes(areaSeleccionada)
    End Sub


    'METODOS LÓGICOS G3
    Private Function esListaLlena() As Boolean
        Dim listaLlena As Boolean = registro.esListaLlena()
        Return listaLlena
    End Function

    Private Function hayEspacio() As Boolean
        Dim espacioInsuficiente As Boolean = False
        Dim espaciosDisponibles As Int16 = registro.contarEspaciosDisponibles()
        Dim examenesPorAgregar As Int16 = clistExamen.CheckedItems.Count()


        If examenesPorAgregar > espaciosDisponibles Then
            espacioInsuficiente = True
            Return espacioInsuficiente
        End If

        Return espacioInsuficiente
    End Function

    Private Function hayRepetidos() As Boolean
        Dim repetido As Boolean = False

        For Each item In clistExamen.CheckedItems
            Dim nombreExamen As String = item.ToString()
            repetido = registro.revisarRepetidos(nombreExamen)

            If repetido Then
                Return repetido
            End If
        Next

        Return repetido
    End Function


    'METODOS LÓGICOS G9
    Private Sub enviarDatos()
        Try
            Dim entradasCargadas As Boolean = cargarEntradas()

            If entradasCargadas Then
                Dim objetosCargados As Boolean = cargarObjetos()

                If objetosCargados Then
                    Dim mensajeValidacion As String = validarEntradas()

                    If mensajeValidacion = "" Then
                        Dim reigstroConfirmado As Boolean = abrirFormularioConfirmacion()
                        If reigstroConfirmado Then enviarDatosDatabase()

                    Else
                        mostrarMensaje(mensajeValidacion)
                    End If
                End If
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Function cargarEntradas() As Boolean
        Return True
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(nuevaOrden)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try
            Dim fecha As Date, orden As OrdenLaboratorio, detalles As DetalleOrdenLaboratorio(), index As Short

            fecha = Date.Today

            orden = New OrdenLaboratorio()
            orden.setAsegurado(aseguradoSeleccionado)
            orden.setFecha(fecha)
            orden.setMedico(medicoSeleccionado)


            detalles = New DetalleOrdenLaboratorio(9) {}
            index = 0
            For Each examen As ExamenLaboratorio In registro.examenesSeleccionados
                If Not IsNothing(examen) Then
                    Dim detalle As DetalleOrdenLaboratorio

                    detalle = New DetalleOrdenLaboratorio()
                    detalle.setExamen(examen)
                    detalle.setOrden(orden)


                    detalles(index) = detalle
                    index += 1
                End If
            Next

            nuevaOrden = orden
            nuevosDetalles = detalles

            nuevaOrden.setDetalles(nuevosDetalles)

            Return True


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub enviarDatosDatabase()
        Dim mensajeInsercion As String, codigoInsercion As Short

        registro.insertarOrden(nuevaOrden)
        mensajeInsercion = registro.generarMensajeInsercion()
        codigoInsercion = registro.codigoInsercion

        If Not mensajeInsercion = "" Then
            mostrarMensaje(mensajeInsercion)
            If codigoInsercion > 0 Then reiniciarFormulario()
        End If
    End Sub

    Private Sub enviarDatosOrden()
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub

    Private Function cancelarOrden(ByVal _mensaje As String, ByVal _titulo As String) As Boolean
        Dim dialogResult As DialogResult = MessageBox.Show(_mensaje, _titulo, MessageBoxButtons.YesNo)

        If dialogResult = DialogResult.Yes Then Return True Else Return False
    End Function

    Private Function abrirFormularioConfirmacion()
        Dim form As FormConfimarOrdenLaboratorio, registroConfirmado As Boolean

        form = New FormConfimarOrdenLaboratorio(True, nuevaOrden)
        form.ShowDialog()
        registroConfirmado = form.registroConfirmado

        Return registroConfirmado
    End Function

    Private Sub mostrarRespuesta(_respuesta As Short)
        If _respuesta = 0 Then mostrarMensaje("El usuario canceló la orden")
        If _respuesta = 1 Then mostrarMensaje("El usuario confirmó la orden")
    End Sub












    'METODOS INTERFAZ G1
    Private Sub poblarCboxMedico()
        cboxMedico.Items.Clear()

        For Each medico As Medico In registro.medicos
            Dim usuario As Usuario, nombreCompleto As String

            usuario = medico.getUsuario()
            nombreCompleto = Trim(usuario.getApellidoPaterno()) + " " + Trim(usuario.getApellidoMaterno()) + " " + Trim(usuario.getNombres())
            nombreCompleto = Trim(nombreCompleto)

            cboxMedico.Items.Add(nombreCompleto)
        Next
    End Sub

    Private Sub mostrarHintMedico()
        hintMedico.Visible = True
    End Sub

    Private Sub ocultarHintMedico()
        hintMedico.Visible = False
    End Sub

    Private Sub poblarCboxAsegurado()
        cboxAsegurado.Items.Clear()

        For Each asegurado As Asegurado In registro.asegurados
            Dim nombreCompleto As String

            nombreCompleto = Trim(asegurado.getApellidoPaterno()) + " " + Trim(asegurado.getApellidoMaterno()) + " " + Trim(asegurado.getNombres)
            nombreCompleto = nombreCompleto.Trim()

            cboxAsegurado.Items.Add(nombreCompleto)
        Next
    End Sub

    Private Sub mostrarHintAsegurado()
        hintAsegurado.Visible = True
    End Sub

    Private Sub ocultarHintAsegurado()
        hintAsegurado.Visible = False
    End Sub




    'METODOS INTERFAZ G2
    Private Sub poblarLboxAreas()
        lboxAreas.Items.Clear()

        For Each area As AreaLaboratorio In registro.areas
            lboxAreas.Items.Add(area.getNombre())
        Next
    End Sub

    Private Sub enfocarLboxAreas()
        lboxAreas.Focus()
    End Sub

    Private Sub poblarClistExamenes()
        clistExamen.Items.Clear()

        For Each examen As ExamenLaboratorio In registro.examenes
            If examen IsNot Nothing Then
                clistExamen.Items.Add(examen.getNombre())
            End If
        Next
    End Sub

    Private Sub enfocarClistExamen()
        clistExamen.Focus()
    End Sub

    Private Sub desmarcarTodoClistExamen()
        For Each index As Int16 In clistExamen.CheckedIndices
            clistExamen.SetItemCheckState(index, CheckState.Unchecked)
        Next
    End Sub

    Private Sub deseleccionarEnClistExamen()
        clistExamen.ClearSelected()
    End Sub

    Private Sub agregarExamenDgv(ByVal _examen As String)
        dgvExamenes.Rows.Add(_examen)
    End Sub

    Private Sub agregarExamenes()
        For Each item In clistExamen.CheckedItems
            Dim nombreExamen As String = item.ToString()
            registro.agregarExamen(nombreExamen)
            agregarExamenDgv(nombreExamen)
        Next

    End Sub

    Private Sub eliminarExamen(ByVal _examenSeleccionado As String)
        registro.eliminarExamen(_examenSeleccionado)
        iniciarDgvExamenes()
        agregarListaExamenes()
    End Sub

    Private Sub agregarListaExamenes()
        For Each examen As ExamenLaboratorio In registro.examenesSeleccionados
            If examen IsNot Nothing Then
                dgvExamenes.Rows.Add(examen.getNombre())
            End If
        Next
    End Sub


    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(_mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub








    'EVENTOS G1
    Private Sub cboxMedico_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxMedico.SelectionChangeCommitted
        Try
            seleccionarMedico()
            ocultarHintMedico()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxAsegurado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxAsegurado.SelectionChangeCommitted
        Try
            seleccionarAsegurado()
            ocultarHintAsegurado()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G2
    Private Sub lboxAreas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxAreas.SelectedIndexChanged
        Try
            seleccionarArea()
            traerExamenes()
            poblarClistExamenes()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub lboxAreas_KeyDown(sender As Object, e As KeyEventArgs) Handles lboxAreas.KeyDown
        Try
            If (e.KeyData = Keys.Enter) Then enfocarClistExamen()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub clistExamen_KeyDown(sender As Object, e As KeyEventArgs) Handles clistExamen.KeyDown
        Try
            If (e.KeyData = Keys.Enter) Then
                If clistExamen.SelectedIndex >= 0 Then
                    Dim tickeado As Boolean

                    tickeado = clistExamen.GetItemChecked(clistExamen.SelectedIndex)

                    If tickeado Then clistExamen.SetItemChecked(clistExamen.SelectedIndex, False)
                    If Not tickeado Then clistExamen.SetItemChecked(clistExamen.SelectedIndex, True)
                End If

            ElseIf (e.KeyData = Keys.Escape) Then
                desmarcarTodoClistExamen()
                deseleccionarEnClistExamen()
                enfocarLboxAreas()
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarExamenes_Click(sender As Object, e As EventArgs) Handles btnAgregarExamenes.Click
        Try
            If esListaLlena() Then
                mostrarMensaje("Error. Sólo se permiten 10 examenes/pruebas por orden. La lista se encuentra llena.")
            Else

                If hayEspacio() Then
                    mostrarMensaje("Sólo se permite agregar 10 examenes por prueba. Seleccione una cantidad menor.")
                Else
                    If hayRepetidos() Then
                        mostrarMensaje("Error. No se puede repetir el mismo examen en una orden. Elija otro examen.")
                    Else
                        agregarExamenes()
                        desmarcarTodoClistExamen()
                    End If
                End If
            End If

            enfocarClistExamen()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G3
    Private Sub dgvExamenes_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvExamenes.RowPostPaint
        Try
            Dim grid = TryCast(sender, DataGridView)
            Dim rowIdx = (e.RowIndex + 1).ToString()
            Dim centerFormat = New StringFormat() With
                           {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                           }
            Dim headerBounds = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
            e.Graphics.DrawString(rowIdx, Me.Font, SystemBrushes.ControlText, headerBounds, centerFormat)


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgviewExamenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExamenes.CellClick
        Try
            Dim clmAccionIndex As Short, filaIndex As Short

            clmAccionIndex = dgvExamenes.Columns(clmAccion).Index
            filaIndex = e.RowIndex

            If e.RowIndex < 0 Then Return

            If e.ColumnIndex = clmAccionIndex Then
                Dim row As DataGridViewRow, nombreExamen As String

                row = dgvExamenes.Rows(filaIndex)
                nombreExamen = row.Cells(clmExamen).Value.ToString()
                eliminarExamen(nombreExamen)
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgviewExamenes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvExamenes.KeyDown
        Try
            If (e.KeyData = Keys.Enter) Then
                Dim filaIndex As Short, columnaIndex As Short, clmAccionIndex As Short


                If Not IsNothing(dgvExamenes.CurrentCell) Then

                    filaIndex = dgvExamenes.CurrentCell.RowIndex
                    columnaIndex = dgvExamenes.CurrentCell.ColumnIndex
                    clmAccionIndex = dgvExamenes.Columns(clmAccion).Index

                    If filaIndex < 0 Then Return

                    If columnaIndex = clmAccionIndex Then
                        Dim row As DataGridViewRow, nombreExamen As String

                        row = dgvExamenes.Rows(filaIndex)
                        nombreExamen = row.Cells(clmExamen).Value.ToString()
                        eliminarExamen(nombreExamen)
                    End If
                End If



            ElseIf (e.KeyData = Keys.Escape) Then
                clistExamen.Focus()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    'EVENTOS G9
    Private Sub btnCancelarOrden_Click(sender As Object, e As EventArgs) Handles btnCancelarOrden.Click
        If cancelarOrden("¿Está seguro de cancelar la orden de laboratorio?", "Cancelar Orden") Then
            reiniciarFormulario()
        End If
    End Sub

    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Try
            Dim form As FormMenuLaboratorio

            form = New FormMenuLaboratorio()
            form.Show()
            Me.Close()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



End Class
