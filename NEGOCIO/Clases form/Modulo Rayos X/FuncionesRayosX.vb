Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports System.Xml.Schema

Public Class FuncionesRayosX
    Private ReadOnly objDatos As DAL.TDatosSql 'se declara un objeto de conexion'
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub
#Region "Solicitudes"
#Region "Medico"
    Public Function BuscarPaciente(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("spBuscarPorNombre", P))
    End Function
    Public Function BuscarPacienteporCodigo(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("SPBuscarPacientePorMatricula", P))
    End Function
    '--------------------------------------------------------------------------------
    Public Function BuscarYTraerTiposDeRadiografia(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("SPTraerTiposdeExamenesRX", P))
    End Function

    Public Function TraerEdadPaciente(ByVal _matricula) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDatos.TraerDataTable("SPTraerTiposdeExamenesRX", P))
    End Function
    Public Function ObtenerEdad(_matricula) As Int16
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Dim tabla As DataTable
        Dim fechaNacimiento As Date

        Dim hoy As Date = Today
        Dim anhohoy As Int16 = Convert.ToInt16(Year(hoy))
        Dim meshoy As Int16 = Convert.ToInt16(Month(hoy))
        Dim edadenmeses As Double
        tabla = (objDatos.TraerDataTable("obtenerfechanacimientopormatricula", P))

        Dim row As DataRow

        If (tabla.Rows.Count > 0) Then
            row = tabla.Rows.Item(0)
            fechaNacimiento = Convert.ToString(row("FechaNacimiento"))
        End If


        Dim anho As Int16 = Convert.ToInt16(Year(fechaNacimiento))
        If anho < anhohoy Then
            edadenmeses = (Year(hoy) - anho) * 12
            Dim mescumpleaño As Int16 = Convert.ToInt16(Month(fechaNacimiento))
            'If mescumpleaño > meshoy Then
            '    Dim diferencia = meshoy - mescumpleaño
            '    edadenmeses = (edadenmeses - diferencia)
            'End If
        Else
            edadenmeses = Month(fechaNacimiento)
        End If
        Return CInt(edadenmeses)
    End Function
    Public Function ObtenerProximoRegistro()
        Dim tabla As DataTable
        Dim row As DataRow
        Dim proximoregistro
        tabla = (objDatos.TraerDataTable("obtenersigRegistroRayosX"))
        If (tabla.Rows.Count > 0) Then
            row = tabla.Rows.Item(0)
            proximoregistro = Convert.ToString(row("ProximoRegistro"))
            Return proximoregistro
        End If
        Return 0
    End Function





#End Region
#Region "Radiologo"
    Public Function ObtenerSolicitudesdeRadiologia(ByVal _nombre, _estado)
        Dim P As Object() = New Object(1) {}
        P(0) = "%" + _nombre + "%"
        P(1) = _estado
        Return (objDatos.TraerDataTable("SPTraerSolicitudesDeRayosXporNombre", P))
    End Function
    Public Function ObtenerImg(ByVal _idCabeza, _idDetalle)
        Dim P As Object() = New Object(1) {}
        P(0) = _idCabeza
        P(1) = _idDetalle
        Return (objDatos.TraerDataTable("SpObtenerImagenDB", P))
    End Function
    Public Function ObtenerDetalleRX(ByVal _ID)
        Dim p As Object() = New Object(0) {}
        p(0) = _ID
        Return (objDatos.TraerDataTable("SPTraerDetalleSolicitudRayosX", p))

    End Function
    Public Function ObtenerTamañosRx()
        Return (objDatos.TraerDataTable("SpObtenerTamaños"))
    End Function
#End Region

#End Region
#Region "Envios"
#Region "Medico"
    Public Function RegistrarCabezaRX(ByVal _codPaciente, _codMedico, _codRegistro)
        Dim P As Object() = New Object(3) {}
        P(0) = _codPaciente
        P(1) = _codMedico
        P(2) = _codRegistro
        P(3) = _codMedico
        Dim respuesta As Short = objDatos.Ejecutar("SPGuardarCabeceraRayosx", P)
        Return respuesta
    End Function
    Public Function RegistrarDetalleRayosX(ByVal _codproximo, ByVal _nombre, ByVal _cant)
        Dim P As Object() = New Object(2) {}
        P(0) = _codproximo
        P(1) = _nombre
        P(2) = _cant
        Dim respuesta As Short = objDatos.Ejecutar("SPGuardarDetalleRayosX", P)
        Return respuesta
    End Function
#End Region

#Region "Radiologo"
    Public Function CancelarSolicitud(ByVal _id, _estado)
        Dim P As Object() = New Object(2) {}
        P(0) = _id
        P(1) = _estado
        Dim respuesta As Short = objDatos.Ejecutar("actualizarEstadocRX", P)
        Return respuesta
    End Function

    Public Function Guardar(ByVal _codcabeza, _codTabla, _nombre, _tamaño, _contenido, _extension)
        Dim P As Object() = New Object(5) {}
        P(0) = _codcabeza
        P(1) = _codTabla
        P(2) = _nombre
        P(3) = _tamaño
        P(4) = _contenido
        P(5) = _extension
        Dim respuesta As Short = objDatos.Ejecutar("SPGuardarImagenRx", P)
        Return respuesta
    End Function

    Public Function CambiarETDetallePorId(ByVal _id, _estado)
        Dim P As Object() = New Object(1) {}
        P(0) = _id
        P(1) = _estado
        Dim respuesta As Short = objDatos.Ejecutar("SPActualizarED", P)
        Return respuesta
    End Function
    Public Function BorrarImagenesCanceladas(ByVal _idc)
        Dim P As Object() = New Object(0) {}
        P(0) = _idc
        Dim respuesta As Short = objDatos.Ejecutar("SPCancelarSubidaArvivos", P)
        Return respuesta
    End Function
#End Region
#End Region
End Class
