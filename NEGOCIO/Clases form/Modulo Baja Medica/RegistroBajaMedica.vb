Public Class RegistroBajaMedica

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public listaAsegurados As Asegurado()
    Public oAsegurado As Asegurado
    Public oBajaMedica As BajaMedica = New BajaMedica()


    Sub New()

    End Sub


    Public Sub traerAsegurados(ByVal _nombre)
        Dim objDTable As DataTable
        Dim index As Int16

        objDTable = traerAseguradosBD(_nombre)
        listaAsegurados = New Asegurado(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim nombre As String = row("ASEGURADO").ToString()
            Dim matricula As String = row("MATRICULA").ToString()

            Dim oAseguradoAux As Asegurado = New Asegurado(nombre, matricula)
            listaAsegurados(index) = oAseguradoAux
            listaAsegurados(index).generarDescripcion()
            index += 1
        Next

    End Sub

    Public Sub buscarAsegurado(ByVal _descripcion As String)
        If Not _descripcion = Nothing Then
            For Each asegurado As Asegurado In listaAsegurados
                If asegurado.getDescripcion() = _descripcion Then
                    oAsegurado = asegurado
                End If
            Next
        End If

    End Sub

    Public Function guardarBajaMedica() As Int16
        Dim respuesta As Int16 = guardarBajaMedicaBD()
        Return respuesta
    End Function

    Public Function validarEntradas() As String
        Dim respuesta As String = revisarCamposVacios()

        If Not respuesta = "" Then
            Return respuesta
        End If

        respuesta = validarDiasEnLiteral(oBajaMedica.getDiasLiteral())
        Return respuesta


    End Function

    Private Function revisarCamposVacios() As String
        If oBajaMedica.getLugarAtencion() = 0 Then
            Return "Error: Elija un Lugar de Atención antes de guardar los datos"

        ElseIf oBajaMedica.getRegimen() = 0 Then
            Return "Error: Elija un Regimen antes de guardar los datos"

        ElseIf oBajaMedica.getTratamiento() = 0 Then
            Return "Error: Elija un Tratamiento antes de guardar los datos"

        ElseIf oBajaMedica.getInicioPeriodoIncapacidad() = "" Then
            Return "Error: Seleccione la fecha de inicio de la baja medica antes de guardar los datos"

        ElseIf oBajaMedica.getFinPeriodoIncapacidad() = "" Then
            Return "Error: Seleccione la fecha del fin de la baja medica antes de guardar los datos"

        ElseIf oBajaMedica.getNroDias = 0 Then
            Return "Error: Ingrese la cantidad de días que dura la baja médica"

        ElseIf oBajaMedica.getDiasLiteral = "" Then
            Return "Error: Ingrese la cantidad de dias (literal) que dura la baja médica"

        End If

        Return ""
    End Function

    Private Function validarDiasEnLiteral(ByVal _diasLiteral) As String
        For Each caracter As Char In _diasLiteral
            If caracter = "0" Or caracter = "1" Or caracter = "2" Or caracter = "3" Or caracter = "4" Or caracter = "5" Or caracter = "6" Or caracter = "7" Or caracter = "8" Or caracter = "9" Then
                Return "Error: El campo de ""días en literal"" no puede contener números"
            End If
        Next

        Return ""
    End Function






    'METODOS BD
    Private Function traerAseguradosBD(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre
        Return (objDAL.TraerDataTable("SPtraerAsegurados", P))

    End Function

    Private Function guardarBajaMedicaBD() As Int16
        Dim P As Object() = New Object(8) {}
        P(0) = oBajaMedica.getMatriculaAsegurao()
        P(1) = oBajaMedica.getLugarAtencion()
        P(2) = oBajaMedica.getRegimen()
        P(3) = oBajaMedica.getTratamiento()
        P(4) = oBajaMedica.getInicioPeriodoIncapacidad()
        P(5) = oBajaMedica.getFinPeriodoIncapacidad()
        P(6) = oBajaMedica.getNroDias()
        P(7) = oBajaMedica.getDiasLiteral()
        P(8) = Usuario.codUserLoggedSystem


        Dim respuesta = objDAL.Ejecutar("SPguardarBajaMedica", P)
        Return respuesta
    End Function


End Class
