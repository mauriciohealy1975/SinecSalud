Public Class TransferenciaMedica

    Private matriculaAsegurado As String
    Private codigoUsuario As Int16
    Private codigoEspecialiadad As Int16
    Private diagnostico As String
    Private fecha As String

    Public Sub New()

    End Sub




    Public Function getMatriculaAsegurado() As String
        Return matriculaAsegurado
    End Function

    Public Sub setMatriculaAsegurado(ByVal _matriculaAsegurado As String)
        matriculaAsegurado = _matriculaAsegurado
    End Sub

    Public Function getCodigoUsuario() As Int16
        Return codigoUsuario
    End Function

    Public Sub setCodigoUsuario(ByVal _codigoUsuario As Int16)
        codigoUsuario = _codigoUsuario
    End Sub

    Public Function getCodigoEspecialidad() As Int16
        Return codigoEspecialiadad
    End Function

    Public Sub setCodigoEspecialidad(ByVal _codigoEspecialidad As Int16)
        codigoEspecialiadad = _codigoEspecialidad
    End Sub

    Public Function getDiagnostico() As String
        Return diagnostico
    End Function

    Public Sub setDiagnostico(ByVal _diagnostico As String)
        diagnostico = _diagnostico
    End Sub

    Public Function getFecha() As String
        Return fecha
    End Function

    Public Sub setFecha(ByVal _fecha As String)
        fecha = _fecha
    End Sub

End Class
