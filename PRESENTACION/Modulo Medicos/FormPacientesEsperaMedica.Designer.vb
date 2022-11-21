<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPacientesEsperaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPacientesEsperaMedica))
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBarra = New System.Windows.Forms.PictureBox()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DgvPacientes = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnVolvermenuPrincipal = New System.Windows.Forms.Button()
        Me.SP = New System.Windows.Forms.Label()
        Me.CheckCentroDiag = New System.Windows.Forms.CheckBox()
        Me.BtncerrarSesion = New System.Windows.Forms.Button()
        Me.BtnBM = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Gray
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(960, 9)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(34, 31)
        Me.BtnCerrar.TabIndex = 48
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(295, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(321, 29)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Lista de pacientes en espera"
        '
        'PictureBarra
        '
        Me.PictureBarra.BackColor = System.Drawing.Color.Gray
        Me.PictureBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBarra.Location = New System.Drawing.Point(0, 0)
        Me.PictureBarra.Name = "PictureBarra"
        Me.PictureBarra.Size = New System.Drawing.Size(1006, 50)
        Me.PictureBarra.TabIndex = 51
        Me.PictureBarra.TabStop = False
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(72, 159)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(15, 16)
        Me.LT.TabIndex = 733
        Me.LT.Text = "--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 734
        Me.Label11.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(72, 182)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(15, 16)
        Me.LN.TabIndex = 735
        Me.LN.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 736
        Me.Label10.Text = "Usuario:"
        '
        'DgvPacientes
        '
        Me.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacientes.Location = New System.Drawing.Point(12, 224)
        Me.DgvPacientes.Name = "DgvPacientes"
        Me.DgvPacientes.RowHeadersWidth = 51
        Me.DgvPacientes.RowTemplate.Height = 24
        Me.DgvPacientes.Size = New System.Drawing.Size(982, 424)
        Me.DgvPacientes.TabIndex = 737
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1006, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 738
        Me.PictureBox2.TabStop = False
        '
        'BtnVolvermenuPrincipal
        '
        Me.BtnVolvermenuPrincipal.Location = New System.Drawing.Point(712, 668)
        Me.BtnVolvermenuPrincipal.Name = "BtnVolvermenuPrincipal"
        Me.BtnVolvermenuPrincipal.Size = New System.Drawing.Size(138, 41)
        Me.BtnVolvermenuPrincipal.TabIndex = 739
        Me.BtnVolvermenuPrincipal.Text = "Menú Administrador"
        Me.BtnVolvermenuPrincipal.UseVisualStyleBackColor = True
        '
        'SP
        '
        Me.SP.AutoSize = True
        Me.SP.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SP.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SP.Location = New System.Drawing.Point(390, 419)
        Me.SP.Name = "SP"
        Me.SP.Size = New System.Drawing.Size(226, 32)
        Me.SP.TabIndex = 740
        Me.SP.Text = "SIN PACIENTES"
        '
        'CheckCentroDiag
        '
        Me.CheckCentroDiag.AutoSize = True
        Me.CheckCentroDiag.Location = New System.Drawing.Point(12, 201)
        Me.CheckCentroDiag.Name = "CheckCentroDiag"
        Me.CheckCentroDiag.Size = New System.Drawing.Size(198, 20)
        Me.CheckCentroDiag.TabIndex = 741
        Me.CheckCentroDiag.Text = "Modo Centro de diagnostico"
        Me.CheckCentroDiag.UseVisualStyleBackColor = True
        '
        'BtncerrarSesion
        '
        Me.BtncerrarSesion.Location = New System.Drawing.Point(856, 668)
        Me.BtncerrarSesion.Name = "BtncerrarSesion"
        Me.BtncerrarSesion.Size = New System.Drawing.Size(138, 41)
        Me.BtncerrarSesion.TabIndex = 742
        Me.BtncerrarSesion.Text = "Cerrar Sesión"
        Me.BtncerrarSesion.UseVisualStyleBackColor = True
        '
        'BtnBM
        '
        Me.BtnBM.Location = New System.Drawing.Point(12, 660)
        Me.BtnBM.Name = "BtnBM"
        Me.BtnBM.Size = New System.Drawing.Size(144, 34)
        Me.BtnBM.TabIndex = 743
        Me.BtnBM.Text = "Bajas Medicas"
        Me.BtnBM.UseVisualStyleBackColor = True
        '
        'FormPacientesEsperaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.BtnBM)
        Me.Controls.Add(Me.BtncerrarSesion)
        Me.Controls.Add(Me.CheckCentroDiag)
        Me.Controls.Add(Me.SP)
        Me.Controls.Add(Me.BtnVolvermenuPrincipal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DgvPacientes)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPacientesEsperaMedica"
        Me.Text = "FormPacientesEsperaMedica"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBarra As PictureBox
    Friend WithEvents LT As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DgvPacientes As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnVolvermenuPrincipal As Button
    Friend WithEvents SP As Label
    Friend WithEvents CheckCentroDiag As CheckBox
    Friend WithEvents BtncerrarSesion As Button
    Friend WithEvents BtnBM As Button
End Class
