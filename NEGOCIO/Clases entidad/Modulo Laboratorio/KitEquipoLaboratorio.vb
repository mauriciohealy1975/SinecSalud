Public Class KitEquipoLaboratorio

    Private codigo As Long
    Private nombre As String
    Private proveedor As ProveedorKitEquipo
    Private modelo As Long
    Private tipo As Concepto
    Private examen As ExamenLaboratorio
    Private tipoReferencia As Concepto

    Public Sub New()
        codigo = 0
        nombre = ""
        proveedor = New ProveedorKitEquipo()
        modelo = 0
        tipo = New Concepto()
        examen = New ExamenLaboratorio()
        tipoReferencia = New Concepto()
    End Sub



    Public Function getCodigo() As Long
        Return codigo
    End Function

    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub



    Public Sub setNombre(_nombre As String)
        nombre = _nombre
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function



    Public Sub setProveedor(_proveedor As ProveedorKitEquipo)
        proveedor = _proveedor
    End Sub

    Public Function getProveedor() As ProveedorKitEquipo
        Return proveedor
    End Function



    Public Sub setModelo(_modelo As Long)
        modelo = _modelo
    End Sub

    Public Function getModelo() As Long
        Return modelo
    End Function



    Public Function getTipo() As Concepto
        Return tipo
    End Function

    Public Sub setTipo(ByRef _tipo As Concepto)
        tipo = _tipo
    End Sub



    Public Function getExamen() As ExamenLaboratorio
        Return examen
    End Function


    Public Sub setExamen(ByRef _examen As ExamenLaboratorio)
        examen = _examen
    End Sub



    Public Function getTipoReferencia() As Concepto
        Return tipoReferencia
    End Function

    Public Sub setTipoReferencia(ByRef _tipoReferencia As Concepto)
        tipoReferencia = _tipoReferencia
    End Sub

End Class

Public Class KitEquipoLaboratorioInput

    Public a As KitEquipoLaboratorio

    Public Property codigo As String
    Public Property nombre As String
    Public Property proveedor As ProveedorKitEquipoInput
    Public Property modelo As String
    Public Property tipo As ConceptoInput
    Public Property examen As ExamenLaboratorioInput
    Public Property tipoReferencia As ConceptoInput

    Public Sub New()
        codigo = "0"
        nombre = ""
        proveedor = New ProveedorKitEquipoInput()
        modelo = "0"
        tipo = New ConceptoInput()
        examen = New ExamenLaboratorioInput()
        tipoReferencia = New ConceptoInput()
    End Sub

End Class




