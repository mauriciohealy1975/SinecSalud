<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActivarDesactivarMedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActivarDesactivarMedicamento))
        Me.LT = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DgvDatos50 = New System.Windows.Forms.DataGridView()
        Me.BtnTerminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxbBliname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDatos50, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(75, 114)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(15, 16)
        Me.LT.TabIndex = 729
        Me.LT.Text = "--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 730
        Me.Label11.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(75, 137)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(15, 16)
        Me.LN.TabIndex = 731
        Me.LN.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 732
        Me.Label10.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 728
        Me.PictureBox1.TabStop = False
        '
        'DgvDatos50
        '
        Me.DgvDatos50.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos50.Location = New System.Drawing.Point(15, 235)
        Me.DgvDatos50.Name = "DgvDatos50"
        Me.DgvDatos50.RowHeadersWidth = 51
        Me.DgvDatos50.RowTemplate.Height = 24
        Me.DgvDatos50.Size = New System.Drawing.Size(755, 277)
        Me.DgvDatos50.TabIndex = 733
        '
        'BtnTerminar
        '
        Me.BtnTerminar.Location = New System.Drawing.Point(695, 518)
        Me.BtnTerminar.Name = "BtnTerminar"
        Me.BtnTerminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnTerminar.TabIndex = 734
        Me.BtnTerminar.Text = "Terminar"
        Me.BtnTerminar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(614, 518)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 734
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxbBliname
        '
        Me.TxbBliname.Location = New System.Drawing.Point(15, 207)
        Me.TxbBliname.Name = "TxbBliname"
        Me.TxbBliname.Size = New System.Drawing.Size(117, 22)
        Me.TxbBliname.TabIndex = 735
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 732
        Me.Label1.Text = "Buscar Por Liname"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(138, 206)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 736
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FormActivarDesactivarMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxbBliname)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnTerminar)
        Me.Controls.Add(Me.DgvDatos50)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormActivarDesactivarMedicamento"
        Me.Text = "Activar  o Descactivar Medicamentos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDatos50, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LT As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvDatos50 As DataGridView
    Friend WithEvents BtnTerminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxbBliname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscar As Button
End Class
