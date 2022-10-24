Imports DAL

Public Class RegistroUnidadMedidaLaboratorio

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql




    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)
    End Sub

    Public Sub iniciarProcesos()

    End Sub





    'METODOS FUNCIONALES G2 
    Private Function traerUnidadRepetida(ByVal _nombreUnidad As String)
        Dim datatable As DataTable = traerUnidadRepetidaBD(_nombreUnidad), nroRepetidos As Short = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("NRO REP")) Then nroRepetidos = 0 Else nroRepetidos = Long.Parse(row("NRO REP"))
        Next

        Return nroRepetidos
    End Function

    Private Function traerAbreviaturadRepetida(ByVal _abreviatura As String)
        Dim datatable As DataTable = traerAbreviaturadRepetidaBD(_abreviatura), nroRepetidos As Short = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("NRO REP")) Then nroRepetidos = 0 Else nroRepetidos = Long.Parse(row("NRO REP"))
        Next

        Return nroRepetidos
    End Function

    Public Function insertUnidad(ByRef _unidad As UnidadMedidaLaboratorio)
        Dim respuesta As Int16 = insertUnidadBD(_unidad)
        Return respuesta
    End Function










    'METODOS BD G2
    Private Function traerUnidadRepetidaBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre

        Return dal.TraerDataTable("SPtraerUnidadRepetida_RegistrarUnidadMedidaLab", P)
    End Function

    Private Function traerAbreviaturadRepetidaBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre

        Return dal.TraerDataTable("SPtraerAbreviaturaRepetida_RegistrarUnidadMedidaLab", P)
    End Function

    Private Function insertUnidadBD(ByRef _unidad As UnidadMedidaLaboratorio) As Short
        Dim P As Object() = New Object(2) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _unidad.getNombre()
        P(2) = _unidad.getAbreviacion()

        Return dal.Ejecutar("SPregistrarUnidad_RegistrarUnidadMedidaLab", P)
    End Function




    'METODOS VALIDACIÓN G2
    Public Function validarEntradasRegistrarUnidad(ByRef _unidadMedida As UnidadMedidaLaboratorio) As String
        Dim mensaje As String

        mensaje = validarNombreUnidad(_unidadMedida.getNombre())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarNombreUnidadRepetida(_unidadMedida.getNombre())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarAbreviacionRepetida(_unidadMedida.getAbreviacion())
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarNombreUnidad(_nombreUnidad As String)
        If _nombreUnidad = "" Then Return "Error. Ingrese el nombre de la unidad."

        Return ""
    End Function

    Private Function validarNombreUnidadRepetida(_nombreUnidad As String) As String
        Dim nroRepetidos As Short

        nroRepetidos = traerUnidadRepetida(_nombreUnidad)
        If nroRepetidos > 0 Then Return "Error. La unidad " + _nombreUnidad + " ya existe en el sistema."

        Return ""
    End Function

    Private Function validarAbreviacionRepetida(_abreviacion As String) As String
        Dim nroRepetidos As Short

        nroRepetidos = traerAbreviaturadRepetida(_abreviacion)
        If nroRepetidos > 0 Then Return "Error. La abreviacion " + _abreviacion + " ya existe en el sistema."

        Return ""
    End Function


End Class



Public Class UnidadMedidaLaboratorioInput

    Public Property codigo As String
    Public Property nombre As String
    Public Property abreviacion As String


    Public Sub New()
        codigo = "0"
        nombre = ""
        abreviacion = ""
    End Sub

End Class


