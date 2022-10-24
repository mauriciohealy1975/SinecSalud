<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrarBajaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistrarBajaMedica))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmboxNombreAsegurado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscarAsegurado = New System.Windows.Forms.TextBox()
        Me.btnBuscarAsegurado = New System.Windows.Forms.Button()
        Me.txtNombreAsegurado = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboxLugar = New System.Windows.Forms.GroupBox()
        Me.radiobuttonInternacion = New System.Windows.Forms.RadioButton()
        Me.rbuttonEmergencia = New System.Windows.Forms.RadioButton()
        Me.rbuttonClinica = New System.Windows.Forms.RadioButton()
        Me.rbuttonConsultaExt = New System.Windows.Forms.RadioButton()
        Me.gboxRegimen = New System.Windows.Forms.GroupBox()
        Me.rbuttonRiesgosLab = New System.Windows.Forms.RadioButton()
        Me.rbuttonMaternidad = New System.Windows.Forms.RadioButton()
        Me.rbuttonEnfermedadCom = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gboxTratamiento = New System.Windows.Forms.GroupBox()
        Me.rbuttonHospitalizacion = New System.Windows.Forms.RadioButton()
        Me.rbuttonDomicilio = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dTimeDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dTimeHasta = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numDias = New System.Windows.Forms.NumericUpDown()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGuardarBajaMedica = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLeyenda = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCancelar2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.gboxLugar.SuspendLayout()
        Me.gboxRegimen.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gboxTratamiento.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.numDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(583, 47)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(616, 39)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de Baja Medica"
        '
        'cmboxNombreAsegurado
        '
        Me.cmboxNombreAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxNombreAsegurado.FormattingEnabled = True
        Me.cmboxNombreAsegurado.Location = New System.Drawing.Point(61, 164)
        Me.cmboxNombreAsegurado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmboxNombreAsegurado.Name = "cmboxNombreAsegurado"
        Me.cmboxNombreAsegurado.Size = New System.Drawing.Size(411, 26)
        Me.cmboxNombreAsegurado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar Asegurado"
        '
        'txtBuscarAsegurado
        '
        Me.txtBuscarAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarAsegurado.Location = New System.Drawing.Point(61, 129)
        Me.txtBuscarAsegurado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscarAsegurado.Name = "txtBuscarAsegurado"
        Me.txtBuscarAsegurado.Size = New System.Drawing.Size(408, 24)
        Me.txtBuscarAsegurado.TabIndex = 3
        '
        'btnBuscarAsegurado
        '
        Me.btnBuscarAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarAsegurado.Location = New System.Drawing.Point(500, 127)
        Me.btnBuscarAsegurado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscarAsegurado.Name = "btnBuscarAsegurado"
        Me.btnBuscarAsegurado.Size = New System.Drawing.Size(104, 28)
        Me.btnBuscarAsegurado.TabIndex = 4
        Me.btnBuscarAsegurado.Text = "Buscar"
        Me.btnBuscarAsegurado.UseVisualStyleBackColor = True
        '
        'txtNombreAsegurado
        '
        Me.txtNombreAsegurado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAsegurado.Location = New System.Drawing.Point(59, 165)
        Me.txtNombreAsegurado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreAsegurado.Name = "txtNombreAsegurado"
        Me.txtNombreAsegurado.Size = New System.Drawing.Size(319, 24)
        Me.txtNombreAsegurado.TabIndex = 5
        Me.txtNombreAsegurado.Visible = False
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(457, 247)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(13, 92)
        Me.TableLayoutPanel7.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(5, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(3, 92)
        Me.Label7.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 263)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 23
        '
        'gboxLugar
        '
        Me.gboxLugar.Controls.Add(Me.radiobuttonInternacion)
        Me.gboxLugar.Controls.Add(Me.rbuttonEmergencia)
        Me.gboxLugar.Controls.Add(Me.rbuttonClinica)
        Me.gboxLugar.Controls.Add(Me.rbuttonConsultaExt)
        Me.gboxLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxLugar.Location = New System.Drawing.Point(61, 247)
        Me.gboxLugar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxLugar.Name = "gboxLugar"
        Me.gboxLugar.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxLugar.Size = New System.Drawing.Size(376, 94)
        Me.gboxLugar.TabIndex = 0
        Me.gboxLugar.TabStop = False
        Me.gboxLugar.Text = "Lugar de Atención"
        '
        'radiobuttonInternacion
        '
        Me.radiobuttonInternacion.AutoSize = True
        Me.radiobuttonInternacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonInternacion.Location = New System.Drawing.Point(237, 54)
        Me.radiobuttonInternacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonInternacion.Name = "radiobuttonInternacion"
        Me.radiobuttonInternacion.Size = New System.Drawing.Size(101, 22)
        Me.radiobuttonInternacion.TabIndex = 1
        Me.radiobuttonInternacion.TabStop = True
        Me.radiobuttonInternacion.Text = "Internacion"
        Me.radiobuttonInternacion.UseVisualStyleBackColor = True
        '
        'rbuttonEmergencia
        '
        Me.rbuttonEmergencia.AutoSize = True
        Me.rbuttonEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonEmergencia.Location = New System.Drawing.Point(237, 23)
        Me.rbuttonEmergencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbuttonEmergencia.Name = "rbuttonEmergencia"
        Me.rbuttonEmergencia.Size = New System.Drawing.Size(108, 22)
        Me.rbuttonEmergencia.TabIndex = 0
        Me.rbuttonEmergencia.TabStop = True
        Me.rbuttonEmergencia.Text = "Emergencía"
        Me.rbuttonEmergencia.UseVisualStyleBackColor = True
        '
        'rbuttonClinica
        '
        Me.rbuttonClinica.AutoSize = True
        Me.rbuttonClinica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonClinica.Location = New System.Drawing.Point(49, 54)
        Me.rbuttonClinica.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbuttonClinica.Name = "rbuttonClinica"
        Me.rbuttonClinica.Size = New System.Drawing.Size(73, 22)
        Me.rbuttonClinica.TabIndex = 0
        Me.rbuttonClinica.TabStop = True
        Me.rbuttonClinica.Text = "Clínica"
        Me.rbuttonClinica.UseVisualStyleBackColor = True
        '
        'rbuttonConsultaExt
        '
        Me.rbuttonConsultaExt.AutoSize = True
        Me.rbuttonConsultaExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonConsultaExt.Location = New System.Drawing.Point(49, 23)
        Me.rbuttonConsultaExt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbuttonConsultaExt.Name = "rbuttonConsultaExt"
        Me.rbuttonConsultaExt.Size = New System.Drawing.Size(142, 22)
        Me.rbuttonConsultaExt.TabIndex = 0
        Me.rbuttonConsultaExt.TabStop = True
        Me.rbuttonConsultaExt.Text = "Consulta Externa"
        Me.rbuttonConsultaExt.UseVisualStyleBackColor = True
        '
        'gboxRegimen
        '
        Me.gboxRegimen.Controls.Add(Me.rbuttonRiesgosLab)
        Me.gboxRegimen.Controls.Add(Me.rbuttonMaternidad)
        Me.gboxRegimen.Controls.Add(Me.rbuttonEnfermedadCom)
        Me.gboxRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxRegimen.Location = New System.Drawing.Point(496, 247)
        Me.gboxRegimen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxRegimen.Name = "gboxRegimen"
        Me.gboxRegimen.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxRegimen.Size = New System.Drawing.Size(391, 94)
        Me.gboxRegimen.TabIndex = 24
        Me.gboxRegimen.TabStop = False
        Me.gboxRegimen.Text = "Regimen"
        '
        'rbuttonRiesgosLab
        '
        Me.rbuttonRiesgosLab.AutoSize = True
        Me.rbuttonRiesgosLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonRiesgosLab.Location = New System.Drawing.Point(49, 54)
        Me.rbuttonRiesgosLab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbuttonRiesgosLab.Name = "rbuttonRiesgosLab"
        Me.rbuttonRiesgosLab.Size = New System.Drawing.Size(153, 22)
        Me.rbuttonRiesgosLab.TabIndex = 0
        Me.rbuttonRiesgosLab.TabStop = True
        Me.rbuttonRiesgosLab.Text = "Riesgos Laborales"
        Me.rbuttonRiesgosLab.UseVisualStyleBackColor = True
        '
        'rbuttonMaternidad
        '
        Me.rbuttonMaternidad.AutoSize = True
        Me.rbuttonMaternidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonMaternidad.Location = New System.Drawing.Point(265, 23)
        Me.rbuttonMaternidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbuttonMaternidad.Name = "rbuttonMaternidad"
        Me.rbuttonMaternidad.Size = New System.Drawing.Size(102, 22)
        Me.rbuttonMaternidad.TabIndex = 0
        Me.rbuttonMaternidad.TabStop = True
        Me.rbuttonMaternidad.Text = "Maternidad"
        Me.rbuttonMaternidad.UseVisualStyleBackColor = True
        '
        'rbuttonEnfermedadCom
        '
        Me.rbuttonEnfermedadCom.AutoSize = True
        Me.rbuttonEnfermedadCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonEnfermedadCom.Location = New System.Drawing.Point(49, 23)
        Me.rbuttonEnfermedadCom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbuttonEnfermedadCom.Name = "rbuttonEnfermedadCom"
        Me.rbuttonEnfermedadCom.Size = New System.Drawing.Size(162, 22)
        Me.rbuttonEnfermedadCom.TabIndex = 0
        Me.rbuttonEnfermedadCom.TabStop = True
        Me.rbuttonEnfermedadCom.Text = "Enfermedad Común"
        Me.rbuttonEnfermedadCom.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(931, 247)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(13, 92)
        Me.TableLayoutPanel2.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(5, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(3, 92)
        Me.Label4.TabIndex = 10
        '
        'gboxTratamiento
        '
        Me.gboxTratamiento.Controls.Add(Me.rbuttonHospitalizacion)
        Me.gboxTratamiento.Controls.Add(Me.rbuttonDomicilio)
        Me.gboxTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxTratamiento.Location = New System.Drawing.Point(979, 246)
        Me.gboxTratamiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxTratamiento.Name = "gboxTratamiento"
        Me.gboxTratamiento.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxTratamiento.Size = New System.Drawing.Size(220, 94)
        Me.gboxTratamiento.TabIndex = 26
        Me.gboxTratamiento.TabStop = False
        Me.gboxTratamiento.Text = "Tratamiento"
        '
        'rbuttonHospitalizacion
        '
        Me.rbuttonHospitalizacion.AutoSize = True
        Me.rbuttonHospitalizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonHospitalizacion.Location = New System.Drawing.Point(49, 54)
        Me.rbuttonHospitalizacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbuttonHospitalizacion.Name = "rbuttonHospitalizacion"
        Me.rbuttonHospitalizacion.Size = New System.Drawing.Size(130, 22)
        Me.rbuttonHospitalizacion.TabIndex = 0
        Me.rbuttonHospitalizacion.TabStop = True
        Me.rbuttonHospitalizacion.Text = "Hospitalización"
        Me.rbuttonHospitalizacion.UseVisualStyleBackColor = True
        '
        'rbuttonDomicilio
        '
        Me.rbuttonDomicilio.AutoSize = True
        Me.rbuttonDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbuttonDomicilio.Location = New System.Drawing.Point(49, 23)
        Me.rbuttonDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbuttonDomicilio.Name = "rbuttonDomicilio"
        Me.rbuttonDomicilio.Size = New System.Drawing.Size(91, 22)
        Me.rbuttonDomicilio.TabIndex = 0
        Me.rbuttonDomicilio.TabStop = True
        Me.rbuttonDomicilio.Text = "Domicilio"
        Me.rbuttonDomicilio.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(61, 352)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(1149, 15)
        Me.TableLayoutPanel10.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(4, 6)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1141, 2)
        Me.Label12.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 391)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Periodo de Incapacidad"
        '
        'dTimeDesde
        '
        Me.dTimeDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dTimeDesde.Location = New System.Drawing.Point(135, 441)
        Me.dTimeDesde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dTimeDesde.Name = "dTimeDesde"
        Me.dTimeDesde.Size = New System.Drawing.Size(304, 24)
        Me.dTimeDesde.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 441)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Desde:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 487)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Hasta:"
        '
        'dTimeHasta
        '
        Me.dTimeHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dTimeHasta.Location = New System.Drawing.Point(135, 487)
        Me.dTimeHasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dTimeHasta.Name = "dTimeHasta"
        Me.dTimeHasta.Size = New System.Drawing.Size(301, 24)
        Me.dTimeHasta.TabIndex = 31
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(452, 420)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(13, 92)
        Me.TableLayoutPanel3.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(5, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(3, 92)
        Me.Label9.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(496, 443)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Nro de días (numeral):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(496, 487)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 20)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Nro de días en literal:"
        '
        'numDias
        '
        Me.numDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDias.Location = New System.Drawing.Point(693, 439)
        Me.numDias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numDias.Name = "numDias"
        Me.numDias.Size = New System.Drawing.Size(207, 24)
        Me.numDias.TabIndex = 36
        '
        'txtDias
        '
        Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias.Location = New System.Drawing.Point(693, 482)
        Me.txtDias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(205, 24)
        Me.txtDias.TabIndex = 37
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(65, 202)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1149, 15)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(4, 6)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1141, 2)
        Me.Label13.TabIndex = 10
        '
        'btnGuardarBajaMedica
        '
        Me.btnGuardarBajaMedica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarBajaMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarBajaMedica.Location = New System.Drawing.Point(1002, 424)
        Me.btnGuardarBajaMedica.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardarBajaMedica.Name = "btnGuardarBajaMedica"
        Me.btnGuardarBajaMedica.Size = New System.Drawing.Size(204, 37)
        Me.btnGuardarBajaMedica.TabIndex = 41
        Me.btnGuardarBajaMedica.Text = "Guardar Baja Medica"
        Me.btnGuardarBajaMedica.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(55, 540)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 20)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Leyenda"
        '
        'txtLeyenda
        '
        Me.txtLeyenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLeyenda.AutoSize = True
        Me.txtLeyenda.BackColor = System.Drawing.Color.White
        Me.txtLeyenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeyenda.Location = New System.Drawing.Point(4, 0)
        Me.txtLeyenda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtLeyenda.Name = "txtLeyenda"
        Me.txtLeyenda.Size = New System.Drawing.Size(1220, 60)
        Me.txtLeyenda.TabIndex = 46
        Me.txtLeyenda.Text = resources.GetString("txtLeyenda.Text")
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txtLeyenda, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(59, 564)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1228, 60)
        Me.TableLayoutPanel5.TabIndex = 47
        '
        'BtnCancelar2
        '
        Me.BtnCancelar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar2.Location = New System.Drawing.Point(1002, 475)
        Me.BtnCancelar2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar2.Name = "BtnCancelar2"
        Me.BtnCancelar2.Size = New System.Drawing.Size(204, 37)
        Me.BtnCancelar2.TabIndex = 49
        Me.BtnCancelar2.Text = "CANCELAR"
        Me.BtnCancelar2.UseVisualStyleBackColor = True
        '
        'FormRegistrarBajaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 553)
        Me.Controls.Add(Me.BtnCancelar2)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnGuardarBajaMedica)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.numDias)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dTimeHasta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dTimeDesde)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel10)
        Me.Controls.Add(Me.gboxTratamiento)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.gboxRegimen)
        Me.Controls.Add(Me.gboxLugar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.txtNombreAsegurado)
        Me.Controls.Add(Me.btnBuscarAsegurado)
        Me.Controls.Add(Me.txtBuscarAsegurado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmboxNombreAsegurado)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormRegistrarBajaMedica"
        Me.Text = "FormRegistrarBajaMedica"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.gboxLugar.ResumeLayout(False)
        Me.gboxLugar.PerformLayout()
        Me.gboxRegimen.ResumeLayout(False)
        Me.gboxRegimen.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.gboxTratamiento.ResumeLayout(False)
        Me.gboxTratamiento.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.numDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmboxNombreAsegurado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarAsegurado As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarAsegurado As System.Windows.Forms.Button
    Friend WithEvents txtNombreAsegurado As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gboxLugar As System.Windows.Forms.GroupBox
    Friend WithEvents rbuttonEmergencia As System.Windows.Forms.RadioButton
    Friend WithEvents rbuttonClinica As System.Windows.Forms.RadioButton
    Friend WithEvents rbuttonConsultaExt As System.Windows.Forms.RadioButton
    Friend WithEvents gboxRegimen As System.Windows.Forms.GroupBox
    Friend WithEvents rbuttonRiesgosLab As System.Windows.Forms.RadioButton
    Friend WithEvents rbuttonMaternidad As System.Windows.Forms.RadioButton
    Friend WithEvents rbuttonEnfermedadCom As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gboxTratamiento As System.Windows.Forms.GroupBox
    Friend WithEvents rbuttonHospitalizacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbuttonDomicilio As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dTimeDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dTimeHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents numDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDias As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarBajaMedica As System.Windows.Forms.Button
    Friend WithEvents radiobuttonInternacion As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLeyenda As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnCancelar2 As Button
End Class
