<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTraspasos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTraspasos))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbOrigen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbDestino = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DgvListaTraspasos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodUsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Lproximo = New System.Windows.Forms.Label()
        Me.BtnReiniciarForm = New System.Windows.Forms.Button()
        Me.CPMed = New System.Windows.Forms.Panel()
        Me.TxbBuscarMed = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnMandarAlDgv = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbCEnviar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxbDisp = New System.Windows.Forms.TextBox()
        Me.CbInventario = New System.Windows.Forms.ComboBox()
        Me.TxbMP = New System.Windows.Forms.TextBox()
        Me.TxbCL = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListaTraspasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CPMed.SuspendLayout()
        Me.SuspendLayout()
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(81, 140)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 31
        Me.LT.Text = "Tipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(81, 114)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 33
        Me.LN.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(808, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'CbOrigen
        '
        Me.CbOrigen.FormattingEnabled = True
        Me.CbOrigen.Location = New System.Drawing.Point(30, 190)
        Me.CbOrigen.Name = "CbOrigen"
        Me.CbOrigen.Size = New System.Drawing.Size(184, 24)
        Me.CbOrigen.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Origen:"
        '
        'CbDestino
        '
        Me.CbDestino.FormattingEnabled = True
        Me.CbDestino.Location = New System.Drawing.Point(30, 239)
        Me.CbDestino.Name = "CbDestino"
        Me.CbDestino.Size = New System.Drawing.Size(184, 24)
        Me.CbDestino.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Destino:"
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Location = New System.Drawing.Point(680, 557)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(140, 34)
        Me.BtnEnviar.TabIndex = 38
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(534, 557)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 34)
        Me.BtnCancelar.TabIndex = 38
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(140, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Medicamento"
        '
        'DgvListaTraspasos
        '
        Me.DgvListaTraspasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListaTraspasos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CL, Me.CSM, Me.Medicamento, Me.CantidadE, Me.CantidadA, Me.Precio, Me.Almacen, Me.CodUsu, Me.Area, Me.Lote, Me.CB, Me.Estado, Me.FechaVencimiento, Me.CR})
        Me.DgvListaTraspasos.Location = New System.Drawing.Point(12, 337)
        Me.DgvListaTraspasos.Name = "DgvListaTraspasos"
        Me.DgvListaTraspasos.ReadOnly = True
        Me.DgvListaTraspasos.RowHeadersWidth = 51
        Me.DgvListaTraspasos.RowTemplate.Height = 24
        Me.DgvListaTraspasos.Size = New System.Drawing.Size(808, 214)
        Me.DgvListaTraspasos.TabIndex = 43
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 125
        '
        'CL
        '
        Me.CL.HeaderText = "Liname"
        Me.CL.MinimumWidth = 6
        Me.CL.Name = "CL"
        Me.CL.ReadOnly = True
        Me.CL.Width = 125
        '
        'CSM
        '
        Me.CSM.HeaderText = "CSM"
        Me.CSM.MinimumWidth = 6
        Me.CSM.Name = "CSM"
        Me.CSM.ReadOnly = True
        Me.CSM.Width = 125
        '
        'Medicamento
        '
        Me.Medicamento.HeaderText = "Medicamento"
        Me.Medicamento.MinimumWidth = 6
        Me.Medicamento.Name = "Medicamento"
        Me.Medicamento.ReadOnly = True
        Me.Medicamento.Width = 125
        '
        'CantidadE
        '
        Me.CantidadE.HeaderText = "CantidadE"
        Me.CantidadE.MinimumWidth = 6
        Me.CantidadE.Name = "CantidadE"
        Me.CantidadE.ReadOnly = True
        Me.CantidadE.Width = 125
        '
        'CantidadA
        '
        Me.CantidadA.HeaderText = "CantidadA"
        Me.CantidadA.MinimumWidth = 6
        Me.CantidadA.Name = "CantidadA"
        Me.CantidadA.ReadOnly = True
        Me.CantidadA.Visible = False
        Me.CantidadA.Width = 125
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 125
        '
        'Almacen
        '
        Me.Almacen.HeaderText = "Almacen"
        Me.Almacen.MinimumWidth = 6
        Me.Almacen.Name = "Almacen"
        Me.Almacen.ReadOnly = True
        Me.Almacen.Width = 125
        '
        'CodUsu
        '
        Me.CodUsu.HeaderText = "CodUsu"
        Me.CodUsu.MinimumWidth = 6
        Me.CodUsu.Name = "CodUsu"
        Me.CodUsu.ReadOnly = True
        Me.CodUsu.Visible = False
        Me.CodUsu.Width = 125
        '
        'Area
        '
        Me.Area.HeaderText = "Area"
        Me.Area.MinimumWidth = 6
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        Me.Area.Width = 125
        '
        'Lote
        '
        Me.Lote.HeaderText = "Lote"
        Me.Lote.MinimumWidth = 6
        Me.Lote.Name = "Lote"
        Me.Lote.ReadOnly = True
        Me.Lote.Width = 125
        '
        'CB
        '
        Me.CB.HeaderText = "CB"
        Me.CB.MinimumWidth = 6
        Me.CB.Name = "CB"
        Me.CB.ReadOnly = True
        Me.CB.Width = 125
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 125
        '
        'FechaVencimiento
        '
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.FechaVencimiento.DefaultCellStyle = DataGridViewCellStyle5
        Me.FechaVencimiento.HeaderText = "Fecha de vencimiento"
        Me.FechaVencimiento.MinimumWidth = 6
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.ReadOnly = True
        Me.FechaVencimiento.Width = 125
        '
        'CR
        '
        Me.CR.HeaderText = "CR"
        Me.CR.MinimumWidth = 6
        Me.CR.Name = "CR"
        Me.CR.ReadOnly = True
        Me.CR.Width = 125
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Registro Numero:"
        '
        'Lproximo
        '
        Me.Lproximo.AutoSize = True
        Me.Lproximo.Location = New System.Drawing.Point(132, 310)
        Me.Lproximo.Name = "Lproximo"
        Me.Lproximo.Size = New System.Drawing.Size(56, 16)
        Me.Lproximo.TabIndex = 45
        Me.Lproximo.Text = "0000000"
        '
        'BtnReiniciarForm
        '
        Me.BtnReiniciarForm.Location = New System.Drawing.Point(424, 557)
        Me.BtnReiniciarForm.Name = "BtnReiniciarForm"
        Me.BtnReiniciarForm.Size = New System.Drawing.Size(104, 34)
        Me.BtnReiniciarForm.TabIndex = 46
        Me.BtnReiniciarForm.Text = "Reiniciar"
        Me.BtnReiniciarForm.UseVisualStyleBackColor = True
        '
        'CPMed
        '
        Me.CPMed.Controls.Add(Me.TxbBuscarMed)
        Me.CPMed.Controls.Add(Me.Label7)
        Me.CPMed.Controls.Add(Me.Label8)
        Me.CPMed.Controls.Add(Me.Label3)
        Me.CPMed.Controls.Add(Me.Label4)
        Me.CPMed.Controls.Add(Me.BtnMandarAlDgv)
        Me.CPMed.Controls.Add(Me.Label5)
        Me.CPMed.Controls.Add(Me.TxbCEnviar)
        Me.CPMed.Controls.Add(Me.Label6)
        Me.CPMed.Controls.Add(Me.TxbDisp)
        Me.CPMed.Controls.Add(Me.CbInventario)
        Me.CPMed.Controls.Add(Me.TxbMP)
        Me.CPMed.Controls.Add(Me.TxbCL)
        Me.CPMed.Location = New System.Drawing.Point(220, 114)
        Me.CPMed.Name = "CPMed"
        Me.CPMed.Size = New System.Drawing.Size(600, 202)
        Me.CPMed.TabIndex = 701
        '
        'TxbBuscarMed
        '
        Me.TxbBuscarMed.Location = New System.Drawing.Point(37, 49)
        Me.TxbBuscarMed.MaxLength = 50
        Me.TxbBuscarMed.Name = "TxbBuscarMed"
        Me.TxbBuscarMed.Size = New System.Drawing.Size(100, 22)
        Me.TxbBuscarMed.TabIndex = 702
        Me.TxbBuscarMed.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 705
        Me.Label8.Text = "Buscar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 706
        Me.Label3.Text = "Cod Liname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 707
        Me.Label4.Text = "Medicamento"
        '
        'BtnMandarAlDgv
        '
        Me.BtnMandarAlDgv.Location = New System.Drawing.Point(453, 143)
        Me.BtnMandarAlDgv.Name = "BtnMandarAlDgv"
        Me.BtnMandarAlDgv.Size = New System.Drawing.Size(116, 43)
        Me.BtnMandarAlDgv.TabIndex = 704
        Me.BtnMandarAlDgv.Text = "Agregar"
        Me.BtnMandarAlDgv.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 708
        Me.Label5.Text = "Disponibilidad"
        '
        'TxbCEnviar
        '
        Me.TxbCEnviar.Location = New System.Drawing.Point(484, 103)
        Me.TxbCEnviar.Name = "TxbCEnviar"
        Me.TxbCEnviar.Size = New System.Drawing.Size(85, 22)
        Me.TxbCEnviar.TabIndex = 710
        Me.TxbCEnviar.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(482, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 709
        Me.Label6.Text = "Cant. a enviar"
        '
        'TxbDisp
        '
        Me.TxbDisp.Enabled = False
        Me.TxbDisp.Location = New System.Drawing.Point(385, 103)
        Me.TxbDisp.Name = "TxbDisp"
        Me.TxbDisp.Size = New System.Drawing.Size(93, 22)
        Me.TxbDisp.TabIndex = 712
        '
        'CbInventario
        '
        Me.CbInventario.FormattingEnabled = True
        Me.CbInventario.Location = New System.Drawing.Point(143, 47)
        Me.CbInventario.Name = "CbInventario"
        Me.CbInventario.Size = New System.Drawing.Size(426, 24)
        Me.CbInventario.TabIndex = 701
        '
        'TxbMP
        '
        Me.TxbMP.Enabled = False
        Me.TxbMP.Location = New System.Drawing.Point(143, 102)
        Me.TxbMP.Name = "TxbMP"
        Me.TxbMP.Size = New System.Drawing.Size(236, 22)
        Me.TxbMP.TabIndex = 711
        '
        'TxbCL
        '
        Me.TxbCL.Enabled = False
        Me.TxbCL.Location = New System.Drawing.Point(37, 103)
        Me.TxbCL.Name = "TxbCL"
        Me.TxbCL.Size = New System.Drawing.Size(100, 22)
        Me.TxbCL.TabIndex = 703
        '
        'FormTraspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 603)
        Me.Controls.Add(Me.BtnReiniciarForm)
        Me.Controls.Add(Me.Lproximo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DgvListaTraspasos)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbDestino)
        Me.Controls.Add(Me.CbOrigen)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CPMed)
        Me.Name = "FormTraspasos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traspasos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListaTraspasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CPMed.ResumeLayout(False)
        Me.CPMed.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LT As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CbOrigen As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbDestino As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DgvListaTraspasos As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Lproximo As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CL As DataGridViewTextBoxColumn
    Friend WithEvents CSM As DataGridViewTextBoxColumn
    Friend WithEvents Medicamento As DataGridViewTextBoxColumn
    Friend WithEvents CantidadE As DataGridViewTextBoxColumn
    Friend WithEvents CantidadA As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Almacen As DataGridViewTextBoxColumn
    Friend WithEvents CodUsu As DataGridViewTextBoxColumn
    Friend WithEvents Area As DataGridViewTextBoxColumn
    Friend WithEvents Lote As DataGridViewTextBoxColumn
    Friend WithEvents CB As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents CR As DataGridViewTextBoxColumn
    Friend WithEvents BtnReiniciarForm As Button
    Friend WithEvents CPMed As Panel
    Friend WithEvents TxbBuscarMed As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnMandarAlDgv As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbCEnviar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxbDisp As TextBox
    Friend WithEvents CbInventario As ComboBox
    Friend WithEvents TxbMP As TextBox
    Friend WithEvents TxbCL As TextBox
End Class
