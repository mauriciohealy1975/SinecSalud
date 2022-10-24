<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAsignarControlPrestaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAsignarControlPrestaciones))
        Me.toolStripModificar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripModos = New System.Windows.Forms.ToolStrip()
        Me.toolStripRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboxGrupoCP = New System.Windows.Forms.ComboBox()
        Me.hintGrupoCP = New System.Windows.Forms.Label()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.panelAsignacion = New System.Windows.Forms.Panel()
        Me.lblRelacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lboxDetalle = New System.Windows.Forms.ListBox()
        Me.hintTipoCP = New System.Windows.Forms.Label()
        Me.hintReceptor = New System.Windows.Forms.Label()
        Me.cboxReceptor = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboxCP = New System.Windows.Forms.ComboBox()
        Me.panelDetalle = New System.Windows.Forms.Panel()
        Me.gboxEstado = New System.Windows.Forms.GroupBox()
        Me.rButtonCancelada = New System.Windows.Forms.RadioButton()
        Me.rButtonVigente = New System.Windows.Forms.RadioButton()
        Me.dpcFechaLimiteAtencion = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.toolStripModos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelAsignacion.SuspendLayout()
        Me.panelDetalle.SuspendLayout()
        Me.gboxEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStripModificar
        '
        Me.toolStripModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripModificar.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.toolStripModificar.Image = CType(resources.GetObject("toolStripModificar.Image"), System.Drawing.Image)
        Me.toolStripModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripModificar.Name = "toolStripModificar"
        Me.toolStripModificar.Size = New System.Drawing.Size(79, 22)
        Me.toolStripModificar.Text = "MODIFICAR"
        '
        'toolStripModos
        '
        Me.toolStripModos.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.toolStripModos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripRegistrar, Me.toolStripModificar})
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
        'btnAdicionar
        '
        Me.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.ForeColor = System.Drawing.Color.Black
        Me.btnAdicionar.Location = New System.Drawing.Point(403, 683)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(133, 28)
        Me.btnAdicionar.TabIndex = 72
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(1066, 508)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(169, 28)
        Me.btnEnviar.TabIndex = 4
        Me.btnEnviar.Text = "Registrar control"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(981, 508)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 28)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(437, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(330, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "APLICAR CONTROL DE PRESTACIONES"
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
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(321, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1.- Asignación de control de prestaciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Aplicar"
        '
        'cboxGrupoCP
        '
        Me.cboxGrupoCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxGrupoCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxGrupoCP.FormattingEnabled = True
        Me.cboxGrupoCP.Location = New System.Drawing.Point(83, 50)
        Me.cboxGrupoCP.Name = "cboxGrupoCP"
        Me.cboxGrupoCP.Size = New System.Drawing.Size(159, 23)
        Me.cboxGrupoCP.TabIndex = 1
        '
        'hintGrupoCP
        '
        Me.hintGrupoCP.AutoSize = True
        Me.hintGrupoCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintGrupoCP.Location = New System.Drawing.Point(88, 55)
        Me.hintGrupoCP.Name = "hintGrupoCP"
        Me.hintGrupoCP.Size = New System.Drawing.Size(82, 13)
        Me.hintGrupoCP.TabIndex = 0
        Me.hintGrupoCP.Text = "SELECCIONAR"
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.Location = New System.Drawing.Point(15, 85)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(62, 16)
        Me.lblBusqueda.TabIndex = 0
        Me.lblBusqueda.Text = "Matrícula"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(83, 87)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(159, 21)
        Me.txtBusqueda.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(248, 85)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'panelAsignacion
        '
        Me.panelAsignacion.BackColor = System.Drawing.Color.White
        Me.panelAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAsignacion.Controls.Add(Me.lblRelacion)
        Me.panelAsignacion.Controls.Add(Me.Label2)
        Me.panelAsignacion.Controls.Add(Me.lboxDetalle)
        Me.panelAsignacion.Controls.Add(Me.hintTipoCP)
        Me.panelAsignacion.Controls.Add(Me.hintReceptor)
        Me.panelAsignacion.Controls.Add(Me.cboxReceptor)
        Me.panelAsignacion.Controls.Add(Me.Label11)
        Me.panelAsignacion.Controls.Add(Me.cboxCP)
        Me.panelAsignacion.Controls.Add(Me.btnBuscar)
        Me.panelAsignacion.Controls.Add(Me.txtBusqueda)
        Me.panelAsignacion.Controls.Add(Me.lblBusqueda)
        Me.panelAsignacion.Controls.Add(Me.hintGrupoCP)
        Me.panelAsignacion.Controls.Add(Me.cboxGrupoCP)
        Me.panelAsignacion.Controls.Add(Me.Label8)
        Me.panelAsignacion.Controls.Add(Me.Label7)
        Me.panelAsignacion.Location = New System.Drawing.Point(30, 80)
        Me.panelAsignacion.Name = "panelAsignacion"
        Me.panelAsignacion.Size = New System.Drawing.Size(655, 190)
        Me.panelAsignacion.TabIndex = 1
        '
        'lblRelacion
        '
        Me.lblRelacion.AutoSize = True
        Me.lblRelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelacion.Location = New System.Drawing.Point(15, 155)
        Me.lblRelacion.Name = "lblRelacion"
        Me.lblRelacion.Size = New System.Drawing.Size(138, 16)
        Me.lblRelacion.TabIndex = 0
        Me.lblRelacion.Text = "Relación con el titular:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Detalle"
        '
        'lboxDetalle
        '
        Me.lboxDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxDetalle.FormattingEnabled = True
        Me.lboxDetalle.ItemHeight = 15
        Me.lboxDetalle.Location = New System.Drawing.Point(432, 87)
        Me.lboxDetalle.Name = "lboxDetalle"
        Me.lboxDetalle.Size = New System.Drawing.Size(205, 49)
        Me.lboxDetalle.TabIndex = 6
        '
        'hintTipoCP
        '
        Me.hintTipoCP.AutoSize = True
        Me.hintTipoCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintTipoCP.Location = New System.Drawing.Point(438, 54)
        Me.hintTipoCP.Name = "hintTipoCP"
        Me.hintTipoCP.Size = New System.Drawing.Size(82, 13)
        Me.hintTipoCP.TabIndex = 0
        Me.hintTipoCP.Text = "SELECCIONAR"
        '
        'hintReceptor
        '
        Me.hintReceptor.AutoSize = True
        Me.hintReceptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintReceptor.Location = New System.Drawing.Point(20, 125)
        Me.hintReceptor.Name = "hintReceptor"
        Me.hintReceptor.Size = New System.Drawing.Size(82, 13)
        Me.hintReceptor.TabIndex = 0
        Me.hintReceptor.Text = "SELECCIONAR"
        '
        'cboxReceptor
        '
        Me.cboxReceptor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxReceptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxReceptor.FormattingEnabled = True
        Me.cboxReceptor.Location = New System.Drawing.Point(15, 120)
        Me.cboxReceptor.Name = "cboxReceptor"
        Me.cboxReceptor.Size = New System.Drawing.Size(300, 23)
        Me.cboxReceptor.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(376, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Control"
        '
        'cboxCP
        '
        Me.cboxCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCP.FormattingEnabled = True
        Me.cboxCP.Location = New System.Drawing.Point(432, 50)
        Me.cboxCP.Name = "cboxCP"
        Me.cboxCP.Size = New System.Drawing.Size(205, 21)
        Me.cboxCP.TabIndex = 5
        '
        'panelDetalle
        '
        Me.panelDetalle.BackColor = System.Drawing.Color.White
        Me.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDetalle.Controls.Add(Me.gboxEstado)
        Me.panelDetalle.Controls.Add(Me.dpcFechaLimiteAtencion)
        Me.panelDetalle.Controls.Add(Me.Label1)
        Me.panelDetalle.Controls.Add(Me.Label13)
        Me.panelDetalle.Location = New System.Drawing.Point(30, 303)
        Me.panelDetalle.Name = "panelDetalle"
        Me.panelDetalle.Size = New System.Drawing.Size(337, 170)
        Me.panelDetalle.TabIndex = 2
        '
        'gboxEstado
        '
        Me.gboxEstado.Controls.Add(Me.rButtonCancelada)
        Me.gboxEstado.Controls.Add(Me.rButtonVigente)
        Me.gboxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxEstado.Location = New System.Drawing.Point(15, 85)
        Me.gboxEstado.Name = "gboxEstado"
        Me.gboxEstado.Size = New System.Drawing.Size(115, 71)
        Me.gboxEstado.TabIndex = 2
        Me.gboxEstado.TabStop = False
        Me.gboxEstado.Text = "Estado"
        '
        'rButtonCancelada
        '
        Me.rButtonCancelada.AutoSize = True
        Me.rButtonCancelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonCancelada.Location = New System.Drawing.Point(10, 41)
        Me.rButtonCancelada.Name = "rButtonCancelada"
        Me.rButtonCancelada.Size = New System.Drawing.Size(84, 19)
        Me.rButtonCancelada.TabIndex = 1
        Me.rButtonCancelada.TabStop = True
        Me.rButtonCancelada.Text = "Cancelada"
        Me.rButtonCancelada.UseVisualStyleBackColor = True
        '
        'rButtonVigente
        '
        Me.rButtonVigente.AutoSize = True
        Me.rButtonVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rButtonVigente.Location = New System.Drawing.Point(10, 21)
        Me.rButtonVigente.Name = "rButtonVigente"
        Me.rButtonVigente.Size = New System.Drawing.Size(66, 19)
        Me.rButtonVigente.TabIndex = 1
        Me.rButtonVigente.TabStop = True
        Me.rButtonVigente.Text = "Vigente"
        Me.rButtonVigente.UseVisualStyleBackColor = True
        '
        'dpcFechaLimiteAtencion
        '
        Me.dpcFechaLimiteAtencion.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame
        Me.dpcFechaLimiteAtencion.CustomFormat = "dd--MM--yyyy"
        Me.dpcFechaLimiteAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcFechaLimiteAtencion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcFechaLimiteAtencion.Location = New System.Drawing.Point(174, 50)
        Me.dpcFechaLimiteAtencion.Name = "dpcFechaLimiteAtencion"
        Me.dpcFechaLimiteAtencion.ShowUpDown = True
        Me.dpcFechaLimiteAtencion.Size = New System.Drawing.Size(114, 21)
        Me.dpcFechaLimiteAtencion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha límite de atención"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(15, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(243, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "2.- Detalle del control asignado"
        '
        'FormAplicarControlPrestaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.panelDetalle)
        Me.Controls.Add(Me.toolStripModos)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.panelAsignacion)
        Me.Name = "FormAplicarControlPrestaciones"
        Me.Text = "FormAsignarControlPrestaciones"
        Me.toolStripModos.ResumeLayout(False)
        Me.toolStripModos.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelAsignacion.ResumeLayout(False)
        Me.panelAsignacion.PerformLayout()
        Me.panelDetalle.ResumeLayout(False)
        Me.panelDetalle.PerformLayout()
        Me.gboxEstado.ResumeLayout(False)
        Me.gboxEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolStripModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripModos As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripRegistrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboxGrupoCP As System.Windows.Forms.ComboBox
    Friend WithEvents hintGrupoCP As System.Windows.Forms.Label
    Friend WithEvents lblBusqueda As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents panelAsignacion As System.Windows.Forms.Panel
    Friend WithEvents cboxCP As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents hintReceptor As System.Windows.Forms.Label
    Friend WithEvents cboxReceptor As System.Windows.Forms.ComboBox
    Friend WithEvents hintTipoCP As System.Windows.Forms.Label
    Friend WithEvents panelDetalle As System.Windows.Forms.Panel
    Friend WithEvents dpcFechaLimiteAtencion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gboxEstado As System.Windows.Forms.GroupBox
    Friend WithEvents rButtonCancelada As System.Windows.Forms.RadioButton
    Friend WithEvents rButtonVigente As System.Windows.Forms.RadioButton
    Friend WithEvents lboxDetalle As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRelacion As System.Windows.Forms.Label
End Class
