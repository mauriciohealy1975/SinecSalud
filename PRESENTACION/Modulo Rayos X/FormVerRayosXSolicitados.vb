Imports System.Xml
Imports NEGOCIO

Public Class FormVerRayosXSolicitados

#Region "Declaraciones"
    Private ReadOnly ObjetoRayosX As New FuncionesRayosX(False)
#End Region
#Region "Principales"
    Private Sub FormVerRayosXSolicitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LAnuncio.Visible = False
        TbxBuscar.Text = "Nombre del paciente"
        TbxBuscar.ForeColor = Color.Gray
        RellenarDatos()
        ConfiguracionVentana()
        RellenarDGV("", 4)

    End Sub
#End Region
#Region "Funciones"
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
        If Usuario.tipoUsuUserLoggedSystem = 1 Then
            BtnMenu.Visible = True
        Else
            BtnMenu.Visible = False

        End If
    End Sub
    Private Sub ConfiguracionVentana()
        Icon = New System.Drawing.Icon("icono.ico")
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RellenarDGV(_nombre, _Estado)
        LAnuncio.Visible = False

        Dim tabla As DataTable
        tabla = ObjetoRayosX.ObtenerSolicitudesdeRadiologia(_nombre, _Estado)
        If tabla.Rows.Count > 0 Then
            DgvSolicitudesRX.DataSource = tabla
            DgvSolicitudesRX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            DgvSolicitudesRX.Columns(0).FillWeight = 6 'id
            DgvSolicitudesRX.Columns(1).FillWeight = 12 'matricula
            DgvSolicitudesRX.Columns(2).FillWeight = 35 'paciente
            DgvSolicitudesRX.Columns(3).FillWeight = 35 'Medico
            DgvSolicitudesRX.Columns(4).FillWeight = 12 'fecha
            DgvSolicitudesRX.Columns(0).ReadOnly = True
            DgvSolicitudesRX.Columns(1).ReadOnly = True
            DgvSolicitudesRX.Columns(2).ReadOnly = True
            DgvSolicitudesRX.Columns(3).ReadOnly = True
            DgvSolicitudesRX.Columns(4).ReadOnly = True


        Else
            DgvSolicitudesRX.Columns.Clear()
            'DgvSolicitudesRX.Rows.Clear()

            LAnuncio.Visible = True
        End If

    End Sub

#End Region
#Region "Eventos"
    Private Sub TbxBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim nombre As String = TbxBuscar.Text.ToString().Trim()
            If nombre = "Nombre del paciente" Then
                RellenarDGV("", 4)
            Else
                RellenarDGV(nombre, 4)
            End If

        End If
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FormMenuPrincipal.Show()
        Close()

    End Sub

    Private Sub DgvSolicitudesRX_DoubleClick(sender As Object, e As EventArgs) Handles DgvSolicitudesRX.DoubleClick
        Try
            'doble clic para obtener la lista del menu
            Dim FilaSeleccionada As DataGridViewRow = DgvSolicitudesRX.CurrentRow
            Dim valor As Integer = Val(FilaSeleccionada.Index)
            If DgvSolicitudesRX.RowCount - 1 > 0 Then
                Dim id As String = Convert.ToDouble(DgvSolicitudesRX.Rows(valor).Cells("ID").Value)
                Dim rayosX = New FormDetalleRayosX
                rayosX.SetId(id)
                rayosX.ShowDialog()
                RellenarDGV("", 4)
            Else
                MessageBox.Show("vacio")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub


    Private Sub TbxBuscar_GotFocus(sender As Object, e As EventArgs) Handles TbxBuscar.GotFocus
        If TbxBuscar.Text = "Nombre del paciente" Then
            TbxBuscar.Text = ""
            TbxBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TbxBuscar_LostFocus(sender As Object, e As EventArgs) Handles TbxBuscar.LostFocus
        If TbxBuscar.Text = "" Then
            TbxBuscar.Text = "Nombre del paciente"
            TbxBuscar.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim nombre As String = TbxBuscar.Text.ToString().Trim()
        If nombre = "Nombre del paciente" Then
            RellenarDGV("", 4)
        Else
            RellenarDGV(nombre, 4)
        End If
    End Sub



#End Region
End Class