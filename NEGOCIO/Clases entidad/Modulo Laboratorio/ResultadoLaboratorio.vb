Public Class ResultadoLaboratorio

    Private codigo As Long
    Private examen As ExamenLaboratorio
    Private detalle As DetalleOrdenLaboratorio
    Private orden As OrdenLaboratorio
    Private procesador As Usuario

    Private tipoResultado As Concepto
    Private unidad As UnidadMedidaLaboratorio
    Private kitequipo As KitEquipoLaboratorio
    Private conjunto As ConjuntoOpcionesResultadosLaboratorio

    Private valorTipoComun As Double
    Private valorTipoOpcion As OpcionResultadoLaboratorio
    Private valorTipoTextual As String

    Private asignado As Boolean
    Private referencia As ReferenciaResultadoLaboratorio

    Public Sub New()
        codigo = 0
        examen = New ExamenLaboratorio()
        detalle = New DetalleOrdenLaboratorio()
        orden = New OrdenLaboratorio()
        procesador = New usuario

        tipoResultado = New Concepto()
        unidad = New UnidadMedidaLaboratorio
        kitequipo = New KitEquipoLaboratorio()
        conjunto = New ConjuntoOpcionesResultadosLaboratorio()

        valorTipoComun = 0
        valorTipoOpcion = New OpcionResultadoLaboratorio()
        valorTipoTextual = ""

        asignado = False
        referencia = New ReferenciaResultadoLaboratorio()
    End Sub



    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Long
        Return codigo
    End Function



    Public Sub setExamen(ByRef _examen As ExamenLaboratorio)
        examen = _examen
    End Sub

    Public Function getExamen() As ExamenLaboratorio
        Return examen
    End Function



    Public Sub setDetalle(ByRef _detalle As DetalleOrdenLaboratorio)
        detalle = _detalle
    End Sub

    Public Function getDetalle() As DetalleOrdenLaboratorio
        Return detalle
    End Function



    Public Sub setOrden(ByRef _orden As OrdenLaboratorio)
        orden = _orden
    End Sub

    Public Function getOrden() As OrdenLaboratorio
        Return orden
    End Function



    Public Sub setProcesador(ByRef _procesador As Usuario)
        procesador = _procesador
    End Sub

    Public Function getProcesador() As Usuario
        Return procesador
    End Function



    Public Sub setTipoResultado(ByRef _tipoResultado As Concepto)
        tipoResultado = _tipoResultado
    End Sub

    Public Function getTipoResultado() As Concepto
        Return tipoResultado
    End Function



    Public Sub setUnidad(ByRef _unidad As UnidadMedidaLaboratorio)
        unidad = _unidad
    End Sub

    Public Function getUnidad() As UnidadMedidaLaboratorio
        Return unidad
    End Function



    Public Sub setKitEquipo(ByRef _kitequipo As KitEquipoLaboratorio)
        kitequipo = _kitequipo
    End Sub

    Public Function getKitEquipo() As KitEquipoLaboratorio
        Return kitequipo
    End Function


    Public Sub setConjunto(ByRef _conjunto As ConjuntoOpcionesResultadosLaboratorio)
        conjunto = _conjunto
    End Sub

    Public Function getConjunto() As ConjuntoOpcionesResultadosLaboratorio
        Return conjunto
    End Function


    Public Sub setValorTipoComun(_valorTipoComun As Double)
        valorTipoComun = _valorTipoComun
    End Sub

    Public Function getValorTipoComun() As Double
        Return valorTipoComun
    End Function



    Public Sub setValorTipoOpcion(ByRef _valorTipoOpcion As OpcionResultadoLaboratorio)
        valorTipoOpcion = _valorTipoOpcion
    End Sub

    Public Function getValorTipoOpcion() As OpcionResultadoLaboratorio
        Return valorTipoOpcion
    End Function



    Public Sub setValorTipoTextual(_valorTipoTextual As String)
        valorTipoTextual = _valorTipoTextual
    End Sub

    Public Function getValorTipoTextual() As String
        Return valorTipoTextual
    End Function



    Public Sub setAsignado(_asignado As Boolean)
        asignado = _asignado
    End Sub

    Public Function getAsignado() As Boolean
        Return asignado
    End Function


    Public Sub setReferenccia(_referencia As ReferenciaResultadoLaboratorio)
        referencia = _referencia
    End Sub

    Public Function getReferencia() As ReferenciaResultadoLaboratorio
        Return referencia
    End Function


End Class


Public Class ResultadoLaboratorioInput
    Public Property codigo As String
    Public Property examen As ExamenLaboratorioInput
    Public Property detalle As DetalleOrdenLaboratorioInput
    Public Property orden As OrdenLaboratorioInput
    Public Property procesador As UsuarioInput

    Public Property tipoResultado As ConceptoInput
    Public Property unidad As UnidadMedidaLaboratorioInput
    Public Property kitequipo As KitEquipoLaboratorioInput

    Public Property valorTipoComun As Double
    Public Property valorTipoOpcion As OpcionResultadoLaboratorioInput
    Public Property valorTipoTextual As String

    Public Property referencia As ReferenciaResultadoLaboratorioInput


    Public Sub New()
        codigo = ""
        examen = New ExamenLaboratorioInput()
        detalle = New DetalleOrdenLaboratorioInput()
        orden = New OrdenLaboratorioInput()
        procesador = New UsuarioInput()

        tipoResultado = New ConceptoInput()
        unidad = New UnidadMedidaLaboratorioInput()
        kitequipo = New KitEquipoLaboratorioInput()

        valorTipoComun = "0"
        valorTipoOpcion = New OpcionResultadoLaboratorioInput()
        valorTipoTextual = ""

        referencia = New ReferenciaResultadoLaboratorioInput()
    End Sub

End Class

