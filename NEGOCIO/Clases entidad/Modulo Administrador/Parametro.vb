Public Class Parametro
    Private codigo As Int64
    Private codigoModulo As Int64
    Private tipo As Int16
    Private estado As Int16
    Private valor As Int64
    Private rangoInicial As Int64
    Private rangoFinal As Int64
    Private descripcion As String

    Public Sub New()

    End Sub


    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function



    Public Sub setCodigoModulo(ByVal _codigoModulo As Int64)
        codigoModulo = _codigoModulo
    End Sub

    Public Function getCodigoModulo() As Int64
        Return codigoModulo
    End Function



    Public Sub setTipo(ByVal _tipo As Int16)
        tipo = _tipo
    End Sub

    Public Function getTipo() As Int16
        Return tipo
    End Function



    Public Sub setEstado(ByVal _parametroEstado As Int16)
        estado = _parametroEstado
    End Sub

    Public Function getEstado()
        Return estado
    End Function



    Public Sub setValor(ByVal _valor As Int64)
        valor = _valor
    End Sub

    Public Function getValor() As Int64
        Return valor
    End Function



    Public Sub setRangoInicial(ByVal _rangoInicial As Int64)
        rangoInicial = _rangoInicial
    End Sub

    Public Function getRangoInicial() As Int64
        Return rangoInicial
    End Function



    Public Sub setRangoFinal(ByVal _rangoFinal As Int64)
        rangoFinal = _rangoFinal
    End Sub

    Public Function getRangoFinal()
        Return rangoFinal
    End Function



    Public Sub setDescripcion(ByVal _descripcion As String)
        descripcion = _descripcion
    End Sub

    Public Function getDescripcion() As String
        Return descripcion
    End Function


End Class
