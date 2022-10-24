Public Class ExamenLaboratorio

    Private codigo As Long
    Private nombre As String
    Private area As AreaLaboratorio
    Private subarea As SubareaLaboratorio
    Private tipoResultado As Concepto
    Private conjuntoOpcionesResultado As ConjuntoOpcionesResultadosLaboratorio
    Private unidad As UnidadMedidaLaboratorio

    'CONSTRUCTORES
    Public Sub New()

    End Sub

    Public Sub New(ByVal _codigo As Int16, ByVal _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub

    Public Sub New(_codigo As Long, _nombre As String, ByRef _area As AreaLaboratorio, ByRef _subarea As SubareaLaboratorio)
        codigo = _codigo
        nombre = _nombre
        area = _area
        subarea = _subarea
    End Sub





    'GETTERS Y SETTERS
    Public Function getCodigo() As Int16
        Return codigo
    End Function

    Public Sub setCodigo(ByVal _codigo As Int16)
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

    Public Sub setArea(ByRef _area As AreaLaboratorio)
        area = _area
    End Sub

    Public Function getSubarea() As SubareaLaboratorio
        Return subarea
    End Function

    Public Sub setSubarea(ByRef _subarea As SubareaLaboratorio)
        subarea = _subarea
    End Sub




    Public Function getTipoResultado() As Concepto
        Return tipoResultado
    End Function

    Public Sub setTipoResultado(ByRef _tipoResultado As Concepto)
        tipoResultado = _tipoResultado
    End Sub



    Public Sub setConjuntoOpcionesResultado(ByRef _conjuntoOpcionesResultado As ConjuntoOpcionesResultadosLaboratorio)
        conjuntoOpcionesResultado = _conjuntoOpcionesResultado
    End Sub

    Public Function getConjuntoOpcionesResultado() As ConjuntoOpcionesResultadosLaboratorio
        Return conjuntoOpcionesResultado
    End Function



    Public Sub setUnidad(ByRef _unidad As UnidadMedidaLaboratorio)
        unidad = _unidad
    End Sub

    Public Function getUnidad() As UnidadMedidaLaboratorio
        Return unidad
    End Function



End Class
