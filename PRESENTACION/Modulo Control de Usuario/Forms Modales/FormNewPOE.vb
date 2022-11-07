Imports System.Runtime.Remoting.Contexts
Imports NEGOCIO

Public Class FormNewPOE
#Region "Declaraciones"
    Private ReadOnly ObjRegistro As New FuncAgregarCD(False)
    Dim POE
    Dim px, py As Integer
    Dim mover As Boolean
#End Region
    Private Sub FormNewPOE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()

    End Sub
#Region "funciones"
    Private Sub Inicializar()
        POE = 9
        txbUsuario.Text = Usuario.codUserLoggedSystem
    End Sub
    Private Function ValidarFormulario()
        If Not TxbNombrePOE.Text.Trim() = "" Then
            If Not POE = 9 Then
                Return True
            Else
                MessageBox.Show("Seleccione si es Procedimiento o Ecografía")
                Return False
            End If
        Else
            Return False
            MessageBox.Show("Ingrese un nombre.")
        End If
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
#End Region
#Region "Eventos"
    Private Sub CheckProc_CheckedChanged(sender As Object, e As EventArgs) Handles CheckProc.CheckedChanged
        If CheckProc.Checked = True Then
            CheckEco.Checked = False
            POE = 1
        End If
    End Sub

    Private Sub CheckEco_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEco.CheckedChanged
        If CheckEco.Checked = True Then
            CheckProc.Checked = False
            POE = 0
        End If
    End Sub

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles Btnregistrar.Click
        Try
            If ValidarFormulario() Then
                Dim usu, nombre, Tipo
                Dim resultado As Int16
                usu = txbUsuario.Text.Trim()
                nombre = TxbNombrePOE.Text.Trim()
                Tipo = POE
                resultado = ObjRegistro.InsertarNewPOES(Tipo, nombre, usu)
                If resultado = 1 Then
                    If MsgBox("Registroagregado correctamente.¿Desea realizar otro registro?", 4, "Alerta") = 6 Then
                        TxbNombrePOE.Text = ""
                        CheckProc.Checked = False
                        CheckEco.Checked = False
                        POE = 9
                    Else
                        Close()
                    End If
                Else
                    MessageBox.Show("Error no se realizo el registro:" + Err.Description)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("ocurrio un error en la ejecucion " + Err.Description)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
#End Region
End Class