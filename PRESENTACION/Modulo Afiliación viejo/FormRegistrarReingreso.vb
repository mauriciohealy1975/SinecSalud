Imports NEGOCIO

Public Class FormRegistrarReingreso

    Private regReingreso As RegistroReingreso
    Private titularSeleccionado As Titular
    Private empresaSeleccionada As Empresa
    Private reingresoEnCesantia As Int16
    Private cargoSeleccionado As Concepto
    Private tipoContratacion As Int16
    Private progproySeleccionado As ProgramaProyecto
    Private entidadDescSeleccionada As EntidadDesconcentrada


    'METODOS INICIO
    Private Sub FormRegistrarReingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Private Sub iniciarFormulario()
        iniciarControlesLogicos()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()

        regReingreso.traerCargosTrabajo()
        poblarCboxCargos()
        configurarDisplay()

    End Sub

    Private Sub configurarDisplay()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub iniciarControlesLogicos()
        regReingreso = New RegistroReingreso()
    End Sub

    Private Sub iniciarControlesGrupo1()
        panelDatosPersonales.Enabled = True

        txtMatricula.Enabled = True
        txtMatricula.Font = New Font("Microsoft Sans Serif", 9)
        txtMatricula.Text = ""
        txtMatricula.CharacterCasing = CharacterCasing.Upper

        btnBuscarMatricula.Enabled = True
        btnBuscarMatricula.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarMatricula.Text = "Buscar"

        cboxTitulares.Enabled = True
        cboxTitulares.Font = New Font("Microsoft Sans Serif", 9)
        cboxTitulares.Items.Clear()
        cboxTitulares.DropDownStyle = ComboBoxStyle.DropDownList

        hintTitulares.Enabled = True
        hintTitulares.Font = New Font("Microsoft Sans Serif", 8)
        hintTitulares.Text = "SELECCIONAR ASEGURADO DE BAJA"
        hintTitulares.BackColor = Color.Transparent
        hintTitulares.Visible = True

        txtApellidoPaterno.Enabled = False
        txtApellidoPaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApellidoPaterno.Text = ""
        txtApellidoPaterno.CharacterCasing = CharacterCasing.Upper

        txtApellidoMaterno.Enabled = False
        txtApellidoMaterno.Font = New Font("Microsoft Sans Serif", 9)
        txtApellidoMaterno.Text = ""
        txtApellidoMaterno.CharacterCasing = CharacterCasing.Upper

        txtNombres.Enabled = False
        txtNombres.Font = New Font("Microsoft Sans Serif", 9)
        txtNombres.Text = ""
        txtNombres.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarControlesGrupo2()
        deshabilitarPanelDatosEmpleador()

        txtUltimoEmpleador.Enabled = True
        txtUltimoEmpleador.ReadOnly = True
        txtUltimoEmpleador.Font = New Font("Microsoft Sans Serif", 9)
        txtUltimoEmpleador.Text = ""
        txtUltimoEmpleador.CharacterCasing = CharacterCasing.Upper

        txtNuevoEmpleador.Enabled = True
        txtNuevoEmpleador.Font = New Font("Microsoft Sans Serif", 9)
        txtNuevoEmpleador.Text = ""
        txtNuevoEmpleador.CharacterCasing = CharacterCasing.Upper

        btnBuscarEmpleador.Enabled = True
        btnBuscarEmpleador.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarEmpleador.Text = "Buscar"

        hintEmpleador.Enabled = True
        hintEmpleador.Visible = True
        hintEmpleador.Font = New Font("Microsoft Sans Serif", 8)
        hintEmpleador.Text = "SELECCIONAR NUEVO EMPLEADOR"
        hintEmpleador.BackColor = Color.Transparent

        cboxEmpleador.Enabled = True
        cboxEmpleador.Font = New Font("Microsoft Sans Serif", 9)
        cboxEmpleador.Items.Clear()
        cboxEmpleador.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub iniciarControlesGrupo3()
        panelDatosAvisoReingreso.Enabled = True

        chReingresoCesantia.Enabled = False
        chReingresoCesantia.Font = New Font("Microsoft Sans Serif", 9)
        chReingresoCesantia.Text = "Reingreso en periodo de cesantia"
        chReingresoCesantia.Checked = False

        dpcFechaContratacion.Enabled = True
        dpcFechaContratacion.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaContratacion.ShowUpDown = True
        dpcFechaContratacion.Format = DateTimePickerFormat.Custom
        dpcFechaContratacion.CustomFormat = "dd--MM--yyyy"
        dpcFechaContratacion.Value = Date.Today

        cboxCargo.Enabled = True
        cboxCargo.Font = New Font("Microsoft Sans Serif", 9)
        cboxCargo.Items.Clear()
        cboxCargo.DropDownStyle = ComboBoxStyle.DropDownList

        hintCargo.Enabled = True
        hintCargo.Visible = True
        hintCargo.Font = New Font("Microsoft Sans Serif", 8)
        hintCargo.Text = "SELECCIONAR"
        hintCargo.BackColor = Color.Transparent

        numSalario.Enabled = True
        numSalario.Value = 0
        numSalario.DecimalPlaces = 2
        numSalario.Maximum = 99999.99
        numSalario.Minimum = 0

        panelTipoContratacion.Enabled = True

        rButtonFijo.Enabled = True
        rButtonFijo.Checked = False

        rButtonEventual.Enabled = True
        rButtonEventual.Checked = False

        chEmpPublica.Enabled = False
        chEmpPublica.Font = New Font("Microsoft Sans Serif", 9)
        chEmpPublica.Text = "Empresa pública"
        chEmpPublica.Checked = False

        panelEmpresaPublica.Enabled = False

        chProgProy.Enabled = True
        chProgProy.Font = New Font("Microsoft Sans Serif", 9)
        chProgProy.Text = "Programa/Proyecto"
        chProgProy.Checked = False

        chEntDesc.Enabled = True
        chEntDesc.Font = New Font("Microsoft Sans Serif", 9)
        chEntDesc.Text = "Entidad desconcentrada"
        chEntDesc.Checked = False

        cboxProgProy.Enabled = False
        cboxProgProy.Font = New Font("Microsoft Sans Serif", 8)
        cboxProgProy.Items.Clear()
        cboxProgProy.DropDownStyle = ComboBoxStyle.DropDownList

        hintProgProy.Enabled = False
        hintProgProy.Visible = True
        hintProgProy.Font = New Font("Microsoft Sans Serif", 8)
        hintProgProy.Text = "SELECCIONAR"
        hintProgProy.BackColor = Color.Transparent

        cboxEntDesc.Enabled = False
        cboxEntDesc.Font = New Font("Microsoft Sans Serif", 8)
        cboxEntDesc.Items.Clear()
        cboxEntDesc.DropDownStyle = ComboBoxStyle.DropDownList

        hintEntDesc.Enabled = False
        hintEntDesc.Visible = True
        hintEntDesc.Font = New Font("Microsoft Sans Serif", 8)
        hintEntDesc.Text = "SELECCIONAR"
        hintEntDesc.BackColor = Color.Transparent
    End Sub


    'METODOS INTERFAZ G1
    Private Sub poblarCboxTitulares()
        cboxTitulares.Items.Clear()

        For Each titular As Titular In regReingreso.titularesDeBaja
            cboxTitulares.Items.Add(titular.getMatricula() + " | " + titular.getApellidoPaterno() + " " + titular.getApellidoMaterno() + " " + titular.getNombres())
        Next
    End Sub

    Private Sub ocultarHintTitulares()
        hintTitulares.Visible = False
    End Sub

    Private Sub mostrarHintTitulares()
        hintTitulares.Visible = True
    End Sub

    Private Sub mostrarDatosTitular()
        txtApellidoPaterno.Text = titularSeleccionado.getApellidoPaterno()
        txtApellidoMaterno.Text = titularSeleccionado.getApellidoMaterno()
        txtNombres.Text = titularSeleccionado.getNombres()
    End Sub


    'METODOS INTERFAZ G2
    Private Sub habilitarPanelDatosEmpleador()
        panelDatosEmpleador.Enabled = True
    End Sub

    Private Sub deshabilitarPanelDatosEmpleador()
        panelDatosEmpleador.Enabled = False
    End Sub

    Private Sub mostrarDatosUltimoEpleador()
        Dim bajaMasReciente As AvisoAfiliacion = regReingreso.bajaMasReciente
        txtUltimoEmpleador.Text = bajaMasReciente.getEmpleador().getNombre()
    End Sub

    Private Sub deshabilitarControlesNuevoEmpleador()
        lblNuevoEmpleador.Enabled = False
        txtNuevoEmpleador.Enabled = False
        btnBuscarEmpleador.Enabled = False
        cboxEmpleador.Enabled = False
        hintEmpleador.Enabled = False
    End Sub

    Private Sub habilitarControlesNuevoEmpleador()
        lblNuevoEmpleador.Enabled = True
        txtNuevoEmpleador.Enabled = True
        btnBuscarEmpleador.Enabled = True
        cboxEmpleador.Enabled = True
        hintEmpleador.Enabled = True
    End Sub

    Private Sub reiniciarControlesNuevoEpmleador()
        txtNuevoEmpleador.Text = ""
        cboxEmpleador.Items.Clear()
        mostrarHintEmpleador()
    End Sub

    Private Sub poblarCboxEmpleador()
        cboxEmpleador.Items.Clear()

        For Each empresa As Empresa In regReingreso.empresas
            cboxEmpleador.Items.Add(empresa.getNombre())
        Next
    End Sub

    Private Sub ocultarHintEmpleador()
        hintEmpleador.Visible = False
    End Sub

    Private Sub mostrarHintEmpleador()
        hintEmpleador.Visible = True
    End Sub


    'METODOS INTERFAZ G3
    Private Sub marcarReingresoEnCesantia()
        Dim reingresoEnCesantia As Boolean = regReingreso.comprobarReingresoEnCesantia()

        If reingresoEnCesantia Then
            chReingresoCesantia.Checked = True
            reingresoEnCesantia = 1
        Else
            chReingresoCesantia.Checked = False
            reingresoEnCesantia = 0
        End If
    End Sub

    Private Sub poblarCboxCargos()
        cboxCargo.Items.Clear()

        For Each cargo As Concepto In regReingreso.cargosTrabajo
            cboxCargo.Items.Add(cargo.getDescripcion())
        Next
    End Sub

    Private Sub ocultarHintCargo()
        hintCargo.Visible = False
    End Sub

    Private Sub mostrarHintCargo()
        hintCargo.Visible = True
    End Sub

    Private Sub marcarChEmpresaPublica()
        chEmpPublica.Checked = True
    End Sub

    Private Sub desmarcarChEmpresaPublica()
        chEmpPublica.Checked = False
    End Sub

    Private Sub habilitarPanelEmpresaPublica()
        panelEmpresaPublica.Enabled = True
    End Sub

    Public Sub deshabilitarPanelEmpresaPublica()
        panelEmpresaPublica.Enabled = False
    End Sub

    Private Sub habilitarCboxProgProy()
        cboxProgProy.Enabled = True
    End Sub

    Private Sub deshabilitarCboxProgrProy()
        cboxProgProy.Enabled = False
    End Sub

    Private Sub habilitarHintProgProy()
        hintProgProy.Enabled = True
    End Sub

    Private Sub deshabilitarHintProgProy()
        hintProgProy.Enabled = False
    End Sub

    Private Sub ocultarHintProgProy()
        hintProgProy.Visible = False
    End Sub

    Private Sub mostrarHintProgProy()
        hintProgProy.Visible = True
    End Sub

    Private Sub habilitarCboxEntDesc()
        cboxEntDesc.Enabled = True
    End Sub

    Private Sub deshabilitarCboxEntDesc()
        cboxEntDesc.Enabled = False
    End Sub

    Private Sub habilitarHintEntDesc()
        hintEntDesc.Enabled = True
    End Sub

    Private Sub deshabilitarHintEntDesc()
        hintEntDesc.Enabled = False
    End Sub

    Private Sub mostrarHintEntDesc()
        hintEntDesc.Visible = True
    End Sub

    Private Sub ocultarHintEntDesc()
        hintEntDesc.Visible = False
    End Sub

    Private Sub poblarCboxProgProy()
        cboxProgProy.Items.Clear()

        For Each progproy As ProgramaProyecto In regReingreso.programasproyectos
            cboxProgProy.Items.Add(progproy.getNombre())
        Next
    End Sub

    Private Sub poblarCboxEntDes()
        cboxEntDesc.Items.Clear()

        For Each entidad As EntidadDesconcentrada In regReingreso.entidadesDesconcentradas
            cboxEntDesc.Items.Add(entidad.getNombre())
        Next
    End Sub

    Private Sub reiniciarPanelEmpresaPublica()
        chProgProy.Checked = False
        chEntDesc.Checked = False

        cboxProgProy.Items.Clear()
        cboxEntDesc.Items.Clear()

        mostrarHintProgProy()
        mostrarHintEntDesc()
    End Sub


    'METODOS INTERFAZ G4
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub








    'METODOS LOGICOS G1
    Private Sub seleccionarTitular(ByVal _index As Int16)
        titularSeleccionado = regReingreso.titularesDeBaja(_index)
    End Sub


    'METODOS LOGICOS G2
    Private Sub seleccionarMismoEmpleador()
        Dim bajaMasReciente As AvisoAfiliacion = regReingreso.bajaMasReciente
        empresaSeleccionada = bajaMasReciente.getEmpleador()
    End Sub

    Private Sub seleccionarNuevoEmpleador(ByVal _index As Int16)
        empresaSeleccionada = regReingreso.empresas(_index)
    End Sub

    Private Sub anularEmpresaSeleccionada()
        empresaSeleccionada = Nothing
    End Sub


    'METODOS LOGICOS G3
    Private Sub seleccionarCargo(ByVal _index As Int16)
        cargoSeleccionado = regReingreso.cargosTrabajo(_index)
    End Sub

    Private Sub traerInfoEmpresasPublica()
        Dim empresa As Empresa = empresaSeleccionada

        regReingreso.traerProgramasProyectos(empresa.getCodigo())
        poblarCboxProgProy()

        regReingreso.traerEntidadesDesconcentradas(empresa.getCodigo())
        poblarCboxEntDes()
    End Sub

    Private Sub seleccionarProgramaProyecto(ByVal _index As Int16)
        progproySeleccionado = regReingreso.programasproyectos(_index)
    End Sub

    Private Sub seleccionarEntidadDesconcentrada(ByVal _index As Int16)
        entidadDescSeleccionada = regReingreso.entidadesDesconcentradas(_index)
    End Sub



    'METODOS LOGICOS G6
    Private Function cargarDatos() As Boolean
        Try
            Dim antEmpleador As Empresa = regReingreso.bajaMasReciente.getEmpleador()
            Dim fecContratacion As Date = dpcFechaContratacion.Value
            Dim salario As Decimal = numSalario.Value
            Dim fecPresentacion As Date = dpcFechaPresentacion.Value


            Dim aviso As AvisoAfiliacion = New AvisoAfiliacion()
            aviso.setAsegurado(titularSeleccionado)
            aviso.setAnteriorEmpleador(antEmpleador)
            aviso.setEmpleador(empresaSeleccionada)
            aviso.setReingresoEnCesantia(reingresoEnCesantia)
            aviso.setFechaContratacion(fecContratacion)
            aviso.setCargo(cargoSeleccionado)
            aviso.setSalario(salario)
            aviso.setTipoContratacion(tipoContratacion)

            Dim sector As Int16 = empresaSeleccionada.getSector().getCorrelativo()
            If sector = 1 Then
                aviso.setProgramaProyecto(progproySeleccionado)
                aviso.setEntidadDesconcentrada(entidadDescSeleccionada)
            End If

            aviso.setFechaPresentacion(fecPresentacion)


            regReingreso.nuevoReingreso = aviso
            Return True

        Catch ex As Exception
            mostrarMensaje("Error. Ingrese los datos antes de guardar el reingreso.")
            Return False
        End Try
    End Function

    Private Sub insertarDatos()
        Try
            Dim respuesta As Int16 = regReingreso.registrarReingreso()
            If respuesta > 0 Then
                mostrarMensaje("Los datos se guardaron correctamente.")
                reiniciarFormulario()
            Else
                mostrarMensaje("Hubo un error al guardar los datos.")
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub registrarAviso()
        Dim datosCargados As Boolean = cargarDatos()

        If datosCargados Then
            Dim mensajeValidacion As String = regReingreso.validarEntradas()
            If Not mensajeValidacion = "" Then mostrarMensaje(mensajeValidacion) Else insertarDatos()
        End If
    End Sub

    Public Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub










    'EVENTOS GRUPO 1
    Private Sub btnBuscarMatricula_Click(sender As Object, e As EventArgs) Handles btnBuscarMatricula.Click
        Try
            Dim matricula As String = txtMatricula.Text.Trim()
            regReingreso.traerTitularesDeBaja(matricula)
            poblarCboxTitulares()
            mostrarHintTitulares()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxTitulares_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTitulares.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxTitulares.SelectedIndex
            seleccionarTitular(index)
            ocultarHintTitulares()
            mostrarDatosTitular()
            regReingreso.traerBajaMasReciente(titularSeleccionado.getMatricula())
            marcarReingresoEnCesantia()
            habilitarPanelDatosEmpleador()
            mostrarDatosUltimoEpleador()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS GRUPO 2
    Private Sub chMismoEmlpeador_CheckedChanged(sender As Object, e As EventArgs) Handles chMismoEmlpeador.CheckedChanged

        If chMismoEmlpeador.Checked Then
            seleccionarMismoEmpleador()
            deshabilitarControlesNuevoEmpleador()
            reiniciarControlesNuevoEpmleador()

            Dim empresa As Empresa = empresaSeleccionada
            If regReingreso.esEmpresaPublica(empresa) Then
                marcarChEmpresaPublica()
                traerInfoEmpresasPublica()
            Else
                desmarcarChEmpresaPublica()
            End If
        Else
            habilitarControlesNuevoEmpleador()
            anularEmpresaSeleccionada()
        End If
    End Sub

    Private Sub cboxEmpleador_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxEmpleador.SelectionChangeCommitted

        Try
            Dim index As Int16 = cboxEmpleador.SelectedIndex
            seleccionarNuevoEmpleador(index)
            ocultarHintEmpleador()

            Dim empresa As Empresa = empresaSeleccionada
            If regReingreso.esEmpresaPublica(empresa) Then
                marcarChEmpresaPublica()
                traerInfoEmpresasPublica()
            Else
                desmarcarChEmpresaPublica()
            End If
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarEmpleador_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleador.Click

        Try
            Dim nombreEmpresa As String = txtNuevoEmpleador.Text.Trim()
            regReingreso.traerEmpresas(nombreEmpresa)
            poblarCboxEmpleador()
            mostrarHintEmpleador()
            anularEmpresaSeleccionada()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS GRUPO 3
    Private Sub cboxCargo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxCargo.SelectionChangeCommitted

        Try
            Dim index As Int16 = cboxCargo.SelectedIndex
            seleccionarCargo(index)
            ocultarHintCargo()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub rButtonFijo_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonFijo.CheckedChanged
        tipoContratacion = 1
    End Sub

    Private Sub rButtonEventual_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonEventual.CheckedChanged
        tipoContratacion = 2
    End Sub

    Private Sub chEmpPublica_CheckedChanged(sender As Object, e As EventArgs) Handles chEmpPublica.CheckedChanged
        If chEmpPublica.Checked Then
            habilitarPanelEmpresaPublica()
        Else
            deshabilitarPanelEmpresaPublica()
            reiniciarPanelEmpresaPublica()
        End If
    End Sub

    Private Sub chProgramaProyecto_CheckedChanged(sender As Object, e As EventArgs) Handles chProgProy.CheckedChanged
        If chProgProy.Checked Then
            habilitarCboxProgProy()
            habilitarHintProgProy()
        Else
            deshabilitarCboxProgrProy()
            deshabilitarHintProgProy()
        End If
    End Sub

    Private Sub chEntidadDesconcentrada_CheckedChanged(sender As Object, e As EventArgs) Handles chEntDesc.CheckedChanged
        If chEntDesc.Checked Then
            habilitarCboxEntDesc()
            habilitarHintEntDesc()
        Else
            deshabilitarCboxEntDesc()
            deshabilitarHintEntDesc()
        End If
    End Sub

    Private Sub cboxProgProy_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxProgProy.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxProgProy.SelectedIndex
            seleccionarProgramaProyecto(index)
            ocultarHintProgProy()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxEntDesc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxEntDesc.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxEntDesc.SelectedIndex
            seleccionarEntidadDesconcentrada(index)
            ocultarHintEntDesc()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub chReingresoCesantia_CheckedChanged(sender As Object, e As EventArgs) Handles chReingresoCesantia.CheckedChanged
        If chReingresoCesantia.Checked Then reingresoEnCesantia = 1 Else reingresoEnCesantia = 0
    End Sub


    'EVENTOS GURPO 6
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim modoFormulario As Int16 = regReingreso.modoFormulario

        If modoFormulario = 1 Then
            registrarAviso()
        ElseIf modoFormulario = 2 Then
            'this is a test
        End If
    End Sub


End Class

