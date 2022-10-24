Imports NEGOCIO
Public Class FormRegistrarBeneficiario

    'CONTROLES LOGICOS G0
    Private regBen As RegistroBeneficiario
    Private beneficiarioActual As Beneficiario

    'CONTROLES LOGICOS G1
    Private parentescoSeleccionado As Concepto
    Private titularSeleccionado As Titular
    Private sexoSeleccinoado As Char

    'CONTROLES LOGICOS G2
    Private tipoDocumentoSeleccionado As Concepto
    Private lugarExpedicionSeleccionado As Concepto
    Private tipoPanelDetalle As Int16


    'OTROS ATRIBUTOS
    Private nomClmMatricula As String
    Private nomClmNombre As String
    Private nomClmParentesco As String
    Private nomClmNroOficilia As String
    Private nomClmNroLibro As String
    Private nomClmNroPartida As String
    Private nomClmNroFolio As String
    Private nomClmNroDeclaracionJurada As String
    Private nomClmNroNotaria As String
    Private nomClmEliminar As String
    Dim rowModelo As DataGridViewRow




    'METODOS INICIO
    Private Sub FormRegistrarBeneficiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
        configurarDisplay()

    End Sub

    Private Sub iniciarFormulario()
        iniciarControles()

        regBen.traerParentesco()
        poblarCboxParentesco()

        regBen.traerTipoDocumento()
        poblarCboxTipoDocumento()

        regBen.traerLugarExpedicion()
        poblarCboxLugarExpedicion()
    End Sub
    Private Sub configurarDisplay()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarControles()
        iniciarControlesLogicos()
        iniciarControlesModoFormulario()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()
        iniciarControlesGrupo4()


        elIniciarControlesModoEliminar()
    End Sub

    Private Sub iniciarControlesLogicos()
        regBen = New RegistroBeneficiario()
    End Sub

    Private Sub iniciarControlesModoFormulario()
        toolStripModos.BackColor = Color.FromArgb(240, 240, 240)
        toolStripRegistrar.BackColor = Color.FromArgb(69, 143, 255)
        toolStripEliminar.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarControlesGrupo1()
        lblTituloPrincipal.Text = "REGISTRAR BENEFICIARIO"


        panelDatosPersonales.Enabled = True

        txtBuscarMatricula.Enabled = True
        txtBuscarMatricula.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarMatricula.Text = ""
        txtBuscarMatricula.CharacterCasing = CharacterCasing.Upper

        btnBuscarMatricula.Enabled = True
        btnBuscarMatricula.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarMatricula.Text = "Buscar"

        cboxTitulares.Enabled = True
        cboxTitulares.Font = New Font("Microsoft Sans Serif", 8)
        cboxTitulares.Items.Clear()
        cboxTitulares.DropDownStyle = ComboBoxStyle.DropDownList

        hintTitulares.Enabled = True
        hintTitulares.Font = New Font("Microsoft Sans Serif", 8)
        hintTitulares.Text = "SELECCIONAR"
        hintTitulares.BackColor = Color.Transparent
        hintTitulares.Visible = True

        cboxParentezco.Enabled = True
        cboxParentezco.Font = New Font("Microsoft Sans Serif", 9)
        cboxParentezco.Items.Clear()
        cboxParentezco.DropDownStyle = ComboBoxStyle.DropDownList

        hintParentezco.Enabled = True
        hintParentezco.Font = New Font("Microsoft Sans Serif", 8)
        hintParentezco.Text = "SELECCIONAR"
        hintParentezco.BackColor = Color.Transparent
        hintParentezco.Visible = True

        txtApellidoPaterno.Enabled = True
        txtApellidoPaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApellidoPaterno.Text = ""
        txtApellidoPaterno.CharacterCasing = CharacterCasing.Upper

        txtApellidoMaterno.Enabled = True
        txtApellidoMaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApellidoMaterno.Text = ""
        txtApellidoMaterno.CharacterCasing = CharacterCasing.Upper

        txtNombres.Enabled = True
        txtNombres.Font = New Font("Microsoft Sans Serif", 9)
        txtNombres.Text = ""
        txtNombres.CharacterCasing = CharacterCasing.Upper

        txtMatriculaBeneficiario.Enabled = True
        txtMatriculaBeneficiario.ReadOnly = True
        txtMatriculaBeneficiario.Font = New Font("Microsoft Sans Serif", 9)
        txtMatriculaBeneficiario.Text = ""
        txtMatriculaBeneficiario.CharacterCasing = CharacterCasing.Upper

        panelSexo.Enabled = True
        rButtonMasculino.Enabled = True
        rButtonMasculino.Checked = False
        rButtonFemenino.Enabled = True
        rButtonFemenino.Checked = False

        dpcFechaNacimiento.Enabled = True
        dpcFechaNacimiento.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaNacimiento.ShowUpDown = True
        dpcFechaNacimiento.Format = DateTimePickerFormat.Custom
        dpcFechaNacimiento.CustomFormat = "dd--MM--yyyy"
        dpcFechaNacimiento.Value = Date.Today

        txtEdad.Enabled = True
        txtEdad.ReadOnly = True
        txtEdad.Font = New Font("Microsoft Sans Serif", 9)
        txtEdad.Text = "0"
        txtEdad.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarControlesGrupo2()
        panelDatosDocumento.Enabled = True

        cboxTipoDoc.Enabled = True
        cboxTipoDoc.Font = New Font("Microsoft Sans Serif", 9)
        cboxTipoDoc.Items.Clear()
        cboxTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList

        hintTipoDocumento.Enabled = True
        hintTipoDocumento.Font = New Font("Microsoft Sans Serif", 8)
        hintTipoDocumento.Text = "SELECCIONAR"
        hintTipoDocumento.BackColor = Color.Transparent
        hintTipoDocumento.Visible = True

        txtNroDocumento.Enabled = True
        txtNroDocumento.Font = New Font("Microsoft Sans Serif", 9)
        txtNroDocumento.Text = ""
        txtNroDocumento.CharacterCasing = CharacterCasing.Upper

        txtComplementoDocumento.Enabled = True
        txtComplementoDocumento.Font = New Font("Microsoft Sans Serif", 9)
        txtComplementoDocumento.Text = ""

        cboxLugarExpedicion.Enabled = True
        cboxLugarExpedicion.Font = New Font("Microsoft Sans Serif", 9)
        cboxLugarExpedicion.Items.Clear()
        cboxLugarExpedicion.DropDownStyle = ComboBoxStyle.DropDownList

        hintLugarExpedicion.Enabled = True
        hintLugarExpedicion.Font = New Font("Microsoft Sans Serif", 8)
        hintLugarExpedicion.Text = "SELECCIONAR"
        hintLugarExpedicion.BackColor = Color.Transparent
        hintLugarExpedicion.Visible = True
    End Sub

    Private Sub iniciarControlesGrupo3()
        panelDetalle1.Enabled = False

        mostrarPanelDetalle1()
        deshabilitarPanelDetalle1()

        txtOficilia.Enabled = True
        txtOficilia.Font = New Font("Microsoft Sans Serif", 9)
        txtOficilia.Text = ""
        txtOficilia.CharacterCasing = CharacterCasing.Upper

        txtNroLibro.Enabled = True
        txtNroLibro.Font = New Font("Microsoft Sans Serif", 9)
        txtNroLibro.Text = ""
        txtNroLibro.CharacterCasing = CharacterCasing.Upper

        txtPartida.Enabled = True
        txtPartida.Font = New Font("Microsoft Sans Serif", 9)
        txtPartida.Text = ""
        txtPartida.CharacterCasing = CharacterCasing.Upper

        txtFolio.Enabled = True
        txtFolio.Font = New Font("Microsoft Sans Serif", 9)
        txtFolio.Text = ""
        txtFolio.CharacterCasing = CharacterCasing.Upper



        ocultarPanelDetalle2()
        deshabilitarPanelDetalle2()


        txtDeclaracionJurada.Enabled = True
        txtDeclaracionJurada.Font = New Font("Microsoft Sans Serif", 9)
        txtDeclaracionJurada.Text = ""
        txtDeclaracionJurada.CharacterCasing = CharacterCasing.Upper

        txtNotaria.Enabled = True
        txtNotaria.Font = New Font("Microsoft Sans Serif", 9)
        txtNotaria.Text = ""
        txtNotaria.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarControlesGrupo4()
        btnAdicionar.Enabled = True
        btnAdicionar.Font = New Font("Microsoft Sans Serif", 9)
        btnAdicionar.Text = "Adicionar"

        iniciarDgvBeneficiarios()
    End Sub

    Private Sub iniciarDgvBeneficiarios()
        'propiedades base
        dgvBeneficiarios.Enabled = True
        dgvBeneficiarios.Font = New Font("Microsoft Sans Serif", 9)


        'permisos editar
        dgvBeneficiarios.EditMode = DataGridViewEditMode.EditOnEnter
        dgvBeneficiarios.AllowUserToAddRows = False
        dgvBeneficiarios.AllowUserToDeleteRows = True
        dgvBeneficiarios.AllowUserToResizeRows = False
        dgvBeneficiarios.AllowUserToOrderColumns = False
        dgvBeneficiarios.AllowUserToResizeColumns = False
        dgvBeneficiarios.MultiSelect = False
        dgvBeneficiarios.ReadOnly = True

        'estilos
        dgvBeneficiarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvBeneficiarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBeneficiarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvBeneficiarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvBeneficiarios.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvBeneficiarios.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvBeneficiarios.DefaultCellStyle.ForeColor = Color.Black
        dgvBeneficiarios.ScrollBars = ScrollBars.Both
        dgvBeneficiarios.EnableHeadersVisualStyles = False

        'columnas
        iniciarDgvConfigurarColumnas()

        'filas
        dgvBeneficiarios.Rows.Add(1)
        rowModelo = CType(dgvBeneficiarios.Rows(0).Clone(), DataGridViewRow)
        dgvBeneficiarios.Rows.Clear()
    End Sub

    Private Sub iniciarDgvConfigurarColumnas()
        iniciarDgvAgregarColumnas()
        iniciarDgvCentrarEncabezadosDgv()
        inciarDgvConfigurarAnchoColumnasDgv()
    End Sub

    Private Sub iniciarDgvAgregarColumnas()
        dgvBeneficiarios.Columns.Clear()

        nomClmMatricula = "clmMatricula"
        nomClmNombre = "clmNombre"
        nomClmParentesco = "clmParentezco"
        nomClmNroOficilia = "clmOficilia"
        nomClmNroLibro = "clmNroLibro"
        nomClmNroPartida = "clmPartida"
        nomClmNroFolio = "clmFolio"
        nomClmNroDeclaracionJurada = "clmDeclaracionJurada"
        nomClmNroNotaria = "clmNroNotaria"
        nomClmEliminar = "clmEliminar"

        dgvBeneficiarios.Columns.Add(nomClmMatricula, "Matricula")
        dgvBeneficiarios.Columns(nomClmMatricula).Visible = True
        dgvBeneficiarios.Columns.Add(nomClmNombre, "Nombre")
        dgvBeneficiarios.Columns(nomClmNombre).Visible = True
        dgvBeneficiarios.Columns.Add(nomClmParentesco, "Parentezco")
        dgvBeneficiarios.Columns(nomClmParentesco).Visible = True
        dgvBeneficiarios.Columns.Add(nomClmNroOficilia, "Oficilia")
        dgvBeneficiarios.Columns(nomClmNroOficilia).Visible = True
        dgvBeneficiarios.Columns.Add(nomClmNroLibro, "Nro Libro")
        dgvBeneficiarios.Columns(nomClmNroLibro).Visible = True
        dgvBeneficiarios.Columns.Add(nomClmNroPartida, "Partida")
        dgvBeneficiarios.Columns(nomClmNroPartida).Visible = True
        dgvBeneficiarios.Columns.Add(nomClmNroFolio, "Folio")
        dgvBeneficiarios.Columns(nomClmNroFolio).Visible = True
        dgvBeneficiarios.Columns.Add(nomClmNroDeclaracionJurada, "Declaracion Jurada")
        dgvBeneficiarios.Columns(nomClmNroDeclaracionJurada).Visible = True
        dgvBeneficiarios.Columns.Add(nomClmNroNotaria, "Nro. notaría")
        dgvBeneficiarios.Columns(nomClmNroNotaria).Visible = True

        Dim deleteButtonColumn = New DataGridViewButtonColumn()
        deleteButtonColumn.Name = nomClmEliminar
        deleteButtonColumn.HeaderText = ""
        deleteButtonColumn.Text = "Eliminar"
        deleteButtonColumn.UseColumnTextForButtonValue = True
        dgvBeneficiarios.Columns.Add(deleteButtonColumn)
    End Sub

    Private Sub iniciarDgvCentrarEncabezadosDgv()
        For Each columna As DataGridViewColumn In dgvBeneficiarios.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub inciarDgvConfigurarAnchoColumnasDgv()
        dgvBeneficiarios.Columns(nomClmMatricula).FillWeight = 11
        dgvBeneficiarios.Columns(nomClmNombre).FillWeight = 11
        dgvBeneficiarios.Columns(nomClmParentesco).FillWeight = 11

        dgvBeneficiarios.Columns(nomClmNroOficilia).FillWeight = 11
        dgvBeneficiarios.Columns(nomClmNroLibro).FillWeight = 11
        dgvBeneficiarios.Columns(nomClmNroPartida).FillWeight = 11

        dgvBeneficiarios.Columns(nomClmNroFolio).FillWeight = 11
        dgvBeneficiarios.Columns(nomClmNroDeclaracionJurada).FillWeight = 11
        dgvBeneficiarios.Columns(nomClmNroNotaria).FillWeight = 11
    End Sub








    'METODOS INTERFAZ G1
    Private Sub poblarCboxTitulares()
        cboxTitulares.Items.Clear()

        For Each titular As Titular In regBen.titulares
            cboxTitulares.Items.Add(titular.getMatricula() + " | " + titular.getApellidoPaterno() + " " + titular.getApellidoMaterno() + " " + titular.getNombres())
        Next
    End Sub

    Private Sub poblarCboxParentesco()
        cboxParentezco.Items.Clear()

        For Each parentesco As Concepto In regBen.parentescos
            cboxParentezco.Items.Add(parentesco.getDescripcion())
        Next
    End Sub

    Private Sub ocultarHintTitulares()
        hintTitulares.Visible = False
    End Sub

    Private Sub ocultarHintParentezco()
        hintParentezco.Visible = False
    End Sub

    Private Sub mostrarNuevaMatricula()
        Dim nuevaMatricula As String = regBen.generarNuevaMatricula(titularSeleccionado.getMatricula())

        txtMatriculaBeneficiario.BackColor = Color.FromArgb(168, 183, 255)
        txtMatriculaBeneficiario.ReadOnly = True 'Textbox remains orange...
        txtMatriculaBeneficiario.Text = nuevaMatricula
    End Sub

    Private Sub mostrarEdad()
        Dim fecha As Date = dpcFechaNacimiento.Value
        Dim edad As Int16 = Utilitarios.calcularEdad(fecha)
        txtEdad.Text = edad.ToString()
    End Sub

    Private Sub deshabilitarCboxTitulares()
        cboxTitulares.Enabled = False
    End Sub

    Private Sub habilitarCboxTitulares()
        cboxTitulares.Enabled = True
    End Sub



    'METODOS INTERFAZ G2
    Private Sub poblarCboxTipoDocumento()
        cboxTipoDoc.Items.Clear()

        For Each tipo As Concepto In regBen.tiposDeDocumento
            cboxTipoDoc.Items.Add(tipo.getDescripcion())
        Next
    End Sub

    Private Sub poblarCboxLugarExpedicion()
        cboxLugarExpedicion.Items.Clear()

        For Each lugar As Concepto In regBen.lugaresExpedicion
            cboxLugarExpedicion.Items.Add(lugar.getDescripcion())
        Next
    End Sub


    'METODOS INTERFAZ G3
    Private Sub ocultarPanelDetalle1()
        panelDetalle1.Visible = False
    End Sub

    Private Sub mostrarPanelDetalle1()
        panelDetalle1.Visible = True
    End Sub

    Private Sub deshabilitarPanelDetalle1()
        panelDetalle1.Enabled = False
    End Sub

    Private Sub habilitarPanelDetalle1()
        panelDetalle1.Enabled = True
    End Sub

    Private Sub ocultarPanelDetalle2()
        panelDetalle2.Visible = False
    End Sub

    Private Sub mostrarPanelDetalle2()
        panelDetalle2.Visible = True
    End Sub

    Private Sub deshabilitarPanelDetalle2()
        panelDetalle2.Enabled = False
    End Sub

    Private Sub habilitarPanelDetalle2()
        panelDetalle2.Enabled = True
    End Sub

    Private Sub ocultarHintTipoDocumento()
        hintTipoDocumento.Visible = False
    End Sub

    Private Sub mostrarHintTipoDocumento()
        hintTipoDocumento.Visible = True
    End Sub



    'METODOS INTERFAZ G4
    Private Sub poblarDgvBeneficiarios()
        dgvBeneficiarios.Rows.Clear()
        Dim nodoActual As NodoBeneficiario = regBen.nuevosBeneficiarios.raiz


        While nodoActual IsNot Nothing
            Dim bnf As Beneficiario = nodoActual.beneficiario
            Dim rowIndex As Int16 = dgvBeneficiarios.Rows.Add()
            Dim rowActual As DataGridViewRow = dgvBeneficiarios.Rows(rowIndex)

            rowActual.Cells(nomClmMatricula).Value = bnf.getMatricula()
            rowActual.Cells(nomClmNombre).Value = bnf.getApellidoPaterno() + " " + bnf.getApellidoMaterno + " " + bnf.getNombres()
            rowActual.Cells(nomClmParentesco).Value = bnf.getParentesco().getDescripcion()


            If tipoPanelDetalle = 1 Then
                rowActual.Cells(nomClmNroOficilia).Value = bnf.getNroOficialia
                rowActual.Cells(nomClmNroLibro).Value = bnf.getNroLibro
                rowActual.Cells(nomClmNroPartida).Value = bnf.getNroPartida
                rowActual.Cells(nomClmNroFolio).Value = bnf.getNroFolio

            ElseIf tipoPanelDetalle = 2 Then
                rowActual.Cells(nomClmNroDeclaracionJurada).Value = bnf.getNroDeclaracionJurada
                rowActual.Cells(nomClmNroNotaria).Value = bnf.getNroNotaria
            End If

            nodoActual = nodoActual.siguiente
        End While

    End Sub

    Private Sub habilitarDgv()
        dgvBeneficiarios.Enabled = True

        dgvBeneficiarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvBeneficiarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvBeneficiarios.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvBeneficiarios.DefaultCellStyle.ForeColor = Color.Black
        dgvBeneficiarios.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvBeneficiarios.ReadOnly = True
        dgvBeneficiarios.EnableHeadersVisualStyles = False
    End Sub

    Private Sub deshabilitarDgv()
        dgvBeneficiarios.Enabled = False

        dgvBeneficiarios.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control
        dgvBeneficiarios.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText
        dgvBeneficiarios.DefaultCellStyle.BackColor = SystemColors.Control
        dgvBeneficiarios.DefaultCellStyle.ForeColor = SystemColors.GrayText
        dgvBeneficiarios.BackgroundColor = SystemColors.Control
        dgvBeneficiarios.CurrentCell = Nothing
        dgvBeneficiarios.ReadOnly = True
        dgvBeneficiarios.EnableHeadersVisualStyles = False
    End Sub




    'METODOS INTERFAZ G5
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub








    'METDOS LOGICOS G1
    Private Sub seleccionarTitular()
        Dim index As Int16 = cboxTitulares.SelectedIndex
        titularSeleccionado = regBen.titulares(index)
    End Sub

    Private Sub seleccionarParentesco(ByVal _index As Int16)
        parentescoSeleccionado = regBen.parentescos(_index)
    End Sub

    Private Sub configurarPanelDetalle()
        Dim correlativo As Int16 = parentescoSeleccionado.getCorrelativo()

        If correlativo = 1 Or correlativo = 3 Then
            habilitarPanelDetalle1()
            mostrarPanelDetalle1()

            deshabilitarPanelDetalle2()
            ocultarPanelDetalle2()

            tipoPanelDetalle = 1


        ElseIf correlativo = 6 Then
            habilitarPanelDetalle2()
            mostrarPanelDetalle2()

            deshabilitarPanelDetalle1()
            ocultarPanelDetalle1()

            tipoPanelDetalle = 2


        Else
            deshabilitarPanelDetalle1()
            deshabilitarPanelDetalle2()

            tipoPanelDetalle = 0
        End If
    End Sub


    'METDOS LOGICOS G2
    Private Sub seleccionarTipoDocumento(ByVal _index As Int16)
        tipoDocumentoSeleccionado = regBen.tiposDeDocumento(_index)
    End Sub

    Private Sub seleccionarLugarExpedicion(ByVal _index As Int16)
        lugarExpedicionSeleccionado = regBen.lugaresExpedicion(_index)
    End Sub

    'METDOS LOGICOS G4
    Private Function cargarDatos()
        Try
            Dim apPaterno As String, apMaterno As String, nombres As String, matricula As String, fecNacimiento As Date,
            nroDocumento As String, complemento As String

            apPaterno = txtApellidoPaterno.Text.Trim()
            apMaterno = txtApellidoMaterno.Text.Trim()
            nombres = txtNombres.Text.Trim()
            matricula = txtMatriculaBeneficiario.Text.Trim()
            fecNacimiento = dpcFechaNacimiento.Value.Date
            nroDocumento = txtNroDocumento.Text.Trim()
            complemento = txtComplementoDocumento.Text.Trim()



            Dim beneficiario As Beneficiario = New Beneficiario()
            beneficiario.setTitular(titularSeleccionado)
            beneficiario.setParentesco(parentescoSeleccionado)
            beneficiario.setApellidoPaterno(apPaterno)
            beneficiario.setApellidoMaterno(apMaterno)
            beneficiario.setNombres(nombres)
            beneficiario.setMatricula(matricula)
            beneficiario.setSexo(sexoSeleccinoado)
            beneficiario.setFechaNacimiento(fecNacimiento)
            beneficiario.setTipoDocumento(tipoDocumentoSeleccionado)
            beneficiario.setNroDocumento(nroDocumento)
            beneficiario.setComplemento(complemento)
            beneficiario.setLugarExpedicion(lugarExpedicionSeleccionado)



            If tipoPanelDetalle = 1 Then
                Dim oficilia As String, nroLibro As String, partida As String, folio As String
                oficilia = txtOficilia.Text.Trim()
                nroLibro = txtNroLibro.Text.Trim()
                partida = txtPartida.Text.Trim()
                folio = txtFolio.Text.Trim()

                beneficiario.setOficilia(oficilia)
                beneficiario.setNroLibro(nroLibro)
                beneficiario.setPartida(partida)
                beneficiario.setFolio(folio)

            ElseIf tipoPanelDetalle = 2 Then
                Dim nroDeclaracionJurada As String, nroNotaria As String

                nroDeclaracionJurada = txtDeclaracionJurada.Text.Trim()
                nroNotaria = txtNotaria.Text.Trim()

                beneficiario.setDeclaracionJurada(nroDeclaracionJurada)
                beneficiario.setNotaria(nroNotaria)
            End If


            beneficiarioActual = beneficiario
            Return True


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try

    End Function

    Public Sub adicionarNuevoBeneficiario(ByRef _beneficiario As Beneficiario)
        regBen.nuevosBeneficiarios.agregarNodo(_beneficiario)
    End Sub

    Private Sub adicionarNuevoBeneficiario()
        regBen.adicionarNuevoBeneficiario(beneficiarioActual)
    End Sub

    Private Sub eliminarBeneficiario(ByVal _matricula As String)
        regBen.eliminarBenficiario(_matricula)
    End Sub

    Private Sub reiniciarInputsBeneficiario()
        'CONTROLES G1 -- Comtroles Logicos
        parentescoSeleccionado = Nothing
        sexoSeleccinoado = ""

        cboxParentezco.SelectedIndex = -1
        hintParentezco.Visible = True
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtNombres.Text = ""
        txtMatriculaBeneficiario.Text = ""
        txtMatriculaBeneficiario.BackColor = SystemColors.Control
        rButtonMasculino.Checked = False
        rButtonFemenino.Checked = False
        dpcFechaNacimiento.Value = Today.Date
        txtEdad.Text = "0"



        'CONTROLES G2 -- Comtroles Logicos
        tipoDocumentoSeleccionado = Nothing
        lugarExpedicionSeleccionado = Nothing
        tipoPanelDetalle = 0

        cboxTipoDoc.SelectedIndex = -1
        hintTipoDocumento.Visible = True
        txtNroDocumento.Text = ""
        txtComplementoDocumento.Text = ""
        cboxLugarExpedicion.SelectedIndex = -1
        hintLugarExpedicion.Visible = True



        'CONTROLES G3
        txtOficilia.Text = ""
        txtNroLibro.Text = ""
        txtPartida.Text = ""
        txtFolio.Text = ""
        txtDeclaracionJurada.Text = ""
        txtNotaria.Text = ""
    End Sub



    'METDOS LOGICOS G5
    Private Sub asignarNroFormularioInsercion()
        regBen.asignarNroFormulario(regBen.nuevosBeneficiarios)
    End Sub

    Private Sub corregirParentescoHijos()
        regBen.corregirParentescoHijos()
    End Sub

    Private Sub copiarHijosMenoresUnAñoEnListaPropia()
        regBen.copiarHijosMenoresUnAñoEnListaPropia()
    End Sub

    Private Sub eliminarHijosMenoresUnAñoListaPrincipal()
        regBen.eliminarHijosMenoresUnAñoListaPrincipal()
    End Sub

    Private Sub generarAvisosAsignacionesFamiliares()
        regBen.generarAvisosAsignacionesFamiliares()
    End Sub

    Private Sub guardarBeneficiarios()
        Dim mensajeValidacion As String = regBen.validarListaVacia()

        If mensajeValidacion = "" Then
            asignarNroFormularioInsercion()
            corregirParentescoHijos()
            copiarHijosMenoresUnAñoEnListaPropia()
            eliminarHijosMenoresUnAñoListaPrincipal()
            generarAvisosAsignacionesFamiliares()

            insertarDatos()
        Else
            mostrarMensaje(mensajeValidacion)
        End If
    End Sub

    Private Sub insertarDatos()
        Try
            Dim respuesta As Int16 = 0

            'START TRANSACTION'
            '{
            respuesta = insertarBeneficiarios()
            'If respuesta < 0 Then Dim rb = True 'rollbacktransaction

            respuesta = insertarBeneficiariosMenores()
            'If respuesta < 0 Then Dim rb = True 'rollbacktransaction

            respuesta = insertarAvisosAsignacionesFamiliares()
            'If respuesta < 0 Then Dim rb = True 'rollbacktransaction
            '}

            reiniciarFormulario()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            'rollbacktransaction'
        End Try
    End Sub

    Private Function insertarBeneficiarios()
        Dim respuesta As Int16 = regBen.insertarNuevosBeneficiarios()
        If respuesta >= 1 Then mostrarMensaje("Los beneficiarios se guardaron correctamente.") Else If respuesta < 0 Then mostrarMensaje("Hubo un error al guardar los beneficiarios.")

        Return respuesta
    End Function

    Private Function insertarBeneficiariosMenores()
        Dim respuesta As Int16 = regBen.insertarNuevosBeneficiariosMenores()
        If respuesta >= 1 Then mostrarMensaje("Los hijos menores de un año se guardaron en un aviso de inserción individual.") Else If respuesta < 0 Then mostrarMensaje("Hubo un error al guardar los beneficiarios menores 1 año.")

        Return respuesta
    End Function

    Private Function insertarAvisosAsignacionesFamiliares()
        Dim respuesta As Int16 = regBen.isnertarAvisosAsignacionesFamiliares()
        If respuesta >= 1 Then mostrarMensaje("Los avisos de asignaciones familiares se guardaron correctamente.") Else If respuesta < 0 Then mostrarMensaje("Hubo un error al guardar los avisos de asignaciones familiares.")

        Return respuesta
    End Function

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub









    'EVENTOS G0
    Private Sub toolStripRegistrar_Click(sender As Object, e As EventArgs) Handles toolStripRegistrar.Click
        reiniciarFormulario()
    End Sub

    Private Sub toolStripEliminar_Click(sender As Object, e As EventArgs) Handles toolStripEliminar.Click
        elCambiarFormModoEliminar()
    End Sub



    'EVENTOS G1
    Private Sub btnBuscarMatricula_Click(sender As Object, e As EventArgs) Handles btnBuscarMatricula.Click
        Dim modoFormulario As Int16 = regBen.modoFormulario

        Try
            If modoFormulario = 1 Then
                Dim matricula As String = txtBuscarMatricula.Text.Trim()
                regBen.traerTitulares(matricula)
                poblarCboxTitulares()


            ElseIf modoFormulario = 3 Then
                Dim matricula As String = txtBuscarMatricula.Text.Trim()
                regBen.elTraerBeneficiarios(matricula)
                elPoblarCboxConBeneficiarios()
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxTitulares_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTitulares.SelectionChangeCommitted
        Dim modoFormulario As Int16 = regBen.modoFormulario

        Try
            If modoFormulario = 1 Then
                seleccionarTitular()
                ocultarHintTitulares()
                deshabilitarCboxTitulares()
                regBen.traerBeneficiarios(titularSeleccionado.getMatricula())


            ElseIf modoFormulario = 3 Then
                Dim index As Int16 = cboxTitulares.SelectedIndex
                elSeleccionarBeneficiario(index)
                ocultarHintTitulares()
                deshabilitarCboxTitulares()
                elMostrarDatosBeneficiario()
                elHabilitarCboxMotivo()
                elHabilitarHintMotivo()
            End If



        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxParentezco_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxParentezco.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxParentezco.SelectedIndex
            seleccionarParentesco(index)
            configurarPanelDetalle()
            ocultarHintParentezco()
            mostrarNuevaMatricula()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dpcFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dpcFechaNacimiento.ValueChanged
        mostrarEdad()
    End Sub

    Private Sub rButtonMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonMasculino.CheckedChanged
        If rButtonMasculino.Checked Then
            sexoSeleccinoado = "M"
        End If
    End Sub

    Private Sub rButtonFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonFemenino.CheckedChanged
        If rButtonFemenino.Checked Then
            sexoSeleccinoado = "F"
        End If
    End Sub


    'EVENTOS G2
    Private Sub cboxTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTipoDoc.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxTipoDoc.SelectedIndex
            seleccionarTipoDocumento(index)
            ocultarHintTipoDocumento()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cmboxDocLugarExpedicion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxLugarExpedicion.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxLugarExpedicion.SelectedIndex
            seleccionarLugarExpedicion(index)
            hintLugarExpedicion.Visible = False
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    'EVENTOS G4
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            Dim datosCargados As Boolean = cargarDatos()
            Dim mensajeValidacion As String = regBen.validarEntradas(beneficiarioActual, tipoPanelDetalle)

            If Not mensajeValidacion = "" Then
                mostrarMensaje(mensajeValidacion)

            Else
                adicionarNuevoBeneficiario()
                poblarDgvBeneficiarios()
                reiniciarInputsBeneficiario()
                beneficiarioActual = Nothing
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dgvTurnos_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvBeneficiarios.RowPostPaint
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

    Private Sub dgvBeneficiarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBeneficiarios.CellClick
        Try
            If e.RowIndex < 0 OrElse e.RowIndex = dgvBeneficiarios.NewRowIndex Then Return

            If e.ColumnIndex = dgvBeneficiarios.Columns(nomClmEliminar).Index Then
                Dim row = dgvBeneficiarios.Rows(e.RowIndex)
                Dim matricula As String = row.Cells(nomClmMatricula).Value.ToString()

                eliminarBeneficiario(matricula)
                poblarDgvBeneficiarios()
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub





    'EVENTOS G5
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim modoFormulario As Int16 = regBen.modoFormulario

        If modoFormulario = 1 Then
            guardarBeneficiarios()

        ElseIf modoFormulario = 3 Then
            elEliminarBeneficiario()
        End If
    End Sub







    'CONTROLES LOGICOS G0
    Private elBeneficiarioSeleccionado As Beneficiario
    Private elMotivoBajaSeleccionado As Concepto


    '[MODO ELIMINAR] METODOS INICIO
    Private Sub elIniciarControlesModoEliminar()
        elBeneficiarioSeleccionado = Nothing
        elMotivoBajaSeleccionado = Nothing




        elCboxMotivo.Enabled = False
        elCboxMotivo.Visible = False
        elCboxMotivo.Font = New Font("Microsoft Sans Serif", 9)
        elCboxMotivo.Items.Clear()
        elCboxMotivo.DropDownStyle = ComboBoxStyle.DropDownList

        elHintMotivo.Enabled = False
        elHintMotivo.Visible = False
        elHintMotivo.Font = New Font("Microsoft Sans Serif", 8)
        elHintMotivo.Text = "SELECCIONAR MOTIVO DE BAJA"
        elHintMotivo.BackColor = Color.Transparent
    End Sub

    Private Sub elCambiarFormModoEliminar()
        regBen.modoFormulario = 3
        lblTituloPrincipal.Text = "REGISTRAR DE BAJA DE BENEFICIARIO"

        'G0
        toolStripRegistrar.BackColor = Color.Transparent
        toolStripEliminar.BackColor = Color.FromArgb(69, 143, 255)

        'G1
        hintTitulares.Text = "SELECCIONAR BENEFICIARIO"
        cboxParentezco.Enabled = False
        hintParentezco.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtApellidoMaterno.Enabled = False
        txtNombres.Enabled = False
        txtMatriculaBeneficiario.Enabled = False
        panelSexo.Enabled = False
        dpcFechaNacimiento.Enabled = False
        txtEdad.Enabled = False

        'G2
        panelDatosDocumento.Enabled = False

        cboxTipoDoc.Enabled = False
        hintTipoDocumento.Enabled = False

        txtNroDocumento.Enabled = False
        txtComplementoDocumento.Enabled = False
        cboxLugarExpedicion.Enabled = False
        hintLugarExpedicion.Enabled = False

        'G3
        panelDetalle1.Enabled = False
        panelDetalle2.Enabled = False

        'G4
        deshabilitarDgv()
        btnAdicionar.Enabled = False


        'G5
        btnEnviar.Text = "Registrar baja"


        elCboxMotivo.Visible = True
        elHintMotivo.Visible = True

        regBen.elTraerMotivoBaja()
        elPoblarCboxMotivo()


    End Sub

    Private Sub elSeleccionarMotivoBaja(ByVal _index As Int16)
        elMotivoBajaSeleccionado = regBen.elMotivosBaja(_index)
    End Sub


    '[MODO ELIMINAR] METODOS INTERFAZ
    Private Sub elPoblarCboxConBeneficiarios()
        cboxTitulares.Items.Clear()

        For Each beneficiario As Beneficiario In regBen.elBeneficiarios
            cboxTitulares.Items.Add(beneficiario.getMatricula() + " | " + beneficiario.getApellidoPaterno() + " " + beneficiario.getApellidoMaterno + " " + beneficiario.getNombres())
        Next
    End Sub

    Private Sub elMostrarDatosBeneficiario()
        txtApellidoPaterno.Text = elBeneficiarioSeleccionado.getApellidoPaterno()
        txtApellidoMaterno.Text = elBeneficiarioSeleccionado.getApellidoMaterno()
        txtNombres.Text = elBeneficiarioSeleccionado.getNombres()
        txtMatriculaBeneficiario.Text = elBeneficiarioSeleccionado.getMatricula()

        Dim sexo As Char = elBeneficiarioSeleccionado.getSexo()
        If sexo = "M" Then
            rButtonMasculino.Checked = True
        ElseIf sexo = "F" Then
            rButtonFemenino.Checked = True
        End If

        dpcFechaNacimiento.Value = elBeneficiarioSeleccionado.getFechaNacimiento()
        mostrarEdad()
    End Sub

    Private Sub elPoblarCboxMotivo()
        elCboxMotivo.Items.Clear()

        For Each motivo As Concepto In regBen.elMotivosBaja
            elCboxMotivo.Items.Add(motivo.getDescripcion())
        Next
    End Sub

    Private Sub elOcultarHintMotivo()
        elHintMotivo.Visible = False
    End Sub

    Private Sub elMostrarHintMotivo()
        elHintMotivo.Visible = True
    End Sub

    Private Sub elDeshabilitarCboxMotivo()
        elCboxMotivo.Enabled = False
    End Sub

    Private Sub elHabilitarCboxMotivo()
        elCboxMotivo.Enabled = True
    End Sub

    Private Sub elHabilitarHintMotivo()
        elHintMotivo.Enabled = True
    End Sub

    Private Sub elDeshabilitarHintMotivo()
        elHintMotivo.Enabled = False
    End Sub


    '[MODO ELIMINAR] METODOS LOGICOS
    Private Sub elSeleccionarBeneficiario(ByVal _index As Int16)
        elBeneficiarioSeleccionado = regBen.elBeneficiarios(_index)
    End Sub

    Private Function elCargarDatos() As Boolean
        Try
            Dim beneficiario As Beneficiario = New Beneficiario(), matricula As String = elBeneficiarioSeleccionado.getMatricula()

            beneficiario.setMatricula(matricula)
            beneficiario.setMotivoBaja(elMotivoBajaSeleccionado)

            regBen.elBeneficiarioParaEliminar = beneficiario
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try

    End Function

    Private Sub elEliminarBeneficiario()
        Dim datosCargados As Boolean = elCargarDatos()

        If datosCargados Then
            Dim mensajeValidacion As String = regBen.elValidarEntradas()
            If mensajeValidacion = "" Then elInsertarEliminacionBeneficiario() Else mostrarMensaje(mensajeValidacion)
        End If
    End Sub

    Private Sub elInsertarEliminacionBeneficiario()
        Try
            Dim respuesta As Int16
            respuesta = regBen.elEliminarBeneficiario(Me.Text)

            If respuesta < 0 Then
                mostrarMensaje("Hubo un error al guardar los datos.")

            Else
                mostrarMensaje("Los datos se guardaron correctamente.")
                reiniciarFormulario()
                elCambiarFormModoEliminar()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub


    '[MODO ELIMINAR] EVENTOS
    Private Sub elCboxMotivo_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles elCboxMotivo.SelectionChangeCommitted
        Try
            Dim index As Int16 = elCboxMotivo.SelectedIndex
            elSeleccionarMotivoBaja(index)
            elOcultarHintMotivo()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub




End Class