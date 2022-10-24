<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarOrdenLaboratorio
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
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clistExamen = New System.Windows.Forms.CheckedListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvExamenes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.lboxAreas = New System.Windows.Forms.ListBox()
        Me.btnAgregarExamenes = New System.Windows.Forms.Button()
        Me.btnCancelarOrden = New System.Windows.Forms.Button()
        Me.cboxMedico = New System.Windows.Forms.ComboBox()
        Me.cboxAsegurado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelDatosExamen = New System.Windows.Forms.Panel()
        Me.hintAsegurado = New System.Windows.Forms.Label()
        Me.hintMedico = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDatosExamen.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1198, 22)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(436, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(326, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR ORDEN DE LABORATORIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Medico"
        '
        'clistExamen
        '
        Me.clistExamen.CheckOnClick = True
        Me.clistExamen.FormattingEnabled = True
        Me.clistExamen.Location = New System.Drawing.Point(218, 65)
        Me.clistExamen.MultiColumn = True
        Me.clistExamen.Name = "clistExamen"
        Me.clistExamen.Size = New System.Drawing.Size(539, 154)
        Me.clistExamen.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(215, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Examenes"
        '
        'dgvExamenes
        '
        Me.dgvExamenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExamenes.BackgroundColor = System.Drawing.Color.White
        Me.dgvExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExamenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvExamenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvExamenes.Location = New System.Drawing.Point(775, 45)
        Me.dgvExamenes.Name = "dgvExamenes"
        Me.dgvExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExamenes.Size = New System.Drawing.Size(405, 252)
        Me.dgvExamenes.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.FillWeight = 75.0!
        Me.Column1.HeaderText = "EXAMEN"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.FillWeight = 25.0!
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.Location = New System.Drawing.Point(1060, 505)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(168, 28)
        Me.btnEnviarDatos.TabIndex = 9
        Me.btnEnviarDatos.Text = "Registrar orden"
        Me.btnEnviarDatos.UseVisualStyleBackColor = True
        '
        'lboxAreas
        '
        Me.lboxAreas.FormattingEnabled = True
        Me.lboxAreas.Location = New System.Drawing.Point(18, 65)
        Me.lboxAreas.Name = "lboxAreas"
        Me.lboxAreas.Size = New System.Drawing.Size(179, 147)
        Me.lboxAreas.TabIndex = 5
        '
        'btnAgregarExamenes
        '
        Me.btnAgregarExamenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarExamenes.Location = New System.Drawing.Point(587, 228)
        Me.btnAgregarExamenes.Name = "btnAgregarExamenes"
        Me.btnAgregarExamenes.Size = New System.Drawing.Size(170, 28)
        Me.btnAgregarExamenes.TabIndex = 7
        Me.btnAgregarExamenes.Text = "Agregar examenes"
        Me.btnAgregarExamenes.UseVisualStyleBackColor = True
        '
        'btnCancelarOrden
        '
        Me.btnCancelarOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarOrden.Location = New System.Drawing.Point(987, 505)
        Me.btnCancelarOrden.Name = "btnCancelarOrden"
        Me.btnCancelarOrden.Size = New System.Drawing.Size(67, 28)
        Me.btnCancelarOrden.TabIndex = 9
        Me.btnCancelarOrden.Text = "Cancelar"
        Me.btnCancelarOrden.UseVisualStyleBackColor = True
        '
        'cboxMedico
        '
        Me.cboxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMedico.FormattingEnabled = True
        Me.cboxMedico.Location = New System.Drawing.Point(65, 45)
        Me.cboxMedico.Name = "cboxMedico"
        Me.cboxMedico.Size = New System.Drawing.Size(250, 23)
        Me.cboxMedico.TabIndex = 10
        '
        'cboxAsegurado
        '
        Me.cboxAsegurado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxAsegurado.FormattingEnabled = True
        Me.cboxAsegurado.Location = New System.Drawing.Point(427, 45)
        Me.cboxAsegurado.Name = "cboxAsegurado"
        Me.cboxAsegurado.Size = New System.Drawing.Size(336, 23)
        Me.cboxAsegurado.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Asegurado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(15, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "1.- Información general"
        '
        'panelDatosExamen
        '
        Me.panelDatosExamen.BackColor = System.Drawing.Color.White
        Me.panelDatosExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatosExamen.Controls.Add(Me.hintAsegurado)
        Me.panelDatosExamen.Controls.Add(Me.hintMedico)
        Me.panelDatosExamen.Controls.Add(Me.cboxAsegurado)
        Me.panelDatosExamen.Controls.Add(Me.Label1)
        Me.panelDatosExamen.Controls.Add(Me.cboxMedico)
        Me.panelDatosExamen.Controls.Add(Me.Label9)
        Me.panelDatosExamen.Controls.Add(Me.Label4)
        Me.panelDatosExamen.Location = New System.Drawing.Point(30, 70)
        Me.panelDatosExamen.Name = "panelDatosExamen"
        Me.panelDatosExamen.Size = New System.Drawing.Size(781, 87)
        Me.panelDatosExamen.TabIndex = 13
        '
        'hintAsegurado
        '
        Me.hintAsegurado.AutoSize = True
        Me.hintAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintAsegurado.Location = New System.Drawing.Point(432, 50)
        Me.hintAsegurado.Name = "hintAsegurado"
        Me.hintAsegurado.Size = New System.Drawing.Size(82, 13)
        Me.hintAsegurado.TabIndex = 94
        Me.hintAsegurado.Text = "SELECCIONAR"
        '
        'hintMedico
        '
        Me.hintMedico.AutoSize = True
        Me.hintMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.hintMedico.Location = New System.Drawing.Point(69, 50)
        Me.hintMedico.Name = "hintMedico"
        Me.hintMedico.Size = New System.Drawing.Size(82, 13)
        Me.hintMedico.TabIndex = 93
        Me.hintMedico.Text = "SELECCIONAR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lboxAreas)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btnAgregarExamenes)
        Me.Panel1.Controls.Add(Me.dgvExamenes)
        Me.Panel1.Controls.Add(Me.clistExamen)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(30, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1198, 314)
        Me.Panel1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Areas"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(15, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "2.- Seleccionar examenes"
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1264, 24)
        Me.menuStrip.TabIndex = 15
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
        'FormRegistrarOrdenLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelDatosExamen)
        Me.Controls.Add(Me.btnCancelarOrden)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "FormRegistrarOrdenLaboratorio"
        Me.Text = "Registrar orden de laboratorio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDatosExamen.ResumeLayout(False)
        Me.panelDatosExamen.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents clistExamen As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvExamenes As System.Windows.Forms.DataGridView
    Friend WithEvents btnEnviarDatos As System.Windows.Forms.Button
    Friend WithEvents lboxAreas As System.Windows.Forms.ListBox
    Friend WithEvents btnAgregarExamenes As System.Windows.Forms.Button
    Friend WithEvents btnCancelarOrden As System.Windows.Forms.Button
    Friend WithEvents cboxMedico As ComboBox
    Friend WithEvents cboxAsegurado As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents panelDatosExamen As Panel
    Friend WithEvents hintAsegurado As Label
    Friend WithEvents hintMedico As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
