Imports DAL
Public Class RegistroBajaPorEmpresa
    'INICIO
    Private objDAL As TDatosSql
    Public empresas As Empresa()
    Public titulares As Titular()
    Public cargos As Concepto()
    Public motivos As Concepto()
    Public nuevosAvisos As ListaEnlazadaAvisosAfiliacion

    Public Sub New()
        objDAL = New TDatosSql(False)
        empresas = Nothing
        titulares = Nothing
        cargos = Nothing
        motivos = Nothing
        nuevosAvisos = New ListaEnlazadaAvisosAfiliacion()
    End Sub









    'METODOS FUNCIONALES G1
    Public Sub traerEmpresas(ByVal _nombre As String)
        Dim index As Int16 = 0, objDTable As DataTable = traerEmpresasBD(_nombre)
        empresas = New Empresa(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, nombre As String

            If IsDBNull(row("COD EMP")) Then codigo = 0 Else codigo = Int64.Parse(row("COD EMP"))
            If IsDBNull(row("NOM EMP")) Then nombre = "" Else nombre = row("NOM EMP").ToString()

            empresas(index) = New Empresa(codigo, nombre)
            index += 1
        Next
    End Sub

    Public Sub traerTitulares(ByVal _codEmpresa As Int64)
        Dim index As Int16 = 0, objDTable As DataTable = traerTitularesBD(_codEmpresa)
        titulares = New Titular(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim codigo As Int64, apPaterno As String, apMaterno As String, nombres As String, matricula As String

            If IsDBNull(row("COD TIT")) Then codigo = 0 Else codigo = Int64.Parse(row("COD TIT"))
            If IsDBNull(row("APA TIT")) Then apPaterno = "" Else apPaterno = row("APA TIT").ToString()
            If IsDBNull(row("AMA TIT")) Then apMaterno = "" Else apMaterno = row("AMA TIT").ToString()
            If IsDBNull(row("NOM TIT")) Then nombres = "" Else nombres = row("NOM TIT").ToString()
            If IsDBNull(row("MAT TIT")) Then matricula = "" Else matricula = row("MAT TIT").ToString()

            titulares(index) = New Titular(codigo, apPaterno, apMaterno, nombres, matricula)
            index += 1
        Next

    End Sub


    'METODOS FUNCIONALES G3
    Public Sub traerCargos()
        Dim objDTable As DataTable = traerCargosBD()
        cargos = New Concepto(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            cargos(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Sub traerMotivos()
        Dim objDTable As DataTable = traerMotivosBD()
        motivos = New Concepto(objDTable.Rows.Count - 1) {}

        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            motivos(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Function generarPeriodoCesantia(ByVal _fechaBaja As Date) As Date()
        Dim periodoCesantia As Date() = New Date(1) {}  'array

        Dim inicioCesantia As Date = _fechaBaja.Date
        Dim finCesantia As Date = _fechaBaja.AddDays(59)

        periodoCesantia(0) = inicioCesantia
        periodoCesantia(1) = finCesantia

        Return periodoCesantia
    End Function

    Public Sub adicionarNuevoAviso(ByRef _avisoBaja As AvisoAfiliacion)
        nuevosAvisos.agregarNodo(_avisoBaja)
    End Sub

    Public Sub eliminarAvisoBaja(ByVal _matricula As String)
        nuevosAvisos.eliminarNodo(_matricula)
    End Sub











    'METODOS BD G1
    Private Function traerEmpresasBD(ByVal _nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre
        Return objDAL.TraerDataTable("SPtraerEmpresas_RegBajaPorEmpresa", P)
    End Function

    Private Function traerTitularesBD(ByVal _codEmpresa As Int64) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codEmpresa
        Return objDAL.TraerDataTable("SPtraerTitulares_RegBajaPorEmpresa", P)
    End Function

    Private Function traerCargosBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerCargosTrabajo_Concepto")
    End Function

    Private Function traerMotivosBD() As DataTable
        Return objDAL.TraerDataTable("SPtraerMotivoBaja_Concepto")
    End Function


    'METODOS BD G4
    Public Function insertarAvisosBajas()
        Dim nodoActual As NodoAvisoAfiliacion = nuevosAvisos.raiz
        Dim aviso As AvisoAfiliacion
        Dim respuesta As Int16

        While nodoActual IsNot Nothing
            aviso = nodoActual.aviso
            respuesta = insertarAvisosBajasBD(aviso)

            nodoActual = nodoActual.siguiente
        End While

        Return respuesta
    End Function









    'METODOS VALIDACIÓN
    Public Function validarEntradas(ByRef _aviso As AvisoAfiliacion) As String
        Dim mensaje As String

        mensaje = validarTitular(_aviso.getAsegurado())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarCargo(_aviso.getCargo())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarSalario(_aviso.getSalario())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarMotivo(_aviso.getMotivo())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarFechaPresentacion(_aviso.getFechaPresentacion())
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarTitular(ByRef _titular As Titular)
        If IsNothing(_titular) Or _titular.getMatricula() = "" Then Return "Error. Seleccione un titular"


        Dim nodoActual As NodoAvisoAfiliacion = nuevosAvisos.raiz
        While nodoActual IsNot Nothing
            Dim matriculaActual As String = nodoActual.aviso.getAsegurado().getMatricula()
            If matriculaActual = _titular.getMatricula() Then Return "Error. Este asegurado ya se encuentra en la lista de baja. Seleccione otro asegurado."

            nodoActual = nodoActual.siguiente
        End While

        Return ""
    End Function

    Private Function validarCargo(ByRef _cargo As Concepto)
        If IsNothing(_cargo) Or _cargo.getPrefijo() = 0 Then Return "Error. Seleccione un cargo." Else Return ""
    End Function

    Private Function validarSalario(ByVal _salario As Decimal)
        If _salario = 0 Then Return "Error. Ingrese un salario." Else Return ""
    End Function

    Private Function validarMotivo(ByRef _motivo As Concepto)
        If IsNothing(_motivo) Or _motivo.getPrefijo() = 0 Then Return "Error. Seleccione un motivo." Else Return ""
    End Function

    Private Function validarFechaPresentacion(ByVal _fechaPresentacion As Date)
        If _fechaPresentacion > Today.Date Then Return "Error. La fecha de presentación no puede ser mayor a la fecha actual." Else Return ""
    End Function

    Private Function insertarAvisosBajasBD(ByRef _aviso As AvisoAfiliacion) As Int16
        Dim P As Object() = New Object(9) {}
        P(0) = Usuario.codUserLoggedSystem
        P(1) = _aviso.getAsegurado().getMatricula()
        P(2) = _aviso.getEmpleador().getCodigo()
        P(3) = _aviso.getCargo().getCorrelativo()
        P(4) = _aviso.getSalario()
        P(5) = _aviso.getFechaBaja()
        P(6) = _aviso.getMotivo().getCorrelativo()
        P(7) = _aviso.getFechaPresentacion()
        P(8) = _aviso.getInicioCesantia()
        P(9) = _aviso.getFinCesantia()

        Dim respuesta As Int16 = objDAL.Ejecutar("SPRegistrarAvisoBaja_RegistrarBaja", P)
        Return respuesta
    End Function

End Class
