Public Class Usuario

    Public Shared tipoUsuUserLoggedSystem As Long
    Public Shared codUserLoggedSystem As Long
    Public Shared nameUserLoggedSystem As String = ""
    Public Shared NomTipoUserLoggedSystem As String = ""


    Private codigo As Long
    Private tipo As Concepto
    Private username As String
    Private contraseña As String

    Private apellidoPaterno As String
    Private apellidoMaterno As String
    Private nombres As String
    Private telefono As String

    Private area As AreaTrabajo
    Private puesto As PuestoTrabajo

    Public Sub New()

        codigo = 0
        tipo = New Concepto()

        username = ""
        contraseña = ""

        apellidoPaterno = ""
        apellidoMaterno = ""
        nombres = ""
        telefono = ""

        area = New AreaTrabajo()
        puesto = New PuestoTrabajo()
    End Sub

    Public Shared Sub guardarDatos(ByVal _Tcodigo, ByVal _codigo, ByVal _nombre, _NomTipo)
        tipoUsuUserLoggedSystem = _Tcodigo
        codUserLoggedSystem = _codigo
        nameUserLoggedSystem = _nombre
        NomTipoUserLoggedSystem = _NomTipo
    End Sub

    Public Shared Sub limpiarDatos()
        codUserLoggedSystem = 0
        nameUserLoggedSystem = ""
        NomTipoUserLoggedSystem = ""
        tipoUsuUserLoggedSystem = 0
    End Sub





    '------------------------------------------------------
    Public Function getCodigo() As Long
        Return codigo
    End Function


    Public Sub setCodigo(_codigo As Long)
        codigo = _codigo
    End Sub



    Public Sub setTipo(ByRef _tipo As Concepto)
        tipo = _tipo
    End Sub

    Public Function getTipo() As Concepto
        Return tipo
    End Function



    Public Function getUsername() As String
        Return username
    End Function

    Public Sub setUsername(ByVal _username As String)
        username = _username
    End Sub



    Public Function getContraseña() As String
        Return contraseña
    End Function

    Public Sub setContraseña(ByVal _contraseña As String)
        contraseña = _contraseña
    End Sub



    Public Function getApellidoPaterno() As String
        Return apellidoPaterno
    End Function

    Public Sub setApellidoPaterno(ByVal _apellidoPaterno As String)
        apellidoPaterno = _apellidoPaterno
    End Sub



    Public Function getApellidoMaterno() As String
        Return apellidoMaterno
    End Function

    Public Sub setApellidoMaterno(ByVal _apellidoMaterno As String)
        apellidoMaterno = _apellidoMaterno
    End Sub



    Public Function getNombres() As String
        Return nombres
    End Function

    Public Sub setNombres(ByVal _nombres As String)
        nombres = _nombres
    End Sub



    Public Function getTelefono() As String
        Return telefono
    End Function

    Public Sub setTelefono(ByVal _telefono As String)
        telefono = _telefono
    End Sub



    Public Function getArea() As AreaTrabajo
        Return area
    End Function

    Public Sub setArea(ByRef _oArea As AreaTrabajo)
        area = _oArea
    End Sub



    Public Function getPuesto() As PuestoTrabajo
        Return puesto
    End Function

    Public Sub setPuesto(ByRef _oPuesto As PuestoTrabajo)
        puesto = _oPuesto
    End Sub


End Class
