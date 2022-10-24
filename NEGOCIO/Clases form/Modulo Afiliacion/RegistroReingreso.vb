Imports DAL
Public Class RegistroReingreso

    'INICIO
    Private objDAL As TDatosSql
    Public modoFormulario As Int16
    Public titularesDeBaja As Titular()
    Public bajaMasReciente As AvisoAfiliacion
    Public empresas As Empresa()
    Public cargosTrabajo As Concepto()
    Public programasproyectos As ProgramaProyecto()
    Public entidadesDesconcentradas As EntidadDesconcentrada()
    Public nuevoReingreso As AvisoAfiliacion

    Public Sub New()
        objDAL = New TDatosSql(False)
        modoFormulario = 1
    End Sub



    'METODOS FUNCIONALES  G1
    Public Sub traerTitularesDeBaja(ByVal _matricula As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerTitularesDeBajaBD(_matricula)
        titularesDeBaja = New Titular(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim apPaterno, apMaterno, nombres, matricula

            If IsDBNull(row("APAT TIT")) Then apPaterno = "" Else apPaterno = row("APAT TIT").ToString()
            If IsDBNull(row("AMAT TIT")) Then apMaterno = "" Else apMaterno = row("AMAT TIT").ToString()
            If IsDBNull(row("NOM TIT")) Then nombres = "" Else nombres = row("NOM TIT").ToString()
            If IsDBNull(row("MAT TIT")) Then matricula = "" Else matricula = row("MAT TIT").ToString()

            Dim titular As Titular = New Titular()
            titular.setApellidoPaterno(apPaterno)
            titular.setApellidoMaterno(apMaterno)
            titular.setNombres(nombres)
            titular.setMatricula(matricula)
            titularesDeBaja(index) = titular
            index += 1
        Next
    End Sub

    Public Sub traerBajaMasReciente(ByVal _matricula As String)
        Dim objDTable As DataTable
        objDTable = traerBajaMasRecienteBD(_matricula)

        For Each row As DataRow In objDTable.Rows
            Dim codSecuencial As Int64, tipoAviso As Char, nroAviso As Int64, matricula As String, codEmpresa As Int64,
                nomEmpresa As String, numSector As Int64, nomSector As String, nit As String, matComercio As String,
                nroPatronal As String, iniCesantia As Date, finCesantia As Date

            If IsDBNull(row("COD SEC AVI")) Then codSecuencial = 0 Else codSecuencial = Int64.Parse(row("COD SEC AVI"))
            If IsDBNull(row("TIPO AVI")) Then tipoAviso = "" Else tipoAviso = row("TIPO AVI").ToString()
            If IsDBNull(row("NRO AVI")) Then nroAviso = 0 Else nroAviso = Int64.Parse(row("NRO AVI"))
            If IsDBNull(row("MAT TIT")) Then matricula = "" Else matricula = row("MAT TIT").ToString()
            If IsDBNull(row("COD EMP")) Then codEmpresa = 0 Else codEmpresa = Int64.Parse(row("COD EMP"))
            If IsDBNull(row("NOM EMP")) Then nomEmpresa = "" Else nomEmpresa = row("NOM EMP").ToString()
            If IsDBNull(row("NIT EMP")) Then nit = "" Else nit = row("NIT EMP").ToString()
            If IsDBNull(row("MATCOMER EMP")) Then matComercio = "" Else matComercio = row("MATCOMER EMP").ToString()
            If IsDBNull(row("NROPAT EMP")) Then nroPatronal = "" Else nroPatronal = row("NROPAT EMP").ToString()
            If IsDBNull(row("NUMSEC EMP")) Then numSector = 0 Else numSector = Int64.Parse(row("NUMSEC EMP"))
            If IsDBNull(row("NOMSEC EMP")) Then nomSector = "" Else nomSector = row("NOMSEC EMP").ToString()
            If IsDBNull(row("INICES AVI")) Then iniCesantia = "" Else iniCesantia = row("INICES AVI").ToString()
            If IsDBNull(row("FINCES AVI")) Then finCesantia = "" Else finCesantia = row("FINCES AVI").ToString()

            Dim titular As Titular = New Titular(), sector As Concepto = New Concepto(),
                empresa As Empresa = New Empresa()

            titular.setMatricula(matricula)
            sector.setCorrelativo(numSector)
            sector.setDescripcion(nomSector)
            empresa.setCodigo(codEmpresa)
            empresa.setNombre(nomEmpresa)
            empresa.setNit(nit)
            empresa.setMatriculaComercio(matComercio)
            empresa.setCodigoPatronal(nroPatronal)
            empresa.setSector(sector)

            Dim aviso As AvisoAfiliacion = New AvisoAfiliacion()
            aviso.setCodigo(codSecuencial)
            aviso.setTipo(tipoAviso)
            aviso.setNroAviso(nroAviso)
            aviso.setAsegurado(titular)
            aviso.setEmpleador(empresa)
            aviso.setInicioCesantia(iniCesantia)
            aviso.setFinCesantia(finCesantia)

            bajaMasReciente = aviso
        Next
    End Sub


    'METODOS FUNCIONALES G2
    Public Sub traerEmpresas(ByVal _nomEmpresa As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerEmpresasBD(_nomEmpresa)
        empresas = New Empresa(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String, nit As String, matriculaComercio As String, nroPatronal As String,
                correlativo As Int64, descripcion As String

            If IsDBNull(row("COD EMP")) Then codigo = 0 Else codigo = Int64.Parse(row("COD EMP"))
            If IsDBNull(row("NOM EMP")) Then nombre = "" Else nombre = row("NOM EMP").ToString()
            If IsDBNull(row("NIT EMP")) Then nit = "" Else nit = row("NIT EMP").ToString()
            If IsDBNull(row("MATCOM EMP")) Then matriculaComercio = "" Else matriculaComercio = row("MATCOM EMP").ToString()
            If IsDBNull(row("NRO PATRO")) Then nroPatronal = "" Else nroPatronal = row("NRO PATRO").ToString()
            If IsDBNull(row("CORR CON")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR CON"))
            If IsDBNull(row("DESC CON")) Then descripcion = "" Else descripcion = row("DESC CON").ToString()


            Dim empresa As Empresa = New Empresa(), sector As Concepto = New Concepto()
            sector.setCorrelativo(correlativo)
            sector.setDescripcion(descripcion)

            empresa.setCodigo(codigo)
            empresa.setNombre(nombre)
            empresa.setNit(nit)
            empresa.setMatriculaComercio(matriculaComercio)
            empresa.setCodigoPatronal(nroPatronal)
            empresa.setSector(sector)

            empresas(index) = empresa
            index += 1
        Next
    End Sub

    Public Function esEmpresaPublica(ByRef _empresa As Empresa) As Boolean
        Dim sector As Concepto = _empresa.getSector()

        If sector.getCorrelativo = 1 Then
            Return True
        End If

        Return False
    End Function

    'METODOS FUNCIONALES G3
    Public Function comprobarReingresoEnCesantia()
        Dim inicioCesantia As Date = bajaMasReciente.getInicioCesantia()
        Dim finCesantia As Date = bajaMasReciente.getFinCesantia()
        Dim fechaHoy As Date = Today

        If fechaHoy >= inicioCesantia And fechaHoy <= finCesantia Then
            Return True
        End If

        Return False
    End Function

    Public Sub traerCargosTrabajo()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerCargosTrabajoBD()
        cargosTrabajo = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            Dim cargo As Concepto = New Concepto(prefijo, correlativo, descripcion)
            cargosTrabajo(index) = cargo
            index += 1
        Next
    End Sub

    Public Sub traerProgramasProyectos(ByVal _codEmpresa As Int64)
        Dim objDTable As DataTable
        objDTable = traerProgramasProyectosBD(_codEmpresa)
        programasproyectos = New ProgramaProyecto(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String, tipo As Int16, codEmpresa As Int64

            If IsDBNull(row("COD PRO")) Then codigo = 0 Else codigo = Int64.Parse(row("COD PRO"))
            If IsDBNull(row("NOM PRO")) Then nombre = "" Else nombre = row("NOM PRO").ToString()
            If IsDBNull(row("TIPO PRO")) Then tipo = 0 Else tipo = Int64.Parse(row("TIPO PRO"))
            If IsDBNull(row("COD EMP")) Then codEmpresa = 0 Else codEmpresa = Int64.Parse(row("COD EMP"))

            Dim empresa As Empresa = New Empresa()
            empresa.setCodigo(codEmpresa)

            Dim programaproyecto As ProgramaProyecto = New ProgramaProyecto()
            programaproyecto.setCodigo(codigo)
            programaproyecto.setNombre(nombre)
            programaproyecto.setTipo(tipo)
            programaproyecto.setEmpresa(empresa)

            programasproyectos(index) = programaproyecto
            index += 1
        Next
    End Sub

    Public Sub traerEntidadesDesconcentradas(ByVal _codEmpresa As Int64)
        Dim objDTable As DataTable
        objDTable = traerEntidadadesDesconcentradasBD(_codEmpresa)
        entidadesDesconcentradas = New EntidadDesconcentrada(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String, codEmpresa As Int64

            If IsDBNull(row("COD ENT")) Then codigo = 0 Else codigo = Int64.Parse(row("COD ENT"))
            If IsDBNull(row("NOM ENT")) Then nombre = "" Else nombre = row("NOM ENT").ToString()
            If IsDBNull(row("COD EMP")) Then codEmpresa = 0 Else codEmpresa = Int64.Parse(row("COD EMP"))

            Dim empresa As Empresa = New Empresa()
            empresa.setCodigo(codEmpresa)

            Dim entidad As EntidadDesconcentrada = New EntidadDesconcentrada()
            entidad.setCodigo(codigo)
            entidad.setNombre(nombre)
            entidad.setEmpresa(empresa)

            entidadesDesconcentradas(index) = entidad
            index += 1
        Next
    End Sub

    'METODOS BD G4
    Public Function registrarReingreso() As Int16
        Dim respuesta As Int16 = registrarReingresoBD()
        Return respuesta
    End Function








    'METODOS BD G1
    Private Function traerTitularesDeBajaBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerTitularesDeBaja_RegistrarReingreso", P)
    End Function


    Private Function traerBajaMasRecienteBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerBajaMasReciente_RegistrarReingreso", P)
    End Function

    'METODOS BD G2
    Private Function traerEmpresasBD(ByVal _nomEmpresa As String)
        Dim P As Object() = New Object(0) {}
        P(0) = _nomEmpresa
        Return objDAL.TraerDataTable("SPtraerEmpresas_RegistrarReingreso", P)
    End Function

    'METODOS BD G3
    Private Function traerCargosTrabajoBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerCargosTrabajo_Concepto")
    End Function

    Private Function traerProgramasProyectosBD(ByVal _codEmpresa As Int64) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codEmpresa
        Return objDAL.TraerDataTable("SPtraerProgramaProyecto_RegistrarReingreso", P)
    End Function

    Private Function traerEntidadadesDesconcentradasBD(ByVal _codEmpresa As Int64) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codEmpresa
        Return objDAL.TraerDataTable("SPtraerEntidadesDesconcentradas_RegistrarReingreso", P)
    End Function

    'METODOS BD G4
    Private Function registrarReingresoBD()
        Dim empresa As Empresa = nuevoReingreso.getEmpleador(),
            programaproyecto As ProgramaProyecto = nuevoReingreso.getProgramaProyecto(),
            entidad As EntidadDesconcentrada = nuevoReingreso.getEntidadDesconcentrada()


        Dim P As Object() = New Object(14) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = nuevoReingreso.getAsegurado().getMatricula()
        P(2) = empresa.getCodigo()

        If String.IsNullOrEmpty(empresa.getNit()) Then P(3) = DBNull.Value Else P(3) = empresa.getNit()
        If String.IsNullOrEmpty(empresa.getMatriculaComercio()) Then P(4) = DBNull.Value Else P(4) = empresa.getMatriculaComercio()
        If String.IsNullOrEmpty(empresa.getCodigoPatronal()) Then P(5) = DBNull.Value Else P(5) = empresa.getCodigoPatronal()

        P(6) = nuevoReingreso.getFechaContratacion()
        P(7) = nuevoReingreso.getCargo().getCorrelativo()
        P(8) = nuevoReingreso.getSalario()
        P(9) = nuevoReingreso.getTipoContratacion()

        If IsNothing(programaproyecto) Then P(10) = DBNull.Value Else P(10) = programaproyecto.getCodigo()
        If IsNothing(entidad) Then P(11) = DBNull.Value Else P(11) = entidad.getCodigo()

        P(12) = nuevoReingreso.getFechaPresentacion()
        P(13) = nuevoReingreso.getReingresoEnCesantia()
        P(14) = nuevoReingreso.getAnteriorEmpleador().getCodigo()

        Dim respuesta As Int16 = 0
        respuesta = objDAL.Ejecutar("SPRegistrarAvisoReingreso_RegistrarReingreso", P)
        Return respuesta
    End Function







    'METODOS DE VALIDACIÓN
    Public Function validarEntradas()
        Dim aviso As AvisoAfiliacion = nuevoReingreso, mensaje As String = ""

        mensaje = validarTitular(aviso.getAsegurado())
        If Not mensaje = "" Then Return mensaje


        mensaje = validarEmpleador(aviso.getEmpleador())
        If Not mensaje = "" Then Return mensaje


        mensaje = validarFechaContratacion(aviso.getFechaContratacion())
        If Not mensaje = "" Then Return mensaje


        mensaje = validarCargo(aviso.getCargo())
        If Not mensaje = "" Then Return mensaje


        mensaje = validarSalario(aviso.getSalario())
        If Not mensaje = "" Then Return mensaje


        mensaje = validarTipoContratacion(aviso.getTipoContratacion())
        If Not mensaje = "" Then Return mensaje


        Dim publica As Boolean = aviso.getEmpleador().esPublica()
        If publica Then
            mensaje = validarInformacionEmpresaPublica(aviso.getProgramaProyecto(), aviso.getEntidadDesconcentrada())
            If Not mensaje = "" Then Return mensaje
        End If


        mensaje = validarFechaDePresenetacion(aviso.getFechaPresentacion())
        If Not mensaje = "" Then Return mensaje


        Return ""
    End Function

    Private Function validarTitular(ByRef _titular As Titular) As String
        If _titular Is Nothing Then Return "Error. Seleccione un titular."

        Return ""
    End Function

    Private Function validarEmpleador(ByRef _empleador As Empresa) As String
        If _empleador Is Nothing Then Return "Error. Seleccione un empleador."

        Return ""
    End Function

    Private Function validarFechaContratacion(ByVal _fechaContratacion As Date) As String
        If _fechaContratacion.Date > Date.Today Then Return "Error. La fecha de contratación no puede ser mayor a la fecha actual."

        Return ""
    End Function

    Private Function validarCargo(ByRef _cargo As Concepto)
        If _cargo Is Nothing Then Return "Error. Seleccione un cargo."

        Return ""
    End Function

    Private Function validarSalario(ByVal _salario As Decimal)
        If _salario = 0 Then Return "Error. Ingrese un salario."

        If _salario < 0 Then Return "Error. El salario no puede ser menor a 0."

        Return ""
    End Function

    Private Function validarTipoContratacion(ByVal _tipoContratacion As Int16) As String
        If _tipoContratacion = 0 Or IsNothing(_tipoContratacion) Then Return "Error. Seleccione el tipo de contratacion."

        Return ""
    End Function

    Private Function validarInformacionEmpresaPublica(ByRef _progproyecto As ProgramaProyecto, ByRef _entidad As EntidadDesconcentrada)
        If _progproyecto Is Nothing And _entidad Is Nothing Then Return "Error. Seleccione un Programa/Proyecto o una Entidad Desconcentrada."

        Return ""
    End Function

    Private Function validarFechaDePresenetacion(ByVal _fechaPresentacion As Date) As String
        If _fechaPresentacion.Date > Today.Date Then Return "Error. La fecha de presentación no puede ser mayor a la fecha actual."

        Return ""
    End Function


End Class






























