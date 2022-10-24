<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarTomaMuestra
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelControles2 = New System.Windows.Forms.Panel()
        Me.lblMensajeListaOrdenes = New System.Windows.Forms.Label()
        Me.DgvDetallesOrden = New System.Windows.Forms.DataGridView()
        Me.btnCancelarRecepcion = New System.Windows.Forms.Button()
        Me.btnRegistrarRecepcion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.hintCmboxOrdenes = New System.Windows.Forms.Label()
        Me.btnBuscarOrdenXMatricula = New System.Windows.Forms.Button()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmboxOrdenes = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscarOrdenXNroOrden = New System.Windows.Forms.Button()
        Me.txtNroOrden = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panelControles2.SuspendLayout()
        CType(Me.DgvDetallesOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(36, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1188, 25)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRAR RECEPCIÓN DE TOMA DE MUESTRA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "1.- Filtrado de ordenes"
        '
        'panelControles2
        '
        Me.panelControles2.BackColor = System.Drawing.SystemColors.Window
        Me.panelControles2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelControles2.Controls.Add(Me.lblMensajeListaOrdenes)
        Me.panelControles2.Controls.Add(Me.DgvDetallesOrden)
        Me.panelControles2.Controls.Add(Me.btnCancelarRecepcion)
        Me.panelControles2.Controls.Add(Me.btnRegistrarRecepcion)
        Me.panelControles2.Controls.Add(Me.Label4)
        Me.panelControles2.Location = New System.Drawing.Point(36, 295)
        Me.panelControles2.Name = "panelControles2"
        Me.panelControles2.Size = New System.Drawing.Size(1188, 242)
        Me.panelControles2.TabIndex = 2
        '
        'lblMensajeListaOrdenes
        '
        Me.lblMensajeListaOrdenes.AutoSize = True
        Me.lblMensajeListaOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeListaOrdenes.Location = New System.Drawing.Point(26, 51)
        Me.lblMensajeListaOrdenes.Name = "lblMensajeListaOrdenes"
        Me.lblMensajeListaOrdenes.Size = New System.Drawing.Size(211, 16)
        Me.lblMensajeListaOrdenes.TabIndex = 0
        Me.lblMensajeListaOrdenes.Text = "Pruebas pendientes de recepción"
        '
        'DgvDetallesOrden
        '
        Me.DgvDetallesOrden.BackgroundColor = System.Drawing.Color.White
        Me.DgvDetallesOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetallesOrden.Location = New System.Drawing.Point(27, 75)
        Me.DgvDetallesOrden.Name = "DgvDetallesOrden"
        Me.DgvDetallesOrden.Size = New System.Drawing.Size(664, 136)
        Me.DgvDetallesOrden.TabIndex = 1
        '
        'btnCancelarRecepcion
        '
        Me.btnCancelarRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarRecepcion.Location = New System.Drawing.Point(781, 195)
        Me.btnCancelarRecepcion.Name = "btnCancelarRecepcion"
        Me.btnCancelarRecepcion.Size = New System.Drawing.Size(122, 30)
        Me.btnCancelarRecepcion.TabIndex = 3
        Me.btnCancelarRecepcion.Text = "Cancelar recepción"
        Me.btnCancelarRecepcion.UseVisualStyleBackColor = True
        '
        'btnRegistrarRecepcion
        '
        Me.btnRegistrarRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarRecepcion.Location = New System.Drawing.Point(909, 195)
        Me.btnRegistrarRecepcion.Name = "btnRegistrarRecepcion"
        Me.btnRegistrarRecepcion.Size = New System.Drawing.Size(248, 30)
        Me.btnRegistrarRecepcion.TabIndex = 4
        Me.btnRegistrarRecepcion.Text = "Registrar recepción"
        Me.btnRegistrarRecepcion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(22, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "2.- Marcado de toma de prueba"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.hintCmboxOrdenes)
        Me.Panel2.Controls.Add(Me.btnBuscarOrdenXMatricula)
        Me.Panel2.Controls.Add(Me.txtMatricula)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cmboxOrdenes)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnBuscarOrdenXNroOrden)
        Me.Panel2.Controls.Add(Me.txtNroOrden)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(36, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 195)
        Me.Panel2.TabIndex = 1
        '
        'hintCmboxOrdenes
        '
        Me.hintCmboxOrdenes.AutoSize = True
        Me.hintCmboxOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintCmboxOrdenes.Location = New System.Drawing.Point(31, 150)
        Me.hintCmboxOrdenes.Name = "hintCmboxOrdenes"
        Me.hintCmboxOrdenes.Size = New System.Drawing.Size(91, 15)
        Me.hintCmboxOrdenes.TabIndex = 0
        Me.hintCmboxOrdenes.Text = "SELECCIONAR"
        '
        'btnBuscarOrdenXMatricula
        '
        Me.btnBuscarOrdenXMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarOrdenXMatricula.Location = New System.Drawing.Point(559, 72)
        Me.btnBuscarOrdenXMatricula.Name = "btnBuscarOrdenXMatricula"
        Me.btnBuscarOrdenXMatricula.Size = New System.Drawing.Size(139, 27)
        Me.btnBuscarOrdenXMatricula.TabIndex = 4
        Me.btnBuscarOrdenXMatricula.Text = "Buscar por matrícula"
        Me.btnBuscarOrdenXMatricula.UseVisualStyleBackColor = True
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Location = New System.Drawing.Point(350, 76)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(203, 21)
        Me.txtMatricula.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(347, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Matrícula del asegurado"
        '
        'cmboxOrdenes
        '
        Me.cmboxOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxOrdenes.FormattingEnabled = True
        Me.cmboxOrdenes.Location = New System.Drawing.Point(26, 146)
        Me.cmboxOrdenes.Name = "cmboxOrdenes"
        Me.cmboxOrdenes.Size = New System.Drawing.Size(448, 23)
        Me.cmboxOrdenes.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(236, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ordenes abiertas de los últimos 7 días"
        '
        'btnBuscarOrdenXNroOrden
        '
        Me.btnBuscarOrdenXNroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarOrdenXNroOrden.Location = New System.Drawing.Point(160, 73)
        Me.btnBuscarOrdenXNroOrden.Name = "btnBuscarOrdenXNroOrden"
        Me.btnBuscarOrdenXNroOrden.Size = New System.Drawing.Size(142, 27)
        Me.btnBuscarOrdenXNroOrden.TabIndex = 2
        Me.btnBuscarOrdenXNroOrden.Text = "Buscar por nro. orden"
        Me.btnBuscarOrdenXNroOrden.UseVisualStyleBackColor = True
        '
        'txtNroOrden
        '
        Me.txtNroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrden.Location = New System.Drawing.Point(26, 75)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(128, 21)
        Me.txtNroOrden.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Número de orden"
        '
        'FormRegistrarTomaMuestra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelControles2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormRegistrarTomaMuestra"
        Me.Text = "FomrRegistrarTomaMuestra"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panelControles2.ResumeLayout(False)
        Me.panelControles2.PerformLayout()
        CType(Me.DgvDetallesOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelControles2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DgvDetallesOrden As System.Windows.Forms.DataGridView
    Friend WithEvents btnRegistrarRecepcion As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscarOrdenXNroOrden As System.Windows.Forms.Button
    Friend WithEvents txtNroOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmboxOrdenes As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents hintCmboxOrdenes As System.Windows.Forms.Label
    Friend WithEvents btnBuscarOrdenXMatricula As System.Windows.Forms.Button
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMensajeListaOrdenes As System.Windows.Forms.Label
    Friend WithEvents btnCancelarRecepcion As System.Windows.Forms.Button
End Class
