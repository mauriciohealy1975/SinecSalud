Imports DAL


Public Class RegistroResultadoLabTipoValorTextual

    'ATRIBUTOS LOGICOS
    Private dal As TDatosSql

    'ATRIBUTOS G1
    Public procesadores As Usuario()


    'METODOS INICIO
    Public Sub New()
        dal = New TDatosSql(False)
        procesadores = New Usuario(-1) {}
    End Sub

    Public Sub iniciarProcesos()

    End Sub


    'METODOS FUNCIONALES G1
    Public Sub traerProcesadores()
        Dim datatable As DataTable = traerProcesadoresBD(), index As Short = 0
        procesadores = New Usuario(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim codigo As Long, codTipo As Short, apPaterno As String, apMaterno As String, nombres As String

            If IsDBNull(row("CODUSU USU")) Then codigo = 0 Else codigo = Long.Parse(row("CODUSU USU"))
            If IsDBNull(row("CODTIP USU")) Then codTipo = 0 Else codTipo = Short.Parse(row("CODTIP USU"))
            If IsDBNull(row("APEPAT USU")) Then apPaterno = "" Else apPaterno = row("APEPAT USU").ToString()
            If IsDBNull(row("APEMAT USU")) Then apMaterno = "" Else apMaterno = row("APEMAT USU").ToString()
            If IsDBNull(row("NOM USU")) Then nombres = "" Else nombres = row("NOM USU").ToString()

            'If IsDBNull(row("")) Then  = 0 Else  = Long.Parse(row(""))
            'If IsDBNull(row("")) Then  = "" Else  = row("").ToString()
            'If IsDBNull(row("")) Then  = "" Else  = Date.Parse(row(""))

            Dim tipo As New Concepto()
            tipo.setCorrelativo(codTipo)

            Dim procesador As New Usuario()
            procesador.setCodigo(codigo)
            procesador.setTipo(tipo)
            procesador.setApellidoPaterno(apPaterno)
            procesador.setApellidoMaterno(apMaterno)
            procesador.setNombres(nombres)

            procesadores(index) = procesador
            index += 1
        Next
    End Sub




    'METODOS BD G1
    Private Function traerProcesadoresBD() As DataTable
        Return (dal.TraerDataTable("SPtraerProcesadores_RegResultadosTipoTextual"))
    End Function




    'METODOS VALIDACIÓN
    Public Function validarEntradas(ByRef _inputResultado As ResultadoLaboratorioInput, _modoTipoUsuario As Short)
        Dim mensaje As String

        If _modoTipoUsuario = 4 Then
            mensaje = validarProcesador(_inputResultado.procesador)
            If Not mensaje = "" Then Return mensaje
        End If

        mensaje = validarResultadoTextual(_inputResultado.valorTipoTextual)
        If Not mensaje = "" Then Return mensaje

        'mensaje = validarProcesador("0")
        'If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Public Function validarProcesador(ByRef _procesador As UsuarioInput)
        If Long.Parse(_procesador.codigo) = 0 Then Return "Error. Seleccione un procesador."
        Return ""
    End Function

    Private Function validarResultadoTextual(ByRef _resultado As String)
        If _resultado = "" Then Return "Error. Ingrese un resultado."
        Return ""
    End Function

End Class
