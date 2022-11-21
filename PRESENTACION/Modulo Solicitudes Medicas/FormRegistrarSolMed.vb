Imports System.ComponentModel
Imports System.Web.UI.WebControls
Imports CrystalDecisions.[Shared]
Imports Microsoft.Win32
Imports NEGOCIO

Public Class FormRegistrarSolMed
#Region "Declaraciones"
    Dim funcionregistro As RegistroSolMedica = New RegistroSolMedica
    Dim registro As RegistroSolMedica

    Dim trajoalgo As String

    Dim CantfichasExt As Int16 = 0
    Dim CantfichasExtocupadas As Int16 = 0
    Dim CantfichasExtdisponibles As Int16 = 0

    Dim codturnoexterno As Int16 = 0
    Dim esexterno As Boolean

    Dim codEspc As Int16 = 0
    Dim espcSeleccionada As String
    Dim intoext As Int16
    Dim codigomedicoglob As Int16

    Dim fechaSolicitud As Date

    Dim tipopacienteglob As String
    Dim nombrepaciente As String
    Dim matriculaGlob As String
    Dim edadglob As String

    Dim nuevopacienteseleccionado As Boolean
    Dim terminodebuscar As Boolean
#End Region


    '-- INICIO --


    Private Sub FormRegistrarSolMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            configurarGuardarButton()
            ConfigurarFormulario()

            configurarDisplay()
            CheckInterno.Checked = True

            CbxPacientes.Enabled = False
            CheckInterno.Checked = True
            Panel1.Enabled = False
            fechaSolicitud = Today
        Catch ex As Exception

        End Try
    End Sub

    Private Sub configurarDisplay()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ConfigurarFormulario()
        If CheckProgramacion.Checked = False Then

            DateTimeFecha.Value = Today
            Ltitulo.Text = "REGISTRO DE SOLICITUD DE ATENCIÓN MÉDICA"
            checkexterno.Visible = False
            checkexterno.Checked = False
            CheckInterno.Checked = True
        Else

            DateTimeFecha.Visible = True
            checkexterno.Visible = True
            checkexterno.Checked = True

            Ltitulo.Text = "PROGRAMACION DE SOLICITUD DE ATENCIÓN MÉDICA"
        End If

    End Sub




    '--ESPECIALIDADES
    Private Sub configurarCmboxEspc()
        cmbEspecialidad.Items.Clear()
        funcionregistro.traerEspecialidades(edadglob)

        For Each objEspecialidad As Especialidad In funcionregistro.listaEspecialidades
            cmbEspecialidad.Items.Add(objEspecialidad.getnombre)
        Next
        trajoalgo = ""
    End Sub



    Private Sub cmboxEspResetControls()
        cboxMedico.Items.Clear()
        cboxMedico.Text = "SELECCIONAR"

        cmbHora.Items.Clear()
        cmbHora.Text = "SELECCIONAR"

        cmbTipoConsulta.Items.Clear()
        cmbTipoConsulta.Text = "SELECCIONAR"
    End Sub



    '-- MEDICOS --
    Private Sub cmbEspecialidad_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbEspecialidad.SelectedValueChanged
        cboxMedico.Items.Clear()

    End Sub

    Private Sub poblarCboxMedico(esexterno)
        Try
            cboxMedico.Items.Clear()

            For Each medico As Medico In funcionregistro.medicos
                Dim usuario As Usuario, nombreCompleto As String

                usuario = medico.getUsuario()
                nombreCompleto = Trim(usuario.getApellidoPaterno()) + " " + Trim(usuario.getApellidoMaterno()) + " " + Trim(usuario.getNombres())
                nombreCompleto = Trim(nombreCompleto)

                cboxMedico.Items.Add(nombreCompleto)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMedico.SelectedIndexChanged
        Try
            cmboxMedResetControls()

            Dim medSeleccionado As String = cboxMedico.SelectedItem()
            funcionregistro.objMedico = funcionregistro.buscarMedico(medSeleccionado)
            codigomedicoglob = funcionregistro.objMedico.getCodigo
            trajoalgo = funcionregistro.traerTurnosDelMedico(codigomedicoglob, fechaSolicitud)
            If checkexterno.Checked = False Then
                funcionregistro.traerHorariosSolMed(codigomedicoglob, fechaSolicitud)
                funcionregistro.descartarHorariosSolMedOcup()
            End If
            configurarCmboxHorario(trajoalgo)
            configurarGuardarButton()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub cmboxMedResetControls()
        cmbHora.Items.Clear()
        cmbHora.Text = "SELECCIONAR"
        cmbTipoConsulta.Items.Clear()
    End Sub




    '-- HORARIOS
    Private Sub configurarCmboxHorario(ta As String)
        If ta = "" Then
            funcionregistro.listaHorarios = New String(funcionregistro.obtenerCantidadFiDelDia() - 1) {}

            For Each objTur As Turno In funcionregistro.listaTurnos

                For Each horario As String In objTur.listaHorarioFichas
                    If Not horario = Nothing Then
                        cmbHora.Items.Add(horario)
                    End If
                Next
            Next
        Else
            cmbHora.Items.Add(ta)
        End If


    End Sub

    Private Sub cmbHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHora.SelectedIndexChanged
        cmboxHoraResetControls()

        If checkexterno.Checked = False Then
            Dim horarioSeleccionado As String = cmbHora.SelectedItem()
            funcionregistro.objTurno = funcionregistro.buscarTurno(horarioSeleccionado)

            funcionregistro.setHorario(cmbHora.SelectedItem())
            configurarCmboxTConsul()
            configurarGuardarButton()
            cmbTipoConsulta.SelectedIndex = 0
        Else
            configurarCmboxTConsul()
            funcionregistro.setHorario(trajoalgo)
            cmbTipoConsulta.SelectedIndex = 0
            configurarGuardarButton()
        End If


    End Sub

    Private Sub cmboxHoraResetControls()
        cmbTipoConsulta.Items.Clear()
    End Sub




    '-- TIPO CONSULTA --
    Private Sub configurarCmboxTConsul()
        funcionregistro.traerTipoConsulta()

        For Each objConsulta As Concepto In funcionregistro.listaTipoConsultas
            cmbTipoConsulta.Items.Add(objConsulta.getDescripcion())
        Next
    End Sub

    Private Sub cmbTipoConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoConsulta.SelectedIndexChanged
        Dim nombreTipoCons As String = ""
        nombreTipoCons = cmbTipoConsulta.SelectedItem()
        funcionregistro.objTipoConsulta = funcionregistro.buscaTipoConsul(nombreTipoCons)
        ObtenerInformacionParaExterno(codigomedicoglob, fechaSolicitud)
        If CantfichasExtdisponibles > 0 Then
            configurarGuardarButton()
        End If

    End Sub


    '-- BOTON GUARDAR
    Private Sub configurarGuardarButton()
        btnGuardar.Enabled = False
        If cmbEspecialidad.SelectedIndex >= 0 And cboxMedico.SelectedIndex >= 0 And cmbHora.SelectedIndex >= 0 And cmbTipoConsulta.SelectedIndex >= 0 Then
            btnGuardar.Enabled = True
        End If
    End Sub


