<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarAsignacionAreasLab
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
        Me.clistAreas = New System.Windows.Forms.CheckedListBox()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.cboxProcesador = New System.Windows.Forms.ComboBox()
        Me.hintProcesador = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelAreas = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelAreas.SuspendLayout()
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(615, 25)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(97, 2)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(420, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "ASIGNAR PERMISOS DE AREAS DE LABORATORIO"
        '
        'clistAreas
        '
        Me.clistAreas.CheckOnClick = True
        Me.clistAreas.FormattingEnabled = True
        Me.clistAreas.Location = New System.Drawing.Point(25, 110)
        Me.clistAreas.Name = "clistAreas"
        Me.clistAreas.Size = New System.Drawing.Size(329, 154)
        Me.clistAreas.TabIndex = 1
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.Location = New System.Drawing.Point(501, 335)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(144, 28)
        Me.btnEnviarDatos.TabIndex = 4
        Me.btnEnviarDatos.Text = "Registrar permisos"
        Me.btnEnviarDatos.UseVisualStyleBackColor = True
        '
        'cboxProcesador
        '
        Me.cboxProcesador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxProcesador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxProcesador.FormattingEnabled = True
        Me.cboxProcesador.Location = New System.Drawing.Point(95, 45)
        Me.cboxProcesador.Name = "cboxProcesador"
        Me.cboxProcesador.Size = New System.Drawing.Size(259, 23)
        Me.cboxProcesador.TabIndex = 1
        '
        'hintProcesador
        '
        Me.hintProcesador.AutoSize = True
        Me.hintProcesador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintProcesador.Location = New System.Drawing.Point(97, 49)
        Me.hintProcesador.Name = "hintProcesador"
        Me.hintProcesador.Size = New System.Drawing.Size(91, 15)
        Me.hintProcesador.TabIndex = 0
        Me.hintProcesador.Text = "SELECCIONAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buiquímico "
        '
        'panelAreas
        '
        Me.panelAreas.BackColor = System.Drawing.Color.White
        Me.panelAreas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAreas.Controls.Add(Me.hintProcesador)
        Me.panelAreas.Controls.Add(Me.Label5)
        Me.panelAreas.Controls.Add(Me.Label3)
        Me.panelAreas.Controls.Add(Me.Label7)
        Me.panelAreas.Controls.Add(Me.clistAreas)
        Me.panelAreas.Controls.Add(Me.cboxProcesador)
        Me.panelAreas.Location = New System.Drawing.Point(30, 75)
        Me.panelAreas.Name = "panelAreas"
        Me.panelAreas.Size = New System.Drawing.Size(397, 288)
        Me.panelAreas.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Areas asignadas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1.- Asignar areas "
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(668, 24)
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
        'FormRegistrarAsignacionAreasLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 386)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.panelAreas)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarAsignacionAreasLab"
        Me.Text = "Asignar permisos de areas de laboratorio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelAreas.ResumeLayout(False)
        Me.panelAreas.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents clistAreas As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnEnviarDatos As System.Windows.Forms.Button
    Friend WithEvents cboxProcesador As System.Windows.Forms.ComboBox
    Friend WithEvents hintProcesador As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelAreas As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
