Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates

Public Class FuncionesOdontologia
    Private ReadOnly objDatos As DAL.TDatosSql 'se declara un objeto de conexion'
    Public Sub New(ByVal Restauracion As Boolean)
        objDatos = New DAL.TDatosSql(Restauracion)
    End Sub

#Region "Solicitudes"
    Public Function BuscarHCO(ByVal _matricula) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _matricula
        Return (objDatos.TraerDataTable("BuscarHCO", P))
    End Function

    Public Function BuscarCI(ByVal _mat) As DataTable
        Dim P As Object() = New Object(0) {}
        P(0) = _mat
        Return (objDatos.TraerDataTable("TraerCI", P))
        'enves de traer datatable es consultar
    End Function

    Public Function EviarDatosHCO(ByVal _nhco, ByVal _ldn, ByVal _gdi, ByVal _mtr, ByVal _tra, ByVal _medi, ByVal _hemr,
                                  ByVal _espef, ByVal _obser, ByVal _atm, ByVal _ganlin, ByVal _resp, ByVal _otsapp, ByVal _labi,
                                  ByVal _lengu, ByVal _palad, ByVal _psboc, ByVal _musyu, ByVal _encs, ByVal _prote, ByVal _algs,
                                  ByVal _enbarz, ByVal _sems, ByVal _uticd, ByVal _utichd, ByVal _utieb, ByVal _frecc, ByVal _senci,
                                  ByVal _higib, ByVal _apf, ByVal _app, ByVal _otreoo, ByVal _fchhco)

        Dim P As Object() = New Object(32) {}
        P(0) = _nhco
        P(1) = _ldn
        P(2) = _gdi
        P(3) = _mtr
        P(4) = _tra
        P(5) = _medi
        P(6) = _hemr
        P(7) = _espef
        P(8) = _obser
        P(9) = _atm
        P(10) = _ganlin
        P(11) = _resp
        P(12) = _otsapp
        P(13) = _labi
        P(14) = _lengu
        P(15) = _palad
        P(16) = _psboc
        P(17) = _musyu
        P(18) = _encs
        P(19) = _prote
        P(20) = _algs
        P(21) = _enbarz
        P(22) = _sems
        P(23) = _uticd
        P(24) = _utichd
        P(25) = _utieb
        P(26) = _frecc
        P(27) = _senci
        P(28) = _higib
        P(29) = _apf
        P(30) = _app
        P(31) = _otreoo
        P(32) = _fchhco
        Return (objDatos.Ejecutar("isertarHCO", P))
    End Function

    Public Function EnviarATMO(ByVal _ip, _nhco, _subj, _objv, _anals, _plnac, _refe, _cnrefe,
                               _fechre, _fechcre, _matric)
        Dim P As Object() = New Object(10) {}
        P(0) = _ip
        P(1) = _nhco
        P(2) = _subj
        P(3) = _objv
        P(4) = _anals
        P(5) = _plnac
        P(6) = _refe
        P(7) = _cnrefe
        P(8) = _fechre
        P(9) = _fechcre
        P(10) = _matric
        Return (objDatos.Ejecutar("instATMO", P))

    End Function

#End Region
#Region "Envios"

#End Region
End Class
