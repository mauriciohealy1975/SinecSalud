<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCargarImg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCargarImg))
        Me.BtnSubirArchivo = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbxTamaños = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.TbxRuta = New System.Windows.Forms.TextBox()
        Me.txbExtension = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSubirArchivo
        '
        Me.BtnSubirArchivo.Location = New System.Drawing.Point(379, 141)
        Me.BtnSubirArchivo.Name = "BtnSubirArchivo"
        Me.BtnSubirArchivo.Size = New System.Drawing.Size(133, 28)
        Me.BtnSubirArchivo.TabIndex = 0
        Me.BtnSubirArchivo.Text = "Subir Archivo"
        Me.BtnSubirArchivo.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(485, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(30, 31)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Seleccionar Tamaño e Imagen"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'CbxTamaños
        '
        Me.CbxTamaños.FormattingEnabled = True
        Me.CbxTamaños.Location = New System.Drawing.Point(26, 111)
        Me.CbxTamaños.Name = "CbxTamaños"
        Me.CbxTamaños.Size = New System.Drawing.Size(131, 24)
        Me.CbxTamaños.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tamaño"
        '
        'Btnguardar
        '
        Me.Btnguardar.Location = New System.Drawing.Point(426, 199)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(86, 32)
        Me.Btnguardar.TabIndex = 11
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'TbxRuta
        '
        Me.TbxRuta.Enabled = False
        Me.TbxRuta.Location = New System.Drawing.Point(26, 141)
        Me.TbxRuta.Name = "TbxRuta"
        Me.TbxRuta.Size = New System.Drawing.Size(267, 22)
        Me.TbxRuta.TabIndex = 14
        '
        'txbExtension
        '
        Me.txbExtension.Enabled = False
        Me.txbExtension.Location = New System.Drawing.Point(310, 141)
        Me.txbExtension.Name = "txbExtension"
        Me.txbExtension.Size = New System.Drawing.Size(63, 22)
        Me.txbExtension.TabIndex = 15
        '
        'FormCargarImg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 243)
        Me.Controls.Add(Me.txbExtension)
        Me.Controls.Add(Me.TbxRuta)
        Me.Controls.Add(Me.Btnguardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxTamaños)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnSubirArchivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCargarImg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormCargarImg"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSubirArchivo As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CbxTamaños As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btnguardar As Button
    Friend WithEvents TbxRuta As TextBox
    Friend WithEvents txbExtension As TextBox
End Class
