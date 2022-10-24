Imports DAL

Public Class RegistroBaja

    'INICIO
    Private objDAL As TDatosSql
    Public modoFormulario As Int16
    Public titulares As Titular()
    Public avisoMasReciente As AvisoAfiliacion
    Public cargosLaborales As Concepto()
    Public motivosBaja As Concepto()
    Public nuevoAvisoBaja As AvisoAfiliacion
    Public Sub New()
        objDAL = New TDatosSql(False)
        modoFormulario = 1
    End Sub





    'METODOS FUNCIONALES G1
    Public Sub traerTitulares(ByVal _matricula As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerTitularesBD(_matricula)
        titulares = New Titular(objDTable.Rows.Count - 1) {}

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
            titulares(index) = titular
            index += 1
        Next
    End Sub

    Public Sub traerAltaReingresoMasReciente(ByVal _matricula As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerAltaReingresoMasRecienteBD(_matricula)
        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, tipo As Char, nroAviso As Int64, matricula As String, apPaterno As String, apMaterno As String,
                nombres As String, codEmpresa As Int64, nomEmpresa As String

            If IsDBNull(row("COD AVI")) Then codigo = 0 Else codigo = Int64.Parse(row("COD AVI"))
            If IsDBNull(row("TIPO AVI")) Then tipo = "" Else tipo = row("TIPO AVI").ToString()
            If IsDBNull(row("NRO AVI")) Then nroAviso = 0 Else nroAviso = Int64.Parse(row("NRO AVI"))
            If IsDBNull(row("MAT TIT")) Then matricula = "" Else matricula = row("MAT TIT").ToString()
            If IsDBNull(row("APA TIT")) Then apPaterno = "" Else apPaterno = row("APA TIT").ToString()
            If IsDBNull(row("AMA TIT")) Then apMaterno = "" Else apMaterno = row("AMA TIT").ToString()
            If IsDBNull(row("NOM TIT")) Then nombres = "" Else nombres = row("NOM TIT").ToString()
            If IsDBNull(row("COD EMP")) Then codEmpresa = 0 Else codEmpresa = Int64.Parse(row("COD EMP"))
            If IsDBNull(row("NOM EMP")) Then nomEmpresa = "" Else nomEmpresa = row("NOM EMP").ToString()

            Dim aviso As AvisoAfiliacion = New AvisoAfiliacion(),
                titular As Titular = New Titular(),
                empresa As Empresa = New Empresa()

            titular.setMatricula(matricula)
            titular.setApellidoPaterno(apPaterno)
            titular.setApellidoMaterno(apMaterno)
            titular.setNombres(nombres)
            empresa.setCodigo(codEmpresa)
            empresa.setNombre(nomEmpresa)


            aviso.setCodigo(codEmpresa)
            aviso.setTipo(tipo)
            aviso.setNroAviso(nroAviso)
            aviso.setAsegurado(titular)
            aviso.setEmpleador(empresa)
            avisoMasReciente = aviso
        Next
    End Sub



    'METODOS FUNCIONALES G2
    Public Sub traerCargos()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerCargoBD()
        cargosLaborales = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            Dim cargo As Concepto = New Concepto(prefijo, correlativo, descripcion)
            cargosLaborales(index) = cargo
            index += 1
        Next
    End Sub

    Public Sub traerMotivosBaja()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerMotivosBajaBD()
        motivosBaja = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            Dim motivo As Concepto = New Concepto(prefijo, correlativo, descripcion)
            motivosBaja(index) = motivo
            index += 1
        Next
    End Sub



    'METODOS FUNCIONALES G6
    Public Function insertarAviso() As Int16
        Dim respuesta As Int16 = insertarAvisoBD()
        Return respuesta
    End Function






    'METODOS BD G1
    Private Function traerTitularesBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerTitulares_RegistrarBaja", P)
    End Function

    Private Function traerAltaReingresoMasRecienteBD(ByVal _matricula As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return objDAL.TraerDataTable("SPtraerAltaReingresoMasReciente_RegistrarBaja", P)
    End Function

    'METODOS BD G2
    Private Function traerCargoBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerCargosTrabajo")
    End Function

    Private Function traerMotivosBajaBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerMotivoBaja_Concepto")
    End Function


    'METODOS BD G6
    Public Function generarPeriodoCesantia(ByVal _fechaBaja As Date) As Date()
        Dim periodoCesantia As Date() = New Date(1) {}

        Dim inicioCesantia As Date = _fechaBaja.AddDays(1)
        Dim finCesantia As Date = _fechaBaja.AddDays(60)

        periodoCesantia(0) = inicioCesantia
        periodoCesantia(1) = finCesantia

        Return periodoCesantia
    End Function

    Private Function insertarAvisoBD() As Int16
        Dim P As Object() = New Object(9) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = nuevoAvisoBaja.getAsegurado().getMatricula()
        P(2) = nuevoAvisoBaja.getEmpleador().getCodigo()
        P(3) = nuevoAvisoBaja.getCargo().getCorrelativo()
        P(4) = nuevoAvisoBaja.getSalario()
        P(5) = nuevoAvisoBaja.getFechaBaja()
        P(6) = nuevoAvisoBaja.getMotivo().getCorrelativo()
        P(7) = nuevoAvisoBaja.getFechaPresentacion()
        P(8) = nuevoAvisoBaja.getInicioCesantia()
        P(9) = nuevoAvisoBaja.getFinCesantia()

        Dim respuesta As Int16 = 0
        respuesta = objDAL.Ejecutar("SPRegistrarAvisoBaja_RegistrarBaja", P)
        Return respuesta
    End Function








    'METODOS VALIDACIÓN
    Public Function validarEntradas() As String
        Dim mensaje As String = "", aviso As AvisoAfiliacion = nuevoAvisoBaja

        mensaje = validarTitular(aviso.getAsegurado())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarCargo(aviso.getCargo())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarSalario(aviso.getSalario())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarMotivo(aviso.getMotivo())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarFechaPresentacion(aviso.getFechaPresentacion())
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarTitular(ByRef _titular As Titular) As String
        If _titular Is Nothing Then Return "Error. Seleccione un titular."

        Return ""
    End Function

    Private Function validarCargo(ByRef _cargo As Concepto) As String
        If _cargo Is Nothing Then Return "Error. Seleccione un cargo."

        Return ""
    End Function

    Private Function validarSalario(ByRef _salario As Decimal) As String
        If _salario = 0 Then Return "Error. Ingrese un salario"
        If _salario < 0 Then Return "Error. El salario no puede ser un número negativo"

        Return ""
    End Function

    Private Function validarMotivo(ByRef _motivo As Concepto) As String
        If _motivo Is Nothing Then Return "Error. Seleccione un motivo."

        Return ""
    End Function

    Private Function validarFechaPresentacion(ByVal _fechaPresentacion As Date) As String
        If _fechaPresentacion.Date > Date.Today Then Return "Error. La fecha de presentación no puede ser mayor a la fecha actual."

        Return ""
    End Function

End Class
