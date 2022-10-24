Imports DAL
Public Class RegistroProcesoAvisoAsignacionesFamiliares

    'ATRIBUTOS LOGICOS
    Private objDAL As TDatosSql

    'ATRIBUTOS G1
    Public filtrosFecha As Concepto()
    Public avisosAsignaciones As AvisoAsignacionesFamiliares()

    'ATRIBUTOS G3
    Public parentescos As Concepto()
    Public estados As Concepto()


    Public Sub New()
        objDAL = New TDatosSql(False)
        filtrosFecha = Nothing
        avisosAsignaciones = Nothing
        parentescos = Nothing
        estados = Nothing
    End Sub





    'METDOS FUNCIONALES G1
    Public Sub traerAvisos(ByVal _opcion As Int16)
        Dim objDTable As DataTable = traerAvisosBD(_opcion), index As Int16 = 0
        avisosAsignaciones = New AvisoAsignacionesFamiliares(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, matriculaBe As String, apPaternoBe As String, apMaternoBe As String,
                nombresBe As String, fecNacimientoBe As Date, matriculaTitular As String, apPaternoTit As String,
                apMaternoTit As String, nombresTit As String, fecAsignacion As Date, natalidad As Int64,
                lactancia As Int64, codProceso As Int16, descProceso As String, fechaFin As Date,
                nomEmpresa As String, nomProgramaProyecto As String

            If IsDBNull(row("COD AVI")) Then codigo = 0 Else codigo = Int64.Parse(row("COD AVI"))
            If IsDBNull(row("MABE AVI")) Then matriculaBe = "" Else matriculaBe = row("MABE AVI").ToString()
            If IsDBNull(row("APA BEN")) Then apPaternoBe = "" Else apPaternoBe = row("APA BEN").ToString()
            If IsDBNull(row("AMA BEN")) Then apMaternoBe = "" Else apMaternoBe = row("AMA BEN").ToString()
            If IsDBNull(row("NOM BEN")) Then nombresBe = "" Else nombresBe = row("NOM BEN").ToString()
            If IsDBNull(row("FENABE AVI")) Then fecNacimientoBe = "" Else fecNacimientoBe = Date.Parse(row("FENABE AVI"))

            If IsDBNull(row("MATI AVI")) Then matriculaTitular = "" Else matriculaTitular = row("MATI AVI").ToString()
            If IsDBNull(row("APA TIT")) Then apPaternoTit = "" Else apPaternoTit = row("APA TIT").ToString()
            If IsDBNull(row("APA TIT")) Then apMaternoTit = "" Else apMaternoTit = row("APA TIT").ToString()
            If IsDBNull(row("NOM TIT")) Then nombresTit = "" Else nombresTit = row("NOM TIT").ToString()

            If IsDBNull(row("FEASI AVI")) Then fecAsignacion = "" Else fecAsignacion = Date.Parse(row("FEASI AVI"))
            If IsDBNull(row("ASNA AVI")) Then natalidad = 0 Else natalidad = Int64.Parse(row("ASNA AVI"))
            If IsDBNull(row("ASLA AVI")) Then lactancia = 0 Else lactancia = Int64.Parse(row("ASLA AVI"))

            If IsDBNull(row("COPRO AVI")) Then codProceso = 0 Else codProceso = Int64.Parse(row("COPRO AVI"))
            If IsDBNull(row("DEPRO CON")) Then descProceso = "" Else descProceso = row("DEPRO CON").ToString()
            If IsDBNull(row("FEFIN AVI")) Then fechaFin = "" Else fechaFin = Date.Parse(row("FEFIN AVI"))

            If IsDBNull(row("NOEM EMP")) Then nomEmpresa = "" Else nomEmpresa = row("NOEM EMP").ToString()
            If IsDBNull(row("NOMPRO PROPROY")) Then nomProgramaProyecto = "" Else nomProgramaProyecto = row("NOMPRO PROPROY").ToString()



            'If IsDBNull(row("")) Then =  Else = Int64.Parse(row(""))
            'If IsDBNull(row("")) Then =  Else = row("").ToString()
            'If IsDBNull(row("")) Then = Else = Date.Parse(row("")) 

            Dim bnf As Beneficiario = New Beneficiario()
            bnf.setMatricula(matriculaBe)
            bnf.setApellidoPaterno(apPaternoBe)
            bnf.setApellidoMaterno(apMaternoBe)
            bnf.setNombres(nombresBe)
            bnf.setFechaNacimiento(fecNacimientoBe)

            Dim titular As Titular = New Titular()
            titular.setMatricula(matriculaTitular)
            titular.setApellidoPaterno(apPaternoTit)
            titular.setApellidoMaterno(apMaternoTit)
            titular.setNombres(nombresTit)

            Dim proceso As Concepto = New Concepto()
            proceso.setCorrelativo(codProceso)
            proceso.setDescripcion(descProceso)

            Dim empresa As Empresa = New Empresa()
            empresa.setNombre(nomEmpresa)

            Dim programaproyecto As ProgramaProyecto = New ProgramaProyecto()
            programaproyecto.setNombre(nomProgramaProyecto)

            Dim aviso As AvisoAsignacionesFamiliares = New AvisoAsignacionesFamiliares()
            aviso.setCodigo(codigo)
            aviso.setBeneficiario(bnf)
            aviso.setTitular(titular)
            aviso.setFechaAsignacion(fecAsignacion)
            aviso.setNatalidad(natalidad)
            aviso.setLactancia(lactancia)
            aviso.setEstado(proceso)
            aviso.setFechaFinAsignacion(fechaFin)
            aviso.setEmpresa(empresa)
            aviso.setProgramaProyecto(programaproyecto)

            avisosAsignaciones(index) = aviso
            index += 1
        Next
    End Sub

    Public Sub traerFiltrosPorFecha()
        Dim objDTable As DataTable = traerFiltrosPorFechaBD(), index As Int16 = 0
        filtrosFecha = New Concepto(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            filtrosFecha(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub


    'METDOS FUNCIONALES G3
    Public Sub traerParentescos()
        Dim objDTable As DataTable = traerParentescoBD(), index As Int16 = 0
        parentescos = New Concepto(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            parentescos(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Sub traerEstadosAviso()
        Dim objDTable As DataTable = traerEstadosAvisoBD(), index As Int16 = 0
        estados = New Concepto(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            estados(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub


    'METDOS FUNCIONALES G4
    Public Function updateAviso(ByVal _nombreFormulario As String, ByRef _aviso As AvisoAsignacionesFamiliares) As Int16
        Dim respuesta As Int16 = updateAvisoBD(_nombreFormulario, _aviso)
        Return respuesta
    End Function










    'METODOS BD G1
    Private Function traerFiltrosPorFechaBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerFiltrosPorFecha_Concepto")
    End Function

    Private Function traerAvisosBD(ByVal _opcion As Int16) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _opcion
        Return objDAL.TraerDataTable("SPtraerAvisos_ProcesarAvisosAsgFam", P)
    End Function


    'METODOS BD G3
    Private Function traerParentescoBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerParentescoDeAvisosAsigFam_Concepto")
    End Function

    Private Function traerEstadosAvisoBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerEstadosAvisoAsigFam_Concepto")
    End Function


    'METODOS BD G4
    Private Function updateAvisoBD(ByVal _nombreFormulario As String, ByRef _aviso As AvisoAsignacionesFamiliares) As Int16
        Dim P As Object() = New Object(7) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _nombreFormulario
        P(2) = _aviso.getEstado().getCorrelativo()
        P(3) = _aviso.getFechaProceso()

        If String.IsNullOrEmpty(_aviso.getNombreEjecutor()) Then P(4) = DBNull.Value Else P(4) = _aviso.getNombreEjecutor()
        If String.IsNullOrEmpty(_aviso.getCiEjecutor()) Then P(5) = DBNull.Value Else P(5) = _aviso.getCiEjecutor()
        If _aviso.getParentescoEjecutor().getCorrelativo() = 0 Then P(6) = DBNull.Value Else P(6) = _aviso.getParentescoEjecutor().getCorrelativo()

        P(7) = _aviso.getCodigo()

        Dim respuesta As Int16 = objDAL.Ejecutar("SPprocesarAviso_ProcesarAvisoAsigFam", P)
        Return respuesta
    End Function








    'METODOS VALIDACIÓN
    Public Function validarEntradas(ByRef _avisoAsigFam As AvisoAsignacionesFamiliares) As String
        Dim mensaje As String = ""

        mensaje = validarAvisoSeleccionado(_avisoAsigFam)
        If Not mensaje = "" Then Return mensaje


        Dim estado As Int16 = _avisoAsigFam.getEstado().getCorrelativo()

        If Not estado = 3 Then
            mensaje = validarNombreEjecutor(_avisoAsigFam.getNombreEjecutor())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarCiEjecutor(_avisoAsigFam.getCiEjecutor())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarParentesco(_avisoAsigFam.getParentescoEjecutor())
            If Not mensaje = "" Then Return mensaje

            mensaje = validarEstado(_avisoAsigFam.getEstado())
            If Not mensaje = "" Then Return mensaje
        End If

        Return ""
    End Function

    Private Function validarAvisoSeleccionado(ByRef _aviso As AvisoAsignacionesFamiliares) As String
        If _aviso.getCodigo = 0 Then Return "Error. Seleccione un aviso para procesar." Else Return ""
    End Function

    Private Function validarNombreEjecutor(ByVal _nombreEjecutor As String) As String
        If _nombreEjecutor = "" Then Return "Error. Ingrese el nombre del ejecutor." Else Return ""
    End Function

    Private Function validarCiEjecutor(ByVal _ciEjecutor As String) As String
        If _ciEjecutor = "" Then Return "Error. Ingrese el ci del ejecutor." Else Return ""
    End Function

    Private Function validarParentesco(ByRef _parentesco As Concepto) As String
        If _parentesco.getPrefijo() = 0 Then Return "Error. Seleccione un parentesco." Else Return ""
    End Function

    Private Function validarEstado(ByRef _estado As Concepto) As String
        If _estado.getPrefijo() = 0 Then Return "Error. Seleccione un estado." Else Return ""
    End Function





End Class
