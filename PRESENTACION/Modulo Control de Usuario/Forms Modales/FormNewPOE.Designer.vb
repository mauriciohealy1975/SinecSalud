<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewPOE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewPOE))
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBarra = New System.Windows.Forms.PictureBox()
        Me.Btnregistrar = New System.Windows.Forms.Button()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbNombrePOE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckProc = New System.Windows.Forms.CheckBox()
        Me.CheckEco = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Gray
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(354, 9)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(34, 31)
        Me.BtnCerrar.TabIndex = 40
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 29)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Registrar Nuevo POE"
        '
        'PictureBarra
        '
        Me.PictureBarra.BackColor = System.Drawing.Color.Gray
        Me.PictureBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBarra.Location = New System.Drawing.Point(0, 0)
        Me.PictureBarra.Name = "PictureBarra"
        Me.PictureBarra.Size = New System.Drawing.Size(400, 50)
        Me.PictureBarra.TabIndex = 43
        Me.PictureBarra.TabStop = False
        '
        'Btnregistrar
        '
        Me.Btnregistrar.Location = New System.Drawing.Point(282, 208)
        Me.Btnregistrar.Name = "Btnregistrar"
        Me.Btnregistrar.Size = New System.Drawing.Size(95, 44)
        Me.Btnregistrar.TabIndex = 44
        Me.Btnregistrar.Text = "Registrar"
        Me.Btnregistrar.UseVisualStyleBackColor = True
        '
        'txbUsuario
        '
        Me.txbUsuario.Enabled = False
        Me.txbUsuario.Location = New System.Drawing.Point(109, 66)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(52, 22)
        Me.txbUsuario.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Cod Usuario:"
        '
        'TxbNombrePOE
        '
        Me.TxbNombrePOE.Location = New System.Drawing.Point(109, 107)
        Me.TxbNombrePOE.Name = "TxbNombrePOE"
        Me.TxbNombrePOE.Size = New System.Drawing.Size(245, 22)
        Me.TxbNombrePOE.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nombre POE:"
        '
        'CheckProc
        '
        Me.CheckProc.AutoSize = True
        Me.CheckProc.Location = New System.Drawing.Point(206, 138)
        Me.CheckProc.Name = "CheckProc"
        Me.CheckProc.Size = New System.Drawing.Size(116, 20)
        Me.CheckProc.TabIndex = 49
        Me.CheckProc.Text = "Procedimiento"
        Me.CheckProc.UseVisualStyleBackColor = True
        '
        'CheckEco
        '
        Me.CheckEco.AutoSize = True
        Me.CheckEco.Location = New System.Drawing.Point(206, 164)
        Me.CheckEco.Name = "CheckEco"
        Me.CheckEco.Size = New System.Drawing.Size(87, 20)
        Me.CheckEco.TabIndex = 50
        Me.CheckEco.Text = "Ecografia"
        Me.CheckEco.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 16)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Procedimiento  o Ecografía :"
        '
        'FormNewPOE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 272)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckEco)
        Me.Controls.Add(Me.CheckProc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxbNombrePOE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.Btnregistrar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNewPOE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNewPOE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBarra As PictureBox
    Friend WithEvents Btnregistrar As Button
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbNombrePOE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckProc As CheckBox
    Friend WithEvents CheckEco As CheckBox
    Friend WithEvents Label3 As Label
End Class
