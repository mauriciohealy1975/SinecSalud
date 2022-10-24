Public Class AvisoAsignacionesFamiliares

    Private codigo As Int64
    Private beneficiario As Beneficiario
    Private titular As Titular
    Private empresa As Empresa
    Private programaproyecto As ProgramaProyecto
    Private fechaAsignacion As Date
    Private natalidad As Int16
    Private lactancia As Int16
    Private fechaFinAsignacion As Date
    Private estado As Concepto
    Private fechaProceso As Date
    Private nombreEjecutor As String
    Private ciEjecutor As String
    Private parentescoEjecutor As Concepto
    Public Sub New()

    End Sub




    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function



    Public Sub setBeneficiario(ByRef _beneficiario As Beneficiario)
        beneficiario = _beneficiario
    End Sub

    Public Function getBeneficiario() As Beneficiario
        Return beneficiario
    End Function



    Public Sub setTitular(ByRef _titular As Titular)
        titular = _titular
    End Sub

    Public Function getTitular() As Titular
        Return titular
    End Function



    Public Sub setEmpresa(ByRef _empresa As Empresa)
        empresa = _empresa
    End Sub

    Public Function getEmpresa() As Empresa
        Return empresa
    End Function


    Public Sub setProgramaProyecto(ByRef _programaproyecto As ProgramaProyecto)
        programaproyecto = _programaproyecto
    End Sub

    Public Function getProgramaProyecto() As ProgramaProyecto
        Return programaproyecto
    End Function



    Public Sub setFechaAsignacion(ByVal _fechaAsignacion As Date)
        fechaAsignacion = _fechaAsignacion
    End Sub

    Public Function getFechaAsignacion() As Date
        Return fechaAsignacion
    End Function



    Public Sub setNatalidad(ByVal _natalidad As Int16)
        natalidad = _natalidad
    End Sub

    Public Function getNatalidad() As Int16
        Return natalidad
    End Function



    Public Sub setLactancia(ByVal _lactancia As Int16)
        lactancia = _lactancia
    End Sub

    Public Function getLactancia() As Int16
        Return lactancia
    End Function



    Public Sub setFechaFinAsignacion(ByVal _fechaFinAsignacion As Date)
        fechaFinAsignacion = _fechaFinAsignacion
    End Sub

    Public Function getFechaFinAsignacion() As Date
        Return fechaFinAsignacion
    End Function



    Public Sub setEstado(ByRef _estado As Concepto)
        estado = _estado
    End Sub

    Public Function getEstado() As Concepto
        Return estado
    End Function



    Public Sub setFechaProceso(ByVal _fechaProceso As Date)
        fechaProceso = _fechaProceso
    End Sub

    Public Function getFechaProceso() As Date
        Return fechaProceso
    End Function


    Public Sub setNombreEjecutor(ByVal _nombreEjecutor As String)
        nombreEjecutor = _nombreEjecutor
    End Sub

    Public Function getNombreEjecutor() As String
        Return nombreEjecutor
    End Function



    Public Sub setCiEjecutor(ByVal _ciEjecutor As String)
        ciEjecutor = _ciEjecutor
    End Sub

    Public Function getCiEjecutor() As String
        Return ciEjecutor
    End Function



    Public Sub setParentescoEjecutor(ByRef _parentescoEjecutor As Concepto)
        parentescoEjecutor = _parentescoEjecutor
    End Sub

    Public Function getParentescoEjecutor() As Concepto
        Return parentescoEjecutor
    End Function


End Class
