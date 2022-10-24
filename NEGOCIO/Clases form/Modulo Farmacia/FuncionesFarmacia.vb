Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Security.Cryptography

Public Class FuncionesFarmacia
    Private objDatos As DAL.TDatosSql 'se declara un objeto de conexion'
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub

    Public Function hayTraspasosPendiente()
        Return (objDatos.TraerDataTable("SPcontrarTraspasosEnEspera"))
    End Function
#Region "solicitudes"
#Region "Inventario"
    Public Function BuscarMedPorLiname(ByVal _nombre, ByVal _tipo) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _nombre + "%"
        P(1)=_tipo
        Return (objDatos.TraerDataTable("SP_I_TraerMedLiname", P))
    End Function
    Public Function TraerUltimoPrecio(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("TraerUltimoPrecio", P))
    End Function
    Public Function TraerPrecioLinameDB(ByVal _Liname) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _Liname
        Return objDatos.TraerDataTable("SPTraerPrecioMedicamentoLiname", P)
    End Function
    Public Function TraerLinameCompleto(ByVal _nombre, _Tipo) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _nombre + "%"
        P(1) = _Tipo
        Return (objDatos.TraerDataTable("SPTraerLinameCompleto", P))

    End Function
    Public Function TraerLinameCompletoInsumo(ByVal _nombre, _Tipo) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("SPTraerLinameCompletoInsumo", P))

    End Function
    Public Function TraerStockMedicamentos(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = "%" + _nombre + "%"
        Return (objDatos.TraerDataTable("SPTraerStockMedicamentos", P))
    End Function
    '---------------------------------------------------------------------------
    Public Function TraerSubMedicaentos(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("SPTraerSubMedicamentoPorLiname", P))
    End Function
    '------------------------------------------------------------------------------
    Public Function TraerLaboratorios(_nombre As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("SPTraerProveedor", P))
    End Function
    Public Function TraerTop20DB() As DataTable
        Return (objDatos.TraerDataTable("SPTraerTop20inventarios"))
    End Function
    Public Function TraerSubMedPorproveedor(_codProveedor As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codProveedor
        Return (objDatos.TraerDataTable("SPTraerMedPorProveedor", P))
    End Function
    Public Function TraerEstado() As DataTable
        Return (objDatos.TraerDataTable("SPTraerEstadosMed"))
    End Function
    Public Function TraerArea() As DataTable
        Return (objDatos.TraerDataTable("SPTraerAreasMed"))
    End Function
    Public Function TraeLinamePorCodSM(_codSubmedicamento As String) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _codSubmedicamento
        Return objDatos.TraerDataTable("SPTaerLinamePorCodSubMedicamento", P)
    End Function

#End Region
#Region "SubMedicamento"
    Public Function BuscarProveedorQueNoTengaMedicmanteoigualDelLiname(ByVal _Liname As String, ByVal _Nombre As String) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _Liname
        P(1) = _Nombre + "%"
        Return (objDatos.TraerDataTable("SPTraerProveedoresQuenotenganesteliname", P))
    End Function
    Public Function ActualizarEstadoMedicamentoLiname(ByVal _Liname, _CodUsuario) As Int16
        Dim P As Object() = New Object(1) {}
        P(0) = _Liname
        P(1) = _CodUsuario
        Return (objDatos.Ejecutar("SPActualizarEstadoLiname", P))
    End Function
    Public Function TraerTipo(ByVal _NombreTipo As String)
        Dim P As Object() = New Object(0) {}
        P(0) = _NombreTipo + "%"
        Return (objDatos.TraerDataTable("SPtraerTiposMedicamentos", P))
    End Function
#End Region
#Region "Traspasos"
    Public Function TraerAlmacenes() As DataTable
        Return objDatos.TraerDataTable("SPTraerAlmacenes")
    End Function
    Public Function TraerInventario(ByVal _almacen, ByVal _nombre) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _almacen
        P(1) = _nombre + "%"
        Return objDatos.TraerDataTable("SPTraerInventario", P)
    End Function
    Public Function TraerInventarioPoriD(ByVal _Id) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _Id
        Return objDatos.TraerDataTable("SPTraerInventarioPorID", P)
    End Function
    Public Function ObtenerCodigoDelUltimoRegistro()
        Return objDatos.TraerDataTable("SPCodUltimoTraspaso")
    End Function
#End Region
#Region "Receta"
    Public Function BuscarPaciente(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("spBuscarPorNombre", P))
    End Function
    Public Function BuscarPacienteporMatricula(ByVal _matricula) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDatos.TraerDataTable("SPBuscarPacientePorMatricula", P))
    End Function
    Public Function CarcarMedicamentos(ByVal _nombre) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _nombre + "%"
        Return (objDatos.TraerDataTable("SPTraerInventarioAlm50", P))
    End Function
    Public Function TraerCantidadPorId(ByVal _id) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _id
        Return (objDatos.TraerDataTable("SPTraerCantidadPorId", P))
    End Function
    Public Function ObtenerProximoRegistro()
        Return objDatos.TraerDataTable("TraerProximoRegistro")
    End Function

    '---------------------------Emision de farmacos--------------------------------------------
    Public Function TraerCabeceraDereceta(ByVal _CodReceta) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _CodReceta
        Return (objDatos.TraerDataTable("SPBuscarReceta", P))
    End Function
    Public Function TraerDetalleDereceta(ByVal _CodReceta) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _CodReceta
        Return (objDatos.TraerDataTable("SPBuscarDetalleReceta", P))
    End Function
    Public Function ActualizarEstadoReceta(ByVal _codReceta, ByVal _Estado, ByVal _codFarmacieutica) As Short
        Dim P As Object() = New Object(2) {}
        P(0) = _codReceta
        P(1) = _Estado
        P(2) = _codFarmacieutica
        Return (objDatos.Ejecutar("SPActualizarEstadoReceta", P))
    End Function
    Public Function Verificarshoa(ByVal _id, ByVal _liname) As DataTable
        Dim P As Object() = New Object(1) {}
        P(0) = _id
        P(1) = _liname
        Return (objDatos.TraerDataTable("SPVerificarSiHayOtroActivo", P))
    End Function
    Public Function reinsertarProductosAlinventario(ByVal _id, ByVal _cant, ByVal _Estado) As Short
        Dim P As Object() = New Object(2) {}
        P(0) = _id
        P(1) = _cant
        p(2) = _Estado
        Return (objDatos.Ejecutar("SPActualizarInventarioAdicion", P))
    End Function
    Public Function traerLinamePorID(ByVal _id) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _id
        Return (objDatos.TraerDataTable("SPTraerLinamePorID", P))
    End Function

    Public Function TraerInventarioActivoDel50(ByVal _liname) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _liname + "%"
        Return (objDatos.TraerDataTable("SPtraerInventario50completo", P))
    End Function





#End Region
#End Region
#Region "envios"
#Region "Inventario"
    Public Function GuardarInventario(ByRef _Farmaco As ConstructorDeInventarioFarmaco) As Short

        Dim P As Object() = New Object(10) {}
        P(0) = _Farmaco.getcodLiname()
        P(1) = _Farmaco.getSubmedicamento()
        P(2) = _Farmaco.getcantidad()
        P(3) = _Farmaco.getcantidad()
        P(4) = _Farmaco.getprecio()
        P(5) = _Farmaco.getfechaVencimento()
        P(6) = _Farmaco.getArea()
        P(7) = _Farmaco.getcodUsuario()
        P(8) = _Farmaco.getLote()
        P(9) = _Farmaco.getCodBarra()
        P(10) = _Farmaco.getEstado()

        Dim respuesta As Int16 = 0
        respuesta = objDatos.Ejecutar("SPInsertarInventario", P)
        Return respuesta

    End Function 'ya no se toca
#End Region
#Region "SubProductos"
    Public Function GuardarNuevoInsumo(_newInsumo As ConstructorDeSubProducto) As Short
        Dim P As Object() = New Object(2) {}
        P(0) = _newInsumo.getcodLiname()
        P(1) = _newInsumo.GetNombre()
        P(2) = _newInsumo.GetCodUsuario()
        Dim respuesta As Int16 = 0
        respuesta = objDatos.Ejecutar("SPInsertarNuevoInsumo", P)
        Return respuesta
    End Function
    Public Function GuardarNuevoSubMedicamento(ByRef _NewSubMedicamento As ConstructorDeSubProducto) As Short
        Dim respuesta As Int16 = 0
        respuesta = InsertarNuevoSubMedicamentoDB(_NewSubMedicamento)
        Return respuesta
    End Function


    Private Function InsertarNuevoSubMedicamentoDB(_newSubMedicamento As ConstructorDeSubProducto) As Short
        Dim P As Object() = New Object(5) {}
        P(0) = _newSubMedicamento.getcodLiname()
        P(1) = _newSubMedicamento.GetNombre()
        P(2) = _newSubMedicamento.GetTipo()
        P(3) = _newSubMedicamento.GetCodProveedor()
        P(4) = _newSubMedicamento.GetCodUsuario()
        Dim respuesta As Int16 = 0
        respuesta = objDatos.Ejecutar("SPInsertarNuevoSubMedicamento", P)
        Return respuesta
    End Function

    Public Function GuardarProveedor(ByRef _proveedor As ConstructorProveedor) As Short
        Dim respuesta As Int16 = 0
        respuesta = InsertarNewProveedorDB(_proveedor)
        Return respuesta
    End Function
    Private Function InsertarNewProveedorDB(ByRef _proveedor As ConstructorProveedor) As Short

        Dim P As Object() = New Object(3) {}
        P(0) = _proveedor.GetNombre()
        P(1) = _proveedor.GetEstardo()
        P(2) = _proveedor.GetCoUsuario()
        Dim respuesta As Int16 = 0
        respuesta = objDatos.Ejecutar("SPInsertarProveedor", P)
        Return respuesta

    End Function

    Public Function ObtenerCodigoDelUtlimoRegistro() As DataTable
        Throw New NotImplementedException()
    End Function

#End Region
#Region "Traspasos"
    Public Function GuardarCabecera(ByRef _NuevaCabeza As ConstructorTraspaso) As Short
        Dim respuesta As Int16 = 0
        Dim P As Object() = New Object(2) {}
        P(0) = _NuevaCabeza.GetCodAlmEmisor()
        P(1) = _NuevaCabeza.GetCodAlmRecept()
        P(2) = _NuevaCabeza.GetUsuEmisor()
        respuesta = objDatos.Ejecutar("SPInsertarCabecezaTraspasoEmisor", P)
        Return respuesta
    End Function
    Public Function InsertarInventarioTraspaso(ByRef _nuevoInventario As ConstructorDeInventarioFarmaco) As Short
        Dim respuesta As Int16 = 0
        Dim P As Object() = New Object(12) {}
        P(0) = _nuevoInventario.getcodLiname()
        P(1) = _nuevoInventario.getSubmedicamento()
        P(2) = _nuevoInventario.getcantidad()
        P(3) = _nuevoInventario.getcantidad()
        P(4) = _nuevoInventario.getprecio()
        P(5) = _nuevoInventario.GetAlmacen()
        P(6) = _nuevoInventario.getcodUsuario()
        P(7) = _nuevoInventario.getArea()
        P(8) = _nuevoInventario.getLote()
        P(9) = _nuevoInventario.getCodBarra()
        P(10) = 4
        P(11) = _nuevoInventario.getfechaVencimento()
        P(12) = _nuevoInventario.GetCT
        respuesta = objDatos.Ejecutar("SPInsertarInventarioporTraspaso", P)
        Return respuesta
    End Function

    Public Function actualizarCantidades(ByVal _Cantidad As Long, ByVal _Id As Long) As Short
        Dim respuesta As Int16 = 0
        Dim P As Object() = New Object(1) {}
        P(0) = _Cantidad
        P(1) = _Id
        respuesta = objDatos.Ejecutar("SPActualizarCantidadPortraspaso", P)
        Return respuesta
    End Function
    Public Function actualizaraAgotado(ByVal _Id As Long) As Short
        Dim respuesta As Int16 = 0
        Dim P As Object() = New Object(0) {}
        P(0) = _Id
        respuesta = objDatos.Ejecutar("SPActualizarEstadoaAgotado", P)
        Return respuesta
    End Function
#End Region
#Region "Recepcion"
    Public Function ObtenerListaDeTraspasosEnEspera(ByVal _almacen) As DataTable

        Dim P As Object() = New Object(0) {}
        P(0) = _almacen
        Return objDatos.TraerDataTable("SPTraerListaDeTraspasosEnEspera", P)
    End Function
    Public Function ObtenerDetalleDelTraspaso(ByVal _codTraspaso) As DataTable

        Dim P As Object() = New Object(0) {}
        P(0) = _codTraspaso
        Return objDatos.TraerDataTable("SpTraerListaDeDatosDelTraspaso", P)
    End Function


    Public Function ActualizarTablaDeTraspasos(ByVal _codTraspaso, _Estado, _observacion, _codUsuario) As Int16
        Dim P As Object() = New Object(3) {}
        P(0) = _codTraspaso
        P(1) = _Estado
        P(2) = _observacion
        P(3) = _codUsuario
        Return (objDatos.Ejecutar("SPActualizarEstadoTraspaso", P))
    End Function

    Public Function ActualizarestadoDEldetalle(ByVal _Id, _estadoI, _estadoT, _almacen) As Int16
        Dim P As Object() = New Object(3) {}
        P(0) = _Id
        P(1) = _estadoI
        P(2) = _estadoT
        P(3) = _almacen
        Return (objDatos.Ejecutar("SpActualizarEstadoDetalleTraspaso", P))
    End Function
#End Region
#Region "Recetas"
    '---------------------------Ingresando Datos-----------------------------------------------
    Public Function GuardarCabeceraReceta(ByVal _codMed, ByVal _codPas) As Short

        Dim P As Object() = New Object(1) {}
        P(0) = _codMed
        P(1) = _codPas
        Dim respuesta As Int16 = 0
        respuesta = objDatos.Ejecutar("InsertarCabeceraReceta", P)
        Return respuesta
    End Function
    Public Function ActualizarInventario(ByVal _Id, ByVal _Cantidad, ByVal _estado)
        Dim P As Object() = New Object(2) {}
        P(0) = _Id
        P(1) = _Cantidad
        P(2) = _estado
        Return objDatos.Ejecutar("SPActualizarInventarioRetiro", P)
    End Function
    Public Function GuardarDetReceta(ByVal _codR, ByVal _id, ByVal _nombre, ByVal _Cantidad, ByVal _indicaciones) As Short

        Dim P As Object() = New Object(4) {}
        P(0) = _codR
        P(1) = _id
        P(2) = _nombre
        P(3) = _Cantidad
        P(4) = _indicaciones
        Dim respuesta As Int16 = 0
        respuesta = objDatos.Ejecutar("SPInsertarDetalleReceta", P)
        Return respuesta
    End Function
#End Region
#End Region



End Class
