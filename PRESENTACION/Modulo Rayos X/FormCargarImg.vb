Imports System.IO
Imports System.Runtime.Serialization.Formatters
Imports System.Web.UI.WebControls
Imports NEGOCIO

Public Class FormCargarImg
    Private sitioAnatomico, tamaño As String

    Private Id, Idc, cant As Integer
    Private ReadOnly ObjetoRayosX As New FuncionesRayosX(False)
    Dim termino, creado, todocargado As Boolean
    Dim ok As String = ""

    'necesito recibir "sitio anatomico","ID","IDC,cant


#Region "Auxiliare"
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        sitioAnatomico = ""
        tamaño = ""
        Id = 0
        Idc = 0
        cant = 0
        ok = ""


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Sub SetId(_id)
        Id = _id
    End Sub
    Public Sub SetIdc(_idc)
        Idc = _idc
    End Sub
    Public Sub SetCant(_Cant)
        cant = _Cant
    End Sub
    Public Sub setSitioAnatomico(_SA)
        sitioAnatomico = _SA
    End Sub
    '---------------------------------
    Public Function GetOk()
        Return ok
    End Function


#End Region
#Region "Principales"
    Private Sub FormCargarImg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcbtamaños()

    End Sub
#End Region
#Region "funciones"

    Private Sub cargarcbtamaños()
        CbxTamaños.DataSource = ObjetoRayosX.ObtenerTamañosRx()
        CbxTamaños.DisplayMember = "Descripcion"
        CbxTamaños.ValueMember = "id"

        termino = True
    End Sub

    Private Function GuardarImg()
        If CbxTamaños.SelectedIndex > 0 Then
            Dim nombre, tama, contPlano, exten As String
            nombre = sitioAnatomico
            contPlano = TbxRuta.Text.ToString()
            exten = txbExtension.Text.ToString()
            tama = CbxTamaños.Text.ToString()

            Dim ruta As New FileStream(contPlano, FileMode.Open, FileAccess.Read)
            Dim binario(ruta.Length) As Byte
            ruta.Read(binario, 0, ruta.Length)
            ruta.Close()
            Dim repuesta = ObjetoRayosX.Guardar(Id, Idc, nombre, tama, binario, exten)
            ObjetoRayosX.CambiarETDetallePorId(Id, 1)
            Return True
        Else
            MessageBox.Show("Seleccione un Tamaño")
            Return False
        End If


    End Function
#End Region
#Region "eventos"


#End Region
#Region "Botónes"
    Private Sub BtnSubirArchivo_Click(sender As Object, e As EventArgs) Handles BtnSubirArchivo.Click
        Try
            Dim Archivo As New OpenFileDialog
            Archivo.Filter = "JPG|*.jpg|GIF|*.gif|Bitmaps|*.bmp"
            If (Archivo.ShowDialog = DialogResult.OK) Then
                Dim ruta = Archivo.FileName
                Dim extension = Path.GetExtension(ruta)
                If Not ruta = "" Then
                    TbxRuta.Text = ruta
                    txbExtension.Text = extension
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click

        If (GuardarImg()) Then
            ok = "ok"
            Close()
        End If
    End Sub

#End Region
End Class