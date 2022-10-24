Imports NEGOCIO

Public Class FormConfirmarSolMed

    Dim confirmacionSolMed As ConfirmacionSolMed = New ConfirmacionSolMed()

    'INICIO
    Private Sub FormConfirmarProgramacionSolicitudMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarDgview()
        traerSolMedProg()
        bloquearSortEnColumnas()
        anhadirColumnaCbox()
        configurarColumnasDgv()
        configurarDisplay()
    End Sub


    'METODOS DATAGRIDVIEW
    Private Sub configurarDisplay()
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub configurarDgview()
        dgvSolMedProgramadas.AllowUserToAddRows = False
        dgvSolMedProgramadas.AllowUserToDeleteRows = False
        dgvSolMedProgramadas.AllowUserToOrderColumns = False
        dgvSolMedProgramadas.AllowUserToResizeColumns = False
        dgvSolMedProgramadas.AllowUserToResizeRows = False
        dgvSolMedProgramadas.MultiSelect = True
        dgvSolMedProgramadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSolMedProgramadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSolMedProgramadas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        dgvSolMedProgramadas.EnableHeadersVisualStyles = False
        dgvSolMedProgramadas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11)
    End Sub

    Private Sub bloquearSortEnColumnas()
        For i = 0 To dgvSolMedProgramadas.Columns.Count - 1
            dgvSolMedProgramadas.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
    End Sub

    Private Sub anhadirColumnaCbox()
        Dim columnaComboboxDgv As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        columnaComboboxDgv.HeaderText = "SELECCIONAR"
        columnaComboboxDgv.FalseValue = "0"
        columnaComboboxDgv.TrueValue = "1"
        dgvSolMedProgramadas.Columns.Insert(dgvSolMedProgramadas.ColumnCount, columnaComboboxDgv)
    End Sub

    Private Sub configurarColumnasDgv()
        For Each columna As DataGridViewColumn In dgvSolMedProgramadas.Columns
            columna.ReadOnly = True
        Next

        dgvSolMedProgramadas.Columns(dgvSolMedProgramadas.ColumnCount - 1).[ReadOnly] = False
    End Sub





    'METODOS SOL MED PROGRAMADAS
    Private Sub traerSolMedProg()
        dgvSolMedProgramadas.DataSource = confirmacionSolMed.traerSolMedProgramadasHoy()
    End Sub




    'METODOS CLICK
    Private Sub btnConfirmarSolicitud_Click(sender As Object, e As EventArgs) Handles btnConfirmarSolicitud.Click
        Dim filasTickeadas As List(Of DataGridViewRow) = New List(Of DataGridViewRow)()

        For Each row As DataGridViewRow In dgvSolMedProgramadas.Rows
            Dim casillaCheckBox As DataGridViewCheckBoxCell

            casillaCheckBox = TryCast(row.Cells(dgvSolMedProgramadas.ColumnCount - 1), DataGridViewCheckBoxCell)

            If casillaCheckBox.Value = True Then
                filasTickeadas.Add(row)
            End If
        Next

        confirmacionSolMed.confirmarSolicitudes(filasTickeadas)
        MessageBox.Show("Las solicitudes se confirmaron correctamente")
        FromMenuTriaje.Show()
        Me.Close()
    End Sub





    'METODOS CHECKBOXES
    Private Sub cboxTodo_CheckedChanged(sender As Object, e As EventArgs) Handles cboxTodo.CheckedChanged
        If cboxTodo.Checked = True Then
            seleccionarTodo()
        Else
            deseleccionarTodo()
        End If

    End Sub

    Private Sub seleccionarTodo()
        For Each row As DataGridViewRow In dgvSolMedProgramadas.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells(dgvSolMedProgramadas.ColumnCount - 1), DataGridViewCheckBoxCell))
            checkBox.Value = True
        Next

    End Sub

    Private Sub deseleccionarTodo()
        For Each row As DataGridViewRow In dgvSolMedProgramadas.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells(dgvSolMedProgramadas.ColumnCount - 1), DataGridViewCheckBoxCell))
            checkBox.Value = False
        Next

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FromMenuTriaje.Show()
        Me.Close()
    End Sub


End Class