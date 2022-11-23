<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarOrdenAtencionServiciosEnfermeria
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardarAtencion = New System.Windows.Forms.Button()
        Me.lboxServicios = New System.Windows.Forms.ListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgviewServiciosConfirmados = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmarServicios = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtAsegurado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMatriculaAsegurado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMedico = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgviewServiciosConfirmados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(69, 49)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1122, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(528, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDEN DE ATENCIÓN PARA SERVICIOS ENFERMERÍA"
        '
        'btnGuardarAtencion
        '
        Me.btnGuardarAtencion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarAtencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarAtencion.Location = New System.Drawing.Point(1051, 501)
        Me.btnGuardarAtencion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarAtencion.Name = "btnGuardarAtencion"
        Me.btnGuardarAtencion.Size = New System.Drawing.Size(140, 34)
        Me.btnGuardarAtencion.TabIndex = 9
        Me.btnGuardarAtencion.Text = "Guardar orden"
        Me.btnGuardarAtencion.UseVisualStyleBackColor = True
        '
        'lboxServicios
        '
        Me.lboxServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxServicios.FormattingEnabled = True
        Me.lboxServicios.ItemHeight = 18
        Me.lboxServicios.Location = New System.Drawing.Point(70, 322)
        Me.lboxServicios.Margin = New System.Windows.Forms.Padding(4)
        Me.lboxServicios.Name = "lboxServicios"
        Me.lboxServicios.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lboxServicios.Size = New System.Drawing.Size(497, 166)
        Me.lboxServicios.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(68, 295)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(159, 20)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Servicios disponibles:"
        '
        'dgviewServiciosConfirmados
        '
        Me.dgviewServiciosConfirmados.AllowUserToAddRows = False
        Me.dgviewServiciosConfirmados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgviewServiciosConfirmados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewServiciosConfirmados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgviewServiciosConfirmados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewServiciosConfirmados.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewServiciosConfirmados.Location = New System.Drawing.Point(607, 322)
        Me.dgviewServiciosConfirmados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgviewServiciosConfirmados.Name = "dgviewServiciosConfirmados"
        Me.dgviewServiciosConfirmados.RowHeadersWidth = 51
        Me.dgviewServiciosConfirmados.Size = New System.Drawing.Size(584, 171)
        Me.dgviewServiciosConfirmados.TabIndex = 8
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(286, 501)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 34)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmarServicios
        '
        Me.btnConfirmarServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarServicios.Location = New System.Drawing.Point(394, 501)
        Me.btnConfirmarServicios.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmarServicios.Name = "btnConfirmarServicios"
        Me.btnConfirmarServicios.Size = New System.Drawing.Size(173, 34)
        Me.btnConfirmarServicios.TabIndex = 7
        Me.btnConfirmarServicios.Text = "Confirmar Servicios"
        Me.btnConfirmarServicios.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 247)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Programación de Servicios "
        '
        'txtEdad
        '
        Me.txtEdad.Enabled = False
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(600, 215)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(139, 24)
        Me.txtEdad.TabIndex = 3
        '
        'txtAsegurado
        '
        Me.txtAsegurado.Enabled = False
        Me.txtAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsegurado.Location = New System.Drawing.Point(77, 215)
        Me.txtAsegurado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAsegurado.Name = "txtAsegurado"
        Me.txtAsegurado.Size = New System.Drawing.Size(219, 24)
        Me.txtAsegurado.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(596, 192)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Edad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 139)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Información Asegurado"
        '
        'txtMatriculaAsegurado
        '
        Me.txtMatriculaAsegurado.Enabled = False
        Me.txtMatriculaAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriculaAsegurado.Location = New System.Drawing.Point(343, 215)
        Me.txtMatriculaAsegurado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatriculaAsegurado.Name = "txtMatriculaAsegurado"
        Me.txtMatriculaAsegurado.Size = New System.Drawing.Size(219, 24)
        Me.txtMatriculaAsegurado.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(339, 192)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Matricula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(603, 295)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Detalle de orden de servicios:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(784, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Medico"
        '
        'txtMedico
        '
        Me.txtMedico.Enabled = False
        Me.txtMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedico.Location = New System.Drawing.Point(788, 215)
        Me.txtMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.Size = New System.Drawing.Size(403, 24)
        Me.txtMedico.TabIndex = 4
        '
        'FormRegistrarOrdenAtencionServiciosEnfermeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 553)
        Me.Controls.Add(Me.txtMedico)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtMatriculaAsegurado)
        Me.Controls.Add(Me.txtAsegurado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnConfirmarServicios)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dgviewServiciosConfirmados)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lboxServicios)
        Me.Controls.Add(Me.btnGuardarAtencion)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRegistrarOrdenAtencionServiciosEnfermeria"
        Me.Text = "REGISTRO DE ORDEN DE ATENCIÓN EN SERVICIOS DE ENERMERÍA"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgviewServiciosConfirmados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarAtencion As System.Windows.Forms.Button
    Friend WithEvents lboxServicios As System.Windows.Forms.ListBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dgviewServiciosConfirmados As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarServicios As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtAsegurado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMatriculaAsegurado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMedico As System.Windows.Forms.TextBox
End Class
