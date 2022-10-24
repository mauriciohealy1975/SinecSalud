Imports System.Windows.Forms

Public Class ConfirmacionSolMed

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)


    'METODOS SOL MED PROG
    Public Function traerSolMedProgramadasHoy() As DataTable
        Dim fecha As String = DateTime.UtcNow.ToString("yyyy-MM-dd")
        Return traerSolMedProgramadasBD(fecha)

    End Function

    Public Sub confirmarSolicitudes(ByRef listaFilasSeleccionadas As List(Of DataGridViewRow))
        For Each row As DataGridViewRow In listaFilasSeleccionadas
            Dim codigo As Int16 = 0
            codigo = Int16.Parse(row.Cells("COD SOL").Value)
            confirmarSolMedBD(codigo)
        Next

    End Sub




    'METODOS QUE UTILIZAN BD
    Private Function traerSolMedProgramadasBD(ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _fecha
        Return (objDAL.TraerDataTable("SP_traerSolMedProgramadas", P))
    End Function

    Private Sub confirmarSolMedBD(ByVal _csol As String)
        Dim P As Object() = New Object(0) {}
        P(0) = _csol
        objDAL.Ejecutar("SP_confirmarSolMed", P)
    End Sub


End Class
