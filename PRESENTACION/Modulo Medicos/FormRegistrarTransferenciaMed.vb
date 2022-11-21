Imports NEGOCIO

Public Class FormRegistrarTransferenciaMed
    'RESOL 1280, 600
#Region "axuliares"
    Private matricula, codsolicitud, paciente As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        matricula = ""
        codsolicitud = ""
        paciente = ""
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub SetMatricula(_Mat)
        matricula = _Mat
    End Sub
    Public Sub SetCodSolicitud(_sol)
        codsolicitud = _sol
    End Sub
    Public Sub SetPaciente(_paciente)
        paciente = _paciente
    End Sub
#End Region
#Region "Declaraciones"
    Dim obRegistroTransMed As RegistroTransferenciaMedica = New RegistroTransferenciaMedica()
    Private ReadOnly Objetoprestado As New FuncionesRayosX(False)
    Dim edad
#End Region
#Region "Funciones"
    Private Sub FormTransferenciaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarControles()
        RellenarDatosPaciente()
        poblarCmboxEsp(edad)
    End Sub

    Private Sub iniciarControles()
        configurarDisplay()
        iniciarControlesGrupo3()
    End Sub
    Private Sub RellenarDatosPaciente()
        LNP.Text = "PACIENTE: " + paciente
        LMP.Text = "MATRICULA: " + matricula

        Dim edadenmeses = Objetoprestado.ObtenerEdad(matricula)
        If edadenmeses < 12 Then
            LEP.Text = " Edad: " + edadenmeses.ToString() + " meses"
            edad = 0
        Else
            LEP.Text = "Edad: " + (edadenmeses / 12).ToString + " años"
            edad = edadenmeses / 12

        End If

    End Sub
    Private Sub configurarDisplay()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub iniciarControlesGrupo3()
        lblFecha.Enabled = True
        lblFecha.Font = New Font("Microsoft Sans Serif", 9.5)
        lblFecha.Text = Utilitarios.obtenerFechaActual()

        cmboxEspecialidad.Enabled = True
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
    Private Sub habilitarCmboxEspecialidad()
        cmboxEspecialidad.Enabled = True
    End Sub
    Private Sub guardar()
        Dim matriculaAsegurado As String = LMP.Text.ToString()
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
            Close()
        End If

    End Sub

#End Region
#Region "Eventos"
    Private Sub cmbEspecialidad_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxEspecialidad.SelectionChangeCommitted
        If Not cmboxEspecialidad.SelectedItem = Nothing Then
            Dim especialidad = cmboxEspecialidad.SelectedItem.ToString()
            Dim codEspecialidad = obRegistroTransMed.buscarCodigoEspecialidad(especialidad)
            obRegistroTransMed.codigoEspecialidad = codEspecialidad
        End If

    End Sub

#End Region

#Region "Botones"
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuMedicos.Show()
        Me.Close()
    End Sub
    Private Sub BtnGuardarTransferencia_Click(sender As Object, e As EventArgs) Handles BtnGuardarTransferencia.Click
        guardar()
    End Sub


#End Region
End Class