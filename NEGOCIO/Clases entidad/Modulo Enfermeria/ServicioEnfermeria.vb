Public Class ServicioEnfermeria

    Private nombre As String
    Private codigoConcepeto As Int16


    Public Sub New(ByVal _nombre As String, ByVal _codigoConcepto As Int16)
        nombre = _nombre
        codigoConcepeto = _codigoConcepto
    End Sub




    'GETTERS Y SETTERS
    Public Function getNombre()
        Return nombre
    End Function

    Public Sub setNombre(ByVal _nombre As String)
        nombre = _nombre
    End Sub

    Public Function getCodigoConcepto()
        Return codigoConcepeto
    End Function

    Public Sub setCodigoConcepto(ByVal _codigoConcepto As Int16)
        codigoConcepeto = _codigoConcepto
    End Sub




End Class


