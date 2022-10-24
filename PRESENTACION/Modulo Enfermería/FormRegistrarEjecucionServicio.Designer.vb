<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrarEjecucionServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistrarEjecucionServicio))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscarNombreAsegurado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmboxOrdenMedica = New System.Windows.Forms.ComboBox()
        Me.btnBuscarOrden = New System.Windows.Forms.Button()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rboxDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numberCesion = New System.Windows.Forms.NumericUpDown()
        Me.datePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOrdenMedica = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtServicioSeleccionado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.numberCesion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(64, 44)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1545, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(592, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EJECUCIÓN SERVICIO ENFERMERÍA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 123)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Información Orden"
        '
        'txtBuscarNombreAsegurado
        '
        Me.txtBuscarNombreAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarNombreAsegurado.Location = New System.Drawing.Point(64, 225)
        Me.txtBuscarNombreAsegurado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscarNombreAsegurado.Name = "txtBuscarNombreAsegurado"
        Me.txtBuscarNombreAsegurado.Size = New System.Drawing.Size(336, 24)
        Me.txtBuscarNombreAsegurado.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Servicio Seleccionado"
        '
        'cmboxOrdenMedica
        '
        Me.cmboxOrdenMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxOrdenMedica.FormattingEnabled = True
        Me.cmboxOrdenMedica.Location = New System.Drawing.Point(64, 270)
        Me.cmboxOrdenMedica.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxOrdenMedica.Name = "cmboxOrdenMedica"
        Me.cmboxOrdenMedica.Size = New System.Drawing.Size(547, 26)
        Me.cmboxOrdenMedica.TabIndex = 3
        Me.cmboxOrdenMedica.Text = "SELECCIONAR"
        '
        'btnBuscarOrden
        '
        Me.btnBuscarOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarOrden.Location = New System.Drawing.Point(409, 223)
        Me.btnBuscarOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarOrden.Name = "btnBuscarOrden"
        Me.btnBuscarOrden.Size = New System.Drawing.Size(131, 30)
        Me.btnBuscarOrden.TabIndex = 2
        Me.btnBuscarOrden.Text = "Buscar Orden"
        Me.btnBuscarOrden.UseVisualStyleBackColor = True
        '
        'dgvDetalles
        '
        Me.dgvDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(637, 162)
        Me.dgvDetalles.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.RowHeadersWidth = 51
        Me.dgvDetalles.Size = New System.Drawing.Size(995, 135)
        Me.dgvDetalles.TabIndex = 4
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(68, 322)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1568, 12)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(4, 5)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(1560, 2)
        Me.Label17.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 350)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ejecución del Servicio"
        '
        'rboxDescripcion
        '
        Me.rboxDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rboxDescripcion.Location = New System.Drawing.Point(1020, 50)
        Me.rboxDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.rboxDescripcion.Name = "rboxDescripcion"
        Me.rboxDescripcion.Size = New System.Drawing.Size(487, 62)
        Me.rboxDescripcion.TabIndex = 4
        Me.rboxDescripcion.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1016, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nro. Cesión"
        '
        'numberCesion
        '
        Me.numberCesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberCesion.Location = New System.Drawing.Point(448, 52)
        Me.numberCesion.Margin = New System.Windows.Forms.Padding(4)
        Me.numberCesion.Name = "numberCesion"
        Me.numberCesion.Size = New System.Drawing.Size(116, 24)
        Me.numberCesion.TabIndex = 2
        '
        'datePickerFecha
        '
        Me.datePickerFecha.Location = New System.Drawing.Point(663, 53)
        Me.datePickerFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.datePickerFecha.Name = "datePickerFecha"
        Me.datePickerFecha.Size = New System.Drawing.Size(265, 22)
        Me.datePickerFecha.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(659, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha Ejecución"
        '
        'txtOrdenMedica
        '
        Me.txtOrdenMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenMedica.Location = New System.Drawing.Point(64, 272)
        Me.txtOrdenMedica.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrdenMedica.Name = "txtOrdenMedica"
        Me.txtOrdenMedica.Size = New System.Drawing.Size(547, 24)
        Me.txtOrdenMedica.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(633, 139)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Detalles de orden"
        '
        'txtServicioSeleccionado
        '
        Me.txtServicioSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServicioSeleccionado.Location = New System.Drawing.Point(69, 50)
        Me.txtServicioSeleccionado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServicioSeleccionado.Name = "txtServicioSeleccionado"
        Me.txtServicioSeleccionado.Size = New System.Drawing.Size(299, 24)
        Me.txtServicioSeleccionado.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 202)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Asegurado"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.rboxDescripcion)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.datePickerFecha)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.numberCesion)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtServicioSeleccionado)
        Me.Panel2.Location = New System.Drawing.Point(68, 400)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1567, 163)
        Me.Panel2.TabIndex = 5
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(1473, 632)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(163, 34)
        Me.Cancelar.TabIndex = 7
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(1473, 592)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(163, 34)
        Me.guardar.TabIndex = 8
        Me.guardar.Text = "Guardar Solicitud"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'FormRegistrarEjecucionServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1685, 690)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Controls.Add(Me.dgvDetalles)
        Me.Controls.Add(Me.btnBuscarOrden)
        Me.Controls.Add(Me.cmboxOrdenMedica)
        Me.Controls.Add(Me.txtOrdenMedica)
        Me.Controls.Add(Me.txtBuscarNombreAsegurado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRegistrarEjecucionServicio"
        Me.Text = "Ejecucion de Servicio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.numberCesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarNombreAsegurado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmboxOrdenMedica As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarOrden As System.Windows.Forms.Button
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rboxDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numberCesion As System.Windows.Forms.NumericUpDown
    Friend WithEvents datePickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenMedica As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtServicioSeleccionado As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Cancelar As Button
    Friend WithEvents guardar As Button
End Class
