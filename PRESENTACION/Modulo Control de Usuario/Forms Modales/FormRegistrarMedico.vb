Imports NEGOCIO

Public Class FormRegistrarMedico

    Private oRegMedico As RegistroMedico
    Private registroCompletado As Boolean
    Private oMedicoInsertado As Medico

    Private username As String
    Private nombreCompleto As String

    Private horaEntrada As String
    Private horaSalida As String
    Private diasTurno As String
    Private tipoTurno As Char
    Private nroFichas As Int16
    Private tiempoDuracionFicha As Int16


    Dim datosCargadosMedico As Boolean
    Dim datosCargadosTurno As Boolean

    Dim mensajeValidarMedico As String
    Dim mensajeValidarTurno As String


    '*****************************************  
    Dim direccion, telefonos As String



    'PROPERTIES
    Public ReadOnly Property registroCompletadoP As Boolean
        Get
            Return registroCompletado
        End Get
    End Property

    Public ReadOnly Property MedicoInsertadoP As Medico
        Get
            Return oMedicoInsertado
        End Get
    End Property




    'METOODS INICIO
    Public Sub New(ByVal _username As String, ByVal _nombreCompleto As String)
        InitializeComponent()

        registroCompletado = New Boolean()
        registroCompletado = False
        username = _username
        nombreCompleto = _nombreCompleto
        LFD.Visible = False
        txbCantFicExt.Visible = False
    End Sub

    Private Sub FormRegistrarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarFormulario()
    End Sub

    Public Sub iniciarFormulario()
        configurarDisplay()
        iniciarControles()
    End Sub

    Private Sub configurarDisplay()
        Size = New Size(1053, 600)
        MaximumSize = New System.Drawing.Size(1053, 600)
        MinimumSize = New System.Drawing.Size(1053, 600)
    End Sub

    Private Sub iniciarControles()
        oRegMedico = New RegistroMedico()

        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        poblarCmboxEspecialidad()
        poblarCmboxDuracionFichas()
        poblarChlistDias()
    End Sub

    Private Sub iniciarControlesGrupo1()
        txtUsername.Enabled = True
        txtUsername.ReadOnly = True
        txtUsername.Font = New Font("Microsoft Sans Serif", 9)
        txtUsername.Text = username

        txtNombreCompleto.Enabled = True
        txtNombreCompleto.ReadOnly = True
        txtNombreCompleto.Font = New Font("Microsoft Sans Serif", 9)
        txtNombreCompleto.Text = nombreCompleto

        cmboxEspecialidad.Enabled = True
        cmboxEspecialidad.Font = New Font("Microsoft Sans Serif", 9)
        cmboxEspecialidad.Items.Clear()
        cmboxEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList

        hintCboxEspecialidad.Font = New Font("Microsoft Sans Serif", 9)
        hintCboxEspecialidad.Text = "SELECCIONAR"
        hintCboxEspecialidad.BackColor = Color.Transparent
        hintCboxEspecialidad.Visible = True
    End Sub

    Private Sub iniciarControlesGrupo2()
        iniciarTipoTurno()
        iniciarHorasTurno()
        inciarDuracionFicha()
        iniciarCantidadFichas()
        iniciarListDias()


        rButtonMañana.Checked = True
    End Sub

    Private Sub iniciarTipoTurno()
        rButtonMañana.Enabled = True
        rButtonMañana.Checked = False

        rButtonTarde.Enabled = True
        rButtonMañana.Checked = False
    End Sub

    Private Sub iniciarHorasTurno()
        cmboxEntradaHora.Enabled = True
        cmboxEntradaHora.Font = New Font("Microsoft Sans Serif", 9)
        cmboxEntradaHora.DropDownStyle = ComboBoxStyle.DropDownList

        cmboxEntradaMinutos.Enabled = True
        cmboxEntradaMinutos.Font = New Font("Microsoft Sans Serif", 9)
        cmboxEntradaMinutos.DropDownStyle = ComboBoxStyle.DropDownList

        cmboxSalidaHora.Enabled = True
        cmboxSalidaHora.Font = New Font("Microsoft Sans Serif", 9)
        cmboxSalidaHora.DropDownStyle = ComboBoxStyle.DropDownList

        cmboxSalidaMinutos.Enabled = True
        cmboxSalidaMinutos.Font = New Font("Microsoft Sans Serif", 9)
        cmboxSalidaMinutos.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub inciarDuracionFicha()
        cmboxDuracionFicha.Enabled = True
        cmboxDuracionFicha.Font = New Font("Microsoft Sans Serif", 9)
        cmboxDuracionFicha.DropDownStyle = ComboBoxStyle.DropDownList

        hintCmboxDuracionFicha.Visible = True
        hintCmboxDuracionFicha.Font = New Font("Microsoft Sans Serif", 9)
        hintCmboxDuracionFicha.Text = "SELECCIONAR"
    End Sub

    Private Sub iniciarCantidadFichas()
        txtCantidadFichas.Enabled = True
        txtCantidadFichas.Font = New Font("Microsoft Sans Serif", 9)
        txtCantidadFichas.Text = "0"
        txtCantidadFichas.ReadOnly = True
    End Sub

    Private Sub iniciarListDias()
        chListDias.Enabled = True
        chListDias.Font = New Font("Microsoft Sans Serif", 9)
    End Sub





    'METODOS INTERFAZ
    Private Sub poblarCmboxEspecialidad()
        cmboxEspecialidad.Items.Clear()

        Try
            oRegMedico.traerEspecialidades()
            For Each especialidad As Especialidad In oRegMedico.listaEspecialidades
                cmboxEspecialidad.Items.Add(especialidad.getnombre())
            Next

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub poblarCmboxDuracionFichas()
        cmboxDuracionFicha.Items.Clear()

        Try
            oRegMedico.traerDuracionFichas()
            For Each duracionFicha As Concepto In oRegMedico.listadDuracionFichas
                cmboxDuracionFicha.Items.Add(duracionFicha.getDescripcion() + " MINUTOS")
            Next

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    Private Sub poblarChlistDias()
        chListDias.Items.Clear()

        For Each dia As String In oRegMedico.listaDiasSemana
            chListDias.Items.Add(dia)
        Next
    End Sub

    Private Sub poblarAmbosCmbHorasTurnoMaña()
        cmboxEntradaHora.Items.Clear()
        cmboxSalidaHora.Items.Clear()

        For Each hora As String In oRegMedico.horasTurnoMañana
            cmboxEntradaHora.Items.Add(hora)
            cmboxSalidaHora.Items.Add(hora)
        Next

        cmboxEntradaHora.SelectedIndex = 0
        cmboxSalidaHora.SelectedIndex = 6
    End Sub

    Private Sub poblarAmbosCombHorasTurnoTarde()
        cmboxEntradaHora.Items.Clear()
        cmboxSalidaHora.Items.Clear()

        For Each hora As String In oRegMedico.horasTurnoTarde
            cmboxEntradaHora.Items.Add(hora)
            cmboxSalidaHora.Items.Add(hora)
        Next


        cmboxEntradaHora.SelectedIndex = 0
        cmboxSalidaHora.SelectedIndex = 6
    End Sub

    Private Sub poblarAmbosCombMinutos()
        cmboxEntradaMinutos.Items.Clear()
        cmboxSalidaMinutos.Items.Clear()

        For Each minutos As String In oRegMedico.listaMinutos
            cmboxEntradaMinutos.Items.Add(minutos)
            cmboxSalidaMinutos.Items.Add(minutos)
        Next

        cmboxEntradaMinutos.SelectedIndex = 0
        cmboxSalidaMinutos.SelectedIndex = 0
    End Sub

    Private Sub calcularNroFichasTurno()
        Dim horaEntrada As Int16 = Int16.Parse(cmboxEntradaHora.SelectedItem.ToString)
        Dim horaSalida As Int16 = Int16.Parse(cmboxSalidaHora.SelectedItem.ToString)
        Dim minutosEntrada As Int16 = Int16.Parse(cmboxEntradaMinutos.SelectedItem.ToString)
        Dim minutosSalida As Int16 = Int16.Parse(cmboxSalidaMinutos.SelectedItem.ToString)

        Dim minutosAcumulados As Int16 = minutosEntrada + minutosSalida
        Dim tiempoFicha As Int16 = oRegMedico.oDuracionFichaSeleccionada.getDescripcion()


        nroFichas = oRegMedico.calcularCantidadFichasTurno(horaEntrada, horaSalida, minutosEntrada, minutosSalida, tiempoFicha)
        txtCantidadFichas.Text = nroFichas.ToString()
    End Sub

    Private Sub reinicarControlesCalculoCantidadFichas()
        cmboxDuracionFicha.SelectedIndex = -1
        hintCmboxDuracionFicha.Visible = True
        txtCantidadFichas.Text = 0
        oRegMedico.oDuracionFichaSeleccionada = Nothing
    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub

    Private Sub reiniciarFomrulario()
        iniciarFormulario()
    End Sub





    'METODOS LOGICOS
    Private Sub cargarDatos()
        datosCargadosMedico = cargarDatosMedico() ' no hace nada ?
        datosCargadosTurno = cargarDatosTurno()
    End Sub

    Private Function cargarDatosMedico() As Boolean
        Try
            Return True
        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try

    End Function

    Private Function cargarDatosTurno() As Boolean
        Try
            horaEntrada = cmboxEntradaHora.SelectedItem.ToString() + ":" + cmboxEntradaMinutos.SelectedItem.ToString()
            horaSalida = cmboxSalidaHora.SelectedItem.ToString() + ":" + cmboxSalidaMinutos.SelectedItem.ToString()
            diasTurno = cargarDiasTurno()
            Return True

        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function cargarDiasTurno() As String
        oRegMedico.listaDiasTurno = New String(chListDias.CheckedIndices.Count - 1) {}

        Dim index As Int16 = 0
        For Each item As String In chListDias.CheckedItems
            oRegMedico.listaDiasTurno(index) = item
            index += 1
        Next

        Dim turnoNumeral As String = oRegMedico.convertirDiasTurno()
        Return turnoNumeral
    End Function

    Private Sub validarEntradas()
        mensajeValidarMedico = oRegMedico.validarEntradasMedico()

        mensajeValidarTurno = oRegMedico.validarEntradasTurno(horaEntrada, horaSalida)
    End Sub

    Private Sub guardarDatos(ByVal _tipomed)
        Try
            Dim respuesta As Int16 = 0
            Dim esexterno As Int16
            direccion = txbDireccion.Text.ToString().Trim()
            telefonos = txbTelefonos.Text.ToString().Trim()
            oRegMedico.guardarMedico(_tipomed, direccion, telefonos)
            oMedicoInsertado = oRegMedico.oMedicoInsertado

            If _tipomed = 1 Then
                esexterno = 1
            Else
                esexterno = 0
            End If
            respuesta = oRegMedico.guardarTurno(horaEntrada, horaSalida, diasTurno, tipoTurno, nroFichas, esexterno)
            If Not respuesta = 1 Then
                mostrarMensaje("Error. Hubo un problema al insertar los datos")
            Else
                mostrarMensaje("Los datos se ingresaron correctamente.")
                registroCompletado = True
                Me.Close()
            End If

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub





    'EVENTOS GRUPO 1
    Private Sub cmboxEspecialidad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxEspecialidad.SelectionChangeCommitted
        hintCboxEspecialidad.Visible = False
        Dim index As Int16 = 0

        Try
            index = cmboxEspecialidad.SelectedIndex
            oRegMedico.seleccionarEspecialidad(index)
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub





    'EVENTOS GRUPO RB 2
    Private Sub rButtonMañana_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonMañana.CheckedChanged
        tipoTurno = "M"
        oRegMedico.tipoTurno = tipoTurno

        poblarAmbosCmbHorasTurnoMaña()
        poblarAmbosCombMinutos()
    End Sub

    Private Sub rButtonTarde_CheckedChanged(sender As Object, e As EventArgs) Handles rButtonTarde.CheckedChanged
        tipoTurno = "T"
        oRegMedico.tipoTurno = tipoTurno

        poblarAmbosCombHorasTurnoTarde()
        poblarAmbosCombMinutos()
    End Sub





    'EVENTOS GRUPO COMBOS 2
    Private Sub cmboxEntradaHora_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxEntradaHora.SelectionChangeCommitted
        reinicarControlesCalculoCantidadFichas()
    End Sub

    Private Sub cmboxEntradaMinutos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxEntradaMinutos.SelectionChangeCommitted
        reinicarControlesCalculoCantidadFichas()
    End Sub

    Private Sub cmboxSalidaHora_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxSalidaHora.SelectionChangeCommitted
        reinicarControlesCalculoCantidadFichas()
    End Sub

    Private Sub cmboxSalidaMinutos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxSalidaMinutos.SelectionChangeCommitted
        reinicarControlesCalculoCantidadFichas()
    End Sub

    Private Sub cmboxDuracionFicha_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxDuracionFicha.SelectionChangeCommitted
        hintCmboxDuracionFicha.Visible = False
        Dim index As Int16 = 0

        Try
            index = cmboxDuracionFicha.SelectedIndex
            oRegMedico.seleccionarTiempoDuracionFicha(index)
            calcularNroFichasTurno()
        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub






    'EVENTOS GRUPO 3
    Private Sub btnGuardarDatos_Click(sender As Object, e As EventArgs) Handles btnGuardarDatos.Click
        cargarDatos()

        If datosCargadosMedico And datosCargadosTurno Then
            validarEntradas()

            If Not mensajeValidarMedico = "" Then
                mostrarMensaje(mensajeValidarMedico)

            Else
                If checkMedExtern.Checked = False Then
                    If Not mensajeValidarTurno = "" Then
                        mostrarMensaje(mensajeValidarTurno)
                    Else

                        guardarDatos(0)
                        MessageBox.Show("Medico interno Guardado")
                    End If
                Else
                    nroFichas = txbCantFicExt.Text.ToString().Trim()
                    guardarDatos(1)
                    MessageBox.Show("Médico Externo Guardado")
                End If


            End If

        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim dialogResult As DialogResult = MessageBox.Show("¿Desea cancelar el registro del medico?", "Cancelar registro", MessageBoxButtons.YesNo)

        If dialogResult = dialogResult.Yes Then
            registroCompletado = False
            Me.Close()
        End If

    End Sub

    Private Sub checkMedExtern_CheckedChanged(sender As Object, e As EventArgs) Handles checkMedExtern.CheckedChanged
        If checkMedExtern.Checked = True Then
            Label10.Visible = False
            hintCmboxDuracionFicha.Visible = False
            txtCantidadFichas.Visible = False
            cmboxDuracionFicha.Visible = False
            Label12.Visible = False
            LFD.Visible = True
            txbCantFicExt.Visible = True

            txbDireccion.Enabled = True
            txbDireccion.Text = ""

            txbTelefonos.Enabled = True
            txbTelefonos.Text=""

        Else
            txbDireccion.Enabled = False
            txbDireccion.Text = "C/ España Nº473"

            txbTelefonos.Enabled = False
            txbTelefonos.Text = "3364160"

            LFD.Visible = False
            Label10.Visible = True
            hintCmboxDuracionFicha.Visible = True
            cmboxDuracionFicha.Visible = True
            txtCantidadFichas.Visible = True
            Label12.Visible = True
            txbCantFicExt.Visible = False
        End If
    End Sub

End Class
