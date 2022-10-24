<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarExamenLaboratorio
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
        Me.Label26 = New System.Windows.Forms.Label()
        Me.panelResultado1 = New System.Windows.Forms.Panel()
        Me.chKitEquipoAsignado = New System.Windows.Forms.CheckBox()
        Me.txtTipoReferencia = New System.Windows.Forms.TextBox()
        Me.lblNombreTipoReferencia = New System.Windows.Forms.Label()
        Me.txtKitEquipo = New System.Windows.Forms.TextBox()
        Me.lblNombreKitEquipo = New System.Windows.Forms.Label()
        Me.btnRegistrarKitEquipo = New System.Windows.Forms.Button()
        Me.cboxArea = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hintArea = New System.Windows.Forms.Label()
        Me.txtNombreExamen = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboxSubarea = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRegistrarArea = New System.Windows.Forms.Button()
        Me.hintSubarea = New System.Windows.Forms.Label()
        Me.btnRegistrarSubarea = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxTipoResultado = New System.Windows.Forms.ComboBox()
        Me.hintTipoResultado = New System.Windows.Forms.Label()
        Me.panelDatosExamen = New System.Windows.Forms.Panel()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.panelDatosUnidad = New System.Windows.Forms.Panel()
        Me.btnBuscarUnidad = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hintUnidadMedida = New System.Windows.Forms.Label()
        Me.txtBuscarUnidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboxUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.btnRegistrarUnidadMedida = New System.Windows.Forms.Button()
        Me.panelResultado2 = New System.Windows.Forms.Panel()
        Me.dgvOpciones = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscarConjunto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hintConjunto = New System.Windows.Forms.Label()
        Me.txtBuscarConjunto = New System.Windows.Forms.TextBox()
        Me.cboxConjunto = New System.Windows.Forms.ComboBox()
        Me.btnRegistrarConjunto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelResultado1.SuspendLayout()
        Me.panelDatosExamen.SuspendLayout()
        Me.panelDatosUnidad.SuspendLayout()
        Me.panelResultado2.SuspendLayout()
        CType(Me.dgvOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 35)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1204, 23)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(434, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(335, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR EXAMEN DE LABORATORIO"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(15, 15)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(184, 18)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "3.- Datos del kit-equipo"
        '
        'panelResultado1
        '
        Me.panelResultado1.BackColor = System.Drawing.Color.White
        Me.panelResultado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelResultado1.Controls.Add(Me.chKitEquipoAsignado)
        Me.panelResultado1.Controls.Add(Me.txtTipoReferencia)
        Me.panelResultado1.Controls.Add(Me.lblNombreTipoReferencia)
        Me.panelResultado1.Controls.Add(Me.txtKitEquipo)
        Me.panelResultado1.Controls.Add(Me.lblNombreKitEquipo)
        Me.panelResultado1.Controls.Add(Me.btnRegistrarKitEquipo)
        Me.panelResultado1.Controls.Add(Me.Label26)
        Me.panelResultado1.Location = New System.Drawing.Point(30, 260)
        Me.panelResultado1.Name = "panelResultado1"
        Me.panelResultado1.Size = New System.Drawing.Size(518, 154)
        Me.panelResultado1.TabIndex = 11
        '
        'chKitEquipoAsignado
        '
        Me.chKitEquipoAsignado.AutoSize = True
        Me.chKitEquipoAsignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chKitEquipoAsignado.Location = New System.Drawing.Point(355, 117)
        Me.chKitEquipoAsignado.Name = "chKitEquipoAsignado"
        Me.chKitEquipoAsignado.Size = New System.Drawing.Size(146, 20)
        Me.chKitEquipoAsignado.TabIndex = 98
        Me.chKitEquipoAsignado.Text = "Kit-equipo asignado"
        Me.chKitEquipoAsignado.UseVisualStyleBackColor = True
        '
        'txtTipoReferencia
        '
        Me.txtTipoReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoReferencia.Location = New System.Drawing.Point(166, 80)
        Me.txtTipoReferencia.Name = "txtTipoReferencia"
        Me.txtTipoReferencia.Size = New System.Drawing.Size(335, 21)
        Me.txtTipoReferencia.TabIndex = 97
        '
        'lblNombreTipoReferencia
        '
        Me.lblNombreTipoReferencia.AutoSize = True
        Me.lblNombreTipoReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTipoReferencia.Location = New System.Drawing.Point(38, 80)
        Me.lblNombreTipoReferencia.Name = "lblNombreTipoReferencia"
        Me.lblNombreTipoReferencia.Size = New System.Drawing.Size(117, 16)
        Me.lblNombreTipoReferencia.TabIndex = 96
        Me.lblNombreTipoReferencia.Text = "Tipo de referencia"
        '
        'txtKitEquipo
        '
        Me.txtKitEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKitEquipo.Location = New System.Drawing.Point(166, 44)
        Me.txtKitEquipo.Name = "txtKitEquipo"
        Me.txtKitEquipo.Size = New System.Drawing.Size(335, 21)
        Me.txtKitEquipo.TabIndex = 95
        '
        'lblNombreKitEquipo
        '
        Me.lblNombreKitEquipo.AutoSize = True
        Me.lblNombreKitEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreKitEquipo.Location = New System.Drawing.Point(15, 44)
        Me.lblNombreKitEquipo.Name = "lblNombreKitEquipo"
        Me.lblNombreKitEquipo.Size = New System.Drawing.Size(140, 16)
        Me.lblNombreKitEquipo.TabIndex = 94
        Me.lblNombreKitEquipo.Text = "Nombre del kit-equipo"
        '
        'btnRegistrarKitEquipo
        '
        Me.btnRegistrarKitEquipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarKitEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarKitEquipo.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarKitEquipo.Location = New System.Drawing.Point(165, 117)
        Me.btnRegistrarKitEquipo.Name = "btnRegistrarKitEquipo"
        Me.btnRegistrarKitEquipo.Size = New System.Drawing.Size(184, 25)
        Me.btnRegistrarKitEquipo.TabIndex = 92
        Me.btnRegistrarKitEquipo.Text = "Registrar nuevo kit-equipo"
        Me.btnRegistrarKitEquipo.UseVisualStyleBackColor = False
        '
        'cboxArea
        '
        Me.cboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxArea.FormattingEnabled = True
        Me.cboxArea.Items.AddRange(New Object() {"SC", "LP", "CO", "BE", "PA", "OR", "PO", "CH", "TA"})
        Me.cboxArea.Location = New System.Drawing.Point(80, 45)
        Me.cboxArea.Name = "cboxArea"
        Me.cboxArea.Size = New System.Drawing.Size(262, 23)
        Me.cboxArea.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Area"
        '
        'hintArea
        '
        Me.hintArea.AutoSize = True
        Me.hintArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintArea.Location = New System.Drawing.Point(85, 50)
        Me.hintArea.Name = "hintArea"
        Me.hintArea.Size = New System.Drawing.Size(82, 13)
        Me.hintArea.TabIndex = 19
        Me.hintArea.Text = "SELECCIONAR"
        '
        'txtNombreExamen
        '
        Me.txtNombreExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreExamen.Location = New System.Drawing.Point(80, 115)
        Me.txtNombreExamen.Name = "txtNombreExamen"
        Me.txtNombreExamen.Size = New System.Drawing.Size(386, 21)
        Me.txtNombreExamen.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Subarea"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nombre"
        '
        'cboxSubarea
        '
        Me.cboxSubarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxSubarea.FormattingEnabled = True
        Me.cboxSubarea.Location = New System.Drawing.Point(80, 80)
        Me.cboxSubarea.Name = "cboxSubarea"
        Me.cboxSubarea.Size = New System.Drawing.Size(261, 23)
        Me.cboxSubarea.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "1.- Datos del examen"
        '
        'btnRegistrarArea
        '
        Me.btnRegistrarArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarArea.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarArea.Location = New System.Drawing.Point(348, 45)
        Me.btnRegistrarArea.Name = "btnRegistrarArea"
        Me.btnRegistrarArea.Size = New System.Drawing.Size(118, 25)
        Me.btnRegistrarArea.TabIndex = 11
        Me.btnRegistrarArea.Text = "Registrar area"
        Me.btnRegistrarArea.UseVisualStyleBackColor = False
        '
        'hintSubarea
        '
        Me.hintSubarea.AutoSize = True
        Me.hintSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintSubarea.Location = New System.Drawing.Point(85, 85)
        Me.hintSubarea.Name = "hintSubarea"
        Me.hintSubarea.Size = New System.Drawing.Size(82, 13)
        Me.hintSubarea.TabIndex = 22
        Me.hintSubarea.Text = "SELECCIONAR"
        '
        'btnRegistrarSubarea
        '
        Me.btnRegistrarSubarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarSubarea.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarSubarea.Location = New System.Drawing.Point(347, 80)
        Me.btnRegistrarSubarea.Name = "btnRegistrarSubarea"
        Me.btnRegistrarSubarea.Size = New System.Drawing.Size(119, 25)
        Me.btnRegistrarSubarea.TabIndex = 12
        Me.btnRegistrarSubarea.Text = "Registrar subarea"
        Me.btnRegistrarSubarea.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(479, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Tipo de resultado"
        '
        'cboxTipoResultado
        '
        Me.cboxTipoResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTipoResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTipoResultado.FormattingEnabled = True
        Me.cboxTipoResultado.Items.AddRange(New Object() {"SC", "LP", "CO", "BE", "PA", "OR", "PO", "CH", "TA"})
        Me.cboxTipoResultado.Location = New System.Drawing.Point(595, 45)
        Me.cboxTipoResultado.Name = "cboxTipoResultado"
        Me.cboxTipoResultado.Size = New System.Drawing.Size(209, 23)
        Me.cboxTipoResultado.TabIndex = 37
        '
        'hintTipoResultado
        '
        Me.hintTipoResultado.AutoSize = True
        Me.hintTipoResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTipoResultado.Location = New System.Drawing.Point(598, 50)
        Me.hintTipoResultado.Name = "hintTipoResultado"
        Me.hintTipoResultado.Size = New System.Drawing.Size(82, 13)
        Me.hintTipoResultado.TabIndex = 36
        Me.hintTipoResultado.Text = "SELECCIONAR"
        '
        'panelDatosExamen
        '
        Me.panelDatosExamen.BackColor = System.Drawing.Color.White
        Me.panelDatosExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosExamen.Controls.Add(Me.hintTipoResultado)
        Me.panelDatosExamen.Controls.Add(Me.cboxTipoResultado)
        Me.panelDatosExamen.Controls.Add(Me.Label3)
        Me.panelDatosExamen.Controls.Add(Me.btnRegistrarSubarea)
        Me.panelDatosExamen.Controls.Add(Me.hintSubarea)
        Me.panelDatosExamen.Controls.Add(Me.btnRegistrarArea)
        Me.panelDatosExamen.Controls.Add(Me.Label8)
        Me.panelDatosExamen.Controls.Add(Me.cboxSubarea)
        Me.panelDatosExamen.Controls.Add(Me.Label7)
        Me.panelDatosExamen.Controls.Add(Me.Label10)
        Me.panelDatosExamen.Controls.Add(Me.txtNombreExamen)
        Me.panelDatosExamen.Controls.Add(Me.hintArea)
        Me.panelDatosExamen.Controls.Add(Me.Label6)
        Me.panelDatosExamen.Controls.Add(Me.cboxArea)
        Me.panelDatosExamen.Location = New System.Drawing.Point(30, 65)
        Me.panelDatosExamen.Name = "panelDatosExamen"
        Me.panelDatosExamen.Size = New System.Drawing.Size(820, 162)
        Me.panelDatosExamen.TabIndex = 10
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarDatos.Location = New System.Drawing.Point(1092, 508)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(142, 25)
        Me.btnEnviarDatos.TabIndex = 8
        Me.btnEnviarDatos.Text = "Registrar examen"
        Me.btnEnviarDatos.UseVisualStyleBackColor = False
        '
        'panelDatosUnidad
        '
        Me.panelDatosUnidad.BackColor = System.Drawing.Color.White
        Me.panelDatosUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosUnidad.Controls.Add(Me.btnBuscarUnidad)
        Me.panelDatosUnidad.Controls.Add(Me.Label4)
        Me.panelDatosUnidad.Controls.Add(Me.hintUnidadMedida)
        Me.panelDatosUnidad.Controls.Add(Me.txtBuscarUnidad)
        Me.panelDatosUnidad.Controls.Add(Me.Label16)
        Me.panelDatosUnidad.Controls.Add(Me.cboxUnidadMedida)
        Me.panelDatosUnidad.Controls.Add(Me.btnRegistrarUnidadMedida)
        Me.panelDatosUnidad.Location = New System.Drawing.Point(869, 65)
        Me.panelDatosUnidad.Name = "panelDatosUnidad"
        Me.panelDatosUnidad.Size = New System.Drawing.Size(365, 162)
        Me.panelDatosUnidad.TabIndex = 12
        '
        'btnBuscarUnidad
        '
        Me.btnBuscarUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarUnidad.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarUnidad.Location = New System.Drawing.Point(285, 45)
        Me.btnBuscarUnidad.Name = "btnBuscarUnidad"
        Me.btnBuscarUnidad.Size = New System.Drawing.Size(65, 25)
        Me.btnBuscarUnidad.TabIndex = 93
        Me.btnBuscarUnidad.Text = "Buscar"
        Me.btnBuscarUnidad.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Buscar unidad"
        '
        'hintUnidadMedida
        '
        Me.hintUnidadMedida.AutoSize = True
        Me.hintUnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintUnidadMedida.Location = New System.Drawing.Point(23, 85)
        Me.hintUnidadMedida.Name = "hintUnidadMedida"
        Me.hintUnidadMedida.Size = New System.Drawing.Size(82, 13)
        Me.hintUnidadMedida.TabIndex = 75
        Me.hintUnidadMedida.Text = "SELECCIONAR"
        '
        'txtBuscarUnidad
        '
        Me.txtBuscarUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarUnidad.Location = New System.Drawing.Point(119, 45)
        Me.txtBuscarUnidad.Name = "txtBuscarUnidad"
        Me.txtBuscarUnidad.Size = New System.Drawing.Size(160, 21)
        Me.txtBuscarUnidad.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(15, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(191, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "2.- Datos unidad medida"
        '
        'cboxUnidadMedida
        '
        Me.cboxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxUnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxUnidadMedida.FormattingEnabled = True
        Me.cboxUnidadMedida.Location = New System.Drawing.Point(18, 80)
        Me.cboxUnidadMedida.Name = "cboxUnidadMedida"
        Me.cboxUnidadMedida.Size = New System.Drawing.Size(332, 23)
        Me.cboxUnidadMedida.TabIndex = 74
        '
        'btnRegistrarUnidadMedida
        '
        Me.btnRegistrarUnidadMedida.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarUnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarUnidadMedida.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarUnidadMedida.Location = New System.Drawing.Point(18, 113)
        Me.btnRegistrarUnidadMedida.Name = "btnRegistrarUnidadMedida"
        Me.btnRegistrarUnidadMedida.Size = New System.Drawing.Size(332, 25)
        Me.btnRegistrarUnidadMedida.TabIndex = 73
        Me.btnRegistrarUnidadMedida.Text = "Registrar nueva unidad"
        Me.btnRegistrarUnidadMedida.UseVisualStyleBackColor = False
        '
        'panelResultado2
        '
        Me.panelResultado2.BackColor = System.Drawing.Color.White
        Me.panelResultado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelResultado2.Controls.Add(Me.dgvOpciones)
        Me.panelResultado2.Controls.Add(Me.btnBuscarConjunto)
        Me.panelResultado2.Controls.Add(Me.Label1)
        Me.panelResultado2.Controls.Add(Me.hintConjunto)
        Me.panelResultado2.Controls.Add(Me.txtBuscarConjunto)
        Me.panelResultado2.Controls.Add(Me.cboxConjunto)
        Me.panelResultado2.Controls.Add(Me.btnRegistrarConjunto)
        Me.panelResultado2.Controls.Add(Me.Label5)
        Me.panelResultado2.Location = New System.Drawing.Point(30, 260)
        Me.panelResultado2.Name = "panelResultado2"
        Me.panelResultado2.Size = New System.Drawing.Size(680, 274)
        Me.panelResultado2.TabIndex = 13
        '
        'dgvOpciones
        '
        Me.dgvOpciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOpciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOpciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvOpciones.Location = New System.Drawing.Point(337, 45)
        Me.dgvOpciones.Name = "dgvOpciones"
        Me.dgvOpciones.Size = New System.Drawing.Size(323, 210)
        Me.dgvOpciones.TabIndex = 100
        '
        'Column1
        '
        Me.Column1.HeaderText = "OPCION"
        Me.Column1.Name = "Column1"
        '
        'btnBuscarConjunto
        '
        Me.btnBuscarConjunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarConjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarConjunto.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarConjunto.Location = New System.Drawing.Point(254, 63)
        Me.btnBuscarConjunto.Name = "btnBuscarConjunto"
        Me.btnBuscarConjunto.Size = New System.Drawing.Size(65, 25)
        Me.btnBuscarConjunto.TabIndex = 99
        Me.btnBuscarConjunto.Text = "Buscar"
        Me.btnBuscarConjunto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Buscar conjunto de opciones"
        '
        'hintConjunto
        '
        Me.hintConjunto.AutoSize = True
        Me.hintConjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintConjunto.Location = New System.Drawing.Point(19, 99)
        Me.hintConjunto.Name = "hintConjunto"
        Me.hintConjunto.Size = New System.Drawing.Size(82, 13)
        Me.hintConjunto.TabIndex = 98
        Me.hintConjunto.Text = "SELECCIONAR"
        '
        'txtBuscarConjunto
        '
        Me.txtBuscarConjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarConjunto.Location = New System.Drawing.Point(18, 65)
        Me.txtBuscarConjunto.Name = "txtBuscarConjunto"
        Me.txtBuscarConjunto.Size = New System.Drawing.Size(230, 21)
        Me.txtBuscarConjunto.TabIndex = 95
        '
        'cboxConjunto
        '
        Me.cboxConjunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxConjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxConjunto.FormattingEnabled = True
        Me.cboxConjunto.Location = New System.Drawing.Point(15, 95)
        Me.cboxConjunto.Name = "cboxConjunto"
        Me.cboxConjunto.Size = New System.Drawing.Size(304, 23)
        Me.cboxConjunto.TabIndex = 97
        '
        'btnRegistrarConjunto
        '
        Me.btnRegistrarConjunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarConjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarConjunto.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarConjunto.Location = New System.Drawing.Point(14, 125)
        Me.btnRegistrarConjunto.Name = "btnRegistrarConjunto"
        Me.btnRegistrarConjunto.Size = New System.Drawing.Size(305, 25)
        Me.btnRegistrarConjunto.TabIndex = 96
        Me.btnRegistrarConjunto.Text = "Registrar nueva conjunto de opciones"
        Me.btnRegistrarConjunto.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(15, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(387, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "2.- Seleccionar conjunto de opciones de resultado"
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1264, 24)
        Me.menuStrip.TabIndex = 17
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
        'FormRegistrarExamenLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.panelResultado2)
        Me.Controls.Add(Me.panelDatosUnidad)
        Me.Controls.Add(Me.panelResultado1)
        Me.Controls.Add(Me.panelDatosExamen)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Name = "FormRegistrarExamenLaboratorio"
        Me.Text = "Registrar examen de laboratorio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelResultado1.ResumeLayout(False)
        Me.panelResultado1.PerformLayout()
        Me.panelDatosExamen.ResumeLayout(False)
        Me.panelDatosExamen.PerformLayout()
        Me.panelDatosUnidad.ResumeLayout(False)
        Me.panelDatosUnidad.PerformLayout()
        Me.panelResultado2.ResumeLayout(False)
        Me.panelResultado2.PerformLayout()
        CType(Me.dgvOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label26 As Label
    Friend WithEvents panelResultado1 As Panel
    Friend WithEvents cboxArea As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents hintArea As Label
    Friend WithEvents txtNombreExamen As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboxSubarea As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnRegistrarArea As Button
    Friend WithEvents hintSubarea As Label
    Friend WithEvents btnRegistrarSubarea As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cboxTipoResultado As ComboBox
    Friend WithEvents hintTipoResultado As Label
    Friend WithEvents panelDatosExamen As Panel
    Friend WithEvents btnRegistrarKitEquipo As Button
    Friend WithEvents btnEnviarDatos As Button
    Friend WithEvents panelDatosUnidad As Panel
    Friend WithEvents hintUnidadMedida As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cboxUnidadMedida As ComboBox
    Friend WithEvents btnRegistrarUnidadMedida As Button
    Friend WithEvents btnBuscarUnidad As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBuscarUnidad As TextBox
    Friend WithEvents chKitEquipoAsignado As CheckBox
    Friend WithEvents txtTipoReferencia As TextBox
    Friend WithEvents lblNombreTipoReferencia As Label
    Friend WithEvents txtKitEquipo As TextBox
    Friend WithEvents lblNombreKitEquipo As Label
    Friend WithEvents panelResultado2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarConjunto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents hintConjunto As Label
    Friend WithEvents txtBuscarConjunto As TextBox
    Friend WithEvents cboxConjunto As ComboBox
    Friend WithEvents btnRegistrarConjunto As Button
    Friend WithEvents dgvOpciones As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
