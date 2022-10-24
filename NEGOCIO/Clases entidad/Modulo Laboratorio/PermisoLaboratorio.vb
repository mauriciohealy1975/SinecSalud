Public Class PermisoLaboratorio

    Private codigo As Long
    Private procesador As Usuario
    Private areas As AreaLaboratorio()

    Public Sub New()
        codigo = 0
        procesador = New Usuario()
        areas = New AreaLaboratorio(-1) {}
    End Sub



    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Long
        Return codigo
    End Function



    Public Sub setProcesador(ByVal _procesador As Usuario)
        procesador = _procesador
    End Sub

    Public Function getProcesador() As Usuario
        Return procesador
    End Function



    Public Sub setAreas(ByRef _area As AreaLaboratorio())
        areas = _area
    End Sub

    Public Function getAreas() As AreaLaboratorio()
        Return areas
    End Function

End Class



Public Class PermisoLaboratorioInput
    Public Property codigo As String
    Public Property procesador As UsuarioInput
    Public Property areas As AreaLaboratorioInput()



    Public Sub New()
        codigo = "0"
        procesador = New UsuarioInput()
        areas = New AreaLaboratorioInput(-1) {}
    End Sub


End Class
