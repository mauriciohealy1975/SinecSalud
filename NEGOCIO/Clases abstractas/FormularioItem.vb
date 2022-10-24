Imports System.Windows.Forms

Public Class FormularioItem

    Private form As Form
    Private guardado As Boolean
    Private resultado As String

    Public Sub New()
        form = New Form()
        guardado = False
        resultado = ""
    End Sub



    Public Sub setForm(_form As Form)
        form = _form
    End Sub

    Public Function getForm() As Form
        Return form
    End Function



    Public Sub setGuardado(_guardado As Boolean)
        guardado = _guardado
    End Sub

    Public Function getGuardado() As Boolean
        Return guardado
    End Function



    Public Sub setResultado(_resultado As String)
        resultado = _resultado
    End Sub

    Public Function getResultado() As String
        Return resultado
    End Function



End Class
