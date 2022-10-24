Imports System.Runtime.InteropServices.ComTypes
Imports System.Runtime.Remoting
Imports NEGOCIO

Public Class FormRecetas
#Region "Declaraciones"
    Dim condUsuari As String = Usuario.codUserLoggedSystem.ToString()
    Dim MedCargados As Int16 = 0
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)
    Dim tabla As DataTable
    Dim completo As Boolean
#End Region
#Region "Principal"
    Private Sub FormRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()

    End Sub

    Private Sub Inicializar()
        completo = False
        configuracionVentana()
        RellenarDatos()
        RellenarCbPaciente()
        PanelPaciente.Enabled = True
        PanelMedicamento.Enabled = False
        completo = True
    End Sub
#End Region
    '------------------------------------------------------FUNCIONES--------------------------------------------------------------------
#Region "Funciones"
    Private Sub ReiniciarFormulario()
        Inicializar()
        DgvListaReceta.Rows.Clear()
        TbIndicaciones.Text = ""
        txbBuscarMedcicamentos.Text = ""
        TxbBuscarAsegurado.Text = ""
        TxbCantidad.Text = 0
        If completo Then
            CbPaciente.SelectedIndex = -1
        End If
    End Sub
    Private Sub configuracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub
    Private Sub RellenarDatos()
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
        Dim proximo = ObtenerPoximoRegistro()
        If proximo > 1000000 Then
            proximo = proximo + 1
        Else
            proximo = "000000" + (proximo + 1).ToString
        End If
        LNR.Text = proximo
    End Sub
    Private Function RellenarCbPaciente()
        Try
            Dim nombre As String = TxbBuscarAsegurado.Text.Trim()
            tabla = objetoFarmacia.BuscarPaciente(nombre)
            CbPaciente.DataSource = tabla
            CbPaciente.DisplayMember = "ASEGURADO"
            CbPaciente.ValueMember = "MATRICULA"
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub RellenarDatosPaciente()
        Dim matricula As String = CbPaciente.SelectedValue.ToString()
        tabla = objetoFarmacia.BuscarPacienteporMatricula(matricula)
        Dim ASEGURADO As String = Convert.ToString(tabla.Rows(0)("ASEGURADO"))
        Dim TIPO As String = Convert.ToString(tabla.Rows(0)("TYPE"))
        Ltp.Text = TIPO
        Lnp.Text = ASEGURADO
        Lmp.Text = matricula

    End Sub
    Private Function RellenarCbMecicamentos()
        Try
            Dim _nombre As String = txbBuscarMedcicamentos.Text.ToString().Trim()
            tabla = objetoFarmacia.CarcarMedicamentos(_nombre)
            CbMedicamentos.DataSource = tabla
            CbMedicamentos.DisplayMember = "Nombre"
            CbMedicamentos.ValueMember = "ID"
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub CargarDatosMedicamentos()
        Dim id As String = CbMedicamentos.SelectedValue.ToString()
        tabla = objetoFarmacia.TraerCantidadPorId(id)
        Lcant.Text = Convert.ToString(tabla.Rows(0)("Cant.Disponible"))

    End Sub
    Private Function CargarAlDGV()
        If CbMedicamentos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un medicamento.")
            Return False
        Else
            If Len(TxbCantidad.Text.ToString().Trim()) > 0 Then
                If MedCargados <= 3 Then
                    Dim id, nombre, CantDisponible, Indicaciones, CantDispensada, CantResultante As String
                    id = CbMedicamentos.SelectedValue.ToString()
                    nombre = CbMedicamentos.Text.ToString()
                    Indicaciones = TbIndicaciones.Text
                    CantDisponible = Lcant.Text
                    CantDispensada = TxbCantidad.Text
                    CantResultante = CantDisponible - CantDispensada

                    If Len(Indicaciones.ToString().Trim()) > 0 Then
                        If Convert.ToInt16(CantDisponible) <= Convert.ToInt16(CantDisponible) Then
                            If Not ExisteDatoEnGrid(id) Then
                                DgvListaReceta.Rows.Add(id, nombre, CantDispensada, Indicaciones, CantResultante)
                                TxbCantidad.Text = 0
                                MedCargados = MedCargados + 1
                                Return True
                            Else
                                MessageBox.Show("El medicamento ya esta en lista")
                                Return False
                            End If
                        Else
                            MessageBox.Show("La cantidad es mayor a la disponible, por favor verifique la cantidad ingresada")
                            Return False
                        End If
                    Else
                        MessageBox.Show("No ingreso las indicaciones")
                        Return False
                    End If

                Else
                    MessageBox.Show("Solo se puede ingresar 3 medicamentos")
                    Return False
                End If
                Return False
            End If

        End If
    End Function
    Private Function ExisteDatoEnGrid(id As Long) As Boolean
        Dim existe As Boolean = DgvListaReceta.Rows.Cast(Of DataGridViewRow).Any(Function(x) CInt(x.Cells("ID").Value) = id)

        If Not existe Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function EnviarDatos()
        Dim matricula As String = CbPaciente.SelectedValue.ToString()
        Dim completo As Boolean = objetoFarmacia.GuardarCabeceraReceta(condUsuari, matricula)
        If completo Then
            Dim termino As Boolean = enviarDGVaDB()
            If termino Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    Private Function enviarDGVaDB()
        Dim proxReg = ObtenerPoximoRegistro()
        Dim est As String
        Try
            For X As Integer = 0 To DgvListaReceta.Rows.Count - 2
                Dim id As String = Convert.ToString(DgvListaReceta.Rows(X).Cells("ID").Value)
                Dim medicamento As String = Convert.ToString(DgvListaReceta.Rows(X).Cells("Medicamento").Value)
                Dim Cant As String = Convert.ToString(DgvListaReceta.Rows(X).Cells("Cantidad").Value)
                Dim Indicaciones As String = Convert.ToString(DgvListaReceta.Rows(X).Cells("Indicaciones").Value)
                Dim CantidadR As String = Convert.ToString(DgvListaReceta.Rows(X).Cells("CantResultante").Value)
                If CantidadR = 0 Then
                    est = 5
                Else
                    est = 1
                End If
                objetoFarmacia.GuardarDetReceta(proxReg, id, medicamento, Cant, Indicaciones)
                objetoFarmacia.ActualizarInventario(id, Cant, est)
            Next
            Return True
        Catch ex As Exception
            'MessageBox.Show(Err.Description)
            Return False
        End Try
    End Function
    Private Function ObtenerPoximoRegistro()
        Try
            Dim Tabla As DataTable = objetoFarmacia.ObtenerProximoRegistro()
            Dim row As DataRow = Nothing
            Dim UR As String
            If (Tabla.Rows.Count > 0) Then
                row = Tabla.Rows.Item(0)
                UR = Convert.ToString(row("UltimoRegistro"))
                If UR = "" Then
                    UR = 0
                    Return UR
                Else
                    Return UR
                End If
            End If
        Catch ex As Exception

        End Try


    End Function
    Private Function RevisarDisponibilidadInventario()
        Dim todobien As Boolean = True
        For X As Integer = 0 To DgvListaReceta.Rows.Count - 2
            If (todobien) Then
                Dim id As String = Convert.ToString(DgvListaReceta.Rows(X).Cells("ID").Value)
                Dim Cant As String = Convert.ToString(DgvListaReceta.Rows(X).Cells("Cantidad").Value)
                tabla = objetoFarmacia.TraerCantidadPorId(id)
                Dim cantidadActual = Convert.ToString(tabla.Rows(0)("Cant.Disponible"))
                If Convert.ToInt16(cantidadActual) >= Convert.ToInt16(Cant) Then
                    todobien = True
                Else
                    MessageBox.Show("No se tiene suficientes existencias del medicamento con el  id:" + id)
                    todobien = False
                    Return todobien
                End If
            End If
        Next
        Return todobien
    End Function
