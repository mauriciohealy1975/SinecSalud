Imports DAL
Public Class RegistroExamenLaboratorio

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public areas As AreaLaboratorio()
    Public subareas As SubareaLaboratorio()
    Public tiposResultado As Concepto()

    'ATRIBUTOS G2
    Public unidadesMedida As UnidadMedidaLaboratorio()

    'ATRIBUTOS G3b
    Public conjuntosOpciones As ConjuntoOpcionesResultadosLaboratorio()
    Public opciones As OpcionResultadoLaboratorio()


    'ATRIBUTOS G9
    Public nuevoCodigoExamen As Long
    Public estadoInsercion As Short


    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        areas = New AreaLaboratorio(-1) {}
        subareas = New SubareaLaboratorio(-1) {}
        tiposResultado = New Concepto(-1) {}

        'ATRIBUTOS G2
        unidadesMedida = New UnidadMedidaLaboratorio(-1) {}

        'ATRIBUTOS G3b
        conjuntosOpciones = New ConjuntoOpcionesResultadosLaboratorio(-1) {}
        opciones = New OpcionResultadoLaboratorio(-1) {}



        'ATRIBUTOS G9
        nuevoCodigoExamen = 0
        estadoInsercion = 0
    End Sub

    Public Sub iniciarProcesos()

    End Sub








    'METODOS FUNCIONALES G1
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

    Public Sub traerSubareas(ByRef _area As AreaLaboratorio)
        Dim datatable As DataTable = traerSubareasBD(_area), index As Int16 = 0
        subareas = New SubareaLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("COD SUB")) Then codigo = 0 Else codigo = Long.Parse(row("COD SUB"))
            If IsDBNull(row("NOM SUB")) Then nombre = "" Else nombre = row("NOM SUB").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim subarea As SubareaLaboratorio = New SubareaLaboratorio()
            subarea.setCodigo(codigo)
            subarea.setNombre(nombre)
            subarea.setArea(_area)

            subareas(index) = subarea
            index += 1
        Next

    End Sub

    Public Sub traerTipoDeResultado()
        Dim datatable As DataTable = traerTipoDeResultadoBD(), index As Int16 = 0
        tiposResultado = New Concepto(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            tiposResultado(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Function esTipoResultadoComun(ByRef _tipoResultao As Concepto) As Boolean
        If _tipoResultao.getCorrelativo() = 1 Then Return True Else Return False

    End Function


    'METODOS FUNCIONALES G2
    Public Sub traerUnidadesMedida(_nombreUnidad As String)
        Dim datatable As DataTable = traerUnidadesMedidaBD(_nombreUnidad), index As Int16 = 0
        unidadesMedida = New UnidadMedidaLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String, abreviacion As String

            If IsDBNull(row("COD UNI")) Then codigo = 0 Else codigo = Long.Parse(row("COD UNI"))
            If IsDBNull(row("NOM UNI")) Then nombre = "" Else nombre = row("NOM UNI").ToString()
            If IsDBNull(row("ABR UNI")) Then abreviacion = "" Else abreviacion = row("ABR UNI").ToString()


            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))


            unidadesMedida(index) = New UnidadMedidaLaboratorio(codigo, nombre, abreviacion)
            index += 1
        Next
    End Sub



    'METODOS FUNCIONALES G3b
    Public Sub traerConjuntosOpciones(_nombre As String)
        Dim datatable As DataTable = traerConjuntosOpcionesBD(_nombre), index As Short = 0
        conjuntosOpciones = New ConjuntoOpcionesResultadosLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODCON CON")) Then codigo = 0 Else codigo = Long.Parse(row("CODCON CON"))
            If IsDBNull(row("NOMCON CON")) Then nombre = "" Else nombre = row("NOMCON CON").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            conjuntosOpciones(index) = New ConjuntoOpcionesResultadosLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Sub traerOpciones(_conjunto As ConjuntoOpcionesResultadosLaboratorio)
        Dim datatable As DataTable = traerOpcionesBD(_conjunto), index As Short = 0
        opciones = New OpcionResultadoLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, valor As String

            If IsDBNull(row("CODOPC OPC")) Then codigo = 0 Else codigo = Long.Parse(row("CODOPC OPC"))
            If IsDBNull(row("VALOPC OPC")) Then valor = "" Else valor = row("VALOPC OPC").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim opcion As New OpcionResultadoLaboratorio()
            opcion.setCodigo(codigo)
            opcion.setValor(valor)
            opcion.setConjuntoOpciones(_conjunto)

            opciones(index) = opcion
            index += 1
        Next
    End Sub


    'METODOS FUNCIONALES G9
    Public Sub insertExamen(ByRef _tipoResultado As Concepto, ByRef _nuevoExamen As ExamenLaboratorio,
                            ByRef _nuevoKitEquipo As KitEquipoLaboratorio, ByRef _nuevasReferencias As ReferenciaResultadoLaboratorio(),
                            ByRef _registroKitEquipo As RegistroKitEquipoLaboratorio, ByRef _registroReferencias As RegistroReferenciaResultadoLaboratorio)

        Dim respuesta As Short, tipo As Short


        tipo = _tipoResultado.getCorrelativo()


        If tipo = 1 Then
            respuesta = insertExamenResultadoTipoComun(_nuevoExamen, _nuevoKitEquipo, _nuevasReferencias, _registroKitEquipo, _registroReferencias)
            estadoInsercion = respuesta

        ElseIf tipo = 2 Then
            respuesta = insertExamenResultadoTipoOpcion(_nuevoExamen)
            estadoInsercion = respuesta

        ElseIf tipo = 3 Then
            respuesta = insertExamenResultadoTipoTextual(_nuevoExamen)
            estadoInsercion = respuesta
        End If
    End Sub

    Private Function insertExamenResultadoTipoComun(ByRef _examen As ExamenLaboratorio, ByRef _kitEquipo As KitEquipoLaboratorio,
                                                    ByRef _referencias As ReferenciaResultadoLaboratorio(), ByRef _registroKitEquipo As RegistroKitEquipoLaboratorio,
                                                    ByRef _registroReferencias As RegistroReferenciaResultadoLaboratorio) As Short
        Dim respuesta As Short

        respuesta = insertExamenResultadoTipoComunBD(_examen)
        traerCodigoExamenMasReciente()
        asignarNuevoCodigo(_examen)
        enlazarExamenConKitEquipo(_examen, _kitEquipo)
        insertKitEquipo(_kitEquipo, _referencias, _registroKitEquipo, _registroReferencias)

        Return respuesta
    End Function

    Private Function insertExamenResultadoTipoOpcion(ByRef _examen As ExamenLaboratorio) As Short
        Dim respuesta As Short = insertExamenResultadoTipoOpcionBD(_examen)
        Return respuesta
    End Function


    Private Function insertExamenResultadoTipoTextual(ByRef _examen As ExamenLaboratorio) As Short
        Dim respuesta As Short = insertExamenResultadoTipoTextualBD(_examen)
        Return respuesta
    End Function

    Private Sub traerCodigoExamenMasReciente()
        Dim datatable As DataTable = traerCodigoExamenMasRecienteBD(), index As Short = 0

        Dim codigo As Long
        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("CODEXA EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA EXA"))
        Next

        nuevoCodigoExamen = codigo
    End Sub

    Private Sub asignarNuevoCodigo(ByRef _examen As ExamenLaboratorio)
        _examen.setCodigo(nuevoCodigoExamen)
    End Sub

    Private Sub enlazarExamenConKitEquipo(ByRef _examen As ExamenLaboratorio, ByRef _kitEquipo As KitEquipoLaboratorio)
        _kitEquipo.setExamen(_examen)
    End Sub

    Private Sub insertKitEquipo(ByRef _nuevoKitEquipo As KitEquipoLaboratorio,
                               ByRef _nuevasReferencias As ReferenciaResultadoLaboratorio(),
                               ByRef _registroKitEquipo As RegistroKitEquipoLaboratorio,
                               ByRef _registroReferencias As RegistroReferenciaResultadoLaboratorio)

        _registroKitEquipo.insertKitEquipo(_nuevoKitEquipo, _nuevasReferencias, _registroReferencias)
    End Sub

    Public Function generarMensajeInsercion()
        Dim mensaje As String = ""

        If estadoInsercion > 0 Then
            mensaje = "El examen se guardó correctamente."

        ElseIf estadoInsercion < 0 Then
            mensaje = "Ocurrió un error al guardar examen"
        End If

        Return mensaje
    End Function



    'METODOS BD G1
    Private Function traerAreasBD() As DataTable
        Return dal.TraerDataTable("SPtraerAreasLab_RegistrarExamenLab")
    End Function

    Private Function traerSubareasBD(ByRef _area As AreaLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _area.getCodigo()
        Return dal.TraerDataTable("SPtraerSubareasLab_RegistrarExamenLab", P)
    End Function

    Private Function traerTipoDeResultadoBD() As DataTable
        Return dal.TraerDataTable("SPtraerTipoResultadoLab_Concepto")
    End Function

    'METODOS BD G2
    Private Function traerUnidadesMedidaBD(_nombreUnidad As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombreUnidad
        Return dal.TraerDataTable("SPtraerUnidades_RegistrarExamenLab", P)
    End Function


    'METODOS BD G3
    Private Function traerConjuntosOpcionesBD(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre
        Return dal.TraerDataTable("SPtraerConjuntoOpciones_RegistrarExamenLab", P)
    End Function

    Private Function traerOpcionesBD(_conjunto As ConjuntoOpcionesResultadosLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _conjunto.getCodigo()
        Return dal.TraerDataTable("SPtraerOpciones_RegistrarExamenLab", P)
    End Function


    'METODOS BD G9
    Private Function insertExamenResultadoTipoComunBD(ByRef _examen As ExamenLaboratorio) As Short
        Dim P As Object() = New Object(5) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _examen.getNombre()
        P(2) = _examen.getArea().getCodigo()
        P(3) = _examen.getSubarea().getCodigo()
        P(4) = _examen.getTipoResultado().getCorrelativo()
        P(5) = _examen.getUnidad().getCodigo()

        Return dal.Ejecutar("SPregistrarExamenLabResultadoTipoComun_RegistrarExamenLaboratorio", P)
    End Function

    Private Function insertExamenResultadoTipoOpcionBD(ByRef _examen As ExamenLaboratorio) As Short
        Dim P As Object() = New Object(5) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _examen.getNombre()
        P(2) = _examen.getArea().getCodigo()
        P(3) = _examen.getSubarea().getCodigo()
        P(4) = _examen.getTipoResultado().getCorrelativo()
        P(5) = _examen.getConjuntoOpcionesResultado().getCodigo()

        Return dal.Ejecutar("SPregistrarExamenLabResultadoTipoOpcion_RegistrarExamenLaboratorio", P)
    End Function

    Private Function insertExamenResultadoTipoTextualBD(ByRef _examen As ExamenLaboratorio) As Short
        Dim P As Object() = New Object(4) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _examen.getNombre()
        P(2) = _examen.getArea().getCodigo()
        P(3) = _examen.getSubarea().getCodigo()
        P(4) = _examen.getTipoResultado().getCorrelativo()

        Return dal.Ejecutar("SPregistrarExamenLabResultadoTipoTextual_RegistrarExamenLaboratorio", P)
    End Function

    Private Function traerCodigoExamenMasRecienteBD() As DataTable
        Return dal.TraerDataTable("SPtraerUltimoCodigoExamen_RegistrarExamenLab")
    End Function






    'METODOS VALIDACIÓN G3
    Public Function validarEntradas(ByRef _tipoReferenia As Concepto, ByRef _examenInput As ExamenLaboratorioInput, ByRef _kitEquipoAsignado As Boolean) As String
        Dim mensaje As String, tipo As Short

        mensaje = validarArea(_examenInput.area)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarSubarea(_examenInput.subarea)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarNombreExamen(_examenInput.nombre)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarTipoResultado(_examenInput.tipoResultado)
        If Not mensaje = "" Then Return mensaje


        tipo = _tipoReferenia.getCorrelativo()

        If tipo = 1 Then
            mensaje = validarUnidad(_examenInput.unidad)
            If Not mensaje = "" Then Return mensaje

            mensaje = validarKitEquipoAsignado(_kitEquipoAsignado)
            If Not mensaje = "" Then Return mensaje

        ElseIf tipo = 2 Then
            mensaje = validarConjuntoOpciones(_examenInput.conjuntoOpcionesResultado)
            If Not mensaje = "" Then Return mensaje

        ElseIf tipo = 3 Then

        End If

        Return ""
    End Function

    Private Function validarArea(ByRef _area As AreaLaboratorioInput) As String
        If Long.Parse(_area.codigo()) = 0 Then Return "Error. Seleccione un area de laboratorio."

        Return ""
    End Function

    Private Function validarSubarea(ByRef _subarea As SubareaLaboratorioInput) As String
        If Long.Parse(_subarea.codigo) = 0 Then Return "Error. Seleccione un subarea de laboratorio."
        Return ""
    End Function

    Private Function validarNombreExamen(_nombre As String) As String
        If _nombre = "" Then Return "Error. Ingrese el nombre del examen."
        Return ""
    End Function

    Private Function validarNombreRepetido(_nombre As String) As String
        Dim nroRepetidos As Short = 0
        'nroRepetidos = traerRepetidos()
        If nroRepetidos > 0 Then Return "Error. El examen " + _nombre + " ya está registrado en el sistema."
        Return ""
    End Function

    Private Function validarTipoResultado(ByRef _tipoResultado As ConceptoInput) As String
        If Short.Parse(_tipoResultado.correlativo) = 0 Then Return "Error. Seleccione un tipo resultado."
        Return ""
    End Function

    Private Function validarUnidad(ByRef _unidad As UnidadMedidaLaboratorioInput) As String
        If Long.Parse(_unidad.codigo) = 0 Then Return "Error. Seleccione una unidad."
        Return ""
    End Function

    Private Function validarKitEquipoAsignado(_kitEquipoAsignado As Boolean) As String
        If Not _kitEquipoAsignado Then Return "Error. Asigne un Kit-Equipo."

        Return ""
    End Function

    Private Function validarConjuntoOpciones(_conjunto As ConjuntoOpcionesResultadosLabInput)
        If Long.Parse(_conjunto.codigo) = 0 Then Return "Error. Seleccione un conjunto de opciones."
        Return ""
    End Function



End Class



