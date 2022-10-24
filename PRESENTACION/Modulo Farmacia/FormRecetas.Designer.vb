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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecetas))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DgvListaReceta = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Indicaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantResultante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LT = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.LNR = New System.Windows.Forms.Label()
        Me.Ltp = New System.Windows.Forms.Label()
        Me.Lnp = New System.Windows.Forms.Label()
        Me.Lmp = New System.Windows.Forms.Label()
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
        Me.PanelPaciente = New System.Windows.Forms.Panel()
        Me.TxbBuscarAsegurado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbPaciente = New System.Windows.Forms.ComboBox()
        Me.BtnReiniciar = New System.Windows.Forms.Button()
        CType(Me.DgvListaReceta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMedicamento.SuspendLayout()
        Me.PanelPaciente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(432, 305)
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
        Me.DgvListaReceta.Location = New System.Drawing.Point(12, 327)
        Me.DgvListaReceta.Name = "DgvListaReceta"
        Me.DgvListaReceta.ReadOnly = True
        Me.DgvListaReceta.RowHeadersWidth = 51
        Me.DgvListaReceta.RowTemplate.Height = 24
        Me.DgvListaReceta.Size = New System.Drawing.Size(596, 173)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(596, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 704
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 717
        Me.Label6.Text = "Tipo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 717
        Me.Label7.Text = "Matricula :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 717
        Me.Label8.Text = "Nombre :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 717
        Me.Label10.Text = "Usuario:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 717
        Me.Label11.Text = "Tipo:"
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(75, 104)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(15, 16)
        Me.LT.TabIndex = 717
        Me.LT.Text = "--"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(75, 127)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(15, 16)
        Me.LN.TabIndex = 717
        Me.LN.Text = "--"
        '
        'LNR
        '
        Me.LNR.AutoSize = True
        Me.LNR.Location = New System.Drawing.Point(552, 305)
        Me.LNR.Name = "LNR"
        Me.LNR.Size = New System.Drawing.Size(56, 16)
        Me.LNR.TabIndex = 712
        Me.LNR.Text = "9999999"
        '
        'Ltp
        '
        Me.Ltp.AutoSize = True
        Me.Ltp.Location = New System.Drawing.Point(52, 255)
        Me.Ltp.Name = "Ltp"
        Me.Ltp.Size = New System.Drawing.Size(15, 16)
        Me.Ltp.TabIndex = 717
        Me.Ltp.Text = "--"
        '
        'Lnp
        '
        Me.Lnp.AutoSize = True
        Me.Lnp.Location = New System.Drawing.Point(75, 280)
        Me.Lnp.Name = "Lnp"
        Me.Lnp.Size = New System.Drawing.Size(15, 16)
        Me.Lnp.TabIndex = 717
        Me.Lnp.Text = "--"
        '
        'Lmp
        '
        Me.Lmp.AutoSize = True
        Me.Lmp.Location = New System.Drawing.Point(75, 308)
        Me.Lmp.Name = "Lmp"
        Me.Lmp.Size = New System.Drawing.Size(15, 16)
        Me.Lmp.TabIndex = 717
        Me.Lmp.Text = "--"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(516, 506)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 35)
        Me.Button1.TabIndex = 719
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(414, 506)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 35)
        Me.BtnCancelar.TabIndex = 719
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'PanelMedicamento
        '
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
        Me.PanelMedicamento.Location = New System.Drawing.Point(279, 107)
        Me.PanelMedicamento.Name = "PanelMedicamento"
        Me.PanelMedicamento.Size = New System.Drawing.Size(329, 189)
        Me.PanelMedicamento.TabIndex = 721
        '
        'BtnagreaReceta
        '
        Me.BtnagreaReceta.Location = New System.Drawing.Point(253, 157)
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
        Me.TbIndicaciones.Location = New System.Drawing.Point(132, 106)
        Me.TbIndicaciones.Multiline = True
        Me.TbIndicaciones.Name = "TbIndicaciones"
        Me.TbIndicaciones.Size = New System.Drawing.Size(194, 45)
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
        Me.Label14.Location = New System.Drawing.Point(16, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 16)
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
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 725
        Me.Label1.Text = "Medicamento"
        '
        'CbMedicamentos
        '
        Me.CbMedicamentos.FormattingEnabled = True
        Me.CbMedicamentos.Location = New System.Drawing.Point(132, 42)
        Me.CbMedicamentos.Name = "CbMedicamentos"
        Me.CbMedicamentos.Size = New System.Drawing.Size(194, 24)
        Me.CbMedicamentos.TabIndex = 719
        '
        'PanelPaciente
        '
        Me.PanelPaciente.Controls.Add(Me.TxbBuscarAsegurado)
        Me.PanelPaciente.Controls.Add(Me.Label5)
        Me.PanelPaciente.Controls.Add(Me.Label2)
        Me.PanelPaciente.Controls.Add(Me.CbPaciente)
        Me.PanelPaciente.Location = New System.Drawing.Point(12, 152)
        Me.PanelPaciente.Name = "PanelPaciente"
        Me.PanelPaciente.Size = New System.Drawing.Size(261, 100)
        Me.PanelPaciente.TabIndex = 722
        '
        'TxbBuscarAsegurado
        '
        Me.TxbBuscarAsegurado.Location = New System.Drawing.Point(8, 26)
        Me.TxbBuscarAsegurado.Name = "TxbBuscarAsegurado"
        Me.TxbBuscarAsegurado.Size = New System.Drawing.Size(250, 22)
        Me.TxbBuscarAsegurado.TabIndex = 720
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 718
        Me.Label5.Text = "Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 719
        Me.Label2.Text = "Buscar"
        '
        'CbPaciente
        '
        Me.CbPaciente.DropDownWidth = 300
        Me.CbPaciente.FormattingEnabled = True
        Me.CbPaciente.Location = New System.Drawing.Point(8, 70)
        Me.CbPaciente.Name = "CbPaciente"
        Me.CbPaciente.Size = New System.Drawing.Size(250, 24)
        Me.CbPaciente.TabIndex = 717
        '
        'BtnReiniciar
        '
        Me.BtnReiniciar.Location = New System.Drawing.Point(312, 508)
        Me.BtnReiniciar.Name = "BtnReiniciar"
        Me.BtnReiniciar.Size = New System.Drawing.Size(96, 33)
        Me.BtnReiniciar.TabIndex = 723
        Me.BtnReiniciar.Text = "Reiniciar"
        Me.BtnReiniciar.UseVisualStyleBackColor = True
        '
        'FormRecetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 553)
        Me.Controls.Add(Me.BtnReiniciar)
        Me.Controls.Add(Me.PanelPaciente)
        Me.Controls.Add(Me.PanelMedicamento)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lnp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Lmp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Ltp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LNR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DgvListaReceta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormRecetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recetas"
        CType(Me.DgvListaReceta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMedicamento.ResumeLayout(False)
        Me.PanelMedicamento.PerformLayout()
        Me.PanelPaciente.ResumeLayout(False)
        Me.PanelPaciente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents DgvListaReceta As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LT As Label
    Friend WithEvents LN As Label
    Friend WithEvents LNR As Label
    Friend WithEvents Ltp As Label
    Friend WithEvents Lnp As Label
    Friend WithEvents Lmp As Label
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
    Friend WithEvents PanelPaciente As Panel
    Friend WithEvents TxbBuscarAsegurado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbPaciente As ComboBox
    Friend WithEvents BtnReiniciar As Button
End Class
