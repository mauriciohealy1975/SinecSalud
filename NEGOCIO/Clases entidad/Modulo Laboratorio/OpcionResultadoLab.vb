Public Class OpcionResultadoLaboratorio

    Private codigo As Long
    Private valor As String
    Private conjuntoOpciones As ConjuntoOpcionesResultadosLaboratorio

    Public Sub New()
        codigo = 0
        valor = ""
        conjuntoOpciones = New ConjuntoOpcionesResultadosLaboratorio()
    End Sub

    Public Sub New(_codigo As Long, _valor As String, ByRef _conjuntoOpciones As ConjuntoOpcionesResultadosLaboratorio)
        codigo = _codigo
        valor = _valor
        conjuntoOpciones = _conjuntoOpciones
    End Sub




    Public Sub setCodigo(_codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function



    Public Sub setValor(_valor As String)
        valor = _valor
    End Sub

    Public Function getValor() As String
        Return valor
    End Function



    Public Sub setConjuntoOpciones(_codigoConjunto As ConjuntoOpcionesResultadosLaboratorio)
        conjuntoOpciones = _codigoConjunto
    End Sub

    Public Function getConjuntoOpcioness() As ConjuntoOpcionesResultadosLaboratorio
        Return conjuntoOpciones
    End Function



End Class
