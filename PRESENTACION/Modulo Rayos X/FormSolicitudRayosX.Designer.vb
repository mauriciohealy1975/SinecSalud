<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSolicitudRayosX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSolicitudRayosX))
        Me.LT = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGVExamenes = New System.Windows.Forms.DataGridView()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.CbxRadiografias = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txbCantidad = New System.Windows.Forms.TextBox()
        Me.TxbBuscarTipoRadiografia = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSolicitar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LEP = New System.Windows.Forms.Label()
        Me.LMP = New System.Windows.Forms.Label()
        Me.LNP = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(12, 505)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(15, 16)
        Me.LT.TabIndex = 724
        Me.LT.Text = "--"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(12, 528)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(15, 16)
        Me.LN.TabIndex = 726
        Me.LN.Text = "--"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(458, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(511, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 723
        Me.PictureBox1.TabStop = False
        '
        'DGVExamenes
        '
        Me.DGVExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVExamenes.Location = New System.Drawing.Point(3, 67)
        Me.DGVExamenes.Name = "DGVExamenes"
        Me.DGVExamenes.RowHeadersWidth = 51
        Me.DGVExamenes.RowTemplate.Height = 24
        Me.DGVExamenes.Size = New System.Drawing.Size(948, 208)
        Me.DGVExamenes.TabIndex = 730
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(793, 512)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(93, 37)
        Me.BtnCancelar.TabIndex = 731
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'CbxRadiografias
        '
        Me.CbxRadiografias.FormattingEnabled = True
        Me.CbxRadiografias.Location = New System.Drawing.Point(208, 31)
        Me.CbxRadiografias.Name = "CbxRadiografias"
        Me.CbxRadiografias.Size = New System.Drawing.Size(181, 24)
        Me.CbxRadiografias.TabIndex = 728
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 729
        Me.Label2.Text = "Sitio Anatómico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 729
        Me.Label4.Text = "Buscar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(396, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 729
        Me.Label3.Text = "Cantidad"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(586, 24)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 37)
        Me.BtnAgregar.TabIndex = 731
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txbCantidad
        '
        Me.txbCantidad.Location = New System.Drawing.Point(463, 31)
        Me.txbCantidad.Name = "txbCantidad"
        Me.txbCantidad.Size = New System.Drawing.Size(117, 22)
        Me.txbCantidad.TabIndex = 732
        Me.txbCantidad.Text = "0"
        '
        'TxbBuscarTipoRadiografia
        '
        Me.TxbBuscarTipoRadiografia.Location = New System.Drawing.Point(21, 33)
        Me.TxbBuscarTipoRadiografia.Name = "TxbBuscarTipoRadiografia"
        Me.TxbBuscarTipoRadiografia.Size = New System.Drawing.Size(181, 22)
        Me.TxbBuscarTipoRadiografia.TabIndex = 736
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TxbBuscarTipoRadiografia)
        Me.Panel1.Controls.Add(Me.CbxRadiografias)
        Me.Panel1.Controls.Add(Me.DGVExamenes)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnAgregar)
        Me.Panel1.Controls.Add(Me.txbCantidad)
        Me.Panel1.Location = New System.Drawing.Point(15, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 299)
        Me.Panel1.TabIndex = 737
        '
        'BtnSolicitar
        '
        Me.BtnSolicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSolicitar.Location = New System.Drawing.Point(892, 511)
        Me.BtnSolicitar.Name = "BtnSolicitar"
        Me.BtnSolicitar.Size = New System.Drawing.Size(94, 37)
        Me.BtnSolicitar.TabIndex = 738
        Me.BtnSolicitar.Text = "Solicitar"
        Me.BtnSolicitar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.LEP)
        Me.Panel2.Controls.Add(Me.LMP)
        Me.Panel2.Controls.Add(Me.LNP)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(15, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(979, 114)
        Me.Panel2.TabIndex = 739
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
        'FormSolicitudRayosX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 560)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnSolicitar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormSolicitudRayosX"
        Me.Text = "SINEC RadioGrafias"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LT As Label
    Friend WithEvents LN As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGVExamenes As DataGridView
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents CbxRadiografias As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents txbCantidad As TextBox
    Friend WithEvents TxbBuscarTipoRadiografia As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSolicitar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LEP As Label
    Friend WithEvents LMP As Label
    Friend WithEvents LNP As Label
End Class
