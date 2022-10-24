<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAsignarTurno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAsignarTurno))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.edLaTurnos = New System.Windows.Forms.Label()
        Me.edHintCTurnos = New System.Windows.Forms.Label()
        Me.edCoTurnos = New System.Windows.Forms.ComboBox()
        Me.edLaModoEdicion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hintCmboxMedico = New System.Windows.Forms.Label()
        Me.edHintCModoEdicion = New System.Windows.Forms.Label()
        Me.btnBuscarMedico = New System.Windows.Forms.Button()
        Me.label25 = New System.Windows.Forms.Label()
        Me.edCoModoEdicion = New System.Windows.Forms.ComboBox()
        Me.txtMedico = New System.Windows.Forms.TextBox()
        Me.cmboxMedicos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelListaTurnos = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvTurnos = New System.Windows.Forms.DataGridView()
        Me.lblTituloGrupo3 = New System.Windows.Forms.Label()
        Me.btnRegistrarTurnos = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregarTurno = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelTipoTurno = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rButtonTarde = New System.Windows.Forms.RadioButton()
        Me.rButtonMañana = New System.Windows.Forms.RadioButton()
        Me.panelHorario = New System.Windows.Forms.Panel()
        Me.txtCantidadFichas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.hintCmboxDuracionFicha = New System.Windows.Forms.Label()
        Me.cmboxEntradaHora = New System.Windows.Forms.ComboBox()
        Me.cmboxDuracionFicha = New System.Windows.Forms.ComboBox()
        Me.cmboxEntradaMinutos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmboxSalidaMinutos = New System.Windows.Forms.ComboBox()
        Me.cmboxSalidaHora = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelDatosTurno = New System.Windows.Forms.Panel()
        Me.lblDiasTurno = New System.Windows.Forms.Label()
        Me.chListDias = New System.Windows.Forms.CheckedListBox()
        Me.toolStripModosForm = New System.Windows.Forms.ToolStrip()
        Me.tlStripRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.tlStripEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlStripEliminar = New System.Windows.Forms.ToolStripButton()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelListaTurnos.SuspendLayout()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTipoTurno.SuspendLayout()
        Me.panelHorario.SuspendLayout()
        Me.panelDatosTurno.SuspendLayout()
        Me.toolStripModosForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(53, 54)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1575, 31)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(695, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ASIGNAR TURNO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.edLaTurnos)
        Me.Panel1.Controls.Add(Me.edHintCTurnos)
        Me.Panel1.Controls.Add(Me.edCoTurnos)
        Me.Panel1.Controls.Add(Me.edLaModoEdicion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.hintCmboxMedico)
        Me.Panel1.Controls.Add(Me.edHintCModoEdicion)
        Me.Panel1.Controls.Add(Me.btnBuscarMedico)
        Me.Panel1.Controls.Add(Me.label25)
        Me.Panel1.Controls.Add(Me.edCoModoEdicion)
        Me.Panel1.Controls.Add(Me.txtMedico)
        Me.Panel1.Controls.Add(Me.cmboxMedicos)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(53, 103)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 264)
        Me.Panel1.TabIndex = 2
        '
        'edLaTurnos
        '
        Me.edLaTurnos.AutoSize = True
        Me.edLaTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edLaTurnos.Location = New System.Drawing.Point(84, 215)
        Me.edLaTurnos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.edLaTurnos.Name = "edLaTurnos"
        Me.edLaTurnos.Size = New System.Drawing.Size(58, 20)
        Me.edLaTurnos.TabIndex = 75
        Me.edLaTurnos.Text = "Turnos"
        '
        'edHintCTurnos
        '
        Me.edHintCTurnos.AutoSize = True
        Me.edHintCTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edHintCTurnos.Location = New System.Drawing.Point(163, 217)
        Me.edHintCTurnos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.edHintCTurnos.Name = "edHintCTurnos"
        Me.edHintCTurnos.Size = New System.Drawing.Size(114, 18)
        Me.edHintCTurnos.TabIndex = 74
        Me.edHintCTurnos.Text = "SELECCIONAR"
        '
        'edCoTurnos
        '
        Me.edCoTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edCoTurnos.FormattingEnabled = True
        Me.edCoTurnos.Location = New System.Drawing.Point(159, 212)
        Me.edCoTurnos.Margin = New System.Windows.Forms.Padding(4)
        Me.edCoTurnos.Name = "edCoTurnos"
        Me.edCoTurnos.Size = New System.Drawing.Size(381, 26)
        Me.edCoTurnos.TabIndex = 73
        '
        'edLaModoEdicion
        '
        Me.edLaModoEdicion.AutoSize = True
        Me.edLaModoEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edLaModoEdicion.Location = New System.Drawing.Point(84, 169)
        Me.edLaModoEdicion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.edLaModoEdicion.Name = "edLaModoEdicion"
        Me.edLaModoEdicion.Size = New System.Drawing.Size(125, 20)
        Me.edLaModoEdicion.TabIndex = 72
        Me.edLaModoEdicion.Text = "Modo de edición"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Medico"
        '
        'hintCmboxMedico
        '
        Me.hintCmboxMedico.AutoSize = True
        Me.hintCmboxMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCmboxMedico.Location = New System.Drawing.Point(163, 122)
        Me.hintCmboxMedico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintCmboxMedico.Name = "hintCmboxMedico"
        Me.hintCmboxMedico.Size = New System.Drawing.Size(114, 18)
        Me.hintCmboxMedico.TabIndex = 0
        Me.hintCmboxMedico.Text = "SELECCIONAR"
        '
        'edHintCModoEdicion
        '
        Me.edHintCModoEdicion.AutoSize = True
        Me.edHintCModoEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edHintCModoEdicion.Location = New System.Drawing.Point(243, 170)
        Me.edHintCModoEdicion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.edHintCModoEdicion.Name = "edHintCModoEdicion"
        Me.edHintCModoEdicion.Size = New System.Drawing.Size(114, 18)
        Me.edHintCModoEdicion.TabIndex = 71
        Me.edHintCModoEdicion.Text = "SELECCIONAR"
        '
        'btnBuscarMedico
        '
        Me.btnBuscarMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarMedico.Location = New System.Drawing.Point(445, 64)
        Me.btnBuscarMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarMedico.Name = "btnBuscarMedico"
        Me.btnBuscarMedico.Size = New System.Drawing.Size(96, 31)
        Me.btnBuscarMedico.TabIndex = 2
        Me.btnBuscarMedico.Text = "Buscar"
        Me.btnBuscarMedico.UseVisualStyleBackColor = True
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label25.Location = New System.Drawing.Point(75, 70)
        Me.label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(65, 20)
        Me.label25.TabIndex = 0
        Me.label25.Text = "Nombre"
        '
        'edCoModoEdicion
        '
        Me.edCoModoEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edCoModoEdicion.FormattingEnabled = True
        Me.edCoModoEdicion.Location = New System.Drawing.Point(237, 165)
        Me.edCoModoEdicion.Margin = New System.Windows.Forms.Padding(4)
        Me.edCoModoEdicion.Name = "edCoModoEdicion"
        Me.edCoModoEdicion.Size = New System.Drawing.Size(303, 26)
        Me.edCoModoEdicion.TabIndex = 70
        '
        'txtMedico
        '
        Me.txtMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedico.Location = New System.Drawing.Point(159, 66)
        Me.txtMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.Size = New System.Drawing.Size(277, 24)
        Me.txtMedico.TabIndex = 1
        '
        'cmboxMedicos
        '
        Me.cmboxMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxMedicos.FormattingEnabled = True
        Me.cmboxMedicos.Location = New System.Drawing.Point(159, 117)
        Me.cmboxMedicos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxMedicos.Name = "cmboxMedicos"
        Me.cmboxMedicos.Size = New System.Drawing.Size(381, 26)
        Me.cmboxMedicos.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(21, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1.- Buscar medico"
        '
        'panelListaTurnos
        '
        Me.panelListaTurnos.BackColor = System.Drawing.Color.White
        Me.panelListaTurnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelListaTurnos.Controls.Add(Me.Label14)
        Me.panelListaTurnos.Controls.Add(Me.Label8)
        Me.panelListaTurnos.Controls.Add(Me.dgvTurnos)
        Me.panelListaTurnos.Controls.Add(Me.lblTituloGrupo3)
        Me.panelListaTurnos.Location = New System.Drawing.Point(671, 103)
        Me.panelListaTurnos.Margin = New System.Windows.Forms.Padding(4)
        Me.panelListaTurnos.Name = "panelListaTurnos"
        Me.panelListaTurnos.Size = New System.Drawing.Size(957, 280)
        Me.panelListaTurnos.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(572, 64)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(149, 0, 149, 0)
        Me.Label14.Size = New System.Drawing.Size(341, 20)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "DIAS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(419, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(51, 0, 51, 0)
        Me.Label8.Size = New System.Drawing.Size(166, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "TURNO"
        '
        'dgvTurnos
        '
        Me.dgvTurnos.BackgroundColor = System.Drawing.Color.White
        Me.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurnos.Location = New System.Drawing.Point(37, 85)
        Me.dgvTurnos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTurnos.Name = "dgvTurnos"
        Me.dgvTurnos.RowHeadersWidth = 51
        Me.dgvTurnos.Size = New System.Drawing.Size(881, 135)
        Me.dgvTurnos.TabIndex = 1
        '
        'lblTituloGrupo3
        '
        Me.lblTituloGrupo3.AutoSize = True
        Me.lblTituloGrupo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloGrupo3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTituloGrupo3.Location = New System.Drawing.Point(33, 20)
        Me.lblTituloGrupo3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloGrupo3.Name = "lblTituloGrupo3"
        Me.lblTituloGrupo3.Size = New System.Drawing.Size(211, 24)
        Me.lblTituloGrupo3.TabIndex = 0
        Me.lblTituloGrupo3.Text = "3.- Turnos de trabajo "
        '
        'btnRegistrarTurnos
        '
        Me.btnRegistrarTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarTurnos.Location = New System.Drawing.Point(1383, 713)
        Me.btnRegistrarTurnos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrarTurnos.Name = "btnRegistrarTurnos"
        Me.btnRegistrarTurnos.Size = New System.Drawing.Size(245, 33)
        Me.btnRegistrarTurnos.TabIndex = 5
        Me.btnRegistrarTurnos.Text = "Registrar turnos"
        Me.btnRegistrarTurnos.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(1275, 713)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 33)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregarTurno
        '
        Me.btnAgregarTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTurno.Location = New System.Drawing.Point(761, 267)
        Me.btnAgregarTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarTurno.Name = "btnAgregarTurno"
        Me.btnAgregarTurno.Size = New System.Drawing.Size(237, 33)
        Me.btnAgregarTurno.TabIndex = 4
        Me.btnAgregarTurno.Text = "Adicionar"
        Me.btnAgregarTurno.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(31, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "2.- Datos del turno"
        '
        'panelTipoTurno
        '
        Me.panelTipoTurno.BackColor = System.Drawing.Color.White
        Me.panelTipoTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelTipoTurno.Controls.Add(Me.Label11)
        Me.panelTipoTurno.Controls.Add(Me.rButtonTarde)
        Me.panelTipoTurno.Controls.Add(Me.rButtonMañana)
        Me.panelTipoTurno.Location = New System.Drawing.Point(65, 70)
        Me.panelTipoTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.panelTipoTurno.Name = "panelTipoTurno"
        Me.panelTipoTurno.Size = New System.Drawing.Size(194, 112)
        Me.panelTipoTurno.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Tipo de turno"
        '
        'rButtonTarde
        '
        Me.rButtonTarde.AutoSize = True
        Me.rButtonTarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonTarde.Location = New System.Drawing.Point(16, 60)
        Me.rButtonTarde.Margin = New System.Windows.Forms.Padding(4)
        Me.rButtonTarde.Name = "rButtonTarde"
        Me.rButtonTarde.Size = New System.Drawing.Size(71, 22)
        Me.rButtonTarde.TabIndex = 2
        Me.rButtonTarde.TabStop = True
        Me.rButtonTarde.Text = "Tarde."
        Me.rButtonTarde.UseVisualStyleBackColor = True
        '
        'rButtonMañana
        '
        Me.rButtonMañana.AutoSize = True
        Me.rButtonMañana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonMañana.Location = New System.Drawing.Point(16, 33)
        Me.rButtonMañana.Margin = New System.Windows.Forms.Padding(4)
        Me.rButtonMañana.Name = "rButtonMañana"
        Me.rButtonMañana.Size = New System.Drawing.Size(86, 22)
        Me.rButtonMañana.TabIndex = 1
        Me.rButtonMañana.TabStop = True
        Me.rButtonMañana.Text = "Mañana."
        Me.rButtonMañana.UseVisualStyleBackColor = True
        '
        'panelHorario
        '
        Me.panelHorario.BackColor = System.Drawing.Color.White
        Me.panelHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelHorario.Controls.Add(Me.txtCantidadFichas)
        Me.panelHorario.Controls.Add(Me.Label6)
        Me.panelHorario.Controls.Add(Me.Label12)
        Me.panelHorario.Controls.Add(Me.hintCmboxDuracionFicha)
        Me.panelHorario.Controls.Add(Me.cmboxEntradaHora)
        Me.panelHorario.Controls.Add(Me.cmboxDuracionFicha)
        Me.panelHorario.Controls.Add(Me.cmboxEntradaMinutos)
        Me.panelHorario.Controls.Add(Me.Label4)
        Me.panelHorario.Controls.Add(Me.Label10)
        Me.panelHorario.Controls.Add(Me.cmboxSalidaMinutos)
        Me.panelHorario.Controls.Add(Me.cmboxSalidaHora)
        Me.panelHorario.Controls.Add(Me.Label5)
        Me.panelHorario.Location = New System.Drawing.Point(296, 70)
        Me.panelHorario.Margin = New System.Windows.Forms.Padding(4)
        Me.panelHorario.Name = "panelHorario"
        Me.panelHorario.Size = New System.Drawing.Size(410, 230)
        Me.panelHorario.TabIndex = 2
        '
        'txtCantidadFichas
        '
        Me.txtCantidadFichas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadFichas.Location = New System.Drawing.Point(187, 180)
        Me.txtCantidadFichas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadFichas.Name = "txtCantidadFichas"
        Me.txtCantidadFichas.Size = New System.Drawing.Size(180, 24)
        Me.txtCantidadFichas.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Horario"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(59, 183)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Nro fichas"
        '
        'hintCmboxDuracionFicha
        '
        Me.hintCmboxDuracionFicha.AutoSize = True
        Me.hintCmboxDuracionFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCmboxDuracionFicha.Location = New System.Drawing.Point(191, 139)
        Me.hintCmboxDuracionFicha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintCmboxDuracionFicha.Name = "hintCmboxDuracionFicha"
        Me.hintCmboxDuracionFicha.Size = New System.Drawing.Size(114, 18)
        Me.hintCmboxDuracionFicha.TabIndex = 63
        Me.hintCmboxDuracionFicha.Text = "SELECCIONAR"
        '
        'cmboxEntradaHora
        '
        Me.cmboxEntradaHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxEntradaHora.FormattingEnabled = True
        Me.cmboxEntradaHora.Location = New System.Drawing.Point(187, 43)
        Me.cmboxEntradaHora.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxEntradaHora.Name = "cmboxEntradaHora"
        Me.cmboxEntradaHora.Size = New System.Drawing.Size(69, 26)
        Me.cmboxEntradaHora.TabIndex = 0
        Me.cmboxEntradaHora.Text = "07"
        '
        'cmboxDuracionFicha
        '
        Me.cmboxDuracionFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxDuracionFicha.FormattingEnabled = True
        Me.cmboxDuracionFicha.Location = New System.Drawing.Point(187, 134)
        Me.cmboxDuracionFicha.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxDuracionFicha.Name = "cmboxDuracionFicha"
        Me.cmboxDuracionFicha.Size = New System.Drawing.Size(177, 26)
        Me.cmboxDuracionFicha.TabIndex = 4
        '
        'cmboxEntradaMinutos
        '
        Me.cmboxEntradaMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxEntradaMinutos.FormattingEnabled = True
        Me.cmboxEntradaMinutos.Location = New System.Drawing.Point(292, 43)
        Me.cmboxEntradaMinutos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxEntradaMinutos.Name = "cmboxEntradaMinutos"
        Me.cmboxEntradaMinutos.Size = New System.Drawing.Size(75, 26)
        Me.cmboxEntradaMinutos.TabIndex = 1
        Me.cmboxEntradaMinutos.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hora de entrada"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 138)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Duración ficha"
        '
        'cmboxSalidaMinutos
        '
        Me.cmboxSalidaMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxSalidaMinutos.FormattingEnabled = True
        Me.cmboxSalidaMinutos.Location = New System.Drawing.Point(292, 89)
        Me.cmboxSalidaMinutos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxSalidaMinutos.Name = "cmboxSalidaMinutos"
        Me.cmboxSalidaMinutos.Size = New System.Drawing.Size(75, 26)
        Me.cmboxSalidaMinutos.TabIndex = 3
        Me.cmboxSalidaMinutos.Text = "00"
        '
        'cmboxSalidaHora
        '
        Me.cmboxSalidaHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxSalidaHora.FormattingEnabled = True
        Me.cmboxSalidaHora.Location = New System.Drawing.Point(187, 89)
        Me.cmboxSalidaHora.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxSalidaHora.Name = "cmboxSalidaHora"
        Me.cmboxSalidaHora.Size = New System.Drawing.Size(69, 26)
        Me.cmboxSalidaHora.TabIndex = 2
        Me.cmboxSalidaHora.Text = "13"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Hora de salida"
        '
        'panelDatosTurno
        '
        Me.panelDatosTurno.BackColor = System.Drawing.Color.White
        Me.panelDatosTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosTurno.Controls.Add(Me.lblDiasTurno)
        Me.panelDatosTurno.Controls.Add(Me.panelHorario)
        Me.panelDatosTurno.Controls.Add(Me.chListDias)
        Me.panelDatosTurno.Controls.Add(Me.panelTipoTurno)
        Me.panelDatosTurno.Controls.Add(Me.Label9)
        Me.panelDatosTurno.Controls.Add(Me.btnAgregarTurno)
        Me.panelDatosTurno.Location = New System.Drawing.Point(53, 410)
        Me.panelDatosTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.panelDatosTurno.Name = "panelDatosTurno"
        Me.panelDatosTurno.Size = New System.Drawing.Size(1041, 336)
        Me.panelDatosTurno.TabIndex = 3
        '
        'lblDiasTurno
        '
        Me.lblDiasTurno.AutoSize = True
        Me.lblDiasTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiasTurno.Location = New System.Drawing.Point(743, 80)
        Me.lblDiasTurno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiasTurno.Name = "lblDiasTurno"
        Me.lblDiasTurno.Size = New System.Drawing.Size(104, 20)
        Me.lblDiasTurno.TabIndex = 0
        Me.lblDiasTurno.Text = "Dias de turno"
        '
        'chListDias
        '
        Me.chListDias.CheckOnClick = True
        Me.chListDias.FormattingEnabled = True
        Me.chListDias.Location = New System.Drawing.Point(747, 114)
        Me.chListDias.Margin = New System.Windows.Forms.Padding(4)
        Me.chListDias.MultiColumn = True
        Me.chListDias.Name = "chListDias"
        Me.chListDias.Size = New System.Drawing.Size(251, 123)
        Me.chListDias.TabIndex = 3
        '
        'toolStripModosForm
        '
        Me.toolStripModosForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.toolStripModosForm.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.toolStripModosForm.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStripModosForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlStripRegistrar, Me.tlStripEditar, Me.tlStripEliminar})
        Me.toolStripModosForm.Location = New System.Drawing.Point(0, 0)
        Me.toolStripModosForm.Name = "toolStripModosForm"
        Me.toolStripModosForm.Size = New System.Drawing.Size(1685, 28)
        Me.toolStripModosForm.TabIndex = 6
        Me.toolStripModosForm.Text = "ToolStrip1"
        '
        'tlStripRegistrar
        '
        Me.tlStripRegistrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlStripRegistrar.Image = CType(resources.GetObject("tlStripRegistrar.Image"), System.Drawing.Image)
        Me.tlStripRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlStripRegistrar.Name = "tlStripRegistrar"
        Me.tlStripRegistrar.Size = New System.Drawing.Size(94, 25)
        Me.tlStripRegistrar.Text = "REGISTRAR"
        '
        'tlStripEditar
        '
        Me.tlStripEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlStripEditar.Image = CType(resources.GetObject("tlStripEditar.Image"), System.Drawing.Image)
        Me.tlStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlStripEditar.Name = "tlStripEditar"
        Me.tlStripEditar.Size = New System.Drawing.Size(64, 25)
        Me.tlStripEditar.Text = "EDITAR"
        '
        'tlStripEliminar
        '
        Me.tlStripEliminar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tlStripEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlStripEliminar.Image = CType(resources.GetObject("tlStripEliminar.Image"), System.Drawing.Image)
        Me.tlStripEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlStripEliminar.Name = "tlStripEliminar"
        Me.tlStripEliminar.Size = New System.Drawing.Size(84, 25)
        Me.tlStripEliminar.Text = "ELIMINAR"
        '
        'BtnMenu
        '
        Me.BtnMenu.Location = New System.Drawing.Point(1193, 713)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(75, 33)
        Me.BtnMenu.TabIndex = 7
        Me.BtnMenu.Text = "Menú"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'FormAsignarTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 777)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.toolStripModosForm)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrarTurnos)
        Me.Controls.Add(Me.panelListaTurnos)
        Me.Controls.Add(Me.panelDatosTurno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAsignarTurno"
        Me.Text = "Asignar turno"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelListaTurnos.ResumeLayout(False)
        Me.panelListaTurnos.PerformLayout()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTipoTurno.ResumeLayout(False)
        Me.panelTipoTurno.PerformLayout()
        Me.panelHorario.ResumeLayout(False)
        Me.panelHorario.PerformLayout()
        Me.panelDatosTurno.ResumeLayout(False)
        Me.panelDatosTurno.PerformLayout()
        Me.toolStripModosForm.ResumeLayout(False)
        Me.toolStripModosForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents label25 As System.Windows.Forms.Label
    Friend WithEvents txtMedico As System.Windows.Forms.TextBox
    Friend WithEvents cmboxMedicos As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents panelListaTurnos As System.Windows.Forms.Panel
    Friend WithEvents dgvTurnos As System.Windows.Forms.DataGridView
    Friend WithEvents lblTituloGrupo3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarMedico As System.Windows.Forms.Button
    Friend WithEvents hintCmboxMedico As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarTurnos As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarTurno As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents panelTipoTurno As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rButtonTarde As System.Windows.Forms.RadioButton
    Friend WithEvents rButtonMañana As System.Windows.Forms.RadioButton
    Friend WithEvents panelHorario As System.Windows.Forms.Panel
    Friend WithEvents txtCantidadFichas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents hintCmboxDuracionFicha As System.Windows.Forms.Label
    Friend WithEvents cmboxEntradaHora As System.Windows.Forms.ComboBox
    Friend WithEvents cmboxDuracionFicha As System.Windows.Forms.ComboBox
    Friend WithEvents cmboxEntradaMinutos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmboxSalidaMinutos As System.Windows.Forms.ComboBox
    Friend WithEvents cmboxSalidaHora As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents panelDatosTurno As System.Windows.Forms.Panel
    Friend WithEvents lblDiasTurno As System.Windows.Forms.Label
    Friend WithEvents chListDias As System.Windows.Forms.CheckedListBox
    Friend WithEvents toolStripModosForm As System.Windows.Forms.ToolStrip
    Friend WithEvents tlStripRegistrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlStripEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlStripEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents edLaTurnos As System.Windows.Forms.Label
    Friend WithEvents edHintCTurnos As System.Windows.Forms.Label
    Friend WithEvents edCoTurnos As System.Windows.Forms.ComboBox
    Friend WithEvents edLaModoEdicion As System.Windows.Forms.Label
    Friend WithEvents edHintCModoEdicion As System.Windows.Forms.Label
    Friend WithEvents edCoModoEdicion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnMenu As Button
End Class
