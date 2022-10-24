Imports NEGOCIO

Public Class FormActualizarAsegurado
    'RESOL 1280, 600
    Dim obActualizacionAseg As ActualizacionAsegurado = New ActualizacionAsegurado()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarDisplay()
        iniciarControles()
        escribirNombreUsuario()
    End Sub





    'METOD. CONFIG INICIAL INTERFAZ
    Private Sub escribirNombreUsuario()
        lblNombreUsuario.Text = Usuario.nameUserLoggedSystem
    End Sub

    Private Sub iniciarControles()
        iniciarControlesGrupo1()
        iniciarControlesParteSuperior()
        iniciarControlesGrupo3()
    End Sub

    Private Sub iniciarControlesParteSuperior()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
    End Sub

    Private Sub iniciarControlesGrupo1()
        lblTituloNomAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        lblTituloNomAsegurado.Text = "Nombre Asegurado"


        txtBuscarAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarAsegurado.Text = ""

        btnBuscar.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscar.Text = "Buscar"
        deshabilitarBtnBuscar()


        txtNombreAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtNombreAsegurado.Text = ""
        ocultarTxtNombreAsegurado()
        deshabilitarTxtNombreAsegurado()


        cmboxAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        cmboxAsegurado.Items.Clear()
        cmboxAsegurado.Text = ""
        mostrarCmboxAsegurado()

        deshabilitarCmboxAsegurado()
    End Sub

    Private Sub iniciarControlesGrupo2()
        lblTituloMatricula.Font = New Font("Microsoft Sans Serif", 9)
        lblTituloMatricula.Text = "Matricula:"

        lblMatricula.Font = New Font("Microsoft Sans Serif", 9)
        lblMatricula.Text = ""

        lblTituloEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        lblTituloEmpresa.Text = "Empresa:"

        lblEmpresa.Font = New Font("Microsoft Sans Serif", 9)
        lblEmpresa.Text = ""
    End Sub

    Private Sub iniciarControlesGrupo3()
        iniciarComboboxesGrupo3()

        cmboxTipoDoc.Enabled = False

        txtDocumento.Text = ""
        txtDocumento.Enabled = False

        txtExtension.Text = ""
        txtExtension.Enabled = False


        cmboxTipoSangre.Enabled = False
        cmboxTipoAsegurado.Enabled = False


        txtDirDomicilio.Text = ""
        txtDirDomicilio.Enabled = False

        rbuttonCiudad.Checked = False
        rbuttonCiudad.Enabled = False

        rbuttonProvincia.Checked = False
        rbuttonProvincia.Enabled = False

        txtTelefonoDomicilio.Text = ""
        txtTelefonoDomicilio.Enabled = False

        txtTelefonoReferencia.Text = ""
        txtTelefonoReferencia.Enabled = False

        txtNitEmpresa.Text = ""
        txtNitEmpresa.Enabled = False

        txtCodigoPatronal.Text = ""
        txtCodigoPatronal.Enabled = False

        txtMatriculaDeComercioEmpresa.Text = ""
        txtMatriculaDeComercioEmpresa.Enabled = False

        txtRoe.Text = ""
        txtRoe.Enabled = False

        rbuttonPublico.Checked = False
        rbuttonPublico.Enabled = False

        rbuttonPrivado.Checked = False
        rbuttonPrivado.Enabled = False

        txtTelefonoLaboral.Text = ""
        txtTelefonoLaboral.Enabled = False

        txtDirLaboral.Text = ""
        txtDirLaboral.Enabled = False

        cmboxDepartamento.Enabled = False

        cmboxProvincia.Enabled = False

        txtLocalidad.Text = ""
        txtLocalidad.Enabled = False

        btnGuardar.Font = New Font("Microsoft Sans Serif", 9)
        btnGuardar.Text = "GUARDAR"
        btnGuardar.Enabled = False
    End Sub

    Private Sub iniciarComboboxesGrupo3()
        cmboxTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList
        cmboxTipoDoc.Font = New Font("Microsoft Sans Serif", 9)
        cmboxTipoDoc.Items.Clear()
        cmboxTipoDoc.Text = ""


        cmboxDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
        cmboxDepartamento.Font = New Font("Microsoft Sans Serif", 9)
        cmboxDepartamento.Items.Clear()
        cmboxDepartamento.Text = ""


        cmboxProvincia.DropDownStyle = ComboBoxStyle.DropDownList
        cmboxProvincia.Font = New Font("Microsoft Sans Serif", 9)
        cmboxProvincia.Items.Clear()
        cmboxProvincia.Text = ""


        cmboxTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList
        cmboxTipoSangre.Font = New Font("Microsoft Sans Serif", 9)
        cmboxTipoSangre.Items.Clear()
        cmboxTipoSangre.Text = ""


        cmboxAsegurado.DropDownStyle = ComboBoxStyle.DropDownList
        cmboxAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        cmboxAsegurado.Items.Clear()
        cmboxAsegurado.Text = ""


        cmboxTipoAsegurado.DropDownStyle = ComboBoxStyle.DropDownList
        cmboxTipoAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        cmboxTipoAsegurado.Items.Clear()
        cmboxTipoAsegurado.Text = ""
    End Sub

    Private Sub configurarDisplay()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub ocultarTxtNombreAsegurado()
        txtNombreAsegurado.Visible = False
    End Sub

    Private Sub deshabilitarTxtNombreAsegurado()
        txtNombreAsegurado.Enabled = False
    End Sub

    Private Sub deshabilitarCmboxAsegurado()
        cmboxAsegurado.Enabled = False
    End Sub

    Private Sub ocultarCmboxAsegurado()
        cmboxAsegurado.Visible = False
    End Sub

    Private Sub bloquearCamposInfoEmpresa()
        txtNitEmpresa.ReadOnly = True
        txtMatriculaDeComercioEmpresa.ReadOnly = True
        txtCodigoPatronal.ReadOnly = True
        txtRoe.ReadOnly = True
    End Sub





    'METOD INTERFAZ
    Private Sub poblarCmboxAsegurado()
        For Each asegurado As Asegurado In obActualizacionAseg.listaAsegurados
            cmboxAsegurado.Items.Add(asegurado.getDescripcion())
        Next
    End Sub

    Private Sub poblarCmboxTipoDocumento()
        obActualizacionAseg.traerTipoDeDoc()

        For Each obTipoDoc As Concepto In obActualizacionAseg.listaTipoDoc
            cmboxTipoDoc.Items.Add(obTipoDoc.getDescripcion())
        Next
    End Sub

    Private Sub poblarCmboxDepartamento()
        obActualizacionAseg.traerDepartamentos()

        For Each obDepartamento As Concepto In obActualizacionAseg.listaDepartamentos
            cmboxDepartamento.Items.Add(obDepartamento.getDescripcion())
        Next
    End Sub

    Private Sub poblarCmboxTipoSangre()
        obActualizacionAseg.traerTiposDeSangre()

        For Each obTipoSangre As Concepto In obActualizacionAseg.listaTiposDeSangre
            cmboxTipoSangre.Items.Add(obTipoSangre.getDescripcion())
        Next
    End Sub

    Private Sub poblarCmboxProvincias()
        For Each oProvincia As Concepto In obActualizacionAseg.listaProvincias
            If Not IsNothing(oProvincia) Then
                cmboxProvincia.Items.Add(oProvincia.getDescripcion)
            End If
        Next

    End Sub

    Private Sub poblarCmboxTipoAsegurado()
        obActualizacionAseg.traerTipoAsegurado()

        For Each tipoAsegurado As Concepto In obActualizacionAseg.listaTipoAsegurado
            cmboxTipoAsegurado.Items.Add(tipoAsegurado.getDescripcion())
        Next
    End Sub
    'metod. poblar combos


    Private Sub habilitarControles()
        cmboxTipoDoc.Enabled = True
        txtDocumento.Enabled = True
        txtExtension.Enabled = True
        cmboxTipoSangre.Enabled = True
        cmboxTipoAsegurado.Enabled = True


        txtDirDomicilio.Enabled = True
        rbuttonCiudad.Enabled = True
        rbuttonProvincia.Enabled = True
        txtTelefonoDomicilio.Enabled = True
        txtTelefonoReferencia.Enabled = True


        txtNitEmpresa.Enabled = True
        txtCodigoPatronal.Enabled = True
        txtMatriculaDeComercioEmpresa.Enabled = True
        txtRoe.Enabled = True
        rbuttonPublico.Enabled = True
        rbuttonPrivado.Enabled = True


        txtTelefonoLaboral.Enabled = True
        txtDirLaboral.Enabled = True


        cmboxDepartamento.Enabled = True
        cmboxProvincia.Enabled = True
        txtLocalidad.Enabled = True


        habilitarBtnGuardar()
    End Sub

    Private Sub deshabilitarControles()
        cmboxAsegurado.Enabled = False
        cmboxTipoDoc.Enabled = False
        txtNitEmpresa.Enabled = False
        txtMatriculaDeComercioEmpresa.Enabled = False
        txtCodigoPatronal.Enabled = False
        txtDirDomicilio.Enabled = False
        txtTelefonoDomicilio.Enabled = False
        txtDirDomicilio.Enabled = False
        txtDirLaboral.Enabled = False
        txtTelefonoLaboral.Enabled = False
        cmboxDepartamento.Enabled = False
        cmboxProvincia.Enabled = False
        txtLocalidad.Enabled = False
        txtTelefonoReferencia.Enabled = False
        cmboxTipoSangre.Enabled = False
        txtDocumento.Enabled = False
        txtExtension.Enabled = False
        txtRoe.Enabled = False
        rbuttonPublico.Enabled = False
        rbuttonPrivado.Enabled = False
        rbuttonCiudad.Enabled = False
        rbuttonProvincia.Enabled = False
        cmboxTipoAsegurado.Enabled = False
    End Sub

    Private Sub mostrarTxtAsegurado()
        txtNombreAsegurado.Enabled = False
        txtNombreAsegurado.Visible = True
    End Sub

    Private Sub deshabilitarBtnGuardar()
        btnGuardar.Enabled = False
    End Sub

    Private Sub habilitarBtnGuardar()
        btnGuardar.Enabled = True
    End Sub

    Private Sub deshabilitarBtnBuscar()
        btnBuscar.Enabled = False
    End Sub

    Private Sub habilitarBtnBuscar()
        btnBuscar.Enabled = True
    End Sub
    'metod. habilitar/deshabilitar


    Private Sub reiniciarControles()
        cmboxAsegurado.Items.Clear()

        cmboxTipoDoc.Items.Clear()
        poblarCmboxTipoDocumento()

        txtNitEmpresa.Text = ""
        txtMatriculaDeComercioEmpresa.Text = ""
        txtCodigoPatronal.Text = ""
        txtRoe.Text = ""
        txtDirDomicilio.Text = ""
        txtTelefonoDomicilio.Text = ""
        txtDirLaboral.Text = ""
        txtTelefonoLaboral.Text = ""
        txtTelefonoReferencia.Text = ""

        cmboxDepartamento.Items.Clear()
        poblarCmboxDepartamento()

        cmboxProvincia.Items.Clear()
        txtLocalidad.Text = ""

        cmboxTipoSangre.Items.Clear()
        poblarCmboxTipoSangre()
    End Sub

    Private Sub reiniciarCmboxProv()
        cmboxProvincia.Text = ""
        cmboxProvincia.Items.Clear()
    End Sub
    'metod. reiniciar

    Private Sub escribirInfoAsegurado(ByVal _asegurado As String, ByVal _matricula As String, ByVal _empresa As String)
        txtNombreAsegurado.Text = _asegurado
        lblMatricula.Text = _matricula
        lblEmpresa.Text = _empresa
    End Sub

    Private Sub rellenarInformacion()
        txtNitEmpresa.Text = obActualizacionAseg.oAsegurado.getEmpesa().getNit()
        txtCodigoPatronal.Text = obActualizacionAseg.oAsegurado.getEmpesa().getCodigoPatronal()
        txtDocumento.Text = obActualizacionAseg.oAsegurado.getNroDocumento()
        txtExtension.Text = obActualizacionAseg.oAsegurado.getComplemento()
        txtMatriculaDeComercioEmpresa.Text = obActualizacionAseg.oAsegurado.getEmpesa().getMatriculaComercio()
    End Sub

    Private Sub reiniciarFormulario()
        obActualizacionAseg = New ActualizacionAsegurado()
        iniciarControles()
    End Sub

    Private Sub reiniciarCampos()
        cmboxTipoDoc.Items.Clear()
        cmboxTipoDoc.Text = ""
        poblarCmboxTipoDocumento()
        cmboxTipoDoc.Enabled = False

        txtDocumento.Text = ""
        txtDocumento.Enabled = False

        txtExtension.Text = ""
        txtExtension.Enabled = False

        cmboxTipoSangre.Items.Clear()
        cmboxTipoSangre.Text = ""
        poblarCmboxTipoSangre()
        cmboxTipoSangre.Enabled = False

        txtDirDomicilio.Text = ""
        txtDirDomicilio.Enabled = False

        txtTelefonoDomicilio.Text = ""
        txtTelefonoDomicilio.Enabled = False

        txtTelefonoReferencia.Text = ""
        txtTelefonoReferencia.Enabled = False

        txtNitEmpresa.Text = ""
        txtNitEmpresa.Enabled = False


        txtNitEmpresa.Text = ""
        txtNitEmpresa.Enabled = False

        txtMatriculaDeComercioEmpresa.Text = ""
        txtMatriculaDeComercioEmpresa.Enabled = False

        txtCodigoPatronal.Text = ""
        txtCodigoPatronal.Enabled = False

        txtRoe.Text = ""
        txtRoe.Enabled = False

        txtTelefonoLaboral.Text = ""
        txtTelefonoLaboral.Enabled = False

        txtDirLaboral.Text = ""
        txtDirLaboral.Enabled = False

        cmboxDepartamento.Items.Clear()
        cmboxDepartamento.Text = ""
        poblarCmboxDepartamento()
        cmboxDepartamento.Enabled = False

        cmboxProvincia.Items.Clear()
        cmboxProvincia.Text = ""
        cmboxProvincia.Enabled = False

        txtLocalidad.Text = ""
        txtLocalidad.Enabled = False

        lblMatricula.Text = ""
        lblEmpresa.Text = ""

        rbuttonCiudad.Checked = False
        rbuttonProvincia.Checked = False

        rbuttonPublico.Checked = False
        rbuttonPrivado.Checked = False

        cmboxTipoAsegurado.Items.Clear()
        cmboxTipoAsegurado.Text = ""
        cmboxTipoAsegurado.Enabled = False

        btnGuardar.Enabled = False

        deshabilitarControles()
    End Sub

    Public Sub reiniciarTxtAsegurado()
        txtNombreAsegurado.Text = ""
        txtNombreAsegurado.Visible = False
    End Sub

    Public Sub reiniciarCmboxAsegurado()
        cmboxAsegurado.Items.Clear()
        cmboxAsegurado.Text = ""
    End Sub

    Public Sub mostrarCmboxAsegurado()
        cmboxAsegurado.Visible = True
    End Sub





    'METOD MOSTRAR MENSAJE
    Private Sub mostrarMensajeGuardarDatos(ByVal _respuesta As Int16)
        If _respuesta = 1 Then
            MessageBox.Show("Los datos se guardaron correctamente.")
        Else
            MessageBox.Show("Se produjo un error.")
        End If
    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje)
    End Sub





    'OTROS METODOS
    Private Sub guardarAsegurado(ByVal _asegurado As String, ByVal _matricula As String)
        obActualizacionAseg.oAsegurado = New Asegurado(_asegurado, _matricula)
    End Sub





    'METOD. CLICK
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        reiniciarCmboxAsegurado()

        Dim nombreAsegurado As String = txtBuscarAsegurado.Text.ToString().Trim()
        obActualizacionAseg.traerAsegurados(nombreAsegurado)
        poblarCmboxAsegurado()

        cmboxAsegurado.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim tipoDocumento As Int16 = obActualizacionAseg.buscarTipoDoc(cmboxTipoDoc.SelectedItem)
        Dim tipoAsegurado As Int16 = obActualizacionAseg.buscarTipoAseg(cmboxTipoAsegurado.SelectedItem)

        Dim tipoSangre As Int16 = obActualizacionAseg.buscarTipoSangre(cmboxTipoSangre.SelectedItem)
        Dim telfReferencia As String = txtTelefonoReferencia.Text.Trim()
        Dim dirDomicilio As String = txtDirDomicilio.Text.Trim()
        Dim telfDomicilio As String = txtTelefonoDomicilio.Text.Trim()
        Dim nroDocumento = txtDocumento.Text.Trim()
        Dim extension = txtExtension.Text.Trim()


        'Dim nitEmpresa As String = txtNitEmpresa.Text.Trim()
        'Dim matriculaComercio As String = txtMatriculaDeComercioEmpresa.Text.Trim()
        'Dim codigoPatronal As String = txtCodigoPatronal.Text.Trim()
        'Dim roe As String = txtRoe.Text.Trim()

        Dim dirLaboral As String = txtDirLaboral.Text.Trim()
        Dim telfLaboral As String = txtTelefonoLaboral.Text.Trim()
        Dim departamento As Int16 = obActualizacionAseg.buscarDepartamento(cmboxDepartamento.SelectedItem)
        Dim provincia As Int16 = obActualizacionAseg.buscarProvincia(cmboxProvincia.SelectedItem)
        Dim localidad As String = txtLocalidad.Text.Trim()
        Dim sector As Int16 = obActualizacionAseg.oAsegurado.getEmpesa().getSector().getCorrelativo()
        Dim lugarResidencia As Int16 = ""


        ''obActualizacionAseg.oAsegurado.setTipoDocumento(tipoDocumento)
        ''obActualizacionAseg.oAsegurado.setDepartamento(departamento)
        ''obActualizacionAseg.oAsegurado.setProvincia(provincia)
        ''obActualizacionAseg.oAsegurado.setTipoSangre(tipoSangre)
        ''obActualizacionAseg.oAsegurado.setDirDomicilio(dirDomicilio)
        'obActualizacionAseg.oAsegurado.setDirLaboral(dirLaboral)
        'obActualizacionAseg.oAsegurado.setLocalidad(localidad)
        'obActualizacionAseg.oAsegurado.setTelfDomicilio(telfDomicilio)
        'obActualizacionAseg.oAsegurado.setTelefonoLaboral(telfLaboral)
        obActualizacionAseg.oAsegurado.setTelefonoReferencia(telfReferencia)
        obActualizacionAseg.oAsegurado.setNroDocumento(nroDocumento)
        'obActualizacionAseg.oAsegurado.setExtension(extension)
        'obActualizacionAseg.oAsegurado.setLugarResidencia(lugarResidencia)
        'obActualizacionAseg.oAsegurado.setTipoAsegurado(tipoAsegurado)

        'obActualizacionAseg.oAsegurado.oEmpresa.setNit(nitEmpresa)
        'obActualizacionAseg.oAsegurado.oEmpresa.setMatriculaComercial(matriculaComercio)
        'obActualizacionAseg.oAsegurado.oEmpresa.setCodigoPatronal(codigoPatronal)
        'obActualizacionAseg.oAsegurado.oEmpresa.setRoe(roe
        'obActualizacionAseg.oAsegurado.oEmpresa.setSector(New Concepto().setCorrelativo(sector))


        Dim mensaje = obActualizacionAseg.revisarCamposVacios(tipoDocumento, dirDomicilio,
                                                              dirLaboral, telfLaboral,
                                                              departamento, provincia,
                                                              localidad, tipoSangre,
                                                              telfDomicilio, telfReferencia,
                                                              nroDocumento, extension,
                                                              sector, lugarResidencia,
                                                              tipoAsegurado)

        If (mensaje = Nothing) Or (mensaje = "") Then
            mensaje = obActualizacionAseg.validarEntradas(telfDomicilio, telfLaboral,
                                                          telfReferencia, nroDocumento)
            If mensaje = Nothing Or mensaje = "" Then
                Dim respuesta As Int16 = obActualizacionAseg.acutalizarDatosAsegurado()
                mostrarMensajeGuardarDatos(respuesta)
                'respuesta = obActualizacionAseg.acutalizarDatosEmpresa()
                'mostrarMensajeGuardarDatos(respuesta, "(Tabla Empresa)")
                reiniciarFormulario()
            Else
                mostrarMensaje(mensaje)
            End If
        Else
            mostrarMensaje(mensaje)
        End If


    End Sub

    'cuando el cmbox se abre, se selecciona algo y luego se cierra
    Private Sub cmboxAsegurado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxAsegurado.SelectionChangeCommitted
        If Not cmboxAsegurado.SelectedItem = Nothing Then
            Dim descripcion = cmboxAsegurado.SelectedItem.ToString()
            obActualizacionAseg.oAsegurado = obActualizacionAseg.buscarAsegurado(descripcion)

            Dim asegurado As String = obActualizacionAseg.oAsegurado.getNombres()
            Dim matricula As String = obActualizacionAseg.oAsegurado.getMatricula()
            Dim nombreEmpresa As String = obActualizacionAseg.oAsegurado.getEmpesa().getNombre()
            Dim codigoEmpresa As String = obActualizacionAseg.oAsegurado.getEmpesa().getCodigo()

            escribirInfoAsegurado(asegurado, matricula, nombreEmpresa)
            deshabilitarCmboxAsegurado()
            ocultarCmboxAsegurado()
            mostrarTxtAsegurado()


            habilitarControles()
            poblarCmboxTipoDocumento()
            poblarCmboxTipoAsegurado()
            poblarCmboxDepartamento()
            poblarCmboxTipoSangre()

            obActualizacionAseg.traerDatosAsegurado(matricula)
            rellenarInformacion()
            bloquearCamposInfoEmpresa()
        End If
    End Sub

    Private Sub cmboxDepartamento_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxDepartamento.SelectionChangeCommitted
        reiniciarCmboxProv()

        Dim departamento As String = cmboxDepartamento.SelectedItem.ToString()
        obActualizacionAseg.traerProvincias(departamento)
        poblarCmboxProvincias()

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarAsegurado.TextChanged
        If txtBuscarAsegurado.Text = "" Then
            deshabilitarBtnBuscar()
        Else
            habilitarBtnBuscar()
        End If
    End Sub

    Private Sub radioBPublico_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonPublico.CheckedChanged
        'tabla concepto: prefijo 15 | correlativo 1 | publico                                                                                                          
        Dim sector = 1
        If Not IsNothing(obActualizacionAseg.oAsegurado) Then
            'obActualizacionAseg.oAsegurado.oEmpresa.setSector(sector)
        End If

    End Sub

    Private Sub radioBPrivado_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonPrivado.CheckedChanged
        'tabla concepto: prefijo 15 | correlativo 2 | privado
        Dim sector = 2
        If Not IsNothing(obActualizacionAseg.oAsegurado) Then
            'obActualizacionAseg.oAsegurado.oEmpresa.setSector(sector)
        End If
    End Sub

    Private Sub rbuttonCiudad_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonCiudad.CheckedChanged
        'tabla concepto: prefijo 16 | correlativo 1 | ciudad
        Dim lugarResidencia = 1
        If Not IsNothing(obActualizacionAseg.oAsegurado) Then
            'obActualizacionAseg.oAsegurado.setLugarResidencia(lugarResidencia)
        End If
    End Sub

    Private Sub rbuttonProvincia_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonProvincia.CheckedChanged
        'tabla concepto: prefijo 16 | correlativo 2 | provincia
        Dim lugarResidencia = 2
        If Not IsNothing(obActualizacionAseg.oAsegurado) Then
            'obActualizacionAseg.oAsegurado.setLugarResidencia(lugarResidencia)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()
    End Sub
End Class
