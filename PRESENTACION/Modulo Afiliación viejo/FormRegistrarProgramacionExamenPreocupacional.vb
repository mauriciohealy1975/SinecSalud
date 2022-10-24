Imports NEGOCIO
Public Class FormRegistrarProgramacionExamenPreocupacional

    'ATRIBUTOS LOGICOS
    Private regProgEP As RegistroProgramacionExamenPreocupacional

    'ATRIBUTOS G1
    Private titularSeleccionado As Titular
    Private empresaMasRecienteTitular As Empresa
    Private esNuevoTitular As Boolean
    Private sexoSeleccionado As Char
    Private esNuevaEmpresa As Boolean
    Private empresaSeleccionada As Empresa
    Private esTitularEnProvincia As Boolean



    'METODOS INICIO

    Private Sub FormRegistrarProgramacionExamenPreocupacional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Private Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
    End Sub

    Private Sub configurarDisplay()
        Dim ejeX As Int16 = Utilitarios.resolucionEstandarEjeX
        Dim ejeY As Int16 = Utilitarios.resolucionEstandarEjeY

        Size = New Size(ejeX, ejeY)
        'MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        MaximumSize = New System.Drawing.Size(ejeX, ejeY)
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarControles()
        iniciarControlesLogicos()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()
        iniciarParametros()
    End Sub

    Private Sub iniciarControlesLogicos()
        regProgEP = New RegistroProgramacionExamenPreocupacional()
        titularSeleccionado = New Titular()
        empresaMasRecienteTitular = New Empresa()
        esNuevoTitular = False
        sexoSeleccionado = ""
        esNuevaEmpresa = False
        empresaSeleccionada = New Empresa()
        esTitularEnProvincia = False
    End Sub

    Private Sub iniciarControlesGrupo1()
        'c1
        txtBuscarMatricula.Enabled = True
        txtBuscarMatricula.Visible = True
        txtBuscarMatricula.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarMatricula.Text = ""
        txtBuscarMatricula.CharacterCasing = CharacterCasing.Upper

        btnBuscarPorMatricula.Enabled = True
        btnBuscarPorMatricula.Visible = True
        btnBuscarPorMatricula.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarPorMatricula.Text = "Buscar"

        cboxTitulares.Enabled = True
        cboxTitulares.Visible = True
        cboxTitulares.Font = New Font("Microsoft Sans Serif", 8)
        cboxTitulares.Items.Clear()
        cboxTitulares.DropDownStyle = ComboBoxStyle.DropDownList

        hintTitulares.Enabled = True
        hintTitulares.Visible = True
        hintTitulares.Font = New Font("Microsoft Sans Serif", 8)
        hintTitulares.Text = "SELECCIONAR"
        hintTitulares.BackColor = Color.Transparent

        lblTitular.Enabled = True
        lblTitular.Visible = True
        lblTitular.Font = New Font("Microsoft Sans Serif", 9.5)
        lblTitular.Text = "Asegurado"

        txtTitular.Enabled = True
        txtTitular.Visible = True
        txtTitular.ReadOnly = True
        txtTitular.Font = New Font("Microsoft Sans Serif", 9)
        txtTitular.Text = ""
        txtTitular.CharacterCasing = CharacterCasing.Upper

        lblEmpresa.Enabled = True
        lblEmpresa.Visible = True
        lblEmpresa.Font = New Font("Microsoft Sans Serif", 9.5)
        lblEmpresa.Text = "Último empleador"

        txtEmpresa.Enabled = True
        txtEmpresa.Visible = True
        txtEmpresa.ReadOnly = True
        txtEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        txtEmpresa.Text = ""
        txtEmpresa.CharacterCasing = CharacterCasing.Upper

        lblCiAntiguoTitular.Enabled = True
        lblCiAntiguoTitular.Visible = True
        lblCiAntiguoTitular.Font = New Font("Microsoft Sans Serif", 9.5)
        lblCiAntiguoTitular.Text = "Carnet Indentidad"


        txtCiAntiguoTitular.Enabled = True
        txtCiAntiguoTitular.Visible = True
        txtCiAntiguoTitular.ReadOnly = False
        txtCiAntiguoTitular.Font = New Font("Microsoft Sans Serif", 9)
        txtCiAntiguoTitular.Text = ""
        txtCiAntiguoTitular.CharacterCasing = CharacterCasing.Upper

        lblLugarExpedicionAntiguoTitular.Enabled = True
        lblLugarExpedicionAntiguoTitular.Visible = True
        lblLugarExpedicionAntiguoTitular.Font = New Font("Microsoft Sans Serif", 9.5)
        lblLugarExpedicionAntiguoTitular.Text = "Lugar expedición"

        cboxLugarExpedicionAntiguoTitular.Enabled = True
        cboxLugarExpedicionAntiguoTitular.Visible = True
        cboxLugarExpedicionAntiguoTitular.Font = New Font("Microsoft Sans Serif", 8)
        cboxLugarExpedicionAntiguoTitular.Text = ""
        'cboxLugarExpedicionAntiguoTitular.Items.Clear()
        'cboxLugarExpedicionAntiguoTitular.DropDownStyle = ComboBoxStyle.DropDownList

        hintLugarExpedicionAntiguoTitular.Enabled = True
        hintLugarExpedicionAntiguoTitular.Visible = False
        hintLugarExpedicionAntiguoTitular.Font = New Font("Microsoft Sans Serif", 8)
        hintLugarExpedicionAntiguoTitular.Text = "SELECCIONAR"
        hintLugarExpedicionAntiguoTitular.BackColor = Color.Transparent




        'c2
        chNuevoTitular.Enabled = True
        chNuevoTitular.Visible = True
        chNuevoTitular.Checked = False
        chNuevoTitular.Font = New Font("Microsoft Sans Serif", 9)
        chNuevoTitular.Text = "Nuevo titular"

        lblApellidoPaterno.Enabled = False
        lblApellidoPaterno.Visible = True
        lblApellidoPaterno.Font = New Font("Microsoft Sans Serif", 9.5)
        lblApellidoPaterno.Text = "Apellido paterno"

        txtApellidoPaterno.Enabled = False
        txtApellidoPaterno.Visible = True
        txtApellidoPaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApellidoPaterno.Text = ""
        txtApellidoPaterno.CharacterCasing = CharacterCasing.Upper

        lblApellidoMaterno.Enabled = False
        lblApellidoMaterno.Visible = True
        lblApellidoMaterno.Font = New Font("Microsoft Sans Serif", 9.5)
        lblApellidoMaterno.Text = "Apellido materno"

        txtApellidoMaterno.Enabled = False
        txtApellidoMaterno.Visible = True
        txtApellidoMaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApellidoMaterno.Text = ""
        txtApellidoMaterno.CharacterCasing = CharacterCasing.Upper

        lblNombres.Enabled = False
        lblNombres.Visible = True
        lblNombres.Font = New Font("Microsoft Sans Serif", 9.5)
        lblNombres.Text = "Nombres"

        txtNombres.Enabled = False
        txtNombres.Visible = True
        txtNombres.Font = New Font("Microsoft Sans Serif", 9)
        txtNombres.Text = ""
        txtNombres.CharacterCasing = CharacterCasing.Upper

        lblMatricula.Enabled = False
        lblMatricula.Visible = True
        lblMatricula.Font = New Font("Microsoft Sans Serif", 9.5)
        lblMatricula.Text = "Matrícula"

        txtMatricula.Enabled = False
        txtMatricula.Visible = True
        txtMatricula.Font = New Font("Microsoft Sans Serif", 9)
        txtMatricula.Text = ""
        txtMatricula.CharacterCasing = CharacterCasing.Upper


        lblSexo.Enabled = False

        rButtonMasculino.Enabled = False
        rButtonMasculino.Visible = True
        rButtonMasculino.Checked = False

        rButtonFemenino.Enabled = False
        rButtonFemenino.Visible = True
        rButtonFemenino.Checked = False

        lblFechaNacimiento.Enabled = False

        dpcFechaNacimiento.Enabled = False
        dpcFechaNacimiento.ShowUpDown = False
        dpcFechaNacimiento.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaNacimiento.Format = DateTimePickerFormat.Custom
        dpcFechaNacimiento.CustomFormat = "dd--MM--yyyy"
        dpcFechaNacimiento.Value = Date.Today



        'c3
        lblCiNuevoTitular.Enabled = False
        lblCiNuevoTitular.Visible = True
        lblCiNuevoTitular.Font = New Font("Microsoft Sans Serif", 9.5)
        lblCiNuevoTitular.Text = "Carnet Indentidad"

        txtCiNuevoTitular.Enabled = False
        txtCiNuevoTitular.Visible = True
        txtCiNuevoTitular.ReadOnly = False
        txtCiNuevoTitular.Font = New Font("Microsoft Sans Serif", 9)
        txtCiNuevoTitular.Text = ""
        txtCiNuevoTitular.CharacterCasing = CharacterCasing.Upper

        lblLugarExpedicionNuevoTitular.Enabled = False
        lblLugarExpedicionNuevoTitular.Visible = True
        lblLugarExpedicionNuevoTitular.Font = New Font("Microsoft Sans Serif", 9.5)
        lblLugarExpedicionNuevoTitular.Text = "Lugar expedición"

        cboxLugarExpedicionNuevoTitular.Enabled = False
        cboxLugarExpedicionNuevoTitular.Visible = True
        cboxLugarExpedicionNuevoTitular.Font = New Font("Microsoft Sans Serif", 8)
        'cboxLugarExpedicionNuevoTitular.Items.Clear()
        cboxLugarExpedicionNuevoTitular.DropDownStyle = ComboBoxStyle.DropDownList

        hintLugarExpedicionNuevoTitular.Enabled = False
        hintLugarExpedicionNuevoTitular.Visible = True
        hintLugarExpedicionNuevoTitular.Font = New Font("Microsoft Sans Serif", 8)
        hintLugarExpedicionNuevoTitular.Text = "SELECCIONAR"
        hintLugarExpedicionNuevoTitular.BackColor = Color.Transparent

        chNuevaEmpresa.Enabled = True
        chNuevaEmpresa.Visible = True
        chNuevaEmpresa.Checked = False
        chNuevaEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        chNuevaEmpresa.Text = "Nueva empresa"

        lblBuscarEmpresa.Enabled = False
        lblBuscarEmpresa.Visible = True
        lblBuscarEmpresa.Font = New Font("Microsoft Sans Serif", 9.5)
        lblBuscarEmpresa.Text = "Empresa"

        txtBuscarEmpresa.Enabled = False
        txtBuscarEmpresa.Visible = True
        txtBuscarEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarEmpresa.Text = ""
        txtBuscarEmpresa.CharacterCasing = CharacterCasing.Upper

        btnBuscarEmpresa.Enabled = False
        btnBuscarEmpresa.Visible = True
        btnBuscarEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarEmpresa.Text = "Buscar"

        cboxEmpresa.Enabled = False
        cboxEmpresa.Visible = True
        cboxEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        cboxEmpresa.Items.Clear()
        cboxEmpresa.DropDownStyle = ComboBoxStyle.DropDownList

        hintEmpresa.Enabled = False
        hintEmpresa.Visible = True
        hintEmpresa.Font = New Font("Microsoft Sans Serif", 8)
        hintEmpresa.Text = "SELECCIONAR"
        hintEmpresa.BackColor = Color.Transparent
    End Sub

    Private Sub iniciarControlesGrupo2()
        chTitularEnProvincia.Enabled = True
        chTitularEnProvincia.Visible = True
        chTitularEnProvincia.Checked = False
        chTitularEnProvincia.Font = New Font("Microsoft Sans Serif", 9)
        chTitularEnProvincia.Text = "Asegurado en provincia"

        dpcFechaLaboratorio.Enabled = True
        dpcFechaLaboratorio.ShowUpDown = False
        dpcFechaLaboratorio.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaLaboratorio.Format = DateTimePickerFormat.Custom
        dpcFechaLaboratorio.CustomFormat = "dd--MM--yyyy"
        dpcFechaLaboratorio.Value = Date.Today
        dpcFechaLaboratorio.MinDate = Date.Today
        dpcFechaLaboratorio.MaxDate = Date.Today.AddMonths(1)

        lblFechaRayosX.Enabled = True
        lblFechaRayosX.Visible = True
        lblFechaRayosX.Font = New Font("Microsoft Sans Serif", 9.5)
        lblFechaRayosX.Text = "Fecha Rayos X"

        dpcFechaRayosX.Enabled = False
        dpcFechaRayosX.ShowUpDown = False
        dpcFechaRayosX.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaRayosX.Format = DateTimePickerFormat.Custom
        dpcFechaRayosX.CustomFormat = "dd--MM--yyyy"
        dpcFechaRayosX.Value = Date.Today
        dpcFechaRayosX.MinDate = Date.Today

        dpcMedicoLaboral.Enabled = False
        dpcMedicoLaboral.ShowUpDown = False
        dpcMedicoLaboral.Font = New Font("Microsoft Sans Serif", 9)
        dpcMedicoLaboral.Format = DateTimePickerFormat.Custom
        dpcMedicoLaboral.CustomFormat = "dd--MM--yyyy"
        dpcMedicoLaboral.Value = Date.Today
        dpcMedicoLaboral.MinDate = Date.Today

        txtFichasRestantes.Enabled = False
        txtFichasRestantes.Visible = True
        txtFichasRestantes.Font = New Font("Microsoft Sans Serif", 9)
        txtFichasRestantes.Text = ""
        txtFichasRestantes.CharacterCasing = CharacterCasing.Upper

        txtNroComprobantePago.Enabled = True
        txtNroComprobantePago.Visible = True
        txtNroComprobantePago.Font = New Font("Microsoft Sans Serif", 9)
        txtNroComprobantePago.Text = ""
        txtNroComprobantePago.CharacterCasing = CharacterCasing.Upper


        'actualizar fecha lab, para volver a calcular fecha medico laboral
        dpcFechaLaboratorio.Value = Today.AddDays(1)
        dpcFechaLaboratorio.Value = Today.Date
    End Sub

    Private Sub iniciarControlesGrupo3()
        btnCancelar.Enabled = True
        btnCancelar.Visible = True
        btnCancelar.Font = New Font("Microsoft Sans Serif", 9)
        btnCancelar.Text = "Cancelar"

        btnEnviar.Enabled = True
        btnEnviar.Visible = True
        btnEnviar.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviar.Text = "Registrar programación"
    End Sub

    Private Sub iniciarParametros()
        regProgEP.traerParametrosRangoDiasLaboral()
    End Sub









    'METODOS INTERFAZ G1 - C1
    Private Sub poblarCboxTitulares()
        cboxTitulares.Items.Clear()

        For Each titular As Titular In regProgEP.titulares
            'cboxTitulares.Items.Add(titular.getMatricula() + " | " + titular.getApellidoPaterno() + " " + titular.getApellidoMaterno() + " " + titular.getNombres())
            cboxTitulares.Items.Add(titular.getMatricula() + " | " + titular.getNombres())
        Next
    End Sub

    Private Sub deshabilitarControlesBuscarTitular()
        lblBuscarMatricula.Enabled = False
        txtBuscarMatricula.Enabled = False
        btnBuscarPorMatricula.Enabled = False
        cboxTitulares.Enabled = False
        deshabilitarHintTitulares()
        lblTitular.Enabled = False
        lblEmpresa.Enabled = False
        lblCiAntiguoTitular.Enabled = False
        txtCiAntiguoTitular.Enabled = False
        lblLugarExpedicionAntiguoTitular.Enabled = False
        cboxLugarExpedicionAntiguoTitular.Enabled = False
    End Sub

    Private Sub habilitarControlesBusquedaTitular()
        lblBuscarMatricula.Enabled = True
        txtBuscarMatricula.Enabled = True
        btnBuscarPorMatricula.Enabled = True
        cboxTitulares.Enabled = True
        habilitarHintTitulares()
        lblTitular.Enabled = True
        lblEmpresa.Enabled = True
        lblCiAntiguoTitular.Enabled = True
        txtCiAntiguoTitular.Enabled = True
        lblLugarExpedicionAntiguoTitular.Enabled = True
        cboxLugarExpedicionAntiguoTitular.Enabled = True
    End Sub

    Private Sub reiniciarControlesBusquedaTitular()
        txtBuscarMatricula.Text = ""
        cboxTitulares.SelectedIndex = -1
        mostrarHintTitulares()
        txtTitular.Text = ""
        txtEmpresa.Text = ""
        txtCiAntiguoTitular.Text = ""
        cboxLugarExpedicionAntiguoTitular.Text = ""
    End Sub

    Private Sub mostrarInformacionTitular()
        'Dim apPaterno As String = titularSeleccionado.getApellidoPaterno()
        'Dim apMaterno As String = titularSeleccionado.getApellidoMaterno() 
        'Dim nombres As String = titularSeleccionado.getNombres()
        'Dim matricula As String = titularSeleccionado.getMatricula()
        'Dim nomEmpresa As String = titularSeleccionado.getEmpesa().getNombre()

        'txtApellidoPaterno.Text = apPaterno
        'txtApellidoMaterno.Text = apMaterno
        'txtNombres.Text = nombres
        txtTitular.Text = titularSeleccionado.getNombres()
        txtEmpresa.Text = titularSeleccionado.getEmpesa().getNombre()
        txtCiAntiguoTitular.Text = titularSeleccionado.getNroDocumento()
        cboxLugarExpedicionAntiguoTitular.Text = titularSeleccionado.getLugarExpedicion().getDescripcion()
    End Sub

    Private Sub deshabilitarHintTitulares()
        hintTitulares.Enabled = False
    End Sub

    Private Sub habilitarHintTitulares()
        hintTitulares.Enabled = True
    End Sub

    Private Sub ocultarHintTitulares()
        hintTitulares.Visible = False
    End Sub

    Private Sub mostrarHintTitulares()
        hintTitulares.Visible = True
    End Sub

    'C2
    Private Sub deshabilitarControlesNuevoTItular()
        lblApellidoPaterno.Enabled = False
        txtApellidoPaterno.Enabled = False

        lblApellidoMaterno.Enabled = False
        txtApellidoMaterno.Enabled = False

        lblNombres.Enabled = False
        txtNombres.Enabled = False

        lblMatricula.Enabled = False
        txtMatricula.Enabled = False

        lblSexo.Enabled = False
        rButtonMasculino.Enabled = False
        rButtonFemenino.Enabled = False

        lblFechaNacimiento.Enabled = False
        dpcFechaNacimiento.Enabled = False

        lblCiNuevoTitular.Enabled = False
        txtCiNuevoTitular.Enabled = False

        lblLugarExpedicionNuevoTitular.Enabled = False
        cboxLugarExpedicionNuevoTitular.Enabled = False
        hintLugarExpedicionNuevoTitular.Enabled = False
    End Sub

    Private Sub habilitarControlesNuevoTitular()
        lblApellidoPaterno.Enabled = True
        txtApellidoPaterno.Enabled = True
        lblApellidoMaterno.Enabled = True
        txtApellidoMaterno.Enabled = True
        lblNombres.Enabled = True
        txtNombres.Enabled = True
        lblMatricula.Enabled = True
        txtMatricula.Enabled = True
        lblSexo.Enabled = True
        rButtonMasculino.Enabled = True
        rButtonFemenino.Enabled = True
        lblFechaNacimiento.Enabled = True
        dpcFechaNacimiento.Enabled = True
        lblCiNuevoTitular.Enabled = True
        txtCiNuevoTitular.Enabled = True
        lblLugarExpedicionNuevoTitular.Enabled = True
        cboxLugarExpedicionNuevoTitular.Enabled = True
        hintLugarExpedicionNuevoTitular.Enabled = True
    End Sub

    Private Sub reiniciarControlesNuevoTitular()
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtNombres.Text = ""
        txtMatricula.Text = ""
        rButtonMasculino.Checked = False
        rButtonFemenino.Checked = False
        dpcFechaNacimiento.Value = Date.Today
        txtCiNuevoTitular.Text = ""
        cboxLugarExpedicionNuevoTitular.SelectedIndex = -1
        hintLugarExpedicionNuevoTitular.Visible = True
    End Sub

    'C3
    Private Sub poblarCboxEmpresa()
        cboxEmpresa.Items.Clear()

        For Each empresa As Empresa In regProgEP.empresas
            cboxEmpresa.Items.Add(empresa.getNombre())
        Next
    End Sub

    Private Sub deshabilitarControlesNuevaEmpresa()
        lblBuscarEmpresa.Enabled = False
        txtBuscarEmpresa.Enabled = False
        btnBuscarEmpresa.Enabled = False
        cboxEmpresa.Enabled = False
        deshabilitarHintEmpresa()
    End Sub

    Private Sub habilitarControlesNuevaEmpresa()
        lblBuscarEmpresa.Enabled = True
        txtBuscarEmpresa.Enabled = True
        btnBuscarEmpresa.Enabled = True
        cboxEmpresa.Enabled = True
        habilitarHintEmpresa()
    End Sub

    Private Sub reiniciarControlesNuevaEmpresa()
        txtBuscarEmpresa.Text = ""
        cboxEmpresa.SelectedIndex = -1
        mostrarHintEmpresa()
    End Sub

    Private Sub deshabilitarChNuevaEmpresa()
        chNuevaEmpresa.Enabled = False
    End Sub

    Private Sub habilitarChNuevaEmpresa()
        chNuevaEmpresa.Enabled = True
    End Sub

    Private Sub checkearChNuevaEmpresa()
        chNuevaEmpresa.Checked = True
    End Sub

    Private Sub deshabilitarHintEmpresa()
        hintEmpresa.Enabled = False
    End Sub

    Private Sub habilitarHintEmpresa()
        hintEmpresa.Enabled = True
    End Sub

    Private Sub ocultarHintEmpresa()
        hintEmpresa.Visible = False
    End Sub

    Private Sub mostrarHintEmpresa()
        hintEmpresa.Visible = True
    End Sub


    'METODOS INTERFAZ G2
    Private Sub mostrarFichasRestantes()
        txtFichasRestantes.Text = regProgEP.fichasDisponibles.ToString()
    End Sub

    Private Sub actualizarFechaRayosX()
        Dim fechaLab As Date = dpcFechaLaboratorio.Value
        Dim fechaRayosX As Date = regProgEP.actualizarFechaRayosX(fechaLab)
        dpcFechaRayosX.Value = fechaRayosX
    End Sub

    Private Sub actualizarFechaMedicoLaboral()
        Dim fechaLab As Date = dpcFechaLaboratorio.Value
        Dim fechaMedLaboral As Date = regProgEP.actualizarFechaMedicoLaboral(fechaLab, esTitularEnProvincia)
        dpcMedicoLaboral.Value = fechaMedLaboral
    End Sub


    'METODOS INTERFAZ G3
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub










    'METODOS LOGICOS G1
    Private Sub traerTitulares()
        Dim matricula As String = txtBuscarMatricula.Text.Trim()
        regProgEP.traerTitulares(matricula)
    End Sub

    Private Sub seleccionarTitular()
        Dim index As Int64 = cboxTitulares.SelectedIndex
        titularSeleccionado = regProgEP.titulares(index)
    End Sub

    Private Sub reiniciarTitularSeleccionado()
        titularSeleccionado = New Titular()
    End Sub

    Private Sub cargarEstadoNuevoTitular()
        If chNuevoTitular.Checked Then esNuevoTitular = True Else esNuevoTitular = False
    End Sub

    Private Sub seleccionarSexo()
        If rButtonMasculino.Checked Then
            sexoSeleccionado = "M"
        ElseIf rButtonFemenino.Checked Then
            sexoSeleccionado = "F"
        Else
            sexoSeleccionado = ""
        End If
    End Sub

    Private Sub cargarEstadoNuevaEmpresa()
        If chNuevaEmpresa.Checked Then esNuevaEmpresa = True Else esNuevaEmpresa = False
    End Sub

    Private Sub traerEmpresas()
        Dim nombreEmpresa As String = txtBuscarEmpresa.Text.Trim()
        regProgEP.traerEmpresas(nombreEmpresa)
    End Sub

    Private Sub seleccionarNuevaEmpresa()
        Dim index As Int64 = cboxEmpresa.SelectedIndex
        empresaSeleccionada = regProgEP.empresas(index)
    End Sub

    Private Sub reniciarEmpresaSeleccionada()
        empresaSeleccionada = New Empresa()
    End Sub

    Private Sub seleccionarEmpresaMasRecienteTitular()
        empresaMasRecienteTitular = titularSeleccionado.getEmpesa()
    End Sub


    'METODOS LOGICOS G2
    Private Sub cargarEstadoTitularEnProvincia()
        If chTitularEnProvincia.Checked Then esTitularEnProvincia = True Else esTitularEnProvincia = False
    End Sub

    Private Sub calcularFichasRestantes()
        Dim fechaSeleccionada As Date = dpcMedicoLaboral.Value
        regProgEP.cargarFichasDisponiblesMedicoLaboral(fechaSeleccionada)
    End Sub



    'METODOS LOGICOS G3
    Private Sub guardarProgramacion()
        Dim datosCargados As Boolean = cargarDatos()

        If datosCargados Then
            Dim mensajeValidacion As String = validarEntradas()
            If mensajeValidacion = "" Then insertarProgramacionEP() Else mostrarMensaje(mensajeValidacion)
        End If
    End Sub

    Private Function cargarDatos() As Boolean
        Try
            Dim titular As Titular, empresa As Empresa, fecha As Date, fechaLab As Date, fechaRayosX As Date,
                fechaMedicoLaboral As Date, nroComprobantePago As String, esDeProvincia As Boolean


            If Not esNuevoTitular Then
                Dim ci As String = txtCiAntiguoTitular.Text.Trim()
                Dim luExpedicion As String = cboxLugarExpedicionAntiguoTitular.Text.Trim()
                titularSeleccionado.setNroDocumento(ci)
                titularSeleccionado.setLugarExpedicion(New Concepto(0, 0, luExpedicion))
                titular = titularSeleccionado

            Else
                Dim apPaterno As String = txtApellidoPaterno.Text.Trim()
                Dim apMaterno As String = txtApellidoMaterno.Text.Trim()
                Dim nombres As String = txtNombres.Text.Trim()
                Dim nombreCompleto As String = apPaterno + " " + apMaterno + " " + nombres
                Dim matricula As String = txtMatricula.Text.Trim()
                Dim sexo As Char = sexoSeleccionado
                Dim fechaNacimieinto As Date = dpcFechaNacimiento.Value
                Dim ci As String = txtCiNuevoTitular.Text.Trim()
                Dim luExpedicion As String
                If IsNothing(cboxLugarExpedicionNuevoTitular.SelectedItem) Then
                    luExpedicion = ""
                Else
                    luExpedicion = cboxLugarExpedicionNuevoTitular.SelectedItem.ToString()
                End If

                Dim nuevoTitular As Titular = New Titular()
                nuevoTitular.setApellidoPaterno(apPaterno)
                nuevoTitular.setApellidoMaterno(apMaterno)
                nuevoTitular.setNombres(nombres)
                nuevoTitular.setNombres(nombreCompleto)
                nuevoTitular.setSexo(sexo)
                nuevoTitular.setFechaNacimiento(fechaNacimieinto)
                nuevoTitular.setMatricula(matricula)
                nuevoTitular.setNroDocumento(ci)
                nuevoTitular.setLugarExpedicion(New Concepto(0, 0, luExpedicion))

                titular = nuevoTitular
            End If

            If Not esNuevaEmpresa Then
                empresa = empresaMasRecienteTitular
            Else
                empresa = empresaSeleccionada
            End If

            fecha = Today.Date
            fechaLab = dpcFechaLaboratorio.Value
            fechaRayosX = dpcFechaRayosX.Value
            fechaMedicoLaboral = dpcMedicoLaboral.Value
            nroComprobantePago = txtNroComprobantePago.Text.Trim()
            esDeProvincia = esTitularEnProvincia

            Dim progExamenActual As ProgramacionExamenPreocupacional = New ProgramacionExamenPreocupacional()
            progExamenActual.setTitular(titular)
            progExamenActual.setEmpresa(empresa)
            progExamenActual.setFecha(fecha)
            progExamenActual.setFechaLaboratio(fechaLab)
            progExamenActual.setFechaRayosX(fechaRayosX)
            progExamenActual.setFechaMedicoLaboral(fechaMedicoLaboral)
            progExamenActual.setEstadoCompletitud(New Concepto(0, 1, ""))
            progExamenActual.setNroComprobantePago(nroComprobantePago)
            progExamenActual.setEsDeProvincia(esDeProvincia)


            regProgEP.nuevaProgrExamen = progExamenActual
            Return True


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try

    End Function

    Private Function validarEntradas() As String
        Dim mensaje As String = regProgEP.validarEntradas(esNuevoTitular, esNuevaEmpresa)
        Return mensaje
    End Function

    Private Sub insertarProgramacionEP()
        Try
            Dim respuesta As Int16 = regProgEP.insertarProgramacion()

            If respuesta > 0 Then
                mostrarMensaje("La programación de examen preocupacional se guardó correctamente.")
                mostrarReporte()
                reiniciarFormulario()

            ElseIf respuesta < 0 Then
                mostrarMensaje("Hubo un error al guardar la programación de examen preocupacional.")
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub mostrarReporte()
        Dim formReporte As FormReporteProgrmacionExamenPreocupacional
        formReporte = New FormReporteProgrmacionExamenPreocupacional(True)
        formReporte.ShowDialog()
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub





    'EVENTOS G1
    Private Sub btnBuscarMatricula_Click(sender As Object, e As EventArgs) Handles btnBuscarPorMatricula.Click
        Try
            traerTitulares()
            poblarCboxTitulares()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxTitulares_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTitulares.SelectionChangeCommitted
        Try
            seleccionarTitular()
            ocultarHintTitulares()
            mostrarInformacionTitular()
            seleccionarEmpresaMasRecienteTitular()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub chNuevoAsegurado_CheckedChanged(sender As Object, e As EventArgs) Handles chNuevoTitular.CheckedChanged
        Try
            cargarEstadoNuevoTitular()

            If chNuevoTitular.Checked Then
                deshabilitarControlesBuscarTitular()
                reiniciarControlesBusquedaTitular()
                reiniciarTitularSeleccionado()
                habilitarControlesNuevoTitular()
                deshabilitarChNuevaEmpresa()
                checkearChNuevaEmpresa()

            Else
                habilitarControlesBusquedaTitular()
                deshabilitarControlesNuevoTItular()
                reiniciarControlesNuevoTitular()
                habilitarChNuevaEmpresa()
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub rButtonMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonMasculino.CheckedChanged
        Try
            seleccionarSexo()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub rButtonFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonFemenino.CheckedChanged
        Try
            seleccionarSexo()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    Private Sub chNuevaEmpresa_CheckedChanged(sender As Object, e As EventArgs) Handles chNuevaEmpresa.CheckedChanged
        Try
            cargarEstadoNuevaEmpresa()

            If chNuevaEmpresa.Checked Then
                habilitarControlesNuevaEmpresa()
            Else
                deshabilitarControlesNuevaEmpresa()
                reiniciarControlesNuevaEmpresa()
                reniciarEmpresaSeleccionada()
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpresa.Click
        Try
            traerEmpresas()
            poblarCboxEmpresa()
            mostrarHintEmpresa()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxEmpresa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxEmpresa.SelectionChangeCommitted
        Try
            seleccionarNuevaEmpresa()
            ocultarHintEmpresa()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxLugarExpedicionNuevoTitular_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxLugarExpedicionNuevoTitular.SelectionChangeCommitted
        Try
            hintLugarExpedicionNuevoTitular.Visible = False

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



    'EVENTOS G2
    Private Sub chTitularEnProvincia_CheckedChanged(sender As Object, e As EventArgs) Handles chTitularEnProvincia.CheckedChanged
        Try
            cargarEstadoTitularEnProvincia()
            actualizarFechaMedicoLaboral()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dpcFechaLaboratorio_ValueChanged(sender As Object, e As EventArgs) Handles dpcFechaLaboratorio.ValueChanged
        Try
            actualizarFechaRayosX()
            actualizarFechaMedicoLaboral()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub dpcMedicoLaboral_ValueChanged(sender As Object, e As EventArgs) Handles dpcMedicoLaboral.ValueChanged
        Try
            calcularFichasRestantes()
            mostrarFichasRestantes()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G3
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        guardarProgramacion()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()

    End Sub
End Class