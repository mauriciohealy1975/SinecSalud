Imports DAL
Public Class ConfirmacionOrdenLaboratorio

    'ATRIBUTOS LÓGICOS
    'Private dal As TDatosSql

    'ATRIBUTOS G1
    Public datatableAsegurado As DataTable
    Public dataAsegurado As DataTable
    Public dataMedico As DataTable
    Public dataUsuario As DataTable




    'METODOS INICIO
    Public Sub New()
        'ATRIBUTOS G1
        datatableAsegurado = New DataTable()
        dataAsegurado = New DataTable()
        dataMedico = New DataTable()
        dataUsuario = New DataTable()
    End Sub

    Public Sub iniciarProcesos()

    End Sub










    'METODOS FUNCIONALES G1

    Public Sub cargarDatosAsegurado(_asegurado As Asegurado)
        Dim dcNombre As DataColumn, dcMatricula As DataColumn, dcSexo As DataColumn, dcEdad As DataColumn,
            nombreCompleto As String, matricula As String, sexo As String, edad As String

        dcNombre = New DataColumn("nombreAsegurado", GetType(String))
        dcMatricula = New DataColumn("matriculaAsegurado", GetType(String))
        dcSexo = New DataColumn("sexoAsegurado", GetType(String))
        dcEdad = New DataColumn("edadAsegurado", GetType(String))

        dataAsegurado.Columns.Add(dcNombre)
        dataAsegurado.Columns.Add(dcMatricula)
        dataAsegurado.Columns.Add(dcSexo)
        dataAsegurado.Columns.Add(dcEdad)


        nombreCompleto = Trim(_asegurado.getApellidoPaterno()) + " " + Trim(_asegurado.getApellidoMaterno()) + " " + Trim(_asegurado.getNombres())
        nombreCompleto = Trim(nombreCompleto)
        matricula = _asegurado.getMatricula()
        sexo = _asegurado.getSexo()
        If sexo = "M" Then sexo = "MASCULINO" Else sexo = "FEMENINO"
        edad = Utilitarios.calcularEdad(_asegurado.getFechaNacimiento())


        dataAsegurado.Rows.Add(nombreCompleto, matricula, sexo, edad)
    End Sub

    Public Sub cargarDatosMedico(_medico As Medico)
        Dim dcNombre As DataColumn, dcEspecialidad As DataColumn, usuarioMedico As Usuario, nombreMedico As String,
            nombreEspecialidad As String

        dcNombre = New DataColumn("nombreMedico", GetType(String))
        dcEspecialidad = New DataColumn("especialidadMedico", GetType(String))

        dataMedico.Columns.Add(dcNombre)
        dataMedico.Columns.Add(dcEspecialidad)

        usuarioMedico = _medico.getUsuario()
        nombreMedico = Trim(usuarioMedico.getApellidoPaterno()) + " " + Trim(usuarioMedico.getApellidoMaterno()) + " " + Trim(usuarioMedico.getNombres())
        nombreMedico = Trim(nombreMedico)
        nombreEspecialidad = _medico.getEspecialidad().getnombre()

        dataMedico.Rows.Add(nombreMedico, nombreEspecialidad)
    End Sub

    Public Sub cargarDatosUsusario()
        Dim dcNombre As DataColumn, nombreUsuario As String

        dcNombre = New DataColumn("nombreUsuario", GetType(String))

        dataUsuario.Columns.Add(dcNombre)

        nombreUsuario = Trim(Usuario.nameUserLoggedSystem)

        dataUsuario.Rows.Add(nombreUsuario)
    End Sub


End Class
