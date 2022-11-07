<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerRayosXSolicitados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVerRayosXSolicitados))
        Me.LT = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DgvSolicitudesRX = New System.Windows.Forms.DataGridView()
        Me.TbxBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LAnuncio = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvSolicitudesRX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LT.Location = New System.Drawing.Point(75, 114)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(21, 20)
        Me.LT.TabIndex = 729
        Me.LT.Text = "--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 20)
        Me.Label11.TabIndex = 730
        Me.Label11.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN.Location = New System.Drawing.Point(75, 137)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(21, 20)
        Me.LN.TabIndex = 731
        Me.LN.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 732
        Me.Label10.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(760, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 728
        Me.PictureBox1.TabStop = False
        '
        'DgvSolicitudesRX
        '
        Me.DgvSolicitudesRX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSolicitudesRX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSolicitudesRX.Location = New System.Drawing.Point(12, 170)
        Me.DgvSolicitudesRX.Name = "DgvSolicitudesRX"
        Me.DgvSolicitudesRX.RowHeadersWidth = 51
        Me.DgvSolicitudesRX.RowTemplate.Height = 24
        Me.DgvSolicitudesRX.Size = New System.Drawing.Size(778, 342)
        Me.DgvSolicitudesRX.TabIndex = 733
        '
        'TbxBuscar
        '
        Me.TbxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxBuscar.Location = New System.Drawing.Point(474, 137)
        Me.TbxBuscar.Name = "TbxBuscar"
        Me.TbxBuscar.Size = New System.Drawing.Size(206, 27)
        Me.TbxBuscar.TabIndex = 734
        Me.TbxBuscar.Text = "Nombre del paciente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(420, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 735
        Me.Label1.Text = "Busca:"
        '
        'LAnuncio
        '
        Me.LAnuncio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LAnuncio.AutoSize = True
        Me.LAnuncio.BackColor = System.Drawing.Color.Black
        Me.LAnuncio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAnuncio.ForeColor = System.Drawing.Color.Transparent
        Me.LAnuncio.Location = New System.Drawing.Point(207, 275)
        Me.LAnuncio.Name = "LAnuncio"
        Me.LAnuncio.Size = New System.Drawing.Size(385, 32)
        Me.LAnuncio.TabIndex = 736
        Me.LAnuncio.Text = "No se encontraron resultados"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(686, 137)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(84, 27)
        Me.BtnBuscar.TabIndex = 737
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.Location = New System.Drawing.Point(688, 518)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(102, 34)
        Me.BtnMenu.TabIndex = 738
        Me.BtnMenu.Text = "Menú"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'FormVerRayosXSolicitados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 553)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LAnuncio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbxBuscar)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvSolicitudesRX)
        Me.Name = "FormVerRayosXSolicitados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RayosX(Solicitudes)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvSolicitudesRX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LT As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvSolicitudesRX As DataGridView
    Friend WithEvents TbxBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LAnuncio As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnMenu As Button
End Class
