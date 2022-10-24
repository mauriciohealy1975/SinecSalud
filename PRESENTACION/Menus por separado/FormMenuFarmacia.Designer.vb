<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuFarmacia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuFarmacia))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LT = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnConsultarInventario = New System.Windows.Forms.Button()
        Me.BtnTraspasos = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnDespacho = New System.Windows.Forms.Button()
        Me.CerrarSesion = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnRecepciones = New System.Windows.Forms.Button()
        Me.LHay = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnActDesac = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Location = New System.Drawing.Point(66, 148)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(35, 16)
        Me.LT.TabIndex = 17
        Me.LT.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tipo:"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(66, 122)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(56, 16)
        Me.LN.TabIndex = 19
        Me.LN.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Usuario:"
        '
        'BtnConsultarInventario
        '
        Me.BtnConsultarInventario.Location = New System.Drawing.Point(153, 170)
        Me.BtnConsultarInventario.Name = "BtnConsultarInventario"
        Me.BtnConsultarInventario.Size = New System.Drawing.Size(492, 50)
        Me.BtnConsultarInventario.TabIndex = 1
        Me.BtnConsultarInventario.Text = "Ingreso de inventario"
        Me.BtnConsultarInventario.UseVisualStyleBackColor = True
        '
        'BtnTraspasos
        '
        Me.BtnTraspasos.Location = New System.Drawing.Point(153, 226)
        Me.BtnTraspasos.Name = "BtnTraspasos"
        Me.BtnTraspasos.Size = New System.Drawing.Size(492, 50)
        Me.BtnTraspasos.TabIndex = 2
        Me.BtnTraspasos.Text = "Traspasos"
        Me.BtnTraspasos.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(153, 449)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(492, 50)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Recuperacion de inventario"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'BtnDespacho
        '
        Me.BtnDespacho.Location = New System.Drawing.Point(153, 393)
        Me.BtnDespacho.Name = "BtnDespacho"
        Me.BtnDespacho.Size = New System.Drawing.Size(492, 50)
        Me.BtnDespacho.TabIndex = 25
        Me.BtnDespacho.Text = "Despacho de medicamentos"
        Me.BtnDespacho.UseVisualStyleBackColor = True
        '
        'CerrarSesion
        '
        Me.CerrarSesion.Location = New System.Drawing.Point(674, 510)
        Me.CerrarSesion.Name = "CerrarSesion"
        Me.CerrarSesion.Size = New System.Drawing.Size(107, 34)
        Me.CerrarSesion.TabIndex = 26
        Me.CerrarSesion.Text = "Cerrar Sesión"
        Me.CerrarSesion.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(532, 510)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(136, 34)
        Me.BtnVolver.TabIndex = 26
        Me.BtnVolver.Text = "Menú Principal"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnRecepciones
        '
        Me.BtnRecepciones.Location = New System.Drawing.Point(153, 338)
        Me.BtnRecepciones.Name = "BtnRecepciones"
        Me.BtnRecepciones.Size = New System.Drawing.Size(492, 50)
        Me.BtnRecepciones.TabIndex = 3
        Me.BtnRecepciones.Text = "Recepciones"
        Me.BtnRecepciones.UseVisualStyleBackColor = True
        '
        'LHay
        '
        Me.LHay.AutoSize = True
        Me.LHay.Location = New System.Drawing.Point(449, 355)
        Me.LHay.Name = "LHay"
        Me.LHay.Size = New System.Drawing.Size(187, 16)
        Me.LHay.TabIndex = 20
        Me.LHay.Text = "Hay 3 solicidtudes pendientes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 50)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Baja de medicamento"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BtnActDesac
        '
        Me.BtnActDesac.Location = New System.Drawing.Point(153, 282)
        Me.BtnActDesac.Name = "BtnActDesac"
        Me.BtnActDesac.Size = New System.Drawing.Size(492, 50)
        Me.BtnActDesac.TabIndex = 25
        Me.BtnActDesac.Text = "Activar/DescactivarMedicamentos"
        Me.BtnActDesac.UseVisualStyleBackColor = True
        '
        'FormMenuFarmacia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.LHay)
        Me.Controls.Add(Me.BtnRecepciones)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.CerrarSesion)
        Me.Controls.Add(Me.BtnActDesac)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnDespacho)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BtnTraspasos)
        Me.Controls.Add(Me.BtnConsultarInventario)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormMenuFarmacia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FARMACIA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LT As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LN As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnConsultarInventario As Button
    Friend WithEvents BtnTraspasos As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BtnDespacho As Button
    Friend WithEvents CerrarSesion As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnRecepciones As Button
    Friend WithEvents LHay As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnActDesac As Button
End Class
