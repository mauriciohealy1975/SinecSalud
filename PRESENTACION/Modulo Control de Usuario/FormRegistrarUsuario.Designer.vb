<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistrarUsuario))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.hintTIpo = New System.Windows.Forms.Label()
        Me.cboxTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fmeLblBuscar = New System.Windows.Forms.Label()
        Me.fmeTxtBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.fmeCmboxUsername = New System.Windows.Forms.ComboBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMostrarMenuPuesto = New System.Windows.Forms.Button()
        Me.btnMostrarMenuArea = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.hintCboxPuesto = New System.Windows.Forms.Label()
        Me.btnGuardarUsuario = New System.Windows.Forms.Button()
        Me.cmboxPuesto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.hintCboxArea = New System.Windows.Forms.Label()
        Me.cmboxArea = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAgregarArea = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelAgregarArea = New System.Windows.Forms.Panel()
        Me.btnAgregarArea = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panelAgregarPuesto = New System.Windows.Forms.Panel()
        Me.hintCmboxAgregarArea = New System.Windows.Forms.Label()
        Me.cmboxAsignarArea = New System.Windows.Forms.ComboBox()
        Me.btnAgregarPuesto = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAgregarPuesto = New System.Windows.Forms.TextBox()
        Me.toolStripModosForm = New System.Windows.Forms.ToolStrip()
        Me.tlStripGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tlStripEditar = New System.Windows.Forms.ToolStripButton()
        Me.tlStripEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelAgregarArea.SuspendLayout()
        Me.panelAgregarPuesto.SuspendLayout()
        Me.toolStripModosForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(67, 52)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1553, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(660, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR USUARIO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.hintTIpo)
        Me.Panel1.Controls.Add(Me.cboxTipo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.fmeLblBuscar)
        Me.Panel1.Controls.Add(Me.fmeTxtBuscarUsuario)
        Me.Panel1.Controls.Add(Me.fmeCmboxUsername)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtNombres)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtApellidoMaterno)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtApellidoPaterno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.lblContraseña)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(67, 100)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 274)
        Me.Panel1.TabIndex = 1
        '
        'hintTIpo
        '
        Me.hintTIpo.AutoSize = True
        Me.hintTIpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTIpo.Location = New System.Drawing.Point(627, 42)
        Me.hintTIpo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintTIpo.Name = "hintTIpo"
        Me.hintTIpo.Size = New System.Drawing.Size(114, 18)
        Me.hintTIpo.TabIndex = 62
        Me.hintTIpo.Text = "SELECCIONAR"
        '
        'cboxTipo
        '
        Me.cboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTipo.FormattingEnabled = True
        Me.cboxTipo.Location = New System.Drawing.Point(620, 37)
        Me.cboxTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboxTipo.Name = "cboxTipo"
        Me.cboxTipo.Size = New System.Drawing.Size(277, 26)
        Me.cboxTipo.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tipo de usuario"
        '
        'fmeLblBuscar
        '
        Me.fmeLblBuscar.AutoSize = True
        Me.fmeLblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fmeLblBuscar.Location = New System.Drawing.Point(72, 186)
        Me.fmeLblBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.fmeLblBuscar.Name = "fmeLblBuscar"
        Me.fmeLblBuscar.Size = New System.Drawing.Size(115, 20)
        Me.fmeLblBuscar.TabIndex = 12
        Me.fmeLblBuscar.Text = "Buscar usuario"
        '
        'fmeTxtBuscarUsuario
        '
        Me.fmeTxtBuscarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fmeTxtBuscarUsuario.Location = New System.Drawing.Point(209, 182)
        Me.fmeTxtBuscarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.fmeTxtBuscarUsuario.Name = "fmeTxtBuscarUsuario"
        Me.fmeTxtBuscarUsuario.Size = New System.Drawing.Size(211, 24)
        Me.fmeTxtBuscarUsuario.TabIndex = 11
        '
        'fmeCmboxUsername
        '
        Me.fmeCmboxUsername.FormattingEnabled = True
        Me.fmeCmboxUsername.Location = New System.Drawing.Point(76, 222)
        Me.fmeCmboxUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.fmeCmboxUsername.Name = "fmeCmboxUsername"
        Me.fmeCmboxUsername.Size = New System.Drawing.Size(344, 24)
        Me.fmeCmboxUsername.TabIndex = 10
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(620, 215)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(277, 24)
        Me.txtTelefono.TabIndex = 9
        Me.txtTelefono.Text = "00000000"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(511, 222)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 20)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Teléfono"
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(620, 170)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(277, 24)
        Me.txtNombres.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(515, 176)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 20)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Nombre"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(620, 124)
        Me.txtApellidoMaterno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(277, 24)
        Me.txtApellidoMaterno.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(447, 130)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Apellido Materno"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(620, 80)
        Me.txtApellidoPaterno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(277, 24)
        Me.txtApellidoPaterno.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(447, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Apellido Paterno"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(192, 127)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(157, 24)
        Me.txtContraseña.TabIndex = 2
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(72, 130)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(92, 20)
        Me.lblContraseña.TabIndex = 0
        Me.lblContraseña.Text = "Contraseña"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(192, 80)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(157, 24)
        Me.txtUsername.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 80)
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
        Me.Label7.Text = "1.- Datos del usuario"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnMostrarMenuPuesto)
        Me.Panel2.Controls.Add(Me.btnMostrarMenuArea)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.hintCboxPuesto)
        Me.Panel2.Controls.Add(Me.btnGuardarUsuario)
        Me.Panel2.Controls.Add(Me.cmboxPuesto)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.hintCboxArea)
        Me.Panel2.Controls.Add(Me.cmboxArea)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(67, 401)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(950, 251)
        Me.Panel2.TabIndex = 2
        '
        'btnMostrarMenuPuesto
        '
        Me.btnMostrarMenuPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarMenuPuesto.Location = New System.Drawing.Point(492, 134)
        Me.btnMostrarMenuPuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrarMenuPuesto.Name = "btnMostrarMenuPuesto"
        Me.btnMostrarMenuPuesto.Size = New System.Drawing.Size(35, 28)
        Me.btnMostrarMenuPuesto.TabIndex = 6
        Me.btnMostrarMenuPuesto.Text = "+"
        Me.btnMostrarMenuPuesto.UseVisualStyleBackColor = True
        '
        'btnMostrarMenuArea
        '
        Me.btnMostrarMenuArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarMenuArea.Location = New System.Drawing.Point(492, 81)
        Me.btnMostrarMenuArea.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrarMenuArea.Name = "btnMostrarMenuArea"
        Me.btnMostrarMenuArea.Size = New System.Drawing.Size(35, 28)
        Me.btnMostrarMenuArea.TabIndex = 5
        Me.btnMostrarMenuArea.Text = "+"
        Me.btnMostrarMenuArea.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(575, 191)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(103, 34)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'hintCboxPuesto
        '
        Me.hintCboxPuesto.AutoSize = True
        Me.hintCboxPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCboxPuesto.Location = New System.Drawing.Point(172, 139)
        Me.hintCboxPuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintCboxPuesto.Name = "hintCboxPuesto"
        Me.hintCboxPuesto.Size = New System.Drawing.Size(114, 18)
        Me.hintCboxPuesto.TabIndex = 64
        Me.hintCboxPuesto.Text = "SELECCIONAR"
        '
        'btnGuardarUsuario
        '
        Me.btnGuardarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnGuardarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarUsuario.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarUsuario.Location = New System.Drawing.Point(700, 191)
        Me.btnGuardarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarUsuario.Name = "btnGuardarUsuario"
        Me.btnGuardarUsuario.Size = New System.Drawing.Size(213, 34)
        Me.btnGuardarUsuario.TabIndex = 4
        Me.btnGuardarUsuario.Text = "Guardar usuario"
        Me.btnGuardarUsuario.UseVisualStyleBackColor = True
        '
        'cmboxPuesto
        '
        Me.cmboxPuesto.FormattingEnabled = True
        Me.cmboxPuesto.Location = New System.Drawing.Point(168, 135)
        Me.cmboxPuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxPuesto.Name = "cmboxPuesto"
        Me.cmboxPuesto.Size = New System.Drawing.Size(303, 24)
        Me.cmboxPuesto.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 139)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Puesto"
        '
        'hintCboxArea
        '
        Me.hintCboxArea.AutoSize = True
        Me.hintCboxArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCboxArea.Location = New System.Drawing.Point(172, 85)
        Me.hintCboxArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintCboxArea.Name = "hintCboxArea"
        Me.hintCboxArea.Size = New System.Drawing.Size(114, 18)
        Me.hintCboxArea.TabIndex = 61
        Me.hintCboxArea.Text = "SELECCIONAR"
        '
        'cmboxArea
        '
        Me.cmboxArea.FormattingEnabled = True
        Me.cmboxArea.Location = New System.Drawing.Point(168, 81)
        Me.cmboxArea.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxArea.Name = "cmboxArea"
        Me.cmboxArea.Size = New System.Drawing.Size(303, 24)
        Me.cmboxArea.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Area"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(31, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(295, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "2.- Datos del puesto de trabajo"
        '
        'txtAgregarArea
        '
        Me.txtAgregarArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgregarArea.Location = New System.Drawing.Point(79, 65)
        Me.txtAgregarArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAgregarArea.Name = "txtAgregarArea"
        Me.txtAgregarArea.Size = New System.Drawing.Size(295, 24)
        Me.txtAgregarArea.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 68)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Area"
        '
        'panelAgregarArea
        '
        Me.panelAgregarArea.BackColor = System.Drawing.Color.White
        Me.panelAgregarArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAgregarArea.Controls.Add(Me.btnAgregarArea)
        Me.panelAgregarArea.Controls.Add(Me.Label11)
        Me.panelAgregarArea.Controls.Add(Me.Label6)
        Me.panelAgregarArea.Controls.Add(Me.txtAgregarArea)
        Me.panelAgregarArea.Location = New System.Drawing.Point(1071, 100)
        Me.panelAgregarArea.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAgregarArea.Name = "panelAgregarArea"
        Me.panelAgregarArea.Size = New System.Drawing.Size(413, 167)
        Me.panelAgregarArea.TabIndex = 3
        Me.panelAgregarArea.Visible = False
        '
        'btnAgregarArea
        '
        Me.btnAgregarArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarArea.Location = New System.Drawing.Point(236, 107)
        Me.btnAgregarArea.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarArea.Name = "btnAgregarArea"
        Me.btnAgregarArea.Size = New System.Drawing.Size(139, 33)
        Me.btnAgregarArea.TabIndex = 2
        Me.btnAgregarArea.Text = "Agregar area"
        Me.btnAgregarArea.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(21, 25)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Agregar nueva area"
        '
        'panelAgregarPuesto
        '
        Me.panelAgregarPuesto.AccessibleDescription = "o"
        Me.panelAgregarPuesto.BackColor = System.Drawing.Color.White
        Me.panelAgregarPuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAgregarPuesto.Controls.Add(Me.hintCmboxAgregarArea)
        Me.panelAgregarPuesto.Controls.Add(Me.cmboxAsignarArea)
        Me.panelAgregarPuesto.Controls.Add(Me.btnAgregarPuesto)
        Me.panelAgregarPuesto.Controls.Add(Me.Label10)
        Me.panelAgregarPuesto.Controls.Add(Me.Label13)
        Me.panelAgregarPuesto.Controls.Add(Me.Label12)
        Me.panelAgregarPuesto.Controls.Add(Me.txtAgregarPuesto)
        Me.panelAgregarPuesto.Location = New System.Drawing.Point(1071, 401)
        Me.panelAgregarPuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAgregarPuesto.Name = "panelAgregarPuesto"
        Me.panelAgregarPuesto.Size = New System.Drawing.Size(430, 222)
        Me.panelAgregarPuesto.TabIndex = 4
        Me.panelAgregarPuesto.Visible = False
        '
        'hintCmboxAgregarArea
        '
        Me.hintCmboxAgregarArea.AutoSize = True
        Me.hintCmboxAgregarArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCmboxAgregarArea.Location = New System.Drawing.Point(100, 82)
        Me.hintCmboxAgregarArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hintCmboxAgregarArea.Name = "hintCmboxAgregarArea"
        Me.hintCmboxAgregarArea.Size = New System.Drawing.Size(114, 18)
        Me.hintCmboxAgregarArea.TabIndex = 0
        Me.hintCmboxAgregarArea.Text = "SELECCIONAR"
        '
        'cmboxAsignarArea
        '
        Me.cmboxAsignarArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxAsignarArea.FormattingEnabled = True
        Me.cmboxAsignarArea.Location = New System.Drawing.Point(96, 78)
        Me.cmboxAsignarArea.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxAsignarArea.Name = "cmboxAsignarArea"
        Me.cmboxAsignarArea.Size = New System.Drawing.Size(292, 26)
        Me.cmboxAsignarArea.TabIndex = 1
        '
        'btnAgregarPuesto
        '
        Me.btnAgregarPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPuesto.Location = New System.Drawing.Point(236, 164)
        Me.btnAgregarPuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarPuesto.Name = "btnAgregarPuesto"
        Me.btnAgregarPuesto.Size = New System.Drawing.Size(156, 33)
        Me.btnAgregarPuesto.TabIndex = 3
        Me.btnAgregarPuesto.Text = "Agregar puesto"
        Me.btnAgregarPuesto.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(21, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(218, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Agregar nuevo puesto"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 78)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Area"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 124)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Puesto"
        '
        'txtAgregarPuesto
        '
        Me.txtAgregarPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgregarPuesto.Location = New System.Drawing.Point(96, 122)
        Me.txtAgregarPuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAgregarPuesto.Name = "txtAgregarPuesto"
        Me.txtAgregarPuesto.Size = New System.Drawing.Size(295, 24)
        Me.txtAgregarPuesto.TabIndex = 2
        '
        'toolStripModosForm
        '
        Me.toolStripModosForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.toolStripModosForm.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.toolStripModosForm.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStripModosForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlStripGuardar, Me.tlStripEditar, Me.tlStripEliminar, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.toolStripModosForm.Location = New System.Drawing.Point(0, 0)
        Me.toolStripModosForm.Name = "toolStripModosForm"
        Me.toolStripModosForm.Size = New System.Drawing.Size(1685, 28)
        Me.toolStripModosForm.TabIndex = 5
        Me.toolStripModosForm.Text = "ToolStrip1"
        '
        'tlStripGuardar
        '
        Me.tlStripGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlStripGuardar.Image = CType(resources.GetObject("tlStripGuardar.Image"), System.Drawing.Image)
        Me.tlStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlStripGuardar.Name = "tlStripGuardar"
        Me.tlStripGuardar.Size = New System.Drawing.Size(94, 25)
        Me.tlStripGuardar.Text = "REGISTRAR"
        '
        'tlStripEditar
        '
        Me.tlStripEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlStripEditar.Image = CType(resources.GetObject("tlStripEditar.Image"), System.Drawing.Image)
        Me.tlStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlStripEditar.Name = "tlStripEditar"
        Me.tlStripEditar.Size = New System.Drawing.Size(64, 25)
        Me.tlStripEditar.Text = "EDITAR"
        '
        'tlStripEliminar
        '
        Me.tlStripEliminar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tlStripEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlStripEliminar.Image = CType(resources.GetObject("tlStripEliminar.Image"), System.Drawing.Image)
        Me.tlStripEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlStripEliminar.Name = "tlStripEliminar"
        Me.tlStripEliminar.Size = New System.Drawing.Size(84, 25)
        Me.tlStripEliminar.Text = "ELIMINAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 25)
        Me.ToolStripButton1.Text = "←Volver A Menú"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'FormRegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 690)
        Me.Controls.Add(Me.toolStripModosForm)
        Me.Controls.Add(Me.panelAgregarPuesto)
        Me.Controls.Add(Me.panelAgregarArea)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRegistrarUsuario"
        Me.Text = "Registrar usuario"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelAgregarArea.ResumeLayout(False)
        Me.panelAgregarArea.PerformLayout()
        Me.panelAgregarPuesto.ResumeLayout(False)
        Me.panelAgregarPuesto.PerformLayout()
        Me.toolStripModosForm.ResumeLayout(False)
        Me.toolStripModosForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents hintCboxArea As System.Windows.Forms.Label
    Friend WithEvents cmboxArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents hintCboxPuesto As System.Windows.Forms.Label
    Friend WithEvents cmboxPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnMostrarMenuArea As System.Windows.Forms.Button
    Friend WithEvents btnMostrarMenuPuesto As System.Windows.Forms.Button
    Friend WithEvents txtAgregarArea As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents panelAgregarArea As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarArea As System.Windows.Forms.Button
    Friend WithEvents panelAgregarPuesto As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAgregarPuesto As System.Windows.Forms.TextBox
    Friend WithEvents hintCmboxAgregarArea As System.Windows.Forms.Label
    Friend WithEvents cmboxAsignarArea As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarPuesto As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents toolStripModosForm As System.Windows.Forms.ToolStrip
    Friend WithEvents tlStripGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlStripEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlStripEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents fmeCmboxUsername As System.Windows.Forms.ComboBox
    Friend WithEvents fmeLblBuscar As System.Windows.Forms.Label
    Friend WithEvents fmeTxtBuscarUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cboxTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents hintTIpo As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
