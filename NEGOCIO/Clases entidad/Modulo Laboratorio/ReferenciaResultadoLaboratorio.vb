Public Class ReferenciaResultadoLaboratorio

    Private codigo As Long
    Private tipo As Concepto
    Private examen As ExamenLaboratorio
    Private kitequipo As KitEquipoLaboratorio

    Private valorInicio As Double
    Private valorFin As Double
    Private sexo As Char
    Private edadInicio As Short
    Private edadFin As Short

    Public Sub New()
        codigo = 0
        tipo = New Concepto()
        examen = New ExamenLaboratorio()
        kitequipo = New KitEquipoLaboratorio()

        valorInicio = 0
        valorFin = 0
        sexo = ""
        edadInicio = 0
        edadFin = 0
    End Sub



    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Long
        Return codigo
    End Function



    Public Sub setTipo(ByRef _tipo As Concepto)
        tipo = _tipo
    End Sub

    Public Function getTipo() As Concepto
        Return tipo
    End Function



    Public Sub setExamen(ByRef _examen As ExamenLaboratorio)
        examen = _examen
    End Sub

    Public Function getExamen() As ExamenLaboratorio
        Return examen
    End Function



    Public Sub setKitEquipo(ByRef _kitEquipo As KitEquipoLaboratorio)
        kitequipo = _kitEquipo
    End Sub

    Public Function getKitEquipo() As KitEquipoLaboratorio
        Return kitequipo
    End Function



    Public Sub setValorInicio(_valorInicio As Double)
        valorInicio = _valorInicio
    End Sub

    Public Function getValorInicio() As Double
        Return valorInicio
    End Function



    Public Sub setValorFin(_valorFin As Double)
        valorFin = _valorFin
    End Sub

    Public Function getValorFin() As Double
        Return valorFin
    End Function



    Public Sub setSexo(_sexo As Char)
        sexo = _sexo
    End Sub

    Public Function getSexo() As Char
        Return sexo
    End Function



    Public Sub setEdadInicio(_edadInicio As Short)
        edadInicio = _edadInicio
    End Sub

    Public Function getEdadInicio() As Short
        Return edadInicio
    End Function



    Public Sub setEdadFin(_edadFin As Short)
        edadFin = _edadFin
    End Sub

    Public Function getEdadFin() As Short
        Return edadFin
    End Function


End Class
