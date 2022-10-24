<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarKitEquipoLaboratorio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.panelDatosKitEquipo = New System.Windows.Forms.Panel()
        Me.btnRegistrarProveedor = New System.Windows.Forms.Button()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hintProveedor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxProveedor = New System.Windows.Forms.ComboBox()
        Me.hintTipo = New System.Windows.Forms.Label()
        Me.cboxTipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscarExamen = New System.Windows.Forms.TextBox()
        Me.hintExamen = New System.Windows.Forms.Label()
        Me.cboxExamen = New System.Windows.Forms.ComboBox()
        Me.btnBuscarExamen = New System.Windows.Forms.Button()
        Me.lblBuscarExamen = New System.Windows.Forms.Label()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.panelReferencias = New System.Windows.Forms.Panel()
        Me.chValoresAsignados = New System.Windows.Forms.CheckBox()
        Me.btnAsignarReferencias = New System.Windows.Forms.Button()
        Me.hintTipoReferencia = New System.Windows.Forms.Label()
        Me.cboxTipoReferencia = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.panelSeleccionarExamen = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.chPermiteReferencias = New System.Windows.Forms.CheckBox()
        Me.lblNombreArea = New System.Windows.Forms.Label()
        Me.txtTipoResultado = New System.Windows.Forms.TextBox()
        Me.lblNombreSubarea = New System.Windows.Forms.Label()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.lblTipoResultado = New System.Windows.Forms.Label()
        Me.txtNombreArea = New System.Windows.Forms.TextBox()
        Me.txtNombreSubarea = New System.Windows.Forms.TextBox()
        Me.panelDatosExamen = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelDatosKitEquipo.SuspendLayout()
        Me.panelReferencias.SuspendLayout()
        Me.panelSeleccionarExamen.SuspendLayout()
        Me.panelDatosExamen.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 37)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1068, 23)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(354, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(360, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR KIT-EQUIPO DE LABORATORIO"
        '
        'panelDatosKitEquipo
        '
        Me.panelDatosKitEquipo.BackColor = System.Drawing.Color.White
        Me.panelDatosKitEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosKitEquipo.Controls.Add(Me.btnRegistrarProveedor)
        Me.panelDatosKitEquipo.Controls.Add(Me.txtModelo)
        Me.panelDatosKitEquipo.Controls.Add(Me.Label3)
        Me.panelDatosKitEquipo.Controls.Add(Me.hintProveedor)
        Me.panelDatosKitEquipo.Controls.Add(Me.Label1)
        Me.panelDatosKitEquipo.Controls.Add(Me.cboxProveedor)
        Me.panelDatosKitEquipo.Controls.Add(Me.hintTipo)
        Me.panelDatosKitEquipo.Controls.Add(Me.cboxTipo)
        Me.panelDatosKitEquipo.Controls.Add(Me.Label6)
        Me.panelDatosKitEquipo.Controls.Add(Me.Label2)
        Me.panelDatosKitEquipo.Location = New System.Drawing.Point(30, 76)
        Me.panelDatosKitEquipo.Name = "panelDatosKitEquipo"
        Me.panelDatosKitEquipo.Size = New System.Drawing.Size(331, 187)
        Me.panelDatosKitEquipo.TabIndex = 11
        '
        'btnRegistrarProveedor
        '
        Me.btnRegistrarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarProveedor.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarProveedor.Location = New System.Drawing.Point(16, 115)
        Me.btnRegistrarProveedor.Name = "btnRegistrarProveedor"
        Me.btnRegistrarProveedor.Size = New System.Drawing.Size(299, 25)
        Me.btnRegistrarProveedor.TabIndex = 76
        Me.btnRegistrarProveedor.Text = "Registrar nuevo proveedor"
        Me.btnRegistrarProveedor.UseVisualStyleBackColor = False
        '
        'txtModelo
        '
        Me.txtModelo.AcceptsReturn = True
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(136, 150)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(177, 21)
        Me.txtModelo.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Modelo"
        '
        'hintProveedor
        '
        Me.hintProveedor.AutoSize = True
        Me.hintProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintProveedor.Location = New System.Drawing.Point(140, 90)
        Me.hintProveedor.Name = "hintProveedor"
        Me.hintProveedor.Size = New System.Drawing.Size(82, 13)
        Me.hintProveedor.TabIndex = 30
        Me.hintProveedor.Text = "SELECCIONAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Proveedor / Marca"
        '
        'cboxProveedor
        '
        Me.cboxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxProveedor.FormattingEnabled = True
        Me.cboxProveedor.Location = New System.Drawing.Point(135, 85)
        Me.cboxProveedor.Name = "cboxProveedor"
        Me.cboxProveedor.Size = New System.Drawing.Size(180, 23)
        Me.cboxProveedor.TabIndex = 31
        '
        'hintTipo
        '
        Me.hintTipo.AutoSize = True
        Me.hintTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTipo.Location = New System.Drawing.Point(141, 56)
        Me.hintTipo.Name = "hintTipo"
        Me.hintTipo.Size = New System.Drawing.Size(82, 13)
        Me.hintTipo.TabIndex = 25
        Me.hintTipo.Text = "SELECCIONAR"
        '
        'cboxTipo
        '
        Me.cboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTipo.FormattingEnabled = True
        Me.cboxTipo.Location = New System.Drawing.Point(135, 50)
        Me.cboxTipo.Name = "cboxTipo"
        Me.cboxTipo.Size = New System.Drawing.Size(180, 23)
        Me.cboxTipo.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(99, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "1.- Datos de kit-equipo"
        '
        'txtBuscarExamen
        '
        Me.txtBuscarExamen.AcceptsReturn = True
        Me.txtBuscarExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarExamen.Location = New System.Drawing.Point(82, 45)
        Me.txtBuscarExamen.Name = "txtBuscarExamen"
        Me.txtBuscarExamen.Size = New System.Drawing.Size(126, 21)
        Me.txtBuscarExamen.TabIndex = 74
        '
        'hintExamen
        '
        Me.hintExamen.AutoSize = True
        Me.hintExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintExamen.Location = New System.Drawing.Point(26, 85)
        Me.hintExamen.Name = "hintExamen"
        Me.hintExamen.Size = New System.Drawing.Size(82, 13)
        Me.hintExamen.TabIndex = 76
        Me.hintExamen.Text = "SELECCIONAR"
        '
        'cboxExamen
        '
        Me.cboxExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxExamen.FormattingEnabled = True
        Me.cboxExamen.Location = New System.Drawing.Point(18, 80)
        Me.cboxExamen.Name = "cboxExamen"
        Me.cboxExamen.Size = New System.Drawing.Size(254, 23)
        Me.cboxExamen.TabIndex = 77
        '
        'btnBuscarExamen
        '
        Me.btnBuscarExamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarExamen.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarExamen.Location = New System.Drawing.Point(214, 45)
        Me.btnBuscarExamen.Name = "btnBuscarExamen"
        Me.btnBuscarExamen.Size = New System.Drawing.Size(58, 25)
        Me.btnBuscarExamen.TabIndex = 75
        Me.btnBuscarExamen.Text = "Buscar"
        Me.btnBuscarExamen.UseVisualStyleBackColor = False
        '
        'lblBuscarExamen
        '
        Me.lblBuscarExamen.AutoSize = True
        Me.lblBuscarExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarExamen.Location = New System.Drawing.Point(18, 45)
        Me.lblBuscarExamen.Name = "lblBuscarExamen"
        Me.lblBuscarExamen.Size = New System.Drawing.Size(56, 16)
        Me.lblBuscarExamen.TabIndex = 29
        Me.lblBuscarExamen.Text = "Examen"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarDatos.Location = New System.Drawing.Point(987, 415)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(111, 28)
        Me.btnEnviarDatos.TabIndex = 8
        Me.btnEnviarDatos.Text = "Registrar kit"
        Me.btnEnviarDatos.UseVisualStyleBackColor = False
        '
        'panelReferencias
        '
        Me.panelReferencias.BackColor = System.Drawing.Color.White
        Me.panelReferencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelReferencias.Controls.Add(Me.chValoresAsignados)
        Me.panelReferencias.Controls.Add(Me.btnAsignarReferencias)
        Me.panelReferencias.Controls.Add(Me.hintTipoReferencia)
        Me.panelReferencias.Controls.Add(Me.cboxTipoReferencia)
        Me.panelReferencias.Controls.Add(Me.Label15)
        Me.panelReferencias.Controls.Add(Me.Label22)
        Me.panelReferencias.Location = New System.Drawing.Point(30, 287)
        Me.panelReferencias.Name = "panelReferencias"
        Me.panelReferencias.Size = New System.Drawing.Size(491, 133)
        Me.panelReferencias.TabIndex = 71
        '
        'chValoresAsignados
        '
        Me.chValoresAsignados.AutoSize = True
        Me.chValoresAsignados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chValoresAsignados.Location = New System.Drawing.Point(344, 99)
        Me.chValoresAsignados.Name = "chValoresAsignados"
        Me.chValoresAsignados.Size = New System.Drawing.Size(140, 20)
        Me.chValoresAsignados.TabIndex = 77
        Me.chValoresAsignados.Text = "Valores asignados"
        Me.chValoresAsignados.UseVisualStyleBackColor = True
        '
        'btnAsignarReferencias
        '
        Me.btnAsignarReferencias.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAsignarReferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarReferencias.ForeColor = System.Drawing.Color.Black
        Me.btnAsignarReferencias.Location = New System.Drawing.Point(16, 94)
        Me.btnAsignarReferencias.Name = "btnAsignarReferencias"
        Me.btnAsignarReferencias.Size = New System.Drawing.Size(309, 25)
        Me.btnAsignarReferencias.TabIndex = 74
        Me.btnAsignarReferencias.Text = "Asignar valores referencia"
        Me.btnAsignarReferencias.UseVisualStyleBackColor = False
        '
        'hintTipoReferencia
        '
        Me.hintTipoReferencia.AutoSize = True
        Me.hintTipoReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTipoReferencia.Location = New System.Drawing.Point(23, 70)
        Me.hintTipoReferencia.Name = "hintTipoReferencia"
        Me.hintTipoReferencia.Size = New System.Drawing.Size(82, 13)
        Me.hintTipoReferencia.TabIndex = 72
        Me.hintTipoReferencia.Text = "SELECCIONAR"
        '
        'cboxTipoReferencia
        '
        Me.cboxTipoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTipoReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTipoReferencia.FormattingEnabled = True
        Me.cboxTipoReferencia.Location = New System.Drawing.Point(18, 65)
        Me.cboxTipoReferencia.Name = "cboxTipoReferencia"
        Me.cboxTipoReferencia.Size = New System.Drawing.Size(307, 23)
        Me.cboxTipoReferencia.TabIndex = 73
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 16)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Tipo de referencia"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(15, 15)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(241, 18)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "4.- Datos valores de referencia"
        '
        'panelSeleccionarExamen
        '
        Me.panelSeleccionarExamen.BackColor = System.Drawing.Color.White
        Me.panelSeleccionarExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelSeleccionarExamen.Controls.Add(Me.txtBuscarExamen)
        Me.panelSeleccionarExamen.Controls.Add(Me.hintExamen)
        Me.panelSeleccionarExamen.Controls.Add(Me.cboxExamen)
        Me.panelSeleccionarExamen.Controls.Add(Me.btnBuscarExamen)
        Me.panelSeleccionarExamen.Controls.Add(Me.lblBuscarExamen)
        Me.panelSeleccionarExamen.Controls.Add(Me.Label9)
        Me.panelSeleccionarExamen.Location = New System.Drawing.Point(377, 76)
        Me.panelSeleccionarExamen.Name = "panelSeleccionarExamen"
        Me.panelSeleccionarExamen.Size = New System.Drawing.Size(292, 141)
        Me.panelSeleccionarExamen.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(15, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "2.- Seleccionar examen"
        '
        'txtUnidad
        '
        Me.txtUnidad.AcceptsReturn = True
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(134, 114)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(259, 21)
        Me.txtUnidad.TabIndex = 91
        '
        'chPermiteReferencias
        '
        Me.chPermiteReferencias.AutoSize = True
        Me.chPermiteReferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chPermiteReferencias.Location = New System.Drawing.Point(251, 15)
        Me.chPermiteReferencias.Name = "chPermiteReferencias"
        Me.chPermiteReferencias.Size = New System.Drawing.Size(142, 20)
        Me.chPermiteReferencias.TabIndex = 84
        Me.chPermiteReferencias.Text = "Permite referencias"
        Me.chPermiteReferencias.UseVisualStyleBackColor = True
        '
        'lblNombreArea
        '
        Me.lblNombreArea.AutoSize = True
        Me.lblNombreArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreArea.Location = New System.Drawing.Point(92, 45)
        Me.lblNombreArea.Name = "lblNombreArea"
        Me.lblNombreArea.Size = New System.Drawing.Size(36, 16)
        Me.lblNombreArea.TabIndex = 83
        Me.lblNombreArea.Text = "Area"
        '
        'txtTipoResultado
        '
        Me.txtTipoResultado.AcceptsReturn = True
        Me.txtTipoResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoResultado.Location = New System.Drawing.Point(134, 147)
        Me.txtTipoResultado.Name = "txtTipoResultado"
        Me.txtTipoResultado.Size = New System.Drawing.Size(259, 21)
        Me.txtTipoResultado.TabIndex = 90
        '
        'lblNombreSubarea
        '
        Me.lblNombreSubarea.AutoSize = True
        Me.lblNombreSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreSubarea.Location = New System.Drawing.Point(69, 80)
        Me.lblNombreSubarea.Name = "lblNombreSubarea"
        Me.lblNombreSubarea.Size = New System.Drawing.Size(59, 16)
        Me.lblNombreSubarea.TabIndex = 82
        Me.lblNombreSubarea.Text = "Subarea"
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidad.Location = New System.Drawing.Point(77, 114)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(51, 16)
        Me.lblUnidad.TabIndex = 89
        Me.lblUnidad.Text = "Unidad"
        '
        'lblTipoResultado
        '
        Me.lblTipoResultado.AutoSize = True
        Me.lblTipoResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoResultado.Location = New System.Drawing.Point(15, 147)
        Me.lblTipoResultado.Name = "lblTipoResultado"
        Me.lblTipoResultado.Size = New System.Drawing.Size(113, 16)
        Me.lblTipoResultado.TabIndex = 88
        Me.lblTipoResultado.Text = "Tipo de resultado"
        '
        'txtNombreArea
        '
        Me.txtNombreArea.AcceptsReturn = True
        Me.txtNombreArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreArea.Location = New System.Drawing.Point(134, 45)
        Me.txtNombreArea.Name = "txtNombreArea"
        Me.txtNombreArea.Size = New System.Drawing.Size(259, 21)
        Me.txtNombreArea.TabIndex = 86
        '
        'txtNombreSubarea
        '
        Me.txtNombreSubarea.AcceptsReturn = True
        Me.txtNombreSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSubarea.Location = New System.Drawing.Point(134, 80)
        Me.txtNombreSubarea.Name = "txtNombreSubarea"
        Me.txtNombreSubarea.Size = New System.Drawing.Size(259, 21)
        Me.txtNombreSubarea.TabIndex = 87
        '
        'panelDatosExamen
        '
        Me.panelDatosExamen.BackColor = System.Drawing.Color.White
        Me.panelDatosExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosExamen.Controls.Add(Me.Label10)
        Me.panelDatosExamen.Controls.Add(Me.txtUnidad)
        Me.panelDatosExamen.Controls.Add(Me.chPermiteReferencias)
        Me.panelDatosExamen.Controls.Add(Me.txtNombreSubarea)
        Me.panelDatosExamen.Controls.Add(Me.txtNombreArea)
        Me.panelDatosExamen.Controls.Add(Me.lblNombreSubarea)
        Me.panelDatosExamen.Controls.Add(Me.lblNombreArea)
        Me.panelDatosExamen.Controls.Add(Me.txtTipoResultado)
        Me.panelDatosExamen.Controls.Add(Me.lblTipoResultado)
        Me.panelDatosExamen.Controls.Add(Me.lblUnidad)
        Me.panelDatosExamen.Location = New System.Drawing.Point(686, 76)
        Me.panelDatosExamen.Name = "panelDatosExamen"
        Me.panelDatosExamen.Size = New System.Drawing.Size(412, 187)
        Me.panelDatosExamen.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(15, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "3.- Datos del examen"
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1129, 24)
        Me.menuStrip.TabIndex = 75
        Me.menuStrip.Text = "MenuStrip1"
        '
        'menuStripMenu
        '
        Me.menuStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenuLaboratorio})
        Me.menuStripMenu.Name = "menuStripMenu"
        Me.menuStripMenu.Size = New System.Drawing.Size(50, 20)
        Me.menuStripMenu.Text = "Menu"
        '
        'menuStripMenuLaboratorio
        '
        Me.menuStripMenuLaboratorio.Name = "menuStripMenuLaboratorio"
        Me.menuStripMenuLaboratorio.Size = New System.Drawing.Size(180, 22)
        Me.menuStripMenuLaboratorio.Text = "Menu laboratorio"
        '
        'FormRegistrarKitEquipoLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1129, 465)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.panelDatosExamen)
        Me.Controls.Add(Me.panelSeleccionarExamen)
        Me.Controls.Add(Me.panelReferencias)
        Me.Controls.Add(Me.panelDatosKitEquipo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Name = "FormRegistrarKitEquipoLaboratorio"
        Me.Text = "Registrar kit-equipo de laboratorio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelDatosKitEquipo.ResumeLayout(False)
        Me.panelDatosKitEquipo.PerformLayout()
        Me.panelReferencias.ResumeLayout(False)
        Me.panelReferencias.PerformLayout()
        Me.panelSeleccionarExamen.ResumeLayout(False)
        Me.panelSeleccionarExamen.PerformLayout()
        Me.panelDatosExamen.ResumeLayout(False)
        Me.panelDatosExamen.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents panelDatosKitEquipo As Panel
    Friend WithEvents btnEnviarDatos As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents hintTipo As Label
    Friend WithEvents cboxTipo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents panelReferencias As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents btnAsignarReferencias As Button
    Friend WithEvents hintTipoReferencia As Label
    Friend WithEvents cboxTipoReferencia As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents panelSeleccionarExamen As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents chPermiteReferencias As CheckBox
    Friend WithEvents lblNombreArea As Label
    Friend WithEvents txtTipoResultado As TextBox
    Friend WithEvents lblNombreSubarea As Label
    Friend WithEvents lblUnidad As Label
    Friend WithEvents lblTipoResultado As Label
    Friend WithEvents txtNombreArea As TextBox
    Friend WithEvents txtNombreSubarea As TextBox
    Friend WithEvents txtBuscarExamen As TextBox
    Friend WithEvents hintExamen As Label
    Friend WithEvents cboxExamen As ComboBox
    Friend WithEvents btnBuscarExamen As Button
    Friend WithEvents lblBuscarExamen As Label
    Friend WithEvents chValoresAsignados As CheckBox
    Friend WithEvents panelDatosExamen As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents hintProveedor As Label
    Friend WithEvents cboxProveedor As ComboBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegistrarProveedor As Button
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
