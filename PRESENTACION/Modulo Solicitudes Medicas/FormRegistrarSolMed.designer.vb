<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarSolMed
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblAsegurado = New System.Windows.Forms.Label()
        Me.Ltitulo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboxMedico = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbTipoConsulta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbHora = New System.Windows.Forms.ComboBox()
        Me.lblTituloFecha = New System.Windows.Forms.Label()
        Me.DateTimeFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkexterno = New System.Windows.Forms.CheckBox()
        Me.LCantfich = New System.Windows.Forms.Label()
        Me.CheckInterno = New System.Windows.Forms.CheckBox()
        Me.CbxPacientes = New System.Windows.Forms.ComboBox()
        Me.TxbBuscarPaciente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CheckProgramacion = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 198)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Paciente:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 231)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Edad:"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(103, 167)
        Me.lblMatricula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(14, 16)
        Me.lblMatricula.TabIndex = 4
        Me.lblMatricula.Text = "_"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Matricula:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(107, 231)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(14, 16)
        Me.lblEdad.TabIndex = 9
        Me.lblEdad.Text = "_"
        '
        'lblAsegurado
        '
        Me.lblAsegurado.AutoSize = True
        Me.lblAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsegurado.Location = New System.Drawing.Point(103, 198)
        Me.lblAsegurado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsegurado.Name = "lblAsegurado"
        Me.lblAsegurado.Size = New System.Drawing.Size(18, 20)
        Me.lblAsegurado.TabIndex = 2
        Me.lblAsegurado.Text = "_"
        '
        'Ltitulo
        '
        Me.Ltitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ltitulo.AutoSize = True
        Me.Ltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Ltitulo.Location = New System.Drawing.Point(385, 6)
        Me.Ltitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ltitulo.Name = "Ltitulo"
        Me.Ltitulo.Size = New System.Drawing.Size(468, 31)
        Me.Ltitulo.TabIndex = 0
        Me.Ltitulo.Text = "SOLICITUD DE ATENCIÓN MÉDICA"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Ltitulo, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(21, 13)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1238, 43)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(450, 77)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "MEDICO (EN TURNO):"
        '
        'cboxMedico
        '
        Me.cboxMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMedico.FormattingEnabled = True
        Me.cboxMedico.Location = New System.Drawing.Point(454, 101)
        Me.cboxMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.cboxMedico.Name = "cboxMedico"
        Me.cboxMedico.Size = New System.Drawing.Size(369, 26)
        Me.cboxMedico.TabIndex = 11
        Me.cboxMedico.Text = "SELECCIONAR"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(450, 139)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "TIPO DE CONSULTA:"
        '
        'cmbTipoConsulta
        '
        Me.cmbTipoConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoConsulta.FormattingEnabled = True
        Me.cmbTipoConsulta.Location = New System.Drawing.Point(454, 163)
        Me.cmbTipoConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
        Me.cmbTipoConsulta.Size = New System.Drawing.Size(304, 26)
        Me.cmbTipoConsulta.TabIndex = 11
        Me.cmbTipoConsulta.Text = "SELECCIONAR"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 77)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ESPECIALIDAD:"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.AccessibleDescription = ""
        Me.cmbEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(46, 101)
        Me.cmbEspecialidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(369, 26)
        Me.cmbEspecialidad.Sorted = True
        Me.cmbEspecialidad.TabIndex = 7
        Me.cmbEspecialidad.Tag = ""
        Me.cmbEspecialidad.Text = "SELECCIONAR"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 139)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "HORARIO:"
        '
        'cmbHora
        '
        Me.cmbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHora.FormattingEnabled = True
        Me.cmbHora.Location = New System.Drawing.Point(46, 163)
        Me.cmbHora.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbHora.Name = "cmbHora"
        Me.cmbHora.Size = New System.Drawing.Size(175, 26)
        Me.cmbHora.TabIndex = 10
        Me.cmbHora.Text = "SELECCIONAR"
        '
        'lblTituloFecha
        '
        Me.lblTituloFecha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTituloFecha.AutoSize = True
        Me.lblTituloFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloFecha.Location = New System.Drawing.Point(390, 112)
        Me.lblTituloFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloFecha.Name = "lblTituloFecha"
        Me.lblTituloFecha.Size = New System.Drawing.Size(68, 20)
        Me.lblTituloFecha.TabIndex = 8
        Me.lblTituloFecha.Text = "FECHA:"
        '
        'DateTimeFecha
        '
        Me.DateTimeFecha.Enabled = False
        Me.DateTimeFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFecha.Location = New System.Drawing.Point(466, 111)
        Me.DateTimeFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimeFecha.Name = "DateTimeFecha"
        Me.DateTimeFecha.Size = New System.Drawing.Size(118, 27)
        Me.DateTimeFecha.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Datos de la consulta"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(1115, 502)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(135, 38)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseMnemonic = False
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(963, 502)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(148, 38)
        Me.BtnCancelar.TabIndex = 13
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(855, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'checkexterno
        '
        Me.checkexterno.AutoSize = True
        Me.checkexterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkexterno.ForeColor = System.Drawing.SystemColors.Highlight
        Me.checkexterno.Location = New System.Drawing.Point(451, 50)
        Me.checkexterno.Name = "checkexterno"
        Me.checkexterno.Size = New System.Drawing.Size(257, 24)
        Me.checkexterno.TabIndex = 15
        Me.checkexterno.Text = "CONSULTORIO EXTERNO"
        Me.checkexterno.UseVisualStyleBackColor = True
        '
        'LCantfich
        '
        Me.LCantfich.AutoSize = True
        Me.LCantfich.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCantfich.Location = New System.Drawing.Point(661, 77)
        Me.LCantfich.Name = "LCantfich"
        Me.LCantfich.Size = New System.Drawing.Size(162, 20)
        Me.LCantfich.TabIndex = 16
        Me.LCantfich.Text = "Ficha Disponibles: 0"
        '
        'CheckInterno
        '
        Me.CheckInterno.AutoSize = True
        Me.CheckInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckInterno.ForeColor = System.Drawing.Color.Green
        Me.CheckInterno.Location = New System.Drawing.Point(451, 21)
        Me.CheckInterno.Name = "CheckInterno"
        Me.CheckInterno.Size = New System.Drawing.Size(225, 24)
        Me.CheckInterno.TabIndex = 17
        Me.CheckInterno.Text = "CONSULTORIO SINEC"
        Me.CheckInterno.UseVisualStyleBackColor = True
        '
        'CbxPacientes
        '
        Me.CbxPacientes.FormattingEnabled = True
        Me.CbxPacientes.Location = New System.Drawing.Point(20, 111)
        Me.CbxPacientes.Name = "CbxPacientes"
        Me.CbxPacientes.Size = New System.Drawing.Size(329, 24)
        Me.CbxPacientes.TabIndex = 18
        '
        'TxbBuscarPaciente
        '
        Me.TxbBuscarPaciente.Location = New System.Drawing.Point(22, 83)
        Me.TxbBuscarPaciente.Name = "TxbBuscarPaciente"
        Me.TxbBuscarPaciente.Size = New System.Drawing.Size(204, 22)
        Me.TxbBuscarPaciente.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Buscar Paciente"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(232, 79)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(117, 30)
        Me.BtnBuscar.TabIndex = 21
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CheckProgramacion
        '
        Me.CheckProgramacion.AutoSize = True
        Me.CheckProgramacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckProgramacion.Location = New System.Drawing.Point(393, 88)
        Me.CheckProgramacion.Name = "CheckProgramacion"
        Me.CheckProgramacion.Size = New System.Drawing.Size(135, 24)
        Me.CheckProgramacion.TabIndex = 22
        Me.CheckProgramacion.Text = "Programacion"
        Me.CheckProgramacion.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbTipoConsulta)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.checkexterno)
        Me.Panel1.Controls.Add(Me.cboxMedico)
        Me.Panel1.Controls.Add(Me.LCantfich)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CheckInterno)
        Me.Panel1.Controls.Add(Me.cmbHora)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cmbEspecialidad)
        Me.Panel1.Location = New System.Drawing.Point(12, 279)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1238, 217)
        Me.Panel1.TabIndex = 23
        '
        'FormRegistrarSolMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 553)
        Me.Controls.Add(Me.CheckProgramacion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAsegurado)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.TxbBuscarPaciente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbxPacientes)
        Me.Controls.Add(Me.lblTituloFecha)
        Me.Controls.Add(Me.DateTimeFecha)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRegistrarSolMed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Solicitud Medica"
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAsegurado As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents Ltitulo As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblTituloFecha As System.Windows.Forms.Label
    Friend WithEvents DateTimeFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbHora As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoConsulta As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cboxMedico As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents checkexterno As CheckBox
    Friend WithEvents LCantfich As Label
    Friend WithEvents CheckInterno As CheckBox
    Friend WithEvents CbxPacientes As ComboBox
    Friend WithEvents TxbBuscarPaciente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents CheckProgramacion As CheckBox
    Friend WithEvents Panel1 As Panel
End Class
