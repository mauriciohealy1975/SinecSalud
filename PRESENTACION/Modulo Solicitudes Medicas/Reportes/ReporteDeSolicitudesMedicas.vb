Imports CrystalDecisions.Shared

Public Class ReporteDeSolicitudesMedicas
    Public nombre As String
    'Public medico As String
    Public desde As Date
    Public hasta As Date
    Public lugartrabajo As Int16
    Public db As Int16

#Region "Funciones"
#Region "prueba"
    'Private Sub configureCrystalReports()
    '    Try
    '        Dim online As Boolean = "true"
    '
    '        Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
    '        If online Then
    '            myConnectionInfo.ServerName = "190.181.23.234"
    '        Else
    '            myConnectionInfo.ServerName = "192.168.100.175"
    '        End If
    '
    '        myConnectionInfo.DatabaseName = "sinecsaluddemo"
    '        myConnectionInfo.UserID = "antlion"
    '        myConnectionInfo.Password = "@75542023aA@"
    '        myConnectionInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type 
    '        myConnectionInfo.IntegratedSecurity = False
    '        setDBLOGONforREPORT(myConnectionInfo)
    '    Catch ex As Exception
    '        Dim msg As String = ex.Message
    '    End Try
    'End Sub
    'Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)
    '    Dim mytableloginfos As New TableLogOnInfos()
    '    mytableloginfos = CrystalReportViewer1.LogOnInfo
    '    For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
    '        myTableLogOnInfo.ConnectionInfo = myconnectioninfo
    '    Next
    'End Sub
#End Region


    Private Sub ReporteDeSolicitudesMedicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConfiguracionVentana()
            Dim online As Boolean
            If db = 4 Then
                online = True
            Else
                online = False
            End If

            If online Then
                Dim objReporte As New CrisReportSolMedOnline
                objReporte.SetDatabaseLogon("antlion", "@75542023aA@", "190.181.23.234", "sinecsaluddemo") 'parametrizar usuario y contraceña para que no la solicite
                objReporte.SetParameterValue("@nombre", nombre)
                objReporte.SetParameterValue("@FechaDesde", desde)
                objReporte.SetParameterValue("@fechahasta", hasta)
                objReporte.SetParameterValue("@LugarTrabajo", lugartrabajo)

                CrystalReportViewer1.ReportSource = objReporte

            Else
                Dim objReporte As New CrisReportSolMedOffline
                objReporte.SetDatabaseLogon("antlion", "@75542023aA@", "192.168.100.175", "sinecsaluddemo") 'parametrizar usuario y contraceña para que no la solicite
                objReporte.SetParameterValue("@nombre", nombre)
                objReporte.SetParameterValue("@FechaDesde", desde)
                objReporte.SetParameterValue("@fechahasta", hasta)
                objReporte.SetParameterValue("@LugarTrabajo", lugartrabajo)

                CrystalReportViewer1.ReportSource = objReporte

            End If




            WindowState = FormWindowState.Maximized


            'MessageBox.Show(nombre)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ConfiguracionVentana()
        Icon = New System.Drawing.Icon("icono.ico")
    End Sub







#End Region
End Class