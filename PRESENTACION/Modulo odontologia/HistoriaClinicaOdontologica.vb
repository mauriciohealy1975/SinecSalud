Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class HistoriaClinicaOdontologica

    Dim aux As String

#Region "Auxiliares"
    Private matricula, codsolicitud, paciente, CI As String
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        matricula = ""
        codsolicitud = ""
        paciente = ""
        CI = ""
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
    Public Sub SetCI(_CI)
        CI = _CI
    End Sub
#End Region
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Fecha.Text = DateString
    End Sub

    Private Sub HistoriaClinicaOdontologica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub antecedentes_patologicos_familiares_TextChanged(sender As Object, e As EventArgs) Handles antecedentes_patologicos_familiares.TextChanged
        aux = sender.name
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(aux)
        ' Verificar(aux)
    End Sub

    Private Sub ninguno_CheckedChanged(sender As Object, e As EventArgs) Handles ninguno.CheckedChanged
        If ninguno.Checked = True Then
            anemia.Checked = False
            anemia.Enabled = False
            cardiotapias.Checked = False
            cardiotapias.Enabled = False
            enf_gastricas.Checked = False
            enf_gastricas.Enabled = False
            hepatitis.Checked = False
            hepatitis.Enabled = False
            tuberculosis.Checked = False
            tuberculosis.Enabled = False
            asma.Checked = False

            diabetes_mel.Checked = False
            epilepcia.Checked = False
            hipertencion.Checked = False
            vih.Checked = False


        End If
    End Sub


End Class
