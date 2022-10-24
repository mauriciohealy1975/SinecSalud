Public Class ValorOpcional

    Private descripcion As String
    Private codigoGrupoOpcional As Int16

    'CONSTRUCTORES
    Public Sub New()

    End Sub

    Public Sub New(ByVal _descripcion As String, ByVal _codigoGrupoOpcional As Int16)
        descripcion = _descripcion
        codigoGrupoOpcional = _codigoGrupoOpcional
    End Sub



    'GETTERS Y SETTERS
    Public Function getDescripcion()
        Return descripcion
    End Function

    Public Sub setDescripcion(ByVal _descripcion As String)
        descripcion = _descripcion
    End Sub

    Public Function getCodigoGrupoOpcional()
        Return codigoGrupoOpcional
    End Function

    Public Sub setCodigoGrupoOpcional(ByVal _codigoGrupoOpcional As Int16)
        codigoGrupoOpcional = _codigoGrupoOpcional
    End Sub




End Class
