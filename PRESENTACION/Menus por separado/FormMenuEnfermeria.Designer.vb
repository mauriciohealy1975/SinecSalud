<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuEnfermeria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuEnfermeria))
        Me.btnEjecucionServicio = New System.Windows.Forms.Button()
        Me.btnInyectables = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.LT = New System.Windows.Forms.Label()
        Me.CerrarSesion = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEjecucionServicio
        '
        Me.btnEjecucionServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecucionServicio.Location = New System.Drawing.Point(242, 218)
        Me.btnEjecucionServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEjecucionServicio.Name = "btnEjecucionServicio"
        Me.btnEjecucionServicio.Size = New System.Drawing.Size(150, 56)
        Me.btnEjecucionServicio.TabIndex = 1
        Me.btnEjecucionServicio.Text = "Ejecución Servicio"
        Me.btnEjecucionServicio.UseVisualStyleBackColor = True
        '
        'btnInyectables
        '
        Me.btnInyectables.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInyectables.Location = New System.Drawing.Point(400, 218)
        Me.btnInyectables.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInyectables.Name = "btnInyectables"
        Me.btnInyectables.Size = New System.Drawing.Size(150, 56)
        Me.btnInyectables.TabIndex = 1
        Me.btnInyectables.Text = "Inyectable Suministrado"
        Me.btnInyectables.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.SystemColors.Control
        Me.BtnVolver.Location = New System.Drawing.Point(639, 467)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(131, 34)
        Me.BtnVolver.TabIndex = 1
        Me.BtnVolver.Text = "Menu Principal"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(101, 141)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 3
        Me.LN.Text = "Nombre"
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(101, 167)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 3
        Me.LT.Text = "Tipo"
        '
        'CerrarSesion
        '
        Me.CerrarSesion.Location = New System.Drawing.Point(639, 507)
        Me.CerrarSesion.Name = "CerrarSesion"
        Me.CerrarSesion.Size = New System.Drawing.Size(131, 34)
        Me.CerrarSesion.TabIndex = 4
        Me.CerrarSesion.Text = "Cerrar Sesión"
        Me.CerrarSesion.UseVisualStyleBackColor = True
        '
        'FormMenuEnfermeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.CerrarSesion)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEjecucionServicio)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.btnInyectables)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormMenuEnfermeria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENFERMERIA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInyectables As System.Windows.Forms.Button
    Friend WithEvents btnEjecucionServicio As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LN As Label
    Friend WithEvents LT As Label
    Friend WithEvents CerrarSesion As Button
End Class
