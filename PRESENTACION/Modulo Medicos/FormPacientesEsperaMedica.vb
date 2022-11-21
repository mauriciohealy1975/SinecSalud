Imports NEGOCIO

Public Class FormPacientesEsperaMedica

#Region "Declaraciones"
    Private ReadOnly Objeto As New FuncionesMedicas(False)
    Dim px, py As Integer
    Dim mover As Boolean
#End Region
#Region "Funciones"
    Private Sub FormPacientesEsperaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub Inicializar()
        ConfiguracionVentana()
        RellenarDatos()
        RellenarDGVPacientes()
        If Usuario.tipoUsuUserLoggedSystem = 1 Then
            BtnVolvermenuPrincipal.Visible = True
        Else
            BtnVolvermenuPrincipal.Visible = False
        End If
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub ConfiguracionVentana()
        Icon = New System.Drawing.Icon("icono.ico")
    End Sub

    Private Sub RellenarDGVPacientes()
        Dim tabla = Objeto.ObtenerListaPacientes(Usuario.codUserLoggedSystem, Today)
        If tabla.rows.count > 0 Then
            SP.Visible = False
            DgvPacientes.DataSource = tabla
            DgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            DgvPacientes.Columns("Horario").FillWeight = 10
            DgvPacientes.Columns("Fecha solicitada").FillWeight = 10
            DgvPacientes.Columns("Especialidad").FillWeight = 18
            DgvPacientes.Columns("Matricula").FillWeight = 12
            DgvPacientes.Columns("Paciente").FillWeight = 50

            DgvPacientes.Columns("CodUsuario").Visible = False
            DgvPacientes.Columns("CodMed").Visible = False
            DgvPacientes.Columns("CodSol").Visible = False
        Else
            DgvPacientes.DataSource = Nothing
            DgvPacientes.Columns.Clear()
            SP.Visible = True
        End If
    End Sub
    Private Sub RellenarDGVPacientesCD()
        'funcion para rellenar con pacientes de centro de diagnostico
    End Sub
    Private Sub DgvPacientes_DoubleClick(sender As Object, e As EventArgs) Handles DgvPacientes.DoubleClick
        Try
            'doble clic para obtener la lista del menu
            Dim FilaSeleccionada As DataGridViewRow = DgvPacientes.CurrentRow
            Dim valor As Integer = Val(FilaSeleccionada.Index)
            If DgvPacientes.RowCount - 1 > 0 Then
                Dim Paciente As String = Convert.ToString(DgvPacientes.Rows(valor).Cells("Paciente").Value)
                Dim Matricula As String = Convert.ToString(DgvPacientes.Rows(valor).Cells("Matricula").Value)
                Dim CodSol As String = Convert.ToString(DgvPacientes.Rows(valor).Cells("CodSol").Value)
                Dim esp As String = Convert.ToString(DgvPacientes.Rows(valor).Cells("Especialidad").Value)
                If esp = "ODONTOLOGIA" Or esp = "ODONTOLOGIA PEDRIATICA" Then
                    Dim FO = New FormDatosconsulta ' formulario historial(cambiar por el formulario de odontologia)
                    FO.SetPaciente(Paciente)
                    FO.SetMatricula(Matricula)
                    FO.SetCodSolicitud(CodSol)
                    FO.ShowDialog()
                    Close()
                Else
                    If CheckCentroDiag.Checked Then
                        'aqui va ir cuando exista una solicitud

                    Else
                        Dim FH = New FormDatosconsulta ' formulario historial
                        FH.SetPaciente(Paciente)
                        FH.SetMatricula(Matricula)
                        FH.SetCodSolicitud(CodSol)
                        FH.ShowDialog()

                    End If
                End If

            Else
                MessageBox.Show("vacio")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
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
        Close()
        FormIniciarSesion.Show()
        FormIniciarSesion.Close()
    End Sub

    Private Sub BtncerrarSesion_Click(sender As Object, e As EventArgs) Handles BtncerrarSesion.Click
        Me.Close()
        FormIniciarSesion.limpiarCampos()
        FormIniciarSesion.Show()
        FormIniciarSesion.txtUsuario.Focus()
        Usuario.limpiarDatos()
    End Sub




    Private Sub BtnVolvermenuPrincipal_Click(sender As Object, e As EventArgs) Handles BtnVolvermenuPrincipal.Click
        FormMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub CheckCentroDiag_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCentroDiag.CheckedChanged
        DgvPacientes.DataSource = Nothing
        DgvPacientes.Columns.Clear()
        If CheckCentroDiag.Checked Then
            RellenarDGVPacientesCD()
        Else
            RellenarDGVPacientes()
        End If
    End Sub

    Private Sub BtnBM_Click(sender As Object, e As EventArgs) Handles BtnBM.Click
        FormMenuBajasMedicas.Show()
        Me.Close()
    End Sub
#End Region
End Class