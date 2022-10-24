Public Class ListaEnlazadaAvisosAfiliacion

    Public raiz As NodoAvisoAfiliacion


    Public Sub agregarNodo(ByRef _nuevoAviso As AvisoAfiliacion)
        If raiz Is Nothing Then
            raiz = New NodoAvisoAfiliacion()
            raiz.aviso = _nuevoAviso
        Else
            Dim ultimoNodo As NodoAvisoAfiliacion
            ultimoNodo = encontrarUltimoNodo()
            ultimoNodo.siguiente = New NodoAvisoAfiliacion()
            ultimoNodo.siguiente.aviso = _nuevoAviso
        End If
    End Sub

    Public Function encontrarUltimoNodo() As NodoAvisoAfiliacion
        Dim nodoAcutal As NodoAvisoAfiliacion
        nodoAcutal = raiz

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return nodoAcutal
    End Function

    Public Function encontrarDimension() As Int16
        Dim nodoAcutal As NodoAvisoAfiliacion = raiz, contador As Int16 = 0

        If nodoAcutal IsNot Nothing Then contador = 1 Else Return 0

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
            contador += 1
        End While

        Return contador
    End Function

    Public Sub eliminarNodo(ByVal _matricula As String)
        'eliminar al principio
        Dim matricula As String = raiz.aviso.getAsegurado().getMatricula()
        If matricula = _matricula Then
            raiz = raiz.siguiente
        End If


        'eliminar al medio  y al final
        Dim nodoAnterior As NodoAvisoAfiliacion = encontrarNodoAnterior(_matricula)
        If nodoAnterior IsNot Nothing Then
            nodoAnterior.siguiente = nodoAnterior.siguiente.siguiente
        End If
    End Sub

    Private Function encontrarNodoAnterior(ByVal _matricula As String) As NodoAvisoAfiliacion
        Dim nodoActual As NodoAvisoAfiliacion = raiz
        Dim nodoAnterior As NodoAvisoAfiliacion = nodoActual

        While nodoActual IsNot Nothing
            Dim matriculaActual As String = nodoActual.aviso.getAsegurado().getMatricula()

            If matriculaActual = _matricula Then
                Return nodoAnterior
            Else
                nodoAnterior = nodoActual
                nodoActual = nodoActual.siguiente
            End If
        End While


        Return Nothing
    End Function



End Class