#Region "botones"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim matAsegurado As String = ""
        Dim codEspecialidad As Int16 = 0
        Dim Esprogra As Int16 = 0

        Dim horario As String = ""
        Dim prefConceptoTipoCons As Int16 = 0
        Dim correConceptoTipoCons As Int16 = 0
        Dim codigoTurno As Int16 = 0
        Dim codigoUsuario As Int16 = 0

        Dim codMedico As Int16 = 0
        Dim fecha As String = ""

        matAsegurado = matriculaGlob
        codEspecialidad = codEspc

        horario = funcionregistro.getHorario()
        prefConceptoTipoCons = funcionregistro.objTipoConsulta.getPrefijo()
        correConceptoTipoCons = funcionregistro.objTipoConsulta.getCorrelativo
        codMedico = funcionregistro.objMedico.getCodigo()
        fecha = fechaSolicitud
        If checkexterno.Checked = False Then
            codigoTurno = funcionregistro.objTurno.getCodigo()
        Else
            codigoTurno = codturnoexterno
        End If
        codigoUsuario = Usuario.codUserLoggedSystem
        If CheckProgramacion.Checked = True Then
            Esprogra = 1
        Else
            Esprogra = 0
        End If

        funcionregistro.guardarSolMedica(matAsegurado, codEspecialidad, codMedico, horario, prefConceptoTipoCons, correConceptoTipoCons, codigoTurno, codigoUsuario, fecha, Esprogra)
        If imprimir() = False Then
            MessageBox.Show("ocurrio un error al imprimir")
        End If
        MessageBox.Show("La solicitud medica se guardó correctamente")
        FromMenuTriaje.Show()
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FromMenuTriaje.Show()
        Me.Close()

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imprimir()
    End Sub

