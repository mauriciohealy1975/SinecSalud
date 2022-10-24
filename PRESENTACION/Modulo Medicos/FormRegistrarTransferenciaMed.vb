Imports NEGOCIO

Public Class FormRegistrarTransferenciaMed
    'RESOL 1280, 600

    Dim obRegistroTransMed As RegistroTransferenciaMedica = New RegistroTransferenciaMedica()
    Private Sub FormTransferenciaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarControles()
    End Sub





    '--METODOS CONFIG INICIAL INTERFAZ
    Private Sub iniciarControles()
        configurarDisplay()
        iniciarControlesGrupo1()
        iniciarControelsGrupo2()
        iniciarControlesGrupo3()
    End Sub

    Private Sub configurarDisplay()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub iniciarControlesGrupo1()
        txtBuscarNombrePaciente.Enabled = True
        txtBuscarNombrePaciente.Font = New Font("Microsoft Sans Serif", 9.5)
        txtBuscarNombrePaciente.Text = ""

        btnBuscarPaciente.Enabled = True
        btnBuscarPaciente.Font = New Font("Microsoft Sans Serif", 9.5)
        btnBuscarPaciente.Text = "Buscar"

        txtNombrePaciente.Enabled = False
        txtNombrePaciente.Visible = False
        txtNombrePaciente.Font = New Font("Microsoft Sans Serif", 9.5)
        txtNombrePaciente.Text = ""

        cmboxNombrePaciente.Enabled = False
        cmboxNombrePaciente.Visible = True
        cmboxNombrePaciente.Items.Clear()
        cmboxNombrePaciente.Font = New Font("Microsoft Sans Serif", 9.5)
        cmboxNombrePaciente.Text = ""
        cmboxNombrePaciente.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub iniciarControelsGrupo2()
        lblMedico.Enabled = True
        lblMedico.Font = New Font("Microsoft Sans Serif", 8)
        lblMedico.Text = Usuario.nameUserLoggedSystem


        lblEdad.Enabled = True
        lblEdad.Font = New Font("Microsoft Sans Serif", 9.5)
        lblEdad.Text = "Edad: "

        lblMatricula.Enabled = True
        lblMatricula.Font = New Font("Microsoft Sans Serif", 9.5)
        lblMatricula.Text = "Matricula: "
    End Sub

    Private Sub iniciarControlesGrupo3()
        lblFecha.Enabled = True
        lblFecha.Font = New Font("Microsoft Sans Serif", 9.5)
        lblFecha.Text = Utilitarios.obtenerFechaActual()

        cmboxEspecialidad.Enabled = False
        cmboxEspecialidad.Items.Clear()
        cmboxEspecialidad.Font = New Font("Microsoft Sans Serif", 9.5)
        cmboxEspecialidad.Text = ""
        cmboxEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList

        richBoxDiagnostico.Enabled = True
        richBoxDiagnostico.Font = New Font("Microsoft Sans Serif", 9.5)
        richBoxDiagnostico.Text = ""
    End Sub

    Private Sub reiniciarFomrmulario()
        Dim obRegistroTransMed As RegistroTransferenciaMedica = New RegistroTransferenciaMedica()
        iniciarControles()
    End Sub





    '--METODOS CONFIG INTERFAZ
    Private Sub poblarCmboxEsp(ByVal _edad As Int16)
        obRegistroTransMed.traerEspecialidades(_edad)

        For Each objEspecialidad As Especialidad In obRegistroTransMed.listaEspecialidades
            cmboxEspecialidad.Items.Add(objEspecialidad.getnombre)
        Next
    End Sub

    Private Sub reiniciarCmboxEspecialidad()
        cmboxEspecialidad.Items.Clear()
        cmboxEspecialidad.Text = ""
    End Sub

    Private Sub poblarCmboxPaciente()
        For Each asegurado As Asegurado In obRegistroTransMed.listaPacientes
            cmboxNombrePaciente.Items.Add(asegurado.getDescripcion())
        Next
    End Sub

    Private Sub reiniciarCmboxNombrePaciente()
        cmboxNombrePaciente.Items.Clear()
        cmboxNombrePaciente.Text = ""
    End Sub

    Private Sub escribirNombreTxtPaciente(ByVal _nombre As String)
        txtNombrePaciente.Text = _nombre
    End Sub

    Private Sub escribirInfoPaciente()
        lblMatricula.Text = "Matricula: " + obRegistroTransMed.oAsegurado.getMatricula()
        lblEdad.Text = "Edad: " + obRegistroTransMed.oAsegurado.getEdad().ToString()
    End Sub

    Private Sub ocultarCmboxNombrePaciente()
        cmboxNombrePaciente.Visible = False
    End Sub

    Private Sub habilitarCmboxNombrePaciente()
        cmboxNombrePaciente.Enabled = True
    End Sub

    Private Sub deshabilitarCmboxNombrePaciente()
        cmboxNombrePaciente.Enabled = False
    End Sub

    Private Sub habilitarTxtNombrePaciente()
        txtNombrePaciente.Enabled = True
    End Sub

    Private Sub deshabilitarTxtNombrePaciente()
        txtNombrePaciente.Enabled = False
    End Sub

    Private Sub mostrarTxtNombrePaciente()
        txtNombrePaciente.Visible = True
    End Sub

    Private Sub habilitarCmboxEspecialidad()
        cmboxEspecialidad.Enabled = True
    End Sub






    '--METODOS CLCIK

    Private Sub btnBuscarAsegurado_Click(sender As Object, e As EventArgs) Handles btnBuscarPaciente.Click
        habilitarCmboxNombrePaciente()
        reiniciarCmboxNombrePaciente()

        Dim nombrePaciente As String = txtBuscarNombrePaciente.Text
        obRegistroTransMed.traerPacientes(nombrePaciente)
        poblarCmboxPaciente()
    End Sub

    Private Sub cmboxNombrePaciente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxNombrePaciente.SelectionChangeCommitted
        If Not cmboxNombrePaciente.SelectedItem = Nothing Then
            Dim descripcion = cmboxNombrePaciente.SelectedItem.ToString()
            obRegistroTransMed.oAsegurado = obRegistroTransMed.buscarPaciente(descripcion)

            Dim paciente As String = obRegistroTransMed.oAsegurado.getNombres()
            Dim matricula As String = obRegistroTransMed.oAsegurado.getMatricula()
            Dim edad As Int16 = obRegistroTransMed.oAsegurado.getEdad()

            habilitarTxtNombrePaciente()
            mostrarTxtNombrePaciente()
            escribirNombreTxtPaciente(paciente)
            ocultarCmboxNombrePaciente()
            deshabilitarCmboxNombrePaciente()
            deshabilitarTxtNombrePaciente()
            escribirInfoPaciente()
            habilitarCmboxEspecialidad()
            poblarCmboxEsp(edad)
        End If

    End Sub

    Private Sub cmbEspecialidad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxEspecialidad.SelectionChangeCommitted
        If Not cmboxEspecialidad.SelectedItem = Nothing Then
            Dim especialidad = cmboxEspecialidad.SelectedItem.ToString()
            Dim codEspecialidad = obRegistroTransMed.buscarCodigoEspecialidad(especialidad)
            obRegistroTransMed.codigoEspecialidad = codEspecialidad
        End If

    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuMedicos.Show()
        Me.Close()

    End Sub



    Private Sub BtnGuardarTransferencia_Click(sender As Object, e As EventArgs) Handles BtnGuardarTransferencia.Click
        guardar()

    End Sub

    Private Sub guardar()
        Dim matriculaAsegurado As String = obRegistroTransMed.oAsegurado.getMatricula()
        Dim codigoUsuario As Int16 = Usuario.codUserLoggedSystem
        Dim codigoEspecialidad As Int16 = obRegistroTransMed.codigoEspecialidad
        Dim diagnostico As String = richBoxDiagnostico.Text
        Dim fecha As String = Utilitarios.obtenerFechaActual()

        Dim oTransMed As TransferenciaMedica = New TransferenciaMedica()
        oTransMed.setMatriculaAsegurado(matriculaAsegurado)
        oTransMed.setCodigoUsuario(codigoUsuario)
        oTransMed.setCodigoEspecialidad(codigoEspecialidad)
        oTransMed.setDiagnostico(diagnostico)
        oTransMed.setFecha(fecha)

        obRegistroTransMed.oTransferenciaMedica = oTransMed
        Dim respuesta As Int16 = obRegistroTransMed.guardarTransferenciaMedica()

        If respuesta = 1 Then
            MessageBox.Show("Los datos se guardaron correctamente")
            reiniciarFomrmulario()
        End If

    End Sub
End Class