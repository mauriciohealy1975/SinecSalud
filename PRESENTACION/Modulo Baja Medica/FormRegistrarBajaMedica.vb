Imports NEGOCIO

'1280 x 600


Public Class FormRegistrarBajaMedica

    Dim oRegistroBajaMed As RegistroBajaMedica
    Dim oBajaMedica As BajaMedica

    Private Sub FormRegistrarBajaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarDisplay()
        iniciarControles()
        iniciarObjetos()
    End Sub

    Private Sub iniciarObjetos()
        oRegistroBajaMed = New RegistroBajaMedica()
        oBajaMedica = New BajaMedica()
    End Sub




    'METODOS INICIO INTERFAZ
    Private Sub configurarDisplay()
        Me.Size = New Size(1280, 600)
        Me.MinimumSize = New System.Drawing.Size(1280, 600)
        Me.Icon = New System.Drawing.Icon("icono.ico")
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub iniciarControles()
        iniciarControlesGrupo1()
        iniciarControlesGrupo2()
        iniciarControlesGrupo3()
    End Sub

    Private Sub iniciarControlesGrupo1()
        txtBuscarAsegurado.Enabled = True
        txtBuscarAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtBuscarAsegurado.Text = ""

        btnBuscarAsegurado.Enabled = True
        btnBuscarAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        btnBuscarAsegurado.Text = "Buscar"

        txtNombreAsegurado.Enabled = False
        txtNombreAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        txtNombreAsegurado.Text = ""
        txtNombreAsegurado.Visible = False

        cmboxNombreAsegurado.Enabled = False
        cmboxNombreAsegurado.Font = New Font("Microsoft Sans Serif", 9)
        cmboxNombreAsegurado.Items.Clear()
        cmboxNombreAsegurado.Text = ""
        cmboxNombreAsegurado.DropDownStyle = ComboBoxStyle.DropDownList
        cmboxNombreAsegurado.Visible = True
    End Sub

    Private Sub iniciarControlesGrupo2()
        rbuttonConsultaExt.Enabled = False
        rbuttonConsultaExt.Font = New Font("Microsoft Sans Serif", 9)
        rbuttonConsultaExt.Checked = False

        rbuttonClinica.Enabled = False
        rbuttonClinica.Font = New Font("Microsoft Sans Serif", 9)
        rbuttonClinica.Checked = False

        rbuttonEmergencia.Enabled = False
        rbuttonEmergencia.Font = New Font("Microsoft Sans Serif", 9)
        rbuttonEmergencia.Checked = False

        radiobuttonInternacion.Enabled = False
        radiobuttonInternacion.Font = New Font("Microsoft Sans Serif", 9)
        radiobuttonInternacion.Checked = False

        rbuttonEnfermedadCom.Enabled = False
        rbuttonEnfermedadCom.Font = New Font("Microsoft Sans Serif", 9)
        rbuttonEnfermedadCom.Checked = False

        rbuttonRiesgosLab.Enabled = False
        rbuttonRiesgosLab.Font = New Font("Microsoft Sans Serif", 9)
        rbuttonRiesgosLab.Checked = False

        rbuttonMaternidad.Enabled = False
        rbuttonMaternidad.Font = New Font("Microsoft Sans Serif", 9)
        rbuttonMaternidad.Checked = False

        rbuttonDomicilio.Enabled = False
        rbuttonDomicilio.Font = New Font("Microsoft Sans Serif", 9)
        rbuttonDomicilio.Checked = False

        rbuttonHospitalizacion.Enabled = False
        rbuttonHospitalizacion.Font = New Font("Microsoft Sans Serif", 9)
        rbuttonHospitalizacion.Checked = False
    End Sub

    Private Sub iniciarControlesGrupo3()
        dTimeDesde.Enabled = False
        dTimeDesde.Font = New Font("Microsoft Sans Serif", 9)
        dTimeDesde.MinDate = DateTime.Today.ToString("yyyy-MM-dd")
        dTimeDesde.Value = DateTime.Today.ToString("yyyy-MM-dd")

        dTimeHasta.Enabled = False
        dTimeDesde.Font = New Font("Microsoft Sans Serif", 9)
        dTimeHasta.MinDate = DateTime.Today.ToString("yyyy-MM-dd")
        dTimeHasta.Value = DateTime.Today.ToString("yyyy-MM-dd")


        numDias.Enabled = False
        numDias.Font = New Font("Microsoft Sans Serif", 9)
        numDias.Value = 0

        txtDias.Enabled = False
        txtDias.Font = New Font("Microsoft Sans Serif", 9)
        txtDias.Text = ""

        txtLeyenda.Enabled = False
        txtLeyenda.Font = New Font("Microsoft Sans Serif", 9)
        txtLeyenda.Text = "Los partes de baja otorgados por los medicos de la caja, deberán ser presentados al empleador, por el trabajador u otra persona, en el término máximo de 24 horas de haberse practicado la consulta. En caso contrario perderá el salario o el subsidio por el tiempo de retraso. Art 60.R.C.S.G"


        btnGuardarBajaMedica.Enabled = False
        btnGuardarBajaMedica.Font = New Font("Microsoft Sans Serif", 9)
        btnGuardarBajaMedica.Text = "Guardar Baja Medica"
    End Sub





    'METODOS INTEFAZ
    Private Sub reiniciarFormulario()
        oRegistroBajaMed = New RegistroBajaMedica()
        oBajaMedica = New BajaMedica()
        iniciarControles()
    End Sub

    Private Sub buscarAsegurado()
        Dim descripcion = cmboxNombreAsegurado.SelectedItem.ToString()
        oRegistroBajaMed.buscarAsegurado(descripcion)
    End Sub

    Private Sub escribirNombreAsegurado()
        txtNombreAsegurado.Text = oRegistroBajaMed.oAsegurado.getNombres()
    End Sub

    Private Sub poblarCmboxAsegurado()
        For Each asegurado As Asegurado In oRegistroBajaMed.listaAsegurados
            cmboxNombreAsegurado.Items.Add(asegurado.getDescripcion())
        Next

    End Sub

    Private Sub reiniciarCmboxNombreAsegurado()
        cmboxNombreAsegurado.Items.Clear()
        cmboxNombreAsegurado.Text = ""
    End Sub

    Private Sub habilitarCmboxNomAseg()
        cmboxNombreAsegurado.Enabled = True
    End Sub

    Private Sub deshabilitarCmboxNomAseg()
        cmboxNombreAsegurado.Enabled = False
    End Sub

    Private Sub ocultarCmboxNombreAsegurado()
        cmboxNombreAsegurado.Visible = False
    End Sub

    Private Sub habilitarTxtNombreAsegurado()
        txtNombreAsegurado.Enabled = True
    End Sub

    Private Sub deshabilitarTxtNombreAsegurado()
        txtNombreAsegurado.Enabled = False
    End Sub

    Private Sub mostrarTxtNombreAsegurado()
        txtNombreAsegurado.Visible = True
    End Sub

    Private Sub ocultarTxtNombreAsegurado()
        txtNombreAsegurado.Visible = False
    End Sub

    Private Sub habilitarGruposControles()
        rbuttonConsultaExt.Enabled = True
        rbuttonClinica.Enabled = True

        rbuttonEmergencia.Enabled = True
        radiobuttonInternacion.Enabled = True

        rbuttonEnfermedadCom.Enabled = True
        rbuttonRiesgosLab.Enabled = True
        rbuttonMaternidad.Enabled = True

        rbuttonDomicilio.Enabled = True
        rbuttonHospitalizacion.Enabled = True

        dTimeDesde.Enabled = True
        dTimeHasta.Enabled = True

        numDias.Enabled = True
        txtDias.Enabled = True
        txtLeyenda.Enabled = True

        btnGuardarBajaMedica.Enabled = True
    End Sub

    Private Sub mostrarMensaje(ByVal _mensaje As String)
         MessageBox.Show(_mensaje)
    End Sub






    'METODOS CLICK
    Private Sub btnBuscarAsegurado_Click(sender As Object, e As EventArgs) Handles btnBuscarAsegurado.Click
        reiniciarCmboxNombreAsegurado()

        Dim nombreAsegurado As String = txtBuscarAsegurado.Text.ToString().Trim()
        oRegistroBajaMed.traerAsegurados(nombreAsegurado)
        poblarCmboxAsegurado()
        habilitarCmboxNomAseg()
    End Sub

    Private Sub cmboxNombreAsegurado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxNombreAsegurado.SelectionChangeCommitted
        buscarAsegurado()
        escribirNombreAsegurado()
        deshabilitarTxtNombreAsegurado()
        mostrarTxtNombreAsegurado()
        ocultarCmboxNombreAsegurado()
        deshabilitarCmboxNomAseg()

        habilitarGruposControles()
    End Sub

    Private Sub rbuttonConsultaExt_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonConsultaExt.CheckedChanged
        If Not IsNothing(oBajaMedica) Then
            oBajaMedica.setLugarAtencion(BajaMedica.LugarAtencionConsultaExterna)
        End If

    End Sub

    Private Sub rbuttonClinica_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonClinica.CheckedChanged
        If Not IsNothing(oBajaMedica) Then
            oBajaMedica.setLugarAtencion(BajaMedica.LugarAtencionClinica)
        End If
    End Sub

    Private Sub rbuttonEmergencia_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonEmergencia.CheckedChanged
        If Not IsNothing(oBajaMedica) Then
            oBajaMedica.setLugarAtencion(BajaMedica.LugarAtencionEmergencia)
        End If
    End Sub

    Private Sub radiobuttonInternacion_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonInternacion.CheckedChanged
        If Not IsNothing(oBajaMedica) Then
            oBajaMedica.setLugarAtencion(BajaMedica.LugarAtencionInternacion)
        End If

    End Sub

    Private Sub rbuttonEnfermedadCom_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonEnfermedadCom.CheckedChanged
        If Not IsNothing(oBajaMedica) Then
            oBajaMedica.setRegimen(BajaMedica.RegimenEnfermedadComun)
        End If

    End Sub

    Private Sub rbuttonRiesgosLab_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonRiesgosLab.CheckedChanged
        If Not IsNothing(oBajaMedica) Then
            oBajaMedica.setRegimen(BajaMedica.RegimenRiesgosLaborales)
        End If

    End Sub

    Private Sub rbuttonMaternidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonMaternidad.CheckedChanged
        If Not IsNothing(oBajaMedica) Then
            oBajaMedica.setRegimen(BajaMedica.RegimenMaternidad)
        End If

    End Sub

    Private Sub rbuttonDomicilio_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonDomicilio.CheckedChanged
        If Not IsNothing(oBajaMedica) Then
            oBajaMedica.setTratamiento(BajaMedica.TratamientoDomicilio)
        End If

    End Sub

    Private Sub rbuttonHospitalizacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbuttonHospitalizacion.CheckedChanged
        If Not IsNothing(oBajaMedica) Then
            oBajaMedica.setTratamiento(BajaMedica.TratamientoHospitalizacion)
        End If

    End Sub

    Private Sub btnGuardarBajaMedica_Click(sender As Object, e As EventArgs) Handles btnGuardarBajaMedica.Click
        oBajaMedica.setMatriculaAsegurado(oRegistroBajaMed.oAsegurado.getMatricula())
        oBajaMedica.setInicioPeriodoIncapacidad(dTimeDesde.Value.ToString("yyyy-MM-dd"))
        oBajaMedica.setFinPeriodoIncapacidad(dTimeHasta.Value.ToString("yyyy-MM-dd"))
        oBajaMedica.setNroDias(numDias.Value)
        oBajaMedica.setDiasLiteral(txtDias.Text.ToUpper())
        oRegistroBajaMed.oBajaMedica = oBajaMedica
        guardarBajaMedica()
    End Sub

    Private Sub guardarBajaMedica()
        Dim mensaje As String = oRegistroBajaMed.validarEntradas()

        If mensaje = "" Then
            Dim respuesta = oRegistroBajaMed.guardarBajaMedica()

            If respuesta = 1 Then
                mostrarMensaje("La baja médica se guardó correctamente")
                reiniciarFormulario()
            Else
                mostrarMensaje("Error: La baja médica no se pudo guardar")
            End If

        Else
            mostrarMensaje(mensaje)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormMenuBajasMedicas.Show()
        Me.Close()
    End Sub


    Private Sub BtnCancelar2_Click(sender As Object, e As EventArgs) Handles BtnCancelar2.Click
        FormMenuBajasMedicas.Show()
        Me.Close()
    End Sub
End Class



