Imports System.IO
Imports NEGOCIO

Public Class VisorRXimg
#Region "Variables"
    Private ReadOnly objetoRayosX As New FuncionesRayosX(False)
    Dim id = 0 ' id detalle
    Dim idc = 0 'id de cabecera
    Dim NombreTemp, SA As String
    Dim archivoanteriror = ""
#End Region

#Region "Auxiliares"
    Public Sub SetId(_id)
        id = _id
    End Sub
    Public Sub SetIdc(_idc)
        idc = _idc
    End Sub
#End Region
#Region "funcione"
    Private Function TextoAleatorio(longitud As Integer)
        Dim abc = "y1v2w3x4y5z6a7b8c9d0efghijklmnopqrstyvwxyz"
        For i = 1 To longitud
            Randomize()
            Dim r = Int((Rnd() * 61) + 1)
            TextoAleatorio = TextoAleatorio & Mid(abc, r, 1)
        Next i
    End Function
    Private Sub ObtenerImagenRX()
        Try
            Dim tabla As DataTable
            tabla = objetoRayosX.ObtenerImg(idc, id)
            Dim NPA = tabla.Rows(0).Item("NPA").ToString
            Dim SA = tabla.Rows(0).Item("Sitio Anatómico").ToString
            Dim ByteImg = tabla.Rows(0).Item("Contenido")
            Dim EXT = tabla.Rows(0).Item("EXT").ToString
            NombreTemp = SA + "_" + NPA + EXT
            '------------------------------------------------------------------------------
            Dim DirectorioArhvio As String
            DirectorioArhvio = System.AppDomain.CurrentDomain.BaseDirectory() & NombreTemp

            '------------------------------------------------------------------------------
            If ByteImg IsNot DBNull.Value Then
                Dim bytes() As Byte
                bytes = ByteImg
                ByteAArchivo(bytes, DirectorioArhvio) 'guardamos todo los bytes en un archivo
                PictureBox1.Image = Image.FromFile(DirectorioArhvio)
                archivoanteriror = NombreTemp
                Label1.Text = SA
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub
    Private Sub ByteAArchivo(ByVal bytes() As Byte, ByVal path As String)
        Dim k As Long
        If bytes Is Nothing Then Exit Sub
        Try
            k = UBound(bytes)
            Dim fs As New FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, k)
            fs.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        PictureBox1.Image.Dispose()
        PictureBox1.Image = Nothing 'Si no pones esta línea, no funciona (no se por que :S)
        My.Computer.FileSystem.DeleteFile(archivoanteriror) 'borramos el archivo creado una vez se carga My.Computer.FileSystem.DeleteFile(archivoanteriror) 'borramos el archivo creado una vez se carga ç
        Close()
    End Sub
#End Region
    Private Sub VisorRXimg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerImagenRX()
    End Sub
End Class