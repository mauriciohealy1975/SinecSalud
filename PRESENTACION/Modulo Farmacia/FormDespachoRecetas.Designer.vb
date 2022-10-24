<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDespachoRecetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDespachoRecetas))
        Me.DgvDetalleReceta = New System.Windows.Forms.DataGridView()
        Me.TxbCodReceta = New System.Windows.Forms.TextBox()
        Me.LvCreceta = New System.Windows.Forms.Label()
        Me.lvCAsegurado = New System.Windows.Forms.Label()
        Me.LvAsegurado = New System.Windows.Forms.Label()
        Me.LvMedico = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnDespachar = New System.Windows.Forms.Button()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.LvEstado = New System.Windows.Forms.Label()
        Me.BtnReImprimir = New System.Windows.Forms.Button()
        CType(Me.DgvDetalleReceta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvDetalleReceta
        '
        Me.DgvDetalleReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleReceta.Location = New System.Drawing.Point(12, 286)
        Me.DgvDetalleReceta.Name = "DgvDetalleReceta"
        Me.DgvDetalleReceta.RowHeadersWidth = 51
        Me.DgvDetalleReceta.RowTemplate.Height = 24
        Me.DgvDetalleReceta.Size = New System.Drawing.Size(758, 206)
        Me.DgvDetalleReceta.TabIndex = 0
        '
        'TxbCodReceta
        '
        Me.TxbCodReceta.Location = New System.Drawing.Point(12, 164)
        Me.TxbCodReceta.Name = "TxbCodReceta"
        Me.TxbCodReceta.Size = New System.Drawing.Size(100, 22)
        Me.TxbCodReceta.TabIndex = 1
        '
        'LvCreceta
        '
        Me.LvCreceta.AutoSize = True
        Me.LvCreceta.Location = New System.Drawing.Point(12, 267)
        Me.LvCreceta.Name = "LvCreceta"
        Me.LvCreceta.Size = New System.Drawing.Size(85, 16)
        Me.LvCreceta.TabIndex = 2
        Me.LvCreceta.Text = "Cod. Receta:"
        '
        'lvCAsegurado
        '
        Me.lvCAsegurado.AutoSize = True
        Me.lvCAsegurado.Location = New System.Drawing.Point(12, 244)
        Me.lvCAsegurado.Name = "lvCAsegurado"
        Me.lvCAsegurado.Size = New System.Drawing.Size(108, 16)
        Me.lvCAsegurado.TabIndex = 2
        Me.lvCAsegurado.Text = "Cod. Asegurado:"
        '
        'LvAsegurado
        '
        Me.LvAsegurado.AutoSize = True
        Me.LvAsegurado.Location = New System.Drawing.Point(12, 228)
        Me.LvAsegurado.Name = "LvAsegurado"
        Me.LvAsegurado.Size = New System.Drawing.Size(80, 16)
        Me.LvAsegurado.TabIndex = 4
        Me.LvAsegurado.Text = "Asegurado: "
        '
        'LvMedico
        '
        Me.LvMedico.AutoSize = True
        Me.LvMedico.Location = New System.Drawing.Point(12, 212)
        Me.LvMedico.Name = "LvMedico"
        Me.LvMedico.Size = New System.Drawing.Size(55, 16)
        Me.LvMedico.TabIndex = 4
        Me.LvMedico.Text = "Medico:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(118, 164)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "BUSCAR"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(75, 114)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(15, 16)
        Me.LT.TabIndex = 719
        Me.LT.Text = "--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 720
        Me.Label11.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(75, 137)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(15, 16)
        Me.LN.TabIndex = 721
        Me.LN.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 722
        Me.Label10.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 718
        Me.PictureBox1.TabStop = False
        '
        'BtnDespachar
        '
        Me.BtnDespachar.Location = New System.Drawing.Point(666, 512)
        Me.BtnDespachar.Name = "BtnDespachar"
        Me.BtnDespachar.Size = New System.Drawing.Size(103, 29)
        Me.BtnDespachar.TabIndex = 723
        Me.BtnDespachar.Text = "Despachar"
        Me.BtnDespachar.UseVisualStyleBackColor = True
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(557, 512)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(103, 29)
        Me.BtnAnular.TabIndex = 723
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(448, 512)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(103, 29)
        Me.BtnRegresar.TabIndex = 723
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'LvEstado
        '
        Me.LvEstado.AutoSize = True
        Me.LvEstado.Location = New System.Drawing.Point(585, 267)
        Me.LvEstado.Name = "LvEstado"
        Me.LvEstado.Size = New System.Drawing.Size(53, 16)
        Me.LvEstado.TabIndex = 4
        Me.LvEstado.Text = "Estado:"
        '
        'BtnReImprimir
        '
        Me.BtnReImprimir.Location = New System.Drawing.Point(673, 119)
        Me.BtnReImprimir.Name = "BtnReImprimir"
        Me.BtnReImprimir.Size = New System.Drawing.Size(97, 34)
        Me.BtnReImprimir.TabIndex = 724
        Me.BtnReImprimir.Text = "Re-Imprimir"
        Me.BtnReImprimir.UseVisualStyleBackColor = True
        '
        'FormDespachoRecetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.BtnReImprimir)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnAnular)
        Me.Controls.Add(Me.BtnDespachar)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LvEstado)
        Me.Controls.Add(Me.LvMedico)
        Me.Controls.Add(Me.LvAsegurado)
        Me.Controls.Add(Me.lvCAsegurado)
        Me.Controls.Add(Me.LvCreceta)
        Me.Controls.Add(Me.TxbCodReceta)
        Me.Controls.Add(Me.DgvDetalleReceta)
        Me.Name = "FormDespachoRecetas"
        Me.Text = "Despacho Farmacia"
        CType(Me.DgvDetalleReceta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvDetalleReceta As DataGridView
    Friend WithEvents TxbCodReceta As TextBox
    Friend WithEvents LvCreceta As Label
    Friend WithEvents lvCAsegurado As Label
    Friend WithEvents LvAsegurado As Label
    Friend WithEvents LvMedico As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LT As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnDespachar As Button
    Friend WithEvents BtnAnular As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents LvEstado As Label
    Friend WithEvents BtnReImprimir As Button
End Class
