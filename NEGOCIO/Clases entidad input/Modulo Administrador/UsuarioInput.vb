Public Class UsuarioInput

    Public Property codigo As String
    Public Property tipo As ConceptoInput
    Public Property username As String
    Public Property contraseña As String
    Public Property apellidoPaterno As String
    Public Property apellidoMaterno As String
    Public Property nombres As String
    Public Property telefono As String


    Public Sub New()
        codigo = "0"
        tipo = New ConceptoInput()
        username = ""
        contraseña = ""
        apellidoPaterno = ""
        apellidoMaterno = ""
        nombres = ""
        telefono = ""
    End Sub


End Class
