Public Class OpcionResultadoLaboratorioInput

    Public Property codigo As String
    Public Property valor As String
    Public Property conjuntoOpciones As ConjuntoOpcionesResultadosLabInput


    Public Sub New()
        codigo = "0"
        valor = ""
        conjuntoOpciones = New ConjuntoOpcionesResultadosLabInput()
    End Sub

End Class
