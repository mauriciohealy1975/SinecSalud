Imports NEGOCIO
Public Class FormRegistrarBajaPorEmpresa

    'ATRIBUTOS
    Private regAviso As RegistroBajaPorEmpresa,
            empresaSeleccionada As Empresa,
            dgvTitNomClmMatricula As String,
            dgvTitNomClmNombre As String,
            titularSeleccionado As Titular,
            dgvBajaNomClmMatricula As String,
            dgvBajaNomClmNombre As String,
            dgvBajaNomClmCargo As String,
            dgvBajaNomClmSalario As String,
            dgvBajaNomClmMotivo As String,
            dgvBajaNomClmFecPres As String,
            dgvBajaNomClmEliminar As String,
            cargoSeleccionado As Concepto,
            motivoSeleccionado As Concepto,
            avisoActual As AvisoAfiliacion


    'METODOS INICIO
    Private Sub FormRegistrarBajaPorEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
        configurarDisplay()

    End Sub
    Private Sub configurarDisplay()

        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarFormulario()
        iniciarControles()
    End Sub

    Private Sub iniciarControles()
        iniciarControlesLogicos()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()


        traerCargos()
        poblarCboxCargos()

        traerMotivos()
        poblarCboxMotivos()
    End Sub

    Private Sub iniciarControlesLogicos()
        regAviso = New RegistroBajaPorEmpresa()
        empresaSeleccionada = New Empresa()
        dgvTitNomClmMatricula = "clmMatricula"
        dgvTitNomClmNombre = "clmNombre"
        titularSeleccionado = New Titular()
        dgvBajaNomClmMatricula = "clmMatricula"
        dgvBajaNomClmNombre = "clmNombre"
        dgvBajaNomClmCargo = "clmCargo"
        dgvBajaNomClmSalario = "clmSalario"
        dgvBajaNomClmMotivo = "clmMotivo"
        dgvBajaNomClmFecPres = "clmFecPres"
        dgvBajaNomClmEliminar = "clmEliminar"
        cargoSeleccionado = New Concepto()
        motivoSeleccionado = New Concepto()
        avisoActual = New AvisoAfiliacion()
    End Sub

    Private Sub iniciarControlesGrupo1()
        lblTituloPrincipal.Text = "REGISTRAR BAJA POR EMPRESA"

        panelBuscarEmpresa.Enabled = True
        panelBuscarEmpresa.Visible = True

        txtBuscarEmpresas.Enabled = True
        txtBuscarEmpresas.Visible = True
        txtBuscarEmpresas.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarEmpresas.Text = ""
        txtBuscarEmpresas.CharacterCasing = CharacterCasing.Upper

        btnBuscarEmpresas.Enabled = True
        btnBuscarEmpresas.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarEmpresas.Text = "Buscar"

        cboxEmpresa.Enabled = True
        cboxEmpresa.Font = New Font("Microsoft Sans Serif", 8)
        cboxEmpresa.Items.Clear()
        cboxEmpresa.DropDownStyle = ComboBoxStyle.DropDownList

        hintEmpresa.Enabled = True
        hintEmpresa.Font = New Font("Microsoft Sans Serif", 8)
        hintEmpresa.Text = "SELECCIONAR"
        hintEmpresa.BackColor = Color.Transparent
        hintEmpresa.Visible = True

        iniciarDgvTitulares()
        deshabilitarDgvTitulares()
    End Sub

    Private Sub iniciarControlesGrupo2()
        panelDatosAsegurado.Enabled = True

        txtApellidoPaterno.Enabled = True
        txtApellidoPaterno.ReadOnly = True
        txtApellidoPaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApellidoPaterno.Text = ""
        txtApellidoPaterno.CharacterCasing = CharacterCasing.Upper

        txtApellidoMaterno.Enabled = True
        txtApellidoMaterno.ReadOnly = True
        txtApellidoMaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApellidoMaterno.Text = ""
        txtApellidoMaterno.CharacterCasing = CharacterCasing.Upper

        txtNombres.Enabled = True
        txtNombres.ReadOnly = True
        txtNombres.Font = New Font("Microsoft Sans Serif", 9)
        txtNombres.Text = ""
        txtNombres.CharacterCasing = CharacterCasing.Upper

        txtMatricula.Enabled = True
        txtMatricula.ReadOnly = True
        txtMatricula.Font = New Font("Microsoft Sans Serif", 9)
        txtMatricula.Text = ""
        txtMatricula.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarDgvTitulares()
        'propiedades base
        dgvTitulares.Enabled = False
        dgvTitulares.Font = New Font("Microsoft Sans Serif", 9)



        'permisos editar
        dgvTitulares.EditMode = DataGridViewEditMode.EditOnEnter
        dgvTitulares.AllowUserToAddRows = False
        dgvTitulares.AllowUserToDeleteRows = True
        dgvTitulares.AllowUserToResizeRows = False
        dgvTitulares.AllowUserToOrderColumns = False
        dgvTitulares.AllowUserToResizeColumns = False
        dgvTitulares.MultiSelect = False
        dgvTitulares.ReadOnly = True



        'estilos
        dgvTitulares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTitulares.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTitulares.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvTitulares.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvTitulares.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvTitulares.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvTitulares.DefaultCellStyle.ForeColor = Color.Black
        dgvTitulares.ScrollBars = ScrollBars.Both
        dgvTitulares.EnableHeadersVisualStyles = False



        'columnas
        dgvTitulares.Columns.Clear()
        dgvTitulares.Columns.Add(dgvTitNomClmMatricula, "Matricula")
        dgvTitulares.Columns(dgvTitNomClmMatricula).Visible = True
        dgvTitulares.Columns.Add(dgvTitNomClmNombre, "Nombre")
        dgvTitulares.Columns(dgvTitNomClmNombre).Visible = True

        For Each columna As DataGridViewColumn In dgvTitulares.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        dgvTitulares.Columns(dgvTitNomClmMatricula).FillWeight = 30
        dgvTitulares.Columns(dgvTitNomClmNombre).FillWeight = 70



        'filas
        dgvTitulares.Rows.Clear()
    End Sub

    Private Sub iniciarControlesGrupo3()
        panelDatosBaja.Enabled = True

        dpcFechaBaja.Enabled = False
        dpcFechaBaja.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaBaja.ShowUpDown = True
        dpcFechaBaja.Format = DateTimePickerFormat.Custom
        dpcFechaBaja.CustomFormat = "dd--MM--yyyy"
        dpcFechaBaja.Value = Date.Today

        cboxCargo.Enabled = False
        cboxCargo.Font = New Font("Microsoft Sans Serif", 9)
        cboxCargo.Items.Clear()
        cboxCargo.DropDownStyle = ComboBoxStyle.DropDownList

        hintCargo.Enabled = False
        hintCargo.Font = New Font("Microsoft Sans Serif", 8)
        hintCargo.Text = "SELECCIONAR"
        hintCargo.BackColor = Color.Transparent
        hintCargo.Visible = True

        numSalario.Enabled = False
        numSalario.Value = 0
        numSalario.DecimalPlaces = 2
        numSalario.Maximum = 99999.99
        numSalario.Minimum = 0

        cboxMotivo.Enabled = False
        cboxMotivo.Font = New Font("Microsoft Sans Serif", 9)
        cboxMotivo.Items.Clear()
        cboxMotivo.DropDownStyle = ComboBoxStyle.DropDownList

        hintMotivo.Enabled = False
        hintMotivo.Font = New Font("Microsoft Sans Serif", 8)
        hintMotivo.Text = "SELECCIONAR"
        hintMotivo.BackColor = Color.Transparent
        hintMotivo.Visible = True

        dpcFechaPresentacion.Enabled = False
        dpcFechaPresentacion.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaPresentacion.ShowUpDown = True
        dpcFechaPresentacion.Format = DateTimePickerFormat.Custom
        dpcFechaPresentacion.CustomFormat = "dd--MM--yyyy"
        dpcFechaPresentacion.Value = Date.Today

        btnAdicionar.Enabled = True
        btnAdicionar.Font = New Font("Microsoft Sans Serif", 9)
        btnAdicionar.Text = "Adicionar"

        iniciarDgvBajas()
        habilitarDgvBajas()
    End Sub

    Private Sub iniciarDgvBajas()
        'propiedades base
        dgvBajas.Enabled = False
        dgvBajas.Font = New Font("Microsoft Sans Serif", 9)




        'permisos editar
        dgvBajas.EditMode = DataGridViewEditMode.EditOnEnter
        dgvBajas.AllowUserToAddRows = False
        dgvBajas.AllowUserToDeleteRows = True
        dgvBajas.AllowUserToResizeRows = False
        dgvBajas.AllowUserToOrderColumns = False
        dgvBajas.AllowUserToResizeColumns = False
        dgvBajas.MultiSelect = False
        dgvBajas.ReadOnly = True




        'estilos
        dgvBajas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvBajas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBajas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvBajas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvBajas.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvBajas.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvBajas.DefaultCellStyle.ForeColor = Color.Black
        dgvBajas.ScrollBars = ScrollBars.Both
        dgvBajas.EnableHeadersVisualStyles = False



        'columnas
        dgvBajas.Columns.Clear()

        Dim deleteButtonColumn = New DataGridViewButtonColumn()
        deleteButtonColumn.Name = dgvBajaNomClmEliminar
        deleteButtonColumn.HeaderText = ""
        deleteButtonColumn.Text = " Eliminar "
        deleteButtonColumn.UseColumnTextForButtonValue = True
        dgvBajas.Columns.Add(deleteButtonColumn)
        dgvBajas.Columns(dgvBajaNomClmEliminar).Visible = True



        dgvBajas.Columns.Add(dgvBajaNomClmMatricula, "Matricula")
        dgvBajas.Columns(dgvBajaNomClmMatricula).Visible = True

        dgvBajas.Columns.Add(dgvBajaNomClmNombre, "Nombre")
        dgvBajas.Columns(dgvBajaNomClmNombre).Visible = True

        dgvBajas.Columns.Add(dgvBajaNomClmCargo, "Cargo")
        dgvBajas.Columns(dgvBajaNomClmCargo).Visible = True

        dgvBajas.Columns.Add(dgvBajaNomClmSalario, "Salario")
        dgvBajas.Columns(dgvBajaNomClmSalario).Visible = True

        dgvBajas.Columns.Add(dgvBajaNomClmMotivo, "Motivo")
        dgvBajas.Columns(dgvBajaNomClmMotivo).Visible = True

        dgvBajas.Columns.Add(dgvBajaNomClmFecPres, "Fecha Presentación")
        dgvBajas.Columns(dgvBajaNomClmFecPres).Visible = True




        'centrar columnas
        For Each columna As DataGridViewColumn In dgvBajas.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next




        'configurar ancho columnas
        dgvBajas.Columns(dgvBajaNomClmMatricula).FillWeight = 15
        dgvBajas.Columns(dgvBajaNomClmNombre).FillWeight = 15
        dgvBajas.Columns(dgvTitNomClmMatricula).FillWeight = 15
        dgvBajas.Columns(dgvBajaNomClmCargo).FillWeight = 15
        dgvBajas.Columns(dgvBajaNomClmSalario).FillWeight = 15
        dgvBajas.Columns(dgvBajaNomClmMotivo).FillWeight = 15
        dgvBajas.Columns(dgvBajaNomClmFecPres).FillWeight = 15




        'filas
        dgvBajas.Rows.Clear()
    End Sub








    'METODOS INTERFAZ G1
    Private Sub deshabilitarTxtBuscarEmpresas()
        txtBuscarEmpresas.Enabled = False
    End Sub

    Private Sub deshabilitarBtnBuscarEmpresas()
        btnBuscarEmpresas.Enabled = False
    End Sub

    Private Sub poblarCboxEmpresas()
        cboxEmpresa.Items.Clear()

        For Each empresa As Empresa In regAviso.empresas
            cboxEmpresa.Items.Add(empresa.getNombre())
        Next
    End Sub

    Private Sub deshabilitarCboxEmpresas()
        cboxEmpresa.Enabled = False
    End Sub

    Private Sub ocultarHintEmpresa()
        hintEmpresa.Visible = False
    End Sub

    Private Sub mostrarHintEmpresa()
        hintEmpresa.Visible = True
    End Sub

    Private Sub deshabilitarControlesBusqueda()
        panelEmpresa.Enabled = False

        deshabilitarTxtBuscarEmpresas()
        deshabilitarBtnBuscarEmpresas()
        deshabilitarCboxEmpresas()
    End Sub

    Private Sub poblarDgvTitulares()
        For Each titular As Titular In regAviso.titulares

            Dim rowIndex As Int16 = dgvTitulares.Rows.Add()
            Dim rowAux As DataGridViewRow = dgvTitulares.Rows(rowIndex)

            rowAux.Cells(dgvTitNomClmMatricula).Value = titular.getMatricula()
            rowAux.Cells(dgvTitNomClmNombre).Value = titular.getApellidoPaterno + " " + titular.getApellidoMaterno() + " " + titular.getNombres()
        Next

    End Sub

    Private Sub habilitarDgvTitulares()
        dgvTitulares.Enabled = True

        dgvTitulares.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvTitulares.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvTitulares.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvTitulares.DefaultCellStyle.ForeColor = Color.Black
        dgvTitulares.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvTitulares.ReadOnly = True
        dgvTitulares.EnableHeadersVisualStyles = False
    End Sub

    Private Sub deshabilitarDgvTitulares()
        dgvTitulares.Enabled = False

        dgvTitulares.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
        dgvTitulares.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText
        dgvTitulares.DefaultCellStyle.BackColor = SystemColors.Control
        dgvTitulares.DefaultCellStyle.ForeColor = SystemColors.GrayText
        dgvTitulares.BackgroundColor = SystemColors.Control
        dgvTitulares.CurrentCell = Nothing
        dgvTitulares.ReadOnly = True
        dgvTitulares.EnableHeadersVisualStyles = False
    End Sub



    'METODOS INTERFAZ G2
    Private Sub mostrarInformacionTitular()
        txtApellidoPaterno.Text = titularSeleccionado.getApellidoPaterno()
        txtApellidoMaterno.Text = titularSeleccionado.getApellidoMaterno()
        txtNombres.Text = titularSeleccionado.getNombres()
        txtMatricula.Text = titularSeleccionado.getMatricula()
    End Sub



    'METODOS INTERFAZ G3
    Private Sub poblarCboxCargos()
        cboxCargo.Items.Clear()

        For Each cargo As Concepto In regAviso.cargos
            cboxCargo.Items.Add(cargo.getDescripcion())
        Next
    End Sub

    Private Sub ocultarHintCargo()
        hintCargo.Visible = False
    End Sub

    Private Sub mostrarHintCargo()
        hintCargo.Visible = True
    End Sub

    Private Sub poblarCboxMotivos()
        cboxMotivo.Items.Clear()

        For Each motivo As Concepto In regAviso.motivos
            cboxMotivo.Items.Add(motivo.getDescripcion())
        Next
    End Sub

    Private Sub ocultarHintMotivo()
        hintMotivo.Visible = False
    End Sub

    Private Sub mostrarHintMotivo()
        hintMotivo.Visible = True
    End Sub

    Private Sub habilitarDgvBajas()
        dgvBajas.Enabled = True

        dgvBajas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvBajas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvBajas.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvBajas.DefaultCellStyle.ForeColor = Color.Black
        dgvBajas.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvBajas.ReadOnly = True
        dgvBajas.EnableHeadersVisualStyles = False
    End Sub

    Private Sub poblarDgvBajas()
        dgvBajas.Rows.Clear()

        Dim avisos As ListaEnlazadaAvisosAfiliacion = regAviso.nuevosAvisos
        Dim nodoActual As NodoAvisoAfiliacion = avisos.raiz

        While nodoActual IsNot Nothing
            Dim aviso As AvisoAfiliacion = nodoActual.aviso

            Dim rowIndex As Int16 = dgvBajas.Rows.Add()
            Dim rowAux As DataGridViewRow = dgvBajas.Rows(rowIndex)

            rowAux.Cells(dgvBajaNomClmMatricula).Value = aviso.getAsegurado().getMatricula()
            rowAux.Cells(dgvBajaNomClmNombre).Value = aviso.getAsegurado().getApellidoPaterno() + " " + aviso.getAsegurado().getApellidoMaterno() + " " + aviso.getAsegurado().getNombres()
            rowAux.Cells(dgvBajaNomClmCargo).Value = aviso.getCargo().getDescripcion()
            rowAux.Cells(dgvBajaNomClmSalario).Value = aviso.getSalario()
            rowAux.Cells(dgvBajaNomClmMotivo).Value = aviso.getMotivo().getDescripcion()
            rowAux.Cells(dgvBajaNomClmFecPres).Value = aviso.getFechaPresentacion().ToShortDateString()

            nodoActual = nodoActual.siguiente
        End While

    End Sub





    'METODOS INTERFAZ G5
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub











    'METODOS LOGICOS G1
    Private Sub traerEmpresas()
        Dim input As String = txtBuscarEmpresas.Text.Trim()
        regAviso.traerEmpresas(input)
    End Sub

    Private Sub seleccionarEmpresa()
        Dim index As Int16 = cboxEmpresa.SelectedIndex
        empresaSeleccionada = regAviso.empresas(index)
    End Sub

    Private Sub traerTitulares()
        Dim codigo As Int64 = empresaSeleccionada.getCodigo()
        regAviso.traerTitulares(codigo)
    End Sub

    Private Sub seleccionarTitular()
        Dim index As Int16 = 0

        For Each row As DataGridViewRow In dgvTitulares.SelectedRows
            index = row.Index
        Next

        titularSeleccionado = regAviso.titulares(index)
    End Sub



    'METODOS LOGICOS G3
    Private Sub traerCargos()
        regAviso.traerCargos()
    End Sub

    Private Sub seleccionarCargo()
        Dim index As Int16 = cboxCargo.SelectedIndex
        cargoSeleccionado = regAviso.cargos(index)
    End Sub

    Private Function generarPeriodoCesantia(ByVal _fechaBaja As Date) As Date()
        Dim periodoCesantia() As Date = regAviso.generarPeriodoCesantia(_fechaBaja)
        Return periodoCesantia
    End Function

    Private Sub traerMotivos()
        regAviso.traerMotivos()
    End Sub

    Private Sub seleccionarMotivo()
        Dim index As Int16 = cboxMotivo.SelectedIndex
        motivoSeleccionado = regAviso.motivos(index)
    End Sub

    Private Function cargarDatos() As Boolean
        Try
            Dim fechaBaja As Date, salario As Int64, fecPresentacion As Date, fecRecepcion As Date
            fechaBaja = dpcFechaBaja.Value.Date
            salario = numSalario.Value
            fecPresentacion = dpcFechaPresentacion.Value
            fecRecepcion = Today.Date

            Dim periodoCesantia() As Date, inicioCesantia As Date, finCesantia As Date
            periodoCesantia = generarPeriodoCesantia(fechaBaja)
            inicioCesantia = periodoCesantia(0)
            finCesantia = periodoCesantia(1)

            Dim aviso As AvisoAfiliacion = New AvisoAfiliacion()
            aviso.setAsegurado(titularSeleccionado)
            aviso.setEmpleador(empresaSeleccionada)
            aviso.setFechaBaja(fechaBaja)
            aviso.setCargo(cargoSeleccionado)
            aviso.setSalario(salario)
            aviso.setMotivo(motivoSeleccionado)
            aviso.setFechaPresentacion(fecPresentacion)
            aviso.setFechaRecepcion(fecRecepcion)
            aviso.setInicioCesantia(inicioCesantia.Date)
            aviso.setFinCesantia(finCesantia.Date)

            avisoActual = aviso
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try

    End Function

    Private Function validarEntradas(ByRef _aviso As AvisoAfiliacion) As String
        Dim mensaje As String = regAviso.validarEntradas(_aviso)
        Return mensaje
    End Function

    Private Sub reiniciarInputsAviso()
        dgvTitulares.ClearSelection()

        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtNombres.Text = ""
        txtMatricula.Text = ""
        titularSeleccionado = New Titular()


        cboxCargo.SelectedIndex = -1
        cboxCargo.Enabled = False
        mostrarHintCargo()
        hintCargo.Enabled = False
        cargoSeleccionado = New Concepto()

        numSalario.Value = 0
        numSalario.Enabled = False

        cboxMotivo.SelectedIndex = -1
        cboxMotivo.Enabled = False
        mostrarHintMotivo()
        hintMotivo.Enabled = False
        motivoSeleccionado = New Concepto()

        dpcFechaPresentacion.Value = Today.Date
        dpcFechaPresentacion.Enabled = False

        dgvBajas.ClearSelection()
    End Sub

    Private Sub habilitarInputsAviso()
        cboxCargo.Enabled = True
        hintCargo.Enabled = True
        numSalario.Enabled = True
        cboxMotivo.Enabled = True
        hintMotivo.Enabled = True
        dpcFechaPresentacion.Enabled = True
    End Sub

    Private Sub adicionarAviso()
        Try
            Dim datosCargados As Boolean = cargarDatos()
            Dim mensajeValidacion As String = validarEntradas(avisoActual)

            If mensajeValidacion = "" Then
                adicionarNuevoAviso()
                poblarDgvBajas()
                reiniciarInputsAviso()
                avisoActual = New AvisoAfiliacion()

            Else
                mostrarMensaje(mensajeValidacion)
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub adicionarNuevoAviso()
        regAviso.adicionarNuevoAviso(avisoActual)
    End Sub

    Private Sub eliminarAviso(ByVal _matricula As String)
        regAviso.eliminarAvisoBaja(_matricula)
    End Sub


    'METODOS LOGICOS G4
    Private Sub insertarBajas()
        Try
            Dim respuesta As Int16 = regAviso.insertarAvisosBajas()
            If respuesta > 0 Then
                mostrarMensaje("Se registraron los datos correctamente.")
                reiniciarFormulario()
            Else
                mostrarMensaje("Hubo un error al guardar los datos.")
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub













    'EVENTOS G1
    Private Sub btnBuscarEmpresas_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpresas.Click
        Try
            traerEmpresas()
            poblarCboxEmpresas()
            mostrarHintEmpresa()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxEmpresa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxEmpresa.SelectionChangeCommitted
        Try
            seleccionarEmpresa()
            ocultarHintEmpresa()
            traerTitulares()
            poblarDgvTitulares()
            habilitarDgvTitulares()
            deshabilitarControlesBusqueda()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvTitulares_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTitulares.CellDoubleClick
        Try
            seleccionarTitular()
            mostrarInformacionTitular()
            habilitarInputsAviso()
            
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvTitulares_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvTitulares.RowPostPaint
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



    'EVENTOS G3
    Private Sub cboxCargo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxCargo.SelectionChangeCommitted
        Try
            seleccionarCargo()
            ocultarHintCargo()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxMotivo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxMotivo.SelectionChangeCommitted
        Try
            seleccionarMotivo()
            ocultarHintMotivo()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnAdicionarAvisoBaja_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        adicionarAviso()
    End Sub

    Private Sub dgvBajas_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvBajas.RowPostPaint
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


    Private Sub dgvBajas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBajas.CellClick
        Try
            If e.RowIndex < 0 OrElse e.RowIndex = dgvBajas.NewRowIndex Then Return

            If e.ColumnIndex = dgvBajas.Columns(dgvBajaNomClmEliminar).Index Then
                Dim row = dgvBajas.Rows(e.RowIndex)
                Dim matricula As String = row.Cells(dgvBajaNomClmMatricula).Value.ToString()


                eliminarAviso(matricula)
                poblarDgvBajas()
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    'EVENTOS G4
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        insertarBajas()
    End Sub





End Class