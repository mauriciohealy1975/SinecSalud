Imports NEGOCIO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormReporteDeSolicitudes

    Private objetoTriaje As NEGOCIO.FuncionesTriaje = New NEGOCIO.FuncionesTriaje(False)
    'Dim DB As Int16 = objetoTriaje.DB
    Private Sub checkDia_CheckedChanged(sender As Object, e As EventArgs) Handles checkDia.CheckedChanged
        If checkDia.Checked = True Then

            DtDesde.Value = Today
            DtDesde.MinDate = Today
            DtDesde.MaxDate = Today

            DtDesde.Value = Today
            DtHasta.Value = Today

            DtDesde.Enabled = False
            DtHasta.Enabled = False
            DtHasta.Visible = False
            hd.Text = "Del Dia"
            Lhasta.Visible = False

        Else
            DtHasta.Visible = True

            DtDesde.MinDate = "01/01/2000"
            DtDesde.MaxDate = Today

            DtDesde.Value = Today
            DtHasta.MinDate = "01/01/2000"
            DtHasta.MaxDate = DateAdd("m", 1, Today)

            DtHasta.Value = DateAdd("m", 1, Today)
            DtDesde.Enabled = True
            DtHasta.Enabled = True
            hd.Text = "Histórico"
            Lhasta.Visible = True
        End If
    End Sub

    Private Sub DtDesde_ValueChanged(sender As Object, e As EventArgs) Handles DtDesde.ValueChanged
        If checkDia.Checked = False Then
            DtHasta.Value = DateAdd("m", 1, Today)

        End If

    End Sub

    Private Sub FormReporteDeSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializacion()
    End Sub

    Private Sub inicializacion()
        DtDesde.Value = Today
        DtHasta.Value = Today

        RellenardgvConsultas()
        checkDia.Checked = True
    End Sub

#Region "funciones"
    Private Function RellenardgvConsultas()
        Try
            Dim Nombre As String = TxbBuscar.Text.ToString().Trim()
            Dim Desde As Date = DtDesde.Value
            Dim hasta As Date = DtHasta.Value
            Dim lugarTrabajo As Int16 = 0
            If CheckMedExterno.Checked = True Then
                lugarTrabajo = 1
            Else
                lugarTrabajo = 0
            End If
            Dim tabla As DataTable
            tabla = objetoTriaje.TraerConsultasDB(Nombre, Desde, hasta, lugarTrabajo)
            DgvTSolicitudes.DataSource = tabla
            Return True
        Catch ex As Exception
            MessageBox.Show("ocurrió un error:" + Err.Description)
            Return False
        End Try
    End Function
    Private Sub Imprimir()
        Dim f As New ReporteDeSolicitudesMedicas
        Dim _nombre = TxbBuscar.Text.ToString().Trim()
        Dim lugarTrabajo As Int16 = 0
        Dim _desde As Date = DtDesde.Value
        Dim _hasta As Date = DtHasta.Value

        f.nombre = _nombre + "%"
        f.desde = _desde
        f.hasta = _hasta
        f.lugartrabajo = lugarTrabajo
        f.db = 4 ' 3= reporte desde dentro del sinec, 4 reporte desde afuera
        f.ShowDialog()

    End Sub

#End Region
#Region "Botones"
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        RellenardgvConsultas()
    End Sub

    Private Sub BtnMenuTriaje_Click(sender As Object, e As EventArgs) Handles BtnMenuTriaje.Click
        FromMenuTriaje.Show()
        Close()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Imprimir()
    End Sub

#End Region
End Class