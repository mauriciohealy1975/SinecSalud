Imports System.Web.UI.WebControls
Imports NEGOCIO

Public Class FormRegMedDiagnostico
#Region "Declaraciones"
    Private ReadOnly ObjRegistro As New FuncAgregarCD(False)

    Private Creado As Boolean
    Dim TERMINADO As Boolean
    Dim diasdeTrabajo, horario, DOM As String
    Dim diasregistrados As Int16

    Dim px, py As Integer
    Dim mover As Boolean

#End Region
    Private Sub FormRegMedDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
#Region "funciones"
    Private Sub Inicializar()
        Icon = New System.Drawing.Icon("icono.ico")
        CbxHS.Visible = False
        CbxMS.Visible = False
        CheckDiaria.Checked = True
        CbxMedico.Enabled = False
        CargarHorariosEntrada()
        CargarcbxeEcografias()
        CargarcbxeProcedimientos()
        TERMINADO = True
        DOM = "SN"

    End Sub
    Private Sub CargarHorariosEntrada()
        CbxHE.Items.Clear() ' limpiamos y comenzamos
        CbxME.Items.Clear()

        CbxHE.Items.Add("Hr")
        Dim i As Integer = 0
        For i = 7 To 18 Step 1
            If Len(i.ToString()) = 1 Then
                CbxHE.Items.Add("0" + i.ToString())
            Else
                CbxHE.Items.Add(i.ToString())
            End If
        Next
        CbxME.Items.Add("Min")
        CbxME.Items.Add("00")
        CbxME.Items.Add("15")
        CbxME.Items.Add("30")
        CbxME.Items.Add("45")

        CbxHE.SelectedIndex = 0
        CbxHE.DropDownStyle = ComboBoxStyle.DropDownList

        CbxME.SelectedIndex = 0
        CbxME.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub CargarHoraioSalida()
        CbxHS.Items.Clear() ' limpiamos y comenzamos
        CbxMS.Items.Clear()
        Dim x As Integer
        Dim hrI = CbxHE.Text.ToString()

        CbxHS.Items.Add("Hr ")
        If CbxME.Text.ToString() = "45" Then
            hrI += 1
        End If
        For x = hrI To 23 Step 1
            If Len(x.ToString()) = 1 Then
                CbxHS.Items.Add("0" + x.ToString())
            Else
                CbxHS.Items.Add(x.ToString())
            End If
        Next
        CbxHS.SelectedIndex = 0
        CbxHS.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub CargarMinSalida()
        CbxMS.Items.Clear()
        Dim HrI = CbxHE.Text.ToString()
        Dim HrS = CbxHS.Text.ToString()
        Dim minI = CbxME.Text.ToString()
        Dim actual As Int16 = minI
        CbxMS.Items.Add("Min")
        If HrI = HrS Then
            While actual < 45
                actual += 15
                CbxMS.Items.Add(actual)
            End While
        Else
            CbxMS.Items.Add("00")
            CbxMS.Items.Add("15")
            CbxMS.Items.Add("30")
            CbxMS.Items.Add("45")
        End If
        CbxMS.SelectedIndex = 0
        CbxMS.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub ObtenerCadenaDeDias()

        diasdeTrabajo = ""
        If CheckLunes.Checked = True Then
            diasdeTrabajo = "2"
        End If
        If CheckMartes.Checked = True Then
            If diasdeTrabajo = "" Then
                diasdeTrabajo = "3"
            Else
                diasdeTrabajo += ",3"
            End If
        End If
        If CheckMiercoles.Checked = True Then
            If diasdeTrabajo = "" Then
                diasdeTrabajo = "4"
            Else
                diasdeTrabajo += ",4"
            End If
        End If
        If CheckJueves.Checked = True Then
            If diasdeTrabajo = "" Then
                diasdeTrabajo = "5"
            Else
                diasdeTrabajo += ",5"
            End If
        End If
        If CheckViernes.Checked = True Then
            If diasdeTrabajo = "" Then
                diasdeTrabajo = "6"
            Else
                diasdeTrabajo += ",6"
            End If
        End If
    End Sub
    Private Sub ObtenerHorarioTrabajo()
        Dim Hre, Hrs, MinE, MinS As String
        horario = ""
        If CbxHE.SelectedIndex > 0 And CbxME.SelectedIndex > 0 And CbxHS.SelectedIndex > 0 And CbxMS.SelectedIndex > 0 Then
            Hre = CbxHE.Text.ToString()
            Hrs = CbxHS.Text.ToString()
            MinE = CbxME.Text.ToString()
            MinS = CbxMS.Text.ToString()
            horario = Hre + " : " + MinE + " A " + Hrs + " : " + MinS
        End If
    End Sub
    Private Sub CargarcbxeEcografias()
        Dim POE = TxbBuscarEco.Text.ToString().Trim()
        Dim tabla = ObjRegistro.ObtenerPOE(POE, 0)
        CbxEcografias.DataSource = tabla
        CbxEcografias.DisplayMember = "POE"
        CbxEcografias.ValueMember = "ID"
    End Sub
    Private Sub CargarcbxeProcedimientos()
        Dim POE = TxbBuscarproc.Text.ToString().Trim()
        Dim tabla = ObjRegistro.ObtenerPOE(POE, 1)
        CbxProcedimientos.DataSource = tabla
        CbxProcedimientos.DisplayMember = "POE"
        CbxProcedimientos.ValueMember = "ID"
    End Sub
    Private Sub CargarcbxMedicos()
        Try
            TERMINADO = False
            Dim Nombre = TxbBuscarMedico.Text.ToString().Trim()
            Dim tabla = ObjRegistro.ObtenerMédicos(Nombre)
            CbxMedico.DataSource = tabla
            CbxMedico.DisplayMember = "Medico"
            CbxMedico.ValueMember = "CodTusu"
            If CbxMedico.Items.Count < 1 Then
                'CbxMedico.Items.Clear()
                CbxMedico.DropDownStyle = ComboBoxStyle.DropDown
                CbxMedico.Text = "No hay coincidencias"
                TERMINADO = False
            Else
                TERMINADO = True
                CbxMedico.DropDownStyle = ComboBoxStyle.DropDownList
            End If
            CbxMedico.Enabled = True
            TERMINADO = True
        Catch ex As Exception
            CbxMedico.Enabled = False
        End Try

    End Sub
    Private Sub CargarDGVasignados()

        Try
            Dim usuario = CbxMedico.SelectedValue.ToString()
            Dim TABLA = ObjRegistro.ObtenerAsignados(usuario)
            If TABLA.rows.count > 0 Then
                DgvAsignados.DataSource = TABLA
                LSA.Visible = False
            Else
                DgvAsignados.DataSource = Nothing
                DgvAsignados.Rows.Clear()
                DgvAsignados.Columns.Clear()

                LSA.Visible = True
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Function ExisteDatoEnGrid(id As Long) As Boolean
        Dim existe As Boolean = DgvPOE.Rows.Cast(Of DataGridViewRow).Any(Function(x) CInt(x.Cells("ID").Value) = id)

        If existe Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CargarEcoCarritoDgvRX()
        Try
            Dim IDPOE, NombrePOE
            IDPOE = CbxEcografias.SelectedValue.ToString()
            NombrePOE = CbxEcografias.Text.ToString()
            If Creado = False Then
                DgvPOE.ColumnCount = 2
                DgvPOE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                DgvPOE.Columns(0).Name = "ID"
                DgvPOE.Columns(0).FillWeight = 9
                DgvPOE.Columns(0).ReadOnly = True

                DgvPOE.Columns(1).Name = "Nombre"
                DgvPOE.Columns(1).FillWeight = 90
                DgvPOE.Columns(1).ReadOnly = True
                Creado = True
            End If
            If (Not ExisteDatoEnGrid(IDPOE)) Then
                Dim row As String() = New String() {IDPOE, NombrePOE}
                DgvPOE.Rows.Add(row)
                Return True
            Else
                MessageBox.Show("Ya se encuentra registrado")
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function CargarProcCarritoDgvRX()
        Try
            Dim IDPOE, NombrePOE
            IDPOE = CbxProcedimientos.SelectedValue.ToString()
            NombrePOE = CbxProcedimientos.Text.ToString()
            If Creado = False Then
                DgvPOE.ColumnCount = 2
                DgvPOE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                DgvPOE.Columns(0).Name = "ID"
                DgvPOE.Columns(0).FillWeight = 9
                DgvPOE.Columns(0).ReadOnly = True

                DgvPOE.Columns(1).Name = "Nombre"
                DgvPOE.Columns(1).FillWeight = 90
                DgvPOE.Columns(1).ReadOnly = True
                Creado = True
            End If
            If (Not ExisteDatoEnGrid(IDPOE)) Then
                Dim row As String() = New String() {IDPOE, NombrePOE}
                DgvPOE.Rows.Add(row)
                Return True
            Else
                MessageBox.Show("Ya se encuentra registrado")
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub EliminarFilaDGVPOE()
        Try
            Dim NumDeFilaSeleccionada As DataGridViewRow = DgvPOE.CurrentRow
            DgvPOE.Rows.Remove(DgvPOE.Rows(NumDeFilaSeleccionada.Index))
        Catch ex As Exception

        End Try

    End Sub

    ' Private Function ContarCheckBoxsActivados() ' esto solo funciona si los combobox estan fuera del panel puede que me sirva mas adelante 
    '     Dim contador As Integer = 0
    '     For Each control As Control In Me.Controls
    '         If TypeOf control Is CheckBox Then
    '             If TryCast(control, CheckBox).Checked = True Then
    '                 contador += 1
    '             End If
    '         End If
    '     Next
    '     Return contador
    ' End Function 'por el momento esta funcion no se ocupa luego veo si la elimino

    Private Function ValidarFormulario()
        If Not diasdeTrabajo = "" Then
            If Not horario = "" Then
                If Not Convert.ToInt16(TxbCantidad.Text) = 0 Then
                    If Not DOM = "SN" Then
                        If Not DgvPOE.Rows.Count < 1 Then
                            Return True
                        Else
                            Return False
                            MessageBox.Show("Error, No asignó procedimientos ni ecografías.")
                        End If
                    Else
                        MessageBox.Show("Error, No asignó procedimientos ni ecografías.")
                        Return False
                    End If
                Else
                    MessageBox.Show("Error, Asignar cantidad de  días de trabajo.")
                    Return False
                End If
            Else
                MessageBox.Show("Error, No completo el horario")
                Return False
            End If

        Else
            MessageBox.Show("Error, Seleccione dias de trabajo.")
            Return False
        End If
    End Function

    Private Function RegistrarNuevoMCD()
        ObtenerCadenaDeDias()
        ObtenerHorarioTrabajo()
        If ValidarFormulario() Then
            Dim Dias, Hora, CantFicha, cmcd, DiaOMes
            Dim resultado1, resultado2 As Int16
            cmcd = CbxMedico.SelectedValue.ToString()
            Dias = diasdeTrabajo
            Hora = horario
            CantFicha = TxbCantidad.Text.ToString().Trim()
            DiaOMes = DOM
            resultado1 = ObjRegistro.REgistrarMCD(cmcd, Hora, Dias, CantFicha, DiaOMes)
            Dim ID
            If resultado1 = 1 Then
                For X As Integer = 0 To DgvPOE.Rows.Count - 2
                    ID = Convert.ToString(DgvPOE.Rows(X).Cells("ID").Value)
                    resultado2 = ObjRegistro.InsertarPOes(ID, cmcd)
                Next
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub OtroRegistro()
        DgvPOE.Rows.Clear()
        DOM = "SN"
        CheckDiaria.Checked = False
        CheckMensual.Checked = False

        ChecklunesAviernes.Enabled = True
        CheckLunes.Enabled = True
        CheckMartes.Enabled = True
        CheckMiercoles.Enabled = True
        CheckJueves.Enabled = True
        CheckViernes.Enabled = True

        ChecklunesAviernes.Checked = False
        CheckLunes.Checked = False
        CheckMartes.Checked = False
        CheckMiercoles.Checked = False
        CheckJueves.Checked = False
        CheckViernes.Checked = False
        CbxHE.SelectedIndex = 0
        TxbCantidad.Text = 0
        diasdeTrabajo = ""
        horario = ""
    End Sub
    Private Sub VerificarDiasOcupados()
        If DgvAsignados.Rows.Count > 0 Then
            ChecklunesAviernes.Checked = False
            ChecklunesAviernes.Enabled = False
            For X As Integer = 0 To DgvAsignados.Rows.Count - 2
                Dim AOD = Convert.ToString(DgvAsignados.Rows(X).Cells(5).Value)
                If AOD = "Activo" Then
                    Dim dias = Convert.ToString(DgvAsignados.Rows(X).Cells(2).Value)
                    Dim arraydias() = Split(dias, ",")
                    Dim texto As String = ""
                    For Each valor In arraydias
                        texto += valor.ToString()
                        Select Case valor
                            Case 2

                                CheckLunes.Enabled = False
                            Case 3

                                CheckMartes.Enabled = False
                            Case 4

                                CheckMiercoles.Enabled = False
                            Case 5

                                CheckJueves.Enabled = False
                            Case 6

                                CheckViernes.Enabled = False
                        End Select

                    Next
                End If
            Next

        Else

            CheckLunes.Enabled = True
            CheckMartes.Enabled = True
            CheckMiercoles.Enabled = True
            CheckJueves.Enabled = True
            CheckViernes.Enabled = True
            ChecklunesAviernes.Enabled = True
        End If
    End Sub
