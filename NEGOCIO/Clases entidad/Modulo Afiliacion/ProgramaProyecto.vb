Public Class ProgramaProyecto
    Private codigo As Int64
    Private nombre As String
    Private tipo As Int16
    Private oEmpresa As Empresa

    Public Sub New()

    End Sub



    Public Sub setCodigo(ByVal _codigo As Int64)
        codigo = _codigo
    End Sub

    Public Function getCodigo() As Int64
        Return codigo
    End Function



    Public Sub setNombre(ByVal _nombre As String)
        nombre = _nombre
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function



    Public Sub setTipo(ByVal _tipo As Int16)
        tipo = _tipo
    End Sub

    Public Function getTipo() As Int16
        Return tipo
    End Function



    Public Sub setEmpresa(ByRef _oEmpresa)
        oEmpresa = _oEmpresa
    End Sub

    Public Function getEmpresa() As Empresa
        Return oEmpresa
    End Function


End Class
