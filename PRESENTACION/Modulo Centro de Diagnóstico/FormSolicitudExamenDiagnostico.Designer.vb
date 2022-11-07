<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSolicitudExamenDiagnostico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSolicitudExamenDiagnostico))
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBarra = New System.Windows.Forms.PictureBox()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CbxPaciente = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxbBuscarPaciente = New System.Windows.Forms.TextBox()
        Me.LCP = New System.Windows.Forms.Label()
        Me.LNP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBCP = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Gray
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(736, 9)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(34, 31)
        Me.BtnCerrar.TabIndex = 44
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(217, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(352, 29)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Solicitud de examen Diagnótico"
        '
        'PictureBarra
        '
        Me.PictureBarra.BackColor = System.Drawing.Color.Gray
        Me.PictureBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBarra.Location = New System.Drawing.Point(0, 0)
        Me.PictureBarra.Name = "PictureBarra"
        Me.PictureBarra.Size = New System.Drawing.Size(782, 50)
        Me.PictureBarra.TabIndex = 47
        Me.PictureBarra.TabStop = False
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(75, 154)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(15, 16)
        Me.LT.TabIndex = 729
        Me.LT.Text = "--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 730
        Me.Label11.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(75, 177)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(15, 16)
        Me.LN.TabIndex = 731
        Me.LN.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 732
        Me.Label10.Text = "Usuario:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(782, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 728
        Me.PictureBox2.TabStop = False
        '
        'CbxPaciente
        '
        Me.CbxPaciente.FormattingEnabled = True
        Me.CbxPaciente.Location = New System.Drawing.Point(6, 70)
        Me.CbxPaciente.Name = "CbxPaciente"
        Me.CbxPaciente.Size = New System.Drawing.Size(205, 24)
        Me.CbxPaciente.TabIndex = 733
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CheckBCP)
        Me.Panel1.Controls.Add(Me.TxbBuscarPaciente)
        Me.Panel1.Controls.Add(Me.LCP)
        Me.Panel1.Controls.Add(Me.LNP)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CbxPaciente)
        Me.Panel1.Location = New System.Drawing.Point(12, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 183)
        Me.Panel1.TabIndex = 734
        '
        'TxbBuscarPaciente
        '
        Me.TxbBuscarPaciente.Location = New System.Drawing.Point(11, 26)
        Me.TxbBuscarPaciente.Name = "TxbBuscarPaciente"
        Me.TxbBuscarPaciente.Size = New System.Drawing.Size(118, 22)
        Me.TxbBuscarPaciente.TabIndex = 739
        '
        'LCP
        '
        Me.LCP.AutoSize = True
        Me.LCP.Location = New System.Drawing.Point(5, 132)
        Me.LCP.Name = "LCP"
        Me.LCP.Size = New System.Drawing.Size(91, 16)
        Me.LCP.TabIndex = 737
        Me.LCP.Text = "Cod Paciente:"
        '
        'LNP
        '
        Me.LNP.AutoSize = True
        Me.LNP.Location = New System.Drawing.Point(4, 104)
        Me.LNP.Name = "LNP"
        Me.LNP.Size = New System.Drawing.Size(63, 16)
        Me.LNP.TabIndex = 738
        Me.LNP.Text = "Paciente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 736
        Me.Label2.Text = "Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 734
        Me.Label1.Text = "Paciente"
        '
        'CheckBCP
        '
        Me.CheckBCP.AutoSize = True
        Me.CheckBCP.Location = New System.Drawing.Point(135, 28)
        Me.CheckBCP.Name = "CheckBCP"
        Me.CheckBCP.Size = New System.Drawing.Size(137, 20)
        Me.CheckBCP.TabIndex = 740
        Me.CheckBCP.Text = "Por Cod. Paciente"
        Me.CheckBCP.UseVisualStyleBackColor = True
        '
        'FormSolicitudExamenDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSolicitudExamenDiagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSolicitudExamenDiagnostico"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CbxPaciente As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LCP As Label
    Friend WithEvents LNP As Label
    Friend WithEvents TxbBuscarPaciente As TextBox
    Friend WithEvents CheckBCP As CheckBox
End Class
