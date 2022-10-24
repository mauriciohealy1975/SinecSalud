Public Class Concepto

    Dim prefijo As Long
    Dim correlativo As Long
    Dim descripcion As String


    Public Sub New(_prefijo As Long, _correlativo As Long, _descripcion As String)
        prefijo = _prefijo
        correlativo = _correlativo
        descripcion = _descripcion
    End Sub

    Public Sub New()
        prefijo = 0
        correlativo = 0
        descripcion = ""
    End Sub



    Public Function getPrefijo() As Long
        Return prefijo
    End Function

    Public Sub setPrefijo(_prefijo As Long)
        prefijo = _prefijo
    End Sub



    Public Function getCorrelativo() As Long
        Return correlativo
    End Function

    Public Sub setCorrelativo(_correlativo As Long)
        correlativo = _correlativo
    End Sub



    Public Function getDescripcion() As String
        Return descripcion
    End Function

    Public Sub setDescripcion(_descripcion As String)
        descripcion = _descripcion
    End Sub






End Class
