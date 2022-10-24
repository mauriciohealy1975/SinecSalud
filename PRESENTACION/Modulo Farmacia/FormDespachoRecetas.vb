Imports System.Runtime.Remoting
Imports System
Imports System.Runtime.InteropServices.ComTypes
Imports NEGOCIO
Imports CrystalDecisions.CrystalReports.Engine

'Recetas funciona al pelo solo falta hacer su reportebb
Public Class FormDespachoRecetas
#Region "Declaraciones"
    Private objetoFarmacia As NEGOCIO.FuncionesFarmacia = New NEGOCIO.FuncionesFarmacia(False)
    Dim id As Integer
#End Region
#Region "Principales"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub Inicializar()
        ConfiguracionVentana()
        BtnAnular.Enabled = False
        BtnDespachar.Enabled = False
        BtnReImprimir.Enabled = False
        BtnReImprimir.Visible = False
        LN.Text = Usuario.nameUserLoggedSystem.ToString()
        LT.Text = Usuario.NomTipoUserLoggedSystem.ToString()
    End Sub
    Private Sub ConfiguracionVentana()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
    End Sub
#End Region
#Region "Funciones"
    Private Function MostrarCabezaDeReceta()
        Try

            Dim condReceta As String = TxbCodReceta.Text.ToString().Trim()
            Dim tabla As DataTable
            Dim codR, codRver As String
            tabla = objetoFarmacia.TraerCabeceraDereceta(condReceta)
            Dim prueba = Convert.ToString(tabla.Rows(0)("Medico"))
            codR = Convert.ToString(tabla.Rows(0)("Cod.Receta"))
            id = codR
            If codR < 1000000 Then
                codRver = "000000" + codR
            Else
                codRver = codR
            End If
            LvCreceta.Text = "Cod.Receta:" + " " + codRver
            LvMedico.Text = "Médico:" + " " + Convert.ToString(tabla.Rows(0)("Medico"))
            LvAsegurado.Text = "Asegurado:" + " " + Convert.ToString(tabla.Rows(0)("ASEGURADO"))
            lvCAsegurado.Text = "Cod. Asegurado:" + " " + Convert.ToString(tabla.Rows(0)("Cod.Asegurado"))
            LvEstado.Text = "Estado :" + " " + Convert.ToString(tabla.Rows(0)("Estado"))
            BtnDespachar.Enabled = True
            BtnAnular.Enabled = True
            Return True
        Catch ex As Exception
            LvCreceta.Text = "Cod.Receta:"
            LvMedico.Text = "Médico:"
            LvAsegurado.Text = "Asegurado:"
            lvCAsegurado.Text = "Cod. Asegurado:"
            LvEstado.Text = "Estado :"
            BtnAnular.Enabled = False
            BtnDespachar.Enabled = False
            Return False
        End Try
    End Function
    Private Function MostrarDetalledeReceta()
        Try
            Dim condReceta As String = TxbCodReceta.Text.ToString().Trim()
            Dim tabla As DataTable
            tabla = objetoFarmacia.TraerDetalleDereceta(condReceta)
            DgvDetalleReceta.DataSource = tabla
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function Despachar()
        Try
            Dim CF As String = Usuario.codUserLoggedSystem.ToString()
            Dim codR As String = TxbCodReceta.Text()
            objetoFarmacia.ActualizarEstadoReceta(codR, "7", CF)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function anulacionReceta()
        Try
            Dim IdCodR As String
            For X As Integer = 0 To DgvDetalleReceta.Rows.Count - 2
                Dim IdMedicamento As String = Convert.ToString(DgvDetalleReceta.Rows(X).Cells("IdMedicamento").Value)
                IdCodR = Convert.ToString(DgvDetalleReceta.Rows(X).Cells("IdReceta").Value)
                Dim Cantidad As String = Convert.ToString(DgvDetalleReceta.Rows(X).Cells("Cantidad").Value)
                Dim TLiname As DataTable = objetoFarmacia.traerLinamePorID(IdMedicamento)
                Dim Liname = Convert.ToString(TLiname.Rows(0)("Liname"))
                Dim Tabla As DataTable = objetoFarmacia.Verificarshoa(IdMedicamento, Liname)
                Dim activos = Convert.ToString(Tabla.Rows(0)("Activos"))
                Dim valor = Convert.ToInt16(activos)
                Dim Estado As String
                If Not valor = 0 Then
                    Estado = "1"
                Else
                    Estado = "2"
                End If
                objetoFarmacia.reinsertarProductosAlinventario(IdMedicamento, Cantidad, Estado)

            Next
            Dim CF As String = Usuario.codUserLoggedSystem.ToString()
            objetoFarmacia.ActualizarEstadoReceta(IdCodR, 6, CF)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function buscar()
        Try

            MostrarCabezaDeReceta()
            MostrarDetalledeReceta()
            Dim VerEstado = LvEstado.Text.ToString()
            Dim Salida = VerEstado.Split(":")
            Dim VEAMOS = Salida(1)
            If VEAMOS.Trim() = "Pendiente" Then
                BtnAnular.Enabled = True
                BtnDespachar.Enabled = True
                BtnReImprimir.Enabled = False
                BtnReImprimir.Visible = False
            Else
                BtnAnular.Enabled = False
                BtnDespachar.Enabled = False
                BtnReImprimir.Enabled = True
                BtnReImprimir.Visible = True
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "Botones"
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        MostrarCabezaDeReceta()
        MostrarDetalledeReceta()
        Dim VerEstado = LvEstado.Text.ToString()
        Dim Salida = VerEstado.Split(":")
        Dim VEAMOS = Salida(1)
        If VEAMOS.Trim() = "Pendiente" Then
            BtnAnular.Enabled = True
            BtnDespachar.Enabled = True

            BtnReImprimir.Enabled = False
            BtnReImprimir.Visible = False
        Else
            BtnAnular.Enabled = False
            BtnDespachar.Enabled = False
            BtnReImprimir.Enabled = True
            BtnReImprimir.Visible = True
        End If


    End Sub
    Private Sub Imprimir()
        Dim f As New FormComprobanteReceta
        Dim CODID = TxbCodReceta.Text.ToString().Trim()
        Dim SCR As String = ""
        For X = 0 To 6 - Len(CODID)
            SCR = SCR + "0"
        Next
        SCR = SCR + CODID
        f.id = CODID
        f.CODREC = SCR
        f.ShowDialog()

    End Sub
    Private Sub BtnDespachar_Click(sender As Object, e As EventArgs) Handles BtnDespachar.Click
        Despachar()
        buscar()
        Imprimir()
        Close()
    End Sub
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        FormMenuFarmacia.Show()
        Close()
    End Sub
    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        anulacionReceta()
        buscar()
    End Sub

    Private Sub BtnReImprimir_Click(sender As Object, e As EventArgs) Handles BtnReImprimir.Click
        Imprimir()
    End Sub
#End Region
End Class