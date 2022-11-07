Imports NEGOCIO

Public Class FormDetalleRayosX
#Region "Declaraciones"
    Private ReadOnly ObjetoRayosX As New FuncionesRayosX(False)
    Dim ID As Int16
    Dim TipoDeEntrada As Int16
#End Region
#Region "auxiliar"
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ID = 0
        TipoDeEntrada = 0 'si se queda asi significa que es para ingresar foto de lo contrario es para ver foto
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub SetId(ByVal _id)
        ID = _id
    End Sub
    Public Sub SetTipoDeEntrada(_TE)
        TipoDeEntrada = _TE
    End Sub
    Public Function GetID()
        Return ID
    End Function

#Region "Botones"
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub


#End Region

#End Region
#Region "PRincipal"
    Private Sub FormDetalleRayosX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarCBDetalleRx()
        If TipoDeEntrada = 0 Then
            btnAnular.Visible = True
            BtnCompletado.Visible = True
        Else
            btnAnular.Visible = False
            BtnCompletado.Visible = False
        End If
    End Sub
#End Region
#Region "Funciones"
    Private Sub RellenarCBDetalleRx()
        Try
            Dim tabla As DataTable = ObjetoRayosX.ObtenerDetalleRX(ID)
            DGVDetalleRx.DataSource = tabla
            DGVDetalleRx.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DGVDetalleRx.Columns(0).Visible = False 'id
            DGVDetalleRx.Columns(1).Visible = False 'FK id cabecera 
            DGVDetalleRx.Columns(2).FillWeight = 45 'Sitio anatomico
            DGVDetalleRx.Columns(3).FillWeight = 15 'cantidad
            DGVDetalleRx.Columns(4).FillWeight = 40 'INforme
            DGVDetalleRx.Columns(5).Visible = False 'Estado


            DGVDetalleRx.Columns(0).ReadOnly = True
            DGVDetalleRx.Columns(1).ReadOnly = True
            DGVDetalleRx.Columns(2).ReadOnly = True
            DGVDetalleRx.Columns(3).ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(Err.Description)
            Close()
        End Try



    End Sub


    Private Function Validarcompleto()
        Dim listo As Boolean = True
        Dim estado
        For X As Integer = 0 To DGVDetalleRx.Rows.Count - 2
            estado = Convert.ToString(DGVDetalleRx.Rows(X).Cells("Estado").Value)
            If estado = 0 Then
                listo = False
                Return listo
            End If
        Next
        Return listo
    End Function

#End Region
#Region "Eventos"
    Private Sub DGVDetalleRx_DoubleClick(sender As Object, e As EventArgs) Handles DGVDetalleRx.DoubleClick
        Try
            'doble clic para obtener la lista del menu
            If TipoDeEntrada = 0 Then
                If DGVDetalleRx.RowCount - 1 > 0 Then

                    Dim FilaSeleccionada As DataGridViewRow = DGVDetalleRx.CurrentRow
                    Dim valor As Integer = Val(FilaSeleccionada.Index)
                    If (Not FilaSeleccionada Is Nothing) Then
                        Dim Estado As String = Convert.ToDouble(DGVDetalleRx.Rows(valor).Cells("Estado").Value) 'Estado
                        If Estado = 0 Then
                            Dim id As String = Convert.ToDouble(DGVDetalleRx.Rows(valor).Cells("ID").Value) 'id la fila del detalle
                            Dim idc As String = Convert.ToDouble(DGVDetalleRx.Rows(valor).Cells("IDC").Value) 'ide de la cabecera
                            Dim SA As String = Convert.ToString(DGVDetalleRx.Rows(valor).Cells("Sitio Anatómico").Value) 'Sitio anatomico
                            Dim Cant As String = Convert.ToString(DGVDetalleRx.Rows(valor).Cells("cantidad").Value) 'Cantidad


                            Dim rayosX = New FormCargarImg
                            rayosX.SetId(id)
                            rayosX.SetIdc(idc)
                            rayosX.setSitioAnatomico(SA)
                            rayosX.SetCant(Cant)
                            rayosX.ShowDialog()
                            If rayosX.GetOk = "ok" Then
                                DGVDetalleRx.Rows(valor).Cells(5).Value = "1"
                                DGVDetalleRx.Rows(valor).DefaultCellStyle.BackColor = Color.GreenYellow
                            End If ' estamos evauando si se envio o no el archivo 
                        End If
                        If Estado = 1 Then
                            DGVDetalleRx.Rows(valor).DefaultCellStyle.BackColor = Color.GreenYellow
                        End If



                    End If
                Else
                    MessageBox.Show("Ese envio esta vacio")
                End If
            Else 'si el entra por aqui solo e para mostrar foto'
                If DGVDetalleRx.RowCount - 1 > 0 Then

                    Dim FilaSeleccionada As DataGridViewRow = DGVDetalleRx.CurrentRow
                    Dim valor As Integer = Val(FilaSeleccionada.Index)
                    If (Not FilaSeleccionada Is Nothing) Then
                        Dim id As String = Convert.ToDouble(DGVDetalleRx.Rows(valor).Cells("ID").Value) 'id la fila del detalle
                        Dim idc As String = Convert.ToDouble(DGVDetalleRx.Rows(valor).Cells("IDC").Value) 'ide de la cabecera

                        Dim VerRX = New VisorRXimg
                        VerRX.SetId(id)
                        VerRX.SetIdc(idc)
                        VerRX.ShowDialog()

                    End If



                End If

            End If

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub
#End Region
#Region "botones"
    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim Respuesta = ObjetoRayosX.CancelarSolicitud(ID, 7)

        If Respuesta Then
            Respuesta = ObjetoRayosX.BorrarImagenesCanceladas(ID)
            If Respuesta Then
                MessageBox.Show("Solicitud Cancelada")
                Close()

            Else
                MessageBox.Show("Error al cancelar solicitud")
            End If

        Else
            MessageBox.Show("error al cancelar")
        End If
    End Sub

    Private Sub BtnCompletado_Click(sender As Object, e As EventArgs) Handles BtnCompletado.Click
        If Validarcompleto() Then
            Dim Respuesta = ObjetoRayosX.CancelarSolicitud(ID, 5)
            If Respuesta Then
                MessageBox.Show("Solicitud completada")
                Close()
            Else
                MessageBox.Show("error al cancelar")
            End If
        Else

        End If


    End Sub

#End Region
End Class