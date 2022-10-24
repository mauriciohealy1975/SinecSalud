Imports NEGOCIO


Public Class FormConfimarOrdenLaboratorio

    ''ATRIBUTOS LÓGICOS
    Private registro As ConfirmacionOrdenLaboratorio
    Private reporte As reportPrueba


    ''ATRIBUTOS LÓGICOS MODO FORM HIJO
    Public estadoFormGuardado As Boolean
    Public esFormHijo As Boolean
    Private ordenFormPadre As OrdenLaboratorio
    Private asguradoFormPadre As Asegurado
    Private medicoFormPadre As Medico


    ''ATRIBUTOS G0
    Private tituloFormulario As String

    ''ATRIBUTOS G9
    Public Property registroConfirmado As Boolean



    'METODOS INICIO
    Public Sub New(_esHijo As Boolean, _orden As OrdenLaboratorio)
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        preIniciarAtributosFormHijo(True, _orden)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean, _orden As OrdenLaboratorio)
        estadoFormGuardado = False
        esFormHijo = _esHijo
        ordenFormPadre = _orden
        asguradoFormPadre = _orden.getAsegurado()
        medicoFormPadre = _orden.getMedico()


        If esFormHijo Then

        Else

        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarControlesInterfaz()


        'If esFormHijo Then iniciarControlesInterfazFormSecundario()
        registro.cargarDatosAsegurado(asguradoFormPadre)
        registro.cargarDatosMedico(medicoFormPadre)
        registro.cargarDatosUsusario()

        cargarReporte()
    End Sub

    Private Sub iniciarAtributos()
        ''ATRIBUTOS LÓGICOS
        registro = New ConfirmacionOrdenLaboratorio()
        reporte = New reportPrueba()

        ''ATRIBUTOS LÓGICOS MODO FORM HIJO
        'estadoFormGuardado = New Boolean()
        'esFormHijo = New Boolean()
        'ordenFormPadre = New OrdenLaboratorio()
        'asguradoFormPadre = New Asegurado()

        ''ATRIBUTOS G0
        tituloFormulario = "Confirmar oden de laboratorio"

        ''ATRIBUTOS G9
        registroConfirmado = False
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

        'lblTituloPrincipal.Enabled = True
        'lblTituloPrincipal.Visible = True
        'lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        'lblTituloPrincipal.Text = tituloFormulario.ToUpper
    End Sub

    Private Sub iniciarControlesInterfazGrupo1()
        iniciarReportViewer()
    End Sub

    Private Sub iniciarReportViewer()
        rViewer.Enabled = True
        rViewer.Visible = True


        rViewer.DisplayBackgroundEdge = False
        rViewer.ShowCopyButton = False
        rViewer.ShowExportButton = False
        rViewer.ShowGroupTreeButton = False
        rViewer.ShowParameterPanelButton = False
        rViewer.ShowLogo = False
        rViewer.ShowCloseButton = False
        rViewer.DisplayStatusBar = False


        rViewer.DisplayToolbar = True
        rViewer.ShowPrintButton = True
        rViewer.ShowRefreshButton = True
        rViewer.ShowGotoPageButton = True
        rViewer.ShowPageNavigateButtons = True
        rViewer.ShowTextSearchButton = True
        rViewer.ShowZoomButton = True


        rViewer.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController
        rViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    End Sub

    Private Sub establecerDisplay()
        '    Dim ejeX As Short, ejeY As Short
        '    ejeX = Utilitarios.resolucionEstandarEjeX
        '    ejeY = Utilitarios.resolucionEstandarEjeY

        '    Size = New Size(ejeX, ejeY)
        '    MinimumSize = New System.Drawing.Size(ejeX, ejeY)
        '    MaximumSize = New System.Drawing.Size(ejeX, ejeY)

        Me.CenterToScreen()
    End Sub









    'MÉTODOS LÓGICOS G1
    Private Sub cargarReporte()
        'reporte.SetDataSource(dt)

        reporte.Database.Tables(0).SetDataSource(registro.dataAsegurado)
        reporte.Database.Tables(1).SetDataSource(registro.dataMedico)
        reporte.Database.Tables(2).SetDataSource(registro.dataUsuario)


        rViewer.ReportSource = reporte
        rViewer.Refresh()
        rViewer.Zoom(80)
    End Sub







    'METODOS INTERFAZ G9
    Private Sub mostrarMensaje(_mensaje As String)
        MessageBox.Show(_mensaje, "Mensaje")
    End Sub









    'EVENTOS    
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            registroConfirmado = False
            Me.Close()

        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            registroConfirmado = True
            Me.Close()


        Catch ex As Exception
            mostrarMensaje(ex.Message)
        End Try
    End Sub



End Class