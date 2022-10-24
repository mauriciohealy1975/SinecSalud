Imports DAL

Public Class RegistroSubareaLaboratorio

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql


    'ATRIBUTOS G2
    Public areas As AreaLaboratorio()
    Public subareas As SubareaLaboratorio()


    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)
        areas = New AreaLaboratorio(-1) {}

        'ATRIBUTOS G2
        subareas = New SubareaLaboratorio(-1) {}
    End Sub

    Public Sub iniciarProcesos()

    End Sub





    'METODOS FUNCIONALES G2 
    Public Sub traerAreas()
        Dim datatable As DataTable = traerAreasBD(), index As Int16 = 0
        areas = New AreaLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("COD ARE")) Then codigo = 0 Else codigo = Long.Parse(row("COD ARE"))
            If IsDBNull(row("NOM ARE")) Then nombre = "" Else nombre = row("NOM ARE").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))


            areas(index) = New AreaLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub

    Private Function traerSubareaRepetida(ByVal _nombreSubarea As String)
        Dim datatable As DataTable = traerSubareaRepetidaBD(_nombreSubarea), nroRepetidos As Short = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("NRO REP")) Then nroRepetidos = 0 Else nroRepetidos = Long.Parse(row("NRO REP"))
        Next

        Return nroRepetidos
    End Function

    Public Function insertSubarea(ByRef _subarea As SubareaLaboratorio)
        Dim respuesta As Int16 = insertSubareaBD(_subarea)
        Return respuesta
    End Function










    'METODOS BD G2
    Private Function traerAreasBD() As DataTable
        Return dal.TraerDataTable("SPtraerAreasLab_RegistrarExamenLab")
    End Function

    Private Function traerSubareaRepetidaBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre

        Return dal.TraerDataTable("SPtraerSubareaRepetida_RegistrarExamenLab", P)
    End Function

    Private Function insertSubareaBD(ByRef _subarea As SubareaLaboratorio) As Short
        Dim P As Object() = New Object(2) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _subarea.getNombre()
        P(2) = _subarea.getArea().getCodigo()

        Return dal.Ejecutar("SPregistrarSubareaLab_RegistrarExamenLab", P)
    End Function




    'METODOS VALIDACIÓN G2
    Public Function validarEntradasRegistrarSubarea(ByRef _subarea As SubareaLaboratorio) As String
        Dim mensaje As String


        mensaje = validarAreaSeleccionada(_subarea.getArea())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarNombreSubarea(_subarea.getNombre())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarSubareaRepetida(_subarea.getNombre())
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarAreaSeleccionada(_area As AreaLaboratorio) As String
        If _area.getCodigo() = 0 Then Return "Error. Seleccione un area."

        Return ""
    End Function

    Private Function validarNombreSubarea(_nombreSubarea As String)
        If _nombreSubarea = "" Then Return "Error. Ingrese el nombre del subarea."

        Return ""
    End Function

    Private Function validarSubareaRepetida(_nombreSubarea As String) As String
        Dim nroRepetidos As Short

        nroRepetidos = traerSubareaRepetida(_nombreSubarea)
        If nroRepetidos > 0 Then Return "Error. El subarea " + _nombreSubarea + " ya existe en el sistema."

        Return ""
    End Function


End Class

Public Class SubareaLaboratorioInput
    Public Property codigo As String
    Public Property nombre As String
    Public Property area As AreaLaboratorioInput

    Public Sub New()
        codigo = "0"
        nombre = ""
        area = New AreaLaboratorioInput()
    End Sub
End Class