<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProcesarProgramacionEP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.panelTraerProgramcion = New System.Windows.Forms.Panel()
        Me.dgvProgramaciones = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dpcProgramciones = New System.Windows.Forms.DateTimePicker()
        Me.btnTraerProgramaciones = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelBuscarEmpresa = New System.Windows.Forms.Label()
        Me.panelProcesarProgramacion = New System.Windows.Forms.Panel()
        Me.hintEstado = New System.Windows.Forms.Label()
        Me.cboxEstado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.lblApellidoMaterno = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblApellidoPaterno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelReprogramacion = New System.Windows.Forms.Panel()
        Me.dpcRayosX = New System.Windows.Forms.DateTimePicker()
        Me.chMedicoLaboral = New System.Windows.Forms.CheckBox()
        Me.chRayosX = New System.Windows.Forms.CheckBox()
        Me.chLaboratorio = New System.Windows.Forms.CheckBox()
        Me.txtFichas = New System.Windows.Forms.TextBox()
        Me.lblFichas = New System.Windows.Forms.Label()
        Me.dpcMedicoLaboral = New System.Windows.Forms.DateTimePicker()
        Me.dpcLaboratorio = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelTraerProgramcion.SuspendLayout()
        CType(Me.dgvProgramaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelProcesarProgramacion.SuspendLayout()
        Me.panelReprogramacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(40, 25)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1607, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(498, 1)
        Me.lblTituloPrincipal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(610, 25)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "PROCESAR PROGRAMACIÓN EXAMEN PRE-OCUPACIONAL"
        '
        'panelTraerProgramcion
        '
        Me.panelTraerProgramcion.BackColor = System.Drawing.Color.White
        Me.panelTraerProgramcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelTraerProgramcion.Controls.Add(Me.dgvProgramaciones)
        Me.panelTraerProgramcion.Controls.Add(Me.dpcProgramciones)
        Me.panelTraerProgramcion.Controls.Add(Me.btnTraerProgramaciones)
        Me.panelTraerProgramcion.Controls.Add(Me.Label3)
        Me.panelTraerProgramcion.Controls.Add(Me.panelBuscarEmpresa)
        Me.panelTraerProgramcion.Location = New System.Drawing.Point(40, 74)
        Me.panelTraerProgramcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelTraerProgramcion.Name = "panelTraerProgramcion"
        Me.panelTraerProgramcion.Size = New System.Drawing.Size(977, 283)
        Me.panelTraerProgramcion.TabIndex = 1
        '
        'dgvProgramaciones
        '
        Me.dgvProgramaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProgramaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvProgramaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3})
        Me.dgvProgramaciones.Location = New System.Drawing.Point(24, 105)
        Me.dgvProgramaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvProgramaciones.Name = "dgvProgramaciones"
        Me.dgvProgramaciones.RowHeadersWidth = 51
        Me.dgvProgramaciones.Size = New System.Drawing.Size(927, 153)
        Me.dgvProgramaciones.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "codigo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.HeaderText = "estado"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.HeaderText = "matricula"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "titular"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'dpcProgramciones
        '
        Me.dpcProgramciones.CustomFormat = "dd--MM--yyyy"
        Me.dpcProgramciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcProgramciones.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcProgramciones.Location = New System.Drawing.Point(93, 62)
        Me.dpcProgramciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dpcProgramciones.Name = "dpcProgramciones"
        Me.dpcProgramciones.ShowUpDown = True
        Me.dpcProgramciones.Size = New System.Drawing.Size(148, 24)
        Me.dpcProgramciones.TabIndex = 1
        '
        'btnTraerProgramaciones
        '
        Me.btnTraerProgramaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraerProgramaciones.Location = New System.Drawing.Point(251, 63)
        Me.btnTraerProgramaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTraerProgramaciones.Name = "btnTraerProgramaciones"
        Me.btnTraerProgramaciones.Size = New System.Drawing.Size(212, 28)
        Me.btnTraerProgramaciones.TabIndex = 2
        Me.btnTraerProgramaciones.Text = "Traer programaciones"
        Me.btnTraerProgramaciones.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Desde"
        '
        'panelBuscarEmpresa
        '
        Me.panelBuscarEmpresa.AutoSize = True
        Me.panelBuscarEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelBuscarEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelBuscarEmpresa.Location = New System.Drawing.Point(20, 18)
        Me.panelBuscarEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.panelBuscarEmpresa.Name = "panelBuscarEmpresa"
        Me.panelBuscarEmpresa.Size = New System.Drawing.Size(240, 24)
        Me.panelBuscarEmpresa.TabIndex = 0
        Me.panelBuscarEmpresa.Text = "1.- Taer programaciones"
        '
        'panelProcesarProgramacion
        '
        Me.panelProcesarProgramacion.BackColor = System.Drawing.Color.White
        Me.panelProcesarProgramacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelProcesarProgramacion.Controls.Add(Me.hintEstado)
        Me.panelProcesarProgramacion.Controls.Add(Me.cboxEstado)
        Me.panelProcesarProgramacion.Controls.Add(Me.Label1)
        Me.panelProcesarProgramacion.Controls.Add(Me.txtEmpresa)
        Me.panelProcesarProgramacion.Controls.Add(Me.lblNombres)
        Me.panelProcesarProgramacion.Controls.Add(Me.txtTitular)
        Me.panelProcesarProgramacion.Controls.Add(Me.lblApellidoMaterno)
        Me.panelProcesarProgramacion.Controls.Add(Me.txtCodigo)
        Me.panelProcesarProgramacion.Controls.Add(Me.lblApellidoPaterno)
        Me.panelProcesarProgramacion.Controls.Add(Me.Label2)
        Me.panelProcesarProgramacion.Location = New System.Drawing.Point(1047, 74)
        Me.panelProcesarProgramacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelProcesarProgramacion.Name = "panelProcesarProgramacion"
        Me.panelProcesarProgramacion.Size = New System.Drawing.Size(425, 240)
        Me.panelProcesarProgramacion.TabIndex = 2
        '
        'hintEstado
        '
        Me.hintEstado.AutoSize = True
        Me.hintEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintEstado.Location = New System.Drawing.Point(116, 197)
        Me.hintEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintEstado.Name = "hintEstado"
        Me.hintEstado.Size = New System.Drawing.Size(104, 17)
        Me.hintEstado.TabIndex = 0
        Me.hintEstado.Text = "SELECCIONAR"
        '
        'cboxEstado
        '
        Me.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxEstado.FormattingEnabled = True
        Me.cboxEstado.Items.AddRange(New Object() {"ESPOSO/A", "HIJO/A", ""})
        Me.cboxEstado.Location = New System.Drawing.Point(109, 191)
        Me.cboxEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxEstado.Name = "cboxEstado"
        Me.cboxEstado.Size = New System.Drawing.Size(193, 26)
        Me.cboxEstado.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 191)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estado"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(109, 148)
        Me.txtEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(291, 24)
        Me.txtEmpresa.TabIndex = 3
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(20, 148)
        Me.lblNombres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(73, 20)
        Me.lblNombres.TabIndex = 0
        Me.lblNombres.Text = "Empresa"
        '
        'txtTitular
        '
        Me.txtTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitular.Location = New System.Drawing.Point(109, 105)
        Me.txtTitular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(291, 24)
        Me.txtTitular.TabIndex = 2
        '
        'lblApellidoMaterno
        '
        Me.lblApellidoMaterno.AutoSize = True
        Me.lblApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoMaterno.Location = New System.Drawing.Point(44, 105)
        Me.lblApellidoMaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidoMaterno.Name = "lblApellidoMaterno"
        Me.lblApellidoMaterno.Size = New System.Drawing.Size(52, 20)
        Me.lblApellidoMaterno.TabIndex = 0
        Me.lblApellidoMaterno.Text = "Titular"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(109, 62)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(193, 24)
        Me.txtCodigo.TabIndex = 1
        '
        'lblApellidoPaterno
        '
        Me.lblApellidoPaterno.AutoSize = True
        Me.lblApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoPaterno.Location = New System.Drawing.Point(35, 62)
        Me.lblApellidoPaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidoPaterno.Name = "lblApellidoPaterno"
        Me.lblApellidoPaterno.Size = New System.Drawing.Size(59, 20)
        Me.lblApellidoPaterno.TabIndex = 0
        Me.lblApellidoPaterno.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "2.- Procesar programación"
        '
        'panelReprogramacion
        '
        Me.panelReprogramacion.BackColor = System.Drawing.Color.White
        Me.panelReprogramacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelReprogramacion.Controls.Add(Me.dpcRayosX)
        Me.panelReprogramacion.Controls.Add(Me.chMedicoLaboral)
        Me.panelReprogramacion.Controls.Add(Me.chRayosX)
        Me.panelReprogramacion.Controls.Add(Me.chLaboratorio)
        Me.panelReprogramacion.Controls.Add(Me.txtFichas)
        Me.panelReprogramacion.Controls.Add(Me.lblFichas)
        Me.panelReprogramacion.Controls.Add(Me.dpcMedicoLaboral)
        Me.panelReprogramacion.Controls.Add(Me.dpcLaboratorio)
        Me.panelReprogramacion.Controls.Add(Me.Label11)
        Me.panelReprogramacion.Location = New System.Drawing.Point(40, 390)
        Me.panelReprogramacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelReprogramacion.Name = "panelReprogramacion"
        Me.panelReprogramacion.Size = New System.Drawing.Size(825, 188)
        Me.panelReprogramacion.TabIndex = 3
        '
        'dpcRayosX
        '
        Me.dpcRayosX.CustomFormat = "dd--MM--yyyy"
        Me.dpcRayosX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcRayosX.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcRayosX.Location = New System.Drawing.Point(319, 98)
        Me.dpcRayosX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dpcRayosX.Name = "dpcRayosX"
        Me.dpcRayosX.Size = New System.Drawing.Size(149, 24)
        Me.dpcRayosX.TabIndex = 2
        '
        'chMedicoLaboral
        '
        Me.chMedicoLaboral.AutoSize = True
        Me.chMedicoLaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chMedicoLaboral.Location = New System.Drawing.Point(560, 64)
        Me.chMedicoLaboral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chMedicoLaboral.Name = "chMedicoLaboral"
        Me.chMedicoLaboral.Size = New System.Drawing.Size(219, 22)
        Me.chMedicoLaboral.TabIndex = 0
        Me.chMedicoLaboral.Text = "Reprogramar Médico laboral"
        Me.chMedicoLaboral.UseVisualStyleBackColor = True
        '
        'chRayosX
        '
        Me.chRayosX.AutoSize = True
        Me.chRayosX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRayosX.Location = New System.Drawing.Point(319, 64)
        Me.chRayosX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chRayosX.Name = "chRayosX"
        Me.chRayosX.Size = New System.Drawing.Size(179, 22)
        Me.chRayosX.TabIndex = 0
        Me.chRayosX.Text = "Reprogramar Rayos X"
        Me.chRayosX.UseVisualStyleBackColor = True
        '
        'chLaboratorio
        '
        Me.chLaboratorio.AutoSize = True
        Me.chLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chLaboratorio.Location = New System.Drawing.Point(59, 62)
        Me.chLaboratorio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chLaboratorio.Name = "chLaboratorio"
        Me.chLaboratorio.Size = New System.Drawing.Size(193, 22)
        Me.chLaboratorio.TabIndex = 0
        Me.chLaboratorio.Text = "Reprogramar laboratorio"
        Me.chLaboratorio.UseVisualStyleBackColor = True
        '
        'txtFichas
        '
        Me.txtFichas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFichas.Location = New System.Drawing.Point(729, 142)
        Me.txtFichas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFichas.Name = "txtFichas"
        Me.txtFichas.Size = New System.Drawing.Size(64, 24)
        Me.txtFichas.TabIndex = 4
        '
        'lblFichas
        '
        Me.lblFichas.AutoSize = True
        Me.lblFichas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFichas.Location = New System.Drawing.Point(560, 142)
        Me.lblFichas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFichas.Name = "lblFichas"
        Me.lblFichas.Size = New System.Drawing.Size(139, 20)
        Me.lblFichas.TabIndex = 0
        Me.lblFichas.Text = "Fichas disponibles"
        '
        'dpcMedicoLaboral
        '
        Me.dpcMedicoLaboral.CustomFormat = "dd--MM--yyyy"
        Me.dpcMedicoLaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcMedicoLaboral.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcMedicoLaboral.Location = New System.Drawing.Point(560, 98)
        Me.dpcMedicoLaboral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dpcMedicoLaboral.Name = "dpcMedicoLaboral"
        Me.dpcMedicoLaboral.Size = New System.Drawing.Size(160, 24)
        Me.dpcMedicoLaboral.TabIndex = 3
        '
        'dpcLaboratorio
        '
        Me.dpcLaboratorio.CustomFormat = "dd--MM--yyyy"
        Me.dpcLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcLaboratorio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcLaboratorio.Location = New System.Drawing.Point(59, 98)
        Me.dpcLaboratorio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dpcLaboratorio.Name = "dpcLaboratorio"
        Me.dpcLaboratorio.Size = New System.Drawing.Size(161, 24)
        Me.dpcLaboratorio.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(20, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(276, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "3.- Datos de reprogramación"
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(1319, 628)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(328, 34)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Procesar programación"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(1223, 628)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 34)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1685, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormProcesarProgramacionEP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 690)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.panelReprogramacion)
        Me.Controls.Add(Me.panelProcesarProgramacion)
        Me.Controls.Add(Me.panelTraerProgramcion)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormProcesarProgramacionEP"
        Me.Text = "FormProcesarProgramacionEP"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelTraerProgramcion.ResumeLayout(False)
        Me.panelTraerProgramcion.PerformLayout()
        CType(Me.dgvProgramaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelProcesarProgramacion.ResumeLayout(False)
        Me.panelProcesarProgramacion.PerformLayout()
        Me.panelReprogramacion.ResumeLayout(False)
        Me.panelReprogramacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents panelTraerProgramcion As System.Windows.Forms.Panel
    Friend WithEvents btnTraerProgramaciones As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelBuscarEmpresa As System.Windows.Forms.Label
    Friend WithEvents dpcProgramciones As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvProgramaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panelProcesarProgramacion As System.Windows.Forms.Panel
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents txtTitular As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidoMaterno As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidoPaterno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelReprogramacion As System.Windows.Forms.Panel
    Friend WithEvents chLaboratorio As System.Windows.Forms.CheckBox
    Friend WithEvents txtFichas As System.Windows.Forms.TextBox
    Friend WithEvents lblFichas As System.Windows.Forms.Label
    Friend WithEvents dpcMedicoLaboral As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpcLaboratorio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chMedicoLaboral As System.Windows.Forms.CheckBox
    Friend WithEvents chRayosX As System.Windows.Forms.CheckBox
    Friend WithEvents dpcRayosX As System.Windows.Forms.DateTimePicker
    Friend WithEvents hintEstado As System.Windows.Forms.Label
    Friend WithEvents cboxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
