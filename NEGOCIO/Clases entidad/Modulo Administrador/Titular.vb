Public Class Titular
    Inherits Asegurado

    
    'CONSTRUCTOR
    Public Sub New()

    End Sub

    Public Sub New(ByVal _nombre As String, ByVal _matricula As String, ByVal _tipo As String)
        MyBase.New(_nombre, _matricula, _tipo)
    End Sub

    Public Sub New(ByVal _codigo As Int64, ByVal _apPaterno As String, ByVal _apMaterno As String, ByVal _nombres As String,
                    ByVal _matricula As String)

        codigo = _codigo
        apellidoPaterno = _apPaterno
        apellidoMaterno = _apMaterno
        nombres = _nombres
        matricula = _matricula
    End Sub




End Class
