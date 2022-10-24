Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data

Public Class Csinec
    Private objDatos As DAL.TDatosSql


    'METODOS BASE
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub

    Public Sub Generar(ByVal Cua As Integer, ByVal Pro As String)
        Dim ORan As Random = New Random()
        Dim P As Object() = New Object(2) {}

        For V As Integer = 0 To Cua - 1
            P(0) = Pro & "-" & (V + 1).ToString()
            P(1) = ORan.[Next](1, 100)
            P(2) = ORan.[Next](500, 5000)
            objDatos.Ejecutar("spInsertar", P)
        Next
    End Sub

    Public Sub Insertar(ByVal pnom As String, ByVal pstock As Integer, ByVal pprecio As Integer)
        Dim P As Object() = New Object(2) {}
        P(0) = pnom
        P(1) = pstock
        P(2) = pprecio
        objDatos.Ejecutar("spInsertar", P)
    End Sub

    Public Sub Insertar2(ByVal _username As String, ByVal _contrasenha As String)
        Dim P As Object() = New Object(1) {}
        P(0) = _username
        P(1) = _contrasenha
        objDatos.Ejecutar("spInsertar", P)
    End Sub

    Public Sub Actualizar(ByVal pcod As Integer, ByVal pnom As String, ByVal pstock As Integer, ByVal pprecio As Integer)
        Dim P As Object() = New Object(3) {}
        P(0) = pcod
        P(1) = pnom
        P(2) = pstock
        P(3) = pprecio
        objDatos.Ejecutar("spActualizar", P)
    End Sub

    Public Sub fullBackup(ByVal NombreArc As String)
        Dim P As Object() = New Object(0) {}
        P(0) = NombreArc
        objDatos.Ejecutar("spFULLBACKUP", P)
    End Sub

    Public Sub differentialBackup(ByVal NombreArc As String)
        Dim P As Object() = New Object(0) {}
        P(0) = NombreArc
        objDatos.Ejecutar("spDifferentialBackup", P)
    End Sub

    Public Sub TLogBackup(ByVal NombreArc As String)
        Dim P As Object() = New Object(0) {}
        P(0) = NombreArc
        objDatos.Ejecutar("spTLogBackup", P)
    End Sub

    Public Sub DañarBaseDatos()
        objDatos.Ejecutar("spDañarBD")
    End Sub

    Public Function buscarPorNroDoc(ByVal _nroDocumento) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = "%" + _nroDocumento + "%"
        Return (objDatos.TraerDataTable("spBuscarPorNroDoc", P))
    End Function

    Public Function buscarPorNombre(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = "%" + _nombre + "%"
        Return (objDatos.TraerDataTable("spBuscarPorNombre", P))
    End Function


    Public Function revisarTiFRepetidaTi(ByVal _matAse As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matAse
        P(1) = _fecha
        Return (objDatos.TraerDataTable("SP_TiCheckFUsedT", P))
    End Function

    Public Function revisarTiFRepetidaBe(ByVal _matAse As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matAse
        P(1) = _fecha
        Return (objDatos.TraerDataTable("SP_TiCheckFUsedB", P))
    End Function

    Public Function revisarBeFRepetidaTi(ByVal _matAse As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matAse
        P(1) = _fecha
        Return (objDatos.TraerDataTable("SP_BeCheckFUsedTi", P))
    End Function

    Public Function revisarBeFRepetidaBe(ByVal _matTitular As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matTitular
        P(1) = _fecha
        Return (objDatos.TraerDataTable("SP_BeCheckFUsedB", P))
    End Function


    Public Function traerMTitularDeBen(ByVal _matBeneficiario As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matBeneficiario
        Return (objDatos.TraerDataTable("traerMTdeBeneficiario", P))
    End Function

End Class
