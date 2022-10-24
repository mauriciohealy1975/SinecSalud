Public Class AtencionInyectables

    Private codigoMedicamento As String
    Private nombreMedicamento As String
    Private dosis As String
    Private via As String
    Private reaccionAdversa As String
    Private PPS As String
    Private actividadRealizada As String

    Public Sub New()
        codigoMedicamento = ""
        nombreMedicamento = ""
        dosis = ""
        via = ""
        reaccionAdversa = ""
        PPS = ""
        actividadRealizada = ""
    End Sub

    Public Function getCodigoMedicamento() As String
        Return codigoMedicamento
    End Function

    Public Sub setCodigoMedicamento(ByVal _codigoMedicamento As String)
        codigoMedicamento = _codigoMedicamento
    End Sub

    Public Function getnombreMedicamento() As String
        Return nombreMedicamento
    End Function

    Public Sub setNombreMedicamento(ByVal _nombreMedicamento As String)
        nombreMedicamento = _nombreMedicamento
    End Sub

    Public Function getDosis() As String
        Return dosis
    End Function

    Public Sub setDosis(ByVal _dosis As String)
        dosis = _dosis
    End Sub

    Public Function getVia() As String
        Return via
    End Function

    Public Sub setVia(ByVal _via As String)
        via = _via
    End Sub

    Public Function getReaccionAdversa() As String
        Return reaccionAdversa
    End Function

    Public Sub setReaccionAdversa(ByVal _reaccionAdversa As String)
        reaccionAdversa = _reaccionAdversa
    End Sub

    Public Function getPPS() As String
        Return PPS
    End Function

    Public Sub setPPS(ByVal _PPS As String)
        PPS = _PPS
    End Sub

    Public Function getActividadRealizada() As String
        Return actividadRealizada
    End Function

    Public Sub setActividadRealizada(ByVal _actividadRealizada As String)
        actividadRealizada = _actividadRealizada
    End Sub





End Class
