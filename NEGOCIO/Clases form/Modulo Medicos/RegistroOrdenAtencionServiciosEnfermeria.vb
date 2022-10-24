Public Class RegistroOrdenAtencionEnfermeria

    Private objDAL As DAL.TDatosSql = New DAL.TDatosSql(False)
    Public listaServiciosEnfermeria() As Concepto
    Public serviciosSeleccionadas() As Concepto
    Public listaDetalles As DetalleOrdenAtencion()
    Public obOrdenAteEnf As OrdenAtencionEnfermeria = New OrdenAtencionEnfermeria()



    'METODOS FUNCIONALES
    Public Sub traerServiciosEnfermeria()
        Dim objDTable As DataTable
        Dim index As Int16
        objDTable = traerServiciosEnfermeriaBD()
        listaServiciosEnfermeria = New Concepto(objDTable.Rows.Count - 1) {}

        index = 0
        For Each row As DataRow In objDTable.Rows
            Dim prefijo As Int16 = Integer.Parse(row("PREFIJO"))
            Dim correlativo As Int16 = Integer.Parse(row("CORRELATIVO"))
            Dim descripcion As String = row("DESCRIPCION").ToString()

            Dim objServicioEnfemeria As Concepto
            objServicioEnfemeria = New Concepto(prefijo, correlativo, descripcion)

            listaServiciosEnfermeria(index) = objServicioEnfemeria
            index += 1
        Next
    End Sub

    Public Function buscarServicio(ByVal _servicioSeleccionado As String) As Concepto
        For Each servicio As Concepto In listaServiciosEnfermeria
            If servicio.getDescripcion() = _servicioSeleccionado Then
                Return servicio
            End If
        Next

        Return Nothing

    End Function

    Public Function obtenerCodServicio(ByVal _nombreServicio As String)
        For Each servicio As Concepto In serviciosSeleccionadas
            If _nombreServicio = servicio.getDescripcion() Then
                Return servicio.getCorrelativo()
            End If
        Next

        Return 0
    End Function

    Public Function guardarOrden(ByVal _matriculaAsegurado, ByVal _codigoMedico,
                                    ByVal _tipoServicio, ByVal _codigoOrden,
                                    ByVal _codUsuario) As Int16

        Dim idOrden As Int16 = 0
        Dim objDTable As DataTable
        objDTable = guardarOrdenAtencionBD(_matriculaAsegurado, _codigoMedico, _tipoServicio, _codigoOrden, _codUsuario)

        For Each row As DataRow In objDTable.Rows
            idOrden = Integer.Parse(row("CODIGO ORDEN"))
        Next

        Return idOrden
    End Function

    Public Function guardarDetalles() As Int16
        Dim respuesta As Int16 = 0

        For Each detalleOrdenServicio As DetalleOrdenAtencion In listaDetalles
            If Not IsNothing(detalleOrdenServicio) Then
                respuesta = guardarDetalleOrdenBD(detalleOrdenServicio)
            End If
        Next

        Return respuesta
    End Function

    Public Function validarDetalle(ByRef _oDetalle As DetalleOrdenAtencion) As String
        Dim respuesta As String = ""

        respuesta = validarDetalleDescripcion(_oDetalle.getDescripcion())
        If Not respuesta = "" Then
            Return respuesta
        End If


        respuesta = validarDetalleCantidad(_oDetalle.getCantidad())
        If Not respuesta = "" Then
            Return respuesta
        End If

        Return ""
    End Function

    Private Function validarDetalleCantidad(ByVal _cantidad As String) As String
        For Each caracter As Char In _cantidad
            If Not caracter = "0" And Not caracter = "1" And Not caracter = "2" And Not caracter = "3" And Not caracter = "4" And Not caracter = "5" And Not caracter = "6" And Not caracter = "7" And Not caracter = "8" And Not caracter = "9" Then
                Return "Error: La cantidad debe ser un valor numerico"
            End If
        Next

        If _cantidad = "0" Then
            Return "Error: La cantidad del servicio no puede ser 0. Ingrese un número mayor"
        End If

        If _cantidad = "" Then
            Return "Error. La cantidad no se puede dejar vacía. Ingrese una cantidad"
        End If

        Return ""

    End Function

    Private Function validarDetalleDescripcion(ByVal _descripcion As String) As String
        If _descripcion.Length > 50 Then
            Return "Error. La descripción sólo puede contener 50 caracteres como máximo"
        End If

        If _descripcion = "" Then
            Return "Error. La descripción no se puede dejar vacía. Ingrese una descripción"
        End If

        Return ""

    End Function





    'METODOS QUE USAN BD
    Private Function traerServiciosEnfermeriaBD() As DataTable
        Return (objDAL.TraerDataTable("SPtraerServiciosEnfermeria"))
    End Function

    Private Function guardarOrdenAtencionBD(ByVal _matriculaAsegurado, ByVal _codigoMedico,
                                    ByVal _tipoServicio, ByVal _codigoOrden,
                                    ByVal _codUsuario) As DataTable

        Dim P As Object() = New Object(4) {}
        P(0) = _matriculaAsegurado
        P(1) = _codigoMedico
        P(2) = _tipoServicio
        P(3) = _codUsuario
        P(4) = _codigoOrden

        Return (objDAL.TraerDataTable("SPguardarOrdenAtencion", P))
    End Function

    Private Function guardarDetalleOrdenBD(ByRef _oDetalle As DetalleOrdenAtencion) As Int16
        Dim P As Object() = New Object(4) {}
        P(0) = _oDetalle.getCodigoOrden()
        P(1) = _oDetalle.getCodigoDetalle()
        P(2) = _oDetalle.getCorrelativoServicio()
        P(3) = _oDetalle.getCantidad()
        P(4) = _oDetalle.getDescripcion()


        Dim respuesta As Int16 = 0
        respuesta = objDAL.Ejecutar("SPguardarDetalleOrdenAtencion", P)
        Return respuesta
    End Function

End Class




