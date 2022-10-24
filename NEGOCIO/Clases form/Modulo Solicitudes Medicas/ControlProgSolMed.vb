
Public Class ControlProgSolMed

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Private tipoAsegurado As String = ""
    Public obJAsegurado As Asegurado
    Public objTitular As Titular
    Public objBeneficiario As Beneficiario
    Private fechaProgramacion As String = ""


    'GETTERS Y SETTERS
    Public Sub setTipoAsegurado(ByVal _tipo As String)
        'TITULAR
        'BENEFICIARIO
        tipoAsegurado = _tipo
    End Sub

    Public Function getTipoAsegurado()
        Return tipoAsegurado
    End Function

    Public Function getFechaProgramacion()
        Return fechaProgramacion
    End Function

    Public Sub setFechaProgramacion(ByVal _fecha As String)
        fechaProgramacion = _fecha
    End Sub




    'METODOS ASEGURADO
    Public Sub guardarAsegurado(ByVal _nombre As String, ByVal _matricula As String, ByVal _tipo As String)
        If tipoAsegurado = "TITULAR" Then
            objTitular = New Titular(_nombre, _matricula, _tipo)
            obJAsegurado = objTitular
            objBeneficiario = Nothing
        Else
            objBeneficiario = New Beneficiario(_nombre, _matricula, _tipo)
            asignarMatriculaTitular()
            obJAsegurado = objBeneficiario
            objTitular = Nothing
        End If

    End Sub

    Public Function buscarAsegurado(ByVal _nombre) As DataTable
        Return (buscarAseguradosPorNomBD(_nombre))
    End Function


    Private Sub asignarMatriculaTitular()
        Dim objDTable As DataTable
        Dim matTitular As String = ""

        objDTable = traerMatriculaTitularBD(objBeneficiario.getMatricula())
        For Each row As DataRow In objDTable.Rows
            matTitular = row("mat titular").ToString()
            objBeneficiario.setMatTitular(matTitular)
        Next

    End Sub




    'METODOS REVISAR DERECHO DE FICHA
    Public Function revisarDerechoFicha() As Boolean
        Dim respuestaTiCheckTi As Boolean
        Dim respuestaTiCheckBe As Boolean
        Dim respuestaBeCheckTi As Boolean
        Dim respuestaBeCheckBe As Boolean

        If tipoAsegurado = "TITULAR" Then
            respuestaTiCheckTi = revisarTitularFTiular()
            respuestaTiCheckBe = revisarTitularFBeneficiario()

            If respuestaTiCheckTi And respuestaTiCheckBe Then
                Return True
            Else
                Return False
            End If

        Else
            respuestaBeCheckTi = revisarBeneficiarioFTitular()
            respuestaBeCheckBe = revisarBeneficiarioFBeneficiario()

            If respuestaBeCheckTi And respuestaBeCheckBe Then
                Return True
            Else
                Return False
            End If

        End If

    End Function

    Private Function revisarTitularFTiular() As Boolean
        Dim objDTable As DataTable
        Dim registros As Int16 = 0

        objDTable = revisarTiFRepetidaTi(objTitular.getMatricula(), fechaProgramacion)

        For Each row As DataRow In objDTable.Rows
            registros = Integer.Parse(row("registros").ToString())
        Next

        If registros = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function revisarTitularFBeneficiario() As Boolean
        Dim objDTable As DataTable
        Dim registros As Int16 = 0

        objDTable = revisarTiFRepetidaBe(objTitular.getMatricula(), fechaProgramacion)

        For Each row As DataRow In objDTable.Rows
            registros = Integer.Parse(row("registros").ToString())
        Next

        If registros = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function revisarBeneficiarioFTitular() As Boolean
        Dim objDTable As DataTable
        Dim registros As Int16 = 0

        objDTable = revisarBeFRepetidaTi(objBeneficiario.getMatriculaTitular(), fechaProgramacion)

        For Each row As DataRow In objDTable.Rows
            registros = Integer.Parse(row("registros").ToString())
        Next

        If registros = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function revisarBeneficiarioFBeneficiario() As Boolean
        Dim objDTable As DataTable
        Dim registros As Int16 = 0

        objDTable = revisarBeFRepetidaBe(objBeneficiario.getMatriculaTitular(), fechaProgramacion)

        For Each row As DataRow In objDTable.Rows
            registros = Integer.Parse(row("registros").ToString())
        Next

        If registros = 0 Then
            Return True
        Else
            Return False
        End If
    End Function




    'METODOS QUE USAN BD
    Public Function TraerPacientePormatricula(ByVal _matricula) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDAL.TraerDataTable("SpTraerPacientePorMatricula", P))
    End Function
    Private Function buscarAseguradosPorNomBD(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = "%" + _nombre + "%"
        Return (objDAL.TraerDataTable("spBuscarPorNombre", P))
    End Function

    Private Function traerMatriculaTitularBD(ByVal _matBeneficiario As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matBeneficiario
        Return (objDAL.TraerDataTable("traerMTdeBeneficiario", P))
    End Function

    Public Function revisarTiFRepetidaTi(ByVal _matAse As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matAse
        P(1) = _fecha
        Return (objDAL.TraerDataTable("SP_TiCheckFUsedT", P))
    End Function

    Public Function revisarTiFRepetidaBe(ByVal _matAse As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matAse
        P(1) = _fecha
        Return (objDAL.TraerDataTable("SP_TiCheckFUsedB", P))
    End Function

    Public Function revisarBeFRepetidaTi(ByVal _matAse As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matAse
        P(1) = _fecha
        Return (objDAL.TraerDataTable("SP_BeCheckFUsedTi", P))
    End Function

    Public Function revisarBeFRepetidaBe(ByVal _matTitular As String, ByVal _fecha As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _matTitular
        P(1) = _fecha
        Return (objDAL.TraerDataTable("SP_BeCheckFUsedB", P))
    End Function

End Class
