<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteDeSolicitudes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteDeSolicitudes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkDia = New System.Windows.Forms.CheckBox()
        Me.DtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Lhasta = New System.Windows.Forms.Label()
        Me.hd = New System.Windows.Forms.Label()
        Me.DgvTSolicitudes = New System.Windows.Forms.DataGridView()
        Me.TxbBuscar = New System.Windows.Forms.TextBox()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnMenuTriaje = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckMedExterno = New System.Windows.Forms.CheckBox()
        CType(Me.DgvTSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reporte de Solicitudes"
        '
        'checkDia
        '
        Me.checkDia.AutoSize = True
        Me.checkDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkDia.Location = New System.Drawing.Point(418, 124)
        Me.checkDia.Name = "checkDia"
        Me.checkDia.Size = New System.Drawing.Size(144, 24)
        Me.checkDia.TabIndex = 2
        Me.checkDia.Text = "Reporte del día"
        Me.checkDia.UseVisualStyleBackColor = True
        '
        'DtDesde
        '
        Me.DtDesde.CustomFormat = ""
        Me.DtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtDesde.Location = New System.Drawing.Point(366, 179)
        Me.DtDesde.Name = "DtDesde"
        Me.DtDesde.Size = New System.Drawing.Size(104, 22)
        Me.DtDesde.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desde:"
        '
        'DtHasta
        '
        Me.DtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtHasta.Location = New System.Drawing.Point(525, 179)
        Me.DtHasta.Name = "DtHasta"
        Me.DtHasta.Size = New System.Drawing.Size(104, 22)
        Me.DtHasta.TabIndex = 5
        '
        'Lhasta
        '
        Me.Lhasta.AutoSize = True
        Me.Lhasta.Location = New System.Drawing.Point(477, 181)
        Me.Lhasta.Name = "Lhasta"
        Me.Lhasta.Size = New System.Drawing.Size(46, 16)
        Me.Lhasta.TabIndex = 4
        Me.Lhasta.Text = "Hasta:"
        '
        'hd
        '
        Me.hd.AutoSize = True
        Me.hd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hd.Location = New System.Drawing.Point(443, 151)
        Me.hd.Name = "hd"
        Me.hd.Size = New System.Drawing.Size(87, 25)
        Me.hd.TabIndex = 8
        Me.hd.Text = "Histórico"
        '
        'DgvTSolicitudes
        '
        Me.DgvTSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvTSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTSolicitudes.Location = New System.Drawing.Point(18, 214)
        Me.DgvTSolicitudes.Name = "DgvTSolicitudes"
        Me.DgvTSolicitudes.RowHeadersWidth = 51
        Me.DgvTSolicitudes.RowTemplate.Height = 24
        Me.DgvTSolicitudes.Size = New System.Drawing.Size(862, 308)
        Me.DgvTSolicitudes.TabIndex = 9
        '
        'TxbBuscar
        '
        Me.TxbBuscar.Location = New System.Drawing.Point(20, 181)
        Me.TxbBuscar.Name = "TxbBuscar"
        Me.TxbBuscar.Size = New System.Drawing.Size(148, 22)
        Me.TxbBuscar.TabIndex = 10
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.Location = New System.Drawing.Point(17, 135)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(52, 16)
        Me.LBuscar.TabIndex = 7
        Me.LBuscar.Text = "Buscar:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(886, 270)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(108, 46)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-6, -6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1016, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 729
        Me.PictureBox2.TabStop = False
        '
        'BtnMenuTriaje
        '
        Me.BtnMenuTriaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenuTriaje.Location = New System.Drawing.Point(886, 214)
        Me.BtnMenuTriaje.Name = "BtnMenuTriaje"
        Me.BtnMenuTriaje.Size = New System.Drawing.Size(108, 50)
        Me.BtnMenuTriaje.TabIndex = 730
        Me.BtnMenuTriaje.Text = "Menú"
        Me.BtnMenuTriaje.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Location = New System.Drawing.Point(886, 322)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(108, 50)
        Me.BtnImprimir.TabIndex = 730
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Paciente"
        '
        'CheckMedExterno
        '
        Me.CheckMedExterno.AutoSize = True
        Me.CheckMedExterno.Location = New System.Drawing.Point(655, 183)
        Me.CheckMedExterno.Name = "CheckMedExterno"
        Me.CheckMedExterno.Size = New System.Drawing.Size(122, 20)
        Me.CheckMedExterno.TabIndex = 732
        Me.CheckMedExterno.Text = "Medico Externo"
        Me.CheckMedExterno.UseVisualStyleBackColor = True
        '
        'FormReporteDeSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 553)
        Me.Controls.Add(Me.CheckMedExterno)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnMenuTriaje)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxbBuscar)
        Me.Controls.Add(Me.DgvTSolicitudes)
        Me.Controls.Add(Me.hd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBuscar)
        Me.Controls.Add(Me.DtHasta)
        Me.Controls.Add(Me.Lhasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtDesde)
        Me.Controls.Add(Me.checkDia)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormReporteDeSolicitudes"
        Me.Text = "Reportes"
        CType(Me.DgvTSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents checkDia As CheckBox
    Friend WithEvents DtDesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DtHasta As DateTimePicker
    Friend WithEvents Lhasta As Label
    Friend WithEvents hd As Label
    Friend WithEvents DgvTSolicitudes As DataGridView
    Friend WithEvents TxbBuscar As TextBox
    Friend WithEvents LBuscar As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnMenuTriaje As Button
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckMedExterno As CheckBox
End Class
