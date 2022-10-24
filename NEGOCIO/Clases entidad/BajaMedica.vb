Public Class BajaMedica
    Private lugarAtencion As Int16
    Private regimen As Int16
    Private tratamiento As Int16
    Private matriculaAsegurado As String
    Private fechainicioPeriodoIncapacidad As String
    Private fechaFinPeriodoIncapacidad As String
    Private nroDias As Int16
    Private diasLiteral As String




    'PROPERTIES
    Public Shared ReadOnly Property LugarAtencionConsultaExterna() As Int16
        Get
            Return 1
        End Get
    End Property

    Public Shared ReadOnly Property LugarAtencionClinica() As Int16
        Get
            Return 2
        End Get
    End Property

    Public Shared ReadOnly Property LugarAtencionEmergencia() As Int16
        Get
            Return 3
        End Get
    End Property

    Public Shared ReadOnly Property LugarAtencionInternacion() As Int16
        Get
            Return 4
        End Get
    End Property

    Public Shared ReadOnly Property RegimenEnfermedadComun() As Int16
        Get
            Return 1
        End Get
    End Property

    Public Shared ReadOnly Property RegimenMaternidad() As Int16
        Get
            Return 2
        End Get
    End Property

    Public Shared ReadOnly Property RegimenRiesgosLaborales() As Int16
        Get
            Return 3
        End Get
    End Property

    Public Shared ReadOnly Property TratamientoDomicilio() As Int16
        Get
            Return 1
        End Get
    End Property

    Public Shared ReadOnly Property TratamientoHospitalizacion() As Int16
        Get
            Return 2
        End Get
    End Property





    'GETTERS Y SETTERS
    Public Sub setLugarAtencion(ByVal _lugarAtencion As Int16)
        lugarAtencion = _lugarAtencion
    End Sub

    Public Function getLugarAtencion()
        Return lugarAtencion
    End Function

    Public Sub setRegimen(ByVal _regimen As Int16)
        regimen = _regimen
    End Sub

    Public Function getRegimen() As Int16
        Return regimen
    End Function

    Public Sub setTratamiento(ByVal _tratamiento As Int16)
        tratamiento = _tratamiento
    End Sub

    Public Function getTratamiento() As Int16
        Return tratamiento
    End Function

    Public Sub setMatriculaAsegurado(ByVal _matriculaAsegurado As String)
        matriculaAsegurado = _matriculaAsegurado
    End Sub

    Public Function getMatriculaAsegurao() As String
        Return matriculaAsegurado
    End Function

    Public Sub setInicioPeriodoIncapacidad(ByVal _fechaInicio As String)
        fechainicioPeriodoIncapacidad = _fechaInicio
    End Sub

    Public Function getInicioPeriodoIncapacidad() As String
        Return fechainicioPeriodoIncapacidad
    End Function

    Public Sub setFinPeriodoIncapacidad(ByVal _fechaFin As String)
        fechaFinPeriodoIncapacidad = _fechaFin
    End Sub

    Public Function getFinPeriodoIncapacidad() As String
        Return fechaFinPeriodoIncapacidad
    End Function

    Public Sub setNroDias(ByVal _nroDias As Int16)
        nroDias = _nroDias
    End Sub

    Public Function getNroDias() As String
        Return nroDias
    End Function

    Public Sub setDiasLiteral(ByVal _diasLiteral As String)
        diasLiteral = _diasLiteral
    End Sub

    Public Function getDiasLiteral() As String
        Return diasLiteral
    End Function


End Class
