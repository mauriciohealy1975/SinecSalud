<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCambiarContrasenha
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContrasenhaActual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContrasenhaNueva = New System.Windows.Forms.TextBox()
        Me.btnCambiarContraseha = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(180, 32)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 21)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña actual:"
        '
        'txtContrasenhaActual
        '
        Me.txtContrasenhaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenhaActual.Location = New System.Drawing.Point(180, 69)
        Me.txtContrasenhaActual.Name = "txtContrasenhaActual"
        Me.txtContrasenhaActual.Size = New System.Drawing.Size(100, 21)
        Me.txtContrasenhaActual.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nueva contraseña:"
        '
        'txtContrasenhaNueva
        '
        Me.txtContrasenhaNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenhaNueva.Location = New System.Drawing.Point(180, 112)
        Me.txtContrasenhaNueva.Name = "txtContrasenhaNueva"
        Me.txtContrasenhaNueva.Size = New System.Drawing.Size(100, 21)
        Me.txtContrasenhaNueva.TabIndex = 1
        '
        'btnCambiarContraseha
        '
        Me.btnCambiarContraseha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarContraseha.Location = New System.Drawing.Point(123, 156)
        Me.btnCambiarContraseha.Name = "btnCambiarContraseha"
        Me.btnCambiarContraseha.Size = New System.Drawing.Size(157, 23)
        Me.btnCambiarContraseha.TabIndex = 2
        Me.btnCambiarContraseha.Text = "Cambiar Contraseña"
        Me.btnCambiarContraseha.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(96, 134)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.lblMensaje.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(33, 156)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FormCambiarContrasenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 216)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCambiarContraseha)
        Me.Controls.Add(Me.txtContrasenhaNueva)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContrasenhaActual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormCambiarContrasenha"
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContrasenhaActual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContrasenhaNueva As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiarContraseha As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
