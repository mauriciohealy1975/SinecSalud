<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSolicitudExamenDiagnostico
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
        Me.CheckBCP = New System.Windows.Forms.CheckBox()
        Me.TxbBuscarPaciente = New System.Windows.Forms.TextBox()
        Me.LCP = New System.Windows.Forms.Label()
        Me.LNP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnAgregarEco = New System.Windows.Forms.Button()
        Me.CbxEcografias = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxbBuscarEco = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxbBuscarproc = New System.Windows.Forms.TextBox()
        Me.BtnAgegarProced = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbxProcedimientos = New System.Windows.Forms.ComboBox()
        Me.DgvPOE = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DgvPOE, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBarra.Size = New System.Drawing.Size(800, 50)
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
        Me.Panel1.Size = New System.Drawing.Size(275, 162)
        Me.Panel1.TabIndex = 734
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
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.BtnAgregarEco)
        Me.Panel3.Controls.Add(Me.CbxEcografias)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TxbBuscarEco)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TxbBuscarproc)
        Me.Panel3.Controls.Add(Me.BtnAgegarProced)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.CbxProcedimientos)
        Me.Panel3.Controls.Add(Me.DgvPOE)
        Me.Panel3.Location = New System.Drawing.Point(315, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(473, 389)
        Me.Panel3.TabIndex = 735
        '
        'BtnAgregarEco
        '
        Me.BtnAgregarEco.Location = New System.Drawing.Point(346, 134)
        Me.BtnAgregarEco.Name = "BtnAgregarEco"
        Me.BtnAgregarEco.Size = New System.Drawing.Size(107, 29)
        Me.BtnAgregarEco.TabIndex = 36
        Me.BtnAgregarEco.Text = "Agregar"
        Me.BtnAgregarEco.UseVisualStyleBackColor = True
        '
        'CbxEcografias
        '
        Me.CbxEcografias.FormattingEnabled = True
        Me.CbxEcografias.Location = New System.Drawing.Point(232, 96)
        Me.CbxEcografias.Name = "CbxEcografias"
        Me.CbxEcografias.Size = New System.Drawing.Size(221, 24)
        Me.CbxEcografias.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(229, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Buscar Ecografía"
        '
        'TxbBuscarEco
        '
        Me.TxbBuscarEco.Location = New System.Drawing.Point(232, 68)
        Me.TxbBuscarEco.Name = "TxbBuscarEco"
        Me.TxbBuscarEco.Size = New System.Drawing.Size(221, 22)
        Me.TxbBuscarEco.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Buscar Procedimiento"
        '
        'TxbBuscarproc
        '
        Me.TxbBuscarproc.Location = New System.Drawing.Point(5, 68)
        Me.TxbBuscarproc.Name = "TxbBuscarproc"
        Me.TxbBuscarproc.Size = New System.Drawing.Size(221, 22)
        Me.TxbBuscarproc.TabIndex = 28
        '
        'BtnAgegarProced
        '
        Me.BtnAgegarProced.Location = New System.Drawing.Point(119, 127)
        Me.BtnAgegarProced.Name = "BtnAgegarProced"
        Me.BtnAgegarProced.Size = New System.Drawing.Size(107, 29)
        Me.BtnAgegarProced.TabIndex = 32
        Me.BtnAgegarProced.Text = "Agregar"
        Me.BtnAgegarProced.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(383, 32)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = " Procedimientos o Ecografias"
        '
        'CbxProcedimientos
        '
        Me.CbxProcedimientos.FormattingEnabled = True
        Me.CbxProcedimientos.Location = New System.Drawing.Point(5, 96)
        Me.CbxProcedimientos.Name = "CbxProcedimientos"
        Me.CbxProcedimientos.Size = New System.Drawing.Size(221, 24)
        Me.CbxProcedimientos.TabIndex = 30
        '
        'DgvPOE
        '
        Me.DgvPOE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPOE.Location = New System.Drawing.Point(5, 167)
        Me.DgvPOE.Name = "DgvPOE"
        Me.DgvPOE.RowHeadersWidth = 51
        Me.DgvPOE.RowTemplate.Height = 24
        Me.DgvPOE.Size = New System.Drawing.Size(454, 215)
        Me.DgvPOE.TabIndex = 29
        '
        'FormSolicitudExamenDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel3)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DgvPOE, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnAgregarEco As Button
    Friend WithEvents CbxEcografias As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxbBuscarEco As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxbBuscarproc As TextBox
    Friend WithEvents BtnAgegarProced As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CbxProcedimientos As ComboBox
    Friend WithEvents DgvPOE As DataGridView
End Class
