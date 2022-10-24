Imports DAL

Public Class RegistroProveedorKitEquipo

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G9
    Public codigoInsercion As Short

    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)
    End Sub

    Public Sub iniciarProcesos()

    End Sub


    'METODOS FUNCIONALES G1 -
    Private Function traerProveedorRepetido(_nombreProveedor As String)
        Dim datatable As DataTable = traerProveedorRepetidoBD(_nombreProveedor), nroRepetidos As Short = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("NRO REP")) Then nroRepetidos = 0 Else nroRepetidos = Long.Parse(row("NRO REP"))
        Next

        Return nroRepetidos
    End Function


    'METODOS FUNCIONALES G9
    Public Sub insertarProveedor(ByRef _proveedor As ProveedorKitEquipo)
        Dim respuesta As Short = insertarProveedorBD(_proveedor)
        codigoInsercion = respuesta
    End Sub

    Public Function generarMensajeInsercion() As String
        If codigoInsercion > 0 Then Return "El proveedor se guardó correctamente."
        If codigoInsercion <= 0 Then Return "Hubo un error al guardar el proveedor."

        Return ""
    End Function



    'METODOS BD G1 -
    Private Function traerProveedorRepetidoBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre

        Return dal.TraerDataTable("SPtraerProveedorKitEquipoRepetido_RegistrarProveedorKitEquipo", P)
    End Function


    'METODOS BD G9
    Private Function insertarProveedorBD(ByRef _proveedor As ProveedorKitEquipo) As Short
        Dim P As Object() = New Object(1) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _proveedor.getNombre()

        Return dal.Ejecutar("SPregistrarProveedorKitEquipo_RegistrarProveedorKitEquipo", P)
    End Function




    'METODOS VALIDACIÓN
    Public Function validarEntradas(ByRef _proveedorKitEquipo As ProveedorKitEquipo) As String
        Dim mensaje As String

        mensaje = validarNombeProveedor(_proveedorKitEquipo.getNombre())
        If Not mensaje = "" Then Return mensaje


        Return ""
    End Function

    Private Function validarNombeProveedor(_nombreProveedor As String) As String
        Dim nroRepetidos As Short

        If _nombreProveedor = "" Then Return "Error. Ingrese el nombre del proveedor."

        nroRepetidos = traerProveedorRepetido(_nombreProveedor)
        If nroRepetidos > 0 Then Return "Error. El proveedor " + _nombreProveedor + " ya existe en el sistema."


        Return ""
    End Function



End Class