#End Region



#Region "Funciones"

    Private Sub rellnarComboboxes()

        Try

            cmboxEspResetControls()
            If checkexterno.Checked = True Then
                intoext = 1
            Else
                intoext = 0
            End If
            espcSeleccionada = cmbEspecialidad.SelectedItem()
            codEspc = funcionregistro.buscarCodEspc(espcSeleccionada)
            funcionregistro.objEspeciadlidad = New Especialidad(codEspc, espcSeleccionada)
            funcionregistro.traerMedicos(codEspc, intoext, fechaSolicitud)
            esexterno = checkexterno.CheckState
            poblarCboxMedico(esexterno)
            configurarGuardarButton()
            If cboxMedico.Items.Count > -1 Then
                cboxMedico.SelectedIndex = 0
            Else
                MessageBox.Show("No se encontro medicos para esta especialidad en esta fehca ")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BuscarPacientes()
        Dim nombre = TxbBuscarPaciente.Text.ToString().Trim()
        Dim tabla As DataTable = funcionregistro.buscarAsegurado(nombre)
        CbxPacientes.DataSource = tabla
        CbxPacientes.DisplayMember = "ASEGURADO"
        CbxPacientes.ValueMember = "MATRICULA"
        terminodebuscar = True
    End Sub

    Private Function obtenerEdadPaciente()
        Dim tabla As DataTable
        tabla = funcionregistro.traerEdadAsegBD(matriculaGlob)
        Dim row As DataRow

        If (tabla.Rows.Count > 0) Then
            row = tabla.Rows.Item(0)
            Dim edad = Convert.ToString(row("edad"))
            Return edad
        End If

    End Function
    Private Sub ObtenerInformacionParaExterno(_codmed, _fecha)
        Dim codMedico As Int16 = 0
        Dim fecha As String = ""
        codMedico = _codmed
        fecha = _fecha

        Dim tabla As DataTable = funcionregistro.traeridturnoparaexterno(codMedico)
        Dim fila As DataRow = Nothing
        If (tabla.Rows.Count > 0) Then
            fila = tabla.Rows.Item(0)
            codturnoexterno = Convert.ToString(fila("codTurno"))
            CantfichasExt = Convert.ToString(fila("CantFicha"))
        End If
        '----------------------------------------------------------------------------
        Dim tabocupada As DataTable = funcionregistro.TraerCantFichOcupada(codMedico, fecha)
        Dim focupada As DataRow = Nothing
        If (tabocupada.Rows.Count > 0) Then
            focupada = tabocupada.Rows.Item(0)
            CantfichasExtocupadas = Convert.ToString(focupada("CantOcupada"))
        End If
        '----------------------------
        CantfichasExtdisponibles = CantfichasExt - CantfichasExtocupadas
        LCantfich.Text = "Fichas Disponibles: " + CantfichasExtdisponibles.ToString()
    End Sub
    Private Function imprimir()
        Try
            Dim fec = Convert.ToDateTime(fechaSolicitud).ToLongDateString()
            Dim direcion, telefonos As String, tabla As DataTable
            tabla = funcionregistro.obtenerdirytel(codigomedicoglob)
            For Each row As DataRow In tabla.Rows
                direcion = row("Direccion").ToString()
                telefonos = row("telefonos").ToString()
            Next

            Dim f As New FormCristalReportFicha
            f.fecha = fec.ToString()
            f.hora = funcionregistro.getHorario()
            f.Paciente = lblAsegurado.Text
            f.Medico = cboxMedico.Text
            f.Especialidad = cmbEspecialidad.Text
            f.Direccion = direcion
            f.Telefonos = telefonos

            f.ShowDialog()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#Region "verificar derecho de ficha "
    Public Function revisarDerechoFicha() As Boolean
        Dim respuestaTiCheckTi As Boolean
        Dim respuestaTiCheckBe As Boolean
        Dim respuestaBeCheckTi As Boolean
        Dim respuestaBeCheckBe As Boolean

        respuestaTiCheckTi = False
        respuestaTiCheckBe = False
        respuestaBeCheckTi = False
        respuestaBeCheckBe = False
        If tipopacienteglob = "TITULAR" Then
            respuestaTiCheckTi = revisarTitularFTiular()
            respuestaTiCheckBe = revisarTitularFBeneficiario()

            If respuestaTiCheckTi And respuestaTiCheckBe Then
                Return True
            Else
                Return False
            End If

        Else

            respuestaTiCheckTi = revisarBeneficiarioFTitular()
            respuestaTiCheckBe = revisarBeneficiarioFBeneficiario()

            If respuestaTiCheckTi And respuestaTiCheckBe Then
                Return True
            Else
                Return False
            End If

        End If

    End Function
    Private Function revisarTitularFTiular() As Boolean

        Dim objDTable As DataTable
        Dim registros As Int16 = 0

        objDTable = funcionregistro.revisarTiFRepetidaTi(matriculaGlob, fechaSolicitud)

        For Each row As DataRow In objDTable.Rows
            registros = Integer.Parse(row("registros").ToString())
        Next

        If registros = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function revisarTitularFBeneficiario() As Boolean
        Dim objDTable As DataTable
        Dim registros As Int16 = 0

        objDTable = funcionregistro.revisarTiFRepetidaBe(matriculaGlob, fechaSolicitud)

        For Each row As DataRow In objDTable.Rows
            registros = Integer.Parse(row("registros").ToString())
        Next

        If registros = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function revisarBeneficiarioFTitular() As Boolean
        Dim objDTable As DataTable
        Dim registros As Int16 = 0
        Dim matriTit = funcionregistro.asignarMatriculaTitular(matriculaGlob)
        objDTable = funcionregistro.revisarBeFRepetidaTi(matriTit, fechaSolicitud)

        For Each row As DataRow In objDTable.Rows
            registros = Integer.Parse(row("registros").ToString())
        Next

        If registros = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function revisarBeneficiarioFBeneficiario() As Boolean
        Dim objDTable As DataTable
        Dim registros As Int16 = 0
        Dim matriTit = funcionregistro.asignarMatriculaTitular(matriculaGlob)
        objDTable = funcionregistro.revisarBeFRepetidaBe(matriTit, fechaSolicitud)

        For Each row As DataRow In objDTable.Rows
            registros = Integer.Parse(row("registros").ToString())
        Next

        If registros = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
