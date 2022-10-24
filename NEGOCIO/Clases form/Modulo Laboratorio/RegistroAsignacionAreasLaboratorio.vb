Imports DAL

Public Class RegistroAsignacionAreasLaboratorio

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql


    'ATRIBUTOS G1
    Public procesadores() As Usuario
    Public areas() As AreaLaboratorio
    Public areasProcesador() As AreaLaboratorio


    'ATRIBUTOS G9
    Public listaAreasRepetidas() As AreaLaboratorio
    Public listaAreasSeleccionadas() As AreaLaboratorio
    'Para verificar si todos los datos se guardaron bien
    Public listaRespuestasConfirmacion() As Int16
    Public codigoPermisoMasReciente As Short
    Public estadoInsercion As Short




    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        procesadores = New Usuario(-1) {}
        areas = New AreaLaboratorio(-1) {}
        areasProcesador = New AreaLaboratorio(-1) {}

        codigoPermisoMasReciente = 0
    End Sub


    'METODOS FUNCIONALES G1
    Public Sub traerProcesadores()
        Dim datatable As DataTable = traerProcesadoresBD(), index As Short
        procesadores = New Usuario(datatable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, codTipo As Short, apPaterno As String, apMaterno As String,
                nombres As String

            If IsDBNull(row("CODUSER USU")) Then codigo = 0 Else codigo = Long.Parse(row("CODUSER USU"))
            If IsDBNull(row("CODTIP USU")) Then codTipo = 0 Else codTipo = Short.Parse(row("CODTIP USU"))
            If IsDBNull(row("APEPAT USU")) Then apPaterno = "" Else apPaterno = row("APEPAT USU").ToString()
            If IsDBNull(row("APEMAT USU")) Then apMaterno = "" Else apMaterno = row("APEMAT USU").ToString()
            If IsDBNull(row("NOM USU")) Then nombres = "" Else nombres = row("NOM USU").ToString()

            Dim tipo As New Concepto()
            tipo.setCorrelativo(codTipo)

            Dim usuario As New Usuario()
            usuario.setCodigo(codigo)
            usuario.setTipo(tipo)
            usuario.setApellidoPaterno(apPaterno)
            usuario.setApellidoMaterno(apMaterno)
            usuario.setNombres(nombres)

            procesadores(index) = usuario
            index += 1
        Next
    End Sub

    Public Sub traerAreasLaboratorio()
        Dim datatable As DataTable = traerAreasLaboratorioBD(), index As Short
        areas = New AreaLaboratorio(datatable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODARE ARE")) Then codigo = 0 Else codigo = Long.Parse(row("CODARE ARE"))
            If IsDBNull(row("NOM ARE")) Then nombre = "" Else nombre = row("NOM ARE").ToString()

            areas(index) = New AreaLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Sub traerAreasProcesador(ByRef _usuarioProcesador As Usuario)
        Dim datatable As DataTable = traerAreasProcesadorBD(_usuarioProcesador), index As Short
        areasProcesador = New AreaLaboratorio(datatable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, nombre As String

            If IsDBNull(row("CODARE ARE")) Then codigo = 0 Else codigo = Long.Parse(row("CODARE ARE"))
            If IsDBNull(row("NOMARE ARE")) Then nombre = "" Else nombre = row("NOMARE ARE").ToString()

            areasProcesador(index) = New AreaLaboratorio(codigo, nombre)
            index += 1
        Next
    End Sub


    'METODOS FUNCIONALES G9
    Public Sub insertarPermiso(ByRef _permiso As PermisoLaboratorio)
        insertarPermisoProcesador(_permiso)
        traerCodigoPermisoMasReciente()
        asignarNuevoCodigoPermiso(_permiso)
        insertarPermisosAreas(_permiso)
        updateAntiguosPermisos(_permiso)
    End Sub

    Public Sub insertarPermisoProcesador(ByRef _permiso As PermisoLaboratorio)
        Dim respuesta As Short
        respuesta = insertarPermisoProcesadorBD(_permiso)
    End Sub

    Private Sub traerCodigoPermisoMasReciente()
        Dim datatable As DataTable = traerCodigoPermisoMasRecienteBD(), index As Short,
            codigo As Long

        index = 0
        For Each row As DataRow In datatable.Rows
            If IsDBNull(row("CODPER PER")) Then codigo = 0 Else codigo = Long.Parse(row("CODPER PER"))
        Next

        codigoPermisoMasReciente = codigo
    End Sub

    Private Sub asignarNuevoCodigoPermiso(ByRef _permiso As PermisoLaboratorio)
        _permiso.setCodigo(codigoPermisoMasReciente)
    End Sub

    Private Sub insertarPermisosAreas(ByRef _permiso As PermisoLaboratorio)
        Dim areas As AreaLaboratorio(), respuesta As Short

        areas = _permiso.getAreas()

        For Each area As AreaLaboratorio In areas
            respuesta = insertarPermisosAreasBD(_permiso.getCodigo(), area)
        Next

        estadoInsercion = respuesta
    End Sub

    Private Sub updateAntiguosPermisos(ByRef _permiso As PermisoLaboratorio)
        Dim respuesta As Short = updateAntiguosPermisosBD(_permiso)
    End Sub

    Public Function generarMensajeInsercion()
        If estadoInsercion > 0 Then Return "Las permisos se guardaron correctamente"
        If estadoInsercion < 0 Then Return "Ocurrió un error al guardar los permisos"

        Return ""
    End Function


    'METODOS BD G1
    Private Function traerProcesadoresBD() As DataTable
        Return (dal.TraerDataTable("SPtraerProcesadores_RegistrarPermisosAreasLaboratorio"))
    End Function

    Private Function traerAreasLaboratorioBD() As DataTable
        Return (dal.TraerDataTable("SPtraerAreasLab_RegistrarPermisosAreasLaboratorio"))
    End Function

    Private Function traerAreasProcesadorBD(ByRef _usuarioProcesador As Usuario) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _usuarioProcesador.getCodigo()
        Return (dal.TraerDataTable("SPtraerPermisosProcesador_RegistrarPermisosAreasLaboratorio", P))
    End Function


    'METODOS BD G9
    Private Function insertarPermisoProcesadorBD(ByRef _permiso As PermisoLaboratorio) As Short
        Dim P As Object() = New Object(1) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _permiso.getProcesador().getCodigo()

        Return dal.Ejecutar("SPregistrarPermiso_RegistrarPermisosAreasLaboratorio", P)
    End Function

    Private Function traerCodigoPermisoMasRecienteBD() As DataTable
        Return dal.TraerDataTable("SPtraerPermisoMasReciente_RegistrarPermisosAreasLaboratorio")
    End Function

    Private Function insertarPermisosAreasBD(ByRef _codigoPermiso As Long, area As AreaLaboratorio) As Short
        Dim P As Object() = New Object(1) {}
        P(0) = _codigoPermiso
        P(1) = area.getCodigo()

        Return dal.Ejecutar("SPregistrarPermisoArea_RegistrarPermisosAreasLaboratorio", P)
    End Function

    Private Function updateAntiguosPermisosBD(ByRef _permiso As PermisoLaboratorio)
        Dim P As Object() = New Object(1) {}
        P(0) = _permiso.getCodigo()
        P(1) = _permiso.getProcesador().getCodigo()

        Return dal.Ejecutar("SPquitarVigenciaAntiguosPermisos", P)
    End Function



    'METODOS VALIDAICÓN
    Public Function validarEntradas(ByRef _permiso As PermisoLaboratorioInput)
        Dim mensaje As String

        mensaje = validarProcesador(_permiso.procesador)
        If Not mensaje = "" Then Return mensaje

        mensaje = validarNroAreas(_permiso.areas)
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarProcesador(ByRef _procesador As UsuarioInput)
        If Long.Parse(_procesador.codigo) = 0 Then Return "Error. Seleccione un procesador."
        Return ""
    End Function

    Private Function validarNroAreas(ByRef _nuevasInputAreas As AreaLaboratorioInput())
        Dim nroAreas As Short

        nroAreas = _nuevasInputAreas.Count()
        If nroAreas <= 0 Then Return "Error. Debe marcar al menos un area."
        Return ""
    End Function


End Class
