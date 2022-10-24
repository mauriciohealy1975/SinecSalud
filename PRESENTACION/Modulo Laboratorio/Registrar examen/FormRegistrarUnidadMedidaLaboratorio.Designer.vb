<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarUnidadMedidaLaboratorio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTituloPrincipal = New System.Windows.Forms.Label()
        Me.panelArea = New System.Windows.Forms.Panel()
        Me.btnRegistrarUnidad = New System.Windows.Forms.Button()
        Me.txtAbreviatura = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelArea.SuspendLayout()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(424, 23)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'lblTituloPrincipal
        '
        Me.lblTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTituloPrincipal.AutoSize = True
        Me.lblTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrincipal.Location = New System.Drawing.Point(72, 1)
        Me.lblTituloPrincipal.Name = "lblTituloPrincipal"
        Me.lblTituloPrincipal.Size = New System.Drawing.Size(280, 20)
        Me.lblTituloPrincipal.TabIndex = 0
        Me.lblTituloPrincipal.Text = "REGISTRAR UNIDAD DE MEDIDA "
        '
        'panelArea
        '
        Me.panelArea.BackColor = System.Drawing.Color.White
        Me.panelArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelArea.Controls.Add(Me.txtAbreviatura)
        Me.panelArea.Controls.Add(Me.Label11)
        Me.panelArea.Controls.Add(Me.txtNombre)
        Me.panelArea.Controls.Add(Me.Label12)
        Me.panelArea.Controls.Add(Me.Label4)
        Me.panelArea.Location = New System.Drawing.Point(30, 65)
        Me.panelArea.Name = "panelArea"
        Me.panelArea.Size = New System.Drawing.Size(424, 131)
        Me.panelArea.TabIndex = 29
        '
        'btnRegistrarUnidad
        '
        Me.btnRegistrarUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarUnidad.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarUnidad.Location = New System.Drawing.Point(335, 211)
        Me.btnRegistrarUnidad.Name = "btnRegistrarUnidad"
        Me.btnRegistrarUnidad.Size = New System.Drawing.Size(119, 28)
        Me.btnRegistrarUnidad.TabIndex = 42
        Me.btnRegistrarUnidad.Text = "Registrar unidad"
        Me.btnRegistrarUnidad.UseVisualStyleBackColor = False
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.Location = New System.Drawing.Point(163, 83)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(137, 21)
        Me.txtAbreviatura.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 16)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Abreviatura / Sigla"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(163, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 21)
        Me.txtNombre.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(56, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Nombre unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Datos de la unidad"
        '
        'FormRegistrarUnidadMedidaLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.btnRegistrarUnidad)
        Me.Controls.Add(Me.panelArea)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarUnidadMedidaLaboratorio"
        Me.Text = "Registrar unidad de medida"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelArea.ResumeLayout(False)
        Me.panelArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTituloPrincipal As Label
    Friend WithEvents panelArea As Panel
    Friend WithEvents txtAbreviatura As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegistrarUnidad As Button
End Class
