Public Class ListaEnlazadaTurnos

    Public raiz As NodoTurno


    Public Sub agregarNodo(ByRef _nuevoTurno As Turno)
        If raiz Is Nothing Then
            raiz = New NodoTurno()
            raiz.turno = _nuevoTurno
        Else
            Dim ultimoNodo As NodoTurno
            ultimoNodo = encontrarUltimoNodo()
            ultimoNodo.siguiente = New NodoTurno()
            ultimoNodo.siguiente.turno = _nuevoTurno
        End If
    End Sub

 
    Public Function encontrarUltimoNodo() As NodoTurno
        Dim nodoAcutal As NodoTurno
        nodoAcutal = raiz

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return nodoAcutal
    End Function

    Public Function traerTurno(ByVal _codigoTurno) As Turno
        Dim nodoAcutal As NodoTurno
        nodoAcutal = raiz

        While (nodoAcutal IsNot Nothing)
            If nodoAcutal.turno.getCodigo = _codigoTurno Then
                Return nodoAcutal.turno
            Else
                nodoAcutal = nodoAcutal.siguiente
            End If
        End While

        Return Nothing
    End Function

    Public Function traerTurnoPorIndex(ByVal _indexTurnoSeleccionado) As Turno
        Dim index As Int16 = 0
        Dim nodoAcutal As NodoTurno
        nodoAcutal = raiz

        While (nodoAcutal IsNot Nothing)
            If index = _indexTurnoSeleccionado Then
                Return nodoAcutal.turno
            Else
                nodoAcutal = nodoAcutal.siguiente
                index += 1
            End If

        End While

        Return Nothing

    End Function




End Class
