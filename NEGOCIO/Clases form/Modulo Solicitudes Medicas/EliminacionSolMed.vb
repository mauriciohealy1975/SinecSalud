Imports DAL

Public Class registroEliminacionSolicitudMedica

    'ATRIBUTOS LÓGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G2
    Public fechas As FiltroFecha()

    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS LÓGICOS
        dal = New TDatosSql(False)

        'ATRIBUTOS G2
    End Sub





    'METODOS FUNCIONALES G1
    Public Sub traerFechasSolicitudesMedicas(_fecha As String)
        Dim objDTable As DataTable = traerFechasSolicitudesMedicasBD(_fecha), index As Short = 0
        fechas = New FiltroFecha(objDTable.Rows.Count - 1) {}

        For Each row As DataRow In objDTable.Rows
            Dim fecha As String = row("fecha").ToString()
            Dim objFiltroFecha = New FiltroFecha(fecha)
            fechas(index) = objFiltroFecha
            index += 1
        Next
    End Sub

    Public Function traerSolicitudesMedicas(_fecha As String) As DataTable
        Return traerSolicitudesMedicasBD(_fecha)
    End Function


    Public Function encontrarFiltroFecha(ByVal _mensaje) As String
        For Each obAuxFiltroFecha As FiltroFecha In fechas
            If obAuxFiltroFecha.getMensaje = _mensaje Then
                Return obAuxFiltroFecha.getFecha()
            End If
        Next

        Return Nothing
    End Function

    Public Sub eliminarSolMed(ByVal _codSol As Int16, ByVal _nombreForm As String, ByVal _codUsu As Int16)
        eliminarSolMedBD(_codSol)
        guardarTransaccionEliminarBD(_nombreForm, _codUsu)
    End Sub




    'METODOS QUE USAN BD
    Private Function traerFechasSolicitudesMedicasBD(ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _fecha
        Return (dal.TraerDataTable("SP_traerFechasSolEnAdelante", P))
    End Function

    Private Function traerSolicitudesMedicasBD(ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _fecha
        Return (dal.TraerDataTable("SP_traerSolMedPorFecha", P))
    End Function

    Private Sub eliminarSolMedBD(ByVal _codSol As Int16)
        Dim P As Object() = New Object(0) {}
        P(0) = _codSol
        dal.Ejecutar("SP_eliminarSolMed", P)
    End Sub

    Private Sub guardarTransaccionEliminarBD(ByVal _nombreFormulatrio As String, ByVal _codUsuario As String)
        Dim P As Object() = New Object(3) {}
        P(0) = _nombreFormulatrio
        P(1) = _codUsuario

        'TABLA CONCEPTO 'prefijo (tipotransaccion)
        P(2) = 2
        'TABLA CONCEPTO 'correlativo (eliminar)
        P(3) = 2

        dal.Ejecutar("SP_guardarTransaccion", P)
    End Sub




End Class
