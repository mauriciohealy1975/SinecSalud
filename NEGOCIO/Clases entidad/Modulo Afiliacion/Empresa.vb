Public Class Empresa

    Private codigo As String
    Private nombre As String
    Private nroNit As String
    Private matriculaComercio As String
    Private codigoPatronal As String
    Private nroRoe As String
    Private sector As Concepto
    Private programaproyecto As ProgramaProyecto
    Private entidadDesconcentrada As EntidadDesconcentrada


    Public Sub New()

    End Sub

    Public Sub New(ByVal _codigo As Int16, ByVal _nombre As String)
        codigo = _codigo
        nombre = _nombre
    End Sub




    'SETTERS Y GETTERS
    Public Sub setCodigo(ByVal _codigo As Int16)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int16
        Return codigo
    End Function



    Public Sub setNombre(ByVal _nombre As String)
        nombre = _nombre
    End Sub

    Public Function getNombre()
        Return nombre
    End Function



    Public Function getNit() As String
        Return nroNit
    End Function

    Public Sub setNit(ByVal _nit As String)
        nroNit = _nit
    End Sub



    Public Function getCodigoPatronal() As String
        Return codigoPatronal
    End Function

    Public Sub setCodigoPatronal(ByVal _codigoPatronal As String)
        codigoPatronal = _codigoPatronal
    End Sub



    Public Function getMatriculaComercio() As String
        Return matriculaComercio
    End Function

    Public Sub setMatriculaComercio(ByVal _matriculaComercial)
        matriculaComercio = _matriculaComercial
    End Sub



    Public Function getRoe() As String
        Return nroRoe
    End Function

    Public Sub setRoe(ByVal _nroRoe)
        nroRoe = _nroRoe
    End Sub



    Public Function getSector() As Concepto
        Return sector
    End Function

    Public Sub setSector(ByRef _oSector As Concepto)
        sector = _oSector
    End Sub



    Public Sub setProgramaProyecto(ByRef _oProgramaProyecto As ProgramaProyecto)
        programaproyecto = _oProgramaProyecto
    End Sub

    Public Function getProgramaProyecto() As ProgramaProyecto
        Return programaproyecto
    End Function



    Public Sub setEntidadDesconcentrada(ByRef _oEntidadDesconcentrada As EntidadDesconcentrada)
        entidadDesconcentrada = _oEntidadDesconcentrada
    End Sub

    Public Function getEntidadDesconcetrada() As EntidadDesconcentrada
        Return entidadDesconcentrada
    End Function



    Public Function esPublica() As Boolean
        Dim correlativo As Int64 = sector.getCorrelativo()

        If sector IsNot Nothing Then
            If correlativo = 1 Then Return True Else Return False
        Else
            Return Nothing
        End If
    End Function

End Class
