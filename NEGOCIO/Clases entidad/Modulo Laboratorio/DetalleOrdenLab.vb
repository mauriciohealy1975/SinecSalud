Public Class DetalleOrdenLaboratorio

    Private codigo As Long
    Private orden As OrdenLaboratorio
    Private examen As ExamenLaboratorio
    Private asegurado As Asegurado

    Public Sub New()
        codigo = 0
        orden = New OrdenLaboratorio()
        examen = New ExamenLaboratorio()
        asegurado = New Asegurado()
    End Sub



    Public Function getCodigo() As Long
        Return codigo
    End Function

    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub



    Public Sub setOrden(ByRef _orden As OrdenLaboratorio)
        orden = _orden
    End Sub

    Public Function getOrden() As OrdenLaboratorio
        Return orden
    End Function



    Public Sub setExamen(ByRef _examen As ExamenLaboratorio)
        examen = _examen
    End Sub

    Public Function getExamen() As ExamenLaboratorio
        Return examen
    End Function



    Public Sub setAsegurado(ByRef _asegurado As Asegurado)
        asegurado = _asegurado
    End Sub

    Public Function getAsegurado() As Asegurado
        Return asegurado
    End Function




End Class