#End Region
#Region "Eventos"
    Private Sub CbxMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxMedico.SelectedIndexChanged
        If CbxMedico.SelectedIndex > -1 Then
            If TERMINADO Then
                OtroRegistro()
                CargarDGVasignados()
                VerificarDiasOcupados()
            End If
        End If
    End Sub

    Private Sub CbxHE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxHE.SelectedIndexChanged
        If CbxHE.SelectedIndex > 0 Then
            CbxME.SelectedIndex = 0
            CbxME.Enabled = True
        Else
            CbxME.SelectedIndex = 0
            CbxME.Enabled = False
        End If
    End Sub
    Private Sub CbxME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxME.SelectedIndexChanged
        If CbxME.SelectedIndex > 0 Then
            CargarHoraioSalida()
            CbxHS.Enabled = True
            CbxHS.Visible = True
            CbxMS.Visible = True
        Else
            CbxHS.Visible = False
            CbxMS.Visible = False
            CbxHS.Enabled = False
        End If
    End Sub
    Private Sub CbxHS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxHS.SelectedIndexChanged

        CargarMinSalida()

    End Sub

    Private Sub ChecklunesAviernes_CheckedChanged(sender As Object, e As EventArgs) Handles ChecklunesAviernes.CheckedChanged
        If ChecklunesAviernes.Checked = True Then
            CheckLunes.Checked = True
            CheckMartes.Checked = True
            CheckMiercoles.Checked = True
            CheckJueves.Checked = True
            CheckViernes.Checked = True

            CheckLunes.Enabled = False
            CheckMartes.Enabled = False
            CheckMiercoles.Enabled = False
            CheckJueves.Enabled = False
            CheckViernes.Enabled = False

        Else

            CheckLunes.Enabled = True
            CheckMartes.Enabled = True
            CheckMiercoles.Enabled = True
            CheckJueves.Enabled = True
            CheckViernes.Enabled = True
        End If
    End Sub


    Private Sub TxbBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbBuscarproc.KeyDown
        If e.KeyCode = Keys.Enter Then
            CargarcbxeProcedimientos()
        End If
    End Sub
    Private Sub TxbBuscarEco_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbBuscarEco.KeyDown
        If e.KeyCode = Keys.Enter Then
            CargarcbxeEcografias()
        End If
    End Sub
    Private Sub TxbBuscarMedico_KeyDown(sender As Object, e As KeyEventArgs) Handles TxbBuscarMedico.KeyDown
        If e.KeyCode = Keys.Enter Then
            CargarcbxMedicos()
        End If
    End Sub

    Private Sub TxbCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If TxbCantidad.Text = "0" Then
            TxbCantidad.Text = ""
        End If
    End Sub
    Private Sub TxbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub


    Private Sub TxbCantidad_GotFocus(sender As Object, e As EventArgs) Handles TxbCantidad.GotFocus
        If TxbCantidad.Text = 0 Then
            TxbCantidad.Text = ""
        End If
    End Sub
    Private Sub TxbCantidad_LostFocus(sender As Object, e As EventArgs) Handles TxbCantidad.LostFocus
        If TxbCantidad.Text = "" Or Not IsNumeric(TxbCantidad.Text) Then
            TxbCantidad.Text = 0
        End If
    End Sub


    Private Sub DgvPOE_DoubleClick(sender As Object, e As EventArgs) Handles DgvPOE.DoubleClick
        EliminarFilaDGVPOE()
    End Sub


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

    Private Sub CheckMensual_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMensual.CheckedChanged
        If CheckMensual.Checked = True Then
            CheckDiaria.Checked = False
            DOM = "M"
        End If
    End Sub



    Private Sub CheckDiaria_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDiaria.CheckedChanged
        If CheckDiaria.Checked = True Then
            CheckMensual.Checked = False
            DOM = "D"
        End If
    End Sub

