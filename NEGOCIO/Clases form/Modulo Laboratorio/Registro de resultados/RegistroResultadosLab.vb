Imports DAL
Imports System.Windows.Forms
Public Class RegistroResultadosLab

    'ATRIBUTOS LOGICOS 
    Private dal As TDatosSql

    'ATRBITUOS G1
    Public parametroNroDiasValidos As Parametro
    Public codigoTipoUsuario As Short
    Public tipoUsuarioValido As Boolean

    Public fechasValidas As Date()
    Public ordenes() As OrdenLaboratorio

    'ATRIBUTOS G2
    Public detalles() As DetalleOrdenLaboratorio

    'ATRIBUTOS G9
    Public estadoInsercion As Short



    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LOGICOS 
        dal = New TDatosSql(False)

        'ATRBITUOS G1
        parametroNroDiasValidos = New Parametro()
        codigoTipoUsuario = 0

        fechasValidas = New Date(-1) {}
        ordenes = New OrdenLaboratorio(-1) {}

        'ATRIBUTOS G2
        detalles = New DetalleOrdenLaboratorio(-1) {}

        'ATRIBUTOS G9
        estadoInsercion = 0
    End Sub

    Public Sub iniciarProcesos()
        traerParametroNroDiasValidosParaRegistro()
        traerCodigoTipoUsuario()
    End Sub









    'METODOS FUNCIONALES G1
    Public Sub traerParametroNroDiasValidosParaRegistro()
        Dim datatable As DataTable = traerParametrNroDiasValidosRegistroBD()
        parametroNroDiasValidos = New Parametro()


        For Each row As DataRow In datatable.Rows
            Dim codigo As Int64, codModulo As Int64, tipo As Int64, valor As Int64, descripcion As String

            If IsDBNull(row("COD PAR")) Then codigo = 0 Else codigo = Int64.Parse(row("COD PAR"))
            If IsDBNull(row("CMOD PAR")) Then codModulo = 0 Else codModulo = Int64.Parse(row("CMOD PAR"))
            If IsDBNull(row("TIPO PAR")) Then tipo = 0 Else tipo = Int64.Parse(row("TIPO PAR"))
            If IsDBNull(row("VA PAR")) Then valor = 0 Else valor = Int64.Parse(row("VA PAR"))
            If IsDBNull(row("DESC PAR")) Then descripcion = "" Else descripcion = row("DESC PAR").ToString()

            parametroNroDiasValidos.setCodigo(codigo)
            parametroNroDiasValidos.setCodigoModulo(codModulo)
            parametroNroDiasValidos.setTipo(tipo)
            parametroNroDiasValidos.setValor(valor)
            parametroNroDiasValidos.setDescripcion(descripcion)

            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

        Next
    End Sub

    Public Sub traerOrdenesPorNroOrden(_codigoOrden As Long)
        Dim datatable As DataTable = traerOrdenesPorNroOrdenBD(_codigoOrden), index As Short = 0
        ordenes = New OrdenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, fecha As Date, apPaterno As String, apMaterno As String,
                nombres As String, sexo As Char, matricula As String, fechaNac As Date

            If IsDBNull(row("COD ORD")) Then codigo = 0 Else codigo = Int64.Parse(row("COD ORD"))
            If IsDBNull(row("FEC ORD")) Then fecha = "" Else fecha = Date.Parse(row("FEC ORD"))
            If IsDBNull(row("APA AFI")) Then apPaterno = "" Else apPaterno = row("APA AFI").ToString()
            If IsDBNull(row("AMA AFI")) Then apMaterno = "" Else apMaterno = row("AMA AFI").ToString()
            If IsDBNull(row("NOM AFI")) Then nombres = "" Else nombres = row("NOM AFI").ToString()
            If IsDBNull(row("SEXO AFI")) Then sexo = "" Else sexo = row("SEXO AFI").ToString()
            If IsDBNull(row("MATRI AFI")) Then matricula = "" Else matricula = row("MATRI AFI").ToString()
            If IsDBNull(row("FENAC AFI")) Then fechaNac = "" Else fechaNac = Date.Parse(row("FENAC AFI"))


            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim asegurado As Asegurado = New Asegurado()
            asegurado.setApellidoPaterno(apPaterno)
            asegurado.setApellidoMaterno(apMaterno)
            asegurado.setNombres(nombres)
            asegurado.setSexo(sexo)
            asegurado.setMatricula(matricula)
            asegurado.setFechaNacimiento(fechaNac)

            Dim orden As OrdenLaboratorio = New OrdenLaboratorio()
            orden.setCodigo(codigo)
            orden.setFecha(fecha)
            orden.setAsegurado(asegurado)

            ordenes(index) = orden
            index += 1
        Next


    End Sub

    Public Sub traerOrdenesPorNombre(_nombreCompleto As String)
        Dim datatable As DataTable = traerOrdenesPorNombreBD(_nombreCompleto), index As Short = 0
        ordenes = New OrdenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, fecha As Date, apPaterno As String, apMaterno As String,
                nombres As String, sexo As Char, matricula As String, fechaNac As Date

            If IsDBNull(row("COD ORD")) Then codigo = 0 Else codigo = Int64.Parse(row("COD ORD"))
            If IsDBNull(row("FEC ORD")) Then fecha = "" Else fecha = Date.Parse(row("FEC ORD"))
            If IsDBNull(row("APA AFI")) Then apPaterno = "" Else apPaterno = row("APA AFI").ToString()
            If IsDBNull(row("AMA AFI")) Then apMaterno = "" Else apMaterno = row("AMA AFI").ToString()
            If IsDBNull(row("NOM AFI")) Then nombres = "" Else nombres = row("NOM AFI").ToString()
            If IsDBNull(row("SEXO AFI")) Then sexo = "" Else sexo = row("SEXO AFI").ToString()
            If IsDBNull(row("MATRI AFI")) Then matricula = "" Else matricula = row("MATRI AFI").ToString()
            If IsDBNull(row("FENAC AFI")) Then fechaNac = "" Else fechaNac = Date.Parse(row("FENAC AFI"))


            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim asegurado As Asegurado = New Asegurado()
            asegurado.setApellidoPaterno(apPaterno)
            asegurado.setApellidoMaterno(apMaterno)
            asegurado.setNombres(nombres)
            asegurado.setSexo(sexo)
            asegurado.setMatricula(matricula)
            asegurado.setFechaNacimiento(fechaNac)

            Dim orden As OrdenLaboratorio = New OrdenLaboratorio()
            orden.setCodigo(codigo)
            orden.setFecha(fecha)
            orden.setAsegurado(asegurado)

            ordenes(index) = orden
            index += 1
        Next
    End Sub

    Public Sub traerOrdenesPorFechas(_fecha As Date)
        Dim datatable As DataTable = traerOrdenesPorFechasBD(_fecha), index As Int16 = 0
        ordenes = New OrdenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Int64, fecha As Date, apPaterno As String, apMaterno As String, nombres As String, sexo As Char, matricula As String,
            fechaNac As Date

            If IsDBNull(row("COD ORD")) Then codigo = 0 Else codigo = Int64.Parse(row("COD ORD"))
            If IsDBNull(row("FEC ORD")) Then fecha = "" Else fecha = Date.Parse(row("FEC ORD"))
            If IsDBNull(row("APA AFI")) Then apPaterno = "" Else apPaterno = row("APA AFI").ToString()
            If IsDBNull(row("AMA AFI")) Then apMaterno = "" Else apMaterno = row("AMA AFI").ToString()
            If IsDBNull(row("NOM AFI")) Then nombres = "" Else nombres = row("NOM AFI").ToString()
            If IsDBNull(row("SEXO AFI")) Then sexo = "" Else sexo = row("SEXO AFI").ToString()
            If IsDBNull(row("MATRI AFI")) Then matricula = "" Else matricula = row("MATRI AFI").ToString()
            If IsDBNull(row("FENAC AFI")) Then fechaNac = "" Else fechaNac = Date.Parse(row("FENAC AFI"))


            'If IsDBNull(row("")) Then  = 0 Else  = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim asegurado As Asegurado = New Asegurado()
            asegurado.setApellidoPaterno(apPaterno)
            asegurado.setApellidoMaterno(apMaterno)
            asegurado.setNombres(nombres)
            asegurado.setSexo(sexo)
            asegurado.setMatricula(matricula)
            asegurado.setFechaNacimiento(fechaNac)

            Dim orden As OrdenLaboratorio = New OrdenLaboratorio()
            orden.setCodigo(codigo)
            orden.setFecha(fecha)
            orden.setAsegurado(asegurado)

            ordenes(index) = orden
            index += 1
        Next
    End Sub

    Public Sub generarFechas()
        Dim nroDias As Short, fechaFinal As Date, fechaInicial As Date, fechaAux As Date,
            index As Short

        nroDias = parametroNroDiasValidos.getValor()
        fechasValidas = New Date(nroDias - 1) {}
        fechaFinal = Today.Date
        fechaInicial = Today.Date.AddDays(-(nroDias - 1))
        fechaAux = fechaFinal.Date


        index = 0
        While fechaAux >= fechaInicial
            fechasValidas(index) = fechaAux
            fechaAux = fechaAux.AddDays(-1)
            index += 1
        End While
    End Sub

    Public Sub traerCodigoTipoUsuario()
        Dim datatable As DataTable = traerCodigoTipoUsuarioBD()
        Dim codigo As Long

        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("CODTIPUSU USU")) Then codigo = 0 Else codigo = Long.Parse(row("CODTIPUSU USU"))
        Next

        codigoTipoUsuario = codigo
    End Sub

    Public Sub controlaerTipoUsuarioValido()
        If codigoTipoUsuario = 3 Or codigoTipoUsuario = 4 Then tipoUsuarioValido = True Else tipoUsuarioValido = False
    End Sub


    'METODOS FUNCIONALES G2
    Public Sub traerDetalles(ByRef _orden As OrdenLaboratorio)
        Dim datatable As DataTable = traerDetallesOrdenBD(_orden), index As Int16 = 0
        detalles = New DetalleOrdenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, codOrden As Long, codExamen As Long, nomExamen As String,
                codArea As Long, nomArea As String, codSubarea As Long, nomSubarea As String,
                codTipoResultado As Short, codConjunto As Long, codUnidad As Long, nomUnidad As String,
                abrevUnidad As String

            If IsDBNull(row("CODDET DET")) Then codigo = 0 Else codigo = Long.Parse(row("CODDET DET"))
            If IsDBNull(row("CODORD DET")) Then codOrden = 0 Else codOrden = Long.Parse(row("CODORD DET"))
            If IsDBNull(row("CODEXA DET")) Then codExamen = 0 Else codExamen = Long.Parse(row("CODEXA DET"))
            If IsDBNull(row("NOMEXA EXA")) Then nomExamen = "" Else nomExamen = row("NOMEXA EXA").ToString()

            If IsDBNull(row("CODARE ARE")) Then codArea = 0 Else codArea = Long.Parse(row("CODARE ARE"))
            If IsDBNull(row("NOMARE ARE")) Then nomArea = "" Else nomArea = row("NOMARE ARE").ToString()
            If IsDBNull(row("CODSUB SUB")) Then codSubarea = 0 Else codSubarea = Long.Parse(row("CODSUB SUB"))
            If IsDBNull(row("NOMSUB SUB")) Then nomSubarea = "" Else nomSubarea = row("NOMSUB SUB").ToString()

            If IsDBNull(row("TIPRES EXA")) Then codTipoResultado = 0 Else codTipoResultado = Short.Parse(row("TIPRES EXA"))
            If IsDBNull(row("CODCONOPC EXA")) Then codConjunto = 0 Else codConjunto = Long.Parse(row("CODCONOPC EXA"))
            If IsDBNull(row("CODUNI UNI")) Then codUnidad = 0 Else codUnidad = Long.Parse(row("CODUNI UNI"))
            If IsDBNull(row("NOMUNI UNI")) Then nomUnidad = "" Else nomUnidad = row("NOMUNI UNI").ToString()

            If IsDBNull(row("ABRUNI UNI")) Then abrevUnidad = "" Else abrevUnidad = row("ABRUNI UNI").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))


            Dim area As AreaLaboratorio, subarea As SubareaLaboratorio, tipoRestulado As Concepto,
                conjunto As ConjuntoOpcionesResultadosLaboratorio, unidad As UnidadMedidaLaboratorio, examen As New ExamenLaboratorio,
                orden As OrdenLaboratorio, detalle As DetalleOrdenLaboratorio

            area = New AreaLaboratorio()
            area.setCodigo(codArea)
            area.setNombre(nomArea)

            subarea = New SubareaLaboratorio()
            subarea.setCodigo(codSubarea)
            subarea.setNombre(nomSubarea)

            tipoRestulado = New Concepto()
            tipoRestulado.setCorrelativo(codTipoResultado)

            conjunto = New ConjuntoOpcionesResultadosLaboratorio()
            conjunto.setCodigo(codConjunto)

            unidad = New UnidadMedidaLaboratorio()
            unidad.setCodigo(codUnidad)
            unidad.setNombre(nomUnidad)
            unidad.setabreviacion(abrevUnidad)

            examen = New ExamenLaboratorio()
            examen.setCodigo(codExamen)
            examen.setNombre(nomExamen)
            examen.setArea(area)
            examen.setSubarea(subarea)
            examen.setTipoResultado(tipoRestulado)
            examen.setConjuntoOpcionesResultado(conjunto)
            examen.setUnidad(unidad)

            orden = New OrdenLaboratorio()
            orden.setCodigo(codOrden)

            detalle = New DetalleOrdenLaboratorio()
            detalle.setCodigo(codigo)
            detalle.setOrden(orden)
            detalle.setExamen(examen)

            detalles(index) = detalle
            index += 1
        Next
    End Sub

    Public Sub generarListaResultados(ByRef _resultados As ResultadoLaboratorio())
        Dim index As Short

        _resultados = New ResultadoLaboratorio(detalles.Count - 1) {}
        For index = 0 To _resultados.Count() - 1
            _resultados(index) = New ResultadoLaboratorio()
        Next


        index = 0
        For Each detalle As DetalleOrdenLaboratorio In detalles
            Dim orden As OrdenLaboratorio, examen As New ExamenLaboratorio, area As AreaLaboratorio, subarea As SubareaLaboratorio, tipoRestulado As Concepto,
                conjunto As ConjuntoOpcionesResultadosLaboratorio, unidad As UnidadMedidaLaboratorio, resultado As ResultadoLaboratorio

            orden = detalle.getOrden()
            examen = detalle.getExamen()
            area = detalle.getExamen().getArea
            subarea = detalle.getExamen().getSubarea()
            tipoRestulado = detalle.getExamen().getTipoResultado()
            conjunto = detalle.getExamen().getConjuntoOpcionesResultado()
            unidad = detalle.getExamen().getUnidad()

            examen.setArea(area)
            examen.setSubarea(subarea)

            resultado = _resultados(index)
            resultado.setDetalle(detalle)
            resultado.setOrden(orden)
            resultado.setExamen(examen)
            resultado.setTipoResultado(tipoRestulado)
            resultado.setConjunto(conjunto)
            resultado.setUnidad(unidad)
            resultado.setAsignado(False)

            _resultados(index) = resultado
            index += 1
        Next
    End Sub


    'METODOS FUNCIONALES G9
    Public Sub insertarResultados(ByRef _nuevosResultados As ResultadoLaboratorio())
        Dim respuesta As Short

        For Each resultado As ResultadoLaboratorio In _nuevosResultados
            Dim asignado As Boolean

            asignado = resultado.getAsignado()
            If asignado Then respuesta = insertarResultadosBD(resultado)
        Next

        estadoInsercion = respuesta
    End Sub

    Public Function generarMensajeInsercion()
        If estadoInsercion > 0 Then Return "Las resultados se guardaron correctamente."
        If estadoInsercion < 0 Then Return "Ocurrió un error al guardar los resultados."
        Return ""
    End Function









    'METODOS BD G1
    Private Function traerCodigoTipoUsuarioBD() As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = Usuario.codUserLoggedSystem
        Return dal.TraerDataTable("SPtraerTipoUsuario_RegistrarResultadosLab", P)
    End Function

    Private Function traerParametrNroDiasValidosRegistroBD()
        Return dal.TraerDataTable("SPtraerNroDiasValidosRegistroResultados_Parametro")
    End Function

    Private Function traerOrdenesPorNroOrdenBD(_codigoOrden As Long) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codigoOrden
        Return dal.TraerDataTable("SPtraerOrdenesPorNroOrden_RegistrarResultadosLab", P)
    End Function

    Private Function traerOrdenesPorNombreBD(_nombreCompleto As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombreCompleto
        Return dal.TraerDataTable("SPtraerOrdenesPorNombre_RegistrarResultadosLab", P)
    End Function

    Private Function traerOrdenesPorFechasBD(_fecha As Date)
        Dim P As Object() = New Object(0) {}
        P(0) = _fecha
        Return (dal.TraerDataTable("SPtraerOrdenes_RegistrarResultadosLab", P))
    End Function






    'METODOS BD G2
    Private Function traerDetallesOrdenBD(ByRef _orden As OrdenLaboratorio) As DataTable
        Dim P As Object() = New Object(2) {}
        P(0) = _orden.getCodigo()
        P(1) = Usuario.codUserLoggedSystem
        P(2) = codigoTipoUsuario
        Return (dal.TraerDataTable("SPtraerDetalles_RegistrarResultadosLab", P))

    End Function

    'METODOS BD G9
    Private Function insertarResultadosBD(ByRef _resultado As ResultadoLaboratorio) As Short
        Dim P As Object() = New Object(11) {}

        P(0) = Usuario.codUserLoggedSystem
        P(1) = _resultado.getExamen().getCodigo()
        P(2) = _resultado.getDetalle.getCodigo()
        P(3) = _resultado.getOrden().getCodigo()
        P(4) = _resultado.getProcesador().getCodigo()
        P(5) = _resultado.getTipoResultado().getCorrelativo()

        'If String.IsNullOrEmpty() Then P(11) = DBNull.Value Else P(11) = _beneficiario.getNroLibro()

        Dim unidad As Long = _resultado.getUnidad().getCodigo()
        If (IsNothing(unidad) Or unidad = 0) Then P(6) = DBNull.Value Else P(6) = unidad

        Dim kitequipo As Long = _resultado.getKitEquipo().getCodigo()
        If (IsNothing(kitequipo) Or kitequipo = 0) Then P(7) = DBNull.Value Else P(7) = kitequipo

        Dim codigoReferncia As Long = _resultado.getReferencia().getCodigo()
        If (IsNothing(codigoReferncia) Or codigoReferncia = 0) Then P(8) = DBNull.Value Else P(8) = codigoReferncia

        Dim valorComun As Double = _resultado.getValorTipoComun()
        If (IsNothing(valorComun) Or valorComun = 0) Then P(9) = DBNull.Value Else P(9) = valorComun

        Dim valorOpcion As Long = _resultado.getValorTipoOpcion().getCodigo()
        If (IsNothing(valorOpcion) Or valorOpcion = 0) Then P(10) = DBNull.Value Else P(10) = valorOpcion

        Dim valorTextual As String = _resultado.getValorTipoTextual()
        If (IsNothing(valorTextual) Or valorTextual = "") Then P(11) = DBNull.Value Else P(11) = valorTextual

        Return dal.Ejecutar("SPregistrarResultado_RegistrarResultadosLab", P)
    End Function


    'METODOS VALIDACIÓN
    Public Function validarEntradas(ByRef _nuevosResultados As ResultadoLaboratorio())
        Dim mensaje As String

        mensaje = validarNroResultadosAsignados(_nuevosResultados)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarNroResultadosAsignados(ByRef _nuevosResultados As ResultadoLaboratorio()) As String
        Dim nroAsignados As Short = 0

        For Each resultado As ResultadoLaboratorio In _nuevosResultados
            Dim asginado As Boolean = resultado.getAsignado()
            If asginado Then nroAsignados += 1
        Next

        If nroAsignados <= 0 Then Return "Error. Debe registrar como mínimo un resultado."
        Return ""
    End Function

End Class
