Public Class RegistroUsuario

    Private ReadOnly objDAL As New DAL.TDatosSql(False)
    Public modoFormulario As Int16


    'ATRIBUTOS G1
    Public tiposUsuarios As Concepto()

    Public listaAreasTrabajo() As AreaTrabajo
    Public listaPuestosTrabajo() As PuestoTrabajo
    Public oAreaSeleccionada As New AreaTrabajo()
    Public oPuestoSeleccionado As New PuestoTrabajo()
    Public oAreaSeleccionadaAgregarArea As New AreaTrabajo()


    'ATRIBUTOS MODO ELIMINAR
    Public listaUsuarios() As Usuario
    Public oUsuarioSeleccionado As Usuario

    Public Sub New()
        tiposUsuarios = New Concepto(-1) {}
    End Sub



    'METODOS FUNCIONALES
    Public Sub traerTiposUsuario()
        Dim datatable As DataTable = traerTiposUsuarioBD(), index As Short = 0
        tiposUsuarios = New Concepto(datatable.Rows.Count - 1) {}

        For Each row As DataRow In datatable.Rows
            Dim prefijo As Int64, correlativo As Int64, descripcion As String

            If IsDBNull(row("PREF")) Then prefijo = 0 Else prefijo = Int64.Parse(row("PREF"))
            If IsDBNull(row("CORR")) Then correlativo = 0 Else correlativo = Int64.Parse(row("CORR"))
            If IsDBNull(row("DESC")) Then descripcion = "" Else descripcion = row("DESC").ToString()

            tiposUsuarios(index) = New Concepto(prefijo, correlativo, descripcion)
            index += 1
        Next
    End Sub

    Public Sub traerAreasTrabajo()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerAreasTrabajoBD()
        listaAreasTrabajo = New AreaTrabajo(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigoArea As Int16 = Int16.Parse(row("COD AREA"))
            Dim nombre As String = row("NOM AREA").ToString()

            Dim objArea As New AreaTrabajo(codigoArea, nombre)
            listaAreasTrabajo(index) = objArea
            index += 1
        Next

    End Sub

    Public Sub traerPuestosTrabajo()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerPuestosTrabajoBD()
        listaPuestosTrabajo = New PuestoTrabajo(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codigoPuesto As Int16 = Int16.Parse(row("COD PUESTO"))
            Dim nombrePuesto As String = row("NOM PUESTO").ToString()
            Dim codigoArea As Int16 = Int16.Parse(row("COD AREA"))


            Dim objArea As New AreaTrabajo()
            objArea.setCodigo(codigoArea)
            Dim objPuestoTrabajo As New PuestoTrabajo(codigoPuesto, nombrePuesto, objArea)
            listaPuestosTrabajo(index) = objPuestoTrabajo
            index += 1
        Next

    End Sub

    Public Sub seleccionarArea(ByVal _indexAreaSeleccionada As Int16)
        oAreaSeleccionada = listaAreasTrabajo(_indexAreaSeleccionada)
    End Sub

    Public Sub seleccionarPuesto(ByVal _indexPuestoSeleccionado As Int16)
        oPuestoSeleccionado = listaPuestosTrabajo(_indexPuestoSeleccionado)
    End Sub

    Public Sub seleccionarAreaCmboxAsignarArea(ByVal _indexAreaSeleccionada As Int16)
        oAreaSeleccionadaAgregarArea = listaAreasTrabajo(_indexAreaSeleccionada)
    End Sub

    Public Function guardarUsuarioTipoMedico(ByRef _usuario As Usuario) As Int16
        Dim codigoUsuario As Int16
        Dim objDTable As DataTable

        objDTable = guardarUsuarioTipoMedicoBD(_usuario)
        For Each row As DataRow In objDTable.Rows
            codigoUsuario = Int16.Parse(row("COD USUARIO"))
        Next

        Return codigoUsuario
    End Function

    Public Function GuardarUsuarioComun(ByRef _usuario As Usuario) As Short
        Dim respuesta As Int16
        respuesta = guardarUsuarioComunBD(_usuario)
        Return respuesta
    End Function

    Public Function GuardarArea(ByVal _nombreArea As String) As Int16
        Dim respuesta As Int16
        respuesta = guardarAreaBD(_nombreArea)
        Return respuesta
    End Function

    Public Function GuardarPuesto(ByVal _nombrePuesto As String) As Int16
        Dim respuesta As Int16
        respuesta = guardarPuestoBD(_nombrePuesto)
        Return respuesta
    End Function

    Public Function RevisarUsuarioTipoMedico() As Boolean
        Dim codigoArea As Int16
        Dim codigoPuesto As Int16
        codigoArea = oAreaSeleccionada.getCodigo()
        codigoPuesto = oPuestoSeleccionado.getCodigo()


        If codigoArea = 5 And codigoPuesto = 6 Then
            Return True
        End If

        Return False
    End Function

    Public Sub ActualizarMedico(ByVal _codUsuario As Int16, ByVal _codMedico As Int16)
        actualizarMedicoBD(_codUsuario, _codMedico)
    End Sub





    'METODOS DE VALIDACIÓN  -- GUARDAR USUARIO
    Public Function validarEntradas(ByRef _usuario As Usuario) As String
        Dim mensaje As String

        mensaje = validarUsername(_usuario.getUsername())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarContraseña(_usuario.getContraseña())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarTipo(_usuario.getTipo())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarNombreCompleto(_usuario.getApellidoPaterno(), _usuario.getApellidoMaterno(), _usuario.getNombres())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarTelefono(_usuario.getTelefono())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarAreaSeleccionada(oAreaSeleccionada.getCodigo())
        If Not mensaje = "" Then Return mensaje

        mensaje = validarPuestoSeleccinoado(oPuestoSeleccionado.getCodigo())
        If Not mensaje = "" Then Return mensaje

        Return ""
    End Function

    Private Function validarUsername(ByVal _username As String) As String
        Dim repetido As Boolean = True

        If _username = "" Then
            Return "Error. Ingrese el usuario"
        End If

        For Each caracter As Char In _username
            If Not Char.IsLetter(caracter) Then
                Return "Error. El usuario sólo debe contener letras"
            End If
        Next

        If modoFormulario = 1 Then
            repetido = comprobarUsernameRepetido(_username)
            If repetido Then
                Return "Error. El nombre de usuario que ingresó ya existe. Ingrese otro nombre de usuario"
            End If
        End If

        Return ""
    End Function

    Public Function comprobarUsernameRepetido(ByVal _username As String) As Boolean
        Dim objDTable As DataTable
        Dim cantidadRepetidos As Int16 = 0

        objDTable = comprobarUsernameRepetidoBD(_username)
        cantidadRepetidos = objDTable.Rows.Count

        If Not cantidadRepetidos = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function validarContraseña(ByVal _contraseña As String)
        If _contraseña = "" Then Return "Error. La contraseña no puede ser vacía. Ingrese la contraseña"
        Return ""
    End Function

    Private Function validarTipo(ByRef _tipo As Concepto)
        If _tipo.getCorrelativo() = 0 Then Return "Error. Seleccione un tipo de usuario."
        Return ""
    End Function

    Private Function validarNombreCompleto(ByVal _apPaterno As String, ByVal _apMaterno As String, ByVal _nombres As String)
        If _apPaterno = "" And _apMaterno = "" Then
            Return "Error. Ambos apellidos no pueden ser vacíos. Ingrese al menos uno."
        End If

        If _nombres = "" Then
            Return "Error. El nombre no puede ser vacío. Ingrese el nombre."
        End If

        Return ""
    End Function

    Private Function validarTelefono(ByVal _telefono As String)
        If _telefono = "" Then
            Return "Error. El número de teléfono no puede ser vacío. Ingrese un número de teléfono."
        End If


        For Each c As Char In _telefono
            Dim esNumero As Boolean = True
            esNumero = Char.IsDigit(c)

            If esNumero = False Then
                Return "Error. Sólo se permiten números para el teléfono."
            End If
        Next


        If _telefono.Length < 8 Then
            Return "Error. El teléfono debe tener como mínimo 8 digitos."
        End If


        Return ""
    End Function

    Private Function validarAreaSeleccionada(ByVal _codigoArea As Int16)
        If _codigoArea <= 0 Then Return "Error. Seleccione un area antes de guardar los datos"
        Return ""
    End Function

    Private Function validarPuestoSeleccinoado(ByVal _codigoPuesto As Int16)
        If _codigoPuesto <= 0 Then
            Return "Error. Seleccione un puesto antes de guardar los datos"
        End If

        Return ""
    End Function





    'METODOS DE VALIDACIÓN  -- AGREGAR AREA
    Public Function validarEntradasAgregarArea(ByVal _nombreArea As String)
        Dim mensaje As String = ""
        mensaje = validarNombreAreaAgregarArea(_nombreArea)

        Return mensaje
    End Function

    Private Function validarNombreAreaAgregarArea(ByVal _nombreArea As String)
        Dim mensaje As String = ""

        If _nombreArea = "" Then
            Return "Error. El nombre de area no puede ser vacío. Ingrese el nombre de area"
        End If


        For Each caracter As Char In _nombreArea
            If Not (Char.IsLetter(caracter)) And Not (Char.IsWhiteSpace(caracter)) Then
                Return "Error. El nombre de área sólo puede contener letras."
            End If
        Next

        Return ""
    End Function

    'METODOS DE VALIDACIÓN  -- AGREGAR PUESTO
    Public Function validarEntradasAgregarPuesto(ByVal _nombrePuesto As String)
        Dim mensaje As String = ""

        mensaje = validarAreaSeleccionadaAgregarPuesto(oAreaSeleccionadaAgregarArea.getCodigo())
        If Not mensaje = "" Then
            Return mensaje
        End If


        mensaje = validarNombrePuestoAgregarPuesto(_nombrePuesto)
        If Not mensaje = "" Then
            Return mensaje
        End If


        Return ""
    End Function

    Private Function validarAreaSeleccionadaAgregarPuesto(ByVal _codigoArea As Int16) As String
        If _codigoArea <= 0 Then
            Return "Error. Seleccione un area para el nuevo puesto"
        End If

        Return ""
    End Function

    Private Function validarNombrePuestoAgregarPuesto(ByVal _nombrePuesto As String) As String
        Dim mensaje As String = ""

        If _nombrePuesto = "" Then
            Return "Error. El nombre de puesto no puede ser vacío. Ingrese el nombre de puesto"
        End If


        For Each caracter As Char In _nombrePuesto
            If Not (Char.IsLetter(caracter)) And Not (Char.IsWhiteSpace(caracter)) Then
                Return "Error. El nombre de puesto sólo puede contener letras."
            End If
        Next

        Return ""
    End Function




    'METODOS BD G1
    Private Function traerTiposUsuarioBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerTiposUsuario_Concepto"))
    End Function

    Private Function traerAreasTrabajoBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerAreasTrabajo"))
    End Function

    Private Function traerPuestosTrabajoBD() As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = oAreaSeleccionada.getCodigo()
        Return (objDAL.TraerDataTable("SPtraerPuestoTrabajo", P))
    End Function

    Private Function comprobarUsernameRepetidoBD(ByVal _username As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _username
        Return (objDAL.TraerDataTable("SPtraerUsernameRepetido", P))
    End Function

    Private Function guardarUsuarioTipoMedicoBD(ByRef _usuario As Usuario) As DataTable
        Dim P As Object() = New Object(8) {}
        P(0) = _usuario.getTipo().getCorrelativo()
        P(1) = _usuario.getUsername()
        P(2) = _usuario.getContraseña()
        P(3) = _usuario.getApellidoPaterno()
        P(4) = _usuario.getApellidoMaterno()
        P(5) = _usuario.getNombres()
        P(6) = _usuario.getTelefono()
        P(7) = oAreaSeleccionada.getCodigo()
        P(8) = oPuestoSeleccionado.getCodigo()

        Return (objDAL.TraerDataTable("SPguardarUsuarioMedico", P))
    End Function

    Private Function guardarUsuarioComunBD(ByRef _usuario As Usuario) As Int16

        Dim P As Object() = New Object(8) {}
        P(0) = _usuario.getTipo().getCorrelativo()
        P(1) = _usuario.getUsername()
        P(2) = _usuario.getContraseña()
        P(3) = _usuario.getApellidoPaterno()
        P(4) = _usuario.getApellidoMaterno()
        P(5) = _usuario.getNombres()
        P(6) = _usuario.getTelefono()
        P(7) = oAreaSeleccionada.getCodigo()
        P(8) = oPuestoSeleccionado.getCodigo()


        Dim respuesta As Int16 = 0
        respuesta = objDAL.Ejecutar("SPguardarUsuarioComun", P)
        Return respuesta

    End Function

    Private Function guardarAreaBD(ByVal _nombreArea As String)
        Dim P As Object() = New Object(1) {}
        P(0) = _nombreArea
        P(1) = Usuario.codUserLoggedSystem

        Return (objDAL.Ejecutar("SPguardarArea", P))
    End Function

    Private Function guardarPuestoBD(ByVal _nombrePuesto As String)
        Dim P As Object() = New Object(2) {}
        P(0) = _nombrePuesto
        P(1) = oAreaSeleccionadaAgregarArea.getCodigo()
        P(2) = Usuario.codUserLoggedSystem

        Return (objDAL.Ejecutar("SPguardarPuesto", P))
    End Function

    Private Function actualizarMedicoBD(ByVal _codUsuario As Int16, ByVal _codMedico As Int16)
        Dim P As Object() = New Object(1) {}
        P(0) = _codUsuario
        P(1) = _codMedico

        Return (objDAL.Ejecutar("SPactualizarMedico", P))
    End Function


    'MODO EDITAR --------------------------------- METODOS FUNCAIONALES
    Public Function editarUsuarioComun(ByVal _username, ByVal _contraseña, ByVal _apPaterno, ByVal _apMaterno,
                                       ByVal _nombres, ByVal _telefono, ByVal _nombreFormulario, ByVal _tipo) As Int16

        Dim respuesta As Int16 = 0
        respuesta = editarUsuarioComunBD(_username, _contraseña, _apPaterno, _apMaterno, _nombres, _telefono,
                                         oUsuarioSeleccionado.getCodigo(), _nombreFormulario, _tipo)

        Return respuesta
    End Function



    'METODOS BD
    Private Function editarUsuarioComunBD(ByVal _username, ByVal _contraseña, ByVal _apPaterno,
                                        ByVal _apMaterno, ByVal _nombres, ByVal _telefono,
                                        ByVal _codUsuario, ByVal _nombreFormulario, ByVal _tipo) As Int16

        Dim P As Object() = New Object(11) {}
        P(0) = _codUsuario
        P(1) = _username
        P(2) = _contraseña
        P(3) = _apPaterno
        P(4) = _apMaterno
        P(5) = _nombres
        P(6) = _telefono
        P(7) = oAreaSeleccionada.getCodigo()
        P(8) = oPuestoSeleccionado.getCodigo()
        P(9) = _nombreFormulario
        P(10) = Usuario.codUserLoggedSystem
        P(11) = _tipo


        Dim respuesta As Int16 = 0
        respuesta = objDAL.Ejecutar("SPeditarUsuario", P)
        Return respuesta
    End Function



    'MODO ELIMINAR --- METODOS FUNCIONALES
    Public Sub fmeTraerUsuarios(ByVal _username As String)
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = fmeTraerUsuariosBD(_username)
        listaUsuarios = New Usuario(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim codUsuario As Int16 = Int16.Parse(row("COD USU"))
            Dim username As String = row("USNA USU").ToString()
            Dim contraseña As String = row("CONTASEÑA").ToString()
            Dim apellidoPa As String = row("APEPA USU").ToString()
            Dim apellidoMa As String = row("APEMA USU").ToString()
            Dim nombres As String = row("NOM USU").ToString()
            Dim telefono As String = row("TEL USU").ToString()
            Dim nombreArea As String = row("NOM AREA").ToString()
            Dim nombrePuesto As String = row("NOM PUE").ToString()

            Dim objUsuario As New Usuario()
            objUsuario.setCodigo(codUsuario)
            objUsuario.setUsername(username)
            objUsuario.setContraseña(contraseña)
            objUsuario.setApellidoPaterno(apellidoPa)
            objUsuario.setApellidoMaterno(apellidoMa)
            objUsuario.setNombres(nombres)
            objUsuario.setTelefono(telefono)
            objUsuario.getArea.setNombre(nombreArea)
            objUsuario.getPuesto.setNombre(nombrePuesto)

            listaUsuarios(index) = objUsuario
            index += 1
        Next
    End Sub

    Public Sub FmeSeleccionarUSuario(ByVal _index)
        oUsuarioSeleccionado = listaUsuarios(_index)
    End Sub

    Public Sub FmeEliminarUsuario(ByVal _nombreFormulario As String)
        fmeEliminarUsuarioBD(_nombreFormulario)
    End Sub


    Public Sub fmeEliminarMedico(ByVal _nombreFormulario As String)
        fmeEliminarMedicoBD(_nombreFormulario)
    End Sub


    'METODOS BD
    Private Function fmeTraerUsuariosBD(ByVal _username As String)
        Dim P As Object() = New Object(0) {}
        P(0) = _username
        Return (objDAL.TraerDataTable("SPtraerDatosUsuarioME", P))
    End Function

    Private Function fmeEliminarUsuarioBD(ByVal _nombreFormulario As String)
        Dim P As Object() = New Object(2) {}
        P(0) = oUsuarioSeleccionado.getCodigo
        P(1) = _nombreFormulario
        P(2) = Usuario.codUserLoggedSystem

        Return (objDAL.Ejecutar("SPEliminarUsuario", P))
    End Function

    Private Function fmeEliminarMedicoBD(ByVal _nombreFormulario As String)
        Dim P As Object() = New Object(2) {}
        P(0) = oUsuarioSeleccionado.getCodigo
        P(1) = _nombreFormulario
        P(2) = Usuario.codUserLoggedSystem

        Return (objDAL.Ejecutar("SPEliminarMedico", P))
    End Function


    ' rodeeando la montaña a caray por aquiconmienzo sho 

    Public Function obtenerproximoregistro()
        Dim tabla = objDAL.TraerDataTable("proximousuario")

        Return tabla.Rows(0).Item(0).ToString()
    End Function


End Class


