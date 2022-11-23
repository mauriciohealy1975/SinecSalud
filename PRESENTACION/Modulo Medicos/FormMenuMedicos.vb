Imports NEGOCIO

Public Class FormMenuMedicos
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
    Private ReadOnly Objetoprestado As New FuncionesRayosX(False)
    Dim NivelAcceso = Usuario.tipoUsuUserLoggedSystem
#End Region
#Region "Funciones"
    Private Sub FormMenuMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarDatos()
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()

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
#Region "Botones"
    Private Sub btnTransfernciaMedica_Click(sender As Object, e As EventArgs) Handles btnTransfernciaMedica.Click
        Dim TM = New FormRegistrarTransferenciaMed
        TM.SetPaciente(paciente)
        TM.SetMatricula(matricula)
        TM.SetCodSolicitud(codsolicitud)
        TM.ShowDialog()
    End Sub
    Private Sub btnOrdenServiciosEnfemeria_Click(sender As Object, e As EventArgs) Handles btnOrdenServiciosEnfemeria.Click
        Dim SE = New FormRegistrarOrdenAtencionServiciosEnfermeria
        SE.SetPaciente(paciente)
        SE.SetMatricula(matricula)
        SE.SetCodSolicitud(codsolicitud)
        SE.ShowDialog()
    End Sub

    Private Sub BtnRayosX_Click(sender As Object, e As EventArgs) Handles BtnRayosX.Click

        Dim SRX = New FormSolicitudRayosX
        SRX.SetPaciente(paciente)
        SRX.SetMatricula(matricula)
        SRX.SetCodSolicitud(codsolicitud)
        SRX.ShowDialog()
        If SRX.GetCompleto() = "si" Then
            BtnRayosX.Enabled = False
        End If

    End Sub

    Private Sub BtnCD_Click(sender As Object, e As EventArgs) Handles BtnCD.Click
        Dim TM = New FormSolicitudExamenDiagnostico
        TM.SetPaciente(paciente)
        TM.SetMatricula(matricula)
        TM.SetCodSolicitud(codsolicitud)
        TM.ShowDialog()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub



    Private Sub BtnRecetas_Click(sender As Object, e As EventArgs) Handles BtnRecetas.Click
        Dim TM = New FormRecetas
        TM.SetPaciente(paciente)
        TM.SetMatricula(matricula)
        TM.SetCodSolicitud(codsolicitud)
        TM.ShowDialog()
        If TM.Getterminado() = "si" Then
            BtnRecetas.Enabled = False
        End If

    End Sub
#End Region
End Class