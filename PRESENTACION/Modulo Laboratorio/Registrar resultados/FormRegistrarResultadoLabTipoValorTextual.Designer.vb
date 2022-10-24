<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarResultadoLabTipoValorTextual
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.panelResultado = New System.Windows.Forms.Panel()
        Me.hintProcesador = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboxProcesador = New System.Windows.Forms.ComboBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtExamen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardarResultado = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelResultado.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTituloPrincipal, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(592, 25)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(77, 2)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(438, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR RESULTADOS DE TIPO VALOR TEXTUAL"
        '
        'panelResultado
        '
        Me.panelResultado.BackColor = System.Drawing.Color.White
        Me.panelResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelResultado.Controls.Add(Me.hintProcesador)
        Me.panelResultado.Controls.Add(Me.Label7)
        Me.panelResultado.Controls.Add(Me.cboxProcesador)
        Me.panelResultado.Controls.Add(Me.txtResultado)
        Me.panelResultado.Controls.Add(Me.txtObservaciones)
        Me.panelResultado.Controls.Add(Me.Label1)
        Me.panelResultado.Controls.Add(Me.txtArea)
        Me.panelResultado.Controls.Add(Me.lblArea)
        Me.panelResultado.Controls.Add(Me.Label15)
        Me.panelResultado.Controls.Add(Me.Label16)
        Me.panelResultado.Controls.Add(Me.Label3)
        Me.panelResultado.Controls.Add(Me.txtExamen)
        Me.panelResultado.Controls.Add(Me.Label2)
        Me.panelResultado.Location = New System.Drawing.Point(30, 66)
        Me.panelResultado.Name = "panelResultado"
        Me.panelResultado.Size = New System.Drawing.Size(422, 319)
        Me.panelResultado.TabIndex = 51
        '
        'hintProcesador
        '
        Me.hintProcesador.AutoSize = True
        Me.hintProcesador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintProcesador.Location = New System.Drawing.Point(124, 120)
        Me.hintProcesador.Name = "hintProcesador"
        Me.hintProcesador.Size = New System.Drawing.Size(82, 13)
        Me.hintProcesador.TabIndex = 81
        Me.hintProcesador.Text = "SELECCIONAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Procesador"
        '
        'cboxProcesador
        '
        Me.cboxProcesador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxProcesador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboxProcesador.FormattingEnabled = True
        Me.cboxProcesador.Location = New System.Drawing.Point(120, 115)
        Me.cboxProcesador.Name = "cboxProcesador"
        Me.cboxProcesador.Size = New System.Drawing.Size(284, 23)
        Me.cboxProcesador.TabIndex = 80
        '
        'txtResultado
        '
        Me.txtResultado.AcceptsTab = True
        Me.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtResultado.Location = New System.Drawing.Point(117, 150)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(286, 61)
        Me.txtResultado.TabIndex = 78
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsTab = True
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtObservaciones.Location = New System.Drawing.Point(117, 230)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(286, 66)
        Me.txtObservaciones.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Observaciones"
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(119, 80)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(285, 21)
        Me.txtArea.TabIndex = 72
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(78, 80)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(36, 16)
        Me.lblArea.TabIndex = 71
        Me.lblArea.Text = "Area"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(15, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 18)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "1.- Registrar resultado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(269, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 16)
        Me.Label16.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Resultado"
        '
        'txtExamen
        '
        Me.txtExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExamen.Location = New System.Drawing.Point(119, 45)
        Me.txtExamen.Name = "txtExamen"
        Me.txtExamen.Size = New System.Drawing.Size(284, 21)
        Me.txtExamen.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Examen"
        '
        'btnGuardarResultado
        '
        Me.btnGuardarResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarResultado.Location = New System.Drawing.Point(497, 357)
        Me.btnGuardarResultado.Name = "btnGuardarResultado"
        Me.btnGuardarResultado.Size = New System.Drawing.Size(125, 28)
        Me.btnGuardarResultado.TabIndex = 52
        Me.btnGuardarResultado.Text = "Guardar resultado"
        Me.btnGuardarResultado.UseVisualStyleBackColor = True
        '
        'FormRegistrarResultadoLabTipoValorTextual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(652, 408)
        Me.Controls.Add(Me.btnGuardarResultado)
        Me.Controls.Add(Me.panelResultado)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarResultadoLabTipoValorTextual"
        Me.Text = "FormGuardarResultadoVTextual"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelResultado.ResumeLayout(False)
        Me.panelResultado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents panelResultado As Panel
    Friend WithEvents txtArea As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtExamen As TextBox
    Friend WithEvents btnGuardarResultado As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents hintProcesador As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboxProcesador As ComboBox
End Class