#End Region
#Region "Botones"
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub BtnAgregarEco_Click(sender As Object, e As EventArgs) Handles BtnAgregarEco.Click
        Try
            If CbxEcografias.SelectedIndex > -1 Then
                CargarEcoCarritoDgvRX()
                TxbBuscarEco.Text = ""
                CbxEcografias.SelectedIndex += 1
            Else
                MessageBox.Show("seleccione una Ecografia")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAgegar_Click(sender As Object, e As EventArgs) Handles BtnAgegarProced.Click
        Try
            If CbxProcedimientos.SelectedIndex > -1 Then
                CargarProcCarritoDgvRX()
                TxbBuscarproc.Text = ""
                CbxProcedimientos.SelectedIndex += 1
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        If RegistrarNuevoMCD() Then
            If MsgBox("Registro agregado correctamente.¿Desea realizar otro registro?", 4, "Alerta") = 6 Then
                OtroRegistro()
            Else
                MessageBox.Show("registro Realizado")
                Close()
                FormMenuControlDeUsuario.Show()
            End If
        Else
            MessageBox.Show("ERROR AL REGISTRAR:" + Err.Description)
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuControlDeUsuario.Show()
        Close()
    End Sub
    Private Sub BtnAgregarNuevoPoe_Click(sender As Object, e As EventArgs) Handles BtnAgregarNuevoPoe.Click
        Dim NewPOE = New FormNewPOE
        NewPOE.ShowDialog()
        CargarcbxeEcografias()
        CargarcbxeProcedimientos()
    End Sub

#End Region
End Class