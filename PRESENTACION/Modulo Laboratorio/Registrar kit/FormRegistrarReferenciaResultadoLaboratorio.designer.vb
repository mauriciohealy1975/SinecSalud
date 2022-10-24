<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarReferenciaResultadoLaboratorio
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
        Me.panelDatosExamen = New System.Windows.Forms.Panel()
        Me.hintKitEquipo = New System.Windows.Forms.Label()
        Me.lblKitEquipo = New System.Windows.Forms.Label()
        Me.hintExamen = New System.Windows.Forms.Label()
        Me.cboxKitEquipo = New System.Windows.Forms.ComboBox()
        Me.cboxExamen = New System.Windows.Forms.ComboBox()
        Me.lblExamen = New System.Windows.Forms.Label()
        Me.hintSubarea = New System.Windows.Forms.Label()
        Me.cboxSubarea = New System.Windows.Forms.ComboBox()
        Me.lblTipoReferencia = New System.Windows.Forms.Label()
        Me.lblSubarea = New System.Windows.Forms.Label()
        Me.hintTipoReferencia = New System.Windows.Forms.Label()
        Me.hintArea = New System.Windows.Forms.Label()
        Me.cboxTipoReferencia = New System.Windows.Forms.ComboBox()
        Me.cboxArea = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvReferencias = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.lblHeaderEdad = New System.Windows.Forms.Label()
        Me.lblHeaderValores = New System.Windows.Forms.Label()
        Me.lblHeaderValoresMujeres = New System.Windows.Forms.Label()
        Me.lblHeaderValoresHombres = New System.Windows.Forms.Label()
        Me.btnAgregarFila = New System.Windows.Forms.Button()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelDatosExamen.SuspendLayout()
        CType(Me.dgvReferencias, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(869, 23)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(321, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(227, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR REFERENCIAS"
        '
        'panelDatosExamen
        '
        Me.panelDatosExamen.BackColor = System.Drawing.Color.White
        Me.panelDatosExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosExamen.Controls.Add(Me.hintKitEquipo)
        Me.panelDatosExamen.Controls.Add(Me.lblKitEquipo)
        Me.panelDatosExamen.Controls.Add(Me.hintExamen)
        Me.panelDatosExamen.Controls.Add(Me.cboxKitEquipo)
        Me.panelDatosExamen.Controls.Add(Me.cboxExamen)
        Me.panelDatosExamen.Controls.Add(Me.lblExamen)
        Me.panelDatosExamen.Controls.Add(Me.hintSubarea)
        Me.panelDatosExamen.Controls.Add(Me.cboxSubarea)
        Me.panelDatosExamen.Controls.Add(Me.lblTipoReferencia)
        Me.panelDatosExamen.Controls.Add(Me.lblSubarea)
        Me.panelDatosExamen.Controls.Add(Me.hintTipoReferencia)
        Me.panelDatosExamen.Controls.Add(Me.hintArea)
        Me.panelDatosExamen.Controls.Add(Me.cboxTipoReferencia)
        Me.panelDatosExamen.Controls.Add(Me.cboxArea)
        Me.panelDatosExamen.Controls.Add(Me.lblArea)
        Me.panelDatosExamen.Controls.Add(Me.Label2)
        Me.panelDatosExamen.Location = New System.Drawing.Point(30, 70)
        Me.panelDatosExamen.Name = "panelDatosExamen"
        Me.panelDatosExamen.Size = New System.Drawing.Size(869, 156)
        Me.panelDatosExamen.TabIndex = 12
        '
        'hintKitEquipo
        '
        Me.hintKitEquipo.AutoSize = True
        Me.hintKitEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintKitEquipo.Location = New System.Drawing.Point(532, 49)
        Me.hintKitEquipo.Name = "hintKitEquipo"
        Me.hintKitEquipo.Size = New System.Drawing.Size(82, 13)
        Me.hintKitEquipo.TabIndex = 91
        Me.hintKitEquipo.Text = "SELECCIONAR"
        '
        'lblKitEquipo
        '
        Me.lblKitEquipo.AutoSize = True
        Me.lblKitEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.lblKitEquipo.Location = New System.Drawing.Point(450, 45)
        Me.lblKitEquipo.Name = "lblKitEquipo"
        Me.lblKitEquipo.Size = New System.Drawing.Size(68, 16)
        Me.lblKitEquipo.TabIndex = 90
        Me.lblKitEquipo.Text = "Kit-Equipo"
        '
        'hintExamen
        '
        Me.hintExamen.AutoSize = True
        Me.hintExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintExamen.Location = New System.Drawing.Point(112, 119)
        Me.hintExamen.Name = "hintExamen"
        Me.hintExamen.Size = New System.Drawing.Size(82, 13)
        Me.hintExamen.TabIndex = 88
        Me.hintExamen.Text = "SELECCIONAR"
        '
        'cboxKitEquipo
        '
        Me.cboxKitEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxKitEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxKitEquipo.FormattingEnabled = True
        Me.cboxKitEquipo.Location = New System.Drawing.Point(528, 45)
        Me.cboxKitEquipo.Name = "cboxKitEquipo"
        Me.cboxKitEquipo.Size = New System.Drawing.Size(307, 23)
        Me.cboxKitEquipo.TabIndex = 92
        '
        'cboxExamen
        '
        Me.cboxExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxExamen.FormattingEnabled = True
        Me.cboxExamen.Location = New System.Drawing.Point(107, 115)
        Me.cboxExamen.Name = "cboxExamen"
        Me.cboxExamen.Size = New System.Drawing.Size(232, 23)
        Me.cboxExamen.TabIndex = 89
        '
        'lblExamen
        '
        Me.lblExamen.AutoSize = True
        Me.lblExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.lblExamen.Location = New System.Drawing.Point(43, 115)
        Me.lblExamen.Name = "lblExamen"
        Me.lblExamen.Size = New System.Drawing.Size(56, 16)
        Me.lblExamen.TabIndex = 87
        Me.lblExamen.Text = "Examen"
        '
        'hintSubarea
        '
        Me.hintSubarea.AutoSize = True
        Me.hintSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintSubarea.Location = New System.Drawing.Point(112, 84)
        Me.hintSubarea.Name = "hintSubarea"
        Me.hintSubarea.Size = New System.Drawing.Size(82, 13)
        Me.hintSubarea.TabIndex = 85
        Me.hintSubarea.Text = "SELECCIONAR"
        '
        'cboxSubarea
        '
        Me.cboxSubarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxSubarea.FormattingEnabled = True
        Me.cboxSubarea.Location = New System.Drawing.Point(107, 80)
        Me.cboxSubarea.Name = "cboxSubarea"
        Me.cboxSubarea.Size = New System.Drawing.Size(232, 23)
        Me.cboxSubarea.TabIndex = 86
        '
        'lblTipoReferencia
        '
        Me.lblTipoReferencia.AutoSize = True
        Me.lblTipoReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.lblTipoReferencia.Location = New System.Drawing.Point(401, 80)
        Me.lblTipoReferencia.Name = "lblTipoReferencia"
        Me.lblTipoReferencia.Size = New System.Drawing.Size(117, 16)
        Me.lblTipoReferencia.TabIndex = 74
        Me.lblTipoReferencia.Text = "Tipo de referencia"
        '
        'lblSubarea
        '
        Me.lblSubarea.AutoSize = True
        Me.lblSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.lblSubarea.Location = New System.Drawing.Point(40, 80)
        Me.lblSubarea.Name = "lblSubarea"
        Me.lblSubarea.Size = New System.Drawing.Size(59, 16)
        Me.lblSubarea.TabIndex = 84
        Me.lblSubarea.Text = "Subarea"
        '
        'hintTipoReferencia
        '
        Me.hintTipoReferencia.AutoSize = True
        Me.hintTipoReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintTipoReferencia.Location = New System.Drawing.Point(534, 85)
        Me.hintTipoReferencia.Name = "hintTipoReferencia"
        Me.hintTipoReferencia.Size = New System.Drawing.Size(82, 13)
        Me.hintTipoReferencia.TabIndex = 75
        Me.hintTipoReferencia.Text = "SELECCIONAR"
        '
        'hintArea
        '
        Me.hintArea.AutoSize = True
        Me.hintArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintArea.Location = New System.Drawing.Point(112, 49)
        Me.hintArea.Name = "hintArea"
        Me.hintArea.Size = New System.Drawing.Size(82, 13)
        Me.hintArea.TabIndex = 82
        Me.hintArea.Text = "SELECCIONAR"
        '
        'cboxTipoReferencia
        '
        Me.cboxTipoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxTipoReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxTipoReferencia.FormattingEnabled = True
        Me.cboxTipoReferencia.Location = New System.Drawing.Point(528, 80)
        Me.cboxTipoReferencia.Name = "cboxTipoReferencia"
        Me.cboxTipoReferencia.Size = New System.Drawing.Size(307, 23)
        Me.cboxTipoReferencia.TabIndex = 76
        '
        'cboxArea
        '
        Me.cboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxArea.FormattingEnabled = True
        Me.cboxArea.Location = New System.Drawing.Point(108, 45)
        Me.cboxArea.Name = "cboxArea"
        Me.cboxArea.Size = New System.Drawing.Size(231, 23)
        Me.cboxArea.TabIndex = 83
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.lblArea.Location = New System.Drawing.Point(63, 45)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(36, 16)
        Me.lblArea.TabIndex = 81
        Me.lblArea.Text = "Area"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "1.- Datos del examen"
        '
        'dgvReferencias
        '
        Me.dgvReferencias.BackgroundColor = System.Drawing.Color.White
        Me.dgvReferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvReferencias.Location = New System.Drawing.Point(30, 270)
        Me.dgvReferencias.Name = "dgvReferencias"
        Me.dgvReferencias.Size = New System.Drawing.Size(665, 155)
        Me.dgvReferencias.TabIndex = 54
        '
        'Column1
        '
        Me.Column1.HeaderText = "DESDE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "HASTA"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "DESDE"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "HASTA"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnEnviarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarDatos.Location = New System.Drawing.Point(758, 397)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(141, 28)
        Me.btnEnviarDatos.TabIndex = 55
        Me.btnEnviarDatos.Text = "Guardar referencias"
        Me.btnEnviarDatos.UseVisualStyleBackColor = False
        '
        'lblHeaderEdad
        '
        Me.lblHeaderEdad.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblHeaderEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeaderEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblHeaderEdad.Location = New System.Drawing.Point(74, 245)
        Me.lblHeaderEdad.Name = "lblHeaderEdad"
        Me.lblHeaderEdad.Size = New System.Drawing.Size(200, 25)
        Me.lblHeaderEdad.TabIndex = 62
        Me.lblHeaderEdad.Text = "EDAD (AÑOS)"
        Me.lblHeaderEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeaderValores
        '
        Me.lblHeaderValores.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblHeaderValores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeaderValores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblHeaderValores.Location = New System.Drawing.Point(268, 245)
        Me.lblHeaderValores.Name = "lblHeaderValores"
        Me.lblHeaderValores.Size = New System.Drawing.Size(209, 25)
        Me.lblHeaderValores.TabIndex = 61
        Me.lblHeaderValores.Text = "VALORES %"
        Me.lblHeaderValores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeaderValoresMujeres
        '
        Me.lblHeaderValoresMujeres.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblHeaderValoresMujeres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeaderValoresMujeres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblHeaderValoresMujeres.Location = New System.Drawing.Point(-179, 242)
        Me.lblHeaderValoresMujeres.Name = "lblHeaderValoresMujeres"
        Me.lblHeaderValoresMujeres.Size = New System.Drawing.Size(203, 25)
        Me.lblHeaderValoresMujeres.TabIndex = 63
        Me.lblHeaderValoresMujeres.Text = "VALORES EN ? - MUJERES"
        Me.lblHeaderValoresMujeres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeaderValoresHombres
        '
        Me.lblHeaderValoresHombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblHeaderValoresHombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeaderValoresHombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblHeaderValoresHombres.Location = New System.Drawing.Point(-178, 279)
        Me.lblHeaderValoresHombres.Name = "lblHeaderValoresHombres"
        Me.lblHeaderValoresHombres.Size = New System.Drawing.Size(202, 25)
        Me.lblHeaderValoresHombres.TabIndex = 64
        Me.lblHeaderValoresHombres.Text = "VALORES EN ? - HOMBRES "
        Me.lblHeaderValoresHombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregarFila
        '
        Me.btnAgregarFila.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarFila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnAgregarFila.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarFila.Location = New System.Drawing.Point(701, 270)
        Me.btnAgregarFila.Name = "btnAgregarFila"
        Me.btnAgregarFila.Size = New System.Drawing.Size(86, 25)
        Me.btnAgregarFila.TabIndex = 65
        Me.btnAgregarFila.Text = "Agregar fila"
        Me.btnAgregarFila.UseVisualStyleBackColor = False
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(929, 24)
        Me.menuStrip.TabIndex = 66
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
        'FormRegistrarReferenciaResultadoLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(929, 454)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.btnAgregarFila)
        Me.Controls.Add(Me.lblHeaderValoresHombres)
        Me.Controls.Add(Me.lblHeaderValoresMujeres)
        Me.Controls.Add(Me.lblHeaderEdad)
        Me.Controls.Add(Me.lblHeaderValores)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.dgvReferencias)
        Me.Controls.Add(Me.panelDatosExamen)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarReferenciaResultadoLaboratorio"
        Me.Text = "Registrar referencias"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelDatosExamen.ResumeLayout(False)
        Me.panelDatosExamen.PerformLayout()
        CType(Me.dgvReferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents panelDatosExamen As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents hintTipoReferencia As Label
    Friend WithEvents cboxTipoReferencia As ComboBox
    Friend WithEvents lblTipoReferencia As Label
    Friend WithEvents dgvReferencias As DataGridView
    Friend WithEvents btnEnviarDatos As Button
    Friend WithEvents lblArea As Label
    Friend WithEvents lblKitEquipo As Label
    Friend WithEvents hintExamen As Label
    Friend WithEvents cboxExamen As ComboBox
    Friend WithEvents lblExamen As Label
    Friend WithEvents hintSubarea As Label
    Friend WithEvents cboxSubarea As ComboBox
    Friend WithEvents lblSubarea As Label
    Friend WithEvents hintArea As Label
    Friend WithEvents cboxArea As ComboBox
    Friend WithEvents hintKitEquipo As Label
    Friend WithEvents cboxKitEquipo As ComboBox
    Friend WithEvents lblHeaderEdad As Label
    Friend WithEvents lblHeaderValores As Label
    Friend WithEvents lblHeaderValoresMujeres As Label
    Friend WithEvents lblHeaderValoresHombres As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents btnAgregarFila As Button
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
