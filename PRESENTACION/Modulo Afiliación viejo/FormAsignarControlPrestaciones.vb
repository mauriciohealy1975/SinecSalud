Imports NEGOCIO
Public Class FormAsignarControlPrestaciones

    Private regAplicCP As RegistroAplicacionControlPrestaciones
    Private grupoCPSeleccionado As GrupoControlPrestaciones
    Private modoBusqueda As Int16 '1 buscar titular | 2  buscar beneficiario | 3 buscar empresa
    Private titularSeleccionado As Titular
    Private beneficiarioSeleccionado As Beneficiario
    Private empresaSeleccionada As Empresa
    Private controlPrestacionesSeleccionado As ControlPrestaciones
    Private tipoAplicacionCP As Char
    Private vigencia As Int16


    'METODOS INICIO
    Private Sub FormAsignarControlPrestaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        iniciarControlesModoFormulario()
        iniciarControlesGrupo1()
        inciarControlesGrupo2()
        iniciarControlesGrupo3()

        regAplicCP.traerGruposControlPrestaciones()
        poblarCboxGruposCP()
    End Sub

    Private Sub iniciarControlesLogicos()
        regAplicCP = New RegistroAplicacionControlPrestaciones()
        grupoCPSeleccionado = Nothing
        modoBusqueda = 0
        titularSeleccionado = New Titular()
        beneficiarioSeleccionado = New Beneficiario()
        empresaSeleccionada = New Empresa()
        controlPrestacionesSeleccionado = Nothing
        tipoAplicacionCP = ""
        vigencia = 1
    End Sub

    Private Sub iniciarControlesGrupo1()
        cboxGrupoCP.Enabled = True
        cboxGrupoCP.Font = New Font("Microsoft Sans Serif", 9)
        cboxGrupoCP.Items.Clear()
        cboxGrupoCP.DropDownStyle = ComboBoxStyle.DropDownList

        hintGrupoCP.Enabled = True
        hintGrupoCP.Visible = True
        hintGrupoCP.Font = New Font("Microsoft Sans Serif", 8)
        hintGrupoCP.Text = "SELECCIONAR"
        hintGrupoCP.BackColor = Color.Transparent

        lblBusqueda.Enabled = False
        lblBusqueda.Font = New Font("Microsoft Sans Serif", 9.5)
        lblBusqueda.Text = "Matrícula"

        txtBusqueda.Enabled = False
        txtBusqueda.Font = New Font("Microsoft Sans Serif", 9)
        txtBusqueda.Text = ""
        txtBusqueda.CharacterCasing = CharacterCasing.Upper

        btnBuscar.Enabled = False
        btnBuscar.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscar.Text = "Buscar"

        cboxReceptor.Enabled = False
        cboxReceptor.Font = New Font("Microsoft Sans Serif", 8)
        cboxReceptor.Items.Clear()
        cboxReceptor.DropDownStyle = ComboBoxStyle.DropDownList

        hintReceptor.Enabled = False
        hintReceptor.Visible = True
        hintReceptor.Font = New Font("Microsoft Sans Serif", 8)
        hintReceptor.Text = "SELECCIONAR"
        hintReceptor.BackColor = Color.Transparent

        lblRelacion.Enabled = True
        lblRelacion.Visible = False
        lblRelacion.Font = New Font("Microsoft Sans Serif", 9.5)
        lblRelacion.Text = "Relación con el titular: "

        cboxCP.Enabled = False
        cboxCP.Font = New Font("Microsoft Sans Serif", 8)
        cboxCP.Items.Clear()
        cboxCP.DropDownStyle = ComboBoxStyle.DropDownList

        hintTipoCP.Enabled = True
        hintTipoCP.Visible = True
        hintTipoCP.Font = New Font("Microsoft Sans Serif", 8)
        hintTipoCP.Text = "SELECCIONAR"
        hintTipoCP.BackColor = Color.Transparent

        lboxDetalle.Enabled = True
        lboxDetalle.Font = New Font("Microsoft Sans Serif", 9)
        lboxDetalle.Items.Clear()
    End Sub

    Private Sub inciarControlesGrupo2()
        panelDetalle.Enabled = True


        'la fecha limite de atención, por el momento es libre para que el ingreseel data que eldsess
        'despues, la fecha limite de atención, se generará de forma automática  
        dpcFechaLimiteAtencion.Enabled = True
        dpcFechaLimiteAtencion.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaLimiteAtencion.ShowUpDown = True
        dpcFechaLimiteAtencion.Format = DateTimePickerFormat.Custom
        dpcFechaLimiteAtencion.CustomFormat = "dd--MM--yyyy"
        dpcFechaLimiteAtencion.Value = Date.Today

        gboxEstado.Enabled = False
        gboxEstado.Font = New Font("Microsoft Sans Serif", 9)
        gboxEstado.Text = "Estado"

        rButtonVigente.Enabled = False
        rButtonVigente.Checked = True
        rButtonCancelada.Enabled = False
        rButtonCancelada.Checked = False
    End Sub

    Private Sub iniciarControlesGrupo3()
        btnCancelar.Enabled = True
        btnCancelar.Font = New Font("Microsoft Sans Serif", 9)
        btnCancelar.Text = "Cancelar"

        btnEnviar.Enabled = True
        btnEnviar.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviar.Text = "Registrar control"
    End Sub

    Private Sub iniciarControlesModoFormulario()
        toolStripModos.BackColor = Color.FromArgb(240, 240, 240)
        toolStripRegistrar.BackColor = Color.FromArgb(69, 143, 255)
        toolStripModificar.BackColor = Color.Transparent
    End Sub






    'METODOS INTERFAZ G1
    Private Sub deshabilitarCboxGruposCP()
        cboxGrupoCP.Enabled = False
    End Sub

    Private Sub habilitarCboxGruposCP()
        cboxGrupoCP.Enabled = True
    End Sub

    Private Sub poblarCboxGruposCP()
        cboxGrupoCP.Items.Clear()

        For Each grupo As GrupoControlPrestaciones In regAplicCP.gruposCP
            cboxGrupoCP.Items.Add(grupo.getNombre())
        Next
    End Sub

    Private Sub ocultarHintGrupoCP()
        hintGrupoCP.Visible = False
    End Sub

    Private Sub mostrarHintGrupoCP()
        hintGrupoCP.Visible = True
    End Sub

    Private Sub cambiarLblBusqeuda()
        If modoBusqueda = 1 Or modoBusqueda = 2 Then lblBusqueda.Text = "Matrícula" Else If modoBusqueda = 3 Then lblBusqueda.Text = "Empresa"
    End Sub

    Private Sub deshabilitarLblBusqueda()
        lblBusqueda.Enabled = False
    End Sub

    Private Sub habilitarLblBusqueda()
        lblBusqueda.Enabled = True
    End Sub

    Private Sub deshabilitarTxtBusqueda()
        txtBusqueda.Enabled = False
    End Sub

    Private Sub habilitarTxtBusqueda()
        txtBusqueda.Enabled = True
    End Sub

    Private Sub limpiarTxtBusqueda()
        txtBusqueda.Text = ""
    End Sub

    Private Sub habilitarBtnBuscar()
        btnBuscar.Enabled = True
    End Sub

    Private Sub deshabilitarBtnBuscar()
        btnBuscar.Enabled = False
    End Sub

    Private Sub habilitarControlesBusqueda()
        habilitarLblBusqueda()
        habilitarTxtBusqueda()
        habilitarBtnBuscar()
    End Sub

    Private Sub deshabilitarControlesBusqueda()
        deshabilitarLblBusqueda()
        deshabilitarTxtBusqueda()
        deshabilitarBtnBuscar()
    End Sub

    Private Sub poblarCboxReceptorConTitulares()
        cboxReceptor.Items.Clear()

        For Each titular As Titular In regAplicCP.titulares
            cboxReceptor.Items.Add(titular.getMatricula() + " | " + titular.getApellidoPaterno() + " " + titular.getApellidoMaterno() + " " + titular.getNombres())
        Next
    End Sub

    Private Sub poblarCboxReceptorConBeneficiarios()
        cboxReceptor.Items.Clear()

        For Each beneficiario As Beneficiario In regAplicCP.beneficiarios
            cboxReceptor.Items.Add(beneficiario.getMatricula() + " | " + beneficiario.getApellidoPaterno() + " " + beneficiario.getApellidoMaterno() + " " + beneficiario.getNombres())
        Next
    End Sub

    Private Sub poblarCboxReceptorConEmpresas()
        cboxReceptor.Items.Clear()

        For Each empresa As Empresa In regAplicCP.empresas
            cboxReceptor.Items.Add(empresa.getNombre())
        Next
    End Sub

    Private Sub deshabilitarCboxReceptor()
        cboxReceptor.Enabled = False
    End Sub

    Private Sub habilitarCboxReceptor()
        cboxReceptor.Enabled = True
    End Sub

    Private Sub cambiarHintReceptor()
        If modoBusqueda = 1 Then hintReceptor.Text = "SELECCIONAR TITULAR" Else 
        If modoBusqueda = 2 Then hintReceptor.Text = "SELECCIONAR BENEFICIARIO" Else 
        If modoBusqueda = 3 Then hintReceptor.Text = "SELECCIONAR EMPRESA"
    End Sub

    Private Sub deshabilitarHintReceptor()
        hintReceptor.Enabled = False
    End Sub

    Private Sub habilitarHintReceptor()
        hintReceptor.Enabled = True
    End Sub

    Private Sub ocultarHintReceptor()
        hintReceptor.Visible = False
    End Sub

    Private Sub mostrarHintReceptor()
        hintReceptor.Visible = True
    End Sub

    Private Sub cambiarLblRelacion()
        If tipoAplicacionCP = "T" Or tipoAplicacionCP = "E" Then lblRelacion.Text = "" Else 

        If tipoAplicacionCP = "B" Then
            Dim relacion As String = beneficiarioSeleccionado.getParentesco().getDescripcion()
            lblRelacion.Text = "Relación con el titular: " + relacion
        End If
    End Sub

    Private Sub mostrarLblRelacion()
        lblRelacion.Visible = True
    End Sub

    Private Sub ocultarLblRelacion()
        lblRelacion.Visible = False
    End Sub

    Private Sub poblarCboxCP()
        cboxCP.Items.Clear()

        For Each tipo As ControlPrestaciones In regAplicCP.controlesPrestaciones
            cboxCP.Items.Add(tipo.getNombre())
        Next
    End Sub

    Private Sub ocultarHintCP()
        hintTipoCP.Visible = False
    End Sub

    Private Sub deshabilitarCboxCP()
        cboxCP.Enabled = False
    End Sub

    Private Sub habilitarCboxCP()
        cboxCP.Enabled = True
    End Sub

    Private Sub mostrarHintTipoCP()
        hintTipoCP.Visible = True
    End Sub

    Private Sub poblarLBoxDetalle()
        lboxDetalle.Items.Clear()

        For Each detalle As DetalleControlPrestaciones In regAplicCP.detalles
            lboxDetalle.Items.Add(detalle.getNombre())
        Next
    End Sub



    'METODOS INTERFAZ G3
    Private Function cargarDatos() As Boolean
        Try
            Dim codigoReceptor As Int64, fecha As Date = Date.Today.Date,
                fechaLimiteAtencion As Date = dpcFechaLimiteAtencion.Value.Date

            Dim aplicacionCP As AplicacionControlPrestaciones = New AplicacionControlPrestaciones()
            aplicacionCP.setTipo(tipoAplicacionCP)

            If tipoAplicacionCP = "T" Then
                aplicacionCP.setTitular(titularSeleccionado)
                codigoReceptor = titularSeleccionado.getCodigo()

            ElseIf tipoAplicacionCP = "B" Then
                aplicacionCP.setBeneficiario(beneficiarioSeleccionado)
                codigoReceptor = beneficiarioSeleccionado.getCodigo()

            ElseIf tipoAplicacionCP = "E" Then
                aplicacionCP.setEmpresa(empresaSeleccionada)
                codigoReceptor = empresaSeleccionada.getCodigo()
            End If


            aplicacionCP.setCodigoReceptor(codigoReceptor)
            aplicacionCP.setControlPrestaciones(controlPrestacionesSeleccionado)
            aplicacionCP.setFecha(fecha)
            aplicacionCP.setVigencia(vigencia)
            aplicacionCP.setFechaLimiteAtencion(fechaLimiteAtencion)

            regAplicCP.nuevaAplicacionCP = aplicacionCP
            Return True


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub insertarAplicacionCP()
        Try
            Dim respuesta As Int16 = regAplicCP.insertarAplicacionCP()
            If respuesta > 0 Then
                mostrarMensaje("Los datos se guardaron correctamente.")
                reiniciarFormulario()
            Else
                mostrarMensaje("Hubo un error al guardar los datos")
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub guardarAplicacionCP()
        Try
            Dim datosCargados As Boolean = cargarDatos()

            If datosCargados Then
                Dim mensajeValidacion As String = regAplicCP.validarEntradas()
                If mensajeValidacion = "" Then insertarAplicacionCP() Else mostrarMensaje(mensajeValidacion)
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub




    'METODOS INTERFAZ G6
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub









    'METODOS LOGICOS G1
    Private Sub seleccionarGrupoCP(ByVal _index As Int16)
        grupoCPSeleccionado = regAplicCP.gruposCP(_index)
    End Sub

    Private Sub cambiarModoBusqueda()
        Dim grupo As String = grupoCPSeleccionado.getNombre()

        If grupo = "TITULAR" Then
            modoBusqueda = 1
        ElseIf grupo = "BENEFICIARIO" Then
            modoBusqueda = 2
        ElseIf grupo = "EMPRESA" Then
            modoBusqueda = 3
        End If
    End Sub

    Private Sub seleccionarTipoAsignacionCP()
        If modoBusqueda = 1 Then tipoAplicacionCP = "T" Else 
        If modoBusqueda = 2 Then tipoAplicacionCP = "B" Else 
        If modoBusqueda = 3 Then tipoAplicacionCP = "E"
    End Sub

    Private Sub seleccionarTirular(ByVal _index As Int64)
        titularSeleccionado = regAplicCP.titulares(_index)
    End Sub

    Private Sub seleccionarBeneficiario(ByVal _index As Int64)
        beneficiarioSeleccionado = regAplicCP.beneficiarios(_index)
    End Sub

    Private Sub seleccinoarEmpresa(ByVal _index As Int64)
        empresaSeleccionada = regAplicCP.empresas(_index)
    End Sub

    Private Sub seleccionarCP(ByVal _index As Int64)
        controlPrestacionesSeleccionado = regAplicCP.controlesPrestaciones(_index)
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub







    'EVENTOS G0
    Private Sub toolStripRegistrar_Click(sender As Object, e As EventArgs) Handles toolStripRegistrar.Click
        reiniciarFormulario()
    End Sub

    Private Sub toolStripModificar_Click(sender As Object, e As EventArgs) Handles toolStripModificar.Click
        reiniciarFormulario()
        edIniciarFormModoEditar()
    End Sub


    'EVENTOS G1
    Private Sub cboxGrupoCP_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxGrupoCP.SelectionChangeCommitted
        Try
            Dim modoFormulario As Int16 = regAplicCP.modoFormulario
            Dim index As Int16 = cboxGrupoCP.SelectedIndex

            If modoFormulario = 1 Then
                seleccionarGrupoCP(index)
                ocultarHintGrupoCP()
                habilitarControlesBusqueda()
                cambiarModoBusqueda()
                seleccionarTipoAsignacionCP()
                cambiarLblBusqeuda()
                limpiarTxtBusqueda()
                cambiarHintReceptor()

                Dim codGrupo As Int64 = grupoCPSeleccionado.getCodigo()
                regAplicCP.traerControlesPrestaciones(codGrupo)
                poblarCboxCP()


            ElseIf modoFormulario = 2 Then
                edSeleccionarGrupoAplicacion(index)
                edGenerarTipoAplicacionCP()
                ocultarHintGrupoCP()
                habilitarLblBusqueda()
                habilitarTxtBusqueda()
                limpiarTxtBusqueda()
                habilitarBtnBuscar()

                Dim codGrupo As Int64 = edGrupoCPSeleccionado.getCodigo()
                regAplicCP.traerControlesPrestaciones(codGrupo)
                poblarCboxCP()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim input As String = txtBusqueda.Text.Trim()
            Dim modoFormulario As Int16 = regAplicCP.modoFormulario

            If modoFormulario = 1 Then
                If modoBusqueda = 1 Then
                    regAplicCP.traerTitulares(input)
                    poblarCboxReceptorConTitulares()

                ElseIf modoBusqueda = 2 Then
                    regAplicCP.traerBeneficiarios(input)
                    poblarCboxReceptorConBeneficiarios()

                ElseIf modoBusqueda = 3 Then
                    regAplicCP.traerEmpresas(input)
                    poblarCboxReceptorConEmpresas()
                End If




            ElseIf modoFormulario = 2 Then
                If edTipoAplicacionCP = "T" Then
                    regAplicCP.traerTitulares(input)
                    poblarCboxReceptorConTitulares()

                ElseIf edTipoAplicacionCP = "B" Then
                    regAplicCP.traerBeneficiarios(input)
                    poblarCboxReceptorConBeneficiarios()


                ElseIf edTipoAplicacionCP = "E" Then
                    regAplicCP.traerEmpresas(input)
                    poblarCboxReceptorConEmpresas()
                End If

            End If


            habilitarCboxReceptor()
            habilitarHintReceptor()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxReceptor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxReceptor.SelectionChangeCommitted
        Try
            Dim modoFormulario As Int16 = regAplicCP.modoFormulario
            Dim index As Int64 = cboxReceptor.SelectedIndex

            If modoFormulario = 1 Then
                If modoBusqueda = 1 Then seleccionarTirular(index) Else 
                If modoBusqueda = 2 Then seleccionarBeneficiario(index) Else 
                If modoBusqueda = 3 Then seleccinoarEmpresa(index)

                ocultarHintReceptor()
                deshabilitarCboxGruposCP()
                deshabilitarTxtBusqueda()
                deshabilitarBtnBuscar()
                deshabilitarCboxReceptor()
                deshabilitarHintReceptor()
                mostrarLblRelacion()
                cambiarLblRelacion()
                habilitarCboxCP()

            ElseIf modoFormulario = 2 Then
                edSelecionarReceptor(index)
                edGenerarCodigoReceptor()
                deshabilitarCboxGruposCP()
                deshabilitarTxtBusqueda()
                deshabilitarBtnBuscar()
                ocultarHintReceptor()
                deshabilitarCboxReceptor()
                ocultarHintCP()
                deshabilitarCboxCP()

                regAplicCP.edTraerAplicacionCPMasReciente(edTipoAplicacionCP, edCodigoReceptor)
                Dim existeAplicacionCPAnterior As Boolean = regAplicCP.edRevisarExisteAplicacionCPAnterior()

                If existeAplicacionCPAnterior Then
                    edSeleccionarCP()
                    regAplicCP.traerDetalles(edCPSeleccionado.getCodigo())
                    edMostrarDatosAplicacionCPMasReciente()
                Else
                    mostrarMensaje("No se encontró un control de prestaciones anterior para modificar.")
                    reiniciarFormulario()
                    edIniciarFormModoEditar()
                End If

            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxTipoControl_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxCP.SelectionChangeCommitted
        Try
            Dim index As Int64 = cboxCP.SelectedIndex
            seleccionarCP(index)
            ocultarHintCP()
            regAplicCP.traerDetalles(controlPrestacionesSeleccionado.getCodigo())
            poblarLBoxDetalle()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G2
    Private Sub rButtonVigente_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonVigente.CheckedChanged
        Dim modoFormulario As Int16 = regAplicCP.modoFormulario

        If rButtonVigente.Checked Then
            If modoFormulario = 1 Then

            ElseIf modoFormulario = 2 Then
                edVigencia = 1
            End If
        End If

    End Sub

    Private Sub rButtonCancelada_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonCancelada.CheckedChanged
        Dim modoFormulario As Int16 = regAplicCP.modoFormulario

        If rButtonCancelada.Checked Then
            If modoFormulario = 1 Then

            ElseIf modoFormulario = 2 Then
                edVigencia = 0
            End If
        End If
    End Sub

    'EVENTOS G3
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim modoFormulario As Int16 = regAplicCP.modoFormulario

        If modoFormulario = 1 Then guardarAplicacionCP() Else 
        If modoFormulario = 2 Then edEditarAplicacionCP()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()
    End Sub
















    '[MODO EDITAR]
    Private edGrupoCPSeleccionado As GrupoControlPrestaciones
    Private edTipoAplicacionCP As Char

    Private edTitularSeleccionado As Titular
    Private edBeneficiarioSeleccionado As Beneficiario
    Private edEmpresaSeleccionada As Empresa
    Private edCodigoReceptor As Int64
    Private edCPSeleccionado As ControlPrestaciones

    Private edVigencia As Int16

    '[MODO EDITAR] METOODS INICIO
    Private Sub edIniciarFormModoEditar()
        regAplicCP.modoFormulario = 2

        edIniciarControlesLogicos()

        'G0
        toolStripRegistrar.BackColor = Color.Transparent
        toolStripModificar.BackColor = Color.FromArgb(69, 143, 255)

        'G1
        cboxCP.Enabled = False
        hintTipoCP.Enabled = False
        lboxDetalle.Enabled = False

        'G2
        dpcFechaLimiteAtencion.Enabled = False
        gboxEstado.Enabled = True
        rButtonVigente.Enabled = True
        rButtonVigente.Checked = False
        rButtonCancelada.Enabled = True
        rButtonCancelada.Checked = False


        'G3
        btnEnviar.Text = "Actualizar control"
    End Sub

    Private Sub edIniciarControlesLogicos()
        edGrupoCPSeleccionado = Nothing
        edTipoAplicacionCP = ""
        edTitularSeleccionado = Nothing
        edBeneficiarioSeleccionado = Nothing
        edEmpresaSeleccionada = Nothing
        edCodigoReceptor = 0
        edVigencia = Nothing
    End Sub




    '[MODO EDITAR] METODOS LOGICOS
    Private Sub edSeleccionarGrupoAplicacion(ByVal _index As Int16)
        edGrupoCPSeleccionado = regAplicCP.gruposCP(_index)
    End Sub

    Private Sub edGenerarTipoAplicacionCP()
        Dim grupo As String = edGrupoCPSeleccionado.getNombre()

        If grupo = "TITULAR" Then edTipoAplicacionCP = "T" Else 
        If grupo = "BENEFICIARIO" Then edTipoAplicacionCP = "B" Else 
        If grupo = "EMPRESA" Then edTipoAplicacionCP = "E"
    End Sub

    Private Sub edSelecionarReceptor(ByVal _index As Int16)
        If edTipoAplicacionCP = "T" Then edSeleccionarTitular(_index) Else 
        If edTipoAplicacionCP = "B" Then edSeleccionarBeneficiario(_index) Else 
        If edTipoAplicacionCP = "E" Then edSeleccionarEmpresa(_index)
    End Sub

    Private Sub edSeleccionarTitular(ByVal _index As Int16)
        edTitularSeleccionado = regAplicCP.titulares(_index)
    End Sub

    Private Sub edSeleccionarBeneficiario(ByVal _index As Int16)
        edBeneficiarioSeleccionado = regAplicCP.beneficiarios(_index)
    End Sub

    Private Sub edSeleccionarEmpresa(ByVal _index As Int16)
        edEmpresaSeleccionada = regAplicCP.empresas(_index)
    End Sub

    Private Sub edGenerarCodigoReceptor()
        If edTipoAplicacionCP = "T" Then edCodigoReceptor = edTitularSeleccionado.getCodigo() Else 
        If edTipoAplicacionCP = "B" Then edCodigoReceptor = edBeneficiarioSeleccionado.getCodigo() Else 
        If edTipoAplicacionCP = "E" Then edCodigoReceptor = edEmpresaSeleccionada.getCodigo()
    End Sub

    Private Function edObtenerCodigoCPSeleccionado()
        Dim index As Int16 = cboxCP.SelectedIndex
        Dim codigo As Int64 = regAplicCP.controlesPrestaciones(index).getCodigo()

        Return codigo
    End Function

    Private Function edCargarDatos() As Boolean
        Try
            Dim codigo As Int64 = regAplicCP.edAplicacionCPMasReciente.getCodigo()
            Dim nuevaAplicacionCP As AplicacionControlPrestaciones = New AplicacionControlPrestaciones()
            nuevaAplicacionCP.setCodigo(codigo)
            nuevaAplicacionCP.setVigencia(edVigencia)
            regAplicCP.edNuevaAplicacionCP = nuevaAplicacionCP
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False

        End Try
    End Function

    Private Sub edEditarAplicacionCP()
        Dim datosCargados As Boolean = edCargarDatos()
        If datosCargados Then edAcutalizarAplicacionCP()
    End Sub

    Private Sub edAcutalizarAplicacionCP()
        Try
            Dim respuesta As Int16 = regAplicCP.edAcutalizarVigenciaAplicacionCP(Me.Text)
            If respuesta > 0 Then
                mostrarMensaje("Los datos se actualizarón correctamente.")
                reiniciarFormulario()
                edIniciarFormModoEditar()
            Else
                mostrarMensaje("Sucedió un error al actualizar los datos.")
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub edSeleccionarCP()
        Dim controlPrestaciones As ControlPrestaciones = regAplicCP.edAplicacionCPMasReciente.getControlPrestaciones()
        Dim nombreCP As String = controlPrestaciones.getNombre()


        Dim index As Int16 = 0
        For Each item As String In cboxCP.Items
            If item = nombreCP Then Exit For
            index += 1
        Next

        edCPSeleccionado = regAplicCP.controlesPrestaciones(index)
    End Sub


    '[MODO EDITAR] METODOS INTERFAZ
    Private Sub edMostrarDatosAplicacionCPMasReciente()
        Dim aplicacionCP As AplicacionControlPrestaciones = regAplicCP.edAplicacionCPMasReciente
        Dim fechaLimite As Date = aplicacionCP.getFechaLimiteAtencion()
        Dim nombreCP As String = aplicacionCP.getControlPrestaciones.getNombre()
        Dim vigencia As Int16 = aplicacionCP.getVigencia()

        cboxCP.SelectedItem = nombreCP
        poblarLBoxDetalle()
        dpcFechaLimiteAtencion.Value = fechaLimite.Date
        If vigencia = 1 Then rButtonVigente.Checked = True
        If vigencia = 0 Then rButtonCancelada.Checked = True
    End Sub

End Class