#End Region

#Region "Eventos"
    'aqui iba elevento cambio de fecha

    '
    Private Sub TxbBuscarPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbBuscarPaciente.KeyDown
        If e.KeyCode = Keys.Enter Then
            terminodebuscar = False
            BuscarPacientes()
            CbxPacientes.SelectedIndex = -1
            If terminodebuscar Then
                CbxPacientes.Enabled = True
            End If


        End If
    End Sub


#Region "select"
    Private Sub cmbEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecialidad.SelectedIndexChanged
        rellnarComboboxes()
    End Sub
#End Region

#Region "change"
    Private Sub CbxPacientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxPacientes.SelectedIndexChanged
        Try

            Dim tabla As DataTable
            Dim row As DataRow
            tabla = funcionregistro.TraerPacientePormatricula(CbxPacientes.SelectedValue.ToString())

            If (tabla.Rows.Count > 0) Then
                row = tabla.Rows.Item(0)
                tipopacienteglob = Convert.ToString(row("TYPE"))
                nombrepaciente = Convert.ToString(row("ASEGURADO"))
                matriculaGlob = Convert.ToString(row("MATRICULA"))
                edadglob = obtenerEdadPaciente()
                lblMatricula.Text = matriculaGlob
                lblAsegurado.Text = nombrepaciente
                lblEdad.Text = edadglob
            End If
            If terminodebuscar Then
                nuevopacienteseleccionado = True
                If revisarDerechoFicha() Then
                    Panel1.Enabled = True
                Else
                    Panel1.Enabled = False
                    btnGuardar.Enabled = False
                    MessageBox.Show("El titular o el beneficiario ya tienen reservas para este dia seleccione otra fecha por favor ")
                End If
            End If

            'MessageBox.Show("Matricula: " + CbxPacientes.SelectedValue.ToString())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckProgramacion_CheckedChanged(sender As Object, e As EventArgs) Handles CheckProgramacion.CheckedChanged
        If CheckProgramacion.Checked = False Then
            DateTimeFecha.MinDate = Today
            DateTimeFecha.Value = Today
            DateTimeFecha.Enabled = False
            CheckInterno.Checked = True
        Else
            Dim fechainicio As New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            Dim fechafin As DateTime = fechainicio.AddMonths(1).AddDays(-1)
            DateTimeFecha.Enabled = True
            DateTimeFecha.MinDate = Today.AddDays(1)
            DateTimeFecha.MaxDate = fechafin

        End If
        ConfigurarFormulario()
    End Sub

    Private Sub cmbEspecialidad_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbEspecialidad.MouseClick
        If nuevopacienteseleccionado Then
            configurarCmboxEspc()
            nuevopacienteseleccionado = False
        End If
    End Sub

    Private Sub DateTimeFecha_CloseUp(sender As Object, e As EventArgs) Handles DateTimeFecha.CloseUp
        fechaSolicitud = DateTimeFecha.Value
        Dim i As Integer = DateTimeFecha.Value.DayOfWeek
        Dim continuar As Boolean = False
        '0 -> domingo / 6 -> sabado
        If i = 0 Or i = 6 Then
            While i = 0 Or i = 1
                continuar = False
            End While
            MessageBox.Show("No se puede programar una ficha en fin de semana. Selecione otra fecha.")
        Else
            continuar = True
        End If
        If continuar Then
            If CbxPacientes.SelectedIndex > -1 Then
                If revisarDerechoFicha() Then
                    Panel1.Enabled = True
                    If cmbEspecialidad.SelectedIndex > -1 Then
                        rellnarComboboxes()
                    End If

                Else
                    Panel1.Enabled = False
                    btnGuardar.Enabled = False
                    MessageBox.Show("El titular o el beneficiario ya tienen reservas para este dia seleccione otra fecha por favor ")
                End If
            End If
        End If


    End Sub

