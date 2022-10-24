<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarAreaLaboratorio
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
        Me.panelArea = New System.Windows.Forms.Panel()
        Me.txtAreaPanelArea = New System.Windows.Forms.TextBox()
        Me.lblApellidoPaterno = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegistrarArea = New System.Windows.Forms.Button()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelArea.SuspendLayout()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(424, 23)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(57, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(310, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR AREA DE LABORATORIO"
        '
        'panelArea
        '
        Me.panelArea.BackColor = System.Drawing.Color.White
        Me.panelArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelArea.Controls.Add(Me.txtAreaPanelArea)
        Me.panelArea.Controls.Add(Me.lblApellidoPaterno)
        Me.panelArea.Controls.Add(Me.Label4)
        Me.panelArea.Location = New System.Drawing.Point(30, 70)
        Me.panelArea.Name = "panelArea"
        Me.panelArea.Size = New System.Drawing.Size(424, 95)
        Me.panelArea.TabIndex = 9
        '
        'txtAreaPanelArea
        '
        Me.txtAreaPanelArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaPanelArea.Location = New System.Drawing.Point(131, 48)
        Me.txtAreaPanelArea.Name = "txtAreaPanelArea"
        Me.txtAreaPanelArea.Size = New System.Drawing.Size(274, 21)
        Me.txtAreaPanelArea.TabIndex = 7
        '
        'lblApellidoPaterno
        '
        Me.lblApellidoPaterno.AutoSize = True
        Me.lblApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoPaterno.Location = New System.Drawing.Point(15, 48)
        Me.lblApellidoPaterno.Name = "lblApellidoPaterno"
        Me.lblApellidoPaterno.Size = New System.Drawing.Size(109, 16)
        Me.lblApellidoPaterno.TabIndex = 6
        Me.lblApellidoPaterno.Text = "Nombre del area"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Datos del area"
        '
        'btnRegistrarArea
        '
        Me.btnRegistrarArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarArea.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarArea.Location = New System.Drawing.Point(334, 180)
        Me.btnRegistrarArea.Name = "btnRegistrarArea"
        Me.btnRegistrarArea.Size = New System.Drawing.Size(120, 28)
        Me.btnRegistrarArea.TabIndex = 8
        Me.btnRegistrarArea.Text = "Registrar area "
        Me.btnRegistrarArea.UseVisualStyleBackColor = False
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(484, 24)
        Me.menuStrip.TabIndex = 16
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
        'FormRegistrarAreaLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 229)
        Me.Controls.Add(Me.btnRegistrarArea)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.panelArea)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarAreaLaboratorio"
        Me.Text = "Registrar area de laboratorio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelArea.ResumeLayout(False)
        Me.panelArea.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents panelArea As Panel
    Friend WithEvents btnRegistrarArea As Button
    Friend WithEvents txtAreaPanelArea As TextBox
    Friend WithEvents lblApellidoPaterno As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
