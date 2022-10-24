Imports DAL


Public Class RegistroReferenciaResultadoLaboratorio

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public areas As AreaLaboratorio()
    Public subareas As SubareaLaboratorio()
    Public examenes As ExamenLaboratorio()
    Public kitsequipos As KitEquipoLaboratorio()
    Public tiposReferencia As Concepto()

    'ATRIBUTOS G9
    Public estadoInsercion As Short


    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        areas = New AreaLaboratorio(-1) {}
        subareas = New SubareaLaboratorio(-1) {}
        examenes = New ExamenLaboratorio(-1) {}
        kitsequipos = New KitEquipoLaboratorio(-1) {}
        tiposReferencia = New Concepto(-1) {}

        'ATRIBUTOS G9
        estadoInsercion = 0
    End Sub

    Public Sub iniciarProcesos()

    End Sub










    'METODOS FUNCIONALES G1 -----
    Public Sub traerAreas()
        Dim datatable As DataTable = traerAreasBD(), index As Int16 = 0
        areas = New AreaLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODARE ARE")) Then codigo = 0 Else codigo = Long.Parse(row("CODARE ARE"))
            If IsDBNull(row("NOMARE ARE")) Then nombre = "" Else nombre = row("NOMARE ARE").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))


            areas(index) = New AreaLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Sub traerSubareas(ByRef _area As AreaLaboratorio)
        Dim datatable As DataTable = traerSubareasBD(_area), index As Short = 0
        subareas = New SubareaLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODSUB SUB")) Then codigo = 0 Else codigo = Long.Parse(row("CODSUB SUB"))
            If IsDBNull(row("NOMSUB SUB")) Then nombre = "" Else nombre = row("NOMSUB SUB").ToString()

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

    Public Sub traerExamenes(ByRef _subarea As SubareaLaboratorio)
        Dim datatable As DataTable = traerExamenesBD(_subarea), index As Short = 0
        examenes = New ExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String, codUnidad As Long, nomUnidad As String, abreUnidad As String

            If IsDBNull(row("CODEXA EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA EXA"))
            If IsDBNull(row("NOMEXA EXA")) Then nombre = "" Else nombre = row("NOMEXA EXA").ToString()
            If IsDBNull(row("CODUNI EXA")) Then codUnidad = 0 Else codUnidad = Long.Parse(row("CODUNI EXA"))
            If IsDBNull(row("NOMUNI UNI")) Then nomUnidad = "" Else nomUnidad = row("NOMUNI UNI").ToString()
            If IsDBNull(row("ABRUNI UNI")) Then abreUnidad = "" Else abreUnidad = row("ABRUNI UNI").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim unidad As New UnidadMedidaLaboratorio()
            unidad.setCodigo(codUnidad)
            unidad.setNombre(nomUnidad)
            unidad.setabreviacion(abreUnidad)

            Dim examen As New ExamenLaboratorio()
            examen.setCodigo(codigo)
            examen.setNombre(nombre)
            examen.setUnidad(unidad)

            examenes(index) = examen
            index += 1
        Next
    End Sub

    Public Sub traerKitsEquipos(ByRef _examen As ExamenLaboratorio)
        Dim datatable As DataTable = traerKitsEquiposBD(_examen), index As Short = 0
        kitsequipos = New KitEquipoLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String, tipo As Short, codExamen As Long, codTipoRef As Short

            If IsDBNull(row("CODKEQ KEQ")) Then codigo = 0 Else codigo = Long.Parse(row("CODKEQ KEQ"))
            If IsDBNull(row("NOMKEQ KEQ")) Then nombre = "" Else nombre = row("NOMKEQ KEQ").ToString()
            If IsDBNull(row("TIPOKEQ KEQ")) Then tipo = 0 Else tipo = Short.Parse(row("TIPOKEQ KEQ"))
            If IsDBNull(row("CODEXA KEQ")) Then codExamen = 0 Else codExamen = Long.Parse(row("CODEXA KEQ"))
            If IsDBNull(row("CODTIPREF KEQ")) Then codTipoRef = 0 Else codTipoRef = Short.Parse(row("CODTIPREF KEQ"))

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = 0 Else  = Short.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim tipokitequipo As New Concepto()
            tipokitequipo.setPrefijo(0)
            tipokitequipo.setCorrelativo(tipo)
            tipokitequipo.setDescripcion("")

            Dim tipoReferencia As New Concepto()
            tipoReferencia.setPrefijo(1)
            tipoReferencia.setCorrelativo(codTipoRef)
            tipoReferencia.setDescripcion("")

            Dim kitequipo As New KitEquipoLaboratorio()
            kitequipo.setCodigo(codigo)
            kitequipo.setNombre(nombre)
            kitequipo.setTipo(tipokitequipo)
            kitequipo.setExamen(_examen)
            kitequipo.setTipoReferencia(tipoReferencia)


            kitsequipos(index) = kitequipo
            index += 1
        Next
    End Sub

    Public Sub traerTiposReferencias()
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


    'METODOS FUNCIONALES G2-----
    Public Function esClickEnColumnaAccion(_columnaClickIndex As Short, _columnaAccionIndex As Short) As Boolean
        If _columnaClickIndex = _columnaAccionIndex Then Return True Else Return False
    End Function


    'METODOS FUNCIONALES G9
    Public Sub insertReferencias(_tipoReferencia As Concepto, ByRef _referencias As ReferenciaResultadoLaboratorio())
        Dim respuesta As Short = 0
        Dim tipo As Short = _tipoReferencia.getCorrelativo()


        If tipo = 1 Then
            Dim referencia As New ReferenciaResultadoLaboratorio()
            referencia = _referencias(0)
            respuesta = insertReferenciaTipoComunBD(referencia)

        ElseIf tipo = 2 Then
            For Each referencia As ReferenciaResultadoLaboratorio In _referencias
                respuesta = insertReferenciaTipoSexoBD(referencia)
            Next

        ElseIf tipo = 3 Then
            For Each referencia As ReferenciaResultadoLaboratorio In _referencias
                respuesta = insertReferenciaTipoEdadBD(referencia)
            Next

        ElseIf tipo = 4 Then
            For Each referencia As ReferenciaResultadoLaboratorio In _referencias
                respuesta = insertReferenciaTipoSexoYEdadBD(referencia)
            Next
        End If


        estadoInsercion = respuesta
    End Sub

    Public Function generarMensajeInsercion()
        If estadoInsercion > 0 Then Return "Las referencias se guardaron correctamente"

        If estadoInsercion < 0 Then Return "Ocurrió un error al guardar las referencias"

        Return ""
    End Function











    'METODOS BD G1 --
    Private Function traerAreasBD() As DataTable
        Return dal.TraerDataTable("SPtraerAreasLab_RegistrarReferenciasResultadoLaboratorio")
    End Function

    Private Function traerSubareasBD(ByRef _area As AreaLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _area.getCodigo()
        Return dal.TraerDataTable("SPtraerSubareasLab_RegistrarReferenciasResultadoLaboratorio", P)
    End Function

    Private Function traerExamenesBD(ByRef _subarea As SubareaLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _subarea.getCodigo()
        Return dal.TraerDataTable("SPtraerExamenesLab_RegistrarReferenciasResultadoLaboratorio", P)
    End Function

    Private Function traerKitsEquiposBD(ByRef _examen As ExamenLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _examen.getCodigo()
        Return dal.TraerDataTable("SPtraerkits_RegistrarReferenciasResultadoLaboratorio", P)
    End Function

    Private Function traerTiposValoresReferenciaBD() As DataTable
        Dim P As Object() = New Object(0) {}
        Return dal.TraerDataTable("SPtraerTipoValoresReferencia_Concepto", P)
    End Function


    'METODOS BD G9 
    Private Function insertReferenciaTipoComunBD(ByRef _referencia As ReferenciaResultadoLaboratorio) As Short
        Dim P As Object() = New Object(5) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _referencia.getTipo().getCorrelativo()
        P(2) = _referencia.getExamen().getCodigo()
        P(3) = _referencia.getKitEquipo().getCodigo()
        P(4) = _referencia.getValorInicio()
        P(5) = _referencia.getValorFin()

        Return dal.Ejecutar("SPregistrarReferenciaTipoComun_RegistrarReferenciasResultadoLaboratorio", P)
    End Function

    Private Function insertReferenciaTipoSexoBD(ByRef _referencia As ReferenciaResultadoLaboratorio) As Short
        Dim P As Object() = New Object(6) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _referencia.getTipo().getCorrelativo()
        P(2) = _referencia.getExamen().getCodigo()
        P(3) = _referencia.getKitEquipo().getCodigo()
        P(4) = _referencia.getValorInicio()
        P(5) = _referencia.getValorFin()
        P(6) = _referencia.getSexo()

        Return dal.Ejecutar("SPregistrarReferenciaTipoSexo_RegistrarReferenciasResultadoLaboratorio", P)
    End Function

    Private Function insertReferenciaTipoEdadBD(ByRef _referencia As ReferenciaResultadoLaboratorio) As Short
        Dim P As Object() = New Object(7) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _referencia.getTipo().getCorrelativo()
        P(2) = _referencia.getExamen().getCodigo()
        P(3) = _referencia.getKitEquipo().getCodigo()
        P(4) = _referencia.getValorInicio()
        P(5) = _referencia.getValorFin()
        P(6) = _referencia.getEdadInicio()
        P(7) = _referencia.getEdadFin()

        Return dal.Ejecutar("SPregistrarRefTipoEdad_RegistrarReferenciasResultadoLaboratorio", P)
    End Function

    Private Function insertReferenciaTipoSexoYEdadBD(ByRef _referencia As ReferenciaResultadoLaboratorio) As Short
        Dim P As Object() = New Object(8) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _referencia.getTipo().getCorrelativo()
        P(2) = _referencia.getExamen().getCodigo()
        P(3) = _referencia.getKitEquipo().getCodigo()
        P(4) = _referencia.getValorInicio()
        P(5) = _referencia.getValorFin()
        P(6) = _referencia.getSexo()
        P(7) = _referencia.getEdadInicio()
        P(8) = _referencia.getEdadFin()

        Return dal.Ejecutar("SPregistrarRefTipoSexoEdad_RegistrarReferenciasResultadoLaboratorio", P)
    End Function
















    'METODOS VALIDACIÓN G1
    Public Function validarEntradas(ByRef _tipoReferencia As Concepto, ByRef _referencias As ReferenciaResultadoLaboratorioInput()) As String
        Dim mensaje As String

        mensaje = validarArea(_referencias(0).examen.area)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarSubarea(_referencias(0).examen.subarea)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarExamen(_referencias(0).examen)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarKitEquipo(_referencias(0).kitequipo)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarTipoReferencia(_referencias(0).tipoReferencia)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarNroReferencias(_referencias)
        If Not mensaje = "" Then Return mensaje

        Dim tipo As Short = _tipoReferencia.getCorrelativo()
        If tipo = 1 Then
            mensaje = validarDeTipoComun(_referencias)
            If Not mensaje = "" Then Return mensaje

        ElseIf tipo = 2 Then
            mensaje = validarDeTipoSexo(_referencias)
            If Not mensaje = "" Then Return mensaje

        ElseIf tipo = 3 Then
            mensaje = validarDeTipoEdad(_referencias)
            If Not mensaje = "" Then Return mensaje

        ElseIf tipo = 4 Then
            mensaje = validarDeTipoSexoYEdad(_referencias)
            If Not mensaje = "" Then Return mensaje

        End If

        Return ""
    End Function

    Private Function validarArea(_area As AreaLaboratorioInput)
        If Long.Parse(_area.codigo) = 0 Then Return "Error. Seleccione un area."

        Return ""
    End Function

    Private Function validarSubarea(_subarea As SubareaLaboratorioInput)
        If Long.Parse(_subarea.codigo) = 0 Then Return "Error. Seleccione una subarea."

        Return ""
    End Function

    Private Function validarExamen(_examen As ExamenLaboratorioInput)
        If Long.Parse(_examen.codigo) = 0 Then Return "Error. Seleccione un examem."

        Return ""
    End Function

    Private Function validarKitEquipo(_kitEquipo As KitEquipoLaboratorioInput)
        If Long.Parse(_kitEquipo.codigo) = 0 Then Return "Error. Seleccione un kit-equipo."

        Return ""
    End Function

    Private Function validarTipoReferencia(_tipoReferencia As ConceptoInput)
        If Long.Parse(_tipoReferencia.correlativo) = 0 Then Return "Error. Seleccione un tipo de referencia."

        Return ""
    End Function

    Private Function validarNroReferencias(ByRef _referencias As ReferenciaResultadoLaboratorioInput()) As String
        If _referencias.Count <= 0 Then Return "Error. Debe ingresar cómo mínimo una fila de referencias."

        Return ""
    End Function

    Private Function validarDeTipoComun(ByRef _referencias As ReferenciaResultadoLaboratorioInput()) As String
        Dim mensaje As String
        Dim referencia As ReferenciaResultadoLaboratorioInput = _referencias(0)

        mensaje = validarDeTipoComunValorInicio(referencia.valorInicio)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarDeTipoComunValorFin(referencia.valorFin)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarDeTipoComunValorInicio(_valorInicio As String) As String
        If _valorInicio = "" Then Return "Error. Ingrese el valor de inicial."

        For Each c As Char In _valorInicio
            If Not Char.IsDigit(c) And Not c = "." Then Return "Error. El valor inicial sólo admite números/números decimales con punto."
        Next

        Return ""
    End Function

    Private Function validarDeTipoComunValorFin(_valorFin As String) As String
        If _valorFin = "" Then Return "Error. Ingrese el valor final."

        For Each c As Char In _valorFin
            If Not Char.IsDigit(c) And Not c = "." Then Return "Error. El valor final sólo admite números/números decimales con punto."
        Next

        Return ""
    End Function

    Public Function validarDeTipoSexo(ByRef _referencias As ReferenciaResultadoLaboratorioInput()) As String
        Dim mensaje As String

        For Each referencia As ReferenciaResultadoLaboratorioInput In _referencias
            mensaje = validarDeTipoSexoValorInicio(referencia)
            If Not mensaje = "" Then Return mensaje

            mensaje = validarDeTipoSexoValorFin(referencia)
            If Not mensaje = "" Then Return mensaje
        Next

        Return ""
    End Function

    Private Function validarDeTipoSexoValorInicio(ByRef _referencia As ReferenciaResultadoLaboratorioInput) As String
        Dim sexo As String = "", valorInicio As String = ""
        sexo = _referencia.sexo
        valorInicio = _referencia.valorInicio


        If sexo = "M" Then
            If valorInicio = "" Then Return "Error. Ingrese el valor de inicial (MASCULINO)."


            For Each c As Char In valorInicio
                If Not Char.IsDigit(c) And Not c = "." Then
                    Return "Error. El valor inicial (MASCULINO) sólo admite números/números decimales con punto."
                End If
            Next


        ElseIf sexo = "F" Then
            If valorInicio = "" Then Return "Error. Ingrese el valor de inicial (FEMENINO)."


            For Each c As Char In valorInicio
                If Not Char.IsDigit(c) And Not c = "." Then
                    Return "Error. El valor inicial (FEMENINO) sólo admite números/números decimales con punto."
                End If
            Next
        End If


        Return ""
    End Function

    Private Function validarDeTipoSexoValorFin(ByRef _referencia As ReferenciaResultadoLaboratorioInput) As String
        Dim sexo As String = "", valorFin As String = ""
        sexo = _referencia.sexo
        valorFin = _referencia.valorFin


        If sexo = "M" Then
            If valorFin = "" Then Return "Error. Ingrese el valor de final (MASCULINO)."


            For Each c As Char In valorFin
                If Not Char.IsDigit(c) And Not c = "." Then
                    Return "Error. El valor final (MASCULINO) sólo admite números/números decimales con punto."
                End If
            Next


        ElseIf sexo = "F" Then
            If valorFin = "" Then Return "Error. Ingrese el valor de final (FEMENINO)."


            For Each c As Char In valorFin
                If Not Char.IsDigit(c) And Not c = "." Then
                    Return "Error. El valor final (FEMENINO) sólo admite números/números decimales con punto."
                End If
            Next
        End If


        Return ""
    End Function

    Private Function validarDeTipoEdad(ByRef _referencias As ReferenciaResultadoLaboratorioInput()) As String
        Dim mensaje As String

        Dim index As Short = 0
        For Each referencia As ReferenciaResultadoLaboratorioInput In _referencias
            mensaje = validarDeTipoEdadEdadInicio(referencia, index)
            If Not mensaje = "" Then Return mensaje

            mensaje = validarDeTipoEdadEdadFin(referencia, index)
            If Not mensaje = "" Then Return mensaje

            mensaje = validarDeTipoEdadValorInicio(referencia, index)
            If Not mensaje = "" Then Return mensaje


            mensaje = validarDeTipoEdadValorFin(referencia, index)
            If Not mensaje = "" Then Return mensaje

            index += 1
        Next

        Return ""
    End Function

    Private Function validarDeTipoEdadEdadInicio(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _index As Short) As String
        Dim mensaje As String = "", nroFila As Short = 0, edadInicio As String = ""


        nroFila = _index + 1
        edadInicio = _referencia.edadInicio


        If edadInicio = "" Then Return "Error Fila " + nroFila.ToString() + ". " + "Ingrese la edad inicial."

        For Each c As Char In edadInicio
            If Not Char.IsDigit(c) And Not c = "-" Then Return "Error Fila " + nroFila.ToString() + ". " + "La edad inicial sólo admite números enteros."
        Next

        If Short.Parse(edadInicio) < 0 Then Return "Error Fila " + nroFila.ToString() + ". " + "La edad inicial no puede ser negativa."

        Return ""
    End Function

    Private Function validarDeTipoEdadEdadFin(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _index As Short) As String
        Dim mensaje As String = "", nroFila As Short = 0, edadFin As String = ""


        nroFila = _index + 1
        edadFin = _referencia.edadFin


        If edadFin = "" Then Return "Error Fila " + nroFila.ToString() + ". " + "Ingrese la edad final."

        For Each c As Char In edadFin
            If Not Char.IsDigit(c) And Not c = "-" Then Return "Error Fila " + nroFila.ToString() + ". " + "La edad final sólo admite números enteros."
        Next

        If Short.Parse(edadFin) < 0 Then Return "Error Fila " + nroFila.ToString() + ". " + "La edad final no puede ser negativa."

        Return ""
    End Function

    Private Function validarDeTipoEdadValorInicio(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _index As Short) As String
        Dim nroFila As Short, valorInicio As String
        nroFila = _index + 1
        valorInicio = _referencia.valorInicio


        If valorInicio = "" Then Return "Error Fila " + nroFila.ToString() + ". " + "Ingrese el valor inicial."

        For Each c As Char In valorInicio
            If Not Char.IsDigit(c) And Not c = "." Then Return "Error Fila " + nroFila.ToString() + ". " + "El valor inicial sólo admite números enteros/números deciamales con punto."
        Next

        Return ""
    End Function

    Private Function validarDeTipoEdadValorFin(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _index As Short) As String
        Dim nroFila As Short, valorFin As String
        nroFila = _index + 1
        valorFin = _referencia.valorFin


        If valorFin = "" Then Return "Error Fila " + nroFila.ToString() + ". " + "Ingrese el valor final."

        For Each c As Char In valorFin
            If Not Char.IsDigit(c) And Not c = "." Then Return "Error Fila " + nroFila.ToString() + ". " + "El valor final sólo admite números enteros/números deciamales con punto."
        Next

        Return ""
    End Function

    Private Function validarDeTipoSexoYEdad(ByRef _referencias As ReferenciaResultadoLaboratorioInput()) As String
        Dim mensaje As String

        Dim index As Short = 0
        Dim nroFila As Short = 1
        For Each referencia As ReferenciaResultadoLaboratorioInput In _referencias
            mensaje = validarDeTipoSexoYEdadEdadInicio(referencia, nroFila)
            If Not mensaje = "" Then Return mensaje

            mensaje = validarDeTipoSexoYEdadEdadFin(referencia, nroFila)
            If Not mensaje = "" Then Return mensaje


            Dim sexo As Char = referencia.sexo

            If sexo = "M" Then
                mensaje = validarDeTipoSexoYEdadValorInicioHombres(referencia, nroFila)
                If Not mensaje = "" Then Return mensaje

                mensaje = validarDeTipoSexoYEdadValorFinHombres(referencia, nroFila)
                If Not mensaje = "" Then Return mensaje

            ElseIf sexo = "F" Then
                mensaje = validarDeTipoSexoYEdadValorInicioMujeres(referencia, nroFila)
                If Not mensaje = "" Then Return mensaje

                mensaje = validarDeTipoSexoYEdadValorFinMujeres(referencia, nroFila)
                If Not mensaje = "" Then Return mensaje
            End If


            index += 1
            If index Mod 2 = 0 And Not index = 0 Then nroFila += 1
        Next

        Return ""
    End Function

    Private Function validarDeTipoSexoYEdadEdadInicio(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _nroFila As Short) As String
        Dim mensaje As String = "", edadInicio As String = ""
        edadInicio = _referencia.edadInicio


        If edadInicio = "" Then Return "Error Fila " + _nroFila.ToString() + ". " + "Ingrese la edad inicial."

        For Each c As Char In edadInicio
            If Not Char.IsDigit(c) And Not c = "-" Then Return "Error Fila " + _nroFila.ToString() + ". " + "La edad inicial sólo admite números enteros."
        Next

        If Short.Parse(edadInicio) < 0 Then Return "Error Fila " + _nroFila.ToString() + ". " + "La edad inicial no puede ser negativa."

        Return ""
    End Function

    Private Function validarDeTipoSexoYEdadEdadFin(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _nroFila As Short) As String
        Dim mensaje As String = "", edadFin As String = ""
        edadFin = _referencia.edadFin


        If edadFin = "" Then Return "Error Fila " + _nroFila.ToString() + ". " + "Ingrese la edad final."

        For Each c As Char In edadFin
            If Not Char.IsDigit(c) And Not c = "-" Then Return "Error Fila " + _nroFila.ToString() + ". " + "La edad final sólo admite números enteros."
        Next

        If Short.Parse(edadFin) < 0 Then Return "Error Fila " + _nroFila.ToString() + ". " + "La edad final no puede ser negativa."

        Return ""
    End Function

    Private Function validarDeTipoSexoYEdadValorInicioHombres(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _nroFila As Short) As String
        Dim valorInicio As String = _referencia.valorInicio


        If valorInicio = "" Then Return "Error Fila " + _nroFila.ToString() + ". " + "Ingrese el valor inicial (HOMBRES)."

        For Each c As Char In valorInicio
            If Not Char.IsDigit(c) And Not c = "." Then Return "Error Fila " + _nroFila.ToString() + ". " + "El valor inicial (HOMBRES) sólo admite números enteros/números decimales con punto."
        Next

        Return ""
    End Function

    Private Function validarDeTipoSexoYEdadValorFinHombres(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _nroFila As Short) As String
        Dim valorFin As String = _referencia.valorFin


        If valorFin = "" Then Return "Error Fila " + _nroFila.ToString() + ". " + "Ingrese el valor final (HOMBRES)."

        For Each c As Char In valorFin
            If Not Char.IsDigit(c) And Not c = "." Then Return "Error Fila " + _nroFila.ToString() + ". " + "El valor final (HOMBRES) sólo admite números enteros/números decimales con punto."
        Next

        Return ""
    End Function

    Private Function validarDeTipoSexoYEdadValorInicioMujeres(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _nroFila As Short) As String
        Dim valorInicio As String = _referencia.valorInicio


        If valorInicio = "" Then Return "Error Fila " + _nroFila.ToString() + ". " + "Ingrese el valor inicial (MUJERES)."

        For Each c As Char In valorInicio
            If Not Char.IsDigit(c) And Not c = "." Then Return "Error Fila " + _nroFila.ToString() + ". " + "El valor inicial (MUJERES) sólo admite números enteros/números decimales con punto."
        Next

        Return ""
    End Function

    Private Function validarDeTipoSexoYEdadValorFinMujeres(ByRef _referencia As ReferenciaResultadoLaboratorioInput, _nroFila As Short) As String
        Dim valorFin As String = _referencia.valorFin


        If valorFin = "" Then Return "Error Fila " + _nroFila.ToString() + ". " + "Ingrese el valor final (MUJERES)."

        For Each c As Char In valorFin
            If Not Char.IsDigit(c) And Not c = "." Then Return "Error Fila " + _nroFila.ToString() + ". " + "El valor final (MUJERES) sólo admite números enteros/números decimales con punto."
        Next

        Return ""
    End Function


End Class


Public Class ReferenciaResultadoLaboratorioInput
    Public Property codigo As String
    Public Property tipoReferencia As ConceptoInput
    Public Property examen As ExamenLaboratorioInput
    Public Property kitequipo As KitEquipoLaboratorioInput
    Public Property valorInicio As String
    Public Property valorFin As String
    Public Property sexo As String
    Public Property edadInicio As String
    Public Property edadFin As String

    Public Sub New()
        codigo = "0"
        tipoReferencia = New ConceptoInput()
        examen = New ExamenLaboratorioInput()
        kitequipo = New KitEquipoLaboratorioInput()
        valorInicio = ""
        valorFin = ""
        sexo = ""
        edadInicio = ""
        edadFin = ""
    End Sub


End Class



