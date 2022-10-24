<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalleTraspaso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetalleTraspaso))
        Me.DvgDetalleTraspaso = New System.Windows.Forms.DataGridView()
        Me.BtnRecibir = New System.Windows.Forms.Button()
        Me.BtnCancelarRecepcion = New System.Windows.Forms.Button()
        Me.BtnVerLuego = New System.Windows.Forms.Button()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbObservaciones = New System.Windows.Forms.TextBox()
        CType(Me.DvgDetalleTraspaso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DvgDetalleTraspaso
        '
        Me.DvgDetalleTraspaso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DvgDetalleTraspaso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvgDetalleTraspaso.Location = New System.Drawing.Point(12, 182)
        Me.DvgDetalleTraspaso.Name = "DvgDetalleTraspaso"
        Me.DvgDetalleTraspaso.RowHeadersWidth = 51
        Me.DvgDetalleTraspaso.RowTemplate.Height = 24
        Me.DvgDetalleTraspaso.Size = New System.Drawing.Size(758, 203)
        Me.DvgDetalleTraspaso.TabIndex = 0
        '
        'BtnRecibir
        '
        Me.BtnRecibir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecibir.Location = New System.Drawing.Point(634, 433)
        Me.BtnRecibir.Name = "BtnRecibir"
        Me.BtnRecibir.Size = New System.Drawing.Size(136, 34)
        Me.BtnRecibir.TabIndex = 1
        Me.BtnRecibir.Text = "Recibir"
        Me.BtnRecibir.UseVisualStyleBackColor = True
        '
        'BtnCancelarRecepcion
        '
        Me.BtnCancelarRecepcion.Location = New System.Drawing.Point(617, 473)
        Me.BtnCancelarRecepcion.Name = "BtnCancelarRecepcion"
        Me.BtnCancelarRecepcion.Size = New System.Drawing.Size(153, 29)
        Me.BtnCancelarRecepcion.TabIndex = 2
        Me.BtnCancelarRecepcion.Text = "CancelarTraspaso"
        Me.BtnCancelarRecepcion.UseVisualStyleBackColor = True
        '
        'BtnVerLuego
        '
        Me.BtnVerLuego.Location = New System.Drawing.Point(670, 398)
        Me.BtnVerLuego.Name = "BtnVerLuego"
        Me.BtnVerLuego.Size = New System.Drawing.Size(100, 29)
        Me.BtnVerLuego.TabIndex = 3
        Me.BtnVerLuego.Text = "Ver Luego"
        Me.BtnVerLuego.UseVisualStyleBackColor = True
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(76, 153)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 41
        Me.LT.Text = "Tipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(76, 127)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 43
        Me.LN.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(776, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 32)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Lista de traspaso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Aclaraciones"
        '
        'TxbObservaciones
        '
        Me.TxbObservaciones.Location = New System.Drawing.Point(12, 417)
        Me.TxbObservaciones.Multiline = True
        Me.TxbObservaciones.Name = "TxbObservaciones"
        Me.TxbObservaciones.Size = New System.Drawing.Size(565, 85)
        Me.TxbObservaciones.TabIndex = 45
        '
        'FormDetalleTraspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.TxbObservaciones)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnVerLuego)
        Me.Controls.Add(Me.BtnCancelarRecepcion)
        Me.Controls.Add(Me.BtnRecibir)
        Me.Controls.Add(Me.DvgDetalleTraspaso)
        Me.Name = "FormDetalleTraspaso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle del Traspaso"
        CType(Me.DvgDetalleTraspaso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DvgDetalleTraspaso As DataGridView
    Friend WithEvents BtnRecibir As Button
    Friend WithEvents BtnCancelarRecepcion As Button
    Friend WithEvents BtnVerLuego As Button
    Friend WithEvents LT As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbObservaciones As TextBox
End Class
