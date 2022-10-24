<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarConjuntoOpcionesResultadoLaboratorio
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreConjunto = New System.Windows.Forms.TextBox()
        Me.dgvOpciones = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarFila = New System.Windows.Forms.Button()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(576, 23)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(57, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(461, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR CONJUNTO DE OPCIONES DE RESULTADO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nombre del conjunto de opciones"
        '
        'txtNombreConjunto
        '
        Me.txtNombreConjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreConjunto.Location = New System.Drawing.Point(30, 100)
        Me.txtNombreConjunto.Name = "txtNombreConjunto"
        Me.txtNombreConjunto.Size = New System.Drawing.Size(245, 21)
        Me.txtNombreConjunto.TabIndex = 17
        '
        'dgvOpciones
        '
        Me.dgvOpciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOpciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOpciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvOpciones.Location = New System.Drawing.Point(30, 165)
        Me.dgvOpciones.Name = "dgvOpciones"
        Me.dgvOpciones.Size = New System.Drawing.Size(323, 210)
        Me.dgvOpciones.TabIndex = 55
        '
        'Column1
        '
        Me.Column1.HeaderText = "OPCION"
        Me.Column1.Name = "Column1"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnEnviarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarDatos.Location = New System.Drawing.Point(380, 347)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(226, 28)
        Me.btnEnviarDatos.TabIndex = 56
        Me.btnEnviarDatos.Text = "Registrar conjunto de opciones"
        Me.btnEnviarDatos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Opciones de este conjunto"
        '
        'btnAgregarFila
        '
        Me.btnAgregarFila.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarFila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnAgregarFila.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarFila.Location = New System.Drawing.Point(359, 165)
        Me.btnAgregarFila.Name = "btnAgregarFila"
        Me.btnAgregarFila.Size = New System.Drawing.Size(116, 25)
        Me.btnAgregarFila.TabIndex = 66
        Me.btnAgregarFila.Text = "Agregar fila"
        Me.btnAgregarFila.UseVisualStyleBackColor = False
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(639, 24)
        Me.menuStrip.TabIndex = 67
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
        'FormRegistrarConjuntoOpcionesResultadoLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 404)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.btnAgregarFila)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvOpciones)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.txtNombreConjunto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarConjuntoOpcionesResultadoLaboratorio"
        Me.Text = "Registrar conjunto de opciones de resultado"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreConjunto As TextBox
    Friend WithEvents dgvOpciones As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents btnEnviarDatos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarFila As Button
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
