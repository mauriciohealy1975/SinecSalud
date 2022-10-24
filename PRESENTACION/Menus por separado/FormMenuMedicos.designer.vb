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
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CerrarSesion = New System.Windows.Forms.Button()
        Me.BtnBM = New System.Windows.Forms.Button()
        Me.BtnRecetas = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOrdenServiciosEnfemeria
        '
        Me.btnOrdenServiciosEnfemeria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenServiciosEnfemeria.Location = New System.Drawing.Point(92, 242)
        Me.btnOrdenServiciosEnfemeria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrdenServiciosEnfemeria.Name = "btnOrdenServiciosEnfemeria"
        Me.btnOrdenServiciosEnfemeria.Size = New System.Drawing.Size(263, 57)
        Me.btnOrdenServiciosEnfemeria.TabIndex = 2
        Me.btnOrdenServiciosEnfemeria.Text = "Orden para servicios enfermería"
        Me.btnOrdenServiciosEnfemeria.UseVisualStyleBackColor = True
        '
        'btnTransfernciaMedica
        '
        Me.btnTransfernciaMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfernciaMedica.Location = New System.Drawing.Point(372, 242)
        Me.btnTransfernciaMedica.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTransfernciaMedica.Name = "btnTransfernciaMedica"
        Me.btnTransfernciaMedica.Size = New System.Drawing.Size(263, 57)
        Me.btnTransfernciaMedica.TabIndex = 2
        Me.btnTransfernciaMedica.Text = "Transferencia Medica"
        Me.btnTransfernciaMedica.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.SystemColors.Control
        Me.BtnVolver.Location = New System.Drawing.Point(639, 468)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(131, 34)
        Me.BtnVolver.TabIndex = 14
        Me.BtnVolver.Text = "Menú Principal"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(89, 158)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 16
        Me.LT.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(89, 132)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 18
        Me.LN.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'CerrarSesion
        '
        Me.CerrarSesion.Location = New System.Drawing.Point(639, 508)
        Me.CerrarSesion.Name = "CerrarSesion"
        Me.CerrarSesion.Size = New System.Drawing.Size(131, 34)
        Me.CerrarSesion.TabIndex = 20
        Me.CerrarSesion.Text = "Cerrar Sesión"
        Me.CerrarSesion.UseVisualStyleBackColor = True
        '
        'BtnBM
        '
        Me.BtnBM.Location = New System.Drawing.Point(372, 319)
        Me.BtnBM.Name = "BtnBM"
        Me.BtnBM.Size = New System.Drawing.Size(263, 57)
        Me.BtnBM.TabIndex = 21
        Me.BtnBM.Text = "Bajas Medicas"
        Me.BtnBM.UseVisualStyleBackColor = True
        '
        'BtnRecetas
        '
        Me.BtnRecetas.Location = New System.Drawing.Point(92, 319)
        Me.BtnRecetas.Name = "BtnRecetas"
        Me.BtnRecetas.Size = New System.Drawing.Size(263, 57)
        Me.BtnRecetas.TabIndex = 22
        Me.BtnRecetas.Text = "Recetas"
        Me.BtnRecetas.UseVisualStyleBackColor = True
        '
        'FormMenuMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.BtnRecetas)
        Me.Controls.Add(Me.BtnBM)
        Me.Controls.Add(Me.CerrarSesion)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOrdenServiciosEnfemeria)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.btnTransfernciaMedica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormMenuMedicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicina"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTransfernciaMedica As System.Windows.Forms.Button
    Friend WithEvents btnOrdenServiciosEnfemeria As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents LT As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CerrarSesion As Button
    Friend WithEvents BtnBM As Button
    Friend WithEvents BtnRecetas As Button
End Class
