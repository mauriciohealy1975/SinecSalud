Imports NEGOCIO

Public Class FormRegistrarTitular

    Private oRegTitular As RegistroAseguradoTitular
    Private sexoSeleccionado As Char
    Private tipoContratacion As Int16


    'METODOS INICIO
    Private Sub FormRegistrarTitular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Public Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
    End Sub

    Private Sub configurarDisplay()
        Dim ejeX As Int16 = Utilitarios.resolucionEstandarEjeX

        Size = New Size(ejeX, 700)
        MaximumSize = New System.Drawing.Size(ejeX, 700)
        MinimumSize = New System.Drawing.Size(ejeX, 700)
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarControles()
        iniciarControlesLogicos()
        iniciarControlesRegistrarEditarEliminar()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()
        iniciarControlesGrupo4()
        iniciarControlesGrupo5()
        iniciarControlesGrupo6()

        oRegTitular.traerNacionalidades()
        poblarCboxNacionalidad()

        oRegTitular.traerLugarNacimiento()
        poblarCboxLugarNacimiento()

        oRegTitular.traerTipoDocumento()
        poblarCboxTipoDocumento()

        oRegTitular.traerLugarExpedicion()
        poblarCboxLugarExpedicion()

        oRegTitular.traerTipoSangre()
        poblarCboxTipoSangre()

        oRegTitular.traerEstadosCivilies()
        poblarCboxEstadoCivil()



        'G3
        oRegTitular.traerTipoAsegurado()
        poblarCboxTipoAsegurado()

        oRegTitular.traerCargosTrabajo()
        poblarCboxCargoTrabajo()


        oRegTitular.traerDepartamentos()
        poblarCboxDepartamento()
        poblarCboxDptoLaboral()
    End Sub

    Private Sub iniciarControlesLogicos()
        oRegTitular = New RegistroAseguradoTitular()
        sexoSeleccionado = ""
        tipoContratacion = 0
    End Sub

    Private Sub iniciarControlesRegistrarEditarEliminar()
        toolStripModos.BackColor = Color.FromArgb(253, 253, 253)
        toolStripRegistrar.BackColor = Color.FromArgb(69, 143, 255)
        toolStripEditar.BackColor = Color.FromArgb(250, 250, 250)
        iniciarControlesModoEditar()
    End Sub

    Private Sub iniciarControlesModoEditar()
        edCboxTitular.Enabled = True
        edCboxTitular.Visible = False
        edCboxTitular.Font = New Font("Microsoft Sans Serif", 9)
        edCboxTitular.Items.Clear()
        edCboxTitular.DropDownStyle = ComboBoxStyle.DropDownList

        edHintTitular.Enabled = True
        edHintTitular.Visible = False
        edHintTitular.Font = New Font("Microsoft Sans Serif", 9)
        edHintTitular.Text = "SELECCIONAR"
    End Sub

    Private Sub iniciarControlesGrupo1()
        panelDatosPersonales.Enabled = True

        txtApellidoPaterno.Enabled = True
        txtApellidoPaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApellidoPaterno.Text = ""
        txtApellidoPaterno.CharacterCasing = CharacterCasing.Upper

        txtApeliidoMaterno.Enabled = True
        txtApeliidoMaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApeliidoMaterno.Text = ""
        txtApeliidoMaterno.CharacterCasing = CharacterCasing.Upper

        txtNombres.Enabled = True
        txtNombres.Font = New Font("Microsoft Sans Serif", 9)
        txtNombres.Text = ""
        txtNombres.CharacterCasing = CharacterCasing.Upper

        txtMatricula.Enabled = True
        txtMatricula.Font = New Font("Microsoft Sans Serif", 9)
        txtMatricula.Text = ""
        txtMatricula.ReadOnly = True
        txtMatricula.CharacterCasing = CharacterCasing.Upper




        cboxNacionalidad.Enabled = True
        cboxNacionalidad.Font = New Font("Microsoft Sans Serif", 9)
        cboxNacionalidad.Items.Clear()
        cboxNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList

        hintNacionalidad.Enabled = True
        hintNacionalidad.Font = New Font("Microsoft Sans Serif", 8)
        hintNacionalidad.Text = "SELECCIONAR"
        hintNacionalidad.BackColor = Color.Transparent
        hintNacionalidad.Visible = True

        cboxLugarNacimiento.Enabled = True
        cboxLugarNacimiento.Font = New Font("Microsoft Sans Serif", 9)
        cboxLugarNacimiento.Items.Clear()
        cboxLugarNacimiento.DropDownStyle = ComboBoxStyle.DropDownList

        hintLugarNacimiento.Enabled = True
        hintLugarNacimiento.Font = New Font("Microsoft Sans Serif", 8)
        hintLugarNacimiento.Text = "SELECCIONAR"
        hintLugarNacimiento.BackColor = Color.Transparent
        hintLugarNacimiento.Visible = True

        dpcFechaNacmiento.Enabled = True
        dpcFechaNacmiento.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaNacmiento.ShowUpDown = True
        dpcFechaNacmiento.Format = DateTimePickerFormat.Custom
        dpcFechaNacmiento.CustomFormat = "dd--MM--yyyy"
        dpcFechaNacmiento.Value = "01-01-2000"

        cmboxTipoSangre.Enabled = True
        cmboxTipoSangre.Font = New Font("Microsoft Sans Serif", 9)
        cmboxTipoSangre.Items.Clear()
        cmboxTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList

        hintTipoSangre.Enabled = True
        hintTipoSangre.Font = New Font("Microsoft Sans Serif", 8)
        hintTipoSangre.Text = "SELECCIONAR"
        hintTipoSangre.BackColor = Color.Transparent
        hintTipoSangre.Visible = True




        panelSexo.Enabled = True
        rButtonMasculino.Enabled = True
        rButtonMasculino.Checked = False
        rButtonFemenino.Enabled = True
        rButtonMasculino.Checked = False

        cboxEstadoCivil.Enabled = True
        cboxEstadoCivil.Font = New Font("Microsoft Sans Serif", 9)
        cboxEstadoCivil.Items.Clear()
        cboxEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList

        hintEstadoCivil.Enabled = True
        hintEstadoCivil.Font = New Font("Microsoft Sans Serif", 8)
        hintEstadoCivil.Text = "SELECCIONAR"
        hintEstadoCivil.BackColor = Color.Transparent
        hintEstadoCivil.Visible = True

        txtLocalidad.Enabled = True
        txtLocalidad.Font = New Font("Microsoft Sans Serif", 9)
        txtLocalidad.Text = ""
        txtLocalidad.CharacterCasing = CharacterCasing.Upper




        txtZona.Enabled = True
        txtZona.Font = New Font("Microsoft Sans Serif", 9)
        txtZona.Text = ""
        txtZona.CharacterCasing = CharacterCasing.Upper

        txtCalle.Enabled = True
        txtCalle.Font = New Font("Microsoft Sans Serif", 9)
        txtCalle.Text = ""
        txtCalle.CharacterCasing = CharacterCasing.Upper

        txtNroCasa.Enabled = True
        txtNroCasa.Font = New Font("Microsoft Sans Serif", 9)
        txtNroCasa.Text = ""
        txtNroCasa.CharacterCasing = CharacterCasing.Upper

        btnGenerarMatricula.Enabled = True
        btnGenerarMatricula.Font = New Font("Microsoft Sans Serif", 9)
        btnGenerarMatricula.Text = "Generar Matricula"
    End Sub

    Private Sub iniciarControlesGrupo2()
        panelDatosDocumento.Enabled = True

        cmboxDocTipo.Enabled = True
        cmboxDocTipo.Font = New Font("Microsoft Sans Serif", 9)
        cmboxDocTipo.Items.Clear()
        cmboxDocTipo.DropDownStyle = ComboBoxStyle.DropDownList

        hintDocTipo.Font = New Font("Microsoft Sans Serif", 8)
        hintDocTipo.Text = "SELECCIONAR"
        hintDocTipo.BackColor = Color.Transparent
        hintDocTipo.Visible = True

        txtDocumento.Enabled = True
        txtDocumento.Font = New Font("Microsoft Sans Serif", 9)
        txtDocumento.Text = ""
        txtDocumento.CharacterCasing = CharacterCasing.Upper

        txtDocComplemento.Enabled = True
        txtDocComplemento.Font = New Font("Microsoft Sans Serif", 9)
        txtDocComplemento.Text = ""
        txtDocumento.CharacterCasing = CharacterCasing.Upper

        cmboxDocLugarExpedicion.Enabled = True
        cmboxDocLugarExpedicion.Font = New Font("Microsoft Sans Serif", 9)
        cmboxDocLugarExpedicion.Items.Clear()
        cmboxDocLugarExpedicion.DropDownStyle = ComboBoxStyle.DropDownList

        hintDocLugarExpedicion.Font = New Font("Microsoft Sans Serif", 8)
        hintDocLugarExpedicion.Text = "SELECCIONAR"
        hintDocLugarExpedicion.BackColor = Color.Transparent
        hintDocLugarExpedicion.Visible = True
    End Sub

    Private Sub iniciarControlesGrupo3()
        panelDatosAfiliacion.Enabled = True

        cmboxTipoAsegurado.Enabled = True
        cmboxTipoAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        cmboxTipoAsegurado.Items.Clear()
        cmboxTipoAsegurado.DropDownStyle = ComboBoxStyle.DropDownList

        hintTipoAsegurado.Font = New Font("Microsoft Sans Serif", 8)
        hintTipoAsegurado.Text = "SELECCIONAR"
        hintTipoAsegurado.BackColor = Color.Transparent
        hintTipoAsegurado.Visible = True

        txtBuscarEmpresa.Enabled = True
        txtBuscarEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarEmpresa.Text = ""
        txtBuscarEmpresa.CharacterCasing = CharacterCasing.Upper

        btnBuscarEmpresa.Enabled = True
        btnBuscarEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarEmpresa.Text = "Buscar "

        cboxEmpresa.Enabled = True
        cboxEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        cboxEmpresa.Items.Clear()
        cboxEmpresa.DropDownStyle = ComboBoxStyle.DropDownList

        hintEmpresa.Font = New Font("Microsoft Sans Serif", 8)
        hintEmpresa.Text = "SELECCIONAR EMPRESA"
        hintEmpresa.BackColor = Color.Transparent
        hintEmpresa.Visible = True

        dpcFechaContratacion.Enabled = True
        dpcFechaContratacion.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaContratacion.Format = DateTimePickerFormat.Custom
        dpcFechaContratacion.CustomFormat = "dd--MM--yyyy"
        dpcFechaContratacion.Value = Date.Today




        cboxCargo.Enabled = True
        cboxCargo.Font = New Font("Microsoft Sans Serif", 9)
        cboxCargo.Items.Clear()
        cboxCargo.DropDownStyle = ComboBoxStyle.DropDownList

        hintCargo.Font = New Font("Microsoft Sans Serif", 8)
        hintCargo.Text = "SELECCIONAR"
        hintCargo.BackColor = Color.Transparent
        hintCargo.Visible = True

        txtSalario.Enabled = True
        txtSalario.Font = New Font("Microsoft Sans Serif", 9)
        txtSalario.Text = ""
        txtSalario.CharacterCasing = CharacterCasing.Upper

        panelTipoContratacion.Enabled = True
        rButtonFijo.Enabled = True
        rButtonFijo.Checked = False

        rButtonEventual.Enabled = True
        rButtonEventual.Checked = False




        chEmpPublica.Enabled = False
        chEmpPublica.Font = New Font("Microsoft Sans Serif", 9)
        chEmpPublica.Text = "Empresa Pública"
        chEmpPublica.Checked = False

        panelEmpPublica.Enabled = False

        chProgramaProyecto.Enabled = True
        chProgramaProyecto.Font = New Font("Microsoft Sans Serif", 9)
        chProgramaProyecto.Text = "Programa/Proyecto"
        chProgramaProyecto.Checked = False

        chEntidadDesconcentrada.Enabled = True
        chEntidadDesconcentrada.Font = New Font("Microsoft Sans Serif", 9)
        chEntidadDesconcentrada.Text = "Entidad desconcentrada"
        chEntidadDesconcentrada.Checked = False

        cboxProgramaProyecto.Enabled = False
        cboxProgramaProyecto.Font = New Font("Microsoft Sans Serif", 8)
        cboxProgramaProyecto.Items.Clear()
        cboxProgramaProyecto.DropDownStyle = ComboBoxStyle.DropDownList

        hintProgramaProyecto.Enabled = False
        hintProgramaProyecto.Font = New Font("Microsoft Sans Serif", 8)
        hintProgramaProyecto.Text = "SELECCIONAR"
        hintProgramaProyecto.BackColor = Color.Transparent
        hintProgramaProyecto.Visible = True

        cboxEntidadDesconcentrada.Enabled = False
        cboxEntidadDesconcentrada.Font = New Font("Microsoft Sans Serif", 8)
        cboxEntidadDesconcentrada.Items.Clear()
        cboxEntidadDesconcentrada.DropDownStyle = ComboBoxStyle.DropDownList

        hintEntidadDesconcentrada.Enabled = False
        hintEntidadDesconcentrada.Font = New Font("Microsoft Sans Serif", 8)
        hintEntidadDesconcentrada.Text = "SELECCIONAR"
        hintEntidadDesconcentrada.BackColor = Color.Transparent
        hintEntidadDesconcentrada.Visible = True

        dpcFechaPresentacion.Enabled = True
        dpcFechaPresentacion.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaPresentacion.ShowUpDown = True
        dpcFechaPresentacion.Format = DateTimePickerFormat.Custom
        dpcFechaPresentacion.CustomFormat = "dd--MM--yyyy"
        dpcFechaPresentacion.Value = Date.Today
    End Sub

    Private Sub iniciarControlesGrupo4()
        panelInformacionContacto.Enabled = True

        txtTelefono.Enabled = True
        txtTelefono.Font = New Font("Microsoft Sans Serif", 9)
        txtTelefono.Text = ""
        txtTelefono.CharacterCasing = CharacterCasing.Upper

        txtTelefonoReferencia.Enabled = True
        txtTelefonoReferencia.Font = New Font("Microsoft Sans Serif", 9)
        txtTelefonoReferencia.Text = ""
        txtTelefonoReferencia.CharacterCasing = CharacterCasing.Upper

        cmboxDepartamento.Enabled = True
        cmboxDepartamento.Font = New Font("Microsoft Sans Serif", 9)
        cmboxDepartamento.Items.Clear()
        cmboxDepartamento.DropDownStyle = ComboBoxStyle.DropDownList

        hintDepartamento.Enabled = True
        hintDepartamento.Font = New Font("Microsoft Sans Serif", 8)
        hintDepartamento.Text = "SELECCIONAR"
        hintDepartamento.BackColor = Color.Transparent
        hintDepartamento.Visible = True

        cmboxProvincia.Enabled = True
        cmboxProvincia.Font = New Font("Microsoft Sans Serif", 9)
        cmboxProvincia.Items.Clear()
        cmboxProvincia.DropDownStyle = ComboBoxStyle.DropDownList

        hintProvincia.Enabled = True
        hintProvincia.Font = New Font("Microsoft Sans Serif", 8)
        hintProvincia.Text = "SELECCIONAR"
        hintProvincia.BackColor = Color.Transparent
        hintProvincia.Visible = True
    End Sub

    Private Sub iniciarControlesGrupo5()
        panelInformacionContactoLaboral.Enabled = True

        txtTelefonoLaboral.Enabled = True
        txtTelefonoLaboral.Font = New Font("Microsoft Sans Serif", 9)
        txtTelefonoLaboral.Text = ""
        txtTelefonoLaboral.CharacterCasing = CharacterCasing.Upper

        txtDireccionLaboral.Enabled = True
        txtDireccionLaboral.Font = New Font("Microsoft Sans Serif", 9)
        txtDireccionLaboral.Text = ""
        txtDireccionLaboral.CharacterCasing = CharacterCasing.Upper

        cboxDptoLaboral.Enabled = True
        cboxDptoLaboral.Font = New Font("Microsoft Sans Serif", 9)
        cboxDptoLaboral.Items.Clear()
        cboxDptoLaboral.DropDownStyle = ComboBoxStyle.DropDownList

        hintDptoLaboral.Font = New Font("Microsoft Sans Serif", 8)
        hintDptoLaboral.Text = "SELECCIONAR"
        hintDptoLaboral.BackColor = Color.Transparent
        hintDptoLaboral.Visible = True

        cboxProvinciaLaboral.Enabled = True
        cboxProvinciaLaboral.Font = New Font("Microsoft Sans Serif", 9)
        cboxProvinciaLaboral.Items.Clear()
        cboxProvinciaLaboral.DropDownStyle = ComboBoxStyle.DropDownList

        hintProvinciaLaboral.Font = New Font("Microsoft Sans Serif", 8)
        hintProvinciaLaboral.Text = "SELECCIONAR"
        hintProvinciaLaboral.BackColor = Color.Transparent
        hintProvinciaLaboral.Visible = True

        txtLocalidadLaboral.Enabled = True
        txtLocalidadLaboral.Font = New Font("Microsoft Sans Serif", 9)
        txtLocalidadLaboral.Text = ""
        txtLocalidadLaboral.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarControlesGrupo6()
        btnCancelar.Enabled = True
        btnCancelar.Font = New Font("Microsoft Sans Serif", 9)
        btnCancelar.Text = "Cancelar"

        btnRegistrar.Enabled = True
        btnRegistrar.Font = New Font("Microsoft Sans Serif", 9)
        btnRegistrar.Text = "Registrar titular"
    End Sub





    'METODOS INTERFAZ
    Private Sub reiniciarTxtMatricula()
        txtMatricula.Text = ""
    End Sub

    Private Sub poblarCboxTipoSangre()
        cmboxTipoSangre.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaTipoSangre
            cmboxTipoSangre.Items.Add(concepto.getDescripcion)
        Next
    End Sub

    Private Sub poblarCboxEstadoCivil()
        cboxEstadoCivil.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaEstadosCiviles
            cboxEstadoCivil.Items.Add(concepto.getDescripcion())
        Next
    End Sub

    Private Sub poblarCboxNacionalidad()
        cboxNacionalidad.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaNacionalidades
            cboxNacionalidad.Items.Add(concepto.getDescripcion)
        Next
    End Sub






    'G2
    Private Sub poblarCboxLugarNacimiento()
        cboxLugarNacimiento.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaLugarNacimiento
            cboxLugarNacimiento.Items.Add(concepto.getDescripcion())
        Next
    End Sub

    Private Sub poblarCboxTipoDocumento()
        cmboxDocTipo.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaTiposDocumento
            cmboxDocTipo.Items.Add(concepto.getDescripcion)
        Next
    End Sub

    Private Sub poblarCboxLugarExpedicion()
        cmboxDocLugarExpedicion.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaLugarExpedicion
            cmboxDocLugarExpedicion.Items.Add(concepto.getDescripcion)
        Next
    End Sub



    'G3
    Private Sub poblarCboxTipoAsegurado()
        cmboxTipoAsegurado.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaTipoAsegurado
            cmboxTipoAsegurado.Items.Add(concepto.getDescripcion)
        Next
    End Sub

    Private Sub poblarCboxCargoTrabajo()
        cboxCargo.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaCargos
            cboxCargo.Items.Add(concepto.getDescripcion())
        Next
    End Sub

    Public Sub poblarCboxEmpresas()
        cboxEmpresa.Items.Clear()

        For Each empresa As Empresa In oRegTitular.listaEmpresas
            cboxEmpresa.Items.Add(empresa.getNombre())
        Next
    End Sub

    Private Sub tickearChEmpresaPublica()
        chEmpPublica.Checked = True
    End Sub

    Public Sub poblarCboxProgramaProyecto()
        cboxProgramaProyecto.Items.Clear()

        For Each programaProyecto As ProgramaProyecto In oRegTitular.listaProgramasProyectos
            cboxProgramaProyecto.Items.Add(programaProyecto.getNombre())
        Next
    End Sub

    Public Sub poblarCboxEntidadDesconcentrada()
        cboxEntidadDesconcentrada.Items.Clear()

        For Each entidadDesconcentrada As EntidadDesconcentrada In oRegTitular.listaEntidadesDesconcetradas
            cboxEntidadDesconcentrada.Items.Add(entidadDesconcentrada.getNombre())
        Next
    End Sub

    Public Sub reiniciarControlesEmpresaPublica()
        chEmpPublica.Checked = False

        chProgramaProyecto.Checked = False
        chEntidadDesconcentrada.Checked = False
    End Sub



    'G5 Y G6
    Private Sub poblarCboxDepartamento()
        cmboxDepartamento.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaDepartamentos
            cmboxDepartamento.Items.Add(concepto.getDescripcion())
        Next
    End Sub

    Private Sub poblarCboxProvincias()
        cmboxProvincia.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaProvincias
            cmboxProvincia.Items.Add(concepto.getDescripcion)
        Next
    End Sub

    Private Sub poblarCboxDptoLaboral()
        cboxDptoLaboral.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaDepartamentos
            cboxDptoLaboral.Items.Add(concepto.getDescripcion)
        Next
    End Sub

    Private Sub poblarCboxProvinciaLaboral()
        cboxProvinciaLaboral.Items.Clear()

        For Each concepto As Concepto In oRegTitular.listaProvinciasLaborales
            cboxProvinciaLaboral.Items.Add(concepto.getDescripcion)
        Next
    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub








    'METODOS LOGICOS
    Private Sub seleccionarNacionalidad(ByVal _index As Int16)
        oRegTitular.oNacionalidadSeleccionada = oRegTitular.listaNacionalidades(_index)
    End Sub

    Private Sub seleccionarLugarNacimiento(ByVal _index As Int16)
        oRegTitular.oLugarNacimientoSeleccionado = oRegTitular.listaLugarNacimiento(_index)
    End Sub

    Private Sub seleccionarTipoSangre(ByVal _index As Int16)
        oRegTitular.oTipoSangreSeleccionado = oRegTitular.listaTipoSangre(_index)
    End Sub

    Private Sub seleccionarEstadoCivil(ByVal _index As Int16)
        oRegTitular.oEstadoCivilSeleccionado = oRegTitular.listaEstadosCiviles(_index)
    End Sub

    Private Function calcularEdad(ByVal _fechaNacimiento As Date)
        Dim fechaHoy As DateTime = DateTime.Today
        Dim edad As Int16 = fechaHoy.Year - _fechaNacimiento.Year

        If _fechaNacimiento.Date > fechaHoy.AddYears(-edad) Then
            edad -= 1
        End If

        Return edad
    End Function

    Private Sub seleccionarTipoDocumento(ByVal _index As Int16)
        oRegTitular.oTipoDocSeleciconado = oRegTitular.listaTiposDocumento(_index)
    End Sub

    Private Sub seleccionarLugarExpedicion(ByVal _index As Int16)
        oRegTitular.oLugarExpedicionSeleccionado = oRegTitular.listaLugarExpedicion(_index)
    End Sub

    Private Sub seleccionarTipoAsegurado(ByVal _index As Int16)
        oRegTitular.oTipoAseguradoSeleccionado = oRegTitular.listaTipoAsegurado(_index)
    End Sub

    Private Sub seleccionarEmpresa(ByVal _index As Int16)
        oRegTitular.oEmpresaSeleccionada = oRegTitular.listaEmpresas(_index)
    End Sub

    Private Sub seleccionarCargo(ByVal _index As Int16)
        oRegTitular.oCargoSeleccionado = oRegTitular.listaCargos(_index)
    End Sub

    Private Sub seleccionarDepartamento(ByVal _index As Int16)
        oRegTitular.oDepartamentoResidenciaSeleccionado = oRegTitular.listaDepartamentos(_index)
    End Sub

    Private Sub seleccionarProvincia(ByVal _index As Int16)
        oRegTitular.oProvinciaResidenciaSeleccionada = oRegTitular.listaProvincias(_index)
    End Sub

    Private Sub seleccionarDptoLaboral(ByVal _index As Int16)
        oRegTitular.oDptoLaboralSeleccionado = oRegTitular.listaDepartamentos(_index)
    End Sub

    Private Sub seleccionarProvinciaLaboral(ByVal _index As Int16)
        oRegTitular.oProvinciaLaboralSeleccionada = oRegTitular.listaProvinciasLaborales(_index)
    End Sub

    Private Sub seleccionarProgramaProyecto(ByVal _index As Int16)
        Dim ProgProyAux As ProgramaProyecto = oRegTitular.listaProgramasProyectos(_index)
        oRegTitular.oProgramaProyectoSeleccionado = ProgProyAux
    End Sub

    Private Sub seleccionarEntidadDesconcentrada(ByVal _index As Int16)
        Dim entiDescAux As EntidadDesconcentrada = oRegTitular.listaEntidadesDesconcetradas(_index)
        oRegTitular.oEntidadDesconcentradaSeleccionada = entiDescAux
    End Sub


    Private Sub registrarDatos()
        Dim datosCargados As Boolean = cargarDatos()

        If datosCargados Then
            Dim mensajeValidacion As String = oRegTitular.validarEntradas()
            If Not mensajeValidacion = "" Then mostrarMensaje(mensajeValidacion) Else insertDatos()
        End If
    End Sub

    Private Function cargarDatos() As Boolean
        Try
            oRegTitular.oTitular.setApellidoPaterno(txtApellidoPaterno.Text.Trim())
            oRegTitular.oTitular.setApellidoMaterno(txtApeliidoMaterno.Text.Trim())
            oRegTitular.oTitular.setNombres(txtNombres.Text.Trim())
            oRegTitular.oTitular.setMatricula(txtMatricula.Text.Trim())
            oRegTitular.oTitular.setNacionalidad(oRegTitular.oNacionalidadSeleccionada)
            oRegTitular.oTitular.setLugarNacimiento(oRegTitular.oLugarNacimientoSeleccionado)

            oRegTitular.oTitular.setFechaNacimiento(dpcFechaNacmiento.Value)
            Dim edad As Int16 = Utilitarios.calcularEdad(oRegTitular.oTitular.getFechaNacimiento())
            oRegTitular.oTitular.setEdad(edad)

            oRegTitular.oTitular.setTipoSangre(oRegTitular.oTipoSangreSeleccionado)
            oRegTitular.oTitular.setSexo(sexoSeleccionado)
            oRegTitular.oTitular.setEstadoCivil(oRegTitular.oEstadoCivilSeleccionado)
            oRegTitular.oTitular.setLocalidad(txtLocalidad.Text.Trim())
            oRegTitular.oTitular.setZona(txtZona.Text.Trim())
            oRegTitular.oTitular.setCalle(txtCalle.Text.Trim())
            oRegTitular.oTitular.setNroCasa(txtNroCasa.Text.Trim())
            oRegTitular.oTitular.setTipoDocumento(oRegTitular.oTipoDocSeleciconado)
            oRegTitular.oTitular.setNroDocumento(txtDocumento.Text.Trim())
            oRegTitular.oTitular.setComplemento(txtDocComplemento.Text.Trim())
            oRegTitular.oTitular.setLugarExpedicion(oRegTitular.oLugarExpedicionSeleccionado)
            oRegTitular.oTitular.setTipoAsegurado(oRegTitular.oTipoAseguradoSeleccionado)
            oRegTitular.oTitular.setEmpresa(oRegTitular.oEmpresaSeleccionada)

            oRegTitular.oTitular.setFechaContratacion(dpcFechaContratacion.Value)
            oRegTitular.oTitular.setCargo(oRegTitular.oCargoSeleccionado)
            oRegTitular.fechaPresentacion = dpcFechaPresentacion.Value



            Try
                oRegTitular.oTitular.setSalario(Int64.Parse(txtSalario.Text.Trim()))
            Catch ex As Exception
                oRegTitular.oTitular.setSalario(0)
            End Try


            oRegTitular.oTitular.setTipoContratacion(tipoContratacion)

            If chEmpPublica.Checked Then
                Dim oEmpresaAux As Empresa = oRegTitular.oTitular.getEmpesa()

                If chProgramaProyecto.Checked Then
                    oEmpresaAux.setProgramaProyecto(oRegTitular.oProgramaProyectoSeleccionado)
                End If

                If chEntidadDesconcentrada.Checked Then
                    oEmpresaAux.setEntidadDesconcentrada(oRegTitular.oEntidadDesconcentradaSeleccionada)
                End If
            End If




            oRegTitular.oTitular.setTelefono(txtTelefono.Text.Trim())
            oRegTitular.oTitular.setTelefonoReferencia(txtTelefonoReferencia.Text.Trim())
            oRegTitular.oTitular.setDepartamentoResidencia(oRegTitular.oDepartamentoResidenciaSeleccionado)
            oRegTitular.oTitular.setProvinciaResidencia(oRegTitular.oProvinciaResidenciaSeleccionada)


            oRegTitular.oTitular.setTelefonoLaboral(txtTelefonoLaboral.Text.Trim())
            oRegTitular.oTitular.setDireccionLaboral(txtDireccionLaboral.Text.Trim())
            oRegTitular.oTitular.setDepartamentoLaboral(oRegTitular.oDptoLaboralSeleccionado)
            oRegTitular.oTitular.setProvinciaLaboral(oRegTitular.oProvinciaLaboralSeleccionada)
            oRegTitular.oTitular.setLocalidadLaboral(txtLocalidadLaboral.Text.Trim())

            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try

    End Function

    Private Sub insertDatos()
        Dim respuesta As Int16
        respuesta = oRegTitular.guardarTitular()
        respuesta = oRegTitular.guardarDatosPersonales()
        respuesta = oRegTitular.guardarAvisoAfiliacion()

        If respuesta < 0 Then
            mostrarMensaje("Hubo un error al guardar los datos.")
        Else
            mostrarMensaje("Los datos se guardaron correctamente.")
            reiniciarFormulario()
        End If
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub








    'EVENTOS GRUPO 0
    Private Sub toolStripRegistrar_Click(sender As Object, e As EventArgs) Handles toolStripRegistrar.Click
        reiniciarFormulario()
    End Sub

    Private Sub toolStripEditar_Click(sender As Object, e As EventArgs) Handles toolStripEditar.Click
        reiniciarFormulario()
        cambiarAlModoEditar()
    End Sub


    'EVENTOS GRUPO 1  
    Private Sub txtApellidoPaterno_TextChanged(sender As Object, e As EventArgs) Handles txtApellidoPaterno.TextChanged
        reiniciarTxtMatricula()
    End Sub

    Private Sub txtApeliidoMaterno_TextChanged(sender As Object, e As EventArgs) Handles txtApeliidoMaterno.TextChanged
        reiniciarTxtMatricula()
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged
        reiniciarTxtMatricula()
    End Sub

    Private Sub dpcFechaNacmiento_ValueChanged(sender As Object, e As EventArgs) Handles dpcFechaNacmiento.ValueChanged
        reiniciarTxtMatricula()
    End Sub

    Private Sub dpcFechaNacmiento_KeyUp(sender As Object, e As KeyEventArgs) Handles dpcFechaNacmiento.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmboxTipoSangre.Focus()
        End If
    End Sub


    Private Sub cboxNacionalidad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxNacionalidad.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxNacionalidad.SelectedIndex
            seleccionarNacionalidad(index)
            hintNacionalidad.Visible = False

            If Not cboxNacionalidad.SelectedItem = "BOLIVIANA" Then
                cboxLugarNacimiento.SelectedItem = "EXTRANJERO"
                index = cboxLugarNacimiento.SelectedIndex
                seleccionarLugarNacimiento(index)
                hintLugarNacimiento.Visible = False
                cboxLugarNacimiento.Enabled = False
            Else
                poblarCboxLugarNacimiento()
                hintLugarNacimiento.Visible = True
                oRegTitular.oLugarNacimientoSeleccionado = Nothing
                cboxLugarNacimiento.Enabled = True
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxLugarNacimiento_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxLugarNacimiento.SelectionChangeCommitted
        Try
            If cboxNacionalidad.SelectedItem = "BOLIVIANA" And cboxLugarNacimiento.SelectedItem = "EXTRANJERO" Then
                poblarCboxLugarNacimiento()
                hintLugarNacimiento.Visible = True
                oRegTitular.oLugarNacimientoSeleccionado = Nothing

                Return
            End If

            Dim index As Int16 = cboxLugarNacimiento.SelectedIndex
            seleccionarLugarNacimiento(index)
            hintLugarNacimiento.Visible = False
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub cmboxTipoSangre_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxTipoSangre.SelectionChangeCommitted
        Try
            Dim index As Int16 = cmboxTipoSangre.SelectedIndex
            seleccionarTipoSangre(index)
            hintTipoSangre.Visible = False
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub rButtonMasculino_CheckedChanged_1(sender As Object, e As EventArgs) Handles rButtonMasculino.CheckedChanged
        If rButtonMasculino.Checked Then
            sexoSeleccionado = "M"
            reiniciarTxtMatricula()
        End If
    End Sub

    Private Sub rButtonFemenino_CheckedChanged_1(sender As Object, e As EventArgs) Handles rButtonFemenino.CheckedChanged
        If rButtonFemenino.Checked Then
            sexoSeleccionado = "F"
            reiniciarTxtMatricula()
        End If
    End Sub

    Private Sub cboxEstadoCivil_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxEstadoCivil.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxEstadoCivil.SelectedIndex
            seleccionarEstadoCivil(index)
            hintEstadoCivil.Visible = False
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerarMatricula_Click(sender As Object, e As EventArgs) Handles btnGenerarMatricula.Click
        Try
            Dim fechaNac As Date = dpcFechaNacmiento.Value
            Dim apPaterno As String = txtApellidoPaterno.Text.Trim()
            Dim apMaterno As String = txtApeliidoMaterno.Text.Trim()
            Dim nombres As String = txtNombres.Text.Trim()
            Dim sexo As Char = sexoSeleccionado

            Dim mensajeValidacion As String = oRegTitular.validarEntradasGenerarMatricula(fechaNac, apPaterno, nombres, sexo)

            If Not mensajeValidacion = "" Then
                mostrarMensaje(mensajeValidacion)
            Else
                Dim matricula As String = oRegTitular.generarMatricula(fechaNac, apPaterno, apMaterno, nombres, sexo)
                txtMatricula.Text = matricula
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS GRUPO 2
    Private Sub cmboxDocTipo_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles cmboxDocTipo.SelectionChangeCommitted
        Try
            Dim index As Int16 = cmboxDocTipo.SelectedIndex
            seleccionarTipoDocumento(index)
            hintDocTipo.Visible = False

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cmboxDocLugarExpedicion_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles cmboxDocLugarExpedicion.SelectionChangeCommitted
        Try
            Dim index As Int16 = cmboxDocLugarExpedicion.SelectedIndex
            seleccionarLugarExpedicion(index)
            hintDocLugarExpedicion.Visible = False
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS GRUPO 3
    Private Sub cmboxTipoAsegurado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxTipoAsegurado.SelectionChangeCommitted
        Try
            Dim index As Int16 = cmboxTipoAsegurado.SelectedIndex
            seleccionarTipoAsegurado(index)
            hintTipoAsegurado.Visible = False
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub btnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpresa.Click
        Dim empresa As String = txtBuscarEmpresa.Text.Trim

        If Not empresa = "" Then
            oRegTitular.traerEmpresas(empresa)
            poblarCboxEmpresas()
            hintEmpresa.Visible = True
        Else
            mostrarMensaje("Error. Ingrese el nombre de la empresa que desea buscar.")
        End If

    End Sub

    Private Sub cboxEmpresa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxEmpresa.SelectionChangeCommitted
        Try
            reiniciarControlesEmpresaPublica()

            Dim index As Int16 = cboxEmpresa.SelectedIndex
            seleccionarEmpresa(index)
            hintEmpresa.Visible = False

            If oRegTitular.esEmpresaPublica() Then
                tickearChEmpresaPublica()

                oRegTitular.traerProgramaProyecto()
                poblarCboxProgramaProyecto()

                oRegTitular.traerEntidadDesconcentrada()
                poblarCboxEntidadDesconcentrada()

            End If
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxCargo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxCargo.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxCargo.SelectedIndex
            seleccionarCargo(index)
            hintCargo.Visible = False
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub rButtonFijo_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonFijo.CheckedChanged
        If rButtonFijo.Checked Then
            tipoContratacion = 1
        End If
    End Sub

    Private Sub rButtonEventual_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonEventual.CheckedChanged
        If rButtonEventual.Checked Then
            tipoContratacion = 2
        End If
    End Sub

    Private Sub ckEmpresaPublica_CheckedChanged(sender As Object, e As EventArgs) Handles chEmpPublica.CheckedChanged
        If chEmpPublica.Checked Then
            panelEmpPublica.Enabled = True
        Else
            panelEmpPublica.Enabled = False
        End If
    End Sub

    Private Sub chProgramaProyecto_CheckedChanged(sender As Object, e As EventArgs) Handles chProgramaProyecto.CheckedChanged
        If chProgramaProyecto.Checked Then
            cboxProgramaProyecto.Enabled = True
            hintProgramaProyecto.Enabled = True
        Else
            cboxProgramaProyecto.Enabled = False
            hintProgramaProyecto.Enabled = False


            cboxProgramaProyecto.SelectedIndex = -1
            hintProgramaProyecto.Visible = True
            oRegTitular.oProgramaProyectoSeleccionado = Nothing
        End If
    End Sub

    Private Sub chEntidadDesconcentrada_CheckedChanged(sender As Object, e As EventArgs) Handles chEntidadDesconcentrada.CheckedChanged
        If chEntidadDesconcentrada.Checked Then
            cboxEntidadDesconcentrada.Enabled = True
            hintEntidadDesconcentrada.Enabled = True
        Else
            cboxEntidadDesconcentrada.Enabled = False
            hintEntidadDesconcentrada.Enabled = False

            cboxEntidadDesconcentrada.SelectedIndex = -1
            hintEntidadDesconcentrada.Visible = True
            oRegTitular.oEntidadDesconcentradaSeleccionada = Nothing
        End If

    End Sub

    Private Sub cboxProgramaProyecto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxProgramaProyecto.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxProgramaProyecto.SelectedIndex
            seleccionarProgramaProyecto(index)
            hintProgramaProyecto.Visible = False

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxEntidadDesconcentrada_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxEntidadDesconcentrada.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxEntidadDesconcentrada.SelectedIndex
            seleccionarEntidadDesconcentrada(index)
            hintEntidadDesconcentrada.Visible = False

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub




    'EVENTOS GRUPO 4
    Private Sub cmboxDepartamento_SelectionChangeCommitted_1(sender As Object, e As EventArgs) Handles cmboxDepartamento.SelectionChangeCommitted
        Try
            Dim index As Int16 = cmboxDepartamento.SelectedIndex()
            seleccionarDepartamento(index)
            hintDepartamento.Visible = False

            oRegTitular.traerProvincias()
            poblarCboxProvincias()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cmboxProvincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxProvincia.SelectionChangeCommitted
        Try
            Dim index As Int16 = cmboxProvincia.SelectedIndex
            seleccionarProvincia(index)
            hintProvincia.Visible = False

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub




    'EVENTOS  GRUPO 5
    Private Sub cboxDptoLaboral_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxDptoLaboral.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxDptoLaboral.SelectedIndex()
            seleccionarDptoLaboral(index)
            hintDptoLaboral.Visible = False

            oRegTitular.traerProvinciasLaborales()
            poblarCboxProvinciaLaboral()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxProvinciaLaboral_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxProvinciaLaboral.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxProvinciaLaboral.SelectedIndex()
            seleccionarProvinciaLaboral(index)
            hintProvinciaLaboral.Visible = False
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub




    'EVENTOS  GRUPO 6
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim modoFormulario As Int16 = oRegTitular.oModoFormuario

        If modoFormulario = 1 Then
            registrarDatos()

        ElseIf modoFormulario = 2 Then
            editarDatos()
        End If
    End Sub














    '[MODO EDITAR] METODOS INICIO
    Private Sub cambiarAlModoEditar()
        oRegTitular.oModoFormuario = 2

        toolStripRegistrar.BackColor = Color.FromArgb(250, 250, 250)
        toolStripEditar.BackColor = Color.FromArgb(69, 143, 255)


        panelDatosPersonales.Enabled = True
        txtApellidoPaterno.Enabled = False
        txtApeliidoMaterno.Enabled = False
        txtNombres.Enabled = False
        txtMatricula.Enabled = True
        txtMatricula.ReadOnly = False


        cboxNacionalidad.Enabled = False
        hintNacionalidad.Enabled = False
        cboxLugarNacimiento.Enabled = False
        hintLugarNacimiento.Enabled = False
        dpcFechaNacmiento.Enabled = False
        cmboxTipoSangre.Enabled = False
        hintTipoSangre.Enabled = False


        panelSexo.Enabled = False
        cboxEstadoCivil.Enabled = False
        hintEstadoCivil.Enabled = False
        txtLocalidad.Enabled = True


        txtZona.Enabled = True
        txtCalle.Enabled = True
        edHintTitular.Enabled = True
        btnGenerarMatricula.Enabled = False


        panelDatosDocumento.Enabled = False
        panelInformacionContacto.Enabled = False
        panelDatosAfiliacion.Enabled = False


        panelInformacionContacto.Enabled = True
        txtTelefono.Enabled = True
        txtTelefonoReferencia.Enabled = True
        cmboxDepartamento.Enabled = False
        hintDepartamento.Enabled = False
        cmboxProvincia.Enabled = False
        hintProvincia.Enabled = False


        panelInformacionContactoLaboral.Enabled = False
        edCboxTitular.Visible = True
        edHintTitular.Visible = True
    End Sub

    '[MODO EDITAR] METODOS INTERFAZ
    Private Sub edPoblarCboxTitulares()
        edCboxTitular.Items.Clear()


        For Each titular As Titular In oRegTitular.edListaTitulares
            edCboxTitular.Items.Add(titular.getMatricula() + " | " + titular.getApellidoPaterno() + " " + titular.getApellidoMaterno() + " " + titular.getNombres())
        Next
    End Sub

    Private Sub edMostrarDatosParaEditar()
        txtApeliidoMaterno.Text = oRegTitular.edOtitularSeleccionado.getApellidoMaterno()
        txtApellidoPaterno.Text = oRegTitular.edOtitularSeleccionado.getApellidoPaterno()
        txtNombres.Text = oRegTitular.edOtitularSeleccionado.getNombres()
        txtLocalidad.Text = oRegTitular.edOtitularSeleccionado.getLocalidad()
        txtZona.Text = oRegTitular.edOtitularSeleccionado.getZona()
        txtCalle.Text = oRegTitular.edOtitularSeleccionado.getCalle()
        txtNroCasa.Text = oRegTitular.edOtitularSeleccionado.getNroCasa()

        txtTelefono.Text = oRegTitular.edOtitularSeleccionado.getTelefono()
        txtTelefonoReferencia.Text = oRegTitular.edOtitularSeleccionado.getTelefonoReferencia()
    End Sub

    '[MODO EDITAR] METODOS LOGICOS
    Private Sub edSeleccionarTitularParaEditar(ByVal _index As Int16)
        oRegTitular.edOtitularSeleccionado = oRegTitular.edListaTitulares(_index)
    End Sub

    Private Sub editarDatos()
        Dim edDatosCargados As Boolean = edCargarDatos()

        If edDatosCargados Then
            Dim edMensajeValidacion As String = oRegTitular.edValidarEntradas()
            If Not edMensajeValidacion = "" Then mostrarMensaje(edMensajeValidacion) Else updateDatos()
        End If
    End Sub

    Private Function edCargarDatos()
        Try
            Dim localidad As String = txtLocalidad.Text.Trim()
            Dim zona As String = txtZona.Text.Trim()
            Dim calle As String = txtCalle.Text.Trim()
            Dim nroCasa As String = txtNroCasa.Text.Trim()
            Dim telefono As String = txtTelefono.Text.Trim()
            Dim telefonoRef As String = txtTelefonoReferencia.Text.Trim()

            Dim titularAux As Titular = oRegTitular.edOtitularSeleccionado
            titularAux.setMatricula(oRegTitular.edOtitularSeleccionado.getMatricula())
            titularAux.setLocalidad(localidad)
            titularAux.setZona(zona)
            titularAux.setCalle(calle)
            titularAux.setNroCasa(nroCasa)
            titularAux.setTelefono(telefono)
            titularAux.setTelefonoReferencia(telefonoRef)

            oRegTitular.oTitular = titularAux
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub updateDatos()
        Dim respuesta As Int16
        respuesta = oRegTitular.edActualizarDatos(Me.Text)

        If respuesta < 0 Then
            mostrarMensaje("Hubo un error al actualizar los datos.")
        Else
            mostrarMensaje("Los datos se actualizaron correctamente.")
            reiniciarFormulario()
            cambiarAlModoEditar()
        End If
    End Sub



    '[MODO EDITAR] EVENTOS 
    Private Sub txtMatricula_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMatricula.KeyUp
        Dim modoFormilario As Int16 = oRegTitular.oModoFormuario

        If e.KeyCode = Keys.Enter And modoFormilario = 2 Then
            Try
                Dim matricula As String = txtMatricula.Text.Trim()
                oRegTitular.edTraerTitulares(matricula)
                edPoblarCboxTitulares()
                edHintTitular.Visible = True

            Catch ex As Exception
                mostrarMensaje(ex.Message)
            End Try
        End If

    End Sub

    Private Sub edCboxTitular_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles edCboxTitular.SelectionChangeCommitted
        Try
            Dim index As Int16 = edCboxTitular.SelectedIndex
            edSeleccionarTitularParaEditar(index)
            oRegTitular.edTraerDatosParaEditar(oRegTitular.edOtitularSeleccionado.getMatricula())
            edMostrarDatosParaEditar()
            edHintTitular.Visible = False
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


End Class