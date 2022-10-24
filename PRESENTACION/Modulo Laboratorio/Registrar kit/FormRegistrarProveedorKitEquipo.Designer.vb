<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarProveedorKitEquipo
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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.panelProveedor = New System.Windows.Forms.Panel()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.lblApellidoPaterno = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.menuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStripMenu})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(484, 24)
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
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(39, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(346, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR PROVEEDOR DE KIT-EQUIPO"
        '
        'panelProveedor
        '
        Me.panelProveedor.BackColor = System.Drawing.Color.White
        Me.panelProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelProveedor.Controls.Add(Me.txtProveedor)
        Me.panelProveedor.Controls.Add(Me.lblApellidoPaterno)
        Me.panelProveedor.Controls.Add(Me.Label4)
        Me.panelProveedor.Location = New System.Drawing.Point(30, 67)
        Me.panelProveedor.Name = "panelProveedor"
        Me.panelProveedor.Size = New System.Drawing.Size(424, 95)
        Me.panelProveedor.TabIndex = 19
        '
        'txtProveedor
        '
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(165, 48)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(240, 21)
        Me.txtProveedor.TabIndex = 7
        '
        'lblApellidoPaterno
        '
        Me.lblApellidoPaterno.AutoSize = True
        Me.lblApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoPaterno.Location = New System.Drawing.Point(15, 48)
        Me.lblApellidoPaterno.Name = "lblApellidoPaterno"
        Me.lblApellidoPaterno.Size = New System.Drawing.Size(144, 16)
        Me.lblApellidoPaterno.TabIndex = 6
        Me.lblApellidoPaterno.Text = "Nombre del proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Datos del proveedor"
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnEnviarDatos.Location = New System.Drawing.Point(317, 180)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(137, 28)
        Me.btnEnviarDatos.TabIndex = 20
        Me.btnEnviarDatos.Text = "Registrar proveedor"
        Me.btnEnviarDatos.UseVisualStyleBackColor = False
        '
        'FormRegistrarProveedorKitEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 229)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.panelProveedor)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.menuStrip)
        Me.Name = "FormRegistrarProveedorKitEquipo"
        Me.Text = "FormRegistrarProveedorKitEquipo"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelProveedor.ResumeLayout(False)
        Me.panelProveedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents panelProveedor As Panel
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents lblApellidoPaterno As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEnviarDatos As Button
End Class