#End Region
    '-------------------------------------------------------EVENTOS---------------------------------------------------------------------
#Region "Eventos"
    Private Sub TxbBuscarAsegurado_TextChanged(sender As Object, e As EventArgs) Handles TxbBuscarAsegurado.TextChanged
        RellenarCbPaciente()
    End Sub
    Private Sub txbBuscarMedcicamentos_TextChanged(sender As Object, e As EventArgs) Handles txbBuscarMedcicamentos.TextChanged
        RellenarCbMecicamentos()
    End Sub
    '***********************************************************************************************************************
    Private Sub CbPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPaciente.SelectedIndexChanged
        Try
            RellenarDatosPaciente()
            PanelMedicamento.Enabled = True
            RellenarCbMecicamentos()
        Catch ex As Exception
            'MessageBox.Show(Err.Description)
        End Try
    End Sub
    Private Sub CbMedicamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMedicamentos.SelectedIndexChanged
        Try
            CargarDatosMedicamentos()
        Catch ex As Exception
            'MessageBox.Show(Err.Description)
        End Try
    End Sub
    '***********************************************************************************************************************
    Private Sub DgvListaReceta_DoubleClick(sender As Object, e As EventArgs) Handles DgvListaReceta.DoubleClick
        Try
            Dim FilaSeleccionada As DataGridViewRow = DgvListaReceta.CurrentRow
            Dim valor As Integer = Val(FilaSeleccionada.Index)
            If DgvListaReceta.RowCount - 1 > 0 Then
                DgvListaReceta.Rows.Remove(DgvListaReceta.Rows(valor))
                MedCargados = MedCargados - 1

            Else
                MessageBox.Show("La lista esta vacia no hay nada que eliminar")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error" + ex.ToString())
        End Try
    End Sub
#End Region
    '-------------------------------------------------------BOTONES---------------------------------------------------------------------
#Region "Botones"
    Private Sub BtnagreaReceta_Click(sender As Object, e As EventArgs) Handles BtnagreaReceta.Click
        If Len(TbIndicaciones.Text.ToString()) Then
            If IsNumeric(TxbCantidad.Text.ToString()) Then
                CargarAlDGV()
                TbIndicaciones.Text = ""
                TxbCantidad.Text = 0
            Else
                MessageBox.Show("La cantidad no puede ser cero ni vacia.")
            End If
        Else
            MessageBox.Show("ingresar la indicacion del medicamento")
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenuMedicos.Show()
        Close()
    End Sub
    Private Sub BntRegistrarinformacion(sender As Object, e As EventArgs) Handles Button1.Click
        If CbPaciente.SelectedIndex = -1 Then
            MessageBox.Show("error. debe selecionar un paciente ")
        Else
            If RevisarDisponibilidadInventario() Then
                Dim valor As Boolean = EnviarDatos()
                If valor Then
                    MessageBox.Show("ingreado correctamente")
                    ReiniciarFormulario()
                    MedCargados = 0
                Else
                    MessageBox.Show("error.")
                End If
            Else
                MessageBox.Show("")
            End If

        End If


    End Sub
    Private Sub BtnReiniciar_Click(sender As Object, e As EventArgs) Handles BtnReiniciar.Click
        ReiniciarFormulario()
    End Sub
#End Region
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If RevisarDisponibilidadInventario() Then
            MessageBox.Show("todobien")
        Else
            MessageBox.Show("todo mal")
        End If
    End Sub
End Class