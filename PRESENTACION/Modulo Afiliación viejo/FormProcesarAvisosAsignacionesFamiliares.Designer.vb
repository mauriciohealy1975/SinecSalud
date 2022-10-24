<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProcesarAvisosAsignacionesFamiliares
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
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panelDetalleAviso = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.txtMatriculaTitular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFechaExpiracion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hintEstado = New System.Windows.Forms.Label()
        Me.cboxEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombreEjecutor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panelProcesarAviso = New System.Windows.Forms.Panel()
        Me.hintParentesco = New System.Windows.Forms.Label()
        Me.cboxParentesco = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.panelAvisos = New System.Windows.Forms.Panel()
        Me.hintFiltroFecha = New System.Windows.Forms.Label()
        Me.cboxFiltroFecha = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvAvisos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelDetalleAviso.SuspendLayout()
        Me.panelProcesarAviso.SuspendLayout()
        Me.panelAvisos.SuspendLayout()
        CType(Me.dgvAvisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(1100, 508)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(135, 28)
        Me.btnEnviar.TabIndex = 18
        Me.btnEnviar.Text = "Procesar aviso"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(1017, 508)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 28)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(387, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(430, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "PROCESAR AVISOS DE ASIGNACIONES FAMILIARES"
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
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'panelDetalleAviso
        '
        Me.panelDetalleAviso.BackColor = System.Drawing.Color.White
        Me.panelDetalleAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDetalleAviso.Controls.Add(Me.Label5)
        Me.panelDetalleAviso.Controls.Add(Me.txtProyecto)
        Me.panelDetalleAviso.Controls.Add(Me.Label1)
        Me.panelDetalleAviso.Controls.Add(Me.txtEmpresa)
        Me.panelDetalleAviso.Controls.Add(Me.txtMatriculaTitular)
        Me.panelDetalleAviso.Controls.Add(Me.Label4)
        Me.panelDetalleAviso.Controls.Add(Me.txtTitular)
        Me.panelDetalleAviso.Controls.Add(Me.Label8)
        Me.panelDetalleAviso.Controls.Add(Me.Label10)
        Me.panelDetalleAviso.Controls.Add(Me.txtFechaExpiracion)
        Me.panelDetalleAviso.Controls.Add(Me.Label2)
        Me.panelDetalleAviso.Controls.Add(Me.txtBeneficiario)
        Me.panelDetalleAviso.Controls.Add(Me.Label6)
        Me.panelDetalleAviso.Location = New System.Drawing.Point(30, 301)
        Me.panelDetalleAviso.Name = "panelDetalleAviso"
        Me.panelDetalleAviso.Size = New System.Drawing.Size(632, 165)
        Me.panelDetalleAviso.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Proyecto"
        '
        'txtProyecto
        '
        Me.txtProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProyecto.Location = New System.Drawing.Point(411, 120)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.ReadOnly = True
        Me.txtProyecto.Size = New System.Drawing.Size(198, 21)
        Me.txtProyecto.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(341, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Empresa"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(410, 85)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.ReadOnly = True
        Me.txtEmpresa.Size = New System.Drawing.Size(199, 21)
        Me.txtEmpresa.TabIndex = 29
        '
        'txtMatriculaTitular
        '
        Me.txtMatriculaTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriculaTitular.Location = New System.Drawing.Point(97, 120)
        Me.txtMatriculaTitular.Name = "txtMatriculaTitular"
        Me.txtMatriculaTitular.ReadOnly = True
        Me.txtMatriculaTitular.Size = New System.Drawing.Size(113, 21)
        Me.txtMatriculaTitular.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Matrícula"
        '
        'txtTitular
        '
        Me.txtTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitular.Location = New System.Drawing.Point(97, 85)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.ReadOnly = True
        Me.txtTitular.Size = New System.Drawing.Size(176, 21)
        Me.txtTitular.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(49, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Titular"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(305, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Fec. expiración"
        '
        'txtFechaExpiracion
        '
        Me.txtFechaExpiracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaExpiracion.Location = New System.Drawing.Point(410, 50)
        Me.txtFechaExpiracion.Name = "txtFechaExpiracion"
        Me.txtFechaExpiracion.ReadOnly = True
        Me.txtFechaExpiracion.Size = New System.Drawing.Size(92, 21)
        Me.txtFechaExpiracion.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Beneficiario"
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(97, 50)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.ReadOnly = True
        Me.txtBeneficiario.Size = New System.Drawing.Size(176, 21)
        Me.txtBeneficiario.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(15, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "2.- Detalles de aviso"
        '
        'hintEstado
        '
        Me.hintEstado.AutoSize = True
        Me.hintEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintEstado.Location = New System.Drawing.Point(389, 57)
        Me.hintEstado.Name = "hintEstado"
        Me.hintEstado.Size = New System.Drawing.Size(82, 13)
        Me.hintEstado.TabIndex = 29
        Me.hintEstado.Text = "SELECCIONAR"
        '
        'cboxEstado
        '
        Me.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxEstado.FormattingEnabled = True
        Me.cboxEstado.Items.AddRange(New Object() {"ESPOSO/A", "HIJO/A", ""})
        Me.cboxEstado.Location = New System.Drawing.Point(384, 52)
        Me.cboxEstado.Name = "cboxEstado"
        Me.cboxEstado.Size = New System.Drawing.Size(146, 23)
        Me.cboxEstado.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(332, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Estado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Parentesco"
        '
        'txtCi
        '
        Me.txtCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCi.Location = New System.Drawing.Point(125, 87)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(175, 21)
        Me.txtCi.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(97, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 16)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "C.I."
        '
        'txtNombreEjecutor
        '
        Me.txtNombreEjecutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEjecutor.Location = New System.Drawing.Point(125, 52)
        Me.txtNombreEjecutor.Name = "txtNombreEjecutor"
        Me.txtNombreEjecutor.Size = New System.Drawing.Size(175, 21)
        Me.txtNombreEjecutor.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 16)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Nombre ejecutor"
        '
        'panelProcesarAviso
        '
        Me.panelProcesarAviso.BackColor = System.Drawing.Color.White
        Me.panelProcesarAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelProcesarAviso.Controls.Add(Me.hintParentesco)
        Me.panelProcesarAviso.Controls.Add(Me.cboxParentesco)
        Me.panelProcesarAviso.Controls.Add(Me.Label11)
        Me.panelProcesarAviso.Controls.Add(Me.Label25)
        Me.panelProcesarAviso.Controls.Add(Me.hintEstado)
        Me.panelProcesarAviso.Controls.Add(Me.txtCi)
        Me.panelProcesarAviso.Controls.Add(Me.Label9)
        Me.panelProcesarAviso.Controls.Add(Me.Label12)
        Me.panelProcesarAviso.Controls.Add(Me.cboxEstado)
        Me.panelProcesarAviso.Controls.Add(Me.txtNombreEjecutor)
        Me.panelProcesarAviso.Controls.Add(Me.Label13)
        Me.panelProcesarAviso.Location = New System.Drawing.Point(681, 301)
        Me.panelProcesarAviso.Name = "panelProcesarAviso"
        Me.panelProcesarAviso.Size = New System.Drawing.Size(554, 165)
        Me.panelProcesarAviso.TabIndex = 37
        '
        'hintParentesco
        '
        Me.hintParentesco.AutoSize = True
        Me.hintParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintParentesco.Location = New System.Drawing.Point(129, 125)
        Me.hintParentesco.Name = "hintParentesco"
        Me.hintParentesco.Size = New System.Drawing.Size(82, 13)
        Me.hintParentesco.TabIndex = 37
        Me.hintParentesco.Text = "SELECCIONAR"
        '
        'cboxParentesco
        '
        Me.cboxParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxParentesco.FormattingEnabled = True
        Me.cboxParentesco.Items.AddRange(New Object() {"ESPOSO/A", "HIJO/A", ""})
        Me.cboxParentesco.Location = New System.Drawing.Point(125, 120)
        Me.cboxParentesco.Name = "cboxParentesco"
        Me.cboxParentesco.Size = New System.Drawing.Size(175, 23)
        Me.cboxParentesco.TabIndex = 38
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(15, 15)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(147, 18)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "3.- Procesar aviso"
        '
        'panelAvisos
        '
        Me.panelAvisos.BackColor = System.Drawing.Color.White
        Me.panelAvisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAvisos.Controls.Add(Me.hintFiltroFecha)
        Me.panelAvisos.Controls.Add(Me.cboxFiltroFecha)
        Me.panelAvisos.Controls.Add(Me.Label15)
        Me.panelAvisos.Controls.Add(Me.dgvAvisos)
        Me.panelAvisos.Controls.Add(Me.Label7)
        Me.panelAvisos.Location = New System.Drawing.Point(30, 53)
        Me.panelAvisos.Name = "panelAvisos"
        Me.panelAvisos.Size = New System.Drawing.Size(971, 228)
        Me.panelAvisos.TabIndex = 38
        '
        'hintFiltroFecha
        '
        Me.hintFiltroFecha.AutoSize = True
        Me.hintFiltroFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintFiltroFecha.Location = New System.Drawing.Point(801, 68)
        Me.hintFiltroFecha.Name = "hintFiltroFecha"
        Me.hintFiltroFecha.Size = New System.Drawing.Size(82, 13)
        Me.hintFiltroFecha.TabIndex = 38
        Me.hintFiltroFecha.Text = "SELECCIONAR"
        '
        'cboxFiltroFecha
        '
        Me.cboxFiltroFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxFiltroFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFiltroFecha.FormattingEnabled = True
        Me.cboxFiltroFecha.Items.AddRange(New Object() {"ESPOSO/A", "HIJO/A", ""})
        Me.cboxFiltroFecha.Location = New System.Drawing.Point(796, 63)
        Me.cboxFiltroFecha.Name = "cboxFiltroFecha"
        Me.cboxFiltroFecha.Size = New System.Drawing.Size(155, 23)
        Me.cboxFiltroFecha.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(793, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Filtrar por fecha"
        '
        'dgvAvisos
        '
        Me.dgvAvisos.BackgroundColor = System.Drawing.Color.White
        Me.dgvAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvAvisos.Location = New System.Drawing.Point(18, 44)
        Me.dgvAvisos.Name = "dgvAvisos"
        Me.dgvAvisos.Size = New System.Drawing.Size(758, 156)
        Me.dgvAvisos.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "Beneficiario"
        Me.Column1.Name = "Column1"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Matricula Benficiario"
        Me.Column6.Name = "Column6"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Titular"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Matricula Titular"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha creación aviso"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Estado"
        Me.Column5.Name = "Column5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "1.- Lista de avisos"
        '
        'FormProcesarAvisosAsignacionesFamiliares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.panelAvisos)
        Me.Controls.Add(Me.panelProcesarAviso)
        Me.Controls.Add(Me.panelDetalleAviso)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormProcesarAvisosAsignacionesFamiliares"
        Me.Text = "FormProcesarAvisosAsignacionesFamiliares"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelDetalleAviso.ResumeLayout(False)
        Me.panelDetalleAviso.PerformLayout()
        Me.panelProcesarAviso.ResumeLayout(False)
        Me.panelProcesarAviso.PerformLayout()
        Me.panelAvisos.ResumeLayout(False)
        Me.panelAvisos.PerformLayout()
        CType(Me.dgvAvisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelDetalleAviso As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents hintEstado As System.Windows.Forms.Label
    Friend WithEvents cboxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFechaExpiracion As System.Windows.Forms.TextBox
    Friend WithEvents txtMatriculaTitular As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTitular As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNombreEjecutor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents panelProcesarAviso As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents panelAvisos As System.Windows.Forms.Panel
    Friend WithEvents hintFiltroFecha As System.Windows.Forms.Label
    Friend WithEvents cboxFiltroFecha As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgvAvisos As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents hintParentesco As System.Windows.Forms.Label
    Friend WithEvents cboxParentesco As System.Windows.Forms.ComboBox
End Class
