Public Class OrdenAtencionEnfermeria

    Private codigo As Int16
    Private fecha As String
    'tipo servicio (consulta externa /  clinica)
    Private tipoServicio As Int16

    Private tipoAsegurado As String
    Private matriculaAsegurado As String
    Private nombreAsegurado As String
    Private codigoMedico As Int16
    Private nombreMedico As String


    Private descripcion As String


    Public Sub New(ByVal _codigo As Int16, ByVal _fecha As String)
        codigo = _codigo
        fecha = _fecha
    End Sub

    Public Sub New()
        codigo = 0
        fecha = ""
        tipoServicio = 0

        tipoAsegurado = ""
        matriculaAsegurado = ""
        nombreAsegurado = ""
        codigoMedico = 0
        nombreMedico = ""
    End Sub



    Public Function getCodigo() As Int16
        Return codigo
    End Function

    Public Sub setCodigo(ByVal _codigo As Int16)
        codigo = _codigo
    End Sub

    Public Function getFecha() As String
        Return fecha
    End Function

    Public Sub setFecha(ByVal _fecha As String)
        fecha = _fecha
    End Sub

    Public Function getTipoServicio() As Int16
        Return tipoServicio
    End Function

    Public Sub setTipoServicio(ByVal _tipoServicio)
        tipoServicio = _tipoServicio
    End Sub

    Public Function getMatriculaAsegurado() As Int16
        Return matriculaAsegurado
    End Function

    Public Sub setMatriculaAsegurado(ByVal _matriculaAsegurado As String)
        matriculaAsegurado = _matriculaAsegurado
    End Sub

    Public Function getNombreAsegurado() As Int16
        Return nombreAsegurado
    End Function

    Public Sub setNombreAsegurado(ByVal _nombreAsegurado As String)
        nombreAsegurado = _nombreAsegurado
    End Sub

    Public Function getCodigoMedico() As Int16
        Return codigoMedico
    End Function

    Public Sub setCodigoMedico(ByVal _codigoMedico)
        codigoMedico = _codigoMedico
    End Sub

    Public Function getNombreMedico() As Int16
        Return nombreMedico
    End Function

    Public Sub setNombreMedico(ByVal _nombreMedico)
        nombreMedico = _nombreMedico
    End Sub




    Public Sub generarDescripcion()
        descripcion = "ORDEN " + codigo.ToString() + " | " + nombreAsegurado + " | " + fecha
    End Sub

    Public Function getDescripcion() As String
        Return descripcion
    End Function

End Class