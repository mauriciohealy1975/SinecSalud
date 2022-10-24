<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAgregarSubMedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarSubMedicamento))
        Me.LT = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbLiname = New System.Windows.Forms.ComboBox()
        Me.TxbBuscar = New System.Windows.Forms.TextBox()
        Me.TxbNombreSubmedicamento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbBuscarProveedor = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbBuscarTipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbTipoMedicamento = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnActivaNewProveedor = New System.Windows.Forms.Button()
        Me.TxbNuevoProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAgregarProveedor = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(78, 163)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 31
        Me.LT.Text = "Tipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(78, 137)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 33
        Me.LN.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(426, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Buscar :"
        '
        'CbLiname
        '
        Me.CbLiname.DropDownWidth = 300
        Me.CbLiname.FormattingEnabled = True
        Me.CbLiname.Location = New System.Drawing.Point(122, 265)
        Me.CbLiname.Name = "CbLiname"
        Me.CbLiname.Size = New System.Drawing.Size(306, 24)
        Me.CbLiname.TabIndex = 36
        '
        'TxbBuscar
        '
        Me.TxbBuscar.Location = New System.Drawing.Point(28, 265)
        Me.TxbBuscar.Name = "TxbBuscar"
        Me.TxbBuscar.Size = New System.Drawing.Size(88, 22)
        Me.TxbBuscar.TabIndex = 37
        '
        'TxbNombreSubmedicamento
        '
        Me.TxbNombreSubmedicamento.Location = New System.Drawing.Point(29, 215)
        Me.TxbNombreSubmedicamento.Name = "TxbNombreSubmedicamento"
        Me.TxbNombreSubmedicamento.Size = New System.Drawing.Size(399, 22)
        Me.TxbNombreSubmedicamento.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Medicamento Liname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Nombre Nuevo Medicamento"
        '
        'CbProveedor
        '
        Me.CbProveedor.DropDownWidth = 200
        Me.CbProveedor.FormattingEnabled = True
        Me.CbProveedor.Location = New System.Drawing.Point(122, 314)
        Me.CbProveedor.Name = "CbProveedor"
        Me.CbProveedor.Size = New System.Drawing.Size(306, 24)
        Me.CbProveedor.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Proveedor :"
        '
        'TbBuscarProveedor
        '
        Me.TbBuscarProveedor.Location = New System.Drawing.Point(29, 316)
        Me.TbBuscarProveedor.Name = "TbBuscarProveedor"
        Me.TbBuscarProveedor.Size = New System.Drawing.Size(87, 22)
        Me.TbBuscarProveedor.TabIndex = 41
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(332, 505)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(96, 36)
        Me.BtnAgregar.TabIndex = 43
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(230, 505)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 36)
        Me.BtnCancelar.TabIndex = 43
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Buscar :"
        '
        'TxbBuscarTipo
        '
        Me.TxbBuscarTipo.Location = New System.Drawing.Point(29, 365)
        Me.TxbBuscarTipo.Name = "TxbBuscarTipo"
        Me.TxbBuscarTipo.Size = New System.Drawing.Size(87, 22)
        Me.TxbBuscarTipo.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Tipo"
        '
        'CbTipoMedicamento
        '
        Me.CbTipoMedicamento.DropDownWidth = 200
        Me.CbTipoMedicamento.FormattingEnabled = True
        Me.CbTipoMedicamento.Location = New System.Drawing.Point(122, 363)
        Me.CbTipoMedicamento.Name = "CbTipoMedicamento"
        Me.CbTipoMedicamento.Size = New System.Drawing.Size(306, 24)
        Me.CbTipoMedicamento.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Buscar :"
        '
        'BtnActivaNewProveedor
        '
        Me.BtnActivaNewProveedor.Location = New System.Drawing.Point(434, 314)
        Me.BtnActivaNewProveedor.Name = "BtnActivaNewProveedor"
        Me.BtnActivaNewProveedor.Size = New System.Drawing.Size(26, 24)
        Me.BtnActivaNewProveedor.TabIndex = 49
        Me.BtnActivaNewProveedor.Text = "+"
        Me.BtnActivaNewProveedor.UseVisualStyleBackColor = True
        '
        'TxbNuevoProveedor
        '
        Me.TxbNuevoProveedor.Location = New System.Drawing.Point(28, 423)
        Me.TxbNuevoProveedor.Name = "TxbNuevoProveedor"
        Me.TxbNuevoProveedor.Size = New System.Drawing.Size(399, 22)
        Me.TxbNuevoProveedor.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Nuevo Proveedor:"
        '
        'BtnAgregarProveedor
        '
        Me.BtnAgregarProveedor.Location = New System.Drawing.Point(323, 451)
        Me.BtnAgregarProveedor.Name = "BtnAgregarProveedor"
        Me.BtnAgregarProveedor.Size = New System.Drawing.Size(104, 42)
        Me.BtnAgregarProveedor.TabIndex = 52
        Me.BtnAgregarProveedor.Text = "Registrar Proveedor"
        Me.BtnAgregarProveedor.UseVisualStyleBackColor = True
        '
        'FormAgregarSubMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 553)
        Me.Controls.Add(Me.BtnAgregarProveedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxbNuevoProveedor)
        Me.Controls.Add(Me.BtnActivaNewProveedor)
        Me.Controls.Add(Me.TxbBuscarTipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CbTipoMedicamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TbBuscarProveedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbProveedor)
        Me.Controls.Add(Me.TxbNombreSubmedicamento)
        Me.Controls.Add(Me.TxbBuscar)
        Me.Controls.Add(Me.CbLiname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormAgregarSubMedicamento"
        Me.Text = "Registrar nuevo Medicamento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LT As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbLiname As ComboBox
    Friend WithEvents TxbBuscar As TextBox
    Friend WithEvents TxbNombreSubmedicamento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbProveedor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbBuscarProveedor As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbBuscarTipo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbTipoMedicamento As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnActivaNewProveedor As Button
    Friend WithEvents TxbNuevoProveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnAgregarProveedor As Button
End Class
