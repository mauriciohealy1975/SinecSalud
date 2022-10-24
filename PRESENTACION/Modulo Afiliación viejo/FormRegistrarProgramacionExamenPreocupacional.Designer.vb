<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarProgramacionExamenPreocupacional
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelDatosPersonales = New System.Windows.Forms.Panel()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.dpcFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.rButtonFemenino = New System.Windows.Forms.RadioButton()
        Me.rButtonMasculino = New System.Windows.Forms.RadioButton()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.hintLugarExpedicionNuevoTitular = New System.Windows.Forms.Label()
        Me.cboxLugarExpedicionNuevoTitular = New System.Windows.Forms.ComboBox()
        Me.lblLugarExpedicionNuevoTitular = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtCiNuevoTitular = New System.Windows.Forms.TextBox()
        Me.lblCiNuevoTitular = New System.Windows.Forms.Label()
        Me.hintLugarExpedicionAntiguoTitular = New System.Windows.Forms.Label()
        Me.cboxLugarExpedicionAntiguoTitular = New System.Windows.Forms.ComboBox()
        Me.lblLugarExpedicionAntiguoTitular = New System.Windows.Forms.Label()
        Me.txtCiAntiguoTitular = New System.Windows.Forms.TextBox()
        Me.lblCiAntiguoTitular = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.chNuevaEmpresa = New System.Windows.Forms.CheckBox()
        Me.hintEmpresa = New System.Windows.Forms.Label()
        Me.btnBuscarEmpresa = New System.Windows.Forms.Button()
        Me.lblBuscarEmpresa = New System.Windows.Forms.Label()
        Me.txtBuscarEmpresa = New System.Windows.Forms.TextBox()
        Me.cboxEmpresa = New System.Windows.Forms.ComboBox()
        Me.chNuevoTitular = New System.Windows.Forms.CheckBox()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.lblTitular = New System.Windows.Forms.Label()
        Me.hintTitulares = New System.Windows.Forms.Label()
        Me.btnBuscarPorMatricula = New System.Windows.Forms.Button()
        Me.lblBuscarMatricula = New System.Windows.Forms.Label()
        Me.txtBuscarMatricula = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cboxTitulares = New System.Windows.Forms.ComboBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.lblApellidoMaterno = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblApellidoPaterno = New System.Windows.Forms.Label()
        Me.panelDatosAvisoBaja = New System.Windows.Forms.Panel()
        Me.txtNroComprobantePago = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chTitularEnProvincia = New System.Windows.Forms.CheckBox()
        Me.lblFechaRayosX = New System.Windows.Forms.Label()
        Me.dpcFechaRayosX = New System.Windows.Forms.DateTimePicker()
        Me.txtFichasRestantes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dpcMedicoLaboral = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dpcFechaLaboratorio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelDatosPersonales.SuspendLayout()
        Me.panelDatosAvisoBaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(40, 25)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1607, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(586, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR EXAMEN PRE-OCUPACIONAL"
        '
        'panelDatosPersonales
        '
        Me.panelDatosPersonales.BackColor = System.Drawing.Color.White
        Me.panelDatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosPersonales.Controls.Add(Me.lblFechaNacimiento)
        Me.panelDatosPersonales.Controls.Add(Me.dpcFechaNacimiento)
        Me.panelDatosPersonales.Controls.Add(Me.rButtonFemenino)
        Me.panelDatosPersonales.Controls.Add(Me.rButtonMasculino)
        Me.panelDatosPersonales.Controls.Add(Me.lblSexo)
        Me.panelDatosPersonales.Controls.Add(Me.hintLugarExpedicionNuevoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.cboxLugarExpedicionNuevoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.lblLugarExpedicionNuevoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.TextBox1)
        Me.panelDatosPersonales.Controls.Add(Me.txtCiNuevoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.lblCiNuevoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.hintLugarExpedicionAntiguoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.cboxLugarExpedicionAntiguoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.lblLugarExpedicionAntiguoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.txtCiAntiguoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.lblCiAntiguoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.txtEmpresa)
        Me.panelDatosPersonales.Controls.Add(Me.lblEmpresa)
        Me.panelDatosPersonales.Controls.Add(Me.txtMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.lblMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.chNuevaEmpresa)
        Me.panelDatosPersonales.Controls.Add(Me.hintEmpresa)
        Me.panelDatosPersonales.Controls.Add(Me.btnBuscarEmpresa)
        Me.panelDatosPersonales.Controls.Add(Me.lblBuscarEmpresa)
        Me.panelDatosPersonales.Controls.Add(Me.txtBuscarEmpresa)
        Me.panelDatosPersonales.Controls.Add(Me.cboxEmpresa)
        Me.panelDatosPersonales.Controls.Add(Me.chNuevoTitular)
        Me.panelDatosPersonales.Controls.Add(Me.txtTitular)
        Me.panelDatosPersonales.Controls.Add(Me.lblTitular)
        Me.panelDatosPersonales.Controls.Add(Me.hintTitulares)
        Me.panelDatosPersonales.Controls.Add(Me.btnBuscarPorMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.lblBuscarMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.txtBuscarMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.lblNombres)
        Me.panelDatosPersonales.Controls.Add(Me.txtNombres)
        Me.panelDatosPersonales.Controls.Add(Me.cboxTitulares)
        Me.panelDatosPersonales.Controls.Add(Me.txtApellidoMaterno)
        Me.panelDatosPersonales.Controls.Add(Me.lblApellidoMaterno)
        Me.panelDatosPersonales.Controls.Add(Me.txtApellidoPaterno)
        Me.panelDatosPersonales.Controls.Add(Me.Label7)
        Me.panelDatosPersonales.Controls.Add(Me.lblApellidoPaterno)
        Me.panelDatosPersonales.Location = New System.Drawing.Point(40, 74)
        Me.panelDatosPersonales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelDatosPersonales.Name = "panelDatosPersonales"
        Me.panelDatosPersonales.Size = New System.Drawing.Size(1553, 328)
        Me.panelDatosPersonales.TabIndex = 1
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(648, 277)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(135, 20)
        Me.lblFechaNacimiento.TabIndex = 0
        Me.lblFechaNacimiento.Text = "Fecha nacimiento"
        '
        'dpcFechaNacimiento
        '
        Me.dpcFechaNacimiento.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaNacimiento.Location = New System.Drawing.Point(808, 277)
        Me.dpcFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dpcFechaNacimiento.Name = "dpcFechaNacimiento"
        Me.dpcFechaNacimiento.Size = New System.Drawing.Size(157, 24)
        Me.dpcFechaNacimiento.TabIndex = 15
        '
        'rButtonFemenino
        '
        Me.rButtonFemenino.AutoSize = True
        Me.rButtonFemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonFemenino.Location = New System.Drawing.Point(809, 250)
        Me.rButtonFemenino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rButtonFemenino.Name = "rButtonFemenino"
        Me.rButtonFemenino.Size = New System.Drawing.Size(95, 22)
        Me.rButtonFemenino.TabIndex = 14
        Me.rButtonFemenino.TabStop = True
        Me.rButtonFemenino.Text = "Femenino"
        Me.rButtonFemenino.UseVisualStyleBackColor = True
        '
        'rButtonMasculino
        '
        Me.rButtonMasculino.AutoSize = True
        Me.rButtonMasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonMasculino.Location = New System.Drawing.Point(809, 226)
        Me.rButtonMasculino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rButtonMasculino.Name = "rButtonMasculino"
        Me.rButtonMasculino.Size = New System.Drawing.Size(97, 22)
        Me.rButtonMasculino.TabIndex = 13
        Me.rButtonMasculino.TabStop = True
        Me.rButtonMasculino.Text = "Masculino"
        Me.rButtonMasculino.UseVisualStyleBackColor = True
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(748, 234)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(45, 20)
        Me.lblSexo.TabIndex = 0
        Me.lblSexo.Text = "Sexo"
        '
        'hintLugarExpedicionNuevoTitular
        '
        Me.hintLugarExpedicionNuevoTitular.AutoSize = True
        Me.hintLugarExpedicionNuevoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintLugarExpedicionNuevoTitular.Location = New System.Drawing.Point(1199, 110)
        Me.hintLugarExpedicionNuevoTitular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintLugarExpedicionNuevoTitular.Name = "hintLugarExpedicionNuevoTitular"
        Me.hintLugarExpedicionNuevoTitular.Size = New System.Drawing.Size(104, 17)
        Me.hintLugarExpedicionNuevoTitular.TabIndex = 0
        Me.hintLugarExpedicionNuevoTitular.Text = "SELECCIONAR"
        '
        'cboxLugarExpedicionNuevoTitular
        '
        Me.cboxLugarExpedicionNuevoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxLugarExpedicionNuevoTitular.FormattingEnabled = True
        Me.cboxLugarExpedicionNuevoTitular.Items.AddRange(New Object() {"SC", "LP", "CO", "BE", "PA", "OR", "PO", "CH", "TA"})
        Me.cboxLugarExpedicionNuevoTitular.Location = New System.Drawing.Point(1193, 105)
        Me.cboxLugarExpedicionNuevoTitular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxLugarExpedicionNuevoTitular.Name = "cboxLugarExpedicionNuevoTitular"
        Me.cboxLugarExpedicionNuevoTitular.Size = New System.Drawing.Size(207, 24)
        Me.cboxLugarExpedicionNuevoTitular.TabIndex = 17
        '
        'lblLugarExpedicionNuevoTitular
        '
        Me.lblLugarExpedicionNuevoTitular.AutoSize = True
        Me.lblLugarExpedicionNuevoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugarExpedicionNuevoTitular.Location = New System.Drawing.Point(1043, 105)
        Me.lblLugarExpedicionNuevoTitular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLugarExpedicionNuevoTitular.Name = "lblLugarExpedicionNuevoTitular"
        Me.lblLugarExpedicionNuevoTitular.Size = New System.Drawing.Size(129, 20)
        Me.lblLugarExpedicionNuevoTitular.TabIndex = 0
        Me.lblLugarExpedicionNuevoTitular.Text = "Lugar expedición"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1216, 95)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 24)
        Me.TextBox1.TabIndex = 16
        '
        'txtCiNuevoTitular
        '
        Me.txtCiNuevoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiNuevoTitular.Location = New System.Drawing.Point(1193, 62)
        Me.txtCiNuevoTitular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCiNuevoTitular.Name = "txtCiNuevoTitular"
        Me.txtCiNuevoTitular.Size = New System.Drawing.Size(207, 24)
        Me.txtCiNuevoTitular.TabIndex = 16
        '
        'lblCiNuevoTitular
        '
        Me.lblCiNuevoTitular.AutoSize = True
        Me.lblCiNuevoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiNuevoTitular.Location = New System.Drawing.Point(1043, 62)
        Me.lblCiNuevoTitular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCiNuevoTitular.Name = "lblCiNuevoTitular"
        Me.lblCiNuevoTitular.Size = New System.Drawing.Size(137, 20)
        Me.lblCiNuevoTitular.TabIndex = 0
        Me.lblCiNuevoTitular.Text = "Carnet Indentidad"
        '
        'hintLugarExpedicionAntiguoTitular
        '
        Me.hintLugarExpedicionAntiguoTitular.AutoSize = True
        Me.hintLugarExpedicionAntiguoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintLugarExpedicionAntiguoTitular.Location = New System.Drawing.Point(220, 282)
        Me.hintLugarExpedicionAntiguoTitular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintLugarExpedicionAntiguoTitular.Name = "hintLugarExpedicionAntiguoTitular"
        Me.hintLugarExpedicionAntiguoTitular.Size = New System.Drawing.Size(104, 17)
        Me.hintLugarExpedicionAntiguoTitular.TabIndex = 0
        Me.hintLugarExpedicionAntiguoTitular.Text = "SELECCIONAR"
        '
        'cboxLugarExpedicionAntiguoTitular
        '
        Me.cboxLugarExpedicionAntiguoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxLugarExpedicionAntiguoTitular.FormattingEnabled = True
        Me.cboxLugarExpedicionAntiguoTitular.Items.AddRange(New Object() {"SC", "LP", "CO", "BE", "PA", "OR", "PO", "CH", "TA"})
        Me.cboxLugarExpedicionAntiguoTitular.Location = New System.Drawing.Point(215, 277)
        Me.cboxLugarExpedicionAntiguoTitular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxLugarExpedicionAntiguoTitular.Name = "cboxLugarExpedicionAntiguoTitular"
        Me.cboxLugarExpedicionAntiguoTitular.Size = New System.Drawing.Size(179, 24)
        Me.cboxLugarExpedicionAntiguoTitular.TabIndex = 7
        '
        'lblLugarExpedicionAntiguoTitular
        '
        Me.lblLugarExpedicionAntiguoTitular.AutoSize = True
        Me.lblLugarExpedicionAntiguoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugarExpedicionAntiguoTitular.Location = New System.Drawing.Point(55, 277)
        Me.lblLugarExpedicionAntiguoTitular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLugarExpedicionAntiguoTitular.Name = "lblLugarExpedicionAntiguoTitular"
        Me.lblLugarExpedicionAntiguoTitular.Size = New System.Drawing.Size(129, 20)
        Me.lblLugarExpedicionAntiguoTitular.TabIndex = 0
        Me.lblLugarExpedicionAntiguoTitular.Text = "Lugar expedición"
        '
        'txtCiAntiguoTitular
        '
        Me.txtCiAntiguoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiAntiguoTitular.Location = New System.Drawing.Point(215, 234)
        Me.txtCiAntiguoTitular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCiAntiguoTitular.Name = "txtCiAntiguoTitular"
        Me.txtCiAntiguoTitular.Size = New System.Drawing.Size(179, 24)
        Me.txtCiAntiguoTitular.TabIndex = 6
        '
        'lblCiAntiguoTitular
        '
        Me.lblCiAntiguoTitular.AutoSize = True
        Me.lblCiAntiguoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiAntiguoTitular.Location = New System.Drawing.Point(56, 234)
        Me.lblCiAntiguoTitular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCiAntiguoTitular.Name = "lblCiAntiguoTitular"
        Me.lblCiAntiguoTitular.Size = New System.Drawing.Size(137, 20)
        Me.lblCiAntiguoTitular.TabIndex = 0
        Me.lblCiAntiguoTitular.Text = "Carnet Indentidad"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(215, 191)
        Me.txtEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(361, 24)
        Me.txtEmpresa.TabIndex = 5
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(53, 191)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(133, 20)
        Me.lblEmpresa.TabIndex = 0
        Me.lblEmpresa.Text = "Último empleador"
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Location = New System.Drawing.Point(808, 193)
        Me.txtMatricula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(157, 24)
        Me.txtMatricula.TabIndex = 12
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(717, 193)
        Me.lblMatricula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(73, 20)
        Me.lblMatricula.TabIndex = 0
        Me.lblMatricula.Text = "Matrícula"
        '
        'chNuevaEmpresa
        '
        Me.chNuevaEmpresa.AutoSize = True
        Me.chNuevaEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chNuevaEmpresa.Location = New System.Drawing.Point(1043, 148)
        Me.chNuevaEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chNuevaEmpresa.Name = "chNuevaEmpresa"
        Me.chNuevaEmpresa.Size = New System.Drawing.Size(134, 22)
        Me.chNuevaEmpresa.TabIndex = 18
        Me.chNuevaEmpresa.Text = "Nueva empresa"
        Me.chNuevaEmpresa.UseVisualStyleBackColor = True
        '
        'hintEmpresa
        '
        Me.hintEmpresa.AutoSize = True
        Me.hintEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintEmpresa.Location = New System.Drawing.Point(1049, 240)
        Me.hintEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintEmpresa.Name = "hintEmpresa"
        Me.hintEmpresa.Size = New System.Drawing.Size(104, 17)
        Me.hintEmpresa.TabIndex = 0
        Me.hintEmpresa.Text = "SELECCIONAR"
        '
        'btnBuscarEmpresa
        '
        Me.btnBuscarEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpresa.Location = New System.Drawing.Point(1409, 193)
        Me.btnBuscarEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscarEmpresa.Name = "btnBuscarEmpresa"
        Me.btnBuscarEmpresa.Size = New System.Drawing.Size(89, 28)
        Me.btnBuscarEmpresa.TabIndex = 20
        Me.btnBuscarEmpresa.Text = "Buscar"
        Me.btnBuscarEmpresa.UseVisualStyleBackColor = True
        '
        'lblBuscarEmpresa
        '
        Me.lblBuscarEmpresa.AutoSize = True
        Me.lblBuscarEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarEmpresa.Location = New System.Drawing.Point(1043, 193)
        Me.lblBuscarEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscarEmpresa.Name = "lblBuscarEmpresa"
        Me.lblBuscarEmpresa.Size = New System.Drawing.Size(73, 20)
        Me.lblBuscarEmpresa.TabIndex = 0
        Me.lblBuscarEmpresa.Text = "Empresa"
        '
        'txtBuscarEmpresa
        '
        Me.txtBuscarEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarEmpresa.Location = New System.Drawing.Point(1136, 193)
        Me.txtBuscarEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscarEmpresa.Name = "txtBuscarEmpresa"
        Me.txtBuscarEmpresa.Size = New System.Drawing.Size(264, 24)
        Me.txtBuscarEmpresa.TabIndex = 19
        '
        'cboxEmpresa
        '
        Me.cboxEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxEmpresa.FormattingEnabled = True
        Me.cboxEmpresa.Location = New System.Drawing.Point(1043, 234)
        Me.cboxEmpresa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxEmpresa.Name = "cboxEmpresa"
        Me.cboxEmpresa.Size = New System.Drawing.Size(447, 26)
        Me.cboxEmpresa.TabIndex = 21
        '
        'chNuevoTitular
        '
        Me.chNuevoTitular.AutoSize = True
        Me.chNuevoTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chNuevoTitular.Location = New System.Drawing.Point(657, 20)
        Me.chNuevoTitular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chNuevoTitular.Name = "chNuevoTitular"
        Me.chNuevoTitular.Size = New System.Drawing.Size(112, 22)
        Me.chNuevoTitular.TabIndex = 8
        Me.chNuevoTitular.Text = "Nuevo titular"
        Me.chNuevoTitular.UseVisualStyleBackColor = True
        '
        'txtTitular
        '
        Me.txtTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitular.Location = New System.Drawing.Point(215, 148)
        Me.txtTitular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(361, 24)
        Me.txtTitular.TabIndex = 4
        '
        'lblTitular
        '
        Me.lblTitular.AutoSize = True
        Me.lblTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitular.Location = New System.Drawing.Point(107, 148)
        Me.lblTitular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitular.Name = "lblTitular"
        Me.lblTitular.Size = New System.Drawing.Size(87, 20)
        Me.lblTitular.TabIndex = 0
        Me.lblTitular.Text = "Asegurado"
        '
        'hintTitulares
        '
        Me.hintTitulares.AutoSize = True
        Me.hintTitulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTitulares.Location = New System.Drawing.Point(219, 110)
        Me.hintTitulares.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintTitulares.Name = "hintTitulares"
        Me.hintTitulares.Size = New System.Drawing.Size(104, 17)
        Me.hintTitulares.TabIndex = 0
        Me.hintTitulares.Text = "SELECCIONAR"
        '
        'btnBuscarPorMatricula
        '
        Me.btnBuscarPorMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPorMatricula.Location = New System.Drawing.Point(488, 62)
        Me.btnBuscarPorMatricula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscarPorMatricula.Name = "btnBuscarPorMatricula"
        Me.btnBuscarPorMatricula.Size = New System.Drawing.Size(89, 28)
        Me.btnBuscarPorMatricula.TabIndex = 2
        Me.btnBuscarPorMatricula.Text = "Buscar"
        Me.btnBuscarPorMatricula.UseVisualStyleBackColor = True
        '
        'lblBuscarMatricula
        '
        Me.lblBuscarMatricula.AutoSize = True
        Me.lblBuscarMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarMatricula.Location = New System.Drawing.Point(124, 62)
        Me.lblBuscarMatricula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscarMatricula.Name = "lblBuscarMatricula"
        Me.lblBuscarMatricula.Size = New System.Drawing.Size(73, 20)
        Me.lblBuscarMatricula.TabIndex = 0
        Me.lblBuscarMatricula.Text = "Matricula"
        '
        'txtBuscarMatricula
        '
        Me.txtBuscarMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarMatricula.Location = New System.Drawing.Point(215, 62)
        Me.txtBuscarMatricula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscarMatricula.Name = "txtBuscarMatricula"
        Me.txtBuscarMatricula.Size = New System.Drawing.Size(264, 24)
        Me.txtBuscarMatricula.TabIndex = 1
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(715, 148)
        Me.lblNombres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(73, 20)
        Me.lblNombres.TabIndex = 0
        Me.lblNombres.Text = "Nombres"
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(808, 148)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(157, 24)
        Me.txtNombres.TabIndex = 11
        '
        'cboxTitulares
        '
        Me.cboxTitulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTitulares.FormattingEnabled = True
        Me.cboxTitulares.Location = New System.Drawing.Point(215, 105)
        Me.cboxTitulares.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboxTitulares.Name = "cboxTitulares"
        Me.cboxTitulares.Size = New System.Drawing.Size(361, 24)
        Me.cboxTitulares.TabIndex = 3
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(808, 105)
        Me.txtApellidoMaterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(157, 24)
        Me.txtApellidoMaterno.TabIndex = 10
        '
        'lblApellidoMaterno
        '
        Me.lblApellidoMaterno.AutoSize = True
        Me.lblApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoMaterno.Location = New System.Drawing.Point(653, 105)
        Me.lblApellidoMaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidoMaterno.Name = "lblApellidoMaterno"
        Me.lblApellidoMaterno.Size = New System.Drawing.Size(128, 20)
        Me.lblApellidoMaterno.TabIndex = 0
        Me.lblApellidoMaterno.Text = "Apellido materno"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(808, 62)
        Me.txtApellidoPaterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(157, 24)
        Me.txtApellidoPaterno.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(20, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1.- Datos personales"
        '
        'lblApellidoPaterno
        '
        Me.lblApellidoPaterno.AutoSize = True
        Me.lblApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoPaterno.Location = New System.Drawing.Point(657, 62)
        Me.lblApellidoPaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidoPaterno.Name = "lblApellidoPaterno"
        Me.lblApellidoPaterno.Size = New System.Drawing.Size(124, 20)
        Me.lblApellidoPaterno.TabIndex = 0
        Me.lblApellidoPaterno.Text = "Apellido paterno"
        '
        'panelDatosAvisoBaja
        '
        Me.panelDatosAvisoBaja.BackColor = System.Drawing.Color.White
        Me.panelDatosAvisoBaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosAvisoBaja.Controls.Add(Me.txtNroComprobantePago)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label2)
        Me.panelDatosAvisoBaja.Controls.Add(Me.chTitularEnProvincia)
        Me.panelDatosAvisoBaja.Controls.Add(Me.lblFechaRayosX)
        Me.panelDatosAvisoBaja.Controls.Add(Me.dpcFechaRayosX)
        Me.panelDatosAvisoBaja.Controls.Add(Me.txtFichasRestantes)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label8)
        Me.panelDatosAvisoBaja.Controls.Add(Me.dpcMedicoLaboral)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label9)
        Me.panelDatosAvisoBaja.Controls.Add(Me.dpcFechaLaboratorio)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label5)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label11)
        Me.panelDatosAvisoBaja.Location = New System.Drawing.Point(40, 437)
        Me.panelDatosAvisoBaja.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelDatosAvisoBaja.Name = "panelDatosAvisoBaja"
        Me.panelDatosAvisoBaja.Size = New System.Drawing.Size(950, 189)
        Me.panelDatosAvisoBaja.TabIndex = 2
        '
        'txtNroComprobantePago
        '
        Me.txtNroComprobantePago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroComprobantePago.Location = New System.Drawing.Point(719, 140)
        Me.txtNroComprobantePago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNroComprobantePago.Name = "txtNroComprobantePago"
        Me.txtNroComprobantePago.Size = New System.Drawing.Size(195, 24)
        Me.txtNroComprobantePago.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(484, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nro. comprobante de pago"
        '
        'chTitularEnProvincia
        '
        Me.chTitularEnProvincia.AutoSize = True
        Me.chTitularEnProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chTitularEnProvincia.Location = New System.Drawing.Point(252, 20)
        Me.chTitularEnProvincia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chTitularEnProvincia.Name = "chTitularEnProvincia"
        Me.chTitularEnProvincia.Size = New System.Drawing.Size(184, 22)
        Me.chTitularEnProvincia.TabIndex = 1
        Me.chTitularEnProvincia.Text = "Asegurado en provincia"
        Me.chTitularEnProvincia.UseVisualStyleBackColor = True
        '
        'lblFechaRayosX
        '
        Me.lblFechaRayosX.AutoSize = True
        Me.lblFechaRayosX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRayosX.Location = New System.Drawing.Point(73, 102)
        Me.lblFechaRayosX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaRayosX.Name = "lblFechaRayosX"
        Me.lblFechaRayosX.Size = New System.Drawing.Size(118, 20)
        Me.lblFechaRayosX.TabIndex = 0
        Me.lblFechaRayosX.Text = "Fecha Rayos X"
        '
        'dpcFechaRayosX
        '
        Me.dpcFechaRayosX.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaRayosX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaRayosX.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaRayosX.Location = New System.Drawing.Point(215, 98)
        Me.dpcFechaRayosX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dpcFechaRayosX.Name = "dpcFechaRayosX"
        Me.dpcFechaRayosX.Size = New System.Drawing.Size(199, 24)
        Me.dpcFechaRayosX.TabIndex = 3
        '
        'txtFichasRestantes
        '
        Me.txtFichasRestantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFichasRestantes.Location = New System.Drawing.Point(719, 98)
        Me.txtFichasRestantes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFichasRestantes.Name = "txtFichasRestantes"
        Me.txtFichasRestantes.Size = New System.Drawing.Size(195, 24)
        Me.txtFichasRestantes.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(539, 105)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nro. fichas restantes"
        '
        'dpcMedicoLaboral
        '
        Me.dpcMedicoLaboral.CustomFormat = "dd--MM--yyyy"
        Me.dpcMedicoLaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcMedicoLaboral.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcMedicoLaboral.Location = New System.Drawing.Point(719, 62)
        Me.dpcMedicoLaboral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dpcMedicoLaboral.Name = "dpcMedicoLaboral"
        Me.dpcMedicoLaboral.Size = New System.Drawing.Size(195, 24)
        Me.dpcMedicoLaboral.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(525, 62)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fecha medico laboral"
        '
        'dpcFechaLaboratorio
        '
        Me.dpcFechaLaboratorio.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaLaboratorio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaLaboratorio.Location = New System.Drawing.Point(215, 62)
        Me.dpcFechaLaboratorio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dpcFechaLaboratorio.Name = "dpcFechaLaboratorio"
        Me.dpcFechaLaboratorio.Size = New System.Drawing.Size(199, 24)
        Me.dpcFechaLaboratorio.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha laboratorio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(20, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "2.- Datos del examen"
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(1393, 628)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(253, 34)
        Me.btnEnviar.TabIndex = 4
        Me.btnEnviar.Text = "Registrar programación"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(1297, 628)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 34)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'FormRegistrarProgramacionExamenPreocupacional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 690)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.panelDatosAvisoBaja)
        Me.Controls.Add(Me.panelDatosPersonales)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormRegistrarProgramacionExamenPreocupacional"
        Me.Text = "Registrar Examen Preocupacional"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelDatosPersonales.ResumeLayout(False)
        Me.panelDatosPersonales.PerformLayout()
        Me.panelDatosAvisoBaja.ResumeLayout(False)
        Me.panelDatosAvisoBaja.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelDatosPersonales As System.Windows.Forms.Panel
    Friend WithEvents hintTitulares As System.Windows.Forms.Label
    Friend WithEvents btnBuscarPorMatricula As System.Windows.Forms.Button
    Friend WithEvents lblBuscarMatricula As System.Windows.Forms.Label
    Friend WithEvents txtBuscarMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents cboxTitulares As System.Windows.Forms.ComboBox
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidoMaterno As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblApellidoPaterno As System.Windows.Forms.Label
    Friend WithEvents panelDatosAvisoBaja As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dpcFechaLaboratorio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dpcMedicoLaboral As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFichasRestantes As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTitular As System.Windows.Forms.TextBox
    Friend WithEvents lblTitular As System.Windows.Forms.Label
    Friend WithEvents chNuevoTitular As System.Windows.Forms.CheckBox
    Friend WithEvents hintEmpresa As System.Windows.Forms.Label
    Friend WithEvents btnBuscarEmpresa As System.Windows.Forms.Button
    Friend WithEvents lblBuscarEmpresa As System.Windows.Forms.Label
    Friend WithEvents txtBuscarEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents cboxEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents chNuevaEmpresa As System.Windows.Forms.CheckBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblFechaRayosX As System.Windows.Forms.Label
    Friend WithEvents dpcFechaRayosX As System.Windows.Forms.DateTimePicker
    Friend WithEvents chTitularEnProvincia As System.Windows.Forms.CheckBox
    Friend WithEvents lblCiAntiguoTitular As System.Windows.Forms.Label
    Friend WithEvents lblLugarExpedicionAntiguoTitular As System.Windows.Forms.Label
    Friend WithEvents txtCiAntiguoTitular As System.Windows.Forms.TextBox
    Friend WithEvents cboxLugarExpedicionAntiguoTitular As System.Windows.Forms.ComboBox
    Friend WithEvents hintLugarExpedicionAntiguoTitular As System.Windows.Forms.Label
    Friend WithEvents hintLugarExpedicionNuevoTitular As System.Windows.Forms.Label
    Friend WithEvents cboxLugarExpedicionNuevoTitular As System.Windows.Forms.ComboBox
    Friend WithEvents lblLugarExpedicionNuevoTitular As System.Windows.Forms.Label
    Friend WithEvents txtCiNuevoTitular As System.Windows.Forms.TextBox
    Friend WithEvents lblCiNuevoTitular As System.Windows.Forms.Label
    Friend WithEvents txtNroComprobantePago As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents dpcFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents rButtonFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rButtonMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As TextBox
End Class
