Imports DAL


Public Class RegistroConjuntoOpcionesResultadoLaboratorio

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1



    'ATRIBUTOS G9
    Public estadoInsercion As Short
    Public nuevoCodigoConjunto As Long


    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1

        'ATRIBUTOS G9
        estadoInsercion = 0
        nuevoCodigoConjunto = 0
    End Sub

    Public Sub iniciarProcesos()

    End Sub




    'METODOS FUNCIOANLES G1
    Private Function traerNombreConjuntoRepetido(ByVal _nombreConjunto As String) As Short
        Dim datatable As DataTable = traerNombreConjuntoRepetidoBD(_nombreConjunto), nroRepetidos As Short = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("NRO REP")) Then nroRepetidos = 0 Else nroRepetidos = Long.Parse(row("NRO REP"))
        Next

        Return nroRepetidos
    End Function


    'METODOS FUNCIOANLES G9
    Public Sub insertConjuntoOpciones(_conjunto As ConjuntoOpcionesResultadosLaboratorio, ByRef _opciones As OpcionResultadoLaboratorio())
        Dim respuestaConjunto As Short, respuestasOpcion As Short(), index As Short

        respuestaConjunto = 0
        respuestasOpcion = New Short(_opciones.Count - 1) {}
        index = 0

        respuestaConjunto = insertarConjuntoOpcionesBD(_conjunto)

        traerCodigoExamenMasReciente()
        asignarNuevoCodigConjunto(_conjunto)


        For Each opcion As OpcionResultadoLaboratorio In _opciones
            respuestasOpcion(index) = insertarOpcionBD(opcion)
            index += 1
        Next


        estadoInsercion = 1
    End Sub

    Private Sub traerCodigoExamenMasReciente()
        Dim datatable As DataTable = traerCodigoConjuntoMasRecienteBD(), codigo As Long = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("CODCON CON")) Then codigo = 0 Else codigo = Long.Parse(row("CODCON CON"))
        Next

        nuevoCodigoConjunto = codigo
    End Sub

    Private Sub asignarNuevoCodigConjunto(_conjunto As ConjuntoOpcionesResultadosLaboratorio)
        _conjunto.setCodigo(nuevoCodigoConjunto)
    End Sub

    Public Function generarMensajeInsercion()
        Dim mensaje As String = ""

        If estadoInsercion > 0 Then
            mensaje = "El conjunto de opciones se guardó correctamente."

        ElseIf estadoInsercion < 0 Then
            mensaje = "Ocurrió un error al guardar el conjunto de opciones."
        End If

        Return mensaje
    End Function



    'METODOS BD G1
    Private Function traerNombreConjuntoRepetidoBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre

        Return dal.TraerDataTable("SPtraerConjuntoRepetido_RegistrarConjuntoOpcionesResultadoLaboratorio", P)
    End Function


    'METODOS BD G9 
    Private Function insertarConjuntoOpcionesBD(ByRef _conjunto As ConjuntoOpcionesResultadosLaboratorio) As Short
        Dim P As Object() = New Object(1) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _conjunto.getNombre()

        Return dal.Ejecutar("SPregistarConjunto_RegistrarConjuntoOpcionesResultadoLaboratorio", P)
    End Function

    Private Function traerCodigoConjuntoMasRecienteBD() As DataTable
        Return dal.TraerDataTable("SPtraerUltimoCodigoConjunto_RegistrarConjuntoOpcionesResultadoLaboratorio")
    End Function

    Private Function insertarOpcionBD(ByRef _opcion As OpcionResultadoLaboratorio) As Short
        Dim P As Object() = New Object(2) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _opcion.getValor()
        P(2) = _opcion.getConjuntoOpcioness().getCodigo()

        Return dal.Ejecutar("SPregistrarOpcion_RegistrarConjuntoOpcionesResultadoLaboratorio", P)
    End Function



    'METODOS VALIDACIÓN G1
    Public Function validarEntradas(ByRef _conjunto As ConjuntoOpcionesResultadosLabInput, ByRef _opciones As OpcionResultadoLaboratorioInput()) As String
        Dim mensaje As String

        mensaje = validarConjunto(_conjunto)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarOpciones(_opciones)
        If Not mensaje = "" Then Return mensaje

        'mensaje = validarNroReferencias(_referencias)
        'If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarConjunto(ByRef _conjunto As ConjuntoOpcionesResultadosLabInput) As String
        Dim mensaje As String

        mensaje = validarNombreConjunto(_conjunto.nombre)
        If Not mensaje = "" Then Return mensaje


        Return ""
    End Function

    Private Function validarNombreConjunto(_nombre As String) As String
        Dim nroRepetidos As Short


        If _nombre = "" Then Return "Error. Ingrese el nombre del conjunto de opciones."

        nroRepetidos = traerNombreConjuntoRepetido(_nombre)
        If nroRepetidos > 0 Then Return "Error. El nombre de conjunto " + _nombre + " ya existe en el sistema."


        Return ""
    End Function


    Private Function validarOpciones(ByRef _opciones As OpcionResultadoLaboratorioInput()) As String
        Dim mensaje As String = "", index As Short = 0

        For Each opcion As OpcionResultadoLaboratorioInput In _opciones
            mensaje = validarValor(opcion.valor, index + 1)
            If Not mensaje = "" Then Return mensaje

            index += 1
        Next

        Return ""
    End Function

    Private Function validarValor(_valor As String, _nroFila As Short) As String
        If _valor = "" Then Return "Error fila " + _nroFila.ToString() + ". " + "Ingrese un valor."
        Return ""
    End Function


End Class
