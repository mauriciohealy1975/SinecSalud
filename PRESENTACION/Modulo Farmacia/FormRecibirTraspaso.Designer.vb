<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecibirTraspaso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecibirTraspaso))
        Me.DgvListaRececpcionEspera = New System.Windows.Forms.DataGridView()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbAlmacenes = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        CType(Me.DgvListaRececpcionEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvListaRececpcionEspera
        '
        Me.DgvListaRececpcionEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListaRececpcionEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListaRececpcionEspera.Location = New System.Drawing.Point(12, 189)
        Me.DgvListaRececpcionEspera.Name = "DgvListaRececpcionEspera"
        Me.DgvListaRececpcionEspera.ReadOnly = True
        Me.DgvListaRececpcionEspera.RowHeadersWidth = 51
        Me.DgvListaRececpcionEspera.RowTemplate.Height = 24
        Me.DgvListaRececpcionEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListaRececpcionEspera.Size = New System.Drawing.Size(758, 303)
        Me.DgvListaRececpcionEspera.TabIndex = 0
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(78, 163)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 36
        Me.LT.Text = "Tipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(78, 137)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 38
        Me.LN.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(776, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'CbAlmacenes
        '
        Me.CbAlmacenes.FormattingEnabled = True
        Me.CbAlmacenes.Location = New System.Drawing.Point(632, 137)
        Me.CbAlmacenes.Name = "CbAlmacenes"
        Me.CbAlmacenes.Size = New System.Drawing.Size(138, 24)
        Me.CbAlmacenes.TabIndex = 40
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(665, 509)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(105, 32)
        Me.BtnCancelar.TabIndex = 41
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FormRecibirTraspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.CbAlmacenes)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvListaRececpcionEspera)
        Me.Name = "FormRecibirTraspaso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepciones"
        CType(Me.DgvListaRececpcionEspera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvListaRececpcionEspera As DataGridView
    Friend WithEvents LT As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CbAlmacenes As ComboBox
    Friend WithEvents BtnCancelar As Button
End Class
