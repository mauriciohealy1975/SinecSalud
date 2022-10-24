Public Class RegistroTransferenciaMedica

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public listaEspecialidades As Especialidad()
    Public listaPacientes As Asegurado()
    Public oAsegurado As Asegurado
    Public codigoEspecialidad As Int16
    Public oTransferenciaMedica As TransferenciaMedica




    'METODOS FUNCIONALES
    Public Sub traerEspecialidades(ByVal _edad As String)
        Dim objDTable As DataTable
        Dim index As Int16

        objDTable = traerEspPorEdadBD(_edad)
        listaEspecialidades = New Especialidad(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim id As Int16 = 0
            Dim especialidad As String = ""

            id = row("id").ToString()
            especialidad = row("especialidad").ToString()
            listaEspecialidades(index) = New Especialidad(id, especialidad)

            index += 1
        Next
    End Sub

    Public Sub traerPacientes(ByVal _nombre As String)
        Dim objDTable As DataTable
        Dim index As Int16

        objDTable = traerPacientesBD(_nombre)
        listaPacientes = New Asegurado(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim matricula As String = ""
            Dim nombrePaciente As String = ""
            Dim edad As Int16 = 0

            matricula = row("MATRICULA").ToString()
            nombrePaciente = row("PACIENTE").ToString()
            edad = Int16.Parse(row("EDAD"))
            listaPacientes(index) = New Asegurado(nombrePaciente, matricula)
            listaPacientes(index).setEdad(edad)
            listaPacientes(index).generarDescripcion()
            index += 1
        Next
    End Sub

    Public Function buscarPaciente(ByVal _descripcion As String) As Asegurado


        If Not _descripcion = Nothing Then
            For Each asegurado As Asegurado In listaPacientes
                If asegurado.getDescripcion() = _descripcion Then
                    Return asegurado
                End If
            Next
        Else
            Return Nothing
        End If

        Return Nothing

    End Function

    Public Function buscarCodigoEspecialidad(ByVal _nombreEspecialidad) As Int16
        Dim codEspc As Int16 = 0

        For Each especialidad As Especialidad In listaEspecialidades
            If _nombreEspecialidad = especialidad.getnombre Then
                codEspc = especialidad.getCodigo()
                Exit For
            End If
        Next

        Return codEspc
    End Function

    Public Function guardarTransferenciaMedica() As Int16
        Dim respuesta As Int16 = guardarTransferenciaMedBD()
        Return respuesta

    End Function






    'METODOS QUE USAN BD
    Private Function traerPacientesBD(ByVal _nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = "%" + _nombre + "%"
        Return (objDAL.TraerDataTable("spBuscarYTraerDatosAse", P))
    End Function

    Private Function traerEspPorEdadBD(ByVal _edad As Integer) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _edad
        Return (objDAL.TraerDataTable("SPTraerEspcPorEdad", P))
    End Function

    Private Function guardarTransferenciaMedBD() As Int16
        Dim P As Object() = New Object(4) {}
        P(0) = oTransferenciaMedica.getMatriculaAsegurado()
        P(1) = oTransferenciaMedica.getCodigoUsuario()
        P(2) = oTransferenciaMedica.getCodigoEspecialidad()
        P(3) = oTransferenciaMedica.getDiagnostico()
        P(4) = oTransferenciaMedica.getFecha()


        Dim respuesta As Int16 = objDAL.Ejecutar("SPguardarTransferenciaMed", P)
        Return respuesta

    End Function



End Class
