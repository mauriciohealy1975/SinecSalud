Imports NEGOCIO

Public Class FormDatosconsulta
#Region "auxiliares"
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
    Private ReadOnly Objetoprestado As New FuncionesRayosX(False)
    Private ReadOnly ObjRegistro As New FuncionesMedicas(False)
    Dim px, py As Integer
    Dim mover As Boolean
#End Region
#Region "Funciones"

    Private Sub FormDatosconsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub Inicializar()
        ConfiguracionVentana()
        RellenarDatosPaciente()
    End Sub
    Private Sub ConfiguracionVentana()
        Icon = New System.Drawing.Icon("icono.ico")
    End Sub
    Private Sub RellenarDatosPaciente()
        LNP.Text = "PACIENTE: " + paciente
        LMP.Text = "MATRICULA: " + matricula

        Dim edadenmeses = Objetoprestado.ObtenerEdad(matricula)
        If edadenmeses < 12 Then
            LEP.Text = " Edad: " + edadenmeses.ToString() + " meses"

        Else
            LEP.Text = "Edad: " + (edadenmeses / 12).ToString + " años"

        End If

    End Sub
#End Region
#Region "Eventos"
    Private Sub PictureBarra_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBarra.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub
    Private Sub PictureBarra_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBarra.MouseUp
        mover = False
    End Sub

    Private Sub PictureBarra_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBarra.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Location.X - px, MousePosition.Y - Location.Y - py))
        End If
    End Sub
#End Region
#Region "Botones"
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        FormPacientesEsperaMedica.Show()
        Close()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormPacientesEsperaMedica.Show()
        Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim MM = New FormMenuMedicos
        MM.SetPaciente(paciente)
        MM.SetMatricula(matricula)
        MM.SetCodSolicitud(codsolicitud)
        'GuardarHistorial() 'aqui estara  la funcion de guardar formulario
        Hide()
        MM.ShowDialog()
        FormPacientesEsperaMedica.Show()
        Close()
    End Sub

#End Region
End Class