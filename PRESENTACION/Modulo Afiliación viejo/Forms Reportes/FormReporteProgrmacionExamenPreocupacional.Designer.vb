<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReporteProgrmacionExamenPreocupacional
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
        Me.cViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.dgvProgramacionesReprogramaciones = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dpcDesede = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTraerProgramaciones = New System.Windows.Forms.Button()
        Me.dpcHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvProgramacionesReprogramaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cViewer
        '
        Me.cViewer.ActiveViewIndex = -1
        Me.cViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cViewer.DisplayBackgroundEdge = False
        Me.cViewer.Location = New System.Drawing.Point(892, 25)
        Me.cViewer.Margin = New System.Windows.Forms.Padding(4)
        Me.cViewer.Name = "cViewer"
        Me.cViewer.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController
        Me.cViewer.ShowCloseButton = False
        Me.cViewer.ShowCopyButton = False
        Me.cViewer.ShowExportButton = False
        Me.cViewer.ShowGotoPageButton = False
        Me.cViewer.ShowGroupTreeButton = False
        Me.cViewer.ShowLogo = False
        Me.cViewer.ShowParameterPanelButton = False
        Me.cViewer.Size = New System.Drawing.Size(742, 637)
        Me.cViewer.TabIndex = 5
        Me.cViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(229, 25)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(464, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(21, 1)
        Me.lblTituloPrincipal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(422, 25)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REPORTES EXAMEN PREOCUPACIONAL"
        '
        'dgvProgramacionesReprogramaciones
        '
        Me.dgvProgramacionesReprogramaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProgramacionesReprogramaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvProgramacionesReprogramaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramacionesReprogramaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvProgramacionesReprogramaciones.Location = New System.Drawing.Point(40, 170)
        Me.dgvProgramacionesReprogramaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProgramacionesReprogramaciones.Name = "dgvProgramacionesReprogramaciones"
        Me.dgvProgramacionesReprogramaciones.RowHeadersWidth = 51
        Me.dgvProgramacionesReprogramaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProgramacionesReprogramaciones.Size = New System.Drawing.Size(808, 178)
        Me.dgvProgramacionesReprogramaciones.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "CODIGO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "FECHA"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "MATRICULA"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "TITULAR"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'dpcDesede
        '
        Me.dpcDesede.CustomFormat = "dd--MM--yyyy"
        Me.dpcDesede.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcDesede.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcDesede.Location = New System.Drawing.Point(113, 80)
        Me.dpcDesede.Margin = New System.Windows.Forms.Padding(4)
        Me.dpcDesede.Name = "dpcDesede"
        Me.dpcDesede.Size = New System.Drawing.Size(185, 24)
        Me.dpcDesede.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Desde"
        '
        'btnTraerProgramaciones
        '
        Me.btnTraerProgramaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraerProgramaciones.Location = New System.Drawing.Point(512, 116)
        Me.btnTraerProgramaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTraerProgramaciones.Name = "btnTraerProgramaciones"
        Me.btnTraerProgramaciones.Size = New System.Drawing.Size(336, 33)
        Me.btnTraerProgramaciones.TabIndex = 3
        Me.btnTraerProgramaciones.Text = "Traer programaciones / reprogramaciones"
        Me.btnTraerProgramaciones.UseVisualStyleBackColor = True
        '
        'dpcHasta
        '
        Me.dpcHasta.CustomFormat = "dd--MM--yyyy"
        Me.dpcHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpcHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpcHasta.Location = New System.Drawing.Point(113, 123)
        Me.dpcHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dpcHasta.Name = "dpcHasta"
        Me.dpcHasta.Size = New System.Drawing.Size(185, 24)
        Me.dpcHasta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 123)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hasta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Volver al Menú"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormReporteProgrmacionExamenPreocupacional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1685, 690)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dpcHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTraerProgramaciones)
        Me.Controls.Add(Me.dpcDesede)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvProgramacionesReprogramaciones)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cViewer)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormReporteProgrmacionExamenPreocupacional"
        Me.Text = "Reportes Examen Preocupacional"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvProgramacionesReprogramaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As System.Windows.Forms.Label
    Friend WithEvents dgvProgramacionesReprogramaciones As System.Windows.Forms.DataGridView
    Friend WithEvents dpcDesede As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTraerProgramaciones As System.Windows.Forms.Button
    Friend WithEvents dpcHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
