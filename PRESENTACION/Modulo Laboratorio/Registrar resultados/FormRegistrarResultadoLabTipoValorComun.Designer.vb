<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarResultadoLabTipoValorComun
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.lblNombreExamen = New System.Windows.Forms.Label()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.panelDatosExamen = New System.Windows.Forms.Panel()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.lblExamen = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtExamen = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.txtAsegurado = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.lblNombreAsegurado = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvReferencias = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblHeaderValorDeReferencia = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxProcesador = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblHeaderEdad = New System.Windows.Forms.Label()
        Me.cboxKit = New System.Windows.Forms.ComboBox()
        Me.hintKit = New System.Windows.Forms.Label()
        Me.hintProcesador = New System.Windows.Forms.Label()
        Me.panelDatosResultado = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hintProveedor = New System.Windows.Forms.Label()
        Me.cboxProveedor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numResultado = New System.Windows.Forms.NumericUpDown()
        Me.lblHeaderEmpty = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelDatosAsegurado = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelDatosExamen.SuspendLayout()
        CType(Me.dgvReferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDatosResultado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDatosAsegurado.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(40, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1173, 23)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(360, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(453, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR RESULTADOS DE TIPO VALOR NUMÉRICO"
        '
        'lblNombreExamen
        '
        Me.lblNombreExamen.AutoSize = True
        Me.lblNombreExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreExamen.Location = New System.Drawing.Point(125, 77)
        Me.lblNombreExamen.Name = "lblNombreExamen"
        Me.lblNombreExamen.Size = New System.Drawing.Size(0, 16)
        Me.lblNombreExamen.TabIndex = 5
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.Location = New System.Drawing.Point(1004, 486)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(206, 28)
        Me.btnEnviarDatos.TabIndex = 48
        Me.btnEnviarDatos.Text = "Guardar resultado"
        Me.btnEnviarDatos.UseVisualStyleBackColor = True
        '
        'panelDatosExamen
        '
        Me.panelDatosExamen.BackColor = System.Drawing.Color.White
        Me.panelDatosExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosExamen.Controls.Add(Me.txtArea)
        Me.panelDatosExamen.Controls.Add(Me.lblArea)
        Me.panelDatosExamen.Controls.Add(Me.txtUnidad)
        Me.panelDatosExamen.Controls.Add(Me.lblExamen)
        Me.panelDatosExamen.Controls.Add(Me.lblUnidad)
        Me.panelDatosExamen.Controls.Add(Me.Label15)
        Me.panelDatosExamen.Controls.Add(Me.txtExamen)
        Me.panelDatosExamen.Controls.Add(Me.Label16)
        Me.panelDatosExamen.Location = New System.Drawing.Point(30, 62)
        Me.panelDatosExamen.Name = "panelDatosExamen"
        Me.panelDatosExamen.Size = New System.Drawing.Size(328, 156)
        Me.panelDatosExamen.TabIndex = 49
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(75, 80)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(230, 21)
        Me.txtArea.TabIndex = 70
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(27, 80)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(36, 16)
        Me.lblArea.TabIndex = 69
        Me.lblArea.Text = "Area"
        '
        'txtUnidad
        '
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(78, 115)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(227, 21)
        Me.txtUnidad.TabIndex = 60
        '
        'lblExamen
        '
        Me.lblExamen.AutoSize = True
        Me.lblExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamen.Location = New System.Drawing.Point(12, 45)
        Me.lblExamen.Name = "lblExamen"
        Me.lblExamen.Size = New System.Drawing.Size(56, 16)
        Me.lblExamen.TabIndex = 57
        Me.lblExamen.Text = "Examen"
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidad.Location = New System.Drawing.Point(20, 115)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(51, 16)
        Me.lblUnidad.TabIndex = 59
        Me.lblUnidad.Text = "Unidad"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(15, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(168, 18)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "1.- Datos del examen"
        '
        'txtExamen
        '
        Me.txtExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExamen.Location = New System.Drawing.Point(75, 45)
        Me.txtExamen.Name = "txtExamen"
        Me.txtExamen.Size = New System.Drawing.Size(230, 21)
        Me.txtExamen.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(269, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 16)
        Me.Label16.TabIndex = 58
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Location = New System.Drawing.Point(78, 82)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(227, 21)
        Me.txtMatricula.TabIndex = 68
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(11, 83)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(61, 16)
        Me.lblMatricula.TabIndex = 67
        Me.lblMatricula.Text = "Matrícula"
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(65, 67)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(151, 21)
        Me.txtEdad.TabIndex = 66
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(15, 67)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(40, 16)
        Me.lblEdad.TabIndex = 65
        Me.lblEdad.Text = "Edad"
        '
        'txtAsegurado
        '
        Me.txtAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsegurado.Location = New System.Drawing.Point(78, 47)
        Me.txtAsegurado.Name = "txtAsegurado"
        Me.txtAsegurado.Size = New System.Drawing.Size(227, 21)
        Me.txtAsegurado.TabIndex = 62
        '
        'txtSexo
        '
        Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo.Location = New System.Drawing.Point(65, 36)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(151, 21)
        Me.txtSexo.TabIndex = 64
        '
        'lblNombreAsegurado
        '
        Me.lblNombreAsegurado.AutoSize = True
        Me.lblNombreAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreAsegurado.Location = New System.Drawing.Point(16, 48)
        Me.lblNombreAsegurado.Name = "lblNombreAsegurado"
        Me.lblNombreAsegurado.Size = New System.Drawing.Size(56, 16)
        Me.lblNombreAsegurado.TabIndex = 61
        Me.lblNombreAsegurado.Text = "Nombre"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(15, 37)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(38, 16)
        Me.lblSexo.TabIndex = 63
        Me.lblSexo.Text = "Sexo"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(486, 260)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(102, 16)
        Me.lblResultado.TabIndex = 32
        Me.lblResultado.Text = "Resultado en %"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(15, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 18)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "3.- Registrar resultado"
        '
        'dgvReferencias
        '
        Me.dgvReferencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReferencias.BackgroundColor = System.Drawing.Color.White
        Me.dgvReferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column4, Me.Column1, Me.Column2})
        Me.dgvReferencias.Location = New System.Drawing.Point(17, 92)
        Me.dgvReferencias.Name = "dgvReferencias"
        Me.dgvReferencias.Size = New System.Drawing.Size(446, 296)
        Me.dgvReferencias.TabIndex = 58
        '
        'Column5
        '
        Me.Column5.HeaderText = "DESDE"
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.HeaderText = "HASTA"
        Me.Column4.Name = "Column4"
        '
        'Column1
        '
        Me.Column1.HeaderText = "DESDE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "HASTA"
        Me.Column2.Name = "Column2"
        '
        'lblHeaderValorDeReferencia
        '
        Me.lblHeaderValorDeReferencia.BackColor = System.Drawing.Color.White
        Me.lblHeaderValorDeReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeaderValorDeReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderValorDeReferencia.Location = New System.Drawing.Point(261, 74)
        Me.lblHeaderValorDeReferencia.Name = "lblHeaderValorDeReferencia"
        Me.lblHeaderValorDeReferencia.Size = New System.Drawing.Size(202, 18)
        Me.lblHeaderValorDeReferencia.TabIndex = 57
        Me.lblHeaderValorDeReferencia.Text = "VALORES EN %"
        Me.lblHeaderValorDeReferencia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(487, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Kit / Equipo"
        '
        'cboxProcesador
        '
        Me.cboxProcesador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxProcesador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxProcesador.FormattingEnabled = True
        Me.cboxProcesador.Location = New System.Drawing.Point(570, 104)
        Me.cboxProcesador.Name = "cboxProcesador"
        Me.cboxProcesador.Size = New System.Drawing.Size(240, 23)
        Me.cboxProcesador.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(487, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Procesador"
        '
        'lblHeaderEdad
        '
        Me.lblHeaderEdad.BackColor = System.Drawing.Color.White
        Me.lblHeaderEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeaderEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderEdad.Location = New System.Drawing.Point(58, 74)
        Me.lblHeaderEdad.Name = "lblHeaderEdad"
        Me.lblHeaderEdad.Size = New System.Drawing.Size(203, 18)
        Me.lblHeaderEdad.TabIndex = 59
        Me.lblHeaderEdad.Text = "EDAD EN AÑOS"
        Me.lblHeaderEdad.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboxKit
        '
        Me.cboxKit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxKit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxKit.FormattingEnabled = True
        Me.cboxKit.Location = New System.Drawing.Point(570, 69)
        Me.cboxKit.Name = "cboxKit"
        Me.cboxKit.Size = New System.Drawing.Size(240, 23)
        Me.cboxKit.TabIndex = 60
        '
        'hintKit
        '
        Me.hintKit.AutoSize = True
        Me.hintKit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintKit.Location = New System.Drawing.Point(574, 73)
        Me.hintKit.Name = "hintKit"
        Me.hintKit.Size = New System.Drawing.Size(82, 13)
        Me.hintKit.TabIndex = 61
        Me.hintKit.Text = "SELECCIONAR"
        '
        'hintProcesador
        '
        Me.hintProcesador.AutoSize = True
        Me.hintProcesador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintProcesador.Location = New System.Drawing.Point(574, 108)
        Me.hintProcesador.Name = "hintProcesador"
        Me.hintProcesador.Size = New System.Drawing.Size(82, 13)
        Me.hintProcesador.TabIndex = 36
        Me.hintProcesador.Text = "SELECCIONAR"
        '
        'panelDatosResultado
        '
        Me.panelDatosResultado.BackColor = System.Drawing.Color.White
        Me.panelDatosResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosResultado.Controls.Add(Me.GroupBox1)
        Me.panelDatosResultado.Controls.Add(Me.hintProveedor)
        Me.panelDatosResultado.Controls.Add(Me.cboxProveedor)
        Me.panelDatosResultado.Controls.Add(Me.Label2)
        Me.panelDatosResultado.Controls.Add(Me.lblHeaderEdad)
        Me.panelDatosResultado.Controls.Add(Me.numResultado)
        Me.panelDatosResultado.Controls.Add(Me.lblHeaderEmpty)
        Me.panelDatosResultado.Controls.Add(Me.Label14)
        Me.panelDatosResultado.Controls.Add(Me.hintProcesador)
        Me.panelDatosResultado.Controls.Add(Me.hintKit)
        Me.panelDatosResultado.Controls.Add(Me.cboxKit)
        Me.panelDatosResultado.Controls.Add(Me.Label7)
        Me.panelDatosResultado.Controls.Add(Me.cboxProcesador)
        Me.panelDatosResultado.Controls.Add(Me.Label4)
        Me.panelDatosResultado.Controls.Add(Me.lblHeaderValorDeReferencia)
        Me.panelDatosResultado.Controls.Add(Me.rc)
        Me.panelDatosResultado.Controls.Add(Me.dgvReferencias)
        Me.panelDatosResultado.Controls.Add(Me.Label13)
        Me.panelDatosResultado.Controls.Add(Me.Label1)
        Me.panelDatosResultado.Controls.Add(Me.lblResultado)
        Me.panelDatosResultado.Location = New System.Drawing.Point(377, 62)
        Me.panelDatosResultado.Name = "panelDatosResultado"
        Me.panelDatosResultado.Size = New System.Drawing.Size(836, 411)
        Me.panelDatosResultado.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.lblSexo)
        Me.GroupBox1.Controls.Add(Me.lblEdad)
        Me.GroupBox1.Controls.Add(Me.txtSexo)
        Me.GroupBox1.Location = New System.Drawing.Point(487, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 102)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Parametros de referencia"
        '
        'hintProveedor
        '
        Me.hintProveedor.AutoSize = True
        Me.hintProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintProveedor.Location = New System.Drawing.Point(576, 34)
        Me.hintProveedor.Name = "hintProveedor"
        Me.hintProveedor.Size = New System.Drawing.Size(82, 13)
        Me.hintProveedor.TabIndex = 67
        Me.hintProveedor.Text = "SELECCIONAR"
        '
        'cboxProveedor
        '
        Me.cboxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxProveedor.FormattingEnabled = True
        Me.cboxProveedor.Location = New System.Drawing.Point(570, 29)
        Me.cboxProveedor.Name = "cboxProveedor"
        Me.cboxProveedor.Size = New System.Drawing.Size(240, 23)
        Me.cboxProveedor.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(493, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Proveedor"
        '
        'numResultado
        '
        Me.numResultado.DecimalPlaces = 3
        Me.numResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numResultado.Location = New System.Drawing.Point(594, 258)
        Me.numResultado.Name = "numResultado"
        Me.numResultado.Size = New System.Drawing.Size(177, 23)
        Me.numResultado.TabIndex = 53
        '
        'lblHeaderEmpty
        '
        Me.lblHeaderEmpty.BackColor = System.Drawing.Color.White
        Me.lblHeaderEmpty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeaderEmpty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderEmpty.Location = New System.Drawing.Point(17, 74)
        Me.lblHeaderEmpty.Name = "lblHeaderEmpty"
        Me.lblHeaderEmpty.Size = New System.Drawing.Size(68, 18)
        Me.lblHeaderEmpty.TabIndex = 64
        Me.lblHeaderEmpty.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(288, 16)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "VALORES DE REFERENCIA DEL KIT-EQUIPO"
        '
        'rc
        '
        Me.rc.AcceptsTab = True
        Me.rc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.rc.Location = New System.Drawing.Point(487, 317)
        Me.rc.Multiline = True
        Me.rc.Name = "rc"
        Me.rc.Size = New System.Drawing.Size(323, 71)
        Me.rc.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(487, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Observaciones"
        '
        'panelDatosAsegurado
        '
        Me.panelDatosAsegurado.BackColor = System.Drawing.Color.White
        Me.panelDatosAsegurado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosAsegurado.Controls.Add(Me.Label22)
        Me.panelDatosAsegurado.Controls.Add(Me.txtMatricula)
        Me.panelDatosAsegurado.Controls.Add(Me.lblNombreAsegurado)
        Me.panelDatosAsegurado.Controls.Add(Me.lblMatricula)
        Me.panelDatosAsegurado.Controls.Add(Me.txtAsegurado)
        Me.panelDatosAsegurado.Location = New System.Drawing.Point(30, 236)
        Me.panelDatosAsegurado.Name = "panelDatosAsegurado"
        Me.panelDatosAsegurado.Size = New System.Drawing.Size(328, 130)
        Me.panelDatosAsegurado.TabIndex = 52
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(15, 15)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(189, 18)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "2.- Datos del asegurado"
        '
        'FormRegistrarResultadoLabTipoValorComun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1244, 541)
        Me.Controls.Add(Me.panelDatosAsegurado)
        Me.Controls.Add(Me.panelDatosResultado)
        Me.Controls.Add(Me.panelDatosExamen)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblNombreExamen)
        Me.Name = "FormRegistrarResultadoLabTipoValorComun"
        Me.Text = "Registrar resultados de tipo valor numérico"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelDatosExamen.ResumeLayout(False)
        Me.panelDatosExamen.PerformLayout()
        CType(Me.dgvReferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDatosResultado.ResumeLayout(False)
        Me.panelDatosResultado.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDatosAsegurado.ResumeLayout(False)
        Me.panelDatosAsegurado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreExamen As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents btnEnviarDatos As Button
    Friend WithEvents panelDatosExamen As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvReferencias As DataGridView
    Friend WithEvents lblHeaderValorDeReferencia As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboxProcesador As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHeaderEdad As Label
    Friend WithEvents cboxKit As ComboBox
    Friend WithEvents hintKit As Label
    Friend WithEvents hintProcesador As Label
    Friend WithEvents panelDatosResultado As Panel
    Friend WithEvents rc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents txtAsegurado As TextBox
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents lblNombreAsegurado As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblExamen As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents lblMatricula As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblHeaderEmpty As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents txtExamen As TextBox
    Friend WithEvents panelDatosAsegurado As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents lblUnidad As Label
    Friend WithEvents numResultado As NumericUpDown
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents hintProveedor As Label
    Friend WithEvents cboxProveedor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
End Class
