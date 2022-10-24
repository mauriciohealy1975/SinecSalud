Imports System.Windows.Forms
Imports DAL

Public Class InicioSesion

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql


    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)
    End Sub


    'Verificacion de tipo de usuario
    Public Function VerificarAcceso(user, contrasenha)
        Dim TipoUsu As Long
        TipoUsu = Usuario.tipoUsuUserLoggedSystem.ToString

        Return TipoUsu

    End Function






    'METODOS FUNCIONALES G9
    Public Function traerUsuario(_username As String, _contrasenha As String) As Boolean
        Dim objDTable As DataTable
        Dim codigo As Int16 = 0
        Dim Tcodigo As Int16 = 0
        Dim nombre As String = ""
        Dim NombreTipo As String = ""

        objDTable = traerUsuarioBD(_username, _contrasenha)

        If objDTable.Rows.Count = 1 Then
            For Each row As DataRow In objDTable.Rows
                codigo = Int16.Parse(row("COD USUARIO"))
                nombre = row("NOM USUARIO").ToString()
                Tcodigo = Int16.Parse(row("CodTipoUsu"))
                NombreTipo = row("NomTipo").ToString()



            Next
            guardarUsuario(Tcodigo, codigo, nombre, NombreTipo)

            Return True
        End If

        Return False
    End Function

    Private Sub guardarUsuario(ByVal _codtusu As String, ByVal _codigo As String, ByVal _nombre As String, ByVal _NombreTipo As String)
        Usuario.guardarDatos(_codtusu, _codigo, _nombre, _NombreTipo)
    End Sub




    'METODOS BD G9
    Private Function traerUsuarioBD(ByVal _username As String, ByVal _contrasenha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _username
        P(1) = _contrasenha
        Return (dal.TraerDataTable("SPtraerUsuario", P))
    End Function




End Class
