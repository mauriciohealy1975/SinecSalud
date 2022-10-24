<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarEmpresa
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.panelInformacionContacto = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.panelInformacionBasica = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hintSector = New System.Windows.Forms.Label()
        Me.cboxSector = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelInformacionInstitucional = New System.Windows.Forms.Panel()
        Me.txtRoe = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLicenciaFuncionaiento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCodigoPatronal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMatriculaComercio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelInformacionContacto.SuspendLayout()
        Me.panelInformacionBasica.SuspendLayout()
        Me.panelInformacionInstitucional.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(944, 499)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.btnCancelar.TabIndex = 66
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(493, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR EMPRESA"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(1025, 499)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(195, 27)
        Me.btnRegistrar.TabIndex = 67
        Me.btnRegistrar.Text = "Registrar empresa"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(43, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1177, 25)
        Me.TableLayoutPanel1.TabIndex = 65
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(51, 134)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(140, 16)
        Me.Label36.TabIndex = 45
        Me.Label36.Text = "Localidad (de trabajo)"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(216, 135)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(91, 15)
        Me.Label35.TabIndex = 46
        Me.Label35.Text = "SELECCIONAR"
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(214, 131)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(162, 23)
        Me.ComboBox7.TabIndex = 47
        '
        'panelInformacionContacto
        '
        Me.panelInformacionContacto.BackColor = System.Drawing.Color.White
        Me.panelInformacionContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelInformacionContacto.Controls.Add(Me.Label3)
        Me.panelInformacionContacto.Controls.Add(Me.TextBox13)
        Me.panelInformacionContacto.Controls.Add(Me.Label30)
        Me.panelInformacionContacto.Controls.Add(Me.TextBox11)
        Me.panelInformacionContacto.Controls.Add(Me.Label38)
        Me.panelInformacionContacto.Controls.Add(Me.Label27)
        Me.panelInformacionContacto.Controls.Add(Me.TextBox17)
        Me.panelInformacionContacto.Controls.Add(Me.Label37)
        Me.panelInformacionContacto.Controls.Add(Me.TextBox16)
        Me.panelInformacionContacto.Controls.Add(Me.Label36)
        Me.panelInformacionContacto.Controls.Add(Me.Label35)
        Me.panelInformacionContacto.Controls.Add(Me.ComboBox7)
        Me.panelInformacionContacto.Location = New System.Drawing.Point(43, 229)
        Me.panelInformacionContacto.Name = "panelInformacionContacto"
        Me.panelInformacionContacto.Size = New System.Drawing.Size(840, 173)
        Me.panelInformacionContacto.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 17)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "3.- Información de contacto "
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(543, 53)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(166, 21)
        Me.TextBox13.TabIndex = 51
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(422, 56)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(110, 16)
        Me.Label30.TabIndex = 50
        Me.Label30.Text = "Dirección laboral"
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(214, 56)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(162, 21)
        Me.TextBox11.TabIndex = 49
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(33, 94)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(166, 16)
        Me.Label38.TabIndex = 41
        Me.Label38.Text = "Departamento (de trabajo)"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(92, 53)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(107, 16)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Teléfono laboral"
        '
        'TextBox17
        '
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(214, 94)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(162, 21)
        Me.TextBox17.TabIndex = 42
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(396, 97)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(136, 16)
        Me.Label37.TabIndex = 43
        Me.Label37.Text = "Provincia (de trabajo)"
        '
        'TextBox16
        '
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(543, 94)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(166, 21)
        Me.TextBox16.TabIndex = 44
        '
        'panelInformacionBasica
        '
        Me.panelInformacionBasica.BackColor = System.Drawing.Color.White
        Me.panelInformacionBasica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelInformacionBasica.Controls.Add(Me.Label5)
        Me.panelInformacionBasica.Controls.Add(Me.hintSector)
        Me.panelInformacionBasica.Controls.Add(Me.cboxSector)
        Me.panelInformacionBasica.Controls.Add(Me.txtNombre)
        Me.panelInformacionBasica.Controls.Add(Me.Label4)
        Me.panelInformacionBasica.Controls.Add(Me.Label2)
        Me.panelInformacionBasica.Location = New System.Drawing.Point(43, 68)
        Me.panelInformacionBasica.Name = "panelInformacionBasica"
        Me.panelInformacionBasica.Size = New System.Drawing.Size(319, 131)
        Me.panelInformacionBasica.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Sector"
        '
        'hintSector
        '
        Me.hintSector.AutoSize = True
        Me.hintSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintSector.Location = New System.Drawing.Point(113, 79)
        Me.hintSector.Name = "hintSector"
        Me.hintSector.Size = New System.Drawing.Size(91, 15)
        Me.hintSector.TabIndex = 63
        Me.hintSector.Text = "SELECCIONAR"
        '
        'cboxSector
        '
        Me.cboxSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxSector.FormattingEnabled = True
        Me.cboxSector.Location = New System.Drawing.Point(111, 75)
        Me.cboxSector.Name = "cboxSector"
        Me.cboxSector.Size = New System.Drawing.Size(162, 23)
        Me.cboxSector.TabIndex = 64
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(111, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(162, 21)
        Me.txtNombre.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 17)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "1. Información básica"
        '
        'panelInformacionInstitucional
        '
        Me.panelInformacionInstitucional.BackColor = System.Drawing.Color.White
        Me.panelInformacionInstitucional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelInformacionInstitucional.Controls.Add(Me.txtRoe)
        Me.panelInformacionInstitucional.Controls.Add(Me.Label12)
        Me.panelInformacionInstitucional.Controls.Add(Me.txtLicenciaFuncionaiento)
        Me.panelInformacionInstitucional.Controls.Add(Me.Label11)
        Me.panelInformacionInstitucional.Controls.Add(Me.txtCodigoPatronal)
        Me.panelInformacionInstitucional.Controls.Add(Me.Label8)
        Me.panelInformacionInstitucional.Controls.Add(Me.txtMatriculaComercio)
        Me.panelInformacionInstitucional.Controls.Add(Me.Label7)
        Me.panelInformacionInstitucional.Controls.Add(Me.txtNit)
        Me.panelInformacionInstitucional.Controls.Add(Me.Label9)
        Me.panelInformacionInstitucional.Controls.Add(Me.Label10)
        Me.panelInformacionInstitucional.Location = New System.Drawing.Point(385, 68)
        Me.panelInformacionInstitucional.Name = "panelInformacionInstitucional"
        Me.panelInformacionInstitucional.Size = New System.Drawing.Size(835, 131)
        Me.panelInformacionInstitucional.TabIndex = 69
        '
        'txtRoe
        '
        Me.txtRoe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoe.Location = New System.Drawing.Point(432, 88)
        Me.txtRoe.Name = "txtRoe"
        Me.txtRoe.Size = New System.Drawing.Size(118, 21)
        Me.txtRoe.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(389, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "ROE"
        '
        'txtLicenciaFuncionaiento
        '
        Me.txtLicenciaFuncionaiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenciaFuncionaiento.Location = New System.Drawing.Point(222, 88)
        Me.txtLicenciaFuncionaiento.Name = "txtLicenciaFuncionaiento"
        Me.txtLicenciaFuncionaiento.Size = New System.Drawing.Size(118, 21)
        Me.txtLicenciaFuncionaiento.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 16)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Licencia de funcionamiento"
        '
        'txtCodigoPatronal
        '
        Me.txtCodigoPatronal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoPatronal.Location = New System.Drawing.Point(654, 42)
        Me.txtCodigoPatronal.Name = "txtCodigoPatronal"
        Me.txtCodigoPatronal.Size = New System.Drawing.Size(142, 21)
        Me.txtCodigoPatronal.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(544, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Codigo patronal"
        '
        'txtMatriculaComercio
        '
        Me.txtMatriculaComercio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriculaComercio.Location = New System.Drawing.Point(392, 42)
        Me.txtMatriculaComercio.Name = "txtMatriculaComercio"
        Me.txtMatriculaComercio.Size = New System.Drawing.Size(109, 21)
        Me.txtMatriculaComercio.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(265, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Matricula comercio"
        '
        'txtNit
        '
        Me.txtNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNit.Location = New System.Drawing.Point(83, 44)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(118, 21)
        Me.txtNit.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "NIT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(24, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(203, 17)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "2. Información institucional"
        '
        'FormRegistrarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.panelInformacionInstitucional)
        Me.Controls.Add(Me.panelInformacionBasica)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.panelInformacionContacto)
        Me.Name = "FormRegistrarEmpresa"
        Me.Text = "FormRegistrarEmpresa"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelInformacionContacto.ResumeLayout(False)
        Me.panelInformacionContacto.PerformLayout()
        Me.panelInformacionBasica.ResumeLayout(False)
        Me.panelInformacionBasica.PerformLayout()
        Me.panelInformacionInstitucional.ResumeLayout(False)
        Me.panelInformacionInstitucional.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents panelInformacionContacto As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents panelInformacionBasica As System.Windows.Forms.Panel
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents hintSector As System.Windows.Forms.Label
    Friend WithEvents cboxSector As System.Windows.Forms.ComboBox
    Friend WithEvents panelInformacionInstitucional As System.Windows.Forms.Panel
    Friend WithEvents txtRoe As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLicenciaFuncionaiento As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPatronal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMatriculaComercio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
