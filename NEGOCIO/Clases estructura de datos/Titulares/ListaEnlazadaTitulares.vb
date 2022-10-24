Public Class ListaEnlazadaTitulares

    Public raiz As NodoTitular

    Public Sub agregarNodo(ByRef _nuevoTitular As Titular)
        If raiz Is Nothing Then
            raiz = New NodoTitular()
            raiz.titular = _nuevoTitular
        Else
            Dim ultimoNodo As NodoTitular
            ultimoNodo = encontrarUltimoNodo()
            ultimoNodo.siguiente = New NodoTitular()
            ultimoNodo.siguiente.titular = _nuevoTitular
        End If
    End Sub

    Public Function encontrarUltimoNodo() As NodoTitular
        Dim nodoAcutal As NodoTitular
        nodoAcutal = raiz

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return nodoAcutal
    End Function

    Public Function encontrarDimension() As Int16
        Dim nodoAcutal As NodoTitular = raiz, contador As Int16 = 0

        If nodoAcutal IsNot Nothing Then contador = 1 Else Return 0

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
            contador += 1
        End While

        Return contador
    End Function

    Public Sub eliminarNodo(ByVal _matricula As String)
        Dim nodoAcutal As NodoTitular = raiz
        Dim nodoAnterior As NodoTitular = nodoAcutal


        'eliminar al principio
        If nodoAcutal.titular.getMatricula() = _matricula Then
            raiz = raiz.siguiente
            Return
        Else
            nodoAnterior = nodoAcutal
            nodoAcutal = nodoAcutal.siguiente
        End If


        'eliminar al medio  y al final
        While True
            If Not nodoAcutal.titular.getMatricula() = _matricula Then
                nodoAnterior = nodoAcutal
                nodoAcutal = nodoAcutal.siguiente

            Else
                nodoAnterior = nodoAcutal.siguiente
                nodoAcutal = Nothing
                Exit While
            End If
        End While

    End Sub

    Private Function encontrarNodoAnteriorDelNodoParaEliminar(ByVal _matricula As String) As NodoTitular
        Dim nodoAcutal As NodoTitular = raiz
        Dim nodoAnterior As NodoTitular = nodoAcutal


        While nodoAcutal IsNot Nothing
            If Not nodoAcutal.titular.getMatricula() = _matricula Then Return nodoAcutal Else nodoAcutal = nodoAcutal.siguiente
        End While

        Return Nothing
    End Function

End Class
