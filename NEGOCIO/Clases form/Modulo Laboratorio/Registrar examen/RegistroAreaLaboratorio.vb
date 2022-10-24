Imports DAL

Public Class RegistroAreaLaboratorio

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)
    End Sub

    Public Sub iniciarProcesos()

    End Sub









    'METODOS FUNCIONALES G1 -
    Private Function traerAreaRepetida(ByVal _nobmreArea As String)
        Dim datatable As DataTable = traerAreaRepetidaBD(_nobmreArea), nroRepetidos As Short = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("NRO REP")) Then nroRepetidos = 0 Else nroRepetidos = Long.Parse(row("NRO REP"))
        Next

        Return nroRepetidos
    End Function

    Public Function insertArea(ByRef _area As AreaLaboratorio)
        Dim respuesta As Int16 = insertAreaBD(_area)
        Return respuesta
    End Function









    'METODOS BD G1 -
    Private Function traerAreaRepetidaBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre

        Return dal.TraerDataTable("SPtraerAreaRepetida_RegistrarExamenLab", P)
    End Function

    Private Function insertAreaBD(ByRef _area As AreaLaboratorio) As Short
        Dim P As Object() = New Object(1) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _area.getNombre()

        Return dal.Ejecutar("SPregistrarAreaLab_RegistrarExamenLab", P)
    End Function









    'METODOS VALIDACIÓN G1
    Public Function validarEntradasRegistrarArea(ByRef _area As AreaLaboratorio) As String
        Dim mensaje As String

        mensaje = validarNombreArea(_area.getNombre())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarAreaRepetida(_area.getNombre())
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarNombreArea(_nombreArea As String) As String
        If _nombreArea = "" Then Return "Error. Ingrese el nombre del area."

        Return ""
    End Function

    Private Function validarAreaRepetida(_nombreArea As String) As String
        Dim nroRepetidos As Short

        nroRepetidos = traerAreaRepetida(_nombreArea)
        If nroRepetidos > 0 Then Return "Error. El area " + _nombreArea + " ya existe en el sistema."

        Return ""
    End Function


End Class


Public Class AreaLaboratorioInput
    Public Property codigo As String
    Public Property nombre As String



    Public Sub New()
        codigo = "0"
        nombre = ""
    End Sub

End Class



