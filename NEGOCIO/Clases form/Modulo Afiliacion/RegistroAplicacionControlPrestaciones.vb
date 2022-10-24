Imports DAL
Public Class RegistroAplicacionControlPrestaciones
    Private objDAL As TDatosSql
    Public modoFormulario As Int16
    Public gruposCP As GrupoControlPrestaciones()
    Public controlesPrestaciones As ControlPrestaciones()
    Public titulares As Titular()
    Public beneficiarios As Beneficiario()
    Public empresas As Empresa()
    Public nuevaAplicacionCP As AplicacionControlPrestaciones
    Public detalles As DetalleControlPrestaciones()
    Public Sub New()
        objDAL = New DAL.TDatosSql(False)
        nuevaAplicacionCP = Nothing
        modoFormulario = 1
    End Sub


    'METODOS FUNCIONALES G1
    Public Sub traerGruposControlPrestaciones()
        Dim objDTable As DataTable = traerGruposControlPrestacionesBD()
        gruposCP = New GrupoControlPrestaciones(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String

            If IsDBNull(row("COD GRU")) Then codigo = 0 Else codigo = Int64.Parse(row("COD GRU"))
            If IsDBNull(row("NOM GRU")) Then nombre = "" Else nombre = row("NOM GRU").ToString()

            gruposCP(index) = New GrupoControlPrestaciones(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Sub traerControlesPrestaciones(ByVal _codGrupo As Int64)
        Dim objDTable As DataTable = traerControlesPrestacionesBD(_codGrupo)
        controlesPrestaciones = New ControlPrestaciones(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String, codigoGrupo As Int64

            If IsDBNull(row("COD TIP")) Then codigo = 0 Else codigo = Int64.Parse(row("COD TIP"))
            If IsDBNull(row("NOM TIP")) Then nombre = "" Else nombre = row("NOM TIP").ToString()
            If IsDBNull(row("COD GRU")) Then codigoGrupo = 0 Else codigoGrupo = Int64.Parse((row("COD GRU")))

            controlesPrestaciones(index) = New ControlPrestaciones(codigo, nombre, codigoGrupo)
            index += 1
        Next
    End Sub

    Public Sub traerTitulares(ByVal _matricula As String)
        Dim objDTable As DataTable = traerTitularesBD(_matricula)
        titulares = New Titular(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, apPaterno As String, apMaterno As String, nombres As String, matricula As String

            If IsDBNull(row("COD TIT")) Then codigo = 0 Else codigo = Int64.Parse(row("COD TIT"))
            If IsDBNull(row("APA TIT")) Then apPaterno = "" Else apPaterno = row("APA TIT").ToString()
            If IsDBNull(row("AMAT TIT")) Then apMaterno = "" Else apMaterno = row("AMAT TIT").ToString()
            If IsDBNull(row("NOM TIT")) Then nombres = "" Else nombres = row("NOM TIT").ToString()
            If IsDBNull(row("MAT TIT")) Then matricula = "" Else matricula = row("MAT TIT").ToString()

            titulares(index) = New Titular(codigo, apPaterno, apMaterno, nombres, matricula)
            index += 1
        Next
    End Sub

    Public Sub traerBeneficiarios(ByVal _matricula As String)
        Dim objDTable As DataTable = traerBenficiariosBD(_matricula)
        beneficiarios = New Beneficiario(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, apPaterno As String, apMaterno As String, nombres As String, matricula As String,
                codParentesco As Int64, nomParentesco As String

            If IsDBNull(row("COD BEN")) Then codigo = 0 Else codigo = Int64.Parse(row("COD BEN"))
            If IsDBNull(row("APA BEN")) Then apPaterno = "" Else apPaterno = row("APA BEN").ToString()
            If IsDBNull(row("AMAT BEN")) Then apMaterno = "" Else apMaterno = row("AMAT BEN").ToString()
            If IsDBNull(row("NOM BEN")) Then nombres = "" Else nombres = row("NOM BEN").ToString()
            If IsDBNull(row("MAT BEN")) Then matricula = "" Else matricula = row("MAT BEN").ToString()
            If IsDBNull(row("PARE BEN")) Then codParentesco = 0 Else codParentesco = Int64.Parse(row("PARE BEN"))
            If IsDBNull(row("DES CONC")) Then nomParentesco = "" Else nomParentesco = row("DES CONC").ToString()

            Dim parentesco As Concepto = New Concepto()
            parentesco.setCorrelativo(codParentesco)
            parentesco.setDescripcion(nomParentesco)

            Dim beneficiario As Beneficiario = New Beneficiario(codigo, apPaterno, apMaterno, nombres, matricula)
            beneficiario.setParentesco(parentesco)

            beneficiarios(index) = beneficiario
            index += 1
        Next
    End Sub

    Public Sub traerEmpresas(ByVal _nombre As String)
        Dim objDTable As DataTable = traerEmpresasBD(_nombre)
        empresas = New Empresa(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String

            If IsDBNull(row("COD EMP")) Then codigo = 0 Else codigo = Int64.Parse(row("COD EMP"))
            If IsDBNull(row("NOM EMP")) Then nombre = "" Else nombre = row("NOM EMP").ToString()

            empresas(index) = New Empresa(codigo, nombre)
            index += 1
        Next

    End Sub

    Public Sub traerDetalles(ByVal _codigoCP As Int64)
        Dim objDTable As DataTable = traerDetallesBD(_codigoCP)
        detalles = New DetalleControlPrestaciones(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String

            If IsDBNull(row("COD DET")) Then codigo = 0 Else codigo = Int64.Parse(row("COD DET"))
            If IsDBNull(row("NOM DET")) Then nombre = "" Else nombre = row("NOM DET").ToString()

            detalles(index) = New DetalleControlPrestaciones(codigo, nombre)
            index += 1
        Next
    End Sub



    'METODOS FUNCIONALES G3
    Public Function insertarAplicacionCP() As Int16
        Dim respuesta As Int16 = insertarAplicacionCPBD()
        Return respuesta
    End Function










    'METODOS BD G1
    Private Function traerGruposControlPrestacionesBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerGruposControlPrestaciones_RegistrarAsignacionControlPrestaciones"))
    End Function

    Private Function traerControlesPrestacionesBD(ByVal _codigoGrupo As Int64) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codigoGrupo
        Return objDAL.TraerDataTable("SPtraerControlPrestacioness_RegistrarAplicacionCP", P)

    End Function

    Private Function traerTitularesBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerTitulares_RegistrarAsignacionCP", P)
    End Function

    Private Function traerBenficiariosBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerBeneficiarios_RegistrarAsignacionCP", P)
    End Function

    Private Function traerEmpresasBD(ByVal _nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre
        Return objDAL.TraerDataTable("SPtraerEmpresas_RegistrarAsignacionCP", P)
    End Function

    Private Function traerDetallesBD(ByVal _codigoCP As Int64) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codigoCP
        Return objDAL.TraerDataTable("SPtraerDetalleCP_RegistrarAplicacionCP", P)
    End Function


    'METODOS BD G3
    Private Function insertarAplicacionCPBD() As Int16
        Dim relacion As Int64 = 0, tipo As String = nuevaAplicacionCP.getTipo()
        If tipo = "B" Then relacion = nuevaAplicacionCP.getBeneficiario.getParentesco().getCorrelativo()


        Dim P As Object() = New Object(7) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = nuevaAplicacionCP.getTipo()
        P(2) = nuevaAplicacionCP.getControlPrestaciones.getCodigo()
        P(3) = nuevaAplicacionCP.getCodigoReceptor()
        If relacion = 0 Then P(4) = DBNull.Value Else P(4) = relacion
        P(5) = nuevaAplicacionCP.getFecha()
        P(6) = nuevaAplicacionCP.getVigencia()
        P(7) = nuevaAplicacionCP.getFechaLimiteAtencion()

        Dim respuesta As Int16 = objDAL.Ejecutar("SPregistrarAplicacionCP_RegistrarAsignacionCP", P)
        Return respuesta
    End Function








    'METODOS VALIDACIÓN
    Public Function validarEntradas() As String
        Dim mensaje As String

        mensaje = validarTipoAplicacionCP(nuevaAplicacionCP.getTipo())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarReceptor(nuevaAplicacionCP.getCodigoReceptor())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarControlPrestaciones(nuevaAplicacionCP.getControlPrestaciones())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarFechaLimiteAtencion(nuevaAplicacionCP.getFechaLimiteAtencion())
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarTipoAplicacionCP(ByRef _tipoAplicacionCP As Char) As String
        If Not _tipoAplicacionCP = "T" And Not _tipoAplicacionCP = "B" And Not _tipoAplicacionCP = "E" Then Return "Error. Seleccione el grupo de control de prestaciones." Else Return ""
    End Function

    Private Function validarControlPrestaciones(ByRef _controlPrestaciones As ControlPrestaciones) As String
        If _controlPrestaciones Is Nothing Then Return "Error. Seleccione un control de prestaciones." Else Return ""
    End Function

    Private Function validarReceptor(ByVal _codigoReceptor As Int64) As String
        Dim tipoAplicacion As Char = nuevaAplicacionCP.getTipo()

        If _codigoReceptor = 0 Or IsNothing(_codigoReceptor) Then
            If tipoAplicacion = "T" Then Return "Error. Seleccione un titular." Else 
            If tipoAplicacion = "B" Then Return "Error. Seleccione un beneficiario." Else 
            If tipoAplicacion = "E" Then Return "Error. Seleccione una empresa."
        End If

        Return ""
    End Function

    Private Function validarFechaLimiteAtencion(ByVal _fechaLimiteAtencion As Date) As String
        If _fechaLimiteAtencion.Date < Date.Today.Date Then Return "Error. La fecha límite de atención no puede ser menor a la fcha actual." Else Return ""
    End Function














    '[MODO EDITAR] ATRIBUTOS
    Public edAplicacionCPMasReciente As AplicacionControlPrestaciones
    Public edNuevaAplicacionCP As AplicacionControlPrestaciones



    '[MODO EDITAR] METODOS FUNCIONALES

    Public Sub edTraerAplicacionCPMasReciente(ByVal _tipo As Char, ByVal _codReceptor As Int64)
        Dim objDTable As DataTable = edTraerAplicacionCPMasRecienteBD(_tipo, _codReceptor)

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, vigencia As Int16, codigoCP As Int64, nombreCP As String, fechaLimite As Date

            If IsDBNull(row("COD APL")) Then codigo = 0 Else codigo = Int64.Parse(row("COD APL"))
            If IsDBNull(row("VIG APL")) Then vigencia = 0 Else vigencia = Int64.Parse(row("VIG APL"))
            If IsDBNull(row("COD CP")) Then codigoCP = 0 Else codigoCP = Int64.Parse(row("COD CP"))
            If IsDBNull(row("NOM CP")) Then nombreCP = "" Else nombreCP = row("NOM CP").ToString()
            If IsDBNull(row("FECLIM APL")) Then fechaLimite = "" Else fechaLimite = row("FECLIM APL").ToString()


            Dim cpAux As ControlPrestaciones = New ControlPrestaciones()
            cpAux.setCodigo(codigoCP)
            cpAux.setNombre(nombreCP)

            edAplicacionCPMasReciente = New AplicacionControlPrestaciones()
            edAplicacionCPMasReciente.setCodigo(codigo)
            edAplicacionCPMasReciente.setVigencia(vigencia)
            edAplicacionCPMasReciente.setControlPrestaciones(cpAux)
            edAplicacionCPMasReciente.setFechaLimiteAtencion(fechaLimite)
        Next
    End Sub

    Public Function edRevisarExisteAplicacionCPAnterior() As Boolean
        If edAplicacionCPMasReciente IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function edAcutalizarVigenciaAplicacionCP(ByVal _nombreForm As String) As Int16
        Dim respuesta As Int16 = edActualizarVigenciaAplicacionCPBD(_nombreForm)
        Return respuesta
    End Function



    '[MODO EDITAR] METODOS BD
    Private Function edTraerAplicacionCPMasRecienteBD(ByVal _tipo As Char, ByVal _codReceptor As Int64) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _tipo
        P(1) = _codReceptor
        Return objDAL.TraerDataTable("SPtraerAplicacionCP_RegistrarAplicacionCPED", P)
    End Function

    Private Function edActualizarVigenciaAplicacionCPBD(ByVal _nombreFormulario As String)
        Dim P As Object() = New Object(3) {}

        P(0) = Usuario.codUserLoggedSystem
        P(1) = _nombreFormulario
        P(2) = edNuevaAplicacionCP.getVigencia()
        P(3) = edNuevaAplicacionCP.getCodigo()


        Return objDAL.Ejecutar("SPeditarVigenciaAplicacionCP_RegistrarAplicacionCPED", P)
    End Function

End Class



