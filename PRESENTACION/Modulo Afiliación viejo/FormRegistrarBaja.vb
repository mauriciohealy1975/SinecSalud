Imports NEGOCIO

Public Class FormRegistrarBaja

    Private regBaja As RegistroBaja
    Private titularSeleccionado As Titular
    Private cargoSeleccionado As Concepto
    Private motivoSeleccionado As Concepto


    'METODOS INICIO
    Private Sub FormRegistrarBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarDisplay()
        iniciarFormulario()
    End Sub

    Private Sub configurarDisplay()
        Dim ejeX As Int16 = Utilitarios.resolucionEstandarEjeX
        Dim ejeY As Int16 = Utilitarios.resolucionEstandarEjeY

        Size = New Size(ejeX, ejeY)
        MaximumSize = New System.Drawing.Size(ejeX, ejeY)
        MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarFormulario()
        iniciarControlesLogicos()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()


        regBaja.traerCargos()
        poblarCboxCargo()

        regBaja.traerMotivosBaja()
        poblarCboxMotivoBaja()
    End Sub

    Private Sub iniciarControlesLogicos()
        regBaja = New RegistroBaja()
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
        hintTitulares.Text = "SELECCIONAR ASEGURADO"
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

        txtUltimoEmpleador.Enabled = False
        txtUltimoEmpleador.Font = New Font("Microsoft Sans Serif", 9)
        txtUltimoEmpleador.Text = ""
        txtUltimoEmpleador.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub iniciarControlesGrupo2()
        panelDatosAvisoBaja.Enabled = True

        dpcFechaBaja.Enabled = False
        dpcFechaBaja.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaBaja.ShowUpDown = True
        dpcFechaBaja.Format = DateTimePickerFormat.Custom
        dpcFechaBaja.CustomFormat = "dd--MM--yyyy"
        dpcFechaBaja.Value = Date.Today

        cboxCargo.Enabled = True
        cboxCargo.Font = New Font("Microsoft Sans Serif", 9)
        cboxCargo.Items.Clear()
        cboxCargo.DropDownStyle = ComboBoxStyle.DropDownList

        hintCargo.Enabled = True
        hintCargo.Font = New Font("Microsoft Sans Serif", 8)
        hintCargo.Text = "SELECCIONAR"
        hintCargo.BackColor = Color.Transparent
        hintCargo.Visible = True

        numSalario.Enabled = True
        numSalario.Value = 0
        numSalario.DecimalPlaces = 2
        numSalario.Maximum = 99999.99
        numSalario.Minimum = 0

        cboxMotivo.Enabled = True
        cboxMotivo.Font = New Font("Microsoft Sans Serif", 9)
        cboxMotivo.Items.Clear()
        cboxMotivo.DropDownStyle = ComboBoxStyle.DropDownList

        hintMotivo.Enabled = True
        hintMotivo.Font = New Font("Microsoft Sans Serif", 8)
        hintMotivo.Text = "SELECCIONAR"
        hintMotivo.BackColor = Color.Transparent
        hintMotivo.Visible = True

        dpcFechaPresentacion.Enabled = True
        dpcFechaPresentacion.Font = New Font("Microsoft Sans Serif", 9)
        dpcFechaPresentacion.ShowUpDown = True
        dpcFechaPresentacion.Format = DateTimePickerFormat.Custom
        dpcFechaPresentacion.CustomFormat = "dd--MM--yyyy"
        dpcFechaPresentacion.Value = Date.Today
    End Sub

    Private Sub iniciarControlesGrupo3()
        btnCancelar.Enabled = True
        btnCancelar.Font = New Font("Microsoft Sans Serif", 9)
        btnCancelar.Text = "Cancelar"

        btnEnviar.Enabled = True
        btnEnviar.Font = New Font("Microsoft Sans Serif", 9)
        btnEnviar.Text = "Registrar baja"
    End Sub






    'METODOS INTERFAZ G1
    Private Sub poblarCboxTitulares()
        cboxTitulares.Items.Clear()

        For Each titular As Titular In regBaja.titulares
            cboxTitulares.Items.Add(titular.getMatricula() + " | " + titular.getApellidoPaterno + " " + titular.getApellidoMaterno() + " " + titular.getNombres())
        Next
    End Sub

    Private Sub ocultarHintTitulares()
        hintTitulares.Visible = False
    End Sub

    Private Sub mostrarHintTitulares()
        hintTitulares.Visible = True
    End Sub

    Private Sub mostrarInformacionTitular()
        Dim aviso As AvisoAfiliacion = regBaja.avisoMasReciente

        txtApellidoPaterno.Text = aviso.getAsegurado().getApellidoPaterno()
        txtApellidoMaterno.Text = aviso.getAsegurado().getApellidoMaterno()
        txtNombres.Text = aviso.getAsegurado().getNombres()
        txtUltimoEmpleador.Text = aviso.getEmpleador().getNombre()
    End Sub


    'METODOS INTERFAZ G2
    Private Sub poblarCboxCargo()
        cboxCargo.Items.Clear()

        For Each cargo As Concepto In regBaja.cargosLaborales
            cboxCargo.Items.Add(cargo.getDescripcion())
        Next
    End Sub

    Private Sub poblarCboxMotivoBaja()
        cboxMotivo.Items.Clear()

        For Each motivo As Concepto In regBaja.motivosBaja
            cboxMotivo.Items.Add(motivo.getDescripcion())
        Next
    End Sub

    Private Sub ocultarHintCargo()
        hintCargo.Visible = False
    End Sub

    Private Sub mostrarHintCargo()
        hintCargo.Visible = True
    End Sub

    Private Sub ocultarHintMotivo()
        hintMotivo.Visible = False
    End Sub

    Private Sub mostrarHintMotivo()
        hintMotivo.Visible = True
    End Sub


    'METODOS INTERFAZ G3
    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub







    'METODOS LOGICOS G1
    Private Sub seleccionarTitular(ByVal _index As Int16)
        titularSeleccionado = regBaja.titulares(_index)
    End Sub


    'METODOS LOGICOS G2
    Private Sub seleccionarCargo(ByVal _index As Int16)
        cargoSeleccionado = regBaja.cargosLaborales(_index)
    End Sub

    Private Sub seleccionarMotivo(ByVal _index As Int16)
        motivoSeleccionado = regBaja.motivosBaja(_index)
    End Sub


    'METODOS LOGICOS G6
    Private Function cargarDatos() As Boolean
        Try
            'cargar datos del formulario
            Dim titular As Asegurado = regBaja.avisoMasReciente.getAsegurado(), empresa As Empresa = regBaja.avisoMasReciente.getEmpleador(),
                fechaBaja As Date = dpcFechaBaja.Value,
                salario As Decimal = numSalario.Value,
                fecPresentacion As Date = dpcFechaPresentacion.Value

            Dim periodoCesantia() As Date = regBaja.generarPeriodoCesantia(fechaBaja),
                inicioCesantia As Date = periodoCesantia(0),
                finCesantia As Date = periodoCesantia(1)


            'agrupar todos los datos cargados en un objeto
            Dim nuevoAviso As AvisoAfiliacion = New AvisoAfiliacion()
            nuevoAviso.setAsegurado(titular)
            nuevoAviso.setEmpleador(empresa)
            nuevoAviso.setFechaBaja(fechaBaja)
            nuevoAviso.setCargo(cargoSeleccionado)
            nuevoAviso.setSalario(salario)
            nuevoAviso.setMotivo(motivoSeleccionado)
            nuevoAviso.setFechaPresentacion(fecPresentacion)
            nuevoAviso.setInicioCesantia(inicioCesantia)
            nuevoAviso.setFinCesantia(finCesantia)

            regBaja.nuevoAvisoBaja = nuevoAviso
            Return True

        Catch ex As Exception
            mostrarMensaje("Error. Ingrese los datos de la baja.")
            Return False
        End Try
    End Function

    Private Sub registrarAviso()
        Dim datosCargados As Boolean = cargarDatos()

        If datosCargados Then
            Dim mensajeValidacion As String = regBaja.validarEntradas()
            If mensajeValidacion = "" Then insertarAviso() Else mostrarMensaje(mensajeValidacion)
        End If
    End Sub

    Private Sub insertarAviso()
        Try
            Dim respuesta As Int16 = regBaja.insertarAviso()

            If respuesta > 0 Then
                mostrarMensaje("Los datos se guardaron correctamente.")
                reiniciarFormulario()
            Else
                mostrarMensaje("Hubo un error al guardar los datoss")
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    







    'EVENTOS G1
    Private Sub btnBuscarMatricula_Click(sender As Object, e As EventArgs) Handles btnBuscarMatricula.Click
        Try
            mostrarHintTitulares()
            Dim matricula As String = txtMatricula.Text.Trim()
            regBaja.traerTitulares(matricula)
            poblarCboxTitulares()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxTitulares_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxTitulares.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxTitulares.SelectedIndex()
            seleccionarTitular(index)
            Dim matricula As String = titularSeleccionado.getMatricula()
            regBaja.traerAltaReingresoMasReciente(matricula)
            mostrarInformacionTitular()
            ocultarHintTitulares()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G2
    Private Sub cboxCargo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxCargo.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxCargo.SelectedIndex
            seleccionarCargo(index)
            ocultarHintCargo()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboxMotivoBaja_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxMotivo.SelectionChangeCommitted
        Try
            Dim index As Int16 = cboxMotivo.SelectedIndex
            seleccionarMotivo(index)
            ocultarHintMotivo()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub


    'EVENTOS G6
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FormMenuAfiliacion.Show()
        Me.Close()

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim modoFormulario As Int16 = regBaja.modoFormulario

        If modoFormulario = 1 Then
            registrarAviso()
        End If
    End Sub




End Class