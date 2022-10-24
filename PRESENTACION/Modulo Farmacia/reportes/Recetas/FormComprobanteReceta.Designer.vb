<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComprobanteReceta
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.AutoSize = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 1)
        Me.CrystalReportViewer1.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1007, 620)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'btnTerminar
        '
        Me.btnTerminar.Location = New System.Drawing.Point(889, 627)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(95, 34)
        Me.btnTerminar.TabIndex = 1
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'FormComprobanteReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 673)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FormComprobanteReceta"
        Me.Text = "Imprimir Receta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnTerminar As Button
End Class
