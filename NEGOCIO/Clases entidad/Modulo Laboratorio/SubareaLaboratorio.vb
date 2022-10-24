Public Class SubareaLaboratorio
    Private codigo As Long
    Private nombre As String
    Private area As AreaLaboratorio


    Public Sub New()

    End Sub

    Public Sub New(_codigo As Short, _nombre As String, ByRef _area As AreaLaboratorio)
        codigo = _codigo
        nombre = _nombre
        area = _area
    End Sub



    Public Function getCodigo() As Long
        Return codigo
    End Function

    Public Sub setCodigo(ByVal _codigo As Long)
        codigo = _codigo
    End Sub



    Public Function getNombre() As String
        Return nombre
    End Function

    Public Sub setNombre(ByVal _nombre As String)
        nombre = _nombre
    End Sub



    Public Function getArea() As AreaLaboratorio
        Return area
    End Function

    Public Sub setArea(ByVal _area As AreaLaboratorio)
        area = _area
    End Sub


End Class
