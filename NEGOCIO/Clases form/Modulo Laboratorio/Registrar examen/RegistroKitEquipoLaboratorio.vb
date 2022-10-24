Imports DAL
Public Class RegistroKitEquipoLaboratorio

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public tipos As Concepto()
    Public proveedores As ProveedorKitEquipo()

    'ATRIBUTOS G2
    Public examenes As ExamenLaboratorio()

    'ATRIBUTOS G4
    Public tiposReferencia As Concepto()

    'ATRIBUTOS G9
    Public nuevoCodigoKitEquipo As Long
    Public estadoInsercion As Short



    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        tipos = New Concepto(-1) {}
        proveedores = New ProveedorKitEquipo(-1) {}

        'ATRIBUTOS G2
        examenes = New ExamenLaboratorio(-1) {}

        'ATRIBUTOS G4
        tiposReferencia = New Concepto(-1) {}

        'ATRIBUTOS G9
        nuevoCodigoKitEquipo = 0
        estadoInsercion = 0
    End Sub

    Public Sub iniciarProcesos()

    End Sub





    'METODOS FUNCIONALES G1 --
    Public Sub traerTipos()
        Dim datatable As DataTable = traerTiposBD(), index As Short = 0
        tipos = New Concepto(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Long.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Long.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            tipos(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Sub traerProveedores()
        Dim datatable As DataTable = traerProveedoresBD(), index As Short = 0
        proveedores = New ProveedorKitEquipo(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODPRO PRO")) Then codigo = 0 Else codigo = Long.Parse(row("CODPRO PRO"))
            If IsDBNull(row("NOMPRO PRO")) Then nombre = "" Else nombre = row("NOMPRO PRO").ToString()

            proveedores(index) = New ProveedorKitEquipo(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Function generarCriterioNombreKitEquipo(ByRef _tipoSeleccionado As Concepto) As String
        Dim tipo As Short = _tipoSeleccionado.getCorrelativo()

        If tipo = 1 Then Return "Nombre kit"
        If tipo = 2 Then Return "Nombre equipo"

        Return ""
    End Function

    Public Function traerModeloRepetido(ByRef _proveedor As ProveedorKitEquipoInput, _modelo As Long, ByRef _examen As ExamenLaboratorioInput) As Short
        Dim datatable As DataTable = traerModeloRepetidoBD(_proveedor, _modelo, _examen), nroRepetidos As Short = 0

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("NRO REP")) Then nroRepetidos = 0 Else nroRepetidos = Long.Parse(row("NRO REP"))
        Next

        Return nroRepetidos
    End Function





    'METODOS FUNCIONALES G2
    Public Sub traerExamenes(_nombreExamen As String)
        Dim datatable As DataTable = traerExamenesBD(_nombreExamen), index As Short = 0
        examenes = New ExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String, codArea As Long, nomArea As String,
                codSubarea As Long, nomSubarea As String, codTipoRes As Short, desTipoRes As String,
                codUnidad As Long, nomUnidad As String, abrevUnidad As String

            If IsDBNull(row("CODEXA EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA EXA"))
            If IsDBNull(row("NOMEXA EXA")) Then nombre = "" Else nombre = row("NOMEXA EXA").ToString()
            If IsDBNull(row("CODARE EXA")) Then codArea = 0 Else codArea = Long.Parse(row("CODARE EXA"))
            If IsDBNull(row("NOMAREA ARE")) Then nomArea = "" Else nomArea = row("NOMAREA ARE").ToString()
            If IsDBNull(row("CODSUBARE EXA")) Then codSubarea = 0 Else codSubarea = Long.Parse(row("CODSUBARE EXA"))
            If IsDBNull(row("NOMSUBARE SUB")) Then nomSubarea = "" Else nomSubarea = row("NOMSUBARE SUB").ToString()
            If IsDBNull(row("CODTIPRES EXA")) Then codTipoRes = 0 Else codTipoRes = Short.Parse(row("CODTIPRES EXA"))
            If IsDBNull(row("DESTIPRES CON")) Then desTipoRes = "" Else desTipoRes = row("DESTIPRES CON").ToString()
            If IsDBNull(row("CODUNI EXA")) Then codUnidad = 0 Else codUnidad = Long.Parse(row("CODUNI EXA"))
            If IsDBNull(row("NOMUNI UNI")) Then nomUnidad = "" Else nomUnidad = row("NOMUNI UNI").ToString()
            If IsDBNull(row("ABRUNI UNI")) Then abrevUnidad = "" Else abrevUnidad = row("ABRUNI UNI").ToString()


            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim area As New AreaLaboratorio()
            area.setCodigo(codigo)
            area.setNombre(nomArea)

            Dim subarea As New SubareaLaboratorio()
            subarea.setCodigo(codSubarea)
            subarea.setNombre(nomSubarea)

            Dim tipoResultado As New Concepto()
            tipoResultado.setCorrelativo(codTipoRes)
            tipoResultado.setDescripcion(desTipoRes)

            Dim unidad As New UnidadMedidaLaboratorio()
            unidad.setCodigo(codUnidad)
            unidad.setNombre(nomUnidad)
            unidad.setabreviacion(abrevUnidad)


            Dim examen As New ExamenLaboratorio()
            examen.setCodigo(codigo)
            examen.setNombre(nombre)
            examen.setArea(area)
            examen.setSubarea(subarea)
            examen.setTipoResultado(tipoResultado)
            examen.setUnidad(unidad)

            examenes(index) = examen
            index += 1
        Next
    End Sub

    Public Function permiteReferenciasResultado(ByRef _tipoRestulado As Concepto) As Boolean
        Dim tipo As Short = _tipoRestulado.getCorrelativo()

        If tipo = 1 Then Return True Else Return False
    End Function

    Public Sub traerTiposValoresReferencia()
        Dim datatable As DataTable = traerTiposValoresReferenciaBD(), index As Short = 0
        tiposReferencia = New Concepto(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Long.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Long.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            tiposReferencia(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub


    'METODOS FUNCIONALES G9
    Public Sub insertKitEquipo(ByRef _nuevoKitEquipo As KitEquipoLaboratorio,
                               ByRef _nuevasReferencias As ReferenciaResultadoLaboratorio(),
                               ByRef _registroReferencias As RegistroReferenciaResultadoLaboratorio)

        Dim respuestaKitEquipo As Short, tipoReferencia As Concepto


        tipoReferencia = _nuevoKitEquipo.getTipoReferencia()


        respuestaKitEquipo = insertKitEquipoBD(_nuevoKitEquipo)
        traerCodigoKitEquipoMasReciente()
        asignarNuevoCodigo(_nuevoKitEquipo)
        enlazarKitEquipoConReferencias(_nuevoKitEquipo, _nuevasReferencias)
        insertReferencias(tipoReferencia, _nuevasReferencias, _registroReferencias)


        estadoInsercion = respuestaKitEquipo
    End Sub

    Private Sub traerCodigoKitEquipoMasReciente()
        Dim datatable As DataTable = traerCodigoKitEquipoMasRecienteBD(), index As Short = 0

        Dim codigo As Long
        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("CODKITEQU KITEQU")) Then codigo = 0 Else codigo = Long.Parse(row("CODKITEQU KITEQU"))
        Next

        nuevoCodigoKitEquipo = codigo
    End Sub

    Private Sub asignarNuevoCodigo(ByRef _kitEquipo As KitEquipoLaboratorio)
        _kitEquipo.setCodigo(nuevoCodigoKitEquipo)
    End Sub

    Private Sub enlazarKitEquipoConReferencias(ByRef _kitEquipo As KitEquipoLaboratorio, ByRef _referencias As ReferenciaResultadoLaboratorio())
        For Each referencia As ReferenciaResultadoLaboratorio In _referencias
            referencia.setKitEquipo(_kitEquipo)
        Next
    End Sub

    Private Sub insertReferencias(ByRef _tipoReferencia As Concepto,
                                  ByRef _nuevasReferencias As ReferenciaResultadoLaboratorio(),
                                  ByRef _registroReferencias As RegistroReferenciaResultadoLaboratorio)

        _registroReferencias.insertReferencias(_tipoReferencia, _nuevasReferencias)
    End Sub

    Public Function generarMensajeInsercion()
        Dim mensaje As String = ""

        If estadoInsercion > 0 Then
            mensaje = "El kit y las referencias se guardaron correctamente."

        ElseIf estadoInsercion < 0 Then
            mensaje = "Ocurrió un error al guardar el kit y las referencias"
        End If

        Return mensaje
    End Function


    'METODOS BD G1 --
    Private Function traerTiposBD() As DataTable
        Dim P As Object() = New Object(0) {}
        Return dal.TraerDataTable("SPtraerTiposKitEquipo_RegistrarKitEquipoLaboratorio", P)
    End Function

    Private Function traerProveedoresBD() As DataTable
        Dim P As Object() = New Object(0) {}
        Return dal.TraerDataTable("SPtraerProveedor_RegistrarKitEquipoLaboratorio", P)
    End Function

    Public Function traerModeloRepetidoBD(ByRef _proveedor As ProveedorKitEquipoInput, _modelo As Long, _examen As ExamenLaboratorioInput) As DataTable
        Dim P As Object() = New Object(2) {}
        P(0) = _proveedor.codigo
        P(1) = _modelo
        P(2) = _examen.codigo

        Return dal.TraerDataTable("SPtraerModeloRepetido_RegistrarKitEquipoLaboratorio", P)
    End Function


    'METODOS BD G2
    Private Function traerExamenesBD(_nombreExamen As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombreExamen
        Return dal.TraerDataTable("SPtraerExamenesLab_RegistrarKitEquipoLaboratorio", P)
    End Function


    'METODOS BD G4
    Private Function traerTiposValoresReferenciaBD() As DataTable
        Dim P As Object() = New Object(0) {}
        Return dal.TraerDataTable("SPtraerTipoValoresReferencia_Concepto", P)
    End Function


    'METODOS BD G9 --
    Private Function insertKitEquipoBD(ByRef _kitEquipo As KitEquipoLaboratorio) As Short
        Dim P As Object() = New Object(5) {}

        P(0) = Usuario.codUserLoggedSystem
        P(1) = _kitEquipo.getTipo().getCorrelativo()
        P(2) = _kitEquipo.getProveedor().getCodigo()
        P(3) = _kitEquipo.getModelo()
        P(4) = _kitEquipo.getExamen().getCodigo()
        P(5) = _kitEquipo.getTipoReferencia().getCorrelativo()

        Return dal.Ejecutar("SPregistrarKit_RegistrarKitEquipoLaboratorio", P)
    End Function

    Private Function traerCodigoKitEquipoMasRecienteBD() As DataTable
        Return dal.TraerDataTable("SPtraerUltimoCodKitEquipo_RegistrarKitEquipoLaboratorio")
    End Function










    'METODOS VALIDACIÓN G1
    Public Function validarEntradas(ByRef _kitEquipoInput As KitEquipoLaboratorioInput, _referenciasAsignadas As Boolean) As String
        Dim mensaje As String

        mensaje = validarTipo(_kitEquipoInput.tipo)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarProveedor(_kitEquipoInput.proveedor)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarModelo(_kitEquipoInput.proveedor, _kitEquipoInput.modelo, _kitEquipoInput.examen)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarExamen(_kitEquipoInput.examen)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarTipoReferencia(_kitEquipoInput.tipoReferencia)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarReferenciasAsignadas(_referenciasAsignadas)
        If Not mensaje = "" Then Return mensaje


        Return ""
    End Function

    Private Function validarTipo(ByRef _tipo As ConceptoInput) As String
        If Short.Parse(_tipo.correlativo) = 0 Then Return "Error. Seleccione un tipo."
        Return ""
    End Function

    Private Function validarProveedor(ByRef _proveedor As ProveedorKitEquipoInput) As String
        If Long.Parse(_proveedor.codigo) = 0 Then Return "Error. Seleccione un proveedor."
        Return ""
    End Function

    Private Function validarModelo(ByRef _proveedor As ProveedorKitEquipoInput, _modelo As String, ByRef examen As ExamenLaboratorioInput) As String
        Dim nroRepetidos As Short, nombreProveedor As String

        nombreProveedor = _proveedor.nombre

        If _modelo = "" Then Return "Error. Ingrese el nro de modelo."

        For Each c As Char In _modelo
            If Not Char.IsNumber(c) Then Return "Error. El el modelo sólo puede ser un número."
        Next

        nroRepetidos = traerModeloRepetido(_proveedor, Long.Parse(_modelo), examen)
        If nroRepetidos > 0 Then Return "Error. Ya existe un kit del proveedor " + nombreProveedor + " " + "con el número de modelo " + _modelo + " " + "para el examen " + examen.nombre + " " + "registrado en el sistema."

        Return ""
    End Function


    Private Function validarExamen(ByRef _examen As ExamenLaboratorioInput) As String
        If Long.Parse(_examen.codigo) = 0 Then Return "Error. Seleccione un examen."

        Return ""
    End Function

    Private Function validarTipoReferencia(ByRef _tipoReferencia As ConceptoInput) As String
        If Short.Parse(_tipoReferencia.correlativo) = 0 Then Return "Error. Seleccione un tipo de referencia."

        Return ""
    End Function

    Private Function validarReferenciasAsignadas(_referenciasAsignadas As Boolean) As String
        If Not _referenciasAsignadas Then Return "Error. Asigne los valores de referencia."

        Return ""
    End Function

End Class



Public Class ExamenLaboratorioInput
    Public Property codigo As String
    Public Property nombre As String
    Public Property area As AreaLaboratorioInput
    Public Property subarea As SubareaLaboratorioInput
    Public Property tipoResultado As ConceptoInput
    Public Property conjuntoOpcionesResultado As ConjuntoOpcionesResultadosLabInput
    Public Property unidad As UnidadMedidaLaboratorioInput


    Public Sub New()
        codigo = "0"
        nombre = ""
        area = New AreaLaboratorioInput()
        subarea = New SubareaLaboratorioInput()
        tipoResultado = New ConceptoInput()
        conjuntoOpcionesResultado = New ConjuntoOpcionesResultadosLabInput()
        unidad = New UnidadMedidaLaboratorioInput()
    End Sub

End Class

