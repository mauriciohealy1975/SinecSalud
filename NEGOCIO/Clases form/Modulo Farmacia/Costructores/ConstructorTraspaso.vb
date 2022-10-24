Public Class ConstructorTraspaso
    Private CodTraspaso As Long
    Private CodAlmEmisor As Long
    Private CodAlmRecept As Long
    Private Estado As Long
    Private Observacion As String
    Private UsuEmisor As Long
    Private UsuReceptor As Long
    Public Sub New()
        CodTraspaso = 0
        CodAlmEmisor = 0
        CodAlmRecept = 0
        Estado = 0
        Observacion = ""
        UsuEmisor = 0
        UsuReceptor = 0
    End Sub

#Region "Get"
    Public Function GetCodTraspaso() As Long
        Return CodTraspaso
    End Function
    Public Function GetCodAlmEmisor() As Long
        Return CodAlmEmisor
    End Function
    Public Function GetCodAlmRecept() As Long
        Return CodAlmRecept
    End Function
    Public Function GetEstado() As Long
        Return Estado
    End Function
    Public Function GetObservacion() As Long
        Return Observacion
    End Function
    Public Function GetUsuEmisor() As Long
        Return UsuEmisor
    End Function
    Public Function GetUsuReceptor() As Long
        Return UsuReceptor
    End Function
#End Region
#Region "Set"
    Public Sub SetCodTraspaso(ByVal _CodTraspaso As Long)
        CodTraspaso = _CodTraspaso
    End Sub
    Public Sub SetCodAlmEmisor(ByVal _CodAlmEmisor As Long)
        CodAlmEmisor = _CodAlmEmisor
    End Sub
    Public Sub SetCodAlmRecept(ByVal _CodAlmRecept As Long)
        CodAlmRecept = _CodAlmRecept
    End Sub
    Public Sub SetEstado(ByVal _Estado As Long)
        Estado = _Estado
    End Sub
    Public Sub SetObservacion(ByVal _Observacion As String)
        Observacion = _Observacion
    End Sub
    Public Sub SetUsuEmisor(ByVal _UsuEmisor As Long)
        UsuEmisor = _UsuEmisor
    End Sub
    Public Sub SetUsuReceptor(ByVal _UsuReceptor As Long)
        UsuReceptor = _UsuReceptor
    End Sub
#End Region
End Class
