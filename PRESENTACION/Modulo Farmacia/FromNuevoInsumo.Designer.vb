<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromNuevoInsumo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromNuevoInsumo))
        Me.LT = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxbEspecificacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbBuscar = New System.Windows.Forms.TextBox()
        Me.CbLiname = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(78, 163)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 31
        Me.LT.Text = "Tipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(78, 137)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 33
        Me.LN.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 137)
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
        Me.PictureBox1.Size = New System.Drawing.Size(416, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'TxbEspecificacion
        '
        Me.TxbEspecificacion.Location = New System.Drawing.Point(115, 288)
        Me.TxbEspecificacion.Name = "TxbEspecificacion"
        Me.TxbEspecificacion.Size = New System.Drawing.Size(247, 22)
        Me.TxbEspecificacion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Especificacion"
        '
        'TxbBuscar
        '
        Me.TxbBuscar.Location = New System.Drawing.Point(23, 230)
        Me.TxbBuscar.Name = "TxbBuscar"
        Me.TxbBuscar.Size = New System.Drawing.Size(88, 22)
        Me.TxbBuscar.TabIndex = 2
        '
        'CbLiname
        '
        Me.CbLiname.DropDownWidth = 300
        Me.CbLiname.FormattingEnabled = True
        Me.CbLiname.Location = New System.Drawing.Point(117, 230)
        Me.CbLiname.Name = "CbLiname"
        Me.CbLiname.Size = New System.Drawing.Size(245, 24)
        Me.CbLiname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Insumo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Buscar :"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(238, 505)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 36)
        Me.BtnCancelar.TabIndex = 45
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(340, 505)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(96, 36)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nombre"
        '
        'txbNombre
        '
        Me.txbNombre.Enabled = False
        Me.txbNombre.Location = New System.Drawing.Point(117, 260)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(247, 22)
        Me.txbNombre.TabIndex = 40
        '
        'FromNuevoInsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 553)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxbBuscar)
        Me.Controls.Add(Me.CbLiname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxbEspecificacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FromNuevoInsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Nuevo Insumo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LT As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxbEspecificacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbBuscar As TextBox
    Friend WithEvents CbLiname As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txbNombre As TextBox
End Class
