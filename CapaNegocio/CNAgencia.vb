Imports System.Data
Imports CapaDatos
Imports CapaEntidad

Public Class CNAgencia
    Dim objAgencia As New DAOAgencia
    Public Function listadoAgencias() As DataSet
        Return objAgencia.listadoAgencias
    End Function

    Public Function nuevoCodigo() As String
        Return objAgencia.nuevoCodigo
    End Function
    Public Sub nuevaAgencia(ByVal objAge As CEAgencia)
        objAgencia.nuevaAgencia(objAge)
    End Sub


End Class
