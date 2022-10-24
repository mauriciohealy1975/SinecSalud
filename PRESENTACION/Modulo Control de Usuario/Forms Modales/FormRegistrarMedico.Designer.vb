<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarMedico
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.checkMedExtern = New System.Windows.Forms.CheckBox()
        Me.hintCboxEspecialidad = New System.Windows.Forms.Label()
        Me.cmboxEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txbCantFicExt = New System.Windows.Forms.TextBox()
        Me.txtCantidadFichas = New System.Windows.Forms.TextBox()
        Me.cmboxSalidaMinutos = New System.Windows.Forms.ComboBox()
        Me.cmboxSalidaHora = New System.Windows.Forms.ComboBox()
        Me.cmboxEntradaMinutos = New System.Windows.Forms.ComboBox()
        Me.cmboxEntradaHora = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rButtonTarde = New System.Windows.Forms.RadioButton()
        Me.rButtonMañana = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.hintCmboxDuracionFicha = New System.Windows.Forms.Label()
        Me.cmboxDuracionFicha = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardarDatos = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chListDias = New System.Windows.Forms.CheckedListBox()
        Me.LFD = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbDireccion = New System.Windows.Forms.TextBox()
        Me.txbTelefonos = New System.Windows.Forms.TextBox()
        Me.LTel = New System.Windows.Forms.Label()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(56, 30)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1263, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(520, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR MÉDICO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LDireccion)
        Me.Panel1.Controls.Add(Me.LTel)
        Me.Panel1.Controls.Add(Me.txbTelefonos)
        Me.Panel1.Controls.Add(Me.txbDireccion)
        Me.Panel1.Controls.Add(Me.checkMedExtern)
        Me.Panel1.Controls.Add(Me.hintCboxEspecialidad)
        Me.Panel1.Controls.Add(Me.cmboxEspecialidad)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNombreCompleto)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(56, 85)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 199)
        Me.Panel1.TabIndex = 1
        '
        'checkMedExtern
        '
        Me.checkMedExtern.AutoSize = True
        Me.checkMedExtern.Location = New System.Drawing.Point(497, 142)
        Me.checkMedExtern.Name = "checkMedExtern"
        Me.checkMedExtern.Size = New System.Drawing.Size(122, 20)
        Me.checkMedExtern.TabIndex = 4
        Me.checkMedExtern.Text = "Médico Externo"
        Me.checkMedExtern.UseVisualStyleBackColor = True
        '
        'hintCboxEspecialidad
        '
        Me.hintCboxEspecialidad.AutoSize = True
        Me.hintCboxEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCboxEspecialidad.Location = New System.Drawing.Point(497, 92)
        Me.hintCboxEspecialidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintCboxEspecialidad.Name = "hintCboxEspecialidad"
        Me.hintCboxEspecialidad.Size = New System.Drawing.Size(114, 18)
        Me.hintCboxEspecialidad.TabIndex = 0
        Me.hintCboxEspecialidad.Text = "SELECCIONAR"
        '
        'cmboxEspecialidad
        '
        Me.cmboxEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxEspecialidad.FormattingEnabled = True
        Me.cmboxEspecialidad.Location = New System.Drawing.Point(493, 87)
        Me.cmboxEspecialidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxEspecialidad.Name = "cmboxEspecialidad"
        Me.cmboxEspecialidad.Size = New System.Drawing.Size(320, 26)
        Me.cmboxEspecialidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(489, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Especialidad"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(145, 138)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(267, 24)
        Me.txtNombreCompleto.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(61, 142)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Nombre"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(145, 92)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(104, 24)
        Me.txtUsername.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(31, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1.- Datos del médico"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txbCantFicExt)
        Me.Panel2.Controls.Add(Me.txtCantidadFichas)
        Me.Panel2.Controls.Add(Me.cmboxSalidaMinutos)
        Me.Panel2.Controls.Add(Me.cmboxSalidaHora)
        Me.Panel2.Controls.Add(Me.cmboxEntradaMinutos)
        Me.Panel2.Controls.Add(Me.cmboxEntradaHora)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.hintCmboxDuracionFicha)
        Me.Panel2.Controls.Add(Me.cmboxDuracionFicha)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.btnGuardarDatos)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.chListDias)
        Me.Panel2.Controls.Add(Me.LFD)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(56, 320)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1275, 321)
        Me.Panel2.TabIndex = 2
        '
        'txbCantFicExt
        '
        Me.txbCantFicExt.Location = New System.Drawing.Point(660, 168)
        Me.txbCantFicExt.Name = "txbCantFicExt"
        Me.txbCantFicExt.Size = New System.Drawing.Size(69, 22)
        Me.txbCantFicExt.TabIndex = 13
        '
        'txtCantidadFichas
        '
        Me.txtCantidadFichas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadFichas.Location = New System.Drawing.Point(665, 261)
        Me.txtCantidadFichas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadFichas.Name = "txtCantidadFichas"
        Me.txtCantidadFichas.Size = New System.Drawing.Size(175, 24)
        Me.txtCantidadFichas.TabIndex = 12
        '
        'cmboxSalidaMinutos
        '
        Me.cmboxSalidaMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxSalidaMinutos.FormattingEnabled = True
        Me.cmboxSalidaMinutos.Location = New System.Drawing.Point(765, 128)
        Me.cmboxSalidaMinutos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxSalidaMinutos.Name = "cmboxSalidaMinutos"
        Me.cmboxSalidaMinutos.Size = New System.Drawing.Size(75, 26)
        Me.cmboxSalidaMinutos.TabIndex = 10
        Me.cmboxSalidaMinutos.Text = "00"
        '
        'cmboxSalidaHora
        '
        Me.cmboxSalidaHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxSalidaHora.FormattingEnabled = True
        Me.cmboxSalidaHora.Location = New System.Drawing.Point(660, 128)
        Me.cmboxSalidaHora.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxSalidaHora.Name = "cmboxSalidaHora"
        Me.cmboxSalidaHora.Size = New System.Drawing.Size(69, 26)
        Me.cmboxSalidaHora.TabIndex = 11
        Me.cmboxSalidaHora.Text = "13"
        '
        'cmboxEntradaMinutos
        '
        Me.cmboxEntradaMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxEntradaMinutos.FormattingEnabled = True
        Me.cmboxEntradaMinutos.Location = New System.Drawing.Point(765, 66)
        Me.cmboxEntradaMinutos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxEntradaMinutos.Name = "cmboxEntradaMinutos"
        Me.cmboxEntradaMinutos.Size = New System.Drawing.Size(75, 26)
        Me.cmboxEntradaMinutos.TabIndex = 4
        Me.cmboxEntradaMinutos.Text = "00"
        '
        'cmboxEntradaHora
        '
        Me.cmboxEntradaHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxEntradaHora.FormattingEnabled = True
        Me.cmboxEntradaHora.Location = New System.Drawing.Point(660, 66)
        Me.cmboxEntradaHora.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxEntradaHora.Name = "cmboxEntradaHora"
        Me.cmboxEntradaHora.Size = New System.Drawing.Size(69, 26)
        Me.cmboxEntradaHora.TabIndex = 4
        Me.cmboxEntradaHora.Text = "07"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.rButtonTarde)
        Me.Panel3.Controls.Add(Me.rButtonMañana)
        Me.Panel3.Location = New System.Drawing.Point(69, 66)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(343, 112)
        Me.Panel3.TabIndex = 2
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(532, 265)
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
        Me.hintCmboxDuracionFicha.Location = New System.Drawing.Point(664, 202)
        Me.hintCmboxDuracionFicha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintCmboxDuracionFicha.Name = "hintCmboxDuracionFicha"
        Me.hintCmboxDuracionFicha.Size = New System.Drawing.Size(114, 18)
        Me.hintCmboxDuracionFicha.TabIndex = 0
        Me.hintCmboxDuracionFicha.Text = "SELECCIONAR"
        '
        'cmboxDuracionFicha
        '
        Me.cmboxDuracionFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxDuracionFicha.FormattingEnabled = True
        Me.cmboxDuracionFicha.Location = New System.Drawing.Point(660, 197)
        Me.cmboxDuracionFicha.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxDuracionFicha.Name = "cmboxDuracionFicha"
        Me.cmboxDuracionFicha.Size = New System.Drawing.Size(180, 26)
        Me.cmboxDuracionFicha.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(493, 197)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Duración ficha"
        '
        'btnGuardarDatos
        '
        Me.btnGuardarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarDatos.Location = New System.Drawing.Point(1053, 257)
        Me.btnGuardarDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarDatos.Name = "btnGuardarDatos"
        Me.btnGuardarDatos.Size = New System.Drawing.Size(175, 33)
        Me.btnGuardarDatos.TabIndex = 9
        Me.btnGuardarDatos.Text = "Registrar Medico"
        Me.btnGuardarDatos.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(945, 257)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 33)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(929, 57)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Dias de turno"
        '
        'chListDias
        '
        Me.chListDias.CheckOnClick = True
        Me.chListDias.FormattingEnabled = True
        Me.chListDias.Location = New System.Drawing.Point(933, 91)
        Me.chListDias.Margin = New System.Windows.Forms.Padding(4)
        Me.chListDias.MultiColumn = True
        Me.chListDias.Name = "chListDias"
        Me.chListDias.Size = New System.Drawing.Size(293, 123)
        Me.chListDias.TabIndex = 7
        '
        'LFD
        '
        Me.LFD.AutoSize = True
        Me.LFD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFD.Location = New System.Drawing.Point(493, 170)
        Me.LFD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LFD.Name = "LFD"
        Me.LFD.Size = New System.Drawing.Size(142, 20)
        Me.LFD.TabIndex = 0
        Me.LFD.Text = "Fichas Disponibles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(493, 132)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Hora de salida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(489, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hora de entrada"
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
        'txbDireccion
        '
        Me.txbDireccion.Location = New System.Drawing.Point(861, 84)
        Me.txbDireccion.Multiline = True
        Me.txbDireccion.Name = "txbDireccion"
        Me.txbDireccion.Size = New System.Drawing.Size(332, 29)
        Me.txbDireccion.TabIndex = 5
        Me.txbDireccion.Text = "C/ España Nº473"
        '
        'txbTelefonos
        '
        Me.txbTelefonos.Location = New System.Drawing.Point(861, 160)
        Me.txbTelefonos.Name = "txbTelefonos"
        Me.txbTelefonos.Size = New System.Drawing.Size(332, 22)
        Me.txbTelefonos.TabIndex = 6
        Me.txbTelefonos.Text = "3364160"
        '
        'LTel
        '
        Me.LTel.AutoSize = True
        Me.LTel.Location = New System.Drawing.Point(861, 138)
        Me.LTel.Name = "LTel"
        Me.LTel.Size = New System.Drawing.Size(68, 16)
        Me.LTel.TabIndex = 7
        Me.LTel.Text = "Telefonos"
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Location = New System.Drawing.Point(861, 66)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(64, 16)
        Me.LDireccion.TabIndex = 7
        Me.LDireccion.Text = "Direccion"
        '
        'FormRegistrarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1383, 690)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRegistrarMedico"
        Me.Text = "FormAgregarMedico"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents hintCboxEspecialidad As System.Windows.Forms.Label
    Friend WithEvents cmboxEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chListDias As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnGuardarDatos As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents hintCmboxDuracionFicha As System.Windows.Forms.Label
    Friend WithEvents cmboxDuracionFicha As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rButtonTarde As System.Windows.Forms.RadioButton
    Friend WithEvents rButtonMañana As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmboxSalidaMinutos As System.Windows.Forms.ComboBox
    Friend WithEvents cmboxSalidaHora As System.Windows.Forms.ComboBox
    Friend WithEvents cmboxEntradaMinutos As System.Windows.Forms.ComboBox
    Friend WithEvents cmboxEntradaHora As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidadFichas As System.Windows.Forms.TextBox
    Friend WithEvents checkMedExtern As CheckBox
    Friend WithEvents txbCantFicExt As TextBox
    Friend WithEvents LFD As Label
    Friend WithEvents LDireccion As Label
    Friend WithEvents LTel As Label
    Friend WithEvents txbTelefonos As TextBox
    Friend WithEvents txbDireccion As TextBox
End Class
