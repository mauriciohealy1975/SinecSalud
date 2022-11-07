<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVisorRX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVisorRX))
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LAnuncio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DgvSolicitudesRX = New System.Windows.Forms.DataGridView()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnMenu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvSolicitudesRX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(704, 123)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(84, 27)
        Me.BtnBuscar.TabIndex = 746
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'LAnuncio
        '
        Me.LAnuncio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LAnuncio.AutoSize = True
        Me.LAnuncio.BackColor = System.Drawing.Color.Black
        Me.LAnuncio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAnuncio.ForeColor = System.Drawing.Color.Transparent
        Me.LAnuncio.Location = New System.Drawing.Point(280, 342)
        Me.LAnuncio.Name = "LAnuncio"
        Me.LAnuncio.Size = New System.Drawing.Size(206, 32)
        Me.LAnuncio.TabIndex = 745
        Me.LAnuncio.Text = "Sin Resultados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 744
        Me.Label1.Text = "Busca:"
        '
        'TbxBuscar
        '
        Me.TbxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxBuscar.Location = New System.Drawing.Point(492, 123)
        Me.TbxBuscar.Name = "TbxBuscar"
        Me.TbxBuscar.Size = New System.Drawing.Size(206, 27)
        Me.TbxBuscar.TabIndex = 743
        Me.TbxBuscar.Text = "Nombre del paciente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(760, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 738
        Me.PictureBox1.TabStop = False
        '
        'DgvSolicitudesRX
        '
        Me.DgvSolicitudesRX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSolicitudesRX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSolicitudesRX.Location = New System.Drawing.Point(11, 153)
        Me.DgvSolicitudesRX.Name = "DgvSolicitudesRX"
        Me.DgvSolicitudesRX.RowHeadersWidth = 51
        Me.DgvSolicitudesRX.RowTemplate.Height = 24
        Me.DgvSolicitudesRX.Size = New System.Drawing.Size(778, 411)
        Me.DgvSolicitudesRX.TabIndex = 742
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LT.Location = New System.Drawing.Point(75, 107)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(21, 20)
        Me.LT.TabIndex = 747
        Me.LT.Text = "--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 20)
        Me.Label11.TabIndex = 748
        Me.Label11.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN.Location = New System.Drawing.Point(75, 130)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(21, 20)
        Me.LN.TabIndex = 749
        Me.LN.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 750
        Me.Label10.Text = "Usuario:"
        '
        'BtnMenu
        '
        Me.BtnMenu.Location = New System.Drawing.Point(714, 570)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(75, 23)
        Me.BtnMenu.TabIndex = 751
        Me.BtnMenu.Text = "Menú"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'FormVisorRX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LAnuncio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbxBuscar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvSolicitudesRX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormVisorRX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvSolicitudesRX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LAnuncio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbxBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvSolicitudesRX As DataGridView
    Friend WithEvents LT As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnMenu As Button
End Class
