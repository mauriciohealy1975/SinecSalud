Imports DAL

Public Class RegistroOrdenLaboratorio


    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public medicos As Medico()
    Public asegurados As Asegurado()


    'ATRIBUTOS G2
    Public areas As AreaLaboratorio()
    Public examenes As ExamenLaboratorio()
    Public examenesSeleccionados() As ExamenLaboratorio

    'ATRIBUTOS G9
    Public nuevoCodigoOrden As Long
    Public codigoInsercion As Short



    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G1
        medicos = New Medico(-1) {}
        asegurados = New Asegurado(-1) {}

        'ATRIBUTOS G2
        areas = New AreaLaboratorio(-1) {}
        examenes = New ExamenLaboratorio(-1) {}
        examenesSeleccionados = New ExamenLaboratorio(9) {}


        'ATRIBUTOS G9
        nuevoCodigoOrden = 0
        codigoInsercion = 0
    End Sub

    Public Sub iniciarProcesos()

    End Sub








    'METODOS FUNCIONALES G1
    Public Sub traerMedicos()
        Dim objDTable As DataTable = traerMedicosBD(), index As Int16 = 0
        medicos = New Medico(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Long, apPaterno As String, apMaterno As String, nombres As String,
                codEspecialidad As Long, nomEspecialidad As String

            If IsDBNull(row("CODMED MED")) Then codigo = 0 Else codigo = Long.Parse(row("CODMED MED"))
            If IsDBNull(row("APAMED USU")) Then apPaterno = "" Else apPaterno = row("APAMED USU").ToString()
            If IsDBNull(row("AMAMED USU")) Then apMaterno = "" Else apMaterno = row("AMAMED USU").ToString()
            If IsDBNull(row("NOMMED USU")) Then nombres = "" Else nombres = row("NOMMED USU").ToString()

            If IsDBNull(row("CODESP ESP")) Then codEspecialidad = 0 Else codEspecialidad = Long.Parse(row("CODESP ESP"))
            If IsDBNull(row("NOMESP ESP")) Then nomEspecialidad = "" Else nomEspecialidad = row("NOMESP ESP").ToString()

            Dim usuario As New Usuario()
            usuario.setApellidoPaterno(apPaterno)
            usuario.setApellidoMaterno(apMaterno)
            usuario.setNombres(nombres)

            Dim especialidad As New Especialidad()
            especialidad.setCodigo(codEspecialidad)
            especialidad.setNombre(nomEspecialidad)

            Dim medico As New Medico()
            medico.setCodigo(codigo)
            medico.setUsuario(usuario)
            medico.setEspecialidad(especialidad)

            medicos(index) = medico
            index += 1
        Next
    End Sub

    Public Sub traerAsegurados()
        Dim objDTable As DataTable = traerAseguradosBD(), index As Short = 0
        asegurados = New Asegurado(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Long, apPaterno As String, apMaterno As String, nombres As String, matricula As String, fechaNac As Date

            If IsDBNull(row("CODASE ASE")) Then codigo = 0 Else codigo = Long.Parse(row("CODASE ASE"))
            If IsDBNull(row("APEPAT ASE")) Then apPaterno = "" Else apPaterno = row("APEPAT ASE").ToString()
            If IsDBNull(row("APEMAT ASE")) Then apMaterno = "" Else apMaterno = row("APEMAT ASE").ToString()
            If IsDBNull(row("NOMASE ASE")) Then nombres = "" Else nombres = row("NOMASE ASE").ToString()
            If IsDBNull(row("MATASE ASE")) Then matricula = "" Else matricula = row("MATASE ASE").ToString()
            If IsDBNull(row("FECNACASE ASE")) Then fechaNac = Today Else fechaNac = Date.Parse(row("FECNACASE ASE"))
            If fechaNac.Year > Today.Year Then fechaNac = fechaNac.AddYears(-100)



            Dim asegurado As New Asegurado()
            asegurado.setCodigo(codigo)
            asegurado.setApellidoPaterno(apPaterno)
            asegurado.setApellidoMaterno(apMaterno)
            asegurado.setNombres(nombres)
            asegurado.setMatricula(matricula)
            asegurado.setFechaNacimiento(fechaNac)

            asegurados(index) = asegurado
            index += 1
        Next
    End Sub


    'METODOS FUNCIONALES G2
    Public Sub traerAreas()
        Dim datatable As DataTable = traerAreasBD(), index As Short = 0
        areas = New AreaLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODARE ARE")) Then codigo = 0 Else codigo = Long.Parse(row("CODARE ARE"))
            If IsDBNull(row("NOMARE ARE")) Then nombre = "" Else nombre = row("NOMARE ARE").ToString()


            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            areas(index) = New AreaLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Sub traerExamenes(ByRef _area As AreaLaboratorio)
        Dim datatable As DataTable = traerExamenesBD(_area), index As Short = 0
        examenes = New ExamenLaboratorio(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODEXA EXA")) Then codigo = 0 Else codigo = Long.Parse(row("CODEXA EXA"))
            If IsDBNull(row("NOMEXA EXA")) Then nombre = "" Else nombre = row("NOMEXA EXA").ToString()


            Dim examen As New ExamenLaboratorio()
            examen.setCodigo(codigo)
            examen.setNombre(nombre)
            examen.setArea(_area)

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            examenes(index) = New ExamenLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Sub agregarExamen(ByVal _nombreExamen As String)
        Dim oAuxExamen As ExamenLaboratorio = traerObjExamen(_nombreExamen)
        Dim index = Utilitarios.obtenerIndexPrimeraCasillaVacia(examenesSeleccionados)
        examenesSeleccionados(index) = oAuxExamen
    End Sub

    Private Function traerObjExamen(ByVal _nombreExamen As String) As ExamenLaboratorio
        For Each examen As ExamenLaboratorio In examenes
            If examen IsNot Nothing Then
                If examen.getNombre() = _nombreExamen Then
                    Return examen
                End If

            End If
        Next

        Return Nothing
    End Function

    Public Function esListaLlena() As Boolean
        For Each examen As ExamenLaboratorio In examenesSeleccionados
            If IsNothing(examen) Then Return False
        Next

        Return True
    End Function

    Public Function contarEspaciosDisponibles() As Int16
        Dim contador As Int16 = 0

        For Each examen As ExamenLaboratorio In examenesSeleccionados
            If examen Is Nothing Then
                contador += 1
            End If
        Next

        Return contador
    End Function

    Public Function revisarRepetidos(ByVal _nombreExamen As String) As Boolean
        For Each examen As ExamenLaboratorio In examenesSeleccionados
            If examen IsNot Nothing Then
                If examen.getNombre = _nombreExamen Then
                    Return True
                End If

            End If
        Next

        Return False
    End Function

    Public Sub eliminarExamen(ByVal _examenSeleccionado As String)
        Dim listaExamenesAux() As ExamenLaboratorio = New ExamenLaboratorio(9) {}
        Dim index As Int16 = 0

        For Each examen As ExamenLaboratorio In examenesSeleccionados
            If examen IsNot Nothing Then
                If Not examen.getNombre() = _examenSeleccionado Then
                    listaExamenesAux(index) = examen
                    index += 1
                End If

            End If
        Next

        examenesSeleccionados = listaExamenesAux
        listaExamenesAux = Nothing
    End Sub



    'METODOS FUNCIONALES G9
    Public Sub insertarOrden(ByRef _nuevaOrden As OrdenLaboratorio)
        Dim respuesta As Short

        insertarOrdenIndividual(_nuevaOrden)
        respuesta = insertarDetalles(_nuevaOrden.getDetalles())
        codigoInsercion = respuesta
    End Sub

    Public Sub insertarOrdenIndividual(ByRef _nuevaOrden As OrdenLaboratorio)
        Dim datatable As DataTable = insertarOrdenBD(_nuevaOrden), codigo As Long

        For Each row As DataRow In datatable.Rows
            codigo = Long.Parse(row("CODIGO ORDEN"))
        Next

        nuevoCodigoOrden = codigo
        _nuevaOrden.setCodigo(nuevoCodigoOrden)
    End Sub

    Public Function insertarDetalles(ByRef _nuevosDetalles As DetalleOrdenLaboratorio())
        Dim respuesta As Short

        For Each detalle As DetalleOrdenLaboratorio In _nuevosDetalles
            If Not IsNothing(detalle) Then respuesta = insertarDetallesBD(detalle)
        Next

        Return respuesta
    End Function

    Public Function generarMensajeInsercion() As String
        If codigoInsercion > 0 Then Return "La orden se guardó correctamente."
        If codigoInsercion < 0 Then Return "Hubo un error al guardar la orden."

        Return ""
    End Function




    'METOODOS BD G1
    Private Function traerMedicosBD() As DataTable
        Return (dal.TraerDataTable("SPtraerMedico_RegistrarOrdenLab"))
    End Function

    Private Function traerAseguradosBD() As DataTable
        Return (dal.TraerDataTable("SPtraerAsegurado_RegistrarOrdenLab"))
    End Function


    'METOODOS BD G2
    Private Function traerAreasBD() As DataTable
        Return (dal.TraerDataTable("SPtraeAreasLab_RegistrarOrdenLaboratorio"))
    End Function

    Private Function traerExamenesBD(ByRef _area As AreaLaboratorio) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _area.getCodigo()
        Return (dal.TraerDataTable("SPtraerExamenes_RegistrarOrdenLab", P))
    End Function


    'METOODOS BD G9
    Private Function insertarOrdenBD(ByRef _orden As OrdenLaboratorio) As DataTable
        Dim P As Object() = New Object(3) {}
        P(0) = _orden.getAsegurado().getMatricula()
        P(1) = _orden.getFecha()
        P(2) = _orden.getMedico().getCodigo()
        P(3) = Usuario.codUserLoggedSystem

        Return (dal.TraerDataTable("SPguardarOrden", P))
    End Function

    Private Function insertarDetallesBD(_detalleOrden As DetalleOrdenLaboratorio) As Int16
        Dim P As Object() = New Object(1) {}
        P(0) = _detalleOrden.getOrden().getCodigo()
        P(1) = _detalleOrden.getExamen().getCodigo()

        Dim respuesta As Short = dal.Ejecutar("SPguardarDetalleOrdenLab", P)
        Return respuesta
    End Function




    'METODOS VALIDACIÓN
    Public Function validarEntradas(_orden As OrdenLaboratorio) As String
        Dim mensaje As String

        mensaje = validarMedico(_orden.getMedico())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarAsegurado(_orden.getAsegurado())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarDetalles(_orden.getDetalles())
        If Not mensaje = "" Then Return mensaje


        Return ""
    End Function

    Private Function validarMedico(ByRef _medico As Medico) As String
        If _medico.getCodigo() = 0 Then Return "Error. Seleccione un medico."
        Return ""
    End Function

    Private Function validarAsegurado(ByRef _asegurado As Asegurado) As String
        If _asegurado.getCodigo() = 0 Then Return "Error. Seleccione un asegurado."
        Return ""
    End Function

    Private Function validarDetalles(ByRef _detalles As DetalleOrdenLaboratorio()) As String
        Dim nroDetalles As Short

        nroDetalles = 0

        For Each detalle As DetalleOrdenLaboratorio In _detalles
            If Not IsNothing(detalle) Then nroDetalles += 1
        Next

        If nroDetalles = 0 Then Return "Error. Debe agregue como mínuno un examen."
        Return ""
    End Function


End Class


