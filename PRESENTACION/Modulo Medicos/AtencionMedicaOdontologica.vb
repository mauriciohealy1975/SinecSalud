Public Class AtencionMedicaOdontologica
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

    Private Sub AtencionMedicaOdontologica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarDatos()
    End Sub

    Public Sub SetPaciente(_paciente)
        paciente = _paciente
    End Sub
#End Region

#Region "Funciones"
    Private Sub RellenarDatos()
        LabelMatricula.Text = matricula
        LabelNombre.Text = paciente
    End Sub
#End Region

End Class
