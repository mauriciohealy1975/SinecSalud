<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImprimirResultadosLaboratorio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.panelBuscarOrden = New System.Windows.Forms.Panel()
        Me.gboxDia = New System.Windows.Forms.GroupBox()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.dpickerDia = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gboxMes = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.hintTipoBusquedaMes = New System.Windows.Forms.Label()
        Me.cboxTiposBusquedaMes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gboxFechas = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dpickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dpickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnTraerOrdenes = New System.Windows.Forms.Button()
        Me.gboxModoBusqueda = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbuttonFechas = New System.Windows.Forms.RadioButton()
        Me.rbuttonMes = New System.Windows.Forms.RadioButton()
        Me.rbuttonDia = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.panelSeleccionarOrden = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarAsegurado = New System.Windows.Forms.Button()
        Me.txtBuscarAsegurado = New System.Windows.Forms.TextBox()
        Me.dgvOrdenes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelBuscarOrden.SuspendLayout()
        Me.gboxDia.SuspendLayout()
        Me.gboxMes.SuspendLayout()
        Me.gboxFechas.SuspendLayout()
        Me.gboxModoBusqueda.SuspendLayout()
        Me.panelSeleccionarOrden.SuspendLayout()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 35)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1197, 23)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(419, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(358, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "IMPRIMIR RESULTADOS DE LABORATORIO"
        '
        'panelBuscarOrden
        '
        Me.panelBuscarOrden.BackColor = System.Drawing.Color.White
        Me.panelBuscarOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBuscarOrden.Controls.Add(Me.gboxDia)
        Me.panelBuscarOrden.Controls.Add(Me.gboxMes)
        Me.panelBuscarOrden.Controls.Add(Me.gboxFechas)
        Me.panelBuscarOrden.Controls.Add(Me.btnTraerOrdenes)
        Me.panelBuscarOrden.Controls.Add(Me.gboxModoBusqueda)
        Me.panelBuscarOrden.Controls.Add(Me.Label15)
        Me.panelBuscarOrden.Location = New System.Drawing.Point(30, 78)
        Me.panelBuscarOrden.Name = "panelBuscarOrden"
        Me.panelBuscarOrden.Size = New System.Drawing.Size(612, 164)
        Me.panelBuscarOrden.TabIndex = 1
        '
        'gboxDia
        '
        Me.gboxDia.Controls.Add(Me.lblDia)
        Me.gboxDia.Controls.Add(Me.dpickerDia)
        Me.gboxDia.Controls.Add(Me.Label4)
        Me.gboxDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxDia.Location = New System.Drawing.Point(198, 36)
        Me.gboxDia.Name = "gboxDia"
        Me.gboxDia.Size = New System.Drawing.Size(395, 74)
        Me.gboxDia.TabIndex = 2
        Me.gboxDia.TabStop = False
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.Location = New System.Drawing.Point(10, 40)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(28, 16)
        Me.lblDia.TabIndex = 0
        Me.lblDia.Text = "Día"
        '
        'dpickerDia
        '
        Me.dpickerDia.CustomFormat = "dd/MM/yyyy"
        Me.dpickerDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpickerDia.Location = New System.Drawing.Point(44, 40)
        Me.dpickerDia.Name = "dpickerDia"
        Me.dpickerDia.Size = New System.Drawing.Size(212, 21)
        Me.dpickerDia.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Buscar por día"
        '
        'gboxMes
        '
        Me.gboxMes.Controls.Add(Me.Label8)
        Me.gboxMes.Controls.Add(Me.hintTipoBusquedaMes)
        Me.gboxMes.Controls.Add(Me.cboxTiposBusquedaMes)
        Me.gboxMes.Controls.Add(Me.Label7)
        Me.gboxMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxMes.Location = New System.Drawing.Point(197, 36)
        Me.gboxMes.Name = "gboxMes"
        Me.gboxMes.Size = New System.Drawing.Size(395, 74)
        Me.gboxMes.TabIndex = 3
        Me.gboxMes.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Mes"
        '
        'hintTipoBusquedaMes
        '
        Me.hintTipoBusquedaMes.AutoSize = True
        Me.hintTipoBusquedaMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTipoBusquedaMes.Location = New System.Drawing.Point(49, 47)
        Me.hintTipoBusquedaMes.Name = "hintTipoBusquedaMes"
        Me.hintTipoBusquedaMes.Size = New System.Drawing.Size(82, 13)
        Me.hintTipoBusquedaMes.TabIndex = 0
        Me.hintTipoBusquedaMes.Text = "SELECCIONAR"
        '
        'cboxTiposBusquedaMes
        '
        Me.cboxTiposBusquedaMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTiposBusquedaMes.FormattingEnabled = True
        Me.cboxTiposBusquedaMes.Location = New System.Drawing.Point(47, 42)
        Me.cboxTiposBusquedaMes.Name = "cboxTiposBusquedaMes"
        Me.cboxTiposBusquedaMes.Size = New System.Drawing.Size(187, 23)
        Me.cboxTiposBusquedaMes.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Buscar por mes"
        '
        'gboxFechas
        '
        Me.gboxFechas.Controls.Add(Me.Label10)
        Me.gboxFechas.Controls.Add(Me.dpickerHasta)
        Me.gboxFechas.Controls.Add(Me.Label9)
        Me.gboxFechas.Controls.Add(Me.dpickerDesde)
        Me.gboxFechas.Controls.Add(Me.Label11)
        Me.gboxFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxFechas.Location = New System.Drawing.Point(197, 36)
        Me.gboxFechas.Name = "gboxFechas"
        Me.gboxFechas.Size = New System.Drawing.Size(395, 74)
        Me.gboxFechas.TabIndex = 4
        Me.gboxFechas.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(213, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Hasta"
        '
        'dpickerHasta
        '
        Me.dpickerHasta.CustomFormat = "dd/MM/yyyy"
        Me.dpickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpickerHasta.Location = New System.Drawing.Point(262, 40)
        Me.dpickerHasta.Name = "dpickerHasta"
        Me.dpickerHasta.Size = New System.Drawing.Size(117, 21)
        Me.dpickerHasta.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Desde"
        '
        'dpickerDesde
        '
        Me.dpickerDesde.CustomFormat = "dd/MM/yyyy"
        Me.dpickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpickerDesde.Location = New System.Drawing.Point(64, 40)
        Me.dpickerDesde.Name = "dpickerDesde"
        Me.dpickerDesde.Size = New System.Drawing.Size(117, 21)
        Me.dpickerDesde.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Buscar por fechas"
        '
        'btnTraerOrdenes
        '
        Me.btnTraerOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraerOrdenes.Location = New System.Drawing.Point(481, 120)
        Me.btnTraerOrdenes.Name = "btnTraerOrdenes"
        Me.btnTraerOrdenes.Size = New System.Drawing.Size(111, 26)
        Me.btnTraerOrdenes.TabIndex = 5
        Me.btnTraerOrdenes.Text = "Traer ordenes"
        Me.btnTraerOrdenes.UseVisualStyleBackColor = True
        '
        'gboxModoBusqueda
        '
        Me.gboxModoBusqueda.Controls.Add(Me.Label3)
        Me.gboxModoBusqueda.Controls.Add(Me.rbuttonFechas)
        Me.gboxModoBusqueda.Controls.Add(Me.rbuttonMes)
        Me.gboxModoBusqueda.Controls.Add(Me.rbuttonDia)
        Me.gboxModoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxModoBusqueda.Location = New System.Drawing.Point(18, 36)
        Me.gboxModoBusqueda.Name = "gboxModoBusqueda"
        Me.gboxModoBusqueda.Size = New System.Drawing.Size(167, 110)
        Me.gboxModoBusqueda.TabIndex = 1
        Me.gboxModoBusqueda.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Modo de busqueda"
        '
        'rbuttonFechas
        '
        Me.rbuttonFechas.AutoSize = True
        Me.rbuttonFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonFechas.Location = New System.Drawing.Point(10, 75)
        Me.rbuttonFechas.Name = "rbuttonFechas"
        Me.rbuttonFechas.Size = New System.Drawing.Size(123, 19)
        Me.rbuttonFechas.TabIndex = 3
        Me.rbuttonFechas.TabStop = True
        Me.rbuttonFechas.Text = "Buscar por fechas"
        Me.rbuttonFechas.UseVisualStyleBackColor = True
        '
        'rbuttonMes
        '
        Me.rbuttonMes.AutoSize = True
        Me.rbuttonMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonMes.Location = New System.Drawing.Point(10, 55)
        Me.rbuttonMes.Name = "rbuttonMes"
        Me.rbuttonMes.Size = New System.Drawing.Size(111, 19)
        Me.rbuttonMes.TabIndex = 2
        Me.rbuttonMes.TabStop = True
        Me.rbuttonMes.Text = "Buscar por mes"
        Me.rbuttonMes.UseVisualStyleBackColor = True
        '
        'rbuttonDia
        '
        Me.rbuttonDia.AutoSize = True
        Me.rbuttonDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonDia.Location = New System.Drawing.Point(10, 35)
        Me.rbuttonDia.Name = "rbuttonDia"
        Me.rbuttonDia.Size = New System.Drawing.Size(104, 19)
        Me.rbuttonDia.TabIndex = 1
        Me.rbuttonDia.TabStop = True
        Me.rbuttonDia.Text = "Buscar por día"
        Me.rbuttonDia.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(15, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 18)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "1.- Buscar orden "
        '
        'panelSeleccionarOrden
        '
        Me.panelSeleccionarOrden.BackColor = System.Drawing.Color.White
        Me.panelSeleccionarOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelSeleccionarOrden.Controls.Add(Me.Label5)
        Me.panelSeleccionarOrden.Controls.Add(Me.btnBuscarAsegurado)
        Me.panelSeleccionarOrden.Controls.Add(Me.txtBuscarAsegurado)
        Me.panelSeleccionarOrden.Controls.Add(Me.dgvOrdenes)
        Me.panelSeleccionarOrden.Controls.Add(Me.Label1)
        Me.panelSeleccionarOrden.Location = New System.Drawing.Point(30, 265)
        Me.panelSeleccionarOrden.Name = "panelSeleccionarOrden"
        Me.panelSeleccionarOrden.Size = New System.Drawing.Size(612, 281)
        Me.panelSeleccionarOrden.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(228, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Asegurado"
        '
        'btnBuscarAsegurado
        '
        Me.btnBuscarAsegurado.Location = New System.Drawing.Point(519, 15)
        Me.btnBuscarAsegurado.Name = "btnBuscarAsegurado"
        Me.btnBuscarAsegurado.Size = New System.Drawing.Size(74, 23)
        Me.btnBuscarAsegurado.TabIndex = 2
        Me.btnBuscarAsegurado.Text = "Buscar"
        Me.btnBuscarAsegurado.UseVisualStyleBackColor = True
        '
        'txtBuscarAsegurado
        '
        Me.txtBuscarAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarAsegurado.Location = New System.Drawing.Point(307, 15)
        Me.txtBuscarAsegurado.Name = "txtBuscarAsegurado"
        Me.txtBuscarAsegurado.Size = New System.Drawing.Size(206, 21)
        Me.txtBuscarAsegurado.TabIndex = 1
        '
        'dgvSolicitudes
        '
        Me.dgvOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrdenes.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvOrdenes.Location = New System.Drawing.Point(18, 53)
        Me.dgvOrdenes.Name = "dgvOrdenes"
        Me.dgvOrdenes.Size = New System.Drawing.Size(574, 211)
        Me.dgvOrdenes.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.FillWeight = 12.5!
        Me.Column1.HeaderText = "ORDEN"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.FillWeight = 12.5!
        Me.Column2.HeaderText = "FECHA"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.FillWeight = 15.0!
        Me.Column3.HeaderText = "MATRICULA"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.FillWeight = 33.0!
        Me.Column4.HeaderText = "ASEGURADO"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.FillWeight = 13.0!
        Me.Column5.HeaderText = "EXAMENES"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.FillWeight = 13.0!
        Me.Column6.HeaderText = "RESULTADOS"
        Me.Column6.Name = "Column6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "2.- Seleccionar orden"
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.DisplayStatusBar = False
        Me.crViewer.Location = New System.Drawing.Point(669, 78)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.ShowCloseButton = False
        Me.crViewer.ShowCopyButton = False
        Me.crViewer.ShowExportButton = False
        Me.crViewer.ShowGotoPageButton = False
        Me.crViewer.ShowGroupTreeButton = False
        Me.crViewer.ShowLogo = False
        Me.crViewer.ShowParameterPanelButton = False
        Me.crViewer.ShowRefreshButton = False
        Me.crViewer.ShowTextSearchButton = False
        Me.crViewer.Size = New System.Drawing.Size(558, 551)
        Me.crViewer.TabIndex = 3
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
        Me.menuStripMenuLaboratorio.Size = New System.Drawing.Size(166, 22)
        Me.menuStripMenuLaboratorio.Text = "Menu laboratorio"
        '
        'FormImprimirResultadosLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 651)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.crViewer)
        Me.Controls.Add(Me.panelSeleccionarOrden)
        Me.Controls.Add(Me.panelBuscarOrden)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormImprimirResultadosLaboratorio"
        Me.Text = "Imprimir resultados de laboratorio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelBuscarOrden.ResumeLayout(False)
        Me.panelBuscarOrden.PerformLayout()
        Me.gboxDia.ResumeLayout(False)
        Me.gboxDia.PerformLayout()
        Me.gboxMes.ResumeLayout(False)
        Me.gboxMes.PerformLayout()
        Me.gboxFechas.ResumeLayout(False)
        Me.gboxFechas.PerformLayout()
        Me.gboxModoBusqueda.ResumeLayout(False)
        Me.gboxModoBusqueda.PerformLayout()
        Me.panelSeleccionarOrden.ResumeLayout(False)
        Me.panelSeleccionarOrden.PerformLayout()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents panelBuscarOrden As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents panelSeleccionarOrden As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvOrdenes As DataGridView
    Friend WithEvents btnTraerOrdenes As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents gboxModoBusqueda As GroupBox
    Friend WithEvents rbuttonFechas As RadioButton
    Friend WithEvents rbuttonMes As RadioButton
    Friend WithEvents rbuttonDia As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents gboxDia As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDia As Label
    Friend WithEvents dpickerDia As DateTimePicker
    Friend WithEvents gboxFechas As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dpickerHasta As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dpickerDesde As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents gboxMes As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents hintTipoBusquedaMes As Label
    Friend WithEvents cboxTiposBusquedaMes As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarAsegurado As Button
    Friend WithEvents txtBuscarAsegurado As TextBox
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
