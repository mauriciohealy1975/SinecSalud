<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIngresarInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIngresarInventario))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LCL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBProv = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxBLote = New System.Windows.Forms.TextBox()
        Me.TxBcb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.CbSm = New System.Windows.Forms.ComboBox()
        Me.TxbCant = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxbPrecio = New System.Windows.Forms.TextBox()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DgvTTop20 = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.CBArea = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBBPL = New System.Windows.Forms.CheckBox()
        Me.BtnNuevoInsumo = New System.Windows.Forms.Button()
        Me.CheckBoxInsumo = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTTop20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(26, 213)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(179, 22)
        Me.TBBuscar.TabIndex = 0
        '
        'CB1
        '
        Me.CB1.FormattingEnabled = True
        Me.CB1.Items.AddRange(New Object() {"med1", "med2", "med3", "med4", "med5"})
        Me.CB1.Location = New System.Drawing.Point(26, 257)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(340, 24)
        Me.CB1.TabIndex = 3
        Me.CB1.Text = "Farmacos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar"
        '
        'LCL
        '
        Me.LCL.AutoSize = True
        Me.LCL.Location = New System.Drawing.Point(171, 238)
        Me.LCL.Name = "LCL"
        Me.LCL.Size = New System.Drawing.Size(23, 16)
        Me.LCL.TabIndex = 7
        Me.LCL.Text = "´´´´"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Producto Liname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Producto"
        '
        'CBProv
        '
        Me.CBProv.FormattingEnabled = True
        Me.CBProv.Location = New System.Drawing.Point(211, 213)
        Me.CBProv.Name = "CBProv"
        Me.CBProv.Size = New System.Drawing.Size(156, 24)
        Me.CBProv.TabIndex = 2
        Me.CBProv.Text = "Laboratorio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Lote:"
        '
        'TxBLote
        '
        Me.TxBLote.Location = New System.Drawing.Point(117, 367)
        Me.TxBLote.MaxLength = 20
        Me.TxBLote.Name = "TxBLote"
        Me.TxBLote.Size = New System.Drawing.Size(249, 22)
        Me.TxBLote.TabIndex = 6
        '
        'TxBcb
        '
        Me.TxBcb.Location = New System.Drawing.Point(118, 336)
        Me.TxBcb.MaxLength = 20
        Me.TxBcb.Name = "TxBcb"
        Me.TxBcb.Size = New System.Drawing.Size(249, 22)
        Me.TxBcb.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cod Barras:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Cantidad :"
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Location = New System.Drawing.Point(869, 499)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(125, 42)
        Me.BtnEnviar.TabIndex = 12
        Me.BtnEnviar.Text = "Registrar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'CbSm
        '
        Me.CbSm.FormattingEnabled = True
        Me.CbSm.Location = New System.Drawing.Point(27, 303)
        Me.CbSm.Name = "CbSm"
        Me.CbSm.Size = New System.Drawing.Size(339, 24)
        Me.CbSm.TabIndex = 4
        '
        'TxbCant
        '
        Me.TxbCant.Location = New System.Drawing.Point(117, 421)
        Me.TxbCant.MaxLength = 10
        Me.TxbCant.Name = "TxbCant"
        Me.TxbCant.Size = New System.Drawing.Size(96, 22)
        Me.TxbCant.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 452)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Precio :"
        '
        'TxbPrecio
        '
        Me.TxbPrecio.Location = New System.Drawing.Point(117, 452)
        Me.TxbPrecio.Name = "TxbPrecio"
        Me.TxbPrecio.Size = New System.Drawing.Size(96, 22)
        Me.TxbPrecio.TabIndex = 9
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(78, 163)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 26
        Me.LT.Text = "Tipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(78, 137)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 28
        Me.LN.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(982, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'DgvTTop20
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTTop20.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvTTop20.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTTop20.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DgvTTop20.Location = New System.Drawing.Point(372, 215)
        Me.DgvTTop20.MultiSelect = False
        Me.DgvTTop20.Name = "DgvTTop20"
        Me.DgvTTop20.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTTop20.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvTTop20.RowHeadersWidth = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DgvTTop20.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvTTop20.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DgvTTop20.RowTemplate.Height = 24
        Me.DgvTTop20.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTTop20.Size = New System.Drawing.Size(621, 261)
        Me.DgvTTop20.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(626, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "ULTIMOS 10 REGISTROS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(218, 424)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Area"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(219, 452)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Estado:"
        '
        'CBEstado
        '
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Location = New System.Drawing.Point(270, 452)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(96, 24)
        Me.CBEstado.TabIndex = 11
        '
        'CBArea
        '
        Me.CBArea.FormattingEnabled = True
        Me.CBArea.ItemHeight = 16
        Me.CBArea.Location = New System.Drawing.Point(271, 421)
        Me.CBArea.Name = "CBArea"
        Me.CBArea.Size = New System.Drawing.Size(96, 24)
        Me.CBArea.TabIndex = 10
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(739, 499)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(124, 41)
        Me.BtnCancelar.TabIndex = 13
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(556, 500)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 41)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Nuevo Medicamento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataFechaVencimiento
        '
        Me.DataFechaVencimiento.Location = New System.Drawing.Point(175, 393)
        Me.DataFechaVencimiento.MinDate = New Date(2022, 9, 14, 11, 54, 8, 0)
        Me.DataFechaVencimiento.Name = "DataFechaVencimiento"
        Me.DataFechaVencimiento.Size = New System.Drawing.Size(192, 22)
        Me.DataFechaVencimiento.TabIndex = 7
        Me.DataFechaVencimiento.Value = New Date(2022, 9, 14, 11, 54, 8, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Fecha de vencimiento:"
        '
        'CheckBBPL
        '
        Me.CheckBBPL.AutoSize = True
        Me.CheckBBPL.Location = New System.Drawing.Point(211, 187)
        Me.CheckBBPL.Name = "CheckBBPL"
        Me.CheckBBPL.Size = New System.Drawing.Size(117, 20)
        Me.CheckBBPL.TabIndex = 32
        Me.CheckBBPL.Text = "por laboratorio"
        Me.CheckBBPL.UseVisualStyleBackColor = True
        '
        'BtnNuevoInsumo
        '
        Me.BtnNuevoInsumo.Location = New System.Drawing.Point(372, 500)
        Me.BtnNuevoInsumo.Name = "BtnNuevoInsumo"
        Me.BtnNuevoInsumo.Size = New System.Drawing.Size(178, 41)
        Me.BtnNuevoInsumo.TabIndex = 33
        Me.BtnNuevoInsumo.Text = "Nuevo Insumo"
        Me.BtnNuevoInsumo.UseVisualStyleBackColor = True
        '
        'CheckBoxInsumo
        '
        Me.CheckBoxInsumo.AutoSize = True
        Me.CheckBoxInsumo.Location = New System.Drawing.Point(133, 187)
        Me.CheckBoxInsumo.Name = "CheckBoxInsumo"
        Me.CheckBoxInsumo.Size = New System.Drawing.Size(72, 20)
        Me.CheckBoxInsumo.TabIndex = 34
        Me.CheckBoxInsumo.Text = "Insumo"
        Me.CheckBoxInsumo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(889, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 34)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Reportes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormIngresarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 553)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBoxInsumo)
        Me.Controls.Add(Me.BtnNuevoInsumo)
        Me.Controls.Add(Me.CheckBBPL)
        Me.Controls.Add(Me.DataFechaVencimiento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.CBArea)
        Me.Controls.Add(Me.CBEstado)
        Me.Controls.Add(Me.DgvTTop20)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxbPrecio)
        Me.Controls.Add(Me.TxbCant)
        Me.Controls.Add(Me.CbSm)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxBcb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxBLote)
        Me.Controls.Add(Me.CBProv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LCL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB1)
        Me.Name = "FormIngresarInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de inventario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTTop20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents CB1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LCL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBProv As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxBLote As TextBox
    Friend WithEvents TxBcb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents CbSm As ComboBox
    Friend WithEvents TxbCant As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxbPrecio As TextBox
    Friend WithEvents LT As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvTTop20 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents CBArea As ComboBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataFechaVencimiento As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBBPL As CheckBox
    Friend WithEvents BtnNuevoInsumo As Button
    Friend WithEvents CheckBoxInsumo As CheckBox
    Friend WithEvents Button2 As Button
End Class
