Imports NEGOCIO
Public Class FormRegistrarConjuntoOpcionesResultadoLaboratorio


    'ATRIBUTOS LÓGICOS
    Public registro As RegistroConjuntoOpcionesResultadoLaboratorio

    'ATRIBUTOS LÓGICOS MODO FORM HIJO
    'Public estadoFormGuardado As Boolean
    Public esFormHijo As Boolean

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G2
    Private clmValorDgvOpciones As String
    Private clmAccionDgvOpciones As String

    'ATRIBUTOS G9
    Private nuevoConjuntoOpciones As ConjuntoOpcionesResultadosLaboratorio
    Private nuevoInputConjuntoOpciones As ConjuntoOpcionesResultadosLabInput

    Private nuevasOpciones As OpcionResultadoLaboratorio()
    Private nuevasInputOpciones As OpcionResultadoLaboratorioInput()




    'METODDOS INICIO
    Public Sub New(ByRef _esFormHijo As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(_esFormHijo)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormRegistrarConjuntoOpcionesResultadoLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)
        'estadoFormGuardado = False

        esFormHijo = _esHijo

        If _esHijo Then
        Else

        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarControlesInterfaz()

        'If esFormHijo Then iniciarFormularioModoHijoLogicoInterfaz()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New RegistroConjuntoOpcionesResultadoLaboratorio()

        'ATRIBUTOS LÓGICOS MODO FORM HIJO
        'Public estadoFormGuardado As Boolean

        'ATRIrBUTOS G0
        tituloFormulario = "Registrar conjunto de opciones de resultado"

        'ATRIBUTOS G2
        clmValorDgvOpciones = "clmValor"
        clmAccionDgvOpciones = "clmAccion"

        'ATRIBUTOS G9
        nuevoConjuntoOpciones = New ConjuntoOpcionesResultadosLaboratorio()
        nuevasOpciones = New OpcionResultadoLaboratorio(-1) {}
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarControlesInterfaz()
        iniciarControlesInterfazGrupo0()
        iniciarControlesInterfazGrupo1()
        iniciarControlesInterfazGrupo2()
        iniciarControlesInterfazGrupo9()
    End Sub

    Private Sub iniciarControlesInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper

        If esFormHijo Then menuStrip.Enabled = False
        If Not esFormHijo Then menuStrip.Enabled = True
    End Sub

    Private Sub iniciarControlesInterfazGrupo1()
        txtNombreConjunto.Enabled = True
        txtNombreConjunto.Visible = True
        txtNombreConjunto.Font = New Font("Microsoft Sans Serif", 9)
        txtNombreConjunto.Text = ""
        txtNombreConjunto.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarControlesInterfazGrupo2()
        iniciarDgvOpciones()
    End Sub

    Public Sub iniciarDgvOpciones()
        'propiedades base
        dgvOpciones.Enabled = True
        dgvOpciones.Font = New Font("Microsoft Sans Serif", 9)
        'dgvOpciones.Size = New Size(665, 155)




        'propiedades permisos editar
        dgvOpciones.EditMode = DataGridViewEditMode.EditOnEnter
        dgvOpciones.AllowUserToAddRows = False
        dgvOpciones.AllowUserToDeleteRows = False
        dgvOpciones.AllowUserToResizeRows = False
        dgvOpciones.AllowUserToOrderColumns = False
        dgvOpciones.AllowUserToResizeColumns = False
        dgvOpciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvOpciones.MultiSelect = False
        dgvOpciones.ReadOnly = False




        'propiedades estilos selección
        dgvOpciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOpciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect




        'propiedades estilos color encabezados columnas
        dgvOpciones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvOpciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black




        'propiedades estilos color seleccion encabezados filas
        dgvOpciones.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvOpciones.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)




        'propiedaes estilos color celdas
        dgvOpciones.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvOpciones.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvOpciones.DefaultCellStyle.ForeColor = Color.Black
        'MAYUSCUL dgvOpciones.DefaultCellStyle.




        'propiedaes estilos color celdas seleccionadas
        dgvOpciones.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvOpciones.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)




        'propiedades otras celdas
        dgvOpciones.ScrollBars = ScrollBars.Both
        dgvOpciones.EnableHeadersVisualStyles = False




        'columnas -- agregar columnas
        dgvOpciones.Columns.Clear()

        dgvOpciones.Columns.Add(clmValorDgvOpciones, "VALOR")
        dgvOpciones.Columns(clmValorDgvOpciones).Visible = True

        Dim clmButtonAccion As New DataGridViewButtonColumn()
        clmButtonAccion.Name = clmAccionDgvOpciones
        clmButtonAccion.HeaderText = ""
        clmButtonAccion.Text = "ELIMINAR"
        clmButtonAccion.UseColumnTextForButtonValue = True

        dgvOpciones.Columns.Add(clmButtonAccion)
        dgvOpciones.Columns(clmAccionDgvOpciones).Visible = True




        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvOpciones.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        'alinear columnas
        For Each columna As DataGridViewColumn In dgvOpciones.Columns

            If columna.Name = clmValorDgvOpciones Then
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            ElseIf columna.Name = clmAccionDgvOpciones Then
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Else
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If

        Next




        'configurar ancho columnas
        'dgvAvisos.Columns(dgvAvisosNomClmMatriculaBnf).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreBnf).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreTit).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmMatriculaTit).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmFechaCreacion).FillWeight = 15
        'dgvAvisos.Columns(dgvAvisosNomClmNombreEstado).FillWeight = 15
        'dgvAvisos.Columns(dgvBajaNomClmFecPres).FillWeight = 15




        'filas
        dgvOpciones.Rows.Clear()
        dgvOpciones.Rows.Add(1)

    End Sub

    Private Sub iniciarControlesInterfazGrupo9()
        btnEnviarDatos.Enabled = True
        btnEnviarDatos.Visible = True
        btnEnviarDatos.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviarDatos.Text = "Registrar conjunto de opciones"
    End Sub

    Private Sub establecerDisplay()
        'Dim ejeX As Short, ejeY As Short

        ''ejeX = Utilitarios.resolucionEstandarEjeX
        ''ejeY = Utilitarios.resolucionEstandarEjeY

        ''Dim size As New Size(ejeX, ejeY)
        'Dim size As New Size(945, 495)

        'Me.Size = size
        'MinimumSize = size
        'MaximumSize = size

        Me.CenterToScreen()
    End Sub





    'MÉTODOS LOGICOS G9
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean = cargarEntradas()

        If entradasCargadas Then
            Dim mensajeValidacion As String = validarEntradas()

            If mensajeValidacion = "" Then

                Dim objetosCargados As Boolean = cargarObjetos()

                If objetosCargados Then
                    'If esFormHijo Then guardarEstadoYSalir()
                    'If Not esFormHijo Then enviarDatosDatabase()
                    enviarDatosDatabase()
                End If
            Else
                mostrarMensaje(mensajeValidacion)
            End If

        End If
    End Sub

    Private Function cargarEntradas() As Boolean
        Try
            Dim nombreConjunto As String

            nombreConjunto = txtNombreConjunto.Text.Trim()
            nuevoInputConjuntoOpciones = New ConjuntoOpcionesResultadosLabInput()
            nuevoInputConjuntoOpciones.nombre = nombreConjunto


            nuevasInputOpciones = New OpcionResultadoLaboratorioInput(dgvOpciones.Rows.Count - 1) {}
            Dim index As Short = 0
            For Each row As DataGridViewRow In dgvOpciones.Rows
                Dim valor As String, inputOpcion As OpcionResultadoLaboratorioInput

                valor = row.Cells(clmValorDgvOpciones).Value.ToUpper()
                inputOpcion = New OpcionResultadoLaboratorioInput()
                inputOpcion.valor = valor
                inputOpcion.conjuntoOpciones = nuevoInputConjuntoOpciones

                nuevasInputOpciones(index) = inputOpcion
                index += 1
            Next

            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradas()
        Dim mensaje As String = registro.validarEntradas(nuevoInputConjuntoOpciones, nuevasInputOpciones)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try
            Dim nombreConjunto As String

            nombreConjunto = nuevoInputConjuntoOpciones.nombre

            nuevoConjuntoOpciones = New ConjuntoOpcionesResultadosLaboratorio()
            nuevoConjuntoOpciones.setNombre(nombreConjunto)


            nuevasOpciones = New OpcionResultadoLaboratorio(nuevasInputOpciones.Count - 1) {}
            Dim index As Short = 0

            For Each inoutOpcion As OpcionResultadoLaboratorioInput In nuevasInputOpciones
                Dim valor As String

                valor = inoutOpcion.valor

                Dim opcion As New OpcionResultadoLaboratorio()
                opcion.setValor(valor)
                opcion.setConjuntoOpciones(nuevoConjuntoOpciones)

                nuevasOpciones(index) = opcion
                index += 1
            Next

            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub enviarDatosDatabase()
        registro.insertConjuntoOpciones(nuevoConjuntoOpciones, nuevasOpciones)

        Dim mensajeInsercion As String = registro.generarMensajeInsercion()
        If Not mensajeInsercion = "" Then mostrarMensaje(mensajeInsercion)

        If registro.estadoInsercion > 0 Then reiniciarFormulario()
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub

    Private Sub guardarEstadoYSalir()
        'estadoFormGuardado = True
        'Me.Hide()
    End Sub

    Private Sub descartarEstado()
        'estadoFormGuardado = False
    End Sub












    'METODOS INTERFAZ G2
    Private Sub agregarFilaDgv()
        dgvOpciones.Rows.Add(1)
    End Sub

    Private Sub eliminarFilaDgvReferencias(_filaIndex As Short)
        Dim row As DataGridViewRow = dgvOpciones.Rows(_filaIndex)
        dgvOpciones.Rows.Remove(row)
    End Sub


    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub




    'EVENTOS G0
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim formMenu As FormMenuLaboratorio

        formMenu = New FormMenuLaboratorio()
        formMenu.Show()
        Me.Close()
    End Sub


    'EVENTOS G2
    Private Sub dgvOpciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOpciones.CellClick
        Try
            'SI ES CLICK EN UNA FILA HEADER
            If e.RowIndex < 0 Then Return

            Dim clmAccionIndex As Short = dgvOpciones.Columns(clmAccionDgvOpciones).Index
            If e.ColumnIndex = clmAccionIndex Then eliminarFilaDgvReferencias(e.RowIndex)

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvOpciones_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvOpciones.RowPostPaint
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

    Private Sub btnAgregarFila_Click(sender As Object, e As EventArgs) Handles btnAgregarFila.Click
        Try
            agregarFilaDgv()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G9
    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



End Class

