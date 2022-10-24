<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarBaja
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
        Me.hintTitulares = New System.Windows.Forms.Label()
        Me.btnBuscarMatricula = New System.Windows.Forms.Button()
        Me.txtUltimoEmpleador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.fmeLblBuscar = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cboxTitulares = New System.Windows.Forms.ComboBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelDatosAvisoBaja = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dpcFechaPresentacion = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.numSalario = New System.Windows.Forms.NumericUpDown()
        Me.hintMotivo = New System.Windows.Forms.Label()
        Me.cboxMotivo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.hintCargo = New System.Windows.Forms.Label()
        Me.cboxCargo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dpcFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelDatosPersonales.SuspendLayout()
        Me.panelDatosAvisoBaja.SuspendLayout()
        CType(Me.numSalario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1205, 22)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(526, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR BAJA"
        '
        'panelDatosPersonales
        '
        Me.panelDatosPersonales.BackColor = System.Drawing.Color.White
        Me.panelDatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosPersonales.Controls.Add(Me.hintTitulares)
        Me.panelDatosPersonales.Controls.Add(Me.btnBuscarMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.txtUltimoEmpleador)
        Me.panelDatosPersonales.Controls.Add(Me.Label4)
        Me.panelDatosPersonales.Controls.Add(Me.Label2)
        Me.panelDatosPersonales.Controls.Add(Me.txtMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.fmeLblBuscar)
        Me.panelDatosPersonales.Controls.Add(Me.txtNombres)
        Me.panelDatosPersonales.Controls.Add(Me.cboxTitulares)
        Me.panelDatosPersonales.Controls.Add(Me.txtApellidoMaterno)
        Me.panelDatosPersonales.Controls.Add(Me.lblContraseña)
        Me.panelDatosPersonales.Controls.Add(Me.txtApellidoPaterno)
        Me.panelDatosPersonales.Controls.Add(Me.Label7)
        Me.panelDatosPersonales.Controls.Add(Me.Label3)
        Me.panelDatosPersonales.Location = New System.Drawing.Point(30, 60)
        Me.panelDatosPersonales.Name = "panelDatosPersonales"
        Me.panelDatosPersonales.Size = New System.Drawing.Size(962, 160)
        Me.panelDatosPersonales.TabIndex = 2
        '
        'hintTitulares
        '
        Me.hintTitulares.AutoSize = True
        Me.hintTitulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTitulares.Location = New System.Drawing.Point(24, 90)
        Me.hintTitulares.Name = "hintTitulares"
        Me.hintTitulares.Size = New System.Drawing.Size(153, 13)
        Me.hintTitulares.TabIndex = 0
        Me.hintTitulares.Text = "SELECCIONAR ASEGURADO"
        '
        'btnBuscarMatricula
        '
        Me.btnBuscarMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarMatricula.Location = New System.Drawing.Point(211, 50)
        Me.btnBuscarMatricula.Name = "btnBuscarMatricula"
        Me.btnBuscarMatricula.Size = New System.Drawing.Size(67, 23)
        Me.btnBuscarMatricula.TabIndex = 2
        Me.btnBuscarMatricula.Text = "Buscar"
        Me.btnBuscarMatricula.UseVisualStyleBackColor = True
        '
        'txtUltimoEmpleador
        '
        Me.txtUltimoEmpleador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimoEmpleador.Location = New System.Drawing.Point(692, 50)
        Me.txtUltimoEmpleador.Name = "txtUltimoEmpleador"
        Me.txtUltimoEmpleador.Size = New System.Drawing.Size(243, 21)
        Me.txtUltimoEmpleador.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(571, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Último empleador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Matricula"
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Location = New System.Drawing.Point(83, 50)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(122, 21)
        Me.txtMatricula.TabIndex = 1
        '
        'fmeLblBuscar
        '
        Me.fmeLblBuscar.AutoSize = True
        Me.fmeLblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fmeLblBuscar.Location = New System.Drawing.Point(357, 120)
        Me.fmeLblBuscar.Name = "fmeLblBuscar"
        Me.fmeLblBuscar.Size = New System.Drawing.Size(64, 16)
        Me.fmeLblBuscar.TabIndex = 0
        Me.fmeLblBuscar.Text = "Nombres"
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(427, 120)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(119, 21)
        Me.txtNombres.TabIndex = 6
        '
        'cboxTitulares
        '
        Me.cboxTitulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTitulares.FormattingEnabled = True
        Me.cboxTitulares.Location = New System.Drawing.Point(19, 85)
        Me.cboxTitulares.Name = "cboxTitulares"
        Me.cboxTitulares.Size = New System.Drawing.Size(259, 23)
        Me.cboxTitulares.TabIndex = 3
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(427, 85)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(119, 21)
        Me.txtApellidoMaterno.TabIndex = 5
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(311, 85)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(110, 16)
        Me.lblContraseña.TabIndex = 0
        Me.lblContraseña.Text = "Apellido materno"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(427, 50)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(119, 21)
        Me.txtApellidoPaterno.TabIndex = 4
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
        'panelDatosAvisoBaja
        '
        Me.panelDatosAvisoBaja.BackColor = System.Drawing.Color.White
        Me.panelDatosAvisoBaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label8)
        Me.panelDatosAvisoBaja.Controls.Add(Me.dpcFechaPresentacion)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label13)
        Me.panelDatosAvisoBaja.Controls.Add(Me.numSalario)
        Me.panelDatosAvisoBaja.Controls.Add(Me.hintMotivo)
        Me.panelDatosAvisoBaja.Controls.Add(Me.cboxMotivo)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label10)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label9)
        Me.panelDatosAvisoBaja.Controls.Add(Me.hintCargo)
        Me.panelDatosAvisoBaja.Controls.Add(Me.cboxCargo)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label6)
        Me.panelDatosAvisoBaja.Controls.Add(Me.dpcFechaBaja)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label5)
        Me.panelDatosAvisoBaja.Controls.Add(Me.Label11)
        Me.panelDatosAvisoBaja.Location = New System.Drawing.Point(30, 245)
        Me.panelDatosAvisoBaja.Name = "panelDatosAvisoBaja"
        Me.panelDatosAvisoBaja.Size = New System.Drawing.Size(724, 163)
        Me.panelDatosAvisoBaja.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(284, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Bs."
        '
        'dpcFechaPresentacion
        '
        Me.dpcFechaPresentacion.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaPresentacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaPresentacion.Location = New System.Drawing.Point(509, 85)
        Me.dpcFechaPresentacion.Name = "dpcFechaPresentacion"
        Me.dpcFechaPresentacion.Size = New System.Drawing.Size(173, 21)
        Me.dpcFechaPresentacion.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(357, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Fecha de presentación"
        '
        'numSalario
        '
        Me.numSalario.DecimalPlaces = 2
        Me.numSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSalario.Location = New System.Drawing.Point(116, 120)
        Me.numSalario.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        Me.numSalario.Name = "numSalario"
        Me.numSalario.Size = New System.Drawing.Size(162, 21)
        Me.numSalario.TabIndex = 3
        '
        'hintMotivo
        '
        Me.hintMotivo.AutoSize = True
        Me.hintMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintMotivo.Location = New System.Drawing.Point(513, 54)
        Me.hintMotivo.Name = "hintMotivo"
        Me.hintMotivo.Size = New System.Drawing.Size(82, 13)
        Me.hintMotivo.TabIndex = 69
        Me.hintMotivo.Text = "SELECCIONAR"
        '
        'cboxMotivo
        '
        Me.cboxMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMotivo.FormattingEnabled = True
        Me.cboxMotivo.Location = New System.Drawing.Point(509, 49)
        Me.cboxMotivo.Name = "cboxMotivo"
        Me.cboxMotivo.Size = New System.Drawing.Size(173, 23)
        Me.cboxMotivo.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(455, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Motivo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Salario"
        '
        'hintCargo
        '
        Me.hintCargo.AutoSize = True
        Me.hintCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCargo.Location = New System.Drawing.Point(120, 90)
        Me.hintCargo.Name = "hintCargo"
        Me.hintCargo.Size = New System.Drawing.Size(82, 13)
        Me.hintCargo.TabIndex = 64
        Me.hintCargo.Text = "SELECCIONAR"
        '
        'cboxCargo
        '
        Me.cboxCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxCargo.FormattingEnabled = True
        Me.cboxCargo.Location = New System.Drawing.Point(116, 85)
        Me.cboxCargo.Name = "cboxCargo"
        Me.cboxCargo.Size = New System.Drawing.Size(195, 23)
        Me.cboxCargo.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cargo"
        '
        'dpcFechaBaja
        '
        Me.dpcFechaBaja.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaBaja.Location = New System.Drawing.Point(116, 50)
        Me.dpcFechaBaja.Name = "dpcFechaBaja"
        Me.dpcFechaBaja.Size = New System.Drawing.Size(195, 21)
        Me.dpcFechaBaja.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha de baja"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(15, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "2.- Datos de aviso de baja"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(983, 507)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 28)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(1066, 507)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(169, 28)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Registrar baja"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'FormRegistrarBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.panelDatosAvisoBaja)
        Me.Controls.Add(Me.panelDatosPersonales)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarBaja"
        Me.Text = "Registrar baja"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelDatosPersonales.ResumeLayout(False)
        Me.panelDatosPersonales.PerformLayout()
        Me.panelDatosAvisoBaja.ResumeLayout(False)
        Me.panelDatosAvisoBaja.PerformLayout()
        CType(Me.numSalario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelDatosPersonales As System.Windows.Forms.Panel
    Friend WithEvents fmeLblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents cboxTitulares As System.Windows.Forms.ComboBox
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarMatricula As System.Windows.Forms.Button
    Friend WithEvents txtUltimoEmpleador As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hintTitulares As System.Windows.Forms.Label
    Friend WithEvents panelDatosAvisoBaja As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dpcFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents hintMotivo As System.Windows.Forms.Label
    Friend WithEvents cboxMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents hintCargo As System.Windows.Forms.Label
    Friend WithEvents cboxCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numSalario As System.Windows.Forms.NumericUpDown
    Friend WithEvents dpcFechaPresentacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
