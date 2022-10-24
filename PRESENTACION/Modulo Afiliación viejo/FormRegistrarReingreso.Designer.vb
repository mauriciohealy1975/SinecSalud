<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarReingreso
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
        Me.hintTitulares = New System.Windows.Forms.Label()
        Me.btnBuscarMatricula = New System.Windows.Forms.Button()
        Me.txtUltimoEmpleador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cboxTitulares = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.panelDatosPersonales = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panelDatosEmpleador = New System.Windows.Forms.Panel()
        Me.btnBuscarEmpleador = New System.Windows.Forms.Button()
        Me.chMismoEmlpeador = New System.Windows.Forms.CheckBox()
        Me.lblNuevoEmpleador = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNuevoEmpleador = New System.Windows.Forms.TextBox()
        Me.hintEmpleador = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboxEmpleador = New System.Windows.Forms.ComboBox()
        Me.panelDatosAvisoReingreso = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dpcFechaPresentacion = New System.Windows.Forms.DateTimePicker()
        Me.dpcFechaContratacion = New System.Windows.Forms.DateTimePicker()
        Me.numSalario = New System.Windows.Forms.NumericUpDown()
        Me.chReingresoCesantia = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.panelTipoContratacion = New System.Windows.Forms.Panel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.rButtonEventual = New System.Windows.Forms.RadioButton()
        Me.rButtonFijo = New System.Windows.Forms.RadioButton()
        Me.panelEmpresaPublica = New System.Windows.Forms.Panel()
        Me.hintEntDesc = New System.Windows.Forms.Label()
        Me.cboxEntDesc = New System.Windows.Forms.ComboBox()
        Me.hintProgProy = New System.Windows.Forms.Label()
        Me.cboxProgProy = New System.Windows.Forms.ComboBox()
        Me.chEntDesc = New System.Windows.Forms.CheckBox()
        Me.chProgProy = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chEmpPublica = New System.Windows.Forms.CheckBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.hintCargo = New System.Windows.Forms.Label()
        Me.cboxCargo = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.panelDatosPersonales.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelDatosEmpleador.SuspendLayout()
        Me.panelDatosAvisoReingreso.SuspendLayout()
        CType(Me.numSalario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTipoContratacion.SuspendLayout()
        Me.panelEmpresaPublica.SuspendLayout()
        Me.SuspendLayout()
        '
        'hintTitulares
        '
        Me.hintTitulares.AutoSize = True
        Me.hintTitulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTitulares.Location = New System.Drawing.Point(24, 90)
        Me.hintTitulares.Name = "hintTitulares"
        Me.hintTitulares.Size = New System.Drawing.Size(153, 13)
        Me.hintTitulares.TabIndex = 62
        Me.hintTitulares.Text = "SELECCIONAR ASEGURADO"
        '
        'btnBuscarMatricula
        '
        Me.btnBuscarMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarMatricula.Location = New System.Drawing.Point(211, 50)
        Me.btnBuscarMatricula.Name = "btnBuscarMatricula"
        Me.btnBuscarMatricula.Size = New System.Drawing.Size(67, 23)
        Me.btnBuscarMatricula.TabIndex = 3
        Me.btnBuscarMatricula.Text = "Buscar"
        Me.btnBuscarMatricula.UseVisualStyleBackColor = True
        '
        'txtUltimoEmpleador
        '
        Me.txtUltimoEmpleador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimoEmpleador.Location = New System.Drawing.Point(140, 50)
        Me.txtUltimoEmpleador.Name = "txtUltimoEmpleador"
        Me.txtUltimoEmpleador.Size = New System.Drawing.Size(268, 21)
        Me.txtUltimoEmpleador.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Último empleador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Matricula"
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Location = New System.Drawing.Point(83, 50)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(122, 21)
        Me.txtMatricula.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(357, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Nombres"
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(427, 120)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(119, 21)
        Me.txtNombres.TabIndex = 11
        '
        'cboxTitulares
        '
        Me.cboxTitulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTitulares.FormattingEnabled = True
        Me.cboxTitulares.Location = New System.Drawing.Point(19, 85)
        Me.cboxTitulares.Name = "cboxTitulares"
        Me.cboxTitulares.Size = New System.Drawing.Size(259, 23)
        Me.cboxTitulares.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(311, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Apellido materno"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(427, 50)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(119, 21)
        Me.txtApellidoPaterno.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1.- Datos personales"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(427, 85)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(119, 21)
        Me.txtApellidoMaterno.TabIndex = 2
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(1066, 510)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(169, 28)
        Me.btnEnviar.TabIndex = 10
        Me.btnEnviar.Text = "Registrar reingreso"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellido paterno"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(983, 510)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 28)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'panelDatosPersonales
        '
        Me.panelDatosPersonales.BackColor = System.Drawing.Color.White
        Me.panelDatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosPersonales.Controls.Add(Me.Label5)
        Me.panelDatosPersonales.Controls.Add(Me.NumericUpDown2)
        Me.panelDatosPersonales.Controls.Add(Me.hintTitulares)
        Me.panelDatosPersonales.Controls.Add(Me.btnBuscarMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.Label2)
        Me.panelDatosPersonales.Controls.Add(Me.txtMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.Label18)
        Me.panelDatosPersonales.Controls.Add(Me.txtNombres)
        Me.panelDatosPersonales.Controls.Add(Me.cboxTitulares)
        Me.panelDatosPersonales.Controls.Add(Me.txtApellidoMaterno)
        Me.panelDatosPersonales.Controls.Add(Me.Label15)
        Me.panelDatosPersonales.Controls.Add(Me.txtApellidoPaterno)
        Me.panelDatosPersonales.Controls.Add(Me.Label7)
        Me.panelDatosPersonales.Controls.Add(Me.Label3)
        Me.panelDatosPersonales.Location = New System.Drawing.Point(30, 63)
        Me.panelDatosPersonales.Name = "panelDatosPersonales"
        Me.panelDatosPersonales.Size = New System.Drawing.Size(569, 160)
        Me.panelDatosPersonales.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "traer desde años atras"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(190, 120)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(88, 21)
        Me.NumericUpDown2.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(498, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR REINGRESO"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 23)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1205, 22)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'panelDatosEmpleador
        '
        Me.panelDatosEmpleador.BackColor = System.Drawing.Color.White
        Me.panelDatosEmpleador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosEmpleador.Controls.Add(Me.btnBuscarEmpleador)
        Me.panelDatosEmpleador.Controls.Add(Me.chMismoEmlpeador)
        Me.panelDatosEmpleador.Controls.Add(Me.txtUltimoEmpleador)
        Me.panelDatosEmpleador.Controls.Add(Me.Label4)
        Me.panelDatosEmpleador.Controls.Add(Me.lblNuevoEmpleador)
        Me.panelDatosEmpleador.Controls.Add(Me.Label16)
        Me.panelDatosEmpleador.Controls.Add(Me.txtNuevoEmpleador)
        Me.panelDatosEmpleador.Controls.Add(Me.hintEmpleador)
        Me.panelDatosEmpleador.Controls.Add(Me.Label12)
        Me.panelDatosEmpleador.Controls.Add(Me.cboxEmpleador)
        Me.panelDatosEmpleador.Location = New System.Drawing.Point(627, 63)
        Me.panelDatosEmpleador.Name = "panelDatosEmpleador"
        Me.panelDatosEmpleador.Size = New System.Drawing.Size(608, 160)
        Me.panelDatosEmpleador.TabIndex = 17
        '
        'btnBuscarEmpleador
        '
        Me.btnBuscarEmpleador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleador.Location = New System.Drawing.Point(339, 85)
        Me.btnBuscarEmpleador.Name = "btnBuscarEmpleador"
        Me.btnBuscarEmpleador.Size = New System.Drawing.Size(67, 23)
        Me.btnBuscarEmpleador.TabIndex = 37
        Me.btnBuscarEmpleador.Text = "Buscar"
        Me.btnBuscarEmpleador.UseVisualStyleBackColor = True
        '
        'chMismoEmlpeador
        '
        Me.chMismoEmlpeador.AutoSize = True
        Me.chMismoEmlpeador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chMismoEmlpeador.Location = New System.Drawing.Point(438, 50)
        Me.chMismoEmlpeador.Name = "chMismoEmlpeador"
        Me.chMismoEmlpeador.Size = New System.Drawing.Size(157, 19)
        Me.chMismoEmlpeador.TabIndex = 17
        Me.chMismoEmlpeador.Text = "Es el mismo empleador"
        Me.chMismoEmlpeador.UseVisualStyleBackColor = True
        '
        'lblNuevoEmpleador
        '
        Me.lblNuevoEmpleador.AutoSize = True
        Me.lblNuevoEmpleador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoEmpleador.Location = New System.Drawing.Point(15, 85)
        Me.lblNuevoEmpleador.Name = "lblNuevoEmpleador"
        Me.lblNuevoEmpleador.Size = New System.Drawing.Size(117, 16)
        Me.lblNuevoEmpleador.TabIndex = 33
        Me.lblNuevoEmpleador.Text = "Nuevo empleador"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(15, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "2.- Datos Empleador"
        '
        'txtNuevoEmpleador
        '
        Me.txtNuevoEmpleador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoEmpleador.Location = New System.Drawing.Point(140, 85)
        Me.txtNuevoEmpleador.Name = "txtNuevoEmpleador"
        Me.txtNuevoEmpleador.Size = New System.Drawing.Size(193, 21)
        Me.txtNuevoEmpleador.TabIndex = 32
        '
        'hintEmpleador
        '
        Me.hintEmpleador.AutoSize = True
        Me.hintEmpleador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintEmpleador.Location = New System.Drawing.Point(20, 125)
        Me.hintEmpleador.Name = "hintEmpleador"
        Me.hintEmpleador.Size = New System.Drawing.Size(193, 13)
        Me.hintEmpleador.TabIndex = 0
        Me.hintEmpleador.Text = "SELECCIONAR NUEVO EMPLEADOR"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 16)
        Me.Label12.TabIndex = 0
        '
        'cboxEmpleador
        '
        Me.cboxEmpleador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxEmpleador.FormattingEnabled = True
        Me.cboxEmpleador.Location = New System.Drawing.Point(15, 120)
        Me.cboxEmpleador.Name = "cboxEmpleador"
        Me.cboxEmpleador.Size = New System.Drawing.Size(318, 23)
        Me.cboxEmpleador.TabIndex = 3
        '
        'panelDatosAvisoReingreso
        '
        Me.panelDatosAvisoReingreso.BackColor = System.Drawing.Color.White
        Me.panelDatosAvisoReingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosAvisoReingreso.Controls.Add(Me.Label6)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.dpcFechaPresentacion)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.dpcFechaContratacion)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.numSalario)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.chReingresoCesantia)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.Label23)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.panelTipoContratacion)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.panelEmpresaPublica)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.chEmpPublica)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.Label43)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.hintCargo)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.cboxCargo)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.Label42)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.Label40)
        Me.panelDatosAvisoReingreso.Controls.Add(Me.Label17)
        Me.panelDatosAvisoReingreso.Location = New System.Drawing.Point(30, 246)
        Me.panelDatosAvisoReingreso.Name = "panelDatosAvisoReingreso"
        Me.panelDatosAvisoReingreso.Size = New System.Drawing.Size(1156, 162)
        Me.panelDatosAvisoReingreso.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(593, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Bs."
        '
        'dpcFechaPresentacion
        '
        Me.dpcFechaPresentacion.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaPresentacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaPresentacion.Location = New System.Drawing.Point(838, 120)
        Me.dpcFechaPresentacion.Name = "dpcFechaPresentacion"
        Me.dpcFechaPresentacion.Size = New System.Drawing.Size(167, 21)
        Me.dpcFechaPresentacion.TabIndex = 73
        '
        'dpcFechaContratacion
        '
        Me.dpcFechaContratacion.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaContratacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaContratacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaContratacion.Location = New System.Drawing.Point(157, 85)
        Me.dpcFechaContratacion.Name = "dpcFechaContratacion"
        Me.dpcFechaContratacion.Size = New System.Drawing.Size(167, 21)
        Me.dpcFechaContratacion.TabIndex = 72
        '
        'numSalario
        '
        Me.numSalario.DecimalPlaces = 2
        Me.numSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSalario.Location = New System.Drawing.Point(433, 15)
        Me.numSalario.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.numSalario.Name = "numSalario"
        Me.numSalario.Size = New System.Drawing.Size(150, 21)
        Me.numSalario.TabIndex = 71
        '
        'chReingresoCesantia
        '
        Me.chReingresoCesantia.AutoSize = True
        Me.chReingresoCesantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chReingresoCesantia.Location = New System.Drawing.Point(10, 50)
        Me.chReingresoCesantia.Name = "chReingresoCesantia"
        Me.chReingresoCesantia.Size = New System.Drawing.Size(211, 19)
        Me.chReingresoCesantia.TabIndex = 37
        Me.chReingresoCesantia.Text = "Reingreso en periodo de cesantia"
        Me.chReingresoCesantia.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(686, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(146, 16)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Fecha de presentación"
        '
        'panelTipoContratacion
        '
        Me.panelTipoContratacion.BackColor = System.Drawing.Color.White
        Me.panelTipoContratacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelTipoContratacion.Controls.Add(Me.Label45)
        Me.panelTipoContratacion.Controls.Add(Me.rButtonEventual)
        Me.panelTipoContratacion.Controls.Add(Me.rButtonFijo)
        Me.panelTipoContratacion.Location = New System.Drawing.Point(376, 50)
        Me.panelTipoContratacion.Name = "panelTipoContratacion"
        Me.panelTipoContratacion.Size = New System.Drawing.Size(259, 58)
        Me.panelTipoContratacion.TabIndex = 31
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(13, 19)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(131, 16)
        Me.Label45.TabIndex = 34
        Me.Label45.Text = "Tipo de contratación"
        '
        'rButtonEventual
        '
        Me.rButtonEventual.AutoSize = True
        Me.rButtonEventual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonEventual.Location = New System.Drawing.Point(161, 28)
        Me.rButtonEventual.Name = "rButtonEventual"
        Me.rButtonEventual.Size = New System.Drawing.Size(72, 19)
        Me.rButtonEventual.TabIndex = 33
        Me.rButtonEventual.TabStop = True
        Me.rButtonEventual.Text = "Eventual"
        Me.rButtonEventual.UseVisualStyleBackColor = True
        '
        'rButtonFijo
        '
        Me.rButtonFijo.AutoSize = True
        Me.rButtonFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonFijo.Location = New System.Drawing.Point(161, 6)
        Me.rButtonFijo.Name = "rButtonFijo"
        Me.rButtonFijo.Size = New System.Drawing.Size(45, 19)
        Me.rButtonFijo.TabIndex = 32
        Me.rButtonFijo.TabStop = True
        Me.rButtonFijo.Text = "Fijo"
        Me.rButtonFijo.UseVisualStyleBackColor = True
        '
        'panelEmpresaPublica
        '
        Me.panelEmpresaPublica.BackColor = System.Drawing.Color.White
        Me.panelEmpresaPublica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpresaPublica.Controls.Add(Me.hintEntDesc)
        Me.panelEmpresaPublica.Controls.Add(Me.cboxEntDesc)
        Me.panelEmpresaPublica.Controls.Add(Me.hintProgProy)
        Me.panelEmpresaPublica.Controls.Add(Me.cboxProgProy)
        Me.panelEmpresaPublica.Controls.Add(Me.chEntDesc)
        Me.panelEmpresaPublica.Controls.Add(Me.chProgProy)
        Me.panelEmpresaPublica.Controls.Add(Me.Label8)
        Me.panelEmpresaPublica.Location = New System.Drawing.Point(686, 15)
        Me.panelEmpresaPublica.Name = "panelEmpresaPublica"
        Me.panelEmpresaPublica.Size = New System.Drawing.Size(415, 93)
        Me.panelEmpresaPublica.TabIndex = 10
        '
        'hintEntDesc
        '
        Me.hintEntDesc.AutoSize = True
        Me.hintEntDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintEntDesc.Location = New System.Drawing.Point(174, 64)
        Me.hintEntDesc.Name = "hintEntDesc"
        Me.hintEntDesc.Size = New System.Drawing.Size(82, 13)
        Me.hintEntDesc.TabIndex = 42
        Me.hintEntDesc.Text = "SELECCIONAR"
        '
        'cboxEntDesc
        '
        Me.cboxEntDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxEntDesc.FormattingEnabled = True
        Me.cboxEntDesc.Location = New System.Drawing.Point(170, 60)
        Me.cboxEntDesc.Name = "cboxEntDesc"
        Me.cboxEntDesc.Size = New System.Drawing.Size(228, 21)
        Me.cboxEntDesc.TabIndex = 43
        '
        'hintProgProy
        '
        Me.hintProgProy.AutoSize = True
        Me.hintProgProy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintProgProy.Location = New System.Drawing.Point(174, 39)
        Me.hintProgProy.Name = "hintProgProy"
        Me.hintProgProy.Size = New System.Drawing.Size(82, 13)
        Me.hintProgProy.TabIndex = 40
        Me.hintProgProy.Text = "SELECCIONAR"
        '
        'cboxProgProy
        '
        Me.cboxProgProy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxProgProy.FormattingEnabled = True
        Me.cboxProgProy.Location = New System.Drawing.Point(170, 35)
        Me.cboxProgProy.Name = "cboxProgProy"
        Me.cboxProgProy.Size = New System.Drawing.Size(228, 21)
        Me.cboxProgProy.TabIndex = 41
        '
        'chEntDesc
        '
        Me.chEntDesc.AutoSize = True
        Me.chEntDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEntDesc.Location = New System.Drawing.Point(13, 60)
        Me.chEntDesc.Name = "chEntDesc"
        Me.chEntDesc.Size = New System.Drawing.Size(159, 19)
        Me.chEntDesc.TabIndex = 33
        Me.chEntDesc.Text = "Entidad desconcentrada"
        Me.chEntDesc.UseVisualStyleBackColor = True
        '
        'chProgProy
        '
        Me.chProgProy.AutoSize = True
        Me.chProgProy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chProgProy.Location = New System.Drawing.Point(13, 35)
        Me.chProgProy.Name = "chProgProy"
        Me.chProgProy.Size = New System.Drawing.Size(131, 19)
        Me.chProgProy.TabIndex = 31
        Me.chProgProy.Text = "Programa/Proyecto"
        Me.chProgProy.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "El afiliado pertenece a:"
        '
        'chEmpPublica
        '
        Me.chEmpPublica.AutoSize = True
        Me.chEmpPublica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEmpPublica.Location = New System.Drawing.Point(376, 120)
        Me.chEmpPublica.Name = "chEmpPublica"
        Me.chEmpPublica.Size = New System.Drawing.Size(119, 19)
        Me.chEmpPublica.TabIndex = 30
        Me.chEmpPublica.Text = "Empresa pública"
        Me.chEmpPublica.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(376, 20)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(51, 16)
        Me.Label43.TabIndex = 25
        Me.Label43.Text = "Salario"
        '
        'hintCargo
        '
        Me.hintCargo.AutoSize = True
        Me.hintCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCargo.Location = New System.Drawing.Point(162, 125)
        Me.hintCargo.Name = "hintCargo"
        Me.hintCargo.Size = New System.Drawing.Size(82, 13)
        Me.hintCargo.TabIndex = 22
        Me.hintCargo.Text = "SELECCIONAR"
        '
        'cboxCargo
        '
        Me.cboxCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCargo.FormattingEnabled = True
        Me.cboxCargo.Location = New System.Drawing.Point(157, 120)
        Me.cboxCargo.Name = "cboxCargo"
        Me.cboxCargo.Size = New System.Drawing.Size(167, 23)
        Me.cboxCargo.TabIndex = 24
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(106, 120)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(45, 16)
        Me.Label42.TabIndex = 23
        Me.Label42.Text = "Cargo"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(10, 85)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(141, 16)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "Fecha de contratación"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(10, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(238, 17)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "3.- Datos de aviso de reingreso"
        '
        'FormRegistrarReingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.panelDatosAvisoReingreso)
        Me.Controls.Add(Me.panelDatosEmpleador)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.panelDatosPersonales)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarReingreso"
        Me.Text = "FormRegistrarReingreso"
        Me.panelDatosPersonales.ResumeLayout(False)
        Me.panelDatosPersonales.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelDatosEmpleador.ResumeLayout(False)
        Me.panelDatosEmpleador.PerformLayout()
        Me.panelDatosAvisoReingreso.ResumeLayout(False)
        Me.panelDatosAvisoReingreso.PerformLayout()
        CType(Me.numSalario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTipoContratacion.ResumeLayout(False)
        Me.panelTipoContratacion.PerformLayout()
        Me.panelEmpresaPublica.ResumeLayout(False)
        Me.panelEmpresaPublica.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents hintTitulares As System.Windows.Forms.Label
    Friend WithEvents btnBuscarMatricula As System.Windows.Forms.Button
    Friend WithEvents txtUltimoEmpleador As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents cboxTitulares As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents panelDatosPersonales As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelDatosEmpleador As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chMismoEmlpeador As System.Windows.Forms.CheckBox
    Friend WithEvents btnBuscarEmpleador As System.Windows.Forms.Button
    Friend WithEvents lblNuevoEmpleador As System.Windows.Forms.Label
    Friend WithEvents txtNuevoEmpleador As System.Windows.Forms.TextBox
    Friend WithEvents hintEmpleador As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboxEmpleador As System.Windows.Forms.ComboBox
    Friend WithEvents panelDatosAvisoReingreso As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents panelTipoContratacion As System.Windows.Forms.Panel
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents rButtonEventual As System.Windows.Forms.RadioButton
    Friend WithEvents rButtonFijo As System.Windows.Forms.RadioButton
    Friend WithEvents panelEmpresaPublica As System.Windows.Forms.Panel
    Friend WithEvents hintEntDesc As System.Windows.Forms.Label
    Friend WithEvents cboxEntDesc As System.Windows.Forms.ComboBox
    Friend WithEvents hintProgProy As System.Windows.Forms.Label
    Friend WithEvents cboxProgProy As System.Windows.Forms.ComboBox
    Friend WithEvents chEntDesc As System.Windows.Forms.CheckBox
    Friend WithEvents chProgProy As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chEmpPublica As System.Windows.Forms.CheckBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents hintCargo As System.Windows.Forms.Label
    Friend WithEvents cboxCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chReingresoCesantia As System.Windows.Forms.CheckBox
    Friend WithEvents numSalario As System.Windows.Forms.NumericUpDown
    Friend WithEvents dpcFechaPresentacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpcFechaContratacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
