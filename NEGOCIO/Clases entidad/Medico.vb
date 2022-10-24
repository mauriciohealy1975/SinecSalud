Public Class Medico
    Private codigo As Long
    Private turno As Turno
    Private turnos As Turno()
    Private usuario As Usuario
    Private especialidad As Especialidad
    Private lugtabajo As Int16

    Public Sub New()
        codigo = 0
        lugtabajo = 0
        turno = New Turno()
        usuario = New Usuario()
        especialidad = New Especialidad()
    End Sub

    Public Sub New(_codigo As Long, ByRef _usuario As Usuario, _lugtrab As Int16)
        codigo = _codigo
        usuario = _usuario
        lugtabajo = _lugtrab
    End Sub



    Public Sub setCodigo(ByVal _codigo As Int16)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int16
        Return codigo
    End Function



    Public Sub setTurno(ByRef _turno As Turno)
        turno = _turno
    End Sub

    Public Function getTurno() As Turno
        Return turno
    End Function



    Public Sub setTurnos(ByRef _turnos As Turno())
        turnos = _turnos
    End Sub

    Public Function getTurnos() As Turno()
        Return turnos
    End Function



    Public Function getUsuario() As Usuario
        Return usuario
    End Function

    Public Sub setUsuario(ByRef _oUsuario)
        usuario = _oUsuario
    End Sub



    Public Sub setEspecialidad(_especialidad As Especialidad)
        especialidad = _especialidad
    End Sub

    Public Function getEspecialidad() As Especialidad
        Return especialidad
    End Function
    '****************************************************************
    Public Sub setLugarTrabajo(ByVal _lugartrabajo As Int16)
        lugtabajo = _lugartrabajo
    End Sub

    Public Function getCLugarTrabajo() As Int16
        Return lugtabajo
    End Function



End Class
