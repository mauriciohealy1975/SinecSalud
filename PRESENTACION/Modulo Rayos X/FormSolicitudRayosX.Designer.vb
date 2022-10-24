<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSolicitudRayosX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSolicitudRayosX))
        Me.LT = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbxPaciente = New System.Windows.Forms.ComboBox()
        Me.LPaciente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxRadiografias = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNP = New System.Windows.Forms.Label()
        Me.LCP = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.CheckTamano1 = New System.Windows.Forms.CheckBox()
        Me.checkTamano2 = New System.Windows.Forms.CheckBox()
        Me.checktamano3 = New System.Windows.Forms.CheckBox()
        Me.TxbBuscarPaciente = New System.Windows.Forms.TextBox()
        Me.CheckBCP = New System.Windows.Forms.CheckBox()
        Me.TxbBuscarTipoRadiografia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(75, 114)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(15, 16)
        Me.LT.TabIndex = 724
        Me.LT.Text = "--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 725
        Me.Label11.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(75, 137)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(15, 16)
        Me.LN.TabIndex = 726
        Me.LN.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 727
        Me.Label10.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 723
        Me.PictureBox1.TabStop = False
        '
        'CbxPaciente
        '
        Me.CbxPaciente.DropDownHeight = 100
        Me.CbxPaciente.DropDownWidth = 250
        Me.CbxPaciente.FormattingEnabled = True
        Me.CbxPaciente.IntegralHeight = False
        Me.CbxPaciente.Location = New System.Drawing.Point(15, 183)
        Me.CbxPaciente.Name = "CbxPaciente"
        Me.CbxPaciente.Size = New System.Drawing.Size(181, 24)
        Me.CbxPaciente.TabIndex = 728
        '
        'LPaciente
        '
        Me.LPaciente.AutoSize = True
        Me.LPaciente.Location = New System.Drawing.Point(12, 160)
        Me.LPaciente.Name = "LPaciente"
        Me.LPaciente.Size = New System.Drawing.Size(60, 16)
        Me.LPaciente.TabIndex = 729
        Me.LPaciente.Text = "Paciente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(692, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 729
        Me.Label1.Text = "Tamaño"
        '
        'CbxRadiografias
        '
        Me.CbxRadiografias.FormattingEnabled = True
        Me.CbxRadiografias.Location = New System.Drawing.Point(498, 183)
        Me.CbxRadiografias.Name = "CbxRadiografias"
        Me.CbxRadiografias.Size = New System.Drawing.Size(181, 24)
        Me.CbxRadiografias.TabIndex = 728
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(495, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 729
        Me.Label2.Text = "Examenes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(495, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 729
        Me.Label3.Text = "Cantidad"
        '
        'LNP
        '
        Me.LNP.AutoSize = True
        Me.LNP.Location = New System.Drawing.Point(11, 216)
        Me.LNP.Name = "LNP"
        Me.LNP.Size = New System.Drawing.Size(63, 16)
        Me.LNP.TabIndex = 729
        Me.LNP.Text = "Paciente:"
        '
        'LCP
        '
        Me.LCP.AutoSize = True
        Me.LCP.Location = New System.Drawing.Point(12, 244)
        Me.LCP.Name = "LCP"
        Me.LCP.Size = New System.Drawing.Size(91, 16)
        Me.LCP.TabIndex = 729
        Me.LCP.Text = "Cod Paciente:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 278)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(755, 220)
        Me.DataGridView1.TabIndex = 730
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(695, 223)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 37)
        Me.BtnAgregar.TabIndex = 731
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(562, 213)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 22)
        Me.TextBox1.TabIndex = 732
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(695, 504)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 37)
        Me.btnSolicitar.TabIndex = 731
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(614, 504)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 37)
        Me.BtnCancelar.TabIndex = 731
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'CheckTamano1
        '
        Me.CheckTamano1.AutoSize = True
        Me.CheckTamano1.Location = New System.Drawing.Point(695, 150)
        Me.CheckTamano1.Name = "CheckTamano1"
        Me.CheckTamano1.Size = New System.Drawing.Size(63, 20)
        Me.CheckTamano1.TabIndex = 733
        Me.CheckTamano1.Text = "30x20"
        Me.CheckTamano1.UseVisualStyleBackColor = True
        '
        'checkTamano2
        '
        Me.checkTamano2.AutoSize = True
        Me.checkTamano2.Location = New System.Drawing.Point(695, 172)
        Me.checkTamano2.Name = "checkTamano2"
        Me.checkTamano2.Size = New System.Drawing.Size(63, 20)
        Me.checkTamano2.TabIndex = 733
        Me.checkTamano2.Text = "20x20"
        Me.checkTamano2.UseVisualStyleBackColor = True
        '
        'checktamano3
        '
        Me.checktamano3.AutoSize = True
        Me.checktamano3.Location = New System.Drawing.Point(695, 195)
        Me.checktamano3.Name = "checktamano3"
        Me.checktamano3.Size = New System.Drawing.Size(63, 20)
        Me.checktamano3.TabIndex = 733
        Me.checktamano3.Text = "10x10"
        Me.checktamano3.UseVisualStyleBackColor = True
        '
        'TxbBuscarPaciente
        '
        Me.TxbBuscarPaciente.Location = New System.Drawing.Point(78, 154)
        Me.TxbBuscarPaciente.Name = "TxbBuscarPaciente"
        Me.TxbBuscarPaciente.Size = New System.Drawing.Size(118, 22)
        Me.TxbBuscarPaciente.TabIndex = 734
        '
        'CheckBCP
        '
        Me.CheckBCP.AutoSize = True
        Me.CheckBCP.Location = New System.Drawing.Point(203, 155)
        Me.CheckBCP.Name = "CheckBCP"
        Me.CheckBCP.Size = New System.Drawing.Size(137, 20)
        Me.CheckBCP.TabIndex = 735
        Me.CheckBCP.Text = "Por Cod. Paciente"
        Me.CheckBCP.UseVisualStyleBackColor = True
        '
        'TxbBuscarTipoRadiografia
        '
        Me.TxbBuscarTipoRadiografia.Location = New System.Drawing.Point(498, 142)
        Me.TxbBuscarTipoRadiografia.Name = "TxbBuscarTipoRadiografia"
        Me.TxbBuscarTipoRadiografia.Size = New System.Drawing.Size(118, 22)
        Me.TxbBuscarTipoRadiografia.TabIndex = 736
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(495, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 729
        Me.Label4.Text = "Buscar:"
        '
        'FormSolicitudRayosX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.TxbBuscarTipoRadiografia)
        Me.Controls.Add(Me.CheckBCP)
        Me.Controls.Add(Me.TxbBuscarPaciente)
        Me.Controls.Add(Me.checktamano3)
        Me.Controls.Add(Me.checkTamano2)
        Me.Controls.Add(Me.CheckTamano1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.btnSolicitar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LCP)
        Me.Controls.Add(Me.LNP)
        Me.Controls.Add(Me.LPaciente)
        Me.Controls.Add(Me.CbxRadiografias)
        Me.Controls.Add(Me.CbxPaciente)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormSolicitudRayosX"
        Me.Text = "SINEC RadioGrafias"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LT As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CbxPaciente As ComboBox
    Friend WithEvents LPaciente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxRadiografias As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LNP As Label
    Friend WithEvents LCP As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents CheckTamano1 As CheckBox
    Friend WithEvents checkTamano2 As CheckBox
    Friend WithEvents checktamano3 As CheckBox
    Friend WithEvents TxbBuscarPaciente As TextBox
    Friend WithEvents CheckBCP As CheckBox
    Friend WithEvents TxbBuscarTipoRadiografia As TextBox
    Friend WithEvents Label4 As Label
End Class
