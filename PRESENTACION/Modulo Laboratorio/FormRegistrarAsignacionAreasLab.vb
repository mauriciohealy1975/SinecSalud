Imports NEGOCIO

Public Class FormRegistrarAsignacionAreasLab

    'ATRIBUTOS LÓGICOS 
    Private registro As RegistroAsignacionAreasLaboratorio

    'ATRIBUTOS G0
    Private tituloFormulario As String

    'ATRIBUTOS G1
    Private procesadorSeleccionado As Usuario

    'ATRIBUTOS G9
    Private nuevoInputPermiso As PermisoLaboratorioInput
    Private nuevoPermiso As PermisoLaboratorio


    'METODOS INICIO 
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

    End Sub

    Private Sub FormAsignarAreaABioquímio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        establecerDisplay()
        iniciarControlesInterfaz()

        traerProcesadores()
        poblarCboxProcesador()

        traerAreas()
        poblarClistAreas()

        desmarcarTodoClistAreas()

    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS 
        registro = New RegistroAsignacionAreasLaboratorio()

        'ATRIBUTOS G0
        tituloFormulario = "Asignar permisos de areas de laboratorio"

        'ATRIBUTOS G1
        procesadorSeleccionado = New Usuario()

        'ATRIBUTOS G9
        nuevoInputPermiso = New PermisoLaboratorioInput()
        nuevoPermiso = New PermisoLaboratorio()
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarControlesInterfaz()
        iniciarControlesInterfazGrupo0()
        iniciarControlesInterfazGrupo1()
    End Sub

    Private Sub iniciarControlesInterfazGrupo0()
        Me.Enabled = True
        Me.Text = tituloFormulario

        lblTituloPrincipal.Enabled = True
        lblTituloPrincipal.Visible = True
        lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        lblTituloPrincipal.Text = tituloFormulario.ToUpper
    End Sub

    Private Sub iniciarControlesInterfazGrupo1()
        cboxProcesador.Enabled = True
        cboxProcesador.Font = New Font("Microsoft Sans Serif", 9)
        cboxProcesador.Items.Clear()
        cboxProcesador.DropDownStyle = ComboBoxStyle.DropDownList

        hintProcesador.Font = New Font("Microsoft Sans Serif", 9)
        hintProcesador.Text = "SELECCIONAR"
        hintProcesador.BackColor = Color.Transparent
        hintProcesador.Visible = True

        clistAreas.Enabled = False
        clistAreas.Visible = True
        clistAreas.Font = New Font("Microsoft Sans Serif", 9)
        clistAreas.CheckOnClick = True
    End Sub

    Private Sub establecerDisplay()
        'Dim ejeX As Short, ejeY As Short

        ''ejeX = Utilitarios.resolucionEstandarEjeX
        ''ejeY = Utilitarios.resolucionEstandarEjeY

        ''Dim size As New Size(ejeX, ejeY)
        'Dim size As New Size(945, 495)

        'Me.Size = size
        'MinimumSize = size
        'MaximumSize = size

        Me.CenterToScreen()
    End Sub







    'METODOS INTERFAZ G1
    Private Sub poblarCboxProcesador()
        cboxProcesador.Items.Clear()

        For Each usuario As Usuario In registro.procesadores
            Dim apPaterno As String, apMaterno As String, nombres As String, nombreCompleto As String

            apPaterno = usuario.getNombres()
            apMaterno = usuario.getApellidoMaterno()
            nombres = usuario.getNombres()

            nombreCompleto = apPaterno + " " + apMaterno + " " + nombres

            cboxProcesador.Items.Add(nombreCompleto)
        Next
    End Sub

    Private Sub mostrarHintProcesador()
        hintProcesador.Visible = True
    End Sub

    Private Sub ocultarHintProcesador()
        hintProcesador.Visible = False
    End Sub

    Private Sub poblarClistAreas()
        clistAreas.Items.Clear()

        For Each area As AreaLaboratorio In registro.areas
            clistAreas.Items.Add(area.getNombre())
        Next
    End Sub

    Private Sub marcarAreasProcesador()
        Dim nroItems As Short = clistAreas.Items.Count()

        For Each areaActualProcesador As AreaLaboratorio In registro.areasProcesador
            Dim areaProcesador As String = areaActualProcesador.getNombre()

            For index = 0 To nroItems - 1
                Dim itemArea As String = clistAreas.Items(index)

                If areaProcesador = itemArea Then
                    clistAreas.SetItemChecked(index, True)
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub desmarcarTodoClistAreas()
        Dim nroItems As Short = clistAreas.Items.Count()

        For index = 0 To nroItems - 1
            clistAreas.SetItemChecked(index, False)
        Next
    End Sub

    Private Sub habilitarClistAreas()
        clistAreas.Enabled = True
    End Sub

    Private Sub deshabilitarClistAreas()
        clistAreas.Enabled = False
    End Sub

    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(ByVal _mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub







    'METODOS LOGICOS G1
    Private Sub traerProcesadores()
        registro.traerProcesadores()
    End Sub

    Private Sub traerAreas()
        registro.traerAreasLaboratorio()
    End Sub

    Private Sub seleccionarProcesador()
        Dim index As Short = cboxProcesador.SelectedIndex
        procesadorSeleccionado = registro.procesadores(index)
    End Sub

    Private Sub traerAreasProcesador()
        registro.traerAreasProcesador(procesadorSeleccionado)
    End Sub


    'METODOS LOGICOS G9
    Private Sub enviarDatos()
        Dim entradasCargadas As Boolean = cargarEntradas()

        If entradasCargadas Then
            Dim mensajeValidacion As String = validarEntradas()

            If mensajeValidacion = "" Then
                Dim objetosCargados As Boolean = cargarObjetos()

                If objetosCargados Then
                    enviarDatosDatabase()
                End If
            Else
                mostrarMensaje(mensajeValidacion)
            End If

        End If
    End Sub

    Private Function cargarEntradas() As Boolean
        Try
            Dim procesador As UsuarioInput, nroAreasMarcadas As Short, inputAreas As AreaLaboratorioInput(),
                index As Short


            procesador = New UsuarioInput()
            procesador.codigo = procesadorSeleccionado.getCodigo()
            procesador.nombres = procesadorSeleccionado.getNombres()


            nroAreasMarcadas = clistAreas.CheckedItems.Count()
            inputAreas = New AreaLaboratorioInput(nroAreasMarcadas - 1) {}
            index = 0
            For Each item In clistAreas.CheckedItems
                Dim indexActual As Short, inputArea As AreaLaboratorioInput

                indexActual = clistAreas.Items().IndexOf(item)
                Dim areaActual As AreaLaboratorio = registro.areas(indexActual)

                inputArea = New AreaLaboratorioInput()
                inputArea.codigo = areaActual.getCodigo()
                inputArea.nombre = areaActual.getNombre()

                inputAreas(index) = inputArea
                index += 1
            Next

            nuevoInputPermiso.procesador = procesador
            nuevoInputPermiso.areas = inputAreas
            Return True


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Function validarEntradas() As String
        Dim mensaje As String = registro.validarEntradas(nuevoInputPermiso)
        Return mensaje
    End Function

    Private Function cargarObjetos()
        Try
            Dim nroAreas As Short, areas As AreaLaboratorio(), index As Short

            nroAreas = nuevoInputPermiso.areas.Count()
            areas = New AreaLaboratorio(nroAreas - 1) {}

            index = 0
            For Each areaInput As AreaLaboratorioInput In nuevoInputPermiso.areas
                Dim codigo As Long, nonmbre As String

                codigo = areaInput.codigo
                nonmbre = areaInput.nombre

                areas(index) = New AreaLaboratorio(codigo, nonmbre)
                index += 1
            Next


            nuevoPermiso.setProcesador(procesadorSeleccionado)
            nuevoPermiso.setAreas(areas)

            Return True


        Catch ex As Exception
            mostrarMensaje(ex.Message)
            Return False
        End Try
    End Function

    Private Sub enviarDatosDatabase()
        Dim estadoInsercion As Short, mensaje As String

        registro.insertarPermiso(nuevoPermiso)
        estadoInsercion = registro.estadoInsercion
        mensaje = registro.generarMensajeInsercion()


        If Not mensaje = "" Then mostrarMensaje(mensaje)
        If estadoInsercion > 0 Then reiniciarFormulario()
    End Sub

    Private Sub reiniciarFormulario()
        iniciarFormulario()
    End Sub





    'EVENTOS G0
    Private Sub menuStripMenuLaboratorio_Click(sender As Object, e As EventArgs) Handles menuStripMenuLaboratorio.Click
        Dim form As FormMenuLaboratorio

        form = New FormMenuLaboratorio()
        form.Show()
        Me.Close()
    End Sub

    'EVENTOS G1
    Private Sub cboxProcesador_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxProcesador.SelectionChangeCommitted
        Try
            seleccionarProcesador()
            ocultarHintProcesador()

            desmarcarTodoClistAreas()
            traerAreasProcesador()
            marcarAreasProcesador()

            habilitarClistAreas()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try

    End Sub

    'EVENTOS G3
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        reiniciarFormulario()
    End Sub

    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Try
            enviarDatos()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



End Class
