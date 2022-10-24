Imports NEGOCIO

Public Class FormSolicitudRayosX
#Region "Declaraciones"
    Private objetoRayosX As NEGOCIO.FuncionesRayosX = New NEGOCIO.FuncionesRayosX(False)
#End Region
#Region "Principal"
    Private Sub FormSolicitudRayosX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub Inicializar()
        ConfiguracionVentana()
        RellenarDatos()
        RellenarCbTipoRadiografia()
        TraerPacientes()
        CbxPaciente.SelectedIndex = -1
    End Sub
    Private Sub ConfiguracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
#End Region
#Region "Funciones"
    Private Function TraerPacientes()
        Try
            Dim Nombre As String = TxbBuscarPaciente.Text.ToString().Trim()
            Dim Tabla As DataTable
            If Not CheckBCP.Checked = True Then
                Tabla = objetoRayosX.BuscarPaciente(Nombre)
            Else
                Tabla = objetoRayosX.BuscarPacienteporCodigo(Nombre)
            End If

            CbxPaciente.DataSource = Tabla
            CbxPaciente.DisplayMember = "ASEGURADO"
            CbxPaciente.ValueMember = "MATRICULA"
            LNP.Text = "Paciente:" + CbxPaciente.Text.ToString()
            LCP.Text = "Codigo:" + CbxPaciente.SelectedValue.ToString()
            Return True
        Catch ex As Exception
            LNP.Text = "Paciente:"
            LCP.Text = "Codigo:"
            'MessageBox.Show(Err.Description)
            Return False
        End Try
    End Function

    Private Sub TxbBuscarPaciente_TextChaenged(sender As Object, e As EventArgs) Handles TxbBuscarPaciente.TextChanged
        TraerPacientes()
        If Len(TxbBuscarPaciente.Text) < 1 Then
            CbxPaciente.SelectedIndex = -1
            LNP.Text = "Paciente:"
            LCP.Text = "Codigo:"
        End If
    End Sub

    Private Function CargarCarritoDgvRX()
        Try
            Dim Tamaños As String = ""
            If CheckTamano1.Checked = True Then
                Tamaños = Tamaños + CheckTamano1.Text.ToString().Trim()
            End If
            If checkTamano2.Checked = True Then
                If Len(Tamaños.ToString().Trim()) = 0 Then
                    Tamaños = Tamaños + checkTamano2.Text.ToString().Trim()
                Else
                    Tamaños = Tamaños + ":" + checkTamano2.Text.ToString().Trim()
                End If
            End If
            If checktamano3.Checked = True Then
                If Len(Tamaños.ToString().Trim()) = 0 Then
                    Tamaños = Tamaños + checktamano3.Text.ToString().Trim()
                Else
                    Tamaños = Tamaños + ":" + checktamano3.Text.ToString().Trim()
                End If
            End If
            If CbxPaciente.SelectedIndex > 0 Then

            End If
            MessageBox.Show(Tamaños.ToString())
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    '----------------------------------------------------------------------------------------------------------------------
    Private Function RellenarCbTipoRadiografia()
        Try
            Dim Nombre As String = TxbBuscarTipoRadiografia.Text.ToString().Trim()
            Dim Tabla As DataTable
            Tabla = objetoRayosX.BuscarYTraerTiposDeRadiografia(Nombre)
            CbxRadiografias.DataSource = Tabla
            CbxRadiografias.DisplayMember = "DESCRIPCION"
            CbxRadiografias.ValueMember = "COD"
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "Botones"
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuPrincipal.Show()
        Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        CargarCarritoDgvRX()

    End Sub

    Private Sub TxbBuscarTipoRadiografia_TextChanged(sender As Object, e As EventArgs) Handles TxbBuscarTipoRadiografia.TextChanged
        RellenarCbTipoRadiografia()
    End Sub

    Private Sub CbxPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxPaciente.SelectedIndexChanged
        Try
            LNP.Text = "Paciente:" + CbxPaciente.Text.ToString()
            LCP.Text = "Codigo:" + CbxPaciente.SelectedValue.ToString()
        Catch ex As Exception
        End Try
    End Sub
#End Region

End Class