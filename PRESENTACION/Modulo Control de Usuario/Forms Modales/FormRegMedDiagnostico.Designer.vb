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
        Me.LSA = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DgvAsignados = New System.Windows.Forms.DataGridView()
        Me.CheckMensual = New System.Windows.Forms.CheckBox()
        Me.CheckDiaria = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxbBuscarMedico = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbxMedico = New System.Windows.Forms.ComboBox()
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
        Me.BtnAgregarNuevoPoe = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.PanelDiaHora.SuspendLayout()
        CType(Me.DgvAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvPOE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxbCantidad
        '
        Me.TxbCantidad.Location = New System.Drawing.Point(205, 199)
        Me.TxbCantidad.Name = "TxbCantidad"
        Me.TxbCantidad.Size = New System.Drawing.Size(39, 22)
        Me.TxbCantidad.TabIndex = 13
        Me.TxbCantidad.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cantidad de fichas"
        '
        'CbxHE
        '
        Me.CbxHE.FormattingEnabled = True
        Me.CbxHE.Location = New System.Drawing.Point(61, 157)
        Me.CbxHE.Name = "CbxHE"
        Me.CbxHE.Size = New System.Drawing.Size(50, 24)
        Me.CbxHE.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Dias y horario"
        '
        'CbxME
        '
        Me.CbxME.FormattingEnabled = True
        Me.CbxME.Location = New System.Drawing.Point(141, 157)
        Me.CbxME.Name = "CbxME"
        Me.CbxME.Size = New System.Drawing.Size(50, 24)
        Me.CbxME.TabIndex = 10
        '
        'CbxMS
        '
        Me.CbxMS.FormattingEnabled = True
        Me.CbxMS.Location = New System.Drawing.Point(358, 157)
        Me.CbxMS.Name = "CbxMS"
        Me.CbxMS.Size = New System.Drawing.Size(50, 24)
        Me.CbxMS.TabIndex = 12
        '
        'CbxHS
        '
        Me.CbxHS.FormattingEnabled = True
        Me.CbxHS.Location = New System.Drawing.Point(278, 157)
        Me.CbxHS.Name = "CbxHS"
        Me.CbxHS.Size = New System.Drawing.Size(50, 24)
        Me.CbxHS.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "INICIO TURNO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "FIN TURNO"
        '
        'CheckLunes
        '
        Me.CheckLunes.AutoSize = True
        Me.CheckLunes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckLunes.Location = New System.Drawing.Point(15, 51)
        Me.CheckLunes.Name = "CheckLunes"
        Me.CheckLunes.Size = New System.Drawing.Size(77, 24)
        Me.CheckLunes.TabIndex = 3
        Me.CheckLunes.Text = "Lunes"
        Me.CheckLunes.UseVisualStyleBackColor = True
        '
        'CheckMartes
        '
        Me.CheckMartes.AutoSize = True
        Me.CheckMartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckMartes.Location = New System.Drawing.Point(198, 51)
        Me.CheckMartes.Name = "CheckMartes"
        Me.CheckMartes.Size = New System.Drawing.Size(83, 24)
        Me.CheckMartes.TabIndex = 4
        Me.CheckMartes.Text = "Martes"
        Me.CheckMartes.UseVisualStyleBackColor = True
        '
        'CheckMiercoles
        '
        Me.CheckMiercoles.AutoSize = True
        Me.CheckMiercoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckMiercoles.Location = New System.Drawing.Point(358, 51)
        Me.CheckMiercoles.Name = "CheckMiercoles"
        Me.CheckMiercoles.Size = New System.Drawing.Size(104, 24)
        Me.CheckMiercoles.TabIndex = 5
        Me.CheckMiercoles.Text = "Miercoles"
        Me.CheckMiercoles.UseVisualStyleBackColor = True
        '
        'CheckJueves
        '
        Me.CheckJueves.AutoSize = True
        Me.CheckJueves.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckJueves.Location = New System.Drawing.Point(15, 90)
        Me.CheckJueves.Name = "CheckJueves"
        Me.CheckJueves.Size = New System.Drawing.Size(84, 24)
        Me.CheckJueves.TabIndex = 6
        Me.CheckJueves.Text = "Jueves"
        Me.CheckJueves.UseVisualStyleBackColor = True
        '
        'CheckViernes
        '
        Me.CheckViernes.AutoSize = True
        Me.CheckViernes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckViernes.Location = New System.Drawing.Point(198, 90)
        Me.CheckViernes.Name = "CheckViernes"
        Me.CheckViernes.Size = New System.Drawing.Size(88, 24)
        Me.CheckViernes.TabIndex = 7
        Me.CheckViernes.Text = "Viernes"
        Me.CheckViernes.UseVisualStyleBackColor = True
        '
        'ChecklunesAviernes
        '
        Me.ChecklunesAviernes.AutoSize = True
        Me.ChecklunesAviernes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChecklunesAviernes.Location = New System.Drawing.Point(358, 90)
        Me.ChecklunesAviernes.Name = "ChecklunesAviernes"
        Me.ChecklunesAviernes.Size = New System.Drawing.Size(150, 24)
        Me.ChecklunesAviernes.TabIndex = 8
        Me.ChecklunesAviernes.Text = "Lunes - Viernes"
        Me.ChecklunesAviernes.UseVisualStyleBackColor = True
        '
        'PanelDiaHora
        '
        Me.PanelDiaHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDiaHora.Controls.Add(Me.LSA)
        Me.PanelDiaHora.Controls.Add(Me.Label12)
        Me.PanelDiaHora.Controls.Add(Me.Label14)
        Me.PanelDiaHora.Controls.Add(Me.Label13)
        Me.PanelDiaHora.Controls.Add(Me.DgvAsignados)
        Me.PanelDiaHora.Controls.Add(Me.TxbCantidad)
        Me.PanelDiaHora.Controls.Add(Me.CheckMensual)
        Me.PanelDiaHora.Controls.Add(Me.CheckViernes)
        Me.PanelDiaHora.Controls.Add(Me.CheckJueves)
        Me.PanelDiaHora.Controls.Add(Me.CheckLunes)
        Me.PanelDiaHora.Controls.Add(Me.ChecklunesAviernes)
        Me.PanelDiaHora.Controls.Add(Me.CheckMiercoles)
        Me.PanelDiaHora.Controls.Add(Me.CheckMartes)
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
        Me.PanelDiaHora.Size = New System.Drawing.Size(518, 448)
        Me.PanelDiaHora.TabIndex = 27
        '
        'LSA
        '
        Me.LSA.AutoSize = True
        Me.LSA.BackColor = System.Drawing.Color.DarkGray
        Me.LSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSA.Location = New System.Drawing.Point(135, 347)
        Me.LSA.Name = "LSA"
        Me.LSA.Size = New System.Drawing.Size(242, 36)
        Me.LSA.TabIndex = 39
        Me.LSA.Text = "Sin asignaciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(180, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 20)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "ASIGNADAS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(334, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 25)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(117, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 25)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = ":"
        '
        'DgvAsignados
        '
        Me.DgvAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAsignados.Location = New System.Drawing.Point(7, 282)
        Me.DgvAsignados.Name = "DgvAsignados"
        Me.DgvAsignados.RowHeadersWidth = 51
        Me.DgvAsignados.RowTemplate.Height = 24
        Me.DgvAsignados.Size = New System.Drawing.Size(504, 159)
        Me.DgvAsignados.TabIndex = 37
        '
        'CheckMensual
        '
        Me.CheckMensual.AutoSize = True
        Me.CheckMensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckMensual.Location = New System.Drawing.Point(358, 199)
        Me.CheckMensual.Name = "CheckMensual"
        Me.CheckMensual.Size = New System.Drawing.Size(94, 24)
        Me.CheckMensual.TabIndex = 15
        Me.CheckMensual.Text = "Mensual"
        Me.CheckMensual.UseVisualStyleBackColor = True
        '
        'CheckDiaria
        '
        Me.CheckDiaria.AutoSize = True
        Me.CheckDiaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDiaria.Location = New System.Drawing.Point(267, 199)
        Me.CheckDiaria.Name = "CheckDiaria"
        Me.CheckDiaria.Size = New System.Drawing.Size(85, 24)
        Me.CheckDiaria.TabIndex = 14
        Me.CheckDiaria.Text = "Diarias"
        Me.CheckDiaria.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxbBuscarMedico)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.CbxMedico)
        Me.Panel2.Controls.Add(Me.PanelDiaHora)
        Me.Panel2.Location = New System.Drawing.Point(4, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 622)
        Me.Panel2.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(201, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 32)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "MÉDICO"
        '
        'TxbBuscarMedico
        '
        Me.TxbBuscarMedico.Location = New System.Drawing.Point(7, 78)
        Me.TxbBuscarMedico.Name = "TxbBuscarMedico"
        Me.TxbBuscarMedico.Size = New System.Drawing.Size(283, 22)
        Me.TxbBuscarMedico.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Buscar Medico"
        '
        'CbxMedico
        '
        Me.CbxMedico.FormattingEnabled = True
        Me.CbxMedico.Location = New System.Drawing.Point(7, 106)
        Me.CbxMedico.Name = "CbxMedico"
        Me.CbxMedico.Size = New System.Drawing.Size(479, 24)
        Me.CbxMedico.TabIndex = 2
        '
        'DgvPOE
        '
        Me.DgvPOE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPOE.Location = New System.Drawing.Point(3, 178)
        Me.DgvPOE.Name = "DgvPOE"
        Me.DgvPOE.RowHeadersWidth = 51
        Me.DgvPOE.RowTemplate.Height = 24
        Me.DgvPOE.Size = New System.Drawing.Size(453, 442)
        Me.DgvPOE.TabIndex = 29
        '
        'CbxProcedimientos
        '
        Me.CbxProcedimientos.FormattingEnabled = True
        Me.CbxProcedimientos.Location = New System.Drawing.Point(15, 106)
        Me.CbxProcedimientos.Name = "CbxProcedimientos"
        Me.CbxProcedimientos.Size = New System.Drawing.Size(192, 24)
        Me.CbxProcedimientos.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(417, 29)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "PROCEDIMIENTOS O ECOGRAFIAS"
        '
        'BtnAgegarProced
        '
        Me.BtnAgegarProced.Location = New System.Drawing.Point(84, 143)
        Me.BtnAgegarProced.Name = "BtnAgegarProced"
        Me.BtnAgegarProced.Size = New System.Drawing.Size(123, 29)
        Me.BtnAgegarProced.TabIndex = 16
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
        Me.Panel3.Location = New System.Drawing.Point(551, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(461, 622)
        Me.Panel3.TabIndex = 33
        '
        'BtnAgregarEco
        '
        Me.BtnAgregarEco.Location = New System.Drawing.Point(307, 142)
        Me.BtnAgregarEco.Name = "BtnAgregarEco"
        Me.BtnAgregarEco.Size = New System.Drawing.Size(123, 29)
        Me.BtnAgregarEco.TabIndex = 17
        Me.BtnAgregarEco.Text = "Agregar"
        Me.BtnAgregarEco.UseVisualStyleBackColor = True
        '
        'CbxEcografias
        '
        Me.CbxEcografias.FormattingEnabled = True
        Me.CbxEcografias.Location = New System.Drawing.Point(244, 106)
        Me.CbxEcografias.Name = "CbxEcografias"
        Me.CbxEcografias.Size = New System.Drawing.Size(186, 24)
        Me.CbxEcografias.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(241, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Buscar Ecografía"
        '
        'TxbBuscarEco
        '
        Me.TxbBuscarEco.Location = New System.Drawing.Point(244, 78)
        Me.TxbBuscarEco.Name = "TxbBuscarEco"
        Me.TxbBuscarEco.Size = New System.Drawing.Size(186, 22)
        Me.TxbBuscarEco.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Buscar Procedimiento"
        '
        'TxbBuscarproc
        '
        Me.TxbBuscarproc.Location = New System.Drawing.Point(15, 78)
        Me.TxbBuscarproc.Name = "TxbBuscarproc"
        Me.TxbBuscarproc.Size = New System.Drawing.Size(192, 22)
        Me.TxbBuscarproc.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(302, 29)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "ASIGNAR P.O.E - MEDICO"
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
        Me.BtnCerrar.Location = New System.Drawing.Point(978, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(34, 31)
        Me.BtnCerrar.TabIndex = 34
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(872, 716)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(140, 40)
        Me.BtnRegistrar.TabIndex = 18
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'PictureBarra
        '
        Me.PictureBarra.BackColor = System.Drawing.Color.Gray
        Me.PictureBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBarra.Location = New System.Drawing.Point(0, 0)
        Me.PictureBarra.Name = "PictureBarra"
        Me.PictureBarra.Size = New System.Drawing.Size(1024, 50)
        Me.PictureBarra.TabIndex = 39
        Me.PictureBarra.TabStop = False
        '
        'BtnAgregarNuevoPoe
        '
        Me.BtnAgregarNuevoPoe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarNuevoPoe.Location = New System.Drawing.Point(506, 718)
        Me.BtnAgregarNuevoPoe.Name = "BtnAgregarNuevoPoe"
        Me.BtnAgregarNuevoPoe.Size = New System.Drawing.Size(214, 38)
        Me.BtnAgregarNuevoPoe.TabIndex = 20
        Me.BtnAgregarNuevoPoe.Text = "Agregar nuevo POE"
        Me.BtnAgregarNuevoPoe.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(726, 718)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 38)
        Me.BtnCancelar.TabIndex = 19
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FormRegMedDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAgregarNuevoPoe)
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
        CType(Me.DgvAsignados, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TxbBuscarMedico As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CbxMedico As ComboBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DgvAsignados As DataGridView
    Friend WithEvents LSA As Label
End Class
