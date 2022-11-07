Imports System.Web.UI.WebControls
Imports NEGOCIO

Public Class FormSolicitudExamenDiagnostico
    Private Sub FormSolicitudExamenDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
#Region "Declaraciones"
    Private ReadOnly objetoRayosX As New FuncionesRayosX(False)
    Private ReadOnly ObjRegistro As New FuncAgregarCD(False)
    Dim px, py As Integer
    Dim mover, termino As Boolean
#End Region
#Region "Funciones"
    Private Sub Inicializar()
        ConfiguracionVentana()
        RellenarDatos()
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub ConfiguracionVentana()
        Icon = New System.Drawing.Icon("icono.ico")
    End Sub
    Private Sub RellenarDatosPaciente()
        Dim matricula = CbxPaciente.SelectedValue.ToString()
        Dim edadenmeses = objetoRayosX.ObtenerEdad(matricula)
        If edadenmeses < 12 Then
            LCP.Text = "Codigo:" + CbxPaciente.SelectedValue.ToString() + "       Edad: " + edadenmeses.ToString() + " meses"

        Else
            LCP.Text = "Codigo:" + CbxPaciente.SelectedValue.ToString() + "       Edad: " + (edadenmeses / 12).ToString + " años"

        End If
        LNP.Text = "Paciente:" + CbxPaciente.Text.ToString()
    End Sub
    Private Function TraerPacientes()
        Try

            LNP.Text = "Paciente:"
            LCP.Text = "Cod Paciente:"
            termino = False
            Dim Nombre As String = TxbBuscarPaciente.Text.ToString().Trim()
            Dim Tabla As DataTable
            If Not CheckBCP.Checked = True Then
                Tabla = objetoRayosX.BuscarPaciente(Nombre)
            Else
                Tabla = objetoRayosX.BuscarPacienteporCodigo(Nombre)
            End If

            If Tabla.Rows.Count < 1 Then
                Return False
            Else

                CbxPaciente.Enabled = True
                CbxPaciente.DataSource = Tabla
                CbxPaciente.DisplayMember = "ASEGURADO"
                CbxPaciente.ValueMember = "MATRICULA"

                Return True
            End If

        Catch ex As Exception
            LNP.Text = "Paciente:"
            LCP.Text = "Cod Paciente:"
            'MessageBox.Show(Err.Description)
            Return False
        End Try
    End Function
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

    Private Sub CbxPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxPaciente.SelectedIndexChanged
        RellenarDatosPaciente()
    End Sub

    Private Sub TxbBuscarPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbBuscarPaciente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (TraerPacientes()) Then
                termino = True
                CbxPaciente.SelectedIndex = 0
                RellenarDatosPaciente()
            Else
                LNP.Text = "Paciente:"
                LCP.Text = "Cod Paciente:"
            End If
        End If
    End Sub

#End Region
#Region "Botones"
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
#End Region
End Class