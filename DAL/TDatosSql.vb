Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data



Public Class TDatosSql
    Protected Servidor As String
    Public BaseDatos As String
    Protected CadenaConexion As String
    Protected Usuario As String
    Protected Password As String
    Protected ModoMixto As Boolean
    Protected Conexion As SqlConnection
    Protected Comando As SqlCommand
    Private mDataSet As DataSet
    Public baseDB As Int16
    Public Sub New(ByVal Restauracion As Boolean)
        baseDB = 4
        Select Case baseDB
            Case 0
                'base local
                If Not Restauracion Then
                    BaseDatos = "sinecsalud"
                Else
                    BaseDatos = "master"
                End If

                Servidor = "ANGEL"
                Usuario = ""
                Password = ""
                ModoMixto = False

                CadenaConexion = pCadenaConexion
            Case 1
                '------server oficial------
                If Not Restauracion Then
                    BaseDatos = "sinecsalud"
                Else
                    BaseDatos = "master"
                End If
                Servidor = "192.168.100.175"
                Usuario = "sa"
                Password = "sinec22"
                ModoMixto = True
            Case 2
                '------ conexion por red con laboratorio () ------
                If Not Restauracion Then
                    BaseDatos = "sinecsaludlaboratorio"
                Else
                    BaseDatos = "master"
                End If

                Servidor = "SERVIDORHP"
                Usuario = "sa"
                Password = "sinec22"
                ModoMixto = True
            Case 3
                '------ conexion server oficial tabla demo offline () ------
                If Not Restauracion Then
                    BaseDatos = "sinecsaluddemo"
                Else
                    BaseDatos = "master"
                End If
                Servidor = "192.168.100.175"
                Usuario = "sa"
                Password = "sinec22"
                ModoMixto = True
            Case 4
                '------ conexion server oficial tabla demo online () ------
                If Not Restauracion Then
                    BaseDatos = "sinecsaluddemo"
                Else
                    BaseDatos = "master"
                End If
                Servidor = "190.181.23.234"
                Usuario = "antlion"
                Password = "@75542023aA@"
                ModoMixto = True
        End Select
    End Sub

    Protected Function CrearConexion(ByVal CadenaConexion As String) As SqlConnection
        Return CType(New System.Data.SqlClient.SqlConnection(CadenaConexion), SqlConnection)
    End Function

    Public Property pCadenaConexion As String
        Get

            If (Servidor.Length <> 0) AndAlso (BaseDatos.Length <> 0) Then
                Dim strCadena As System.Text.StringBuilder = New System.Text.StringBuilder()

                If ModoMixto = True Then
                    strCadena.Append("data source=<SERVIDOR>;")
                    strCadena.Append("initial catalog=<BASEDATOS>;")
                    strCadena.Append("persist security info=True;")
                    strCadena.Append("user id = <USUARIO>;pwd=<PASSWORD>;packet size=4096")
                    strCadena.Replace("<USUARIO>", Me.Usuario)
                    strCadena.Replace("<SERVIDOR>", Me.Servidor)
                    strCadena.Replace("<BASEDATOS>", Me.BaseDatos)
                    strCadena.Replace("<PASSWORD>", Me.Password)
                Else
                    strCadena.Append("data source=<SERVIDOR>;")
                    strCadena.Append("initial catalog=<BASEDATOS>;")
                    strCadena.Append("Integrated Security=True")
                    strCadena.Replace("<SERVIDOR>", Me.Servidor)
                    strCadena.Replace("<BASEDATOS>", Me.BaseDatos)
                End If

                Return strCadena.ToString()
            Else
                Dim Ex As System.Exception = New System.Exception("No se puede establecer la cadena de conexion")
                Throw Ex
            End If
        End Get
        Set(ByVal value As String)
            CadenaConexion = value
        End Set
    End Property

    Protected Sub CargarParametros(ByVal Com As SqlCommand, ByVal Args As System.Object())
        Dim Limite As Integer = Com.Parameters.Count

        For i As Integer = 1 To Com.Parameters.Count - 1
            Dim P As SqlParameter = CType(Com.Parameters(i), SqlParameter)

            If i <= Args.Length Then
                P.Value = Args(i - 1)
            Else
                P.Value = Nothing
            End If
        Next
    End Sub

    Public Sub Conectar()
        Try

            If Conexion Is Nothing Then
                Conexion = New SqlConnection(pCadenaConexion)
                Conexion.Open()
            ElseIf Conexion.State = ConnectionState.Closed Then
                Conexion = New SqlConnection(pCadenaConexion)
                Conexion.Open()
            End If

        Catch ex As Exception
            Console.WriteLine("Error al conectar a la base de datos")
        End Try
    End Sub

    Public Sub Desconectar()
        Try

            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
                Conexion.Dispose()
                mDataSet.Dispose()
                Comando.Dispose()
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString())
        End Try
    End Sub

    Protected Sub ObtenerComando(ByVal ProcedimientoAlmacenado As String)
        Comando = New SqlCommand(ProcedimientoAlmacenado, Conexion)
        Comando.CommandType = CommandType.StoredProcedure
        SqlCommandBuilder.DeriveParameters(Comando)
        Comando.Connection = CType(Me.Conexion, SqlConnection)
    End Sub

    Public Function Ejecutar(ByVal ProcedimientoAlmacenado As String) As Integer
        Try
            Me.Conectar()
            ObtenerComando(ProcedimientoAlmacenado)
            Return Comando.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString())
            Return -1
        Finally
            Me.Desconectar()
        End Try
    End Function

    Public Function Ejecutar(ByVal ProcedimientoAlmacenado As String, ByVal Args As System.Object()) As Integer
        Try
            Conectar()
            ObtenerComando(ProcedimientoAlmacenado)
            CargarParametros(Comando, Args)
            Dim Resp As Integer = Comando.ExecuteNonQuery()

            For i As Integer = 0 To Comando.Parameters.Count - 1 - 1
                Dim Par As SqlParameter = CType(Comando.Parameters(i), SqlParameter)
                If Par.Direction = ParameterDirection.InputOutput OrElse Par.Direction = ParameterDirection.Output Then Args.SetValue(Par.Value, i)
            Next

            Return Resp
        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString())
            Return -1
        Finally
            Desconectar()
        End Try
    End Function

    Public Function TraerDataSet(ByVal ProcedimientoAlmacenado As String) As DataSet
        Try
            Conectar()
            Dim mDataSet As DataSet = New DataSet()
            ObtenerComando(ProcedimientoAlmacenado)
            Dim da As SqlDataAdapter = New SqlDataAdapter(Comando)
            da.Fill(mDataSet)
            da.SelectCommand.Connection.Close()
            da.Dispose()
            Return mDataSet
        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString())
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function TraerDataSet(ByVal ProcedimientoAlmacenado As String, ParamArray Args As System.Object()) As DataSet
        Try
            Conectar()
            mDataSet = New DataSet()
            ObtenerComando(ProcedimientoAlmacenado)
            Dim da As SqlDataAdapter = New SqlDataAdapter(Comando)
            If Args.Length <> 0 Then CargarParametros(da.SelectCommand, Args)
            da.Fill(mDataSet)
            da.Dispose()
            Return mDataSet
        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString())
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function TraerDataTable(ByVal ProcedimientoAlmacenado As String) As System.Data.DataTable
        Return TraerDataSet(ProcedimientoAlmacenado).Tables(0).Copy()
    End Function

    Public Function TraerDataTable(ByVal ProcedimientoAlmacenado As String, ByVal Args As System.Object()) As System.Data.DataTable
        Return TraerDataSet(ProcedimientoAlmacenado, Args).Tables(0).Copy()
    End Function




End Class
