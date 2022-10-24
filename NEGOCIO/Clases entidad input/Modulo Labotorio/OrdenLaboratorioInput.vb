Public Class OrdenLaboratorioInput

    Public Property codigo As String
    Public Property matriculaAsegurado As String
    Public Property fecha As String
    Public Property codigoMedico As String
    Public Property nombreMedico As String
    Public Property nombreAsegurado As String
    Public Property asegurado As AseguradoInput

    Public Sub New()
        codigo = "0"
        matriculaAsegurado = ""
        fecha = ""
        codigoMedico = "0"
        nombreMedico = ""
        nombreAsegurado = ""
        asegurado = New AseguradoInput()
    End Sub

End Class
