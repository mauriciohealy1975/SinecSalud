Imports NEGOCIO
Public Class FormRegistrarUsuario

    'MODO 1 GUARADR --- MODO 2 EDITAR ---- MODO 3 ELIMINAR
    Private registro As RegistroUsuario
    Dim oMedicoInsertado As Medico


    'ATRIBUTOS G1
    Private tipoUsuarioSeleccionado As Concepto


    'ATRIBUTOS G9
    Public nuevoUsuario As Usuario

    'METODOS INICIO 
    Private Sub FormRegistrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Public Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
    End Sub

    Private Sub configurarDisplay()
        Dim resEjeX As Int16 = 0
        Dim resEjeY As Int16 = 0

        resEjeX = Utilitarios.resolucionEstandarEjeX
        resEjeY = Utilitarios.resolucionEstandarEjeY

        Size = New Size(resEjeX, resEjeY)
        MaximumSize = New System.Drawing.Size(resEjeX, resEjeY)
        MinimumSize = New System.Drawing.Size(resEjeX, resEjeY)
    End Sub

    Private Sub iniciarControles()
        registro = New RegistroUsuario()
        registro.modoFormulario = 1

        tipoUsuarioSeleccionado = New Concepto()
        nuevoUsuario = New Usuario()


        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()
        iniciarControlesGrupo4(True)
        iniciarControlesGrupo5(True)


        traerTiposUsuario()
        poblarCboxTipo()

        poblarAmbosCmboxArea()
    End Sub

    Private Sub iniciarControlesGrupo1()
        iniciarControlesEditarEliminar()

        txtUsername.Enabled = True
        txtUsername.Font = New Font("Microsoft Sans Serif", 9)
        txtUsername.Text = ""
        txtUsername.CharacterCasing = CharacterCasing.Upper

        txtContraseña.Enabled = True
        txtContraseña.Font = New Font("Microsoft Sans Serif", 9)
        txtContraseña.Text = ""
        txtContraseña.PasswordChar = "*"

        cboxTipo.Enabled = True
        cboxTipo.Font = New Font("Microsoft Sans Serif", 9)
        cboxTipo.Items.Clear()
        cboxTipo.DropDownStyle = ComboBoxStyle.DropDownList

        hintTIpo.Enabled = True
        hintTIpo.Font = New Font("Microsoft Sans Serif", 9)
        hintTIpo.Text = "SELECCIONAR"
        hintTIpo.BackColor = Color.Transparent
        hintTIpo.Visible = True

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

        txtTelefono.Enabled = True
        txtTelefono.Font = New Font("Microsoft Sans Serif", 9)
        txtTelefono.Text = ""
    End Sub

    Private Sub iniciarControlesEditarEliminar()
        toolStripModosForm.BackColor = Color.FromArgb(244, 244, 244)

        tlStripGuardar.BackColor = Color.FromArgb(69, 143, 255)
        tlStripEditar.BackColor = Color.FromArgb(250, 250, 250)
        tlStripEliminar.BackColor = Color.FromArgb(250, 250, 250)


        fmeLblBuscar.Enabled = False
        fmeLblBuscar.Visible = False

        fmeTxtBuscarUsuario.Enabled = True
        fmeTxtBuscarUsuario.Visible = False
        fmeTxtBuscarUsuario.Font = New Font("Microsoft Sans Serif", 9)
        fmeTxtBuscarUsuario.Text = ""
        fmeTxtBuscarUsuario.CharacterCasing = CharacterCasing.Upper

        fmeCmboxUsername.Enabled = False
        fmeCmboxUsername.Visible = False
        fmeCmboxUsername.Font = New Font("Microsoft Sans Serif", 9)
        fmeCmboxUsername.Items.Clear()
        fmeCmboxUsername.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub iniciarControlesGrupo2()
        cmboxArea.Enabled = True
        cmboxArea.Font = New Font("Microsoft Sans Serif", 9)
        cmboxArea.Items.Clear()
        cmboxArea.DropDownStyle = ComboBoxStyle.DropDownList

        hintCboxArea.Enabled = True
        hintCboxArea.Font = New Font("Microsoft Sans Serif", 9)
        hintCboxArea.Text = "SELECCIONAR"
        hintCboxArea.BackColor = Color.Transparent
        hintCboxArea.Visible = True

        cmboxPuesto.Enabled = True
        cmboxPuesto.Font = New Font("Microsoft Sans Serif", 9)
        cmboxPuesto.Items.Clear()
        cmboxPuesto.DropDownStyle = ComboBoxStyle.DropDownList

        hintCboxPuesto.Enabled = True
        hintCboxPuesto.Font = New Font("Microsoft Sans Serif", 9)
        hintCboxPuesto.Text = "SELECCIONAR"
        hintCboxPuesto.BackColor = Color.Transparent
        hintCboxPuesto.Visible = True


        btnMostrarMenuArea.Enabled = True
        btnMostrarMenuPuesto.Enabled = True
    End Sub

    Private Sub iniciarControlesGrupo3()
        btnCancelar.Enabled = True
        btnCancelar.Font = New Font("Microsoft Sans Serif", 9)
        btnCancelar.Text = "Canelar"

        btnGuardarUsuario.Enabled = True
        btnGuardarUsuario.Font = New Font("Microsoft Sans Serif", 9)
        btnGuardarUsuario.Text = "Guardar usuario"
    End Sub

    Private Sub iniciarControlesGrupo4(ByVal _ocultarPanel As Boolean)
        registro.oAreaSeleccionadaAgregarArea = New AreaTrabajo()


        If _ocultarPanel Then
            panelAgregarArea.Visible = False
        End If

        txtAgregarArea.Enabled = True
        txtAgregarArea.Font = New Font("Microsoft Sans Serif", 9)
        txtAgregarArea.Text = ""
        txtAgregarArea.CharacterCasing = CharacterCasing.Upper

        btnAgregarArea.Enabled = True
        btnAgregarArea.Font = New Font("Microsoft Sans Serif", 9)
        btnAgregarArea.Text = "Agregar Area"
    End Sub

    Private Sub iniciarControlesGrupo5(ByVal _ocultarPanel As Boolean)
        registro.oAreaSeleccionadaAgregarArea = New AreaTrabajo()

        If _ocultarPanel Then
            panelAgregarPuesto.Visible = False
        End If

        cmboxAsignarArea.Enabled = True
        cmboxAsignarArea.Font = New Font("Microsoft Sans Serif", 9)
        cmboxAsignarArea.DropDownStyle = ComboBoxStyle.DropDownList
        cmboxAsignarArea.SelectedIndex = -1


        hintCmboxAgregarArea.Visible = True
        hintCmboxAgregarArea.Font = New Font("Microsoft Sans Serif", 9)
        hintCmboxAgregarArea.Text = "SELECCIONAR"

        txtAgregarPuesto.Enabled = True
        txtAgregarPuesto.Font = New Font("Microsoft Sans Serif", 9)
        txtAgregarPuesto.Text = ""
        txtAgregarPuesto.CharacterCasing = CharacterCasing.Upper

        btnAgregarPuesto.Enabled = True
        btnAgregarPuesto.Font = New Font("Microsoft Sans Serif", 9)
        btnAgregarPuesto.Text = "Agregar puesto"
    End Sub





    'METODOS INTERFAZ
    Private Sub poblarCboxTipo()
        cboxTipo.Items.Clear()

        For Each tipo As Concepto In registro.tiposUsuarios
            cboxTipo.Items.Add(tipo.getDescripcion())
        Next
    End Sub

    Private Sub mostrarHintTipo()
        hintTIpo.Visible = True
    End Sub

    Private Sub ocultarHintTipo()
        hintTIpo.Visible = False
    End Sub

    Private Sub poblarAmbosCmboxArea()
        poblarCmboxAreas()
        poblarCmboxAgregarArea()
    End Sub

    Private Sub poblarCmboxAreas()
        cmboxArea.Items.Clear()

        Try
            registro.traerAreasTrabajo()
            For Each area As AreaTrabajo In registro.listaAreasTrabajo
                cmboxArea.Items.Add(area.getNombre)
            Next
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub poblarCmboxPuestos()
        cmboxPuesto.Items.Clear()

        Try
            registro.traerPuestosTrabajo()
            For Each puesto As PuestoTrabajo In registro.listaPuestosTrabajo
                cmboxPuesto.Items.Add(puesto.getNombre())
            Next
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub poblarCmboxAgregarArea()
        cmboxAsignarArea.Items.Clear()

        Try
            registro.traerAreasTrabajo()
            For Each area As AreaTrabajo In registro.listaAreasTrabajo
                cmboxAsignarArea.Items.Add(area.getNombre)
            Next
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub

    Private Sub cancelarRegistro()
        Dim dialogResult As DialogResult = MessageBox.Show("¿Está seguro de cancelar este registro de usuario?",
                                 "Cancelar registro", MessageBoxButtons.YesNo)

        If dialogResult = DialogResult.Yes Then
            reiniciarFormulario()
        End If

    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub





    'METODOS LOGICOS G1
    Private Sub traerTiposUsuario()
        registro.traerTiposUsuario()
    End Sub

    Private Sub seleccionarUsuario()
        Dim index As Short = cboxTipo.SelectedIndex
        tipoUsuarioSeleccionado = registro.tiposUsuarios(index)
        'MessageBox.Show("index: " + index.ToString() + "tipo de usuario seleccionado: " + tipoUsuarioSeleccionado.getCorrelativo().ToString())
    End Sub


    Private Function cargarObjetos()
        Try
            Dim username As String, contraseña As String, apPaterno As String, apMaterno As String,
                nombres As String, telefono As String

            username = txtUsername.Text.Trim()
            contraseña = txtContraseña.Text.Trim()
            apPaterno = txtApellidoPaterno.Text.Trim()
            apMaterno = txtApellidoMaterno.Text.Trim()
            nombres = txtNombres.Text.Trim()
            telefono = txtTelefono.Text.Trim()

            nuevoUsuario = New Usuario()
            nuevoUsuario.setTipo(tipoUsuarioSeleccionado)
            nuevoUsuario.setUsername(username)
            nuevoUsuario.setContraseña(contraseña)
            nuevoUsuario.setApellidoPaterno(apPaterno)
            nuevoUsuario.setApellidoMaterno(apMaterno)
            nuevoUsuario.setNombres(nombres)
            nuevoUsuario.setTelefono(telefono)

            Dim mensaje As String = registro.validarEntradas(nuevoUsuario)

            If Not mensaje = "" Then
                mostrarMensaje(mensaje)
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try

    End Function

    Private Sub guardarArea()
        Dim mensaje As String = ""

        Try
            Dim nombreArea As String = txtAgregarArea.Text.Trim()
            mensaje = registro.validarEntradasAgregarArea(nombreArea)

            If Not mensaje = "" Then
                mostrarMensaje(mensaje)
            Else
                Dim respuesta As Int16 = 0
                respuesta = registro.guardarArea(nombreArea)

                If respuesta = 1 Then
                    mostrarMensaje("Los datos se guardaron correctamente")
                    iniciarControlesGrupo4(False)
                    poblarAmbosCmboxArea()
                Else
                    mostrarMensaje("Error. No se pudieron guardar los datos")
                End If
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

        iniciarControlesGrupo4(False)
    End Sub

    Private Sub guardarPuesto()
        Dim mensaje As String = ""

        Try
            Dim nombrePuesto As String = txtAgregarPuesto.Text.Trim()
            mensaje = registro.validarEntradasAgregarPuesto(nombrePuesto)

            If Not mensaje = "" Then
                mostrarMensaje(mensaje)
            Else
                Dim respuesta As Int16 = 0
                respuesta = registro.guardarPuesto(nombrePuesto)

                If respuesta = 1 Then
                    mostrarMensaje("Los datos se guardaron correctamente")
                    iniciarControlesGrupo5(False)
                    poblarAmbosCmboxArea()
                Else
                    mostrarMensaje("Error. No se pudieron guardar los datos")
                End If
            End If


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

        iniciarControlesGrupo5(False)
    End Sub

    Private Function revisarRegistroMedico()
        Return (registro.revisarUsuarioTipoMedico())
    End Function

    Private Function registrarMedico()

        Dim username, apPaterno, apMaterno, nombres, nombreCompleto As String

        username = txtUsername.Text.Trim()
        apPaterno = txtApellidoPaterno.Text.Trim()
        apMaterno = txtApellidoMaterno.Text.Trim()
        nombres = txtNombres.Text.Trim()
        nombreCompleto = apPaterno + " " + apMaterno + " " + nombres

        Dim formMedico As FormRegistrarMedico = New FormRegistrarMedico(username, nombreCompleto)
        formMedico.ShowDialog()


        'despues de cerrar el show dialog
        Dim registroCompletado As Boolean = formMedico.registroCompletadoP
        If registroCompletado Then
            oMedicoInsertado = formMedico.MedicoInsertadoP
        End If

        Return registroCompletado
    End Function

    Private Sub guardarUsuarioTipoMedico()
        Dim codigoUsuario As Int16 = 0
        Dim codigoMedico As Int16 = 0

        codigoUsuario = registro.guardarUsuarioTipoMedico(nuevoUsuario)
        codigoMedico = oMedicoInsertado.getCodigo()

        registro.actualizarMedico(codigoUsuario, codigoMedico)
    End Sub

    Private Sub guardarUsuarioComun()
        Dim respuesta As Int16 = registro.guardarUsuarioComun(nuevoUsuario)

        If respuesta = 1 Then
            mostrarMensaje("Se guardaron los datos correctmente.")
            reiniciarFormulario()
        Else
            mostrarMensaje("Hubo un error al guardar los datos.")
        End If

    End Sub

    Private Sub guardarUsuario()
        Dim datosCargados As Boolean = cargarObjetos()

        If datosCargados Then
            Dim EsMedico As Boolean = revisarRegistroMedico()

            If EsMedico Then
                Dim registroCompletado As Boolean = registrarMedico()

                If registroCompletado Then
                    guardarUsuarioTipoMedico()
                    mostrarMensaje("El usuario de tipo médico se guardó correctamente.")
                    reiniciarFormulario()
                End If

            Else
                If (registro.EsTipoCD) Then 'AQUI ESTOY TRABAJNAOD NO TE PASES
                    Dim proxr = registro.obtenerproximoregistro()
                    Dim FormGMCD = New FormRegMedDiagnostico
                    Dim nombre = nuevoUsuario.getNombres() + " " + nuevoUsuario.getApellidoPaterno + " " + nuevoUsuario.getApellidoMaterno
                    FormGMCD.SetProximoRegistro(proxr)
                    FormGMCD.SetNombre(nombre)
                    FormGMCD.ShowDialog()
                    If Not FormGMCD.GetCompleto() = "" Then
                        guardarUsuarioComun()

                        MessageBox.Show("Registro Realizado")
                    Else
                        MessageBox.Show("Registro Cancelado")
                    End If
                    'MessageBox.Show("El porixmo registr0o es " + proxr)
                Else
                    guardarUsuarioComun()
                End If
            End If
            End If
    End Sub






    'EVENTOS CONTROLES GRUPO 2    
    Private Sub cmboxArea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxArea.SelectionChangeCommitted
        hintCboxArea.Visible = False
        hintCboxPuesto.Visible = True

        Dim indexArea As Int16 = 0
        Try
            indexArea = cmboxArea.SelectedIndex
            registro.seleccionarArea(indexArea)
            poblarCmboxPuestos()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cmboxPuesto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxPuesto.SelectionChangeCommitted
        hintCboxPuesto.Visible = False


        Dim indexPuesto As Int16 = 0

        Try
            indexPuesto = cmboxPuesto.SelectedIndex
            registro.seleccionarPuesto(indexPuesto)
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub btnMostrarMenuArea_Click(sender As Object, e As EventArgs) Handles btnMostrarMenuArea.Click
        If panelAgregarArea.Visible Then
            panelAgregarArea.Visible = False
        Else
            panelAgregarArea.Visible = True
        End If

    End Sub

    Private Sub btnMostrarMenuPuesto_Click(sender As Object, e As EventArgs) Handles btnMostrarMenuPuesto.Click
        If panelAgregarPuesto.Visible Then
            panelAgregarPuesto.Visible = False
        Else
            panelAgregarPuesto.Visible = True
        End If

    End Sub





    'EVENTOS CONTROLES GRUPO 3
    Private Sub btnGuardarUsuario_Click(sender As Object, e As EventArgs) Handles btnGuardarUsuario.Click
        Dim modoFormulario As Int16 = registro.modoFormulario

        If modoFormulario = 1 Then
            guardarUsuario()

        ElseIf modoFormulario = 2 Then
            editarUsuario()

        ElseIf modoFormulario = 3 Then
            eliminarUsuario()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim modoFormulario As Int16 = registro.modoFormulario

        If modoFormulario = 1 Then
            cancelarRegistro()

        ElseIf modoFormulario = 2 Then
            cancelarEdicion()

        ElseIf modoFormulario = 3 Then
            cancelarEliminacion()
        End If

    End Sub





    'EVENTOS CONTROLES GRUPO 4 
    Private Sub btnAgregarArea_Click(sender As Object, e As EventArgs) Handles btnAgregarArea.Click
        guardarArea()
    End Sub





    'EVENTOS CONTROLES GRUPO 5
    Private Sub cmboxAgregarArea_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxAsignarArea.SelectionChangeCommitted
        Dim indexAgregarArea As Int16 = 0

        Try
            indexAgregarArea = cmboxAsignarArea.SelectedIndex
            registro.seleccionarAreaCmboxAsignarArea(indexAgregarArea)
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

        hintCmboxAgregarArea.Visible = False
    End Sub

    Private Sub btnAgregarPuesto_Click(sender As Object, e As EventArgs) Handles btnAgregarPuesto.Click
        guardarPuesto()
        panelAgregarPuesto.Visible = False
    End Sub





    'EVENTROS BARRA TOOLSTRIP
    Private Sub tlStripRegistrar_Click(sender As Object, e As EventArgs) Handles tlStripGuardar.Click
        registro.modoFormulario = 1
        reiniciarFormulario()
    End Sub

    Private Sub tlStripEditar_Click(sender As Object, e As EventArgs) Handles tlStripEditar.Click
        reiniciarFormulario()
        cambiarFormAModoEditar()
    End Sub

    Private Sub tlStripEliminar_Click(sender As Object, e As EventArgs) Handles tlStripEliminar.Click
        reiniciarFormulario()
        cambiarFormAModoEliminar()
    End Sub











    'MODO EDITAR  --------------------------------------------- METODOS INTERFAZ
    Private Sub cambiarFormAModoEditar()
        registro.modoFormulario = 2
        tlStripEditar.BackColor = Color.FromArgb(69, 143, 255)
        tlStripGuardar.BackColor = Color.FromArgb(250, 250, 250)
        tlStripEliminar.BackColor = Color.FromArgb(250, 250, 250)


        txtUsername.Enabled = False
        txtContraseña.Enabled = True
        txtApellidoPaterno.Enabled = True
        txtApellidoMaterno.Enabled = True
        txtNombres.Enabled = True
        txtTelefono.Enabled = True
        hintCboxArea.Enabled = False
        cmboxArea.Enabled = False
        hintCboxPuesto.Enabled = False
        cmboxPuesto.Enabled = False

        btnMostrarMenuArea.Enabled = False
        btnMostrarMenuPuesto.Enabled = False


        fmeLblBuscar.Enabled = True
        fmeLblBuscar.Visible = True
        fmeTxtBuscarUsuario.Enabled = True
        fmeTxtBuscarUsuario.Visible = True
        fmeCmboxUsername.Enabled = True
        fmeCmboxUsername.Visible = True
        btnGuardarUsuario.Text = "Editar usuario"
    End Sub

    Private Sub mostrarInfoUsuarioFmed()
        Dim oUsAux As Usuario = registro.oUsuarioSeleccionado

        txtUsername.Text = oUsAux.getUsername()
        txtContraseña.Text = oUsAux.getContraseña()
        txtApellidoPaterno.Text = oUsAux.getApellidoPaterno()
        txtApellidoMaterno.Text = oUsAux.getApellidoMaterno()
        txtNombres.Text = oUsAux.getNombres()
        txtTelefono.Text = oUsAux.getTelefono()
        hintCboxArea.Visible = False
        hintCboxPuesto.Visible = False

        Try
            cmboxArea.SelectedItem = oUsAux.getArea.getNombre
            Dim indexArea As Int16 = cmboxArea.SelectedIndex
            registro.seleccionarArea(indexArea)
            poblarCmboxPuestos()

            cmboxPuesto.SelectedItem = oUsAux.getPuesto.getNombre
            Dim indexPuesto As Int16 = cmboxPuesto.SelectedIndex
            registro.seleccionarPuesto(indexPuesto)

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cancelarEdicion()
        Dim dialogResult As DialogResult = MessageBox.Show("¿Está seguro de cancelar la edición de usuario?",
                      "Cancelar edicion", MessageBoxButtons.YesNo)

        If dialogResult = DialogResult.Yes Then
            reiniciarFormulario()
            cambiarFormAModoEditar()
        End If
    End Sub


    'METODOS LOGICOS
    Private Sub editarUsuario()
        Dim datosCargados As Boolean = cargarObjetos()

        If datosCargados Then
            editarUsuarioComun(Me.Text)
        End If
    End Sub

    Private Sub editarUsuarioComun(ByVal _nombreFormulario As String)
        Dim username, contraseña, apPaterno, apMaterno,
            nombres, telefono, tipo As String

        username = txtUsername.Text.Trim()
        contraseña = txtContraseña.Text.Trim()
        apPaterno = txtApellidoPaterno.Text.Trim()
        apMaterno = txtApellidoMaterno.Text.Trim()
        nombres = txtNombres.Text.Trim()
        telefono = txtTelefono.Text.Trim()
        tipo = tipoUsuarioSeleccionado.getCorrelativo().ToString()
        Dim respuesta As Int16 = registro.editarUsuarioComun(username, contraseña, apPaterno, apMaterno, nombres, telefono, _nombreFormulario, tipo)

        If respuesta = 2 Then
            mostrarMensaje("Se editaron los datos correctmente.")
            reiniciarFormulario()
            cambiarFormAModoEditar()
        Else
            mostrarMensaje("Hubo un error al editar los datos.")
        End If
    End Sub










    'MODO ELIMINAR -------------------------------------------- METODOS INTERFAZ
    Private Sub cambiarFormAModoEliminar()
        registro.modoFormulario = 3
        tlStripEliminar.BackColor = Color.FromArgb(69, 143, 255)
        tlStripEditar.BackColor = Color.FromArgb(250, 250, 250)
        tlStripGuardar.BackColor = Color.FromArgb(250, 250, 250)


        txtUsername.Enabled = False
        txtContraseña.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtApellidoMaterno.Enabled = False
        txtNombres.Enabled = False
        txtTelefono.Enabled = False
        cmboxArea.Enabled = False
        hintCboxArea.Enabled = False
        cmboxPuesto.Enabled = False
        hintCboxPuesto.Enabled = False
        btnMostrarMenuArea.Enabled = False
        btnMostrarMenuPuesto.Enabled = False


        fmeLblBuscar.Enabled = True
        fmeLblBuscar.Visible = True
        fmeTxtBuscarUsuario.Enabled = True
        fmeTxtBuscarUsuario.Visible = True
        fmeCmboxUsername.Enabled = True
        fmeCmboxUsername.Visible = True
        btnGuardarUsuario.Text = "Eliminar usuario"
    End Sub

    Private Sub poblarCmboxUsernameME(ByVal _username As String)
        fmeCmboxUsername.Items.Clear()
        registro.fmeTraerUsuarios(_username)

        For Each usuario As Usuario In registro.listaUsuarios
            fmeCmboxUsername.Items.Add(usuario.getUsername + " | " + usuario.getNombres + " " + usuario.getApellidoPaterno + " " + usuario.getApellidoMaterno)
        Next

    End Sub

    Private Sub mostrarInfoUsuarioFmel()
        Dim oUsAux As Usuario = registro.oUsuarioSeleccionado

        txtUsername.Text = oUsAux.getUsername()
        txtContraseña.Text = oUsAux.getContraseña()
        txtApellidoPaterno.Text = oUsAux.getApellidoPaterno()
        txtApellidoMaterno.Text = oUsAux.getApellidoMaterno()
        txtNombres.Text = oUsAux.getNombres()
        txtTelefono.Text = oUsAux.getTelefono()

        hintCboxArea.Visible = False
        hintCboxPuesto.Visible = False


        Try
            cmboxArea.SelectedItem = oUsAux.getArea.getNombre
            Dim indexArea As Int16 = cmboxArea.SelectedIndex
            registro.seleccionarArea(indexArea)
            poblarCmboxPuestos()

            cmboxPuesto.SelectedItem = oUsAux.getPuesto.getNombre
            Dim indexPuesto As Int16 = cmboxPuesto.SelectedIndex
            registro.seleccionarPuesto(indexPuesto)

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub cancelarEliminacion()
        Dim dialogResult As DialogResult = MessageBox.Show("¿Está seguro de cancelar la eliminación de usuario?",
                        "Cancelar eliminación", MessageBoxButtons.YesNo)

        If dialogResult = DialogResult.Yes Then
            reiniciarFormulario()
            cambiarFormAModoEliminar()
        End If

    End Sub


    'METODOS LOGICOS
    Private Sub eliminarUsuario()
        Dim dialogResult As DialogResult = MessageBox.Show("¿Está seguro de eliminar a este usuario?", "Eliminar usuario",
                                                           MessageBoxButtons.YesNo)

        If dialogResult = DialogResult.Yes Then

            Dim revisionExitosa As Boolean = revisarRegistroMedico()
            If revisionExitosa Then
                registro.fmeEliminarUsuario(Me.Text)
                registro.fmeEliminarMedico(Me.Text)
            Else
                registro.fmeEliminarUsuario(Me.Text)
            End If

            mostrarMensaje("El usuario se eliminó correctamente.")
            reiniciarFormulario()
            cambiarFormAModoEliminar()
        End If

    End Sub



    'EVENTOS G1
    Private Sub cboxTipo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTipo.SelectionChangeCommitted
        Try
            seleccionarUsuario()
            ocultarHintTipo()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscarUsuario_KeyUp(sender As Object, e As KeyEventArgs) Handles fmeTxtBuscarUsuario.KeyUp
        Dim modoFormulario As Int16 = registro.modoFormulario


        If e.KeyCode = Keys.Enter Then
            'ya sea en modo editar o eliminar, se traen los datos de la misma forma
            If modoFormulario = 2 Or modoFormulario = 3 Then
                Try
                    Dim username As String = ""
                    username = fmeTxtBuscarUsuario.Text.Trim()
                    poblarCmboxUsernameME(username)
                Catch ex As Exception
                    mostrarMensaje(ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub fmeCmboxUsername_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles fmeCmboxUsername.SelectionChangeCommitted
        Dim modoFormulario As Int16 = registro.modoFormulario

        Try
            Dim index As Int16 = 0
            index = fmeCmboxUsername.SelectedIndex

            registro.fmeSeleccionarUSuario(index)

            If modoFormulario = 2 Then
                mostrarInfoUsuarioFmed()

            ElseIf modoFormulario = 3 Then
                mostrarInfoUsuarioFmel()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FormMenuControlDeUsuario.Show()
        Me.Close()
    End Sub



    Private Sub txtTelefono_MouseClick(sender As Object, e As MouseEventArgs) Handles txtTelefono.MouseClick
        If txtTelefono.Text = "" Then
            txtTelefono.Text = "00000000"
        End If
    End Sub


End Class





