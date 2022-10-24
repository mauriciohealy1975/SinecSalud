Public Class Especialidad

    Private codigo As Long
    Private nombre As String

    Public Sub New()
        codigo = 0
        nombre = ""
    End Sub

    Public Sub New(_codigo, _nombre)
        codigo = _codigo
        nombre = _nombre
    End Sub




    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Long
        Return Me.codigo
    End Function



    Public Sub setNombre(_nombre As String)
        nombre = _nombre
    End Sub

    Function getnombre() As String
        Return Me.nombre
    End Function



End Class
