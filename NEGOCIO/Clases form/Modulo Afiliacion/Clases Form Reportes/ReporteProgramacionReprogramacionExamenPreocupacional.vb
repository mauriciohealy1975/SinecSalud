Imports DAL

Public Class ReporteProgramacionReprogramacionExamenPreocupacional

    'ATRIBUTOS LOGICOS
    Private objDAL As TDatosSql


    'ATRIBUTOS G1
    Public programaciones As ProgramacionExamenPreocupacional()

    'METODOS INICIO 
    Public Sub New()
        objDAL = New TDatosSql(False)

        'G1
        programaciones = New ProgramacionExamenPreocupacional(0) {}
    End Sub










    'METODOS FUNCIONALES   G1
    Public Sub traerProgramacionesReprogrmaciones(ByVal _desde As Date, _hasta As Date)
        Dim objDTable As DataTable = traerProgramacionesReprogrmacionesBD(_desde, _hasta), index As Int16 = 0
        programaciones = New ProgramacionExamenPreocupacional(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, fecha As Date, matricula As String, nombre As String, tipo As Int16

            If IsDBNull(row("CODIGO")) Then codigo = 0 Else codigo = Int64.Parse(row("CODIGO"))
            If IsDBNull(row("FECHA")) Then fecha = "" Else fecha = Date.Parse(row("FECHA"))
            If IsDBNull(row("MATRICULA")) Then matricula = "" Else matricula = row("MATRICULA").ToString()
            If IsDBNull(row("NOMBRE")) Then nombre = "" Else nombre = row("NOMBRE").ToString()
            If IsDBNull(row("TYPE")) Then tipo = 0 Else tipo = Int16.Parse(row("TYPE"))

            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row(""c).ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim titular As Titular = New Titular()
            titular.setMatricula(matricula)
            titular.setNombres(nombre)

            Dim programacion As ProgramacionExamenPreocupacional = New ProgramacionExamenPreocupacional()
            programacion.setCodigo(codigo)
            programacion.setFecha(fecha)
            programacion.setTitular(titular)
            programacion.setTipo(tipo)


            programaciones(index) = programacion
            index += 1
        Next
    End Sub


    'METODOS FUNCIOANLES G2
    Public Function traerReporte(ByRef _programacion As ProgramacionExamenPreocupacional) As DataTable
        Return traerReporteBD(_programacion)
    End Function




    'METODOS BD G1
    Private Function traerProgramacionesReprogrmacionesBD(ByVal _desde As Date, ByVal _hasta As Date) As DataTable
        Dim P As Object() = New Object(9) {}
        P(0) = _desde
        P(1) = _hasta
        Return objDAL.TraerDataTable("SPtraerProgramacionesReprogramaciones", P)
    End Function

    'METODOS BD G2
    Private Function traerReporteBD(ByRef _programacion As ProgramacionExamenPreocupacional) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _programacion.getCodigo()
        P(1) = _programacion.getTipo()

        Return objDAL.TraerDataTable("SPtraerDatosParaReporte", P)
    End Function

End Class
