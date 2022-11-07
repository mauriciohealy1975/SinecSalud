<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegMedDiagnostico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegMedDiagnostico))
        Me.TxbNombre = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.LTel = New System.Windows.Forms.Label()
        Me.TxbTelefono = New System.Windows.Forms.TextBox()
        Me.TbxDireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxHE = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxME = New System.Windows.Forms.ComboBox()
        Me.CbxMS = New System.Windows.Forms.ComboBox()
        Me.CbxHS = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckLunes = New System.Windows.Forms.CheckBox()
        Me.CheckMartes = New System.Windows.Forms.CheckBox()
        Me.CheckMiercoles = New System.Windows.Forms.CheckBox()
        Me.CheckJueves = New System.Windows.Forms.CheckBox()
        Me.CheckViernes = New System.Windows.Forms.CheckBox()
        Me.ChecklunesAviernes = New System.Windows.Forms.CheckBox()
        Me.PanelDiaHora = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgvPOE = New System.Windows.Forms.DataGridView()
        Me.CbxProcedimientos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAgegarProced = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnAgregarEco = New System.Windows.Forms.Button()
        Me.CbxEcografias = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxbBuscarEco = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxbBuscarproc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.PictureBarra = New System.Windows.Forms.PictureBox()
        Me.CheckDiaria = New System.Windows.Forms.CheckBox()
        Me.CheckMensual = New System.Windows.Forms.CheckBox()
        Me.BtnAgregarNuevoPoe = New System.Windows.Forms.Button()
        Me.PanelDiaHora.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvPOE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxbNombre
        '
        Me.TxbNombre.Enabled = False
        Me.TxbNombre.Location = New System.Drawing.Point(7, 43)
        Me.TxbNombre.Name = "TxbNombre"
        Me.TxbNombre.Size = New System.Drawing.Size(273, 22)
        Me.TxbNombre.TabIndex = 0
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Location = New System.Drawing.Point(10, 116)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(64, 16)
        Me.LDireccion.TabIndex = 10
        Me.LDireccion.Text = "Direccion"
        '
        'LTel
        '
        Me.LTel.AutoSize = True
        Me.LTel.Location = New System.Drawing.Point(7, 69)
        Me.LTel.Name = "LTel"
        Me.LTel.Size = New System.Drawing.Size(68, 16)
        Me.LTel.TabIndex = 11
        Me.LTel.Text = "Telefonos"
        '
        'TxbTelefono
        '
        Me.TxbTelefono.Location = New System.Drawing.Point(7, 91)
        Me.TxbTelefono.Name = "TxbTelefono"
        Me.TxbTelefono.Size = New System.Drawing.Size(273, 22)
        Me.TxbTelefono.TabIndex = 9
        Me.TxbTelefono.Text = "3364160"
        '
        'TbxDireccion
        '
        Me.TbxDireccion.Location = New System.Drawing.Point(10, 134)
        Me.TbxDireccion.Name = "TbxDireccion"
        Me.TbxDireccion.Size = New System.Drawing.Size(273, 22)
        Me.TbxDireccion.TabIndex = 8
        Me.TbxDireccion.Text = "C/ España Nº473"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre"
        '
        'TxbCantidad
        '
        Me.TxbCantidad.Location = New System.Drawing.Point(209, 213)
        Me.TxbCantidad.Name = "TxbCantidad"
        Me.TxbCantidad.Size = New System.Drawing.Size(39, 22)
        Me.TxbCantidad.TabIndex = 13
        Me.TxbCantidad.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cantidad de fichas"
        '
        'CbxHE
        '
        Me.CbxHE.FormattingEnabled = True
        Me.CbxHE.Location = New System.Drawing.Point(21, 173)
        Me.CbxHE.Name = "CbxHE"
        Me.CbxHE.Size = New System.Drawing.Size(50, 24)
        Me.CbxHE.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Dias y horario"
        '
        'CbxME
        '
        Me.CbxME.FormattingEnabled = True
        Me.CbxME.Location = New System.Drawing.Point(77, 173)
        Me.CbxME.Name = "CbxME"
        Me.CbxME.Size = New System.Drawing.Size(50, 24)
        Me.CbxME.TabIndex = 16
        '
        'CbxMS
        '
        Me.CbxMS.FormattingEnabled = True
        Me.CbxMS.Location = New System.Drawing.Point(198, 173)
        Me.CbxMS.Name = "CbxMS"
        Me.CbxMS.Size = New System.Drawing.Size(50, 24)
        Me.CbxMS.TabIndex = 18
        '
        'CbxHS
        '
        Me.CbxHS.FormattingEnabled = True
        Me.CbxHS.Location = New System.Drawing.Point(142, 173)
        Me.CbxHS.Name = "CbxHS"
        Me.CbxHS.Size = New System.Drawing.Size(50, 24)
        Me.CbxHS.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Entrada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Salida"
        '
        'CheckLunes
        '
        Me.CheckLunes.AutoSize = True
        Me.CheckLunes.Location = New System.Drawing.Point(60, 337)
        Me.CheckLunes.Name = "CheckLunes"
        Me.CheckLunes.Size = New System.Drawing.Size(65, 20)
        Me.CheckLunes.TabIndex = 21
        Me.CheckLunes.Text = "Lunes"
        Me.CheckLunes.UseVisualStyleBackColor = True
        '
        'CheckMartes
        '
        Me.CheckMartes.AutoSize = True
        Me.CheckMartes.Location = New System.Drawing.Point(141, 337)
        Me.CheckMartes.Name = "CheckMartes"
        Me.CheckMartes.Size = New System.Drawing.Size(70, 20)
        Me.CheckMartes.TabIndex = 22
        Me.CheckMartes.Text = "Martes"
        Me.CheckMartes.UseVisualStyleBackColor = True
        '
        'CheckMiercoles
        '
        Me.CheckMiercoles.AutoSize = True
        Me.CheckMiercoles.Location = New System.Drawing.Point(25, 363)
        Me.CheckMiercoles.Name = "CheckMiercoles"
        Me.CheckMiercoles.Size = New System.Drawing.Size(88, 20)
        Me.CheckMiercoles.TabIndex = 23
        Me.CheckMiercoles.Text = "Miercoles"
        Me.CheckMiercoles.UseVisualStyleBackColor = True
        '
        'CheckJueves
        '
        Me.CheckJueves.AutoSize = True
        Me.CheckJueves.Location = New System.Drawing.Point(119, 363)
        Me.CheckJueves.Name = "CheckJueves"
        Me.CheckJueves.Size = New System.Drawing.Size(73, 20)
        Me.CheckJueves.TabIndex = 24
        Me.CheckJueves.Text = "Jueves"
        Me.CheckJueves.UseVisualStyleBackColor = True
        '
        'CheckViernes
        '
        Me.CheckViernes.AutoSize = True
        Me.CheckViernes.Location = New System.Drawing.Point(198, 363)
        Me.CheckViernes.Name = "CheckViernes"
        Me.CheckViernes.Size = New System.Drawing.Size(75, 20)
        Me.CheckViernes.TabIndex = 25
        Me.CheckViernes.Text = "Viernes"
        Me.CheckViernes.UseVisualStyleBackColor = True
        '
        'ChecklunesAviernes
        '
        Me.ChecklunesAviernes.AutoSize = True
        Me.ChecklunesAviernes.Location = New System.Drawing.Point(102, 310)
        Me.ChecklunesAviernes.Name = "ChecklunesAviernes"
        Me.ChecklunesAviernes.Size = New System.Drawing.Size(69, 20)
        Me.ChecklunesAviernes.TabIndex = 26
        Me.ChecklunesAviernes.Text = "Todos"
        Me.ChecklunesAviernes.UseVisualStyleBackColor = True
        '
        'PanelDiaHora
        '
        Me.PanelDiaHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDiaHora.Controls.Add(Me.TxbCantidad)
        Me.PanelDiaHora.Controls.Add(Me.CheckMensual)
        Me.PanelDiaHora.Controls.Add(Me.CheckDiaria)
        Me.PanelDiaHora.Controls.Add(Me.Label4)
        Me.PanelDiaHora.Controls.Add(Me.CbxHE)
        Me.PanelDiaHora.Controls.Add(Me.Label5)
        Me.PanelDiaHora.Controls.Add(Me.CbxMS)
        Me.PanelDiaHora.Controls.Add(Me.Label2)
        Me.PanelDiaHora.Controls.Add(Me.CbxME)
        Me.PanelDiaHora.Controls.Add(Me.Label3)
        Me.PanelDiaHora.Controls.Add(Me.CbxHS)
        Me.PanelDiaHora.Location = New System.Drawing.Point(7, 167)
        Me.PanelDiaHora.Name = "PanelDiaHora"
        Me.PanelDiaHora.Size = New System.Drawing.Size(276, 244)
        Me.PanelDiaHora.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PanelDiaHora)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxbNombre)
        Me.Panel2.Controls.Add(Me.TbxDireccion)
        Me.Panel2.Controls.Add(Me.TxbTelefono)
        Me.Panel2.Controls.Add(Me.LDireccion)
        Me.Panel2.Controls.Add(Me.LTel)
        Me.Panel2.Location = New System.Drawing.Point(4, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 419)
        Me.Panel2.TabIndex = 28
        '
        'DgvPOE
        '
        Me.DgvPOE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPOE.Location = New System.Drawing.Point(5, 167)
        Me.DgvPOE.Name = "DgvPOE"
        Me.DgvPOE.RowHeadersWidth = 51
        Me.DgvPOE.RowTemplate.Height = 24
        Me.DgvPOE.Size = New System.Drawing.Size(454, 244)
        Me.DgvPOE.TabIndex = 29
        '
        'CbxProcedimientos
        '
        Me.CbxProcedimientos.FormattingEnabled = True
        Me.CbxProcedimientos.Location = New System.Drawing.Point(5, 96)
        Me.CbxProcedimientos.Name = "CbxProcedimientos"
        Me.CbxProcedimientos.Size = New System.Drawing.Size(221, 24)
        Me.CbxProcedimientos.TabIndex = 30
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
        'BtnAgegarProced
        '
        Me.BtnAgegarProced.Location = New System.Drawing.Point(119, 127)
        Me.BtnAgegarProced.Name = "BtnAgegarProced"
        Me.BtnAgegarProced.Size = New System.Drawing.Size(107, 29)
        Me.BtnAgegarProced.TabIndex = 32
        Me.BtnAgegarProced.Text = "Agregar"
        Me.BtnAgegarProced.UseVisualStyleBackColor = True
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
        Me.Panel3.Location = New System.Drawing.Point(304, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(473, 419)
        Me.Panel3.TabIndex = 33
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(525, 29)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Registro de Médico Para Centro de Diagnóstico"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Gray
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(743, 10)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(34, 31)
        Me.BtnCerrar.TabIndex = 34
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Location = New System.Drawing.Point(678, 511)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(87, 30)
        Me.BtnRegistrar.TabIndex = 38
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'PictureBarra
        '
        Me.PictureBarra.BackColor = System.Drawing.Color.Gray
        Me.PictureBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBarra.Location = New System.Drawing.Point(0, 0)
        Me.PictureBarra.Name = "PictureBarra"
        Me.PictureBarra.Size = New System.Drawing.Size(782, 50)
        Me.PictureBarra.TabIndex = 39
        Me.PictureBarra.TabStop = False
        '
        'CheckDiaria
        '
        Me.CheckDiaria.AutoSize = True
        Me.CheckDiaria.Location = New System.Drawing.Point(121, 215)
        Me.CheckDiaria.Name = "CheckDiaria"
        Me.CheckDiaria.Size = New System.Drawing.Size(39, 20)
        Me.CheckDiaria.TabIndex = 21
        Me.CheckDiaria.Text = "D"
        Me.CheckDiaria.UseVisualStyleBackColor = True
        '
        'CheckMensual
        '
        Me.CheckMensual.AutoSize = True
        Me.CheckMensual.Location = New System.Drawing.Point(165, 215)
        Me.CheckMensual.Name = "CheckMensual"
        Me.CheckMensual.Size = New System.Drawing.Size(40, 20)
        Me.CheckMensual.TabIndex = 22
        Me.CheckMensual.Text = "M"
        Me.CheckMensual.UseVisualStyleBackColor = True
        '
        'BtnAgregarNuevoPoe
        '
        Me.BtnAgregarNuevoPoe.Location = New System.Drawing.Point(511, 511)
        Me.BtnAgregarNuevoPoe.Name = "BtnAgregarNuevoPoe"
        Me.BtnAgregarNuevoPoe.Size = New System.Drawing.Size(161, 30)
        Me.BtnAgregarNuevoPoe.TabIndex = 40
        Me.BtnAgregarNuevoPoe.Text = "Agregar nuevo POE"
        Me.BtnAgregarNuevoPoe.UseVisualStyleBackColor = True
        '
        'FormRegMedDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.BtnAgregarNuevoPoe)
        Me.Controls.Add(Me.ChecklunesAviernes)
        Me.Controls.Add(Me.CheckLunes)
        Me.Controls.Add(Me.CheckJueves)
        Me.Controls.Add(Me.CheckViernes)
        Me.Controls.Add(Me.CheckMartes)
        Me.Controls.Add(Me.CheckMiercoles)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBarra)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRegMedDiagnostico"
        Me.Text = "Registro de Medico de Diagnóstico"
        Me.PanelDiaHora.ResumeLayout(False)
        Me.PanelDiaHora.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvPOE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxbNombre As TextBox
    Friend WithEvents LDireccion As Label
    Friend WithEvents LTel As Label
    Friend WithEvents TxbTelefono As TextBox
    Friend WithEvents TbxDireccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbxHE As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbxME As ComboBox
    Friend WithEvents CbxMS As ComboBox
    Friend WithEvents CbxHS As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckLunes As CheckBox
    Friend WithEvents CheckMartes As CheckBox
    Friend WithEvents CheckMiercoles As CheckBox
    Friend WithEvents CheckJueves As CheckBox
    Friend WithEvents CheckViernes As CheckBox
    Friend WithEvents ChecklunesAviernes As CheckBox
    Friend WithEvents PanelDiaHora As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DgvPOE As DataGridView
    Friend WithEvents CbxProcedimientos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnAgegarProced As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxbBuscarproc As TextBox
    Friend WithEvents PictureBarra As PictureBox
    Friend WithEvents CbxEcografias As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxbBuscarEco As TextBox
    Friend WithEvents BtnAgregarEco As Button
    Friend WithEvents CheckMensual As CheckBox
    Friend WithEvents CheckDiaria As CheckBox
    Friend WithEvents BtnAgregarNuevoPoe As Button
End Class
