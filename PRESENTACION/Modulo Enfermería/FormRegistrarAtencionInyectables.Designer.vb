<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarAtencionInyectables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistrarAtencionInyectables))
        Me.rbuttonNegativoPps = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbuttonPositivoPps = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVia = New System.Windows.Forms.TextBox()
        Me.txtNombreMedicamento = New System.Windows.Forms.TextBox()
        Me.txtActividadRealizada = New System.Windows.Forms.TextBox()
        Me.txtCodigoMedicamento = New System.Windows.Forms.TextBox()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.btnGuardarAtencion = New System.Windows.Forms.Button()
        Me.datePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbuttonNoReacionAdversa = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbuttonSiReacionAdversa = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMedico = New System.Windows.Forms.TextBox()
        Me.cmboxMedico = New System.Windows.Forms.ComboBox()
        Me.panelMedicamentoSuministrado = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtAsegurado = New System.Windows.Forms.TextBox()
        Me.cmboxAsegurado = New System.Windows.Forms.ComboBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Restroceder = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.panelMedicamentoSuministrado.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbuttonNegativoPps
        '
        Me.rbuttonNegativoPps.AutoSize = True
        Me.rbuttonNegativoPps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonNegativoPps.Location = New System.Drawing.Point(59, 54)
        Me.rbuttonNegativoPps.Margin = New System.Windows.Forms.Padding(4)
        Me.rbuttonNegativoPps.Name = "rbuttonNegativoPps"
        Me.rbuttonNegativoPps.Size = New System.Drawing.Size(44, 22)
        Me.rbuttonNegativoPps.TabIndex = 0
        Me.rbuttonNegativoPps.TabStop = True
        Me.rbuttonNegativoPps.Text = "(-)"
        Me.rbuttonNegativoPps.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbuttonNegativoPps)
        Me.GroupBox2.Controls.Add(Me.rbuttonPositivoPps)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(924, 51)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(125, 85)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PPS"
        '
        'rbuttonPositivoPps
        '
        Me.rbuttonPositivoPps.AutoSize = True
        Me.rbuttonPositivoPps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonPositivoPps.Location = New System.Drawing.Point(59, 23)
        Me.rbuttonPositivoPps.Margin = New System.Windows.Forms.Padding(4)
        Me.rbuttonPositivoPps.Name = "rbuttonPositivoPps"
        Me.rbuttonPositivoPps.Size = New System.Drawing.Size(48, 22)
        Me.rbuttonPositivoPps.TabIndex = 0
        Me.rbuttonPositivoPps.TabStop = True
        Me.rbuttonPositivoPps.Text = "(+)"
        Me.rbuttonPositivoPps.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(556, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Via"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(321, 51)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Dosis"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(321, 112)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Actividad Realizada"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(96, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Código de Medicamento"
        '
        'txtVia
        '
        Me.txtVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVia.Location = New System.Drawing.Point(560, 75)
        Me.txtVia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVia.Name = "txtVia"
        Me.txtVia.Size = New System.Drawing.Size(116, 24)
        Me.txtVia.TabIndex = 1
        '
        'txtNombreMedicamento
        '
        Me.txtNombreMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreMedicamento.Location = New System.Drawing.Point(100, 141)
        Me.txtNombreMedicamento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreMedicamento.Name = "txtNombreMedicamento"
        Me.txtNombreMedicamento.Size = New System.Drawing.Size(207, 24)
        Me.txtNombreMedicamento.TabIndex = 1
        '
        'txtActividadRealizada
        '
        Me.txtActividadRealizada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActividadRealizada.Location = New System.Drawing.Point(325, 141)
        Me.txtActividadRealizada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtActividadRealizada.Name = "txtActividadRealizada"
        Me.txtActividadRealizada.Size = New System.Drawing.Size(223, 24)
        Me.txtActividadRealizada.TabIndex = 1
        '
        'txtCodigoMedicamento
        '
        Me.txtCodigoMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoMedicamento.Location = New System.Drawing.Point(100, 75)
        Me.txtCodigoMedicamento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoMedicamento.Name = "txtCodigoMedicamento"
        Me.txtCodigoMedicamento.Size = New System.Drawing.Size(203, 24)
        Me.txtCodigoMedicamento.TabIndex = 1
        '
        'txtDosis
        '
        Me.txtDosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDosis.Location = New System.Drawing.Point(325, 75)
        Me.txtDosis.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(223, 24)
        Me.txtDosis.TabIndex = 1
        '
        'btnGuardarAtencion
        '
        Me.btnGuardarAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarAtencion.Location = New System.Drawing.Point(967, 571)
        Me.btnGuardarAtencion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarAtencion.Name = "btnGuardarAtencion"
        Me.btnGuardarAtencion.Size = New System.Drawing.Size(181, 32)
        Me.btnGuardarAtencion.TabIndex = 21
        Me.btnGuardarAtencion.Text = "Guardar Atención "
        Me.btnGuardarAtencion.UseVisualStyleBackColor = True
        '
        'datePickerFecha
        '
        Me.datePickerFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePickerFecha.Location = New System.Drawing.Point(21, 113)
        Me.datePickerFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.datePickerFecha.Name = "datePickerFecha"
        Me.datePickerFecha.Size = New System.Drawing.Size(305, 24)
        Me.datePickerFecha.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Médico"
        '
        'rbuttonNoReacionAdversa
        '
        Me.rbuttonNoReacionAdversa.AutoSize = True
        Me.rbuttonNoReacionAdversa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonNoReacionAdversa.Location = New System.Drawing.Point(93, 54)
        Me.rbuttonNoReacionAdversa.Margin = New System.Windows.Forms.Padding(4)
        Me.rbuttonNoReacionAdversa.Name = "rbuttonNoReacionAdversa"
        Me.rbuttonNoReacionAdversa.Size = New System.Drawing.Size(49, 22)
        Me.rbuttonNoReacionAdversa.TabIndex = 0
        Me.rbuttonNoReacionAdversa.TabStop = True
        Me.rbuttonNoReacionAdversa.Text = "No"
        Me.rbuttonNoReacionAdversa.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(71, 289)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(564, 29)
        Me.TableLayoutPanel6.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(4, 13)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(556, 2)
        Me.Label17.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Medicamento Suministrado"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ATENCIÓN DE INYECTABLES"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Asegurado"
        '
        'rbuttonSiReacionAdversa
        '
        Me.rbuttonSiReacionAdversa.AutoSize = True
        Me.rbuttonSiReacionAdversa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonSiReacionAdversa.Location = New System.Drawing.Point(93, 23)
        Me.rbuttonSiReacionAdversa.Margin = New System.Windows.Forms.Padding(4)
        Me.rbuttonSiReacionAdversa.Name = "rbuttonSiReacionAdversa"
        Me.rbuttonSiReacionAdversa.Size = New System.Drawing.Size(42, 22)
        Me.rbuttonSiReacionAdversa.TabIndex = 0
        Me.rbuttonSiReacionAdversa.TabStop = True
        Me.rbuttonSiReacionAdversa.Text = "Si"
        Me.rbuttonSiReacionAdversa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre de medicamento"
        '
        'txtMedico
        '
        Me.txtMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedico.Location = New System.Drawing.Point(414, 57)
        Me.txtMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.Size = New System.Drawing.Size(191, 24)
        Me.txtMedico.TabIndex = 25
        '
        'cmboxMedico
        '
        Me.cmboxMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxMedico.FormattingEnabled = True
        Me.cmboxMedico.Location = New System.Drawing.Point(414, 57)
        Me.cmboxMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxMedico.Name = "cmboxMedico"
        Me.cmboxMedico.Size = New System.Drawing.Size(219, 26)
        Me.cmboxMedico.TabIndex = 23
        '
        'panelMedicamentoSuministrado
        '
        Me.panelMedicamentoSuministrado.BackColor = System.Drawing.Color.Transparent
        Me.panelMedicamentoSuministrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMedicamentoSuministrado.Controls.Add(Me.GroupBox3)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.GroupBox2)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.Label6)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.Label5)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.Label4)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.Label12)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.Label7)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.txtVia)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.txtNombreMedicamento)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.txtActividadRealizada)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.txtDosis)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.txtCodigoMedicamento)
        Me.panelMedicamentoSuministrado.Controls.Add(Me.Label2)
        Me.panelMedicamentoSuministrado.Location = New System.Drawing.Point(71, 326)
        Me.panelMedicamentoSuministrado.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMedicamentoSuministrado.Name = "panelMedicamentoSuministrado"
        Me.panelMedicamentoSuministrado.Size = New System.Drawing.Size(1077, 210)
        Me.panelMedicamentoSuministrado.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbuttonSiReacionAdversa)
        Me.GroupBox3.Controls.Add(Me.rbuttonNoReacionAdversa)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(684, 47)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(217, 85)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reacción Adversa"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 89)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 20)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(261, 34)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Edad"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(34, 41)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1114, 35)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'txtAsegurado
        '
        Me.txtAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsegurado.Location = New System.Drawing.Point(21, 59)
        Me.txtAsegurado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAsegurado.Name = "txtAsegurado"
        Me.txtAsegurado.Size = New System.Drawing.Size(219, 24)
        Me.txtAsegurado.TabIndex = 24
        '
        'cmboxAsegurado
        '
        Me.cmboxAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxAsegurado.FormattingEnabled = True
        Me.cmboxAsegurado.Location = New System.Drawing.Point(21, 59)
        Me.cmboxAsegurado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxAsegurado.Name = "cmboxAsegurado"
        Me.cmboxAsegurado.Size = New System.Drawing.Size(219, 26)
        Me.cmboxAsegurado.TabIndex = 22
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(265, 58)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(121, 24)
        Me.txtEdad.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.datePickerFecha)
        Me.GroupBox1.Controls.Add(Me.cmboxAsegurado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmboxMedico)
        Me.GroupBox1.Controls.Add(Me.txtAsegurado)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMedico)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(71, 137)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1077, 144)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'Restroceder
        '
        Me.Restroceder.Location = New System.Drawing.Point(966, 610)
        Me.Restroceder.Name = "Restroceder"
        Me.Restroceder.Size = New System.Drawing.Size(181, 32)
        Me.Restroceder.TabIndex = 31
        Me.Restroceder.Text = "Cancelar"
        Me.Restroceder.UseVisualStyleBackColor = True
        '
        'FormRegistrarAtencionInyectables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1172, 673)
        Me.Controls.Add(Me.Restroceder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardarAtencion)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Controls.Add(Me.panelMedicamentoSuministrado)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormRegistrarAtencionInyectables"
        Me.Text = "Inyectables"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.panelMedicamentoSuministrado.ResumeLayout(False)
        Me.panelMedicamentoSuministrado.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbuttonNegativoPps As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbuttonPositivoPps As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVia As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents txtActividadRealizada As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents txtDosis As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarAtencion As System.Windows.Forms.Button
    Friend WithEvents datePickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbuttonNoReacionAdversa As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbuttonSiReacionAdversa As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMedico As System.Windows.Forms.TextBox
    Friend WithEvents cmboxMedico As System.Windows.Forms.ComboBox
    Friend WithEvents panelMedicamentoSuministrado As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtAsegurado As System.Windows.Forms.TextBox
    Friend WithEvents cmboxAsegurado As System.Windows.Forms.ComboBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Restroceder As Button
End Class
