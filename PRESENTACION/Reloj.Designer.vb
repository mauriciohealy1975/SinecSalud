<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reloj
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
        Me.components = New System.ComponentModel.Container()
        Me.LH = New System.Windows.Forms.Label()
        Me.LM = New System.Windows.Forms.Label()
        Me.LDN = New System.Windows.Forms.Label()
        Me.LS = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LH
        '
        Me.LH.AutoSize = True
        Me.LH.Font = New System.Drawing.Font("Century Gothic", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LH.Location = New System.Drawing.Point(12, 9)
        Me.LH.Name = "LH"
        Me.LH.Size = New System.Drawing.Size(90, 57)
        Me.LH.TabIndex = 0
        Me.LH.Text = "00:"
        '
        'LM
        '
        Me.LM.AutoSize = True
        Me.LM.Font = New System.Drawing.Font("Calibri", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LM.Location = New System.Drawing.Point(108, 11)
        Me.LM.Name = "LM"
        Me.LM.Size = New System.Drawing.Size(73, 58)
        Me.LM.TabIndex = 0
        Me.LM.Text = "00"
        '
        'LDN
        '
        Me.LDN.AutoSize = True
        Me.LDN.BackColor = System.Drawing.Color.Transparent
        Me.LDN.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDN.Location = New System.Drawing.Point(176, 9)
        Me.LDN.Name = "LDN"
        Me.LDN.Size = New System.Drawing.Size(54, 35)
        Me.LDN.TabIndex = 0
        Me.LDN.Text = "PM"
        '
        'LS
        '
        Me.LS.AutoSize = True
        Me.LS.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LS.Location = New System.Drawing.Point(176, 44)
        Me.LS.Name = "LS"
        Me.LS.Size = New System.Drawing.Size(43, 35)
        Me.LS.TabIndex = 0
        Me.LS.Text = "00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Reloj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(258, 161)
        Me.Controls.Add(Me.LS)
        Me.Controls.Add(Me.LDN)
        Me.Controls.Add(Me.LM)
        Me.Controls.Add(Me.LH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reloj"
        Me.Text = "Reloj"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LH As Label
    Friend WithEvents LM As Label
    Friend WithEvents LDN As Label
    Friend WithEvents LS As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
