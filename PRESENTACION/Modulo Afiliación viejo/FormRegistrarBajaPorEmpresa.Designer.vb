<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarBajaPorEmpresa
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
        Me.btnBuscarEmpresas = New System.Windows.Forms.Button()
        Me.hintEmpresa = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBuscarEmpresas = New System.Windows.Forms.TextBox()
        Me.cboxEmpresa = New System.Windows.Forms.ComboBox()
        Me.panelBuscarEmpresa = New System.Windows.Forms.Label()
        Me.panelEmpresa = New System.Windows.Forms.Panel()
        Me.dgvTitulares = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvBajas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelDatosAsegurado = New System.Windows.Forms.Panel()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fmeLblBuscar = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numSalario = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.hintCargo = New System.Windows.Forms.Label()
        Me.cboxCargo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dpcFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelDatosBaja = New System.Windows.Forms.Panel()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.dpcFechaPresentacion = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.hintMotivo = New System.Windows.Forms.Label()
        Me.cboxMotivo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelEmpresa.SuspendLayout()
        CType(Me.dgvTitulares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvBajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDatosAsegurado.SuspendLayout()
        CType(Me.numSalario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDatosBaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscarEmpresas
        '
        Me.btnBuscarEmpresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpresas.Location = New System.Drawing.Point(185, 50)
        Me.btnBuscarEmpresas.Name = "btnBuscarEmpresas"
        Me.btnBuscarEmpresas.Size = New System.Drawing.Size(59, 23)
        Me.btnBuscarEmpresas.TabIndex = 2
        Me.btnBuscarEmpresas.Text = "Buscar"
        Me.btnBuscarEmpresas.UseVisualStyleBackColor = True
        '
        'hintEmpresa
        '
        Me.hintEmpresa.AutoSize = True
        Me.hintEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintEmpresa.Location = New System.Drawing.Point(24, 89)
        Me.hintEmpresa.Name = "hintEmpresa"
        Me.hintEmpresa.Size = New System.Drawing.Size(82, 13)
        Me.hintEmpresa.TabIndex = 0
        Me.hintEmpresa.Text = "SELECCIONAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Empresa"
        '
        'txtBuscarEmpresas
        '
        Me.txtBuscarEmpresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarEmpresas.Location = New System.Drawing.Point(81, 50)
        Me.txtBuscarEmpresas.Name = "txtBuscarEmpresas"
        Me.txtBuscarEmpresas.Size = New System.Drawing.Size(98, 21)
        Me.txtBuscarEmpresas.TabIndex = 1
        '
        'cboxEmpresa
        '
        Me.cboxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxEmpresa.FormattingEnabled = True
        Me.cboxEmpresa.Location = New System.Drawing.Point(19, 85)
        Me.cboxEmpresa.Name = "cboxEmpresa"
        Me.cboxEmpresa.Size = New System.Drawing.Size(225, 21)
        Me.cboxEmpresa.TabIndex = 3
        '
        'panelBuscarEmpresa
        '
        Me.panelBuscarEmpresa.AutoSize = True
        Me.panelBuscarEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelBuscarEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelBuscarEmpresa.Location = New System.Drawing.Point(15, 15)
        Me.panelBuscarEmpresa.Name = "panelBuscarEmpresa"
        Me.panelBuscarEmpresa.Size = New System.Drawing.Size(156, 18)
        Me.panelBuscarEmpresa.TabIndex = 0
        Me.panelBuscarEmpresa.Text = "1.- Buscar empresa"
        '
        'panelEmpresa
        '
        Me.panelEmpresa.BackColor = System.Drawing.Color.White
        Me.panelEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpresa.Controls.Add(Me.hintEmpresa)
        Me.panelEmpresa.Controls.Add(Me.btnBuscarEmpresas)
        Me.panelEmpresa.Controls.Add(Me.Label3)
        Me.panelEmpresa.Controls.Add(Me.txtBuscarEmpresas)
        Me.panelEmpresa.Controls.Add(Me.cboxEmpresa)
        Me.panelEmpresa.Controls.Add(Me.panelBuscarEmpresa)
        Me.panelEmpresa.Location = New System.Drawing.Point(30, 63)
        Me.panelEmpresa.Name = "panelEmpresa"
        Me.panelEmpresa.Size = New System.Drawing.Size(265, 126)
        Me.panelEmpresa.TabIndex = 1
        '
        'dgvTitulares
        '
        Me.dgvTitulares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTitulares.BackgroundColor = System.Drawing.Color.White
        Me.dgvTitulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTitulares.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvTitulares.Location = New System.Drawing.Point(316, 82)
        Me.dgvTitulares.Name = "dgvTitulares"
        Me.dgvTitulares.Size = New System.Drawing.Size(625, 107)
        Me.dgvTitulares.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "matricula"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "nombre"
        Me.Column2.Name = "Column2"
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(1094, 510)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(141, 28)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Registrar bajas"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(1022, 510)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(66, 28)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(462, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(280, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR BAJA POR EMPRESA"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1205, 22)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvBajas
        '
        Me.dgvBajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBajas.BackgroundColor = System.Drawing.Color.White
        Me.dgvBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBajas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvBajas.Location = New System.Drawing.Point(322, 50)
        Me.dgvBajas.Name = "dgvBajas"
        Me.dgvBajas.Size = New System.Drawing.Size(557, 161)
        Me.dgvBajas.TabIndex = 7
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "matricula"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Column3
        '
        Me.Column3.HeaderText = "fecha presentacion"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "inicio cesantia"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "fin cesantia"
        Me.Column5.Name = "Column5"
        '
        'panelDatosAsegurado
        '
        Me.panelDatosAsegurado.BackColor = System.Drawing.Color.White
        Me.panelDatosAsegurado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosAsegurado.Controls.Add(Me.txtMatricula)
        Me.panelDatosAsegurado.Controls.Add(Me.Label2)
        Me.panelDatosAsegurado.Controls.Add(Me.fmeLblBuscar)
        Me.panelDatosAsegurado.Controls.Add(Me.txtNombres)
        Me.panelDatosAsegurado.Controls.Add(Me.txtApellidoMaterno)
        Me.panelDatosAsegurado.Controls.Add(Me.lblContraseña)
        Me.panelDatosAsegurado.Controls.Add(Me.txtApellidoPaterno)
        Me.panelDatosAsegurado.Controls.Add(Me.Label15)
        Me.panelDatosAsegurado.Controls.Add(Me.Label6)
        Me.panelDatosAsegurado.Location = New System.Drawing.Point(30, 212)
        Me.panelDatosAsegurado.Name = "panelDatosAsegurado"
        Me.panelDatosAsegurado.Size = New System.Drawing.Size(265, 195)
        Me.panelDatosAsegurado.TabIndex = 3
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Location = New System.Drawing.Point(125, 155)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(119, 21)
        Me.txtMatricula.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Matrícula"
        '
        'fmeLblBuscar
        '
        Me.fmeLblBuscar.AutoSize = True
        Me.fmeLblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fmeLblBuscar.Location = New System.Drawing.Point(55, 120)
        Me.fmeLblBuscar.Name = "fmeLblBuscar"
        Me.fmeLblBuscar.Size = New System.Drawing.Size(64, 16)
        Me.fmeLblBuscar.TabIndex = 0
        Me.fmeLblBuscar.Text = "Nombres"
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(125, 120)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(119, 21)
        Me.txtNombres.TabIndex = 3
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(125, 85)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(119, 21)
        Me.txtApellidoMaterno.TabIndex = 2
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(9, 85)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(110, 16)
        Me.lblContraseña.TabIndex = 0
        Me.lblContraseña.Text = "Apellido materno"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(125, 50)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(119, 21)
        Me.txtApellidoPaterno.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Apellido paterno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(15, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "2.- Datos del asegurado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(271, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 16)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Bs."
        '
        'numSalario
        '
        Me.numSalario.DecimalPlaces = 2
        Me.numSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSalario.Location = New System.Drawing.Point(154, 120)
        Me.numSalario.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.numSalario.Name = "numSalario"
        Me.numSalario.Size = New System.Drawing.Size(106, 21)
        Me.numSalario.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(98, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Salario"
        '
        'hintCargo
        '
        Me.hintCargo.AutoSize = True
        Me.hintCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCargo.Location = New System.Drawing.Point(159, 90)
        Me.hintCargo.Name = "hintCargo"
        Me.hintCargo.Size = New System.Drawing.Size(82, 13)
        Me.hintCargo.TabIndex = 0
        Me.hintCargo.Text = "SELECCIONAR"
        '
        'cboxCargo
        '
        Me.cboxCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxCargo.FormattingEnabled = True
        Me.cboxCargo.Location = New System.Drawing.Point(154, 85)
        Me.cboxCargo.Name = "cboxCargo"
        Me.cboxCargo.Size = New System.Drawing.Size(139, 23)
        Me.cboxCargo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cargo"
        '
        'dpcFechaBaja
        '
        Me.dpcFechaBaja.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaBaja.Location = New System.Drawing.Point(154, 50)
        Me.dpcFechaBaja.Name = "dpcFechaBaja"
        Me.dpcFechaBaja.ShowUpDown = True
        Me.dpcFechaBaja.Size = New System.Drawing.Size(139, 21)
        Me.dpcFechaBaja.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha de baja"
        '
        'panelDatosBaja
        '
        Me.panelDatosBaja.BackColor = System.Drawing.Color.White
        Me.panelDatosBaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosBaja.Controls.Add(Me.btnAdicionar)
        Me.panelDatosBaja.Controls.Add(Me.dpcFechaPresentacion)
        Me.panelDatosBaja.Controls.Add(Me.Label13)
        Me.panelDatosBaja.Controls.Add(Me.hintMotivo)
        Me.panelDatosBaja.Controls.Add(Me.cboxMotivo)
        Me.panelDatosBaja.Controls.Add(Me.Label10)
        Me.panelDatosBaja.Controls.Add(Me.Label8)
        Me.panelDatosBaja.Controls.Add(Me.numSalario)
        Me.panelDatosBaja.Controls.Add(Me.Label9)
        Me.panelDatosBaja.Controls.Add(Me.dgvBajas)
        Me.panelDatosBaja.Controls.Add(Me.Label17)
        Me.panelDatosBaja.Controls.Add(Me.hintCargo)
        Me.panelDatosBaja.Controls.Add(Me.Label4)
        Me.panelDatosBaja.Controls.Add(Me.cboxCargo)
        Me.panelDatosBaja.Controls.Add(Me.Label1)
        Me.panelDatosBaja.Controls.Add(Me.dpcFechaBaja)
        Me.panelDatosBaja.Location = New System.Drawing.Point(316, 212)
        Me.panelDatosBaja.Name = "panelDatosBaja"
        Me.panelDatosBaja.Size = New System.Drawing.Size(908, 263)
        Me.panelDatosBaja.TabIndex = 4
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Location = New System.Drawing.Point(154, 225)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(139, 23)
        Me.btnAdicionar.TabIndex = 6
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'dpcFechaPresentacion
        '
        Me.dpcFechaPresentacion.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaPresentacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaPresentacion.Location = New System.Drawing.Point(154, 190)
        Me.dpcFechaPresentacion.Name = "dpcFechaPresentacion"
        Me.dpcFechaPresentacion.ShowUpDown = True
        Me.dpcFechaPresentacion.Size = New System.Drawing.Size(139, 21)
        Me.dpcFechaPresentacion.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Fec. de presentación"
        '
        'hintMotivo
        '
        Me.hintMotivo.AutoSize = True
        Me.hintMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintMotivo.Location = New System.Drawing.Point(159, 160)
        Me.hintMotivo.Name = "hintMotivo"
        Me.hintMotivo.Size = New System.Drawing.Size(82, 13)
        Me.hintMotivo.TabIndex = 0
        Me.hintMotivo.Text = "SELECCIONAR"
        '
        'cboxMotivo
        '
        Me.cboxMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMotivo.FormattingEnabled = True
        Me.cboxMotivo.Location = New System.Drawing.Point(154, 155)
        Me.cboxMotivo.Name = "cboxMotivo"
        Me.cboxMotivo.Size = New System.Drawing.Size(139, 23)
        Me.cboxMotivo.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(101, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Motivo"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(15, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(155, 18)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "3.- Datos de la baja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(316, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(240, 0, 240, 0)
        Me.Label5.Size = New System.Drawing.Size(624, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ASEGURADOS ACTIVOS"
        '
        'FormRegistrarBajaPorEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.panelDatosBaja)
        Me.Controls.Add(Me.panelDatosAsegurado)
        Me.Controls.Add(Me.panelEmpresa)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.dgvTitulares)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarBajaPorEmpresa"
        Me.Text = "FormRegistrarBajaPorEmpresa"
        Me.panelEmpresa.ResumeLayout(False)
        Me.panelEmpresa.PerformLayout()
        CType(Me.dgvTitulares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvBajas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDatosAsegurado.ResumeLayout(False)
        Me.panelDatosAsegurado.PerformLayout()
        CType(Me.numSalario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDatosBaja.ResumeLayout(False)
        Me.panelDatosBaja.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarEmpresas As System.Windows.Forms.Button
    Friend WithEvents hintEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarEmpresas As System.Windows.Forms.TextBox
    Friend WithEvents cboxEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents panelBuscarEmpresa As System.Windows.Forms.Label
    Friend WithEvents panelEmpresa As System.Windows.Forms.Panel
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvBajas As System.Windows.Forms.DataGridView
    Friend WithEvents panelDatosAsegurado As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvTitulares As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fmeLblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents numSalario As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents hintCargo As System.Windows.Forms.Label
    Friend WithEvents cboxCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dpcFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panelDatosBaja As System.Windows.Forms.Panel
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents dpcFechaPresentacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents hintMotivo As System.Windows.Forms.Label
    Friend WithEvents cboxMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
