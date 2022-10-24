Imports NEGOCIO

Public Class FormCristalReportFicha

    Public fecha As String
    Public hora As String
    Public Paciente As String
    Public Medico As String
    Public Especialidad As String
    Public Direccion As String
    Public Telefonos As String

    Private Sub FormCristalReportFicha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfiguracionVentana()
        CargarDatosFicha()

    End Sub

    Private Sub CargarDatosFicha()

        Try
            Dim objReporte As CRFichaReport = New CRFichaReport

            objReporte.SetParameterValue("Fecha", fecha)
            objReporte.SetParameterValue("hora", hora)
            objReporte.SetParameterValue("Paciente", Paciente)
            objReporte.SetParameterValue("Medico", Medico)
            objReporte.SetParameterValue("Especialidad", Especialidad)
            objReporte.SetParameterValue("Usuario", Usuario.nameUserLoggedSystem)
            objReporte.SetParameterValue("FechaImpresion", DateTime.Now.ToShortDateString())
            objReporte.SetParameterValue("HoraImpresion", DateTime.Now.ToString("t"))
            objReporte.SetParameterValue("Direccion", Direccion)
            objReporte.SetParameterValue("Telefonos", Telefonos)
            CrystalReportViewer1.ReportSource = objReporte


        Catch ex As Exception

        End Try

    End Sub
    Private Sub ConfiguracionVentana()
        Icon = New System.Drawing.Icon("icono.ico")
    End Sub
End Class