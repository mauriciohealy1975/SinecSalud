<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuPrincipal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSolicitudesMedicas = New System.Windows.Forms.Button()
        Me.btnMedicos = New System.Windows.Forms.Button()
        Me.btnAfiliacion = New System.Windows.Forms.Button()
        Me.btnBajaMedica = New System.Windows.Forms.Button()
        Me.btnEnfermeria = New System.Windows.Forms.Button()
        Me.btnLaboratorio = New System.Windows.Forms.Button()
        Me.btnControlUsuario = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnRayosX = New System.Windows.Forms.Button()
        Me.BtnFarmacia = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(965, -39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sinec Administrador"
        '
        'btnSolicitudesMedicas
        '
        Me.btnSolicitudesMedicas.Enabled = False
        Me.btnSolicitudesMedicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitudesMedicas.Location = New System.Drawing.Point(19, 175)
        Me.btnSolicitudesMedicas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSolicitudesMedicas.Name = "btnSolicitudesMedicas"
        Me.btnSolicitudesMedicas.Size = New System.Drawing.Size(160, 60)
        Me.btnSolicitudesMedicas.TabIndex = 1
        Me.btnSolicitudesMedicas.Text = "Solicitudes Medicas"
        Me.btnSolicitudesMedicas.UseVisualStyleBackColor = True
        '
        'btnMedicos
        '
        Me.btnMedicos.Enabled = False
        Me.btnMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedicos.Location = New System.Drawing.Point(186, 238)
        Me.btnMedicos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMedicos.Name = "btnMedicos"
        Me.btnMedicos.Size = New System.Drawing.Size(160, 60)
        Me.btnMedicos.TabIndex = 2
        Me.btnMedicos.Text = "Médicos"
        Me.btnMedicos.UseVisualStyleBackColor = True
        '
        'btnAfiliacion
        '
        Me.btnAfiliacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfiliacion.Location = New System.Drawing.Point(19, 238)
        Me.btnAfiliacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAfiliacion.Name = "btnAfiliacion"
        Me.btnAfiliacion.Size = New System.Drawing.Size(160, 60)
        Me.btnAfiliacion.TabIndex = 3
        Me.btnAfiliacion.Text = "Afiliación"
        Me.btnAfiliacion.UseVisualStyleBackColor = True
        '
        'btnBajaMedica
        '
        Me.btnBajaMedica.Enabled = False
        Me.btnBajaMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaMedica.Location = New System.Drawing.Point(186, 301)
        Me.btnBajaMedica.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBajaMedica.Name = "btnBajaMedica"
        Me.btnBajaMedica.Size = New System.Drawing.Size(160, 60)
        Me.btnBajaMedica.TabIndex = 4
        Me.btnBajaMedica.Text = "Baja Medica"
        Me.btnBajaMedica.UseVisualStyleBackColor = True
        '
        'btnEnfermeria
        '
        Me.btnEnfermeria.Enabled = False
        Me.btnEnfermeria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnfermeria.Location = New System.Drawing.Point(186, 175)
        Me.btnEnfermeria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnfermeria.Name = "btnEnfermeria"
        Me.btnEnfermeria.Size = New System.Drawing.Size(160, 60)
        Me.btnEnfermeria.TabIndex = 5
        Me.btnEnfermeria.Text = "Enfermeria"
        Me.btnEnfermeria.UseVisualStyleBackColor = True
        '
        'btnLaboratorio
        '
        Me.btnLaboratorio.Enabled = False
        Me.btnLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaboratorio.Location = New System.Drawing.Point(19, 301)
        Me.btnLaboratorio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLaboratorio.Name = "btnLaboratorio"
        Me.btnLaboratorio.Size = New System.Drawing.Size(160, 60)
        Me.btnLaboratorio.TabIndex = 5
        Me.btnLaboratorio.Text = "Laboratorio"
        Me.btnLaboratorio.UseVisualStyleBackColor = True
        '
        'btnControlUsuario
        '
        Me.btnControlUsuario.Enabled = False
        Me.btnControlUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlUsuario.Location = New System.Drawing.Point(19, 368)
        Me.btnControlUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnControlUsuario.Name = "btnControlUsuario"
        Me.btnControlUsuario.Size = New System.Drawing.Size(493, 60)
        Me.btnControlUsuario.TabIndex = 6
        Me.btnControlUsuario.Text = "Módulo control de usuario"
        Me.btnControlUsuario.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(775, 116)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 60)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Centro De Diagonostico (pendiente)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnRayosX
        '
        Me.BtnRayosX.Location = New System.Drawing.Point(352, 241)
        Me.BtnRayosX.Name = "BtnRayosX"
        Me.BtnRayosX.Size = New System.Drawing.Size(160, 60)
        Me.BtnRayosX.TabIndex = 9
        Me.BtnRayosX.Text = "Rayos X (En Proceso)"
        Me.BtnRayosX.UseVisualStyleBackColor = True
        '
        'BtnFarmacia
        '
        Me.BtnFarmacia.Location = New System.Drawing.Point(352, 302)
        Me.BtnFarmacia.Name = "BtnFarmacia"
        Me.BtnFarmacia.Size = New System.Drawing.Size(160, 60)
        Me.BtnFarmacia.TabIndex = 9
        Me.BtnFarmacia.Text = "Farmacia"
        Me.BtnFarmacia.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(555, 88)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(215, 40)
        Me.Fecha.TabIndex = 7
        Me.Fecha.Text = "00/00/0000"
        '
        'FormMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.BtnFarmacia)
        Me.Controls.Add(Me.BtnRayosX)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnControlUsuario)
        Me.Controls.Add(Me.btnLaboratorio)
        Me.Controls.Add(Me.btnEnfermeria)
        Me.Controls.Add(Me.btnBajaMedica)
        Me.Controls.Add(Me.btnAfiliacion)
        Me.Controls.Add(Me.btnMedicos)
        Me.Controls.Add(Me.btnSolicitudesMedicas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Administrador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSolicitudesMedicas As System.Windows.Forms.Button
    Friend WithEvents btnMedicos As System.Windows.Forms.Button
    Friend WithEvents btnAfiliacion As System.Windows.Forms.Button
    Friend WithEvents btnBajaMedica As System.Windows.Forms.Button
    Friend WithEvents btnEnfermeria As System.Windows.Forms.Button
    Friend WithEvents btnLaboratorio As System.Windows.Forms.Button
    Friend WithEvents btnControlUsuario As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnRayosX As Button
    Friend WithEvents BtnFarmacia As Button
    Friend WithEvents Fecha As Label
End Class
