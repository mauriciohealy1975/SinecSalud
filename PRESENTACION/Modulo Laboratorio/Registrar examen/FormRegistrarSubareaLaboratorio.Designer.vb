<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarSubareaLaboratorio
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.hintAreaPanelSubarea = New System.Windows.Forms.Label()
        Me.cboxAreaPanelSubarea = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegistrarSubarea = New System.Windows.Forms.Button()
        Me.txtSubareaPanelSubarea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStripMenuLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.hintAreaPanelSubarea)
        Me.Panel1.Controls.Add(Me.cboxAreaPanelSubarea)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSubareaPanelSubarea)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(30, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 126)
        Me.Panel1.TabIndex = 10
        '
        'hintAreaPanelSubarea
        '
        Me.hintAreaPanelSubarea.AutoSize = True
        Me.hintAreaPanelSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintAreaPanelSubarea.Location = New System.Drawing.Point(157, 51)
        Me.hintAreaPanelSubarea.Name = "hintAreaPanelSubarea"
        Me.hintAreaPanelSubarea.Size = New System.Drawing.Size(82, 13)
        Me.hintAreaPanelSubarea.TabIndex = 11
        Me.hintAreaPanelSubarea.Text = "SELECCIONAR"
        '
        'cboxAreaPanelSubarea
        '
        Me.cboxAreaPanelSubarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAreaPanelSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxAreaPanelSubarea.FormattingEnabled = True
        Me.cboxAreaPanelSubarea.Items.AddRange(New Object() {"SC", "LP", "CO", "BE", "PA", "OR", "PO", "CH", "TA"})
        Me.cboxAreaPanelSubarea.Location = New System.Drawing.Point(153, 46)
        Me.cboxAreaPanelSubarea.Name = "cboxAreaPanelSubarea"
        Me.cboxAreaPanelSubarea.Size = New System.Drawing.Size(249, 23)
        Me.cboxAreaPanelSubarea.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Area"
        '
        'btnRegistrarSubarea
        '
        Me.btnRegistrarSubarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarSubarea.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarSubarea.Location = New System.Drawing.Point(330, 212)
        Me.btnRegistrarSubarea.Name = "btnRegistrarSubarea"
        Me.btnRegistrarSubarea.Size = New System.Drawing.Size(120, 28)
        Me.btnRegistrarSubarea.TabIndex = 8
        Me.btnRegistrarSubarea.Text = "Registrar subarea"
        Me.btnRegistrarSubarea.UseVisualStyleBackColor = False
        '
        'txtSubareaPanelSubarea
        '
        Me.txtSubareaPanelSubarea.AcceptsReturn = True
        Me.txtSubareaPanelSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubareaPanelSubarea.Location = New System.Drawing.Point(153, 80)
        Me.txtSubareaPanelSubarea.Name = "txtSubareaPanelSubarea"
        Me.txtSubareaPanelSubarea.Size = New System.Drawing.Size(249, 21)
        Me.txtSubareaPanelSubarea.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre del subarea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos del subarea"
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(420, 23)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(37, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(345, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR SUBAREA DE LABORATORIO"
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
        'FormRegistrarSubareaLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegistrarSubarea)
        Me.Name = "FormRegistrarSubareaLaboratorio"
        Me.Text = "Registrar subarea de laboratorio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents hintAreaPanelSubarea As Label
    Friend WithEvents cboxAreaPanelSubarea As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegistrarSubarea As Button
    Friend WithEvents txtSubareaPanelSubarea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuStripMenu As ToolStripMenuItem
    Friend WithEvents menuStripMenuLaboratorio As ToolStripMenuItem
End Class
