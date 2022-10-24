Public Class ListaEnlazadaBeneficiarios

    Public raiz As NodoBeneficiario


    Public Sub agregarNodo(ByRef _nuevoBeneficiario As Beneficiario)
        If raiz Is Nothing Then
            raiz = New NodoBeneficiario()
            raiz.beneficiario = _nuevoBeneficiario
        Else
            Dim ultimoNodo As NodoBeneficiario
            ultimoNodo = encontrarUltimoNodo()
            ultimoNodo.siguiente = New NodoBeneficiario()
            ultimoNodo.siguiente.beneficiario = _nuevoBeneficiario
        End If
    End Sub

    Public Function encontrarUltimoNodo() As NodoBeneficiario
        Dim nodoAcutal As NodoBeneficiario
        nodoAcutal = raiz

        While (nodoAcutal.siguiente IsNot Nothing)
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return nodoAcutal
    End Function

    Public Function encontrarDimension() As Int16
        Dim nodoAcutal As NodoBeneficiario = raiz,
            contador As Int16 = 0

        While nodoAcutal IsNot Nothing
            contador += 1
            nodoAcutal = nodoAcutal.siguiente
        End While

        Return contador
    End Function

    Public Sub eliminarNodo(ByVal _matricula As String)
        'eliminar al principio
        Dim matricula As String = raiz.beneficiario.getMatricula()
        If matricula = _matricula Then
            raiz = raiz.siguiente
        End If



        'eliminar al medio y al final
        Dim nodoAnterior As NodoBeneficiario = encontrarNodoAnterior(_matricula)
        If nodoAnterior IsNot Nothing Then
            nodoAnterior.siguiente = nodoAnterior.siguiente.siguiente
        End If

    End Sub

    Private Function encontrarNodoAnterior(ByVal _matricula As String) As NodoBeneficiario
        Dim nodoActual As NodoBeneficiario = raiz
        Dim nodoAnterior As NodoBeneficiario = nodoActual

        While nodoActual IsNot Nothing
            Dim matriculaActual As String = nodoActual.beneficiario.getMatricula()

            If matriculaActual = _matricula Then
                Return nodoAnterior
            Else
                nodoAnterior = nodoActual
                nodoActual = nodoActual.siguiente
            End If
        End While


        Return Nothing
    End Function

    Public Sub vaciarLista()
        raiz = Nothing
    End Sub






End Class
