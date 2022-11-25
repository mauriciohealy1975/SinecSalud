<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuMedicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuMedicos))
        Me.btnOrdenServiciosEnfemeria = New System.Windows.Forms.Button()
        Me.btnTransfernciaMedica = New System.Windows.Forms.Button()
        Me.LT = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.BtnRecetas = New System.Windows.Forms.Button()
        Me.BtnRayosX = New System.Windows.Forms.Button()
        Me.BtnCD = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LEP = New System.Windows.Forms.Label()
        Me.LMP = New System.Windows.Forms.Label()
        Me.LNP = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBarra = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOrdenServiciosEnfemeria
        '
        Me.btnOrdenServiciosEnfemeria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenServiciosEnfemeria.Location = New System.Drawing.Point(15, 207)
        Me.btnOrdenServiciosEnfemeria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrdenServiciosEnfemeria.Name = "btnOrdenServiciosEnfemeria"
        Me.btnOrdenServiciosEnfemeria.Size = New System.Drawing.Size(322, 57)
        Me.btnOrdenServiciosEnfemeria.TabIndex = 2
        Me.btnOrdenServiciosEnfemeria.Text = "Orden para servicios enfermería"
        Me.btnOrdenServiciosEnfemeria.UseVisualStyleBackColor = True
        '
        'btnTransfernciaMedica
        '
        Me.btnTransfernciaMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfernciaMedica.Location = New System.Drawing.Point(15, 271)
        Me.btnTransfernciaMedica.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTransfernciaMedica.Name = "btnTransfernciaMedica"
        Me.btnTransfernciaMedica.Size = New System.Drawing.Size(322, 57)
        Me.btnTransfernciaMedica.TabIndex = 2
        Me.btnTransfernciaMedica.Text = "Transferencia Medica"
        Me.btnTransfernciaMedica.UseVisualStyleBackColor = True
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(14, 680)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 16
        Me.LT.Text = "Tipo"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(12, 696)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 18
        Me.LN.Text = "Nombre"
        '
        'BtnRecetas
        '
        Me.BtnRecetas.Location = New System.Drawing.Point(346, 208)
        Me.BtnRecetas.Name = "BtnRecetas"
        Me.BtnRecetas.Size = New System.Drawing.Size(322, 57)
        Me.BtnRecetas.TabIndex = 22
        Me.BtnRecetas.Text = "Recetas"
        Me.BtnRecetas.UseVisualStyleBackColor = True
        '
        'BtnRayosX
        '
        Me.BtnRayosX.Location = New System.Drawing.Point(346, 270)
        Me.BtnRayosX.Name = "BtnRayosX"
        Me.BtnRayosX.Size = New System.Drawing.Size(322, 58)
        Me.BtnRayosX.TabIndex = 23
        Me.BtnRayosX.Text = "Rayos X "
        Me.BtnRayosX.UseVisualStyleBackColor = True
        '
        'BtnCD
        '
        Me.BtnCD.Location = New System.Drawing.Point(674, 208)
        Me.BtnCD.Name = "BtnCD"
        Me.BtnCD.Size = New System.Drawing.Size(315, 57)
        Me.BtnCD.TabIndex = 24
        Me.BtnCD.Text = "Solicitar Cita CD(en proceso)"
        Me.BtnCD.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LEP)
        Me.Panel1.Controls.Add(Me.LMP)
        Me.Panel1.Controls.Add(Me.LNP)
        Me.Panel1.Location = New System.Drawing.Point(12, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 114)
        Me.Panel1.TabIndex = 57
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(546, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(429, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 724
        Me.PictureBox2.TabStop = False
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
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Gray
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(960, 9)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(34, 31)
        Me.BtnCerrar.TabIndex = 58
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(379, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 29)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Solicitudes Medicas"
        '
        'PictureBarra
        '
        Me.PictureBarra.BackColor = System.Drawing.Color.Gray
        Me.PictureBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBarra.Location = New System.Drawing.Point(0, 0)
        Me.PictureBarra.Name = "PictureBarra"
        Me.PictureBarra.Size = New System.Drawing.Size(1006, 50)
        Me.PictureBarra.TabIndex = 61
        Me.PictureBarra.TabStop = False
        '
        'FormMenuMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBarra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRayosX)
        Me.Controls.Add(Me.BtnCD)
        Me.Controls.Add(Me.BtnRecetas)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.btnOrdenServiciosEnfemeria)
        Me.Controls.Add(Me.btnTransfernciaMedica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormMenuMedicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "a"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTransfernciaMedica As System.Windows.Forms.Button
    Friend WithEvents btnOrdenServiciosEnfemeria As System.Windows.Forms.Button
    Friend WithEvents LT As Label
    Friend WithEvents LN As Label
    Friend WithEvents BtnRecetas As Button
    Friend WithEvents BtnRayosX As Button
    Friend WithEvents BtnCD As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LEP As Label
    Friend WithEvents LMP As Label
    Friend WithEvents LNP As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBarra As PictureBox
End Class
