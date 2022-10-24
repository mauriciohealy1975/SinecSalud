Public Class FormMenuLaboratorio



    'METODOS INICIO -
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormMenuLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub establecerDisplay()
        'Dim ejeX As Short, ejeY As Short

        'ejeX = Utilitarios.resolucionEstandarEjeX
        'ejeY = Utilitarios.resolucionEstandarEjeY

        'Dim size As New Size(ejeX, ejeY)

        'Me.Size = size
        'MinimumSize = size
        'MaximumSize = size

        Me.CenterToScreen()
    End Sub






    'COLUMNA 1
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        Dim formArea As FormRegistrarAreaLaboratorio

        formArea = New FormRegistrarAreaLaboratorio(False)
        formArea.Show()
        Me.Close()
    End Sub

    Private Sub btnSubarea_Click(sender As Object, e As EventArgs) Handles btnSubarea.Click
        Dim formSubarea As FormRegistrarSubareaLaboratorio

        formSubarea = New FormRegistrarSubareaLaboratorio(False)
        formSubarea.Show()
        Me.Close()
    End Sub

    Private Sub btnExamen_Click(sender As Object, e As EventArgs) Handles btnExamen.Click
        Dim formExamen As FormRegistrarExamenLaboratorio

        formExamen = New FormRegistrarExamenLaboratorio()
        formExamen.Show()
        Me.Close()
    End Sub

    Private Sub btnConjuntoOpcionesClick(sender As Object, e As EventArgs) Handles btnConjuntoOpciones.Click
        Dim form As New FormRegistrarConjuntoOpcionesResultadoLaboratorio(False)
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        Dim form As New FormRegistrarProveedorKitEquipo(False)
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnKitEquipoQuimico_Click(sender As Object, e As EventArgs) Handles btnKitEquipoQuimico.Click
        Dim formKitEquipo As New FormRegistrarKitEquipoLaboratorio()

        formKitEquipo.Show()
        Me.Close()
    End Sub

    Private Sub btnReferencias_Click(sender As Object, e As EventArgs) Handles btnReferencias.Click
        FormRegistrarReferenciaResultadoLaboratorio.Show()
        Me.Close()
    End Sub

    Private Sub btnAsignarAreasPermisos_Click(sender As Object, e As EventArgs) Handles btnAsignarAreasPermisos.Click
        FormRegistrarAsignacionAreasLab.Show()
        Me.Close()
    End Sub




    'COLUMNA 2
    Private Sub btnOrden_Click(sender As Object, e As EventArgs) Handles btnOrden.Click
        FormRegistrarOrdenLaboratorio.Show()
        Me.Close()
    End Sub

    Private Sub btnResultados_Click(sender As Object, e As EventArgs) Handles btnResultados.Click
        Dim form As FormRegistrarResultadosLab, habilitado As Boolean

        form = New FormRegistrarResultadosLab()
        form.controlarTipoUsuarioValido()
        form.ajustarHabilitacionFormulario()
        habilitado = form.registro.tipoUsuarioValido


        If habilitado Then
            form.Show()
            Me.Close()
        Else
            form.Close()
        End If
    End Sub

    Private Sub btnImprimirResultados_Click(sender As Object, e As EventArgs) Handles btnImprimirResultados.Click
        Dim form As New FormImprimirResultadosLaboratorio()
        form.Show()
        Me.Close()

    End Sub



    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FormMenuPrincipal.Show()
        Me.Close()
    End Sub
End Class