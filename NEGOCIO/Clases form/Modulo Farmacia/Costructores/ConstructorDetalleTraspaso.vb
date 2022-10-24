Public Class ConstructorDetalleTraspaso
    Private CodTraspaso As Long

    Public Sub New()
        CodTraspaso = 0
    End Sub

#Region "Get"
    Public Function GetCodTraspaso()
        Return CodTraspaso
    End Function
#End Region
#Region "set"
    Public Sub SetCodTraspaso(ByVal _CodTraspaso As Long)
        CodTraspaso = _CodTraspaso
    End Sub

#End Region
End Class
