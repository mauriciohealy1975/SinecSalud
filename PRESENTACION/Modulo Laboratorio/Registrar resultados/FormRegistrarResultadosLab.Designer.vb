<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarResultadosLab
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.panelBuscarOrden = New System.Windows.Forms.Panel()
        Me.gboxFecha = New System.Windows.Forms.GroupBox()
        Me.hintOrdenFecha = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.hintFecha = New System.Windows.Forms.Label()
        Me.cboxOrdenFecha = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxFecha = New System.Windows.Forms.ComboBox()
        Me.gboxModoBusqueda = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbuttonFecha = New System.Windows.Forms.RadioButton()
        Me.rbuttonNombre = New System.Windows.Forms.RadioButton()
        Me.rbuttonNroOrden = New System.Windows.Forms.RadioButton()
        Me.gboxNombre = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.hintOrdenNombre = New System.Windows.Forms.Label()
        Me.cboxOrdenNombre = New System.Windows.Forms.ComboBox()
        Me.btnBuscarPorNombre = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBuscarPorNombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gboxNroOrden = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hintOrdenNroOrden = New System.Windows.Forms.Label()
        Me.cboxOrdenNroOrden = New System.Windows.Forms.ComboBox()
        Me.btnBuscarPorNroOrden = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBuscarPorNroOrden = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMensajeRestriccion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelResultados = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmItemMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelBuscarOrden.SuspendLayout()
        Me.gboxFecha.SuspendLayout()
        Me.gboxModoBusqueda.SuspendLayout()
        Me.gboxNombre.SuspendLayout()
        Me.gboxNroOrden.SuspendLayout()
        Me.panelResultados.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1199, 23)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(410, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(379, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR RESULTADOS DE LABORATORIO"
        '
        'panelBuscarOrden
        '
        Me.panelBuscarOrden.BackColor = System.Drawing.Color.White
        Me.panelBuscarOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBuscarOrden.Controls.Add(Me.gboxFecha)
        Me.panelBuscarOrden.Controls.Add(Me.gboxModoBusqueda)
        Me.panelBuscarOrden.Controls.Add(Me.gboxNombre)
        Me.panelBuscarOrden.Controls.Add(Me.gboxNroOrden)
        Me.panelBuscarOrden.Controls.Add(Me.lblMensajeRestriccion)
        Me.panelBuscarOrden.Controls.Add(Me.Label4)
        Me.panelBuscarOrden.Location = New System.Drawing.Point(30, 80)
        Me.panelBuscarOrden.Name = "panelBuscarOrden"
        Me.panelBuscarOrden.Size = New System.Drawing.Size(737, 163)
        Me.panelBuscarOrden.TabIndex = 7
        '
        'gboxFecha
        '
        Me.gboxFecha.Controls.Add(Me.hintOrdenFecha)
        Me.gboxFecha.Controls.Add(Me.Label18)
        Me.gboxFecha.Controls.Add(Me.hintFecha)
        Me.gboxFecha.Controls.Add(Me.cboxOrdenFecha)
        Me.gboxFecha.Controls.Add(Me.Label2)
        Me.gboxFecha.Controls.Add(Me.Label1)
        Me.gboxFecha.Controls.Add(Me.cboxFecha)
        Me.gboxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxFecha.Location = New System.Drawing.Point(197, 37)
        Me.gboxFecha.Name = "gboxFecha"
        Me.gboxFecha.Size = New System.Drawing.Size(520, 110)
        Me.gboxFecha.TabIndex = 25
        Me.gboxFecha.TabStop = False
        '
        'hintOrdenFecha
        '
        Me.hintOrdenFecha.AutoSize = True
        Me.hintOrdenFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintOrdenFecha.Location = New System.Drawing.Point(66, 75)
        Me.hintOrdenFecha.Name = "hintOrdenFecha"
        Me.hintOrdenFecha.Size = New System.Drawing.Size(82, 13)
        Me.hintOrdenFecha.TabIndex = 0
        Me.hintOrdenFecha.Text = "SELECCIONAR"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Buscar por fecha"
        '
        'hintFecha
        '
        Me.hintFecha.AutoSize = True
        Me.hintFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintFecha.Location = New System.Drawing.Point(66, 45)
        Me.hintFecha.Name = "hintFecha"
        Me.hintFecha.Size = New System.Drawing.Size(82, 13)
        Me.hintFecha.TabIndex = 21
        Me.hintFecha.Text = "SELECCIONAR"
        '
        'cboxOrdenFecha
        '
        Me.cboxOrdenFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxOrdenFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxOrdenFecha.FormattingEnabled = True
        Me.cboxOrdenFecha.Location = New System.Drawing.Point(62, 70)
        Me.cboxOrdenFecha.Name = "cboxOrdenFecha"
        Me.cboxOrdenFecha.Size = New System.Drawing.Size(435, 23)
        Me.cboxOrdenFecha.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Orden"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha"
        '
        'cboxFecha
        '
        Me.cboxFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFecha.FormattingEnabled = True
        Me.cboxFecha.Location = New System.Drawing.Point(62, 40)
        Me.cboxFecha.Name = "cboxFecha"
        Me.cboxFecha.Size = New System.Drawing.Size(119, 23)
        Me.cboxFecha.TabIndex = 17
        '
        'gboxModoBusqueda
        '
        Me.gboxModoBusqueda.Controls.Add(Me.Label9)
        Me.gboxModoBusqueda.Controls.Add(Me.rbuttonFecha)
        Me.gboxModoBusqueda.Controls.Add(Me.rbuttonNombre)
        Me.gboxModoBusqueda.Controls.Add(Me.rbuttonNroOrden)
        Me.gboxModoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxModoBusqueda.Location = New System.Drawing.Point(18, 36)
        Me.gboxModoBusqueda.Name = "gboxModoBusqueda"
        Me.gboxModoBusqueda.Size = New System.Drawing.Size(160, 110)
        Me.gboxModoBusqueda.TabIndex = 22
        Me.gboxModoBusqueda.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Modo de busqueda"
        '
        'rbuttonFecha
        '
        Me.rbuttonFecha.AutoSize = True
        Me.rbuttonFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonFecha.Location = New System.Drawing.Point(10, 75)
        Me.rbuttonFecha.Name = "rbuttonFecha"
        Me.rbuttonFecha.Size = New System.Drawing.Size(117, 19)
        Me.rbuttonFecha.TabIndex = 3
        Me.rbuttonFecha.TabStop = True
        Me.rbuttonFecha.Text = "Buscar por fecha"
        Me.rbuttonFecha.UseVisualStyleBackColor = True
        '
        'rbuttonNombre
        '
        Me.rbuttonNombre.AutoSize = True
        Me.rbuttonNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonNombre.Location = New System.Drawing.Point(10, 55)
        Me.rbuttonNombre.Name = "rbuttonNombre"
        Me.rbuttonNombre.Size = New System.Drawing.Size(130, 19)
        Me.rbuttonNombre.TabIndex = 2
        Me.rbuttonNombre.TabStop = True
        Me.rbuttonNombre.Text = "Buscar por nombre"
        Me.rbuttonNombre.UseVisualStyleBackColor = True
        '
        'rbuttonNroOrden
        '
        Me.rbuttonNroOrden.AutoSize = True
        Me.rbuttonNroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonNroOrden.Location = New System.Drawing.Point(11, 35)
        Me.rbuttonNroOrden.Name = "rbuttonNroOrden"
        Me.rbuttonNroOrden.Size = New System.Drawing.Size(143, 19)
        Me.rbuttonNroOrden.TabIndex = 1
        Me.rbuttonNroOrden.TabStop = True
        Me.rbuttonNroOrden.Text = "Buscar por nro. orden"
        Me.rbuttonNroOrden.UseVisualStyleBackColor = True
        '
        'gboxNombre
        '
        Me.gboxNombre.Controls.Add(Me.Label11)
        Me.gboxNombre.Controls.Add(Me.hintOrdenNombre)
        Me.gboxNombre.Controls.Add(Me.cboxOrdenNombre)
        Me.gboxNombre.Controls.Add(Me.btnBuscarPorNombre)
        Me.gboxNombre.Controls.Add(Me.Label13)
        Me.gboxNombre.Controls.Add(Me.txtBuscarPorNombre)
        Me.gboxNombre.Controls.Add(Me.Label14)
        Me.gboxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxNombre.Location = New System.Drawing.Point(197, 37)
        Me.gboxNombre.Name = "gboxNombre"
        Me.gboxNombre.Size = New System.Drawing.Size(520, 110)
        Me.gboxNombre.TabIndex = 24
        Me.gboxNombre.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Orden"
        '
        'hintOrdenNombre
        '
        Me.hintOrdenNombre.AutoSize = True
        Me.hintOrdenNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintOrdenNombre.Location = New System.Drawing.Point(95, 74)
        Me.hintOrdenNombre.Name = "hintOrdenNombre"
        Me.hintOrdenNombre.Size = New System.Drawing.Size(82, 13)
        Me.hintOrdenNombre.TabIndex = 27
        Me.hintOrdenNombre.Text = "SELECCIONAR"
        '
        'cboxOrdenNombre
        '
        Me.cboxOrdenNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxOrdenNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxOrdenNombre.FormattingEnabled = True
        Me.cboxOrdenNombre.Location = New System.Drawing.Point(90, 70)
        Me.cboxOrdenNombre.Name = "cboxOrdenNombre"
        Me.cboxOrdenNombre.Size = New System.Drawing.Size(416, 21)
        Me.cboxOrdenNombre.TabIndex = 28
        '
        'btnBuscarPorNombre
        '
        Me.btnBuscarPorNombre.Location = New System.Drawing.Point(370, 38)
        Me.btnBuscarPorNombre.Name = "btnBuscarPorNombre"
        Me.btnBuscarPorNombre.Size = New System.Drawing.Size(66, 25)
        Me.btnBuscarPorNombre.TabIndex = 26
        Me.btnBuscarPorNombre.Text = "Buscar"
        Me.btnBuscarPorNombre.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Asegurado"
        '
        'txtBuscarPorNombre
        '
        Me.txtBuscarPorNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarPorNombre.Location = New System.Drawing.Point(90, 40)
        Me.txtBuscarPorNombre.Name = "txtBuscarPorNombre"
        Me.txtBuscarPorNombre.Size = New System.Drawing.Size(274, 21)
        Me.txtBuscarPorNombre.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(212, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Buscar por nombre del asegurado"
        '
        'gboxNroOrden
        '
        Me.gboxNroOrden.Controls.Add(Me.Label6)
        Me.gboxNroOrden.Controls.Add(Me.hintOrdenNroOrden)
        Me.gboxNroOrden.Controls.Add(Me.cboxOrdenNroOrden)
        Me.gboxNroOrden.Controls.Add(Me.btnBuscarPorNroOrden)
        Me.gboxNroOrden.Controls.Add(Me.Label5)
        Me.gboxNroOrden.Controls.Add(Me.txtBuscarPorNroOrden)
        Me.gboxNroOrden.Controls.Add(Me.Label3)
        Me.gboxNroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxNroOrden.Location = New System.Drawing.Point(197, 37)
        Me.gboxNroOrden.Name = "gboxNroOrden"
        Me.gboxNroOrden.Size = New System.Drawing.Size(520, 110)
        Me.gboxNroOrden.TabIndex = 23
        Me.gboxNroOrden.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Orden"
        '
        'hintOrdenNroOrden
        '
        Me.hintOrdenNroOrden.AutoSize = True
        Me.hintOrdenNroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintOrdenNroOrden.Location = New System.Drawing.Point(106, 74)
        Me.hintOrdenNroOrden.Name = "hintOrdenNroOrden"
        Me.hintOrdenNroOrden.Size = New System.Drawing.Size(82, 13)
        Me.hintOrdenNroOrden.TabIndex = 27
        Me.hintOrdenNroOrden.Text = "SELECCIONAR"
        '
        'cboxOrdenNroOrden
        '
        Me.cboxOrdenNroOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxOrdenNroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxOrdenNroOrden.FormattingEnabled = True
        Me.cboxOrdenNroOrden.Location = New System.Drawing.Point(102, 70)
        Me.cboxOrdenNroOrden.Name = "cboxOrdenNroOrden"
        Me.cboxOrdenNroOrden.Size = New System.Drawing.Size(407, 21)
        Me.cboxOrdenNroOrden.TabIndex = 28
        '
        'btnBuscarPorNroOrden
        '
        Me.btnBuscarPorNroOrden.Location = New System.Drawing.Point(220, 40)
        Me.btnBuscarPorNroOrden.Name = "btnBuscarPorNroOrden"
        Me.btnBuscarPorNroOrden.Size = New System.Drawing.Size(66, 25)
        Me.btnBuscarPorNroOrden.TabIndex = 26
        Me.btnBuscarPorNroOrden.Text = "Buscar"
        Me.btnBuscarPorNroOrden.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Nro de orden"
        '
        'txtBuscarPorNroOrden
        '
        Me.txtBuscarPorNroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarPorNroOrden.Location = New System.Drawing.Point(102, 40)
        Me.txtBuscarPorNroOrden.Name = "txtBuscarPorNroOrden"
        Me.txtBuscarPorNroOrden.Size = New System.Drawing.Size(112, 21)
        Me.txtBuscarPorNroOrden.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buscar por nro de orden"
        '
        'lblMensajeRestriccion
        '
        Me.lblMensajeRestriccion.AutoSize = True
        Me.lblMensajeRestriccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeRestriccion.Location = New System.Drawing.Point(194, 18)
        Me.lblMensajeRestriccion.Name = "lblMensajeRestriccion"
        Me.lblMensajeRestriccion.Size = New System.Drawing.Size(79, 16)
        Me.lblMensajeRestriccion.TabIndex = 18
        Me.lblMensajeRestriccion.Text = "Información:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "1.- Buscar orden"
        '
        'panelResultados
        '
        Me.panelResultados.BackColor = System.Drawing.SystemColors.Window
        Me.panelResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelResultados.Controls.Add(Me.Label7)
        Me.panelResultados.Controls.Add(Me.dgvResultados)
        Me.panelResultados.Controls.Add(Me.Label8)
        Me.panelResultados.Location = New System.Drawing.Point(30, 263)
        Me.panelResultados.Name = "panelResultados"
        Me.panelResultados.Size = New System.Drawing.Size(922, 251)
        Me.panelResultados.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(363, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "LISTA DE EXAMENES CON RESULTADOS PENDIENTES:"
        '
        'dgvResultados
        '
        Me.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultados.BackgroundColor = System.Drawing.Color.White
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column4})
        Me.dgvResultados.Location = New System.Drawing.Point(18, 70)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.Size = New System.Drawing.Size(883, 162)
        Me.dgvResultados.TabIndex = 1
        '
        'Column3
        '
        Me.Column3.HeaderText = "AREA"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "EXAMEN"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "RESULTADO"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "2.- Registro de resultados"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.Location = New System.Drawing.Point(1078, 486)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(174, 28)
        Me.btnEnviarDatos.TabIndex = 4
        Me.btnEnviarDatos.Text = "Guardar resultados"
        Me.btnEnviarDatos.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmItemMenuLaboratorio})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'tsmItemMenuLaboratorio
        '
        Me.tsmItemMenuLaboratorio.Name = "tsmItemMenuLaboratorio"
        Me.tsmItemMenuLaboratorio.Size = New System.Drawing.Size(169, 22)
        Me.tsmItemMenuLaboratorio.Text = "Menu Laboratorio"
        '
        'FormRegistrarResultadosLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 531)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.panelResultados)
        Me.Controls.Add(Me.panelBuscarOrden)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarResultadosLab"
        Me.Text = "Registrar resultados laboratorio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelBuscarOrden.ResumeLayout(False)
        Me.panelBuscarOrden.PerformLayout()
        Me.gboxFecha.ResumeLayout(False)
        Me.gboxFecha.PerformLayout()
        Me.gboxModoBusqueda.ResumeLayout(False)
        Me.gboxModoBusqueda.PerformLayout()
        Me.gboxNombre.ResumeLayout(False)
        Me.gboxNombre.PerformLayout()
        Me.gboxNroOrden.ResumeLayout(False)
        Me.gboxNroOrden.PerformLayout()
        Me.panelResultados.ResumeLayout(False)
        Me.panelResultados.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents panelBuscarOrden As System.Windows.Forms.Panel
    Friend WithEvents hintOrdenFecha As System.Windows.Forms.Label
    Friend WithEvents cboxOrdenFecha As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panelResultados As System.Windows.Forms.Panel
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents btnEnviarDatos As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmItemMenuLaboratorio As ToolStripMenuItem
    Friend WithEvents lblMensajeRestriccion As Label
    Friend WithEvents cboxFecha As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents hintFecha As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents gboxModoBusqueda As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rbuttonFecha As RadioButton
    Friend WithEvents rbuttonNombre As RadioButton
    Friend WithEvents rbuttonNroOrden As RadioButton
    Friend WithEvents gboxNroOrden As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBuscarPorNroOrden As TextBox
    Friend WithEvents btnBuscarPorNroOrden As Button
    Friend WithEvents gboxNombre As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents hintOrdenNombre As Label
    Friend WithEvents cboxOrdenNombre As ComboBox
    Friend WithEvents btnBuscarPorNombre As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBuscarPorNombre As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents hintOrdenNroOrden As Label
    Friend WithEvents cboxOrdenNroOrden As ComboBox
    Friend WithEvents gboxFecha As GroupBox
    Friend WithEvents Label18 As Label
End Class
