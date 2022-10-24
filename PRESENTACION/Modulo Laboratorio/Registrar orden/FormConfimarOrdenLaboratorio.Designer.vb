<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConfimarOrdenLaboratorio
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
        Me.rViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rViewer
        '
        Me.rViewer.ActiveViewIndex = -1
        Me.rViewer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rViewer.DisplayBackgroundEdge = False
        Me.rViewer.DisplayStatusBar = False
        Me.rViewer.Location = New System.Drawing.Point(33, 33)
        Me.rViewer.Name = "rViewer"
        Me.rViewer.ShowCloseButton = False
        Me.rViewer.ShowCopyButton = False
        Me.rViewer.ShowExportButton = False
        Me.rViewer.ShowGroupTreeButton = False
        Me.rViewer.ShowLogo = False
        Me.rViewer.ShowParameterPanelButton = False
        Me.rViewer.Size = New System.Drawing.Size(710, 481)
        Me.rViewer.TabIndex = 0
        Me.rViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(761, 62)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(66, 28)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(833, 62)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(193, 28)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "Confirmar y registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(792, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CONFIRMAR REGISTRO"
        '
        'FormConfimarOrdenLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 546)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.rViewer)
        Me.Name = "FormConfimarOrdenLaboratorio"
        Me.Text = "Confirmrar registro de orden de laboratorio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label1 As Label
End Class
