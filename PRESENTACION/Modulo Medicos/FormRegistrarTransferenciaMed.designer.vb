<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarTransferenciaMed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistrarTransferenciaMed))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.richBoxDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarPaciente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscarNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmboxEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMedico = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.cmboxNombrePaciente = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardarTransferencia = New System.Windows.Forms.Button()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(414, 239)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Diagnostico"
        '
        'richBoxDiagnostico
        '
        Me.richBoxDiagnostico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.richBoxDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richBoxDiagnostico.Location = New System.Drawing.Point(418, 263)
        Me.richBoxDiagnostico.Margin = New System.Windows.Forms.Padding(4)
        Me.richBoxDiagnostico.Name = "richBoxDiagnostico"
        Me.richBoxDiagnostico.Size = New System.Drawing.Size(339, 127)
        Me.richBoxDiagnostico.TabIndex = 24
        Me.richBoxDiagnostico.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 236)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Derivacion"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(411, 169)
        Me.lblMatricula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(77, 20)
        Me.lblMatricula.TabIndex = 2
        Me.lblMatricula.Text = "Matricula:"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(411, 149)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(51, 20)
        Me.lblEdad.TabIndex = 1
        Me.lblEdad.Text = "Edad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Datos del Paciente"
        '
        'btnBuscarPaciente
        '
        Me.btnBuscarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPaciente.Location = New System.Drawing.Point(270, 142)
        Me.btnBuscarPaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarPaciente.Name = "btnBuscarPaciente"
        Me.btnBuscarPaciente.Size = New System.Drawing.Size(100, 32)
        Me.btnBuscarPaciente.TabIndex = 3
        Me.btnBuscarPaciente.Text = "Buscar"
        Me.btnBuscarPaciente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar Paciente"
        '
        'txtBuscarNombrePaciente
        '
        Me.txtBuscarNombrePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarNombrePaciente.Location = New System.Drawing.Point(60, 149)
        Me.txtBuscarNombrePaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscarNombrePaciente.Name = "txtBuscarNombrePaciente"
        Me.txtBuscarNombrePaciente.Size = New System.Drawing.Size(202, 25)
        Me.txtBuscarNombrePaciente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TRANSFERENCIA MEDICA"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(65, 220)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(0, 12)
        Me.TableLayoutPanel10.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(4, 5)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1, 2)
        Me.Label12.TabIndex = 10
        '
        'cmboxEspecialidad
        '
        Me.cmboxEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxEspecialidad.FormattingEnabled = True
        Me.cmboxEspecialidad.Location = New System.Drawing.Point(60, 302)
        Me.cmboxEspecialidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxEspecialidad.Name = "cmboxEspecialidad"
        Me.cmboxEspecialidad.Size = New System.Drawing.Size(310, 28)
        Me.cmboxEspecialidad.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 274)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Especialidad:"
        '
        'lblMedico
        '
        Me.lblMedico.AutoSize = True
        Me.lblMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedico.Location = New System.Drawing.Point(4, 21)
        Me.lblMedico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(128, 17)
        Me.lblMedico.TabIndex = 0
        Me.lblMedico.Text = "nombre del medico"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMedico, 0, 1)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-843, 344)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(267, 43)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "MEDICO"
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(60, 183)
        Me.txtNombrePaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(310, 22)
        Me.txtNombrePaciente.TabIndex = 31
        '
        'cmboxNombrePaciente
        '
        Me.cmboxNombrePaciente.FormattingEnabled = True
        Me.cmboxNombrePaciente.Location = New System.Drawing.Point(60, 183)
        Me.cmboxNombrePaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxNombrePaciente.Name = "cmboxNombrePaciente"
        Me.cmboxNombrePaciente.Size = New System.Drawing.Size(310, 24)
        Me.cmboxNombrePaciente.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(56, 344)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Fecha de Derivación"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(56, 365)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(89, 20)
        Me.lblFecha.TabIndex = 34
        Me.lblFecha.Text = "2021/10/15"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(623, 460)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(134, 33)
        Me.BtnCancelar.TabIndex = 35
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardarTransferencia
        '
        Me.BtnGuardarTransferencia.Location = New System.Drawing.Point(413, 460)
        Me.BtnGuardarTransferencia.Name = "BtnGuardarTransferencia"
        Me.BtnGuardarTransferencia.Size = New System.Drawing.Size(204, 33)
        Me.BtnGuardarTransferencia.TabIndex = 36
        Me.BtnGuardarTransferencia.Text = "Guardar Trasferencia"
        Me.BtnGuardarTransferencia.UseVisualStyleBackColor = True
        '
        'FormRegistrarTransferenciaMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.richBoxDiagnostico)
        Me.Controls.Add(Me.BtnGuardarTransferencia)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmboxNombrePaciente)
        Me.Controls.Add(Me.txtNombrePaciente)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmboxEspecialidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBuscarPaciente)
        Me.Controls.Add(Me.txtBuscarNombrePaciente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TableLayoutPanel10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRegistrarTransferenciaMed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencias Medicas"
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents richBoxDiagnostico As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarPaciente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmboxEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMedico As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents cmboxNombrePaciente As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardarTransferencia As Button
End Class
