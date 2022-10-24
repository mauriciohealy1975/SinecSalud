<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromMenuTriaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromMenuTriaje))
        Me.BtnRS = New System.Windows.Forms.Button()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.CTipo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LTipo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCS = New System.Windows.Forms.Button()
        Me.BtnES = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lAviso = New System.Windows.Forms.Label()
        Me.BtnCerrarSession = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMP = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRS
        '
        Me.BtnRS.Location = New System.Drawing.Point(193, 265)
        Me.BtnRS.Name = "BtnRS"
        Me.BtnRS.Size = New System.Drawing.Size(151, 62)
        Me.BtnRS.TabIndex = 0
        Me.BtnRS.Text = "Registrar Solicitud"
        Me.BtnRS.UseVisualStyleBackColor = True
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(68, 123)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(56, 16)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre"
        '
        'CTipo
        '
        Me.CTipo.AutoSize = True
        Me.CTipo.Location = New System.Drawing.Point(8, 148)
        Me.CTipo.Name = "CTipo"
        Me.CTipo.Size = New System.Drawing.Size(38, 16)
        Me.CTipo.TabIndex = 2
        Me.CTipo.Text = "Tipo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario:"
        '
        'LTipo
        '
        Me.LTipo.AutoSize = True
        Me.LTipo.Location = New System.Drawing.Point(68, 148)
        Me.LTipo.Name = "LTipo"
        Me.LTipo.Size = New System.Drawing.Size(38, 16)
        Me.LTipo.TabIndex = 2
        Me.LTipo.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(258, 176)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Solicitudes Medicas"
        '
        'BtnCS
        '
        Me.BtnCS.Location = New System.Drawing.Point(193, 335)
        Me.BtnCS.Name = "BtnCS"
        Me.BtnCS.Size = New System.Drawing.Size(151, 62)
        Me.BtnCS.TabIndex = 2
        Me.BtnCS.Text = "Confirmar Solicitud"
        Me.BtnCS.UseVisualStyleBackColor = True
        '
        'BtnES
        '
        Me.BtnES.Location = New System.Drawing.Point(350, 265)
        Me.BtnES.Name = "BtnES"
        Me.BtnES.Size = New System.Drawing.Size(151, 62)
        Me.BtnES.TabIndex = 3
        Me.BtnES.Text = "Eliminar Solicitud"
        Me.BtnES.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 505)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Aviso:"
        '
        'lAviso
        '
        Me.lAviso.AutoSize = True
        Me.lAviso.Location = New System.Drawing.Point(80, 505)
        Me.lAviso.Name = "lAviso"
        Me.lAviso.Size = New System.Drawing.Size(98, 16)
        Me.lAviso.TabIndex = 10
        Me.lAviso.Text = "Sin Solicitudes "
        '
        'BtnCerrarSession
        '
        Me.BtnCerrarSession.Location = New System.Drawing.Point(648, 504)
        Me.BtnCerrarSession.Name = "BtnCerrarSession"
        Me.BtnCerrarSession.Size = New System.Drawing.Size(122, 37)
        Me.BtnCerrarSession.TabIndex = 11
        Me.BtnCerrarSession.Text = "Cerrar Sessión"
        Me.BtnCerrarSession.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 108)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BtnMP
        '
        Me.BtnMP.Location = New System.Drawing.Point(648, 467)
        Me.BtnMP.Name = "BtnMP"
        Me.BtnMP.Size = New System.Drawing.Size(122, 31)
        Me.BtnMP.TabIndex = 13
        Me.BtnMP.Text = "Menú Principal"
        Me.BtnMP.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(350, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 58)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Reporte de solicitudes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FromMenuTriaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnMP)
        Me.Controls.Add(Me.BtnCerrarSession)
        Me.Controls.Add(Me.lAviso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LTipo)
        Me.Controls.Add(Me.CTipo)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.BtnES)
        Me.Controls.Add(Me.BtnCS)
        Me.Controls.Add(Me.BtnRS)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FromMenuTriaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitudes Medicas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRS As Button
    Friend WithEvents LNombre As Label
    Friend WithEvents CTipo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LTipo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCS As Button
    Friend WithEvents BtnES As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lAviso As Label
    Friend WithEvents BtnCerrarSession As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnMP As Button
    Friend WithEvents Button1 As Button
End Class
