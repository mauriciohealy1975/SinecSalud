<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRecetas
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DgvListaReceta = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Indicaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantResultante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LT = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.LNR = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.PanelMedicamento = New System.Windows.Forms.Panel()
        Me.BtnagreaReceta = New System.Windows.Forms.Button()
        Me.TxbCantidad = New System.Windows.Forms.TextBox()
        Me.TbIndicaciones = New System.Windows.Forms.TextBox()
        Me.txbBuscarMedcicamentos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Lcant = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbMedicamentos = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LEP = New System.Windows.Forms.Label()
        Me.LMP = New System.Windows.Forms.Label()
        Me.LNP = New System.Windows.Forms.Label()
        CType(Me.DgvListaReceta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMedicamento.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 712
        Me.Label9.Text = "Registro Numero:"
        '
        'DgvListaReceta
        '
        Me.DgvListaReceta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListaReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListaReceta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Medicamento, Me.Cantidad, Me.Indicaciones, Me.CantResultante})
        Me.DgvListaReceta.Location = New System.Drawing.Point(11, 346)
        Me.DgvListaReceta.Name = "DgvListaReceta"
        Me.DgvListaReceta.ReadOnly = True
        Me.DgvListaReceta.RowHeadersWidth = 51
        Me.DgvListaReceta.RowTemplate.Height = 24
        Me.DgvListaReceta.Size = New System.Drawing.Size(982, 177)
        Me.DgvListaReceta.TabIndex = 711
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Medicamento
        '
        Me.Medicamento.HeaderText = "Medicamento"
        Me.Medicamento.MinimumWidth = 6
        Me.Medicamento.Name = "Medicamento"
        Me.Medicamento.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Indicaciones
        '
        Me.Indicaciones.HeaderText = "Indicaciones"
        Me.Indicaciones.MinimumWidth = 6
        Me.Indicaciones.Name = "Indicaciones"
        Me.Indicaciones.ReadOnly = True
        '
        'CantResultante
        '
        Me.CantResultante.HeaderText = "CantResultante"
        Me.CantResultante.MinimumWidth = 6
        Me.CantResultante.Name = "CantResultante"
        Me.CantResultante.ReadOnly = True
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(12, 682)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(15, 16)
        Me.LT.TabIndex = 717
        Me.LT.Text = "--"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(12, 698)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(15, 16)
        Me.LN.TabIndex = 717
        Me.LN.Text = "--"
        '
        'LNR
        '
        Me.LNR.AutoSize = True
        Me.LNR.Location = New System.Drawing.Point(132, 327)
        Me.LNR.Name = "LNR"
        Me.LNR.Size = New System.Drawing.Size(56, 16)
        Me.LNR.TabIndex = 712
        Me.LNR.Text = "9999999"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(898, 529)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 35)
        Me.Button1.TabIndex = 719
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(796, 529)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 35)
        Me.BtnCancelar.TabIndex = 719
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'PanelMedicamento
        '
        Me.PanelMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMedicamento.Controls.Add(Me.BtnagreaReceta)
        Me.PanelMedicamento.Controls.Add(Me.TxbCantidad)
        Me.PanelMedicamento.Controls.Add(Me.TbIndicaciones)
        Me.PanelMedicamento.Controls.Add(Me.txbBuscarMedcicamentos)
        Me.PanelMedicamento.Controls.Add(Me.Label4)
        Me.PanelMedicamento.Controls.Add(Me.Label13)
        Me.PanelMedicamento.Controls.Add(Me.Label14)
        Me.PanelMedicamento.Controls.Add(Me.Lcant)
        Me.PanelMedicamento.Controls.Add(Me.Label3)
        Me.PanelMedicamento.Controls.Add(Me.Label1)
        Me.PanelMedicamento.Controls.Add(Me.CbMedicamentos)
        Me.PanelMedicamento.Location = New System.Drawing.Point(11, 189)
        Me.PanelMedicamento.Name = "PanelMedicamento"
        Me.PanelMedicamento.Size = New System.Drawing.Size(983, 132)
        Me.PanelMedicamento.TabIndex = 721
        '
        'BtnagreaReceta
        '
        Me.BtnagreaReceta.Location = New System.Drawing.Point(873, 95)
        Me.BtnagreaReceta.Name = "BtnagreaReceta"
        Me.BtnagreaReceta.Size = New System.Drawing.Size(75, 30)
        Me.BtnagreaReceta.TabIndex = 729
        Me.BtnagreaReceta.Text = "Agregar"
        Me.BtnagreaReceta.UseVisualStyleBackColor = True
        '
        'TxbCantidad
        '
        Me.TxbCantidad.Location = New System.Drawing.Point(269, 72)
        Me.TxbCantidad.Name = "TxbCantidad"
        Me.TxbCantidad.Size = New System.Drawing.Size(57, 22)
        Me.TxbCantidad.TabIndex = 726
        '
        'TbIndicaciones
        '
        Me.TbIndicaciones.Location = New System.Drawing.Point(385, 23)
        Me.TbIndicaciones.Multiline = True
        Me.TbIndicaciones.Name = "TbIndicaciones"
        Me.TbIndicaciones.Size = New System.Drawing.Size(563, 67)
        Me.TbIndicaciones.TabIndex = 727
        '
        'txbBuscarMedcicamentos
        '
        Me.txbBuscarMedcicamentos.Location = New System.Drawing.Point(132, 14)
        Me.txbBuscarMedcicamentos.Name = "txbBuscarMedcicamentos"
        Me.txbBuscarMedcicamentos.Size = New System.Drawing.Size(194, 22)
        Me.txbBuscarMedcicamentos.TabIndex = 728
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 720
        Me.Label4.Text = "Buscar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(191, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 721
        Me.Label13.Text = "Dispensar:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(381, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 20)
        Me.Label14.TabIndex = 722
        Me.Label14.Text = "Indicaciones"
        '
        'Lcant
        '
        Me.Lcant.AutoSize = True
        Me.Lcant.Location = New System.Drawing.Point(130, 76)
        Me.Lcant.Name = "Lcant"
        Me.Lcant.Size = New System.Drawing.Size(35, 16)
        Me.Lcant.TabIndex = 723
        Me.Lcant.Text = "0000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 724
        Me.Label3.Text = "Cant Disponible"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 725
        Me.Label1.Text = "Medicamento"
        '
        'CbMedicamentos
        '
        Me.CbMedicamentos.FormattingEnabled = True
        Me.CbMedicamentos.Location = New System.Drawing.Point(132, 45)
        Me.CbMedicamentos.Name = "CbMedicamentos"
        Me.CbMedicamentos.Size = New System.Drawing.Size(194, 24)
        Me.CbMedicamentos.TabIndex = 719
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LEP)
        Me.Panel1.Controls.Add(Me.LMP)
        Me.Panel1.Controls.Add(Me.LNP)
        Me.Panel1.Location = New System.Drawing.Point(11, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 114)
        Me.Panel1.TabIndex = 724
        '
        'LEP
        '
        Me.LEP.AutoSize = True
        Me.LEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEP.Location = New System.Drawing.Point(12, 68)
        Me.LEP.Name = "LEP"
        Me.LEP.Size = New System.Drawing.Size(156, 20)
        Me.LEP.TabIndex = 59
        Me.LEP.Text = "EDAD : 24 AÑOS"
        '
        'LMP
        '
        Me.LMP.AutoSize = True
        Me.LMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMP.Location = New System.Drawing.Point(12, 39)
        Me.LMP.Name = "LMP"
        Me.LMP.Size = New System.Drawing.Size(266, 20)
        Me.LMP.TabIndex = 58
        Me.LMP.Text = "MATRICULA: 12345678901011"
        '
        'LNP
        '
        Me.LNP.AutoSize = True
        Me.LNP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNP.Location = New System.Drawing.Point(12, 11)
        Me.LNP.Name = "LNP"
        Me.LNP.Size = New System.Drawing.Size(419, 20)
        Me.LNP.TabIndex = 57
        Me.LNP.Text = "PACIENTE : ANGEL ARTURO MONTAÑO MEJIA"
        '
        'FormRecetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.LNR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DgvListaReceta)
        Me.Controls.Add(Me.PanelMedicamento)
        Me.Name = "FormRecetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recetas"
        CType(Me.DgvListaReceta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMedicamento.ResumeLayout(False)
        Me.PanelMedicamento.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents DgvListaReceta As DataGridView
    Friend WithEvents LT As Label
    Friend WithEvents LN As Label
    Friend WithEvents LNR As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Medicamento As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Indicaciones As DataGridViewTextBoxColumn
    Friend WithEvents CantResultante As DataGridViewTextBoxColumn
    Friend WithEvents PanelMedicamento As Panel
    Friend WithEvents BtnagreaReceta As Button
    Friend WithEvents TxbCantidad As TextBox
    Friend WithEvents TbIndicaciones As TextBox
    Friend WithEvents txbBuscarMedcicamentos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Lcant As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbMedicamentos As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LEP As Label
    Friend WithEvents LMP As Label
    Friend WithEvents LNP As Label
End Class
