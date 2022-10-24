Imports Microsoft.Win32
Imports System.Windows.Forms.MonthCalendar
Imports NEGOCIO
Public Class FormEliminarSolMed

    'ATRIBUTOS LÓGICOS
    Dim registro As registroEliminacionSolicitudMedica

    'ATRIBUTOS LÓGICOS MODO FORMHIJO
    Private esFormHijo As Boolean

    'ATRIBUTOS G2
    Private clmNroSol As String
    Private clmNomAse As String
    Private clmHor As String
    Private clmEsp As String
    Private clmNomMed As String


    'METODOS INICIO -
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        preIniciarAtributosFormHijo(False)
        iniciarFormulario()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        establecerDisplay()
    End Sub

    Private Sub FormCancelarSolMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub preIniciarAtributosFormHijo(_esHijo As Boolean)
        esFormHijo = _esHijo

        If esFormHijo Then

        Else

        End If
    End Sub

    Private Sub iniciarFormulario()
        iniciarAtributos()
        iniciarProcesosNegocio()
        iniciarInterfaz()


        registro.traerFechasSolicitudesMedicas(Utilitarios.obtenerFechaActual())
        poblarLboxFechas()
    End Sub

    Private Sub iniciarAtributos()
        'ATRIBUTOS LÓGICOS
        registro = New registroEliminacionSolicitudMedica()

        'ATRIBUTOS LÓGICOS MODO FORMHIJO
        'Private esFormHijo As Boolean

        'ATRIBUTOS G1
        clmNroSol = "NRO SOL"
        clmNomAse = "ASEGURADO"
        clmHor = "HORARIO"
        clmEsp = "ESPECIALIDAD"
        clmNomMed = "MEDICO"
    End Sub

    Private Sub iniciarProcesosNegocio()

    End Sub

    Private Sub iniciarInterfaz()
        iniciarInterfazGrupo0()
        iniciarInterfazGrupo1()
        iniciarInterfazGrupo2()
    End Sub

    Private Sub iniciarInterfazGrupo0()
        'Me.Enabled = True
        'Me.Text = tituloFormulario

        'lblTituloPrincipal.Enabled = True
        'lblTituloPrincipal.Visible = True
        'lblTituloPrincipal.Font = New Font("Microsoft Sans Serif", 12.5)
        'lblTituloPrincipal.Text = tituloFormulario.ToUpper

        'If esFormHijo Then MenuStrip.Enabled = False
        'If Not esFormHijo Then MenuStrip.Enabled = True
    End Sub

    Private Sub iniciarInterfazGrupo1()
        iniciarDgvSolicitudes()
    End Sub

    Private Sub iniciarInterfazGrupo2()
        lboxFechas.Font = New Font("Microsoft Sans Serif", 10.5)
        iniciarDgvSolicitudes()
        btnEliminar.Enabled = False
    End Sub

    Private Sub iniciarDgvSolicitudes()
        'propiedades base
        dgvSolicitudes.Enabled = True
        dgvSolicitudes.Font = New Font("Microsoft Sans Serif", 9)

        'propiedades permisos editar
        dgvSolicitudes.EditMode = DataGridViewEditMode.EditOnEnter
        dgvSolicitudes.AllowUserToAddRows = False
        dgvSolicitudes.AllowUserToDeleteRows = False
        dgvSolicitudes.AllowUserToResizeRows = False
        dgvSolicitudes.AllowUserToOrderColumns = False
        dgvSolicitudes.AllowUserToResizeColumns = False
        dgvSolicitudes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvSolicitudes.MultiSelect = False
        dgvSolicitudes.ReadOnly = True

        'propiedades estilos selección
        dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'propiedades estilos color encabezados columnas
        dgvSolicitudes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235)
        dgvSolicitudes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

        'propiedades estilos color seleccion encabezados filas
        dgvSolicitudes.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvSolicitudes.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'propiedaes estilos color celdas
        dgvSolicitudes.BackgroundColor = Color.FromArgb(255, 255, 255)
        dgvSolicitudes.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
        dgvSolicitudes.DefaultCellStyle.ForeColor = Color.Black

        'propiedaes estilos color celdas seleccionadas
        dgvSolicitudes.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255)
        dgvSolicitudes.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0)

        'propiedades otras celdas
        dgvSolicitudes.ScrollBars = ScrollBars.Both
        dgvSolicitudes.EnableHeadersVisualStyles = False

        'columnas -- agregar columnas
        dgvSolicitudes.Columns.Clear()



        dgvSolicitudes.Columns.Add(clmNroSol, "NRO. SOLICITUDES")
        dgvSolicitudes.Columns(clmNroSol).Visible = True

        dgvSolicitudes.Columns.Add(clmNomAse, "ASEGURADO")
        dgvSolicitudes.Columns(clmNomAse).Visible = True

        dgvSolicitudes.Columns.Add(clmHor, "HORARIO")
        dgvSolicitudes.Columns(clmHor).Visible = True

        dgvSolicitudes.Columns.Add(clmEsp, "ESPECIALIDAD")
        dgvSolicitudes.Columns(clmEsp).Visible = True

        dgvSolicitudes.Columns.Add(clmNomMed, "MEDICO")
        dgvSolicitudes.Columns(clmNomMed).Visible = True



        'bloquear ordenar por columna
        For Each columna As DataGridViewColumn In dgvSolicitudes.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'alinear columnas
        For Each columna As DataGridViewColumn In dgvSolicitudes.Columns
            columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next


        'configurar ancho columnas
        dgvSolicitudes.Columns(clmNroSol).FillWeight = 12.5
        dgvSolicitudes.Columns(clmNomAse).FillWeight = 12.5
        dgvSolicitudes.Columns(clmHor).FillWeight = 15
        dgvSolicitudes.Columns(clmEsp).FillWeight = 33
        dgvSolicitudes.Columns(clmNomMed).FillWeight = 13


        'filas
        dgvSolicitudes.Rows.Clear()

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












    'METODOS INTERFAZ G1

    Private Sub revisarControles()
        If Not (lboxFechas.SelectedItem = Nothing) And Not (dgvSolicitudes.SelectedRows.Count = 0) And Not (richtxtDescripcion.Text.Trim() = "") Then
            habilitarBtnEliminar()
        Else
            deshabilitarBtnEliminar()
        End If

    End Sub

    Private Sub habilitarBtnEliminar()
        btnEliminar.Enabled = True
    End Sub

    Private Sub deshabilitarBtnEliminar()
        btnEliminar.Enabled = False
    End Sub

    Private Sub reiniciarControles()
        richtxtDescripcion.Text = ""
    End Sub












    'METODOS LOGICOS G1
    Private Sub poblarLboxFechas()
        For Each fecha As FiltroFecha In registro.fechas
            lboxFechas.Items.Add(fecha.getMensaje())
        Next
    End Sub

    Private Sub poblarDgvSolicitudes()

    End Sub

    Private Function confirmarElimandoSolMed() As Boolean
        Dim dialogResult As DialogResult = MessageBox.Show("¿Está seguro de eliminar esta solicitud medica?", "Eliminar", MessageBoxButtons.YesNo)
        If dialogResult = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If

    End Function










    'EVENTOS G2
    Private Sub lboxFechas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxFechas.SelectedIndexChanged
        Try
            Dim fecha As String

            If Not lboxFechas.SelectedItem = Nothing Then

                If IsNothing(dgvSolicitudes.DataSource) Then
                    dgvSolicitudes.Rows.Clear()
                    dgvSolicitudes.Columns.Clear()
                End If

                fecha = registro.encontrarFiltroFecha(lboxFechas.SelectedItem)
                dgvSolicitudes.DataSource = registro.traerSolicitudesMedicas(fecha)
                revisarControles()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    'EVENTOS G9
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If confirmarElimandoSolMed() Then
            For Each row As DataGridViewRow In dgvSolicitudes.SelectedRows
                Dim codSol As Int16 = Int16.Parse(row.Cells(0).Value)
                registro.eliminarSolMed(codSol, Me.Text, Usuario.codUserLoggedSystem)
            Next

            Dim fecha As String = registro.encontrarFiltroFecha(lboxFechas.SelectedItem)
            dgvSolicitudes.DataSource = registro.traerSolicitudesMedicas(fecha)
            MessageBox.Show("La solicitud se eliminó correctamente")
            reiniciarControles()
        End If

    End Sub


    'OTROS EVENTOS
    Private Sub dgvSolMed_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSolicitudes.SelectionChanged
        revisarControles()
    End Sub

    Private Sub richtxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles richtxtDescripcion.TextChanged
        revisarControles()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FromMenuTriaje.Show()
        Me.Close()
    End Sub

End Class