#End Region

#Region "checksboxs"
    Private Sub CheckInterno_CheckedChanged(sender As Object, e As EventArgs) Handles CheckInterno.CheckedChanged
        Try
            If CheckInterno.Checked = True Then
                checkexterno.Checked = False

                CheckInterno.ForeColor = Color.Green
                CheckInterno.Enabled = False
                checkexterno.Enabled = True

                esexterno = False
                '------------------------------------------------------------------------
                espcSeleccionada = cmbEspecialidad.SelectedItem()
                codEspc = registro.buscarCodEspc(espcSeleccionada)
                registro.objEspeciadlidad = New Especialidad(codEspc, espcSeleccionada)
                registro.traerMedicos(codEspc, intoext, fechaSolicitud)
                poblarCboxMedico(esexterno)
                cboxMedico.SelectedIndex = 0
                '-------------------------------------------------------------------------
            Else
                CheckInterno.ForeColor = Color.Black
                CheckInterno.Enabled = False

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub checkexterno_CheckedChanged(sender As Object, e As EventArgs) Handles checkexterno.CheckedChanged
        Try
            If checkexterno.Checked = True Then
                CheckInterno.Checked = False
                checkexterno.ForeColor = Color.Blue
                checkexterno.Enabled = False
                CheckInterno.Enabled = True
                esexterno = True
                intoext = 1

                '------------------------------------------------------------------------
                espcSeleccionada = cmbEspecialidad.SelectedItem()
                codEspc = registro.buscarCodEspc(espcSeleccionada)
                registro.objEspeciadlidad = New Especialidad(codEspc, espcSeleccionada)
                registro.traerMedicos(codEspc, intoext, fechaSolicitud)
                poblarCboxMedico(esexterno)
                cboxMedico.SelectedIndex = 0
                '-------------------------------------------------------------------------
            Else
                checkexterno.ForeColor = Color.Black
                checkexterno.Enabled = True
                intoext = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimeFecha_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeFecha.ValueChanged
        fechaSolicitud = DateTimeFecha.Value
    End Sub




#End Region

#End Region

End Class