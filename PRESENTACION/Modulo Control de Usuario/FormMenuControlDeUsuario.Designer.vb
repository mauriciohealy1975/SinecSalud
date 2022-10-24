<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuControlDeUsuario
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReactivarUsuario = New System.Windows.Forms.Button()
        Me.btnRegistrarUsuario = New System.Windows.Forms.Button()
        Me.btnAsignarTurno = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnReactivarUsuario, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnRegistrarUsuario, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAsignarTurno, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(709, 101)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99788!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99789!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00141!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00141!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00141!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(203, 229)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'btnReactivarUsuario
        '
        Me.btnReactivarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReactivarUsuario.Location = New System.Drawing.Point(4, 49)
        Me.btnReactivarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReactivarUsuario.Name = "btnReactivarUsuario"
        Me.btnReactivarUsuario.Size = New System.Drawing.Size(192, 32)
        Me.btnReactivarUsuario.TabIndex = 1
        Me.btnReactivarUsuario.Text = "Reactivar usuario"
        Me.btnReactivarUsuario.UseVisualStyleBackColor = True
        '
        'btnRegistrarUsuario
        '
        Me.btnRegistrarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarUsuario.Location = New System.Drawing.Point(4, 4)
        Me.btnRegistrarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        Me.btnRegistrarUsuario.Size = New System.Drawing.Size(192, 32)
        Me.btnRegistrarUsuario.TabIndex = 0
        Me.btnRegistrarUsuario.Text = "Registrar usuario"
        Me.btnRegistrarUsuario.UseVisualStyleBackColor = True
        '
        'btnAsignarTurno
        '
        Me.btnAsignarTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarTurno.Location = New System.Drawing.Point(4, 94)
        Me.btnAsignarTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAsignarTurno.Name = "btnAsignarTurno"
        Me.btnAsignarTurno.Size = New System.Drawing.Size(192, 32)
        Me.btnAsignarTurno.TabIndex = 2
        Me.btnAsignarTurno.Text = "Asignar nuevo turno"
        Me.btnAsignarTurno.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(655, 13)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(307, 36)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MODULO USUARIOS"
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.SystemColors.Control
        Me.BtnVolver.Location = New System.Drawing.Point(1, 3)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(131, 34)
        Me.BtnVolver.TabIndex = 15
        Me.BtnVolver.Text = "←Volver al menú"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'FormMenuControlDeUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1685, 690)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMenuControlDeUsuario"
        Me.Text = "FormMenuControlDeUsuario"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnReactivarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnAsignarTurno As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As Button
End Class
