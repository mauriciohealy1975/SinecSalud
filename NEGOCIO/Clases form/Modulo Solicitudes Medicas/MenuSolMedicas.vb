Public Class MenuSolMedicas

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public cantidadSolMedProg As Int16 = 0

    'INICIO
    Public Sub New()
        cantidadSolMedProg = traerCantidadSolMedProg()
    End Sub




    'METODO SOL MED PROG
    Public Function traerCantidadSolMedProg() As Int16
        Dim objDTable As DataTable
        Dim fecha As String = Date.Today.ToString("yyyy-MM-dd")
        Dim cantidad As Int16 = 0

        objDTable = traerCantidadSolMedProgBD(fecha)
        Dim index As Int16 = 0
        For Each row As DataRow In objDTable.Rows
            cantidad = row("cantidad").ToString()
            index += 1

        Next

        Return cantidad
    End Function




    'METODOS QUE UTILIZAN BD
    Private Function traerCantidadSolMedProgBD(ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _fecha
        Return (objDAL.TraerDataTable("SP_traerCantSolMedProg", P))
    End Function

End Class
