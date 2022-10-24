Public Class Beneficiario
    Inherits Asegurado

    Private matriculaTitular As String = ""
    Private titular As Titular
    Private parentesco As Concepto
    Private oficilia As String
    Private nroLibro As String
    Private partida As String
    Private folio As String
    Private declaracionJurada As String
    Private notaria As String
    Private motivoBaja As Concepto
    Private nroFormulario As Int64




    'CONTRUSCTOR
    Sub New()
    End Sub

    Public Sub New(ByVal _nombre As String, ByVal _matricula As String, ByVal _tipo As String)
        MyBase.New(_nombre, _matricula, _tipo)
    End Sub

    Public Sub New(ByVal _codigo As Int64, ByVal _apPaterno As String, ByVal _apMaterno As String, ByVal _nombres As String,
                    ByVal _matricula As String)

        codigo = _codigo
        apellidoPaterno = _apPaterno
        apellidoMaterno = _apMaterno
        nombres = _nombres
        matricula = _matricula
    End Sub



    'GETTERS Y SETTERS
    Public Sub setMatTitular(ByVal _matTitular)
        matriculaTitular = _matTitular
    End Sub

    Public Function getMatriculaTitular() As String
        Return matriculaTitular
    End Function



    Public Sub setTitular(ByVal _titular As Titular)
        titular = _titular
    End Sub

    Public Function getTitular() As Titular
        Return titular
    End Function



    Public Sub setParentesco(ByRef _parentesco As Concepto)
        parentesco = _parentesco
    End Sub

    Public Function getParentesco() As Concepto
        Return parentesco
    End Function



    Public Sub setOficilia(ByVal _oficialia As String)
        oficilia = _oficialia
    End Sub

    Public Function getNroOficialia() As String
        Return oficilia
    End Function



    Public Sub setNroLibro(ByVal _nroLibro As String)
        nroLibro = _nroLibro
    End Sub

    Public Function getNroLibro() As String
        Return nroLibro
    End Function



    Public Sub setPartida(ByVal _partida As String)
        partida = _partida
    End Sub

    Public Function getNroPartida() As String
        Return partida
    End Function



    Public Sub setFolio(ByVal _folio As String)
        folio = _folio
    End Sub

    Public Function getNroFolio() As String
        Return folio
    End Function



    Public Sub setDeclaracionJurada(ByVal _declaracionJurada As String)
        declaracionJurada = _declaracionJurada
    End Sub

    Public Function getNroDeclaracionJurada() As String
        Return declaracionJurada
    End Function



    Public Sub setNotaria(ByVal _notaria As String)
        notaria = _notaria
    End Sub

    Public Function getNroNotaria() As String
        Return notaria
    End Function



    Public Sub setMotivoBaja(ByRef _motivoBaja As Concepto)
        motivoBaja = _motivoBaja
    End Sub

    Public Function getMotivoBaja() As Concepto
        Return motivoBaja
    End Function



    Public Sub setNroFormulario(ByVal _nroFormulario As Int64)
        nroFormulario = _nroFormulario
    End Sub

    Public Function getNroFormulario() As Int64
        Return nroFormulario
    End Function




End Class
