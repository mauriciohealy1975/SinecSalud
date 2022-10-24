<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarBeneficiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistrarBeneficiario))
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panelDatosDocumento = New System.Windows.Forms.Panel()
        Me.hintLugarExpedicion = New System.Windows.Forms.Label()
        Me.hintTipoDocumento = New System.Windows.Forms.Label()
        Me.cboxLugarExpedicion = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboxTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtComplementoDocumento = New System.Windows.Forms.TextBox()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.panelDetalle1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPartida = New System.Windows.Forms.TextBox()
        Me.txtNroLibro = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtOficilia = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dgvBeneficiarios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.panelDetalle2 = New System.Windows.Forms.Panel()
        Me.txtNotaria = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDeclaracionJurada = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.toolStripModos = New System.Windows.Forms.ToolStrip()
        Me.toolStripRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripEliminar = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.cboxTitulares = New System.Windows.Forms.ComboBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.fmeLblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarMatricula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarMatricula = New System.Windows.Forms.Button()
        Me.hintTitulares = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panelSexo = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.rButtonFemenino = New System.Windows.Forms.RadioButton()
        Me.rButtonMasculino = New System.Windows.Forms.RadioButton()
        Me.txtMatriculaBeneficiario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dpcFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.elCboxMotivo = New System.Windows.Forms.ComboBox()
        Me.elHintMotivo = New System.Windows.Forms.Label()
        Me.panelDatosPersonales = New System.Windows.Forms.Panel()
        Me.hintParentezco = New System.Windows.Forms.Label()
        Me.cboxParentezco = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelDatosDocumento.SuspendLayout()
        Me.panelDetalle1.SuspendLayout()
        CType(Me.dgvBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetalle2.SuspendLayout()
        Me.toolStripModos.SuspendLayout()
        Me.panelSexo.SuspendLayout()
        Me.panelDatosPersonales.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(1066, 509)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(169, 28)
        Me.btnEnviar.TabIndex = 8
        Me.btnEnviar.Text = "Registrar beneficiarios"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(983, 509)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 28)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(489, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(226, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR BENEFICIARIO"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 40)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1205, 22)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'panelDatosDocumento
        '
        Me.panelDatosDocumento.BackColor = System.Drawing.Color.White
        Me.panelDatosDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosDocumento.Controls.Add(Me.hintLugarExpedicion)
        Me.panelDatosDocumento.Controls.Add(Me.hintTipoDocumento)
        Me.panelDatosDocumento.Controls.Add(Me.cboxLugarExpedicion)
        Me.panelDatosDocumento.Controls.Add(Me.Label61)
        Me.panelDatosDocumento.Controls.Add(Me.Label4)
        Me.panelDatosDocumento.Controls.Add(Me.Label9)
        Me.panelDatosDocumento.Controls.Add(Me.cboxTipoDoc)
        Me.panelDatosDocumento.Controls.Add(Me.txtComplementoDocumento)
        Me.panelDatosDocumento.Controls.Add(Me.txtNroDocumento)
        Me.panelDatosDocumento.Controls.Add(Me.Label10)
        Me.panelDatosDocumento.Controls.Add(Me.label25)
        Me.panelDatosDocumento.Location = New System.Drawing.Point(33, 265)
        Me.panelDatosDocumento.Name = "panelDatosDocumento"
        Me.panelDatosDocumento.Size = New System.Drawing.Size(276, 200)
        Me.panelDatosDocumento.TabIndex = 3
        '
        'hintLugarExpedicion
        '
        Me.hintLugarExpedicion.AutoSize = True
        Me.hintLugarExpedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintLugarExpedicion.Location = New System.Drawing.Point(158, 160)
        Me.hintLugarExpedicion.Name = "hintLugarExpedicion"
        Me.hintLugarExpedicion.Size = New System.Drawing.Size(82, 13)
        Me.hintLugarExpedicion.TabIndex = 0
        Me.hintLugarExpedicion.Text = "SELECCIONAR"
        '
        'hintTipoDocumento
        '
        Me.hintTipoDocumento.AutoSize = True
        Me.hintTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTipoDocumento.Location = New System.Drawing.Point(156, 55)
        Me.hintTipoDocumento.Name = "hintTipoDocumento"
        Me.hintTipoDocumento.Size = New System.Drawing.Size(82, 13)
        Me.hintTipoDocumento.TabIndex = 0
        Me.hintTipoDocumento.Text = "SELECCIONAR"
        '
        'cboxLugarExpedicion
        '
        Me.cboxLugarExpedicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxLugarExpedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxLugarExpedicion.FormattingEnabled = True
        Me.cboxLugarExpedicion.Location = New System.Drawing.Point(153, 155)
        Me.cboxLugarExpedicion.Name = "cboxLugarExpedicion"
        Me.cboxLugarExpedicion.Size = New System.Drawing.Size(103, 23)
        Me.cboxLugarExpedicion.TabIndex = 4
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label61.Location = New System.Drawing.Point(15, 15)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(150, 17)
        Me.Label61.TabIndex = 0
        Me.Label61.Text = "2.- Datos documeto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Complemento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Lugar expedición"
        '
        'cboxTipoDoc
        '
        Me.cboxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTipoDoc.FormattingEnabled = True
        Me.cboxTipoDoc.Location = New System.Drawing.Point(152, 50)
        Me.cboxTipoDoc.Name = "cboxTipoDoc"
        Me.cboxTipoDoc.Size = New System.Drawing.Size(104, 23)
        Me.cboxTipoDoc.TabIndex = 1
        '
        'txtComplementoDocumento
        '
        Me.txtComplementoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplementoDocumento.Location = New System.Drawing.Point(152, 120)
        Me.txtComplementoDocumento.Name = "txtComplementoDocumento"
        Me.txtComplementoDocumento.Size = New System.Drawing.Size(104, 21)
        Me.txtComplementoDocumento.TabIndex = 3
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento.Location = New System.Drawing.Point(152, 85)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(104, 21)
        Me.txtNroDocumento.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tipo de documento"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label25.Location = New System.Drawing.Point(25, 85)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(119, 16)
        Me.label25.TabIndex = 0
        Me.label25.Text = "Nro de documento"
        '
        'panelDetalle1
        '
        Me.panelDetalle1.BackColor = System.Drawing.Color.White
        Me.panelDetalle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDetalle1.Controls.Add(Me.Label6)
        Me.panelDetalle1.Controls.Add(Me.txtFolio)
        Me.panelDetalle1.Controls.Add(Me.Label19)
        Me.panelDetalle1.Controls.Add(Me.txtPartida)
        Me.panelDetalle1.Controls.Add(Me.txtNroLibro)
        Me.panelDetalle1.Controls.Add(Me.Label20)
        Me.panelDetalle1.Controls.Add(Me.txtOficilia)
        Me.panelDetalle1.Controls.Add(Me.Label21)
        Me.panelDetalle1.Controls.Add(Me.Label22)
        Me.panelDetalle1.Location = New System.Drawing.Point(330, 265)
        Me.panelDetalle1.Name = "panelDetalle1"
        Me.panelDetalle1.Size = New System.Drawing.Size(206, 200)
        Me.panelDetalle1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Folio"
        '
        'txtFolio
        '
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(83, 155)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(71, 21)
        Me.txtFolio.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(26, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Partida"
        '
        'txtPartida
        '
        Me.txtPartida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Location = New System.Drawing.Point(83, 120)
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.Size = New System.Drawing.Size(71, 21)
        Me.txtPartida.TabIndex = 3
        '
        'txtNroLibro
        '
        Me.txtNroLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroLibro.Location = New System.Drawing.Point(82, 85)
        Me.txtNroLibro.Name = "txtNroLibro"
        Me.txtNroLibro.Size = New System.Drawing.Size(72, 21)
        Me.txtNroLibro.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Nro. libro"
        '
        'txtOficilia
        '
        Me.txtOficilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOficilia.Location = New System.Drawing.Point(82, 50)
        Me.txtOficilia.Name = "txtOficilia"
        Me.txtOficilia.Size = New System.Drawing.Size(72, 21)
        Me.txtOficilia.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(15, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(177, 18)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "3.- Detalle beneficiario"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(21, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Oficialia"
        '
        'dgvBeneficiarios
        '
        Me.dgvBeneficiarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBeneficiarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvBeneficiarios.Location = New System.Drawing.Point(563, 265)
        Me.dgvBeneficiarios.Name = "dgvBeneficiarios"
        Me.dgvBeneficiarios.Size = New System.Drawing.Size(672, 200)
        Me.dgvBeneficiarios.TabIndex = 6
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
        'Column3
        '
        Me.Column3.HeaderText = "parentezco"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "oficilia"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "nro libro"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "partida"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "folio"
        Me.Column7.Name = "Column7"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.ForeColor = System.Drawing.Color.Black
        Me.btnAdicionar.Location = New System.Drawing.Point(403, 471)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(133, 28)
        Me.btnAdicionar.TabIndex = 5
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'panelDetalle2
        '
        Me.panelDetalle2.BackColor = System.Drawing.Color.White
        Me.panelDetalle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDetalle2.Controls.Add(Me.txtNotaria)
        Me.panelDetalle2.Controls.Add(Me.Label17)
        Me.panelDetalle2.Controls.Add(Me.txtDeclaracionJurada)
        Me.panelDetalle2.Controls.Add(Me.Label18)
        Me.panelDetalle2.Controls.Add(Me.Label23)
        Me.panelDetalle2.Location = New System.Drawing.Point(330, 265)
        Me.panelDetalle2.Name = "panelDetalle2"
        Me.panelDetalle2.Size = New System.Drawing.Size(206, 200)
        Me.panelDetalle2.TabIndex = 4
        '
        'txtNotaria
        '
        Me.txtNotaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaria.Location = New System.Drawing.Point(21, 135)
        Me.txtNotaria.Name = "txtNotaria"
        Me.txtNotaria.Size = New System.Drawing.Size(97, 21)
        Me.txtNotaria.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 115)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Nro. notaría"
        '
        'txtDeclaracionJurada
        '
        Me.txtDeclaracionJurada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeclaracionJurada.Location = New System.Drawing.Point(24, 75)
        Me.txtDeclaracionJurada.Name = "txtDeclaracionJurada"
        Me.txtDeclaracionJurada.Size = New System.Drawing.Size(94, 21)
        Me.txtDeclaracionJurada.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(15, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(177, 18)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "3.- Detalle beneficiario"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(21, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(148, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Nro. declaración jurada"
        '
        'toolStripModos
        '
        Me.toolStripModos.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.toolStripModos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripRegistrar, Me.toolStripEliminar})
        Me.toolStripModos.Location = New System.Drawing.Point(0, 0)
        Me.toolStripModos.Name = "toolStripModos"
        Me.toolStripModos.Size = New System.Drawing.Size(1264, 25)
        Me.toolStripModos.TabIndex = 0
        Me.toolStripModos.Text = "ToolStrip1"
        '
        'toolStripRegistrar
        '
        Me.toolStripRegistrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.toolStripRegistrar.Image = CType(resources.GetObject("toolStripRegistrar.Image"), System.Drawing.Image)
        Me.toolStripRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripRegistrar.Name = "toolStripRegistrar"
        Me.toolStripRegistrar.Size = New System.Drawing.Size(77, 22)
        Me.toolStripRegistrar.Text = "REGISTRAR"
        '
        'toolStripEliminar
        '
        Me.toolStripEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripEliminar.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.toolStripEliminar.Image = CType(resources.GetObject("toolStripEliminar.Image"), System.Drawing.Image)
        Me.toolStripEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripEliminar.Name = "toolStripEliminar"
        Me.toolStripEliminar.Size = New System.Drawing.Size(69, 22)
        Me.toolStripEliminar.Text = "ELIMINAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(314, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Apellido paterno"
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
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(427, 50)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(119, 21)
        Me.txtApellidoPaterno.TabIndex = 5
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
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(427, 85)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(119, 21)
        Me.txtApellidoMaterno.TabIndex = 6
        '
        'cboxTitulares
        '
        Me.cboxTitulares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTitulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTitulares.FormattingEnabled = True
        Me.cboxTitulares.Location = New System.Drawing.Point(19, 85)
        Me.cboxTitulares.Name = "cboxTitulares"
        Me.cboxTitulares.Size = New System.Drawing.Size(259, 21)
        Me.cboxTitulares.TabIndex = 3
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(427, 120)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(119, 21)
        Me.txtNombres.TabIndex = 7
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
        'txtBuscarMatricula
        '
        Me.txtBuscarMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarMatricula.Location = New System.Drawing.Point(83, 50)
        Me.txtBuscarMatricula.Name = "txtBuscarMatricula"
        Me.txtBuscarMatricula.Size = New System.Drawing.Size(122, 21)
        Me.txtBuscarMatricula.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Matricula"
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
        'hintTitulares
        '
        Me.hintTitulares.AutoSize = True
        Me.hintTitulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTitulares.Location = New System.Drawing.Point(24, 89)
        Me.hintTitulares.Name = "hintTitulares"
        Me.hintTitulares.Size = New System.Drawing.Size(131, 13)
        Me.hintTitulares.TabIndex = 0
        Me.hintTitulares.Text = "SELECCIONAR TITULAR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(583, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Matricula"
        '
        'panelSexo
        '
        Me.panelSexo.BackColor = System.Drawing.Color.White
        Me.panelSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelSexo.Controls.Add(Me.Label34)
        Me.panelSexo.Controls.Add(Me.rButtonFemenino)
        Me.panelSexo.Controls.Add(Me.rButtonMasculino)
        Me.panelSexo.Location = New System.Drawing.Point(583, 85)
        Me.panelSexo.Name = "panelSexo"
        Me.panelSexo.Size = New System.Drawing.Size(213, 53)
        Me.panelSexo.TabIndex = 9
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(7, 20)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(39, 16)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Sexo"
        '
        'rButtonFemenino
        '
        Me.rButtonFemenino.AutoSize = True
        Me.rButtonFemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonFemenino.Location = New System.Drawing.Point(62, 27)
        Me.rButtonFemenino.Name = "rButtonFemenino"
        Me.rButtonFemenino.Size = New System.Drawing.Size(81, 19)
        Me.rButtonFemenino.TabIndex = 2
        Me.rButtonFemenino.TabStop = True
        Me.rButtonFemenino.Text = "Femenino"
        Me.rButtonFemenino.UseVisualStyleBackColor = True
        '
        'rButtonMasculino
        '
        Me.rButtonMasculino.AutoSize = True
        Me.rButtonMasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonMasculino.Location = New System.Drawing.Point(61, 7)
        Me.rButtonMasculino.Name = "rButtonMasculino"
        Me.rButtonMasculino.Size = New System.Drawing.Size(82, 19)
        Me.rButtonMasculino.TabIndex = 1
        Me.rButtonMasculino.TabStop = True
        Me.rButtonMasculino.Text = "Masculino"
        Me.rButtonMasculino.UseVisualStyleBackColor = True
        '
        'txtMatriculaBeneficiario
        '
        Me.txtMatriculaBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriculaBeneficiario.Location = New System.Drawing.Point(661, 50)
        Me.txtMatriculaBeneficiario.Name = "txtMatriculaBeneficiario"
        Me.txtMatriculaBeneficiario.Size = New System.Drawing.Size(135, 21)
        Me.txtMatriculaBeneficiario.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Parentezco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(835, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha de nac."
        '
        'dpcFechaNacimiento
        '
        Me.dpcFechaNacimiento.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaNacimiento.Location = New System.Drawing.Point(936, 50)
        Me.dpcFechaNacimiento.Name = "dpcFechaNacimiento"
        Me.dpcFechaNacimiento.ShowUpDown = True
        Me.dpcFechaNacimiento.Size = New System.Drawing.Size(114, 21)
        Me.dpcFechaNacimiento.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(887, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Edad"
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(936, 85)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(49, 21)
        Me.txtEdad.TabIndex = 11
        '
        'elCboxMotivo
        '
        Me.elCboxMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.elCboxMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elCboxMotivo.FormattingEnabled = True
        Me.elCboxMotivo.Items.AddRange(New Object() {"ESPOSO/A", "HIJO/A", ""})
        Me.elCboxMotivo.Location = New System.Drawing.Point(314, 15)
        Me.elCboxMotivo.Name = "elCboxMotivo"
        Me.elCboxMotivo.Size = New System.Drawing.Size(207, 23)
        Me.elCboxMotivo.TabIndex = 0
        '
        'elHintMotivo
        '
        Me.elHintMotivo.AutoSize = True
        Me.elHintMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elHintMotivo.Location = New System.Drawing.Point(319, 20)
        Me.elHintMotivo.Name = "elHintMotivo"
        Me.elHintMotivo.Size = New System.Drawing.Size(174, 13)
        Me.elHintMotivo.TabIndex = 89
        Me.elHintMotivo.Text = "SELECCIONAR MOTIVO DE BAJA"
        '
        'panelDatosPersonales
        '
        Me.panelDatosPersonales.BackColor = System.Drawing.Color.White
        Me.panelDatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosPersonales.Controls.Add(Me.elHintMotivo)
        Me.panelDatosPersonales.Controls.Add(Me.elCboxMotivo)
        Me.panelDatosPersonales.Controls.Add(Me.txtEdad)
        Me.panelDatosPersonales.Controls.Add(Me.Label14)
        Me.panelDatosPersonales.Controls.Add(Me.dpcFechaNacimiento)
        Me.panelDatosPersonales.Controls.Add(Me.Label2)
        Me.panelDatosPersonales.Controls.Add(Me.hintParentezco)
        Me.panelDatosPersonales.Controls.Add(Me.cboxParentezco)
        Me.panelDatosPersonales.Controls.Add(Me.Label13)
        Me.panelDatosPersonales.Controls.Add(Me.txtMatriculaBeneficiario)
        Me.panelDatosPersonales.Controls.Add(Me.panelSexo)
        Me.panelDatosPersonales.Controls.Add(Me.Label11)
        Me.panelDatosPersonales.Controls.Add(Me.hintTitulares)
        Me.panelDatosPersonales.Controls.Add(Me.btnBuscarMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.Label3)
        Me.panelDatosPersonales.Controls.Add(Me.txtBuscarMatricula)
        Me.panelDatosPersonales.Controls.Add(Me.fmeLblBuscar)
        Me.panelDatosPersonales.Controls.Add(Me.txtNombres)
        Me.panelDatosPersonales.Controls.Add(Me.cboxTitulares)
        Me.panelDatosPersonales.Controls.Add(Me.txtApellidoMaterno)
        Me.panelDatosPersonales.Controls.Add(Me.lblContraseña)
        Me.panelDatosPersonales.Controls.Add(Me.txtApellidoPaterno)
        Me.panelDatosPersonales.Controls.Add(Me.Label7)
        Me.panelDatosPersonales.Controls.Add(Me.Label5)
        Me.panelDatosPersonales.Location = New System.Drawing.Point(30, 80)
        Me.panelDatosPersonales.Name = "panelDatosPersonales"
        Me.panelDatosPersonales.Size = New System.Drawing.Size(1085, 160)
        Me.panelDatosPersonales.TabIndex = 2
        '
        'hintParentezco
        '
        Me.hintParentezco.AutoSize = True
        Me.hintParentezco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintParentezco.Location = New System.Drawing.Point(101, 125)
        Me.hintParentezco.Name = "hintParentezco"
        Me.hintParentezco.Size = New System.Drawing.Size(82, 13)
        Me.hintParentezco.TabIndex = 0
        Me.hintParentezco.Text = "SELECCIONAR"
        '
        'cboxParentezco
        '
        Me.cboxParentezco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxParentezco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxParentezco.FormattingEnabled = True
        Me.cboxParentezco.Items.AddRange(New Object() {"ESPOSO/A", "HIJO/A", ""})
        Me.cboxParentezco.Location = New System.Drawing.Point(97, 120)
        Me.cboxParentezco.Name = "cboxParentezco"
        Me.cboxParentezco.Size = New System.Drawing.Size(181, 23)
        Me.cboxParentezco.TabIndex = 4
        '
        'FormRegistrarBeneficiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.toolStripModos)
        Me.Controls.Add(Me.panelDetalle2)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.dgvBeneficiarios)
        Me.Controls.Add(Me.panelDetalle1)
        Me.Controls.Add(Me.panelDatosPersonales)
        Me.Controls.Add(Me.panelDatosDocumento)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarBeneficiario"
        Me.Text = "Registar beneficiario"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelDatosDocumento.ResumeLayout(False)
        Me.panelDatosDocumento.PerformLayout()
        Me.panelDetalle1.ResumeLayout(False)
        Me.panelDetalle1.PerformLayout()
        CType(Me.dgvBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetalle2.ResumeLayout(False)
        Me.panelDetalle2.PerformLayout()
        Me.toolStripModos.ResumeLayout(False)
        Me.toolStripModos.PerformLayout()
        Me.panelSexo.ResumeLayout(False)
        Me.panelSexo.PerformLayout()
        Me.panelDatosPersonales.ResumeLayout(False)
        Me.panelDatosPersonales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelDatosDocumento As System.Windows.Forms.Panel
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboxTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtComplementoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents label25 As System.Windows.Forms.Label
    Friend WithEvents panelDetalle1 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPartida As System.Windows.Forms.TextBox
    Friend WithEvents txtNroLibro As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtOficilia As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents cboxLugarExpedicion As System.Windows.Forms.ComboBox
    Friend WithEvents dgvBeneficiarios As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents hintLugarExpedicion As System.Windows.Forms.Label
    Friend WithEvents hintTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents panelDetalle2 As System.Windows.Forms.Panel
    Friend WithEvents txtNotaria As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDeclaracionJurada As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents toolStripModos As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripRegistrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents cboxTitulares As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents fmeLblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscarMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarMatricula As System.Windows.Forms.Button
    Friend WithEvents hintTitulares As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents panelSexo As System.Windows.Forms.Panel
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents rButtonFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rButtonMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents txtMatriculaBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dpcFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents elCboxMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents elHintMotivo As System.Windows.Forms.Label
    Friend WithEvents panelDatosPersonales As System.Windows.Forms.Panel
    Friend WithEvents hintParentezco As System.Windows.Forms.Label
    Friend WithEvents cboxParentezco As System.Windows.Forms.ComboBox
End Class
